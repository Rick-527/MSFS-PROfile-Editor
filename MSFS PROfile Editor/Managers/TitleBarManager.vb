Public NotInheritable Class TitleBarManager

    Private Sub New()
    End Sub

    Public Shared Sub ApplyFormInfo(form As Form, text As String)

        Dim version = Application.ProductVersion.Split("+"c)(0)

        If String.IsNullOrWhiteSpace(My.Settings.MSFSVersion) Then
            form.Text = $"MSFS PROfile Editor - v{version} - Simulator: No Simulator Detected"
        Else
            form.Text = $"MSFS PROfile Editor - {text}"
        End If

    End Sub

    Public Shared Sub ApplyVersionInfo(form As Form)

        Dim version = Application.ProductVersion.Split("+"c)(0)

        If String.IsNullOrWhiteSpace(My.Settings.MSFSVersion) Then
            form.Text = $"MSFS PROfile Editor - v{version} - Simulator: No Simulator Detected"
        Else
            form.Text = $"MSFS PROfile Editor - v{version} - Simulator: {My.Settings.MSFSVersion}"
        End If

    End Sub

End Class

