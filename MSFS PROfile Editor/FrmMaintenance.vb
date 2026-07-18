Public Class FrmMaintenance

    Private ReadOnly _backupManager As New BackupManager()
    Private ReadOnly _profileManager As New ProfileManager()

    Private Sub FrmMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeManager.ApplyModernTheme(Me)
    End Sub


    Private Sub LoadBackupInformation()

        'Dim folder = ProfileManager.CurrentProfileFolder
        'Dim backups = BackupManager.GetBackupFiles(folder)

        'lblFolder.Text = folder
        'lblFiles.Text = backups.Count.ToString()

        'lblSize.Text = FormatSize(backups.Sum(Function(f) f.Length))

        'If backups.Any() Then
        '    lblOldest.Text = backups.Min(Function(f) f.CreationTime).ToString()
        'Else
        '    lblOldest.Text = "None"
        'End If

        'btnDelete.Enabled = backups.Any()

    End Sub

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        Me.Close()
    End Sub
End Class