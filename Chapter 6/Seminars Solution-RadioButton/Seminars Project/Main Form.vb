' Name:         Seminars Project
' Purpose:      Display the amount due.
' Programmer:   Michael Pham on 02/25/2019

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    ' Independent Sub procedure
    Private Sub getChecked(ByVal intAmountDue As Integer)
        Select Case True
            Case radFinance.Checked
                intAmountDue = 150
            Case radHealth.Checked
                intAmountDue = 125
            Case radMarketing.Checked
                intAmountDue = 135
        End Select

        lblAmountDue.Text = intAmountDue.ToString("C0")
    End Sub
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Display the amount due.

        Dim intAmountDue As Integer

        getChecked(intAmountDue)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub clearAmountDue(sender As Object, e As EventArgs) Handles radFinance.CheckedChanged,
                                                                                    radHealth.CheckedChanged,
                                                                                    radMarketing.CheckedChanged
        lblAmountDue.Text = String.Empty
    End Sub

End Class
