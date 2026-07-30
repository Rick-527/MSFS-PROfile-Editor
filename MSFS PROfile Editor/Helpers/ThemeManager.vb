Imports System.Drawing
Imports System.Windows.Forms

Public Class ThemeManager

    Public Shared Sub ApplyModernTheme(frm As Form)
        Dim bgForm As Color = Color.FromArgb(43, 50, 64)       ' Deep Charcoal Blue
        Dim bgTextBox As Color = Color.FromArgb(59, 69, 89)   ' Muted Steel
        Dim textLight As Color = Color.FromArgb(236, 239, 244) ' Soft Frost White
        Dim btnPrimary As Color = Color.FromArgb(143, 188, 187) ' Sage Green
        Dim btnSecondary As Color = Color.FromArgb(76, 86, 106) ' Medium Slate Gray

        StyleControlCollection(frm.Controls, bgTextBox, textLight, btnPrimary, btnSecondary)

    End Sub

    Private Shared Sub StyleControlCollection(controls As Control.ControlCollection,
                bgTextBox As Color,
                textLight As Color,
                btnPrimary As Color,
                btnSecondary As Color)
        For Each ctrl As Control In controls

            ' Style Labels
            If TypeOf ctrl Is Label Then
                ctrl.ForeColor = textLight
                ctrl.BackColor = Color.Transparent ' Forces label to use its container's background

                ' Style GroupBoxes
            ElseIf TypeOf ctrl Is GroupBox Then
                Dim gbox As GroupBox = DirectCast(ctrl, GroupBox)
                gbox.FlatStyle = FlatStyle.Flat ' Crucial: Removes the legacy white background frame
                gbox.ForeColor = btnPrimary     ' Makes the GroupBox frame title pop out nicely
                gbox.BackColor = Color.Transparent

                ' Style StatusStrip
            ElseIf TypeOf ctrl Is StatusStrip Then
                Dim strip As StatusStrip = DirectCast(ctrl, StatusStrip)

                strip.BackColor = Color.FromArgb(43, 50, 64)
                strip.ForeColor = textLight
                strip.SizingGrip = False

                ' Style ToolStripStatusLabel
            ElseIf TypeOf ctrl Is ToolStrip Then

                Dim toolStrip As ToolStrip = DirectCast(ctrl, ToolStrip)

                toolStrip.BackColor = Color.FromArgb(43, 50, 64)
                toolStrip.ForeColor = textLight

                For Each item As ToolStripItem In toolStrip.Items

                    If TypeOf item Is ToolStripStatusLabel Then

                        Dim lbl = DirectCast(item, ToolStripStatusLabel)

                        lbl.BackColor = Color.Transparent
                        lbl.ForeColor = textLight
                        lbl.BorderSides = ToolStripStatusLabelBorderSides.None
                        lbl.Spring = True
                        lbl.TextAlign = ContentAlignment.MiddleLeft

                    End If

                Next

                ' Style Input Fields
            ElseIf TypeOf ctrl Is TextBox Then
                Dim txt As TextBox = DirectCast(ctrl, TextBox)
                txt.BackColor = bgTextBox
                txt.ForeColor = textLight
                txt.BorderStyle = BorderStyle.FixedSingle

                ' Style Buttons
            ElseIf TypeOf ctrl Is Button Then
                Dim btn As Button = DirectCast(ctrl, Button)
                btn.FlatStyle = FlatStyle.Flat
                btn.FlatAppearance.BorderSize = 0
                btn.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)

                ' Give primary actions a distinct color from secondary tools
                If btn.Name = "btnSaveAs" Then
                    btn.BackColor = btnPrimary
                    btn.ForeColor = Color.FromArgb(43, 50, 64) ' Dark text on sage green
                ElseIf btn.Name = "btnUpdateCurrentProfile" Then
                    btn.BackColor = Color.DarkOrange
                    btn.ForeColor = Color.FromArgb(43, 50, 64)
                Else
                    btn.BackColor = btnSecondary
                    btn.ForeColor = textLight
                End If
            End If

            ' CRUCIAL STEP: If this control has children (like a GroupBox), style its insides too!
            If ctrl.HasChildren Then
                StyleControlCollection(ctrl.Controls, bgTextBox, textLight, btnPrimary, btnSecondary)
            End If
        Next
    End Sub

End Class