Imports System.Windows.Forms.Design
Imports System.Drawing.Design

Public Class FormChangeButton
    Inherits Button

#Region "Properties"
    Private m_Passcode As String
    Public Property Passcode As String
        Get
            Return m_Passcode
        End Get
        Set(value As String)
            m_Passcode = value
        End Set
    End Property

    Private m_FormToOpen As Type
    <System.ComponentModel.EditorAttribute(GetType(FormListEditor), GetType(System.Drawing.Design.UITypeEditor))> _
    Public Property FormToOpen() As Type
        Get
            Return m_FormToOpen
        End Get
        Set(ByVal value As Type)
            m_FormToOpen = value
        End Set
    End Property
#End Region


#Region "Events"
    Protected Overrides Sub OnClick(e As System.EventArgs)
        If m_FormToOpen IsNot Nothing Then
            If m_Passcode <> "" Then
                '* Create a keypad to prompt for passcode
                Dim kpd As New MfgControl.AdvancedHMI.Controls.Keypad

                kpd.Text = "Enter pass code to continue"

                kpd.StartPosition = FormStartPosition.CenterParent

                If kpd.ShowDialog() = Windows.Forms.DialogResult.OK And kpd.Value = m_Passcode Then
                    MyBase.OnClick(e)

                    OpenForm()
                End If
            Else
                OpenForm()
            End If
        End If
    End Sub

    Private Sub OpenForm()
        If FormToOpen IsNot Nothing Then
            Dim index As Integer
            Dim f = My.Application.OpenForms
            While index < f.Count AndAlso f(index).GetType.Name <> m_FormToOpen.Name
                index += 1
            End While

            If index >= f.Count Then
                Dim NewForm As Form = System.Activator.CreateInstance(m_FormToOpen)
                NewForm.Show()
            Else
                f(index).Show()
                If f(index).WindowState = FormWindowState.Minimized Then
                    f(index).WindowState = FormWindowState.Normal
                End If
                f(index).BringToFront()
            End If

            '* Hide the form this event came from
            '* It may be embedded in other containers
            If TypeOf (Parent) Is Form Then
                Me.Parent.Hide()
            ElseIf TypeOf (Me.Parent.Parent) Is Form Then
                Me.Parent.Parent.Hide()
            Else
                Me.Parent.Parent.Parent.Hide()
            End If
        End If
    End Sub
#End Region
End Class

<System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name:="FullTrust")> _
Public Class FormListEditor
    Inherits System.Drawing.Design.UITypeEditor

    Public Sub New()
    End Sub

    ' Indicates whether the UITypeEditor provides a form-based (modal) dialog, 
    ' drop down dialog, or no UI outside of the properties window.
    Public Overloads Overrides Function GetEditStyle(ByVal context As System.ComponentModel.ITypeDescriptorContext) As System.Drawing.Design.UITypeEditorEditStyle
        Return UITypeEditorEditStyle.DropDown
    End Function

    ' Displays the UI for value selection.
    Dim edSvc As IWindowsFormsEditorService
    Private WithEvents lb As ListBox
    Private ListOfForms As New List(Of Type)

    Public Overloads Overrides Function EditValue(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal provider As System.IServiceProvider, ByVal value As Object) As Object
        ' Uses the IWindowsFormsEditorService to display a 
        ' drop-down UI in the Properties window.
        edSvc = CType(provider.GetService(GetType(IWindowsFormsEditorService)), IWindowsFormsEditorService)
        lb = New ListBox

        'Dim x = My.Forms
        'For Each mm As Form In My.Forms

        'Next


        If (edSvc IsNot Nothing) Then
            'Reflection.Assembly.GetEntryAssembly()
            Dim MyTypes As Type() = Reflection.Assembly.GetExecutingAssembly.GetTypes
            For Each mType As Type In MyTypes
                If mType.BaseType Is GetType(Form) Then
                    ListOfForms.Add(mType.UnderlyingSystemType)
                    lb.Items.Add(mType.UnderlyingSystemType.Name)
                End If
            Next

            AddHandler lb.SelectedIndexChanged, AddressOf ListItemSelected

            lb.Height = lb.ItemHeight * (lb.Items.Count + 1)

            edSvc.DropDownControl(lb)
        End If

        If lb.SelectedIndex >= 0 And lb.SelectedIndex < ListOfForms.Count Then
            Return ListOfForms(lb.SelectedIndex)
        Else
            Return Nothing
        End If
    End Function

    Private Sub ListItemSelected(ByVal sender As Object, ByVal e As System.EventArgs)
        edSvc.CloseDropDown()
    End Sub



    ' Indicates whether the UITypeEditor supports painting a 
    ' representation of a property's value.
    Public Overloads Overrides Function GetPaintValueSupported(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
        Return False
    End Function
End Class

