Public Class Form9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label4.Text = Val(TextBox1.Text) * 25 / 100
        Label5.Text = Format(Val(TextBox1.Text) - Val(Label4.Text), "0.00")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class