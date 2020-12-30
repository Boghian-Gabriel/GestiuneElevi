Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class AfisareInformatiiUserControl1

    'instantiam Clasa Connection
    Dim conn As New Connection
    Dim connestionString = conn.OpenDB()
    Dim query As String
    Dim tempDT As New DataTable

#Region "Close UserControl"
    Private Sub Btn_Inchidere_Click(sender As Object, e As EventArgs) Handles Btn_Inchidere.Click
        Panel1.Controls.Clear()
    End Sub
#End Region

#Region "Informatii 1"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If connestionString Then
            'SQL QUERY FROM DATA TO DATABASE
            query = "select distinct e.nume as 'Nume', e.prenume as 'Prenume',  a.anul as 'Anul', CAST(AVG(n.nota) AS Decimal(4,2)) as 'Media finala'
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
                DataGridView1.DataSource = tempDT
            End If
        End If
    End Sub
#End Region

#Region "Informatii 2"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If connestionString Then
            'SQL QUERY FROM DATA TO DATABASE
            query = "select m.materie as 'Materia', a.anul as 'Anul'
                    from Materii m inner join An_Studiu a on a.idAnStudiu = m.idAnStudiu"

            tempDT = conn.GenerateResultSet(query)
            If (tempDT Is Nothing) Then
                MsgBox("No record")
            Else
                DataGridView1.DataSource = tempDT
            End If
        End If
    End Sub
#End Region

#Region "Informatii 3"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtNume.TextLength = 0 Or txtPrenume.TextLength = 0 Then
            MessageBox.Show("Te rog, completeaza mai intai campurile 'Nume' si 'Prenume', iar apoi puteti afla informatiile necesare!", "Informatii", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Search()
        End If
    End Sub
#End Region

#Region "Search Students"
    Public Sub Search()

        Dim keywordsNume, keywordsPrenume As String
        keywordsNume = txtNume.Text
        keywordsPrenume = txtPrenume.Text

        'SQL QUERY FROM DATA TO DATABASE
        query = "select Distinct e.nume, e.prenume , m.materie, a.anul, n.nota
                    from Elevi e, Materii m , An_Studiu a, Note_Primite n
                    where e.idElevi=n.idElevi
                    and m.idAnStudiu = a.idAnStudiu
                    and m.idMaterii = n.idMaterii
                    and e.nume like '%" + keywordsNume + "%' and e.prenume like '%" + keywordsPrenume + "%'
                    order by n.nota DESC"

        Dim tempDT As New DataTable
        tempDT = conn.GenerateResultSet(query)
        If (tempDT Is Nothing) Then
            MsgBox("No record")
        Else
            DataGridView1.DataSource = tempDT

        End If

    End Sub

#End Region

#Region "Search Materie"
    Public Sub SearchMaterie()

        Dim keywordsAnul As String
        keywordsAnul = cmbAnul.SelectedItem

        'SQL QUERY FROM DATA TO DATABASE
        query = "select m.materie, a.anul
                    from Materii m, An_Studiu a
                    where a.idAnStudiu = m.idAnStudiu
                    and a.anul='" & cmbAnul.SelectedItem & "' "

        Dim tempDT As New DataTable
        tempDT = conn.GenerateResultSet(query)
        If (tempDT Is Nothing) Then
            MsgBox("No record")
        Else
            DataGridView1.DataSource = tempDT

        End If

    End Sub
#End Region

#Region "Search Toti Elevii dintr-un anumit an"
    Public Sub SearchEleviPerAn()

        Dim keywordsAnul As String
        keywordsAnul = cmbAnul.SelectedItem

        'SQL QUERY FROM DATA TO DATABASE
        query = "select distinct e.nume, e.prenume,  a.anul
                from Elevi e, An_Studiu a, Note_Primite n, Materii m
                where e.idElevi=n.idElevi
                and a.idAnStudiu = m.idAnStudiu
                and m.idMaterii = n.idMaterii
                and a.anul='" & cmbBoxAnulElevi.SelectedItem & "'
                group by e.nume, e.prenume,  a.anul
                order by a.anul "

        Dim tempDT As New DataTable
        tempDT = conn.GenerateResultSet(query)
        If (tempDT Is Nothing) Then
            MsgBox("No record")
        Else
            DataGridView1.DataSource = tempDT

        End If

    End Sub
#End Region

#Region "Informatii 4"
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '= -1 deoarece indexul 0 se refera la prima valoare din lista respectiva de ani I,II,III, IV
        'daca as pune =0 atunci cand aleg anul I imi afiseaza acest mesaj de eroare
        If cmbAnul.SelectedIndex = -1 Then
            MessageBox.Show("Te rog, alege anul din casuta din dreptul cerintei cu numarul 4, iar apoi puteti afla informatiile necesare!", "Informatii", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            SearchMaterie()
        End If
    End Sub
#End Region

#Region "Informatii 5"
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        '= -1 deoarece indexul 0 se refera la prima valoare din lista respectiva de ani I,II,III, IV
        'daca as pune =0 atunci cand aleg anul I imi afiseaza acest mesaj de eroare
        If cmbBoxAnulElevi.Text.Length = -1 Then

            MessageBox.Show("Te rog, alege anul din casuta din dreptul cerintei cu numarul 5, iar apoi puteti afla informatiile necesare!", "Informatii", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            SearchEleviPerAn()

        End If


    End Sub
#End Region

End Class
