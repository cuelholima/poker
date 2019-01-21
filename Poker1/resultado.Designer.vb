<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resultado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(resultado))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.jogadores = New System.Windows.Forms.Label
        Me.jogadores1 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.carta1simbolo = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.carta1valor = New System.Windows.Forms.ComboBox
        Me.carta2simbolo = New System.Windows.Forms.ComboBox
        Me.carta2valor = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.chances1 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(423, 136)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(254, 386)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(156, 23)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Voltar ao menu de jogadores"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'jogadores
        '
        Me.jogadores.AutoSize = True
        Me.jogadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jogadores.ForeColor = System.Drawing.Color.Red
        Me.jogadores.Location = New System.Drawing.Point(382, 132)
        Me.jogadores.Name = "jogadores"
        Me.jogadores.Size = New System.Drawing.Size(39, 29)
        Me.jogadores.TabIndex = 8
        Me.jogadores.Text = "00"
        '
        'jogadores1
        '
        Me.jogadores1.AutoSize = True
        Me.jogadores1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jogadores1.ForeColor = System.Drawing.Color.Red
        Me.jogadores1.Location = New System.Drawing.Point(7, 9)
        Me.jogadores1.Name = "jogadores1"
        Me.jogadores1.Size = New System.Drawing.Size(19, 13)
        Me.jogadores1.TabIndex = 9
        Me.jogadores1.Text = "00"
        Me.jogadores1.Visible = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.chances1)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.carta2valor)
        Me.TabPage1.Controls.Add(Me.carta2simbolo)
        Me.TabPage1.Controls.Add(Me.carta1valor)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.carta1simbolo)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(391, 211)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pré-flop"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(7, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Por favor, selecione as cartas que deseja começar e clique em 'Pré-flop'." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.P0KeR.My.Resources.Resources.icone
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(10, 34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 73)
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(88, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Carta 1 - Simbolo"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(6, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(245, 33)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Calcular o Pré-flop"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'carta1simbolo
        '
        Me.carta1simbolo.BackColor = System.Drawing.Color.White
        Me.carta1simbolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.carta1simbolo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.carta1simbolo.FormattingEnabled = True
        Me.carta1simbolo.Items.AddRange(New Object() {"♠ Espadas", "♣ Paus", "♥ Copas", "♦ Ouros"})
        Me.carta1simbolo.Location = New System.Drawing.Point(91, 64)
        Me.carta1simbolo.Name = "carta1simbolo"
        Me.carta1simbolo.Size = New System.Drawing.Size(117, 21)
        Me.carta1simbolo.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(224, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Carta 2 - Simbolo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(88, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Carta 1 - Valor"
        '
        'carta1valor
        '
        Me.carta1valor.BackColor = System.Drawing.Color.White
        Me.carta1valor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.carta1valor.Enabled = False
        Me.carta1valor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.carta1valor.FormattingEnabled = True
        Me.carta1valor.Location = New System.Drawing.Point(91, 112)
        Me.carta1valor.Name = "carta1valor"
        Me.carta1valor.Size = New System.Drawing.Size(117, 21)
        Me.carta1valor.TabIndex = 2
        '
        'carta2simbolo
        '
        Me.carta2simbolo.BackColor = System.Drawing.Color.White
        Me.carta2simbolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.carta2simbolo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.carta2simbolo.FormattingEnabled = True
        Me.carta2simbolo.Items.AddRange(New Object() {"♠ Espadas", "♣ Paus", "♥ Copas", "♦ Ouros"})
        Me.carta2simbolo.Location = New System.Drawing.Point(227, 64)
        Me.carta2simbolo.Name = "carta2simbolo"
        Me.carta2simbolo.Size = New System.Drawing.Size(117, 21)
        Me.carta2simbolo.TabIndex = 1
        '
        'carta2valor
        '
        Me.carta2valor.BackColor = System.Drawing.Color.White
        Me.carta2valor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.carta2valor.Enabled = False
        Me.carta2valor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.carta2valor.FormattingEnabled = True
        Me.carta2valor.Items.AddRange(New Object() {"2 ♦", "3 ♦", "4 ♦", "5 ♦", "6 ♦", "7 ♦", "8 ♦", "9 ♦", "10 ♦", "J ♦", "Q ♦", "R ♦", "A ♦", "", "2 ♠", "3 ♠", "4 ♠", "5 ♠", "6 ♠", "7 ♠", "8 ♠", "9 ♠", "10 ♠", "J ♠", "Q ♠", "R ♠", "A ♠", "", "2 ♥", "3 ♥", "4 ♥", "5 ♥", "6 ♥", "7 ♥", "8 ♥", "9 ♥", "10 ♥", "J ♥", "Q ♥", "R ♥", "A ♥", "", "2 ♣", "3 ♣", "4 ♣", "5 ♣", "6 ♣", "7 ♣", "8 ♣", "9 ♣", "10 ♣", "J ♣", "Q ♣", "R ♣", "A ♣"})
        Me.carta2valor.Location = New System.Drawing.Point(227, 112)
        Me.carta2valor.Name = "carta2valor"
        Me.carta2valor.Size = New System.Drawing.Size(117, 21)
        Me.carta2valor.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(224, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Carta 2 - Valor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(88, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Chances de vitória no pré-flop:"
        '
        'chances1
        '
        Me.chances1.AutoSize = True
        Me.chances1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chances1.Location = New System.Drawing.Point(239, 143)
        Me.chances1.Name = "chances1"
        Me.chances1.Size = New System.Drawing.Size(21, 13)
        Me.chances1.TabIndex = 28
        Me.chances1.Text = "?%"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 142)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(399, 237)
        Me.TabControl1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(257, 168)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 33)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Auto-preencher"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'resultado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 419)
        Me.Controls.Add(Me.jogadores1)
        Me.Controls.Add(Me.jogadores)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "resultado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "P0KeR!! - Pré-flop"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents jogadores As System.Windows.Forms.Label
    Friend WithEvents jogadores1 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents chances1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents carta2valor As System.Windows.Forms.ComboBox
    Friend WithEvents carta2simbolo As System.Windows.Forms.ComboBox
    Friend WithEvents carta1valor As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents carta1simbolo As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
End Class
