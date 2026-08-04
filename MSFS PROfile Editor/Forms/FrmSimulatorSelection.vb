Public Class FrmSimulatorSelection

    Public Property SelectedVersion As SimulatorVersion
    Public Property RememberChoice As Boolean
    Public Property RememberVersion As Boolean

    Private Sub FrmSimulatorSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BackgroundManager.Apply(Me, "masterBackgroundForm1.png")
        ThemeManager.ApplyModernTheme(Me)
        Me.DoubleBuffered = True

        lblPromptMessage.Text = "Both your editions of Microsoft Flight Simulator are supported." & vbCrLf & "Please select the edition you want to use with this application."
        rbSteam.Checked = True
        cbRememberChoice.Checked = RememberChoice

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        If rbSteam.Checked Then
            SelectedVersion = SimulatorVersion.Steam
        Else
            SelectedVersion = SimulatorVersion.Store
        End If

        RememberChoice = cbRememberChoice.Checked

        Me.DialogResult = DialogResult.OK

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        DialogResult = DialogResult.Cancel

    End Sub

End Class