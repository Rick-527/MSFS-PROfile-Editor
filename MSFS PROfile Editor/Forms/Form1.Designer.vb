<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnClose = New Button()
        btnMaintenance = New Button()
        lblStatus = New ToolStripStatusLabel()
        lblPageTitle = New Label()
        lblPageDescription = New Label()
        btnProfileSelector = New Button()
        pnlHeader = New Panel()
        pnlBody = New Panel()
        pnlContent = New Panel()
        pnlSideMenu = New Panel()
        StatusStrip1 = New StatusStrip()
        btnMigrateProfiles = New Button()
        btnManageProfiles = New Button()
        btnCreateNewProfile = New Button()
        btnSetProfileFolder = New Button()
        pnlHeader.SuspendLayout()
        pnlBody.SuspendLayout()
        pnlSideMenu.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnClose.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnClose.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(11, 420)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(172, 41)
        btnClose.TabIndex = 12
        btnClose.Text = "Close Program"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnMaintenance
        ' 
        btnMaintenance.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnMaintenance.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMaintenance.Location = New Point(12, 317)
        btnMaintenance.Name = "btnMaintenance"
        btnMaintenance.Size = New Size(172, 41)
        btnMaintenance.TabIndex = 14
        btnMaintenance.Text = "MSFS File Maintenance"
        btnMaintenance.UseVisualStyleBackColor = False
        ' 
        ' lblStatus
        ' 
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(39, 17)
        lblStatus.Text = "Ready"
        ' 
        ' lblPageTitle
        ' 
        lblPageTitle.AutoSize = True
        lblPageTitle.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPageTitle.Location = New Point(134, 0)
        lblPageTitle.Name = "lblPageTitle"
        lblPageTitle.Size = New Size(275, 37)
        lblPageTitle.TabIndex = 36
        lblPageTitle.Text = "MSFS PROfile Editor"
        ' 
        ' lblPageDescription
        ' 
        lblPageDescription.AutoSize = True
        lblPageDescription.Location = New Point(236, 55)
        lblPageDescription.Name = "lblPageDescription"
        lblPageDescription.Size = New Size(41, 15)
        lblPageDescription.TabIndex = 37
        lblPageDescription.Text = "Label1"
        ' 
        ' btnProfileSelector
        ' 
        btnProfileSelector.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnProfileSelector.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnProfileSelector.Location = New Point(11, 6)
        btnProfileSelector.Name = "btnProfileSelector"
        btnProfileSelector.Size = New Size(172, 41)
        btnProfileSelector.TabIndex = 38
        btnProfileSelector.Text = "Profile &Manager"
        btnProfileSelector.UseVisualStyleBackColor = False
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Controls.Add(lblPageDescription)
        pnlHeader.Controls.Add(lblPageTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(900, 97)
        pnlHeader.TabIndex = 39
        ' 
        ' pnlBody
        ' 
        pnlBody.Controls.Add(pnlContent)
        pnlBody.Controls.Add(pnlSideMenu)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(0, 97)
        pnlBody.Name = "pnlBody"
        pnlBody.Size = New Size(900, 481)
        pnlBody.TabIndex = 40
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.Transparent
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(190, 0)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(710, 481)
        pnlContent.TabIndex = 42
        ' 
        ' pnlSideMenu
        ' 
        pnlSideMenu.Controls.Add(btnManageProfiles)
        pnlSideMenu.Controls.Add(btnCreateNewProfile)
        pnlSideMenu.Controls.Add(btnSetProfileFolder)
        pnlSideMenu.Controls.Add(btnMigrateProfiles)
        pnlSideMenu.Controls.Add(btnProfileSelector)
        pnlSideMenu.Controls.Add(btnMaintenance)
        pnlSideMenu.Controls.Add(btnClose)
        pnlSideMenu.Dock = DockStyle.Left
        pnlSideMenu.Location = New Point(0, 0)
        pnlSideMenu.Name = "pnlSideMenu"
        pnlSideMenu.Size = New Size(190, 481)
        pnlSideMenu.TabIndex = 41
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.BackColor = Color.FromArgb(CByte(43), CByte(50), CByte(64))
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblStatus})
        StatusStrip1.Location = New Point(0, 578)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(900, 22)
        StatusStrip1.TabIndex = 60
        StatusStrip1.Text = "MSFSVersion:"
        ' 
        ' btnMigrateProfiles
        ' 
        btnMigrateProfiles.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnMigrateProfiles.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMigrateProfiles.Location = New Point(11, 194)
        btnMigrateProfiles.Name = "btnMigrateProfiles"
        btnMigrateProfiles.Size = New Size(172, 41)
        btnMigrateProfiles.TabIndex = 39
        btnMigrateProfiles.Text = "&Migrate Old Profiles"
        btnMigrateProfiles.UseVisualStyleBackColor = False
        ' 
        ' btnManageProfiles
        ' 
        btnManageProfiles.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnManageProfiles.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnManageProfiles.Location = New Point(11, 100)
        btnManageProfiles.Name = "btnManageProfiles"
        btnManageProfiles.Size = New Size(172, 41)
        btnManageProfiles.TabIndex = 41
        btnManageProfiles.Text = "Manage P&rofiles"
        btnManageProfiles.UseVisualStyleBackColor = False
        ' 
        ' btnCreateNewProfile
        ' 
        btnCreateNewProfile.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnCreateNewProfile.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCreateNewProfile.Location = New Point(11, 53)
        btnCreateNewProfile.Name = "btnCreateNewProfile"
        btnCreateNewProfile.Size = New Size(172, 41)
        btnCreateNewProfile.TabIndex = 42
        btnCreateNewProfile.Text = "Ne&w Profile"
        btnCreateNewProfile.UseVisualStyleBackColor = False
        ' 
        ' btnSetProfileFolder
        ' 
        btnSetProfileFolder.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnSetProfileFolder.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSetProfileFolder.Location = New Point(11, 147)
        btnSetProfileFolder.Name = "btnSetProfileFolder"
        btnSetProfileFolder.Size = New Size(172, 41)
        btnSetProfileFolder.TabIndex = 40
        btnSetProfileFolder.Text = "&Set Profile Folder"
        btnSetProfileFolder.UseVisualStyleBackColor = False
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(43), CByte(50), CByte(64))
        CancelButton = btnClose
        ClientSize = New Size(900, 600)
        Controls.Add(pnlBody)
        Controls.Add(pnlHeader)
        Controls.Add(StatusStrip1)
        ForeColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MSFS PROfile Editor"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlBody.ResumeLayout(False)
        pnlSideMenu.ResumeLayout(False)
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnMaintenance As Button
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents lblPageTitle As Label
    Friend WithEvents btnProfileSelector As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlBody As Panel
    Friend WithEvents pnlSideMenu As Panel
    Friend WithEvents pnlContent As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblPageDescription As Label
    Friend WithEvents btnMigrateProfiles As Button
    Friend WithEvents btnManageProfiles As Button
    Friend WithEvents btnCreateNewProfile As Button
    Friend WithEvents btnSetProfileFolder As Button

End Class
