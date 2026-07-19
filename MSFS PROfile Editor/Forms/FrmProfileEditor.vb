Imports System.IO

Public Class FrmProfileEditor

    Private ReadOnly _backupManager As New BackupManager()
    Private ReadOnly _profileManager As New ProfileManager()

    Private Sub FrmProfileEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ThemeManager.ApplyModernTheme(Me)

        RefreshBackupInformation()

    End Sub

    Private Sub RefreshBackupInformation()

        Dim backups = _backupManager.GetBackupFiles(_profileManager.CurrentProfileFolder)

        txtProfileFolder.Text = _profileManager.CurrentProfileFolder

        lblFolderPathInstructions.Text = "The Profile Folder is where your MSFS profiles are stored. " &
           "This folder contains your various profiles that store your graphics settings. " &
           "You can change the Profile Folder by clicking the 'Browse' button."

        'Later...
        'lblTotalSize.Text = ...
        'lblOldestBackup.Text = ...

    End Sub

    ' Button to select the Target File (File 1)
    Private Sub btnBrowseFolder_Click(sender As Object, e As EventArgs) Handles btnBrowseProfileFolder.Click
        Using dlg As New FolderBrowserDialog

            If dlg.ShowDialog = DialogResult.OK Then

                If _profileManager.SetCurrentProfileFolder(dlg.SelectedPath) Then
                    RefreshBackupInformation()
                Else
                    MessageBox.Show("Invalid profile folder.")
                End If

            End If

        End Using
    End Sub

    Private Sub btnBrowseDestinationFile_Click(sender As Object, e As EventArgs)
        Using ofd1 As New OpenFileDialog
            ofd1.Title = "Select your UserCfg.opt file (File to Overwrite)"
            ofd1.Filter = "opt Files (*.opt)|*.opt"

            If Not String.IsNullOrWhiteSpace(My.Settings.LastDirectory) Then
                ofd1.InitialDirectory = My.Settings.LastDirectory
            End If

            If ofd1.ShowDialog = DialogResult.OK Then
                ' Display ONLY the short file name to the user in the textbox
                txtDestinationFile.Text = Path.GetFileName(ofd1.FileName)

                ' Display the FULL absolute path to the user in the label
                lblDestinationFilePath.Text = ofd1.FileName

                ' Store the full hidden path inside the .Tag property for background use
                txtDestinationFile.Tag = ofd1.FileName

                ' SAVE FILE 1 PERSISTENT MEMORY VALUES
                'My.Settings.LastFile1Path = ofd1.FileName
                'My.Settings.LastFile1Name = Path.GetFileName(ofd1.FileName)

                ' Save the folder path to memory
                My.Settings.LastDirectory = Path.GetDirectoryName(ofd1.FileName)
                My.Settings.Save()
            End If
        End Using
    End Sub

    ' Button to select the Source File (File 2)
    Private Sub btnBrowseSourceFile_Click(sender As Object, e As EventArgs)
        Using ofd2 As New OpenFileDialog
            ofd2.Title = "Select Your Stored Profile (Source of New Data)"
            ofd2.Filter = "opt Files (*.opt)|*.opt|Text Files (*.txt)|*.txt"

            If Not String.IsNullOrWhiteSpace(My.Settings.LastDirectory) Then
                ofd2.InitialDirectory = My.Settings.LastDirectory
            End If

            If ofd2.ShowDialog = DialogResult.OK Then
                ' Display ONLY the short file name to the user in the textbox
                txtSourceFile.Text = Path.GetFileName(ofd2.FileName)

                ' Display the FULL absolute path to the user in the new label
                lblSourceFilePath.Text = ofd2.FileName

                ' Store the full hidden path inside the .Tag property for background use
                txtSourceFile.Tag = ofd2.FileName

                ' Save the folder path to memory
                My.Settings.LastDirectory = Path.GetDirectoryName(ofd2.FileName)
                My.Settings.Save()
            End If
        End Using
    End Sub

    Private Sub btnSaveAsCurrentProfile_Click(sender As Object, e As EventArgs)
        Dim success = _profileManager.ReplaceProfile(txtDestinationFile.Tag, txtSourceFile.Tag)

        'If success Then
        'MessageBox.Show("Profile replaced successfully.")
        'Else
        'MessageBox.Show("Profile replacement failed.")
        'End If
    End Sub


End Class