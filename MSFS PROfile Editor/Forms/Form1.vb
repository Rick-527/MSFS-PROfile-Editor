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

        Dim detector As New SimulatorDetector()
        Dim result = detector.DetectSimulator()

        ThemeManager.ApplyModernTheme(Me)

        ' Lock down the form sizing capabilities completely
        'Me.FormBorderStyle = FormBorderStyle.FixedSingle ' Disables edge dragging
        'Me.MaximizeBox = False                           ' Disables the maximize box window utility

        'update the latest version of the MSFS PROfile Editor
        Dim rawVersion As String = Application.ProductVersion
        Dim currentVersion As String = rawVersion.Split("+"c)(0)
        Me.Text = Me.Text & " - v" & currentVersion

        Select Case True

            Case result.SteamInstalled AndAlso result.StoreInstalled

                MessageBox.Show("Both versions were found.")

            Case result.SteamInstalled

                My.Settings.MSFSVersion = "Steam"

            Case result.StoreInstalled

                My.Settings.MSFSVersion = "Store"

            Case Else

                MessageBox.Show("Microsoft Flight Simulator 2024 was not found.")

        End Select

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
