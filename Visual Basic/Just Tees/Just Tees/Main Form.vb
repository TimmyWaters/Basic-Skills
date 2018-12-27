Public Class Form1
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub

    Private Sub calcBtn_Click(sender As Object, e As EventArgs) Handles calcBtn.Click
        Dim subTotal As Double
        Dim quantity As Integer
        Dim preTax As Double
        Dim total As Double

        If womenRadBtn.Checked Then
            subTotal = 17.75
            If pictureCheckBox.Checked Then
                subTotal += 5.0
            End If
            If nameCheckBox.Checked Then
                subTotal += 7.5
            End If
        ElseIf menRadBtn.Checked Then
            If smallRadBtn.Checked Then
                subTotal = 17.75
                If pictureCheckBox.Checked Then
                    subTotal += 5.0
                End If
                If nameCheckBox.Checked Then
                    subTotal += 7.5
                End If
            End If
            If mediumRadBtn.Checked Then
                subTotal = 19.75
                If pictureCheckBox.Checked Then
                    subTotal += 5.0
                End If
                If nameCheckBox.Checked Then
                    subTotal += 7.5
                End If
            End If
            If largeRadBtn.Checked Then
                subTotal = 19.75
                If pictureCheckBox.Checked Then
                    subTotal += 6.0
                End If
                If nameCheckBox.Checked Then
                    subTotal += 7.5
                End If
            End If
        End If
        Integer.TryParse(numOrderedTxtBox.Text, quantity)
        preTax = subTotal * quantity
        total = preTax * 1.02
        priceResultLbl.Text = total.ToString("C2")
    End Sub
End Class
