Imports System.IO

Public Class MenuActionsManager

    Public Shared Sub ShowModal(owner As Form, child As Form)

        Using child
            child.ShowDialog(owner)
        End Using

    End Sub

End Class
