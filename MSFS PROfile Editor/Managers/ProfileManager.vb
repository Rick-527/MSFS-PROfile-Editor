Imports System.IO

Public Class ProfileManager
#Region "Constants"

    Private _lastErrorMessage As String
    Private _storedProfileCount As Integer

#End Region

#Region "Properties"

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

    Public ReadOnly Property StoredProfileCount As Integer

        Get

            Return _storedProfileCount

        End Get

    End Property

#End Region

    Public Function SetCurrentProfileFolder(folder As String) As Boolean

        If String.IsNullOrWhiteSpace(folder) OrElse
            Not Directory.Exists(folder) Then

            Return False

        End If

        My.Settings.ProfileFolder = Path.GetFullPath(folder)
        My.Settings.Save()

        Return True

    End Function

    Public Function GetProfiles() As List(Of ProfileInfo)

        _lastErrorMessage = String.Empty

        Dim profileFolder = My.Settings.ProfileFolder

        If String.IsNullOrWhiteSpace(profileFolder) OrElse
            Not Directory.Exists(profileFolder) Then

            _storedProfileCount = 0
            Return New List(Of ProfileInfo)

        End If

        Try

            Dim profileFiles =
                Directory.GetFiles(
                profileFolder,
                "*" & ApplicationConstants.ProfileExtension,
                SearchOption.TopDirectoryOnly
            )

            _storedProfileCount = profileFiles.Length

            Return profileFiles.
                OrderByDescending(
                Function(profileFile)
                    Return File.GetCreationTimeUtc(profileFile)
                End Function
                ).
                Take(ApplicationConstants.MaximumProfileCount).
                OrderBy(
                    Function(profileFile)
                        Return Path.GetFileNameWithoutExtension(profileFile)
                    End Function,
                    StringComparer.CurrentCultureIgnoreCase
                ).
                Select(
                    Function(profileFile)
                        Return New ProfileInfo With {
                            .ProfileFile = profileFile
                        }
                    End Function
                ).
                ToList()

        Catch ex As Exception

            _storedProfileCount = 0
            _lastErrorMessage =
                $"The profile folder could not be read.{Environment.NewLine}" &
                $"{Environment.NewLine}{ex.Message}"

            Return New List(Of ProfileInfo)

        End Try

    End Function

    Public Function CreateProfile(profileName As String) As String

        If String.IsNullOrWhiteSpace(profileName) Then
            Throw New ArgumentException("Please enter a profile name.")
        End If

        Dim profileFolder = My.Settings.ProfileFolder

        If String.IsNullOrWhiteSpace(profileFolder) OrElse
           Not Directory.Exists(profileFolder) Then

            Throw New DirectoryNotFoundException(
                "The profile folder has not been configured."
            )

        End If

        Dim normalizedName = NormalizeProfileName(profileName)

        If String.IsNullOrWhiteSpace(normalizedName) Then
            Throw New ArgumentException("Please enter a valid profile name.")
        End If

        Dim destinationFile =
            Path.Combine(profileFolder, normalizedName)

        If File.Exists(destinationFile) Then
            Throw New IOException(
                $"A profile named '{Path.GetFileNameWithoutExtension(normalizedName)}' already exists."
            )
        End If

        Dim userCfgFile =
            SimulatorFilesManager.GetFilePath(SimulatorFile.UserCfg)

        If String.IsNullOrWhiteSpace(userCfgFile) OrElse
           Not File.Exists(userCfgFile) Then

            Throw New FileNotFoundException(
                "The simulator UserCfg.opt file could not be found."
            )
        End If

        CopyFileContents(
            userCfgFile,
            destinationFile,
            overwrite:=False
        )

        Return destinationFile

    End Function

    Private Function NormalizeProfileName(profileName As String) As String

        Dim normalizedName = profileName.Trim()

        While normalizedName.EndsWith(
            ApplicationConstants.ProfileExtension,
            StringComparison.OrdinalIgnoreCase
        )

            normalizedName =
                normalizedName.Substring(
                    0,
                    normalizedName.Length -
                    ApplicationConstants.ProfileExtension.Length
                ).Trim()

        End While

        If String.IsNullOrWhiteSpace(normalizedName) Then
            Throw New ArgumentException(
                "Please enter a profile name.",
                NameOf(profileName)
            )

        End If

        If normalizedName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0 Then
            Throw New ArgumentException(
                "The profile name contains invalid characters.",
                NameOf(profileName)
            )
        End If

        Return normalizedName & ApplicationConstants.ProfileExtension

    End Function

    Public Function GetLegacyProfileCount() As Integer

        Dim profileFolder = My.Settings.ProfileFolder

        If String.IsNullOrWhiteSpace(profileFolder) OrElse
           Not Directory.Exists(profileFolder) Then

            Return 0

        End If

        Return Directory.
        GetFiles(
            profileFolder,
            "*.opt",
            SearchOption.TopDirectoryOnly
        ).
        Count(
            Function(filePath)
                Return Not String.Equals(
                    Path.GetFileName(filePath),
                    "UserCfg.opt",
                    StringComparison.OrdinalIgnoreCase
                )
            End Function
        )

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
                    Path.ChangeExtension(
                    legacyProfile,
                    ApplicationConstants.ProfileExtension
                )

                If File.Exists(newProfilePath) Then
                    result.SkippedCount += 1
                    Continue For
                End If

                CopyFileContents(
                    legacyProfile,
                    newProfilePath,
                    overwrite:=False
                )

                File.Delete(legacyProfile)

                result.ConvertedCount += 1

            Catch ex As Exception

                result.FailedCount += 1

                result.ErrorMessages.Add(
                    $"{Path.GetFileName(legacyProfile)}: {ex.Message}")

            End Try

        Next

        Return result

    End Function

    Private Sub CopyFileContents(
        sourceFile As String,
        destinationFile As String,
        overwrite As Boolean)

        Using sourceStream =
            New FileStream(
                sourceFile,
                FileMode.Open,
                FileAccess.Read,
                FileShare.ReadWrite)

            Dim destinationMode =
                If(
                    overwrite,
                    FileMode.Create,
                    FileMode.CreateNew)

            Using destinationStream =
                New FileStream(
                    destinationFile,
                    destinationMode,
                    FileAccess.Write,
                    FileShare.None)

                sourceStream.CopyTo(destinationStream)

            End Using

        End Using

    End Sub

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

            Dim newBackupPath = CreateUserCfgBackup(userCfgPath)

            DeletePreviousProfileBackups(
                userCfgPath,
                newBackupPath
            )

            CopyFileContents(
                profile.ProfileFile,
                userCfgPath,
                overwrite:=True
            )

            Return True

        Catch ex As Exception

            _lastErrorMessage =
                $"The profile could not be applied.{Environment.NewLine}" &
                $"{Environment.NewLine}{ex.Message}"

            Return False

        End Try

    End Function

    Private Function AreSameFile(firstPath As String, secondPath As String) As Boolean

        Dim firstFullPath = Path.GetFullPath(firstPath)
        Dim secondFullPath = Path.GetFullPath(secondPath)

        Return String.Equals(
            firstFullPath,
            secondFullPath,
            StringComparison.OrdinalIgnoreCase)

    End Function

    Private Function CreateUserCfgBackup(userCfgPath As String) As String

        Dim timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss")

        Dim backupPath =
            $"{userCfgPath}{ApplicationConstants.ProfileBackupMarker}{timestamp}.bak"

        CopyFileContents(
            userCfgPath,
            backupPath,
            overwrite:=False
        )

        Return backupPath

    End Function

    Private Sub DeletePreviousProfileBackups(userCfgPath As String, backupToKeep As String)

        Dim configFolder = Path.GetDirectoryName(userCfgPath)

        If String.IsNullOrWhiteSpace(configFolder) Then
            Throw New DirectoryNotFoundException(
            "The UserCfg.opt folder could not be determined."
        )
        End If

        Dim userCfgFileName = Path.GetFileName(userCfgPath)

        Dim searchPattern =
            $"{userCfgFileName}{ApplicationConstants.ProfileBackupMarker}*.bak"

        For Each backupFile In Directory.GetFiles(configFolder, searchPattern)

            If Not String.Equals(
            Path.GetFullPath(backupFile),
            Path.GetFullPath(backupToKeep),
            StringComparison.OrdinalIgnoreCase
        ) Then

                File.Delete(backupFile)

            End If

        Next

    End Sub

End Class