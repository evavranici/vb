' Name: Exercise 6 Lab 1
' Description:
' Programmer: Eva Vranici

Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = Convert.ToDecimal(TextBox1.Text) - Convert.ToDecimal(TextBox2.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class