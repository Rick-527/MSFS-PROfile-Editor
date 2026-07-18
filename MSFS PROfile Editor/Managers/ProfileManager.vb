Public Class ProfileManager

    Public ReadOnly Property CurrentProfileFolder As String
        Get
            Return My.Settings.ProfileFolder
        End Get
    End Property

    Public Function SetCurrentProfileFolder(folder As String) As Boolean

        If Not IO.Directory.Exists(folder) Then
            Return False
        End If

        My.Settings.ProfileFolder = folder
        My.Settings.Save()

        Return True

    End Function

End Class