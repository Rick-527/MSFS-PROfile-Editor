Imports System.IO
Imports MSFS_PROfile_Editor.SimulatorLaunchMode

Public Class FrmFsProfiles

    Private Const ProfilesPerGroup As Integer = 5
    Private Const ProfileButtonHeight As Integer = 38

    Private ReadOnly _profileManager As New ProfileManager()
    Private ReadOnly _currentProfileManager As New CurrentProfileManager()

    Private ReadOnly _normalProfileColor As Color =
            Color.FromArgb(45, 55, 65)

    Private ReadOnly _activeProfileColor As Color =
            Color.FromArgb(0, 120, 215)

    Private _activeProfileButton As ModernSplitButton

    Private Sub FrmFsProfiles_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        BackgroundManager.Apply(Me, "masterBackground.png")
        ThemeManager.ApplyModernTheme(Me)
        flpProfiles.BackColor = Color.Transparent
        pnlHeader.BackColor = Color.Transparent
        pnlFooter.BackColor = Color.Transparent

        PageTitleManager.Apply(
            lblPageTitle,
            lblPageDescription,
            "MSFS PROfile Selector",
            "Select a saved profile to apply, or use the menu to edit it"
            )

        btnSimLauncher2024.Width = 350
        btnSimLauncher2024.Height = 38

        Me.DoubleBuffered = True

        LoadUserProfiles()

        TitleBarManager.ApplyFormInfo(Me, "Profile Manager")

    End Sub

    Private Function CreateProfileGroupPanel() As FlowLayoutPanel

        Return New FlowLayoutPanel With {
            .AutoSize = True,
            .AutoSizeMode = AutoSizeMode.GrowAndShrink,
            .FlowDirection = FlowDirection.TopDown,
            .WrapContents = False,
            .Margin = New Padding(8, 8, 8, 8),
            .Padding = New Padding(0),
            .BackColor = Color.Transparent
        }

    End Function

    Private Sub HighlightProfileButton(activeButton As ModernSplitButton)

        If _activeProfileButton IsNot Nothing Then
            _activeProfileButton.BackColor = _normalProfileColor
        End If

        activeButton.BackColor = _activeProfileColor
        _activeProfileButton = activeButton

    End Sub

    Private Sub LoadUserProfiles()

        flpProfiles.SuspendLayout()

        Try

            ClearProfileControls()

            _activeProfileButton = Nothing
            lblStatus.Text = "No Profile Selected"

            Dim profiles = _profileManager.GetProfiles()

            UpdateProfileCount(profiles.Count)

            If profiles.Count = 0 Then

                lblStatus.Text = "No saved profiles were found."

                Return

            End If

            Dim availableWidth =
            flpProfiles.ClientSize.Width -
            flpProfiles.Padding.Horizontal

            Const columnSpacing As Integer = 16

            Dim maximumGroupCount =
                CInt(
                    Math.Ceiling(
                        ApplicationConstants.MaximumProfileCount /
                        CDbl(ProfilesPerGroup)
                    )
                )

            Dim profileButtonWidth =
            Math.Max(
                150,
                (availableWidth \ maximumGroupCount) - columnSpacing)

            Dim profileLayout As New TableLayoutPanel With {
                .Name = "tblProfileGroups",
                .AutoSize = True,
                .AutoSizeMode = AutoSizeMode.GrowAndShrink,
                .ColumnCount = maximumGroupCount,
                .RowCount = 1,
                .Margin = New Padding(0),
                .Padding = New Padding(0),
                .BackColor = Color.Transparent
            }

            For columnNumber = 0 To maximumGroupCount - 1

                profileLayout.ColumnStyles.Add(
                    New ColumnStyle(SizeType.AutoSize))

            Next

            profileLayout.RowStyles.Add(
                New RowStyle(SizeType.AutoSize))

            Dim groupCount =
            CInt(
                Math.Ceiling(
                    profiles.Count / CDbl(ProfilesPerGroup)))

            For groupIndex = 0 To groupCount - 1

                Dim groupPanel =
                    CreateProfileGroupPanel()

                Dim startIndex =
                    groupIndex * ProfilesPerGroup

                Dim endIndex =
                Math.Min(
                    startIndex + ProfilesPerGroup,
                    profiles.Count)

                For profileIndex = startIndex To endIndex - 1

                    Dim profileInfo =
                        profiles(profileIndex)

                    Dim profileButton =
                        CreateProfileButton(
                        profileInfo,
                        profileButtonWidth)

                    groupPanel.Controls.Add(profileButton)

                Next

                profileLayout.Controls.Add(
                    groupPanel,
                    groupIndex,
                    0)

            Next

            profileLayout.PerformLayout()

            Dim preferredSize =
                profileLayout.GetPreferredSize(Size.Empty)

            profileLayout.AutoSize = False
            profileLayout.Size = preferredSize

            flpProfiles.Controls.Add(profileLayout)

            flpProfiles.PerformLayout()

        Finally

            flpProfiles.ResumeLayout(True)

        End Try

    End Sub

    Private Function CreateProfileButton(profileInfo As ProfileInfo, buttonWidth As Integer) As ModernSplitButton

        Dim btn As New ModernSplitButton()

        btn.Text = profileInfo.DisplayProfileName
        btn.Width = buttonWidth
        btn.Height = ProfileButtonHeight

        btn.FlatStyle = FlatStyle.Flat
        btn.BackColor = _normalProfileColor
        btn.ForeColor = Color.White

        btn.FlatAppearance.BorderColor =
        Color.FromArgb(80, 160, 170)

        btn.FlatAppearance.BorderSize = 1

        btn.TextAlign =
        ContentAlignment.MiddleLeft

        btn.Padding =
        New Padding(12, 0, 0, 0)

        btn.Margin =
        New Padding(0, 0, 0, 8)

        btn.TabStop = False

        btn.Tag = profileInfo

        If _currentProfileManager.
        IsCurrentProfile(profileInfo.ProfileFile) Then

            HighlightProfileButton(btn)

            lblStatus.Text = $"Active profile: {profileInfo.DisplayProfileName}"

        End If

        Dim menu As New ContextMenuStrip()

        Dim openItem As New ToolStripMenuItem(
            "Open " &
            profileInfo.DisplayProfileName &
            " in Notepad")

        AddHandler openItem.Click,
        Sub()

            Dim profile =
                DirectCast(btn.Tag, ProfileInfo)

            Try

                Process.Start(
                    New ProcessStartInfo With {
                        .FileName = "notepad.exe",
                        .Arguments =
                            $"""{profile.ProfileFile}""",
                        .UseShellExecute = True
                        })

            Catch ex As Exception

                MessageBox.Show(
                    $"The profile could not be opened." &
                    $"{Environment.NewLine}{Environment.NewLine}" &
                    ex.Message,
                    "Open Profile Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)

            End Try

        End Sub

        menu.Items.Add(openItem)

        menu.Items.Add(New ToolStripSeparator())

        Dim removeItem As New ToolStripMenuItem("Remove Profile")

        AddHandler removeItem.Click,
        Sub()

            Dim profile = DirectCast(btn.Tag, ProfileInfo)

            RemoveProfile(profile, btn)

        End Sub

        menu.Items.Add(removeItem)

        btn.DropDownMenu = menu

        AddHandler btn.Click,
        AddressOf ProfileButton_Click

        Return btn

    End Function

    Private Sub RemoveProfile(
        profileInfo As ProfileInfo,
        profileButton As ModernSplitButton)

        Dim isCurrentProfile = _currentProfileManager.IsCurrentProfile(profileInfo.ProfileFile)

        Dim message =
            $"Remove the profile '{profileInfo.DisplayProfileName}'?" &
            $"{Environment.NewLine}{Environment.NewLine}" &
            "This will permanently delete the profile file."

        If isCurrentProfile Then

            message &= $"{Environment.NewLine}{Environment.NewLine}" &
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

            If File.Exists(profileInfo.ProfileFile) Then
                File.Delete(profileInfo.ProfileFile)
            End If

            If isCurrentProfile Then

                _currentProfileManager.ClearCurrentProfile()

            End If

            profileButton.Parent?.Controls.Remove(profileButton)

            profileButton.Dispose()

            If isCurrentProfile Then

                lblStatus.Text = "Active profile removed."

            Else

                lblStatus.Text = $"Profile removed: {profileInfo.DisplayProfileName}"

            End If

        Catch ex As Exception

            MessageBox.Show(
                $"The profile could not be removed." &
                $"{Environment.NewLine}{Environment.NewLine}" &
                ex.Message,
                "Remove Profile Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub UpdateProfileCount(profileCount As Integer)

        If _profileManager.StoredProfileCount > ApplicationConstants.MaximumProfileCount Then

            lblStatusCenter.Text =
                $"Showing the {ApplicationConstants.MaximumProfileCount} most recently added profiles " &
                $"of {_profileManager.StoredProfileCount} stored. Select Manage Profiles to view all profiles."

        Else

            Dim storedCount = _profileManager.StoredProfileCount

            Dim profileText =
                If(storedCount = 1, "profile", "profiles")

            lblStatusCenter.Text =
                $"{storedCount} {profileText} stored"

        End If

        Dim profileFolder = My.Settings.ProfileFolder

        Dim legacyProfileCount =
            _profileManager.GetLegacyProfileCount()

        If Not String.IsNullOrWhiteSpace(profileFolder) AndAlso
       Directory.Exists(profileFolder) Then

            legacyProfileCount =
            Directory.
            GetFiles(
                profileFolder,
                "*.opt",
                SearchOption.TopDirectoryOnly).
            Count(
                Function(filePath)

                    Return Not String.Equals(
                        Path.GetFileName(filePath),
                        "UserCfg.opt",
                        StringComparison.OrdinalIgnoreCase)

                End Function)

        End If

        btnMigrateProfiles.Enabled = legacyProfileCount > 0

    End Sub

    Private Sub ProfileButton_Click(sender As Object, e As EventArgs)

        Dim btn = DirectCast(sender, ModernSplitButton)
        Dim profileInfo = DirectCast(btn.Tag, ProfileInfo)

        Dim confirmResult = MessageBox.Show(
                $"Apply the profile ""{profileInfo.DisplayProfileName}"" to Microsoft Flight Simulator?",
                "Apply Profile",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                )

        If confirmResult <> DialogResult.Yes Then
            Return
        End If

        If Not _profileManager.ApplyProfile(profileInfo) Then

            MessageBox.Show(
                    _profileManager.LastErrorMessage,
                    "Profile Not Applied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    )

            lblStatus.Text = "The profile could not be applied."

            Return

        End If

        If Not _currentProfileManager.SetCurrentProfile(profileInfo.ProfileFile) Then

            HighlightProfileButton(btn)

            MessageBox.Show(
                "The profile was applied, but the application could not save it as the current profile.",
                "Profile Tracking Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            lblStatus.Text =
                $"{profileInfo.DisplayProfileName} was applied, but could not be saved as the active profile."

            Return

        End If

        HighlightProfileButton(btn)

        lblStatus.Text =
                $"Active profile: {profileInfo.DisplayProfileName}"

        MessageBox.Show(
                $"{profileInfo.DisplayProfileName} was applied successfully.",
                "Profile Applied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                )

    End Sub

    Private Async Function LaunchSimulator(mode As LaunchMode) As Task

        btnSimLauncher2024.Enabled = False

        Try

            lblStatus.Text = "Launching Microsoft Flight Simulator..."

            If Await SimulatorLauncher.LaunchAsync(mode) Then

                CloseApplication()
                Return

            End If

            lblStatus.Text = "Microsoft Flight Simulator could not be launched."

        Finally

            btnSimLauncher2024.Enabled = True

        End Try

    End Function

    Private Async Sub btnSimLauncher2024_Click(sender As Object, e As EventArgs) Handles btnSimLauncher2024.Click

        Await LaunchSimulator(LaunchMode.Normal)

    End Sub

    Private Async Sub mnuLaunchNormal_Click(sender As Object, e As EventArgs) Handles mnuLaunchNormal.Click

        Await LaunchSimulator(LaunchMode.Normal)

    End Sub

    Private Async Sub mnuLaunchFsuipc_Click(sender As Object, e As EventArgs) Handles mnuLaunchFsuipc.Click

        Await LaunchSimulator(LaunchMode.FSUIPC)

    End Sub

    Private Sub ClearProfileControls()

        While flpProfiles.Controls.Count > 0

            Dim control = flpProfiles.Controls(0)

            flpProfiles.Controls.RemoveAt(0)
            control.Dispose()

        End While

    End Sub

    Private Sub btnMigrateProfiles_Click(sender As Object, e As EventArgs) Handles btnMigrateProfiles.Click

        Dim profileFolder = My.Settings.ProfileFolder

        If String.IsNullOrWhiteSpace(profileFolder) Then

            MessageBox.Show(
                "Please select your profile folder before migrating profiles.",
                "Profile Folder Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            Exit Sub

        End If

        If Not Directory.Exists(profileFolder) Then

            MessageBox.Show(
                "The configured profile folder could not be found.",
                "Profile Folder Not Found",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            Exit Sub

        End If
        Dim legacyProfileCount =
            _profileManager.GetLegacyProfileCount()

        If legacyProfileCount = 0 Then

            MessageBox.Show(
                "No old .opt profile files were found.",
                "No Profiles to Migrate",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            Exit Sub

        End If

        Dim confirmation = MessageBox.Show(
            $"{legacyProfileCount} old .opt profile file(s) were found." &
            $"{Environment.NewLine}{Environment.NewLine}" &
            "Matching .profx copies will be created." &
            $"{Environment.NewLine}" &
            "The original .opt files will not be changed or deleted." &
            $"{Environment.NewLine}{Environment.NewLine}" &
            "Would you like to continue?",
            "Migrate Old Profiles",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If confirmation <> DialogResult.Yes Then
            Exit Sub
        End If

        Dim result = _profileManager.MigrateLegacyProfiles()

        Dim message =
            $"Migration complete.{Environment.NewLine}{Environment.NewLine}" &
            $"Converted: {result.ConvertedCount}{Environment.NewLine}" &
            $"Skipped: {result.SkippedCount}{Environment.NewLine}" &
            $"Failed: {result.FailedCount}"

        If result.ErrorMessages.Count > 0 Then

            message &=
                $"{Environment.NewLine}{Environment.NewLine}" &
                String.Join(Environment.NewLine, result.ErrorMessages)

        End If

        Dim icon =
            If(result.FailedCount > 0,
               MessageBoxIcon.Warning,
               MessageBoxIcon.Information)

        MessageBox.Show(
            message,
            "Profile Migration",
            MessageBoxButtons.OK,
            icon)

        LoadUserProfiles()

    End Sub

    Private Sub btnSetProfileFolder_Click(sender As Object, e As EventArgs) Handles btnSetProfileFolder.Click

        Using dlg As New FolderBrowserDialog()

            dlg.Description = "Select the folder that stores your MSFS profile files."

            If Directory.Exists(My.Settings.ProfileFolder) Then
                dlg.SelectedPath = My.Settings.ProfileFolder
            End If

            If dlg.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            Dim selectedFolder = dlg.SelectedPath

            If SimulatorFilesManager.IsSimulatorConfigFolder(selectedFolder) OrElse
                SimulatorFilesManager.FolderContainsUserCfg(selectedFolder) Then

                MessageBox.Show(
                    "This folder contains the active Microsoft Flight Simulator configuration file, UserCfg.opt." &
                    $"{Environment.NewLine}{Environment.NewLine}" &
                    "Please select a separate folder for storing your profiles.",
                    "Invalid Profile Folder",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning)

                Return

            End If

            If Not _profileManager.SetCurrentProfileFolder(selectedFolder) Then

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

    Private Sub btnCreateNewProfile_Click(sender As Object, e As EventArgs) Handles btnCreateNewProfile.Click

        Using dlg As New FrmNewSimulatorProfile

            If dlg.ShowDialog(Me) <> DialogResult.OK Then
                Return
            End If

            Try

                Dim createdProfile = _profileManager.CreateProfile(dlg.ProfileName)

                LoadUserProfiles()

                MessageBox.Show(
                    $"The profile ""{Path.GetFileNameWithoutExtension(createdProfile)}"" was created successfully.",
                    "Profile Created",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

            Catch ex As ArgumentException

                MessageBox.Show(
                    ex.Message,
                    "Invalid Profile Name",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

            Catch ex As IOException

                MessageBox.Show(
                    ex.Message,
                    "Profile Not Created",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

            Catch ex As UnauthorizedAccessException

                MessageBox.Show(
                    "The profile could not be created because access to the selected folder was denied.",
                    "Profile Not Created",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

            Catch ex As Exception

                MessageBox.Show(
                    $"The profile could not be created.{Environment.NewLine}{Environment.NewLine}{ex.Message}",
                    "Profile Not Created",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

            End Try

        End Using

    End Sub

    Private Sub btnManageProfiles_Click(sender As Object, e As EventArgs) Handles btnManageProfiles.Click

        Dim profileFolder = My.Settings.ProfileFolder

        If String.IsNullOrWhiteSpace(profileFolder) OrElse
            Not Directory.Exists(profileFolder) Then

            MessageBox.Show(
                "The profile folder has not been configured or no longer exists.",
                "Manage Profiles",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return
        End If

        Try

            Process.Start(
                New ProcessStartInfo With {
                    .FileName = profileFolder,
                    .UseShellExecute = True
                }
            )

        Catch ex As Exception

            MessageBox.Show(
                $"The profile folder could not be opened.{Environment.NewLine}{Environment.NewLine}{ex.Message}",
                "Manage Profiles",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

            Return

        End Try

        MessageBox.Show(
            Me,
            "File Explorer has been opened to your profile folder." &
            Environment.NewLine & Environment.NewLine &
            "Delete, rename, or organize your profile files as needed." &
            Environment.NewLine & Environment.NewLine &
            "When you're finished, return here and click OK to refresh the profile list.",
            "Manage Profiles",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

        LoadUserProfiles()

    End Sub

    Private Sub CloseApplication()

        Dim mainForm =
            Application.OpenForms.
            OfType(Of FrmMain)().
            FirstOrDefault()

        If mainForm IsNot Nothing Then
            mainForm.Close()
        Else
            Application.Exit()
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub btnViewUserCfg_Click(sender As Object, e As EventArgs) Handles btnViewUserCfg.Click

        UiActionRunner.Run(Me, lblStatus,
            Sub()
                SimulatorFilesManager.OpenUserCfg()
            End Sub
            )

    End Sub
End Class