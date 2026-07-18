Public Class FrmMaintenance

    Private ReadOnly _backupManager As New BackupManager()
    Private ReadOnly _profileManager As New ProfileManager()

    Private Sub FrmMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ThemeManager.ApplyModernTheme(Me)

        lblFolderPathInstructions.Text = "The Profile Folder is where your MSFS profiles are stored. " &
            "This folder contains your various profiles that store your graphics settings. " &
            "You can change the Profile Folder by clicking the 'Browse' button."

        Dim profileFolder = _profileManager.CurrentProfileFolder

        txtProfileFolder.Text = profileFolder

        Dim backups = _backupManager.GetBackupFiles(profileFolder)

    End Sub



    Private Sub RefreshBackupInformation()

        Dim profileFolder = _profileManager.CurrentProfileFolder
        Dim backups = _backupManager.GetBackupFiles(profileFolder)

        lblBackupCount.Text = backups.Count.ToString()

        'Later...
        'lblTotalSize.Text = ...
        'lblOldestBackup.Text = ...

    End Sub

    Private Sub btnBrowseFile_Click(sender As Object, e As EventArgs) Handles btnBrowseFile.Click
        Using dlg As New FolderBrowserDialog

            If dlg.ShowDialog() = DialogResult.OK Then

                If _profileManager.SetCurrentProfileFolder(dlg.SelectedPath) Then

                    txtProfileFolder.Text =
                        _profileManager.CurrentProfileFolder

                    RefreshBackupInformation()

                Else

                    MessageBox.Show("Invalid profile folder.")

                End If

            End If

        End Using
    End Sub

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        Me.Close()
    End Sub

End Class