# POKER
Programa desenvolvido com finalidade de descobrir a porcentagem de chance de vitória no Poker, mais precisamente, em uma rodada do pré-flop. Foi Desenvolvido nas aulas do curso Ciência da Computação na FAM à fim de ganhar horas complementares.

## Implementação futura - Banco de dados para login
```vb
Imports MySql.Data.MySqlClient

Public Class Login

    Dim mydbcon As MySqlConnection
    Dim COMMAND As MySqlCommand


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        mydbcon = New MySqlConnection
        mydbcon.ConnectionString = "server=localhost;userid=root;password=rootword;database=hrdb"
        Dim reader As MySqlDataReader

        Try
            mydbcon.Open()
            Dim Query As String
            Query = String.Format("SELECT * FROM user WHERE username = '{0}' AND password = '{1}'", Me.tbxUsername.Text.Trim(), Me.tbxPassword.Text.Trim())
            COMMAND = New MySqlCommand(Query, mydbcon)
            reader = COMMAND.ExecuteReader

            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1

            End While

            If count = 1 Then
                MessageBox.Show("Username and password are correct")
            ElseIf count > 1 Then
                MessageBox.Show("Username and password are duplicate")
            Else
                MessageBox.Show("Username and password are wrong")
            End If
            mydbcon.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mydbcon.Dispose()
        End Try

    End Sub
```

## Implementação futura - Banco de dados para cadastro
```vb
Imports MySql.Data.MySqlClient
Public Class Form2
	Dim MysqlConn As MySqlConnection
	Dim COMMAND As MySqlCommand

Login_Btn_click(.............)
	MysqlConn = New MySqlConnection
	MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=database"
	Dim READER As MySqlDataReader

	Try
		MysqlConn.Open()
		Dim Query As String
		Query = "insert into database.edata (eid,name,surname,age) values ('"& TextBox_Eid.Text &"','"& TextBox_Name &"','"& TextBox_SName.Text &"','"& TextBox_Age.text &"')"
		COMMAND = New MySqlCommand(Query, MysqlConn)
		READER = COMMAND.ExecuteReader
		

		MessageBox.Show("Data Saved")
		MysqlConn.Close()
		

	Catch ex As MySqlException
		MessageBox.Show(ex.Message)
	Finally
		MysqlConn.Dispose()
	End try
```

## Seriais implantados
DE15R12-8R2J6NS-WTQTUGB-4XZZAT2
DE15R04-KWEU76G-5MK8F9M-Q86DRDE
DE15R96-XPFARTS-Y5XEPV5-GDMGY74
DE15R07-CPRLNAQ-5GPQ7B3-FSZLBQY
DE15R78-E3SNH9C-FLQ847Q-Y7DC84L
DE15R09-2DL5D6X-5LFKTN9-6UD4LMU
DE15R79-632XUNJ-DXKPWEN-3BB37H2
DE15R17-BZQK6XP-74M3KGC-YRUDC9N
DE15R59-9DU3XZT-TNLSPDY-YKSJP3W
DE15R29-4UC9H72-53G8ZE9-B9YXPVC
DE15R21-UDYG3QU-YMQQPNV-SH22TQG
DE15R18-SB3HD5F-2PAYY52-RDKK7BE
DE15R86-52F9S9B-NGR3MQQ-QVTJJJ8
DE15R16-PEW4PAV-HCKVLP9-J4YNGYJ
DE15R05-4MC3NUX-TWXHPFA-KCH4JXE
DE15R96-HH7JF5R-MD585WJ-CBVM5TJ
DE15R35-EBL8NHP-GTMM5FD-23BM5E6
DE15R65-9H9KAV8-U625RGC-5AKJV3A
DE15R76-WLKJ28K-8JFJ2WD-J7H35KC
DE15R16-6S9HXUL-VUS9SQR-YTEYUGN
DE15R81-5WDZHYB-LEK9Z8U-K5LNEEE
DE15R20-4ASMBKS-MEVNZWA-CTKZWCW
DE15R62-8ZF7YCB-KBCSSDV-5W7GY28
DE15R30-YTLTJKQ-9BTBRDW-TE8MXAY
DE15R53-NFDHW28-GWVJSTT-54M4J8W

## Referencias
Botão random
https://www.youtube.com/watch?v=AK_q4jB7xz8

Formulario de login com banco
https://www.youtube.com/watch?v=PUN-0Fx9GQM&index=12

Conectar banco ao VB.NET
https://www.youtube.com/watch?v=9-j7QYzUEz4

Probabilidades de poker
http://www.calculadora-poker.com/maos-iniciais.php

Imagens utilizadas no programa
http://creativecommons.org/publicdomain/zero/1.0/