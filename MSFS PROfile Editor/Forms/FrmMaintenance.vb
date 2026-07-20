Imports System.IO

Public Class FrmMaintenance


    Private Sub FrmMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ThemeManager.ApplyModernTheme(Me)

    End Sub

    Private Sub btnClearRolingCache_Click(sender As Object, e As EventArgs) Handles btnClearRolingCache.Click

        If SimulatorFilesManager.DeleteFile(SimulatorFile.RollingCache) Then
            MessageBox.Show("Rolling cache deleted.")
        Else
            MessageBox.Show("Rolling cache not found.")
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

End Class