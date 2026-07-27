Imports System.IO
Imports System.IO.Compression

Public Class SimulatorFilesManager

    Private Shared _simulatorPaths As SimulatorPaths

    Private Const BackupTimestampFormat As String = "yyyyMMdd-HHmmss"

    Public Shared Function BackupSceneryIndexes(sceneryFolder As String,
                                                backupFolder As String) As BackupOperationResult

        Dim result As New BackupOperationResult
        Dim filesCopied = 0

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

    Public Shared Function GetSceneryIndexesFolder() As String

        Dim configFolder = GetConfigFolder()

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

    Private Shared Function GetPaths() As SimulatorPaths

        If _simulatorPaths Is Nothing Then

            Dim result = SimulatorDetector.DetectSimulator()

            _simulatorPaths = New SimulatorPaths()

            If result.SteamInstalled Then

                _simulatorPaths.ConfigFolder = result.SteamConfigFolder
                _simulatorPaths.IsSteam = True

            ElseIf result.StoreInstalled Then

                _simulatorPaths.ConfigFolder = result.StoreConfigFolder
                _simulatorPaths.IsStore = True

            Else

                Return Nothing

            End If

        End If

        Return _simulatorPaths

    End Function

    Public Shared Function GetConfigFolder() As String

        Dim paths = GetPaths()

        If paths Is Nothing Then
            Return Nothing
        End If

        Return paths.ConfigFolder

    End Function

    Public Shared ReadOnly Property GetConfigFolderPath As String
        Get
            Return GetConfigFolder()
        End Get

    End Property

    Public Shared Function GetFilePath(simFile As SimulatorFile) As String

        Dim configFolder = GetConfigFolder()

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

            Case Else
                Throw New ArgumentOutOfRangeException(NameOf(file))
        End Select

    End Function

    Public Shared Function FileExists(simFile As SimulatorFile) As Boolean

        Dim folder = GetConfigFolder()

        If String.IsNullOrWhiteSpace(folder) Then
            Return False
        End If

        Return File.Exists(Path.Combine(folder, GetFileName(simFile)))

    End Function

    Public Shared Sub OpenExeXml()

        Dim filePath = GetFilePath(SimulatorFile.EXExml)

        If Not File.Exists(filePath) Then
            Throw New FileNotFoundException(
            "The EXE.xml file could not be found.", filePath)
        End If

        Process.Start("notepad.exe", filePath)

    End Sub

    Public Shared Function BackupExeXml() As BackupOperationResult

        Dim result As New BackupOperationResult()

        Dim sourceFile = GetFilePath(SimulatorFile.EXExml)

        If String.IsNullOrWhiteSpace(sourceFile) Then

            result.Success = False
            result.ErrorMessage = "Microsoft Flight Simulator 2024 was not detected on this computer."

            Return result

        End If

        Dim backupFile = Path.Combine(
        GetConfigFolder(),
        GetBackupFileName(SimulatorFile.EXExml))

        File.Copy(sourceFile, backupFile, True)

        result.Success = True
        result.FilesCopied = 1
        result.BackupFile = backupFile

        Return result

    End Function

    Private Shared Function GetBackupFileName(simFile As SimulatorFile) As String

        Select Case simFile

            Case SimulatorFile.EXExml

                Return $"{GetFileName(simFile)}_MSFSProfileEditor_{DateTime.Now.ToString(BackupTimestampFormat)}.bak"

            Case SimulatorFile.CamerasCfg

                Return $"{GetFileName(simFile)}_MSFSProfileEditor_{DateTime.Now.ToString(BackupTimestampFormat)}.bak"

            Case Else

                Throw New ArgumentOutOfRangeException(
                NameOf(simFile),
                $"No backup filename has been defined for {simFile}.")

        End Select

    End Function

    Public Shared Sub OpenCamerasCfg()

        Dim filePath = GetFilePath(SimulatorFile.CamerasCfg)

        If Not File.Exists(filePath) Then
            Throw New FileNotFoundException(
            "The Cameras.cfg file could not be found.", filePath)
        End If

        Process.Start("notepad.exe", filePath)

    End Sub

    Public Shared Function BackupCamerasCfg() As BackupOperationResult

        Dim result As New BackupOperationResult()

        Dim sourceFile = GetFilePath(SimulatorFile.CamerasCfg)

        If String.IsNullOrWhiteSpace(sourceFile) Then

            result.Success = False
            result.ErrorMessage = "Microsoft Flight Simulator 2024 was not detected on this computer."

            Return result

        End If

        If Not File.Exists(sourceFile) Then
            Throw New FileNotFoundException(
            "The CamerasCfg file could not be found.", sourceFile)
        End If

        Dim backupFile = Path.Combine(
        GetConfigFolder(),
        GetBackupFileName(SimulatorFile.CamerasCfg))

        File.Copy(sourceFile, backupFile, True)

        result.Success = True
        result.FilesCopied = 1
        result.BackupFile = backupFile

        Return result

    End Function

    Public Shared Function DeleteFile(simFile As SimulatorFile) As Boolean

        Dim fullPath = GetFilePath(simFile)

        If File.Exists(fullPath) Then
            File.Delete(fullPath)
            Return True
        End If

        Return False

    End Function

End Class
