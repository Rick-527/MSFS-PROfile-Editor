Imports System.IO

Public Class FrmMaintenance

    Private ReadOnly _backupManager As New BackupManager()
    Private ReadOnly _profileManager As New ProfileManager()

    Private Sub FrmMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ThemeManager.ApplyModernTheme(Me)

        'RefreshBackupInformation()

    End Sub

    'Private Sub RefreshBackupInformation()

    'Dim backups = _backupManager.GetBackupFiles(_profileManager.CurrentProfileFolder)

    'lblBackupCount.Text = backups.Count.ToString()

    'Later...
    'lblTotalSize.Text = ...
    'lblOldestBackup.Text = ...

    'End Sub


    '******************************************START CODE FROM EARLY COMMIT FOR TESTING PURPOSES******************************************
    'Private Sub btnBrowse1_Click(sender As Object, e As EventArgs) Handles btnBrowse1.Click
    '    Using ofd1 As New OpenFileDialog
    '        ofd1.Title = "Select File 1 (Target to Overwrite)"
    '        ofd1.Filter = "All Files (*.*)|*.*|Text Files (*.txt)|*.txt"

    '        If Not String.IsNullOrWhiteSpace(My.Settings.LastDirectory) Then
    '            ofd1.InitialDirectory = My.Settings.LastDirectory
    '        End If

    '        If ofd1.ShowDialog = DialogResult.OK Then
    '            ' Display ONLY the short file name to the user in the textbox
    '            txtFile1.Text = Path.GetFileName(ofd1.FileName)

    '            ' Display the FULL absolute path to the user in the label
    '            lblFile1Path.Text = ofd1.FileName

    '            ' Store the full hidden path inside the .Tag property for background use
    '            txtFile1.Tag = ofd1.FileName

    '            ' SAVE FILE 1 PERSISTENT MEMORY VALUES
    '            My.Settings.LastFile1Path = ofd1.FileName
    '            My.Settings.LastFile1Name = Path.GetFileName(ofd1.FileName)

    '            ' Save the folder path to memory
    '            My.Settings.LastDirectory = Path.GetDirectoryName(ofd1.FileName)
    '            My.Settings.Save()
    '        End If
    '    End Using
    'End Sub

    ' Button to select the Source File (File 2)
    'Private Sub btnBrowse2_Click(sender As Object, e As EventArgs) Handles btnBrowse2.Click
    '    Using ofd2 As New OpenFileDialog
    '        ofd2.Title = "Select File 2 (Source of New Data)"
    '        ofd2.Filter = "All Files (*.*)|*.*|Text Files (*.txt)|*.txt"

    '        If Not String.IsNullOrWhiteSpace(My.Settings.LastDirectory) Then
    '            ofd2.InitialDirectory = My.Settings.LastDirectory
    '        End If

    '        If ofd2.ShowDialog = DialogResult.OK Then
    '            ' Display ONLY the short file name to the user in the textbox
    '            txtFile2.Text = Path.GetFileName(ofd2.FileName)

    '            ' Display the FULL absolute path to the user in the new label
    '            lblFile2Path.Text = ofd2.FileName

    '            ' Store the full hidden path inside the .Tag property for background use
    '            txtFile2.Tag = ofd2.FileName

    '            ' Save the folder path to memory
    '            My.Settings.LastDirectory = Path.GetDirectoryName(ofd2.FileName)
    '            My.Settings.Save()
    '        End If
    '    End Using
    'End Sub

    '*******************************************END CODE FROM EARLY COMMIT FOR TESTING PURPOSES******************************************


    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        Me.Close()
    End Sub

    Private Sub btnViewDestinationFile_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnProfileEditor_Click(sender As Object, e As EventArgs) Handles btnProfileEditor.Click
        Using frm As New FrmProfileEditor()
            frm.ShowDialog(Me)
        End Using
    End Sub
End Class