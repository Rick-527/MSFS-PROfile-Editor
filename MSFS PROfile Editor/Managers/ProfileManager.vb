Imports System.IO

Public Class ProfileManager

    Private Const ProfileBackupMarker As String = ".PROfileBackup_"
    Private _lastErrorMessage As String

    Public ReadOnly Property CurrentProfileFolder As String
        Get
            Return My.Settings.ProfileFolder
        End Get
    End Property

    Public ReadOnly Property LastErrorMessage As String
        Get
            Return _lastErrorMessage
        End Get
    End Property

    Public Function SetCurrentProfileFolder(folder As String) As Boolean

        If Not Directory.Exists(folder) Then
            Return False
        End If

        My.Settings.ProfileFolder = folder
        My.Settings.Save()

        Return True

    End Function

    Public Function MigrateLegacyProfiles() As ProfileMigrationResult

        Dim result As New ProfileMigrationResult()
        Dim profileFolder = My.Settings.ProfileFolder

        If String.IsNullOrWhiteSpace(profileFolder) Then
            result.FailedCount = 1
            result.ErrorMessages.Add("The profile folder has not been configured.")
            Return result
        End If

        If Not Directory.Exists(profileFolder) Then
            result.FailedCount = 1
            result.ErrorMessages.Add(
                $"The profile folder could not be found:{Environment.NewLine}{profileFolder}")
            Return result
        End If

        Dim legacyProfiles =
            Directory.GetFiles(
            profileFolder,
            "*.opt",
            SearchOption.TopDirectoryOnly).
            Where(
                 Function(filePath)
                     Return Not String.Equals(
                            Path.GetFileName(filePath),
                            "UserCfg.opt",
                            StringComparison.OrdinalIgnoreCase)
                 End Function
            )

        For Each legacyProfile In legacyProfiles

            Try
                Dim newProfilePath =
                    Path.ChangeExtension(legacyProfile, ".profx")

                If File.Exists(newProfilePath) Then
                    result.SkippedCount += 1
                    Continue For
                End If

                File.Copy(
                    sourceFileName:=legacyProfile,
                    destFileName:=newProfilePath,
                    overwrite:=False)

                result.ConvertedCount += 1

            Catch ex As Exception

                result.FailedCount += 1

                result.ErrorMessages.Add(
                    $"{Path.GetFileName(legacyProfile)}: {ex.Message}")

            End Try

        Next

        Return result

    End Function

    Public Function GetProfiles() As List(Of ProfileInfo)

        Dim profiles As New List(Of ProfileInfo)

        If String.IsNullOrWhiteSpace(CurrentProfileFolder) Then
            Return profiles
        End If

        If Not Directory.Exists(CurrentProfileFolder) Then
            Return profiles
        End If

        For Each profileFile In
            Directory.GetFiles(CurrentProfileFolder, "*.profx")

            profiles.Add(
                New ProfileInfo With {
                    .ProfileFile = profileFile
                })

        Next

        Return profiles

    End Function

    Public Function ApplyProfile(profile As ProfileInfo) As Boolean

        _lastErrorMessage = String.Empty

        If profile Is Nothing Then
            _lastErrorMessage = "No profile was selected."
            Return False
        End If

        If String.IsNullOrWhiteSpace(profile.ProfileFile) Then
            _lastErrorMessage =
                "The selected profile does not have a valid file path."

            Return False
        End If

        If Not File.Exists(profile.ProfileFile) Then
            _lastErrorMessage =
                $"The selected profile could not be found:{Environment.NewLine}" &
                profile.ProfileFile

            Return False
        End If

        Dim userCfgPath =
            SimulatorFilesManager.GetFilePath(SimulatorFile.UserCfg)

        If String.IsNullOrWhiteSpace(userCfgPath) Then
            _lastErrorMessage =
                "The simulator UserCfg.opt location could not be determined."

            Return False
        End If

        If Not File.Exists(userCfgPath) Then
            _lastErrorMessage =
                $"UserCfg.opt could not be found:{Environment.NewLine}" &
                userCfgPath

            Return False
        End If

        If AreSameFile(profile.ProfileFile, userCfgPath) Then
            _lastErrorMessage =
                "The selected profile is already the active UserCfg.opt file."

            Return False
        End If

        Try

            DeletePreviousProfileBackups(userCfgPath)
            CreateUserCfgBackup(userCfgPath)

            File.Copy(
                profile.ProfileFile,
                userCfgPath,
                overwrite:=True)

            Return True

        Catch ex As Exception

            _lastErrorMessage =
                $"The profile could not be applied.{Environment.NewLine}" &
                $"{Environment.NewLine}{ex.Message}"

            Return False

        End Try

    End Function

    Private Function AreSameFile(firstPath As String,
                                 secondPath As String) As Boolean

        Dim firstFullPath = Path.GetFullPath(firstPath)
        Dim secondFullPath = Path.GetFullPath(secondPath)

        Return String.Equals(
            firstFullPath,
            secondFullPath,
            StringComparison.OrdinalIgnoreCase)

    End Function

    Private Function IsSimulatorConfigFolder(selectedFolder As String) As Boolean

        Dim simulatorConfigFolder =
        SimulatorFilesManager.GetSimulatorConfigFolder()

        If String.IsNullOrWhiteSpace(simulatorConfigFolder) Then
            Return False
        End If

        Dim normalizedSelectedFolder =
        Path.GetFullPath(selectedFolder).
        TrimEnd(Path.DirectorySeparatorChar)

        Dim normalizedConfigFolder =
        Path.GetFullPath(simulatorConfigFolder).
        TrimEnd(Path.DirectorySeparatorChar)

        Return String.Equals(
        normalizedSelectedFolder,
        normalizedConfigFolder,
        StringComparison.OrdinalIgnoreCase)

    End Function

    Private Sub DeletePreviousProfileBackups(userCfgPath As String)

        Dim configFolder = Path.GetDirectoryName(userCfgPath)

        If String.IsNullOrWhiteSpace(configFolder) Then
            Throw New DirectoryNotFoundException(
                "The UserCfg.opt folder could not be determined.")
        End If

        Dim userCfgFileName = Path.GetFileName(userCfgPath)

        Dim searchPattern =
            $"{userCfgFileName}{ProfileBackupMarker}*.bak"

        For Each backupFile In Directory.GetFiles(configFolder, searchPattern)
            File.Delete(backupFile)
        Next

    End Sub

    Private Function CreateUserCfgBackup(userCfgPath As String) As String

        Dim timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss")

        Dim backupPath =
            $"{userCfgPath}{ProfileBackupMarker}{timestamp}.bak"

        File.Copy(
            userCfgPath,
            backupPath,
            overwrite:=False)

        Return backupPath

    End Function

    Public Function NewProfile(destinationFile As TextBox) As Boolean

        Dim sourceFile =
            If(destinationFile.Tag IsNot Nothing,
               destinationFile.Tag.ToString(),
               String.Empty)

        If String.IsNullOrWhiteSpace(sourceFile) Then

            MessageBox.Show(
                "Please select UserCfg.opt first before attempting to save the file to a new destination.",
                "No Source File Selected",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            Return False

        End If

        If Not File.Exists(sourceFile) Then

            MessageBox.Show(
                "The UserCfg.opt could not be found. It may have been moved or deleted.",
                "File Not Found",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            Return False

        End If

        Using sfd As New SaveFileDialog

            sfd.Title = "Save Profile to New Destination"
            sfd.Filter = "Profile Files (*.profx)|*.profx"
            sfd.DefaultExt = "profx"
            sfd.AddExtension = True
            sfd.FileName = Path.GetFileNameWithoutExtension(sourceFile)

            If Not String.IsNullOrWhiteSpace(My.Settings.ProfileFolder) Then
                sfd.InitialDirectory = My.Settings.ProfileFolder
            End If

            If sfd.ShowDialog() <> DialogResult.OK Then
                Return False
            End If

            Try

                File.Copy(
                    sourceFile,
                    sfd.FileName,
                    overwrite:=True)

                My.Settings.ProfileFolder =
                    Path.GetDirectoryName(sfd.FileName)

                My.Settings.Save()

                MessageBox.Show(
                    "Profile saved successfully to its new destination!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)

                Return True

            Catch ex As Exception

                MessageBox.Show(
                    $"An error occurred while saving the profile: {ex.Message}",
                    "Operation Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)

                Return False

            End Try

        End Using

    End Function


End Class