'**************************************************************************************
'* Control Resizer
'*
'* Contributed by Bryan Babcock
'* 11-AUG-13
'*
'* This component changes the sizes of the controls on the form in order to
'* maintain a relative size and position to the form
'* It is designed to help with various monitor resolutions
'*
'* NOTE: Controls with locked aspect ratios may not scale properly
'************************************************************************************
Public Class Resizer
    Inherits System.ComponentModel.Component

    Private OriginalFormWidth, OriginalFormHeight As Integer

    Private ControlList As New List(Of ControlInformation)
    Protected Class ControlInformation
        Friend ControlRef As System.ComponentModel.Component
        Friend OriginalSize As Point
        Friend OriginalLocation As Point
        Friend OriginalFontSize As Single
    End Class

#Region "Properties"
    '*********************************************************************************
    '* The purpose of this property is to fetch and hold a reference to the main form 
    '*********************************************************************************
    Private m_ParentForm As Form
    '* do not let this property show up in the property window
    <System.ComponentModel.Browsable(False)> _
    Public Property ParentForm() As Form
        Get
            If m_ParentForm Is Nothing AndAlso DesignMode Then
                Dim host As System.ComponentModel.Design.IDesignerHost = DirectCast(GetService(GetType(System.ComponentModel.Design.IDesignerHost)), System.ComponentModel.Design.IDesignerHost)
                If host IsNot Nothing Then
                    Dim baseComponent As Object = host.RootComponent
                    If baseComponent IsNot Nothing AndAlso TypeOf baseComponent Is Form Then
                        m_ParentForm = DirectCast(baseComponent, Form)
                    End If
                End If
            End If

            Return m_ParentForm
        End Get

        Set(value As Form)
            m_ParentForm = value

            If m_ParentForm IsNot Nothing And Not Me.DesignMode Then
                AddHandler m_ParentForm.Load, AddressOf Initialize
            End If
        End Set
    End Property
#End Region

#Region "Constructors"
    Public Sub New()
        MyBase.New()
    End Sub
#End Region

#Region "Private Methods"
    '*****************************************************************
    '* On startup get a list of all of the controls on the form
    '* and save their original sizes, locations, and font sizes
    '*****************************************************************
    Private Sub Initialize(sender As System.Object, e As System.EventArgs)
        Dim PreviousIndex As New Stack(Of Integer)

        OriginalFormWidth = m_ParentForm.Width
        OriginalFormHeight = m_ParentForm.Height

        Dim index As Integer
        Dim CurrentContainer As System.ComponentModel.Component = m_ParentForm
        '* Continue to while there are controls in the parent form or we are indexing through a container of controls
        While index < m_ParentForm.Controls.Count Or PreviousIndex.Count > 0
            '* Capture the size, location, and font information of the control or container
            'Dim c As Control = CurrentContainer
            'If CurrentContainer Is GetType(Control) Then
            'c = DirectCast(CurrentContainer, Control)
            'End If
            Dim ci As New ControlInformation

            If Not (TypeOf (CurrentContainer) Is Microsoft.VisualBasic.PowerPacks.ShapeContainer) Then
                Dim c As Control
                c = DirectCast(CurrentContainer, Control)
                Dim sc As Control
                sc = DirectCast(c.Controls(index), Control)

                ci.OriginalSize = (New Point(sc.Size.Width, sc.Size.Height))
                ci.OriginalLocation = (New Point(sc.Location.X, sc.Location.Y))
                Try
                    ci.OriginalFontSize = sc.Controls(index).Font.Size
                Catch ex As Exception
                End Try
                ci.ControlRef = sc
                ControlList.Add(ci)
            Else ' If TypeOf (CurrentContainer) Is Microsoft.VisualBasic.PowerPacks.ShapeContainer Then
                Dim sc As Microsoft.VisualBasic.PowerPacks.ShapeContainer
                sc = DirectCast(CurrentContainer, Microsoft.VisualBasic.PowerPacks.ShapeContainer)
               If TypeOf (sc.Shapes.Item(index)) Is Microsoft.VisualBasic.PowerPacks.OvalShape Then
                    Dim s As Microsoft.VisualBasic.PowerPacks.OvalShape
                    s = DirectCast(sc.Shapes.Item(index), Microsoft.VisualBasic.PowerPacks.OvalShape)
                    ci.OriginalSize = (New Point(s.Width, s.Height))
                Else
                    Dim s As Microsoft.VisualBasic.PowerPacks.RectangleShape
                    s = DirectCast(sc.Shapes.Item(index), Microsoft.VisualBasic.PowerPacks.RectangleShape)
                    ci.OriginalSize = (New Point(s.Width, s.Height))
                End If
                ci.OriginalLocation = (New Point(sc.Shapes.Item(index).Location.X, sc.Shapes.Item(index).Location.Y))
                ci.ControlRef = sc.Shapes.Item(index)
                ControlList.Add(ci)
            End If

            'If TypeOf (CurrentContainer.Controls(index)) Is Microsoft.VisualBasic.PowerPacks.ShapeContainer Then
            '    Dim sc As Microsoft.VisualBasic.PowerPacks.ShapeContainer
            '    Try
            '        sc = DirectCast(CurrentContainer.Controls(index), Microsoft.VisualBasic.PowerPacks.ShapeContainer)

            '        ci.OriginalSize = (New Point(sc.Size.Width, sc.Shapes.Item(index).Size.Height))
            '        ci.OriginalLocation = (New Point(sc.Shapes.Item(index).Location.X, sc.Shapes.Item(index).Location.Y))
            '        'ci.OriginalFontSize = CurrentContainer.Controls(index).Font.Size
            '        ci.ControlRef = sc.Shapes.Item(index)
            '        ControlList.Add(ci)
            '    Catch ex As Exception
            '        Dim dbg = 0
            '    End Try
            'ElseIf TypeOf (CurrentContainer.Controls(index)) Is Microsoft.VisualBasic.PowerPacks.Shape Then
            'Else
            '    Dim sc As Control

            '    sc = DirectCast(CurrentContainer.Controls(index), Control)

            '    ci.OriginalSize = (New Point(sc.Size.Width, sc.Size.Height))
            '    ci.OriginalLocation = (New Point(sc.Location.X, sc.Location.Y))
            '    ci.OriginalFontSize = CurrentContainer.Controls(index).Font.Size
            '    ci.ControlRef = sc
            '    ControlList.Add(ci)
            'End If


            index += 1


            '* If this control is a container, then drill into to get it's controls
            'Dim x() = ci.ControlRef.GetType.GetInterfaces
            If TypeOf (ci.ControlRef) Is Control AndAlso IsContainer(ci.ControlRef) Then
                'If ci.ControlRef.GetType.GetInterface("IContainer") IsNot Nothing Or _
                '   TypeOf (ci.ControlRef) Is Microsoft.VisualBasic.PowerPacks.ShapeContainer Then
                '* Begin indexing through this container
                CurrentContainer = ci.ControlRef
                '* Save the index to be able to pick back up from same point after going through this container
                PreviousIndex.Push(index)
                '* Start at the first control in this container
                index = 0
            End If


            '* Did we reach the end of the controls in this container?
            'Dim z = CurrentContainer.GetType.GetInterface("IContainerControl")
            ' If CurrentContainer.GetType.GetInterface("IContainerControl") IsNot Nothing Then
            'If CurrentContainer IsNot GetType(Microsoft.VisualBasic.PowerPacks.ShapeContainer) Then
            If Not (TypeOf (CurrentContainer) Is Microsoft.VisualBasic.PowerPacks.ShapeContainer) Then
                Dim c As Control = DirectCast(CurrentContainer, Control)
                If index >= c.Controls.Count And PreviousIndex.Count > 0 Then
                    '* Retrieve the saved index from the parent container
                    index = PreviousIndex.Pop
                    CurrentContainer = c.Parent
                End If
            Else ' If TypeOf (CurrentContainer) Is Microsoft.VisualBasic.PowerPacks.ShapeContainer Then
                Dim c As Microsoft.VisualBasic.PowerPacks.ShapeContainer = DirectCast(CurrentContainer, Microsoft.VisualBasic.PowerPacks.ShapeContainer)
                If index >= c.Shapes.Count And PreviousIndex.Count > 0 Then
                    index = PreviousIndex.Pop
                    CurrentContainer = c.Parent
                End If
            End If
            'ElseIf CurrentContainer Is GetType(Microsoft.VisualBasic.PowerPacks.ShapeContainer) Then
            'If index >= CurrentContainer.Shapes And PreviousIndex.Count > 0 Then
            '    '* Retrieve the saved index from the parent container
            '    index = PreviousIndex.Pop
            '    CurrentContainer = CurrentContainer.Parent
            'End If
            'End If
        End While

        'index = 0
        'While index < m_ParentForm.Site.Container.Components.Count
        '    If m_ParentForm.Site.Container.Components(index).GetType Is GetType(Microsoft.VisualBasic.PowerPacks.SimpleShape) Then
        '        Dim ci As New ControlInformation
        '        ci.OriginalSize = (New Point(CurrentContainer.Controls(index).Size.Width, CurrentContainer.Controls(index).Size.Height))
        '        ci.OriginalLocation = (New Point(CurrentContainer.Controls(index).Location.X, CurrentContainer.Controls(index).Location.Y))
        '        ci.ControlRef = m_ParentForm.Site.Container.Components(index)
        '        ControlList.Add(ci)

        '    End If
        'End While

        '* We are now initializied, so remove hook from load event
        RemoveHandler m_ParentForm.Load, AddressOf Initialize

        '* Hook the Size changed event so we can adjust the controls when the main form changes size
        AddHandler m_ParentForm.SizeChanged, AddressOf ControlResizer
    End Sub

    '*******************************************
    '* Can this control contain more controls?
    '*******************************************
    Private Function IsContainer(ByVal con As Control) As Boolean
        'Dim x As String = con.GetType.Name
        Return con.GetType.Name = "TableLayoutPanel" OrElse _
                con.GetType.Name = "GroupBox" OrElse _
                con.GetType.Name = "Panel" OrElse _
                con.GetType.Name = "FlowLayoutPanel" OrElse _
                con.GetType.Name = "SplitContainer" OrElse _
                con.GetType.Name = "Form" OrElse _
                con.GetType.Name = "TabControl" OrElse _
                con.GetType.Name = "ShapeContainer"
    End Function

    '*******************************************************************************
    '* Modify all of the controls based on the new size ratio to the original size
    '*******************************************************************************
    Private Sub ControlResizer()
        Dim WidthChangeRatio As Double = m_ParentForm.Width / OriginalFormWidth
        Dim HeightChangeRatio As Double = m_ParentForm.Height / OriginalFormHeight

        '* Modify the controls, for the new size
        For i = 0 To ControlList.Count - 1
            If TypeOf (ControlList(i).ControlRef) Is Microsoft.VisualBasic.PowerPacks.OvalShape Then
                Dim c As Microsoft.VisualBasic.PowerPacks.OvalShape = DirectCast(ControlList(i).ControlRef, Microsoft.VisualBasic.PowerPacks.OvalShape)
                '* Relocate the control
                c.Location = New Point(CInt(ControlList(i).OriginalLocation.X * WidthChangeRatio), _
                                                               CInt(ControlList(i).OriginalLocation.Y * HeightChangeRatio))
                '* Resize the control
                c.Size = New Point(CInt(ControlList(i).OriginalSize.X * WidthChangeRatio), _
                                                           CInt(ControlList(i).OriginalSize.Y * HeightChangeRatio))
            ElseIf TypeOf (ControlList(i).ControlRef) Is Microsoft.VisualBasic.PowerPacks.RectangleShape Then
                Dim c As Microsoft.VisualBasic.PowerPacks.RectangleShape = DirectCast(ControlList(i).ControlRef, Microsoft.VisualBasic.PowerPacks.RectangleShape)
                '* Relocate the control
                c.Location = New Point(CInt(ControlList(i).OriginalLocation.X * WidthChangeRatio), _
                                                               CInt(ControlList(i).OriginalLocation.Y * HeightChangeRatio))
                '* Resize the control
                c.Size = New Point(CInt(ControlList(i).OriginalSize.X * WidthChangeRatio), _
                                                           CInt(ControlList(i).OriginalSize.Y * HeightChangeRatio))
            Else
                Dim c As Control = DirectCast(ControlList(i).ControlRef, Control)
                '* Relocate the control
                c.Location = New Point(CInt(ControlList(i).OriginalLocation.X * WidthChangeRatio), _
                                                               CInt(ControlList(i).OriginalLocation.Y * HeightChangeRatio))
                '* Resize the control
                c.Size = New Point(CInt(ControlList(i).OriginalSize.X * WidthChangeRatio), _
                                                           CInt(ControlList(i).OriginalSize.Y * HeightChangeRatio))
                Try
                    '* Adjust the font
                    c.Font = AdjustFontSize(c.Font, ControlList(i).OriginalFontSize, ControlList(i).OriginalLocation, c.Location)
                Catch ex As Exception
                    Dim dbg = 0
                End Try
            End If
        Next
    End Sub


    Private Function AdjustFontSize(ByVal font As Font, ByVal originalFontSize As Single, ByVal oldLocation As Point, ByVal newLocation As Point) As Font
        '* Avoid divide by 0
        If oldLocation.X = 0 Then oldLocation.X = 1
        Dim NewSize As Single = originalFontSize * newLocation.X / oldLocation.X

        Return New Font(font.Name, NewSize, font.Style)
    End Function
#End Region
End Class