' Name:         Gross Project
' Purpose:      Display an employee's gross pay.
' Programmer:   Michael Pham on 02/25/2019

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    ' Independent Function procedures.
    Private Function CalcWeekly(ByVal intWeekly As Integer) As Integer
        ' Displays the weekly gross pay

        Dim dblPay As Double
        dblPay = intWeekly / 52
        lblGross.Text = dblPay.ToString("C2")
    End Function

    Private Function CalcTwicePerMonth(ByVal intTwicePerMonth As Integer) As Integer
        ' Displays the twice per month gross pay

        Dim dblPay As Double
        dblPay = intTwicePerMonth / 24
        lblGross.Text = dblPay.ToString("C2")
    End Function

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calls independent Sub procedures to calculate and display the gross pay.

        Dim intSalary As Integer

        Integer.TryParse(txtSalary.Text, intSalary)
        If radWeekly.Checked Then
            CalcWeekly(intSalary)
        Else
            CalcTwicePerMonth(intSalary)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtSalary_Enter(sender As Object, e As EventArgs) Handles txtSalary.Enter
        txtSalary.SelectAll()
    End Sub

    Private Sub ClearGross(sender As Object, e As EventArgs) Handles txtSalary.TextChanged, radWeekly.CheckedChanged, radTwicePerMonth.CheckedChanged
        lblGross.Text = String.Empty
    End Sub

    Private Sub txtSalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalary.KeyPress
        ' Accept only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
