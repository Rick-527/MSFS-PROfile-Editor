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
        mnuFrmMaintenance = New MenuStrip()
        mnuFile = New ToolStripMenuItem()
        mnuDeleteBackupFiles = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        mnuClose = New ToolStripMenuItem()
        dlgOpenFile = New OpenFileDialog()
        mnuFrmMaintenance.SuspendLayout()
        SuspendLayout()
        ' 
        ' mnuFrmMaintenance
        ' 
        mnuFrmMaintenance.Items.AddRange(New ToolStripItem() {mnuFile})
        mnuFrmMaintenance.Location = New Point(0, 0)
        mnuFrmMaintenance.Name = "mnuFrmMaintenance"
        mnuFrmMaintenance.Size = New Size(426, 24)
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
        ' dlgOpenFile
        ' 
        dlgOpenFile.Filter = """opt file|*.opt"""
        ' 
        ' FrmMaintenance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(43), CByte(50), CByte(64))
        ClientSize = New Size(426, 356)
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
    Friend WithEvents mnuFrmMaintenance As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuDeleteBackupFiles As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents dlgOpenFile As OpenFileDialog
End Class
