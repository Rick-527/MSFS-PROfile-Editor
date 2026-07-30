<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProfileEditor
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
        btnSelectProfilesFolder = New Button()
        lblFolderPathInstructions = New Label()
        lblFolderSelection = New Label()
        btnUpdateCurrentProfile = New Button()
        lblSourceFileCaption = New Label()
        btnViewSourceFile = New Button()
        txtSourceFile = New TextBox()
        btnBrowseSourceFile = New Button()
        btnSaveAsCurrentProfile = New Button()
        btnViewDestinationFile = New Button()
        btnBrowseDestinationFile = New Button()
        lblUserCfgCaption = New Label()
        txtDestinationFile = New TextBox()
        btnClose = New Button()
        StatusStrip1 = New StatusStrip()
        lblStatus = New ToolStripStatusLabel()
        lblStatusCenter = New ToolStripStatusLabel()
        lblInfoRight = New ToolStripStatusLabel()
        lblProfilesFolderPath = New Label()
        lblProfileEditor = New Label()
        lblMsfsProfileFolder = New Label()
        btnLaunchSimulator = New Button()
        btnFs2024Launcher = New ModernSplitButton()
        cmsLaunchSimulator = New ContextMenuStrip(components)
        ToolStripMenuItem1 = New ToolStripMenuItem()
        LaunchViaFSUIPCToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1.SuspendLayout()
        cmsLaunchSimulator.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnSelectProfilesFolder
        ' 
        btnSelectProfilesFolder.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnSelectProfilesFolder.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnSelectProfilesFolder.Location = New Point(511, 268)
        btnSelectProfilesFolder.Margin = New Padding(4, 3, 4, 3)
        btnSelectProfilesFolder.Name = "btnSelectProfilesFolder"
        btnSelectProfilesFolder.Size = New Size(374, 46)
        btnSelectProfilesFolder.TabIndex = 8
        btnSelectProfilesFolder.Text = "Bro&wse"
        btnSelectProfilesFolder.UseVisualStyleBackColor = False
        ' 
        ' lblFolderPathInstructions
        ' 
        lblFolderPathInstructions.AutoSize = True
        lblFolderPathInstructions.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFolderPathInstructions.Location = New Point(511, 80)
        lblFolderPathInstructions.Margin = New Padding(4, 0, 4, 0)
        lblFolderPathInstructions.Name = "lblFolderPathInstructions"
        lblFolderPathInstructions.Size = New Size(115, 17)
        lblFolderPathInstructions.TabIndex = 26
        lblFolderPathInstructions.Text = "Folder Instructions"
        ' 
        ' lblFolderSelection
        ' 
        lblFolderSelection.AutoSize = True
        lblFolderSelection.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFolderSelection.Location = New Point(511, 37)
        lblFolderSelection.Margin = New Padding(4, 0, 4, 0)
        lblFolderSelection.Name = "lblFolderSelection"
        lblFolderSelection.Size = New Size(171, 30)
        lblFolderSelection.TabIndex = 25
        lblFolderSelection.Text = "Folder Selection"
        lblFolderSelection.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnUpdateCurrentProfile
        ' 
        btnUpdateCurrentProfile.BackColor = Color.DarkOrange
        btnUpdateCurrentProfile.FlatAppearance.BorderSize = 0
        btnUpdateCurrentProfile.FlatStyle = FlatStyle.Flat
        btnUpdateCurrentProfile.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdateCurrentProfile.Location = New Point(37, 268)
        btnUpdateCurrentProfile.Margin = New Padding(4, 3, 4, 3)
        btnUpdateCurrentProfile.Name = "btnUpdateCurrentProfile"
        btnUpdateCurrentProfile.Size = New Size(374, 46)
        btnUpdateCurrentProfile.TabIndex = 7
        btnUpdateCurrentProfile.Text = "&APPLY PROFILE"
        btnUpdateCurrentProfile.UseVisualStyleBackColor = False
        ' 
        ' lblSourceFileCaption
        ' 
        lblSourceFileCaption.AutoSize = True
        lblSourceFileCaption.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lblSourceFileCaption.Location = New Point(37, 200)
        lblSourceFileCaption.Margin = New Padding(4, 0, 4, 0)
        lblSourceFileCaption.Name = "lblSourceFileCaption"
        lblSourceFileCaption.Size = New Size(104, 17)
        lblSourceFileCaption.TabIndex = 3
        lblSourceFileCaption.Text = "Selected Profile"
        ' 
        ' btnViewSourceFile
        ' 
        btnViewSourceFile.BackColor = Color.FromArgb(CByte(143), CByte(188), CByte(187))
        btnViewSourceFile.FlatAppearance.BorderSize = 0
        btnViewSourceFile.FlatStyle = FlatStyle.Flat
        btnViewSourceFile.Font = New Font("Segoe UI", 11.25F)
        btnViewSourceFile.ForeColor = SystemColors.ControlText
        btnViewSourceFile.Location = New Point(314, 219)
        btnViewSourceFile.Margin = New Padding(4, 3, 4, 3)
        btnViewSourceFile.Name = "btnViewSourceFile"
        btnViewSourceFile.Size = New Size(97, 29)
        btnViewSourceFile.TabIndex = 6
        btnViewSourceFile.Text = "O&pen"
        btnViewSourceFile.UseVisualStyleBackColor = False
        ' 
        ' txtSourceFile
        ' 
        txtSourceFile.BackColor = Color.FromArgb(CByte(59), CByte(69), CByte(89))
        txtSourceFile.BorderStyle = BorderStyle.FixedSingle
        txtSourceFile.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSourceFile.ForeColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        txtSourceFile.Location = New Point(37, 223)
        txtSourceFile.Margin = New Padding(4, 3, 4, 3)
        txtSourceFile.Name = "txtSourceFile"
        txtSourceFile.ReadOnly = True
        txtSourceFile.Size = New Size(190, 25)
        txtSourceFile.TabIndex = 4
        ' 
        ' btnBrowseSourceFile
        ' 
        btnBrowseSourceFile.BackColor = Color.FromArgb(CByte(143), CByte(188), CByte(187))
        btnBrowseSourceFile.FlatAppearance.BorderSize = 0
        btnBrowseSourceFile.FlatStyle = FlatStyle.Flat
        btnBrowseSourceFile.Font = New Font("Segoe UI", 11.25F)
        btnBrowseSourceFile.Location = New Point(233, 219)
        btnBrowseSourceFile.Margin = New Padding(4, 3, 4, 3)
        btnBrowseSourceFile.Name = "btnBrowseSourceFile"
        btnBrowseSourceFile.Size = New Size(75, 29)
        btnBrowseSourceFile.TabIndex = 5
        btnBrowseSourceFile.Text = "Brow&se"
        btnBrowseSourceFile.UseVisualStyleBackColor = False
        ' 
        ' btnSaveAsCurrentProfile
        ' 
        btnSaveAsCurrentProfile.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnSaveAsCurrentProfile.FlatAppearance.BorderSize = 0
        btnSaveAsCurrentProfile.FlatStyle = FlatStyle.Flat
        btnSaveAsCurrentProfile.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSaveAsCurrentProfile.ForeColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        btnSaveAsCurrentProfile.Location = New Point(37, 149)
        btnSaveAsCurrentProfile.Margin = New Padding(4, 3, 4, 3)
        btnSaveAsCurrentProfile.Name = "btnSaveAsCurrentProfile"
        btnSaveAsCurrentProfile.Size = New Size(374, 29)
        btnSaveAsCurrentProfile.TabIndex = 3
        btnSaveAsCurrentProfile.Text = "Create Pro&file..."
        btnSaveAsCurrentProfile.UseVisualStyleBackColor = False
        ' 
        ' btnViewDestinationFile
        ' 
        btnViewDestinationFile.BackColor = Color.FromArgb(CByte(143), CByte(188), CByte(187))
        btnViewDestinationFile.FlatAppearance.BorderSize = 0
        btnViewDestinationFile.FlatStyle = FlatStyle.Flat
        btnViewDestinationFile.Font = New Font("Segoe UI", 11.25F)
        btnViewDestinationFile.Location = New Point(314, 108)
        btnViewDestinationFile.Margin = New Padding(4, 3, 4, 3)
        btnViewDestinationFile.Name = "btnViewDestinationFile"
        btnViewDestinationFile.Size = New Size(97, 29)
        btnViewDestinationFile.TabIndex = 2
        btnViewDestinationFile.Text = "Ope&n"
        btnViewDestinationFile.UseVisualStyleBackColor = False
        ' 
        ' btnBrowseDestinationFile
        ' 
        btnBrowseDestinationFile.BackColor = Color.FromArgb(CByte(143), CByte(188), CByte(187))
        btnBrowseDestinationFile.FlatAppearance.BorderSize = 0
        btnBrowseDestinationFile.FlatStyle = FlatStyle.Flat
        btnBrowseDestinationFile.Font = New Font("Segoe UI", 11.25F)
        btnBrowseDestinationFile.Location = New Point(233, 108)
        btnBrowseDestinationFile.Margin = New Padding(4, 3, 4, 3)
        btnBrowseDestinationFile.Name = "btnBrowseDestinationFile"
        btnBrowseDestinationFile.Size = New Size(75, 29)
        btnBrowseDestinationFile.TabIndex = 1
        btnBrowseDestinationFile.Text = "&Browse"
        btnBrowseDestinationFile.UseVisualStyleBackColor = False
        ' 
        ' lblUserCfgCaption
        ' 
        lblUserCfgCaption.AutoSize = True
        lblUserCfgCaption.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lblUserCfgCaption.Location = New Point(37, 90)
        lblUserCfgCaption.Margin = New Padding(4, 0, 4, 0)
        lblUserCfgCaption.Name = "lblUserCfgCaption"
        lblUserCfgCaption.Size = New Size(107, 17)
        lblUserCfgCaption.TabIndex = 1
        lblUserCfgCaption.Text = "UserCfg.opt File"
        ' 
        ' txtDestinationFile
        ' 
        txtDestinationFile.BackColor = Color.FromArgb(CByte(59), CByte(69), CByte(89))
        txtDestinationFile.BorderStyle = BorderStyle.FixedSingle
        txtDestinationFile.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDestinationFile.ForeColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        txtDestinationFile.Location = New Point(37, 112)
        txtDestinationFile.Margin = New Padding(4, 3, 4, 3)
        txtDestinationFile.Name = "txtDestinationFile"
        txtDestinationFile.ReadOnly = True
        txtDestinationFile.Size = New Size(190, 25)
        txtDestinationFile.TabIndex = 0
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnClose.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnClose.Location = New Point(713, 354)
        btnClose.Margin = New Padding(4, 3, 4, 3)
        btnClose.Name = "btnClose"
        btnClose.RightToLeft = RightToLeft.Yes
        btnClose.Size = New Size(172, 46)
        btnClose.TabIndex = 20
        btnClose.Text = "&Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblStatus, lblStatusCenter, lblInfoRight})
        StatusStrip1.Location = New Point(0, 425)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(910, 22)
        StatusStrip1.TabIndex = 23
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' lblStatus
        ' 
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(39, 17)
        lblStatus.Text = "Ready"
        lblStatus.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblStatusCenter
        ' 
        lblStatusCenter.Name = "lblStatusCenter"
        lblStatusCenter.Size = New Size(810, 17)
        lblStatusCenter.Spring = True
        lblStatusCenter.Text = "Current Status"
        ' 
        ' lblInfoRight
        ' 
        lblInfoRight.Name = "lblInfoRight"
        lblInfoRight.Size = New Size(46, 17)
        lblInfoRight.Text = "Not Set"
        lblInfoRight.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblProfilesFolderPath
        ' 
        lblProfilesFolderPath.AutoSize = True
        lblProfilesFolderPath.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblProfilesFolderPath.Location = New Point(656, 247)
        lblProfilesFolderPath.Name = "lblProfilesFolderPath"
        lblProfilesFolderPath.Size = New Size(116, 15)
        lblProfilesFolderPath.TabIndex = 27
        lblProfilesFolderPath.Text = "lblProfilesFolderPath"
        ' 
        ' lblProfileEditor
        ' 
        lblProfileEditor.AutoSize = True
        lblProfileEditor.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProfileEditor.Location = New Point(37, 37)
        lblProfileEditor.Margin = New Padding(4, 0, 4, 0)
        lblProfileEditor.Name = "lblProfileEditor"
        lblProfileEditor.Size = New Size(143, 30)
        lblProfileEditor.TabIndex = 28
        lblProfileEditor.Text = "Profile Editor"
        lblProfileEditor.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblMsfsProfileFolder
        ' 
        lblMsfsProfileFolder.AutoSize = True
        lblMsfsProfileFolder.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMsfsProfileFolder.Location = New Point(511, 245)
        lblMsfsProfileFolder.Name = "lblMsfsProfileFolder"
        lblMsfsProfileFolder.Size = New Size(147, 17)
        lblMsfsProfileFolder.TabIndex = 29
        lblMsfsProfileFolder.Text = "Current Profile Folder:"
        ' 
        ' btnLaunchSimulator
        ' 
        btnLaunchSimulator.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnLaunchSimulator.FlatStyle = FlatStyle.Flat
        btnLaunchSimulator.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnLaunchSimulator.Location = New Point(37, 354)
        btnLaunchSimulator.Margin = New Padding(4, 3, 4, 3)
        btnLaunchSimulator.Name = "btnLaunchSimulator"
        btnLaunchSimulator.Size = New Size(374, 46)
        btnLaunchSimulator.TabIndex = 9
        btnLaunchSimulator.Text = "&Launch Simulator"
        btnLaunchSimulator.UseVisualStyleBackColor = False
        ' 
        ' btnFs2024Launcher
        ' 
        btnFs2024Launcher.DropDownMenu = cmsLaunchSimulator
        btnFs2024Launcher.FlatStyle = FlatStyle.Flat
        btnFs2024Launcher.Location = New Point(511, 140)
        btnFs2024Launcher.Name = "btnFs2024Launcher"
        btnFs2024Launcher.Size = New Size(365, 48)
        btnFs2024Launcher.TabIndex = 31
        btnFs2024Launcher.Text = "Launch Simulator via FSUIPC"
        btnFs2024Launcher.TextAlign = ContentAlignment.MiddleLeft
        btnFs2024Launcher.UseVisualStyleBackColor = True
        ' 
        ' cmsLaunchSimulator
        ' 
        cmsLaunchSimulator.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1})
        cmsLaunchSimulator.Name = "cmsLaunchSimulator"
        cmsLaunchSimulator.Size = New Size(236, 26)
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(235, 22)
        ToolStripMenuItem1.Text = "Launch Simulator - No FSUIPC"
        ' 
        ' LaunchViaFSUIPCToolStripMenuItem
        ' 
        LaunchViaFSUIPCToolStripMenuItem.Name = "LaunchViaFSUIPCToolStripMenuItem"
        LaunchViaFSUIPCToolStripMenuItem.Size = New Size(235, 22)
        LaunchViaFSUIPCToolStripMenuItem.Text = "Launch Simulator via FSUIPC"
        ' 
        ' FrmProfileEditor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(43), CByte(50), CByte(64))
        CancelButton = btnClose
        ClientSize = New Size(910, 447)
        Controls.Add(btnFs2024Launcher)
        Controls.Add(btnLaunchSimulator)
        Controls.Add(lblMsfsProfileFolder)
        Controls.Add(lblProfileEditor)
        Controls.Add(lblSourceFileCaption)
        Controls.Add(btnUpdateCurrentProfile)
        Controls.Add(btnViewSourceFile)
        Controls.Add(btnSaveAsCurrentProfile)
        Controls.Add(txtSourceFile)
        Controls.Add(btnBrowseSourceFile)
        Controls.Add(lblProfilesFolderPath)
        Controls.Add(btnViewDestinationFile)
        Controls.Add(btnSelectProfilesFolder)
        Controls.Add(btnBrowseDestinationFile)
        Controls.Add(txtDestinationFile)
        Controls.Add(StatusStrip1)
        Controls.Add(btnClose)
        Controls.Add(lblUserCfgCaption)
        Controls.Add(lblFolderSelection)
        Controls.Add(lblFolderPathInstructions)
        ForeColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmProfileEditor"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "MSFS PROfile Editor -Profile Editor"
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        cmsLaunchSimulator.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnSelectProfilesFolder As Button
    Friend WithEvents lblFolderPathInstructions As Label
    Friend WithEvents lblFolderSelection As Label
    Friend WithEvents btnUpdateCurrentProfile As Button
    Friend WithEvents lblSourceFilePath As Label
    Friend WithEvents lblSourceFileCaption As Label
    Friend WithEvents btnViewSourceFile As Button
    Friend WithEvents txtSourceFile As TextBox
    Friend WithEvents btnBrowseSourceFile As Button
    Friend WithEvents btnSaveAsCurrentProfile As Button
    Friend WithEvents btnViewDestinationFile As Button
    Friend WithEvents btnBrowseDestinationFile As Button
    Friend WithEvents lblUserCfgCaption As Label
    Friend WithEvents txtDestinationFile As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents lblProfilesFolderPath As Label
    Friend WithEvents lblProfileEditor As Label
    Friend WithEvents lblMsfsProfileFolder As Label
    Friend WithEvents btnLaunchSimulator As Button
    Friend WithEvents lblStatusCenter As ToolStripStatusLabel
    Friend WithEvents lblInfoRight As ToolStripStatusLabel
    Friend WithEvents btnFs2024Launcher As ModernSplitButton
    Friend WithEvents cmsLaunchSimulator As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LaunchViaFSUIPCToolStripMenuItem As ToolStripMenuItem
End Class
