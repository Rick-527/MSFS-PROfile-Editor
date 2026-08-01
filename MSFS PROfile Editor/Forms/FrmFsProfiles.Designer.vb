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
        flpProfiles = New FlowLayoutPanel()
        pnlHeader = New Panel()
        lblPageDescription = New Label()
        lblPageTitle = New Label()
        btnClose = New Button()
        StatusStrip1 = New StatusStrip()
        lblStatus = New ToolStripStatusLabel()
        pnlFooter = New Panel()
        pnlHeader.SuspendLayout()
        StatusStrip1.SuspendLayout()
        pnlFooter.SuspendLayout()
        SuspendLayout()
        ' 
        ' flpProfiles
        ' 
        flpProfiles.AutoScroll = True
        flpProfiles.BorderStyle = BorderStyle.FixedSingle
        flpProfiles.Dock = DockStyle.Fill
        flpProfiles.FlowDirection = FlowDirection.TopDown
        flpProfiles.Location = New Point(0, 90)
        flpProfiles.Name = "flpProfiles"
        flpProfiles.Padding = New Padding(10)
        flpProfiles.Size = New Size(800, 391)
        flpProfiles.TabIndex = 0
        flpProfiles.WrapContents = False
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Controls.Add(lblPageDescription)
        pnlHeader.Controls.Add(lblPageTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(800, 90)
        pnlHeader.TabIndex = 16
        ' 
        ' lblPageDescription
        ' 
        lblPageDescription.AutoSize = True
        lblPageDescription.Location = New Point(353, 59)
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
        btnClose.Location = New Point(607, 8)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(172, 41)
        btnClose.TabIndex = 13
        btnClose.Text = "&Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblStatus})
        StatusStrip1.Location = New Point(0, 459)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 22)
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
        pnlFooter.Controls.Add(btnClose)
        pnlFooter.Dock = DockStyle.Bottom
        pnlFooter.Location = New Point(0, 399)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(800, 60)
        pnlFooter.TabIndex = 18
        ' 
        ' FrmFsProfiles
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 481)
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

End Class
