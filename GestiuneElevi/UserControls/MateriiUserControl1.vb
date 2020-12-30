Imports System.Windows.Forms
Public Class MateriiUserControl1

    'instantiam Clasa Connection
    Dim conn As New Connection

    'instantioa clasa Elevi
    Dim materie As New Materii

    Dim connestionString = conn.OpenDB()
    Dim query As String

    'AVERTISMENT YES/nO DACA DORIM SA STERGEM CU ADEVARAT O INREGISTRARE SAU NU
    'Pentru a evita orice neatentie
    Dim dialog As DialogResult

#Region "Apelare functie Adauga materiile"
    Private Sub btnAddMaterie_Click(sender As Object, e As EventArgs) Handles btnAddMaterie.Click
        InsertRecord()
    End Sub
#End Region

#Region "Functia de a adauga o materie"
    Public Sub InsertRecord()
        'Getting data from UI
        'am atribuit proprietatilor din clasa Materii , pentru fiecare entitate, textboxul corespunzator
        materie.Materii = txt_NumeMaterie.Text

        Dim idAn As New Integer
        If (Int32.TryParse(cmbBox_idAn.Text, idAn)) Then
            materie.idAnStudiu = idAn
        End If

        'am creat o validare
        If txt_NumeMaterie.TextLength = 0 Or cmbBox_idAn.SelectedItem = 0 Then

            MessageBox.Show("Pentru a putea adauga o noua inregistrare, trebuie sa completati campurile corespunzatoare!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            dialog = MessageBox.Show("Sigur doriti sa adaugati aceasta inregistrare? Verificati inca odata datele pe care le-ati introdus", "Informatii", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)


            If dialog = DialogResult.Yes Then

                'query = "insert into Elevi(nume,prenume,email,adresa) values ('" & txt_Nume.Text & "', '" & txt_Prenume.Text & "', '" & txtEmail.Text & "', '" & txtAdresa.Text & "')"
                query = "insert into Materii(materie, idAnStudiu) values (@materie, @idAnStudiu)"
                'acesta este un wuery folosind parametri, 
                'cmd addParam este o functie in clasa Connection

                '@nume, camptul din baza de date,  elev.nume proprietatea din clasa Elevi atribuita mai sus textboxurilor
                conn.AddParam("@materie", materie.Materii)
                conn.AddParam("@idAnStudiu", materie.idAnStudiu)


                'Daca query-ul a fost creat cu suces, se afiseaza un mesaj, Aceasta functie din clasa
                'Connection.vb este de tipul boolean, returneaza true or false
                If conn.ExecuteMySql(query) Then
                    MessageBox.Show("Inregistrarea a fost adaugata cu succes!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
                'clear text box after inserted record
                Clear_Text_Box()
            End If
        End If
    End Sub
#End Region

#Region "Afiseaza Materiile"
    Private Sub btnAfiseazaMaterie_Click(sender As Object, e As EventArgs) Handles btnAfiseazaMaterie.Click

        If connestionString Then

            'SQL QUERY FROM DATA TO DATABASE
            query = "select * from Materii"
            Dim tempDT As New DataTable
            tempDT = conn.GenerateResultSet(query)
            If (tempDT Is Nothing) Then
                MsgBox("No record")
            Else
                dgv_Materii.DataSource = tempDT
            End If

        End If

    End Sub
#End Region

#Region "Apelare functie Actualizare materie"
    Private Sub btnActualizeazaMaterie_Click(sender As Object, e As EventArgs) Handles btnActualizeazaMaterie.Click
        UpdateRecord()
    End Sub
#End Region

#Region "Functtia de actualizare a materiei"
    Public Sub UpdateRecord()

        'Getting data from UI
        materie.Materii = txt_NumeMaterie.Text

        'Aici, ca sa pot actualiza un Elev, a trebui sa convertesc in Int 
        ' am declarat o variabila separat de tipul InTEGER,  ID,
        'SI LA conditia IF TRY PARSE, id- se refera la valaorea out, in c# se putea scire direct out int id
        Dim idMaterie As New Integer
        If (Int32.TryParse(txtIdMaterie.Text, idMaterie)) Then
            materie.idMaterii = idMaterie
        End If

        Dim idAn As New Integer
        If (Int32.TryParse(cmbBox_idAn.Text, idAn)) Then
            materie.idAnStudiu = idAn
        End If


        If txtIdMaterie.TextLength = 0 Or cmbBox_idAn.SelectedItem = 0 Or txt_NumeMaterie.TextLength = 0 Then

            MessageBox.Show("Te rog, selecteaza o inregistrare din tabela de mai jos dupa ce ai afisat informatiile despre materii! Apoi puteti actualiza inregistrarea", "Informatii", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            dialog = MessageBox.Show("Sigur doriti sa modificati aceasta inregistrare?", "Informatii", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If dialog = DialogResult.Yes Then

                'query = "insert into Elevi(nume,prenume,email,adresa) values ('" & txt_Nume.Text & "', '" & txt_Prenume.Text & "', '" & txtEmail.Text & "', '" & txtAdresa.Text & "')"
                query = "Update Materii set materie=@materie, idAnStudiu=@idAnStudiu  where idMaterii=@idMaterii"
                'la fel ca la inserare am adaugar si la editare cu parametri.

                conn.AddParam("@materie", materie.Materii)
                conn.AddParam("@idMaterii", materie.idMaterii)
                conn.AddParam("@idAnStudiu", materie.idAnStudiu)

                If conn.ExecuteMySql(query) Then
                    MessageBox.Show("Inregistrarea a fost actualizata cu succes", "Informatii", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
                'clear text box after inserted record
                Clear_Text_Box()
            End If
            End If
    End Sub
#End Region

#Region "Apelare functie stergere materie"
    Private Sub btnStergeInformatii_Click(sender As Object, e As EventArgs) Handles btnStergeInformatii.Click
        DeleteRecord()
    End Sub
#End Region

#Region "Delete record Function"
    Public Sub DeleteRecord()

        'Getting data from UI
        materie.Materii = txt_NumeMaterie.Text

        'Aici, ca sa pot actualiza un Elev, a trebui sa convertesc in Int 
        ' am declarat o variabila separat de tipul InTEGER,  ID,
        'SI LA conditia IF TRY PARSE, id- se refera la valaorea out, in c# se putea scire direct out int id
        Dim idMaterie As New Integer
        If (Int32.TryParse(txtIdMaterie.Text, idMaterie)) Then
            materie.idMaterii = idMaterie
        End If

        Dim idAn As New Integer
        If (Int32.TryParse(cmbBox_idAn.Text, idAn)) Then
            materie.idAnStudiu = idAn
        End If


        If cmbBox_idAn.SelectedItem = 0 Or txtIdMaterie.TextLength = 0 Or txt_NumeMaterie.TextLength = 0 Then

            MessageBox.Show("Te rog, selecteaza o inregistrare din tabela de mai jos dupa ce ai afisat informatiile despre materii! Apoi puteti actualiza inregistrarea", "Informatii", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            dialog = MessageBox.Show("Sigur doriti sa stergeti aceasta inregistrare?", "Informatii", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If dialog = DialogResult.Yes Then
                query = "Delete from Materii where idMaterii=@idMaterii"
                conn.AddParam("@idMaterii", materie.idMaterii)

                'in Design nu am afisat txtboxul id, este invizibil pus, nu avem nevoie de id ,
                'ar trebui cumva scos si din datagriview sau sa o fac invizibila coloana idElevi.

                If conn.ExecuteMySql(query) Then
                    MessageBox.Show("Inregistrarea a fost stearsa cu succes", "Informatii", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
                'clear text box after inserted record
                Clear_Text_Box()
            End If
        End If
    End Sub

#End Region

#Region "Clear text box"
    Public Sub Clear_Text_Box()
        txtIdMaterie.Text = ""
        cmbBox_idAn.Text = ""
        txt_NumeMaterie.Text = ""
    End Sub
#End Region

#Region "Apelare functie Cautare"
    Private Sub btnCautaMaterii_Click(sender As Object, e As EventArgs) Handles btnCautaMaterii.Click
        If txt_CautaMaterii.TextLength = 0 Then
            txt_CautaMaterii.Focus()
            ErrorProvider1.SetError(txt_CautaMaterii, txt_CautaMaterii.Tag)

        Else
            ErrorProvider1.Clear()
            Search()
        End If
    End Sub
#End Region

#Region "Functia de cautare a unei materii disponibile"
    Public Sub Search()

        Dim keywords As String
        keywords = txt_CautaMaterii.Text

        'SQL QUERY FROM DATA TO DATABASE
        query = "select * from Materii where materie like  '%" + keywords + "%'"

        Dim tempDT As New DataTable
        tempDT = conn.GenerateResultSet(query)
        If (tempDT Is Nothing) Then
            MsgBox("No record")
        Else
            dgv_Materii.DataSource = tempDT

        End If

    End Sub
#End Region

#Region "Close MateriiUserControl"
    Private Sub Btn_Inchidere_Click(sender As Object, e As EventArgs) Handles Btn_Inchidere.Click
        Content.Controls.Clear()
    End Sub
#End Region

#Region "Auto-completare selectare prima celula"
    Private Sub dgv_Materii_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Materii.CellContentClick

        Dim rowIndex As New Integer
        rowIndex = e.RowIndex

        txtIdMaterie.Text = dgv_Materii.Rows(rowIndex).Cells(0).Value.ToString()
        txt_NumeMaterie.Text = dgv_Materii.Rows(rowIndex).Cells(1).Value.ToString()
        cmbBox_idAn.Text = dgv_Materii.Rows(rowIndex).Cells(2).Value.ToString()


    End Sub
#End Region

#Region "Auto-completare textbox apasad pe inregistrare"
    Private Sub dgv_Materii_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_Materii.RowHeaderMouseClick
        Dim rowIndex As New Integer
        rowIndex = e.RowIndex

        txtIdMaterie.Text = dgv_Materii.Rows(rowIndex).Cells(0).Value.ToString()
        txt_NumeMaterie.Text = dgv_Materii.Rows(rowIndex).Cells(1).Value.ToString()
        cmbBox_idAn.Text = dgv_Materii.Rows(rowIndex).Cells(2).Value.ToString()
    End Sub
#End Region

End Class
