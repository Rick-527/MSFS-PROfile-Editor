Imports System.IO

Public Class FrmProfileEditor

    Private ReadOnly _backupManager As New BackupManager()
    Private ReadOnly _profileManager As New ProfileManager()
    Private ReadOnly _recentFileManager As New RecentFileManager()

    Private Sub FrmProfileEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ThemeManager.ApplyModernTheme(Me)

        ' Validate and clear old directory histories if they no longer exist on disk
        If Not String.IsNullOrWhiteSpace(My.Settings.LastDirectory) OrElse Not String.IsNullOrWhiteSpace(My.Settings.LastDirectory2) Then
            If Not Directory.Exists(My.Settings.LastDirectory) Then
                My.Settings.LastDirectory = ""
                My.Settings.Save()
            End If
            If Not Directory.Exists(My.Settings.LastDirectory2) Then
                My.Settings.LastDirectory2 = ""
                My.Settings.Save()
            End If
        End If

        'load the UserCfg.opt file from the last session
        Dim lastFile = _recentFileManager.LoadLastFile()
        txtDestinationFile.Text = lastFile.FileName
        txtDestinationFile.Tag = lastFile.FilePath
        lblDestinationFilePath.Text = lastFile.FilePath

        RefreshBackupInformation()

    End Sub

    Private Sub LoadFileNameInTextbox(destinationFileName As String, destinationFilePath As TextBox, destinationFilePathLabel As Label)

        ' reload the last file name and path in the textbox and label
        If Not String.IsNullOrWhiteSpace(My.Settings.LastFile1Path) Then
            ' Only load it if the file still actually exists on the hard drive
            If File.Exists(My.Settings.LastFile1Path) Then
                destinationFileName = My.Settings.LastFile1Name
                destinationFilePath.Tag = My.Settings.LastFile1Path
                destinationFilePathLabel.Text = My.Settings.LastFile1Path
            Else
                ' Wipe settings if the file was deleted or moved while the app was closed
                My.Settings.LastFile1Path = ""
                My.Settings.LastFile1Name = ""
                My.Settings.Save()
            End If
        End If
    End Sub

    Private Sub RefreshBackupInformation()

        Dim backups = _backupManager.GetBackupFiles(_profileManager.CurrentProfileFolder)

        txtProfileFolder.Text = _profileManager.CurrentProfileFolder

        lblFolderPathInstructions.Text = "The Profile Folder is where your MSFS profiles are stored. " &
           "This folder contains your various profiles that store your graphics settings. " &
           "You can change the Profile Folder by clicking the 'Browse' button."

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

    Private Sub btnBrowseDestinationFile_Click(sender As Object, e As EventArgs) Handles btnBrowseDestinationFile.Click

        Using ofd1 As New OpenFileDialog
            ofd1.Title = "Select your UserCfg.opt file (File to Overwrite)"
            ofd1.Filter = "opt Files (*.opt)|*.opt"

            If Not String.IsNullOrWhiteSpace(My.Settings.LastDirectory) Then
                ofd1.InitialDirectory = My.Settings.LastDirectory
            End If

            If ofd1.ShowDialog() = DialogResult.OK Then

                txtDestinationFile.Text = Path.GetFileName(ofd1.FileName)
                txtDestinationFile.Tag = ofd1.FileName
                lblDestinationFilePath.Text = ofd1.FileName

                _recentFileManager.SaveFile1(ofd1.FileName)

            End If

            'If ofd1.ShowDialog = DialogResult.OK Then
            '    ' Display ONLY the short file name to the user in the textbox
            '    txtDestinationFile.Text = Path.GetFileName(ofd1.FileName)

            '    ' Display the FULL absolute path to the user in the label
            '    lblDestinationFilePath.Text = ofd1.FileName
            '    lblSourceFilePath.Text = ofd1.FileName

            '    ' Store the full hidden path inside the .Tag property for background use
            '    txtDestinationFile.Tag = ofd1.FileName

            '    ' SAVE FILE 1 PERSISTENT MEMORY VALUES
            '    My.Settings.LastFile1Path = ofd1.FileName
            '    My.Settings.LastFile1Name = Path.GetFileName(ofd1.FileName)

            '    ' Save the folder path to memory
            '    My.Settings.LastDirectory = Path.GetDirectoryName(ofd1.FileName)
            '    My.Settings.Save()

            'End If
        End Using

    End Sub

    Private Sub btnBrowseSourceFile_Click(sender As Object, e As EventArgs) Handles btnBrowseSourceFile.Click

        Using ofd2 As New OpenFileDialog
            ofd2.Title = "Select Your Stored Profile (Source of New Data)"
            ofd2.Filter = "opt Files (*.opt)|*.opt|Text Files (*.txt)|*.txt"

            If Not String.IsNullOrWhiteSpace(My.Settings.LastDirectory2) Then
                ofd2.InitialDirectory = My.Settings.LastDirectory2
            End If

            If ofd2.ShowDialog() = DialogResult.OK Then

                txtSourceFile.Text = Path.GetFileName(ofd2.FileName)
                txtSourceFile.Tag = ofd2.FileName
                lblSourceFilePath.Text = ofd2.FileName

                _recentFileManager.SaveFile2(ofd2.FileName)

            End If

            'If ofd2.ShowDialog = DialogResult.OK Then
            '    ' Display only the short file name to the user in the textbox
            '    txtSourceFile.Text = Path.GetFileName(ofd2.FileName)

            '    ' Display the full absolute path to the user in the new label
            '    lblSourceFilePath.Text = ofd2.FileName

            '    ' Store the full hidden path inside the .Tag property for background use
            '    txtSourceFile.Tag = ofd2.FileName

            '    ' save file 2 persistent values
            '    My.Settings.LastFile2Path = ofd2.FileName
            '    My.Settings.LastFile2Name = Path.GetFileName(ofd2.FileName)

            '    ' Save the folder path to memory
            '    My.Settings.LastDirectory2 = Path.GetDirectoryName(ofd2.FileName)
            '    My.Settings.Save()
            'End If
        End Using

    End Sub

    Private Sub btnSaveAsCurrentProfile_Click(sender As Object, e As EventArgs) Handles btnSaveAsCurrentProfile.Click

        _profileManager.NewProfile(txtDestinationFile)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class