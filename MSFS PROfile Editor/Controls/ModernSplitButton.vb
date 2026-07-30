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

#Region "Fields"

    Private Const ArrowSectionWidth As Integer = 24

    Private _dropDownMenu As ContextMenuStrip

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

End Class