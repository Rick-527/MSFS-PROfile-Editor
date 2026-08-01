Imports System.Diagnostics
Imports MSFS_PROfile_Editor.SimulatorLaunchMode

Public Class SimulatorLauncher

    Public Shared Async Function LaunchAsync(
            mode As LaunchMode) As Task(Of Boolean)

        Dim result = SimulatorDetector.DetectSimulator()

        If Not result.SteamInstalled AndAlso Not result.StoreInstalled Then

            MessageBox.Show(
            "Microsoft Flight Simulator 2024 could not be found.",
            "Launch Simulator",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

            Return False

        End If

        Select Case mode

            Case LaunchMode.Normal

                If Not LaunchNormally(result) Then
                    Return False
                End If

            Case LaunchMode.FSUIPC

                If Not LaunchViaFsuipc() Then
                    Return False
                End If

            Case Else

                Throw New NotSupportedException($"Launch mode '{mode}' is not supported.")

        End Select

        Return Await WaitForSimulatorAsync()

    End Function

    Private Shared Function LaunchNormally(
    result As SimulatorDetectionResult) As Boolean

        Try

            If result.SteamInstalled Then

                Process.Start(New ProcessStartInfo(
                "steam://rungameid/2537590") With {
                .UseShellExecute = True
            })

            Else

                Process.Start(New ProcessStartInfo(
                "shell:AppsFolder\Microsoft.Limitless_8wekyb3d8bbwe!App") With {
                .UseShellExecute = True
            })

            End If

            Return True

        Catch ex As Exception

            MessageBox.Show(
            "Unable to launch Microsoft Flight Simulator." &
            Environment.NewLine &
            Environment.NewLine &
            ex.Message,
            "Launch Simulator",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)

            Return False

        End Try

    End Function

    Private Shared Function LaunchViaFsuipc() As Boolean

        Return FsuipcManager.Launch()

    End Function

    Public Shared Async Function WaitForSimulatorAsync() As Task(Of Boolean)

        Const MaxSeconds As Integer = 60

        For i As Integer = 1 To MaxSeconds

            Dim running = IsRunning()

            If running Then

                Await Task.Delay(5000)

                Return True

            End If

            Await Task.Delay(1000)

        Next

        Return False

    End Function

    Public Shared Function IsRunning() As Boolean

        Return Process.GetProcessesByName("FlightSimulator2024").Any()

    End Function


End Class