Public Class cartas

    Private Sub cartas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chancefinal.Text = resultado.chances1.Text
    End Sub

    Private Sub cartas_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        resultado.Show()
    End Sub
End Class