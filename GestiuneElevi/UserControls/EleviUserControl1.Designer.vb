<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EleviUserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EleviUserControl1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Inchidere = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.groupBox_Elevi = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIdElevi = New System.Windows.Forms.TextBox()
        Me.txt_Nume = New System.Windows.Forms.TextBox()
        Me.txt_Prenume = New System.Windows.Forms.TextBox()
        Me.txtAdresa = New System.Windows.Forms.TextBox()
        Me.btnCautaElevi = New System.Windows.Forms.Button()
        Me.txt_CautaElevi = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgv_Elevi = New System.Windows.Forms.DataGridView()
        Me.Content = New System.Windows.Forms.Panel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.Btn_Inchidere, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox_Elevi.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_Elevi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Content.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(350, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 32)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Evidenta Elevilor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Btn_Inchidere
        '
        Me.Btn_Inchidere.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Btn_Inchidere.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Inchidere.Image = CType(resources.GetObject("Btn_Inchidere.Image"), System.Drawing.Image)
        Me.Btn_Inchidere.Location = New System.Drawing.Point(836, 3)
        Me.Btn_Inchidere.Name = "Btn_Inchidere"
        Me.Btn_Inchidere.Size = New System.Drawing.Size(25, 25)
        Me.Btn_Inchidere.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Inchidere.TabIndex = 28
        Me.Btn_Inchidere.TabStop = False
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(247, 292)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(166, 47)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = "Afiseaza elevii"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(618, 292)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(201, 47)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Sterge informatii"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(431, 292)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(170, 47)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Modifica"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(54, 292)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(164, 47)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Adauga elevi"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'groupBox_Elevi
        '
        Me.groupBox_Elevi.Controls.Add(Me.txtEmail)
        Me.groupBox_Elevi.Controls.Add(Me.Label2)
        Me.groupBox_Elevi.Controls.Add(Me.Label3)
        Me.groupBox_Elevi.Controls.Add(Me.Label4)
        Me.groupBox_Elevi.Controls.Add(Me.Label5)
        Me.groupBox_Elevi.Controls.Add(Me.txtIdElevi)
        Me.groupBox_Elevi.Controls.Add(Me.txt_Nume)
        Me.groupBox_Elevi.Controls.Add(Me.txt_Prenume)
        Me.groupBox_Elevi.Controls.Add(Me.txtAdresa)
        Me.groupBox_Elevi.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.groupBox_Elevi.Location = New System.Drawing.Point(54, 64)
        Me.groupBox_Elevi.Name = "groupBox_Elevi"
        Me.groupBox_Elevi.Size = New System.Drawing.Size(765, 216)
        Me.groupBox_Elevi.TabIndex = 31
        Me.groupBox_Elevi.TabStop = False
        Me.groupBox_Elevi.Text = "Campuri"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(126, 122)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(267, 22)
        Me.txtEmail.TabIndex = 8
        Me.txtEmail.Tag = "Te rog completeaza campul 'Email'"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(16, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nume"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(16, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Prenume"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(16, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Email"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(16, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 28)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Adresa"
        '
        'txtIdElevi
        '
        Me.txtIdElevi.BackColor = System.Drawing.Color.CadetBlue
        Me.txtIdElevi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdElevi.ForeColor = System.Drawing.Color.CadetBlue
        Me.txtIdElevi.Location = New System.Drawing.Point(433, 43)
        Me.txtIdElevi.Name = "txtIdElevi"
        Me.txtIdElevi.Size = New System.Drawing.Size(66, 15)
        Me.txtIdElevi.TabIndex = 17
        '
        'txt_Nume
        '
        Me.txt_Nume.Location = New System.Drawing.Point(126, 40)
        Me.txt_Nume.Multiline = True
        Me.txt_Nume.Name = "txt_Nume"
        Me.txt_Nume.Size = New System.Drawing.Size(267, 23)
        Me.txt_Nume.TabIndex = 6
        Me.txt_Nume.Tag = "Te rog completeaza campul 'Nume'"
        '
        'txt_Prenume
        '
        Me.txt_Prenume.Location = New System.Drawing.Point(126, 82)
        Me.txt_Prenume.Name = "txt_Prenume"
        Me.txt_Prenume.Size = New System.Drawing.Size(267, 22)
        Me.txt_Prenume.TabIndex = 7
        Me.txt_Prenume.Tag = "Te rog completeaza campul 'Prenume'"
        '
        'txtAdresa
        '
        Me.txtAdresa.Location = New System.Drawing.Point(126, 168)
        Me.txtAdresa.Name = "txtAdresa"
        Me.txtAdresa.Size = New System.Drawing.Size(267, 22)
        Me.txtAdresa.TabIndex = 9
        Me.txtAdresa.Tag = "Te rog completeaza campul 'Adresa'"
        '
        'btnCautaElevi
        '
        Me.btnCautaElevi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCautaElevi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.btnCautaElevi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCautaElevi.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCautaElevi.ForeColor = System.Drawing.Color.White
        Me.btnCautaElevi.Location = New System.Drawing.Point(55, 364)
        Me.btnCautaElevi.Name = "btnCautaElevi"
        Me.btnCautaElevi.Size = New System.Drawing.Size(163, 31)
        Me.btnCautaElevi.TabIndex = 30
        Me.btnCautaElevi.Text = "Cauta Elevi"
        Me.btnCautaElevi.UseVisualStyleBackColor = True
        '
        'txt_CautaElevi
        '
        Me.txt_CautaElevi.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CautaElevi.Location = New System.Drawing.Point(247, 364)
        Me.txt_CautaElevi.Multiline = True
        Me.txt_CautaElevi.Name = "txt_CautaElevi"
        Me.txt_CautaElevi.Size = New System.Drawing.Size(572, 31)
        Me.txt_CautaElevi.TabIndex = 29
        Me.txt_CautaElevi.Tag = "Te rog, introdu numele sau prenumele elevului pe care doriti sa-l cautati!"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgv_Elevi)
        Me.Panel1.Location = New System.Drawing.Point(54, 413)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(765, 238)
        Me.Panel1.TabIndex = 34
        '
        'dgv_Elevi
        '
        Me.dgv_Elevi.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgv_Elevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Elevi.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Elevi.Name = "dgv_Elevi"
        Me.dgv_Elevi.RowHeadersWidth = 51
        Me.dgv_Elevi.RowTemplate.Height = 24
        Me.dgv_Elevi.Size = New System.Drawing.Size(765, 238)
        Me.dgv_Elevi.TabIndex = 16
        '
        'Content
        '
        Me.Content.Controls.Add(Me.Label1)
        Me.Content.Controls.Add(Me.Panel1)
        Me.Content.Controls.Add(Me.txt_CautaElevi)
        Me.Content.Controls.Add(Me.btnCautaElevi)
        Me.Content.Controls.Add(Me.groupBox_Elevi)
        Me.Content.Controls.Add(Me.Button2)
        Me.Content.Controls.Add(Me.Button3)
        Me.Content.Controls.Add(Me.Button4)
        Me.Content.Controls.Add(Me.Button5)
        Me.Content.Controls.Add(Me.Btn_Inchidere)
        Me.Content.Location = New System.Drawing.Point(0, 0)
        Me.Content.Name = "Content"
        Me.Content.Size = New System.Drawing.Size(864, 655)
        Me.Content.TabIndex = 35
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'EleviUserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.Controls.Add(Me.Content)
        Me.Name = "EleviUserControl1"
        Me.Size = New System.Drawing.Size(864, 655)
        CType(Me.Btn_Inchidere, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox_Elevi.ResumeLayout(False)
        Me.groupBox_Elevi.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv_Elevi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Content.ResumeLayout(False)
        Me.Content.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Private WithEvents Btn_Inchidere As PictureBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents groupBox_Elevi As GroupBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIdElevi As TextBox
    Friend WithEvents txt_Nume As TextBox
    Friend WithEvents txt_Prenume As TextBox
    Friend WithEvents txtAdresa As TextBox
    Friend WithEvents btnCautaElevi As Button
    Friend WithEvents txt_CautaElevi As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgv_Elevi As DataGridView
    Friend WithEvents Content As Panel
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
