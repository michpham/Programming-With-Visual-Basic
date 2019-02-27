' Name:         Seminars Project
' Purpose:      Calculate and display the amount due.
' Programmer:   Michael Pham on 02/25/2019

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    ' Independent Function method
    Private Function getChecked() As Integer
        ' Determine which (if any) check boxes are selected
        ' and add the associated fee to the amount due.
        Dim total As Integer = 0

        If chkFinance.Checked = True Then
            total += 150
        End If
        If chkHealth.Checked = True Then
            total += 125
        End If
        If chkMarketing.Checked = True Then
            total += 135
        End If

        Return total
    End Function
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculate and display the amount due.

        Dim intAmountDue As Integer

        intAmountDue = Convert.ToInt32(getChecked())

        lblAmountDue.Text = intAmountDue.ToString("C0")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearAmountDue(sender As Object, e As EventArgs) Handles chkFinance.CheckedChanged,
                                                                         chkHealth.CheckedChanged,
                                                                         chkMarketing.CheckedChanged
        lblAmountDue.Text = String.Empty

    End Sub
End Class
