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
        lblConfigurationFiles = New Label()
        lblStatus = New ToolStripStatusLabel()
        StatusStrip1 = New StatusStrip()
        lblRollingCache = New Label()
        lblSceneryIndexes = New Label()
        btnBackupCamerasCfg = New Button()
        btnViewCamerasCfg = New Button()
        btnViewExeXml = New Button()
        btnBackupExeXml = New Button()
        btnViewFs2024Cfg = New Button()
        btnBackupFs2024Cfg = New Button()
        pnlHeader = New Panel()
        lblPageDescription = New Label()
        lblPageTitle = New Label()
        pnlContent = New Panel()
        pnlFooter = New Panel()
        StatusStrip1.SuspendLayout()
        pnlHeader.SuspendLayout()
        pnlContent.SuspendLayout()
        pnlFooter.SuspendLayout()
        SuspendLayout()
        ' 
        ' dlgOpenFile
        ' 
        dlgOpenFile.Filter = """opt file|*.opt"""
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Right
        btnClose.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnClose.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnClose.Location = New Point(352, 20)
        btnClose.Margin = New Padding(4, 3, 4, 3)
        btnClose.Name = "btnClose"
        btnClose.RightToLeft = RightToLeft.Yes
        btnClose.Size = New Size(251, 47)
        btnClose.TabIndex = 21
        btnClose.Text = "&Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteRollingCache
        ' 
        btnDeleteRollingCache.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnDeleteRollingCache.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnDeleteRollingCache.Location = New Point(75, 325)
        btnDeleteRollingCache.Name = "btnDeleteRollingCache"
        btnDeleteRollingCache.Size = New Size(251, 47)
        btnDeleteRollingCache.TabIndex = 22
        btnDeleteRollingCache.Text = "&Delete Rolling Cache"
        btnDeleteRollingCache.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteSceneryIndexes
        ' 
        btnDeleteSceneryIndexes.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnDeleteSceneryIndexes.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnDeleteSceneryIndexes.Location = New Point(75, 431)
        btnDeleteSceneryIndexes.Name = "btnDeleteSceneryIndexes"
        btnDeleteSceneryIndexes.Size = New Size(251, 47)
        btnDeleteSceneryIndexes.TabIndex = 23
        btnDeleteSceneryIndexes.Text = "Delete &Scenery Indexes"
        btnDeleteSceneryIndexes.UseVisualStyleBackColor = False
        ' 
        ' lblConfigurationFiles
        ' 
        lblConfigurationFiles.AutoSize = True
        lblConfigurationFiles.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblConfigurationFiles.Location = New Point(75, 15)
        lblConfigurationFiles.Name = "lblConfigurationFiles"
        lblConfigurationFiles.Size = New Size(141, 20)
        lblConfigurationFiles.TabIndex = 27
        lblConfigurationFiles.Text = "Configuration Files"
        ' 
        ' lblStatus
        ' 
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(39, 17)
        lblStatus.Text = "Ready"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblStatus})
        StatusStrip1.Location = New Point(0, 667)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(672, 22)
        StatusStrip1.TabIndex = 37
        StatusStrip1.Text = "Ready"
        ' 
        ' lblRollingCache
        ' 
        lblRollingCache.AutoSize = True
        lblRollingCache.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblRollingCache.Location = New Point(75, 295)
        lblRollingCache.Name = "lblRollingCache"
        lblRollingCache.Size = New Size(103, 20)
        lblRollingCache.TabIndex = 38
        lblRollingCache.Text = "Rolling Cache"
        ' 
        ' lblSceneryIndexes
        ' 
        lblSceneryIndexes.AutoSize = True
        lblSceneryIndexes.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblSceneryIndexes.Location = New Point(75, 401)
        lblSceneryIndexes.Name = "lblSceneryIndexes"
        lblSceneryIndexes.Size = New Size(122, 20)
        lblSceneryIndexes.TabIndex = 39
        lblSceneryIndexes.Text = "Scenery Indexes"
        ' 
        ' btnBackupCamerasCfg
        ' 
        btnBackupCamerasCfg.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnBackupCamerasCfg.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnBackupCamerasCfg.Location = New Point(75, 225)
        btnBackupCamerasCfg.Name = "btnBackupCamerasCfg"
        btnBackupCamerasCfg.Size = New Size(251, 47)
        btnBackupCamerasCfg.TabIndex = 24
        btnBackupCamerasCfg.Text = "&Backup Cameras.cfg"
        btnBackupCamerasCfg.UseVisualStyleBackColor = False
        ' 
        ' btnViewCamerasCfg
        ' 
        btnViewCamerasCfg.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnViewCamerasCfg.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnViewCamerasCfg.Location = New Point(75, 172)
        btnViewCamerasCfg.Name = "btnViewCamerasCfg"
        btnViewCamerasCfg.Size = New Size(251, 47)
        btnViewCamerasCfg.TabIndex = 26
        btnViewCamerasCfg.Text = "Vie&w Cameras.cfg"
        btnViewCamerasCfg.UseVisualStyleBackColor = False
        ' 
        ' btnViewExeXml
        ' 
        btnViewExeXml.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnViewExeXml.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnViewExeXml.Location = New Point(75, 45)
        btnViewExeXml.Name = "btnViewExeXml"
        btnViewExeXml.Size = New Size(251, 47)
        btnViewExeXml.TabIndex = 25
        btnViewExeXml.Text = "&View EXE.xml"
        btnViewExeXml.UseVisualStyleBackColor = False
        ' 
        ' btnBackupExeXml
        ' 
        btnBackupExeXml.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnBackupExeXml.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnBackupExeXml.Location = New Point(75, 98)
        btnBackupExeXml.Name = "btnBackupExeXml"
        btnBackupExeXml.Size = New Size(251, 47)
        btnBackupExeXml.TabIndex = 34
        btnBackupExeXml.Text = "Bac&kup EXE.xml"
        btnBackupExeXml.UseVisualStyleBackColor = False
        ' 
        ' btnViewFs2024Cfg
        ' 
        btnViewFs2024Cfg.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnViewFs2024Cfg.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnViewFs2024Cfg.Location = New Point(352, 45)
        btnViewFs2024Cfg.Margin = New Padding(3, 2, 3, 2)
        btnViewFs2024Cfg.Name = "btnViewFs2024Cfg"
        btnViewFs2024Cfg.Size = New Size(251, 47)
        btnViewFs2024Cfg.TabIndex = 40
        btnViewFs2024Cfg.Text = "View &Flightsimulator2024.cfg"
        btnViewFs2024Cfg.UseVisualStyleBackColor = False
        ' 
        ' btnBackupFs2024Cfg
        ' 
        btnBackupFs2024Cfg.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnBackupFs2024Cfg.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnBackupFs2024Cfg.Location = New Point(352, 99)
        btnBackupFs2024Cfg.Margin = New Padding(3, 2, 3, 2)
        btnBackupFs2024Cfg.Name = "btnBackupFs2024Cfg"
        btnBackupFs2024Cfg.Size = New Size(251, 47)
        btnBackupFs2024Cfg.TabIndex = 41
        btnBackupFs2024Cfg.Text = "Backup Flightsi&mulator2024.cfg"
        btnBackupFs2024Cfg.UseVisualStyleBackColor = False
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Controls.Add(lblPageDescription)
        pnlHeader.Controls.Add(lblPageTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(672, 80)
        pnlHeader.TabIndex = 42
        ' 
        ' lblPageDescription
        ' 
        lblPageDescription.Anchor = AnchorStyles.Top
        lblPageDescription.AutoSize = True
        lblPageDescription.Location = New Point(296, 53)
        lblPageDescription.Name = "lblPageDescription"
        lblPageDescription.Size = New Size(80, 15)
        lblPageDescription.TabIndex = 1
        lblPageDescription.Text = "lblDescription"
        ' 
        ' lblPageTitle
        ' 
        lblPageTitle.Anchor = AnchorStyles.Top
        lblPageTitle.AutoSize = True
        lblPageTitle.Location = New Point(315, 19)
        lblPageTitle.Name = "lblPageTitle"
        lblPageTitle.Size = New Size(43, 15)
        lblPageTitle.TabIndex = 0
        lblPageTitle.Text = "lblTitle"
        ' 
        ' pnlContent
        ' 
        pnlContent.Controls.Add(btnBackupFs2024Cfg)
        pnlContent.Controls.Add(lblConfigurationFiles)
        pnlContent.Controls.Add(lblRollingCache)
        pnlContent.Controls.Add(lblSceneryIndexes)
        pnlContent.Controls.Add(btnViewFs2024Cfg)
        pnlContent.Controls.Add(btnBackupCamerasCfg)
        pnlContent.Controls.Add(btnBackupExeXml)
        pnlContent.Controls.Add(btnDeleteRollingCache)
        pnlContent.Controls.Add(btnDeleteSceneryIndexes)
        pnlContent.Controls.Add(btnViewCamerasCfg)
        pnlContent.Controls.Add(btnViewExeXml)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(0, 80)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(672, 587)
        pnlContent.TabIndex = 43
        ' 
        ' pnlFooter
        ' 
        pnlFooter.Controls.Add(btnClose)
        pnlFooter.Dock = DockStyle.Bottom
        pnlFooter.Location = New Point(0, 587)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(672, 80)
        pnlFooter.TabIndex = 44
        ' 
        ' FrmMaintenance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(43), CByte(50), CByte(64))
        CancelButton = btnClose
        ClientSize = New Size(672, 689)
        Controls.Add(pnlFooter)
        Controls.Add(pnlContent)
        Controls.Add(pnlHeader)
        Controls.Add(StatusStrip1)
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
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlContent.ResumeLayout(False)
        pnlContent.PerformLayout()
        pnlFooter.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dlgOpenFile As OpenFileDialog
    Friend WithEvents btnClose As Button
    Friend WithEvents btnDeleteRollingCache As Button
    Friend WithEvents btnDeleteSceneryIndexes As Button
    Friend WithEvents lblConfigurationFiles As Label
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
    Friend WithEvents btnBackupExeXml As Button
    Friend WithEvents btnViewFs2024Cfg As Button
    Friend WithEvents btnBackupFs2024Cfg As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents lblPageDescription As Label
    Friend WithEvents lblPageTitle As Label
End Class
