' Name: Exercise 4 Lab 2
' Description: not completed, only the important part is coded
'Programmer: Eva Vranici

Public Class Form6
    Private Sub GenerateAndDisplayIntegers()
        Dim FirstVar As Integer
        Dim SecondVar As Integer
        Dim randomGenerator As New Random

        If RadioButton1.Checked Then
            FirstVar = randomGenerator.Next(1, 11)
            SecondVar = randomGenerator.Next(1, 11)
        Else
            FirstVar = randomGenerator.Next(10, 100)
            SecondVar = randomGenerator.Next(10, 100)
        End If

        If RadioButton4.Checked And FirstVar < SecondVar Then
            Dim intTemp As Integer
            intTemp = FirstVar
            FirstVar = SecondVar
            SecondVar = intTemp
        End If

        TextBox1.Text = FirstVar.ToString
        TextBox2.Text = SecondVar.ToString
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles RadioButton1.Click, RadioButton2.Click
        GenerateAndDisplayIntegers()
    End Sub

    ' send the focus on the textbox of the answer
    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles RadioButton3.Click, RadioButton4.Click
        GenerateAndDisplayIntegers()
        TextBox3.Select()
    End Sub
End Class