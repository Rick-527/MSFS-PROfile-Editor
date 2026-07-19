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
        btnOk = New Button()
        mnuFrmMaintenance = New MenuStrip()
        mnuFile = New ToolStripMenuItem()
        mnuDeleteBackupFiles = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        mnuClose = New ToolStripMenuItem()
        lblBackupCount = New Label()
        lblTotalSize = New Label()
        lblOldestBackup = New Label()
        dlgOpenFile = New OpenFileDialog()
        btnProfileEditor = New Button()
        mnuFrmMaintenance.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnOk
        ' 
        btnOk.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnOk.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnOk.Location = New Point(1069, 641)
        btnOk.Name = "btnOk"
        btnOk.Size = New Size(172, 41)
        btnOk.TabIndex = 15
        btnOk.Text = "OK"
        btnOk.UseVisualStyleBackColor = False
        ' 
        ' mnuFrmMaintenance
        ' 
        mnuFrmMaintenance.Items.AddRange(New ToolStripItem() {mnuFile})
        mnuFrmMaintenance.Location = New Point(0, 0)
        mnuFrmMaintenance.Name = "mnuFrmMaintenance"
        mnuFrmMaintenance.Size = New Size(1253, 24)
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
        mnuDeleteBackupFiles.Size = New Size(175, 22)
        mnuDeleteBackupFiles.Text = "&Delete Backup Files"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(172, 6)
        ' 
        ' mnuClose
        ' 
        mnuClose.Name = "mnuClose"
        mnuClose.Size = New Size(175, 22)
        mnuClose.Text = "&Close"
        ' 
        ' lblBackupCount
        ' 
        lblBackupCount.Font = New Font("Segoe UI", 11.25F)
        lblBackupCount.Location = New Point(591, 595)
        lblBackupCount.Name = "lblBackupCount"
        lblBackupCount.Size = New Size(120, 30)
        lblBackupCount.TabIndex = 20
        lblBackupCount.Text = "lblBackupCount"
        lblBackupCount.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblTotalSize
        ' 
        lblTotalSize.Font = New Font("Segoe UI", 11.25F)
        lblTotalSize.Location = New Point(591, 655)
        lblTotalSize.Name = "lblTotalSize"
        lblTotalSize.Size = New Size(120, 30)
        lblTotalSize.TabIndex = 22
        lblTotalSize.Text = "lblTotalSize"
        lblTotalSize.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblOldestBackup
        ' 
        lblOldestBackup.Font = New Font("Segoe UI", 11.25F)
        lblOldestBackup.Location = New Point(591, 625)
        lblOldestBackup.Name = "lblOldestBackup"
        lblOldestBackup.Size = New Size(120, 30)
        lblOldestBackup.TabIndex = 23
        lblOldestBackup.Text = "lblOldest"
        lblOldestBackup.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' dlgOpenFile
        ' 
        dlgOpenFile.Filter = """opt file|*.opt"""
        ' 
        ' btnProfileEditor
        ' 
        btnProfileEditor.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnProfileEditor.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnProfileEditor.Location = New Point(12, 557)
        btnProfileEditor.Name = "btnProfileEditor"
        btnProfileEditor.Size = New Size(172, 41)
        btnProfileEditor.TabIndex = 33
        btnProfileEditor.Text = "Profile Editor"
        btnProfileEditor.UseVisualStyleBackColor = False
        ' 
        ' FrmMaintenance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(43), CByte(50), CByte(64))
        CancelButton = btnOk
        ClientSize = New Size(1253, 694)
        Controls.Add(btnProfileEditor)
        Controls.Add(lblOldestBackup)
        Controls.Add(lblTotalSize)
        Controls.Add(lblBackupCount)
        Controls.Add(btnOk)
        Controls.Add(mnuFrmMaintenance)
        ForeColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        FormBorderStyle = FormBorderStyle.FixedDialog
        MainMenuStrip = mnuFrmMaintenance
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmMaintenance"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "MSFS PROfile Editor - Maintenance Module"
        mnuFrmMaintenance.ResumeLayout(False)
        mnuFrmMaintenance.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnOk As Button
    Friend WithEvents mnuFrmMaintenance As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuDeleteBackupFiles As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents lblBackupCount As Label
    Friend WithEvents lblTotalSize As Label
    Friend WithEvents lblOldestBackup As Label
    Friend WithEvents dlgOpenFile As OpenFileDialog
    Friend WithEvents btnProfileEditor As Button
End Class
