Imports System.IO

Public Class UcNewProfile

    Public Event ProfileCreated()
    Public Event CancelRequested()
    Public Event StatusChanged(message As String)

    Private ReadOnly _profileManager As New ProfileManager()

    Private Sub UcNewProfile_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ConfigureAppearance()

        txtProfileName.Select()

    End Sub

    Private Sub ConfigureAppearance()

        Me.BackColor = Color.Transparent
        Me.DoubleBuffered = True

        txtProfileName.BackColor =
            Color.FromArgb(59, 69, 89)

        txtProfileName.ForeColor =
            Color.FromArgb(236, 239, 244)

        txtProfileName.BorderStyle =
            BorderStyle.FixedSingle

        btnCreate.FlatStyle =
            FlatStyle.Flat

        btnCreate.FlatAppearance.BorderSize = 0

        btnCreate.BackColor =
            Color.FromArgb(0, 120, 190)

        btnCreate.ForeColor =
            Color.White

        btnCreate.Font =
            New Font(
                "Segoe UI",
                9.75F,
                FontStyle.Bold)

        btnCancel.FlatStyle =
            FlatStyle.Flat

        btnCancel.FlatAppearance.BorderSize = 1

        btnCancel.FlatAppearance.BorderColor =
            Color.FromArgb(90, 100, 115)

        btnCancel.BackColor =
            Color.FromArgb(48, 58, 68)

        btnCancel.ForeColor =
            Color.FromArgb(236, 239, 244)

        btnCancel.Font =
            New Font(
                "Segoe UI",
                9.75F,
                FontStyle.Bold)

    End Sub

    Private Shared Function IsReservedFileName(
        fileName As String
    ) As Boolean

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

    Private Shared Function RemoveProfileExtension(
        profileName As String
    ) As String

        Dim normalizedName =
            profileName.Trim()

        While normalizedName.EndsWith(
            ApplicationConstants.ProfileExtension,
            StringComparison.OrdinalIgnoreCase)

            normalizedName =
                normalizedName.
                Substring(
                    0,
                    normalizedName.Length -
                    ApplicationConstants.ProfileExtension.Length).
                Trim()

        End While

        Return normalizedName

    End Function

    Private Function ValidateProfileName(
        profileName As String
    ) As Boolean

        If String.IsNullOrWhiteSpace(profileName) Then

            ShowInvalidProfileName(
                "Please enter a valid profile name.")

            Return False

        End If

        If profileName.IndexOfAny(
            Path.GetInvalidFileNameChars()) >= 0 Then

            ShowInvalidProfileName(
                "The profile name contains characters that cannot be used in a file name.")

            Return False

        End If

        If profileName.EndsWith("."c) Then

            ShowInvalidProfileName(
                "The profile name cannot end with a period.")

            Return False

        End If

        If IsReservedFileName(profileName) Then

            ShowInvalidProfileName(
                "The profile name is reserved by Windows. Please choose another name.")

            Return False

        End If

        Return True

    End Function

    Private Sub ShowInvalidProfileName(
        message As String)

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
        e As EventArgs
    ) Handles btnCreate.Click

        Dim enteredName =
            txtProfileName.Text.Trim()

        If String.IsNullOrWhiteSpace(enteredName) Then

            MessageBox.Show(
                "Please enter a name for the new profile.",
                "Profile Name Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            txtProfileName.Select()

            Return

        End If

        Dim profileName =
            RemoveProfileExtension(
                enteredName)

        If Not ValidateProfileName(profileName) Then
            Return
        End If

        Try

            Dim createdProfile =
                _profileManager.CreateProfile(
                    profileName)

            Dim displayName =
                Path.GetFileNameWithoutExtension(
                    createdProfile)

            RaiseEvent StatusChanged(
                $"Profile created: {displayName}")

            MessageBox.Show(
                $"The profile ""{displayName}"" was created successfully.",
                "Profile Created",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            RaiseEvent ProfileCreated()

        Catch ex As ArgumentException

            ShowInvalidProfileName(
                ex.Message)

        Catch ex As IOException

            MessageBox.Show(
                ex.Message,
                "Profile Not Created",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

        Catch ex As UnauthorizedAccessException

            MessageBox.Show(
                "The profile could not be created because access to the selected folder was denied.",
                "Profile Not Created",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

        Catch ex As Exception

            MessageBox.Show(
                "The profile could not be created." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Profile Not Created",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btnCancel_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCancel.Click

        RaiseEvent CancelRequested()

    End Sub

End Class