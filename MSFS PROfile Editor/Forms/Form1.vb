'Imports System.IO
Public Class FrmMain

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BackgroundManager.Apply(Me, "masterBackground.png")
        ThemeManager.ApplyModernTheme(Me)

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
                Else
                    My.Settings.MSFSVersion = "Microsoft Store"
                End If

                My.Settings.Save()

            Case 2

                Using frm As New FrmSimulatorSelection()

                    frm.RememberChoice = My.Settings.RememberSimulatorChoice

                    If frm.ShowDialog(Me) = DialogResult.OK Then

                        My.Settings.RememberSimulatorChoice = frm.RememberChoice
                        My.Settings.MSFSVersion = frm.SelectedVersion.ToString()
                        My.Settings.Save()

                    End If

                End Using

        End Select

        'Update the application version in the title bar.
        UpdateTitleBar()

    End Sub

    Private Sub UpdateTitleBar()

        Dim version = Application.ProductVersion.Split("+"c)(0)

        If My.Settings.MSFSVersion = "" Then
            Me.Text = $"MSFS PROfile Editor - v{version} - Simulator: No Simulator Detected"
        Else
            Me.Text = $"MSFS PROfile Editor - v{version} - Simulator: {My.Settings.MSFSVersion}"
        End If

    End Sub

    Private Sub btnProfileEditor_Click(sender As Object, e As EventArgs) Handles btnProfileEditor.Click

        MenuActionsManager.ShowModal(Me, New FrmProfileEditor())

    End Sub

    Private Sub btnMaintenance_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click

        MenuActionsManager.ShowModal(Me, New FrmMaintenance())

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Application.Exit()

    End Sub

End Class
