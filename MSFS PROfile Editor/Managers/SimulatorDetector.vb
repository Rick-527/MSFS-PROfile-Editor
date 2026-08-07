Imports System.IO

Public Class SimulatorDetector

    Private Sub New()
    End Sub

    Private Const MSFSStorePackageName As String =
        "Microsoft.Limitless_8wekyb3d8bbwe"

    Private Const SteamConfigFolderName As String =
        "Microsoft Flight Simulator 2024"

    Public Shared Function DetectSimulator() As SimulatorDetectionResult

        Dim result As New SimulatorDetectionResult()

        ' Steam
        result.SteamConfigFolder = Path.Combine(
            Environment.GetFolderPath(
                Environment.SpecialFolder.ApplicationData),
            SteamConfigFolderName)

        result.SteamInstalled =
            Directory.Exists(result.SteamConfigFolder) AndAlso
            File.Exists(
                Path.Combine(
                    result.SteamConfigFolder,
                    "UserCfg.opt"))

        ' Microsoft Store
        result.StoreConfigFolder = Path.Combine(
            Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData),
            "Packages",
            MSFSStorePackageName,
            "LocalCache")

        result.StoreInstalled =
            Directory.Exists(result.StoreConfigFolder) AndAlso
            File.Exists(
                Path.Combine(
                    result.StoreConfigFolder,
                    "UserCfg.opt"))

        Return result

    End Function

End Class