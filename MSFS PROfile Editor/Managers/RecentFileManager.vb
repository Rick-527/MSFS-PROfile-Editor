Imports System.IO

Public Class RecentFileManager

    Public Class LastFileInfo

        Public Property FileName As String
        Public Property FilePath As String

    End Class

    Public Sub SaveFile1(filePath As String)

            My.Settings.LastFile1Path = filePath
            My.Settings.LastFile1Name = Path.GetFileName(filePath)
            My.Settings.LastDirectory = Path.GetDirectoryName(filePath)
            My.Settings.Save()

        End Sub

    Public Sub SaveFile2(filePath As String)

        My.Settings.LastFile2Path = filePath
        My.Settings.LastFile2Name = Path.GetFileName(filePath)
        My.Settings.Save()

    End Sub

    Public Function LoadLastFile() As LastFileInfo

        If String.IsNullOrWhiteSpace(My.Settings.LastFile1Path) Then
            Return Nothing
        End If

        If Not File.Exists(My.Settings.LastFile1Path) Then
            Clear()
            Return Nothing
        End If

        Return New LastFileInfo With {
            .FileName = My.Settings.LastFile1Name,
            .FilePath = My.Settings.LastFile1Path
        }

    End Function

    Private Sub OpenFileInDefaultApp(filePath As String)

        If String.IsNullOrWhiteSpace(filePath) Then
            MessageBox.Show("Please select a file first before trying to view it.", "No File Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not File.Exists(filePath) Then
            MessageBox.Show("The file could not be found. It may have been moved or deleted.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'open Notepad to view file - else prompt user for viewer if Notepad is not found
        Dim notepadPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows),
    "System32", "notepad.exe")
        If File.Exists(notepadPath) Then
            Process.Start(notepadPath, filePath)
        Else
            Process.Start(New ProcessStartInfo() With {.FileName = filePath, .UseShellExecute = True})
        End If

    End Sub

    Public Sub ViewFile(filetoview As TextBox)

        Dim fullPath = If(filetoview.Tag IsNot Nothing, filetoview.Tag.ToString(), "")
        OpenFileInDefaultApp(fullPath)

    End Sub

    Public Sub Clear()

        My.Settings.LastFile1Path = ""
        My.Settings.LastFile1Name = ""
        My.Settings.Save()

    End Sub

End Class