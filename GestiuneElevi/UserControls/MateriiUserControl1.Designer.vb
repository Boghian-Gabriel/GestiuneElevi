<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MateriiUserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MateriiUserControl1))
        Me.Content = New System.Windows.Forms.Panel()
        Me.Btn_Inchidere = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgv_Materii = New System.Windows.Forms.DataGridView()
        Me.txt_CautaMaterii = New System.Windows.Forms.TextBox()
        Me.btnCautaMaterii = New System.Windows.Forms.Button()
        Me.groupBox_Elevi = New System.Windows.Forms.GroupBox()
        Me.cmbBox_idAn = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdMaterie = New System.Windows.Forms.TextBox()
        Me.txt_NumeMaterie = New System.Windows.Forms.TextBox()
        Me.btnAddMaterie = New System.Windows.Forms.Button()
        Me.btnActualizeazaMaterie = New System.Windows.Forms.Button()
        Me.btnStergeInformatii = New System.Windows.Forms.Button()
        Me.btnAfiseazaMaterie = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Content.SuspendLayout()
        CType(Me.Btn_Inchidere, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_Materii, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox_Elevi.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Content
        '
        Me.Content.BackColor = System.Drawing.Color.CadetBlue
        Me.Content.Controls.Add(Me.Btn_Inchidere)
        Me.Content.Controls.Add(Me.Panel1)
        Me.Content.Controls.Add(Me.txt_CautaMaterii)
        Me.Content.Controls.Add(Me.btnCautaMaterii)
        Me.Content.Controls.Add(Me.groupBox_Elevi)
        Me.Content.Controls.Add(Me.btnAddMaterie)
        Me.Content.Controls.Add(Me.btnActualizeazaMaterie)
        Me.Content.Controls.Add(Me.btnStergeInformatii)
        Me.Content.Controls.Add(Me.btnAfiseazaMaterie)
        Me.Content.Controls.Add(Me.Label1)
        Me.Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Content.Location = New System.Drawing.Point(0, 0)
        Me.Content.Name = "Content"
        Me.Content.Size = New System.Drawing.Size(864, 731)
        Me.Content.TabIndex = 0
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
        Me.Btn_Inchidere.TabIndex = 44
        Me.Btn_Inchidere.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgv_Materii)
        Me.Panel1.Location = New System.Drawing.Point(50, 333)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(765, 383)
        Me.Panel1.TabIndex = 43
        '
        'dgv_Materii
        '
        Me.dgv_Materii.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgv_Materii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Materii.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Materii.Name = "dgv_Materii"
        Me.dgv_Materii.RowHeadersWidth = 51
        Me.dgv_Materii.RowTemplate.Height = 24
        Me.dgv_Materii.Size = New System.Drawing.Size(765, 424)
        Me.dgv_Materii.TabIndex = 16
        '
        'txt_CautaMaterii
        '
        Me.txt_CautaMaterii.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.txt_CautaMaterii.Location = New System.Drawing.Point(243, 276)
        Me.txt_CautaMaterii.Multiline = True
        Me.txt_CautaMaterii.Name = "txt_CautaMaterii"
        Me.txt_CautaMaterii.Size = New System.Drawing.Size(572, 31)
        Me.txt_CautaMaterii.TabIndex = 39
        Me.txt_CautaMaterii.Tag = "Te rog, completeaza acest camp iar apoi puteti afla diverse informatii"
        '
        'btnCautaMaterii
        '
        Me.btnCautaMaterii.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCautaMaterii.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.btnCautaMaterii.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCautaMaterii.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCautaMaterii.ForeColor = System.Drawing.Color.White
        Me.btnCautaMaterii.Location = New System.Drawing.Point(50, 276)
        Me.btnCautaMaterii.Name = "btnCautaMaterii"
        Me.btnCautaMaterii.Size = New System.Drawing.Size(163, 31)
        Me.btnCautaMaterii.TabIndex = 40
        Me.btnCautaMaterii.Text = "Cauta o materie"
        Me.btnCautaMaterii.UseVisualStyleBackColor = True
        '
        'groupBox_Elevi
        '
        Me.groupBox_Elevi.Controls.Add(Me.cmbBox_idAn)
        Me.groupBox_Elevi.Controls.Add(Me.Label2)
        Me.groupBox_Elevi.Controls.Add(Me.Label3)
        Me.groupBox_Elevi.Controls.Add(Me.txtIdMaterie)
        Me.groupBox_Elevi.Controls.Add(Me.txt_NumeMaterie)
        Me.groupBox_Elevi.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.groupBox_Elevi.Location = New System.Drawing.Point(50, 57)
        Me.groupBox_Elevi.Name = "groupBox_Elevi"
        Me.groupBox_Elevi.Size = New System.Drawing.Size(765, 116)
        Me.groupBox_Elevi.TabIndex = 41
        Me.groupBox_Elevi.TabStop = False
        Me.groupBox_Elevi.Text = "Campuri"
        '
        'cmbBox_idAn
        '
        Me.cmbBox_idAn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbBox_idAn.FormattingEnabled = True
        Me.cmbBox_idAn.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmbBox_idAn.Location = New System.Drawing.Point(484, 72)
        Me.cmbBox_idAn.Name = "cmbBox_idAn"
        Me.cmbBox_idAn.Size = New System.Drawing.Size(192, 24)
        Me.cmbBox_idAn.TabIndex = 20
        Me.cmbBox_idAn.Text = "Selecteaza anul"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(54, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(389, 28)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Anul in care se studiaza materia adaugata"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(116, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Materia care se studiaza"
        '
        'txtIdMaterie
        '
        Me.txtIdMaterie.BackColor = System.Drawing.Color.CadetBlue
        Me.txtIdMaterie.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdMaterie.ForeColor = System.Drawing.Color.CadetBlue
        Me.txtIdMaterie.Location = New System.Drawing.Point(693, 9)
        Me.txtIdMaterie.Name = "txtIdMaterie"
        Me.txtIdMaterie.Size = New System.Drawing.Size(66, 15)
        Me.txtIdMaterie.TabIndex = 17
        '
        'txt_NumeMaterie
        '
        Me.txt_NumeMaterie.Location = New System.Drawing.Point(484, 33)
        Me.txt_NumeMaterie.Name = "txt_NumeMaterie"
        Me.txt_NumeMaterie.Size = New System.Drawing.Size(192, 22)
        Me.txt_NumeMaterie.TabIndex = 6
        '
        'btnAddMaterie
        '
        Me.btnAddMaterie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddMaterie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.btnAddMaterie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddMaterie.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMaterie.ForeColor = System.Drawing.Color.White
        Me.btnAddMaterie.Location = New System.Drawing.Point(50, 192)
        Me.btnAddMaterie.Name = "btnAddMaterie"
        Me.btnAddMaterie.Size = New System.Drawing.Size(163, 54)
        Me.btnAddMaterie.TabIndex = 35
        Me.btnAddMaterie.Text = "Adauga materie"
        Me.btnAddMaterie.UseVisualStyleBackColor = True
        '
        'btnActualizeazaMaterie
        '
        Me.btnActualizeazaMaterie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizeazaMaterie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnActualizeazaMaterie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizeazaMaterie.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizeazaMaterie.ForeColor = System.Drawing.Color.White
        Me.btnActualizeazaMaterie.Location = New System.Drawing.Point(427, 192)
        Me.btnActualizeazaMaterie.Name = "btnActualizeazaMaterie"
        Me.btnActualizeazaMaterie.Size = New System.Drawing.Size(172, 54)
        Me.btnActualizeazaMaterie.TabIndex = 36
        Me.btnActualizeazaMaterie.Text = "Modifica"
        Me.btnActualizeazaMaterie.UseVisualStyleBackColor = True
        '
        'btnStergeInformatii
        '
        Me.btnStergeInformatii.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStergeInformatii.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnStergeInformatii.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStergeInformatii.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStergeInformatii.ForeColor = System.Drawing.Color.White
        Me.btnStergeInformatii.Location = New System.Drawing.Point(614, 192)
        Me.btnStergeInformatii.Name = "btnStergeInformatii"
        Me.btnStergeInformatii.Size = New System.Drawing.Size(201, 54)
        Me.btnStergeInformatii.TabIndex = 37
        Me.btnStergeInformatii.Text = "Sterge informatii"
        Me.btnStergeInformatii.UseVisualStyleBackColor = True
        '
        'btnAfiseazaMaterie
        '
        Me.btnAfiseazaMaterie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAfiseazaMaterie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnAfiseazaMaterie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAfiseazaMaterie.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAfiseazaMaterie.ForeColor = System.Drawing.Color.White
        Me.btnAfiseazaMaterie.Location = New System.Drawing.Point(243, 192)
        Me.btnAfiseazaMaterie.Name = "btnAfiseazaMaterie"
        Me.btnAfiseazaMaterie.Size = New System.Drawing.Size(166, 54)
        Me.btnAfiseazaMaterie.TabIndex = 38
        Me.btnAfiseazaMaterie.Text = "Afiseaza Materiile"
        Me.btnAfiseazaMaterie.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(336, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 32)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Evidenta Materiilor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'MateriiUserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Content)
        Me.Name = "MateriiUserControl1"
        Me.Size = New System.Drawing.Size(864, 731)
        Me.Content.ResumeLayout(False)
        Me.Content.PerformLayout()
        CType(Me.Btn_Inchidere, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv_Materii, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox_Elevi.ResumeLayout(False)
        Me.groupBox_Elevi.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Content As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgv_Materii As DataGridView
    Friend WithEvents txt_CautaMaterii As TextBox
    Friend WithEvents btnCautaMaterii As Button
    Friend WithEvents groupBox_Elevi As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIdMaterie As TextBox
    Friend WithEvents txt_NumeMaterie As TextBox
    Friend WithEvents btnAddMaterie As Button
    Friend WithEvents btnActualizeazaMaterie As Button
    Friend WithEvents btnStergeInformatii As Button
    Friend WithEvents btnAfiseazaMaterie As Button
    Friend WithEvents Label2 As Label
    Private WithEvents Btn_Inchidere As PictureBox
    Friend WithEvents cmbBox_idAn As ComboBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
