Imports System.IO

Public Class ProfileManager

    Public ReadOnly Property CurrentProfileFolder As String
        Get
            Return My.Settings.ProfileFolder
        End Get
    End Property

    Public Function SetCurrentProfileFolder(folder As String) As Boolean

        If Not IO.Directory.Exists(folder) Then
            Return False
        End If

        My.Settings.ProfileFolder = folder
        My.Settings.Save()

        Return True

    End Function

    Private Function BackupName(path As String) As String
        Return $"{path}.bak"
    End Function
    Public Function ReplaceProfile(destinationFile As String,
                               sourceFile As String) As Boolean

        Dim file1FullPath = destinationFile
        Dim file2FullPath = sourceFile
        Dim fileName = Path.GetFileName(destinationFile)


        If String.IsNullOrWhiteSpace(file1FullPath) OrElse String.IsNullOrWhiteSpace(file2FullPath) Then
            MessageBox.Show("Please select both files before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If file1FullPath.ToLower = file2FullPath.ToLower Then
            MessageBox.Show("You cannot overwrite a file with itself. Please select two different files.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If Not File.Exists(file1FullPath) OrElse Not File.Exists(file2FullPath) Then
            MessageBox.Show(file1FullPath & " " & file2FullPath & " One or both selected files could not be found. Please check the paths.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Dim confirmResult = MessageBox.Show(
            $"Are you sure you want to overwrite " & fileName & "? This will permanently delete its original contents.",
            "Confirm Overwrite",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If confirmResult = DialogResult.Yes Then
            Try

                Dim backupResult = MessageBox.Show(
                        $"Would you like to create a backup copy of " & fileName & " before it is overwritten?",
                        "Create Backup?",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Question
                    )

                If backupResult = DialogResult.Cancel Then
                    Return False
                End If

                If backupResult = DialogResult.Yes Then
                    Dim backupPath = BackupName(destinationFile)
                    File.Copy(destinationFile, backupPath, True)
                End If

                MessageBox.Show("File updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Return True

            Catch ex As Exception
                MessageBox.Show($"An error occurred while writing data:  {ex.Message}", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try

        End If

        Return False


    End Function

End Class