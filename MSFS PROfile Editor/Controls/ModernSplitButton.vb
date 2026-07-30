Imports System.ComponentModel
Imports System.Windows.Forms

''' <summary>
''' A modern split button that performs a normal button click when the main
''' portion is clicked, or displays a ContextMenuStrip when the drop-down
''' arrow is clicked.
''' </summary>
<DefaultEvent("Click")>
Public Class ModernSplitButton
    Inherits Button

    Private Const SplitSectionWidth As Integer = 24

#Region "Fields"

    Private _dropDownMenu As ContextMenuStrip

#End Region

#Region "Private Properties"

    Private ReadOnly Property SplitRectangle As Rectangle
        Get
            Return New Rectangle(
            ClientRectangle.Right - SplitSectionWidth,
            ClientRectangle.Top,
            SplitSectionWidth,
            ClientRectangle.Height)
        End Get
    End Property

#End Region

#Region "Properties"

    ''' <summary>
    ''' Gets or sets the menu displayed when the drop-down arrow is clicked.
    ''' </summary>
    <Browsable(True)>
    <Category("Behavior")>
    <Description("The menu displayed when the drop-down arrow is clicked.")>
    Public Property DropDownMenu As ContextMenuStrip
        Get
            Return _dropDownMenu
        End Get
        Set(value As ContextMenuStrip)
            _dropDownMenu = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()

        FlatStyle = FlatStyle.Flat
        TextAlign = ContentAlignment.MiddleLeft

    End Sub

#End Region

    Protected Overrides Sub OnPaint(e As PaintEventArgs)

        MyBase.OnPaint(e)

        Dim splitRect = SplitRectangle

        Dim center As Point = New Point(
            splitRect.Left + splitRect.Width \ 2,
            splitRect.Top + splitRect.Height \ 2)

        Dim arrowPoints As Point() =
        {
            New Point(center.X - 4, center.Y - 2),
            New Point(center.X + 4, center.Y - 2),
            New Point(center.X, center.Y + 3)
        }

        Using Brush As New SolidBrush(ForeColor)
            e.Graphics.FillPolygon(Brush, arrowPoints)
        End Using

        Using pen As New Pen(Color.FromArgb(100, Color.White))
            e.Graphics.DrawLine(
            pen,
            splitRect.Left,
            4,
            splitRect.Left,
            splitRect.Bottom - 5)
        End Using

    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)

        If SplitRectangle.Contains(e.Location) Then

            If DropDownMenu IsNot Nothing Then
                DropDownMenu.Show(Me, New Point(0, Height))
            End If

            Return

        End If

        MyBase.OnMouseDown(e)

    End Sub

End Class