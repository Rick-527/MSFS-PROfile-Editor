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
        Dim backupFolder As String


        If String.IsNullOrWhiteSpace(sceneryFolder) Then
            MessageBox.Show("SceneryIndexes folder not found.")
            Exit Sub
        End If

        If Directory.Exists(My.Settings.IndexesBackupPath) Then

            backupFolder = My.Settings.IndexesBackupPath

        Else

            Using fbd As New FolderBrowserDialog()

                fbd.Description = "Select a backup folder for your scenery index backups."

                If fbd.ShowDialog() <> DialogResult.OK Then
                    Exit Sub
                End If

                backupFolder = fbd.SelectedPath

                My.Settings.IndexesBackupPath = backupFolder
                My.Settings.Save()

            End Using

        End If

        Dim sceneryFiles = Directory.GetFiles(sceneryFolder)

        If sceneryFiles.Length = 0 Then

            MessageBox.Show(
        "The SceneryIndexes folder is already empty.",
        "Nothing to Delete",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information)

            Exit Sub

        End If

        If MessageBox.Show("Would you like to back up your existing scenery indexes before deleting them?",
                           "Backup",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then

            If Directory.Exists(My.Settings.IndexesBackupPath) Then

                backupFolder = My.Settings.IndexesBackupPath

            Else

                Using fbd As New FolderBrowserDialog()

                    fbd.Description = "Select a backup folder for your scenery index backups."

                    If fbd.ShowDialog() <> DialogResult.OK Then
                        Exit Sub
                    End If

                    backupFolder = fbd.SelectedPath

                    My.Settings.IndexesBackupPath = backupFolder
                    My.Settings.Save()

                End Using

            End If

            Dim result As BackupOperationResult =
                SimulatorFilesManager.BackupSceneryIndexes(
                sceneryFolder,
                backupFolder)

            If result.Success Then

                Dim deleted As Integer =
                SimulatorFilesManager.DeleteSceneryIndexes(sceneryFolder)

                MessageBox.Show(
                    $"{result.FilesCopied} scenery index files were backed up." &
                    Environment.NewLine &
                    Environment.NewLine &
                    "Backup Location:" &
                    Environment.NewLine &
                    result.BackupFolder &
                    Environment.NewLine &
                    Environment.NewLine &
                    $"{deleted} scenery index files were deleted.")

            Else

                MessageBox.Show(result.ErrorMessage)

            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class