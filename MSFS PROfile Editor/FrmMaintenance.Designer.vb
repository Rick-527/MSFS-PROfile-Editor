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
        btnDelete = New Button()
        btnDeleteRollingCache = New Button()
        btnDeleteSceneryIndex = New Button()
        lblRollingCache = New Label()
        lblSceneryIndex = New Label()
        mnuFrmMaintenance = New MenuStrip()
        mnuFile = New ToolStripMenuItem()
        mnuDeleteBackupFiles = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        mnuClose = New ToolStripMenuItem()
        lblFolder = New Label()
        lblFiles = New Label()
        lblSize = New Label()
        lblOldest = New Label()
        mnuFrmMaintenance.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblRemoveBackupFiles
        ' 
        lblRemoveBackupFiles.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRemoveBackupFiles.ImageAlign = ContentAlignment.MiddleRight
        lblRemoveBackupFiles.Location = New Point(155, 332)
        lblRemoveBackupFiles.Name = "lblRemoveBackupFiles"
        lblRemoveBackupFiles.Size = New Size(120, 30)
        lblRemoveBackupFiles.TabIndex = 18
        lblRemoveBackupFiles.Text = "Backup Files"
        lblRemoveBackupFiles.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnDelete.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnDelete.Location = New Point(281, 327)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(172, 41)
        btnDelete.TabIndex = 17
        btnDelete.Text = "Remove Backup Files"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteRollingCache
        ' 
        btnDeleteRollingCache.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnDeleteRollingCache.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnDeleteRollingCache.Location = New Point(281, 259)
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
        btnDeleteSceneryIndex.Location = New Point(281, 191)
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
        lblRollingCache.Location = New Point(155, 263)
        lblRollingCache.Name = "lblRollingCache"
        lblRollingCache.Size = New Size(120, 30)
        lblRollingCache.TabIndex = 14
        lblRollingCache.Text = "Rolling Cache"
        lblRollingCache.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblSceneryIndex
        ' 
        lblSceneryIndex.Font = New Font("Segoe UI", 11.25F)
        lblSceneryIndex.Location = New Point(155, 195)
        lblSceneryIndex.Name = "lblSceneryIndex"
        lblSceneryIndex.Size = New Size(120, 30)
        lblSceneryIndex.TabIndex = 13
        lblSceneryIndex.Text = "Scenery Index"
        lblSceneryIndex.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' mnuFrmMaintenance
        ' 
        mnuFrmMaintenance.Items.AddRange(New ToolStripItem() {mnuFile})
        mnuFrmMaintenance.Location = New Point(0, 0)
        mnuFrmMaintenance.Name = "mnuFrmMaintenance"
        mnuFrmMaintenance.Size = New Size(465, 24)
        mnuFrmMaintenance.TabIndex = 19
        mnuFrmMaintenance.Text = "MenuStrip1"
        ' 
        ' mnuFile
        ' 
        mnuFile.DropDownItems.AddRange(New ToolStripItem() {mnuDeleteBackupFiles, ToolStripSeparator1, mnuClose})
        mnuFile.Name = "mnuFile"
        mnuFile.Size = New Size(37, 20)
        mnuFile.Text = "&File"
        ' 
        ' mnuDeleteBackupFiles
        ' 
        mnuDeleteBackupFiles.Name = "mnuDeleteBackupFiles"
        mnuDeleteBackupFiles.Size = New Size(180, 22)
        mnuDeleteBackupFiles.Text = "&Delete Backup Files"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(177, 6)
        ' 
        ' mnuClose
        ' 
        mnuClose.Name = "mnuClose"
        mnuClose.Size = New Size(180, 22)
        mnuClose.Text = "&Close"
        ' 
        ' lblFolder
        ' 
        lblFolder.Font = New Font("Segoe UI", 11.25F)
        lblFolder.Location = New Point(29, 38)
        lblFolder.Name = "lblFolder"
        lblFolder.Size = New Size(120, 30)
        lblFolder.TabIndex = 20
        lblFolder.Text = "lblFolder"
        lblFolder.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblFiles
        ' 
        lblFiles.Font = New Font("Segoe UI", 11.25F)
        lblFiles.Location = New Point(29, 68)
        lblFiles.Name = "lblFiles"
        lblFiles.Size = New Size(120, 30)
        lblFiles.TabIndex = 21
        lblFiles.Text = "lblFile"
        lblFiles.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblSize
        ' 
        lblSize.Font = New Font("Segoe UI", 11.25F)
        lblSize.Location = New Point(29, 128)
        lblSize.Name = "lblSize"
        lblSize.Size = New Size(120, 30)
        lblSize.TabIndex = 22
        lblSize.Text = "lblSize"
        lblSize.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblOldest
        ' 
        lblOldest.Font = New Font("Segoe UI", 11.25F)
        lblOldest.Location = New Point(29, 98)
        lblOldest.Name = "lblOldest"
        lblOldest.Size = New Size(120, 30)
        lblOldest.TabIndex = 23
        lblOldest.Text = "lblOldest"
        lblOldest.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' FrmMaintenance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(43), CByte(50), CByte(64))
        ClientSize = New Size(465, 380)
        Controls.Add(lblOldest)
        Controls.Add(lblSize)
        Controls.Add(lblFiles)
        Controls.Add(lblFolder)
        Controls.Add(lblRemoveBackupFiles)
        Controls.Add(btnDelete)
        Controls.Add(btnDeleteRollingCache)
        Controls.Add(btnDeleteSceneryIndex)
        Controls.Add(lblRollingCache)
        Controls.Add(lblSceneryIndex)
        Controls.Add(mnuFrmMaintenance)
        ForeColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        MainMenuStrip = mnuFrmMaintenance
        Name = "FrmMaintenance"
        Text = "MSFS PROfile Editor - Maintenance Module"
        mnuFrmMaintenance.ResumeLayout(False)
        mnuFrmMaintenance.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblRemoveBackupFiles As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnDeleteRollingCache As Button
    Friend WithEvents btnDeleteSceneryIndex As Button
    Friend WithEvents lblRollingCache As Label
    Friend WithEvents lblSceneryIndex As Label
    Friend WithEvents mnuFrmMaintenance As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuDeleteBackupFiles As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents lblFolder As Label
    Friend WithEvents lblFiles As Label
    Friend WithEvents lblSize As Label
    Friend WithEvents lblOldest As Label
End Class
