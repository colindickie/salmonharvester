﻿'****************************************************************************
'* Archie Jacobs
'* Manufacturing Automation, LLC
'* ajacobs@mfgcontrol.com
'* 25-SEP-11
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
'* 22-SEP-11 Created
'****************************************************************************
Public Class MessageDisplayByBit
    Inherits MfgControl.AdvancedHMI.Controls.MessageDisplayByBit


#Region "Properties"

    '    '******************************************************************************************
    '    '* Use the base control's text property and make it visible as a property on the designer
    '    '******************************************************************************************
    '    <System.ComponentModel.Browsable(True)> _
    '<System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)> _
    'Public Overrides Property Text() As String
    '        Get
    '            Return MyBase.Text
    '        End Get
    '        Set(ByVal value As String)
    '            If m_Format <> "" And (Not DesignMode) Then
    '                Try
    '                    MyBase.Text = Format(CSng(value) * _ValueScaleFactor, m_Format)
    '                Catch ex As Exception
    '                    MyBase.Text = "Check NumericFormat and variable type"
    '                End Try
    '            Else
    '                '* Highlight in red if an exclamation mark is in text
    '                If InStr(value, "!") > 0 Then
    '                    If MyBase.BackColor <> _Highlightcolor Then SavedBackColor = MyBase.BackColor
    '                    MyBase.BackColor = _Highlightcolor
    '                Else
    '                    If SavedBackColor <> Nothing Then MyBase.BackColor = SavedBackColor
    '                End If

    '                If _ValueScaleFactor = 1 Then
    '                    MyBase.Text = value
    '                Else
    '                    MyBase.Text = value * _ValueScaleFactor
    '                End If
    '            End If
    '        End Set
    '    End Property




    '*****************************************************
    '* Property - Component to communicate to PLC through
    '*****************************************************
    Private _CommComponent As AdvancedHMIDrivers.IComComponent
    Public Property CommComponent() As AdvancedHMIDrivers.IComComponent
        Get
            Return _CommComponent
        End Get
        Set(ByVal value As AdvancedHMIDrivers.IComComponent)
            _CommComponent = value
        End Set
    End Property


    '*****************************************
    '* Property - Address in PLC to Link to
    '*****************************************
    Private InvertVisible As Boolean
    Private m_PLCAddressVisible As String = ""
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
    '* Property - Address in PLC to Link to
    '*****************************************
    Private NotificationIDValue As Integer
    Private m_PLCAddressValue As String = ""
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

#End Region

#Region "Events"
    'Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
    'End Sub

    '********************************************************************
    '* When an instance is added to the form, set the comm component
    '* property. If a comm component does not exist, add one to the form
    '********************************************************************
    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()

        If Me.DesignMode Then
            '********************************************************
            '* Search for AdvancedHMIDrivers.IComComponent component in parent form
            '* If one exists, set the client of this component to it
            '********************************************************
            Dim i = 0
            Dim j As Integer = Me.Parent.Site.Container.Components.Count
            While _CommComponent Is Nothing And i < j
                If Me.Parent.Site.Container.Components(i).GetType.GetInterface("AdvancedHMIDrivers.IComComponent") IsNot Nothing Then _CommComponent = Me.Parent.Site.Container.Components(i)
                i += 1
            End While

            '************************************************
            '* If no comm component was found, then add one and
            '* point the CommComponent property to it
            '*********************************************
            If _CommComponent Is Nothing Then
                Me.Parent.Site.Container.Add(New AdvancedHMIDrivers.EthernetIPforPLCSLCMicroCom)
                _CommComponent = Me.Parent.Site.Container.Components(Me.Parent.Site.Container.Components.Count - 1)
            End If
        Else
            SubscribeToCommDriver()
        End If
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
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
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
            '* Visbility Subscription
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
            Catch ex As MfgControl.AdvancedHMI.Drivers.common.PLCDriverException
                '* If subscribe fails, set up for retry
                InitializeSubscribeRetry(ex, PLCAddress)
            End Try
        End If
    End Sub

    '********************************************
    '* Show the error and start the retry time
    '********************************************
    Private Sub InitializeSubscribeRetry(ByVal ex As MfgControl.AdvancedHMI.Drivers.common.PLCDriverException, ByVal PLCAddress As String)
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
    Private Sub PolledDataReturnedVisible(ByVal sender As Object, ByVal e As MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs)
        Try
            If InvertVisible Then
                MyBase.Visible = Not CBool(e.Values(0))
            Else
                MyBase.Visible = e.Values(0)
            End If
        Catch
            DisplayError(e.Values(0) & "-INVALID Visibilty VALUE RETURNED!")
        End Try
    End Sub


    Private Sub PolledDataReturnedValue(ByVal sender As Object, ByVal e As MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs)
        Try
            MyBase.Value = e.Values(0)
        Catch
            DisplayError(e.Values(0) & "-INVALID VALUE RETURNED!")
        End Try
    End Sub
#End Region

    '********************************************************
    '* Show an error via the text property for a short time
    '********************************************************
    Private OriginalText As String
    Private WithEvents ErrorDisplayTime As System.Windows.Forms.Timer
    Private Sub DisplayError(ByVal ErrorMessage As String)
        If ErrorDisplayTime Is Nothing Then
            ErrorDisplayTime = New System.Windows.Forms.Timer
            AddHandler ErrorDisplayTime.Tick, AddressOf ErrorDisplay_Tick
            ErrorDisplayTime.Interval = 5000
        End If

        '* Save the text to return to
        If Not ErrorDisplayTime.Enabled Then
            OriginalText = Me.Text
        End If

        ErrorDisplayTime.Enabled = True

        Me.Text = ErrorMessage
    End Sub


    '**************************************************************************************
    '* Return the text back to its original after displaying the error for a few seconds.
    '**************************************************************************************
    Private Sub ErrorDisplay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Text = OriginalText

        If ErrorDisplayTime IsNot Nothing Then
            ErrorDisplayTime.Enabled = False
            ErrorDisplayTime.Dispose()
            ErrorDisplayTime = Nothing
        End If
    End Sub

End Class
