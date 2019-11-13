Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged, TextBox1.TextChanged, TextBox3.TextChanged, TextBox4.TextChanged, TextBox5.TextChanged, TextBox6.TextChanged
        If InStr(sender.ToString, "3") > 0 Then
            MessageBox.Show("Record: " & vbCrLf & TextBox1.Text & vbCrLf & " Updated", "Skynet Systems")
            Application.Exit()
        Else

        End If

    End Sub

End Class
