Imports System.Globalization

Public Class Form1
    Dim guessLimitCounter As Integer = 0
    Dim guessCorrectCounter As Integer = 0
    Dim guessTotalCounter As Integer = 0
    Dim guess As Integer
    Dim randomAnswer As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim randGen As New Random
        randomAnswer = randGen.Next(1, 11)
        Label3.Text = randomAnswer.ToString
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Dim stats As Double
        Dim msgString As String
        stats = 100 * (guessCorrectCounter / guessTotalCounter)
        msgString = "Thank you for playing! You had " & guessCorrectCounter.ToString & " correct guesses out of a total of " & guessTotalCounter.ToString & " guesses for a win percentage of " & stats.ToString("N", CultureInfo.InvariantCulture) & "%."
        MessageBox.Show(msgString, "Correct",
 MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub checkGuessBtn_Click(sender As Object, e As EventArgs) Handles checkGuessBtn.Click
        Dim guessCorrect As Boolean
        Dim randGen As New Random
        If Not Single.TryParse(guessInput.Text, guess) Then
            MessageBox.Show("You must enter a numeric value here.", "Bad value",
 MessageBoxButtons.OK, MessageBoxIcon.Information)
            guessInput.Focus()
            Exit Sub
        End If
        If guess = randomAnswer Then
            guessCorrect = True
            guessCorrectCounter += 1
            guessLimitCounter += 1
            guessTotalCounter += 1
            MessageBox.Show("Congratulations! You guessed correctly!", "Correct",
 MessageBoxButtons.OK, MessageBoxIcon.Information)

            randomAnswer = randGen.Next(1, 11)
            Label3.Text = randomAnswer.ToString
            guessLimitCounter = 0
            guessInput.Clear()
            guessInput.Focus()
        Else
            guessCorrect = False
            guessLimitCounter += 1
            guessTotalCounter += 1
            If guessLimitCounter = 5 Then
                MessageBox.Show("You have reached 5 incorrect guesses. I have a new number for you to guess!", "Try Again",
 MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                randomAnswer = randGen.Next(1, 11)
                Label3.Text = randomAnswer.ToString
                guessLimitCounter = 0
                guessInput.Clear()
                guessInput.Focus()
                Exit Sub
            End If
            MessageBox.Show("You guessed incorrectly. Try again!", "Incorrect",
 MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            guessInput.Clear()
            guessInput.Focus()
        End If
    End Sub

    Private Sub startNewBtn_Click(sender As Object, e As EventArgs) Handles startNewBtn.Click
        MessageBox.Show("I have a new number for you to guess!", "Start a New Game",
 MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim randGen As New Random
        randomAnswer = randGen.Next(1, 11)
        Label3.Text = randomAnswer.ToString
        guessLimitCounter = 0
        guessInput.Clear()
        guessInput.Focus()
    End Sub
End Class
