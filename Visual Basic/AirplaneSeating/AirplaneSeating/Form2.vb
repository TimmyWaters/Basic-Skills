Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passNameLbl.Text = passengerName
        seatNumLbl.Text = seat
        dateLbl.Text = resDateTime
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class