<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSimulatorSelection
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
        btnOk = New Button()
        rbSteam = New RadioButton()
        rbStore = New RadioButton()
        btnCancel = New Button()
        lblMSFSVersion = New Label()
        grpMSVersions = New GroupBox()
        cbRememberChoice = New CheckBox()
        lblPromptMessage = New Label()
        grpMSVersions.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnOk
        ' 
        btnOk.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnOk.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnOk.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOk.ForeColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        btnOk.Location = New Point(315, 253)
        btnOk.Name = "btnOk"
        btnOk.Size = New Size(122, 36)
        btnOk.TabIndex = 0
        btnOk.Text = "&OK"
        btnOk.UseVisualStyleBackColor = False
        ' 
        ' rbSteam
        ' 
        rbSteam.AutoSize = True
        rbSteam.Location = New Point(6, 40)
        rbSteam.Name = "rbSteam"
        rbSteam.Size = New Size(66, 19)
        rbSteam.TabIndex = 1
        rbSteam.TabStop = True
        rbSteam.Text = "(Steam)"
        rbSteam.UseVisualStyleBackColor = True
        ' 
        ' rbStore
        ' 
        rbStore.AutoSize = True
        rbStore.Location = New Point(6, 65)
        rbStore.Name = "rbStore"
        rbStore.Size = New Size(80, 19)
        rbStore.TabIndex = 2
        rbStore.TabStop = True
        rbStore.Text = "(MS Store)"
        rbStore.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnCancel.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        btnCancel.Location = New Point(12, 248)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(131, 41)
        btnCancel.TabIndex = 15
        btnCancel.Text = "&Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' lblMSFSVersion
        ' 
        lblMSFSVersion.AutoSize = True
        lblMSFSVersion.Location = New Point(6, 22)
        lblMSFSVersion.Name = "lblMSFSVersion"
        lblMSFSVersion.Size = New Size(125, 15)
        lblMSFSVersion.TabIndex = 16
        lblMSFSVersion.Text = "Select Version of MSFS"
        ' 
        ' grpMSVersions
        ' 
        grpMSVersions.Controls.Add(cbRememberChoice)
        grpMSVersions.Controls.Add(rbSteam)
        grpMSVersions.Controls.Add(lblMSFSVersion)
        grpMSVersions.Controls.Add(rbStore)
        grpMSVersions.Location = New Point(12, 55)
        grpMSVersions.Name = "grpMSVersions"
        grpMSVersions.Size = New Size(270, 141)
        grpMSVersions.TabIndex = 17
        grpMSVersions.TabStop = False
        ' 
        ' cbRememberChoice
        ' 
        cbRememberChoice.AutoSize = True
        cbRememberChoice.Location = New Point(6, 116)
        cbRememberChoice.Name = "cbRememberChoice"
        cbRememberChoice.Size = New Size(122, 19)
        cbRememberChoice.TabIndex = 19
        cbRememberChoice.Text = "Remember choice"
        cbRememberChoice.UseVisualStyleBackColor = True
        ' 
        ' lblPromptMessage
        ' 
        lblPromptMessage.AutoSize = True
        lblPromptMessage.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPromptMessage.Location = New Point(18, 9)
        lblPromptMessage.Name = "lblPromptMessage"
        lblPromptMessage.Size = New Size(98, 20)
        lblPromptMessage.TabIndex = 18
        lblPromptMessage.Text = "Label Prompt"
        ' 
        ' FrmSimulatorSelection
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(43), CByte(50), CByte(64))
        CancelButton = btnCancel
        ClientSize = New Size(449, 301)
        Controls.Add(lblPromptMessage)
        Controls.Add(grpMSVersions)
        Controls.Add(btnCancel)
        Controls.Add(btnOk)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmSimulatorSelection"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "FrmSimulatorSelection"
        grpMSVersions.ResumeLayout(False)
        grpMSVersions.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnOk As Button
    Friend WithEvents rbSteam As RadioButton
    Friend WithEvents rbStore As RadioButton
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblMSFSVersion As Label
    Friend WithEvents grpMSVersions As GroupBox
    Friend WithEvents lblPromptMessage As Label
    Friend WithEvents cbRememberChoice As CheckBox
End Class
