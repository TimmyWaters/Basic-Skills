<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.guessInput = New System.Windows.Forms.TextBox()
        Me.checkGuessBtn = New System.Windows.Forms.Button()
        Me.startNewBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(119, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(563, 141)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "I'm thinking of a number between 1 and 10. Enter your guess and click on the Chec" &
    "k My Guess button."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(163, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Your guess:"
        '
        'guessInput
        '
        Me.guessInput.Location = New System.Drawing.Point(298, 198)
        Me.guessInput.Name = "guessInput"
        Me.guessInput.Size = New System.Drawing.Size(100, 31)
        Me.guessInput.TabIndex = 2
        '
        'checkGuessBtn
        '
        Me.checkGuessBtn.Location = New System.Drawing.Point(81, 314)
        Me.checkGuessBtn.Name = "checkGuessBtn"
        Me.checkGuessBtn.Size = New System.Drawing.Size(200, 49)
        Me.checkGuessBtn.TabIndex = 3
        Me.checkGuessBtn.Text = "Check My Guess"
        Me.checkGuessBtn.UseVisualStyleBackColor = True
        '
        'startNewBtn
        '
        Me.startNewBtn.Location = New System.Drawing.Point(314, 312)
        Me.startNewBtn.Name = "startNewBtn"
        Me.startNewBtn.Size = New System.Drawing.Size(219, 53)
        Me.startNewBtn.TabIndex = 4
        Me.startNewBtn.Text = "Start a New Game"
        Me.startNewBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(573, 312)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(109, 53)
        Me.exitBtn.TabIndex = 5
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(547, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Label3"
        '
        'Form1
        '
        Me.AcceptButton = Me.checkGuessBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.startNewBtn)
        Me.Controls.Add(Me.checkGuessBtn)
        Me.Controls.Add(Me.guessInput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guess My Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents guessInput As TextBox
    Friend WithEvents checkGuessBtn As Button
    Friend WithEvents startNewBtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents Label3 As Label
End Class
