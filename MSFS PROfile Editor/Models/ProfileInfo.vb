Imports System.IO

Public Class ProfileInfo

    Public Property ProfileFile As String

    Public ReadOnly Property DisplayProfileName As String

        Get
            Return Path.GetFileNameWithoutExtension(ProfileFile)

        End Get
    End Property

End Class