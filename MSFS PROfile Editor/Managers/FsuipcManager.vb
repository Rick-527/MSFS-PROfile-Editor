Imports System.IO
Imports Microsoft.Win32

Public Class FsuipcManager

    Private Const UninstallKey As String =
                    "SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall"

    Public Shared Function IsInstalled() As Boolean

        Return Not String.IsNullOrWhiteSpace(GetInstallFolder())

    End Function

    Public Shared Function GetInstallFolder() As String

        Using uninstallRoot = Registry.LocalMachine.OpenSubKey(UninstallKey)

            If uninstallRoot Is Nothing Then Return String.Empty

            For Each subKeyName As String In uninstallRoot.GetSubKeyNames()

                Using subKey = uninstallRoot.OpenSubKey(subKeyName)

                    If subKey Is Nothing Then Continue For

                    Dim displayName =
                    CStr(subKey.GetValue("DisplayName"))

                    If String.IsNullOrWhiteSpace(displayName) Then Continue For

                    If displayName.StartsWith("FSUIPC",
                                          StringComparison.OrdinalIgnoreCase) Then

                        Dim installDir =
                        CStr(subKey.GetValue("InstallDir"))

                        If Directory.Exists(installDir) Then
                            Return installDir
                        End If

                    End If

                End Using

            Next

        End Using

        Return String.Empty

    End Function

    Public Shared Function GetLauncherPath() As String

        Return Directory.Exists(GetInstallFolder())

    End Function

    Public Shared Function Launch() As Boolean

        Return False

    End Function

    '*****************************************
    ' code that goes to future button on FrmMaintenance - just a placeholder in this file for now, will be moved and implemented in future release

    'If FSUIPCManager.IsInstalled() Then

    'FSUIPCManager.Launch()

    'Else

    'LaunchSimulatorNormally()

    'End If
    '*****************************************

End Class
