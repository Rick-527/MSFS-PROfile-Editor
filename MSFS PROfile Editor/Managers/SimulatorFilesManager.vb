Imports System.IO

Public Class SimulatorFilesManager
    Public Shared Function GetPaths() As SimulatorPaths

        Dim result = SimulatorDetector.DetectSimulator()

        If _paths Is Nothing Then

            _paths = New SimulatorPaths()

            If result.SteamInstalled Then

                _paths.ConfigFolder = result.SteamConfigFolder
                _paths.IsSteam = True

            ElseIf result.StoreInstalled Then

                _paths.ConfigFolder = result.StoreConfigFolder
                _paths.IsStore = True

            Else

                Throw New DirectoryNotFoundException(
                "Microsoft Flight Simulator 2024 could not be found.")

            End If

        End If

        Return _paths

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

    Private Shared _paths As SimulatorPaths

    Public Shared Function DeleteFile(simFile As SimulatorFile) As Boolean

        Dim paths = GetPaths()
        'Dim simulatorFileName As String

        If String.IsNullOrWhiteSpace(paths.ConfigFolder) Then
            Throw New InvalidOperationException("The simulator configuration folder has not been determined.")
        End If

        Dim simulatorFileName = GetFileName(simFile)
        Dim fullPath = Path.Combine(paths.ConfigFolder, simulatorFileName)

        'file.Delete(fullPath)

        MessageBox.Show("SimulatorFileName = " & simulatorFileName)

        'Dim fullPath = Path.Combine(paths.ConfigFolder, simulatorFileName)

        MessageBox.Show("Combined = " & fullPath)

        MessageBox.Show(fullPath)

        If File.Exists(fullPath) Then
            File.Delete(fullPath)
            Return True
        End If

        Return False

    End Function

    'Public Shared Sub DeleteAllFiles()

    '    DeleteFile(SimulatorFile.UserCfgOpt.ToString())
    '    DeleteFile(SimulatorFile.RollingCache.ToString())
    '    DeleteFile(SimulatorFile.XmlExe.ToString())

    'End Sub

End Class
