Imports System.IO

Public NotInheritable Class SimulatorDetector

    Private Const MSFSStorePackageName As String =
    "Microsoft.Limitless_8wekyb3d8bbwe"

    Private Const SteamConfigFolderName As String =
    "Microsoft Flight Simulator 2024"


    Public Shared Function DetectSimulator() As SimulatorDetectionResult

        Dim result As New SimulatorDetectionResult()

        ' Steam
        result.SteamConfigFolder = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        SteamConfigFolderName)

        result.SteamInstalled = Directory.Exists(result.SteamConfigFolder)

        ' Microsoft Store
        result.StoreConfigFolder = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        "Packages",
        MSFSStorePackageName,
        "LocalCache")

        result.StoreInstalled = Directory.Exists(result.StoreConfigFolder)

        Return result

    End Function

End Class