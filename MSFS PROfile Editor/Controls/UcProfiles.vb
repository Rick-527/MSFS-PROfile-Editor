Imports System.IO
Imports MSFS_PROfile_Editor.SimulatorLaunchMode

Public Class UcProfiles

    Private Const ProfilesPerGroup As Integer = 5
    Private Const ProfileButtonHeight As Integer = 38

    Private ReadOnly _profileManager As New ProfileManager()
    Private ReadOnly _currentProfileManager As New CurrentProfileManager()

    Private ReadOnly _normalProfileColor As Color =
        Color.FromArgb(45, 55, 65)

    Private ReadOnly _activeProfileColor As Color =
        Color.FromArgb(0, 120, 215)

    Private _activeProfileButton As ModernSplitButton

    Public Event StatusChanged(message As String)

    Private Sub UcProfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        flpProfiles.BackColor = Color.Transparent
        pnlFooter.BackColor = Color.Transparent

        Me.DoubleBuffered = True

        LoadUserProfiles()

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
            RaiseEvent StatusChanged("No Profile Selected")

            Dim profiles = _profileManager.GetProfiles()

            UpdateProfileCount(profiles.Count)

            If profiles.Count = 0 Then

                RaiseEvent StatusChanged("No saved profiles were found.")

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
            Math.Max(150, (availableWidth \ maximumGroupCount) - columnSpacing)

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

            RaiseEvent StatusChanged($"Active profile: {profileInfo.DisplayProfileName}")

        End If

        Dim menu As New ContextMenuStrip()

        Dim openItem As New ToolStripMenuItem("Open " & profileInfo.DisplayProfileName & " in Notepad")

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

                RaiseEvent StatusChanged("Active profile removed.")

            Else

                RaiseEvent StatusChanged($"Profile removed: {profileInfo.DisplayProfileName}")

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

                End Function
                )

        End If

        'btnMigrateProfiles.Enabled = legacyProfileCount > 0

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

            RaiseEvent StatusChanged("The profile could not be applied.")

            Return

        End If

        If Not _currentProfileManager.SetCurrentProfile(profileInfo.ProfileFile) Then

            HighlightProfileButton(btn)

            MessageBox.Show(
                "The profile was applied, but the application could not save it as the current profile.",
                "Profile Tracking Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            RaiseEvent StatusChanged($"{profileInfo.DisplayProfileName} was applied, but could not be saved as the active profile.")

            Return

        End If

        HighlightProfileButton(btn)

        RaiseEvent StatusChanged($"Active profile: {profileInfo.DisplayProfileName}")

        MessageBox.Show(
            $"{profileInfo.DisplayProfileName} was applied successfully.",
            "Profile Applied",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            )

    End Sub

    Private Sub ClearProfileControls()

        While flpProfiles.Controls.Count > 0

            Dim control = flpProfiles.Controls(0)

            flpProfiles.Controls.RemoveAt(0)
            control.Dispose()

        End While

    End Sub

End Class