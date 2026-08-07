Public Class FrmMain

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.UpgradeRequired Then

            My.Settings.Upgrade()

            My.Settings.UpgradeRequired = False
            My.Settings.Save()

        End If

        BackgroundManager.Apply(Me, "masterBackground.png")
        ThemeManager.ApplyModernTheme(Me)

        pnlHeader.BackColor = Color.Transparent

        PageTitleManager.Apply(
            lblPageTitle,
            lblPageDescription,
            "MSFS PROfile Editor",
            "Manage and maintain your simulator profiles"
        )

        Me.DoubleBuffered = True

        Dim result = SimulatorDetector.DetectSimulator()

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

                ' Clear any previously cached simulator path.
                SimulatorFilesManager.ResetSimulatorPaths()

            Case 2

                Using frm As New FrmSimulatorSelection()

                    frm.RememberChoice =
                        My.Settings.RememberSimulatorChoice

                    If frm.ShowDialog(Me) = DialogResult.OK Then

                        My.Settings.RememberSimulatorChoice =
                            frm.RememberChoice

                        If frm.SelectedVersion = SimulatorVersion.Steam Then

                            My.Settings.MSFSVersion = "Steam"

                        Else

                            My.Settings.MSFSVersion = "Microsoft Store"

                        End If

                        My.Settings.Save()

                        ' Clear the cached path so the newly
                        ' selected simulator version is used.
                        SimulatorFilesManager.ResetSimulatorPaths()

                    End If

                End Using

        End Select

        ' Update the application version and simulator
        ' selection in the title bar.
        TitleBarManager.ApplyVersionInfo(Me)

    End Sub

    Private Sub btnMaintenance_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnMaintenance.Click

        MenuActionsManager.ShowModal(
            Me,
            New FrmMaintenance()
        )

    End Sub

    Private Sub btnClose_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnClose.Click

        Application.Exit()

    End Sub

    Private Sub btnProfileSelector_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnProfileSelector.Click

        MenuActionsManager.ShowModal(
            Me,
            New FrmFsProfiles()
        )

    End Sub

End Class