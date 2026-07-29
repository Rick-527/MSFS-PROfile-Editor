Imports System.IO

Public Class FrmMaintenance


    Private Sub FrmMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BackgroundManager.Apply(Me, "masterBackgroundForm1.png")
        ThemeManager.ApplyModernTheme(Me)

    End Sub

    Private Sub btnDeleteRollingCache_Click(sender As Object, e As EventArgs) Handles btnDeleteRollingCache.Click

        If Not SimulatorFilesManager.FileExists(SimulatorFile.RollingCache) Then

            MessageBox.Show(
                "The Rolling Cache file was not found.",
                "MSFS PROfile Editor",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                )

            Exit Sub

        End If

        Dim response As DialogResult = MessageBox.Show(
            "Are you sure you want to delete the Rolling Cache file?",
            "MSFS PROfile Editor",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question
            )

        If response <> DialogResult.Yes Then Exit Sub

        Dim deleted = UiActionRunner.RunWithResult(
            Me,
            lblStatus,
            "Deleting Rolling Cache...",
            Function()
                Return SimulatorFilesManager.DeleteFile(SimulatorFile.RollingCache)
            End Function
            )

        If deleted Then

            MessageBox.Show(
                "The Rolling Cache was deleted successfully.",
                "MSFS PROfile Editor",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                )

        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub btnDeleteSceneryIndexes_Click(sender As Object, e As EventArgs) Handles btnDeleteSceneryIndexes.Click

        Dim sceneryFolder = SimulatorFilesManager.GetSceneryIndexesFolder()

        If String.IsNullOrWhiteSpace(sceneryFolder) Then
            MessageBox.Show(
                "Unable to locate the SceneryIndexes folder.",
                "MSFS PROfile Editor",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                )
            Exit Sub
        End If

        Dim sceneryFiles = Directory.GetFiles(sceneryFolder)

        If sceneryFiles.Length = 0 Then

            MessageBox.Show(
            "The SceneryIndexes folder is already empty.",
            "MSFS PROfile Editor",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

            Exit Sub

        End If

        Dim backupPerformed As Boolean = False
        Dim result As BackupOperationResult = Nothing

        Dim response = MessageBox.Show(
        "Would you like to back up your existing scenery indexes before deleting them?",
        "MSFS PROfile Editor",
        MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Question)

        Select Case response

            Case DialogResult.Cancel
                Exit Sub

            Case DialogResult.Yes

                Dim backupFolder = GetBackupFolderForSceneryIndexes()

                If String.IsNullOrWhiteSpace(backupFolder) Then Exit Sub

                result = UiActionRunner.RunWithResult(
                            Me,
                            lblStatus,
                            "Backing up scenery indexes...",
                            Function()
                                Return SimulatorFilesManager.BackupSceneryIndexes(
                                sceneryFolder,
                                backupFolder)
                            End Function
                            )
                If result Is Nothing Then Return

                If Not result.Success Then
                    MessageBox.Show(result.ErrorMessage)
                    Exit Sub
                End If

                backupPerformed = True

            Case DialogResult.No
                ' Continue directly to deletion.

        End Select

        Dim deleted = UiActionRunner.RunWithResult(
                        Me,
                        lblStatus,
                        "Deleting scenery indexes...",
                        Function()
                            Return SimulatorFilesManager.DeleteSceneryIndexes(sceneryFolder)
                        End Function
                        )

        If backupPerformed Then

            MessageBox.Show(
            $"{result.FilesCopied} scenery index files were backed up." &
            Environment.NewLine &
            Environment.NewLine &
            "Backup Location:" &
            Environment.NewLine &
            result.BackupFolder &
            Environment.NewLine &
            Environment.NewLine &
            $"{deleted} scenery index files were deleted.",
            "MSFS PROfile Editor",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            )

        Else

            MessageBox.Show(
            $"{deleted} scenery index file(s) were deleted.",
            "MSFS PROfile Editor",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            )

        End If

    End Sub

    Private Function GetBackupFolderForSceneryIndexes() As String

        If Directory.Exists(My.Settings.IndexesBackupPath) Then

            Dim response = MessageBox.Show(
            "Current backup folder:" &
            Environment.NewLine &
            Environment.NewLine &
            My.Settings.IndexesBackupPath &
            Environment.NewLine &
            Environment.NewLine &
            "Would you like to continue using this folder?" &
            Environment.NewLine &
            Environment.NewLine &
            "Yes = Use this folder" &
            Environment.NewLine &
            "No = Choose a different folder" &
            Environment.NewLine &
            "Cancel = Cancel the operation",
            "MSFS PROfile Editor",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question)

            Select Case response

                Case DialogResult.Yes
                    Return My.Settings.IndexesBackupPath

                Case DialogResult.No
                    Return BrowseForBackupFolder()

                Case Else
                    Return Nothing

            End Select

        End If

        Return BrowseForBackupFolder()

    End Function

    Private Function BrowseForBackupFolder() As String

        Using fbd As New FolderBrowserDialog

            fbd.Description =
            "Select a backup folder for your scenery index backups."

            If fbd.ShowDialog <> DialogResult.OK Then
                Return Nothing
            End If

            My.Settings.IndexesBackupPath = fbd.SelectedPath
            My.Settings.Save()

            Return fbd.SelectedPath

        End Using

    End Function

    Private Sub btnBackupXmlExe_Click(sender As Object, e As EventArgs) Handles btnBackupXmlExe.Click

        RunSimulatorFileBackup(
            "Creating EXE.xml backup...",
            AddressOf SimulatorFilesManager.BackupExeXml
            )

    End Sub

    Private Sub btnViewExeXml_Click(sender As Object, e As EventArgs) Handles btnViewExeXml.Click

        UiActionRunner.Run(Me, lblStatus,
            Sub()
                SimulatorFilesManager.OpenExeXml()
            End Sub
            )

    End Sub

    Private Sub btnViewCamerasCfg_Click(sender As Object, e As EventArgs) Handles btnViewCamerasCfg.Click

        UiActionRunner.Run(Me, lblStatus,
            Sub()
                SimulatorFilesManager.OpenCamerasCfg()
            End Sub
            )

    End Sub

    Private Sub btnBackupCamerasCfg_Click(sender As Object, e As EventArgs) Handles btnBackupCamerasCfg.Click

        RunSimulatorFileBackup("Creating Cameras.cfg backup...",
                AddressOf SimulatorFilesManager.BackupCamerasCfg
                )

    End Sub

    Private Sub RunSimulatorFileBackup(statusMessage As String, backupAction As Func(Of BackupOperationResult))

        Dim result = UiActionRunner.RunWithResult(
            Me,
            lblStatus,
            statusMessage,
            backupAction
            )

        If result Is Nothing Then Return

        If Not result.Success Then

            MessageBox.Show(
                result.ErrorMessage,
                "MSFS PROfile Editor",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                )

            Return

        End If

        MessageBox.Show(
            "Backup created successfully." &
            Environment.NewLine &
            Path.GetFileName(result.BackupFile),
            "MSFS PROfile Editor",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            )

    End Sub

    Private Sub btnViewFs2024Cfg_Click(sender As Object, e As EventArgs) Handles btnViewFs2024Cfg.Click

        UiActionRunner.Run(Me, lblStatus,
            Sub()
                SimulatorFilesManager.OpenFlightSimulator2024Cfg()
            End Sub
            )

    End Sub

    Private Sub btnBackupFs2024Cfg_Click(sender As Object, e As EventArgs) Handles btnBackupFs2024Cfg.Click

        RunSimulatorFileBackup("Creating FlightSimulator2024.cfg backup...",
                AddressOf SimulatorFilesManager.BackupFlightSimulator2024Cfg
                )

    End Sub
End Class