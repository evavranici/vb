' Name: Exercise 10 Lab 1
' Description:
' Programmer: Eva Vranici

Public Class Form10
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedItem
            Case "Virginia"
                Label2.Text = "VA"
            Case "North Carolina"
                Label2.Text = "NC"
            Case "South Carolina"
                Label2.Text = "SC"
            Case "Georgia"
                Label2.Text = "GA"
            Case "Alabama"
                Label2.Text = "AL"
            Case "Florida"
                Label2.Text = "FL"
        End Select
    End Sub
End Class