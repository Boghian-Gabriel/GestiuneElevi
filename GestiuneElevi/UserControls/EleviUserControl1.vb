Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports System.Text.RegularExpressions

Public Class EleviUserControl1

    'instantiam Clasa Connection
    Dim conn As New Connection

    'instantiez clasa Elevi
    Dim elev As New Elevi

    'AVERTISMENT YES/nO DACA DORIM SA STERGEM CU ADEVARAT O INREGISTRARE SAU NU
    'Pentru a evita orice neatentie
    Dim dialog As DialogResult

    'Apeleaz METODA DIN CLASA Connection
    Dim connestionString = conn.OpenDB()

    Dim query As String

    Dim val As Validare


    'obs
    'dupa ce afisam elevii trebuie sa apasam pe prima casuta din gridiew pt a putea observa toti elevii
    ' probabil nu se poate afisa din cauza a nu stiu ce.. nu mi-am dat seama
    ' dar functioneaza totul bine...

#Region "Btn Insert"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        InsertRecord()
    End Sub

#End Region

#Region "Validare E-mail format corect"
    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

        Dim validate_email As String = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$"
        elev.Email = txtEmail.Text

        If (Regex.IsMatch(txtEmail.Text, validate_email)) Then
            ErrorProvider1.Clear()
        Else
            ErrorProvider1.SetError(txtEmail, "Introduceti o adresa de e-mail valida.")

        End If

    End Sub

#End Region

#Region "Btn Update"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        UpdateRecord()
    End Sub
#End Region

#Region "Btn Delete"
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DeleteRecord()
    End Sub
#End Region

#Region "Btn Search students"
    Private Sub btnCautaElevi_Click(sender As Object, e As EventArgs) Handles btnCautaElevi.Click
        If validare(txt_CautaElevi) = False Then
            txt_CautaElevi.Focus()
            Exit Sub
        Else
            Search()
        End If

    End Sub
#End Region

#Region "Insert Record function"
    Public Sub InsertRecord()
        'Getting data from UI
        'am atribuit proprietatilor din clasa Elev , pentru fiecare entitate, textboxul corespunzator
        elev.Nume = txt_Nume.Text
        elev.Prenume = txt_Prenume.Text
        elev.Email = txtEmail.Text
        elev.Adresa = txtAdresa.Text


        'am creat o validare
        'If txt_Nume.TextLength = 0 Or txt_Prenume.TextLength = 0 Or txtEmail.Text.Length = 0 Or txtAdresa.Text.Length = 0 Then

        'MsgBox("Please fill in all the fields")
        If validare(txt_Nume, txt_Prenume, txtEmail, txtAdresa) = False Then
            Exit Sub
        Else
            'variabila dialog este egala cu variabila val care la randul ei face referire la metoda din clasa Validare
            dialog = MessageBox.Show("Sigur doriti sa adaugati aceasta inregistrare? Verificati inca odata datele pe care le-ati introdus", "Informatii", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)


            If dialog = DialogResult.Yes Then

                'query = "insert into Elevi(nume,prenume,email,adresa) values ('" & txt_Nume.Text & "', '" & txt_Prenume.Text & "', '" & txtEmail.Text & "', '" & txtAdresa.Text & "')"

                'existRegister = "Select  nume, prenume, email, adresa from Elevi where nume=@nume and prenume=@prenume and email=@email and adresa=@adresa"

                query = "insert into Elevi(nume,prenume,email,adresa) values (@nume, @prenume, @email, @adresa)"
                'acesta este un wuery folosind parametri, 
                'cmd addParam este o functie in clasa Connection

                '@nume, camptul din baza de date,  elev.nume proprietatea din clasa Elevi atribuita mai sus textboxurilor
                conn.AddParam("@nume", elev.Nume)
                conn.AddParam("@prenume", elev.Prenume)
                conn.AddParam("@email", elev.Email)
                conn.AddParam("@adresa", elev.Adresa)

                'Daca query-ul a fost creat cu suces, se afiseaza un mesaj, Aceasta functie din clasa
                'Connection.vb este de tipul boolean, returneaza true or false             
                If conn.ExecuteMySql(query) Then
                    MessageBox.Show("Inregistrarea a fost adaugata cu succes!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clear_Text_Box()

                End If
            End If
        End If
    End Sub

#End Region

#Region "Update Record Function"
    Public Sub UpdateRecord()

        'Getting data from UI
        elev.Nume = txt_Nume.Text
        elev.Prenume = txt_Prenume.Text
        elev.Email = txtEmail.Text
        elev.Adresa = txtAdresa.Text

        'Aici, ca sa pot actualiza un Elev, a trebui sa convertesc in Int 
        ' am declarat o variabila separat de tipul InTEGER,  ID,
        'SI LA conditia IF TRY PARSE, id- se refera la valaorea out, in c# se putea scire direct out int id
        Dim id As New Integer
        If (Int32.TryParse(txtIdElevi.Text, id)) Then
            elev.idElevi = id
        End If



        If txtIdElevi.TextLength = 0 Or txt_Nume.TextLength = 0 Or txt_Prenume.TextLength = 0 Or txtEmail.Text.Length = 0 Or txtAdresa.Text.Length = 0 Then

            MessageBox.Show("Te rog, selecteaza o inregistrare din tabela de mai jos dupa ce ai afisat informatiile despre elevi! Apoi puteti actualiza inregistrarea", "Informatii", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            dialog = MessageBox.Show("Sigur doriti sa modificati aceasta inregistrare?", "Informatii", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If dialog = DialogResult.Yes Then

                'query = "insert into Elevi(nume,prenume,email,adresa) values ('" & txt_Nume.Text & "', '" & txt_Prenume.Text & "', '" & txtEmail.Text & "', '" & txtAdresa.Text & "')"
                query = "Update Elevi set nume=@nume, prenume=@prenume, email=@email, adresa=@adresa where idElevi=@idElevi"
                'la fel ca la inserare am adaugar si la editare cu parametri.

                conn.AddParam("@nume", elev.Nume)
                conn.AddParam("@prenume", elev.Prenume)
                conn.AddParam("@email", elev.Email)
                conn.AddParam("@adresa", elev.Adresa)
                conn.AddParam("@idElevi", elev.idElevi)

                If conn.ExecuteMySql(query) Then
                    MessageBox.Show("Inregistrarea a fost actualizata cu succes", "Informatii", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
                'clear text box after inserted record
                clear_Text_Box()
            End If
        End If
    End Sub

#End Region

#Region "Delete record Function"
    Public Sub DeleteRecord()

        'Getting data from UI
        elev.Nume = txt_Nume.Text
        elev.Prenume = txt_Prenume.Text
        elev.Email = txtEmail.Text
        elev.Adresa = txtAdresa.Text

        Dim id As New Integer
        If (Int32.TryParse(txtIdElevi.Text, id)) Then
            elev.idElevi = id
        End If



        If txtIdElevi.TextLength = 0 Or txt_Nume.TextLength = 0 Or txt_Prenume.TextLength = 0 Or txtEmail.Text.Length = 0 Or txtAdresa.Text.Length = 0 Then
            MessageBox.Show("Te rog, selecteaza o inregistrare din tabela de mai jos dupa ce ai afisat informatiile despre elevi! Apoi puteti sterge inregistrarea", "Informatii", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            dialog = MessageBox.Show("Sigur doriti sa stergeti aceasta inregistrare?", "Informatii", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If dialog = DialogResult.Yes Then

                'query = "insert into Elevi(nume,prenume,email,adresa) values ('" & txt_Nume.Text & "', '" & txt_Prenume.Text & "', '" & txtEmail.Text & "', '" & txtAdresa.Text & "')"
                query = "Delete from Elevi where idElevi=@idElevi"


                'conn.AddParam("@nume", elev.Nume)
                'conn.AddParam("@prenume", elev.Prenume)
                ' conn.AddParam("@email", elev.Email)
                'conn.AddParam("@adresa", elev.Adresa)
                conn.AddParam("@idElevi", elev.idElevi)

                'in Design nu am afisat txtboxul id, este invizibil pus, nu avem nevoie de id ,
                'ar trebui cumva scos si din datagriview sau sa o fac invizibila coloana idElevi.

                If conn.ExecuteMySql(query) Then
                    MessageBox.Show("Inregistrarea a fost stearsa cu succes", "Informatii", MessageBoxButtons.OK, MessageBoxIcon.Information)


                End If
                'clear text box after inserted record
                clear_Text_Box()
            End If
        End If
    End Sub

#End Region

#Region "Afiseaza toti elevii"
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


        If connestionString Then
            'SQL QUERY FROM DATA TO DATABASE
            query = "select * from Elevi"
            Dim tempDT As New DataTable
            tempDT = conn.GenerateResultSet(query)
            If (tempDT Is Nothing) Then
                MsgBox("No record")
            Else
                dgv_Elevi.DataSource = tempDT
            End If
        End If


    End Sub

#End Region

#Region "Search Students"
    Public Sub Search()

        Dim keywords As String
        keywords = txt_CautaElevi.Text

        'SQL QUERY FROM DATA TO DATABASE
        query = "select * from Elevi where nume like  '%" + keywords + "%' or prenume like  '%" + keywords + "%'"

        Dim tempDT As New DataTable
        tempDT = conn.GenerateResultSet(query)
        If (tempDT Is Nothing) Then
            MsgBox("No record")
        Else
            dgv_Elevi.DataSource = tempDT

        End If

    End Sub

#End Region

#Region "Clear Text Box after inserting record"
    Private Sub clear_Text_Box()

        'Dupa fiecare actualziare sau inserare textboxurile se golesc.
        txtIdElevi.Text = ""
        txt_Nume.Text = ""
        txt_Prenume.Text = ""
        txtEmail.Text = ""
        txtAdresa.Text = ""

    End Sub

#End Region

#Region "Auto-completlly with record from dt at click cell event"
    Private Sub dgv_Elevi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Elevi.CellContentClick

        'row index se refera la coloana curenta
        Dim rowIndex As New Integer
        rowIndex = e.RowIndex

        txtIdElevi.Text = dgv_Elevi.Rows(rowIndex).Cells(0).Value.ToString()
        txt_Nume.Text = dgv_Elevi.Rows(rowIndex).Cells(1).Value.ToString()
        txt_Prenume.Text = dgv_Elevi.Rows(rowIndex).Cells(2).Value.ToString()
        txtEmail.Text = dgv_Elevi.Rows(rowIndex).Cells(3).Value.ToString()
        txtAdresa.Text = dgv_Elevi.Rows(rowIndex).Cells(4).Value.ToString()

    End Sub
    'atunci cand selectez prima celula din datagridveuw sau mai jos, headerul, partea dreapta a tabelei
    'sa se umple textboxurile pentru putea modifica. (Usureaza munca pentru a moficia un Elev)

#End Region

#Region "Auto-completlly with record from dt at click row header mouse event"
    Private Sub dgv_Elevi_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_Elevi.RowHeaderMouseClick

        Dim rowIndex As New Integer
        rowIndex = e.RowIndex

        txtIdElevi.Text = dgv_Elevi.Rows(rowIndex).Cells(0).Value.ToString()
        txt_Nume.Text = dgv_Elevi.Rows(rowIndex).Cells(1).Value.ToString()
        txt_Prenume.Text = dgv_Elevi.Rows(rowIndex).Cells(2).Value.ToString()
        txtEmail.Text = dgv_Elevi.Rows(rowIndex).Cells(3).Value.ToString()
        txtAdresa.Text = dgv_Elevi.Rows(rowIndex).Cells(4).Value.ToString()

    End Sub
#End Region

#Region "Close UserControl"
    Private Sub Btn_Inchidere_Click(sender As Object, e As EventArgs) Handles Btn_Inchidere.Click

        'Dim eleviUserControl As EleviUserControl1
        Content.Controls.Clear()


    End Sub
#End Region

#Region "Functie dinamica in care apare o eroare daca nu am completat toate campurile necesare"
    Public Function validare(ByVal ParamArray ctl() As Object) As Boolean

        'ctl este un array de textboxuri (de obiecte mai exact)
        'pt fiecare obiect i=0 pana la Ubount(ctl)= nr de obiecte
        'verifica daca campurile respective sunt nule, focuseaza pe fiecare camp care nu este completat + eroarea 
        'mesajul de eraore este scris in fereastra proprietati la Tag
        'daca se indeplinesc toate aceste condicii atunci returneaza false,
        'daca nu se indeplinesc aceste conditii si totul este OK se returneaza true
        For i As Integer = 0 To UBound(ctl)
            If ctl(i).text = "" Then
                ctl(i).Focus()
                ErrorProvider1.SetError(ctl(i), ctl(i).tag)
                Return False
            End If
        Next
        Return True
        ErrorProvider1.Clear()
    End Function

#End Region


End Class
