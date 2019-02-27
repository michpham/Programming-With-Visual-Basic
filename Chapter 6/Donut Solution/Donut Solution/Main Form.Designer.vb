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
        Me.lblStatement = New System.Windows.Forms.Label()
        Me.grpDoughuts = New System.Windows.Forms.GroupBox()
        Me.radFilled = New System.Windows.Forms.RadioButton()
        Me.radChocolate = New System.Windows.Forms.RadioButton()
        Me.radSugar = New System.Windows.Forms.RadioButton()
        Me.radGlazed = New System.Windows.Forms.RadioButton()
        Me.lblDisplayBox = New System.Windows.Forms.Label()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.lblSal = New System.Windows.Forms.Label()
        Me.lblTot = New System.Windows.Forms.Label()
        Me.grpCoffee = New System.Windows.Forms.GroupBox()
        Me.radCappucino = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.radNone = New System.Windows.Forms.RadioButton()
        Me.lblCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpDoughuts.SuspendLayout()
        Me.grpCoffee.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStatement
        '
        Me.lblStatement.AutoSize = True
        Me.lblStatement.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatement.Location = New System.Drawing.Point(49, 9)
        Me.lblStatement.Name = "lblStatement"
        Me.lblStatement.Size = New System.Drawing.Size(354, 21)
        Me.lblStatement.TabIndex = 0
        Me.lblStatement.Text = "Our donuts and coffee are the best in town!"
        '
        'grpDoughuts
        '
        Me.grpDoughuts.Controls.Add(Me.radFilled)
        Me.grpDoughuts.Controls.Add(Me.radChocolate)
        Me.grpDoughuts.Controls.Add(Me.radSugar)
        Me.grpDoughuts.Controls.Add(Me.radGlazed)
        Me.grpDoughuts.Location = New System.Drawing.Point(68, 33)
        Me.grpDoughuts.Name = "grpDoughuts"
        Me.grpDoughuts.Size = New System.Drawing.Size(153, 141)
        Me.grpDoughuts.TabIndex = 1
        Me.grpDoughuts.TabStop = False
        Me.grpDoughuts.Text = "Doughnut choices"
        '
        'radFilled
        '
        Me.radFilled.AutoSize = True
        Me.radFilled.Location = New System.Drawing.Point(6, 98)
        Me.radFilled.Name = "radFilled"
        Me.radFilled.Size = New System.Drawing.Size(91, 19)
        Me.radFilled.TabIndex = 3
        Me.radFilled.TabStop = True
        Me.radFilled.Text = "&Filled ($1.50)"
        Me.radFilled.UseVisualStyleBackColor = True
        '
        'radChocolate
        '
        Me.radChocolate.AutoSize = True
        Me.radChocolate.Location = New System.Drawing.Point(6, 72)
        Me.radChocolate.Name = "radChocolate"
        Me.radChocolate.Size = New System.Drawing.Size(117, 19)
        Me.radChocolate.TabIndex = 2
        Me.radChocolate.TabStop = True
        Me.radChocolate.Text = "C&hocolate ($1.25)"
        Me.radChocolate.UseVisualStyleBackColor = True
        '
        'radSugar
        '
        Me.radSugar.AutoSize = True
        Me.radSugar.Location = New System.Drawing.Point(6, 47)
        Me.radSugar.Name = "radSugar"
        Me.radSugar.Size = New System.Drawing.Size(93, 19)
        Me.radSugar.TabIndex = 1
        Me.radSugar.TabStop = True
        Me.radSugar.Text = "&Sugar ($1.05)"
        Me.radSugar.UseVisualStyleBackColor = True
        '
        'radGlazed
        '
        Me.radGlazed.AutoSize = True
        Me.radGlazed.Location = New System.Drawing.Point(6, 22)
        Me.radGlazed.Name = "radGlazed"
        Me.radGlazed.Size = New System.Drawing.Size(98, 19)
        Me.radGlazed.TabIndex = 0
        Me.radGlazed.TabStop = True
        Me.radGlazed.Text = "&Glazed ($1.05)"
        Me.radGlazed.UseVisualStyleBackColor = True
        '
        'lblDisplayBox
        '
        Me.lblDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplayBox.Location = New System.Drawing.Point(250, 38)
        Me.lblDisplayBox.Name = "lblDisplayBox"
        Me.lblDisplayBox.Size = New System.Drawing.Size(141, 136)
        Me.lblDisplayBox.TabIndex = 8
        '
        'lblSub
        '
        Me.lblSub.AutoSize = True
        Me.lblSub.Location = New System.Drawing.Point(261, 57)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(54, 15)
        Me.lblSub.TabIndex = 6
        Me.lblSub.Text = "Subtotal:"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubtotal.Location = New System.Drawing.Point(322, 55)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(53, 19)
        Me.lblSubtotal.TabIndex = 7
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(322, 131)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(53, 19)
        Me.lblTotal.TabIndex = 0
        '
        'lblSales
        '
        Me.lblSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSales.Location = New System.Drawing.Point(322, 94)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(53, 19)
        Me.lblSales.TabIndex = 10
        '
        'lblSal
        '
        Me.lblSal.AutoSize = True
        Me.lblSal.Location = New System.Drawing.Point(261, 95)
        Me.lblSal.Name = "lblSal"
        Me.lblSal.Size = New System.Drawing.Size(54, 15)
        Me.lblSal.TabIndex = 9
        Me.lblSal.Text = "Sales tax:"
        '
        'lblTot
        '
        Me.lblTot.AutoSize = True
        Me.lblTot.Location = New System.Drawing.Point(261, 133)
        Me.lblTot.Name = "lblTot"
        Me.lblTot.Size = New System.Drawing.Size(59, 15)
        Me.lblTot.TabIndex = 11
        Me.lblTot.Text = "Total due:"
        '
        'grpCoffee
        '
        Me.grpCoffee.Controls.Add(Me.radCappucino)
        Me.grpCoffee.Controls.Add(Me.radRegular)
        Me.grpCoffee.Controls.Add(Me.radNone)
        Me.grpCoffee.Location = New System.Drawing.Point(68, 180)
        Me.grpCoffee.Name = "grpCoffee"
        Me.grpCoffee.Size = New System.Drawing.Size(153, 100)
        Me.grpCoffee.TabIndex = 2
        Me.grpCoffee.TabStop = False
        Me.grpCoffee.Text = "Coffee choices"
        '
        'radCappucino
        '
        Me.radCappucino.AutoSize = True
        Me.radCappucino.Location = New System.Drawing.Point(7, 75)
        Me.radCappucino.Name = "radCappucino"
        Me.radCappucino.Size = New System.Drawing.Size(127, 19)
        Me.radCappucino.TabIndex = 2
        Me.radCappucino.TabStop = True
        Me.radCappucino.Text = "Ca&ppuccino ($2.75)"
        Me.radCappucino.UseVisualStyleBackColor = True
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Location = New System.Drawing.Point(7, 49)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(103, 19)
        Me.radRegular.TabIndex = 1
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "&Regular ($1.50)"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'radNone
        '
        Me.radNone.AutoSize = True
        Me.radNone.Location = New System.Drawing.Point(7, 23)
        Me.radNone.Name = "radNone"
        Me.radNone.Size = New System.Drawing.Size(54, 19)
        Me.radNone.TabIndex = 0
        Me.radNone.TabStop = True
        Me.radNone.Text = "&None"
        Me.radNone.UseVisualStyleBackColor = True
        '
        'lblCalculate
        '
        Me.lblCalculate.Location = New System.Drawing.Point(316, 199)
        Me.lblCalculate.Name = "lblCalculate"
        Me.lblCalculate.Size = New System.Drawing.Size(75, 23)
        Me.lblCalculate.TabIndex = 3
        Me.lblCalculate.Text = "&Calculate"
        Me.lblCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(316, 229)
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
        Me.ClientSize = New System.Drawing.Size(453, 301)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblCalculate)
        Me.Controls.Add(Me.grpCoffee)
        Me.Controls.Add(Me.lblTot)
        Me.Controls.Add(Me.lblSal)
        Me.Controls.Add(Me.lblSales)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.lblSub)
        Me.Controls.Add(Me.lblDisplayBox)
        Me.Controls.Add(Me.grpDoughuts)
        Me.Controls.Add(Me.lblStatement)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Donut Shoppe"
        Me.grpDoughuts.ResumeLayout(False)
        Me.grpDoughuts.PerformLayout()
        Me.grpCoffee.ResumeLayout(False)
        Me.grpCoffee.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStatement As Label
    Friend WithEvents grpDoughuts As GroupBox
    Friend WithEvents radFilled As RadioButton
    Friend WithEvents radChocolate As RadioButton
    Friend WithEvents radSugar As RadioButton
    Friend WithEvents radGlazed As RadioButton
    Friend WithEvents lblDisplayBox As Label
    Friend WithEvents lblSub As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblSales As Label
    Friend WithEvents lblSal As Label
    Friend WithEvents lblTot As Label
    Friend WithEvents grpCoffee As GroupBox
    Friend WithEvents radCappucino As RadioButton
    Friend WithEvents radRegular As RadioButton
    Friend WithEvents radNone As RadioButton
    Friend WithEvents lblCalculate As Button
    Friend WithEvents btnExit As Button
End Class
