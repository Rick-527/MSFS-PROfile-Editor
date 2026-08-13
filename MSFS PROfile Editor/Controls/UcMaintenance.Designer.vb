<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcMaintenance
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
        btnExeXml = New ModernSplitButton()
        btnCamerasCfg = New ModernSplitButton()
        btnFlightsimulator2024Cfg = New ModernSplitButton()
        btnRollingCache = New ModernSplitButton()
        btnSceneryIndexes = New ModernSplitButton()
        SuspendLayout()
        ' 
        ' btnExeXml
        ' 
        btnExeXml.DropDownMenu = Nothing
        btnExeXml.FlatStyle = FlatStyle.Flat
        btnExeXml.Location = New Point(8, 20)
        btnExeXml.Name = "btnExeXml"
        btnExeXml.Size = New Size(300, 42)
        btnExeXml.TabIndex = 1
        btnExeXml.Text = "EXE.xml"
        btnExeXml.UseVisualStyleBackColor = True
        ' 
        ' btnCamerasCfg
        ' 
        btnCamerasCfg.DropDownMenu = Nothing
        btnCamerasCfg.FlatStyle = FlatStyle.Flat
        btnCamerasCfg.Location = New Point(8, 84)
        btnCamerasCfg.Name = "btnCamerasCfg"
        btnCamerasCfg.Size = New Size(300, 42)
        btnCamerasCfg.TabIndex = 2
        btnCamerasCfg.Text = "Cameras.cfg"
        btnCamerasCfg.UseVisualStyleBackColor = True
        ' 
        ' btnFlightsimulator2024Cfg
        ' 
        btnFlightsimulator2024Cfg.DropDownMenu = Nothing
        btnFlightsimulator2024Cfg.FlatStyle = FlatStyle.Flat
        btnFlightsimulator2024Cfg.Location = New Point(8, 139)
        btnFlightsimulator2024Cfg.Name = "btnFlightsimulator2024Cfg"
        btnFlightsimulator2024Cfg.Size = New Size(300, 42)
        btnFlightsimulator2024Cfg.TabIndex = 3
        btnFlightsimulator2024Cfg.Text = "Flightsimulator2024.cfg"
        btnFlightsimulator2024Cfg.UseVisualStyleBackColor = True
        ' 
        ' btnRollingCache
        ' 
        btnRollingCache.DropDownMenu = Nothing
        btnRollingCache.FlatStyle = FlatStyle.Flat
        btnRollingCache.Location = New Point(8, 215)
        btnRollingCache.Name = "btnRollingCache"
        btnRollingCache.Size = New Size(300, 42)
        btnRollingCache.TabIndex = 4
        btnRollingCache.Text = "Rolling Cache"
        btnRollingCache.UseVisualStyleBackColor = True
        ' 
        ' btnSceneryIndexes
        ' 
        btnSceneryIndexes.DropDownMenu = Nothing
        btnSceneryIndexes.FlatStyle = FlatStyle.Flat
        btnSceneryIndexes.Location = New Point(8, 269)
        btnSceneryIndexes.Name = "btnSceneryIndexes"
        btnSceneryIndexes.Size = New Size(300, 42)
        btnSceneryIndexes.TabIndex = 5
        btnSceneryIndexes.Text = "SceneryIndexes"
        btnSceneryIndexes.UseVisualStyleBackColor = True
        ' 
        ' UcMaintenance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(btnSceneryIndexes)
        Controls.Add(btnRollingCache)
        Controls.Add(btnFlightsimulator2024Cfg)
        Controls.Add(btnCamerasCfg)
        Controls.Add(btnExeXml)
        Name = "UcMaintenance"
        Size = New Size(318, 449)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnExeXml As ModernSplitButton
    Friend WithEvents btnCamerasCfg As ModernSplitButton
    Friend WithEvents btnFlightsimulator2024Cfg As ModernSplitButton
    Friend WithEvents btnRollingCache As ModernSplitButton
    Friend WithEvents btnSceneryIndexes As ModernSplitButton

End Class
