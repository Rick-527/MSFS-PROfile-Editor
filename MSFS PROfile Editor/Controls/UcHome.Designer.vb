<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcHome
    Inherits System.Windows.Forms.UserControl

    Private components As System.ComponentModel.IContainer

    Protected Overrides Sub Dispose(disposing As Boolean)

        If disposing AndAlso
            components IsNot Nothing Then

            components.Dispose()

        End If

        MyBase.Dispose(disposing)

    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()

        pnlWelcome = New Panel()
        lblWelcomeTitle = New Label()
        lblWelcomeDescription = New Label()

        pnlProfilesCard = New Panel()
        lblProfilesTitle = New Label()
        lblProfilesDescription = New Label()
        btnManageProfiles = New Button()

        pnlMaintenanceCard = New Panel()
        lblMaintenanceTitle = New Label()
        lblMaintenanceDescription = New Label()
        btnMaintenance = New Button()

        pnlSimulatorCard = New Panel()
        lblSimulatorTitle = New Label()
        lblSimulatorValue = New Label()
        lblSimulatorStatus = New Label()

        pnlQuickStart = New Panel()
        lblQuickStartTitle = New Label()
        lblQuickStartText = New Label()

        pnlWelcome.SuspendLayout()
        pnlProfilesCard.SuspendLayout()
        pnlMaintenanceCard.SuspendLayout()
        pnlSimulatorCard.SuspendLayout()
        pnlQuickStart.SuspendLayout()
        SuspendLayout()

        '
        ' pnlWelcome
        '
        pnlWelcome.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        pnlWelcome.BackColor =
            Color.FromArgb(47, 58, 72)

        pnlWelcome.Controls.Add(lblWelcomeTitle)
        pnlWelcome.Controls.Add(lblWelcomeDescription)

        pnlWelcome.Location =
            New Point(35, 18)

        pnlWelcome.Name =
            "pnlWelcome"

        pnlWelcome.Size =
            New Size(630, 100)

        pnlWelcome.TabIndex = 0

        '
        ' lblWelcomeTitle
        '
        lblWelcomeTitle.AutoSize = True

        lblWelcomeTitle.Font =
            New Font(
                "Segoe UI",
                18.0F,
                FontStyle.Bold,
                GraphicsUnit.Point)

        lblWelcomeTitle.ForeColor =
            Color.White

        lblWelcomeTitle.Location =
            New Point(22, 16)

        lblWelcomeTitle.Name =
            "lblWelcomeTitle"

        lblWelcomeTitle.Size =
            New Size(360, 32)

        lblWelcomeTitle.TabIndex = 0

        lblWelcomeTitle.Text =
            "Microsoft Flight Simulator 2024"

        '
        ' lblWelcomeDescription
        '
        lblWelcomeDescription.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        lblWelcomeDescription.Font =
            New Font(
                "Segoe UI",
                10.0F,
                FontStyle.Regular,
                GraphicsUnit.Point)

        lblWelcomeDescription.ForeColor =
            Color.Gainsboro

        lblWelcomeDescription.Location =
            New Point(25, 55)

        lblWelcomeDescription.Name =
            "lblWelcomeDescription"

        lblWelcomeDescription.Size =
            New Size(580, 28)

        lblWelcomeDescription.TabIndex = 1

        lblWelcomeDescription.Text =
            "Quick access to your PROfiles, configuration files, and simulator maintenance tools."

        '
        ' pnlProfilesCard
        '
        pnlProfilesCard.BackColor =
            Color.FromArgb(47, 58, 72)

        pnlProfilesCard.Controls.Add(lblProfilesTitle)
        pnlProfilesCard.Controls.Add(lblProfilesDescription)
        pnlProfilesCard.Controls.Add(btnManageProfiles)

        pnlProfilesCard.Location =
            New Point(35, 135)

        pnlProfilesCard.Name =
            "pnlProfilesCard"

        pnlProfilesCard.Size =
            New Size(195, 185)

        pnlProfilesCard.TabIndex = 1

        '
        ' lblProfilesTitle
        '
        lblProfilesTitle.AutoSize = True

        lblProfilesTitle.Font =
            New Font(
                "Segoe UI",
                11.0F,
                FontStyle.Bold,
                GraphicsUnit.Point)

        lblProfilesTitle.ForeColor =
            Color.White

        lblProfilesTitle.Location =
            New Point(18, 18)

        lblProfilesTitle.Name =
            "lblProfilesTitle"

        lblProfilesTitle.Size =
            New Size(119, 20)

        lblProfilesTitle.TabIndex = 0

        lblProfilesTitle.Text =
            "PROfile Manager"

        '
        ' lblProfilesDescription
        '
        lblProfilesDescription.Font =
            New Font(
                "Segoe UI",
                9.0F,
                FontStyle.Regular,
                GraphicsUnit.Point)

        lblProfilesDescription.ForeColor =
            Color.Gainsboro

        lblProfilesDescription.Location =
            New Point(18, 54)

        lblProfilesDescription.Name =
            "lblProfilesDescription"

        lblProfilesDescription.Size =
            New Size(160, 64)

        lblProfilesDescription.TabIndex = 1

        lblProfilesDescription.Text =
            "Save, manage and restore Microsoft Flight Simulator graphics profiles."

        '
        ' btnManageProfiles
        '
        btnManageProfiles.FlatAppearance.BorderColor =
            Color.FromArgb(100, 115, 130)

        btnManageProfiles.FlatStyle =
            FlatStyle.Flat

        btnManageProfiles.Font =
            New Font(
                "Segoe UI",
                9.0F,
                FontStyle.Bold,
                GraphicsUnit.Point)

        btnManageProfiles.ForeColor =
            Color.White

        btnManageProfiles.Location =
            New Point(18, 137)

        btnManageProfiles.Name =
            "btnManageProfiles"

        btnManageProfiles.Size =
            New Size(160, 32)

        btnManageProfiles.TabIndex = 2

        btnManageProfiles.Text =
            "Manage PROfiles"

        btnManageProfiles.UseVisualStyleBackColor =
            True

        '
        ' pnlMaintenanceCard
        '
        pnlMaintenanceCard.BackColor =
            Color.FromArgb(47, 58, 72)

        pnlMaintenanceCard.Controls.Add(lblMaintenanceTitle)
        pnlMaintenanceCard.Controls.Add(lblMaintenanceDescription)
        pnlMaintenanceCard.Controls.Add(btnMaintenance)

        pnlMaintenanceCard.Location =
            New Point(250, 135)

        pnlMaintenanceCard.Name =
            "pnlMaintenanceCard"

        pnlMaintenanceCard.Size =
            New Size(195, 185)

        pnlMaintenanceCard.TabIndex = 2

        '
        ' lblMaintenanceTitle
        '
        lblMaintenanceTitle.AutoSize = True

        lblMaintenanceTitle.Font =
            New Font(
                "Segoe UI",
                11.0F,
                FontStyle.Bold,
                GraphicsUnit.Point)

        lblMaintenanceTitle.ForeColor =
            Color.White

        lblMaintenanceTitle.Location =
            New Point(18, 18)

        lblMaintenanceTitle.Name =
            "lblMaintenanceTitle"

        lblMaintenanceTitle.Size =
            New Size(128, 20)

        lblMaintenanceTitle.TabIndex = 0

        lblMaintenanceTitle.Text =
            "File Maintenance"

        '
        ' lblMaintenanceDescription
        '
        lblMaintenanceDescription.Font =
            New Font(
                "Segoe UI",
                9.0F,
                FontStyle.Regular,
                GraphicsUnit.Point)

        lblMaintenanceDescription.ForeColor =
            Color.Gainsboro

        lblMaintenanceDescription.Location =
            New Point(18, 54)

        lblMaintenanceDescription.Name =
            "lblMaintenanceDescription"

        lblMaintenanceDescription.Size =
            New Size(160, 64)

        lblMaintenanceDescription.TabIndex = 1

        lblMaintenanceDescription.Text =
            "Back up and maintain important Microsoft Flight Simulator configuration files."

        '
        ' btnMaintenance
        '
        btnMaintenance.FlatAppearance.BorderColor =
            Color.FromArgb(100, 115, 130)

        btnMaintenance.FlatStyle =
            FlatStyle.Flat

        btnMaintenance.Font =
            New Font(
                "Segoe UI",
                9.0F,
                FontStyle.Bold,
                GraphicsUnit.Point)

        btnMaintenance.ForeColor =
            Color.White

        btnMaintenance.Location =
            New Point(18, 137)

        btnMaintenance.Name =
            "btnMaintenance"

        btnMaintenance.Size =
            New Size(160, 32)

        btnMaintenance.TabIndex = 2

        btnMaintenance.Text =
            "File Maintenance"

        btnMaintenance.UseVisualStyleBackColor =
            True

        '
        ' pnlSimulatorCard
        '
        pnlSimulatorCard.BackColor =
            Color.FromArgb(47, 58, 72)

        pnlSimulatorCard.Controls.Add(lblSimulatorTitle)
        pnlSimulatorCard.Controls.Add(lblSimulatorValue)
        pnlSimulatorCard.Controls.Add(lblSimulatorStatus)

        pnlSimulatorCard.Location =
            New Point(465, 135)

        pnlSimulatorCard.Name =
            "pnlSimulatorCard"

        pnlSimulatorCard.Size =
            New Size(200, 185)

        pnlSimulatorCard.TabIndex = 3

        '
        ' lblSimulatorTitle
        '
        lblSimulatorTitle.AutoSize = True

        lblSimulatorTitle.Font =
            New Font(
                "Segoe UI",
                11.0F,
                FontStyle.Bold,
                GraphicsUnit.Point)

        lblSimulatorTitle.ForeColor =
            Color.White

        lblSimulatorTitle.Location =
            New Point(18, 18)

        lblSimulatorTitle.Name =
            "lblSimulatorTitle"

        lblSimulatorTitle.Size =
            New Size(79, 20)

        lblSimulatorTitle.TabIndex = 0

        lblSimulatorTitle.Text =
            "Simulator"

        '
        ' lblSimulatorValue
        '
        lblSimulatorValue.Font =
            New Font(
                "Segoe UI",
                11.0F,
                FontStyle.Bold,
                GraphicsUnit.Point)

        lblSimulatorValue.ForeColor =
            Color.White

        lblSimulatorValue.Location =
            New Point(18, 60)

        lblSimulatorValue.Name =
            "lblSimulatorValue"

        lblSimulatorValue.Size =
            New Size(165, 26)

        lblSimulatorValue.TabIndex = 1

        lblSimulatorValue.Text =
            "Not detected"

        '
        ' lblSimulatorStatus
        '
        lblSimulatorStatus.Font =
            New Font(
                "Segoe UI",
                9.0F,
                FontStyle.Regular,
                GraphicsUnit.Point)

        lblSimulatorStatus.ForeColor =
            Color.Gainsboro

        lblSimulatorStatus.Location =
            New Point(18, 100)

        lblSimulatorStatus.Name =
            "lblSimulatorStatus"

        lblSimulatorStatus.Size =
            New Size(165, 54)

        lblSimulatorStatus.TabIndex = 2

        lblSimulatorStatus.Text =
            "Simulator status unavailable."

        '
        ' pnlQuickStart
        '
        pnlQuickStart.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        pnlQuickStart.BackColor =
            Color.FromArgb(47, 58, 72)

        pnlQuickStart.Controls.Add(lblQuickStartTitle)
        pnlQuickStart.Controls.Add(lblQuickStartText)

        pnlQuickStart.Location =
            New Point(35, 335)

        pnlQuickStart.Name =
            "pnlQuickStart"

        pnlQuickStart.Size =
            New Size(630, 100)

        pnlQuickStart.TabIndex = 4

        '
        ' lblQuickStartTitle
        '
        lblQuickStartTitle.AutoSize = True

        lblQuickStartTitle.Font =
            New Font(
                "Segoe UI",
                11.0F,
                FontStyle.Bold,
                GraphicsUnit.Point)

        lblQuickStartTitle.ForeColor =
            Color.White

        lblQuickStartTitle.Location =
            New Point(22, 18)

        lblQuickStartTitle.Name =
            "lblQuickStartTitle"

        lblQuickStartTitle.Size =
            New Size(89, 20)

        lblQuickStartTitle.TabIndex = 0

        lblQuickStartTitle.Text =
            "Quick Start"

        '
        ' lblQuickStartText
        '
        lblQuickStartText.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        lblQuickStartText.Font =
            New Font(
                "Segoe UI",
                9.0F,
                FontStyle.Regular,
                GraphicsUnit.Point)

        lblQuickStartText.ForeColor =
            Color.Gainsboro

        lblQuickStartText.Location =
            New Point(22, 48)

        lblQuickStartText.Name =
            "lblQuickStartText"

        lblQuickStartText.Size =
            New Size(585, 40)

        lblQuickStartText.TabIndex = 1

        lblQuickStartText.Text =
            "Create PROfiles for different graphics settings, VR configurations, display setups, or performance requirements. Switch between them without manually editing UserCfg.opt."

        '
        ' UcHome
        '
        AutoScaleDimensions =
            New SizeF(7.0F, 15.0F)

        AutoScaleMode =
            AutoScaleMode.Font

        BackColor =
            Color.FromArgb(42, 52, 66)

        Controls.Add(pnlQuickStart)
        Controls.Add(pnlSimulatorCard)
        Controls.Add(pnlMaintenanceCard)
        Controls.Add(pnlProfilesCard)
        Controls.Add(pnlWelcome)

        Name =
            "UcHome"

        Size =
            New Size(700, 530)

        pnlWelcome.ResumeLayout(False)
        pnlWelcome.PerformLayout()

        pnlProfilesCard.ResumeLayout(False)
        pnlProfilesCard.PerformLayout()

        pnlMaintenanceCard.ResumeLayout(False)
        pnlMaintenanceCard.PerformLayout()

        pnlSimulatorCard.ResumeLayout(False)
        pnlSimulatorCard.PerformLayout()

        pnlQuickStart.ResumeLayout(False)
        pnlQuickStart.PerformLayout()

        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlWelcome As Panel
    Friend WithEvents lblWelcomeTitle As Label
    Friend WithEvents lblWelcomeDescription As Label

    Friend WithEvents pnlProfilesCard As Panel
    Friend WithEvents lblProfilesTitle As Label
    Friend WithEvents lblProfilesDescription As Label
    Friend WithEvents btnManageProfiles As Button

    Friend WithEvents pnlMaintenanceCard As Panel
    Friend WithEvents lblMaintenanceTitle As Label
    Friend WithEvents lblMaintenanceDescription As Label
    Friend WithEvents btnMaintenance As Button

    Friend WithEvents pnlSimulatorCard As Panel
    Friend WithEvents lblSimulatorTitle As Label
    Friend WithEvents lblSimulatorValue As Label
    Friend WithEvents lblSimulatorStatus As Label

    Friend WithEvents pnlQuickStart As Panel
    Friend WithEvents lblQuickStartTitle As Label
    Friend WithEvents lblQuickStartText As Label

End Class