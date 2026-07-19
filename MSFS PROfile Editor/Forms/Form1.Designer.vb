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
        btnProfileEditor = New Button()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnClose.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnClose.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(351, 371)
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
        btnMaintenance.Location = New Point(12, 113)
        btnMaintenance.Name = "btnMaintenance"
        btnMaintenance.Size = New Size(172, 41)
        btnMaintenance.TabIndex = 14
        btnMaintenance.Text = "MSFS File Maintenance"
        btnMaintenance.UseVisualStyleBackColor = False
        ' 
        ' btnProfileEditor
        ' 
        btnProfileEditor.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnProfileEditor.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnProfileEditor.Location = New Point(12, 49)
        btnProfileEditor.Name = "btnProfileEditor"
        btnProfileEditor.Size = New Size(172, 41)
        btnProfileEditor.TabIndex = 34
        btnProfileEditor.Text = "Profile Editor"
        btnProfileEditor.UseVisualStyleBackColor = False
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(43), CByte(50), CByte(64))
        CancelButton = btnClose
        ClientSize = New Size(535, 424)
        Controls.Add(btnProfileEditor)
        Controls.Add(btnMaintenance)
        Controls.Add(btnClose)
        ForeColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MSFS PROfile Editor"
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnClose As Button
    Friend WithEvents btnMaintenance As Button
    Friend WithEvents btnProfileEditor As Button

End Class
