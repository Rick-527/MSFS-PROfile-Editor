Public Class SetToolTip

    Public Shared Sub SetToolTip(control As Control, toolTipText As String)

        If control Is Nothing Then Throw New ArgumentNullException(NameOf(control))

        Dim _profileToolTip = New ToolTip()

        _profileToolTip.BackColor = Color.FromArgb(255, 235, 140)
        _profileToolTip.ForeColor = Color.Black
        _profileToolTip.InitialDelay = 400
        _profileToolTip.ReshowDelay = 100
        _profileToolTip.AutoPopDelay = 5000
        _profileToolTip.ShowAlways = True

        _profileToolTip.SetToolTip(control, toolTipText)

    End Sub

End Class
