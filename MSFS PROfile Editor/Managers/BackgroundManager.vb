Imports System.IO

Public Class BackgroundManager

    Public Shared Sub Apply(target As Control, fileName As String)

        Dim bgFile = Path.Combine(
            Application.StartupPath,
            "Resources",
            fileName)

        target.BackgroundImage = Image.FromFile(bgFile)
        target.BackgroundImageLayout = ImageLayout.Stretch

    End Sub

End Class