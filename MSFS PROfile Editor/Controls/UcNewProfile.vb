Imports System.IO

Public Class UcNewProfile

    Public Event ProfileCreated()
    Public Event CancelRequested()
    Public Event StatusChanged(message As String)

    Private ReadOnly _profileManager As New ProfileManager()

    Private Sub UcNewProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = Color.Transparent
        Me.DoubleBuffered = True

        txtProfileName.Select()

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

    Private Sub ShowInvalidProfileName(
        message As String
    )

        MessageBox.Show(
            message,
            "Invalid Profile Name",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )

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
                MessageBoxIcon.Information
            )

            txtProfileName.Select()

            Return

        End If

        Dim nameWithoutExtension =
            enteredName

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
                "Please enter a valid profile name."
            )

            Return

        End If

        If nameWithoutExtension.IndexOfAny(
            Path.GetInvalidFileNameChars()) >= 0 Then

            ShowInvalidProfileName(
                "The profile name contains characters that cannot be used in a file name."
            )

            Return

        End If

        If nameWithoutExtension.EndsWith("."c) Then

            ShowInvalidProfileName(
                "The profile name cannot end with a period."
            )

            Return

        End If

        If IsReservedFileName(nameWithoutExtension) Then

            ShowInvalidProfileName(
                "The profile name is reserved by Windows. Please choose another name."
            )

            Return

        End If

        Try

            Dim createdProfile =
                _profileManager.CreateProfile(
                    nameWithoutExtension
                )

            RaiseEvent StatusChanged(
                $"Profile created: {Path.GetFileNameWithoutExtension(createdProfile)}"
            )

            MessageBox.Show(
                $"The profile ""{Path.GetFileNameWithoutExtension(createdProfile)}"" was created successfully.",
                "Profile Created",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            RaiseEvent ProfileCreated()

        Catch ex As ArgumentException

            ShowInvalidProfileName(ex.Message)

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

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        RaiseEvent CancelRequested()

    End Sub

End Class