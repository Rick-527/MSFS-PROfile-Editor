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
        SuspendLayout()
        ' 
        ' flpProfiles
        ' 
        flpProfiles.AutoScroll = True
        flpProfiles.Dock = DockStyle.Fill
        flpProfiles.FlowDirection = FlowDirection.TopDown
        flpProfiles.Location = New Point(0, 0)
        flpProfiles.Name = "flpProfiles"
        flpProfiles.Padding = New Padding(10)
        flpProfiles.Size = New Size(800, 450)
        flpProfiles.TabIndex = 0
        flpProfiles.WrapContents = False
        ' 
        ' FrmFsProfiles
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(flpProfiles)
        Name = "FrmFsProfiles"
        Text = "FrmFsProfiles"
        ResumeLayout(False)
    End Sub

    Friend WithEvents flpProfiles As FlowLayoutPanel
End Class
