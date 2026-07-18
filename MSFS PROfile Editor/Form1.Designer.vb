<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        gpbFile1 = New GroupBox()
        lblFile1Path = New Label()
        btnSaveAs = New Button()
        btnViewFile1 = New Button()
        btnBrowse1 = New Button()
        Label1 = New Label()
        txtFile1 = New TextBox()
        gpbFile2 = New GroupBox()
        lblFile2Path = New Label()
        Label2 = New Label()
        btnViewFile2 = New Button()
        txtFile2 = New TextBox()
        btnBrowse2 = New Button()
        btnSwap = New Button()
        btnClose = New Button()
        gpbFileCleanup = New GroupBox()
        btnDeleteRollingCache = New Button()
        btnDeleteSceneryIndex = New Button()
        lblRollingCache = New Label()
        lblSceneryIndex = New Label()
        gpbFile1.SuspendLayout()
        gpbFile2.SuspendLayout()
        gpbFileCleanup.SuspendLayout()
        SuspendLayout()
        ' 
        ' gpbFile1
        ' 
        gpbFile1.BackColor = Color.FromArgb(CByte(43), CByte(50), CByte(64))
        gpbFile1.Controls.Add(lblFile1Path)
        gpbFile1.Controls.Add(btnSaveAs)
        gpbFile1.Controls.Add(btnViewFile1)
        gpbFile1.Controls.Add(btnBrowse1)
        gpbFile1.Controls.Add(Label1)
        gpbFile1.Controls.Add(txtFile1)
        gpbFile1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gpbFile1.Location = New Point(15, 23)
        gpbFile1.Name = "gpbFile1"
        gpbFile1.Size = New Size(429, 148)
        gpbFile1.TabIndex = 11
        gpbFile1.TabStop = False
        gpbFile1.Text = "File Selection 1"
        ' 
        ' lblFile1Path
        ' 
        lblFile1Path.Location = New Point(11, 107)
        lblFile1Path.Name = "lblFile1Path"
        lblFile1Path.Size = New Size(400, 30)
        lblFile1Path.TabIndex = 8
        lblFile1Path.Text = "Label3"
        ' 
        ' btnSaveAs
        ' 
        btnSaveAs.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnSaveAs.FlatAppearance.BorderSize = 0
        btnSaveAs.FlatStyle = FlatStyle.Flat
        btnSaveAs.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSaveAs.ForeColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        btnSaveAs.Location = New Point(260, 69)
        btnSaveAs.Name = "btnSaveAs"
        btnSaveAs.Size = New Size(156, 29)
        btnSaveAs.TabIndex = 6
        btnSaveAs.Text = "Save File As..."
        btnSaveAs.UseVisualStyleBackColor = False
        ' 
        ' btnViewFile1
        ' 
        btnViewFile1.BackColor = Color.FromArgb(CByte(143), CByte(188), CByte(187))
        btnViewFile1.FlatAppearance.BorderSize = 0
        btnViewFile1.FlatStyle = FlatStyle.Flat
        btnViewFile1.Font = New Font("Segoe UI", 11.25F)
        btnViewFile1.Location = New Point(341, 34)
        btnViewFile1.Name = "btnViewFile1"
        btnViewFile1.Size = New Size(75, 29)
        btnViewFile1.TabIndex = 2
        btnViewFile1.Text = "View File"
        btnViewFile1.UseVisualStyleBackColor = False
        ' 
        ' btnBrowse1
        ' 
        btnBrowse1.BackColor = Color.FromArgb(CByte(143), CByte(188), CByte(187))
        btnBrowse1.FlatAppearance.BorderSize = 0
        btnBrowse1.FlatStyle = FlatStyle.Flat
        btnBrowse1.Font = New Font("Segoe UI", 11.25F)
        btnBrowse1.Location = New Point(260, 34)
        btnBrowse1.Name = "btnBrowse1"
        btnBrowse1.Size = New Size(75, 29)
        btnBrowse1.TabIndex = 1
        btnBrowse1.Text = "Browse..."
        btnBrowse1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F)
        Label1.Location = New Point(11, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 20)
        Label1.TabIndex = 1
        Label1.Text = "File 1:"
        ' 
        ' txtFile1
        ' 
        txtFile1.BackColor = Color.FromArgb(CByte(59), CByte(69), CByte(89))
        txtFile1.BorderStyle = BorderStyle.FixedSingle
        txtFile1.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFile1.ForeColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        txtFile1.Location = New Point(64, 38)
        txtFile1.Name = "txtFile1"
        txtFile1.ReadOnly = True
        txtFile1.Size = New Size(190, 21)
        txtFile1.TabIndex = 0
        ' 
        ' gpbFile2
        ' 
        gpbFile2.BackColor = Color.FromArgb(CByte(43), CByte(50), CByte(64))
        gpbFile2.Controls.Add(lblFile2Path)
        gpbFile2.Controls.Add(Label2)
        gpbFile2.Controls.Add(btnViewFile2)
        gpbFile2.Controls.Add(txtFile2)
        gpbFile2.Controls.Add(btnBrowse2)
        gpbFile2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gpbFile2.Location = New Point(15, 197)
        gpbFile2.Name = "gpbFile2"
        gpbFile2.Size = New Size(429, 148)
        gpbFile2.TabIndex = 10
        gpbFile2.TabStop = False
        gpbFile2.Text = "File Selection 2"
        ' 
        ' lblFile2Path
        ' 
        lblFile2Path.Location = New Point(11, 111)
        lblFile2Path.Name = "lblFile2Path"
        lblFile2Path.Size = New Size(400, 30)
        lblFile2Path.TabIndex = 10
        lblFile2Path.Text = "Label4"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F)
        Label2.Location = New Point(14, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 20)
        Label2.TabIndex = 3
        Label2.Text = "File 2:"
        ' 
        ' btnViewFile2
        ' 
        btnViewFile2.BackColor = Color.FromArgb(CByte(143), CByte(188), CByte(187))
        btnViewFile2.FlatAppearance.BorderSize = 0
        btnViewFile2.FlatStyle = FlatStyle.Flat
        btnViewFile2.Font = New Font("Segoe UI", 11.25F)
        btnViewFile2.ForeColor = SystemColors.ControlText
        btnViewFile2.Location = New Point(341, 33)
        btnViewFile2.Name = "btnViewFile2"
        btnViewFile2.Size = New Size(75, 29)
        btnViewFile2.TabIndex = 5
        btnViewFile2.Text = "View File"
        btnViewFile2.UseVisualStyleBackColor = False
        ' 
        ' txtFile2
        ' 
        txtFile2.BackColor = Color.FromArgb(CByte(59), CByte(69), CByte(89))
        txtFile2.BorderStyle = BorderStyle.FixedSingle
        txtFile2.ForeColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        txtFile2.Location = New Point(67, 37)
        txtFile2.Name = "txtFile2"
        txtFile2.ReadOnly = True
        txtFile2.Size = New Size(187, 23)
        txtFile2.TabIndex = 3
        ' 
        ' btnBrowse2
        ' 
        btnBrowse2.BackColor = Color.FromArgb(CByte(143), CByte(188), CByte(187))
        btnBrowse2.FlatAppearance.BorderSize = 0
        btnBrowse2.FlatStyle = FlatStyle.Flat
        btnBrowse2.Font = New Font("Segoe UI", 11.25F)
        btnBrowse2.Location = New Point(260, 33)
        btnBrowse2.Name = "btnBrowse2"
        btnBrowse2.Size = New Size(75, 29)
        btnBrowse2.TabIndex = 4
        btnBrowse2.Text = "Browse..."
        btnBrowse2.UseVisualStyleBackColor = False
        ' 
        ' btnSwap
        ' 
        btnSwap.BackColor = Color.DarkOrange
        btnSwap.FlatAppearance.BorderSize = 0
        btnSwap.FlatStyle = FlatStyle.Flat
        btnSwap.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSwap.Location = New Point(28, 361)
        btnSwap.Name = "btnSwap"
        btnSwap.Size = New Size(429, 36)
        btnSwap.TabIndex = 11
        btnSwap.Text = "OVERWRITE FILE 1 CONTENTS"
        btnSwap.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnClose.Location = New Point(28, 430)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(429, 36)
        btnClose.TabIndex = 12
        btnClose.Text = "Close Program"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' gpbFileCleanup
        ' 
        gpbFileCleanup.BackColor = Color.FromArgb(CByte(43), CByte(50), CByte(64))
        gpbFileCleanup.Controls.Add(btnDeleteRollingCache)
        gpbFileCleanup.Controls.Add(btnDeleteSceneryIndex)
        gpbFileCleanup.Controls.Add(lblRollingCache)
        gpbFileCleanup.Controls.Add(lblSceneryIndex)
        gpbFileCleanup.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gpbFileCleanup.Location = New Point(497, 30)
        gpbFileCleanup.Name = "gpbFileCleanup"
        gpbFileCleanup.Size = New Size(429, 315)
        gpbFileCleanup.TabIndex = 12
        gpbFileCleanup.TabStop = False
        gpbFileCleanup.Text = "File Cleanup"
        ' 
        ' btnDeleteRollingCache
        ' 
        btnDeleteRollingCache.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnDeleteRollingCache.Location = New Point(127, 133)
        btnDeleteRollingCache.Name = "btnDeleteRollingCache"
        btnDeleteRollingCache.Size = New Size(133, 41)
        btnDeleteRollingCache.TabIndex = 10
        btnDeleteRollingCache.Text = "Clear Contents"
        btnDeleteRollingCache.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteSceneryIndex
        ' 
        btnDeleteSceneryIndex.BackColor = Color.FromArgb(CByte(76), CByte(86), CByte(106))
        btnDeleteSceneryIndex.Location = New Point(127, 65)
        btnDeleteSceneryIndex.Name = "btnDeleteSceneryIndex"
        btnDeleteSceneryIndex.Size = New Size(133, 41)
        btnDeleteSceneryIndex.TabIndex = 9
        btnDeleteSceneryIndex.Text = "Clear Contents"
        btnDeleteSceneryIndex.UseVisualStyleBackColor = False
        ' 
        ' lblRollingCache
        ' 
        lblRollingCache.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRollingCache.ImageAlign = ContentAlignment.MiddleRight
        lblRollingCache.Location = New Point(21, 140)
        lblRollingCache.Name = "lblRollingCache"
        lblRollingCache.Size = New Size(100, 30)
        lblRollingCache.TabIndex = 8
        lblRollingCache.Text = "Rolling Cache"
        ' 
        ' lblSceneryIndex
        ' 
        lblSceneryIndex.AutoSize = True
        lblSceneryIndex.Font = New Font("Segoe UI", 11.25F)
        lblSceneryIndex.Location = New Point(21, 72)
        lblSceneryIndex.Name = "lblSceneryIndex"
        lblSceneryIndex.Size = New Size(100, 20)
        lblSceneryIndex.TabIndex = 1
        lblSceneryIndex.Text = "Scenery Index"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(43), CByte(50), CByte(64))
        ClientSize = New Size(938, 550)
        Controls.Add(gpbFileCleanup)
        Controls.Add(btnClose)
        Controls.Add(btnSwap)
        Controls.Add(gpbFile2)
        Controls.Add(gpbFile1)
        ForeColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        Name = "Form1"
        Text = "Form1"
        gpbFile1.ResumeLayout(False)
        gpbFile1.PerformLayout()
        gpbFile2.ResumeLayout(False)
        gpbFile2.PerformLayout()
        gpbFileCleanup.ResumeLayout(False)
        gpbFileCleanup.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents gpbFile1 As GroupBox
    Friend WithEvents lblFile1Path As Label
    Friend WithEvents btnSaveAs As Button
    Friend WithEvents btnViewFile1 As Button
    Friend WithEvents btnBrowse1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFile1 As TextBox
    Friend WithEvents gpbFile2 As GroupBox
    Friend WithEvents lblFile2Path As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnViewFile2 As Button
    Friend WithEvents txtFile2 As TextBox
    Friend WithEvents btnBrowse2 As Button
    Friend WithEvents btnSwap As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents gpbFileCleanup As GroupBox
    Friend WithEvents lblRollingCache As Label
    Friend WithEvents lblSceneryIndex As Label
    Friend WithEvents btnDeleteRollingCache As Button
    Friend WithEvents btnDeleteSceneryIndex As Button

End Class
