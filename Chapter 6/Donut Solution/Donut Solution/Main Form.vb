' Name: Donut shoppe
' Purpose: Calculate the cost of doughnut and coffee choices
' Programmer: Michael Pham on 02/25/2019

Public Class frmMain
    ' Independent Function procedures
    Private Function calculateSubTotal() As Double
        ' Calculate subtotal

        Dim subtotal As Double

        Select Case True
            Case radGlazed.Checked
                subtotal += 1.05
            Case radSugar.Checked
                subtotal += 1.05
            Case radChocolate.Checked
                subtotal += 1.25
            Case radFilled.Checked
                subtotal += 1.5
        End Select

        Select Case True
            Case radRegular.Checked
                subtotal += 1.5
            Case radCappucino.Checked
                subtotal += 2.75
        End Select

        Return subtotal
    End Function

    Private Function calculateSalesTax(ByVal subtotal As Double) As Double
        ' Calculate a 6% tax

        Return subtotal * 0.06
    End Function

    Private Function calculateTotal(ByVal subtotal As Double,
                                    ByVal salesTax As Double) As Double
        ' Calculate total

        Return subtotal + salesTax
    End Function

    Private Sub lblCalculate_Click(sender As Object, e As EventArgs) Handles lblCalculate.Click
        ' Calculate subtotal, tax, and total
        Dim subtotal As Double
        Dim salesTax As Double
        Dim total As Double

        subtotal = calculateSubTotal()
        salesTax = calculateSalesTax(subtotal)
        total = calculateTotal(subtotal, salesTax)

        lblSubtotal.Text = subtotal.ToString("C2")
        lblSales.Text = salesTax.ToString("C2")
        lblTotal.Text = total.ToString("C2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub clearLabels(sender As Object, e As EventArgs) Handles radGlazed.CheckedChanged,
                                                                      radSugar.CheckedChanged,
                                                                      radChocolate.CheckedChanged,
                                                                      radFilled.CheckedChanged,
                                                                      radNone.CheckedChanged,
                                                                      radRegular.CheckedChanged,
                                                                      radCappucino.CheckedChanged

        lblSubtotal.Text = String.Empty
        lblSales.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radGlazed.Checked = True
        radNone.Checked = True
    End Sub
End Class
