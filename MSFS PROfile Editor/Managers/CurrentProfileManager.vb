Public Class CurrentProfileManager

    Public Property CurrentProfilePath As String

    Public Sub New()

        CurrentProfilePath = My.Settings.CurrentProfile

    End Sub


    Public Function SetCurrentProfile(profilePath As String) As Boolean

        If String.IsNullOrWhiteSpace(profilePath) Then
            Return False
        End If

        CurrentProfilePath = profilePath

        My.Settings.CurrentProfile = profilePath
        My.Settings.Save()

        Return True

    End Function


    Public Function IsCurrentProfile(profilePath As String) As Boolean

        Return String.Equals(
            CurrentProfilePath,
            profilePath,
            StringComparison.OrdinalIgnoreCase)

    End Function


    Public Sub ClearCurrentProfile()

        CurrentProfilePath = String.Empty

        My.Settings.CurrentProfile = String.Empty
        My.Settings.Save()

    End Sub

End Class