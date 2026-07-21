Imports System.IO

Public Class FrmMaintenance


    Private Sub FrmMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ThemeManager.ApplyModernTheme(Me)

    End Sub

    Private Sub btnClearRollingCache_Click(sender As Object, e As EventArgs) Handles btnClearRollingCache.Click

        If SimulatorFilesManager.DeleteFile(SimulatorFile.RollingCache) Then
            MessageBox.Show("Rolling cache deleted.")
        Else
            MessageBox.Show("Rolling cache not found.")
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub btnDeleteSceneryIndexes_Click(sender As Object, e As EventArgs) Handles btnDeleteSceneryIndexes.Click

        Dim sceneryFolder As String =
            SimulatorFilesManager.GetSceneryIndexesFolder()

        If String.IsNullOrWhiteSpace(sceneryFolder) Then
            MessageBox.Show("SceneryIndexes folder not found.")
            Exit Sub
        End If

        If MessageBox.Show("Would you like to back up your existing scenery indexes before deleting them?",
                           "Backup",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then

            Using fbd As New FolderBrowserDialog()

                If fbd.ShowDialog() = DialogResult.OK Then

                    Dim copied As Integer =
                        SimulatorFilesManager.BackupSceneryIndexes(
                            sceneryFolder,
                            fbd.SelectedPath)

                    MessageBox.Show($"{copied} scenery index files backed up.")

                End If

            End Using

        End If
    End Sub
End Class