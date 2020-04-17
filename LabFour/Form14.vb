Public Class Form14
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim two = TextBox1.Text.Remove(0, 2)
        Dim first = two.Remove(1, 1)
        Dim second = two.Remove(0, 1)

        If ListBox1.SelectedItem Like first Then
            MessageBox.Show(first)
        End If
    End Sub
End Class