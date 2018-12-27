Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        commaRadioButton.Checked = True
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub parseButton_Click(sender As Object, e As EventArgs) Handles parseButton.Click
        Dim delimiter As String
        Dim oldIndex As Integer
        Dim newIndex As Integer
        Dim length As Integer
        Dim tempString As String
        Dim tempWord As String
        Dim advanceSize As Integer

        ListBox1.Items.Clear()

        If commaRadioButton.Checked = True Then
            delimiter = ","
            advanceSize = 1
        ElseIf crlfRadioButton.Checked = True Then
            delimiter = vbCrLf
            advanceSize = 2
        ElseIf spaceRadioButton.Checked = True Then
            delimiter = " "
            advanceSize = 1
        Else
            Exit Sub
        End If

        length = TextBox1.Text.Length
        tempString = TextBox1.Text
        oldIndex = 0

        While oldIndex < length
            newIndex = tempString.IndexOf(delimiter)
            If newIndex > -1 Then
                oldIndex = 0
                tempWord = Mid(tempString, oldIndex + 1, newIndex)
                oldIndex = newIndex + advanceSize
                tempString = tempString.Substring(oldIndex, length - oldIndex)
                length = tempString.Length
                tempWord.Trim()
                ListBox1.Items.Add(tempWord)
            Else
                Exit While
            End If
        End While
        ListBox1.Items.Add(tempString)
    End Sub

    Private Sub buildButton_Click(sender As Object, e As EventArgs) Handles buildButton.Click
        Dim delimiter As String
        Dim i As Integer
        Dim length As Integer
        Dim tempString As String
        Dim advanceSize As Integer

        TextBox1.Clear()

        If commaRadioButton.Checked = True Then
            delimiter = ","
            advanceSize = 1
        ElseIf crlfRadioButton.Checked = True Then
            delimiter = vbCrLf
            advanceSize = 2
        ElseIf spaceRadioButton.Checked = True Then
            delimiter = " "
            advanceSize = 1
        Else
            Exit Sub
        End If

        tempString = ""

        For i = 0 To ListBox1.Items.Count - 1
            tempString += ListBox1.Items.Item(i) + delimiter
        Next
        TextBox1.Text = tempString
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        TextBox1.Clear()
        ListBox1.Items.Clear()
    End Sub
End Class
