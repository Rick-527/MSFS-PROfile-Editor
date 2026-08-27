Imports System.IO

Public Class UcMaintenance

    Public Event StatusChanged(message As String)

    Private Sub UcMaintenance_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ConfigureBackupMenu(
            btnExeXml,
            AddressOf BackupExeXml_Click)

        ConfigureBackupMenu(
            btnCamerasCfg,
            AddressOf BackupCamerasCfg_Click)

        ConfigureBackupMenu(
            btnFlightsimulator2024Cfg,
            AddressOf BackupFlightSimulator2024Cfg_Click)

        ConfigureRollingCacheMenu()

        ConfigureSceneryIndexesMenu()

    End Sub

    Private Sub SetStatus(message As String)

        RaiseEvent StatusChanged(message)

    End Sub

    Private Sub ConfigureBackupMenu(
        button As ModernSplitButton,
        backupHandler As EventHandler)

        Dim menu As New ContextMenuStrip()
        Dim backupItem As New ToolStripMenuItem("Back Up")

        AddHandler backupItem.Click, backupHandler

        menu.Items.Add(backupItem)

        button.DropDownMenu = menu

    End Sub

    Private Sub ConfigureRollingCacheMenu()

        Dim menu As New ContextMenuStrip()
        Dim deleteItem As New ToolStripMenuItem("Delete")

        AddHandler deleteItem.Click,
            AddressOf DeleteRollingCache_Click

        menu.Items.Add(deleteItem)

        btnRollingCache.DropDownMenu = menu

    End Sub

    Private Sub ConfigureSceneryIndexesMenu()

        Dim menu As New ContextMenuStrip()

        Dim backupItem =
            New ToolStripMenuItem("Back Up")

        Dim deleteItem =
            New ToolStripMenuItem("Delete")

        Dim backupDeleteItem =
            New ToolStripMenuItem("Back Up && Delete")

        AddHandler backupItem.Click,
            AddressOf BackupSceneryIndexes_Click

        AddHandler deleteItem.Click,
            AddressOf DeleteSceneryIndexes_Click

        AddHandler backupDeleteItem.Click,
            AddressOf BackupDeleteSceneryIndexes_Click

        menu.Items.Add(backupItem)
        menu.Items.Add(deleteItem)

        menu.Items.Add(
            New ToolStripSeparator())

        menu.Items.Add(backupDeleteItem)

        btnSceneryIndexes.DropDownMenu = menu

    End Sub

    Private Sub OpenSimulatorFile(
        displayName As String,
        openAction As Action)

        Try

            SetStatus(
                $"Opening {displayName}...")

            openAction()

            SetStatus("Ready")

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                $"Open {displayName} Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            SetStatus(
                $"{displayName} could not be opened.")

        End Try

    End Sub

    Private Sub RunSimulatorFileBackup(
        displayName As String,
        statusMessage As String,
        backupAction As Func(Of BackupOperationResult))

        Try

            SetStatus(statusMessage)

            Dim result =
                backupAction()

            If result Is Nothing Then
                Return
            End If

            If Not result.Success Then

                MessageBox.Show(
                    result.ErrorMessage,
                    $"{displayName} Backup Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)

                SetStatus(
                    $"{displayName} backup failed.")

                Return

            End If

            MessageBox.Show(
                "Backup created successfully." &
                Environment.NewLine &
                Environment.NewLine &
                "Backup file:" &
                Environment.NewLine &
                Path.GetFileName(result.BackupFile),
                "MSFS PROfile Editor",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            SetStatus("Ready")

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                $"{displayName} Backup Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            SetStatus(
                $"{displayName} backup failed.")

        End Try

    End Sub

    Private Function GetSceneryIndexesFolder() As String

        Dim sceneryFolder =
            SimulatorFilesManager.GetSceneryIndexesFolder()

        If String.IsNullOrWhiteSpace(sceneryFolder) OrElse
            Not Directory.Exists(sceneryFolder) Then

            MessageBox.Show(
                "The SceneryIndexes folder could not be found.",
                "SceneryIndexes",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            Return Nothing

        End If

        Return sceneryFolder

    End Function

    Private Function GetSceneryIndexesFiles(
        sceneryFolder As String
    ) As String()

        Return Directory.GetFiles(sceneryFolder)

    End Function

    Private Function GetSceneryIndexesBackupFolder() As String

        Dim configFolder =
            SimulatorFilesManager.GetSimulatorConfigFolder()

        If String.IsNullOrWhiteSpace(configFolder) Then
            Return Nothing
        End If

        Return Path.Combine(
            configFolder,
            "SceneryIndexes_Backups")

    End Function

    Private Sub DeleteRollingCache_Click(
        sender As Object,
        e As EventArgs)

        DeleteRollingCache()

    End Sub

    Private Sub DeleteRollingCache()

        If Not SimulatorFilesManager.FileExists(
            SimulatorFile.RollingCache) Then

            MessageBox.Show(
                "The rolling cache file was not found.",
                "Rolling Cache",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            SetStatus(
                "Rolling cache was not found.")

            Return

        End If

        Dim confirmation =
            MessageBox.Show(
                "Delete the Microsoft Flight Simulator rolling cache?" &
                Environment.NewLine &
                Environment.NewLine &
                "Microsoft Flight Simulator will recreate the file if rolling cache is enabled.",
                "Delete Rolling Cache",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2)

        If confirmation <> DialogResult.Yes Then
            Return
        End If

        Try

            SetStatus(
                "Deleting rolling cache...")

            SimulatorFilesManager.DeleteFile(
                SimulatorFile.RollingCache)

            MessageBox.Show(
                "The rolling cache was deleted successfully.",
                "Rolling Cache",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            SetStatus("Ready")

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Delete Rolling Cache Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            SetStatus(
                "Rolling cache could not be deleted.")

        End Try

    End Sub

    Private Sub BackupSceneryIndexes_Click(
        sender As Object,
        e As EventArgs)

        BackupSceneryIndexes()

    End Sub

    Private Function BackupSceneryIndexes() As Boolean

        Try

            Dim sceneryFolder =
                GetSceneryIndexesFolder()

            If sceneryFolder Is Nothing Then
                Return False
            End If

            Dim sceneryFiles =
                GetSceneryIndexesFiles(
                    sceneryFolder)

            If sceneryFiles.Length = 0 Then

                MessageBox.Show(
                    "There are no SceneryIndexes files to back up.",
                    "SceneryIndexes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)

                SetStatus(
                    "No SceneryIndexes files were found.")

                Return False

            End If

            Dim backupFolder =
                GetSceneryIndexesBackupFolder()

            If String.IsNullOrWhiteSpace(
                backupFolder) Then

                Return False

            End If

            SetStatus(
                "Backing up SceneryIndexes...")

            Dim result =
                SimulatorFilesManager.BackupSceneryIndexes(
                    sceneryFolder,
                    backupFolder)

            If Not result.Success Then

                MessageBox.Show(
                    result.ErrorMessage,
                    "SceneryIndexes Backup Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)

                SetStatus(
                    "SceneryIndexes backup failed.")

                Return False

            End If

            MessageBox.Show(
                $"{result.FilesCopied} SceneryIndexes file(s) were backed up successfully." &
                Environment.NewLine &
                Environment.NewLine &
                "Backup folder:" &
                Environment.NewLine &
                Path.GetFileName(result.BackupFolder),
                "SceneryIndexes Backup",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            SetStatus("Ready")

            Return True

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "SceneryIndexes Backup Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            SetStatus(
                "SceneryIndexes backup failed.")

            Return False

        End Try

    End Function

    Private Sub DeleteSceneryIndexes_Click(
        sender As Object,
        e As EventArgs)

        DeleteSceneryIndexes()

    End Sub

    Private Function DeleteSceneryIndexes() As Boolean

        Try

            Dim sceneryFolder =
                GetSceneryIndexesFolder()

            If sceneryFolder Is Nothing Then
                Return False
            End If

            Dim sceneryFiles =
                GetSceneryIndexesFiles(
                    sceneryFolder)

            If sceneryFiles.Length = 0 Then

                MessageBox.Show(
                    "There are no SceneryIndexes files to delete.",
                    "SceneryIndexes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)

                SetStatus(
                    "No SceneryIndexes files were found.")

                Return False

            End If

            Dim confirmation =
                MessageBox.Show(
                    $"Delete {sceneryFiles.Length} file(s) from the SceneryIndexes folder?" &
                    Environment.NewLine &
                    Environment.NewLine &
                    "Microsoft Flight Simulator will rebuild these files as required.",
                    "Delete SceneryIndexes",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2)

            If confirmation <> DialogResult.Yes Then
                Return False
            End If

            SetStatus(
                "Deleting SceneryIndexes...")

            Dim filesDeleted =
                SimulatorFilesManager.DeleteSceneryIndexes(
                    sceneryFolder)

            MessageBox.Show(
                $"{filesDeleted} SceneryIndexes file(s) were deleted successfully.",
                "SceneryIndexes",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            SetStatus("Ready")

            Return True

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Delete SceneryIndexes Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            SetStatus(
                "SceneryIndexes could not be deleted.")

            Return False

        End Try

    End Function

    Private Sub BackupDeleteSceneryIndexes_Click(
        sender As Object,
        e As EventArgs)

        Dim sceneryFolder =
            GetSceneryIndexesFolder()

        If sceneryFolder Is Nothing Then
            Return
        End If

        Dim sceneryFiles =
            GetSceneryIndexesFiles(
                sceneryFolder)

        If sceneryFiles.Length = 0 Then

            MessageBox.Show(
                "There are no SceneryIndexes files to back up or delete.",
                "SceneryIndexes",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            SetStatus(
                "No SceneryIndexes files were found.")

            Return

        End If

        Dim confirmation =
            MessageBox.Show(
                $"Back up and then delete {sceneryFiles.Length} SceneryIndexes file(s)?",
                "Back Up && Delete SceneryIndexes",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2)

        If confirmation <> DialogResult.Yes Then
            Return
        End If

        If Not BackupSceneryIndexes() Then
            Return
        End If

        Try

            Dim filesDeleted =
                SimulatorFilesManager.DeleteSceneryIndexes(
                    sceneryFolder)

            MessageBox.Show(
                $"{filesDeleted} original SceneryIndexes file(s) were deleted after the backup.",
                "SceneryIndexes",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            SetStatus("Ready")

        Catch ex As Exception

            MessageBox.Show(
                "The backup was created successfully, but the original SceneryIndexes files could not be deleted." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "SceneryIndexes Delete Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            SetStatus(
                "SceneryIndexes could not be deleted.")

        End Try

    End Sub

    Private Sub BackupExeXml_Click(
        sender As Object,
        e As EventArgs)

        RunSimulatorFileBackup(
            "EXE.xml",
            "Creating EXE.xml backup...",
            AddressOf SimulatorFilesManager.BackupExeXml)

    End Sub

    Private Sub BackupCamerasCfg_Click(
        sender As Object,
        e As EventArgs)

        RunSimulatorFileBackup(
            "Cameras.cfg",
            "Creating Cameras.cfg backup...",
            AddressOf SimulatorFilesManager.BackupCamerasCfg)

    End Sub

    Private Sub BackupFlightSimulator2024Cfg_Click(
        sender As Object,
        e As EventArgs)

        RunSimulatorFileBackup(
            "Flightsimulator2024.cfg",
            "Creating Flightsimulator2024.cfg backup...",
            AddressOf SimulatorFilesManager.BackupFlightSimulator2024Cfg)

    End Sub

    Private Sub btnExeXml_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnExeXml.Click

        OpenSimulatorFile(
            "EXE.xml",
            AddressOf SimulatorFilesManager.OpenExeXml)

    End Sub

    Private Sub btnCamerasCfg_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCamerasCfg.Click

        OpenSimulatorFile(
            "Cameras.cfg",
            AddressOf SimulatorFilesManager.OpenCamerasCfg)

    End Sub

    Private Sub btnFlightsimulator2024Cfg_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnFlightsimulator2024Cfg.Click

        OpenSimulatorFile(
            "Flightsimulator2024.cfg",
            AddressOf SimulatorFilesManager.OpenFlightSimulator2024Cfg)

    End Sub

    Private Sub btnSceneryIndexes_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSceneryIndexes.Click

        DeleteSceneryIndexes()

    End Sub

    Private Sub btnRollingCache_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRollingCache.Click

        DeleteRollingCache()

    End Sub

End Class