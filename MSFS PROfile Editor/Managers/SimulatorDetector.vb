Imports System.IO

Public Class SimulatorDetector

    Private Sub New()
    End Sub

    ' MSFS 2024 paths based on the official Microsoft Flight Simulator
    ' SDK PackageInstaller\DetectMSFS sample.
    '
    ' Steam:
    '   %AppData%\Microsoft Flight Simulator 2024\UserCfg.opt
    '
    ' Microsoft Store / Xbox App:
    '   %LocalAppData%\Packages\
    '   Microsoft.Limitless_8wekyb3d8bbwe\
    '   LocalCache\UserCfg.opt

    Private Const MSFSStorePackageName As String =
        "Microsoft.Limitless_8wekyb3d8bbwe"

    Private Const SteamConfigFolderName As String =
        "Microsoft Flight Simulator 2024"

    Private Const UserCfgFileName As String =
        "UserCfg.opt"

    Private Const InstalledPackagesKey As String =
        "InstalledPackagesPath"

    Public Shared Function DetectSimulator() As SimulatorDetectionResult

        Dim result As New SimulatorDetectionResult()

        ' Steam
        result.SteamConfigFolder =
            GetSteamConfigFolder()

        result.SteamInstalled =
            File.Exists(
                GetSteamUserCfgPath())

        ' Microsoft Store / Xbox App
        result.StoreConfigFolder =
            GetStoreConfigFolder()

        result.StoreInstalled =
            File.Exists(
                GetStoreUserCfgPath())

        Return result

    End Function

    Public Shared Function GetSteamConfigFolder() As String

        Return Path.Combine(
            Environment.GetFolderPath(
                Environment.SpecialFolder.ApplicationData),
            SteamConfigFolderName)

    End Function

    Public Shared Function GetStoreConfigFolder() As String

        Return Path.Combine(
            Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData),
            "Packages",
            MSFSStorePackageName,
            "LocalCache")

    End Function

    Public Shared Function GetSteamUserCfgPath() As String

        Return Path.Combine(
            GetSteamConfigFolder(),
            UserCfgFileName)

    End Function

    Public Shared Function GetStoreUserCfgPath() As String

        Return Path.Combine(
            GetStoreConfigFolder(),
            UserCfgFileName)

    End Function

    Public Shared Function GetInstalledPackagesPath(
        userCfgPath As String
    ) As String

        If String.IsNullOrWhiteSpace(userCfgPath) Then
            Return String.Empty
        End If

        If Not File.Exists(userCfgPath) Then
            Return String.Empty
        End If

        Try

            For Each line As String In File.ReadLines(userCfgPath)

                Dim trimmedLine =
                    line.Trim()

                If Not trimmedLine.StartsWith(
                    InstalledPackagesKey,
                    StringComparison.OrdinalIgnoreCase) Then

                    Continue For

                End If

                Dim value =
                    trimmedLine.Substring(
                        InstalledPackagesKey.Length).Trim()

                value =
                    value.Trim(""""c)

                If Directory.Exists(value) Then
                    Return value
                End If

                Return String.Empty

            Next

        Catch ex As IOException

            Return String.Empty

        Catch ex As UnauthorizedAccessException

            Return String.Empty

        End Try

        Return String.Empty

    End Function

    Public Shared Function GetCommunityFolder(
        userCfgPath As String
    ) As String

        Dim packagesPath =
            GetInstalledPackagesPath(userCfgPath)

        If String.IsNullOrWhiteSpace(packagesPath) Then
            Return String.Empty
        End If

        Return Path.Combine(
            packagesPath,
            "Community")

    End Function

End Class