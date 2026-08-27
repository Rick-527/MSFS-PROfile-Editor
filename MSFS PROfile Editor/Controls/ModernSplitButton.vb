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

    Private Const HoverMaxAlpha As Integer = 75
    Private Const HoverAnimationStep As Integer = 10
    Private Const HoverAnimationInterval As Integer = 15

#Region "Fields"

    Private _dropDownMenu As ContextMenuStrip

    Private _hoverAlpha As Integer = 0
    Private _mainHoverAlpha As Integer = 0

    Private ReadOnly _animationTimer As Timer

    Private _isMainHovered As Boolean
    Private _isArrowHovered As Boolean
    Private _isArrowPressed As Boolean

    Private _splitWidth As Integer = 22
    Private _arrowColor As Color = Color.White
    Private _splitHoverColor As Color = Color.Gainsboro
    Private _showSplit As Boolean = True

#End Region

#Region "Constructor"

    Public Sub New()

        FlatStyle = FlatStyle.Flat
        UseVisualStyleBackColor = False
        TextAlign = ContentAlignment.MiddleCenter

        _animationTimer = New Timer() With {
            .Interval = HoverAnimationInterval
        }

        AddHandler _animationTimer.Tick,
            AddressOf AnimationTimer_Tick

    End Sub

#End Region

#Region "Properties"

    <Category("Appearance")>
    <Description("Gets or sets the width of the dropdown section in pixels.")>
    <DefaultValue(22)>
    Public Property SplitWidth As Integer
        Get
            Return _splitWidth
        End Get
        Set(value As Integer)

            If value < 12 Then
                value = 12
            End If

            If _splitWidth <> value Then
                _splitWidth = value
                Invalidate()
            End If

        End Set
    End Property

    <Category("Appearance")>
    <Description("Gets or sets the color of the dropdown arrow.")>
    <DefaultValue(GetType(Color), "Black")>
    Public Property ArrowColor As Color
        Get
            Return _arrowColor
        End Get
        Set(value As Color)

            If _arrowColor <> value Then
                _arrowColor = value
                Invalidate()
            End If

        End Set
    End Property

    <Category("Appearance")>
    <Description("Gets or sets the background color displayed when a section is hovered.")>
    <DefaultValue(GetType(Color), "Gainsboro")>
    Public Property SplitHoverColor As Color
        Get
            Return _splitHoverColor
        End Get
        Set(value As Color)

            If _splitHoverColor <> value Then
                _splitHoverColor = value
                Invalidate()
            End If

        End Set
    End Property

    <Category("Behavior")>
    <Description("Determines whether the split dropdown section is displayed.")>
    <DefaultValue(True)>
    Public Property ShowSplit As Boolean
        Get
            Return _showSplit
        End Get
        Set(value As Boolean)

            If _showSplit <> value Then

                _showSplit = value

                _isArrowHovered = False
                _isArrowPressed = False
                _hoverAlpha = 0

                Invalidate()

            End If

        End Set
    End Property

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

            If _dropDownMenu IsNot Nothing Then
                RemoveHandler _dropDownMenu.Closed,
                    AddressOf DropDownMenu_Closed
            End If

            _dropDownMenu = value

            If _dropDownMenu IsNot Nothing Then
                AddHandler _dropDownMenu.Closed,
                    AddressOf DropDownMenu_Closed
            End If

        End Set
    End Property

#End Region

#Region "Private Properties"

    Private ReadOnly Property ArrowRectangle As Rectangle
        Get
            Return New Rectangle(
                Width - _splitWidth,
                0,
                _splitWidth,
                Height)
        End Get
    End Property

#End Region

#Region "Private Methods"

    Private Sub StartAnimation()

        If Not _animationTimer.Enabled Then
            _animationTimer.Start()
        End If

    End Sub

    Private Sub ShowDropDownMenu()

        If DropDownMenu Is Nothing Then
            Return
        End If

        _isArrowPressed = True
        Invalidate()

        DropDownMenu.Show(
            Me,
            New Point(0, Height))

    End Sub

    Private Sub DropDownMenu_Closed(
        sender As Object,
        e As ToolStripDropDownClosedEventArgs)

        _isArrowPressed = False
        Invalidate()

    End Sub

    Private Sub AnimationTimer_Tick(
        sender As Object,
        e As EventArgs)

        If _isArrowHovered AndAlso _showSplit Then

            _hoverAlpha =
                Math.Min(
                    HoverMaxAlpha,
                    _hoverAlpha + HoverAnimationStep)

        Else

            _hoverAlpha =
                Math.Max(
                    0,
                    _hoverAlpha - HoverAnimationStep)

        End If

        If _isMainHovered Then

            _mainHoverAlpha =
                Math.Min(
                    HoverMaxAlpha,
                    _mainHoverAlpha + HoverAnimationStep)

        Else

            _mainHoverAlpha =
                Math.Max(
                    0,
                    _mainHoverAlpha - HoverAnimationStep)

        End If

        Invalidate()

        Dim arrowFinished =
            (Not _showSplit) OrElse
            (_isArrowHovered AndAlso _hoverAlpha = HoverMaxAlpha) OrElse
            (Not _isArrowHovered AndAlso _hoverAlpha = 0)

        Dim mainFinished =
            (_isMainHovered AndAlso _mainHoverAlpha = HoverMaxAlpha) OrElse
            (Not _isMainHovered AndAlso _mainHoverAlpha = 0)

        If arrowFinished AndAlso mainFinished Then
            _animationTimer.Stop()
        End If

    End Sub

#End Region

#Region "Protected Overrides"

    Protected Overrides Sub OnBackColorChanged(e As EventArgs)

        MyBase.OnBackColorChanged(e)

        FlatAppearance.MouseOverBackColor = BackColor
        FlatAppearance.MouseDownBackColor = BackColor

    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)

        MyBase.OnPaint(e)

        e.Graphics.SmoothingMode =
            Drawing2D.SmoothingMode.AntiAlias

        Dim mainWidth =
            If(
                _showSplit,
                Math.Max(0, Width - _splitWidth),
                Width)

        Dim mainRect As New Rectangle(
            0,
            0,
            mainWidth,
            Height)

        If _mainHoverAlpha > 0 Then

            Using hoverBrush As New SolidBrush(
                Color.FromArgb(
                    _mainHoverAlpha,
                    _splitHoverColor))

                e.Graphics.FillRectangle(
                    hoverBrush,
                    mainRect)

            End Using

        End If

        If Not _showSplit Then
            Return
        End If

        Dim splitRect = ArrowRectangle

        If _isArrowPressed Then

            Using pressedBrush As New SolidBrush(
                Color.FromArgb(
                    100,
                    Color.Black))

                e.Graphics.FillRectangle(
                    pressedBrush,
                    splitRect)

            End Using

        ElseIf _hoverAlpha > 0 Then

            Using hoverBrush As New SolidBrush(
                Color.FromArgb(
                    _hoverAlpha,
                    _splitHoverColor))

                e.Graphics.FillRectangle(
                    hoverBrush,
                    splitRect)

            End Using

        End If

        Dim center As New Point(
            splitRect.Left + splitRect.Width \ 2,
            splitRect.Top + splitRect.Height \ 2)

        Dim arrowPoints As Point() =
        {
            New Point(center.X - 5, center.Y - 2),
            New Point(center.X + 5, center.Y - 2),
            New Point(center.X, center.Y + 4)
        }

        Using brush As New SolidBrush(_arrowColor)

            e.Graphics.FillPolygon(
                brush,
                arrowPoints)

        End Using

        Using pen As New Pen(
            Color.FromArgb(
                60,
                Color.White))

            e.Graphics.DrawLine(
                pen,
                splitRect.Left,
                4,
                splitRect.Left,
                splitRect.Bottom - 5)

        End Using

    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)

        MyBase.OnMouseMove(e)

        If Not _showSplit Then

            If Not _isMainHovered OrElse _isArrowHovered Then

                _isMainHovered = True
                _isArrowHovered = False

                StartAnimation()

            End If

            Return

        End If

        Dim overArrow =
            ArrowRectangle.Contains(e.Location)

        Dim overMain =
            Not overArrow

        If overArrow <> _isArrowHovered OrElse
            overMain <> _isMainHovered Then

            _isArrowHovered = overArrow
            _isMainHovered = overMain

            StartAnimation()

        End If

    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)

        If Not _showSplit Then

            MyBase.OnMouseDown(e)
            Return

        End If

        If ArrowRectangle.Contains(e.Location) Then

            ShowDropDownMenu()
            Return

        End If

        MyBase.OnMouseDown(e)

    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)

        MyBase.OnMouseUp(e)

        If _isArrowPressed Then

            _isArrowPressed = False
            Invalidate()

        End If

    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)

        MyBase.OnMouseLeave(e)

        If _isArrowHovered OrElse _isMainHovered Then

            _isArrowHovered = False
            _isMainHovered = False

            StartAnimation()

        End If

    End Sub

    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)

        If _showSplit AndAlso
            e.Alt AndAlso
            e.KeyCode = Keys.Down Then

            ShowDropDownMenu()

            e.Handled = True
            Return

        End If

        MyBase.OnKeyDown(e)

    End Sub

    Protected Overrides Sub Dispose(disposing As Boolean)

        If disposing Then

            If _dropDownMenu IsNot Nothing Then
                RemoveHandler _dropDownMenu.Closed,
                    AddressOf DropDownMenu_Closed
            End If

            _animationTimer.Stop()
            _animationTimer.Dispose()

        End If

        MyBase.Dispose(disposing)

    End Sub

#End Region

End Class