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
        Me.grpEnglish = New System.Windows.Forms.GroupBox()
        Me.radBrother = New System.Windows.Forms.RadioButton()
        Me.radSister = New System.Windows.Forms.RadioButton()
        Me.radFather = New System.Windows.Forms.RadioButton()
        Me.radMother = New System.Windows.Forms.RadioButton()
        Me.cmbTranslate = New System.Windows.Forms.ComboBox()
        Me.lblTrans = New System.Windows.Forms.Label()
        Me.btnTranslate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTranslate = New System.Windows.Forms.Label()
        Me.grpEnglish.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpEnglish
        '
        Me.grpEnglish.Controls.Add(Me.radBrother)
        Me.grpEnglish.Controls.Add(Me.radSister)
        Me.grpEnglish.Controls.Add(Me.radFather)
        Me.grpEnglish.Controls.Add(Me.radMother)
        Me.grpEnglish.Location = New System.Drawing.Point(12, 12)
        Me.grpEnglish.Name = "grpEnglish"
        Me.grpEnglish.Size = New System.Drawing.Size(129, 133)
        Me.grpEnglish.TabIndex = 1
        Me.grpEnglish.TabStop = False
        Me.grpEnglish.Text = "English"
        '
        'radBrother
        '
        Me.radBrother.AutoSize = True
        Me.radBrother.Location = New System.Drawing.Point(7, 101)
        Me.radBrother.Name = "radBrother"
        Me.radBrother.Size = New System.Drawing.Size(64, 19)
        Me.radBrother.TabIndex = 3
        Me.radBrother.TabStop = True
        Me.radBrother.Text = "&Brother"
        Me.radBrother.UseVisualStyleBackColor = True
        '
        'radSister
        '
        Me.radSister.AutoSize = True
        Me.radSister.Location = New System.Drawing.Point(7, 75)
        Me.radSister.Name = "radSister"
        Me.radSister.Size = New System.Drawing.Size(53, 19)
        Me.radSister.TabIndex = 2
        Me.radSister.TabStop = True
        Me.radSister.Text = "&Sister"
        Me.radSister.UseVisualStyleBackColor = True
        '
        'radFather
        '
        Me.radFather.AutoSize = True
        Me.radFather.Location = New System.Drawing.Point(7, 49)
        Me.radFather.Name = "radFather"
        Me.radFather.Size = New System.Drawing.Size(58, 19)
        Me.radFather.TabIndex = 1
        Me.radFather.TabStop = True
        Me.radFather.Text = "&Father"
        Me.radFather.UseVisualStyleBackColor = True
        '
        'radMother
        '
        Me.radMother.AutoSize = True
        Me.radMother.Location = New System.Drawing.Point(7, 23)
        Me.radMother.Name = "radMother"
        Me.radMother.Size = New System.Drawing.Size(64, 19)
        Me.radMother.TabIndex = 0
        Me.radMother.TabStop = True
        Me.radMother.Text = "&Mother"
        Me.radMother.UseVisualStyleBackColor = True
        '
        'cmbTranslate
        '
        Me.cmbTranslate.FormattingEnabled = True
        Me.cmbTranslate.Items.AddRange(New Object() {"Italian", "Spanish", "French"})
        Me.cmbTranslate.Location = New System.Drawing.Point(180, 34)
        Me.cmbTranslate.Name = "cmbTranslate"
        Me.cmbTranslate.Size = New System.Drawing.Size(110, 23)
        Me.cmbTranslate.TabIndex = 3
        '
        'lblTrans
        '
        Me.lblTrans.AutoSize = True
        Me.lblTrans.Location = New System.Drawing.Point(177, 12)
        Me.lblTrans.Name = "lblTrans"
        Me.lblTrans.Size = New System.Drawing.Size(71, 15)
        Me.lblTrans.TabIndex = 2
        Me.lblTrans.Text = "T&ranslate to:"
        '
        'btnTranslate
        '
        Me.btnTranslate.Location = New System.Drawing.Point(315, 33)
        Me.btnTranslate.Name = "btnTranslate"
        Me.btnTranslate.Size = New System.Drawing.Size(75, 23)
        Me.btnTranslate.TabIndex = 4
        Me.btnTranslate.Text = "&Translate"
        Me.btnTranslate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(315, 71)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTranslate
        '
        Me.lblTranslate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTranslate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTranslate.Location = New System.Drawing.Point(180, 92)
        Me.lblTranslate.Name = "lblTranslate"
        Me.lblTranslate.Size = New System.Drawing.Size(110, 53)
        Me.lblTranslate.TabIndex = 0
        Me.lblTranslate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(409, 184)
        Me.Controls.Add(Me.lblTranslate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTranslate)
        Me.Controls.Add(Me.lblTrans)
        Me.Controls.Add(Me.cmbTranslate)
        Me.Controls.Add(Me.grpEnglish)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Translator"
        Me.grpEnglish.ResumeLayout(False)
        Me.grpEnglish.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpEnglish As GroupBox
    Friend WithEvents radBrother As RadioButton
    Friend WithEvents radSister As RadioButton
    Friend WithEvents radFather As RadioButton
    Friend WithEvents radMother As RadioButton
    Friend WithEvents cmbTranslate As ComboBox
    Friend WithEvents lblTrans As Label
    Friend WithEvents btnTranslate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTranslate As Label
End Class
