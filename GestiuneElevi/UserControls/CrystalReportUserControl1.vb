Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class CrystalReportUserControl1

    'instantiam Clasa Connection
    Dim conn As New Connection

    Dim connestionString = conn.OpenDB()
    Dim query As String

    Dim reportElevi As New CrystalReportElevi
    Dim reportEleviMedii As New CrystalReportEleviMedii
    Dim reportMaterii As New CrystalReportViewMaterii
    Dim reportMateriaAnul As New CrystalReportMateriaAnul
    Dim reportEleviNotePrimite As New CrystalReportEleviNotePrimite

    Dim cryRpt As New ReportDocument

#Region "Close UserControlCrystalReport"
    Private Sub Btn_Inchidere_Click(sender As Object, e As EventArgs) Handles Btn_Inchidere.Click
        Panel1.Controls.Clear()
    End Sub
#End Region

#Region "Vizualizeaza toti elevii "
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        If connestionString Then
            'SQL QUERY FROM DATA TO DATABASE
            query = "select nume, prenume, email, adresa from Elevi"
            Dim tempDS As New DataSet
            'Numele tabelei este din GestiuneEleviDataSet.xsd, ce am prezentat mai devreme 
            Dim tableName As String = "Elevi"
            tempDS = conn.CrystalReportGenerateResultSet(query, tableName)
            If (tempDS Is Nothing) Then
                MsgBox("Din pacate, nu exista inregistrari!")
            Else
                'se creaza si populeaza cu informatiile corespunzatoare raportul
                reportElevi.SetDataSource(tempDS)
                CrystalReportViewer1.ReportSource = reportElevi
                CrystalReportViewer1.Refresh()

            End If
        End If


        'se populeaza doar daca folosesc DataSource, nu data table

        'Dim strConnection As New SqlConnection("Server = DESKTOP-KB381VD\SQLEXPRESS; Database= GestiuneElevi; Integrated Security = TRUE")
        'If strConnection.State = ConnectionState.Closed Then
        '    strConnection.Open()
        'End If
        'Dim dt As New DataTable
        'Dim cmd As New SqlCommand("select nume, prenume, email, adresa from Elevi", strConnection)
        'Dim sda As New SqlDataAdapter(cmd)
        'sda.Fill(dt)
        'strConnection.Close()

        'report.SetDataSource(dt)
        'CrystalReportViewer1.ReportSource = report
        'CrystalReportViewer1.Refresh()
        'report.Close()
        'report.Dispose()

    End Sub
#End Region

#Region "Vizualizeaza toti elevii in functie de medie"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If connestionString Then
            'SQL QUERY FROM DATA TO DATABASE
            'as fi vrut ca sa apara si in crystal report media finala fiecarui student care are note la toate materiile
            'FOLOSING ACEST QUERY

            query = "SELECT Elevi.nume, Elevi.prenume, An_Studiu.anul, AVG(Note_Primite.nota) 
                      FROM     An_Studiu INNER JOIN
                      Materii ON An_Studiu.idAnStudiu = Materii.idAnStudiu INNER JOIN
                      Note_Primite ON Materii.idMaterii = Note_Primite.idMaterii INNER JOIN
                      Elevi ON Note_Primite.idElevi = Elevi.idElevi
                      group by Elevi.nume, Elevi.prenume,  An_Studiu.anul 
                      ORDER BY AVG(Note_Primite.nota)desc"


            Dim tempDS As New DataSet
            Dim tableName As String = "EleviMedii"
            tempDS = conn.CrystalReportGenerateResultSet(query, tableName)
            If (tempDS Is Nothing) Then
                MsgBox("No record")
            Else
                reportEleviMedii.SetDataSource(tempDS)
                CrystalReportViewer1.ReportSource = reportEleviMedii
                CrystalReportViewer1.Refresh()

            End If
        End If
        ' commnet multiple line ctrl+k ->  ctrl+c, 

    End Sub
#End Region

#Region "Curata crystal report daca exista ceva inainte ca sa poate genera unul nou"
    Private Sub CleanOutViewer()
        If Not Me.CrystalReportViewer1.ReportSource() Is Nothing Then
            CType(Me.CrystalReportViewer1.ReportSource(), CrystalDecisions.CrystalReports.Engine.ReportDocument).Close()
            CType(Me.CrystalReportViewer1.ReportSource(), CrystalDecisions.CrystalReports.Engine.ReportDocument).Dispose()
            Me.CrystalReportViewer1.ReportSource() = Nothing
        End If
    End Sub
#End Region

#Region "Afiseaza toate materiile"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If connestionString Then
            'SQL QUERY FROM DATA TO DATABASE
            query = "select idMaterii, materie  from Materii"
            Dim tempDS As New DataSet
            Dim tableName As String = "Materii"
            tempDS = conn.CrystalReportGenerateResultSet(query, tableName)
            If (tempDS Is Nothing) Then
                MsgBox("No record")
            Else
                reportMaterii.SetDataSource(tempDS)
                CrystalReportViewer1.ReportSource = reportMaterii
                CrystalReportViewer1.Refresh()

            End If
        End If
    End Sub
#End Region

#Region "Vizualizeaza toate materiile si anul din care face parte fiecare"
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        'CleanOutViewer()
        'cryRpt.Load("D:\Proiect VB.NET\GestiuneElevi\GestiuneElevi\CrystalReport\CrystalReportMateriaAnul.rpt")
        'CrystalReportViewer1.ReportSource = cryRpt
        'CrystalReportViewer1.Refresh()

        'am creat o alta tabela in GestiuneEleviDataSet.xsd cu cele 2 coloane  Numele materiei si anul
        'am creat o interogare in Microsoft SQL Server
        ' dupa exemplul de aici 
        ' https://www.youtube.com/watch?v=7qK20wS0_KA&t=567s
        'si interogarea am introdus si ca query in variabila query
        If connestionString Then
            'SQL QUERY FROM DATA TO DATABASE
            query = "SELECT Materii.materie, An_Studiu.anul
                        FROM An_Studiu INNER JOIN
                        Materii ON An_Studiu.idAnStudiu = Materii.idAnStudiu"
            'atunci cand creezi un query cu ajutorul diagramei, adica selectezi ce coloane doresti sa se afiseze, pui alis etc
            ' formatul til da in felul urmator cu  JOIN (cum e mai sus )
            'daca pun sub forma de jonctiune cum e mai jos, da acelasi rezultat

            'select m.materie  , a.anul   
            'From Materii m, An_Studiu a
            'Where a.idAnStudiu = m.idAnStudiu
            '
            Dim tempDS As New DataSet
            Dim tableName As String = "MateriaAnul"
            'in variabial temporara DataSet = tempDS am apelat metoda  respectiva din clasa Connection
            'iar in variabile tableName am introdus numele tabelei create (dupa cum am specificat mai sus)
            tempDS = conn.CrystalReportGenerateResultSet(query, tableName)
            'in cazul in care nu exista irnegistrari intr o interogare apare mesajul respectiv
            If (tempDS Is Nothing) Then
                MsgBox("Din pacate, nu exista inregistrari!")
            Else
                'daca exista, am creat o instanta a clase CrystalReportMateriaAnul
                'si apoi creez un raport cu datele din tabela respectiva
                reportMateriaAnul.SetDataSource(tempDS)
                CrystalReportViewer1.ReportSource = reportMateriaAnul
                CrystalReportViewer1.Refresh()

            End If
        End If

    End Sub
#End Region

#Region "Vizualizeaza toate notele pt fiecare elev si materie in parte"
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        query = "SELECT Elevi.nume, Elevi.prenume, An_Studiu.anul, Materii.materie, Note_Primite.nota 
                      FROM     An_Studiu INNER JOIN
                      Materii ON An_Studiu.idAnStudiu = Materii.idAnStudiu INNER JOIN
                      Note_Primite ON Materii.idMaterii = Note_Primite.idMaterii INNER JOIN
                      Elevi ON Note_Primite.idElevi = Elevi.idElevi    
                      order by An_Studiu.anul asc
                      "

        Dim tempDS As New DataSet
        Dim tableName As String = "EleviNotePrimite"
        tempDS = conn.CrystalReportGenerateResultSet(query, tableName)
        If (tempDS Is Nothing) Then
            MsgBox("No record")
        Else
            reportEleviNotePrimite.SetDataSource(tempDS)
            CrystalReportViewer1.ReportSource = reportEleviNotePrimite
            CrystalReportViewer1.Refresh()

        End If

    End Sub
#End Region
End Class
