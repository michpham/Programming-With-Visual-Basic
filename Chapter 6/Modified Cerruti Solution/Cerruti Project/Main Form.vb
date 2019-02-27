' Name:         Cerruti Project
' Purpose:      Displays an employee's gross pay, taxes, and net pay.
' Programmer:   Michael Pham on 02/25/2019

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    ' Independent Sub procedure and function.
    Private Function GetSingleFwt(ByVal dblTaxPay As Double,
                                  ByRef dblFedWthTax As Double) As Double
        Select Case dblTaxPay
            Case Is <= 44
                dblFedWthTax = 0
            Case Is <= 224
                dblFedWthTax = 0.1 * (dblTaxPay - 44)
            Case Is <= 774
                dblFedWthTax = 18 + 0.15 * (dblTaxPay - 224)
            Case Is <= 1812
                dblFedWthTax = 100.5 + 0.25 * (dblTaxPay - 774)
            Case Is <= 3730
                dblFedWthTax = 360 + 0.28 * (dblTaxPay - 1812)
            Case Is <= 8058
                dblFedWthTax = 897.04 + 0.33 * (dblTaxPay - 3730)
            Case Is <= 8090
                dblFedWthTax = 2325.28 + 0.35 * (dblTaxPay - 8058)
            Case Else
                dblFedWthTax = 2336.48 + 0.396 * (dblTaxPay - 8090)
        End Select
    End Function

    Private Sub GetMarriedFwt(ByVal dblTaxPay As Double)
        Dim dblFedWthTax As Double

        Select Case dblTaxPay
            Case Is <= 166
                dblFedWthTax = 0
            Case Is <= 525
                dblFedWthTax = 0.1 * (dblTaxPay - 166)
            Case Is <= 1626
                dblFedWthTax = 35.9 + 0.15 * (dblTaxPay - 525)
            Case Is <= 3111
                dblFedWthTax = 201.05 + 0.25 * (dblTaxPay - 1626)
            Case Is <= 4654
                dblFedWthTax = 572.3 + 0.28 * (dblTaxPay - 3111)
            Case Is <= 8180
                dblFedWthTax = 1004.34 + 0.33 * (dblTaxPay - 4654)
            Case Is <= 9218
                dblFedWthTax = 2167.92 + 0.35 * (dblTaxPay - 8180)
            Case Else
                dblFedWthTax = 2531.22 + 0.396 * (dblTaxPay - 9218)
        End Select
    End Sub
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculates and displays gross pay, taxes, and net pay.

        Const dblONE_ALLOWANCE As Double = 77.9
        Const dblFICA_RATE As Double = 0.0765
        Dim dblHours As Double
        Dim dblPayRate As Double
        Dim intAllowances As Integer
        Dim dblGross As Double
        Dim dblTaxable As Double
        Dim dblFwt As Double
        Dim dblFica As Double
        Dim dblNet As Double

        Double.TryParse(lstHours.SelectedItem.ToString, dblHours)
        Double.TryParse(lstRates.SelectedItem.ToString, dblPayRate)
        Integer.TryParse(cboAllowances.Text, intAllowances)

        ' Calculate gross pay.
        If dblHours <= 40 Then
            dblGross = dblHours * dblPayRate
        Else
            dblGross = 40 * dblPayRate + (dblHours - 40) * dblPayRate * 1.5
        End If

        ' Calculate taxable wages.
        dblTaxable = dblGross - (intAllowances * dblONE_ALLOWANCE)

        ' Determine the FWT.


        ' Calculate FICA tax.
        dblFica = dblGross * dblFICA_RATE
        ' Round gross pay, FWT, and FICA tax.

        ' Calculate net pay.
        dblNet = dblGross - dblFwt - dblFica

        ' Display calculated amounts.
        lblGross.Text = dblGross.ToString("N2")
        lblFwt.Text = dblFwt.ToString("N2")
        lblFica.Text = dblFica.ToString("N2")
        lblNet.Text = dblNet.ToString("N2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        txtName.SelectAll()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Fill list boxes and combo box with values and select a default value in each.

        For dblHours As Double = 0 To 55 Step 0.5
            lstHours.Items.Add(dblHours.ToString("N1"))
        Next dblHours
        lstHours.SelectedItem = "40.0"

        For dblRates As Double = 7.5 To 15.5 Step 0.5
            lstRates.Items.Add(dblRates.ToString("N2"))
        Next dblRates
        lstRates.SelectedItem = "9.50"


    End Sub

End Class
