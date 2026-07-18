<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMaintenance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblRemoveBackupFiles = New Label()
        btnRemoveBackupFiles = New Button()
        btnDeleteRollingCache = New Button()
        btnDeleteSceneryIndex = New Button()
        lblRollingCache = New Label()
        lblSceneryIndex = New Label()
        SuspendLayout()
        ' 
        ' lblRemoveBackupFiles
        ' 
        lblRemoveBackupFiles.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRemoveBackupFiles.ImageAlign = ContentAlignment.MiddleRight
        lblRemoveBackupFiles.Location = New Point(28, 187)
        lblRemoveBackupFiles.Name = "lblRemoveBackupFiles"
        lblRemoveBackupFiles.Size = New Size(120, 30)
        lblRemoveBackupFiles.TabIndex = 18
        lblRemoveBackupFiles.Text = "Backup Files"
        lblRemoveBackupFiles.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' btnRemoveBackupFiles
        ' 
        btnRemoveBackupFiles.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnRemoveBackupFiles.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnRemoveBackupFiles.Location = New Point(154, 182)
        btnRemoveBackupFiles.Name = "btnRemoveBackupFiles"
        btnRemoveBackupFiles.Size = New Size(172, 41)
        btnRemoveBackupFiles.TabIndex = 17
        btnRemoveBackupFiles.Text = "Remove Backup Files"
        btnRemoveBackupFiles.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteRollingCache
        ' 
        btnDeleteRollingCache.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnDeleteRollingCache.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnDeleteRollingCache.Location = New Point(154, 114)
        btnDeleteRollingCache.Name = "btnDeleteRollingCache"
        btnDeleteRollingCache.Size = New Size(172, 41)
        btnDeleteRollingCache.TabIndex = 16
        btnDeleteRollingCache.Text = "Clear Rolling Cache"
        btnDeleteRollingCache.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteSceneryIndex
        ' 
        btnDeleteSceneryIndex.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnDeleteSceneryIndex.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnDeleteSceneryIndex.Location = New Point(154, 46)
        btnDeleteSceneryIndex.Name = "btnDeleteSceneryIndex"
        btnDeleteSceneryIndex.Size = New Size(172, 41)
        btnDeleteSceneryIndex.TabIndex = 15
        btnDeleteSceneryIndex.Text = "Clear Scenery Indexes"
        btnDeleteSceneryIndex.UseVisualStyleBackColor = False
        ' 
        ' lblRollingCache
        ' 
        lblRollingCache.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRollingCache.ImageAlign = ContentAlignment.MiddleRight
        lblRollingCache.Location = New Point(28, 118)
        lblRollingCache.Name = "lblRollingCache"
        lblRollingCache.Size = New Size(120, 30)
        lblRollingCache.TabIndex = 14
        lblRollingCache.Text = "Rolling Cache"
        lblRollingCache.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblSceneryIndex
        ' 
        lblSceneryIndex.Font = New Font("Segoe UI", 11.25F)
        lblSceneryIndex.Location = New Point(28, 50)
        lblSceneryIndex.Name = "lblSceneryIndex"
        lblSceneryIndex.Size = New Size(120, 30)
        lblSceneryIndex.TabIndex = 13
        lblSceneryIndex.Text = "Scenery Index"
        lblSceneryIndex.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' FrmMaintenance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(465, 380)
        Controls.Add(lblRemoveBackupFiles)
        Controls.Add(btnRemoveBackupFiles)
        Controls.Add(btnDeleteRollingCache)
        Controls.Add(btnDeleteSceneryIndex)
        Controls.Add(lblRollingCache)
        Controls.Add(lblSceneryIndex)
        Name = "FrmMaintenance"
        Text = "MSFS PROfile Editor - Maintenance Module"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblRemoveBackupFiles As Label
    Friend WithEvents btnRemoveBackupFiles As Button
    Friend WithEvents btnDeleteRollingCache As Button
    Friend WithEvents btnDeleteSceneryIndex As Button
    Friend WithEvents lblRollingCache As Label
    Friend WithEvents lblSceneryIndex As Label
End Class
