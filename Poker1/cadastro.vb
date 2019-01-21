Public Class cadastro

    Private Sub cadastro_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        login.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles voltar.Click
        login.Show()
        login.usuario.Focus()
        Me.Close()
    End Sub

    Private Sub nome_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nome.KeyDown
        If e.KeyCode = Keys.Enter Then
            email.Focus()
        End If
    End Sub

    Private Sub email_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles email.KeyDown
        If e.KeyCode = Keys.Enter Then
            sexo.Focus()
        End If
    End Sub

    Private Sub sexo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sexo.KeyDown
        If e.KeyCode = Keys.Enter Then
            usuario.Focus()
        End If
    End Sub

    Private Sub usuario_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles usuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            senha.Focus()
        End If
    End Sub

    Private Sub senha_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles senha.KeyDown
        If e.KeyCode = Keys.Enter Then
            serial.Focus()
        End If
    End Sub

    Private Sub serial_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles serial.KeyDown
        If e.KeyCode = Keys.Enter Then
            cadastrar.Focus()
        End If
    End Sub

    Private Sub apagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles apagar.Click
        nome.Clear()
        email.Clear()
        usuario.Clear()
        senha.Clear()
        serial.Clear()
    End Sub

    Private Sub nome_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nome.Leave
        nome.BackColor = Color.White
    End Sub

    Private Sub nome_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nome.Enter
        nome.BackColor = Color.Azure
    End Sub

    Private Sub email_DragLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles email.DragLeave
        email.BackColor = Color.White
    End Sub

    Private Sub email_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles email.Enter
        email.BackColor = Color.Azure
    End Sub

    Private Sub sexo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sexo.Leave
        sexo.BackColor = Color.White
    End Sub

    Private Sub sexo_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sexo.Enter
        sexo.BackColor = Color.Azure
    End Sub

    Private Sub usuario_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usuario.Leave
        usuario.BackColor = Color.White
    End Sub

    Private Sub usuario_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usuario.Enter
        usuario.BackColor = Color.Azure
    End Sub

    Private Sub senha_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles senha.Enter
        senha.BackColor = Color.Azure
    End Sub

    Private Sub senha_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles senha.Leave
        senha.BackColor = Color.White
    End Sub

    Private Sub serial_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles serial.Leave
        serial.BackColor = Color.White
        serial.Text = serial.Text.ToUpper
    End Sub

    Private Sub serial_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles serial.Enter
        serial.BackColor = Color.Azure
    End Sub

    Private Sub email_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles email.Leave
        email.BackColor = Color.White
    End Sub

    Private Sub cadastrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cadastrar.Click
        If ((nome.Text = "") Or (email.Text = "") Or (sexo.Text = "") Or (usuario.Text = "") Or (senha.Text = "") Or (serial.Text = "")) Then
            MessageBox.Show("Ei, você se esqueceu de preencher algum campo")
        ElseIf nome.Text.Length < 5 Then
            MessageBox.Show("Coloque um nome com mais caracteres")
        ElseIf email.Text.Length < 5 Then
            MessageBox.Show("Este e-mail não é válido")
        ElseIf usuario.Text.Length < 4 Then
            MessageBox.Show("Coloque um usuário de pelomenos 5 dígitos")
        ElseIf senha.Text.Length < 5 Then
            MessageBox.Show("Coloque uma senha com mais de 6 dígitos")
        ElseIf ((serial.Text = "DE15R12-8R2J6NS-WTQTUGB-4XZZAT2") Or (serial.Text = "DE15R04-KWEU76G-5MK8F9M-Q86DRDE") Or (serial.Text = "DE15R96-XPFARTS-Y5XEPV5-GDMGY74") Or (serial.Text = "DE15R07-CPRLNAQ-5GPQ7B3-FSZLBQY") Or (serial.Text = "DE15R78-E3SNH9C-FLQ847Q-Y7DC84L") Or (serial.Text = "DE15R09-2DL5D6X-5LFKTN9-6UD4LMU") Or (serial.Text = "DE15R79-632XUNJ-DXKPWEN-3BB37H2") Or (serial.Text = "DE15R17-BZQK6XP-74M3KGC-YRUDC9N") Or (serial.Text = "DE15R59-9DU3XZT-TNLSPDY-YKSJP3W") Or (serial.Text = "DE15R29-4UC9H72-53G8ZE9-B9YXPVC") Or (serial.Text = "DE15R21-UDYG3QU-YMQQPNV-SH22TQG") Or (serial.Text = "DE15R18-SB3HD5F-2PAYY52-RDKK7BE") Or (serial.Text = "DE15R86-52F9S9B-NGR3MQQ-QVTJJJ8") Or (serial.Text = "DE15R16-PEW4PAV-HCKVLP9-J4YNGYJ") Or (serial.Text = "DE15R05-4MC3NUX-TWXHPFA-KCH4JXE") Or (serial.Text = "DE15R96-HH7JF5R-MD585WJ-CBVM5TJ") Or (serial.Text = "DE15R35-EBL8NHP-GTMM5FD-23BM5E6") Or (serial.Text = "DE15R65-9H9KAV8-U625RGC-5AKJV3A") Or (serial.Text = "DE15R76-WLKJ28K-8JFJ2WD-J7H35KC") Or (serial.Text = "DE15R16-6S9HXUL-VUS9SQR-YTEYUGN") Or (serial.Text = "DE15R81-5WDZHYB-LEK9Z8U-K5LNEEE") Or (serial.Text = "DE15R20-4ASMBKS-MEVNZWA-CTKZWCW") Or (serial.Text = "DE15R62-8ZF7YCB-KBCSSDV-5W7GY28") Or (serial.Text = "DE15R30-YTLTJKQ-9BTBRDW-TE8MXAY")) Then
            MessageBox.Show("Cadastro realizado com sucesso!!")
        Else
            MessageBox.Show("Você inseriu um serial inválido, por favor verifique se todos os caracteres estão corretos.")
        End If
    End Sub
End Class