' Name: Translator Project
' Purpose: Displays translations.
' Programmer: Bj Jackson on 4/9/23
Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub radM_CheckedChanged(sender As Object, e As EventArgs) Handles radM.CheckedChanged, radF.CheckedChanged, radB.CheckedChanged, radS.CheckedChanged
        lblAnswer.Text = ""
    End Sub

    Private Sub btnTrans_Click(sender As Object, e As EventArgs) Handles btnTrans.Click

        If radM.Checked = True And cbL.SelectedIndex = 0 Then
            lblAnswer.Text = "Mère"
        ElseIf radF.Checked = True And cbL.SelectedIndex = 0 Then
            lblAnswer.Text = "Père"
        ElseIf radB.Checked = True And cbL.SelectedIndex = 0 Then
            lblAnswer.Text = "Frère"
        ElseIf radS.Checked = True And cbL.SelectedIndex = 0 Then
            lblAnswer.Text = "Sœur"
        ElseIf radM.Checked = True And cbL.SelectedIndex = 1 Then
            lblAnswer.Text = "Madre"
        ElseIf radF.Checked = True And cbL.SelectedIndex = 1 Then
            lblAnswer.Text = "Padre"
        ElseIf radB.Checked = True And cbL.SelectedIndex = 1 Then
            lblAnswer.Text = "Fratello"
        ElseIf radS.Checked = True And cbL.SelectedIndex = 1 Then
            lblAnswer.Text = "Sorella"
        ElseIf radM.Checked = True And cbL.SelectedIndex = 2 Then
            lblAnswer.Text = "Madre"
        ElseIf radF.Checked = True And cbL.SelectedIndex = 2 Then
            lblAnswer.Text = "Padre"
        ElseIf radB.Checked = True And cbL.SelectedIndex = 2 Then
            lblAnswer.Text = "Hermoso"
        ElseIf radS.Checked = True And cbL.SelectedIndex = 2 Then
            lblAnswer.Text = "Hermosa"
        End If



    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Do you want to exit?",
"Translator", MessageBoxButtons.YesNo,
MessageBoxIcon.Exclamation)
        If dlgButton = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbL.SelectedIndex = 0
    End Sub

    Private Sub cbL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbL.SelectedIndexChanged
        lblAnswer.Text = ""
    End Sub
End Class
