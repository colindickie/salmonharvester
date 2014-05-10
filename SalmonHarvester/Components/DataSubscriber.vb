Option Strict On
'*****************************************************************************
'* Data Subscriber
'*
'* Archie Jacobs
'* Manufacturing Automation, LLC
'* 03-MAR-13
'* http://www.advancedhmi.com
'*
'* This component is used to simplify the creation of subscriptions
'*
'* 03-MAR-13 Created
'*****************************************************************************
Imports System.ComponentModel

<DefaultEvent("DataChanged")> _
Public Class DataSubscriber
    Inherits System.ComponentModel.Component
    Implements ISupportInitialize

    Public Event DataReturned As EventHandler(Of MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs)
    Public Event DataChanged As EventHandler(Of MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs)
    Public Event ComError As EventHandler(Of MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs)
    Public Event SuccessfulSubscription As EventHandler

#Region "Basic Properties"
    Public Overrides Property Site() As ISite
        Get
            Return MyBase.Site
        End Get
        Set(value As ISite)
            MyBase.Site = value

            If (value IsNot Nothing) And m_CommComponent Is Nothing Then
                If MyBase.Site.DesignMode Then
                    '********************************************************
                    '* Search for AdvancedHMIDrivers.IComComponent component in parent form
                    '* If one exists, set the client of this component to it
                    '********************************************************
                    Dim i As Integer = 0
                    While m_CommComponent Is Nothing And i < Me.Site.Container.Components.Count
                        If Me.Site.Container.Components(i).GetType.GetInterface("AdvancedHMIDrivers.IComComponent") IsNot Nothing Then m_CommComponent = DirectCast(Me.Site.Container.Components(i), AdvancedHMIDrivers.IComComponent)
                        i += 1
                    End While

                    '************************************************
                    '* If no comm component was found, then add one and
                    '* point the CommComponent property to it
                    '*********************************************
                    If m_CommComponent Is Nothing Then
                        Me.Container.Add(New AdvancedHMIDrivers.EthernetIPforPLCSLCMicroCom)
                        m_CommComponent = DirectCast(Me.Container.Components(Me.Site.Container.Components.Count - 1), AdvancedHMIDrivers.IComComponent)
                    End If
                End If
            End If
         End Set
    End Property

    '**************************************************
    '* Its purpose is to fetch
    '* the main form in order to synchronize the
    '* notification thread/event
    '**************************************************
    Protected m_SynchronizingObject As System.ComponentModel.ISynchronizeInvoke
    '* do not let this property show up in the property window
    ' <System.ComponentModel.Browsable(False)> _
    Public Property SynchronizingObject() As System.ComponentModel.ISynchronizeInvoke
        Get
            Dim host1 As Design.IDesignerHost
            If (m_SynchronizingObject Is Nothing) AndAlso MyBase.DesignMode Then
                host1 = CType(Me.GetService(GetType(Design.IDesignerHost)), Design.IDesignerHost)
                If host1 IsNot Nothing Then
                    m_SynchronizingObject = CType(host1.RootComponent, System.ComponentModel.ISynchronizeInvoke)
                End If
            End If

            Return m_SynchronizingObject
        End Get

        Set(ByVal Value As System.ComponentModel.ISynchronizeInvoke)
            If Not Value Is Nothing Then
                m_SynchronizingObject = Value
            End If
        End Set
    End Property

    Protected m_Value As String
    Public Property Value As String
        Get
            Return m_Value
        End Get
        Set(value As String)
            m_Value = value
        End Set
    End Property

#End Region

#Region "Constructor/Destructor"
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.
        InitializeComponent()
    End Sub

    '****************************************************************
    '* Component overrides dispose to clean up the component list.
    '****************************************************************
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing Then
                '* Unsubscribe from the subscriptions
                If m_CommComponent IsNot Nothing Then
                    '* Unsubscribe from all
                    For i As Integer = 0 To SuccessfulSubscriptions.Count - 1
                        m_CommComponent.Unsubscribe(SuccessfulSubscriptions(i).NotificationID)
                    Next
                    SuccessfulSubscriptions.Clear()
                End If

                'components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Component Designer
    'Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        'components = New System.ComponentModel.Container()
    End Sub

#End Region

#Region "PLC Related Properties"
    '*****************************************************
    '* Property - Component to communicate to PLC through
    '*****************************************************
    Private m_CommComponent As AdvancedHMIDrivers.IComComponent
    <System.ComponentModel.Category("PLC Properties")> _
    Public Property CommComponent() As AdvancedHMIDrivers.IComComponent
        Get
            Return m_CommComponent
        End Get
        Set(ByVal value As AdvancedHMIDrivers.IComComponent)
            m_CommComponent = value
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
                If Not Initializing Then
                    SubscribeToCommDriver()
                End If
            End If
        End Set
    End Property
#End Region

#Region "Events"
    Private Initializing As Boolean
    Private Sub BeginInit() Implements ISupportInitialize.BeginInit
        Initializing = True
    End Sub

    Private Sub EndInit() Implements ISupportInitialize.EndInit
        Initializing = False

        If m_CommComponent IsNot Nothing Then
            SubscribeToCommDriver()
        End If
    End Sub


    Protected Overridable Sub OnDataReturned(ByVal e As MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs)
        If m_SynchronizingObject Is Nothing Then
            RaiseEvent DataReturned(Me, e)
        Else
            If DirectCast(m_SynchronizingObject, Control).IsHandleCreated Then
                Dim Parameters() As Object = {Me, e}
                SynchronizingObject.BeginInvoke(drsd, Parameters)
            End If
        End If
    End Sub

    '****************************************************************************
    '* This is required to sync the event back to the parent form's main thread
    '****************************************************************************
    Dim drsd As EventHandler(Of MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs) = AddressOf DataReturnedSync
    Private Sub DataReturnedSync(ByVal sender As Object, ByVal e As MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs)
        RaiseEvent DataReturned(Me, e)
    End Sub


    Protected Overridable Sub OnDataChanged(ByVal e As MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs)
        If m_SynchronizingObject Is Nothing Then
            RaiseEvent DataChanged(Me, e)
        Else
            If DirectCast(m_SynchronizingObject, Control).IsHandleCreated Then
                Dim Parameters() As Object = {Me, e}
                SynchronizingObject.BeginInvoke(dcsd, Parameters)
            End If
        End If
    End Sub

    '****************************************************************************
    '* This is required to sync the event back to the parent form's main thread
    '****************************************************************************
    Dim dcsd As EventHandler(Of MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs) = AddressOf DataChangedSync
    Private Sub DataChangedSync(ByVal sender As Object, ByVal e As MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs)
        RaiseEvent DataChanged(Me, e)
    End Sub


    Protected Overridable Sub OnSuccessfulSubscription(ByVal e As MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs)
        RaiseEvent SuccessfulSubscription(Me, e)
    End Sub

    Protected Overridable Sub OnComError(ByVal e As MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs)
        RaiseEvent ComError(Me, e)
    End Sub
#End Region

#Region "Subscribing and PLC data receiving"
    Private InvertValue As Boolean
    '**************************************************
    '* Subscribe to addresses in the Comm(PLC) Driver
    '**************************************************
    Private Sub SubscribeToCommDriver()
        If Not DesignMode Then
            If (m_SynchronizingObject Is Nothing OrElse DirectCast(m_SynchronizingObject, Control).IsHandleCreated) Then
                '*************************
                '* Value Subscription
                '*************************
                Dim PLCAddress As String = m_PLCAddressValue

                If m_PLCAddressValue <> "" Then
                    If PLCAddress.ToUpper.IndexOf("NOT ") = 0 Then
                        PLCAddress = PLCAddress.Substring(4).Trim
                        InvertValue = True
                    End If
                    SubscribeTo(PLCAddressValue, AddressOf PolledDataReturnedValue)
                End If
            Else
                '* The handle of the syncronizingObject has not been created yet, so delay and try again
                If SubscribeRetryTimer Is Nothing Then
                    SubscribeRetryTimer = New Windows.Forms.Timer
                    SubscribeRetryTimer.Interval = 1000
                    AddHandler SubscribeRetryTimer.Tick, AddressOf Retry_Tick
                End If

                SubscribeRetryTimer.Enabled = True
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
        While index < SuccessfulSubscriptions.Count AndAlso SuccessfulSubscriptions(index).CallBack <> callBack
            index += 1
        End While

        '* Already subscribed and PLCAddress was changed, so unsubscribe
        If (index < SuccessfulSubscriptions.Count) AndAlso SuccessfulSubscriptions(index).PLCAddress <> PLCAddress Then
            m_CommComponent.Unsubscribe(SuccessfulSubscriptions(index).NotificationID)
            SuccessfulSubscriptions.RemoveAt(index)
        End If

        '* Is there an address to subscribe to?
        If PLCAddress <> "" Then
            Try
                If m_CommComponent IsNot Nothing Then
                    Dim NotificationID As Integer = m_CommComponent.Subscribe(PLCAddress, 1, 250, callBack)

                    '* If subscription succeedded, save the subscription details
                    Dim temp As New SubscriptionDetail(PLCAddress, NotificationID, callBack)
                    SuccessfulSubscriptions.Add(temp)

                    Dim dummy(0) As String
                    OnSuccessfulSubscription(New MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs(dummy, PLCAddress, 0))
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
    Private LastValue As String
    Private Sub PolledDataReturnedValue(ByVal sender As Object, ByVal e As MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs)
        Try
            OnDataReturned(e)
            If e.Values(0) <> LastValue Then
                '* Save this value so we know if it changed without comparing the invert
                LastValue = m_Value

                If InvertValue Then
                    m_Value = CStr(Not CBool(e.Values(0)))
                Else
                    m_Value = e.Values(0)
                End If

                OnDataChanged(e)
            End If

        Catch
            DisplayError("INVALID VALUE RETURNED!")
        End Try
    End Sub
#End Region

#Region "Error Display"
    '********************************************************
    '* Show an error via the text property for a short time
    '********************************************************
    Private WithEvents ErrorDisplayTime As System.Windows.Forms.Timer
    Private Sub DisplayError(ByVal ErrorMessage As String)
        If ErrorDisplayTime Is Nothing Then
            ErrorDisplayTime = New System.Windows.Forms.Timer
            AddHandler ErrorDisplayTime.Tick, AddressOf ErrorDisplay_Tick
            ErrorDisplayTime.Interval = 5000
        End If

        '* Save the text to return to
        If Not ErrorDisplayTime.Enabled Then
            ' OriginalText = Me.Text
        End If

        OnComError(New MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs(1, ErrorMessage))

        ErrorDisplayTime.Enabled = True
    End Sub


    '**************************************************************************************
    '* Return the text back to its original after displaying the error for a few seconds.
    '**************************************************************************************
    Private Sub ErrorDisplay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ErrorDisplayTime IsNot Nothing Then
            ErrorDisplayTime.Enabled = False
            ErrorDisplayTime.Dispose()
            ErrorDisplayTime = Nothing
        End If
    End Sub
#End Region

End Class
