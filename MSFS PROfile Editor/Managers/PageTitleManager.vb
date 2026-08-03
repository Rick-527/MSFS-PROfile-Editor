Public NotInheritable Class PageTitleManager

    Private Sub New()
    End Sub

    Public Shared Sub Apply(
        labelTitle As Label,
        labelDescription As Label,
        title As String,
        description As String)

        labelTitle.AutoSize = False
        labelTitle.Dock = DockStyle.Top
        labelTitle.Height = 40
        labelTitle.TextAlign = ContentAlignment.MiddleCenter
        labelTitle.ForeColor = Color.White
        labelTitle.Font = New Font("Segoe UI", 20, FontStyle.Bold)
        labelTitle.Text = title

        labelDescription.AutoSize = False
        labelDescription.Dock = DockStyle.Top
        labelDescription.Height =
            If(description.Contains(Environment.NewLine), 50, 25)
        labelDescription.TextAlign = ContentAlignment.MiddleCenter
        labelDescription.ForeColor = Color.LightGray
        labelDescription.Font = New Font("Segoe UI", 12)
        labelDescription.Text = description

    End Sub

End Class