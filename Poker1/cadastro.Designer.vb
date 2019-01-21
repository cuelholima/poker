<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadastro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cadastro))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.apagar = New System.Windows.Forms.Button
        Me.voltar = New System.Windows.Forms.Button
        Me.cadastrar = New System.Windows.Forms.Button
        Me.serial = New System.Windows.Forms.MaskedTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.sexo = New System.Windows.Forms.ComboBox
        Me.email = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.senha = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.usuario = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.nome = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(334, 109)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 115)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(310, 348)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.apagar)
        Me.TabPage1.Controls.Add(Me.voltar)
        Me.TabPage1.Controls.Add(Me.cadastrar)
        Me.TabPage1.Controls.Add(Me.serial)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.sexo)
        Me.TabPage1.Controls.Add(Me.email)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.senha)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.usuario)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.nome)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(302, 322)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastro de usuário"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'apagar
        '
        Me.apagar.Location = New System.Drawing.Point(161, 280)
        Me.apagar.Name = "apagar"
        Me.apagar.Size = New System.Drawing.Size(129, 23)
        Me.apagar.TabIndex = 7
        Me.apagar.Text = "Apagar campos"
        Me.apagar.UseVisualStyleBackColor = True
        '
        'voltar
        '
        Me.voltar.Location = New System.Drawing.Point(11, 280)
        Me.voltar.Name = "voltar"
        Me.voltar.Size = New System.Drawing.Size(144, 23)
        Me.voltar.TabIndex = 8
        Me.voltar.Text = "Voltar ao login"
        Me.voltar.UseVisualStyleBackColor = True
        '
        'cadastrar
        '
        Me.cadastrar.Location = New System.Drawing.Point(11, 251)
        Me.cadastrar.Name = "cadastrar"
        Me.cadastrar.Size = New System.Drawing.Size(279, 23)
        Me.cadastrar.TabIndex = 6
        Me.cadastrar.Text = "Cadastrar"
        Me.cadastrar.UseVisualStyleBackColor = True
        '
        'serial
        '
        Me.serial.BackColor = System.Drawing.Color.White
        Me.serial.Location = New System.Drawing.Point(11, 195)
        Me.serial.Mask = "aaaaaaa-aaaaaaa-aaaaaaa-aaaaaaa"
        Me.serial.Name = "serial"
        Me.serial.Size = New System.Drawing.Size(279, 20)
        Me.serial.TabIndex = 5
        Me.serial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(8, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Serial:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(248, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Sexo:"
        '
        'sexo
        '
        Me.sexo.BackColor = System.Drawing.Color.White
        Me.sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sexo.FormattingEnabled = True
        Me.sexo.Items.AddRange(New Object() {"M", "F"})
        Me.sexo.Location = New System.Drawing.Point(251, 91)
        Me.sexo.Name = "sexo"
        Me.sexo.Size = New System.Drawing.Size(39, 21)
        Me.sexo.TabIndex = 2
        '
        'email
        '
        Me.email.BackColor = System.Drawing.Color.White
        Me.email.Location = New System.Drawing.Point(11, 91)
        Me.email.MaxLength = 35
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(234, 20)
        Me.email.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(8, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Email:"
        '
        'senha
        '
        Me.senha.BackColor = System.Drawing.Color.White
        Me.senha.Location = New System.Drawing.Point(147, 156)
        Me.senha.MaxLength = 20
        Me.senha.Name = "senha"
        Me.senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.senha.Size = New System.Drawing.Size(143, 20)
        Me.senha.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(144, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Senha:"
        '
        'usuario
        '
        Me.usuario.BackColor = System.Drawing.Color.White
        Me.usuario.Location = New System.Drawing.Point(11, 156)
        Me.usuario.MaxLength = 20
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(130, 20)
        Me.usuario.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(8, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Usuário:"
        '
        'nome
        '
        Me.nome.BackColor = System.Drawing.Color.White
        Me.nome.Location = New System.Drawing.Point(11, 52)
        Me.nome.MaxLength = 37
        Me.nome.Name = "nome"
        Me.nome.Size = New System.Drawing.Size(279, 20)
        Me.nome.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nome completo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Preencha os campos abaixo para se cadastrar."
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(11, 52)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(196, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nome completo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(373, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Preencha os campos abaixo e clique no botão cadastrar para criar sua conta."
        '
        'cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 475)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "P0KeR!! - Cadastro"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents senha As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nome As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents sexo As System.Windows.Forms.ComboBox
    Friend WithEvents email As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents serial As System.Windows.Forms.MaskedTextBox
    Friend WithEvents voltar As System.Windows.Forms.Button
    Friend WithEvents cadastrar As System.Windows.Forms.Button
    Friend WithEvents apagar As System.Windows.Forms.Button
End Class
