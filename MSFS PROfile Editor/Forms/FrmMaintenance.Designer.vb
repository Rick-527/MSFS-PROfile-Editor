<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMaintenance
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
        dlgOpenFile = New OpenFileDialog()
        btnClose = New Button()
        btnClearRollingCache = New Button()
        btnDeleteSceneryIndexes = New Button()
        btnRestoreBackup = New Button()
        btnViewXmlExe = New Button()
        Button5 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btnNewIndexesBackupPath = New Button()
        Button2 = New Button()
        grpSceneryIndexes = New GroupBox()
        grpSceneryIndexes.SuspendLayout()
        SuspendLayout()
        ' 
        ' dlgOpenFile
        ' 
        dlgOpenFile.Filter = """opt file|*.opt"""
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnClose.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnClose.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnClose.Location = New Point(715, 553)
        btnClose.Margin = New Padding(4, 3, 4, 3)
        btnClose.Name = "btnClose"
        btnClose.RightToLeft = RightToLeft.Yes
        btnClose.Size = New Size(172, 42)
        btnClose.TabIndex = 21
        btnClose.Text = "&Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnClearRollingCache
        ' 
        btnClearRollingCache.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnClearRollingCache.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnClearRollingCache.Location = New Point(518, 52)
        btnClearRollingCache.Name = "btnClearRollingCache"
        btnClearRollingCache.Size = New Size(186, 47)
        btnClearRollingCache.TabIndex = 22
        btnClearRollingCache.Text = "Clear &Rolling Cache"
        btnClearRollingCache.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteSceneryIndexes
        ' 
        btnDeleteSceneryIndexes.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnDeleteSceneryIndexes.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnDeleteSceneryIndexes.Location = New Point(18, 28)
        btnDeleteSceneryIndexes.Name = "btnDeleteSceneryIndexes"
        btnDeleteSceneryIndexes.Size = New Size(186, 47)
        btnDeleteSceneryIndexes.TabIndex = 23
        btnDeleteSceneryIndexes.Text = "Delete &Scenery Indexes"
        btnDeleteSceneryIndexes.UseVisualStyleBackColor = False
        ' 
        ' btnRestoreBackup
        ' 
        btnRestoreBackup.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnRestoreBackup.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnRestoreBackup.Location = New Point(518, 132)
        btnRestoreBackup.Name = "btnRestoreBackup"
        btnRestoreBackup.Size = New Size(186, 47)
        btnRestoreBackup.TabIndex = 24
        btnRestoreBackup.Text = "Restore &Backup File (UserCfg.opt)"
        btnRestoreBackup.UseVisualStyleBackColor = False
        ' 
        ' btnViewXmlExe
        ' 
        btnViewXmlExe.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnViewXmlExe.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnViewXmlExe.Location = New Point(518, 204)
        btnViewXmlExe.Name = "btnViewXmlExe"
        btnViewXmlExe.Size = New Size(186, 47)
        btnViewXmlExe.TabIndex = 25
        btnViewXmlExe.Text = "View/&Edit xml.exe"
        btnViewXmlExe.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        Button5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Button5.Location = New Point(518, 276)
        Button5.Name = "Button5"
        Button5.Size = New Size(186, 47)
        Button5.TabIndex = 26
        Button5.Text = "View/E&dit Cameras (cameras.exe)"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(786, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 27
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(794, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 28
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(797, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 29
        Label3.Text = "Label3"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(798, 173)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 30
        Label4.Text = "Label4"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(802, 223)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 15)
        Label5.TabIndex = 31
        Label5.Text = "Label5"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(805, 263)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 15)
        Label6.TabIndex = 32
        Label6.Text = "Label6"
        ' 
        ' btnNewIndexesBackupPath
        ' 
        btnNewIndexesBackupPath.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnNewIndexesBackupPath.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnNewIndexesBackupPath.Location = New Point(18, 94)
        btnNewIndexesBackupPath.Name = "btnNewIndexesBackupPath"
        btnNewIndexesBackupPath.Size = New Size(186, 47)
        btnNewIndexesBackupPath.TabIndex = 33
        btnNewIndexesBackupPath.Text = "&Change Backup Folder"
        btnNewIndexesBackupPath.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        Button2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Button2.Location = New Point(18, 160)
        Button2.Name = "Button2"
        Button2.Size = New Size(186, 47)
        Button2.TabIndex = 34
        Button2.Text = "&Restore Backup Files"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' grpSceneryIndexes
        ' 
        grpSceneryIndexes.Controls.Add(btnDeleteSceneryIndexes)
        grpSceneryIndexes.Controls.Add(Button2)
        grpSceneryIndexes.Controls.Add(btnNewIndexesBackupPath)
        grpSceneryIndexes.Location = New Point(205, 283)
        grpSceneryIndexes.Name = "grpSceneryIndexes"
        grpSceneryIndexes.Size = New Size(227, 244)
        grpSceneryIndexes.TabIndex = 35
        grpSceneryIndexes.TabStop = False
        ' 
        ' FrmMaintenance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(43), CByte(50), CByte(64))
        ClientSize = New Size(900, 607)
        Controls.Add(grpSceneryIndexes)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button5)
        Controls.Add(btnViewXmlExe)
        Controls.Add(btnRestoreBackup)
        Controls.Add(btnClearRollingCache)
        Controls.Add(btnClose)
        ForeColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmMaintenance"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "MSFS PROfile Editor - Maintenance Module"
        grpSceneryIndexes.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dlgOpenFile As OpenFileDialog
    Friend WithEvents btnClose As Button
    Friend WithEvents btnClearRollingCache As Button
    Friend WithEvents btnDeleteSceneryIndexes As Button
    Friend WithEvents btnRestoreBackup As Button
    Friend WithEvents btnViewXmlExe As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnNewIndexesBackupPath As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents grpSceneryIndexes As GroupBox
End Class
