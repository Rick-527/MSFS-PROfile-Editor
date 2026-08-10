Imports System.IO

Public Class UcMaintenance

    Public Event StatusChanged(message As String)

    Private Sub UcMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConfigureBackupMenu(btnExeXml, AddressOf BackupExeXml_Click)

        ConfigureBackupMenu(btnCamerasCfg, AddressOf BackupCamerasCfg_Click)

        ConfigureBackupMenu(btnFlightsimulator2024Cfg, AddressOf BackupFlightSimulator2024Cfg_Click)

    End Sub

    Private Sub OpenSimulatorFile(
    displayName As String,
    openAction As Action)

        Try

            RaiseEvent StatusChanged(
                $"Opening {displayName}...")

            openAction()

            RaiseEvent StatusChanged("Ready")

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                $"Open {displayName} Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            RaiseEvent StatusChanged(
                $"{displayName} could not be opened.")

        End Try

    End Sub

    Private Sub RunSimulatorFileBackup(
        displayName As String,
        statusMessage As String,
        backupAction As Func(Of BackupOperationResult))

        Try

            RaiseEvent StatusChanged(statusMessage)

            Dim result As BackupOperationResult =
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

                RaiseEvent StatusChanged(
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

            RaiseEvent StatusChanged("Ready")

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                $"{displayName} Backup Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            RaiseEvent StatusChanged(
                $"{displayName} backup failed.")

        End Try

    End Sub

    Private Sub ConfigureBackupMenu(button As ModernSplitButton, backupHandler As EventHandler)

        Dim menu As New ContextMenuStrip()

        Dim backupItem As New ToolStripMenuItem("Back Up")

        AddHandler backupItem.Click, backupHandler

        menu.Items.Add(backupItem)

        button.DropDownMenu = menu

    End Sub

    Private Sub BackupExeXml_Click(sender As Object, e As EventArgs)

        RunSimulatorFileBackup(
            "EXE.xml",
            "Creating EXE.xml backup...",
            AddressOf SimulatorFilesManager.BackupExeXml)

    End Sub

    Private Sub BackupCamerasCfg_Click(sender As Object, e As EventArgs)

        RunSimulatorFileBackup(
            "Cameras.cfg",
            "Creating Cameras.cfg backup...",
            AddressOf SimulatorFilesManager.BackupCamerasCfg)

    End Sub

    Private Sub BackupFlightSimulator2024Cfg_Click(sender As Object, e As EventArgs)

        RunSimulatorFileBackup(
            "Flightsimulator2024.cfg",
            "Creating Flightsimulator2024.cfg backup...",
            AddressOf SimulatorFilesManager.BackupFlightSimulator2024Cfg)

    End Sub

    Private Sub btnExeXml_Click(sender As Object, e As EventArgs) Handles btnExeXml.Click

        OpenSimulatorFile("EXE.xml", AddressOf SimulatorFilesManager.OpenExeXml)

    End Sub

    Private Sub btnCamerasCfg_Click(sender As Object, e As EventArgs) Handles btnCamerasCfg.Click

        OpenSimulatorFile("Cameras.cfg", AddressOf SimulatorFilesManager.OpenCamerasCfg)

    End Sub

    Private Sub btnFlightsimulator2024Cfg_Click(sender As Object, e As EventArgs) Handles btnFlightsimulator2024Cfg.Click

        OpenSimulatorFile("Flightsimulator2024.cfg", AddressOf SimulatorFilesManager.OpenFlightSimulator2024Cfg)

    End Sub
End Class
