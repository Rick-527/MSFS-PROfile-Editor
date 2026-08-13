<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcProfiles
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        flpProfiles = New FlowLayoutPanel()
        lblStatusCenter = New Label()
        pnlFooter = New Panel()
        btnSimLauncher2024 = New ModernSplitButton()
        btnViewUserCfg = New ModernSplitButton()
        pnlFooter.SuspendLayout()
        SuspendLayout()
        ' 
        ' flpProfiles
        ' 
        flpProfiles.AutoScroll = True
        flpProfiles.BackColor = Color.Transparent
        flpProfiles.Dock = DockStyle.Fill
        flpProfiles.Location = New Point(0, 0)
        flpProfiles.Name = "flpProfiles"
        flpProfiles.Padding = New Padding(16)
        flpProfiles.Size = New Size(620, 513)
        flpProfiles.TabIndex = 0
        ' 
        ' lblStatusCenter
        ' 
        lblStatusCenter.ForeColor = Color.White
        lblStatusCenter.Location = New Point(3, 5)
        lblStatusCenter.Name = "lblStatusCenter"
        lblStatusCenter.Size = New Size(250, 26)
        lblStatusCenter.TabIndex = 0
        lblStatusCenter.Text = "No saved profiles were found"
        lblStatusCenter.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlFooter
        ' 
        pnlFooter.Controls.Add(lblStatusCenter)
        pnlFooter.Controls.Add(btnSimLauncher2024)
        pnlFooter.Controls.Add(btnViewUserCfg)
        pnlFooter.Dock = DockStyle.Bottom
        pnlFooter.Location = New Point(0, 427)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(620, 86)
        pnlFooter.TabIndex = 0
        ' 
        ' btnSimLauncher2024
        ' 
        btnSimLauncher2024.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnSimLauncher2024.DropDownMenu = Nothing
        btnSimLauncher2024.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnSimLauncher2024.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnSimLauncher2024.FlatStyle = FlatStyle.Flat
        btnSimLauncher2024.Location = New Point(372, 34)
        btnSimLauncher2024.Name = "btnSimLauncher2024"
        btnSimLauncher2024.Size = New Size(240, 38)
        btnSimLauncher2024.TabIndex = 1
        btnSimLauncher2024.Text = "Launch MSFS 2024"
        btnSimLauncher2024.UseVisualStyleBackColor = True
        ' 
        ' btnViewUserCfg
        ' 
        btnViewUserCfg.DropDownMenu = Nothing
        btnViewUserCfg.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnViewUserCfg.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnViewUserCfg.FlatStyle = FlatStyle.Flat
        btnViewUserCfg.Location = New Point(0, 34)
        btnViewUserCfg.Name = "btnViewUserCfg"
        btnViewUserCfg.ShowSplit = False
        btnViewUserCfg.Size = New Size(172, 38)
        btnViewUserCfg.TabIndex = 2
        btnViewUserCfg.Text = "UserCfg.opt"
        btnViewUserCfg.UseVisualStyleBackColor = False
        ' 
        ' UcProfiles
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(pnlFooter)
        Controls.Add(flpProfiles)
        Name = "UcProfiles"
        Size = New Size(620, 513)
        pnlFooter.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents flpProfiles As FlowLayoutPanel
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents btnSimLauncher2024 As ModernSplitButton
    Friend WithEvents btnViewUserCfg As ModernSplitButton
    Friend WithEvents lblStatusCenter As Label

End Class
