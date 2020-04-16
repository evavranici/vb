' Name: Exercise 13 Lab 1
' Description:
' Programmer: Eva Vranici

Public Class Form13
    Private Sub btnShowDate_Click(sender As Object, e As EventArgs) Handles btnShowDate.Click
        lblDateString.Text = txtDayOfWeek.Text + ", " + txtMonth.Text + txtDayOfMonth.Text + ", " + txtYear.Text
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtMonth.Text = ""
        txtDayOfMonth.Text = ""
        txtDayOfWeek.Text = ""
        txtYear.Text = ""
        lblDateString.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class