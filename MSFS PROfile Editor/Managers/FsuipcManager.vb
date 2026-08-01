Imports System.IO
Imports System.Diagnostics
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

        Dim installFolder = GetInstallFolder()

        If String.IsNullOrWhiteSpace(installFolder) Then

            Return String.Empty

        End If

        Dim launcherPath = Path.Combine(installFolder, "MSFS24.bat")

        If File.Exists(launcherPath) Then

            Return launcherPath

        End If

        Return String.Empty

    End Function

    Public Shared Function Launch() As Boolean

        Dim launcherPath = GetLauncherPath()

        If String.IsNullOrWhiteSpace(launcherPath) Then

            MessageBox.Show(
            "The FSUIPC launcher (MSFS2024.bat) could not be found.",
            "Launch via FSUIPC",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)

            Return False

        End If

        Try

            Process.Start(New ProcessStartInfo(launcherPath) With {
            .UseShellExecute = True
        })

            Return True

        Catch ex As Exception

            MessageBox.Show(
            "Unable to launch FSUIPC." &
            Environment.NewLine &
            Environment.NewLine &
            ex.Message,
            "Launch via FSUIPC",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)

            Return False

        End Try

    End Function

End Class
