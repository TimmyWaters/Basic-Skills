Public Class Form1
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        ClearAll()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearAll()
        fullRadioButton.Checked = True
        If fullRadioButton.Checked = True Then
            outsidebackRadioButton.Enabled = True
            outsidebackRadioButton.Checked = True
        Else
            outsidebackRadioButton.Enabled = False
        End If
    End Sub

    Private Sub ClearAll()
        fullRadioButton.Checked = True
        halfRadioButton.Checked = False
        quaterRadioButton.Checked = False
        businessRadioButton.Checked = False
        outsidebackRadioButton.Checked = True
        insidebackRadioButton.Checked = False
        insidefrontRadioButton.Checked = False
        interiorRadioButton.Checked = False

        outsidebackRadioButton.Enabled = True
        insidebackRadioButton.Enabled = True
        insidefrontRadioButton.Enabled = True
        interiorRadioButton.Enabled = True

        companyTextBox.Text = ""
        telephoneTextBox.Text = ""
        dateTextBox.Text = ""

        priceLabel.Text = ""
    End Sub

    Private Sub fullRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles fullRadioButton.CheckedChanged
        outsidebackRadioButton.Enabled = True
        insidebackRadioButton.Enabled = True
        insidefrontRadioButton.Enabled = True
        interiorRadioButton.Enabled = True

        outsidebackRadioButton.Checked = True
    End Sub

    Private Sub buisnessRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles businessRadioButton.CheckedChanged
        outsidebackRadioButton.Enabled = False
        insidebackRadioButton.Enabled = False
        insidefrontRadioButton.Enabled = False
        interiorRadioButton.Enabled = False
        interiorRadioButton.Checked = True
    End Sub

    Private Sub halfRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles halfRadioButton.CheckedChanged
        outsidebackRadioButton.Enabled = False
        insidebackRadioButton.Enabled = True
        insidefrontRadioButton.Enabled = True
        interiorRadioButton.Enabled = True
        outsidebackRadioButton.Checked = False
        insidebackRadioButton.Checked = False
        insidefrontRadioButton.Checked = False
        interiorRadioButton.Checked = False
    End Sub

    Private Sub quaterRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles quaterRadioButton.CheckedChanged
        outsidebackRadioButton.Enabled = False
        insidebackRadioButton.Enabled = True
        insidefrontRadioButton.Enabled = True
        interiorRadioButton.Enabled = True
        outsidebackRadioButton.Checked = False
        insidebackRadioButton.Checked = False
        insidefrontRadioButton.Checked = False
        interiorRadioButton.Checked = False
    End Sub

    Private Sub reserveButton_Click(sender As Object, e As EventArgs) Handles reserveButton.Click
        Dim size As Integer
        Dim location As Integer
        If (companyTextBox.Text = "") Then
            MessageBox.Show("Please Enter Company Name")
        ElseIf (telephoneTextBox.Text = "") Then
            MessageBox.Show("Please Enter TelePhone Number")
        ElseIf (dateTextBox.Text = "") Then
            MessageBox.Show("Please Enter Run Date")
        Else
            If fullRadioButton.Checked = True Then
                size = 1
            ElseIf halfRadioButton.Checked = True Then
                size = 2
            ElseIf quaterRadioButton.Checked = True Then
                size = 3
            ElseIf businessRadioButton.Checked = True Then
                size = 4
            End If

            If interiorRadioButton.Checked = True Then
                location = 1
            ElseIf insidefrontRadioButton.Checked = True Then
                location = 2
            ElseIf insidebackRadioButton.Checked = True Then
                location = 3
            Else
                location = 4
            End If
            Dim Ad1 As Ad = New Ad(companyTextBox.Text, telephoneTextBox.Text, size, location, dateTextBox.Text)
            priceLabel.Text = Ad1.final_price.ToString("C2")
        End If
    End Sub
End Class

Public Class Ad
    Private companyname As String
    Private telephone As String
    Private price As Double
    Private cost As Double
    Private location As Double
    Private rundate As String
    Public Sub New(ByVal Cname As String, ByVal telephone As String, ByVal size As Integer, ByVal loc As Integer, rundt As String)
        companyname = Cname
        telephone = telephone
        rundate = rundt

        If (size = 1) Then
            cost = 225
        ElseIf (size = 2) Then
            cost = 225 * 0.65
        ElseIf (size = 3) Then
            cost = 225 * 0.4
        Else
            cost = 35
        End If

        If (loc = 1) Then
            location = 1
        ElseIf (loc = 2) Then
            location = 1.2
        ElseIf (loc = 3) Then
            location = 1.15
        Else
            location = 1.4
        End If

        price = cost * location

    End Sub

    Public ReadOnly Property final_price As Double
        Get
            Return price
        End Get
    End Property

End Class