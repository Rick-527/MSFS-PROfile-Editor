Imports System.IO

Public Class BackupManager

    Public Function EnsureBackup(profileFile As String) As Boolean

        If Not File.Exists(profileFile) Then
            Return False
        End If

        Dim backupFile = profileFile & ".bak"

        If File.Exists(backupFile) Then
            File.Delete(backupFile)
        End If

        File.Copy(profileFile, backupFile)

        Return True

    End Function

    Public Function GetBackupFiles(folderPath As String) As List(Of FileInfo)

        Dim backups As New List(Of FileInfo)

        If Directory.Exists(folderPath) Then

            Dim directory As New DirectoryInfo(folderPath)

            backups = directory.GetFiles("*.bak").ToList()

        End If

        Return backups

    End Function

End Class
