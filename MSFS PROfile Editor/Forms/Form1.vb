Public Class FrmMain

    Private _profilesControl As UcProfiles

    Private Const NavTop As Integer = 20
    Private Const NavButtonSpacing As Integer = 45
    Private Const NavSectionSpacing As Integer = 20
    Private Const CloseButtonTop As Integer = 394

    Private Sub FrmMain_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        UpgradeSettingsIfRequired()

        ThemeManager.ApplyModernTheme(Me)

        pnlHeader.BackColor = Color.Transparent

        Me.DoubleBuffered = True

        ConfigureSimulator()

        ShowHomePage()

        TitleBarManager.ApplyVersionInfo(Me)

    End Sub

    Private Sub UpgradeSettingsIfRequired()

        If Not My.Settings.UpgradeRequired Then
            Return
        End If

        My.Settings.Upgrade()

        My.Settings.UpgradeRequired = False
        My.Settings.Save()

    End Sub

    Private Sub ConfigureSimulator()

        Dim result =
            SimulatorDetector.DetectSimulator()

        Select Case result.InstalledCount

            Case 0

                MessageBox.Show(
                    "Microsoft Flight Simulator 2024 could not be found on this computer.",
                    "MSFS PROfile Editor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

            Case 1

                If result.SteamInstalled Then

                    My.Settings.MSFSVersion = "Steam"

                ElseIf result.StoreInstalled Then

                    My.Settings.MSFSVersion = "Microsoft Store"

                End If

                My.Settings.Save()

                SimulatorFilesManager.ResetSimulatorPaths()

            Case 2

                SelectSimulatorVersion()

        End Select

    End Sub

    Private Sub SelectSimulatorVersion()

        Using frm As New FrmSimulatorSelection()

            frm.RememberChoice =
                My.Settings.RememberSimulatorChoice

            If frm.ShowDialog(Me) <> DialogResult.OK Then
                Return
            End If

            My.Settings.RememberSimulatorChoice =
                frm.RememberChoice

            If frm.SelectedVersion = SimulatorVersion.Steam Then

                My.Settings.MSFSVersion = "Steam"

            Else

                My.Settings.MSFSVersion = "Microsoft Store"

            End If

            My.Settings.Save()

            SimulatorFilesManager.ResetSimulatorPaths()

        End Using

    End Sub

    Private Sub ShowHomePage()

        Dim homeControl As New UcHome()

        AddHandler homeControl.ProfilesRequested,
        AddressOf ShowProfilesPage

        AddHandler homeControl.MaintenanceRequested,
        AddressOf ShowMaintenancePage

        homeControl.SetSimulatorName(
        My.Settings.MSFSVersion)

        ShowContent(homeControl)

        SetPageTitle(
        "MSFS PROfile Editor",
        "Profiles and configuration tools for Microsoft Flight Simulator 2024"
    )

        ShowMainNavigation()

    End Sub

    Private Sub ShowProfilesPage()

        _profilesControl = New UcProfiles()

        AddHandler _profilesControl.StatusChanged,
            AddressOf SetStatus

        ShowContent(_profilesControl)

        SetPageTitle(
            "Profiles",
            "Manage your Microsoft Flight Simulator profiles"
        )

        ShowProfileNavigation()

        btnProfileSelector.Enabled = False
        btnCreateNewProfile.Enabled = True

        UpdateProfileNavigationState()

    End Sub

    Private Sub ShowNewProfilePage()

        Dim newProfileControl As New UcNewProfile()

        AddHandler newProfileControl.StatusChanged,
            AddressOf SetStatus

        AddHandler newProfileControl.CancelRequested,
            Sub()
                ShowProfilesPage()
            End Sub

        AddHandler newProfileControl.ProfileCreated,
            Sub()
                ShowProfilesPage()
            End Sub

        ShowContent(newProfileControl)

        SetPageTitle(
            "Create New Profile",
            "Save the current MSFS graphics settings as a new profile"
        )

        ShowProfileNavigation()

        btnCreateNewProfile.Enabled = False

    End Sub

    Private Sub ShowMaintenancePage()

        Dim maintenanceControl As New UcMaintenance()

        AddHandler maintenanceControl.StatusChanged,
            AddressOf SetStatus

        ShowContent(maintenanceControl)

        SetPageTitle(
            "MSFS File Maintenance",
            "Manage Microsoft Flight Simulator program files"
        )

        ShowMaintenanceNavigation()

    End Sub

    Private Sub ShowContent(control As Control)

        pnlContent.BackgroundImage = Nothing
        pnlContent.Controls.Clear()

        control.Dock = DockStyle.Fill

        pnlContent.Controls.Add(control)

        control.BringToFront()

    End Sub

    Private Sub SetPageTitle(
        title As String,
        description As String)

        PageTitleManager.Apply(
            lblPageTitle,
            lblPageDescription,
            title,
            description
        )

    End Sub

    Private Sub SetStatus(message As String)

        lblStatus.Text = message

    End Sub

    Private Sub ShowMainNavigation()

        btnProfileSelector.Enabled = True

        SetToolTip.SetToolTip(
            btnProfileSelector,
            "Manage your Microsoft Flight Simulator profiles."
        )

        btnCreateNewProfile.Visible = False
        btnManageProfiles.Visible = False
        btnSetProfileFolder.Visible = False
        btnMigrateProfiles.Visible = False

        btnMaintenance.Enabled = True

        SetToolTip.SetToolTip(
            btnMaintenance,
            "Backup and edit MSFS system files"
        )

        btnClose.Visible = True

        btnProfileSelector.Top = NavTop

        btnMaintenance.Top =
            btnProfileSelector.Top +
            btnProfileSelector.Height +
            NavSectionSpacing

        btnClose.Top = CloseButtonTop

    End Sub

    Private Sub ShowProfileNavigation()

        btnProfileSelector.Enabled = False

        btnCreateNewProfile.Visible = True
        btnManageProfiles.Visible = True
        btnSetProfileFolder.Visible = True
        btnMigrateProfiles.Visible = False

        btnMaintenance.Enabled = True

        SetToolTip.SetToolTip(
            btnMaintenance,
            "Backup and edit MSFS system files"
        )

        btnClose.Visible = True

        btnProfileSelector.Top = NavTop

        btnCreateNewProfile.Top =
            btnProfileSelector.Top +
            NavButtonSpacing

        btnManageProfiles.Top =
            btnCreateNewProfile.Top +
            NavButtonSpacing

        btnSetProfileFolder.Top =
            btnManageProfiles.Top +
            NavButtonSpacing

        btnMigrateProfiles.Top =
            btnSetProfileFolder.Top +
            NavButtonSpacing

        PositionMaintenanceButton()

        btnClose.Top = CloseButtonTop

    End Sub

    Private Sub ShowMaintenanceNavigation()

        btnProfileSelector.Enabled = True

        btnCreateNewProfile.Visible = False
        btnManageProfiles.Visible = False
        btnSetProfileFolder.Visible = False
        btnMigrateProfiles.Visible = False

        btnMaintenance.Enabled = False
        btnClose.Visible = True

        btnProfileSelector.Top = NavTop
        btnClose.Top = CloseButtonTop

    End Sub

    Private Sub UpdateProfileNavigationState()

        If _profilesControl Is Nothing Then

            btnMigrateProfiles.Visible = False
            PositionMaintenanceButton()

            Return

        End If

        btnMigrateProfiles.Visible =
            _profilesControl.HasLegacyProfiles

        PositionMaintenanceButton()

    End Sub

    Private Sub PositionMaintenanceButton()

        If btnMigrateProfiles.Visible Then

            btnMaintenance.Top =
                btnMigrateProfiles.Top +
                btnMigrateProfiles.Height +
                NavSectionSpacing

        Else

            btnMaintenance.Top =
                btnSetProfileFolder.Top +
                btnSetProfileFolder.Height +
                NavSectionSpacing

        End If

    End Sub

    Private Sub btnProfileSelector_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnProfileSelector.Click

        ShowProfilesPage()

    End Sub

    Private Sub btnCreateNewProfile_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCreateNewProfile.Click

        ShowNewProfilePage()

    End Sub

    Private Sub btnManageProfiles_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnManageProfiles.Click

        _profilesControl?.ManageProfiles()

    End Sub

    Private Sub btnSetProfileFolder_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSetProfileFolder.Click

        _profilesControl?.SetProfileFolder()

        UpdateProfileNavigationState()

    End Sub

    Private Sub btnMigrateProfiles_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnMigrateProfiles.Click

        _profilesControl?.MigrateProfiles()

        UpdateProfileNavigationState()

    End Sub

    Private Sub btnMaintenance_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnMaintenance.Click

        ShowMaintenancePage()

    End Sub

    Private Sub btnClose_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnClose.Click

        Application.Exit()

    End Sub

End Class