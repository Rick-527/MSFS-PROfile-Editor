Imports System.IO
Imports System.Diagnostics ' Required to open files in external programs

Public Enum SimulatorType
    None
    Steam
    Store
End Enum

Public Class FrmMain

    ' Form Load event handles remembering the last used directory
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim result = SimulatorDetector.DetectSimulator()

        ThemeManager.ApplyModernTheme(Me)

        'update the latest version of the MSFS PROfile Editor
        Dim rawVersion As String = Application.ProductVersion
        Dim currentVersion As String = rawVersion.Split("+"c)(0)
        Me.Text = Me.Text & " - v" & currentVersion & " - MSFS Version: " & My.Settings.MSFSVersion

        Select Case result.InstalledCount

            Case 0

                MessageBox.Show(
                    "Microsoft Flight Simulator 2024 could not be found on this computer.",
                    "MSFS PROfile Editor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning)

            Case 1

                If result.SteamInstalled Then
                    My.Settings.MSFSVersion = "Steam"
                Else
                    My.Settings.MSFSVersion = "Store"
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

        tslMsfsVersion.Text = "MSFS Version: " & My.Settings.MSFSVersion

    End Sub

    Private Sub btnProfileEditor_Click(sender As Object, e As EventArgs) Handles btnProfileEditor.Click

        MenuActionsManager.ShowModal(Me, New FrmProfileEditor())

    End Sub

    Private Sub btnMaintenance_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click

        MenuActionsManager.ShowModal(Me, New FrmMaintenance())

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
        'Me.Close()
    End Sub

End Class
