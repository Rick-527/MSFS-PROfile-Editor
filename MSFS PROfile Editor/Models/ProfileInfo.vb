Imports System.IO

Public Class ProfileInfo

    Public Property ProfileFolder As String
    Public Property ProfileFile As String
    Public Property BackupFolder As String

    Public ReadOnly Property DisplayName As String
        Get
            Return Path.GetFileName(ProfileFolder)
        End Get
    End Property

End Class