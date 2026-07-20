Public Class SimulatorDetectionResult

    Public Property SteamInstalled As Boolean
    Public Property StoreInstalled As Boolean

    Public Property SteamConfigFolder As String = String.Empty
    Public Property StoreConfigFolder As String = String.Empty

    Public ReadOnly Property InstalledCount As Integer
        Get
            Dim count As Integer = 0

            If SteamInstalled Then count += 1
            If StoreInstalled Then count += 1

            Return count
        End Get
    End Property

End Class