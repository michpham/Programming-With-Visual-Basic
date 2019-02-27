' Name: Translator
' Purpose: Translate mother, father, brother, and sister into different languages
' Programmer: Michael Pham on 02/25/2019
Public Class frmMain
    ' Private Function procedures
    Private Function toFrench() As String
        ' Change selected word to French
        Select Case True
            Case radMother.Checked
                lblTranslate.Text = "Mère"
            Case radFather.Checked
                lblTranslate.Text = "Père"
            Case radBrother.Checked
                lblTranslate.Text = "Frère"
            Case radSister.Checked
                lblTranslate.Text = "Sœur"
        End Select
    End Function

    Private Function toItalian() As String
        ' Change selected word to Italian
        Select Case True
            Case radMother.Checked
                lblTranslate.Text = "Madre"
            Case radFather.Checked
                lblTranslate.Text = "Padre"
            Case radBrother.Checked
                lblTranslate.Text = "Fratello"
            Case radSister.Checked
                lblTranslate.Text = "Sorella"
        End Select
    End Function

    Private Function toSpanish() As String
        ' Change select word to Spanish
        Select Case True
            Case radMother.Checked
                lblTranslate.Text = "Madre"
            Case radFather.Checked
                lblTranslate.Text = "Padre"
            Case radBrother.Checked
                lblTranslate.Text = "Hermano"
            Case radSister.Checked
                lblTranslate.Text = "Hermana"
        End Select
    End Function

    Private Sub btnTranslate_Click(sender As Object, e As EventArgs) Handles btnTranslate.Click
        ' Translate word to selected language

        If (cmbTranslate.SelectedItem = "French") Then
            toFrench()
        ElseIf (cmbTranslate.SelectedItem = "Italian") Then
            toItalian()
        Else
            toSpanish()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub clearTranslate(sender As Object, e As EventArgs) Handles radMother.CheckedChanged,
                                                                         radFather.CheckedChanged,
                                                                         radBrother.CheckedChanged,
                                                                         radSister.CheckedChanged
        lblTranslate.Text = String.Empty
    End Sub
End Class
