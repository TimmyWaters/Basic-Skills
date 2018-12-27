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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.commaRadioButton = New System.Windows.Forms.RadioButton()
        Me.crlfRadioButton = New System.Windows.Forms.RadioButton()
        Me.spaceRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.parseButton = New System.Windows.Forms.Button()
        Me.buildButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.spaceRadioButton)
        Me.GroupBox1.Controls.Add(Me.crlfRadioButton)
        Me.GroupBox1.Controls.Add(Me.commaRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 234)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a delimiter"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.parseButton)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(263, 36)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(660, 374)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Build a List from a TextBox"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.buildButton)
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(263, 426)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(660, 374)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Build a TextBox from a List"
        '
        'commaRadioButton
        '
        Me.commaRadioButton.AutoSize = True
        Me.commaRadioButton.Location = New System.Drawing.Point(38, 48)
        Me.commaRadioButton.Name = "commaRadioButton"
        Me.commaRadioButton.Size = New System.Drawing.Size(116, 29)
        Me.commaRadioButton.TabIndex = 0
        Me.commaRadioButton.TabStop = True
        Me.commaRadioButton.Text = "Comma"
        Me.commaRadioButton.UseVisualStyleBackColor = True
        '
        'crlfRadioButton
        '
        Me.crlfRadioButton.AutoSize = True
        Me.crlfRadioButton.Location = New System.Drawing.Point(38, 109)
        Me.crlfRadioButton.Name = "crlfRadioButton"
        Me.crlfRadioButton.Size = New System.Drawing.Size(105, 29)
        Me.crlfRadioButton.TabIndex = 1
        Me.crlfRadioButton.TabStop = True
        Me.crlfRadioButton.Text = "CR-LF"
        Me.crlfRadioButton.UseVisualStyleBackColor = True
        '
        'spaceRadioButton
        '
        Me.spaceRadioButton.AutoSize = True
        Me.spaceRadioButton.Location = New System.Drawing.Point(38, 173)
        Me.spaceRadioButton.Name = "spaceRadioButton"
        Me.spaceRadioButton.Size = New System.Drawing.Size(104, 29)
        Me.spaceRadioButton.TabIndex = 2
        Me.spaceRadioButton.TabStop = True
        Me.spaceRadioButton.Text = "Space"
        Me.spaceRadioButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(62, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(460, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter items, separated by the chosen delimiter"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(62, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(416, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Use this list to build the TextBox contents"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(67, 102)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(286, 229)
        Me.ListBox1.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(67, 92)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(286, 229)
        Me.TextBox1.TabIndex = 1
        '
        'parseButton
        '
        Me.parseButton.Location = New System.Drawing.Point(416, 262)
        Me.parseButton.Name = "parseButton"
        Me.parseButton.Size = New System.Drawing.Size(201, 59)
        Me.parseButton.TabIndex = 2
        Me.parseButton.Text = "Parse Text to List"
        Me.parseButton.UseVisualStyleBackColor = True
        '
        'buildButton
        '
        Me.buildButton.Location = New System.Drawing.Point(406, 272)
        Me.buildButton.Name = "buildButton"
        Me.buildButton.Size = New System.Drawing.Size(211, 59)
        Me.buildButton.TabIndex = 3
        Me.buildButton.Text = "Build Text from List"
        Me.buildButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(330, 828)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(109, 59)
        Me.clearButton.TabIndex = 4
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(669, 828)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(116, 59)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1118, 916)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "String Parser"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents spaceRadioButton As RadioButton
    Friend WithEvents crlfRadioButton As RadioButton
    Friend WithEvents commaRadioButton As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents parseButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents buildButton As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
End Class
