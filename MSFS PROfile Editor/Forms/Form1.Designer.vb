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
        MenuStrip1 = New MenuStrip()
        mnuFile = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        mnuEditProfile = New ToolStripMenuItem()
        mnuSaveProfile = New ToolStripMenuItem()
        mnuExport = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        mnuMaintenance = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        mnuExitProgram = New ToolStripMenuItem()
        btnMaintenance = New Button()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnClose.Location = New Point(42, 469)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(429, 36)
        btnClose.TabIndex = 12
        btnClose.Text = "Close Program"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuFile})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(520, 24)
        MenuStrip1.TabIndex = 13
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuFile
        ' 
        mnuFile.DropDownItems.AddRange(New ToolStripItem() {ToolStripSeparator1, mnuEditProfile, mnuSaveProfile, mnuExport, ToolStripSeparator2, mnuMaintenance, ToolStripSeparator3, mnuExitProgram})
        mnuFile.Name = "mnuFile"
        mnuFile.Size = New Size(37, 20)
        mnuFile.Text = "&File"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(149, 6)
        ' 
        ' mnuEditProfile
        ' 
        mnuEditProfile.Name = "mnuEditProfile"
        mnuEditProfile.Size = New Size(152, 22)
        mnuEditProfile.Text = "&Edit Profile"
        ' 
        ' mnuSaveProfile
        ' 
        mnuSaveProfile.Name = "mnuSaveProfile"
        mnuSaveProfile.Size = New Size(152, 22)
        mnuSaveProfile.Text = "&Save Profile"
        ' 
        ' mnuExport
        ' 
        mnuExport.Name = "mnuExport"
        mnuExport.Size = New Size(152, 22)
        mnuExport.Text = "&Export"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(149, 6)
        ' 
        ' mnuMaintenance
        ' 
        mnuMaintenance.Name = "mnuMaintenance"
        mnuMaintenance.Size = New Size(152, 22)
        mnuMaintenance.Text = "&Maintenance..."
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(149, 6)
        ' 
        ' mnuExitProgram
        ' 
        mnuExitProgram.Name = "mnuExitProgram"
        mnuExitProgram.Size = New Size(152, 22)
        mnuExitProgram.Text = "E&xit Program"
        ' 
        ' btnMaintenance
        ' 
        btnMaintenance.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnMaintenance.Location = New Point(46, 252)
        btnMaintenance.Name = "btnMaintenance"
        btnMaintenance.Size = New Size(172, 41)
        btnMaintenance.TabIndex = 14
        btnMaintenance.Text = "Setup"
        btnMaintenance.UseVisualStyleBackColor = False
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(43), CByte(50), CByte(64))
        CancelButton = btnClose
        ClientSize = New Size(520, 541)
        Controls.Add(btnMaintenance)
        Controls.Add(btnClose)
        Controls.Add(MenuStrip1)
        ForeColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        FormBorderStyle = FormBorderStyle.FixedDialog
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MSFS PROfile Editor"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnClose As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuMaintenance As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuExitProgram As ToolStripMenuItem
    Friend WithEvents mnuEditProfile As ToolStripMenuItem
    Friend WithEvents mnuSaveProfile As ToolStripMenuItem
    Friend WithEvents mnuExport As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents btnMaintenance As Button

End Class
