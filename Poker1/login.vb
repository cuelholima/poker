Public Class login

    Private Sub GuilhermeHenriqueMartinsAzevedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuilhermeHenriqueMartinsAzevedoToolStripMenuItem.Click
        guilherme.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles entrar.Click
        Form1.Show()
        Form1.NumericUpDown1.Focus()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        usuario.Clear()
        senha.Clear()
    End Sub

    Private Sub MatheusHenriqueDeFariaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MatheusHenriqueDeFariaToolStripMenuItem.Click
        matheus.Show()
        Me.Hide()
    End Sub

    Private Sub CarlosEduardoDouradoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CarlosEduardoDouradoToolStripMenuItem.Click
        carlos.Show()
        Me.Hide()
    End Sub

    Private Sub FlavioLuizDeAlmeidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlavioLuizDeAlmeidaToolStripMenuItem.Click
        flavio.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cadastro.Show()
        cadastro.nome.Focus()
        Me.Hide()
    End Sub

    Private Sub usuario_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usuario.Enter
        usuario.BackColor = Color.Azure
    End Sub

    Private Sub usuario_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usuario.Leave
        usuario.BackColor = Color.White
    End Sub

    Private Sub senha_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles senha.Leave
        senha.BackColor = Color.White
    End Sub

    Private Sub senha_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles senha.Enter
        senha.BackColor = Color.Azure
    End Sub

    Private Sub usuario_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles usuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            senha.Focus()
        End If
    End Sub

    Private Sub senha_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles senha.KeyDown
        If e.KeyCode = Keys.Enter Then
            entrar.Focus()
        End If
    End Sub

    Private Sub NossaEquipeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NossaEquipeToolStripMenuItem.Click
        MessageBox.Show("Programa desenvolvido pelo grupo 'John J. Techno Smith' composto por 4 integrantes com o intuito de aprendizado, proposto pelo professor Jose Matias Lemes Filho, do curso ciencia da computação da faculdade FAM - 2016")
    End Sub

    Private Sub ComprarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprarToolStripMenuItem1.Click
        MessageBox.Show("Entre em contato com: matheuzinho.f@hotmail.com para estar enviando o pagamento e assim receber o serial para cadastro.")
    End Sub
End Class