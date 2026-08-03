<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNewSimulatorProfile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        btnCreate = New Button()
        btnCancel = New Button()
        txtProfileName = New TextBox()
        lblProfileNameText = New Label()
        pnlHeader = New Panel()
        lblPageDescription = New Label()
        lblPageTitle = New Label()
        StatusStrip1 = New StatusStrip()
        lblStatus = New ToolStripStatusLabel()
        pnlFooter = New Panel()
        pnlContent = New Panel()
        pnlHeader.SuspendLayout()
        StatusStrip1.SuspendLayout()
        pnlFooter.SuspendLayout()
        pnlContent.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnCreate
        ' 
        btnCreate.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnCreate.ForeColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        btnCreate.Location = New Point(12, 16)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(197, 46)
        btnCreate.TabIndex = 0
        btnCreate.Text = "Create"
        btnCreate.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnCancel.DialogResult = DialogResult.Cancel
        btnCancel.ForeColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        btnCancel.Location = New Point(215, 16)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(197, 46)
        btnCancel.TabIndex = 1
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' txtProfileName
        ' 
        txtProfileName.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtProfileName.Location = New Point(13, 45)
        txtProfileName.Name = "txtProfileName"
        txtProfileName.Size = New Size(399, 27)
        txtProfileName.TabIndex = 2
        ' 
        ' lblProfileNameText
        ' 
        lblProfileNameText.AutoSize = True
        lblProfileNameText.Location = New Point(13, 25)
        lblProfileNameText.Name = "lblProfileNameText"
        lblProfileNameText.Size = New Size(93, 17)
        lblProfileNameText.TabIndex = 3
        lblProfileNameText.Text = "Profile Name:"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Controls.Add(lblPageDescription)
        pnlHeader.Controls.Add(lblPageTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(432, 90)
        pnlHeader.TabIndex = 4
        ' 
        ' lblPageDescription
        ' 
        lblPageDescription.Anchor = AnchorStyles.Top
        lblPageDescription.AutoSize = True
        lblPageDescription.Location = New Point(74, 51)
        lblPageDescription.Name = "lblPageDescription"
        lblPageDescription.Size = New Size(284, 17)
        lblPageDescription.TabIndex = 1
        lblPageDescription.Text = "Enter the new profile name in the box below"
        lblPageDescription.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPageTitle
        ' 
        lblPageTitle.Anchor = AnchorStyles.Top
        lblPageTitle.AutoSize = True
        lblPageTitle.Location = New Point(150, 24)
        lblPageTitle.Name = "lblPageTitle"
        lblPageTitle.Size = New Size(132, 17)
        lblPageTitle.TabIndex = 0
        lblPageTitle.Text = "MSFS PROfile Editor"
        lblPageTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblStatus})
        StatusStrip1.Location = New Point(0, 260)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(432, 22)
        StatusStrip1.TabIndex = 5
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' lblStatus
        ' 
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(39, 17)
        lblStatus.Text = "Ready"
        ' 
        ' pnlFooter
        ' 
        pnlFooter.Controls.Add(btnCreate)
        pnlFooter.Controls.Add(btnCancel)
        pnlFooter.Dock = DockStyle.Bottom
        pnlFooter.Location = New Point(0, 180)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(432, 80)
        pnlFooter.TabIndex = 6
        ' 
        ' pnlContent
        ' 
        pnlContent.Controls.Add(txtProfileName)
        pnlContent.Controls.Add(lblProfileNameText)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(0, 90)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(432, 90)
        pnlContent.TabIndex = 7
        ' 
        ' FrmNewSimulatorProfile
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnCancel
        ClientSize = New Size(432, 282)
        Controls.Add(pnlContent)
        Controls.Add(pnlFooter)
        Controls.Add(StatusStrip1)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmNewSimulatorProfile"
        StartPosition = FormStartPosition.CenterParent
        Text = "FrmNewSimulatorProfile"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        pnlFooter.ResumeLayout(False)
        pnlContent.ResumeLayout(False)
        pnlContent.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCreate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtProfileName As TextBox
    Friend WithEvents lblProfileNameText As Label
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblPageDescription As Label
    Friend WithEvents lblPageTitle As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents pnlContent As Panel
End Class
