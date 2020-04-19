' Name: Exercise 4 Lab 2
' Description: not completed, only the important part is coded
'Programmer: Eva Vranici

Public Class Form4
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = True
        If e.KeyChar Like "[0-9]" Or e.KeyChar Like "." OrElse e.KeyChar Like Convert.ToChar(Keys.Back) Then e.Handled = False
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        e.Handled = True
        If e.KeyChar Like "[0-9]" Or e.KeyChar Like "." OrElse e.KeyChar Like Convert.ToChar(Keys.Back) Then e.Handled = False
    End Sub

    ' The case when the error message is displayed in real time while typin
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text < "1" Then MessageBox.Show("Insert a term equal or greater than 1")
    End Sub
End Class