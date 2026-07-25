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
        dlgOpenFile = New OpenFileDialog()
        btnClose = New Button()
        btnDeleteRollingCache = New Button()
        btnDeleteSceneryIndexes = New Button()
        Label1 = New Label()
        lblStatus = New ToolStripStatusLabel()
        StatusStrip1 = New StatusStrip()
        lblRollingCache = New Label()
        lblSceneryIndexes = New Label()
        btnBackupCamerasCfg = New Button()
        btnViewCamerasCfg = New Button()
        btnViewExeXml = New Button()
        btnBackupXmlExe = New Button()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dlgOpenFile
        ' 
        dlgOpenFile.Filter = """opt file|*.opt"""
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnClose.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnClose.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnClose.Location = New Point(340, 477)
        btnClose.Margin = New Padding(4, 3, 4, 3)
        btnClose.Name = "btnClose"
        btnClose.RightToLeft = RightToLeft.Yes
        btnClose.Size = New Size(197, 47)
        btnClose.TabIndex = 21
        btnClose.Text = "&Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteRollingCache
        ' 
        btnDeleteRollingCache.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnDeleteRollingCache.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnDeleteRollingCache.Location = New Point(43, 360)
        btnDeleteRollingCache.Name = "btnDeleteRollingCache"
        btnDeleteRollingCache.Size = New Size(197, 47)
        btnDeleteRollingCache.TabIndex = 22
        btnDeleteRollingCache.Text = "&Delete Rolling Cache"
        btnDeleteRollingCache.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteSceneryIndexes
        ' 
        btnDeleteSceneryIndexes.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnDeleteSceneryIndexes.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnDeleteSceneryIndexes.Location = New Point(43, 477)
        btnDeleteSceneryIndexes.Name = "btnDeleteSceneryIndexes"
        btnDeleteSceneryIndexes.Size = New Size(197, 47)
        btnDeleteSceneryIndexes.TabIndex = 23
        btnDeleteSceneryIndexes.Text = "Delete &Scenery Indexes"
        btnDeleteSceneryIndexes.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        Label1.Location = New Point(43, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 20)
        Label1.TabIndex = 27
        Label1.Text = "Configuration Files"
        ' 
        ' lblStatus
        ' 
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(39, 17)
        lblStatus.Text = "Ready"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblStatus})
        StatusStrip1.Location = New Point(0, 566)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(580, 22)
        StatusStrip1.TabIndex = 37
        StatusStrip1.Text = "Ready"
        ' 
        ' lblRollingCache
        ' 
        lblRollingCache.AutoSize = True
        lblRollingCache.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblRollingCache.Location = New Point(43, 330)
        lblRollingCache.Name = "lblRollingCache"
        lblRollingCache.Size = New Size(103, 20)
        lblRollingCache.TabIndex = 38
        lblRollingCache.Text = "Rolling Cache"
        ' 
        ' lblSceneryIndexes
        ' 
        lblSceneryIndexes.AutoSize = True
        lblSceneryIndexes.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblSceneryIndexes.Location = New Point(43, 447)
        lblSceneryIndexes.Name = "lblSceneryIndexes"
        lblSceneryIndexes.Size = New Size(122, 20)
        lblSceneryIndexes.TabIndex = 39
        lblSceneryIndexes.Text = "Scenery Indexes"
        ' 
        ' btnBackupCamerasCfg
        ' 
        btnBackupCamerasCfg.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnBackupCamerasCfg.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnBackupCamerasCfg.Location = New Point(43, 243)
        btnBackupCamerasCfg.Name = "btnBackupCamerasCfg"
        btnBackupCamerasCfg.Size = New Size(197, 47)
        btnBackupCamerasCfg.TabIndex = 24
        btnBackupCamerasCfg.Text = "&Backup Cameras.cfg"
        btnBackupCamerasCfg.UseVisualStyleBackColor = False
        ' 
        ' btnViewCamerasCfg
        ' 
        btnViewCamerasCfg.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnViewCamerasCfg.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnViewCamerasCfg.Location = New Point(43, 190)
        btnViewCamerasCfg.Name = "btnViewCamerasCfg"
        btnViewCamerasCfg.Size = New Size(197, 47)
        btnViewCamerasCfg.TabIndex = 26
        btnViewCamerasCfg.Text = "O&pen Cameras.cfg"
        btnViewCamerasCfg.UseVisualStyleBackColor = False
        ' 
        ' btnViewExeXml
        ' 
        btnViewExeXml.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnViewExeXml.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnViewExeXml.Location = New Point(43, 63)
        btnViewExeXml.Name = "btnViewExeXml"
        btnViewExeXml.Size = New Size(197, 47)
        btnViewExeXml.TabIndex = 25
        btnViewExeXml.Text = "&Open EXE.xml"
        btnViewExeXml.UseVisualStyleBackColor = False
        ' 
        ' btnBackupXmlExe
        ' 
        btnBackupXmlExe.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnBackupXmlExe.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnBackupXmlExe.Location = New Point(43, 116)
        btnBackupXmlExe.Name = "btnBackupXmlExe"
        btnBackupXmlExe.Size = New Size(197, 47)
        btnBackupXmlExe.TabIndex = 34
        btnBackupXmlExe.Text = "Bac&kup EXE.xml"
        btnBackupXmlExe.UseVisualStyleBackColor = False
        ' 
        ' FrmMaintenance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(43), CByte(50), CByte(64))
        ClientSize = New Size(580, 588)
        Controls.Add(btnBackupXmlExe)
        Controls.Add(btnDeleteSceneryIndexes)
        Controls.Add(btnViewExeXml)
        Controls.Add(btnViewCamerasCfg)
        Controls.Add(btnDeleteRollingCache)
        Controls.Add(btnBackupCamerasCfg)
        Controls.Add(lblSceneryIndexes)
        Controls.Add(lblRollingCache)
        Controls.Add(StatusStrip1)
        Controls.Add(Label1)
        Controls.Add(btnClose)
        ForeColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmMaintenance"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "MSFS PROfile Editor - Maintenance Module"
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dlgOpenFile As OpenFileDialog
    Friend WithEvents btnClose As Button
    Friend WithEvents btnDeleteRollingCache As Button
    Friend WithEvents btnDeleteSceneryIndexes As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnNewIndexesBackupPath As Button
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblRollingCache As Label
    Friend WithEvents lblSceneryIndexes As Label
    Friend WithEvents btnBackupCamerasCfg As Button
    Friend WithEvents btnViewCamerasCfg As Button
    Friend WithEvents btnViewExeXml As Button
    Friend WithEvents btnBackupXmlExe As Button
End Class
