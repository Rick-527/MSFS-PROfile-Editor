Imports System.IO
Imports System.Windows.Forms

Public NotInheritable Class UiActionRunner

    Private Sub New()
    End Sub

    Public Shared Sub Run(
    owner As Form,
    statusLabel As ToolStripStatusLabel,
    action As Action)

        Run(owner,
            statusLabel,
            "Please wait...",
            action)

    End Sub

    Public Shared Sub Run(owner As Form,
                          statusLabel As ToolStripStatusLabel,
                          statusMessage As String,
                          action As Action)

        If owner Is Nothing Then Throw New ArgumentNullException(NameOf(owner))
        If statusLabel Is Nothing Then Throw New ArgumentNullException(NameOf(statusLabel))
        If action Is Nothing Then Throw New ArgumentNullException(NameOf(action))

        Dim previousCursor = owner.Cursor
        Dim previousStatus = statusLabel.Text

        Try

            owner.Cursor = Cursors.WaitCursor
            statusLabel.Text = statusMessage

            owner.Refresh()
            Application.DoEvents()

            action.Invoke()

        Catch ex As FileNotFoundException

            MessageBox.Show(owner,
                            ex.Message,
                            "File Not Found",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

        Catch ex As DirectoryNotFoundException

            MessageBox.Show(owner,
                            ex.Message,
                            "Folder Not Found",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

        Catch ex As UnauthorizedAccessException

            MessageBox.Show(owner,
                            ex.Message,
                            "Access Denied",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        Catch ex As Exception

            MessageBox.Show(owner,
                            ex.Message,
                            "MSFS PROfile Editor",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        Finally

            owner.Cursor = previousCursor
            statusLabel.Text = previousStatus

        End Try

    End Sub

    Public Shared Function RunWithResult(Of T)(
    owner As Form,
    statusLabel As ToolStripStatusLabel,
    statusMessage As String,
    action As Func(Of T)) As T

        If owner Is Nothing Then Throw New ArgumentNullException(NameOf(owner))
        If statusLabel Is Nothing Then Throw New ArgumentNullException(NameOf(statusLabel))
        If action Is Nothing Then Throw New ArgumentNullException(NameOf(action))

        Dim previousCursor = owner.Cursor
        Dim previousStatus = statusLabel.Text

        Try

            owner.Cursor = Cursors.WaitCursor
            statusLabel.Text = statusMessage

            owner.Refresh()
            Application.DoEvents()

            Return action.Invoke()

        Catch ex As FileNotFoundException

            MessageBox.Show(owner,
                        ex.Message,
                        "File Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)

        Catch ex As DirectoryNotFoundException

            MessageBox.Show(owner,
                        ex.Message,
                        "Folder Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)

        Catch ex As UnauthorizedAccessException

            MessageBox.Show(owner,
                        ex.Message,
                        "Access Denied",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)

        Catch ex As Exception

            MessageBox.Show(owner,
                        ex.Message,
                        "MSFS PROfile Editor",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)

        Finally

            owner.Cursor = previousCursor
            statusLabel.Text = previousStatus

        End Try

        Return Nothing

    End Function

End Class