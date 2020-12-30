<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NoteEleviUserControl1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NoteEleviUserControl1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Inchidere = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_Elevi = New System.Windows.Forms.ComboBox()
        Me.cmb_Materii = New System.Windows.Forms.ComboBox()
        Me.txtNota = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgv_Meterii = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgv_Elevi = New System.Windows.Forms.DataGridView()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dgv_Note = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Btn_Inchidere, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_Meterii, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Elevi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Note, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(172, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(503, 32)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Evidenta Notelor Pentru fiecare elev in parte"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Btn_Inchidere
        '
        Me.Btn_Inchidere.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Btn_Inchidere.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Inchidere.Image = CType(resources.GetObject("Btn_Inchidere.Image"), System.Drawing.Image)
        Me.Btn_Inchidere.Location = New System.Drawing.Point(1484, 3)
        Me.Btn_Inchidere.Name = "Btn_Inchidere"
        Me.Btn_Inchidere.Size = New System.Drawing.Size(25, 25)
        Me.Btn_Inchidere.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Inchidere.TabIndex = 45
        Me.Btn_Inchidere.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 28)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Selecteaza elevul"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 28)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Selecteaza Materia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 28)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Introdu nota "
        '
        'cmb_Elevi
        '
        Me.cmb_Elevi.FormattingEnabled = True
        Me.cmb_Elevi.Location = New System.Drawing.Point(253, 113)
        Me.cmb_Elevi.Name = "cmb_Elevi"
        Me.cmb_Elevi.Size = New System.Drawing.Size(177, 25)
        Me.cmb_Elevi.TabIndex = 49
        '
        'cmb_Materii
        '
        Me.cmb_Materii.FormattingEnabled = True
        Me.cmb_Materii.Location = New System.Drawing.Point(253, 159)
        Me.cmb_Materii.Name = "cmb_Materii"
        Me.cmb_Materii.Size = New System.Drawing.Size(177, 25)
        Me.cmb_Materii.TabIndex = 50
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(253, 203)
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(177, 25)
        Me.txtNota.TabIndex = 51
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(50, 245)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(252, 60)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "Adauga nota"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgv_Meterii)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.dgv_Elevi)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.dgv_Note)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.txtNota)
        Me.Panel1.Controls.Add(Me.cmb_Materii)
        Me.Panel1.Controls.Add(Me.cmb_Elevi)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Btn_Inchidere)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1512, 705)
        Me.Panel1.TabIndex = 36
        '
        'dgv_Meterii
        '
        Me.dgv_Meterii.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgv_Meterii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Meterii.Location = New System.Drawing.Point(817, 516)
        Me.dgv_Meterii.Name = "dgv_Meterii"
        Me.dgv_Meterii.RowHeadersWidth = 51
        Me.dgv_Meterii.RowTemplate.Height = 24
        Me.dgv_Meterii.Size = New System.Drawing.Size(680, 176)
        Me.dgv_Meterii.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(814, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(259, 19)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Vor fi incarcate informatiile despre elevi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(814, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(616, 114)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = resources.GetString("Label6.Text")
        '
        'dgv_Elevi
        '
        Me.dgv_Elevi.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgv_Elevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Elevi.Location = New System.Drawing.Point(817, 107)
        Me.dgv_Elevi.Name = "dgv_Elevi"
        Me.dgv_Elevi.RowHeadersWidth = 51
        Me.dgv_Elevi.RowTemplate.Height = 24
        Me.dgv_Elevi.Size = New System.Drawing.Size(680, 234)
        Me.dgv_Elevi.TabIndex = 59
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(817, 466)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(289, 44)
        Me.Button5.TabIndex = 57
        Me.Button5.Text = "Afiseaza idMaterii si materiile"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(817, 54)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(289, 47)
        Me.Button4.TabIndex = 56
        Me.Button4.Text = "Afiseaza idElev si Elevii"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(465, 245)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(301, 60)
        Me.Button3.TabIndex = 55
        Me.Button3.Text = "Afiseaza toti elevii in functie de mediile obtinute"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dgv_Note
        '
        Me.dgv_Note.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgv_Note.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Note.Location = New System.Drawing.Point(50, 331)
        Me.dgv_Note.Name = "dgv_Note"
        Me.dgv_Note.RowHeadersWidth = 51
        Me.dgv_Note.RowTemplate.Height = 24
        Me.dgv_Note.Size = New System.Drawing.Size(716, 359)
        Me.dgv_Note.TabIndex = 54
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(465, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(301, 60)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Incarca elevii si materiile din baza de date"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NoteEleviUserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "NoteEleviUserControl1"
        Me.Size = New System.Drawing.Size(1512, 705)
        CType(Me.Btn_Inchidere, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_Meterii, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Elevi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Note, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Private WithEvents Btn_Inchidere As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_Elevi As ComboBox
    Friend WithEvents cmb_Materii As ComboBox
    Friend WithEvents txtNota As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents dgv_Note As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents dgv_Meterii As DataGridView
    Friend WithEvents dgv_Elevi As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
