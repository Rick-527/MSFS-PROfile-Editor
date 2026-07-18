Imports System.IO
Imports System.Diagnostics ' Required to open files in external programs

Public Class FrmMain

    ' Form Load event handles remembering the last used directory
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeManager.ApplyModernTheme(Me)

        ' Lock down the form sizing capabilities completely
        Me.FormBorderStyle = FormBorderStyle.FixedSingle ' Disables edge dragging
        Me.MaximizeBox = False                           ' Disables the maximize box window utility

        ' DYNAMICALLY UPDATE THE TITLE BAR WITH YOUR NEW VERSION NUMBER
        Dim rawVersion As String = Application.ProductVersion
        Dim currentVersion As String = rawVersion.Split("+"c)(0)
        Me.Text = Me.Text & " - v" & currentVersion

        ' Initialize path labels as empty on startup
        lblFile1Path.Text = ""
        lblFile2Path.Text = ""

        ' Validate and clear old directory histories if they no longer exist on disk
        If Not String.IsNullOrWhiteSpace(My.Settings.LastDirectory) Then
            If Not Directory.Exists(My.Settings.LastDirectory) Then
                My.Settings.LastDirectory = ""
                My.Settings.Save()
            End If
        End If

        ' AUTOMATICALLY RELOAD FILE 1 FROM LAST SESSION
        If Not String.IsNullOrWhiteSpace(My.Settings.LastFile1Path) Then
            ' Only load it if the file still actually exists on the hard drive
            If File.Exists(My.Settings.LastFile1Path) Then
                txtFile1.Text = My.Settings.LastFile1Name
                txtFile1.Tag = My.Settings.LastFile1Path
                lblFile1Path.Text = My.Settings.LastFile1Path
            Else
                ' Wipe settings if the file was deleted or moved while the app was closed
                My.Settings.LastFile1Path = ""
                My.Settings.LastFile1Name = ""
                My.Settings.Save()
            End If
        End If
    End Sub


    ' Button to select the Target File (File 1)
    Private Sub btnBrowse1_Click(sender As Object, e As EventArgs) Handles btnBrowse1.Click
        Using ofd1 As New OpenFileDialog
            ofd1.Title = "Select File 1 (Target to Overwrite)"
            ofd1.Filter = "All Files (*.*)|*.*|Text Files (*.txt)|*.txt"

            If Not String.IsNullOrWhiteSpace(My.Settings.LastDirectory) Then
                ofd1.InitialDirectory = My.Settings.LastDirectory
            End If

            If ofd1.ShowDialog = DialogResult.OK Then
                ' Display ONLY the short file name to the user in the textbox
                txtFile1.Text = Path.GetFileName(ofd1.FileName)

                ' Display the FULL absolute path to the user in the label
                lblFile1Path.Text = ofd1.FileName

                ' Store the full hidden path inside the .Tag property for background use
                txtFile1.Tag = ofd1.FileName

                ' SAVE FILE 1 PERSISTENT MEMORY VALUES
                My.Settings.LastFile1Path = ofd1.FileName
                My.Settings.LastFile1Name = Path.GetFileName(ofd1.FileName)

                ' Save the folder path to memory
                My.Settings.LastDirectory = Path.GetDirectoryName(ofd1.FileName)
                My.Settings.Save()
            End If
        End Using
    End Sub

    ' Button to select the Source File (File 2)
    Private Sub btnBrowse2_Click(sender As Object, e As EventArgs) Handles btnBrowse2.Click
        Using ofd2 As New OpenFileDialog
            ofd2.Title = "Select File 2 (Source of New Data)"
            ofd2.Filter = "All Files (*.*)|*.*|Text Files (*.txt)|*.txt"

            If Not String.IsNullOrWhiteSpace(My.Settings.LastDirectory) Then
                ofd2.InitialDirectory = My.Settings.LastDirectory
            End If

            If ofd2.ShowDialog = DialogResult.OK Then
                ' Display ONLY the short file name to the user in the textbox
                txtFile2.Text = Path.GetFileName(ofd2.FileName)

                ' Display the FULL absolute path to the user in the new label
                lblFile2Path.Text = ofd2.FileName

                ' Store the full hidden path inside the .Tag property for background use
                txtFile2.Tag = ofd2.FileName

                ' Save the folder path to memory
                My.Settings.LastDirectory = Path.GetDirectoryName(ofd2.FileName)
                My.Settings.Save()
            End If
        End Using
    End Sub

    ' Button to view the contents of File 1
    Private Sub btnViewFile1_Click(sender As Object, e As EventArgs) Handles btnViewFile1.Click
        Dim fullPath = If(txtFile1.Tag IsNot Nothing, txtFile1.Tag.ToString, "")
        OpenFileInDefaultApp(fullPath)
    End Sub

    ' Button to view the contents of File 2
    Private Sub btnViewFile2_Click(sender As Object, e As EventArgs) Handles btnViewFile2.Click
        Dim fullPath = If(txtFile2.Tag IsNot Nothing, txtFile2.Tag.ToString, "")
        OpenFileInDefaultApp(fullPath)
    End Sub

    Private Function BackupName(path As String) As String
        Return $"{path}.{DateTime.Now:yyyyMMdd_HHmmss}.bak"
    End Function

    ' Helper method to safely validate and open a file in Windows
    Private Sub OpenFileInDefaultApp(filePath As String)
        If String.IsNullOrWhiteSpace(filePath) Then
            MessageBox.Show("Please select a file first before trying to view it.", "No File Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not File.Exists(filePath) Then
            MessageBox.Show("The file could not be found. It may have been moved or deleted.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Process.Start(New ProcessStartInfo(filePath) With {.UseShellExecute = True})
        Catch ex As Exception
            MessageBox.Show($"Could not open the file: {ex.Message}", "Error Opening File", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Button to overwrite File 1 with File 2's data
    Private Sub btnSwap_Click(sender As Object, e As EventArgs) Handles btnSwap.Click
        Dim file1FullPath = If(txtFile1.Tag IsNot Nothing, txtFile1.Tag.ToString(), "")
        Dim file2FullPath = If(txtFile2.Tag IsNot Nothing, txtFile2.Tag.ToString(), "")

        If String.IsNullOrWhiteSpace(file1FullPath) OrElse String.IsNullOrWhiteSpace(file2FullPath) Then
            MessageBox.Show("Please select both files before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If file1FullPath.ToLower = file2FullPath.ToLower Then
            MessageBox.Show("You cannot overwrite a file with itself. Please select two different files.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not File.Exists(file1FullPath) OrElse Not File.Exists(file2FullPath) Then
            MessageBox.Show("One or both selected files could not be found. Please check the paths.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim confirmResult = MessageBox.Show(
            $"Are you sure you want to overwrite '{txtFile1.Text}'? This will permanently delete its original contents.",
            "Confirm Overwrite",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If confirmResult = DialogResult.Yes Then
            Try
                Dim backupResult = MessageBox.Show(
                    $"Would you like to create a backup copy of '{txtFile1.Text}' before it is overwritten?",
                    "Create Backup?",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question
                )

                If backupResult = DialogResult.Cancel Then
                    Exit Sub
                End If

                If backupResult = DialogResult.Yes Then
                    Dim backupPath = BackupName(file1FullPath)
                    File.Copy(file1FullPath, backupPath, True)
                End If

                File.Copy(file2FullPath, file1FullPath, True)
                MessageBox.Show("File updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"An error occurred while writing data: {ex.Message}", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' Button to save File 1 into a brand new location
    Private Sub btnSaveAs_Click(sender As Object, e As EventArgs) Handles btnSaveAs.Click
        Dim file1FullPath = If(txtFile1.Tag IsNot Nothing, txtFile1.Tag.ToString, "")

        If String.IsNullOrWhiteSpace(file1FullPath) Then
            MessageBox.Show("Please select File 1 first before attempting to save it to a new destination.", "No Source File Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not File.Exists(file1FullPath) Then
            MessageBox.Show("The source file (File 1) could not be found. It may have been moved or deleted.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using sfd As New SaveFileDialog
            sfd.Title = "Save File 1 to New Destination"
            sfd.Filter = "All Files (*.*)|*.*|Text Files (*.txt)|*.txt"
            sfd.FileName = Path.GetFileName(file1FullPath)

            If Not String.IsNullOrWhiteSpace(My.Settings.LastDirectory) Then
                sfd.InitialDirectory = My.Settings.LastDirectory
            End If

            If sfd.ShowDialog = DialogResult.OK Then
                Try
                    File.Copy(file1FullPath, sfd.FileName, True)

                    My.Settings.LastDirectory = Path.GetDirectoryName(sfd.FileName)
                    My.Settings.Save()

                    MessageBox.Show("File saved successfully to its new destination!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show($"An error occurred while saving the file: {ex.Message}", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub mnuMaintenance_Click(sender As Object, e As EventArgs) Handles mnuMaintenance.Click
        Using frm As New FrmMaintenance()
            frm.ShowDialog(Me)
        End Using

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
