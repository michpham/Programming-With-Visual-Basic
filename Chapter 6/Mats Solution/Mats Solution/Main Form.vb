' Name: Mats-R-Us
' Purpose: Calculate total price of a mattress
' Programmer: Michael Pham on 02/25/2019
Public Class frmMain
    ' Private Function procedure
    Private Function getTotal(ByVal total As Double) As Double
        ' Calculate and return total price
        Select Case True
            Case radStandard.Checked
                total += 99
            Case radDeluxe.Checked
                total += 129
            Case radPremium.Checked
                total += 179
        End Select

        Select Case True
            Case radRed.Checked
                total += 10
            Case radPink.Checked
                total += 15
        End Select

        If (chkFoldable.Checked) Then
            total += 25
        End If

        Return total
    End Function
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Calculate and display total price
        Dim total As Double

        total = getTotal(total)

        lblPrice.Text = total.ToString("C2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub clearPrice(sender As Object, e As EventArgs) Handles radStandard.CheckedChanged,
                                                                     radDeluxe.CheckedChanged,
                                                                     radPremium.CheckedChanged,
                                                                     radBlue.CheckedChanged,
                                                                     radRed.CheckedChanged,
                                                                     radPink.CheckedChanged,
                                                                     chkFoldable.CheckedChanged
        lblPrice.Text = String.Empty
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radStandard.Checked = True
        radBlue.Checked = True
    End Sub
End Class
