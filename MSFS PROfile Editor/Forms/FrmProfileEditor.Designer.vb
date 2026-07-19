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
        GroupBox1 = New GroupBox()
        btnBrowseProfileFolder = New Button()
        txtProfileFolder = New TextBox()
        lblFolderPathInstructions = New Label()
        lblProfileFolderPath = New Label()
        grpProfileEditor = New GroupBox()
        btnSwap = New Button()
        gpbFile2 = New GroupBox()
        lblSourceFilePath = New Label()
        lblSourceFileCaption = New Label()
        btnViewSourceFile = New Button()
        txtSourceFile = New TextBox()
        btnBrowseSourceFile = New Button()
        gpbFile1 = New GroupBox()
        lblDestinationFilePath = New Label()
        btnSaveAsCurrentProfile = New Button()
        btnViewDestinationFile = New Button()
        btnBrowseDestinationFile = New Button()
        lblUserCfgCaption = New Label()
        txtDestinationFile = New TextBox()
        btnClose = New Button()
        GroupBox1.SuspendLayout()
        grpProfileEditor.SuspendLayout()
        gpbFile2.SuspendLayout()
        gpbFile1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnBrowseProfileFolder)
        GroupBox1.Controls.Add(txtProfileFolder)
        GroupBox1.Controls.Add(lblFolderPathInstructions)
        GroupBox1.Controls.Add(lblProfileFolderPath)
        GroupBox1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(500, 66)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(455, 284)
        GroupBox1.TabIndex = 22
        GroupBox1.TabStop = False
        GroupBox1.Text = "PROfile Folder Selection"
        ' 
        ' btnBrowseProfileFolder
        ' 
        btnBrowseProfileFolder.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnBrowseProfileFolder.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnBrowseProfileFolder.Location = New Point(8, 198)
        btnBrowseProfileFolder.Margin = New Padding(4, 3, 4, 3)
        btnBrowseProfileFolder.Name = "btnBrowseProfileFolder"
        btnBrowseProfileFolder.Size = New Size(436, 42)
        btnBrowseProfileFolder.TabIndex = 8
        btnBrowseProfileFolder.Text = "Browse..."
        btnBrowseProfileFolder.UseVisualStyleBackColor = False
        ' 
        ' txtProfileFolder
        ' 
        txtProfileFolder.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtProfileFolder.Location = New Point(8, 166)
        txtProfileFolder.Margin = New Padding(4, 3, 4, 3)
        txtProfileFolder.Name = "txtProfileFolder"
        txtProfileFolder.ReadOnly = True
        txtProfileFolder.Size = New Size(436, 23)
        txtProfileFolder.TabIndex = 24
        txtProfileFolder.TabStop = False
        txtProfileFolder.Text = "Click the 'Browse' button to set the Profiles Folder"
        ' 
        ' lblFolderPathInstructions
        ' 
        lblFolderPathInstructions.Font = New Font("Segoe UI", 11.25F)
        lblFolderPathInstructions.Location = New Point(6, 33)
        lblFolderPathInstructions.Margin = New Padding(4, 0, 4, 0)
        lblFolderPathInstructions.Name = "lblFolderPathInstructions"
        lblFolderPathInstructions.Size = New Size(443, 82)
        lblFolderPathInstructions.TabIndex = 26
        lblFolderPathInstructions.Text = "Folder Instructions"
        ' 
        ' lblProfileFolderPath
        ' 
        lblProfileFolderPath.AutoSize = True
        lblProfileFolderPath.Font = New Font("Segoe UI", 11.25F)
        lblProfileFolderPath.Location = New Point(6, 143)
        lblProfileFolderPath.Margin = New Padding(4, 0, 4, 0)
        lblProfileFolderPath.Name = "lblProfileFolderPath"
        lblProfileFolderPath.Size = New Size(148, 20)
        lblProfileFolderPath.TabIndex = 25
        lblProfileFolderPath.Text = "Path to Profile Folder"
        lblProfileFolderPath.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' grpProfileEditor
        ' 
        grpProfileEditor.Controls.Add(btnSwap)
        grpProfileEditor.Controls.Add(gpbFile2)
        grpProfileEditor.Controls.Add(gpbFile1)
        grpProfileEditor.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grpProfileEditor.Location = New Point(12, 66)
        grpProfileEditor.Margin = New Padding(4, 3, 4, 3)
        grpProfileEditor.Name = "grpProfileEditor"
        grpProfileEditor.Padding = New Padding(4, 3, 4, 3)
        grpProfileEditor.Size = New Size(455, 438)
        grpProfileEditor.TabIndex = 21
        grpProfileEditor.TabStop = False
        grpProfileEditor.Text = "PROfile Editor"
        ' 
        ' btnSwap
        ' 
        btnSwap.BackColor = Color.DarkOrange
        btnSwap.FlatAppearance.BorderSize = 0
        btnSwap.FlatStyle = FlatStyle.Flat
        btnSwap.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSwap.Location = New Point(13, 385)
        btnSwap.Margin = New Padding(4, 3, 4, 3)
        btnSwap.Name = "btnSwap"
        btnSwap.Size = New Size(429, 36)
        btnSwap.TabIndex = 7
        btnSwap.Text = "UPDATE PROFILE [UserCfg.opt]"
        btnSwap.UseVisualStyleBackColor = False
        ' 
        ' gpbFile2
        ' 
        gpbFile2.BackColor = Color.FromArgb(CByte(43), CByte(50), CByte(64))
        gpbFile2.Controls.Add(lblSourceFilePath)
        gpbFile2.Controls.Add(lblSourceFileCaption)
        gpbFile2.Controls.Add(btnViewSourceFile)
        gpbFile2.Controls.Add(txtSourceFile)
        gpbFile2.Controls.Add(btnBrowseSourceFile)
        gpbFile2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gpbFile2.Location = New Point(13, 226)
        gpbFile2.Margin = New Padding(4, 3, 4, 3)
        gpbFile2.Name = "gpbFile2"
        gpbFile2.Padding = New Padding(4, 3, 4, 3)
        gpbFile2.Size = New Size(429, 148)
        gpbFile2.TabIndex = 27
        gpbFile2.TabStop = False
        ' 
        ' lblSourceFilePath
        ' 
        lblSourceFilePath.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSourceFilePath.Location = New Point(10, 85)
        lblSourceFilePath.Margin = New Padding(4, 0, 4, 0)
        lblSourceFilePath.Name = "lblSourceFilePath"
        lblSourceFilePath.Size = New Size(400, 30)
        lblSourceFilePath.TabIndex = 10
        ' 
        ' lblSourceFileCaption
        ' 
        lblSourceFileCaption.AutoSize = True
        lblSourceFileCaption.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSourceFileCaption.Location = New Point(36, 23)
        lblSourceFileCaption.Margin = New Padding(4, 0, 4, 0)
        lblSourceFileCaption.Name = "lblSourceFileCaption"
        lblSourceFileCaption.Size = New Size(98, 17)
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
        btnViewSourceFile.Location = New Point(313, 42)
        btnViewSourceFile.Margin = New Padding(4, 3, 4, 3)
        btnViewSourceFile.Name = "btnViewSourceFile"
        btnViewSourceFile.Size = New Size(75, 29)
        btnViewSourceFile.TabIndex = 6
        btnViewSourceFile.Text = "View File"
        btnViewSourceFile.UseVisualStyleBackColor = False
        ' 
        ' txtSourceFile
        ' 
        txtSourceFile.BackColor = Color.FromArgb(CByte(59), CByte(69), CByte(89))
        txtSourceFile.BorderStyle = BorderStyle.FixedSingle
        txtSourceFile.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSourceFile.ForeColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        txtSourceFile.Location = New Point(36, 46)
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
        btnBrowseSourceFile.Location = New Point(232, 42)
        btnBrowseSourceFile.Margin = New Padding(4, 3, 4, 3)
        btnBrowseSourceFile.Name = "btnBrowseSourceFile"
        btnBrowseSourceFile.Size = New Size(75, 29)
        btnBrowseSourceFile.TabIndex = 5
        btnBrowseSourceFile.Text = "Browse..."
        btnBrowseSourceFile.UseVisualStyleBackColor = False
        ' 
        ' gpbFile1
        ' 
        gpbFile1.BackColor = Color.FromArgb(CByte(43), CByte(50), CByte(64))
        gpbFile1.Controls.Add(lblDestinationFilePath)
        gpbFile1.Controls.Add(btnSaveAsCurrentProfile)
        gpbFile1.Controls.Add(btnViewDestinationFile)
        gpbFile1.Controls.Add(btnBrowseDestinationFile)
        gpbFile1.Controls.Add(lblUserCfgCaption)
        gpbFile1.Controls.Add(txtDestinationFile)
        gpbFile1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gpbFile1.Location = New Point(13, 30)
        gpbFile1.Margin = New Padding(4, 3, 4, 3)
        gpbFile1.Name = "gpbFile1"
        gpbFile1.Padding = New Padding(4, 3, 4, 3)
        gpbFile1.Size = New Size(429, 182)
        gpbFile1.TabIndex = 29
        gpbFile1.TabStop = False
        ' 
        ' lblDestinationFilePath
        ' 
        lblDestinationFilePath.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDestinationFilePath.Location = New Point(10, 130)
        lblDestinationFilePath.Margin = New Padding(4, 0, 4, 0)
        lblDestinationFilePath.Name = "lblDestinationFilePath"
        lblDestinationFilePath.Size = New Size(400, 30)
        lblDestinationFilePath.TabIndex = 8
        ' 
        ' btnSaveAsCurrentProfile
        ' 
        btnSaveAsCurrentProfile.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnSaveAsCurrentProfile.FlatAppearance.BorderSize = 0
        btnSaveAsCurrentProfile.FlatStyle = FlatStyle.Flat
        btnSaveAsCurrentProfile.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSaveAsCurrentProfile.ForeColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        btnSaveAsCurrentProfile.Location = New Point(36, 89)
        btnSaveAsCurrentProfile.Margin = New Padding(4, 3, 4, 3)
        btnSaveAsCurrentProfile.Name = "btnSaveAsCurrentProfile"
        btnSaveAsCurrentProfile.Size = New Size(352, 29)
        btnSaveAsCurrentProfile.TabIndex = 3
        btnSaveAsCurrentProfile.Text = "Save Current Profile As..."
        btnSaveAsCurrentProfile.UseVisualStyleBackColor = False
        ' 
        ' btnViewDestinationFile
        ' 
        btnViewDestinationFile.BackColor = Color.FromArgb(CByte(143), CByte(188), CByte(187))
        btnViewDestinationFile.FlatAppearance.BorderSize = 0
        btnViewDestinationFile.FlatStyle = FlatStyle.Flat
        btnViewDestinationFile.Font = New Font("Segoe UI", 11.25F)
        btnViewDestinationFile.Location = New Point(313, 42)
        btnViewDestinationFile.Margin = New Padding(4, 3, 4, 3)
        btnViewDestinationFile.Name = "btnViewDestinationFile"
        btnViewDestinationFile.Size = New Size(75, 29)
        btnViewDestinationFile.TabIndex = 2
        btnViewDestinationFile.Text = "View File"
        btnViewDestinationFile.UseVisualStyleBackColor = False
        ' 
        ' btnBrowseDestinationFile
        ' 
        btnBrowseDestinationFile.BackColor = Color.FromArgb(CByte(143), CByte(188), CByte(187))
        btnBrowseDestinationFile.FlatAppearance.BorderSize = 0
        btnBrowseDestinationFile.FlatStyle = FlatStyle.Flat
        btnBrowseDestinationFile.Font = New Font("Segoe UI", 11.25F)
        btnBrowseDestinationFile.Location = New Point(232, 42)
        btnBrowseDestinationFile.Margin = New Padding(4, 3, 4, 3)
        btnBrowseDestinationFile.Name = "btnBrowseDestinationFile"
        btnBrowseDestinationFile.Size = New Size(75, 29)
        btnBrowseDestinationFile.TabIndex = 1
        btnBrowseDestinationFile.Text = "Browse..."
        btnBrowseDestinationFile.UseVisualStyleBackColor = False
        ' 
        ' lblUserCfgCaption
        ' 
        lblUserCfgCaption.AutoSize = True
        lblUserCfgCaption.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUserCfgCaption.Location = New Point(36, 23)
        lblUserCfgCaption.Margin = New Padding(4, 0, 4, 0)
        lblUserCfgCaption.Name = "lblUserCfgCaption"
        lblUserCfgCaption.Size = New Size(101, 17)
        lblUserCfgCaption.TabIndex = 1
        lblUserCfgCaption.Text = "UserCfg.opt File"
        ' 
        ' txtDestinationFile
        ' 
        txtDestinationFile.BackColor = Color.FromArgb(CByte(59), CByte(69), CByte(89))
        txtDestinationFile.BorderStyle = BorderStyle.FixedSingle
        txtDestinationFile.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDestinationFile.ForeColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        txtDestinationFile.Location = New Point(36, 46)
        txtDestinationFile.Margin = New Padding(4, 3, 4, 3)
        txtDestinationFile.Name = "txtDestinationFile"
        txtDestinationFile.ReadOnly = True
        txtDestinationFile.Size = New Size(190, 25)
        txtDestinationFile.TabIndex = 0
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnClose.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnClose.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnClose.Location = New Point(803, 526)
        btnClose.Margin = New Padding(4, 3, 4, 3)
        btnClose.Name = "btnClose"
        btnClose.RightToLeft = RightToLeft.Yes
        btnClose.Size = New Size(172, 42)
        btnClose.TabIndex = 20
        btnClose.Text = "&Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' FrmProfileEditor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(43), CByte(50), CByte(64))
        CancelButton = btnClose
        ClientSize = New Size(987, 579)
        Controls.Add(btnClose)
        Controls.Add(GroupBox1)
        Controls.Add(grpProfileEditor)
        ForeColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmProfileEditor"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "MSFS PROfile Editor -Profile Editor Module"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        grpProfileEditor.ResumeLayout(False)
        gpbFile2.ResumeLayout(False)
        gpbFile2.PerformLayout()
        gpbFile1.ResumeLayout(False)
        gpbFile1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBrowseProfileFolder As Button
    Friend WithEvents txtProfileFolder As TextBox
    Friend WithEvents lblFolderPathInstructions As Label
    Friend WithEvents lblProfileFolderPath As Label
    Friend WithEvents grpProfileEditor As GroupBox
    Friend WithEvents btnSwap As Button
    Friend WithEvents gpbFile2 As GroupBox
    Friend WithEvents lblSourceFilePath As Label
    Friend WithEvents lblSourceFileCaption As Label
    Friend WithEvents btnViewSourceFile As Button
    Friend WithEvents txtSourceFile As TextBox
    Friend WithEvents btnBrowseSourceFile As Button
    Friend WithEvents gpbFile1 As GroupBox
    Friend WithEvents lblDestinationFilePath As Label
    Friend WithEvents btnSaveAsCurrentProfile As Button
    Friend WithEvents btnViewDestinationFile As Button
    Friend WithEvents btnBrowseDestinationFile As Button
    Friend WithEvents lblUserCfgCaption As Label
    Friend WithEvents txtDestinationFile As TextBox
    Friend WithEvents btnClose As Button
End Class
