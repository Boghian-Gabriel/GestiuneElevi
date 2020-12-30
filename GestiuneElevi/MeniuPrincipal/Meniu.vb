Imports System.Windows.Forms
Imports System.Runtime.InteropServices 'pentru a misca fereastra

Public Class Meniu

#Region "Open form Elevi"
    Private Sub btn_Elevi_Click(sender As Object, e As EventArgs) Handles btn_Elevi.Click

        'View form Elevi
        'Dim frmElevi As New FormElevi
        'frmElevi.ShowDialog()

        'Add UserControl Elevi
        Dim eleviControl As New EleviUserControl1
        showUserControl(eleviControl)


    End Sub
#End Region

#Region "Afisare User Control"
    Public Sub showUserControl(control As Control)

        'La inceput sa elimine tot ce se afla in content
        'Content este practic panelul unde sa se afiseze UserControls

        Content.Controls.Clear()

        control.Dock = DockStyle.Fill
        control.BringToFront()
        control.Focus()

        Content.Controls.Add(control)

    End Sub
#End Region

#Region "Open Form Materii"
    Private Sub btn_Materii_Click(sender As Object, e As EventArgs) Handles btn_Materii.Click

        Dim materiiControl As New MateriiUserControl1
        showUserControl(materiiControl)

    End Sub
#End Region

#Region "Open form Anul de Studiu"
    Private Sub btn_AnStudiu_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

#Region "Open form Evidenta Notelor Elevilor"
    Private Sub btn_NoteElevi_Click(sender As Object, e As EventArgs) Handles btn_NoteElevi.Click
        Dim noteeleviUC As New NoteEleviUserControl1
        showUserControl(noteeleviUC)
    End Sub
#End Region

#Region "Open Rapoarte USER control"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cryUC As New CrystalReportUserControl1
        showUserControl(cryUC)
    End Sub
#End Region

#Region "Btn Exit"
    Private Sub Btn_Inchidere_Click(sender As Object, e As EventArgs) Handles Btn_Inchidere.Click
        Application.Exit()
    End Sub
#End Region

#Region "Minimizare aplicatie"
    Private Sub btnMinimizare_Click(sender As Object, e As EventArgs) Handles btnMinimizare.Click
        WindowState = FormWindowState.Minimized
    End Sub
#End Region

#Region "Mazximizare fereastra"
    Private Sub BtnMaximizare_Click_1(sender As Object, e As EventArgs) Handles BtnMaximizare.Click
        WindowState = FormWindowState.Maximized
        BtnMaximizare.Visible = False
        btnRestabilire.Visible = True
    End Sub
#End Region

#Region "Restabilire fereastra"
    Private Sub btnRestabilire_Click(sender As Object, e As EventArgs) Handles btnRestabilire.Click
        WindowState = FormWindowState.Normal
        btnRestabilire.Visible = False
        BtnMaximizare.Visible = True
    End Sub
#End Region

#Region "Facebook"
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Process.Start("https://www.facebook.com/BMarius.Gabriel/")
    End Sub
#End Region

#Region "GitHub"
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Process.Start("https://github.com/Boghian-Gabriel?tab=repositories")
    End Sub
#End Region

#Region "LinkedIN"
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        Process.Start("https://www.linkedin.com/in/boghiangabriel/")
    End Sub
#End Region

#Region "Diverse informatii"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim aiUS As New AfisareInformatiiUserControl1
        showUserControl(aiUS)
    End Sub
#End Region

#Region "Move Window"
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Bara_Titlu_MouseDown(sender As Object, e As MouseEventArgs) Handles Bara_Titlu.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Bara_Titlu_MouseMove(sender As Object, e As MouseEventArgs) Handles Bara_Titlu.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Bara_Titlu_MouseUp(sender As Object, e As MouseEventArgs) Handles Bara_Titlu.MouseUp
        drag = False

    End Sub




#End Region

End Class