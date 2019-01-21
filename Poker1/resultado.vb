Public Class resultado

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub jogadores_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jogadores.TextChanged
        If jogadores.Text = "2" Then
            jogadores.Text = "➋"
        End If
        If jogadores.Text = "3" Then
            jogadores.Text = "➌"
        End If
        If jogadores.Text = "4" Then
            jogadores.Text = "➍"
        End If
        If jogadores.Text = "5" Then
            jogadores.Text = "➎"
        End If
        If jogadores.Text = "6" Then
            jogadores.Text = "➏"
        End If
        If jogadores.Text = "7" Then
            jogadores.Text = "➐"
        End If
        If jogadores.Text = "8" Then
            jogadores.Text = "➑"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ((carta1simbolo.Text = "") Or (carta1valor.Text = "") Or (carta2simbolo.Text = "") Or (carta2valor.Text = "")) Then
            MessageBox.Show("Ei, você se esqueceu de preencher algum campo")
        End If

        If ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "2") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "3") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "4") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "5") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "6") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "7") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "8") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "9") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "10") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "J") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "Q") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "K") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "A") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")

        ElseIf ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "2") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "3") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "4") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "5") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "6") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "7") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "8") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "9") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "10") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "J") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "Q") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "K") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "A") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")

        ElseIf ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "2") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "3") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "4") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "5") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "6") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "7") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "8") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "9") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "10") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "J") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "Q") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "K") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "A") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")

        ElseIf ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "2") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♦ Ouros") And (carta1valor.Text = "3") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♦ Ouros") And (carta1valor.Text = "4") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♦ Ouros") And (carta1valor.Text = "5") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♦ Ouros") And (carta1valor.Text = "6") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♦ Ouros") And (carta1valor.Text = "7") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♦ Ouros") And (carta1valor.Text = "8") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♦ Ouros") And (carta1valor.Text = "9") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♦ Ouros") And (carta1valor.Text = "10") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♦ Ouros") And (carta1valor.Text = "J") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♦ Ouros") And (carta1valor.Text = "Q") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♦ Ouros") And (carta1valor.Text = "K") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")
        ElseIf ((carta1simbolo.Text = "♦ Ouros") And (carta1valor.Text = "A") And (carta2simbolo.Text = carta1simbolo.Text) And (carta2valor.Text = carta1valor.Text)) Then
            MessageBox.Show("Você selecionou cartas iguais do mesmo nipe em ambos os campos, por favor escolha nipes diferente e clique novamente")


        Else
            If ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "2")) Then
                cartas.carta1.Image = My.Resources.cardSpades2
            End If
            If ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "3")) Then
                cartas.carta1.Image = My.Resources.cardSpades3
            End If
            If ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "3")) Then
                cartas.carta1.Image = My.Resources.cardSpades3
            End If
            If ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "4")) Then
                cartas.carta1.Image = My.Resources.cardSpades4
            End If
            If ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "4")) Then
                cartas.carta1.Image = My.Resources.cardSpades4
            End If
            If ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "5")) Then
                cartas.carta1.Image = My.Resources.cardSpades5
            End If
            If ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "6")) Then
                cartas.carta1.Image = My.Resources.cardSpades6
            End If
            If ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "7")) Then
                cartas.carta1.Image = My.Resources.cardSpades7
            End If
            If ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "8")) Then
                cartas.carta1.Image = My.Resources.cardSpades8
            End If
            If ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "9")) Then
                cartas.carta1.Image = My.Resources.cardSpades9
            End If
            If ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "10")) Then
                cartas.carta1.Image = My.Resources.cardSpades10
            End If
            If ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "J")) Then
                cartas.carta1.Image = My.Resources.cardSpadesJ
            End If
            If ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "Q")) Then
                cartas.carta1.Image = My.Resources.cardSpadesQ
            End If
            If ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "K")) Then
                cartas.carta1.Image = My.Resources.cardSpadesK
            End If
            If ((carta1simbolo.Text = "♠ Espadas") And (carta1valor.Text = "A")) Then
                cartas.carta1.Image = My.Resources.cardSpadesA
            End If

            If ((carta2simbolo.Text = "♠ Espadas") And (carta2valor.Text = "2")) Then
                cartas.carta2.Image = My.Resources.cardSpades2
            End If
            If ((carta2simbolo.Text = "♠ Espadas") And (carta2valor.Text = "3")) Then
                cartas.carta2.Image = My.Resources.cardSpades3
            End If
            If ((carta2simbolo.Text = "♠ Espadas") And (carta2valor.Text = "3")) Then
                cartas.carta2.Image = My.Resources.cardSpades3
            End If
            If ((carta2simbolo.Text = "♠ Espadas") And (carta2valor.Text = "4")) Then
                cartas.carta2.Image = My.Resources.cardSpades4
            End If
            If ((carta2simbolo.Text = "♠ Espadas") And (carta2valor.Text = "4")) Then
                cartas.carta2.Image = My.Resources.cardSpades4
            End If
            If ((carta2simbolo.Text = "♠ Espadas") And (carta2valor.Text = "5")) Then
                cartas.carta2.Image = My.Resources.cardSpades5
            End If
            If ((carta2simbolo.Text = "♠ Espadas") And (carta2valor.Text = "6")) Then
                cartas.carta2.Image = My.Resources.cardSpades6
            End If
            If ((carta2simbolo.Text = "♠ Espadas") And (carta2valor.Text = "7")) Then
                cartas.carta2.Image = My.Resources.cardSpades7
            End If
            If ((carta2simbolo.Text = "♠ Espadas") And (carta2valor.Text = "8")) Then
                cartas.carta2.Image = My.Resources.cardSpades8
            End If
            If ((carta2simbolo.Text = "♠ Espadas") And (carta2valor.Text = "9")) Then
                cartas.carta2.Image = My.Resources.cardSpades9
            End If
            If ((carta2simbolo.Text = "♠ Espadas") And (carta2valor.Text = "10")) Then
                cartas.carta2.Image = My.Resources.cardSpades10
            End If
            If ((carta2simbolo.Text = "♠ Espadas") And (carta2valor.Text = "J")) Then
                cartas.carta2.Image = My.Resources.cardSpadesJ
            End If
            If ((carta2simbolo.Text = "♠ Espadas") And (carta2valor.Text = "Q")) Then
                cartas.carta2.Image = My.Resources.cardSpadesQ
            End If
            If ((carta2simbolo.Text = "♠ Espadas") And (carta2valor.Text = "K")) Then
                cartas.carta2.Image = My.Resources.cardSpadesK
            End If
            If ((carta2simbolo.Text = "♠ Espadas") And (carta2valor.Text = "A")) Then
                cartas.carta2.Image = My.Resources.cardSpadesA
            End If

            If ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "2")) Then
                cartas.carta1.Image = My.Resources.cardClubs2
            End If
            If ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "3")) Then
                cartas.carta1.Image = My.Resources.cardClubs3
            End If
            If ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "3")) Then
                cartas.carta1.Image = My.Resources.cardClubs3
            End If
            If ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "4")) Then
                cartas.carta1.Image = My.Resources.cardClubs4
            End If
            If ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "4")) Then
                cartas.carta1.Image = My.Resources.cardClubs4
            End If
            If ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "5")) Then
                cartas.carta1.Image = My.Resources.cardClubs5
            End If
            If ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "6")) Then
                cartas.carta1.Image = My.Resources.cardClubs6
            End If
            If ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "7")) Then
                cartas.carta1.Image = My.Resources.cardClubs7
            End If
            If ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "8")) Then
                cartas.carta1.Image = My.Resources.cardClubs8
            End If
            If ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "9")) Then
                cartas.carta1.Image = My.Resources.cardClubs9
            End If
            If ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "10")) Then
                cartas.carta1.Image = My.Resources.cardClubs10
            End If
            If ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "J")) Then
                cartas.carta1.Image = My.Resources.cardClubsJ
            End If
            If ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "Q")) Then
                cartas.carta1.Image = My.Resources.cardClubsQ
            End If
            If ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "K")) Then
                cartas.carta1.Image = My.Resources.cardClubsK
            End If
            If ((carta1simbolo.Text = "♣ Paus") And (carta1valor.Text = "A")) Then
                cartas.carta1.Image = My.Resources.cardClubsA
            End If

            If ((carta2simbolo.Text = "♣ Paus") And (carta2valor.Text = "2")) Then
                cartas.carta2.Image = My.Resources.cardClubs2
            End If
            If ((carta2simbolo.Text = "♣ Paus") And (carta2valor.Text = "3")) Then
                cartas.carta2.Image = My.Resources.cardClubs3
            End If
            If ((carta2simbolo.Text = "♣ Paus") And (carta2valor.Text = "3")) Then
                cartas.carta2.Image = My.Resources.cardClubs3
            End If
            If ((carta2simbolo.Text = "♣ Paus") And (carta2valor.Text = "4")) Then
                cartas.carta2.Image = My.Resources.cardClubs4
            End If
            If ((carta2simbolo.Text = "♣ Paus") And (carta2valor.Text = "4")) Then
                cartas.carta2.Image = My.Resources.cardClubs4
            End If
            If ((carta2simbolo.Text = "♣ Paus") And (carta2valor.Text = "5")) Then
                cartas.carta2.Image = My.Resources.cardClubs5
            End If
            If ((carta2simbolo.Text = "♣ Paus") And (carta2valor.Text = "6")) Then
                cartas.carta2.Image = My.Resources.cardClubs6
            End If
            If ((carta2simbolo.Text = "♣ Paus") And (carta2valor.Text = "7")) Then
                cartas.carta2.Image = My.Resources.cardClubs7
            End If
            If ((carta2simbolo.Text = "♣ Paus") And (carta2valor.Text = "8")) Then
                cartas.carta2.Image = My.Resources.cardClubs8
            End If
            If ((carta2simbolo.Text = "♣ Paus") And (carta2valor.Text = "9")) Then
                cartas.carta2.Image = My.Resources.cardClubs9
            End If
            If ((carta2simbolo.Text = "♣ Paus") And (carta2valor.Text = "10")) Then
                cartas.carta2.Image = My.Resources.cardClubs10
            End If
            If ((carta2simbolo.Text = "♣ Paus") And (carta2valor.Text = "J")) Then
                cartas.carta2.Image = My.Resources.cardClubsJ
            End If
            If ((carta2simbolo.Text = "♣ Paus") And (carta2valor.Text = "Q")) Then
                cartas.carta2.Image = My.Resources.cardClubsQ
            End If
            If ((carta2simbolo.Text = "♣ Paus") And (carta2valor.Text = "K")) Then
                cartas.carta2.Image = My.Resources.cardClubsK
            End If
            If ((carta2simbolo.Text = "♣ Paus") And (carta2valor.Text = "A")) Then
                cartas.carta2.Image = My.Resources.cardClubsA
            End If

            If ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "2")) Then
                cartas.carta1.Image = My.Resources.cardHearts2
            End If
            If ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "3")) Then
                cartas.carta1.Image = My.Resources.cardHearts3
            End If
            If ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "3")) Then
                cartas.carta1.Image = My.Resources.cardHearts3
            End If
            If ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "4")) Then
                cartas.carta1.Image = My.Resources.cardHearts4
            End If
            If ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "4")) Then
                cartas.carta1.Image = My.Resources.cardHearts4
            End If
            If ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "5")) Then
                cartas.carta1.Image = My.Resources.cardHearts5
            End If
            If ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "6")) Then
                cartas.carta1.Image = My.Resources.cardHearts6
            End If
            If ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "7")) Then
                cartas.carta1.Image = My.Resources.cardHearts7
            End If
            If ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "8")) Then
                cartas.carta1.Image = My.Resources.cardHearts8
            End If
            If ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "9")) Then
                cartas.carta1.Image = My.Resources.cardHearts9
            End If
            If ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "10")) Then
                cartas.carta1.Image = My.Resources.cardHearts10
            End If
            If ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "J")) Then
                cartas.carta1.Image = My.Resources.cardHeartsJ
            End If
            If ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "Q")) Then
                cartas.carta1.Image = My.Resources.cardHeartsQ
            End If
            If ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "K")) Then
                cartas.carta1.Image = My.Resources.cardHeartsK
            End If
            If ((carta1simbolo.Text = "♥ Copas") And (carta1valor.Text = "A")) Then
                cartas.carta1.Image = My.Resources.cardHeartsA
            End If

            If ((carta2simbolo.Text = "♥ Copas") And (carta2valor.Text = "2")) Then
                cartas.carta2.Image = My.Resources.cardHearts2
            End If
            If ((carta2simbolo.Text = "♥ Copas") And (carta2valor.Text = "3")) Then
                cartas.carta2.Image = My.Resources.cardHearts3
            End If
            If ((carta2simbolo.Text = "♥ Copas") And (carta2valor.Text = "3")) Then
                cartas.carta2.Image = My.Resources.cardHearts3
            End If
            If ((carta2simbolo.Text = "♥ Copas") And (carta2valor.Text = "4")) Then
                cartas.carta2.Image = My.Resources.cardHearts4
            End If
            If ((carta2simbolo.Text = "♥ Copas") And (carta2valor.Text = "4")) Then
                cartas.carta2.Image = My.Resources.cardHearts4
            End If
            If ((carta2simbolo.Text = "♥ Copas") And (carta2valor.Text = "5")) Then
                cartas.carta2.Image = My.Resources.cardHearts5
            End If
            If ((carta2simbolo.Text = "♥ Copas") And (carta2valor.Text = "6")) Then
                cartas.carta2.Image = My.Resources.cardHearts6
            End If
            If ((carta2simbolo.Text = "♥ Copas") And (carta2valor.Text = "7")) Then
                cartas.carta2.Image = My.Resources.cardHearts7
            End If
            If ((carta2simbolo.Text = "♥ Copas") And (carta2valor.Text = "8")) Then
                cartas.carta2.Image = My.Resources.cardHearts8
            End If
            If ((carta2simbolo.Text = "♥ Copas") And (carta2valor.Text = "9")) Then
                cartas.carta2.Image = My.Resources.cardHearts9
            End If
            If ((carta2simbolo.Text = "♥ Copas") And (carta2valor.Text = "10")) Then
                cartas.carta2.Image = My.Resources.cardHearts10
            End If
            If ((carta2simbolo.Text = "♥ Copas") And (carta2valor.Text = "J")) Then
                cartas.carta2.Image = My.Resources.cardHeartsJ
            End If
            If ((carta2simbolo.Text = "♥ Copas") And (carta2valor.Text = "Q")) Then
                cartas.carta2.Image = My.Resources.cardHeartsQ
            End If
            If ((carta2simbolo.Text = "♥ Copas") And (carta2valor.Text = "K")) Then
                cartas.carta2.Image = My.Resources.cardHeartsK
            End If
            If ((carta2simbolo.Text = "♥ Copas") And (carta2valor.Text = "A")) Then
                cartas.carta2.Image = My.Resources.cardHeartsA
            End If

            If ((carta1simbolo.Text = "♦ Ouros") And (carta1valor.Text = "2")) Then
                cartas.carta1.Image = My.Resources.cardDiamonds2
            End If
            If ((carta1simbolo.Text = "♦ Ouros") And (carta1valor.Text = "3")) Then
                cartas.carta1.Image = My.Resources.cardDiamonds3
            End If
            If ((carta1simbolo.Text = "♦ Ouros") And (carta1valor.Text = "3")) Then
                cartas.carta1.Image = My.Resources.cardDiamonds3
            End If
            If ((carta1simbolo.Text = "♦ Ouros") And (carta1valor.Text = "4")) Then
                cartas.carta1.Image = My.Resources.cardDiamonds4
            End If
            If ((carta1simbolo.Text = "♦ Ouros") And (carta1valor.Text = "4")) Then
                cartas.carta1.Image = My.Resources.cardDiamonds4
            End If
            If ((carta1simbolo.Text = "♦ Ouros") And (carta1valor.Text = "5")) Then
                cartas.carta1.Image = My.Resources.cardDiamonds5
            End If
            If ((carta1simbolo.Text = "♦ Ouros") And (carta1valor.Text = "6")) Then
                cartas.carta1.Image = My.Resources.cardDiamonds6
            End If
            If ((carta1simbolo.Text = "♦ Ouros") And (carta1valor.Text = "7")) Then
                cartas.carta1.Image = My.Resources.cardDiamonds7
            End If
            If ((carta1simbolo.Text = "♦ Ouros") And (carta1valor.Text = "8")) Then
                cartas.carta1.Image = My.Resources.cardDiamonds8
            End If
            If ((carta1simbolo.Text = "♦ Ouros") And (carta1valor.Text = "9")) Then
                cartas.carta1.Image = My.Resources.cardDiamonds9
            End If
            If ((carta1simbolo.Text = "♦ Ouros") And (carta1valor.Text = "10")) Then
                cartas.carta1.Image = My.Resources.cardDiamonds10
            End If
            If ((carta1simbolo.Text = "♦ Ouros") And (carta1valor.Text = "J")) Then
                cartas.carta1.Image = My.Resources.cardDiamondsJ
            End If
            If ((carta1simbolo.Text = "♦ Ouros") And (carta1valor.Text = "Q")) Then
                cartas.carta1.Image = My.Resources.cardDiamondsQ
            End If
            If ((carta1simbolo.Text = "♦ Ouros") And (carta1valor.Text = "K")) Then
                cartas.carta1.Image = My.Resources.cardDiamondsK
            End If
            If ((carta1simbolo.Text = "♦ Ouros") And (carta1valor.Text = "A")) Then
                cartas.carta1.Image = My.Resources.cardDiamondsA
            End If

            If ((carta2simbolo.Text = "♦ Ouros") And (carta2valor.Text = "2")) Then
                cartas.carta2.Image = My.Resources.cardDiamonds2
            End If
            If ((carta2simbolo.Text = "♦ Ouros") And (carta2valor.Text = "3")) Then
                cartas.carta2.Image = My.Resources.cardDiamonds3
            End If
            If ((carta2simbolo.Text = "♦ Ouros") And (carta2valor.Text = "3")) Then
                cartas.carta2.Image = My.Resources.cardDiamonds3
            End If
            If ((carta2simbolo.Text = "♦ Ouros") And (carta2valor.Text = "4")) Then
                cartas.carta2.Image = My.Resources.cardDiamonds4
            End If
            If ((carta2simbolo.Text = "♦ Ouros") And (carta2valor.Text = "4")) Then
                cartas.carta2.Image = My.Resources.cardDiamonds4
            End If
            If ((carta2simbolo.Text = "♦ Ouros") And (carta2valor.Text = "5")) Then
                cartas.carta2.Image = My.Resources.cardDiamonds5
            End If
            If ((carta2simbolo.Text = "♦ Ouros") And (carta2valor.Text = "6")) Then
                cartas.carta2.Image = My.Resources.cardDiamonds6
            End If
            If ((carta2simbolo.Text = "♦ Ouros") And (carta2valor.Text = "7")) Then
                cartas.carta2.Image = My.Resources.cardDiamonds7
            End If
            If ((carta2simbolo.Text = "♦ Ouros") And (carta2valor.Text = "8")) Then
                cartas.carta2.Image = My.Resources.cardDiamonds8
            End If
            If ((carta2simbolo.Text = "♦ Ouros") And (carta2valor.Text = "9")) Then
                cartas.carta2.Image = My.Resources.cardDiamonds9
            End If
            If ((carta2simbolo.Text = "♦ Ouros") And (carta2valor.Text = "10")) Then
                cartas.carta2.Image = My.Resources.cardDiamonds10
            End If
            If ((carta2simbolo.Text = "♦ Ouros") And (carta2valor.Text = "J")) Then
                cartas.carta2.Image = My.Resources.cardDiamondsJ
            End If
            If ((carta2simbolo.Text = "♦ Ouros") And (carta2valor.Text = "Q")) Then
                cartas.carta2.Image = My.Resources.cardDiamondsQ
            End If
            If ((carta2simbolo.Text = "♦ Ouros") And (carta2valor.Text = "K")) Then
                cartas.carta2.Image = My.Resources.cardDiamondsK
            End If
            If ((carta2simbolo.Text = "♦ Ouros") And (carta2valor.Text = "A")) Then
                cartas.carta2.Image = My.Resources.cardDiamondsA
            End If





            If ((carta1simbolo.Text = "") Or (carta1valor.Text = "") Or (carta2simbolo.Text = "") Or (carta2valor.Text = "")) Then

            Else
                If jogadores1.Text = 2 Then
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "A")) Then
                        chances1.Text = "85%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "K")) Then
                        chances1.Text = "82,4%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "79,9%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "J")) Then
                        chances1.Text = "77%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "10")) Then
                        chances1.Text = "74,7%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "9")) Then
                        chances1.Text = "71,4%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "8")) Then
                        chances1.Text = "68,7%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "7")) Then
                        chances1.Text = "65,6%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "6")) Then
                        chances1.Text = "62,6%"
                    End If
                    If ((carta1valor.Text = "5") And (carta2valor.Text = "5")) Then
                        chances1.Text = "59,4%"
                    End If
                    If ((carta1valor.Text = "4") And (carta2valor.Text = "4")) Then
                        chances1.Text = "55,9%"
                    End If
                    If ((carta1valor.Text = "3") And (carta2valor.Text = "3")) Then
                        chances1.Text = "52,7%"
                    End If
                    If ((carta1valor.Text = "2") And (carta2valor.Text = "2")) Then
                        chances1.Text = "49,3%"
                    End If

                    If ((carta1valor.Text = "A") And (carta2valor.Text = "K")) Or ((carta1valor.Text = "K") And (carta2valor.Text = "A")) Then
                        chances1.Text = "66,3%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "Q")) Or ((carta1valor.Text = "Q") And (carta2valor.Text = "A")) Then
                        chances1.Text = "65,6%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "J")) Or ((carta1valor.Text = "J") And (carta2valor.Text = "A")) Then
                        chances1.Text = "64,3%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "A")) Then
                        chances1.Text = "63,3%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "A")) Then
                        chances1.Text = "61,6%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "A")) Then
                        chances1.Text = "60,3%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "A")) Then
                        chances1.Text = "59,2%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "A")) Then
                        chances1.Text = "58,4%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "A")) Then
                        chances1.Text = "58,1%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "A")) Then
                        chances1.Text = "57,5%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "A")) Then
                        chances1.Text = "56,5%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "A")) Then
                        chances1.Text = "55,5%"
                    End If

                    If ((carta1valor.Text = "K") And (carta2valor.Text = "Q")) Or ((carta1valor.Text = "Q") And (carta2valor.Text = "K")) Then
                        chances1.Text = "62,2%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "J")) Or ((carta1valor.Text = "J") And (carta2valor.Text = "K")) Then
                        chances1.Text = "61,2%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "K")) Then
                        chances1.Text = "60,8%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "K")) Then
                        chances1.Text = "58,5%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "K")) Then
                        chances1.Text = "57%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "K")) Then
                        chances1.Text = "55,8%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "K")) Then
                        chances1.Text = "54,8%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "K")) Then
                        chances1.Text = "53,8%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "K")) Then
                        chances1.Text = "52,9%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "K")) Then
                        chances1.Text = "51,8%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "K")) Then
                        chances1.Text = "51,1%"
                    End If

                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "J")) Or ((carta1valor.Text = "J") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "59,2%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "58,5%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "56,2%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "54,1%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "52,6%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "51,7%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "50,9%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "50,1%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "49,2%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "48%"
                    End If

                    If ((carta1valor.Text = "J") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "J")) Then
                        chances1.Text = "56,4%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "J")) Then
                        chances1.Text = "54,1%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "J")) Then
                        chances1.Text = "52,4%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "J")) Then
                        chances1.Text = "50,4%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "J")) Then
                        chances1.Text = "48,4%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "J")) Then
                        chances1.Text = "47,9%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "J")) Then
                        chances1.Text = "46,7%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "J")) Then
                        chances1.Text = "46,1%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "J")) Then
                        chances1.Text = "45,2%"
                    End If

                    If ((carta1valor.Text = "10") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "10")) Then
                        chances1.Text = "52,4%"
                    
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "10")) Then
                        chances1.Text = "50,7%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "10")) Then
                        chances1.Text = "48,5%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "10")) Then
                        chances1.Text = "46,6%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "10")) Then
                        chances1.Text = "45,2%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "10")) Then
                        chances1.Text = "44%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "10")) Then
                        chances1.Text = "43,5%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "10")) Then
                        chances1.Text = "42,4%"
                    End If

                    If ((carta1valor.Text = "9") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "9")) Then
                        chances1.Text = "48,9%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "9")) Then
                        chances1.Text = "47,3%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "9")) Then
                        chances1.Text = "45%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "9")) Then
                        chances1.Text = "43,6%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "9")) Then
                        chances1.Text = "41,5%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "9")) Then
                        chances1.Text = "40,7%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "9")) Then
                        chances1.Text = "40%"
                    End If

                    If ((carta1valor.Text = "8") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "8")) Then
                        chances1.Text = "45,8%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "8")) Then
                        chances1.Text = "43,6%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "8")) Then
                        chances1.Text = "42,1%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "8")) Then
                        chances1.Text = "40,1%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "8")) Then
                        chances1.Text = "38,2%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "8")) Then
                        chances1.Text = "37,5%"
                    End If

                    If ((carta1valor.Text = "7") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "7")) Then
                        chances1.Text = "43,1%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "7")) Then
                        chances1.Text = "40,8%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "7")) Then
                        chances1.Text = "38,9%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "7")) Then
                        chances1.Text = "37,7%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "7")) Then
                        chances1.Text = "35,5%"
                    End If

                    If ((carta1valor.Text = "6") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "6")) Then
                        chances1.Text = "40,3%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "6")) Then
                        chances1.Text = "38,4%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "6")) Then
                        chances1.Text = "37%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "6")) Then
                        chances1.Text = "34,8%"
                    End If

                    If ((carta1valor.Text = "5") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "5")) Then
                        chances1.Text = "38,3%"
                    End If
                    If ((carta1valor.Text = "5") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "5")) Then
                        chances1.Text = "36,6%"
                    End If
                    If ((carta1valor.Text = "5") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "5")) Then
                        chances1.Text = "35,2%"
                    End If

                    If ((carta1valor.Text = "4") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "4")) Then
                        chances1.Text = "36,2%"
                    End If
                    If ((carta1valor.Text = "4") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "4")) Then
                        chances1.Text = "33,8%"
                    End If

                    If ((carta1valor.Text = "3") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "3")) Then
                        chances1.Text = "32,9%"
                    End If
                    cartas.Show()
                    Me.Hide()
                End If



                If jogadores1.Text = 3 Then
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "A")) Then
                        chances1.Text = "73,2%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "K")) Then
                        chances1.Text = "68,6%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "64,5%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "J")) Then
                        chances1.Text = "60,7"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "10")) Then
                        chances1.Text = "57,3%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "9")) Then
                        chances1.Text = "53,2%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "8")) Then
                        chances1.Text = "49,5%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "7")) Then
                        chances1.Text = "46,2%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "6")) Then
                        chances1.Text = "42,6%"
                    End If
                    If ((carta1valor.Text = "5") And (carta2valor.Text = "5")) Then
                        chances1.Text = "39,8%"
                    End If
                    If ((carta1valor.Text = "4") And (carta2valor.Text = "4")) Then
                        chances1.Text = "36,6%"
                    End If
                    If ((carta1valor.Text = "3") And (carta2valor.Text = "3")) Then
                        chances1.Text = "33,3%"
                    End If
                    If ((carta1valor.Text = "2") And (carta2valor.Text = "2")) Then
                        chances1.Text = "30,3%"
                    End If

                    If ((carta1valor.Text = "A") And (carta2valor.Text = "K")) Or ((carta1valor.Text = "K") And (carta2valor.Text = "A")) Then
                        chances1.Text = "49,8%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "Q")) Or ((carta1valor.Text = "Q") And (carta2valor.Text = "A")) Then
                        chances1.Text = "48,7%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "J")) Or ((carta1valor.Text = "J") And (carta2valor.Text = "A")) Then
                        chances1.Text = "47%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "A")) Then
                        chances1.Text = "45,7%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "A")) Then
                        chances1.Text = "43%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "A")) Then
                        chances1.Text = "41,8%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "A")) Then
                        chances1.Text = "40,5%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "A")) Then
                        chances1.Text = "39,3%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "A")) Then
                        chances1.Text = "39,3%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "A")) Then
                        chances1.Text = "38,6%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "A")) Then
                        chances1.Text = "37,5%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "A")) Then
                        chances1.Text = "37%"
                    End If

                    If ((carta1valor.Text = "K") And (carta2valor.Text = "Q")) Or ((carta1valor.Text = "Q") And (carta2valor.Text = "K")) Then
                        chances1.Text = "45,9%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "J")) Or ((carta1valor.Text = "J") And (carta2valor.Text = "K")) Then
                        chances1.Text = "44,5%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "K")) Then
                        chances1.Text = "43,5%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "K")) Then
                        chances1.Text = "40,7%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "K")) Then
                        chances1.Text = "38,7%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "K")) Then
                        chances1.Text = "37,4%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "K")) Then
                        chances1.Text = "36,4%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "K")) Then
                        chances1.Text = "35,6%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "K")) Then
                        chances1.Text = "34,7%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "K")) Then
                        chances1.Text = "33,9%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "K")) Then
                        chances1.Text = "33,3%"
                    End If

                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "J")) Or ((carta1valor.Text = "J") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "43%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "41,8%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "39,4%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "36,9%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "34,7%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "33,8%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "33,1%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "32,1%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "31,5%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "30,8%"
                    End If

                    If ((carta1valor.Text = "J") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "J")) Then
                        chances1.Text = "40,5%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "J")) Then
                        chances1.Text = "38,2%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "J")) Then
                        chances1.Text = "35,6%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "J")) Then
                        chances1.Text = "33,4%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "J")) Then
                        chances1.Text = "31,6%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "J")) Then
                        chances1.Text = "30,8%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "J")) Then
                        chances1.Text = "30%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "J")) Then
                        chances1.Text = "29,2%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "J")) Then
                        chances1.Text = "28,5%"
                    End If

                    If ((carta1valor.Text = "10") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "10")) Then
                        chances1.Text = "37,3%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "10")) Then
                        chances1.Text = "35,3%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "10")) Then
                        chances1.Text = "33%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "10")) Then
                        chances1.Text = "30,6%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "10")) Then
                        chances1.Text = "29,1%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "10")) Then
                        chances1.Text = "28,4%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "10")) Then
                        chances1.Text = "27,4%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "10")) Then
                        chances1.Text = "27,2%"
                    End If

                    If ((carta1valor.Text = "9") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "9")) Then
                        chances1.Text = "34,6%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "9")) Then
                        chances1.Text = "32,6%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "9")) Then
                        chances1.Text = "30,6%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "9")) Then
                        chances1.Text = "28,5%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "9")) Then
                        chances1.Text = "26,7%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "9")) Then
                        chances1.Text = "26,3%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "9")) Then
                        chances1.Text = "25,4%"
                    End If

                    If ((carta1valor.Text = "8") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "8")) Then
                        chances1.Text = "32,3%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "8")) Then
                        chances1.Text = "30,5%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "8")) Then
                        chances1.Text = "28,7%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "8")) Then
                        chances1.Text = "26,7%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "8")) Then
                        chances1.Text = "24,7%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "8")) Then
                        chances1.Text = "24,3%"
                    End If

                    If ((carta1valor.Text = "7") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "7")) Then
                        chances1.Text = "30,5%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "7")) Then
                        chances1.Text = "28,5%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "7")) Then
                        chances1.Text = "26,6%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "7")) Then
                        chances1.Text = "24,9%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "7")) Then
                        chances1.Text = "23,1%"
                    End If

                    If ((carta1valor.Text = "6") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "6")) Then
                        chances1.Text = "28,7%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "6")) Then
                        chances1.Text = "26,9%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "6")) Then
                        chances1.Text = "25,5%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "6")) Then
                        chances1.Text = "23,3%"
                    End If

                    If ((carta1valor.Text = "5") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "5")) Then
                        chances1.Text = "27,5%"
                    End If
                    If ((carta1valor.Text = "5") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "5")) Then
                        chances1.Text = "25,9%"
                    End If
                    If ((carta1valor.Text = "5") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "5")) Then
                        chances1.Text = "23,9%"
                    End If

                    If ((carta1valor.Text = "4") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "4")) Then
                        chances1.Text = "25,2%"
                    End If
                    If ((carta1valor.Text = "4") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "4")) Then
                        chances1.Text = "23,3%"
                    End If

                    If ((carta1valor.Text = "3") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "3")) Then
                        chances1.Text = "22,3%"
                    End If
                    cartas.Show()
                    Me.Hide()
                End If



                If jogadores1.Text = 4 Then
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "A")) Then
                        chances1.Text = "63,2%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "K")) Then
                        chances1.Text = "57,8%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "53,3%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "J")) Then
                        chances1.Text = "48,6%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "10")) Then
                        chances1.Text = "44,7%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "9")) Then
                        chances1.Text = "40,6%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "8")) Then
                        chances1.Text = "37,6%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "7")) Then
                        chances1.Text = "34,3%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "6")) Then
                        chances1.Text = "31,2%"
                    End If
                    If ((carta1valor.Text = "5") And (carta2valor.Text = "5")) Then
                        chances1.Text = "28,6%"
                    End If
                    If ((carta1valor.Text = "4") And (carta2valor.Text = "4")) Then
                        chances1.Text = "25,9%"
                    End If
                    If ((carta1valor.Text = "3") And (carta2valor.Text = "3")) Then
                        chances1.Text = "23,4%"
                    End If
                    If ((carta1valor.Text = "2") And (carta2valor.Text = "2")) Then
                        chances1.Text = "21,9%"
                    End If

                    If ((carta1valor.Text = "A") And (carta2valor.Text = "K")) Or ((carta1valor.Text = "K") And (carta2valor.Text = "A")) Then
                        chances1.Text = "40,5%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "Q")) Or ((carta1valor.Text = "Q") And (carta2valor.Text = "A")) Then
                        chances1.Text = "38,8%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "J")) Or ((carta1valor.Text = "J") And (carta2valor.Text = "A")) Then
                        chances1.Text = "37,4%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "A")) Then
                        chances1.Text = "35,8%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "A")) Then
                        chances1.Text = "32,9%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "A")) Then
                        chances1.Text = "32%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "A")) Then
                        chances1.Text = "30,7%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "A")) Then
                        chances1.Text = "29,4%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "A")) Then
                        chances1.Text = "30,2%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "A")) Then
                        chances1.Text = "28,9%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "A")) Then
                        chances1.Text = "28,4%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "A")) Then
                        chances1.Text = "27,6%"
                    End If

                    If ((carta1valor.Text = "K") And (carta2valor.Text = "Q")) Or ((carta1valor.Text = "Q") And (carta2valor.Text = "K")) Then
                        chances1.Text = "37,4%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "J")) Or ((carta1valor.Text = "J") And (carta2valor.Text = "K")) Then
                        chances1.Text = "35,6%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "K")) Then
                        chances1.Text = "34,5%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "K")) Then
                        chances1.Text = "31,7%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "K")) Then
                        chances1.Text = "29%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "K")) Then
                        chances1.Text = "28,4%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "K")) Then
                        chances1.Text = "27,4%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "K")) Then
                        chances1.Text = "26,5%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "K")) Then
                        chances1.Text = "25,9%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "K")) Then
                        chances1.Text = "25,1%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "K")) Then
                        chances1.Text = "24,4%"
                    End If

                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "J")) Or ((carta1valor.Text = "J") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "34,7%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "33,4%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "30,4%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "28,3%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "26,2%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "25,5%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "24,7%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "23,9%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "23,3%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "23%"
                    End If

                    If ((carta1valor.Text = "J") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "J")) Then
                        chances1.Text = "32,7%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "J")) Then
                        chances1.Text = "29,7%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "J")) Then
                        chances1.Text = "27,6%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "J")) Then
                        chances1.Text = "25,8%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "J")) Then
                        chances1.Text = "23,8%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "J")) Then
                        chances1.Text = "23%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "J")) Then
                        chances1.Text = "22,6%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "J")) Then
                        chances1.Text = "21,6%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "J")) Then
                        chances1.Text = "21,3%"
                    End If

                    If ((carta1valor.Text = "10") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "10")) Then
                        chances1.Text = "29,8%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "10")) Then
                        chances1.Text = "27,6%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "10")) Then
                        chances1.Text = "25,3%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "10")) Then
                        chances1.Text = "23,5%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "10")) Then
                        chances1.Text = "22%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "10")) Then
                        chances1.Text = "21,3%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "10")) Then
                        chances1.Text = "20,7%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "10")) Then
                        chances1.Text = "20%"
                    End If

                    If ((carta1valor.Text = "9") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "9")) Then
                        chances1.Text = "27,1%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "9")) Then
                        chances1.Text = "25,2%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "9")) Then
                        chances1.Text = "23,4%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "9")) Then
                        chances1.Text = "21,6%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "9")) Then
                        chances1.Text = "20%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "9")) Then
                        chances1.Text = "19,5%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "9")) Then
                        chances1.Text = "19,1%"
                    End If

                    If ((carta1valor.Text = "8") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "8")) Then
                        chances1.Text = "25,6%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "8")) Then
                        chances1.Text = "23,3%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "8")) Then
                        chances1.Text = "22%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "8")) Then
                        chances1.Text = "20,4%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "8")) Then
                        chances1.Text = "18,5%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "8")) Then
                        chances1.Text = "18,3%"
                    End If

                    If ((carta1valor.Text = "7") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "7")) Then
                        chances1.Text = "23,7%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "7")) Then
                        chances1.Text = "22%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "7")) Then
                        chances1.Text = "20,3%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "7")) Then
                        chances1.Text = "19%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "7")) Then
                        chances1.Text = "17,4%"
                    End If

                    If ((carta1valor.Text = "6") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "6")) Then
                        chances1.Text = "22,4%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "6")) Then
                        chances1.Text = "20,9%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "6")) Then
                        chances1.Text = "19,6%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "6")) Then
                        chances1.Text = "18%"
                    End If

                    If ((carta1valor.Text = "5") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "5")) Then
                        chances1.Text = "21,6%"
                    End If
                    If ((carta1valor.Text = "5") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "5")) Then
                        chances1.Text = "20%"
                    End If
                    If ((carta1valor.Text = "5") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "5")) Then
                        chances1.Text = "18,2%"
                    End If

                    If ((carta1valor.Text = "4") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "4")) Then
                        chances1.Text = "19,3%"
                    End If
                    If ((carta1valor.Text = "4") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "4")) Then
                        chances1.Text = "17,7%"
                    End If

                    If ((carta1valor.Text = "3") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "3")) Then
                        chances1.Text = "17,1%"
                    End If
                    cartas.Show()
                    Me.Hide()
                End If



                If jogadores1.Text = 5 Then
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "A")) Then
                        chances1.Text = "55,5%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "K")) Then
                        chances1.Text = "49,7%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "44,5%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "J")) Then
                        chances1.Text = "40%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "10")) Then
                        chances1.Text = "35,9%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "9")) Then
                        chances1.Text = "32,1%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "8")) Then
                        chances1.Text = "29,4%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "7")) Then
                        chances1.Text = "26,5%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "6")) Then
                        chances1.Text = "24%"
                    End If
                    If ((carta1valor.Text = "5") And (carta2valor.Text = "5")) Then
                        chances1.Text = "22%"
                    End If
                    If ((carta1valor.Text = "4") And (carta2valor.Text = "4")) Then
                        chances1.Text = "20,4%"
                    End If
                    If ((carta1valor.Text = "3") And (carta2valor.Text = "3")) Then
                        chances1.Text = "18,9%"
                    End If
                    If ((carta1valor.Text = "2") And (carta2valor.Text = "2")) Then
                        chances1.Text = "17,5%"
                    End If

                    If ((carta1valor.Text = "A") And (carta2valor.Text = "K")) Or ((carta1valor.Text = "K") And (carta2valor.Text = "A")) Then
                        chances1.Text = "34,5%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "Q")) Or ((carta1valor.Text = "Q") And (carta2valor.Text = "A")) Then
                        chances1.Text = "32,2%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "J")) Or ((carta1valor.Text = "J") And (carta2valor.Text = "A")) Then
                        chances1.Text = "31,1%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "A")) Then
                        chances1.Text = "29,8%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "A")) Then
                        chances1.Text = "27%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "A")) Then
                        chances1.Text = "25,7%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "A")) Then
                        chances1.Text = "24,9%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "A")) Then
                        chances1.Text = "23,7%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "A")) Then
                        chances1.Text = "24,3%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "A")) Then
                        chances1.Text = "23,3%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "A")) Then
                        chances1.Text = "23,2%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "A")) Then
                        chances1.Text = "22,4%"
                    End If

                    If ((carta1valor.Text = "K") And (carta2valor.Text = "Q")) Or ((carta1valor.Text = "Q") And (carta2valor.Text = "K")) Then
                        chances1.Text = "31,4%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "J")) Or ((carta1valor.Text = "J") And (carta2valor.Text = "K")) Then
                        chances1.Text = "29,9%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "K")) Then
                        chances1.Text = "28,6%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "K")) Then
                        chances1.Text = "25,8%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "K")) Then
                        chances1.Text = "23,5%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "K")) Then
                        chances1.Text = "22,9%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "K")) Then
                        chances1.Text = "21,9%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "K")) Then
                        chances1.Text = "21,3%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "K")) Then
                        chances1.Text = "20,8%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "K")) Then
                        chances1.Text = "20,2%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "K")) Then
                        chances1.Text = "20,1%"
                    End If

                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "J")) Or ((carta1valor.Text = "J") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "29,1%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "28,1%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "25,2%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "23,1%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "21,2%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "20,4%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "19,8%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "19,6%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "18,9%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "18,5%"
                    End If

                    If ((carta1valor.Text = "J") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "J")) Then
                        chances1.Text = "27,4%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "J")) Then
                        chances1.Text = "24,7%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "J")) Then
                        chances1.Text = "22,7%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "J")) Then
                        chances1.Text = "20,9%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "J")) Then
                        chances1.Text = "19,1%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "J")) Then
                        chances1.Text = "18,4%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "J")) Then
                        chances1.Text = "18,1%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "J")) Then
                        chances1.Text = "17,7%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "J")) Then
                        chances1.Text = "17,2%"
                    End If

                    If ((carta1valor.Text = "10") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "10")) Then
                        chances1.Text = "24,7%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "10")) Then
                        chances1.Text = "22,7%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "10")) Then
                        chances1.Text = "21%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "10")) Then
                        chances1.Text = "19%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "10")) Then
                        chances1.Text = "17,3%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "10")) Then
                        chances1.Text = "17%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "10")) Then
                        chances1.Text = "16,6%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "10")) Then
                        chances1.Text = "16,2%"
                    End If

                    If ((carta1valor.Text = "9") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "9")) Then
                        chances1.Text = "22,5%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "9")) Then
                        chances1.Text = "20,5%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "9")) Then
                        chances1.Text = "19,1%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "9")) Then
                        chances1.Text = "17,4%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "9")) Then
                        chances1.Text = "16%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "9")) Then
                        chances1.Text = "15,7%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "9")) Then
                        chances1.Text = "15,4%"
                    End If

                    If ((carta1valor.Text = "8") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "8")) Then
                        chances1.Text = "20,9%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "8")) Then
                        chances1.Text = "19,2%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "8")) Then
                        chances1.Text = "17,8%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "8")) Then
                        chances1.Text = "16,2%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "8")) Then
                        chances1.Text = "15%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "8")) Then
                        chances1.Text = "14,8%"
                    End If

                    If ((carta1valor.Text = "7") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "7")) Then
                        chances1.Text = "19,3%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "7")) Then
                        chances1.Text = "18,2%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "7")) Then
                        chances1.Text = "16,7%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "7")) Then
                        chances1.Text = "15,2%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "7")) Then
                        chances1.Text = "14,1%"
                    End If

                    If ((carta1valor.Text = "6") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "6")) Then
                        chances1.Text = "18,4%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "6")) Then
                        chances1.Text = "17,2%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "6")) Then
                        chances1.Text = "15,9%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "6")) Then
                        chances1.Text = "14,5%"
                    End If

                    If ((carta1valor.Text = "5") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "5")) Then
                        chances1.Text = "17,9%"
                    End If
                    If ((carta1valor.Text = "5") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "5")) Then
                        chances1.Text = "16,4%"
                    End If
                    If ((carta1valor.Text = "5") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "5")) Then
                        chances1.Text = "15,2%"
                    End If

                    If ((carta1valor.Text = "4") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "4")) Then
                        chances1.Text = "16%"
                    End If
                    If ((carta1valor.Text = "4") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "4")) Then
                        chances1.Text = "14,7%"
                    End If

                    If ((carta1valor.Text = "3") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "3")) Then
                        chances1.Text = "14,1%"
                    End If
                    cartas.Show()
                    Me.Hide()
                End If



                If jogadores1.Text = 6 Then
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "A")) Then
                        chances1.Text = "49,1%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "K")) Then
                        chances1.Text = "42,8%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "37,7%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "J")) Then
                        chances1.Text = "33,2%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "10")) Then
                        chances1.Text = "29,4%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "9")) Then
                        chances1.Text = "26,2%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "8")) Then
                        chances1.Text = "23,7%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "7")) Then
                        chances1.Text = "21,6%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "6")) Then
                        chances1.Text = "19,8%"
                    End If
                    If ((carta1valor.Text = "5") And (carta2valor.Text = "5")) Then
                        chances1.Text = "18,1%"
                    End If
                    If ((carta1valor.Text = "4") And (carta2valor.Text = "4")) Then
                        chances1.Text = "16,9%"
                    End If
                    If ((carta1valor.Text = "3") And (carta2valor.Text = "3")) Then
                        chances1.Text = "16,1%"
                    End If
                    If ((carta1valor.Text = "2") And (carta2valor.Text = "2")) Then
                        chances1.Text = "15,5%"
                    End If

                    If ((carta1valor.Text = "A") And (carta2valor.Text = "K")) Or ((carta1valor.Text = "K") And (carta2valor.Text = "A")) Then
                        chances1.Text = "30,2%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "Q")) Or ((carta1valor.Text = "Q") And (carta2valor.Text = "A")) Then
                        chances1.Text = "28,3%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "J")) Or ((carta1valor.Text = "J") And (carta2valor.Text = "A")) Then
                        chances1.Text = "26,7%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "A")) Then
                        chances1.Text = "25,4%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "A")) Then
                        chances1.Text = "22,8%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "A")) Then
                        chances1.Text = "21,7%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "A")) Then
                        chances1.Text = "20,9%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "A")) Then
                        chances1.Text = "19,9%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "A")) Then
                        chances1.Text = "20,5%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "A")) Then
                        chances1.Text = "20,1%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "A")) Then
                        chances1.Text = "19,6%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "A")) Then
                        chances1.Text = "18,8%"
                    End If

                    If ((carta1valor.Text = "K") And (carta2valor.Text = "Q")) Or ((carta1valor.Text = "Q") And (carta2valor.Text = "K")) Then
                        chances1.Text = "27,3%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "J")) Or ((carta1valor.Text = "J") And (carta2valor.Text = "K")) Then
                        chances1.Text = "25,9%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "K")) Then
                        chances1.Text = "24,4%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "K")) Then
                        chances1.Text = "22%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "K")) Then
                        chances1.Text = "20%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "K")) Then
                        chances1.Text = "19,5%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "K")) Then
                        chances1.Text = "18,7%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "K")) Then
                        chances1.Text = "18%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "K")) Then
                        chances1.Text = "17,5%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "K")) Then
                        chances1.Text = "17,3%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "K")) Then
                        chances1.Text = "16,8%"
                    End If

                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "J")) Or ((carta1valor.Text = "J") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "24,9%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "23,9%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "21,3%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "19,6%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "17,7%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "17,1%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "16,5%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "16,2%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "16%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "15,4%"
                    End If

                    If ((carta1valor.Text = "J") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "J")) Then
                        chances1.Text = "23,6%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "J")) Then
                        chances1.Text = "21,2%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "J")) Then
                        chances1.Text = "19,3%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "J")) Then
                        chances1.Text = "17,6%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "J")) Then
                        chances1.Text = "15,9%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "J")) Then
                        chances1.Text = "15,8%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "J")) Then
                        chances1.Text = "14,9%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "J")) Then
                        chances1.Text = "14,8%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "J")) Then
                        chances1.Text = "14,4%"
                    End If

                    If ((carta1valor.Text = "10") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "10")) Then
                        chances1.Text = "21,2%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "10")) Then
                        chances1.Text = "19,4%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "10")) Then
                        chances1.Text = "17,7%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "10")) Then
                        chances1.Text = "16%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "10")) Then
                        chances1.Text = "14,4%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "10")) Then
                        chances1.Text = "14,3%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "10")) Then
                        chances1.Text = "13,9%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "10")) Then
                        chances1.Text = "13,4%"
                    End If

                    If ((carta1valor.Text = "9") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "9")) Then
                        chances1.Text = "19%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "9")) Then
                        chances1.Text = "17,7%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "9")) Then
                        chances1.Text = "16,2%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "9")) Then
                        chances1.Text = "14,7%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "9")) Then
                        chances1.Text = "13,4%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "9")) Then
                        chances1.Text = "13,2%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "9")) Then
                        chances1.Text = "12,7%"
                    End If

                    If ((carta1valor.Text = "8") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "8")) Then
                        chances1.Text = "17,7%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "8")) Then
                        chances1.Text = "16,4%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "8")) Then
                        chances1.Text = "15,2%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "8")) Then
                        chances1.Text = "13,8%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "8")) Then
                        chances1.Text = "12,6%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "8")) Then
                        chances1.Text = "12,4%"
                    End If

                    If ((carta1valor.Text = "7") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "7")) Then
                        chances1.Text = "16,8%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "7")) Then
                        chances1.Text = "15,6%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "7")) Then
                        chances1.Text = "14,6%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "7")) Then
                        chances1.Text = "13,1%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "7")) Then
                        chances1.Text = "11,9%"
                    End If

                    If ((carta1valor.Text = "6") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "6")) Then
                        chances1.Text = "15,8%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "6")) Then
                        chances1.Text = "14,9%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "6")) Then
                        chances1.Text = "13,7%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "6")) Then
                        chances1.Text = "12,5%"
                    End If

                    If ((carta1valor.Text = "5") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "5")) Then
                        chances1.Text = "15,4%"
                    End If
                    If ((carta1valor.Text = "5") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "5")) Then
                        chances1.Text = "14,5%"
                    End If
                    If ((carta1valor.Text = "5") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "5")) Then
                        chances1.Text = "13,3%"
                    End If

                    If ((carta1valor.Text = "4") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "4")) Then
                        chances1.Text = "13,7"
                    End If
                    If ((carta1valor.Text = "4") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "4")) Then
                        chances1.Text = "12,6%"
                    End If

                    If ((carta1valor.Text = "3") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "3")) Then
                        chances1.Text = "12,3%"
                    End If
                    cartas.Show()
                    Me.Hide()
                End If



                If jogadores1.Text = 7 Then
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "A")) Then
                        chances1.Text = "43,1%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "K")) Then
                        chances1.Text = "37,1%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "32,2%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "J")) Then
                        chances1.Text = "28,2%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "10")) Then
                        chances1.Text = "24,9%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "9")) Then
                        chances1.Text = "22,1%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "8")) Then
                        chances1.Text = "20%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "7")) Then
                        chances1.Text = "18%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "6")) Then
                        chances1.Text = "16,5%"
                    End If
                    If ((carta1valor.Text = "5") And (carta2valor.Text = "5")) Then
                        chances1.Text = "15,5%"
                    End If
                    If ((carta1valor.Text = "4") And (carta2valor.Text = "4")) Then
                        chances1.Text = "14,8%"
                    End If
                    If ((carta1valor.Text = "3") And (carta2valor.Text = "3")) Then
                        chances1.Text = "14,5%"
                    End If
                    If ((carta1valor.Text = "2") And (carta2valor.Text = "2")) Then
                        chances1.Text = "13,9%"
                    End If

                    If ((carta1valor.Text = "A") And (carta2valor.Text = "K")) Or ((carta1valor.Text = "K") And (carta2valor.Text = "A")) Then
                        chances1.Text = "26,9%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "Q")) Or ((carta1valor.Text = "Q") And (carta2valor.Text = "A")) Then
                        chances1.Text = "25,1%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "J")) Or ((carta1valor.Text = "J") And (carta2valor.Text = "A")) Then
                        chances1.Text = "23,4%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "A")) Then
                        chances1.Text = "22%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "A")) Then
                        chances1.Text = "19,7%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "A")) Then
                        chances1.Text = "18,7%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "A")) Then
                        chances1.Text = "18%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "A")) Then
                        chances1.Text = "17,5%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "A")) Then
                        chances1.Text = "18%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "A")) Then
                        chances1.Text = "17,4%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "A")) Then
                        chances1.Text = "17,2%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "A")) Then
                        chances1.Text = "16,9%"
                    End If

                    If ((carta1valor.Text = "K") And (carta2valor.Text = "Q")) Or ((carta1valor.Text = "Q") And (carta2valor.Text = "K")) Then
                        chances1.Text = "24,3%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "J")) Or ((carta1valor.Text = "J") And (carta2valor.Text = "K")) Then
                        chances1.Text = "22,8%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "K")) Then
                        chances1.Text = "21,7%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "K")) Then
                        chances1.Text = "19,3%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "K")) Then
                        chances1.Text = "17,3%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "K")) Then
                        chances1.Text = "16,7%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "K")) Then
                        chances1.Text = "16,1%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "K")) Then
                        chances1.Text = "15,5%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "K")) Then
                        chances1.Text = "15,2%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "K")) Then
                        chances1.Text = "14,9%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "K")) Then
                        chances1.Text = "14,7%"
                    End If

                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "J")) Or ((carta1valor.Text = "J") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "22,2%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "21,1%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "18,8%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "16,9%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "15,6%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "14,9%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "14,4%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "14%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "13,8%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "13,5%"
                    End If

                    If ((carta1valor.Text = "J") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "J")) Then
                        chances1.Text = "20,9%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "J")) Then
                        chances1.Text = "18,6%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "J")) Then
                        chances1.Text = "16,7%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "J")) Then
                        chances1.Text = "15,1%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "J")) Then
                        chances1.Text = "13,6%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "J")) Then
                        chances1.Text = "13,3%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "J")) Then
                        chances1.Text = "13%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "J")) Then
                        chances1.Text = "12,8%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "J")) Then
                        chances1.Text = "12,7%"
                    End If

                    If ((carta1valor.Text = "10") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "10")) Then
                        chances1.Text = "18,3%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "10")) Then
                        chances1.Text = "16,9%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "10")) Then
                        chances1.Text = "15,2%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "10")) Then
                        chances1.Text = "13,7%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "10")) Then
                        chances1.Text = "12,6%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "10")) Then
                        chances1.Text = "12,4%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "10")) Then
                        chances1.Text = "12,1%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "10")) Then
                        chances1.Text = "12%"
                    End If

                    If ((carta1valor.Text = "9") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "9")) Then
                        chances1.Text = "16,7%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "9")) Then
                        chances1.Text = "15,2%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "9")) Then
                        chances1.Text = "13,9%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "9")) Then
                        chances1.Text = "12,6%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "9")) Then
                        chances1.Text = "11,5%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "9")) Then
                        chances1.Text = "11,3%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "9")) Then
                        chances1.Text = "11,3%"
                    End If

                    If ((carta1valor.Text = "8") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "8")) Then
                        chances1.Text = "15,4%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "8")) Then
                        chances1.Text = "14,5%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "8")) Then
                        chances1.Text = "13%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "8")) Then
                        chances1.Text = "12%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "8")) Then
                        chances1.Text = "10,8%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "8")) Then
                        chances1.Text = "10,7%"
                    End If

                    If ((carta1valor.Text = "7") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "7")) Then
                        chances1.Text = "14,8%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "7")) Then
                        chances1.Text = "13,8%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "7")) Then
                        chances1.Text = "12,5%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "7")) Then
                        chances1.Text = "11,3%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "7")) Then
                        chances1.Text = "10,4%"
                    End If

                    If ((carta1valor.Text = "6") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "6")) Then
                        chances1.Text = "14,1%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "6")) Then
                        chances1.Text = "13,1%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "6")) Then
                        chances1.Text = "12,1%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "6")) Then
                        chances1.Text = "10,9%"
                    End If

                    If ((carta1valor.Text = "5") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "5")) Then
                        chances1.Text = "13,5%"
                    End If
                    If ((carta1valor.Text = "5") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "5")) Then
                        chances1.Text = "12,7%"
                    End If
                    If ((carta1valor.Text = "5") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "5")) Then
                        chances1.Text = "11,7%"
                    End If

                    If ((carta1valor.Text = "4") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "4")) Then
                        chances1.Text = "12,3"
                    End If
                    If ((carta1valor.Text = "4") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "4")) Then
                        chances1.Text = "11,4%"
                    End If

                    If ((carta1valor.Text = "3") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "3")) Then
                        chances1.Text = "11%"
                    End If
                    cartas.Show()
                    Me.Hide()
                End If



                If jogadores1.Text = 8 Then
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "A")) Then
                        chances1.Text = "38,2%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "K")) Then
                        chances1.Text = "32,6%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "28%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "J")) Then
                        chances1.Text = "24,2%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "10")) Then
                        chances1.Text = "21,4%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "9")) Then
                        chances1.Text = "19,1%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "8")) Then
                        chances1.Text = "17,3%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "7")) Then
                        chances1.Text = "15,9%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "6")) Then
                        chances1.Text = "15%"
                    End If
                    If ((carta1valor.Text = "5") And (carta2valor.Text = "5")) Then
                        chances1.Text = "14,1%"
                    End If
                    If ((carta1valor.Text = "4") And (carta2valor.Text = "4")) Then
                        chances1.Text = "13,6%"
                    End If
                    If ((carta1valor.Text = "3") And (carta2valor.Text = "3")) Then
                        chances1.Text = "13,2%"
                    End If
                    If ((carta1valor.Text = "2") And (carta2valor.Text = "2")) Then
                        chances1.Text = "13,1%"
                    End If

                    If ((carta1valor.Text = "A") And (carta2valor.Text = "K")) Or ((carta1valor.Text = "K") And (carta2valor.Text = "A")) Then
                        chances1.Text = "24,1%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "Q")) Or ((carta1valor.Text = "Q") And (carta2valor.Text = "A")) Then
                        chances1.Text = "22%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "J")) Or ((carta1valor.Text = "J") And (carta2valor.Text = "A")) Then
                        chances1.Text = "20,8%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "A")) Then
                        chances1.Text = "19,7%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "A")) Then
                        chances1.Text = "17,3%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "A")) Then
                        chances1.Text = "16,5%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "A")) Then
                        chances1.Text = "15,9%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "A")) Then
                        chances1.Text = "15,3%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "A")) Then
                        chances1.Text = "16%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "A")) Then
                        chances1.Text = "15,7%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "A")) Then
                        chances1.Text = "15,3%"
                    End If
                    If ((carta1valor.Text = "A") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "A")) Then
                        chances1.Text = "14,9%"
                    End If

                    If ((carta1valor.Text = "K") And (carta2valor.Text = "Q")) Or ((carta1valor.Text = "Q") And (carta2valor.Text = "K")) Then
                        chances1.Text = "21,7%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "J")) Or ((carta1valor.Text = "J") And (carta2valor.Text = "K")) Then
                        chances1.Text = "20,1%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "K")) Then
                        chances1.Text = "19,2%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "K")) Then
                        chances1.Text = "17%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "K")) Then
                        chances1.Text = "15,2%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "K")) Then
                        chances1.Text = "14,7%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "K")) Then
                        chances1.Text = "14,1%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "K")) Then
                        chances1.Text = "13,9%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "K")) Then
                        chances1.Text = "13,4%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "K")) Then
                        chances1.Text = "13,2%"
                    End If
                    If ((carta1valor.Text = "K") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "K")) Then
                        chances1.Text = "13,2%"
                    End If

                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "J")) Or ((carta1valor.Text = "J") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "19,6%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "18,7%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "16,6%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "14,7%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "13,5%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "13%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "12,6%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "12,3%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "12,2%"
                    End If
                    If ((carta1valor.Text = "Q") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "Q")) Then
                        chances1.Text = "12,2%"
                    End If

                    If ((carta1valor.Text = "J") And (carta2valor.Text = "10")) Or ((carta1valor.Text = "10") And (carta2valor.Text = "J")) Then
                        chances1.Text = "18,5%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "J")) Then
                        chances1.Text = "16,4%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "J")) Then
                        chances1.Text = "14,6%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "J")) Then
                        chances1.Text = "13,3%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "J")) Then
                        chances1.Text = "12,1%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "J")) Then
                        chances1.Text = "11,6%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "J")) Then
                        chances1.Text = "11,8%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "J")) Then
                        chances1.Text = "11,5%"
                    End If
                    If ((carta1valor.Text = "J") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "J")) Then
                        chances1.Text = "11,4%"
                    End If

                    If ((carta1valor.Text = "10") And (carta2valor.Text = "9")) Or ((carta1valor.Text = "9") And (carta2valor.Text = "10")) Then
                        chances1.Text = "16,5%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "10")) Then
                        chances1.Text = "14,9%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "10")) Then
                        chances1.Text = "13,6%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "10")) Then
                        chances1.Text = "12,2%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "10")) Then
                        chances1.Text = "11%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "10")) Then
                        chances1.Text = "10,8%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "10")) Then
                        chances1.Text = "10,9%"
                    End If
                    If ((carta1valor.Text = "10") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "10")) Then
                        chances1.Text = "10,5%"
                    End If

                    If ((carta1valor.Text = "9") And (carta2valor.Text = "8")) Or ((carta1valor.Text = "8") And (carta2valor.Text = "9")) Then
                        chances1.Text = "14,9%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "9")) Then
                        chances1.Text = "13,8%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "9")) Then
                        chances1.Text = "12,5%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "9")) Then
                        chances1.Text = "11,2%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "9")) Then
                        chances1.Text = "10,4%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "9")) Then
                        chances1.Text = "10,2%"
                    End If
                    If ((carta1valor.Text = "9") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "9")) Then
                        chances1.Text = "10%"
                    End If

                    If ((carta1valor.Text = "8") And (carta2valor.Text = "7")) Or ((carta1valor.Text = "7") And (carta2valor.Text = "8")) Then
                        chances1.Text = "13,9%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "8")) Then
                        chances1.Text = "12,9%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "8")) Then
                        chances1.Text = "11,9%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "8")) Then
                        chances1.Text = "10,7%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "8")) Then
                        chances1.Text = "9,9%"
                    End If
                    If ((carta1valor.Text = "8") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "8")) Then
                        chances1.Text = "9,7%"
                    End If

                    If ((carta1valor.Text = "7") And (carta2valor.Text = "6")) Or ((carta1valor.Text = "6") And (carta2valor.Text = "7")) Then
                        chances1.Text = "13,3%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "7")) Then
                        chances1.Text = "12,3%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "7")) Then
                        chances1.Text = "11,1%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "7")) Then
                        chances1.Text = "10,2%"
                    End If
                    If ((carta1valor.Text = "7") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "7")) Then
                        chances1.Text = "9,3%"
                    End If

                    If ((carta1valor.Text = "6") And (carta2valor.Text = "5")) Or ((carta1valor.Text = "5") And (carta2valor.Text = "6")) Then
                        chances1.Text = "12,8%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "6")) Then
                        chances1.Text = "11,9%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "6")) Then
                        chances1.Text = "10,7%"
                    End If
                    If ((carta1valor.Text = "6") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "6")) Then
                        chances1.Text = "9,9%"
                    End If

                    If ((carta1valor.Text = "5") And (carta2valor.Text = "4")) Or ((carta1valor.Text = "4") And (carta2valor.Text = "5")) Then
                        chances1.Text = "12,3%"
                    End If
                    If ((carta1valor.Text = "5") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "5")) Then
                        chances1.Text = "11,8%"
                    End If
                    If ((carta1valor.Text = "5") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "5")) Then
                        chances1.Text = "10,7%"
                    End If

                    If ((carta1valor.Text = "4") And (carta2valor.Text = "3")) Or ((carta1valor.Text = "3") And (carta2valor.Text = "4")) Then
                        chances1.Text = "11,2"
                    End If
                    If ((carta1valor.Text = "4") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "4")) Then
                        chances1.Text = "10,5%"
                    End If

                    If ((carta1valor.Text = "3") And (carta2valor.Text = "2")) Or ((carta1valor.Text = "2") And (carta2valor.Text = "3")) Then
                        chances1.Text = "10,3%"
                    End If
                    cartas.Show()
                    Me.Hide()
                End If
            End If
            End If

    End Sub

    Private Sub carta1simbolo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles carta1simbolo.TextChanged
        carta1valor.Enabled = True
        If carta1simbolo.Text = "♠ Espadas" Then
            carta1valor.Items.Clear()
            carta1valor.Items.AddRange(New String() {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"})
        End If

        If carta1simbolo.Text = "♣ Paus" Then
            carta1valor.Items.Clear()
            carta1valor.Items.AddRange(New String() {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"})
        End If

        If carta1simbolo.Text = "♥ Copas" Then
            carta1valor.Items.Clear()
            carta1valor.Items.AddRange(New String() {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"})
        End If

        If carta1simbolo.Text = "♦ Ouros" Then
            carta1valor.Items.Clear()
            carta1valor.Items.AddRange(New String() {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"})
        End If

    End Sub

    Private Sub carta2simbolo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles carta2simbolo.TextChanged
        carta2valor.Enabled = True
        If carta2simbolo.Text = "♠ Espadas" Then
            carta2valor.Items.Clear()
            carta2valor.Items.AddRange(New String() {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"})
        End If

        If carta2simbolo.Text = "♣ Paus" Then
            carta2valor.Items.Clear()
            carta2valor.Items.AddRange(New String() {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"})
        End If

        If carta2simbolo.Text = "♥ Copas" Then
            carta2valor.Items.Clear()
            carta2valor.Items.AddRange(New String() {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"})
        End If

        If carta2simbolo.Text = "♦ Ouros" Then
            carta2valor.Items.Clear()
            carta2valor.Items.AddRange(New String() {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"})
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("Em construção")
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Key As Integer
        Key = Int(Rnd() * 4)
        Select Case Key
            Case 0
                carta1simbolo.Text = "♠ Espadas"
            Case 1
                carta1simbolo.Text = "♣ Paus"
            Case 2
                carta1simbolo.Text = "♥ Copas"
            Case 3
                carta1simbolo.Text = "♦ Ouros"
        End Select

        Dim Key2 As Integer
        Key2 = Int(Rnd() * 4)
        Select Case Key2
            Case 0
                carta2simbolo.Text = "♠ Espadas"
            Case 1
                carta2simbolo.Text = "♣ Paus"
            Case 2
                carta2simbolo.Text = "♥ Copas"
            Case 3
                carta2simbolo.Text = "♦ Ouros"
        End Select

        Dim Key3 As Integer
        Key3 = Int(Rnd() * 13)
        Select Case Key3
            Case 0
                carta1valor.Text = "2"
            Case 1
                carta1valor.Text = "3"
            Case 2
                carta1valor.Text = "4"
            Case 3
                carta1valor.Text = "5"
            Case 4
                carta1valor.Text = "6"
            Case 5
                carta1valor.Text = "7"
            Case 6
                carta1valor.Text = "8"
            Case 7
                carta1valor.Text = "9"
            Case 8
                carta1valor.Text = "10"
            Case 9
                carta1valor.Text = "J"
            Case 10
                carta1valor.Text = "Q"
            Case 11
                carta1valor.Text = "K"
            Case 12
                carta1valor.Text = "A"
        End Select

        Dim Key4 As Integer
        Key4 = Int(Rnd() * 13)
        Select Case Key4
            Case 0
                carta2valor.Text = "2"
            Case 1
                carta2valor.Text = "3"
            Case 2
                carta2valor.Text = "4"
            Case 3
                carta2valor.Text = "5"
            Case 4
                carta2valor.Text = "6"
            Case 5
                carta2valor.Text = "7"
            Case 6
                carta2valor.Text = "8"
            Case 7
                carta2valor.Text = "9"
            Case 8
                carta2valor.Text = "10"
            Case 9
                carta2valor.Text = "J"
            Case 10
                carta2valor.Text = "Q"
            Case 11
                carta2valor.Text = "K"
            Case 12
                carta2valor.Text = "A"
        End Select
    End Sub
End Class