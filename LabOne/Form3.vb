' Name: Exercise 3 Lab 1
' Description:
' Programmer: Eva Vranici

Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label11.Text = Val(TextBox6.Text) + Val(TextBox7.Text)
        Label12.Text = FormatCurrency(Val(TextBox6.Text) * 25 + Val(TextBox7.Text) * 40)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        Label11.Text = ""
        Label12.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class