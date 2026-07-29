Imports System.IO

Public Class BackgroundManager

    Public Shared Sub Apply(frm As Form, fileName As String)

        Dim bgFile = Path.Combine(
            Application.StartupPath,
            "Resources",
            fileName)

        frm.BackgroundImage = Image.FromFile(bgFile)
        frm.BackgroundImageLayout = ImageLayout.Stretch

    End Sub

End Class