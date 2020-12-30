Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data
Public Class NoteEleviUserControl1

    Dim conn As New Connection

    'instantiam clasa Elevi
    Dim elev As New Elevi
    'instantiam clasa Materii
    Dim materie As New Materii

    Dim noteprimite As New NotePrimite
    Dim tempDT As New DataTable
    Dim connestionString = conn.OpenDB()
    Dim query As String
    Dim dialog As DialogResult

#Region "Close UserControl"
    Private Sub Btn_Inchidere_Click(sender As Object, e As EventArgs) Handles Btn_Inchidere.Click
        Panel1.Controls.Clear()
    End Sub

#End Region

#Region "Elevi ComboBox"
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint



    End Sub

#End Region

#Region "Adauga Nota"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Getting data from UI
        'am atribuit proprietatilor din clasa Elev , pentru fiecare entitate, textboxul corespunzator


        'noteprimite.idElevi = cmb_Elevi.Text

        Dim ide As New Integer
        If (Int32.TryParse(cmb_Elevi.Text, ide)) Then
            noteprimite.idElevi = ide
        End If

        'noteprimite.idMaterii = cmb_Materii.Text
        Dim idm As New Integer
        If (Int32.TryParse(cmb_Materii.Text, idm)) Then
            noteprimite.idMaterii = idm
        End If

        Dim notAA As New Decimal
        If (Decimal.TryParse(txtNota.Text, notAA)) Then
            noteprimite.nota = notAA
        End If
        'noteprimite.nota = txtNota.Text


        'am creat o validare
        If cmb_Elevi.SelectedItem Is Nothing Or cmb_Materii.SelectedItem Is Nothing Or txtNota.Text.Length = 0 Then

            MessageBox.Show("Te rog, selecteaza id-ul corespunzator elevului si materiei iar apoi sa introduceti nota ! Apoi puteti observa modificarile facute", "Informatii", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            dialog = MessageBox.Show("Sigur doriti sa adaugati aceasta inregistrare? Verificati inca odata datele pe care le-ati introdus", "Informatii", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)


            If dialog = DialogResult.Yes Then
                'query = "insert into Elevi(nume,prenume,email,adresa) values ('" & txt_Nume.Text & "', '" & txt_Prenume.Text & "', '" & txtEmail.Text & "', '" & txtAdresa.Text & "')"
                query = "insert into Note_Primite(idElevi,idMaterii,nota) values ( @idElevi, @idMaterii, @nota )"

                conn.AddParam("@idElevi", noteprimite.idElevi)
                conn.AddParam("@idMaterii", noteprimite.idMaterii)
                conn.AddParam("@nota", noteprimite.nota)

                'Daca query-ul a fost creat cu suces, se afiseaza un mesaj, Aceasta functie din clasa
                'Connection.vb este de tipul boolean, returneaza true or false
                If conn.ExecuteMySql(query) Then
                    MessageBox.Show("Nota pentru acest elev, la aceasta materie a fost adaugata cu succes!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
                'clear text box after inserted record
                'clear_Text_Box()
            End If
        End If
    End Sub
#End Region

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'preluam informatiile corespunzatoare tabelelor din baza de date 
        'si apoi populam cele 2 combobox-uri doar cu id-ul corespunzator inregistrarilor
        ' pe baza lor se pot face adaugari
        Dim query As String = "Select idElevi, nume, prenume, email, adresa from Elevi"
        Dim query1 As String = "Select idMaterii, materie, idAnStudiu  from Materii"
        Dim connection As New SqlConnection("Server = DESKTOP-KB381VD\SQLEXPRESS; Database= GestiuneElevi; Integrated Security = TRUE")
        Dim adapter As New SqlDataAdapter(query, connection)
        Dim adapter1 As New SqlDataAdapter(query1, connection)
        Dim table As New DataTable
        Dim table1 As New DataTable

        adapter.Fill(table)
        adapter1.Fill(table1)

        cmb_Elevi.DataSource = table
        cmb_Materii.DataSource = table1

        cmb_Elevi.ValueMember = "idElevi"
        cmb_Elevi.DisplayMember = "idElevi"
        'cmb_Elevi.DisplayMember = "Nume"
        'cmb_Elevi.DisplayMember = "Prenume"

        cmb_Materii.ValueMember = "idMaterii"
        'cmb_Materii.DisplayMember = "materie"
        cmb_Materii.DisplayMember = "idMaterie"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If connestionString Then
            'SQL QUERY FROM DATA TO DATABASE
            query = "select distinct e.nume, e.prenume,  a.anul, CAST(AVG(n.nota) AS Decimal(4,2)) as 'Media finala'
                        from Elevi e, An_Studiu a, Note_Primite n, Materii m
                        where e.idElevi=n.idElevi
                        and a.idAnStudiu = m.idAnStudiu
                        and m.idMaterii = n.idMaterii
                        group by e.nume, e.prenume,  a.anul 
                        order by CAST(AVG(n.nota) AS Decimal(4,2)) DESC"

            tempDT = conn.GenerateResultSet(query)
            If (tempDT Is Nothing) Then
                MsgBox("No record")
            Else
                dgv_Note.DataSource = tempDT
            End If
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        'afiseaza informatii din tabela elevi, pentru a vedeam elevul pentru care trebuie sa adaugam o nota
        If connestionString Then
            'SQL QUERY FROM DATA TO DATABASE
            query = "select idElevi, nume , prenume
                        from Elevi"

            tempDT = conn.GenerateResultSet(query)
            If (tempDT Is Nothing) Then
                MsgBox("No record")
            Else
                dgv_Elevi.DataSource = tempDT
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        'aici afisam informatii despre materii
        'id ul materiei, materia si anul in care se studiaza
        'in mod automat dupa ce al ales Elevul pentru care trebuie sa adaugam o nota
        'si alegem materia care se studiaza in anul X putem observa in ce an se afla si acel elev
        ' de exemplu daca introduc elevul X care invata la materia Y din anul Z- atunci elevul X este in anul Z
        If connestionString Then
            'SQL QUERY FROM DATA TO DATABASE
            query = "select distinct m.idMaterii, m.materie , a.anul
                        from Elevi e, An_Studiu a, Note_Primite n, Materii m
                        where e.idElevi=n.idElevi
                        and a.idAnStudiu = m.idAnStudiu
                        and m.idMaterii = n.idMaterii"

            tempDT = conn.GenerateResultSet(query)
            If (tempDT Is Nothing) Then
                MsgBox("No record")
            Else
                dgv_Meterii.DataSource = tempDT
            End If
        End If
    End Sub


End Class
