Imports System.IO

Public Class SimulatorFilesManager

    Private Shared _simulatorPaths As SimulatorPaths

    Private Const BackupTimestampFormat As String = "yyyyMMdd-HHmmss"
    Private Const SimulatorNotFoundMessage As String = "Microsoft Flight Simulator 2024 was not detected on this computer."

    Public Shared Function BackupSceneryIndexes(sceneryFolder As String,
                                                backupFolder As String) As BackupOperationResult

        Dim result As New BackupOperationResult
        Dim filesCopied = 0

        ' Create timestamp folder.
        Dim backupSessionFolder As String =
        Path.Combine(
            backupFolder,
            DateTime.Now.ToString("yyyyMMdd-HHmmss"))

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

    Public Shared Function BackupExeXml() As BackupOperationResult

        Return BackupSimulatorFile(SimulatorFile.EXExml)

    End Function

    Public Shared Function BackupCamerasCfg() As BackupOperationResult

        Return BackupSimulatorFile(SimulatorFile.CamerasCfg)

    End Function

    Public Shared Function BackupFlightSimulator2024Cfg() As BackupOperationResult

        Return BackupSimulatorFile(SimulatorFile.FlightSimulator2024Cfg)

    End Function

    Private Shared Function BackupSimulatorFile(simFile As SimulatorFile) As BackupOperationResult

        Dim result As New BackupOperationResult()

        Dim sourceFile = GetFilePath(simFile)

        If String.IsNullOrWhiteSpace(sourceFile) Then

            result.Success = False
            result.ErrorMessage = SimulatorNotFoundMessage

            Return result

        End If

        Dim configFolder = Path.GetDirectoryName(sourceFile)

        If Not File.Exists(sourceFile) Then
            Throw New FileNotFoundException(
            $"The {GetFileName(simFile)} file could not be found.",
            sourceFile)
        End If

        Dim backupFile = Path.Combine(
        configFolder,
        GetBackupFileName(simFile))

        File.Copy(sourceFile, backupFile, True)

        result.Success = True
        result.FilesCopied = 1
        result.BackupFile = backupFile

        Return result

    End Function

    Public Shared Function GetSceneryIndexesFolder() As String

        Dim configFolder = GetSimulatorConfigFolder()

        If String.IsNullOrWhiteSpace(configFolder) Then
            Return Nothing
        End If

        Return Path.Combine(configFolder, "SceneryIndexes")

    End Function

    Public Shared Function DeleteSceneryIndexes(sceneryFolder As String) As Integer

        Dim filesDeleted = 0

        If Not Directory.Exists(sceneryFolder) Then
            Throw New DirectoryNotFoundException(sceneryFolder)
        End If

        Dim files = Directory.GetFiles(sceneryFolder)

        For Each sourceFile As String In files

            File.Delete(sourceFile)
            filesDeleted += 1

        Next

        Return filesDeleted

    End Function

    Public Shared Sub ResetSimulatorPaths()

        _simulatorPaths = Nothing

    End Sub

    Private Shared Function GetSimulatorPaths() As SimulatorPaths

        If _simulatorPaths IsNot Nothing Then
            Return _simulatorPaths
        End If

        Dim result = SimulatorDetector.DetectSimulator()
        Dim selectedVersion = My.Settings.MSFSVersion

        Select Case selectedVersion

            Case "Microsoft Store"

                If result.StoreInstalled Then

                    _simulatorPaths = New SimulatorPaths With {
                    .ConfigFolder = result.StoreConfigFolder,
                    .IsStore = True
                }

                End If

            Case "Steam"

                If result.SteamInstalled Then

                    _simulatorPaths = New SimulatorPaths With {
                    .ConfigFolder = result.SteamConfigFolder,
                    .IsSteam = True
                }

                End If

        End Select

        Return _simulatorPaths

    End Function

    Public Shared Function GetSimulatorConfigFolder() As String

        Dim simulatorPaths = GetSimulatorPaths()

        If simulatorPaths Is Nothing Then
            Return Nothing
        End If

        Return simulatorPaths.ConfigFolder

    End Function

    Public Shared Function GetFilePath(simFile As SimulatorFile) As String

        Dim configFolder = GetSimulatorConfigFolder()

        If String.IsNullOrWhiteSpace(configFolder) Then
            Return Nothing
        End If

        Return Path.Combine(configFolder, GetFileName(simFile))

    End Function

    Public Shared Function GetFileName(file As SimulatorFile) As String

        Select Case file
            Case SimulatorFile.RollingCache
                Return "ROLLINGCACHE.CCC"

            Case SimulatorFile.UserCfg
                Return "UserCfg.opt"

            Case SimulatorFile.EXExml
                Return "EXE.xml"

            Case SimulatorFile.CamerasCfg
                Return "Cameras.cfg"

            Case SimulatorFile.FlightSimulator2024Cfg
                Return "FlightSimulator2024.cfg"

            Case Else
                Throw New ArgumentOutOfRangeException(NameOf(file))
        End Select

    End Function

    Public Shared Function FileExists(simFile As SimulatorFile) As Boolean

        Dim filePath = GetFilePath(simFile)

        Return Not String.IsNullOrWhiteSpace(filePath) AndAlso
           File.Exists(filePath)

    End Function

    Private Shared Sub OpenSimulatorFile(simFile As SimulatorFile)

        Dim filePath = GetFilePath(simFile)

        If String.IsNullOrWhiteSpace(filePath) Then
            Throw New DirectoryNotFoundException(SimulatorNotFoundMessage)
        End If

        If Not File.Exists(filePath) Then
            Throw New FileNotFoundException(
            $"The {GetFileName(simFile)} file could not be found.",
            filePath)
        End If

        Process.Start("notepad.exe", filePath)

    End Sub

    Private Shared Function GetBackupFileName(simFile As SimulatorFile) As String

        Select Case simFile

            Case SimulatorFile.EXExml,
             SimulatorFile.CamerasCfg, SimulatorFile.FlightSimulator2024Cfg

                Return $"{GetFileName(simFile)}_MSFSProfileEditor_{DateTime.Now.ToString(BackupTimestampFormat)}.bak"

            Case Else

                Throw New ArgumentOutOfRangeException(
                NameOf(simFile),
                $"No backup filename has been defined for {simFile}.")

        End Select

    End Function

    Public Shared Sub OpenExeXml()

        OpenSimulatorFile(SimulatorFile.EXExml)

    End Sub

    Public Shared Sub OpenUserCfg()

        OpenSimulatorFile(SimulatorFile.UserCfg)

    End Sub

    Public Shared Sub OpenCamerasCfg()

        OpenSimulatorFile(SimulatorFile.CamerasCfg)

    End Sub

    Public Shared Sub OpenFlightSimulator2024Cfg()

        OpenSimulatorFile(SimulatorFile.FlightSimulator2024Cfg)

    End Sub

    Public Shared Function DeleteFile(simFile As SimulatorFile) As Boolean

        Dim fullPath = GetFilePath(simFile)

        If String.IsNullOrWhiteSpace(fullPath) Then
            Return False
        End If

        If Not File.Exists(fullPath) Then
            Return False
        End If

        File.Delete(fullPath)

        Return True

    End Function

    Public Shared Function IsSimulatorConfigFolder(
    folderPath As String
) As Boolean

        If String.IsNullOrWhiteSpace(folderPath) Then
            Return False
        End If

        Dim simulatorConfigFolder = GetSimulatorConfigFolder()

        If String.IsNullOrWhiteSpace(simulatorConfigFolder) Then
            Return False
        End If

        Dim normalizedSelectedFolder =
        Path.GetFullPath(folderPath).
        TrimEnd(
            Path.DirectorySeparatorChar,
            Path.AltDirectorySeparatorChar)

        Dim normalizedConfigFolder =
        Path.GetFullPath(simulatorConfigFolder).
        TrimEnd(
            Path.DirectorySeparatorChar,
            Path.AltDirectorySeparatorChar)

        Return String.Equals(
        normalizedSelectedFolder,
        normalizedConfigFolder,
        StringComparison.OrdinalIgnoreCase)

    End Function

    Public Shared Function FolderContainsUserCfg(
    folderPath As String
) As Boolean

        If String.IsNullOrWhiteSpace(folderPath) Then
            Return False
        End If

        Return File.Exists(
        Path.Combine(folderPath, "UserCfg.opt"))

    End Function

End Class
