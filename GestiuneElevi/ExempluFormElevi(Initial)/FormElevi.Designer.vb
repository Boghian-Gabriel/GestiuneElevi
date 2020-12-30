<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormElevi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Nume = New System.Windows.Forms.TextBox()
        Me.txt_Prenume = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtAdresa = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.EleviBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GestiuneEleviDataSet = New GestiuneElevi.GestiuneEleviDataSet()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.EleviTableAdapter = New GestiuneElevi.GestiuneEleviDataSetTableAdapters.EleviTableAdapter()
        Me.dgv_Elevi = New System.Windows.Forms.DataGridView()
        Me.txtIdElevi = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_CautaElevi = New System.Windows.Forms.TextBox()
        Me.btnCautaElevi = New System.Windows.Forms.Button()
        Me.btn_Close_DB = New System.Windows.Forms.Button()
        Me.groupBox_Elevi = New System.Windows.Forms.GroupBox()
        CType(Me.EleviBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GestiuneEleviDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Elevi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox_Elevi.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Connect DB"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(222, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "..."
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nume"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Prenume"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Email"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Adresa"
        '
        'txt_Nume
        '
        Me.txt_Nume.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Nume.Location = New System.Drawing.Point(89, 35)
        Me.txt_Nume.Multiline = True
        Me.txt_Nume.Name = "txt_Nume"
        Me.txt_Nume.Size = New System.Drawing.Size(197, 23)
        Me.txt_Nume.TabIndex = 6
        '
        'txt_Prenume
        '
        Me.txt_Prenume.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Prenume.Location = New System.Drawing.Point(89, 76)
        Me.txt_Prenume.Name = "txt_Prenume"
        Me.txt_Prenume.Size = New System.Drawing.Size(197, 22)
        Me.txt_Prenume.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.Location = New System.Drawing.Point(89, 116)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(197, 22)
        Me.txtEmail.TabIndex = 8
        '
        'txtAdresa
        '
        Me.txtAdresa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAdresa.Location = New System.Drawing.Point(89, 162)
        Me.txtAdresa.Name = "txtAdresa"
        Me.txtAdresa.Size = New System.Drawing.Size(197, 22)
        Me.txtAdresa.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 257)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 35)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Adauga elevi"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(576, 257)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(163, 35)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Actualzieaza iformatiile"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(811, 257)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(163, 35)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Sterge informatii"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'EleviBindingSource
        '
        Me.EleviBindingSource.DataMember = "Elevi"
        Me.EleviBindingSource.DataSource = Me.GestiuneEleviDataSet
        '
        'GestiuneEleviDataSet
        '
        Me.GestiuneEleviDataSet.DataSetName = "GestiuneEleviDataSet"
        Me.GestiuneEleviDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(282, 257)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(163, 35)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Afiseaza elevii"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'EleviTableAdapter
        '
        Me.EleviTableAdapter.ClearBeforeFill = True
        '
        'dgv_Elevi
        '
        Me.dgv_Elevi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgv_Elevi.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgv_Elevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Elevi.Location = New System.Drawing.Point(12, 364)
        Me.dgv_Elevi.Name = "dgv_Elevi"
        Me.dgv_Elevi.RowHeadersWidth = 51
        Me.dgv_Elevi.RowTemplate.Height = 24
        Me.dgv_Elevi.Size = New System.Drawing.Size(962, 208)
        Me.dgv_Elevi.TabIndex = 15
        '
        'txtIdElevi
        '
        Me.txtIdElevi.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtIdElevi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdElevi.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtIdElevi.Location = New System.Drawing.Point(88, -15)
        Me.txtIdElevi.Name = "txtIdElevi"
        Me.txtIdElevi.Size = New System.Drawing.Size(163, 15)
        Me.txtIdElevi.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(269, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 17)
        Me.Label6.TabIndex = 18
        '
        'txt_CautaElevi
        '
        Me.txt_CautaElevi.Location = New System.Drawing.Point(226, 327)
        Me.txt_CautaElevi.Multiline = True
        Me.txt_CautaElevi.Name = "txt_CautaElevi"
        Me.txt_CautaElevi.Size = New System.Drawing.Size(748, 31)
        Me.txt_CautaElevi.TabIndex = 20
        '
        'btnCautaElevi
        '
        Me.btnCautaElevi.Location = New System.Drawing.Point(12, 327)
        Me.btnCautaElevi.Name = "btnCautaElevi"
        Me.btnCautaElevi.Size = New System.Drawing.Size(163, 31)
        Me.btnCautaElevi.TabIndex = 21
        Me.btnCautaElevi.Text = "Cauta Elevi"
        Me.btnCautaElevi.UseVisualStyleBackColor = True
        '
        'btn_Close_DB
        '
        Me.btn_Close_DB.Location = New System.Drawing.Point(111, 9)
        Me.btn_Close_DB.Name = "btn_Close_DB"
        Me.btn_Close_DB.Size = New System.Drawing.Size(105, 27)
        Me.btn_Close_DB.TabIndex = 22
        Me.btn_Close_DB.Text = "Disconect DB"
        Me.btn_Close_DB.UseVisualStyleBackColor = True
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
        Me.groupBox_Elevi.Location = New System.Drawing.Point(11, 42)
        Me.groupBox_Elevi.Name = "groupBox_Elevi"
        Me.groupBox_Elevi.Size = New System.Drawing.Size(962, 202)
        Me.groupBox_Elevi.TabIndex = 23
        Me.groupBox_Elevi.TabStop = False
        Me.groupBox_Elevi.Text = "Campuri"
        '
        'FormElevi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(992, 584)
        Me.Controls.Add(Me.groupBox_Elevi)
        Me.Controls.Add(Me.btn_Close_DB)
        Me.Controls.Add(Me.btnCautaElevi)
        Me.Controls.Add(Me.txt_CautaElevi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgv_Elevi)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FormElevi"
        Me.Text = "Gestiune Elevi"
        CType(Me.EleviBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GestiuneEleviDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Elevi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox_Elevi.ResumeLayout(False)
        Me.groupBox_Elevi.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_Nume As TextBox
    Friend WithEvents txt_Prenume As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAdresa As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents GestiuneEleviDataSet As GestiuneEleviDataSet
    Friend WithEvents EleviBindingSource As BindingSource
    Friend WithEvents EleviTableAdapter As GestiuneEleviDataSetTableAdapters.EleviTableAdapter
    Friend WithEvents dgv_Elevi As DataGridView
    Friend WithEvents txtIdElevi As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_CautaElevi As TextBox
    Friend WithEvents btnCautaElevi As Button
    Friend WithEvents btn_Close_DB As Button
    Friend WithEvents groupBox_Elevi As GroupBox
End Class
