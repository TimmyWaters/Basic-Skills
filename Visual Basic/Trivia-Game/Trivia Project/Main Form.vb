Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Dim numIncorrect() As Integer = {-1, -1, -1, -1, -1, -1, -1, -1, -1}
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TblGameTableAdapter.Fill(Me.TriviaDataSet.tblGame)
        Label1.Text = "Question: " & (TblGameBindingSource.Position + 1).ToString
    End Sub

    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        'determines whether the user's answer is correct
        ' and the number of incorrect answers 
        Dim ptrPosition As Integer
        Dim userAnswer As String


        ' store record pointer's position
        ptrPosition = TblGameBindingSource.Position
        ' determine selected radio button 
        Select Case True
            Case aRadioButton.Checked
                userAnswer = aRadioButton.Text.Substring(1, 1)
            Case bRadioButton.Checked
                userAnswer = bRadioButton.Text.Substring(1, 1)
            Case cRadioButton.Checked
                userAnswer = cRadioButton.Text.Substring(1, 1)
            Case Else
                userAnswer = dRadioButton.Text.Substring(1, 1)
        End Select

        ' if necessary, update the number of incorrect answers 
        If userAnswer <> TriviaDataSet.tblGame(ptrPosition).CorrectAnswer Then
            numIncorrect(ptrPosition) = 0
        Else
            numIncorrect(ptrPosition) = 1
        End If

        MessageBox.Show("Your answer has been submitted.")
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        TblGameBindingSource.MoveNext()
        Label1.Text = "Question: " & (TblGameBindingSource.Position + 1).ToString
    End Sub

    Private Sub jumpButton_Click(sender As Object, e As EventArgs) Handles jumpButton.Click
        Try
            Dim quesNumber As Integer = CInt(InputBox("Enter the question you wish to go to:", "Trivia Game"))
            TblGameBindingSource.Position = quesNumber - 1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Trivia Game")
        End Try

        Label1.Text = "Question: " & (TblGameBindingSource.Position + 1).ToString
    End Sub

    Private Sub checkButton_Click(sender As Object, e As EventArgs) Handles checkButton.Click
        Dim incorrect As Integer = 0
        Dim attempted As Integer = 0
        Dim i As Integer

        For i = 0 To 8
            If (numIncorrect(i) = 0) Then
                incorrect += 1
            End If

            If (numIncorrect(i) <> -1) Then
                attempted += 1
            End If
        Next
        MessageBox.Show("Incorrect answers: " & incorrect.ToString & Environment.NewLine & "Attempted Questions: " & attempted.ToString, "Trivia Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Label1.Text = "Question: " & (TblGameBindingSource.Position + 1).ToString
    End Sub
End Class