<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.islandBreezesLbl = New System.Windows.Forms.Label()
        Me.dolphinPic = New System.Windows.Forms.PictureBox()
        Me.nameLbl = New System.Windows.Forms.Label()
        Me.passNameLbl = New System.Windows.Forms.Label()
        Me.seatNumLbl = New System.Windows.Forms.Label()
        Me.seatLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.reservationDateLbl = New System.Windows.Forms.Label()
        Me.dateLbl = New System.Windows.Forms.Label()
        Me.closeBtn = New System.Windows.Forms.Button()
        CType(Me.dolphinPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'islandBreezesLbl
        '
        Me.islandBreezesLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.islandBreezesLbl.Location = New System.Drawing.Point(180, 9)
        Me.islandBreezesLbl.Name = "islandBreezesLbl"
        Me.islandBreezesLbl.Size = New System.Drawing.Size(602, 117)
        Me.islandBreezesLbl.TabIndex = 1
        Me.islandBreezesLbl.Text = "Island Breezes Sea Planes"
        Me.islandBreezesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dolphinPic
        '
        Me.dolphinPic.Image = CType(resources.GetObject("dolphinPic.Image"), System.Drawing.Image)
        Me.dolphinPic.Location = New System.Drawing.Point(788, 9)
        Me.dolphinPic.Name = "dolphinPic"
        Me.dolphinPic.Size = New System.Drawing.Size(199, 100)
        Me.dolphinPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dolphinPic.TabIndex = 2
        Me.dolphinPic.TabStop = False
        '
        'nameLbl
        '
        Me.nameLbl.AutoSize = True
        Me.nameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLbl.Location = New System.Drawing.Point(356, 208)
        Me.nameLbl.Name = "nameLbl"
        Me.nameLbl.Size = New System.Drawing.Size(117, 37)
        Me.nameLbl.TabIndex = 3
        Me.nameLbl.Text = "Name:"
        '
        'passNameLbl
        '
        Me.passNameLbl.AutoSize = True
        Me.passNameLbl.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passNameLbl.Location = New System.Drawing.Point(496, 208)
        Me.passNameLbl.Name = "passNameLbl"
        Me.passNameLbl.Size = New System.Drawing.Size(0, 36)
        Me.passNameLbl.TabIndex = 4
        '
        'seatNumLbl
        '
        Me.seatNumLbl.AutoSize = True
        Me.seatNumLbl.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seatNumLbl.Location = New System.Drawing.Point(496, 265)
        Me.seatNumLbl.Name = "seatNumLbl"
        Me.seatNumLbl.Size = New System.Drawing.Size(0, 36)
        Me.seatNumLbl.TabIndex = 6
        '
        'seatLbl
        '
        Me.seatLbl.AutoSize = True
        Me.seatLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seatLbl.Location = New System.Drawing.Point(377, 265)
        Me.seatLbl.Name = "seatLbl"
        Me.seatLbl.Size = New System.Drawing.Size(96, 37)
        Me.seatLbl.TabIndex = 5
        Me.seatLbl.Text = "Seat:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(466, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(262, 36)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Boarding Pass"
        '
        'reservationDateLbl
        '
        Me.reservationDateLbl.AutoSize = True
        Me.reservationDateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reservationDateLbl.Location = New System.Drawing.Point(147, 320)
        Me.reservationDateLbl.Name = "reservationDateLbl"
        Me.reservationDateLbl.Size = New System.Drawing.Size(326, 37)
        Me.reservationDateLbl.TabIndex = 8
        Me.reservationDateLbl.Text = "Date of Reservation:"
        '
        'dateLbl
        '
        Me.dateLbl.AutoSize = True
        Me.dateLbl.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateLbl.Location = New System.Drawing.Point(496, 322)
        Me.dateLbl.Name = "dateLbl"
        Me.dateLbl.Size = New System.Drawing.Size(0, 36)
        Me.dateLbl.TabIndex = 9
        '
        'closeBtn
        '
        Me.closeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.Location = New System.Drawing.Point(472, 438)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(149, 63)
        Me.closeBtn.TabIndex = 10
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 530)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.dateLbl)
        Me.Controls.Add(Me.reservationDateLbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.seatNumLbl)
        Me.Controls.Add(Me.seatLbl)
        Me.Controls.Add(Me.passNameLbl)
        Me.Controls.Add(Me.nameLbl)
        Me.Controls.Add(Me.dolphinPic)
        Me.Controls.Add(Me.islandBreezesLbl)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.dolphinPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents islandBreezesLbl As Label
    Friend WithEvents dolphinPic As PictureBox
    Friend WithEvents nameLbl As Label
    Friend WithEvents passNameLbl As Label
    Friend WithEvents seatNumLbl As Label
    Friend WithEvents seatLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents reservationDateLbl As Label
    Friend WithEvents dateLbl As Label
    Friend WithEvents closeBtn As Button
End Class
