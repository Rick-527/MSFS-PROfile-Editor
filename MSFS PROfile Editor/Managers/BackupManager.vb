Imports System.IO

Public Class BackupManager

    Public Function GetBackupFiles(folderPath As String) As List(Of FileInfo)

        Dim backups As New List(Of FileInfo)

        If Directory.Exists(folderPath) Then

            Dim directory As New DirectoryInfo(folderPath)

            backups = directory.GetFiles("*.bak").ToList()

        End If

        Return backups

    End Function

End Class
