Public Class ProfileMigrationResult

    Public Property ConvertedCount As Integer

    Public Property SkippedCount As Integer

    Public Property FailedCount As Integer

    Public Property ErrorMessages As New List(Of String)

    Public ReadOnly Property Success As Boolean

        Get

            Return FailedCount = 0

        End Get

    End Property

End Class