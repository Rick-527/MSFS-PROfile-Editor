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
        StatusStrip1 = New StatusStrip()
        lblStatus = New ToolStripStatusLabel()
        lblPageTitle = New Label()
        btnProfileSelector = New Button()
        pnlHeader = New Panel()
        lblPageDescription = New Label()
        StatusStrip1.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnClose.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnClose.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(287, 289)
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
        btnMaintenance.Location = New Point(287, 130)
        btnMaintenance.Name = "btnMaintenance"
        btnMaintenance.Size = New Size(172, 41)
        btnMaintenance.TabIndex = 14
        btnMaintenance.Text = "MSFS File Maintenance"
        btnMaintenance.UseVisualStyleBackColor = False
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.BackColor = Color.FromArgb(CByte(43), CByte(50), CByte(64))
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblStatus})
        StatusStrip1.Location = New Point(0, 366)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(542, 22)
        StatusStrip1.TabIndex = 35
        StatusStrip1.Text = "MSFSVersion:"
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
        ' btnProfileSelector
        ' 
        btnProfileSelector.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnProfileSelector.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnProfileSelector.Location = New Point(86, 130)
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
        pnlHeader.Size = New Size(542, 90)
        pnlHeader.TabIndex = 39
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
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(43), CByte(50), CByte(64))
        CancelButton = btnClose
        ClientSize = New Size(542, 388)
        Controls.Add(pnlHeader)
        Controls.Add(btnProfileSelector)
        Controls.Add(StatusStrip1)
        Controls.Add(btnMaintenance)
        Controls.Add(btnClose)
        ForeColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MSFS PROfile Editor"
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnClose As Button
    Friend WithEvents btnMaintenance As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents lblPageTitle As Label
    Friend WithEvents btnProfileSelector As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblPageDescription As Label

End Class
