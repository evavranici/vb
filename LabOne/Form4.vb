Public Class Form4
    Private Sub btnShowInfo_Click(sender As Object, e As EventArgs) Handles btnShowInfo.Click
        lblName.Text = "Eva Vranici"
        lblStreet.Text = "Dumb Street"
        lblCityStateZip.Text = "Dumb City, State, ZIP"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class