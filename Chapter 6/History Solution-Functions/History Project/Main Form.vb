' Name:         History Project
' Purpose:      Display a student's grade.
' Programmer:   Michael Pham on 02/25/2019

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    ' Independent Sub procedures.


    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Calls independent Sub procedures to display a grade.
        Dim totalPoints As Integer

        Integer.TryParse(txtPoints.Text, totalPoints)

        If radHis101.Checked Then
            DisplayGrade101(totalPoints)
        Else
            DisplayGrade202(totalPoints)
        End If
    End Sub

    ' Independent Function procedures
    Private Function DisplayGrade101(ByVal points As Integer) As Integer
        ' Display the grade for History 101

        Dim intPoints As Integer = points

        Select Case intPoints
            Case Is >= 90
                lblGrade.Text = "A"
            Case Is >= 80
                lblGrade.Text = "B"
            Case Is >= 70
                lblGrade.Text = "C"
            Case Is >= 60
                lblGrade.Text = "D"
            Case Else
                lblGrade.Text = "F"
        End Select
    End Function
    Private Function DisplayGrade202(ByVal points As Integer) As Integer
        ' Display the grade for History 202

        Dim intPoints As Integer = points

        If intPoints >= 75 Then
            lblGrade.Text = "P"
        Else
            lblGrade.Text = "F"
        End If
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtPoints_Enter(sender As Object, e As EventArgs) Handles txtPoints.Enter
        txtPoints.SelectAll()
    End Sub

    Private Sub ClearGrade(sender As Object, e As EventArgs) Handles txtPoints.TextChanged, radHis101.CheckedChanged, radHis201.CheckedChanged
        lblGrade.Text = String.Empty
    End Sub

    Private Sub txtPoints_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPoints.KeyPress
        ' Accept only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
