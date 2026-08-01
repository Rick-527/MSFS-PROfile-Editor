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

    Public Function ApplyProfile(profile As ProfileInfo) As Boolean

        'Find UserCfg.opt
        'Backup current UserCfg.opt
        'Copy .profx file
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
            $"Are you sure you want to update the profile for " & fileName & "? This will remove the previous profile.",
            "Confirm Profile Change",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If confirmResult = DialogResult.Yes Then
            Try

                Dim backupResult = MessageBox.Show(
                        $"Would you like to create a backup copy of " & fileName & " before the profile is removed?",
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

                File.Copy(sourceFile, destinationFile, True)

                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Return True

            Catch ex As Exception
                MessageBox.Show($"An error occurred while writing data:  {ex.Message}", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try

        End If

        Return False

    End Function

    Public Function NewProfile(destinationFile As TextBox) As Boolean

        'sets the new profile in the Profiles Directory
        ' save the new Profile in the Profiles Directory
        Dim file1FullPath = If(destinationFile.Tag IsNot Nothing, destinationFile.Tag.ToString(), "")

        If String.IsNullOrWhiteSpace(file1FullPath) Then
            MessageBox.Show("Please select UserCfg.opt first before attempting to save the file to a new destination.", "No Source File Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If Not File.Exists(file1FullPath) Then
            MessageBox.Show("The UserCfg.opt could not be found. It may have been moved or deleted.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Using sfd As New SaveFileDialog
            ' Profile files use the custom .profx extension.
            ' Remove the simulator file extension before creating the profile name.sfd.Title = "Save Profile to New Destination"
            sfd.Filter = "Profile Files (*.profx)|*.profx"
            sfd.DefaultExt = "profx"
            sfd.AddExtension = True
            sfd.FileName = Path.GetFileNameWithoutExtension(file1FullPath)

            If Not String.IsNullOrWhiteSpace(My.Settings.ProfileFolder) Then
                sfd.InitialDirectory = My.Settings.ProfileFolder
            End If

            If sfd.ShowDialog = DialogResult.OK Then
                Try
                    File.Copy(file1FullPath, sfd.FileName, True)

                    My.Settings.ProfileFolder = Path.GetDirectoryName(sfd.FileName)
                    My.Settings.Save()

                    MessageBox.Show("Profile saved successfully to its new destination!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show($"An error occurred while saving the profile: {ex.Message}", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If

            Return True

        End Using

        Return False

    End Function

    Public Function GetProfiles() As List(Of ProfileInfo)

        Dim profiles As New List(Of ProfileInfo)

        If String.IsNullOrWhiteSpace(My.Settings.ProfileFolder) Then
            Return profiles
        End If

        If Not Directory.Exists(My.Settings.ProfileFolder) Then
            Return profiles
        End If

        For Each profileFile In Directory.GetFiles(My.Settings.ProfileFolder, "*.profx")

            Dim profile As New ProfileInfo With {
                .ProfileFile = profileFile
            }

            profiles.Add(profile)

        Next

        Return profiles

    End Function

End Class