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
        Me.menRadBtn = New System.Windows.Forms.RadioButton()
        Me.womenRadBtn = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.smallRadBtn = New System.Windows.Forms.RadioButton()
        Me.mediumRadBtn = New System.Windows.Forms.RadioButton()
        Me.largeRadBtn = New System.Windows.Forms.RadioButton()
        Me.pictureCheckBox = New System.Windows.Forms.CheckBox()
        Me.nameCheckBox = New System.Windows.Forms.CheckBox()
        Me.calcBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.numberOrderedLbl = New System.Windows.Forms.Label()
        Me.totalPriceLbl = New System.Windows.Forms.Label()
        Me.priceResultLbl = New System.Windows.Forms.Label()
        Me.numOrderedTxtBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menRadBtn
        '
        Me.menRadBtn.AutoSize = True
        Me.menRadBtn.Location = New System.Drawing.Point(128, 69)
        Me.menRadBtn.Name = "menRadBtn"
        Me.menRadBtn.Size = New System.Drawing.Size(85, 29)
        Me.menRadBtn.TabIndex = 0
        Me.menRadBtn.TabStop = True
        Me.menRadBtn.Text = "Men"
        Me.menRadBtn.UseVisualStyleBackColor = True
        '
        'womenRadBtn
        '
        Me.womenRadBtn.AutoSize = True
        Me.womenRadBtn.Location = New System.Drawing.Point(128, 139)
        Me.womenRadBtn.Name = "womenRadBtn"
        Me.womenRadBtn.Size = New System.Drawing.Size(116, 29)
        Me.womenRadBtn.TabIndex = 1
        Me.womenRadBtn.TabStop = True
        Me.womenRadBtn.Text = "Women"
        Me.womenRadBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.largeRadBtn)
        Me.GroupBox1.Controls.Add(Me.mediumRadBtn)
        Me.GroupBox1.Controls.Add(Me.smallRadBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(303, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 226)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Size"
        '
        'smallRadBtn
        '
        Me.smallRadBtn.AutoSize = True
        Me.smallRadBtn.Location = New System.Drawing.Point(7, 35)
        Me.smallRadBtn.Name = "smallRadBtn"
        Me.smallRadBtn.Size = New System.Drawing.Size(96, 29)
        Me.smallRadBtn.TabIndex = 0
        Me.smallRadBtn.TabStop = True
        Me.smallRadBtn.Text = "Small"
        Me.smallRadBtn.UseVisualStyleBackColor = True
        '
        'mediumRadBtn
        '
        Me.mediumRadBtn.AutoSize = True
        Me.mediumRadBtn.Location = New System.Drawing.Point(6, 105)
        Me.mediumRadBtn.Name = "mediumRadBtn"
        Me.mediumRadBtn.Size = New System.Drawing.Size(119, 29)
        Me.mediumRadBtn.TabIndex = 1
        Me.mediumRadBtn.TabStop = True
        Me.mediumRadBtn.Text = "Medium"
        Me.mediumRadBtn.UseVisualStyleBackColor = True
        '
        'largeRadBtn
        '
        Me.largeRadBtn.AutoSize = True
        Me.largeRadBtn.Location = New System.Drawing.Point(7, 179)
        Me.largeRadBtn.Name = "largeRadBtn"
        Me.largeRadBtn.Size = New System.Drawing.Size(98, 29)
        Me.largeRadBtn.TabIndex = 2
        Me.largeRadBtn.TabStop = True
        Me.largeRadBtn.Text = "Large"
        Me.largeRadBtn.UseVisualStyleBackColor = True
        '
        'pictureCheckBox
        '
        Me.pictureCheckBox.AutoSize = True
        Me.pictureCheckBox.Location = New System.Drawing.Point(539, 70)
        Me.pictureCheckBox.Name = "pictureCheckBox"
        Me.pictureCheckBox.Size = New System.Drawing.Size(111, 29)
        Me.pictureCheckBox.TabIndex = 3
        Me.pictureCheckBox.Text = "Picture"
        Me.pictureCheckBox.UseVisualStyleBackColor = True
        '
        'nameCheckBox
        '
        Me.nameCheckBox.AutoSize = True
        Me.nameCheckBox.Location = New System.Drawing.Point(539, 140)
        Me.nameCheckBox.Name = "nameCheckBox"
        Me.nameCheckBox.Size = New System.Drawing.Size(100, 29)
        Me.nameCheckBox.TabIndex = 4
        Me.nameCheckBox.Text = "Name"
        Me.nameCheckBox.UseVisualStyleBackColor = True
        '
        'calcBtn
        '
        Me.calcBtn.Location = New System.Drawing.Point(569, 318)
        Me.calcBtn.Name = "calcBtn"
        Me.calcBtn.Size = New System.Drawing.Size(133, 56)
        Me.calcBtn.TabIndex = 5
        Me.calcBtn.Text = "Calculate"
        Me.calcBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(569, 404)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(133, 60)
        Me.exitBtn.TabIndex = 6
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'numberOrderedLbl
        '
        Me.numberOrderedLbl.AutoSize = True
        Me.numberOrderedLbl.Location = New System.Drawing.Point(107, 334)
        Me.numberOrderedLbl.Name = "numberOrderedLbl"
        Me.numberOrderedLbl.Size = New System.Drawing.Size(183, 25)
        Me.numberOrderedLbl.TabIndex = 7
        Me.numberOrderedLbl.Text = "Number Ordered: "
        '
        'totalPriceLbl
        '
        Me.totalPriceLbl.AutoSize = True
        Me.totalPriceLbl.Location = New System.Drawing.Point(163, 422)
        Me.totalPriceLbl.Name = "totalPriceLbl"
        Me.totalPriceLbl.Size = New System.Drawing.Size(127, 25)
        Me.totalPriceLbl.TabIndex = 8
        Me.totalPriceLbl.Text = "Total Price: "
        '
        'priceResultLbl
        '
        Me.priceResultLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.priceResultLbl.Location = New System.Drawing.Point(322, 404)
        Me.priceResultLbl.Name = "priceResultLbl"
        Me.priceResultLbl.Size = New System.Drawing.Size(153, 60)
        Me.priceResultLbl.TabIndex = 9
        Me.priceResultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'numOrderedTxtBox
        '
        Me.numOrderedTxtBox.Location = New System.Drawing.Point(322, 334)
        Me.numOrderedTxtBox.Name = "numOrderedTxtBox"
        Me.numOrderedTxtBox.Size = New System.Drawing.Size(100, 31)
        Me.numOrderedTxtBox.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 616)
        Me.Controls.Add(Me.numOrderedTxtBox)
        Me.Controls.Add(Me.priceResultLbl)
        Me.Controls.Add(Me.totalPriceLbl)
        Me.Controls.Add(Me.numberOrderedLbl)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.calcBtn)
        Me.Controls.Add(Me.nameCheckBox)
        Me.Controls.Add(Me.pictureCheckBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.womenRadBtn)
        Me.Controls.Add(Me.menRadBtn)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Just Tees"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menRadBtn As RadioButton
    Friend WithEvents womenRadBtn As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents largeRadBtn As RadioButton
    Friend WithEvents mediumRadBtn As RadioButton
    Friend WithEvents smallRadBtn As RadioButton
    Friend WithEvents pictureCheckBox As CheckBox
    Friend WithEvents nameCheckBox As CheckBox
    Friend WithEvents calcBtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents numberOrderedLbl As Label
    Friend WithEvents totalPriceLbl As Label
    Friend WithEvents priceResultLbl As Label
    Friend WithEvents numOrderedTxtBox As TextBox
End Class
