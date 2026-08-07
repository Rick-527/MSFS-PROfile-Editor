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
        btnViewUserCfg = New Button()
        lblPageDescription = New Label()
        lblPageTitle = New Label()
        btnClose = New Button()
        StatusStrip1 = New StatusStrip()
        lblStatus = New ToolStripStatusLabel()
        lblStatusCenter = New ToolStripStatusLabel()
        pnlFooter = New Panel()
        btnManageProfiles = New Button()
        btnMigrateProfiles = New Button()
        btnCreateNewProfile = New Button()
        btnSetProfileFolder = New Button()
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
        flpProfiles.Size = New Size(1357, 489)
        flpProfiles.TabIndex = 0
        flpProfiles.WrapContents = False
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Controls.Add(btnViewUserCfg)
        pnlHeader.Controls.Add(lblPageDescription)
        pnlHeader.Controls.Add(lblPageTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1357, 90)
        pnlHeader.TabIndex = 16
        ' 
        ' btnViewUserCfg
        ' 
        btnViewUserCfg.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnViewUserCfg.Location = New Point(18, 43)
        btnViewUserCfg.Name = "btnViewUserCfg"
        btnViewUserCfg.Size = New Size(172, 41)
        btnViewUserCfg.TabIndex = 16
        btnViewUserCfg.TabStop = False
        btnViewUserCfg.Text = "View &UserCfg.opt File"
        btnViewUserCfg.UseVisualStyleBackColor = True
        ' 
        ' lblPageDescription
        ' 
        lblPageDescription.Anchor = AnchorStyles.Top
        lblPageDescription.AutoSize = True
        lblPageDescription.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPageDescription.Location = New Point(632, 47)
        lblPageDescription.Name = "lblPageDescription"
        lblPageDescription.Size = New Size(103, 17)
        lblPageDescription.TabIndex = 15
        lblPageDescription.Text = "PageDescription"
        ' 
        ' lblPageTitle
        ' 
        lblPageTitle.Anchor = AnchorStyles.Top
        lblPageTitle.AutoSize = True
        lblPageTitle.Location = New Point(650, 21)
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
        btnClose.Location = New Point(1173, 8)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(172, 41)
        btnClose.TabIndex = 20
        btnClose.Text = "&Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblStatus, lblStatusCenter})
        StatusStrip1.Location = New Point(0, 557)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(1357, 22)
        StatusStrip1.TabIndex = 17
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' lblStatus
        ' 
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(107, 17)
        lblStatus.Text = "No Profile Selected"
        lblStatus.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblStatusCenter
        ' 
        lblStatusCenter.Name = "lblStatusCenter"
        lblStatusCenter.Size = New Size(1235, 17)
        lblStatusCenter.Spring = True
        lblStatusCenter.Text = "ToolStripStatusLabel1"
        ' 
        ' pnlFooter
        ' 
        pnlFooter.Controls.Add(btnManageProfiles)
        pnlFooter.Controls.Add(btnMigrateProfiles)
        pnlFooter.Controls.Add(btnCreateNewProfile)
        pnlFooter.Controls.Add(btnSetProfileFolder)
        pnlFooter.Controls.Add(btnSimLauncher2024)
        pnlFooter.Controls.Add(btnClose)
        pnlFooter.Dock = DockStyle.Bottom
        pnlFooter.Location = New Point(0, 497)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(1357, 60)
        pnlFooter.TabIndex = 18
        ' 
        ' btnManageProfiles
        ' 
        btnManageProfiles.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnManageProfiles.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnManageProfiles.Location = New Point(779, 8)
        btnManageProfiles.Name = "btnManageProfiles"
        btnManageProfiles.Size = New Size(172, 41)
        btnManageProfiles.TabIndex = 3
        btnManageProfiles.Text = "Manage P&rofiles"
        btnManageProfiles.UseVisualStyleBackColor = False
        ' 
        ' btnMigrateProfiles
        ' 
        btnMigrateProfiles.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnMigrateProfiles.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMigrateProfiles.Location = New Point(423, 8)
        btnMigrateProfiles.Name = "btnMigrateProfiles"
        btnMigrateProfiles.Size = New Size(172, 41)
        btnMigrateProfiles.TabIndex = 1
        btnMigrateProfiles.Text = "&Migrate Old Profiles"
        btnMigrateProfiles.UseVisualStyleBackColor = False
        ' 
        ' btnCreateNewProfile
        ' 
        btnCreateNewProfile.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnCreateNewProfile.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCreateNewProfile.Location = New Point(957, 8)
        btnCreateNewProfile.Name = "btnCreateNewProfile"
        btnCreateNewProfile.Size = New Size(172, 41)
        btnCreateNewProfile.TabIndex = 4
        btnCreateNewProfile.Text = "Ne&w Profile"
        btnCreateNewProfile.UseVisualStyleBackColor = False
        ' 
        ' btnSetProfileFolder
        ' 
        btnSetProfileFolder.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnSetProfileFolder.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSetProfileFolder.Location = New Point(601, 8)
        btnSetProfileFolder.Name = "btnSetProfileFolder"
        btnSetProfileFolder.Size = New Size(172, 41)
        btnSetProfileFolder.TabIndex = 2
        btnSetProfileFolder.Text = "&Set Profile Folder"
        btnSetProfileFolder.UseVisualStyleBackColor = False
        ' 
        ' btnSimLauncher2024
        ' 
        btnSimLauncher2024.DropDownMenu = cmsSimLauncher2024
        btnSimLauncher2024.FlatStyle = FlatStyle.Flat
        btnSimLauncher2024.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimLauncher2024.Location = New Point(18, 8)
        btnSimLauncher2024.Name = "btnSimLauncher2024"
        btnSimLauncher2024.Size = New Size(268, 41)
        btnSimLauncher2024.TabIndex = 0
        btnSimLauncher2024.Text = "&Launch Simulator"
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
        CancelButton = btnClose
        ClientSize = New Size(1357, 579)
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
    Friend WithEvents btnSetProfileFolder As Button
    Friend WithEvents btnCreateNewProfile As Button
    Friend WithEvents btnManageProfiles As Button
    Friend WithEvents lblStatusCenter As ToolStripStatusLabel
    Friend WithEvents btnViewUserCfg As Button

End Class
