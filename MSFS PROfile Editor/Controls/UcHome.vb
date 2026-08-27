Public Class UcHome

    Public Event ProfilesRequested()
    Public Event MaintenanceRequested()

    Public Sub SetSimulatorName(simulatorName As String)

        If String.IsNullOrWhiteSpace(simulatorName) Then

            lblSimulatorValue.Text =
                "Not detected"

            lblSimulatorStatus.Text =
                "Simulator could not be detected."

            Return

        End If

        lblSimulatorValue.Text =
            simulatorName

        lblSimulatorStatus.Text =
            "Microsoft Flight Simulator 2024 detected"

    End Sub

    Private Sub btnManageProfiles_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnManageProfiles.Click

        RaiseEvent ProfilesRequested()

    End Sub

    Private Sub btnMaintenance_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnMaintenance.Click

        RaiseEvent MaintenanceRequested()

    End Sub

End Class