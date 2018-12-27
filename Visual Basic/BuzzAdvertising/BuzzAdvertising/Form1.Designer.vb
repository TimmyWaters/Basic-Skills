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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.businessRadioButton = New System.Windows.Forms.RadioButton()
        Me.quaterRadioButton = New System.Windows.Forms.RadioButton()
        Me.halfRadioButton = New System.Windows.Forms.RadioButton()
        Me.fullRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.interiorRadioButton = New System.Windows.Forms.RadioButton()
        Me.insidefrontRadioButton = New System.Windows.Forms.RadioButton()
        Me.insidebackRadioButton = New System.Windows.Forms.RadioButton()
        Me.outsidebackRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.companyTextBox = New System.Windows.Forms.TextBox()
        Me.telephoneTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dateTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.reserveButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(374, 404)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(392, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(758, 67)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Catch the Buzz!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(392, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(758, 121)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Place your ad with Buzz Advertising for maximum exposure!"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(392, 339)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(758, 77)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Reserve your ad today:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.businessRadioButton)
        Me.GroupBox1.Controls.Add(Me.quaterRadioButton)
        Me.GroupBox1.Controls.Add(Me.halfRadioButton)
        Me.GroupBox1.Controls.Add(Me.fullRadioButton)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 442)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 310)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ad Size"
        '
        'businessRadioButton
        '
        Me.businessRadioButton.AutoSize = True
        Me.businessRadioButton.Location = New System.Drawing.Point(18, 262)
        Me.businessRadioButton.Name = "businessRadioButton"
        Me.businessRadioButton.Size = New System.Drawing.Size(235, 35)
        Me.businessRadioButton.TabIndex = 3
        Me.businessRadioButton.TabStop = True
        Me.businessRadioButton.Text = "Business Card"
        Me.businessRadioButton.UseVisualStyleBackColor = True
        '
        'quaterRadioButton
        '
        Me.quaterRadioButton.AutoSize = True
        Me.quaterRadioButton.Location = New System.Drawing.Point(18, 188)
        Me.quaterRadioButton.Name = "quaterRadioButton"
        Me.quaterRadioButton.Size = New System.Drawing.Size(219, 35)
        Me.quaterRadioButton.TabIndex = 2
        Me.quaterRadioButton.TabStop = True
        Me.quaterRadioButton.Text = "Quarter Page"
        Me.quaterRadioButton.UseVisualStyleBackColor = True
        '
        'halfRadioButton
        '
        Me.halfRadioButton.AutoSize = True
        Me.halfRadioButton.Location = New System.Drawing.Point(18, 110)
        Me.halfRadioButton.Name = "halfRadioButton"
        Me.halfRadioButton.Size = New System.Drawing.Size(173, 35)
        Me.halfRadioButton.TabIndex = 1
        Me.halfRadioButton.TabStop = True
        Me.halfRadioButton.Text = "Half Page"
        Me.halfRadioButton.UseVisualStyleBackColor = True
        '
        'fullRadioButton
        '
        Me.fullRadioButton.AutoSize = True
        Me.fullRadioButton.Location = New System.Drawing.Point(18, 38)
        Me.fullRadioButton.Name = "fullRadioButton"
        Me.fullRadioButton.Size = New System.Drawing.Size(168, 35)
        Me.fullRadioButton.TabIndex = 0
        Me.fullRadioButton.TabStop = True
        Me.fullRadioButton.Text = "Full Page"
        Me.fullRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.interiorRadioButton)
        Me.GroupBox2.Controls.Add(Me.insidefrontRadioButton)
        Me.GroupBox2.Controls.Add(Me.insidebackRadioButton)
        Me.GroupBox2.Controls.Add(Me.outsidebackRadioButton)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(326, 442)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(393, 310)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Location"
        '
        'interiorRadioButton
        '
        Me.interiorRadioButton.AutoSize = True
        Me.interiorRadioButton.Location = New System.Drawing.Point(17, 262)
        Me.interiorRadioButton.Name = "interiorRadioButton"
        Me.interiorRadioButton.Size = New System.Drawing.Size(213, 35)
        Me.interiorRadioButton.TabIndex = 4
        Me.interiorRadioButton.TabStop = True
        Me.interiorRadioButton.Text = "Interior Page"
        Me.interiorRadioButton.UseVisualStyleBackColor = True
        '
        'insidefrontRadioButton
        '
        Me.insidefrontRadioButton.AutoSize = True
        Me.insidefrontRadioButton.Location = New System.Drawing.Point(17, 188)
        Me.insidefrontRadioButton.Name = "insidefrontRadioButton"
        Me.insidefrontRadioButton.Size = New System.Drawing.Size(287, 35)
        Me.insidefrontRadioButton.TabIndex = 3
        Me.insidefrontRadioButton.TabStop = True
        Me.insidefrontRadioButton.Text = "Inside Front Cover"
        Me.insidefrontRadioButton.UseVisualStyleBackColor = True
        '
        'insidebackRadioButton
        '
        Me.insidebackRadioButton.AutoSize = True
        Me.insidebackRadioButton.Location = New System.Drawing.Point(17, 110)
        Me.insidebackRadioButton.Name = "insidebackRadioButton"
        Me.insidebackRadioButton.Size = New System.Drawing.Size(283, 35)
        Me.insidebackRadioButton.TabIndex = 2
        Me.insidebackRadioButton.TabStop = True
        Me.insidebackRadioButton.Text = "Inside Back Cover"
        Me.insidebackRadioButton.UseVisualStyleBackColor = True
        '
        'outsidebackRadioButton
        '
        Me.outsidebackRadioButton.AutoSize = True
        Me.outsidebackRadioButton.Location = New System.Drawing.Point(17, 38)
        Me.outsidebackRadioButton.Name = "outsidebackRadioButton"
        Me.outsidebackRadioButton.Size = New System.Drawing.Size(305, 35)
        Me.outsidebackRadioButton.TabIndex = 1
        Me.outsidebackRadioButton.TabStop = True
        Me.outsidebackRadioButton.Text = "Outside Back Cover"
        Me.outsidebackRadioButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(741, 442)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(230, 31)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Company Name:"
        '
        'companyTextBox
        '
        Me.companyTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.companyTextBox.Location = New System.Drawing.Point(747, 479)
        Me.companyTextBox.Multiline = True
        Me.companyTextBox.Name = "companyTextBox"
        Me.companyTextBox.Size = New System.Drawing.Size(403, 48)
        Me.companyTextBox.TabIndex = 7
        '
        'telephoneTextBox
        '
        Me.telephoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telephoneTextBox.Location = New System.Drawing.Point(747, 589)
        Me.telephoneTextBox.Multiline = True
        Me.telephoneTextBox.Name = "telephoneTextBox"
        Me.telephoneTextBox.Size = New System.Drawing.Size(403, 48)
        Me.telephoneTextBox.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(741, 552)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 31)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Telephone:"
        '
        'dateTextBox
        '
        Me.dateTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTextBox.Location = New System.Drawing.Point(747, 704)
        Me.dateTextBox.Multiline = True
        Me.dateTextBox.Name = "dateTextBox"
        Me.dateTextBox.Size = New System.Drawing.Size(403, 48)
        Me.dateTextBox.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(741, 670)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 31)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Run Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 806)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 31)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Ad Price:"
        '
        'priceLabel
        '
        Me.priceLabel.BackColor = System.Drawing.SystemColors.Window
        Me.priceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.priceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceLabel.Location = New System.Drawing.Point(26, 855)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(262, 63)
        Me.priceLabel.TabIndex = 13
        Me.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'reserveButton
        '
        Me.reserveButton.BackColor = System.Drawing.Color.LemonChiffon
        Me.reserveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.reserveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reserveButton.Location = New System.Drawing.Point(392, 844)
        Me.reserveButton.Name = "reserveButton"
        Me.reserveButton.Size = New System.Drawing.Size(229, 74)
        Me.reserveButton.TabIndex = 14
        Me.reserveButton.Text = "Reserve Ad"
        Me.reserveButton.UseVisualStyleBackColor = False
        '
        'clearButton
        '
        Me.clearButton.BackColor = System.Drawing.Color.LemonChiffon
        Me.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(658, 844)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(229, 74)
        Me.clearButton.TabIndex = 15
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = False
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.LemonChiffon
        Me.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(921, 844)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(229, 74)
        Me.exitButton.TabIndex = 16
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1200, 958)
        Me.ControlBox = False
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.reserveButton)
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dateTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.telephoneTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.companyTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buzz Advertising"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents businessRadioButton As RadioButton
    Friend WithEvents quaterRadioButton As RadioButton
    Friend WithEvents halfRadioButton As RadioButton
    Friend WithEvents fullRadioButton As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents interiorRadioButton As RadioButton
    Friend WithEvents insidefrontRadioButton As RadioButton
    Friend WithEvents insidebackRadioButton As RadioButton
    Friend WithEvents outsidebackRadioButton As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents companyTextBox As TextBox
    Friend WithEvents telephoneTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dateTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents priceLabel As Label
    Friend WithEvents reserveButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
End Class
