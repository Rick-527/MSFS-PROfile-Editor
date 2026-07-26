Imports System.Diagnostics

Public Class SimulatorLauncher

    Public Shared Function Launch() As Boolean

        Dim result = SimulatorDetector.DetectSimulator()
        Dim launched As Boolean = False

        If Not result.SteamInstalled AndAlso Not result.StoreInstalled Then

            MessageBox.Show(
            "Microsoft Flight Simulator 2024 could not be found.",
            "Launch Simulator",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

            Return False

        End If

        If result.SteamInstalled AndAlso Not result.StoreInstalled Then

            launched = LaunchSteam()

        ElseIf result.StoreInstalled AndAlso Not result.SteamInstalled Then

            launched = LaunchStore()

        Else

            launched = LaunchSelectedSimulator()

        End If

        Return launched

    End Function

    Public Shared Sub WaitForSimulator()

        Const MaxSeconds As Integer = 60

        For i As Integer = 1 To MaxSeconds

            Dim running = IsRunning()

            Debug.WriteLine($"Second {i}: Running = {running}")

            If running Then

                Debug.WriteLine("Simulator detected!")

                Threading.Thread.Sleep(5000)

                Exit Sub

            End If

            Threading.Thread.Sleep(1000)

        Next

        Debug.WriteLine("Timed out waiting.")

    End Sub

    Private Shared Function LaunchSelectedSimulator() As Boolean

        Dim response = MessageBox.Show(
        "Both Microsoft Flight Simulator versions were detected." &
        Environment.NewLine &
        Environment.NewLine &
        "Yes = Launch Microsoft Store" &
        Environment.NewLine &
        "No = Launch Steam" &
        Environment.NewLine &
        "Cancel = Cancel",
        "Launch Simulator",
        MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Question)

        Select Case response

            Case DialogResult.Yes
                Return LaunchStore()

            Case DialogResult.No
                Return LaunchSteam()

            Case Else
                Return False

        End Select

    End Function

    Private Shared Function LaunchSteam() As Boolean

        Try

            Dim psi As New ProcessStartInfo()

            psi.FileName = "steam://rungameid/2537590"
            psi.UseShellExecute = True

            Process.Start(psi)

            Return True

        Catch ex As Exception

            MessageBox.Show(
            "Unable to launch Microsoft Flight Simulator (Steam)." &
            Environment.NewLine &
            Environment.NewLine &
            ex.Message,
            "Launch Simulator",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)

            Return False

        End Try

    End Function

    Private Shared Function LaunchStore() As Boolean

        Try

            Dim psi As New ProcessStartInfo()

            psi.FileName = "explorer.exe"
            psi.Arguments = "shell:AppsFolder\Microsoft.Limitless_8wekyb3d8bbwe!App"
            psi.UseShellExecute = True

            Process.Start(psi)

            Return True

        Catch ex As Exception
            MessageBox.Show(
            "Unable to launch Microsoft Flight Simulator (Microsoft Store)." &
            Environment.NewLine &
            Environment.NewLine &
            ex.Message,
            "Launch Simulator",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)
            Return False

        End Try

    End Function

    Public Shared Function IsRunning() As Boolean

        Return Process.GetProcessesByName("FlightSimulator2024").Any()

    End Function

End Class