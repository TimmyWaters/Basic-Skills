Public Class MainForm
    Const HOURLY_RATE As Double = 12.0

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        lastNameTextBox.Text = ""
        firstNameTextBox.Text = ""
        hoursTextBox.Text = ""
        amountDueLabel.Text = ""
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim hours As Single
        Dim amount As Single
        Dim isConverted As Boolean
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")

        If Single.TryParse(hoursTextBox.Text, hours) Then
            isConverted = True
            amount = hours * HOURLY_RATE
            amountDueLabel.Text = amount.ToString("C2")
            SAPI.speak(amountDueLabel.Text)
        Else
            isConverted = False
        End If
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
