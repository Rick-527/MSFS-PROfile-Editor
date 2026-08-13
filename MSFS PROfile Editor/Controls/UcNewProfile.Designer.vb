<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcNewProfile
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblProfileNameText = New Label()
        txtProfileName = New TextBox()
        btnCreate = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' lblProfileNameText
        ' 
        lblProfileNameText.AutoSize = True
        lblProfileNameText.Location = New Point(8, 20)
        lblProfileNameText.Name = "lblProfileNameText"
        lblProfileNameText.Size = New Size(79, 15)
        lblProfileNameText.Font = New Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblProfileNameText.TabIndex = 0
        lblProfileNameText.Text = "Profile Name:"
        ' 
        ' txtProfileName
        ' 
        txtProfileName.Location = New Point(11, 43)
        txtProfileName.Name = "txtProfileName"
        txtProfileName.Size = New Size(400, 27)
        txtProfileName.Font = New Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point)
        txtProfileName.TabIndex = 3
        ' 
        ' btnCreate
        ' 
        btnCreate.Location = New Point(11, 87)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(100, 34)
        btnCreate.TabIndex = 4
        btnCreate.Text = "C&reate"
        btnCreate.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(121, 87)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(100, 34)
        btnCancel.TabIndex = 5
        btnCancel.Text = "&Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' UcNewProfile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btnCancel)
        Controls.Add(btnCreate)
        Controls.Add(txtProfileName)
        Controls.Add(lblProfileNameText)
        Name = "UcNewProfile"
        Size = New Size(415, 287)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblProfileNameText As Label
    Friend WithEvents txtProfileName As TextBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnCancel As Button

End Class
