Imports System.Data.SqlClient
Imports System.Data

'Prima forma momentan, tabela Elevi
Public Class FormElevi

    'instantiam Clasa Connection
    Dim conn As New Connection

    'instantioa clasa Elevi
    Dim elev As New Elevi

    Dim connestionString = conn.OpenDB()
    Dim query As String

#Region "Check Connection Database"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If connestionString Then
            Label1.Text = "Connected"
            Label1.ForeColor = Color.Green
        End If

    End Sub
    'am verificat daca s-a conectat cu succes la baza de date
#End Region

#Region "Disconected Database"
    Private Sub btn_Close_DB_Click(sender As Object, e As EventArgs) Handles btn_Close_DB.Click

        If connestionString Then
            Label1.Text = "Disconected"
            Label1.ForeColor = Color.Red
        End If
    End Sub

#End Region

#Region "Btn Insert"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        InsertRecord()
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
        If txt_CautaElevi.TextLength = 0 Then
            MsgBox("Please fill text box search")
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
        If txt_Nume.TextLength = 0 Or txt_Prenume.TextLength = 0 Or txtEmail.Text.Length = 0 Or txtAdresa.Text.Length = 0 Then

            MsgBox("Please fill in all the fields")

        Else

            'query = "insert into Elevi(nume,prenume,email,adresa) values ('" & txt_Nume.Text & "', '" & txt_Prenume.Text & "', '" & txtEmail.Text & "', '" & txtAdresa.Text & "')"
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
                MsgBox("Record inserted")

            End If
            'clear text box after inserted record
            clear_Text_Box()
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

            MsgBox("Please fill in all the fields FOR INSERTED")

        Else

            'query = "insert into Elevi(nume,prenume,email,adresa) values ('" & txt_Nume.Text & "', '" & txt_Prenume.Text & "', '" & txtEmail.Text & "', '" & txtAdresa.Text & "')"
            query = "Update Elevi set nume=@nume, prenume=@prenume, email=@email, adresa=@adresa where idElevi=@idElevi"
            'la fel ca la inserare am adaugar si la editare cu parametri.

            conn.AddParam("@nume", elev.Nume)
            conn.AddParam("@prenume", elev.Prenume)
            conn.AddParam("@email", elev.Email)
            conn.AddParam("@adresa", elev.Adresa)
            conn.AddParam("@idElevi", elev.idElevi)

            If conn.ExecuteMySql(query) Then
                MsgBox("Record updated")

            End If
            'clear text box after inserted record
            clear_Text_Box()
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

            MsgBox("Please fill in all the fields FOR INSERTED")

        Else

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
                MsgBox("Record deleted!")

            End If
            'clear text box after inserted record
            clear_Text_Box()
        End If
    End Sub

#End Region

#Region "Get all students"
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        'SQL QUERY FROM DATA TO DATABASE
        query = "select * from Elevi"
        Dim tempDT As New DataTable
        tempDT = conn.GenerateResultSet(query)
        If (tempDT Is Nothing) Then
            MsgBox("No record")
        Else
            dgv_Elevi.DataSource = tempDT

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

End Class

