Public Class Form16
    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Now.AddDays(6).ToString("dd MMMM yyyy")
        TextBox2.Text = TimeOfDay.ToString("hh:mm:ss")
    End Sub
End Class