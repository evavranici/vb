' Name: Exercise 2 Lab 1
' Description:
'Programmer: Eva Vranici

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label4.Text = FormatCurrency(Val(TextBox1.Text) * Val(TextBox2.Text))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class