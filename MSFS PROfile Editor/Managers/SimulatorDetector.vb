Imports System.IO

Public Class SimulatorDetector

    Private Const MSFSStorePackageName As String =
    "Microsoft.Limitless_8wekyb3d8bbwe"

    Public Function DetectSimulator() As SimulatorDetectionResult

        Dim result As New SimulatorDetectionResult()

        ' Steam
        result.SteamUserCfgPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "Microsoft Flight Simulator 2024",
            "UserCfg.opt")

        result.SteamInstalled = File.Exists(result.SteamUserCfgPath)

        ' Microsoft Store
        result.StoreUserCfgPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "Packages",
            MSFSStorePackageName,
            "LocalCache",
            "UserCfg.opt")

        result.StoreInstalled = File.Exists(result.StoreUserCfgPath)

        Return result

    End Function

End Class