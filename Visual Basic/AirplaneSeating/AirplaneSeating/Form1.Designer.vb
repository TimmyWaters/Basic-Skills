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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.islandBreezesLbl = New System.Windows.Forms.Label()
        Me.dolphinPic = New System.Windows.Forms.PictureBox()
        Me.passengerNameLbl = New System.Windows.Forms.Label()
        Me.passengerNameTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.seat13BRadioButton = New System.Windows.Forms.RadioButton()
        Me.seat12BRadioButton = New System.Windows.Forms.RadioButton()
        Me.seat11BRadioButton = New System.Windows.Forms.RadioButton()
        Me.seat10BRadioButton = New System.Windows.Forms.RadioButton()
        Me.seat13ARadioButton = New System.Windows.Forms.RadioButton()
        Me.seat12ARadioButton = New System.Windows.Forms.RadioButton()
        Me.seat11ARadioButton = New System.Windows.Forms.RadioButton()
        Me.seat10ARadioButton = New System.Windows.Forms.RadioButton()
        Me.confirmBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        CType(Me.dolphinPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'islandBreezesLbl
        '
        Me.islandBreezesLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.islandBreezesLbl.Location = New System.Drawing.Point(53, 11)
        Me.islandBreezesLbl.Name = "islandBreezesLbl"
        Me.islandBreezesLbl.Size = New System.Drawing.Size(344, 117)
        Me.islandBreezesLbl.TabIndex = 0
        Me.islandBreezesLbl.Text = "Island Breezes Sea Planes"
        Me.islandBreezesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dolphinPic
        '
        Me.dolphinPic.Image = CType(resources.GetObject("dolphinPic.Image"), System.Drawing.Image)
        Me.dolphinPic.Location = New System.Drawing.Point(16, 131)
        Me.dolphinPic.Name = "dolphinPic"
        Me.dolphinPic.Size = New System.Drawing.Size(409, 220)
        Me.dolphinPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dolphinPic.TabIndex = 1
        Me.dolphinPic.TabStop = False
        '
        'passengerNameLbl
        '
        Me.passengerNameLbl.AutoSize = True
        Me.passengerNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passengerNameLbl.Location = New System.Drawing.Point(24, 378)
        Me.passengerNameLbl.Name = "passengerNameLbl"
        Me.passengerNameLbl.Size = New System.Drawing.Size(317, 42)
        Me.passengerNameLbl.TabIndex = 2
        Me.passengerNameLbl.Text = "Passenger Name:"
        '
        'passengerNameTxt
        '
        Me.passengerNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passengerNameTxt.Location = New System.Drawing.Point(29, 424)
        Me.passengerNameTxt.Name = "passengerNameTxt"
        Me.passengerNameTxt.Size = New System.Drawing.Size(381, 44)
        Me.passengerNameTxt.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.seat13BRadioButton)
        Me.GroupBox1.Controls.Add(Me.seat12BRadioButton)
        Me.GroupBox1.Controls.Add(Me.seat11BRadioButton)
        Me.GroupBox1.Controls.Add(Me.seat10BRadioButton)
        Me.GroupBox1.Controls.Add(Me.seat13ARadioButton)
        Me.GroupBox1.Controls.Add(Me.seat12ARadioButton)
        Me.GroupBox1.Controls.Add(Me.seat11ARadioButton)
        Me.GroupBox1.Controls.Add(Me.seat10ARadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 510)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 318)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seat Selection"
        '
        'seat13BRadioButton
        '
        Me.seat13BRadioButton.AutoSize = True
        Me.seat13BRadioButton.Location = New System.Drawing.Point(218, 245)
        Me.seat13BRadioButton.Name = "seat13BRadioButton"
        Me.seat13BRadioButton.Size = New System.Drawing.Size(88, 29)
        Me.seat13BRadioButton.TabIndex = 7
        Me.seat13BRadioButton.TabStop = True
        Me.seat13BRadioButton.Text = "13-B"
        Me.seat13BRadioButton.UseVisualStyleBackColor = True
        '
        'seat12BRadioButton
        '
        Me.seat12BRadioButton.AutoSize = True
        Me.seat12BRadioButton.Location = New System.Drawing.Point(218, 177)
        Me.seat12BRadioButton.Name = "seat12BRadioButton"
        Me.seat12BRadioButton.Size = New System.Drawing.Size(88, 29)
        Me.seat12BRadioButton.TabIndex = 6
        Me.seat12BRadioButton.TabStop = True
        Me.seat12BRadioButton.Text = "12-B"
        Me.seat12BRadioButton.UseVisualStyleBackColor = True
        '
        'seat11BRadioButton
        '
        Me.seat11BRadioButton.AutoSize = True
        Me.seat11BRadioButton.Location = New System.Drawing.Point(218, 108)
        Me.seat11BRadioButton.Name = "seat11BRadioButton"
        Me.seat11BRadioButton.Size = New System.Drawing.Size(88, 29)
        Me.seat11BRadioButton.TabIndex = 5
        Me.seat11BRadioButton.TabStop = True
        Me.seat11BRadioButton.Text = "11-B"
        Me.seat11BRadioButton.UseVisualStyleBackColor = True
        '
        'seat10BRadioButton
        '
        Me.seat10BRadioButton.AutoSize = True
        Me.seat10BRadioButton.Location = New System.Drawing.Point(218, 50)
        Me.seat10BRadioButton.Name = "seat10BRadioButton"
        Me.seat10BRadioButton.Size = New System.Drawing.Size(88, 29)
        Me.seat10BRadioButton.TabIndex = 4
        Me.seat10BRadioButton.TabStop = True
        Me.seat10BRadioButton.Text = "10-B"
        Me.seat10BRadioButton.UseVisualStyleBackColor = True
        '
        'seat13ARadioButton
        '
        Me.seat13ARadioButton.AutoSize = True
        Me.seat13ARadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.seat13ARadioButton.Location = New System.Drawing.Point(6, 245)
        Me.seat13ARadioButton.Name = "seat13ARadioButton"
        Me.seat13ARadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.seat13ARadioButton.Size = New System.Drawing.Size(88, 29)
        Me.seat13ARadioButton.TabIndex = 3
        Me.seat13ARadioButton.TabStop = True
        Me.seat13ARadioButton.Text = "13-A"
        Me.seat13ARadioButton.UseVisualStyleBackColor = True
        '
        'seat12ARadioButton
        '
        Me.seat12ARadioButton.AutoSize = True
        Me.seat12ARadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.seat12ARadioButton.Location = New System.Drawing.Point(6, 177)
        Me.seat12ARadioButton.Name = "seat12ARadioButton"
        Me.seat12ARadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.seat12ARadioButton.Size = New System.Drawing.Size(88, 29)
        Me.seat12ARadioButton.TabIndex = 2
        Me.seat12ARadioButton.TabStop = True
        Me.seat12ARadioButton.Text = "12-A"
        Me.seat12ARadioButton.UseVisualStyleBackColor = True
        '
        'seat11ARadioButton
        '
        Me.seat11ARadioButton.AutoSize = True
        Me.seat11ARadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.seat11ARadioButton.Location = New System.Drawing.Point(6, 108)
        Me.seat11ARadioButton.Name = "seat11ARadioButton"
        Me.seat11ARadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.seat11ARadioButton.Size = New System.Drawing.Size(88, 29)
        Me.seat11ARadioButton.TabIndex = 1
        Me.seat11ARadioButton.TabStop = True
        Me.seat11ARadioButton.Text = "11-A"
        Me.seat11ARadioButton.UseVisualStyleBackColor = True
        '
        'seat10ARadioButton
        '
        Me.seat10ARadioButton.AutoSize = True
        Me.seat10ARadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.seat10ARadioButton.Location = New System.Drawing.Point(6, 50)
        Me.seat10ARadioButton.Name = "seat10ARadioButton"
        Me.seat10ARadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.seat10ARadioButton.Size = New System.Drawing.Size(88, 29)
        Me.seat10ARadioButton.TabIndex = 0
        Me.seat10ARadioButton.TabStop = True
        Me.seat10ARadioButton.Text = "10-A"
        Me.seat10ARadioButton.UseVisualStyleBackColor = True
        '
        'confirmBtn
        '
        Me.confirmBtn.Location = New System.Drawing.Point(64, 872)
        Me.confirmBtn.Name = "confirmBtn"
        Me.confirmBtn.Size = New System.Drawing.Size(129, 86)
        Me.confirmBtn.TabIndex = 5
        Me.confirmBtn.Text = "Confirm Seat"
        Me.confirmBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(254, 872)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(129, 86)
        Me.exitBtn.TabIndex = 6
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 970)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.confirmBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.passengerNameTxt)
        Me.Controls.Add(Me.passengerNameLbl)
        Me.Controls.Add(Me.dolphinPic)
        Me.Controls.Add(Me.islandBreezesLbl)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.dolphinPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents islandBreezesLbl As Label
    Friend WithEvents dolphinPic As PictureBox
    Friend WithEvents passengerNameLbl As Label
    Friend WithEvents passengerNameTxt As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents seat13BRadioButton As RadioButton
    Friend WithEvents seat12BRadioButton As RadioButton
    Friend WithEvents seat11BRadioButton As RadioButton
    Friend WithEvents seat10BRadioButton As RadioButton
    Friend WithEvents seat13ARadioButton As RadioButton
    Friend WithEvents seat12ARadioButton As RadioButton
    Friend WithEvents seat11ARadioButton As RadioButton
    Friend WithEvents seat10ARadioButton As RadioButton
    Friend WithEvents confirmBtn As Button
    Friend WithEvents exitBtn As Button
End Class
