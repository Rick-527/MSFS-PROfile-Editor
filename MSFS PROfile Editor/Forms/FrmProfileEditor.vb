Imports System.IO

Public Class FrmProfileEditor

    Private ReadOnly _backupManager As New BackupManager()
    Private ReadOnly _profileManager As New ProfileManager()
    Private ReadOnly _recentFileManager As New RecentFileManager()

    Private Const folderInstructions As String = "The Profile Folder stores all of your saved MSFS profiles." & vbCrLf & vbCrLf &
                                    "Each profile contains your graphics settings," & vbCrLf &
                                    "located in your UserCfg.opt file." & vbCrLf & vbCrLf &
                                    "Profiles let you quickly switch between different" & vbCrLf &
                                    "MSFS graphics settings for different types of flying." & vbCrLf & vbCrLf &
                                    "Click 'Browse' to set your profiles folder."

    Private Sub FrmProfileEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ThemeManager.ApplyModernTheme(Me)

        lblFolderPathInstructions.Text = folderInstructions

        lblProfilesFolderPath.Text = Path.GetFileName(My.Settings.ProfileFolder)
        If My.Settings.CurrentProfile = "" Then

            lblInfoRight.Text = ""
        Else
            lblInfoRight.Text = My.Settings.CurrentProfile
        End If

        ' Validate and clear old directory histories if they no longer exist on disk
        If Not String.IsNullOrWhiteSpace(My.Settings.LastDirectory) Then
            If Not Directory.Exists(My.Settings.LastDirectory) Then
                My.Settings.LastDirectory = ""
                My.Settings.Save()
            End If
        End If

        'load the UserCfg.opt file from the last session
        Dim lastFile = _recentFileManager.LoadLastFile()

        If lastFile IsNot Nothing Then

            txtDestinationFile.Text = lastFile.FileName
            txtDestinationFile.Tag = lastFile.FilePath

        End If

        RefreshProfileInformation()

    End Sub

    Private Sub UpdateLaunchButton()

        Dim result = SimulatorDetector.DetectSimulator()

        If result.InstalledCount = 0 Then

            btnLaunchSimulator.Enabled = False
            btnUpdateCurrentProfile.Enabled = False
            btnLaunchSimulator.Text = "Launch Simulator"

        ElseIf SimulatorLauncher.IsRunning() Then

            btnLaunchSimulator.Enabled = False
            btnLaunchSimulator.Text = "MSFS Already Running"

        Else

            btnLaunchSimulator.Enabled = True
            btnLaunchSimulator.Text = "Launch Simulator"

        End If

    End Sub

    Private Sub FrmProfileEditor_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        UpdateLaunchButton()

        'Dim running = SimulatorLauncher.IsRunning()

        'btnLaunchSimulator.Enabled = Not running
        'btnLaunchSimulator.Text = If(running,
        '"MSFS Already Running",
        '"Launch Simulator")

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

    Private Sub RefreshProfileInformation()

        Dim profileFolder = _profileManager.CurrentProfileFolder

        If Not Directory.Exists(profileFolder) Then

            lblProfilesFolderPath.Text = "(Not Set)"
            lblStatusCenter.Text = "No profile folder selected"
            lblInfoRight.Text = ""

            Exit Sub

        End If

        lblProfilesFolderPath.Text = Path.GetFileName(profileFolder)

        Dim profileCount = Directory.GetFiles(profileFolder, "*.opt").Length

        Select Case profileCount

            Case 0
                lblStatusCenter.Text = "No profiles found"

            Case 1
                lblStatusCenter.Text = "1 profile found"

            Case Else
                lblStatusCenter.Text = $"{profileCount} profiles found"

        End Select

        lblProfilesFolderPath.Text = Path.GetFileName(My.Settings.ProfileFolder)
        lblInfoRight.Text = "Latest Profile installed: " & My.Settings.CurrentProfile

    End Sub

    Private Sub btnSelectProfilesFolder_Click(sender As Object, e As EventArgs) Handles btnSelectProfilesFolder.Click

        Using dlg As New FolderBrowserDialog

            If Directory.Exists(My.Settings.ProfileFolder) Then
                dlg.SelectedPath = My.Settings.ProfileFolder
            End If

            If dlg.ShowDialog() = DialogResult.OK Then

                If _profileManager.SetCurrentProfileFolder(dlg.SelectedPath) Then
                    RefreshProfileInformation()
                Else
                    MessageBox.Show("Invalid profile folder.")
                End If

            End If

        End Using

    End Sub

    Private Sub btnBrowseDestinationFile_Click(sender As Object, e As EventArgs) Handles btnBrowseDestinationFile.Click

        Using ofd1 As New OpenFileDialog

            ofd1.Title = "Select your UserCfg.opt file (File to Overwrite)"
            ofd1.Filter = "OPT Files (*.opt)|*.opt"

            Dim simulatorFolder = SimulatorFilesManager.GetConfigFolderPath()

            If String.IsNullOrWhiteSpace(simulatorFolder) Then

                MessageBox.Show(
                    "Microsoft Flight Simulator 2024 was not detected on this computer.",
                    "MSFS PROfile Editor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)

                Exit Sub

            End If

            ofd1.InitialDirectory = simulatorFolder

            If ofd1.ShowDialog() = DialogResult.OK Then

                txtDestinationFile.Text = Path.GetFileName(ofd1.FileName)
                txtDestinationFile.Tag = ofd1.FileName

                _recentFileManager.SaveFile1(ofd1.FileName)

            End If

        End Using

    End Sub

    Private Sub btnBrowseSourceFile_Click(sender As Object, e As EventArgs) Handles btnBrowseSourceFile.Click

        Using ofd2 As New OpenFileDialog

            ofd2.Title = "Select Your Stored Profile (Source of New Data)"
            ofd2.Filter = "OPT Files (*.opt)|*.opt|Text Files (*.txt)|*.txt"

            If Directory.Exists(My.Settings.ProfileFolder) Then
                ofd2.InitialDirectory = My.Settings.ProfileFolder
            End If

            If ofd2.ShowDialog() = DialogResult.OK Then

                txtSourceFile.Text = Path.GetFileName(ofd2.FileName)
                txtSourceFile.Tag = ofd2.FileName

                _recentFileManager.SaveFile2(ofd2.FileName)

            End If

        End Using

    End Sub

    Private Sub btnSaveAsCurrentProfile_Click(sender As Object, e As EventArgs) Handles btnSaveAsCurrentProfile.Click

        _profileManager.NewProfile(txtDestinationFile)

    End Sub

    Private Sub btnViewDestinationFile_Click(sender As Object, e As EventArgs) Handles btnViewDestinationFile.Click

        _recentFileManager.ViewFile(txtDestinationFile)

    End Sub

    Private Sub btnViewSourceFile_Click(sender As Object, e As EventArgs) Handles btnViewSourceFile.Click

        _recentFileManager.ViewFile(txtSourceFile)

    End Sub

    Private Sub btnUpdateCurrentProfile_Click(sender As Object, e As EventArgs) Handles btnUpdateCurrentProfile.Click

        _profileManager.ReplaceProfile(txtDestinationFile.Tag, txtSourceFile.Tag)
        My.Settings.CurrentProfile = txtSourceFile.Text
        My.Settings.Save()
        RefreshProfileInformation()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnLaunchSimulator_Click(sender As Object, e As EventArgs) Handles btnLaunchSimulator.Click

        lblStatus.Text = "Launching Microsoft Flight Simulator..."

        If SimulatorLauncher.Launch() Then

            Me.Close()

        End If

    End Sub

End Class