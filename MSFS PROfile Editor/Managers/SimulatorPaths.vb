Public Class SimulatorPaths

    Public Property ConfigFolder As String
    Public Property LocalCacheFolder As String
    Public Property CommunityFolder As String
    Public Property IsSteam As Boolean
    Public Property IsStore As Boolean

    Private Shared _paths As SimulatorPaths

    Public Shared Function GetPaths() As SimulatorPaths

        If _paths Is Nothing Then

            _paths = New SimulatorPaths()

            ' Detect Steam or Store
            ' Populate the properties

        End If

        Return _paths

    End Function

End Class
