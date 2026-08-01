Public Class FrmFsProfiles

    Private ReadOnly _profileManager As New ProfileManager()
    Private ReadOnly _currentProfileManager As New CurrentProfileManager()

    Private _activeProfileButton As Button

    Private Sub FrmFsProfiles_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        BackgroundManager.Apply(Me, "masterBackground.png")
        ThemeManager.ApplyModernTheme(Me)
        flpProfiles.BackColor = Color.Transparent
        pnlHeader.BackColor = Color.Transparent
        pnlFooter.BackColor = Color.Transparent

        lblPageTitle.AutoSize = False
        lblPageTitle.Dock = DockStyle.Top
        lblPageTitle.Height = 40
        lblPageTitle.TextAlign = ContentAlignment.MiddleCenter
        lblPageTitle.ForeColor = Color.White
        lblPageTitle.Font = New Font("Segoe UI", 18, FontStyle.Bold)
        lblPageTitle.Text = "MSFS PROfile Selector"

        lblPageDescription.AutoSize = False
        lblPageDescription.Dock = DockStyle.Top
        lblPageDescription.Height = 25
        lblPageDescription.TextAlign = ContentAlignment.MiddleCenter
        lblPageDescription.ForeColor = Color.LightGray
        lblPageDescription.Font = New Font("Segoe UI", 10)
        lblPageDescription.Text = "Select a saved profile to load or edit"

        Me.DoubleBuffered = True

        LoadProfiles()

        TitleBarManager.Apply(Me)

    End Sub

    Private Sub HighlightProfileButton(activeButton As Button)

        If _activeProfileButton IsNot Nothing Then
            _activeProfileButton.BackColor = Color.FromArgb(55, 55, 60)
        End If

        activeButton.BackColor = Color.FromArgb(0, 120, 215)

        _activeProfileButton = activeButton

    End Sub

    Private Sub LoadProfiles()

        flpProfiles.Controls.Clear()

        Dim profiles As List(Of ProfileInfo) = _profileManager.GetProfiles()

        For Each profileInfo As ProfileInfo In profiles

            Dim btn As New ModernSplitButton()

            btn.Text = profileInfo.DisplayProfileName

            btn.Width = Math.Min(350, flpProfiles.ClientSize.Width - 25)
            btn.Height = 38

            btn.FlatStyle = FlatStyle.Flat
            btn.BackColor = Color.FromArgb(45, 55, 65)
            btn.ForeColor = Color.White

            btn.FlatAppearance.BorderColor = Color.FromArgb(80, 160, 170)
            btn.FlatAppearance.BorderSize = 1

            btn.TextAlign = ContentAlignment.MiddleLeft
            btn.Padding = New Padding(12, 0, 0, 0)

            btn.Margin = New Padding(0, 0, 0, 8)

            btn.Tag = profileInfo

            If _currentProfileManager.IsCurrentProfile(profileInfo.ProfileFile) Then
                HighlightProfileButton(btn)
            End If

            Dim menu As New ContextMenuStrip()

            Dim openItem As New ToolStripMenuItem("Open " & profileInfo.DisplayProfileName & " in Notepad")

            AddHandler openItem.Click,
                    Sub()

                        Dim profile = DirectCast(btn.Tag, ProfileInfo)

                        Process.Start("notepad.exe", profile.ProfileFile)

                    End Sub

            menu.Items.Add(openItem)

            btn.DropDownMenu = menu

            flpProfiles.Controls.Add(btn)

            AddHandler btn.Click, AddressOf ProfileButton_Click

            'If _profileManager.LoadProfile(profileInfo) Then

            '    _currentProfileManager.SetCurrentProfile(profileInfo.ProfileFile)

            '    HighlightProfileButton(btn)

            '    lblStatus.Text =
            '        $"{profileInfo.DisplayProfileName} loaded successfully."

            'End If

        Next

    End Sub

    Private Sub ProfileButton_Click(sender As Object, e As EventArgs)

        Dim btn = DirectCast(sender, ModernSplitButton)

        Dim profileInfo = DirectCast(btn.Tag, ProfileInfo)

        If _currentProfileManager.SetCurrentProfile(profileInfo.ProfileFile) Then

            HighlightProfileButton(btn)

            lblStatus.Text = $"Active profile: {profileInfo.DisplayProfileName}"

        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub
End Class