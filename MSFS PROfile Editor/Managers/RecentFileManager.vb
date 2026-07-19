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
        My.Settings.LastDirectory2 = Path.GetDirectoryName(filePath)
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

    Public Sub Save(filePath As String)

        My.Settings.LastFile1Path = filePath
        My.Settings.LastFile1Name = Path.GetFileName(filePath)
        My.Settings.Save()

    End Sub

    Public Sub Clear()

        My.Settings.LastFile1Path = ""
        My.Settings.LastFile1Name = ""
        My.Settings.Save()

    End Sub

End Class