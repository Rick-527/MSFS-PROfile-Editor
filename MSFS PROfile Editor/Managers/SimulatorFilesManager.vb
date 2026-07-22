Imports System.IO

Public Class SimulatorFilesManager

    Private Shared _simulatorPaths As SimulatorPaths

    Public Shared Function GetPaths() As SimulatorPaths

        Dim result = SimulatorDetector.DetectSimulator()

        If _simulatorPaths Is Nothing Then

            _simulatorPaths = New SimulatorPaths()

            If result.SteamInstalled Then

                _simulatorPaths.ConfigFolder = result.SteamConfigFolder
                _simulatorPaths.IsSteam = True

            ElseIf result.StoreInstalled Then

                _simulatorPaths.ConfigFolder = result.StoreConfigFolder
                _simulatorPaths.IsStore = True

            Else

                Throw New DirectoryNotFoundException(
                "Microsoft Flight Simulator 2024 could not be found.")

            End If

        End If

        Return _simulatorPaths

    End Function

    Public Shared Function GetFileName(file As SimulatorFile) As String

        Select Case file
            Case SimulatorFile.RollingCache
                Return "ROLLINGCACHE.CCC"

            Case SimulatorFile.UserCfg
                Return "UserCfg.opt"

            Case Else
                Throw New ArgumentOutOfRangeException(NameOf(file))
        End Select

    End Function

    Private Shared Function GetFilePath(simFile As SimulatorFile) As String

        Dim paths = GetPaths()

        If String.IsNullOrWhiteSpace(paths.ConfigFolder) Then
            Throw New InvalidOperationException(
            "The simulator configuration folder has not been determined.")
        End If

        Return Path.Combine(paths.ConfigFolder, GetFileName(simFile))

    End Function

    Public Shared Function DeleteFile(simFile As SimulatorFile) As Boolean

        Dim fullPath = GetFilePath(simFile)

        If File.Exists(fullPath) Then
            File.Delete(fullPath)
            Return True
        End If

        Return False

    End Function

    Public Shared Function BackupSceneryIndexes(sceneryFolder As String,
                                                backupFolder As String) As BackupOperationResult

        Dim result As New BackupOperationResult
        Dim filesCopied As Integer = 0

        ' Create timestamp folder.
        Dim backupSessionFolder As String =
        Path.Combine(
            backupFolder,
            DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss"))

        Directory.CreateDirectory(backupSessionFolder)

        For Each sourceFile As String In Directory.GetFiles(sceneryFolder)

            Dim destinationFile As String =
            Path.Combine(
                backupSessionFolder,
                Path.GetFileName(sourceFile) & ".bak")

            Dim fileBytes() As Byte = File.ReadAllBytes(sourceFile)
            File.WriteAllBytes(destinationFile, fileBytes)

            filesCopied += 1

        Next

        result.Success = True
        result.FilesCopied = filesCopied
        result.BackupFolder = backupSessionFolder

        Return result

    End Function

    'Public Shared Function BackupSceneryIndexes(sceneryFolder As Integer,
    '                                 backupFolder As String) As BackupOperationResult 'Integer

    '    Dim filesCopied As Integer = 0

    '    Dim result As New BackupOperationResult

    '    ' Create one timestamped backup folder for this operation.
    '    Dim backupSessionFolder As String =
    '        Path.Combine(
    '        backupFolder,
    '        DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss"))

    '    Directory.CreateDirectory(backupSessionFolder)

    '    result.Success = True
    '    result.FilesCopied = filesCopied
    '    result.BackupFolder = backupSessionFolder

    '    For Each sourceFile As String In Directory.GetFiles(sceneryFolder)

    '        Dim destinationFile As String =
    '                Path.Combine(
    '                backupSessionFolder,
    '                Path.GetFileName(sourceFile) & ".bak")

    '        Dim fileBytes() As Byte = File.ReadAllBytes(sourceFile)
    '        File.WriteAllBytes(destinationFile, fileBytes)

    '        filesCopied += 1

    '    Next

    '    Return result

    '    'Return filesCopied

    'End Function

    Public Shared Function GetSceneryIndexesFolder() As String

        Dim paths = GetPaths()

        If String.IsNullOrWhiteSpace(paths.ConfigFolder) Then
            Throw New InvalidOperationException(
            "The simulator configuration folder has not been determined.")
        End If

        Dim sceneryFolder = Path.Combine(paths.ConfigFolder, "SceneryIndexes")

        If Directory.Exists(sceneryFolder) Then

            Return sceneryFolder

        End If

        Return String.Empty

    End Function

    Public Shared Function DeleteSceneryIndexes() As String

        'For Each file In Directory.GetFiles(sceneryFolder)
        '    file.Delete(file)
        'Next

        Return ""

    End Function


    'Public Shared Sub DeleteAllFiles()

    '    DeleteFile(SimulatorFile.UserCfgOpt.ToString())
    '    DeleteFile(SimulatorFile.RollingCache.ToString())
    '    DeleteFile(SimulatorFile.XmlExe.ToString())

    'End Sub

End Class
