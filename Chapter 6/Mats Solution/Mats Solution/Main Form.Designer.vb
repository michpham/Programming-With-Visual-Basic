<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.grpType = New System.Windows.Forms.GroupBox()
        Me.radPremium = New System.Windows.Forms.RadioButton()
        Me.radDeluxe = New System.Windows.Forms.RadioButton()
        Me.radStandard = New System.Windows.Forms.RadioButton()
        Me.grpColor = New System.Windows.Forms.GroupBox()
        Me.radPink = New System.Windows.Forms.RadioButton()
        Me.radRed = New System.Windows.Forms.RadioButton()
        Me.radBlue = New System.Windows.Forms.RadioButton()
        Me.chkFoldable = New System.Windows.Forms.CheckBox()
        Me.lblPr = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpType.SuspendLayout()
        Me.grpColor.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpType
        '
        Me.grpType.Controls.Add(Me.radPremium)
        Me.grpType.Controls.Add(Me.radDeluxe)
        Me.grpType.Controls.Add(Me.radStandard)
        Me.grpType.Location = New System.Drawing.Point(12, 12)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(144, 100)
        Me.grpType.TabIndex = 0
        Me.grpType.TabStop = False
        Me.grpType.Text = "Type"
        '
        'radPremium
        '
        Me.radPremium.AutoSize = True
        Me.radPremium.Location = New System.Drawing.Point(6, 72)
        Me.radPremium.Name = "radPremium"
        Me.radPremium.Size = New System.Drawing.Size(109, 19)
        Me.radPremium.TabIndex = 2
        Me.radPremium.TabStop = True
        Me.radPremium.Text = "&Premium ($179)"
        Me.radPremium.UseVisualStyleBackColor = True
        '
        'radDeluxe
        '
        Me.radDeluxe.AutoSize = True
        Me.radDeluxe.Location = New System.Drawing.Point(6, 47)
        Me.radDeluxe.Name = "radDeluxe"
        Me.radDeluxe.Size = New System.Drawing.Size(95, 19)
        Me.radDeluxe.TabIndex = 1
        Me.radDeluxe.TabStop = True
        Me.radDeluxe.Text = "&Deluxe ($129)"
        Me.radDeluxe.UseVisualStyleBackColor = True
        '
        'radStandard
        '
        Me.radStandard.AutoSize = True
        Me.radStandard.Location = New System.Drawing.Point(6, 22)
        Me.radStandard.Name = "radStandard"
        Me.radStandard.Size = New System.Drawing.Size(101, 19)
        Me.radStandard.TabIndex = 0
        Me.radStandard.TabStop = True
        Me.radStandard.Text = "&Standard ($99)"
        Me.radStandard.UseVisualStyleBackColor = True
        '
        'grpColor
        '
        Me.grpColor.Controls.Add(Me.radPink)
        Me.grpColor.Controls.Add(Me.radRed)
        Me.grpColor.Controls.Add(Me.radBlue)
        Me.grpColor.Location = New System.Drawing.Point(162, 12)
        Me.grpColor.Name = "grpColor"
        Me.grpColor.Size = New System.Drawing.Size(144, 100)
        Me.grpColor.TabIndex = 1
        Me.grpColor.TabStop = False
        Me.grpColor.Text = "Color"
        '
        'radPink
        '
        Me.radPink.AutoSize = True
        Me.radPink.Location = New System.Drawing.Point(6, 72)
        Me.radPink.Name = "radPink"
        Me.radPink.Size = New System.Drawing.Size(105, 19)
        Me.radPink.TabIndex = 2
        Me.radPink.TabStop = True
        Me.radPink.Text = "Pin&k ($15 extra)"
        Me.radPink.UseVisualStyleBackColor = True
        '
        'radRed
        '
        Me.radRed.AutoSize = True
        Me.radRed.Location = New System.Drawing.Point(6, 47)
        Me.radRed.Name = "radRed"
        Me.radRed.Size = New System.Drawing.Size(102, 19)
        Me.radRed.TabIndex = 1
        Me.radRed.TabStop = True
        Me.radRed.Text = "&Red ($10 extra)"
        Me.radRed.UseVisualStyleBackColor = True
        '
        'radBlue
        '
        Me.radBlue.AutoSize = True
        Me.radBlue.Location = New System.Drawing.Point(6, 22)
        Me.radBlue.Name = "radBlue"
        Me.radBlue.Size = New System.Drawing.Size(48, 19)
        Me.radBlue.TabIndex = 0
        Me.radBlue.TabStop = True
        Me.radBlue.Text = "&Blue"
        Me.radBlue.UseVisualStyleBackColor = True
        '
        'chkFoldable
        '
        Me.chkFoldable.AutoSize = True
        Me.chkFoldable.Location = New System.Drawing.Point(324, 25)
        Me.chkFoldable.Name = "chkFoldable"
        Me.chkFoldable.Size = New System.Drawing.Size(128, 19)
        Me.chkFoldable.TabIndex = 2
        Me.chkFoldable.Text = "&Foldable ($25 extra)"
        Me.chkFoldable.UseVisualStyleBackColor = True
        '
        'lblPr
        '
        Me.lblPr.AutoSize = True
        Me.lblPr.Location = New System.Drawing.Point(321, 61)
        Me.lblPr.Name = "lblPr"
        Me.lblPr.Size = New System.Drawing.Size(36, 15)
        Me.lblPr.TabIndex = 5
        Me.lblPr.Text = "Price:"
        '
        'lblPrice
        '
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblPrice.Location = New System.Drawing.Point(363, 56)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(130, 33)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(324, 92)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(407, 92)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(505, 145)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblPr)
        Me.Controls.Add(Me.chkFoldable)
        Me.Controls.Add(Me.grpColor)
        Me.Controls.Add(Me.grpType)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mats-R-Us"
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        Me.grpColor.ResumeLayout(False)
        Me.grpColor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpType As GroupBox
    Friend WithEvents radPremium As RadioButton
    Friend WithEvents radDeluxe As RadioButton
    Friend WithEvents radStandard As RadioButton
    Friend WithEvents grpColor As GroupBox
    Friend WithEvents radPink As RadioButton
    Friend WithEvents radRed As RadioButton
    Friend WithEvents radBlue As RadioButton
    Friend WithEvents chkFoldable As CheckBox
    Friend WithEvents lblPr As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
End Class
