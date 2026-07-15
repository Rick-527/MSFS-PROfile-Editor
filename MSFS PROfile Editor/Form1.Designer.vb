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
        GroupBox2 = New GroupBox()
        lblFile1Path = New Label()
        btnSaveAs = New Button()
        btnViewFile1 = New Button()
        btnBrowse1 = New Button()
        Label1 = New Label()
        txtFile1 = New TextBox()
        GroupBox1 = New GroupBox()
        lblFile2Path = New Label()
        Label2 = New Label()
        btnViewFile2 = New Button()
        txtFile2 = New TextBox()
        btnBrowse2 = New Button()
        btnSwap = New Button()
        btnClose = New Button()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.White
        GroupBox2.Controls.Add(lblFile1Path)
        GroupBox2.Controls.Add(btnSaveAs)
        GroupBox2.Controls.Add(btnViewFile1)
        GroupBox2.Controls.Add(btnBrowse1)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(txtFile1)
        GroupBox2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(28, 23)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(429, 148)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Text = "File Selection 1"
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
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(lblFile2Path)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(btnViewFile2)
        GroupBox1.Controls.Add(txtFile2)
        GroupBox1.Controls.Add(btnBrowse2)
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(28, 196)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(429, 148)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "File Selection 2"
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
        btnClose.Location = New Point(28, 430)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(429, 36)
        btnClose.TabIndex = 12
        btnClose.Text = "Close Program"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(486, 477)
        Controls.Add(btnClose)
        Controls.Add(btnSwap)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Name = "Form1"
        Text = "Form1"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblFile1Path As Label
    Friend WithEvents btnSaveAs As Button
    Friend WithEvents btnViewFile1 As Button
    Friend WithEvents btnBrowse1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFile1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblFile2Path As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnViewFile2 As Button
    Friend WithEvents txtFile2 As TextBox
    Friend WithEvents btnBrowse2 As Button
    Friend WithEvents btnSwap As Button
    Friend WithEvents btnClose As Button

End Class
