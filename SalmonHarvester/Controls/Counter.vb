'****************************************************************************
'* Archie Jacobs
'* Manufacturing Automation, LLC
'* ajacobs@mfgcontrol.com
'* 12-JUN-11
'*
'* Copyright 2011 Archie Jacobs
'*
'* Distributed under the GNU General Public License (www.gnu.org)
'*
'* This program is free software; you can redistribute it and/or
'* as published by the Free Software Foundation; either version 2
'* of the License, or (at your option) any later version.
'*
'* This program is distributed in the hope that it will be useful,
'* but WITHOUT ANY WARRANTY; without even the implied warranty of
'* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'* GNU General Public License for more details.

'* You should have received a copy of the GNU General Public License
'* along with this program; if not, write to the Free Software
'* Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
'*
'* 12-JUN-11 Created
'* 31-DEC-11 Added BooleanDisplay property
'* 28-SEP-12 Catch specific PLCDriverException when trying to subscribe
'* 29-JAN-13 Added KeypadMinValue and KeypadMaxValue
'* 10-JUL-13 Added Value property
'****************************************************************************
Public Class Counter
    Inherits System.Windows.Forms.Label

    Public Event ValueChanged As EventHandler





#Region "Basic Properties"

    Private _hidden As Boolean
    Public Property Hidden As Boolean
        Get
            Return _hidden
        End Get
        Set(value As Boolean)
            _hidden = value
        End Set
    End Property



    Private SavedBackColor As System.Drawing.Color

    '* Remove Text from the property window so users do not attempt to use it
    <System.ComponentModel.Browsable(False)> _
    Public Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
            MyBase.Text = value
        End Set
    End Property

    '******************************************************************************************
    '* Use the base control's text property and make it visible as a property on the designer
    '******************************************************************************************
    Private m_Value As String
    Public Property Value As String
        Get
            Return m_Value
        End Get
        Set(ByVal value As String)
            If value <> m_Value Then
                m_Value = value
                UpdateText()
                '* Be sure error handler doesn't revert back to an incorrect text
                'OriginalText = MyBase.Text

                OnvalueChanged(EventArgs.Empty)
            End If
        End Set
    End Property
    Private m_intvalue As Integer
    Public Property intValue As Integer
        Get
            Return m_intvalue
        End Get
        Set(value As Integer)
            m_intvalue = value
        End Set
    End Property

    '**********************************
    '* Prefix and suffixes to text
    '**********************************
    Private m_Prefix As String
    Public Property ValuePrefix() As String
        Get
            Return m_Prefix
        End Get
        Set(ByVal value As String)
            m_Prefix = value
            UpdateText()
            Invalidate()
        End Set
    End Property

    Private _Suffix As String
    Public Property ValueSuffix() As String
        Get
            Return _Suffix
        End Get
        Set(ByVal value As String)
            _Suffix = value
            UpdateText()
            Invalidate()
        End Set
    End Property


    '***************************************************************
    '* Property - Highlight Color
    '***************************************************************
    Private _Highlightcolor As Drawing.Color = Drawing.Color.Red
    <System.ComponentModel.Category("Appearance")> _
    Public Property HighlightColor() As Drawing.Color
        Get
            Return _Highlightcolor
        End Get
        Set(ByVal value As Drawing.Color)
            _Highlightcolor = value
        End Set
    End Property

    Private _HighlightKeyChar As String = "!"
    <System.ComponentModel.Category("Appearance")> _
    Public Property HighlightKeyCharacter() As String
        Get
            Return _HighlightKeyChar
        End Get
        Set(ByVal value As String)
            _HighlightKeyChar = value
        End Set
    End Property


    Private m_Format As String
    Public Property NumericFormat() As String
        Get
            Return m_Format
        End Get
        Set(ByVal value As String)
            m_Format = value
        End Set
    End Property

    Private m_ValueScaleFactor As Double = 1
    Public Property ValueScaleFactor() As Double
        Get
            Return m_ValueScaleFactor
        End Get
        Set(ByVal value As Double)
            m_ValueScaleFactor = value
            'TODO: Does not refresh in designmode
            'Text = MyBase.Text
        End Set
    End Property

    Public Enum BooleanDisplayOption
        TrueFalse
        YesNo
        OnOff
    End Enum

    Private m_BooleanDisplay As BooleanDisplayOption
    Public Property BooleanDisplay() As BooleanDisplayOption
        Get
            Return m_BooleanDisplay
        End Get
        Set(ByVal value As BooleanDisplayOption)
            m_BooleanDisplay = value
        End Set
    End Property
#End Region

#Region "PLC Related Properties"
    '*****************************************************
    '* Property - Component to communicate to PLC through
    '*****************************************************
    Private _CommComponent As AdvancedHMIDrivers.IComComponent
    <System.ComponentModel.Description("Driver Instance for data reading and writing")> _
    <System.ComponentModel.Category("PLC Properties")> _
    Public Property CommComponent() As AdvancedHMIDrivers.IComComponent
        Get
            Return _CommComponent
        End Get
        Set(ByVal value As AdvancedHMIDrivers.IComComponent)
            _CommComponent = value
        End Set
    End Property

    Private _PollRate As Integer
    Public Property PollRate() As Integer
        Get
            Return _PollRate
        End Get
        Set(ByVal value As Integer)
            _PollRate = value
        End Set
    End Property

    Private m_KeypadText As String
    Public Property KeypadText() As String
        Get
            Return m_KeypadText
        End Get
        Set(ByVal value As String)
            m_KeypadText = value
        End Set
    End Property

    Private m_KeypadFont As Font = New Font("Arial", 10)
    Public Property KeypadFont() As Font
        Get
            Return m_KeypadFont
        End Get
        Set(ByVal value As Font)
            m_KeypadFont = value
        End Set
    End Property

    Private m_KeypadForeColor As Color = Color.WhiteSmoke
    Public Property KeypadFontColor() As Color
        Get
            Return m_KeypadForeColor
        End Get
        Set(ByVal value As Color)
            m_KeypadForeColor = value
        End Set
    End Property

    Private m_KeypadWidth As Integer = 300
    Public Property KeypadWidth() As Integer
        Get
            Return m_KeypadWidth
        End Get
        Set(ByVal value As Integer)
            m_KeypadWidth = value
        End Set
    End Property

    '* 29-JAN-13
    Private m_KeypadMinValue As Double
    Public Property KeypadMinValue As Double
        Get
            Return m_KeypadMinValue
        End Get
        Set(value As Double)
            m_KeypadMinValue = value
        End Set
    End Property




    Private m_SuppressErrorDisplay As Boolean
    <System.ComponentModel.DefaultValue(False)> _
    Public Property SuppressErrorDisplay As Boolean
        Get
            Return m_SuppressErrorDisplay
        End Get
        Set(value As Boolean)
            m_SuppressErrorDisplay = value
        End Set
    End Property



    '*****************************************
    '* Property - Address in PLC to Link to
    '*****************************************
    Private m_PLCAddressValue As String = ""
    <System.ComponentModel.Category("PLC Properties")> _
    Public Property PLCAddressValue() As String
        Get
            Return m_PLCAddressValue
        End Get
        Set(ByVal value As String)
            If m_PLCAddressValue <> value Then
                m_PLCAddressValue = value

                '* When address is changed, re-subscribe to new address
                SubscribeToCommDriver()
            End If
        End Set
    End Property

    '*****************************************
    '* Property - Address in PLC to Link to
    '*****************************************
    Private InvertVisible As Boolean
    Private m_PLCAddressVisible As String = ""
    <System.ComponentModel.Category("PLC Properties")> _
    Public Property PLCAddressVisible() As String
        Get
            Return m_PLCAddressVisible
        End Get
        Set(ByVal value As String)
            If m_PLCAddressVisible <> value Then
                m_PLCAddressVisible = value

                '* When address is changed, re-subscribe to new address
                SubscribeToCommDriver()
            End If
        End Set
    End Property

    '*****************************************
    '* Property - Address in PLC to Write Data To
    '*****************************************
    Private m_PLCAddressKeypad As String = ""
    <System.ComponentModel.Category("PLC Properties")> _
    Public Property PLCAddressKeypad() As String
        Get
            Return m_PLCAddressKeypad
        End Get
        Set(ByVal value As String)
            If m_PLCAddressKeypad <> value Then
                m_PLCAddressKeypad = value
            End If
        End Set
    End Property
#End Region

#Region "Private Methods"
    Private Sub UpdateText()

        If m_Format <> "" And (Not DesignMode) Then

            MyBase.Text = Format(m_intvalue, m_Format)
            'make sure the color changes back to red after successful read. CHD
            If Not Me.Hidden Then
                Me.ForeColor = Color.Red
            End If




        End If

    End Sub
#End Region

#Region "Events"
    '********************************************************************
    '* When an instance is added to the form, set the comm component
    '* property. If a comm component does not exist, add one to the form
    '********************************************************************
    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()

        If Me.DesignMode Then
            '********************************************************
            '* Search for AdvancedHMIDrivers.IComComponent component
            '*   in the Designer Host Container
            '* If one exists, set the client of this component to it
            '********************************************************
            Dim i As Integer
            While _CommComponent Is Nothing And i < Me.Site.Container.Components.Count
                If Me.Site.Container.Components(i).GetType.GetInterface("AdvancedHMIDrivers.IComComponent") IsNot Nothing Then _CommComponent = Me.Site.Container.Components(i)
                i += 1
            End While

            '***************************************************
            '* If no comm component was found, then add one and
            '* point the CommComponent property to it
            '***************************************************
            If _CommComponent Is Nothing Then
                'Me.Site.Container.Add(New AdvancedHMIDrivers.EthernetIPforCLXCom)
                '_CommComponent = Me.Site.Container.Components(Me.Site.Container.Components.Count - 1)
            End If

        Else
            SubscribeToCommDriver()
        End If
    End Sub

    Public Sub New()
        MyBase.new()

        'Value = "Counter"
        'Me.AutoSize = True
        'Me.BooleanDisplay = MfgControl.AdvancedHMI.BasicLabel.BooleanDisplayOption.TrueFalse
        'BasicLabel(Counter).CommComponent = Me.EthernetIPforPLCSLCMicroCom1

        'Me.HighlightColor = System.Drawing.Color.Red
        'Me.HighlightKeyCharacter = "!"
        'Me.KeypadFont = New System.Drawing.Font("Let's go Digital", 10.0!)
        'Me.KeypadFontColor = System.Drawing.Color.WhiteSmoke


        'Me.KeypadText = Nothing
        ' Me.KeypadWidth = 300
        'Me.Location = New System.Drawing.Point(427 + 50 * Counter, 288)
        Me.Name = "Counter"
        Me.PLCAddressKeypad = ""
        'Me.PLCAddressValue = "T4:" & CStr(Counter - 1) & ".PRE"
        Me.PLCAddressVisible = ""
        Me.PollRate = 0
        Me.Size = New System.Drawing.Size(69, 13)
        Me.TabIndex = 47
        Me.Text = "0000"
        Me.Value = "0"
        Me.intValue = 0
        Me.ValuePrefix = Nothing
        Me.ValueScaleFactor = 1.0R
        Me.ValueSuffix = Nothing
        Me.TextAlign = ContentAlignment.MiddleRight
        Me.BackColor = Color.White
        Me.ForeColor = Color.Red
        Me.BorderStyle = BorderStyle.FixedSingle
        Me.NumericFormat = "0000"
        Me.BooleanDisplay = BooleanDisplayOption.TrueFalse
        Me.AutoSize = False
        Me.Hidden = False


    End Sub

    Protected Overrides Sub OnHandleCreated(e As System.EventArgs)
        MyBase.OnHandleCreated(e)

        'If ForeColor.R = Me.Parent.BackColor.R And ForeColor.G = Me.Parent.BackColor.G And ForeColor.B = Me.Parent.BackColor.B Then
        '    ForeColor = Drawing.Color.FromArgb(Not Me.ForeColor.R, Not Me.ForeColor.G, Not Me.ForeColor.B)
        'End If
    End Sub

    '****************************************************************
    '* UserControl overrides dispose to clean up the component list.
    '****************************************************************
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing Then
                '* Unsubscribe from the subscriptions
                If _CommComponent IsNot Nothing Then
                    '* Unsubscribe from all
                    For i As Integer = 0 To SuccessfulSubscriptions.Count - 1
                        _CommComponent.UnSubscribe(SuccessfulSubscriptions(i).NotificationID)
                    Next
                    SuccessfulSubscriptions.Clear()
                End If

                m_KeypadFont.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Protected Overridable Sub OnvalueChanged(ByVal e As EventArgs)
        RaiseEvent ValueChanged(Me, e)
    End Sub
#End Region

#Region "Subscribing and PLC data receiving"
    '**************************************************
    '* Subscribe to addresses in the Comm(PLC) Driver
    '**************************************************
    Private Sub SubscribeToCommDriver()
        If Not DesignMode And IsHandleCreated Then
            '*************************
            '* Value Subscription
            '*************************
            SubscribeTo(m_PLCAddressValue, AddressOf PolledDataReturnedValue)

            '*************************
            '* Visibility Subscription
            '*************************
            If m_PLCAddressVisible <> "" Then
                Dim PLCAddress As String = m_PLCAddressVisible
                If PLCAddress.ToUpper.IndexOf("NOT ") = 0 Then
                    PLCAddress = m_PLCAddressVisible.Substring(4).Trim
                    InvertVisible = True
                Else
                    InvertVisible = False
                End If
                SubscribeTo(PLCAddress, AddressOf PolledDataReturnedVisible)
            End If
        End If
    End Sub

    Private SuccessfulSubscriptions As New List(Of SubscriptionDetail)

    '******************************************************
    '* Attempt to create a subscription to the PLC driver
    '******************************************************
    Private Sub SubscribeTo(ByVal PLCAddress As String, ByVal callBack As EventHandler(Of MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs))
        '* Check to see if the subscription has already been created
        Dim index As Integer
        While index < SuccessfulSubscriptions.Count AndAlso SuccessfulSubscriptions(index).Callback <> callBack
            index += 1
        End While

        '* Already subscribed and PLCAddress was changed, so unsubscribe
        If (index < SuccessfulSubscriptions.Count) AndAlso SuccessfulSubscriptions(index).PLCAddress <> PLCAddress Then
            _CommComponent.UnSubscribe(SuccessfulSubscriptions(index).NotificationID)
            SuccessfulSubscriptions.RemoveAt(index)
        End If

        '* Is there an address to subscribe to?
        If PLCAddress <> "" Then
            Try
                If _CommComponent IsNot Nothing Then
                    Dim NotificationID As Integer = _CommComponent.Subscribe(PLCAddress, 1, 250, callBack)

                    '* If subscription succeedded, save the subscription details
                    Dim temp As New SubscriptionDetail(PLCAddress, NotificationID, callBack)
                    SuccessfulSubscriptions.Add(temp)
                Else
                    DisplayError("CommComponent Property not set")
                End If
            Catch ex As MfgControl.AdvancedHMI.Drivers.Common.PLCDriverException
                'Me.Text = ex.Message
                '* If subscribe fails, set up for retry
                InitializeSubscribeRetry(ex, PLCAddress)
            End Try
        End If
    End Sub

    '********************************************
    '* Show the error and start the retry time
    '********************************************
    Private Sub InitializeSubscribeRetry(ByVal ex As MfgControl.AdvancedHMI.Drivers.Common.PLCDriverException, ByVal PLCAddress As String)
        If ex.ErrorCode = 1808 Then
            DisplayError("""" & PLCAddress & """ PLC Address not found")
        Else
            DisplayError(ex.Message)
        End If

        If SubscribeRetryTimer Is Nothing Then
            SubscribeRetryTimer = New Windows.Forms.Timer
            SubscribeRetryTimer.Interval = 10000
            AddHandler SubscribeRetryTimer.Tick, AddressOf Retry_Tick
        End If

        SubscribeRetryTimer.Enabled = True
    End Sub


    '********************************************
    '* Keep retrying to subscribe if it failed
    '********************************************
    Private SubscribeRetryTimer As Windows.Forms.Timer
    Private Sub Retry_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SubscribeRetryTimer.Enabled = False
        SubscribeRetryTimer.Dispose()
        SubscribeRetryTimer = Nothing

        SubscribeToCommDriver()
    End Sub

    '***************************************
    '* Call backs for returned data
    '***************************************
    Private OriginalText As String
    Private Sub PolledDataReturnedValue(ByVal sender As Object, ByVal e As MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs)
        If e.ErrorId = 0 Then
            Try
                'If e.Values(0).IndexOf("ndex") >= 0 Then
                '    Dim dbg = 0
                'End If
                Value = e.Values(0)
                intValue = Convert.ToInt32(e.Values(0))
            Catch
                DisplayError("INVALID VALUE RETURNED!")

            End Try
        Else
            DisplayError(e.ErrorMessage)
            m_Value = "---"
        End If
    End Sub


    Private Sub PolledDataReturnedVisible(ByVal sender As Object, ByVal e As MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs)
        Try
            If InvertVisible Then
                MyBase.Visible = Not CBool(e.Values(0))
            Else
                MyBase.Visible = e.Values(0)
            End If
        Catch
            DisplayError("INVALID Visibilty VALUE RETURNED!")
        End Try
    End Sub
#End Region

#Region "Error Display"
    '********************************************************
    '* Show an error via the text property for a short time
    '********************************************************
    Private ErrorDisplayTime As System.Windows.Forms.Timer
    Private ErrorLock As New Object
    Private Sub DisplayError(ByVal ErrorMessage As String)
        If Not m_SuppressErrorDisplay Then
            '* Create the error display timer
            If ErrorDisplayTime Is Nothing Then
                ErrorDisplayTime = New System.Windows.Forms.Timer
                AddHandler ErrorDisplayTime.Tick, AddressOf ErrorDisplay_Tick
                ErrorDisplayTime.Interval = 5000
            End If

            '* Save the text to return to
            SyncLock (ErrorLock)
                If Not ErrorDisplayTime.Enabled Then
                    ErrorDisplayTime.Enabled = True
                    OriginalText = MyBase.Text
                    'MyBase.Text = "err" 'ErrorMessage
                    If Not Me.Hidden Then
                        Me.ForeColor = Color.Gray
                    End If
                End If
            End SyncLock
        End If
    End Sub


    '**************************************************************************************
    '* Return the text back to its original after displaying the error for a few seconds.
    '**************************************************************************************
    Private Sub ErrorDisplay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'UpdateText()
        SyncLock (ErrorLock)
            'MyBase.Text = OriginalText
            'If ErrorDisplayTime IsNot Nothing Then
            ErrorDisplayTime.Enabled = False
            ' ErrorIsDisplayed = False
        End SyncLock
        'RemoveHandler ErrorDisplayTime.Tick, AddressOf ErrorDisplay_Tick
        'ErrorDisplayTime.Dispose()
        'ErrorDisplayTime = Nothing
        'End If
    End Sub
#End Region



End Class
