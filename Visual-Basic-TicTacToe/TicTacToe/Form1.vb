Public Class Form1
    Dim turn As Integer

    Private Function winnerValidator(player)

        If btn1.Text = btn2.Text = btn3.Text Or
        btn4.Text = btn5.Text = btn6.Text Or
        btn7.Text = btn8.Text = btn9.Text Or
        btn1.Text = btn4.Text = btn7.Text Or
        btn2.Text = btn5.Text = btn8.Text Or
        btn3.Text = btn6.Text = btn9.Text Or
        btn1.Text = btn5.Text = btn9.Text Or
        btn3.Text = btn5.Text = btn6.Text Then



        End If

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click

        turn = 1

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If turn = 1 Then
            btn1.Text = "X"
            turn = 2
        Else
            btn1.Text = "O"
            turn = 1
        End If
        btn1.Enabled = False
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If turn = 1 Then
            btn2.Text = "X"
            turn = 2
        Else
            btn2.Text = "O"
            turn = 1
        End If
        btn2.Enabled = False

        winnerValidator()
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If turn = 1 Then
            btn3.Text = "X"
            turn = 2
        Else
            btn3.Text = "O"
            turn = 1
        End If
        btn3.Enabled = False
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If turn = 1 Then
            btn4.Text = "X"
            turn = 2
        Else
            btn4.Text = "O"
            turn = 1
        End If
        btn4.Enabled = False
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If turn = 1 Then
            btn5.Text = "X"
            turn = 2
        Else
            btn5.Text = "O"
            turn = 1
        End If
        btn5.Enabled = False
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If turn = 1 Then
            btn6.Text = "X"
            turn = 2
        Else
            btn6.Text = "O"
            turn = 1
        End If
        btn6.Enabled = False
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If turn = 1 Then
            btn7.Text = "X"
            turn = 2
        Else
            btn7.Text = "O"
            turn = 1
        End If
        btn7.Enabled = False
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If turn = 1 Then
            btn8.Text = "X"
            turn = 2
        Else
            btn8.Text = "O"
            turn = 1
        End If
        btn8.Enabled = False
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If turn = 1 Then
            btn9.Text = "X"
            turn = 2
        Else
            btn9.Text = "O"
            turn = 1
        End If
        btn9.Enabled = False
    End Sub
End Class
