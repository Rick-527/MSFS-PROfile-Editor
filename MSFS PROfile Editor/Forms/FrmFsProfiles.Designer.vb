<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFsProfiles
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
        components = New ComponentModel.Container()
        flpProfiles = New FlowLayoutPanel()
        pnlHeader = New Panel()
        lblProfileCount = New Label()
        lblPageDescription = New Label()
        lblPageTitle = New Label()
        btnClose = New Button()
        StatusStrip1 = New StatusStrip()
        lblStatus = New ToolStripStatusLabel()
        pnlFooter = New Panel()
        btnSetProfileFolder = New Button()
        btnMigrateProfiles = New Button()
        btnSimLauncher2024 = New ModernSplitButton()
        cmsSimLauncher2024 = New ContextMenuStrip(components)
        mnuLaunchNormal = New ToolStripMenuItem()
        mnuLaunchFsuipc = New ToolStripMenuItem()
        pnlHeader.SuspendLayout()
        StatusStrip1.SuspendLayout()
        pnlFooter.SuspendLayout()
        cmsSimLauncher2024.SuspendLayout()
        SuspendLayout()
        ' 
        ' flpProfiles
        ' 
        flpProfiles.AutoScroll = True
        flpProfiles.Dock = DockStyle.Fill
        flpProfiles.FlowDirection = FlowDirection.TopDown
        flpProfiles.Location = New Point(0, 90)
        flpProfiles.Name = "flpProfiles"
        flpProfiles.Padding = New Padding(10)
        flpProfiles.Size = New Size(1224, 491)
        flpProfiles.TabIndex = 0
        flpProfiles.WrapContents = False
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Controls.Add(lblProfileCount)
        pnlHeader.Controls.Add(lblPageDescription)
        pnlHeader.Controls.Add(lblPageTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1224, 90)
        pnlHeader.TabIndex = 16
        ' 
        ' lblProfileCount
        ' 
        lblProfileCount.AutoSize = True
        lblProfileCount.Location = New Point(335, 72)
        lblProfileCount.Name = "lblProfileCount"
        lblProfileCount.Size = New Size(120, 15)
        lblProfileCount.TabIndex = 16
        lblProfileCount.Text = "0 of 20 profiles stored"
        ' 
        ' lblPageDescription
        ' 
        lblPageDescription.AutoSize = True
        lblPageDescription.Location = New Point(353, 47)
        lblPageDescription.Name = "lblPageDescription"
        lblPageDescription.Size = New Size(93, 15)
        lblPageDescription.TabIndex = 15
        lblPageDescription.Text = "PageDescription"
        ' 
        ' lblPageTitle
        ' 
        lblPageTitle.AutoSize = True
        lblPageTitle.Location = New Point(372, 21)
        lblPageTitle.Name = "lblPageTitle"
        lblPageTitle.Size = New Size(56, 15)
        lblPageTitle.TabIndex = 14
        lblPageTitle.Text = "PageTitle"
        lblPageTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnClose.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnClose.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(1031, 8)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(172, 41)
        btnClose.TabIndex = 13
        btnClose.Text = "&Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblStatus})
        StatusStrip1.Location = New Point(0, 559)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(1224, 22)
        StatusStrip1.TabIndex = 17
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' lblStatus
        ' 
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(107, 17)
        lblStatus.Text = "No Profile Selected"
        ' 
        ' pnlFooter
        ' 
        pnlFooter.Controls.Add(btnSetProfileFolder)
        pnlFooter.Controls.Add(btnMigrateProfiles)
        pnlFooter.Controls.Add(btnSimLauncher2024)
        pnlFooter.Controls.Add(btnClose)
        pnlFooter.Dock = DockStyle.Bottom
        pnlFooter.Location = New Point(0, 499)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(1224, 60)
        pnlFooter.TabIndex = 18
        ' 
        ' btnSetProfileFolder
        ' 
        btnSetProfileFolder.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnSetProfileFolder.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSetProfileFolder.Location = New Point(643, 8)
        btnSetProfileFolder.Name = "btnSetProfileFolder"
        btnSetProfileFolder.Size = New Size(172, 41)
        btnSetProfileFolder.TabIndex = 16
        btnSetProfileFolder.Text = "Set Profile Folder"
        btnSetProfileFolder.UseVisualStyleBackColor = False
        ' 
        ' btnMigrateProfiles
        ' 
        btnMigrateProfiles.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnMigrateProfiles.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMigrateProfiles.Location = New Point(465, 8)
        btnMigrateProfiles.Name = "btnMigrateProfiles"
        btnMigrateProfiles.Size = New Size(172, 41)
        btnMigrateProfiles.TabIndex = 15
        btnMigrateProfiles.Text = "&Migrate Old Profiles"
        btnMigrateProfiles.UseVisualStyleBackColor = False
        ' 
        ' btnSimLauncher2024
        ' 
        btnSimLauncher2024.DropDownMenu = cmsSimLauncher2024
        btnSimLauncher2024.FlatStyle = FlatStyle.Flat
        btnSimLauncher2024.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimLauncher2024.Location = New Point(12, 8)
        btnSimLauncher2024.Name = "btnSimLauncher2024"
        btnSimLauncher2024.Size = New Size(268, 41)
        btnSimLauncher2024.TabIndex = 14
        btnSimLauncher2024.Text = "Launch Simulator"
        btnSimLauncher2024.UseVisualStyleBackColor = True
        ' 
        ' cmsSimLauncher2024
        ' 
        cmsSimLauncher2024.Items.AddRange(New ToolStripItem() {mnuLaunchNormal, mnuLaunchFsuipc})
        cmsSimLauncher2024.Name = "cmsLaunchSimulator"
        cmsSimLauncher2024.Size = New Size(205, 48)
        ' 
        ' mnuLaunchNormal
        ' 
        mnuLaunchNormal.Name = "mnuLaunchNormal"
        mnuLaunchNormal.Size = New Size(204, 22)
        mnuLaunchNormal.Text = "Launch MSFS Normally"
        ' 
        ' mnuLaunchFsuipc
        ' 
        mnuLaunchFsuipc.Name = "mnuLaunchFsuipc"
        mnuLaunchFsuipc.Size = New Size(204, 22)
        mnuLaunchFsuipc.Text = "Launch MSFS via FSUIPC"
        ' 
        ' FrmFsProfiles
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1224, 581)
        Controls.Add(pnlFooter)
        Controls.Add(StatusStrip1)
        Controls.Add(flpProfiles)
        Controls.Add(pnlHeader)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmFsProfiles"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "FrmFsProfiles"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        pnlFooter.ResumeLayout(False)
        cmsSimLauncher2024.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblPageTitle As Label
    Friend WithEvents lblPageDescription As Label
    Friend WithEvents flpProfiles As FlowLayoutPanel
    Friend WithEvents btnClose As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents btnSimLauncher2024 As ModernSplitButton
    Friend WithEvents cmsSimLauncher2024 As ContextMenuStrip
    Friend WithEvents mnuLaunchNormal As ToolStripMenuItem
    Friend WithEvents mnuLaunchFsuipc As ToolStripMenuItem
    Friend WithEvents btnMigrateProfiles As Button
    Friend WithEvents lblProfileCount As Label
    Friend WithEvents btnSetProfileFolder As Button

End Class
