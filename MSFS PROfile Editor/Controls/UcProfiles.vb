Imports System.IO
Imports MSFS_PROfile_Editor.SimulatorLaunchMode

Public Class UcProfiles

    Private Const ProfilesPerGroup As Integer = 5
    Private Const ProfileButtonHeight As Integer = 38
    Private Const ProfileButtonWidth As Integer = 172

    Private ReadOnly _profileManager As New ProfileManager()
    Private ReadOnly _currentProfileManager As New CurrentProfileManager()

    Private ReadOnly _normalProfileColor As Color =
        Color.FromArgb(45, 55, 65)

    Private ReadOnly _activeProfileColor As Color =
        Color.FromArgb(0, 120, 215)

    Private _activeProfileButton As ModernSplitButton

    Public Event StatusChanged(message As String)

    Public ReadOnly Property HasLegacyProfiles As Boolean
        Get
            Return _profileManager.GetLegacyProfileCount() > 0
        End Get
    End Property

    Private Sub UcProfiles_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        flpProfiles.BackColor = Color.Transparent
        pnlFooter.BackColor = Color.Transparent

        Me.DoubleBuffered = True

        SetToolTip.SetToolTip(
            btnViewUserCfg,
            "Open UserCfg.opt in Notepad.")

        ConfigureSimulatorLauncher()
        UpdateSimulatorLauncherState()
        LoadUserProfiles()

    End Sub

    Private Sub SetStatus(message As String)

        RaiseEvent StatusChanged(message)

    End Sub

    Private Sub ConfigureSimulatorLauncher()

        Dim menu As New ContextMenuStrip()

        Dim normalItem =
            New ToolStripMenuItem(
                "Normal Launch")

        AddHandler normalItem.Click,
            Async Sub()
                Await LaunchSimulatorAsync(
                    LaunchMode.Normal)
            End Sub

        Dim fsuipcItem =
            New ToolStripMenuItem(
                "Launch with FSUIPC")

        AddHandler fsuipcItem.Click,
            Async Sub()
                Await LaunchSimulatorAsync(
                    LaunchMode.FSUIPC)
            End Sub

        menu.Items.Add(normalItem)
        menu.Items.Add(fsuipcItem)

        btnSimLauncher2024.DropDownMenu = menu

    End Sub

    Private Sub UpdateSimulatorLauncherState()

        Dim simulatorRunning =
            SimulatorLauncher.IsRunning()

        btnSimLauncher2024.Enabled =
            Not simulatorRunning

        If simulatorRunning Then

            SetToolTip.SetToolTip(
                btnSimLauncher2024,
                Nothing)

        Else

            SetToolTip.SetToolTip(
                btnSimLauncher2024,
                "Launch Microsoft Flight Simulator 2024.")

        End If

    End Sub

    Private Async Function LaunchSimulatorAsync(
        mode As LaunchMode
    ) As Task

        Try

            SetStatus(
                "Launching Microsoft Flight Simulator...")

            Dim launched =
                Await SimulatorLauncher.LaunchAsync(
                    mode)

            If launched Then

                SetStatus(
                    "Microsoft Flight Simulator is running.")

                Application.Exit()

                Return

            End If

            SetStatus(
                "Microsoft Flight Simulator could not be started.")

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Launch Simulator Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            SetStatus(
                "Microsoft Flight Simulator could not be started.")

        End Try

    End Function

    Private Sub LoadUserProfiles()

        flpProfiles.SuspendLayout()

        Try

            ClearProfileControls()

            _activeProfileButton = Nothing

            SetStatus(
                "No Profile Selected")

            Dim profiles =
                _profileManager.GetProfiles()

            UpdateProfileCount()

            If profiles.Count = 0 Then

                SetStatus(
                    "No saved profiles were found.")

                Return

            End If

            Dim profileLayout =
                CreateProfileLayout()

            Dim groupCount =
                CInt(
                    Math.Ceiling(
                        profiles.Count /
                        CDbl(ProfilesPerGroup)))

            For groupIndex = 0 To groupCount - 1

                Dim groupPanel =
                    CreateProfileGroupPanel()

                Dim startIndex =
                    groupIndex *
                    ProfilesPerGroup

                Dim endIndex =
                    Math.Min(
                        startIndex +
                        ProfilesPerGroup,
                        profiles.Count)

                For profileIndex =
                    startIndex To endIndex - 1

                    Dim profileButton =
                        CreateProfileButton(
                            profiles(profileIndex))

                    groupPanel.Controls.Add(
                        profileButton)

                Next

                profileLayout.Controls.Add(
                    groupPanel,
                    groupIndex,
                    0)

            Next

            profileLayout.PerformLayout()

            Dim preferredSize =
                profileLayout.GetPreferredSize(
                    Size.Empty)

            profileLayout.AutoSize = False
            profileLayout.Size = preferredSize

            flpProfiles.Controls.Add(
                profileLayout)

            flpProfiles.PerformLayout()

        Finally

            flpProfiles.ResumeLayout(True)

        End Try

    End Sub

    Private Function CreateProfileLayout() As TableLayoutPanel

        Dim maximumGroupCount =
            CInt(
                Math.Ceiling(
                    ApplicationConstants.MaximumProfileCount /
                    CDbl(ProfilesPerGroup)))

        Dim profileLayout =
            New TableLayoutPanel With {
                .Name = "tblProfileGroups",
                .AutoSize = True,
                .AutoSizeMode = AutoSizeMode.GrowAndShrink,
                .ColumnCount = maximumGroupCount,
                .RowCount = 1,
                .Margin = New Padding(0),
                .Padding = New Padding(0),
                .BackColor = Color.Transparent
            }

        For columnNumber =
            0 To maximumGroupCount - 1

            profileLayout.ColumnStyles.Add(
                New ColumnStyle(
                    SizeType.AutoSize))

        Next

        profileLayout.RowStyles.Add(
            New RowStyle(
                SizeType.AutoSize))

        Return profileLayout

    End Function

    Private Function CreateProfileGroupPanel() As FlowLayoutPanel

        Return New FlowLayoutPanel With {
            .AutoSize = True,
            .AutoSizeMode = AutoSizeMode.GrowAndShrink,
            .FlowDirection = FlowDirection.TopDown,
            .WrapContents = False,
            .Margin = New Padding(0, 4, 16, 0),
            .Padding = New Padding(0),
            .BackColor = Color.Transparent
        }

    End Function

    Private Function CreateProfileButton(
        profileInfo As ProfileInfo
    ) As ModernSplitButton

        Dim btn =
            New ModernSplitButton With {
                .Text = profileInfo.DisplayProfileName,
                .Width = ProfileButtonWidth,
                .Height = ProfileButtonHeight,
                .FlatStyle = FlatStyle.Flat,
                .BackColor = _normalProfileColor,
                .ForeColor = Color.White,
                .TextAlign = ContentAlignment.MiddleLeft,
                .Padding = New Padding(12, 0, 0, 0),
                .Margin = New Padding(0, 0, 0, 8),
                .TabStop = False,
                .Tag = profileInfo
            }

        btn.FlatAppearance.BorderColor =
            Color.FromArgb(
                80,
                160,
                170)

        btn.FlatAppearance.BorderSize = 1

        SetToolTip.SetToolTip(
            btn,
            profileInfo.DisplayProfileName)

        If _currentProfileManager.IsCurrentProfile(
            profileInfo.ProfileFile) Then

            HighlightProfileButton(btn)

            SetStatus(
                $"Active profile: {profileInfo.DisplayProfileName}")

        End If

        ConfigureProfileMenu(
            btn,
            profileInfo)

        AddHandler btn.Click,
            AddressOf ProfileButton_Click

        Return btn

    End Function

    Private Sub ConfigureProfileMenu(
        button As ModernSplitButton,
        profileInfo As ProfileInfo)

        Dim menu As New ContextMenuStrip()

        Dim openItem =
            New ToolStripMenuItem(
                $"Open {profileInfo.DisplayProfileName} in Notepad")

        AddHandler openItem.Click,
            Sub()
                OpenProfile(
                    profileInfo)
            End Sub

        Dim removeItem =
            New ToolStripMenuItem(
                "Remove Profile")

        AddHandler removeItem.Click,
            Sub()
                RemoveProfile(
                    profileInfo,
                    button)
            End Sub

        menu.Items.Add(openItem)
        menu.Items.Add(
            New ToolStripSeparator())
        menu.Items.Add(removeItem)

        button.DropDownMenu = menu

    End Sub

    Private Sub OpenProfile(
        profileInfo As ProfileInfo)

        Try

            Process.Start(
                New ProcessStartInfo With {
                    .FileName = "notepad.exe",
                    .Arguments =
                        $"""{profileInfo.ProfileFile}""",
                    .UseShellExecute = True
                })

        Catch ex As Exception

            MessageBox.Show(
                "The profile could not be opened." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Open Profile Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub HighlightProfileButton(
        activeButton As ModernSplitButton)

        If _activeProfileButton IsNot Nothing Then

            _activeProfileButton.BackColor =
                _normalProfileColor

        End If

        activeButton.BackColor =
            _activeProfileColor

        _activeProfileButton =
            activeButton

    End Sub

    Private Sub RemoveProfile(
        profileInfo As ProfileInfo,
        profileButton As ModernSplitButton)

        Dim isCurrentProfile =
            _currentProfileManager.IsCurrentProfile(
                profileInfo.ProfileFile)

        Dim message =
            $"Remove the profile '{profileInfo.DisplayProfileName}'?" &
            Environment.NewLine &
            Environment.NewLine &
            "This will permanently delete the profile file."

        If isCurrentProfile Then

            message &=
                Environment.NewLine &
                Environment.NewLine &
                "This is currently the active profile."

        End If

        Dim result =
            MessageBox.Show(
                message,
                "Remove Profile",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2)

        If result <> DialogResult.Yes Then
            Return
        End If

        Try

            If File.Exists(
                profileInfo.ProfileFile) Then

                File.Delete(
                    profileInfo.ProfileFile)

            End If

            If isCurrentProfile Then

                _currentProfileManager.
                    ClearCurrentProfile()

            End If

            LoadUserProfiles()

            If isCurrentProfile Then

                SetStatus(
                    "Active profile removed.")

            Else

                SetStatus(
                    $"Profile removed: {profileInfo.DisplayProfileName}")

            End If

        Catch ex As Exception

            MessageBox.Show(
                "The profile could not be removed." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Remove Profile Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub UpdateProfileCount()

        Dim storedCount =
            _profileManager.StoredProfileCount

        If storedCount >
            ApplicationConstants.MaximumProfileCount Then

            lblStatusCenter.Text =
                $"Showing the {ApplicationConstants.MaximumProfileCount} most recently added profiles " &
                $"of {storedCount} stored. Select Manage Profiles to view all profiles."

            Return

        End If

        Dim profileText =
            If(
                storedCount = 1,
                "profile",
                "profiles")

        lblStatusCenter.Text =
            $"{storedCount} {profileText} stored"

    End Sub

    Private Sub ProfileButton_Click(
        sender As Object,
        e As EventArgs)

        Dim btn =
            DirectCast(
                sender,
                ModernSplitButton)

        Dim profileInfo =
            DirectCast(
                btn.Tag,
                ProfileInfo)

        If _currentProfileManager.IsCurrentProfile(
            profileInfo.ProfileFile) Then

            MessageBox.Show(
                $"The profile ""{profileInfo.DisplayProfileName}"" is already loaded in Microsoft Flight Simulator.",
                "Profile Already Loaded",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            Return

        End If

        Dim confirmation =
            MessageBox.Show(
                $"Apply the profile ""{profileInfo.DisplayProfileName}"" to Microsoft Flight Simulator?",
                "Apply Profile",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)

        If confirmation <> DialogResult.Yes Then
            Return
        End If

        If Not _profileManager.ApplyProfile(
            profileInfo) Then

            MessageBox.Show(
                _profileManager.LastErrorMessage,
                "Profile Not Applied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            SetStatus(
                "The profile could not be applied.")

            Return

        End If

        If Not _currentProfileManager.SetCurrentProfile(
            profileInfo.ProfileFile) Then

            HighlightProfileButton(btn)

            MessageBox.Show(
                "The profile was applied, but the application could not save it as the current profile.",
                "Profile Tracking Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            SetStatus(
                $"{profileInfo.DisplayProfileName} was applied, but could not be saved as the active profile.")

            Return

        End If

        HighlightProfileButton(btn)

        SetStatus(
            $"Active profile: {profileInfo.DisplayProfileName}")

        MessageBox.Show(
            $"{profileInfo.DisplayProfileName} was applied successfully.",
            "Profile Applied",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

    End Sub

    Private Sub ClearProfileControls()

        While flpProfiles.Controls.Count > 0

            Dim control =
                flpProfiles.Controls(0)

            flpProfiles.Controls.RemoveAt(0)

            control.Dispose()

        End While

    End Sub

    Public Sub ManageProfiles()

        Dim profileFolder =
            My.Settings.ProfileFolder

        If String.IsNullOrWhiteSpace(
            profileFolder) OrElse
            Not Directory.Exists(
                profileFolder) Then

            MessageBox.Show(
                "The profile folder has not been configured or no longer exists.",
                "Manage Profiles",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            Return

        End If

        Try

            Process.Start(
                New ProcessStartInfo With {
                    .FileName = profileFolder,
                    .UseShellExecute = True
                })

        Catch ex As Exception

            MessageBox.Show(
                "The profile folder could not be opened." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Manage Profiles",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            Return

        End Try

        MessageBox.Show(
            Me,
            "File Explorer has been opened to your profile folder." &
            Environment.NewLine &
            Environment.NewLine &
            "Delete, rename, or organize your profile files as needed." &
            Environment.NewLine &
            Environment.NewLine &
            "When you're finished, return here and click OK to refresh the profile list.",
            "Manage Profiles",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

        LoadUserProfiles()

    End Sub

    Public Sub SetProfileFolder()

        Using dlg As New FolderBrowserDialog()

            dlg.Description =
                "Select the folder that stores your MSFS profile files."

            If Directory.Exists(
                My.Settings.ProfileFolder) Then

                dlg.SelectedPath =
                    My.Settings.ProfileFolder

            End If

            If dlg.ShowDialog() <>
                DialogResult.OK Then

                Return

            End If

            Dim selectedFolder =
                dlg.SelectedPath

            If SimulatorFilesManager.
                IsSimulatorConfigFolder(
                    selectedFolder) OrElse
                SimulatorFilesManager.
                FolderContainsUserCfg(
                    selectedFolder) Then

                MessageBox.Show(
                    "This folder contains the active Microsoft Flight Simulator configuration file, UserCfg.opt." &
                    Environment.NewLine &
                    Environment.NewLine &
                    "Please select a separate folder for storing your profiles.",
                    "Invalid Profile Folder",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning)

                Return

            End If

            If Not _profileManager.
                SetCurrentProfileFolder(
                    selectedFolder) Then

                MessageBox.Show(
                    "The selected profile folder could not be saved.",
                    "Invalid Profile Folder",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning)

                Return

            End If

            LoadUserProfiles()

        End Using

    End Sub

    Public Sub MigrateProfiles()

        Dim profileFolder =
            My.Settings.ProfileFolder

        If String.IsNullOrWhiteSpace(
            profileFolder) Then

            MessageBox.Show(
                "Please select your profile folder before migrating profiles.",
                "Profile Folder Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            Return

        End If

        If Not Directory.Exists(
            profileFolder) Then

            MessageBox.Show(
                "The configured profile folder could not be found.",
                "Profile Folder Not Found",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            Return

        End If

        Dim legacyProfileCount =
            _profileManager.GetLegacyProfileCount()

        If legacyProfileCount = 0 Then

            MessageBox.Show(
                "No old .opt profile files were found.",
                "No Profiles to Migrate",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            Return

        End If

        Dim confirmation =
            MessageBox.Show(
                $"{legacyProfileCount} old .opt profile file(s) were found." &
                Environment.NewLine &
                Environment.NewLine &
                "Matching .profx profile files will be created." &
                Environment.NewLine &
                "Successfully migrated .opt files will then be deleted." &
                Environment.NewLine &
                Environment.NewLine &
                "Would you like to continue?",
                "Migrate Old Profiles",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)

        If confirmation <> DialogResult.Yes Then
            Return
        End If

        Dim result =
            _profileManager.MigrateLegacyProfiles()

        Dim message =
            "Migration complete." &
            Environment.NewLine &
            Environment.NewLine &
            $"Converted: {result.ConvertedCount}" &
            Environment.NewLine &
            $"Skipped: {result.SkippedCount}" &
            Environment.NewLine &
            $"Failed: {result.FailedCount}"

        If result.ErrorMessages.Count > 0 Then

            message &=
                Environment.NewLine &
                Environment.NewLine &
                String.Join(
                    Environment.NewLine,
                    result.ErrorMessages)

        End If

        Dim icon =
            If(
                result.FailedCount > 0,
                MessageBoxIcon.Warning,
                MessageBoxIcon.Information)

        MessageBox.Show(
            message,
            "Profile Migration",
            MessageBoxButtons.OK,
            icon)

        LoadUserProfiles()

    End Sub

    Private Sub btnViewUserCfg_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnViewUserCfg.Click

        Try

            SetStatus(
                "Opening UserCfg.opt...")

            SimulatorFilesManager.OpenUserCfg()

            SetStatus("Ready")

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Open UserCfg.opt Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            SetStatus(
                "UserCfg.opt could not be opened.")

        End Try

    End Sub

    Private Async Sub btnSimLauncher2024_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSimLauncher2024.Click

        Await LaunchSimulatorAsync(
            LaunchMode.Normal)

    End Sub

End Class