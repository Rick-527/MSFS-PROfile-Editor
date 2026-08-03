Imports System.IO

Public Class FrmNewSimulatorProfile

    Public ReadOnly Property ProfileName As String
        Get
            Return txtProfileName.Text.Trim()
        End Get
    End Property

    Private Sub FrmNewSimulatorProfile_Load(
        sender As Object,
        e As EventArgs) Handles MyBase.Load

        BackgroundManager.Apply(Me, "masterBackgroundForm1.png")
        ThemeManager.ApplyModernTheme(Me)

        PageTitleManager.Apply(
            lblPageTitle,
            lblPageDescription,
            "Create New Profile",
            "Save the current MSFS graphics settings" &
            Environment.NewLine &
            "as a new profile.")

        pnlHeader.BackColor = Color.Transparent
        pnlContent.BackColor = Color.Transparent
        pnlFooter.BackColor = Color.Transparent

        Me.DoubleBuffered = True

        txtProfileName.Select()

    End Sub

    Private Shared Function IsReservedFileName(fileName As String) As Boolean

        Select Case fileName.ToUpperInvariant()

            Case "CON",
                 "PRN",
                 "AUX",
                 "NUL",
                 "COM1",
                 "COM2",
                 "COM3",
                 "COM4",
                 "COM5",
                 "COM6",
                 "COM7",
                 "COM8",
                 "COM9",
                 "LPT1",
                 "LPT2",
                 "LPT3",
                 "LPT4",
                 "LPT5",
                 "LPT6",
                 "LPT7",
                 "LPT8",
                 "LPT9"

                Return True

            Case Else

                Return False

        End Select

    End Function

    Private Sub ShowInvalidProfileName(message As String)

        MessageBox.Show(
            message,
            "Invalid Profile Name",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning)

        txtProfileName.SelectAll()
        txtProfileName.Select()

    End Sub

    Private Sub btnCreate_Click(
        sender As Object,
        e As EventArgs) Handles btnCreate.Click

        Dim enteredName = txtProfileName.Text.Trim()

        If String.IsNullOrWhiteSpace(enteredName) Then

            MessageBox.Show(
                "Please enter a name for the new profile.",
                "Profile Name Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            txtProfileName.Select()

            Return

        End If

        Dim nameWithoutExtension = enteredName

        While nameWithoutExtension.EndsWith(
            ApplicationConstants.ProfileExtension,
            StringComparison.OrdinalIgnoreCase)

            nameWithoutExtension =
                nameWithoutExtension.
                Substring(
                    0,
                    nameWithoutExtension.Length -
                    ApplicationConstants.ProfileExtension.Length).
                Trim()

        End While

        If String.IsNullOrWhiteSpace(nameWithoutExtension) Then

            ShowInvalidProfileName(
                "Please enter a valid profile name.")

            Return

        End If

        If nameWithoutExtension.IndexOfAny(
            Path.GetInvalidFileNameChars()) >= 0 Then

            ShowInvalidProfileName(
                "The profile name contains characters that cannot be used in a file name.")

            Return

        End If

        If nameWithoutExtension.EndsWith("."c) Then

            ShowInvalidProfileName(
                "The profile name cannot end with a period.")

            Return

        End If

        If IsReservedFileName(nameWithoutExtension) Then

            ShowInvalidProfileName(
                "The profile name is reserved by Windows. Please choose another name.")

            Return

        End If

        txtProfileName.Text = nameWithoutExtension

        Me.DialogResult = DialogResult.OK

    End Sub

    Private Sub btnCancel_Click(
        sender As Object,
        e As EventArgs) Handles btnCancel.Click

        Me.DialogResult = DialogResult.Cancel

    End Sub

End Class