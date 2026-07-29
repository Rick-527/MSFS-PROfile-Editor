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
        btnViewFs2024Cfg = New Button()
        btnBackupFs2024Cfg = New Button()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dlgOpenFile
        ' 
        dlgOpenFile.Filter = """opt file|*.opt"""
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnClose.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnClose.Location = New Point(387, 636)
        btnClose.Margin = New Padding(5, 4, 5, 4)
        btnClose.Name = "btnClose"
        btnClose.RightToLeft = RightToLeft.Yes
        btnClose.Size = New Size(287, 63)
        btnClose.TabIndex = 21
        btnClose.Text = "&Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteRollingCache
        ' 
        btnDeleteRollingCache.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnDeleteRollingCache.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnDeleteRollingCache.Location = New Point(71, 480)
        btnDeleteRollingCache.Margin = New Padding(3, 4, 3, 4)
        btnDeleteRollingCache.Name = "btnDeleteRollingCache"
        btnDeleteRollingCache.Size = New Size(287, 63)
        btnDeleteRollingCache.TabIndex = 22
        btnDeleteRollingCache.Text = "&Delete Rolling Cache"
        btnDeleteRollingCache.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteSceneryIndexes
        ' 
        btnDeleteSceneryIndexes.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnDeleteSceneryIndexes.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnDeleteSceneryIndexes.Location = New Point(71, 636)
        btnDeleteSceneryIndexes.Margin = New Padding(3, 4, 3, 4)
        btnDeleteSceneryIndexes.Name = "btnDeleteSceneryIndexes"
        btnDeleteSceneryIndexes.Size = New Size(287, 63)
        btnDeleteSceneryIndexes.TabIndex = 23
        btnDeleteSceneryIndexes.Text = "Delete &Scenery Indexes"
        btnDeleteSceneryIndexes.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        Label1.Location = New Point(71, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(181, 25)
        Label1.TabIndex = 27
        Label1.Text = "Configuration Files"
        ' 
        ' lblStatus
        ' 
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(50, 20)
        lblStatus.Text = "Ready"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblStatus})
        StatusStrip1.Location = New Point(0, 758)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Padding = New Padding(1, 0, 16, 0)
        StatusStrip1.Size = New Size(744, 26)
        StatusStrip1.TabIndex = 37
        StatusStrip1.Text = "Ready"
        ' 
        ' lblRollingCache
        ' 
        lblRollingCache.AutoSize = True
        lblRollingCache.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblRollingCache.Location = New Point(71, 440)
        lblRollingCache.Name = "lblRollingCache"
        lblRollingCache.Size = New Size(132, 25)
        lblRollingCache.TabIndex = 38
        lblRollingCache.Text = "Rolling Cache"
        ' 
        ' lblSceneryIndexes
        ' 
        lblSceneryIndexes.AutoSize = True
        lblSceneryIndexes.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblSceneryIndexes.Location = New Point(71, 596)
        lblSceneryIndexes.Name = "lblSceneryIndexes"
        lblSceneryIndexes.Size = New Size(157, 25)
        lblSceneryIndexes.TabIndex = 39
        lblSceneryIndexes.Text = "Scenery Indexes"
        ' 
        ' btnBackupCamerasCfg
        ' 
        btnBackupCamerasCfg.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnBackupCamerasCfg.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnBackupCamerasCfg.Location = New Point(71, 324)
        btnBackupCamerasCfg.Margin = New Padding(3, 4, 3, 4)
        btnBackupCamerasCfg.Name = "btnBackupCamerasCfg"
        btnBackupCamerasCfg.Size = New Size(287, 63)
        btnBackupCamerasCfg.TabIndex = 24
        btnBackupCamerasCfg.Text = "&Backup Cameras.cfg"
        btnBackupCamerasCfg.UseVisualStyleBackColor = False
        ' 
        ' btnViewCamerasCfg
        ' 
        btnViewCamerasCfg.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnViewCamerasCfg.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnViewCamerasCfg.Location = New Point(71, 253)
        btnViewCamerasCfg.Margin = New Padding(3, 4, 3, 4)
        btnViewCamerasCfg.Name = "btnViewCamerasCfg"
        btnViewCamerasCfg.Size = New Size(287, 63)
        btnViewCamerasCfg.TabIndex = 26
        btnViewCamerasCfg.Text = "Vie&w Cameras.cfg"
        btnViewCamerasCfg.UseVisualStyleBackColor = False
        ' 
        ' btnViewExeXml
        ' 
        btnViewExeXml.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnViewExeXml.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnViewExeXml.Location = New Point(71, 84)
        btnViewExeXml.Margin = New Padding(3, 4, 3, 4)
        btnViewExeXml.Name = "btnViewExeXml"
        btnViewExeXml.Size = New Size(287, 63)
        btnViewExeXml.TabIndex = 25
        btnViewExeXml.Text = "&View EXE.xml"
        btnViewExeXml.UseVisualStyleBackColor = False
        ' 
        ' btnBackupXmlExe
        ' 
        btnBackupXmlExe.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnBackupXmlExe.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnBackupXmlExe.Location = New Point(71, 155)
        btnBackupXmlExe.Margin = New Padding(3, 4, 3, 4)
        btnBackupXmlExe.Name = "btnBackupXmlExe"
        btnBackupXmlExe.Size = New Size(287, 63)
        btnBackupXmlExe.TabIndex = 34
        btnBackupXmlExe.Text = "Bac&kup EXE.xml"
        btnBackupXmlExe.UseVisualStyleBackColor = False
        ' 
        ' btnViewFs2024Cfg
        ' 
        btnViewFs2024Cfg.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnViewFs2024Cfg.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnViewFs2024Cfg.Location = New Point(387, 84)
        btnViewFs2024Cfg.Name = "btnViewFs2024Cfg"
        btnViewFs2024Cfg.Size = New Size(287, 63)
        btnViewFs2024Cfg.TabIndex = 40
        btnViewFs2024Cfg.Text = "View &Flightsimulator2024.cfg"
        btnViewFs2024Cfg.UseVisualStyleBackColor = False
        ' 
        ' btnBackupFs2024Cfg
        ' 
        btnBackupFs2024Cfg.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnBackupFs2024Cfg.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnBackupFs2024Cfg.Location = New Point(387, 156)
        btnBackupFs2024Cfg.Name = "btnBackupFs2024Cfg"
        btnBackupFs2024Cfg.Size = New Size(287, 63)
        btnBackupFs2024Cfg.TabIndex = 41
        btnBackupFs2024Cfg.Text = "Bac&kup Flightsimulator2024.cfg"
        btnBackupFs2024Cfg.UseVisualStyleBackColor = False
        ' 
        ' FrmMaintenance
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(43), CByte(50), CByte(64))
        ClientSize = New Size(744, 784)
        Controls.Add(btnBackupFs2024Cfg)
        Controls.Add(btnViewFs2024Cfg)
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
        Margin = New Padding(3, 4, 3, 4)
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
    Friend WithEvents btnViewFs2024Cfg As Button
    Friend WithEvents btnBackupFs2024Cfg As Button
End Class
