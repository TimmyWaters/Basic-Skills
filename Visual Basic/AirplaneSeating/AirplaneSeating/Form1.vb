Public Class Form1
    Private availableSeats(7) As Boolean
    Private buttons(7) As RadioButton
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim highestSub As Integer = buttons.GetUpperBound(0)
        For i As Integer = 0 To highestSub
            buttons(i) = New RadioButton
            availableSeats(i) = True
        Next i

        buttons(0) = seat10ARadioButton
        buttons(1) = seat10BRadioButton
        buttons(2) = seat11ARadioButton
        buttons(3) = seat11BRadioButton
        buttons(4) = seat12ARadioButton
        buttons(5) = seat12BRadioButton
        buttons(6) = seat13ARadioButton
        buttons(7) = seat13BRadioButton

        For x As Integer = 0 To highestSub
            buttons(x).Checked = False
        Next x
    End Sub

    Private Sub UpdateSeatButtons()
        Dim highestSub As Integer = availableSeats.GetUpperBound(0)
        For i As Integer = 0 To highestSub
            If availableSeats(i) = False Then
                buttons(i).Enabled = False
            End If
        Next i
    End Sub

    Private Function CheckForAvailable() As Boolean
        Dim highestSub As Integer = availableSeats.GetUpperBound(0)
        Dim numAvailable As Integer = 0
        For i As Integer = 0 To highestSub
            If availableSeats(i) = True Then
                numAvailable += 1
            End If
        Next i

        If numAvailable > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub confirmBtn_Click(sender As Object, e As EventArgs) Handles confirmBtn.Click
        Dim highestSub As Integer = buttons.GetUpperBound(0)
        For i As Integer = 0 To highestSub
            If buttons(i).Checked = True Then
                availableSeats(i) = False
                passengerName = passengerNameTxt.Text
                seat = buttons(i).Text
                resDateTime = Date.Now
                Me.Hide()
                Form2.Show()
                Exit For
            End If
        Next i
        UpdateSeatButtons()
        If CheckForAvailable() = False Then
            MessageBox.Show("The flight is full.", "Flight Full", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class
