Option Strict On
Imports System.Threading
Imports System.Threading.Tasks
Public Class MainForm


    Public tokensource As New CancellationTokenSource
    Public token As CancellationToken = tokensource.Token


    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        If components IsNot Nothing Then
            Dim drv As AdvancedHMIDrivers.IComComponent
            '*****************************
            '* Search for comm components
            '*****************************
            For i As Integer = 0 To components.Components.Count - 1
                If components.Components(i).GetType.GetInterface("AdvancedHMIDrivers.IComComponent") IsNot Nothing Then
                    drv = CType(components.Components.Item(i), AdvancedHMIDrivers.IComComponent)
                    '* Stop/Start polling based on form visibility
                    drv.DisableSubscriptions = Not Me.Visible
                End If
            Next
        End If
    End Sub

    '************************************************************
    '* This will guarantee that even hidden forms are all closed
    '* when the main application is closed
    '************************************************************
    Private Sub DemoForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Environment.Exit(0)
    End Sub



    Sub mainrun() Handles Me.Load


        GlobalVar.currentmachine = 0

        'initialise screen
        Me.WindowState = FormWindowState.Maximized
        Dim screenwidth = Screen.PrimaryScreen.Bounds.Width
        Dim screenheight = Screen.PrimaryScreen.Bounds.Height
        TabControl1.Width = screenwidth - 40
        TabControl1.Height = screenheight - 90
        Dim counterwidth As Integer = Convert.ToInt32(Math.Min(screenwidth / My.Settings.NoMachines - 10, 500))
        Dim counterheight As Integer = Convert.ToInt32((counterwidth / 2.5))
        Dim counterfontsize As Integer = 90 - 5 * My.Settings.NoMachines

        XmlModule.xmlsetup()
        'writeLog()

        'unsure what these are.  Copied for form designer.
        'components = New System.ComponentModel.Container()
        'Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))

        For machine = 0 To My.Settings.NoMachines - 1
            GlobalVar.plc(machine) = New AdvancedHMIDrivers.EthernetIPforPLCSLCMicroCom
            GlobalVar.plc(machine).DisableSubscriptions = False


            'Swap the following lines for debugging
            GlobalVar.plc(machine).IPAddress = "192.168.1." & Trim(Convert.ToString(machine + 11))
            'GlobalVar.plc(machine).IPAddress = "192.168.1.11"

            GlobalVar.plc(machine).MyNode = 0
            GlobalVar.plc(machine).PollRateOverride = 0
            GlobalVar.plc(machine).Port = 44818
            GlobalVar.plc(machine).SynchronizingObject = Me
            GlobalVar.plc(machine).TargetNode = 0
        Next

        'draw labels and counters
        Dim mcounter(My.Settings.NoMachines - 1) As MfgControl.AdvancedHMI.Counter
        For machine = 0 To My.Settings.NoMachines - 1
            'draw counters
            mcounter(machine) = New MfgControl.AdvancedHMI.Counter
            mcounter(machine).CommComponent = GlobalVar.plc(machine)

            If My.Settings.ReverseDisplay Then
                mcounter(machine).Location = New System.Drawing.Point(counterwidth * (My.Settings.NoMachines - machine - 1), 300)
            Else
                mcounter(machine).Location = New System.Drawing.Point(counterwidth * machine, 300)
            End If


            mcounter(machine).Name = "Counter" & machine.ToString
            mcounter(machine).PLCAddressValue = "C5:0.ACC"
            'mcounter(machine).Font = New System.Drawing.Font("Let's go Digital", counterfontsize)
            mcounter(machine).Font = New System.Drawing.Font("Digital-7 Mono", counterfontsize)
            mcounter(machine).Width = counterwidth
            mcounter(machine).Height = counterheight
            mcounter(machine).PollRate = 10000
            Me.TabMain.Controls.Add(mcounter(machine))

            AddHandler mcounter(machine).ValueChanged, AddressOf updatetotal

            'draw labels
            Dim mlabel As Label
            mlabel = New Label

            If My.Settings.ReverseDisplay Then
                mlabel.Location = New System.Drawing.Point(counterwidth * (My.Settings.NoMachines - machine - 1), 250)
            Else
                mlabel.Location = New System.Drawing.Point(counterwidth * machine, 250)
            End If

            mlabel.Width = counterwidth
            mlabel.TextAlign = ContentAlignment.TopCenter
            mlabel.Font = New Font("Ariel", 11, FontStyle.Bold)
            mlabel.Text = My.Settings.VesselName & " #" & (machine + 1).ToString
            Me.TabMain.Controls.Add(mlabel)
        Next machine


        LabelTotal.Width = 247
        LabelTotal.Height = 84
        LabelTotal.Location = New System.Drawing.Point(Convert.ToInt32((Screen.PrimaryScreen.Bounds.Width - 247) / 2), 550)
        'LabelTotal.Font = New System.Drawing.Font("Let's go Digital", 62)
        LabelTotal.Font = New System.Drawing.Font("Digital-7 Mono", 62)
        LabelTotal.Text = "0"
        ShBResetAll.Location = New System.Drawing.Point(Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width / 2 + 150), 550 + 84 - 110)

        If My.Settings.SecondScreen Then

            SecondScreen.Show()
            SecondScreen.Left = 1200
            SecondScreen.WindowState = FormWindowState.Maximized
            SecondScreen.LabelSecondTotal.Width = SecondScreen.Width - 30
            SecondScreen.LabelSecondTotal.Height = Convert.ToInt32(SecondScreen.Width * 0.3 + 20)
            SecondScreen.LabelSecondTotal.Font = New System.Drawing.Font("Digital-7 Mono", Convert.ToInt32((SecondScreen.Width - 150) / 4))

        End If


        Dim updatetask As Task
        updatetask = Task.Factory.StartNew(Sub() updatecounters(token), token)
        'updatetask.Start()

    End Sub

    Sub updatecounters(cancel As CancellationToken)
        Dim machinesupdated As Integer = 0
        Dim updated As Boolean
        Me.SetText(TBmain, "Connecting....")

        For machine = 0 To My.Settings.NoMachines - 1
            If cancel.IsCancellationRequested Then Exit For
            updated = True
            Try
                Me.SetText(TabMain.Controls("Counter" & machine.ToString), "")
                Me.SetText(TabMain.Controls("Counter" & machine.ToString), Convert.ToString(GlobalVar.plc(machine).Read("C5:0", 3)(2)))
            Catch
                updated = False
                Me.SetText(TabMain.Controls("Counter" & machine.ToString), "----")
            End Try
            If Not updated Then machinesupdated = machinesupdated + 1
        Next
        If Not cancel.IsCancellationRequested Then
            If machinesupdated > 0 Then
                Me.SetText(TBmain, "Could not connect to " & machinesupdated & " machines!")
            Else
                Me.SetText(TBmain, "Connected")
            End If
        End If
    End Sub


    Sub tabchanged() Handles TabControl1.SelectedIndexChanged
        Select Case TabControl1.SelectedIndex
            Case 0 'main tab



                'If Not IsNothing(updatetask) Then updatetask.Wait()
                Try
                    tokensource.Cancel()
                    tokensource.Dispose()
                    tokensource = New CancellationTokenSource
                    token = tokensource.Token
                Catch
                    tokensource = New CancellationTokenSource
                    token = tokensource.Token
                End Try

                Dim updatetask As Task
                updatetask = Task.Factory.StartNew(Sub() updatecounters(token), token)
                'updatetask.Start()



            Case 1 'machine tab


                'Hide LifeH and LifeL counters
                CounterMachineLifeH.Hidden = True
                CounterMachineLifeH.ForeColor = Color.White
                CounterMachineLifeH.BorderStyle = BorderStyle.None
                CounterMachineLifeL.Hidden = True
                CounterMachineLifeL.ForeColor = Color.White
                CounterMachineLifeL.BorderStyle = BorderStyle.None

                'Set the order of the NU controls.  Used below to cycle through each control in turn.
                GBSettings.Controls.SetChildIndex(NUGateCloseDelay, 1)
                GBSettings.Controls.SetChildIndex(NUhammerdelay, 2)
                GBSettings.Controls.SetChildIndex(NUknifedelay, 3)
                GBSettings.Controls.SetChildIndex(NUknifetime, 4)
                GBSettings.Controls.SetChildIndex(NUlifttime, 5)
                GBSettings.Controls.SetChildIndex(NUGateOpendelay, 6)
                GBSettings.Controls.SetChildIndex(NUoverridewate, 7)

                Try
                    tokensource.Cancel()
                    tokensource.Dispose()
                    tokensource = New CancellationTokenSource
                    token = tokensource.Token
                Catch
                    tokensource = New CancellationTokenSource
                    token = tokensource.Token
                End Try


                Dim updatetask As Task
                updatetask = Task.Factory.StartNew(Sub() initialise_machinetab(token), token)

                'Dim machinetask As Task
                'machinetask = New Task(AddressOf initialise_machinetab)
                'machinetask.Start()

                Dim toolTip1 As New ToolTip()

                ' Set up the delays for the ToolTip.
                toolTip1.AutoPopDelay = 50000
                toolTip1.InitialDelay = 500
                toolTip1.ReshowDelay = 50
                ' Force the ToolTip text to be displayed whether or not the form is active.
                toolTip1.ShowAlways = True

                ' Set up the ToolTip text for the Button and Checkbox.
                toolTip1.SetToolTip(Label39, "Delay between Tailgate Trigger activating and the Tail Gate closing")
                toolTip1.SetToolTip(Label15, "Delay from the Main Trigger activating and the Hammer activating")
                toolTip1.SetToolTip(Label16, "Delay from the Hammer activating and the Knife activating")
                toolTip1.SetToolTip(Label17, "Time the Knife is activated")
                toolTip1.SetToolTip(Label18, "Time the Lift Cylinder is activated")
                toolTip1.SetToolTip(Label19, "Delay from the Lift Cylinder activating and the Tail Gate opening")
                toolTip1.SetToolTip(CBMachineAutoOverride, "When set, if the Tailgate trigger is activated and the Main Trigger is not activated in the alloted time then the machine will run through its complete cycle and reset.")

                'machinetask.Wait()
                'LabMachine.Text = My.Settings.VesselName & " #" & (GlobalVar.currentmachine + 1).ToString
                machine_show()

            Case 2 'log tab

                Try
                    tokensource.Cancel()
                    tokensource.Dispose()
                    tokensource = New CancellationTokenSource
                    token = tokensource.Token
                Catch
                    tokensource = New CancellationTokenSource
                    token = tokensource.Token
                End Try

                DateTimePickerLog.Value = Date.Now

            Case 3 'chart tab

                Try
                    tokensource.Cancel()
                    tokensource.Dispose()
                    tokensource = New CancellationTokenSource
                    token = tokensource.Token
                Catch
                    tokensource = New CancellationTokenSource
                    token = tokensource.Token
                End Try

                GlobalVar.chartloaded = False
                loadchartdata()
                drawchart()

            Case 4 'report tab

                Try
                    tokensource.Cancel()
                    tokensource.Dispose()
                    tokensource = New CancellationTokenSource
                    token = tokensource.Token
                Catch
                    tokensource = New CancellationTokenSource
                    token = tokensource.Token
                End Try

            Case 5 'settings tab

                Try
                    tokensource.Cancel()
                    tokensource.Dispose()
                    tokensource = New CancellationTokenSource
                    token = tokensource.Token
                Catch
                    tokensource = New CancellationTokenSource
                    token = tokensource.Token
                End Try

                TBVessel.Text = My.Settings.VesselName
                TBNoMachines.Text = My.Settings.NoMachines.ToString
                TBLogPath.Text = My.Settings.LogPath
                CBSecondScreen.Checked = My.Settings.SecondScreen
                TBGateCloseDelay.Text = My.Settings.GateCloseDelay.ToString
                TBHammerDelay.Text = My.Settings.HammerDelay.ToString
                TBKnifeDelay.Text = My.Settings.KnifeDelay.ToString
                TBKnifeTime.Text = My.Settings.KnifeTime.ToString
                TBLiftTime.Text = My.Settings.LiftTime.ToString
                TBGateOpenDelay.Text = My.Settings.GateOpenDelay.ToString
                CBSettingsAutooverride.Checked = My.Settings.AutoOverride
                TBoverridewait.Text = My.Settings.OverrideWait.ToString
                CBReverseDisplay.Checked = My.Settings.ReverseDisplay





            Case 6 'help tab

                Try
                    tokensource.Cancel()
                    tokensource.Dispose()
                    tokensource = New CancellationTokenSource
                    token = tokensource.Token
                Catch
                    tokensource = New CancellationTokenSource
                    token = tokensource.Token
                End Try

                LbHelpVersion.Text = GlobalVar.version
        End Select

    End Sub

    Private Sub ShBResetAll_Down(sender As Object, e As EventArgs) Handles ShBResetAll.MouseDown
        Dim machine As Integer
        For machine = 0 To My.Settings.NoMachines - 1
            Try
                GlobalVar.plc(machine).Write("B3:0/1", 1)
            Catch
                'MsgBox("Not Connected to machine: " & My.Settings.VesselName & "#" & machine + 1)
                Exit For
            End Try

        Next
    End Sub
    Private Sub ShBResetAll_Up(sender As Object, e As EventArgs) Handles ShBResetAll.MouseUp
        Dim machine As Integer
        For machine = 0 To My.Settings.NoMachines - 1
            Try
                GlobalVar.plc(machine).Write("B3:0/1", 0)
            Catch
                'MsgBox("Not Connected to machine: " & My.Settings.VesselName & "#" & machine + 1)
                Exit For
            End Try

        Next
    End Sub

#Region "machine tab"





    Delegate Sub SetValueCallback(_nud As NumericUpDown, newvalue As Int32)
    Private Sub SetValue(nud As NumericUpDown, ByVal newvalue As Int32)
        If nud.InvokeRequired Then
            Dim d As New SetValueCallback(AddressOf SetValue)
            Me.Invoke(d, New Object() {nud, newvalue})
        Else
            nud.Value = newvalue
        End If
    End Sub

    Delegate Sub SetEnabledCallback(_nud As NumericUpDown, enabled As Boolean)
    Private Sub SetEnabled(nud As NumericUpDown, ByVal enabled As Boolean)
        If nud.InvokeRequired Then
            Dim d As New SetEnabledCallback(AddressOf SetEnabled)
            Me.Invoke(d, New Object() {nud, enabled})
        Else
            nud.Enabled = enabled
        End If
    End Sub

    Delegate Sub SetButtonEnabledCallback(_nud As SHButton, enabled As Boolean)
    Private Sub SetEnabled(nud As SHButton, ByVal enabled As Boolean)
        If nud.InvokeRequired Then
            Dim d As New SetButtonEnabledCallback(AddressOf SetEnabled)
            Me.Invoke(d, New Object() {nud, enabled})
        Else
            nud.Enabled = enabled
        End If
    End Sub


    Delegate Sub SetColourCallback(_nud As Control, newcolour As Color)
    Private Sub SetColour(nud As Control, ByVal newcolour As Color)
        If nud.InvokeRequired Then
            Dim d As New SetColourCallback(AddressOf SetColour)
            Me.Invoke(d, New Object() {nud, newcolour})
        Else
            nud.ForeColor = newcolour
        End If
    End Sub

    Delegate Sub SetTextCallback(_nud As Control, newtext As String)
    Private Sub SetText(nud As Control, ByVal newtext As String)
        If nud.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {nud, newtext})
        Else
            nud.Text = newtext
        End If
    End Sub

    Delegate Sub SetCheckCallback(_cb As CheckBox, newcheck As Boolean)
    Private Sub SetChecked(cb As CheckBox, ByVal newcheck As Boolean)
        If cb.InvokeRequired Then
            Dim d As New SetCheckCallback(AddressOf SetChecked)
            Me.Invoke(d, New Object() {cb, newcheck})
        Else
            cb.Checked = newcheck
        End If
    End Sub



    Sub initialise_machinetab(cancel As CancellationToken) 'Handles TabMachine.Paint

        Me.SetText(LabMachine, "Connecting to " & My.Settings.VesselName & " #" & GlobalVar.currentmachine + 1 & ".....")
        'AddHandler CounterMachineLifeL.ValueChanged, AddressOf updatelifecounter
        'AddHandler CounterMachineLifeH.ValueChanged, AddressOf updatelifecounter

        Dim machine As Int32 = GlobalVar.currentmachine
        Dim controlindex As Int32 = 7
        Dim mladdress As machinelog = New machinelog
        Dim dataaddress As String
        Dim readvalue As Int32

        'Set each setting to defaults using Threadsafe methods
        Me.SetValue(NUGateCloseDelay, My.Settings.GateCloseDelay)
        Me.SetValue(NUhammerdelay, My.Settings.HammerDelay)
        Me.SetValue(NUknifedelay, My.Settings.KnifeDelay)
        Me.SetValue(NUknifetime, My.Settings.KnifeTime)
        Me.SetValue(NUlifttime, My.Settings.LiftTime)
        Me.SetValue(NUGateOpendelay, My.Settings.GateOpenDelay)
        Me.SetValue(NUoverridewate, My.Settings.OverrideWait)
        Me.SetEnabled(NUoverridewate, My.Settings.AutoOverride)
        Me.SetChecked(CBMachineAutoOverride, My.Settings.AutoOverride)
        Me.SetEnabled(ShBReset, False)


        'Cycle through each NU control and attempt to set its value from the PLC
        'see above for setting the order of the controls
        For Each c As Control In GBSettings.Controls
            If cancel.IsCancellationRequested Then GoTo end_machine_initialisation
            If TypeOf c Is NumericUpDown Then
                Dim nu As NumericUpDown = DirectCast(c, NumericUpDown)
                Try
                    controlindex = controlindex + 1
                    dataaddress = mladdress.index(controlindex).address
                    Dim buf1() = GlobalVar.plc(machine).Read(dataaddress, 3)
                    readvalue = CInt(buf1(1))
                    Me.SetValue(nu, readvalue)
                    Me.SetColour(nu, Color.Red)
                Catch ex As Exception
                    Me.SetColour(nu, Color.LightGray)
                End Try
            End If
        Next

        If cancel.IsCancellationRequested Then GoTo end_machine_initialisation
        'Attempt to read AutoOverride state from PLC
        Try
            dataaddress = mladdress.autooverride.address
            Dim buf3 = AutooverrideSet(machine)
            Me.SetChecked(CBMachineAutoOverride, buf3)
        Catch
            Me.SetChecked(CBMachineAutoOverride, My.Settings.AutoOverride)
            Me.SetEnabled(NUoverridewate, My.Settings.AutoOverride)
        End Try

        If cancel.IsCancellationRequested Then GoTo end_machine_initialisation
        Try

            Me.SetText(CounterMachineDay, GlobalVar.plc(machine).Read("C5:0", 3)(2))
            Me.SetText(CounterMachineLifeL, GlobalVar.plc(machine).Read("C5:1", 3)(2))
            Me.SetText(CounterMachineLifeH, GlobalVar.plc(machine).Read("C5:2", 3)(2))

            updatelifecounter()
            Me.SetColour(CounterMachineDay, Color.Red)
            Me.SetColour(CounterMachineLife, Color.Red)

            ShBReset.CommComponent = GlobalVar.plc(GlobalVar.currentmachine)

            Me.SetText(LabMachine, My.Settings.VesselName & " #" & (GlobalVar.currentmachine + 1).ToString & " connected")
            Me.SetEnabled(ShBReset, True)
        Catch ex As Exception
            'if communication with PLC fails then greyout counters and display message


            Me.SetColour(CounterMachineDay, Color.Gray)
            Me.SetColour(CounterMachineLife, Color.Gray)
            'ShBReset.Enabled = False
            Me.SetEnabled(ShBReset, False)
            Me.SetText(LabMachine, "Not Connected")
        End Try

        Dim repeatcycletime As Integer
        draw_timing(Convert.ToInt32(NUGateCloseDelay.Value), Convert.ToInt32(NUhammerdelay.Value), Convert.ToInt32(NUknifedelay.Value), Convert.ToInt32(NUknifetime.Value), Convert.ToInt32(NUlifttime.Value), Convert.ToInt32(NUGateOpendelay.Value), repeatcycletime)
        Me.SetText(LabelRepeat, "Repeat Cycle:" & repeatcycletime.ToString & "ms Approx.")

end_machine_initialisation:




    End Sub

    Sub updatelifecounter() '(sender As Object, e As EventArgs)
        Try
            If CounterMachineLifeH.Text <> "0" Or CounterMachineLifeL.Text <> "0" Then
                Me.SetText(CounterMachineLife, Convert.ToString(Convert.ToInt32(CounterMachineLifeH.Text) * 32767 + Convert.ToInt32(CounterMachineLifeL.Text)))
                Me.SetColour(CounterMachineLife, Color.Red)
            Else
                Me.SetText(CounterMachineLife, "0")
                Me.SetColour(CounterMachineLife, Color.Gray)
            End If
        Catch
            Me.SetText(CounterMachineLife, "0")
            Me.SetColour(CounterMachineLife, Color.Gray)
        End Try

    End Sub

    Sub machine_show()

        Dim repeatcycle As Integer
        draw_timing(CInt(NUGateCloseDelay.Value), CInt(NUhammerdelay.Value), CInt(NUknifedelay.Value), CInt(NUknifetime.Value), CInt(NUlifttime.Value), CInt(NUGateOpendelay.Value), repeatcycle)
        'LabelRepeat.Text = "Repeat Cycle:" & repeatcycle.ToString("0") & "ms Approx."
        Me.SetText(LabelRepeat, "Repeat Cycle:" & repeatcycle.ToString("0") & "ms Approx.")

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NUGateCloseDelay.ValueChanged, NUhammerdelay.ValueChanged, NUknifedelay.ValueChanged, NUknifetime.ValueChanged, NUlifttime.ValueChanged, NUGateOpendelay.ValueChanged


        Dim repeatcycle As Integer

        draw_timing(CInt(NUGateCloseDelay.Value), CInt(NUhammerdelay.Value), CInt(NUknifedelay.Value), CInt(NUknifetime.Value), CInt(NUlifttime.Value), CInt(NUGateOpendelay.Value), repeatcycle)
        'LabelRepeat.Text = "Repeat Cycle:" & repeatcycle.ToString("0") & "ms Approx."
        Me.SetText(LabelRepeat, "Repeat Cycle:" & repeatcycle.ToString("0") & "ms Approx.")

        ShBReset.Refresh()
        'ShBTailtrigger.Refresh()
    End Sub

    Private Sub Autooverride_changes() Handles CBMachineAutoOverride.CheckStateChanged
        Me.SetEnabled(NUoverridewate, CBMachineAutoOverride.Checked)
    End Sub


    Private Sub ButPrev_Click(sender As Object, e As EventArgs) Handles ButPrev.Click

        tokensource.Cancel()
        tokensource.Dispose()
        tokensource = New CancellationTokenSource
        token = tokensource.Token

        Dim updatetask As Task
        updatetask = Task.Factory.StartNew(Sub() initialise_machinetab(token), token)

        'Dim machinetask As Task
        'machinetask = New Task(AddressOf initialise_machinetab)
        'machinetask.Start()

        GlobalVar.currentmachine = GlobalVar.currentmachine - 1
        If GlobalVar.currentmachine < 0 Then
            GlobalVar.currentmachine = My.Settings.NoMachines - 1
        End If

        ShBReset.Refresh()

        'machinetask.Wait()


    End Sub

    Private Sub ButNext_Click(sender As Object, e As EventArgs) Handles ButNext.Click

        tokensource.Cancel()
        tokensource.Dispose()
        tokensource = New CancellationTokenSource
        token = tokensource.Token

        Dim updatetask As Task
        updatetask = Task.Factory.StartNew(Sub() initialise_machinetab(token), token)

        'Dim machinetask As Task
        'machinetask = New Task(AddressOf initialise_machinetab)
        'machinetask.Start()

        GlobalVar.currentmachine = GlobalVar.currentmachine + 1
        If GlobalVar.currentmachine >= My.Settings.NoMachines Then
            GlobalVar.currentmachine = 0
        End If
        'initialise_machinetab()
        ShBReset.Refresh()

        ' machinetask.Wait()

    End Sub

    Private Sub ButtonSaveTimings_Click(sender As Object, e As EventArgs) Handles ButtonSaveTimings.Click

        Try
            GlobalVar.plc(GlobalVar.currentmachine).Write("T4:7/PRE", NUGateCloseDelay.Value)
            GlobalVar.plc(GlobalVar.currentmachine).Write("T4:0/PRE", NUhammerdelay.Value)
            GlobalVar.plc(GlobalVar.currentmachine).Write("T4:1/PRE", NUknifedelay.Value)
            GlobalVar.plc(GlobalVar.currentmachine).Write("T4:2/PRE", NUknifetime.Value)
            GlobalVar.plc(GlobalVar.currentmachine).Write("T4:3/PRE", NUlifttime.Value)
            GlobalVar.plc(GlobalVar.currentmachine).Write("T4:4/PRE", NUGateOpendelay.Value)
            GlobalVar.plc(GlobalVar.currentmachine).Write("B3:0/3", Convert.ToInt32(CBMachineAutoOverride.Checked))
            MsgBox("Timmings Saved to PLC")
        Catch ex As Exception
            MsgBox("Timings Not Saved:" & vbCrLf & ex.Message)
        End Try
    End Sub





#End Region

#Region "log tab"

    Private Sub DateTimePickerLog_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerLog.ValueChanged
        LogDateChanged()
    End Sub


#End Region

#Region "chart tab"

    Private Sub StartTime_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerStart.Leave
        If DateTimePickerStart.Value.Date <> GlobalVar.chartstart.Date Then
            GlobalVar.chartstart = DateTimePickerStart.Value.Date
            loadchartdata()
            drawchart()
            DateTimePickerEnd.Value = GlobalVar.chartend
        End If
        If DateTimePickerStart.Value < DateTimePickerEnd.Value Then
            If GlobalVar.chartloaded Then
                Rechart()
            End If
        Else
            'DateTimePickerStart.Value = DateTimePickerEnd.Value
        End If
    End Sub

    Private Sub EndTime_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerEnd.Leave
        If DateTimePickerEnd.Value > DateTimePickerStart.Value Then
            If GlobalVar.chartloaded Then
                Rechart()
            End If
        Else
            'DateTimePickerEnd.Value = DateTimePickerStart.Value
        End If
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        Dim i As Integer
        Try
            For i = 0 To GlobalVar.chartmachines
                Chart1.Series(i).Enabled = CBool(CheckedListBox1.GetItemCheckState(i))
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ButtonSR_Click(sender As Object, e As EventArgs) Handles ButtonResetStart.Click
        DateTimePickerStart.Value = GlobalVar.chartstart
        Rechart()

    End Sub


    Private Sub ButtonER_Click(sender As Object, e As EventArgs) Handles ButtonResetEnd.Click
        DateTimePickerEnd.Value = GlobalVar.chartend
        Rechart()
    End Sub

#End Region

#Region "report tab"

    Private Sub ButtonAddVessel_Click(sender As Object, e As EventArgs) Handles ButtonAddVessel.Click
        ViewVessel.Show()
        ViewVessel.VesselTBindingNavigator.AddNewItem.PerformClick()
    End Sub

    Private Sub ButtonAddSite_Click(sender As Object, e As EventArgs) Handles ButtonAddSite.Click
        ViewSite.Show()
        ViewSite.SiteTBindingNavigator.AddNewItem.PerformClick()
    End Sub
    Private Sub ButtonAddPort_Click(sender As Object, e As EventArgs) Handles ButtonAddPort.Click
        ViewPort.Show()
        ViewPort.PortTBindingNavigator.AddNewItem.PerformClick()
    End Sub
    Private Sub ButtonAddSkipper_Click(sender As Object, e As EventArgs) Handles ButtonAddSkipper.Click
        ViewSkipper.Show()
        ViewSkipper.SkipperTBindingNavigator.AddNewItem.PerformClick()
    End Sub
    Private Sub ButtonAddRep_Click(sender As Object, e As EventArgs) Handles ButtonAddRep.Click
        ViewRep.Show()
        ViewRep.RepTBindingNavigator.AddNewItem.PerformClick()
    End Sub

    Private Sub ViewHarvest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ClientDS.ReadXml(My.Settings.LogPath & GlobalVar.harvestdb)
        Catch ex As Exception
            MsgBox("Cannot Load Harvest Database")
        End Try

    End Sub
    Private Sub AverageWeightTextBox_TextChanged(sender As Object, e As EventArgs) Handles AverageWeightTextBox.TextChanged
        Dim avweight, fishcount As Single
        Try
            avweight = CSng(AverageWeightTextBox.Text)
            fishcount = CSng(FishCountTextBox.Text)
            TBBiomass.Text = Format(avweight * fishcount, "#,##0.")
        Catch
            TBBiomass.Text = ""
        End Try
    End Sub

    Private Sub FishCountTextBox_TextChanged(sender As Object, e As EventArgs) Handles FishCountTextBox.TextChanged
        Dim avweight, fishcount As Single
        Try
            avweight = CSng(AverageWeightTextBox.Text)
            fishcount = CSng(FishCountTextBox.Text)
            TBBiomass.Text = Format(avweight * fishcount, "#,##0.")
        Catch
            TBBiomass.Text = ""
        End Try
    End Sub

    Private Sub fishcount_format() Handles FishCountTextBox.Validated
        Dim fishcount As Single = CSng(FishCountTextBox.Text)
        FishCountTextBox.Text = Format(fishcount, "#,##0.")
    End Sub
    Private Sub HarvestTBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles HarvestTBindingNavigatorSaveItem.Click
        HarvestTBindingSource.EndEdit()
        ClientDS.WriteXml(My.Settings.LogPath & GlobalVar.harvestdb)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonPrint.Click
        HarvestReport.TBBiomass.Text = TBBiomass.Text

        HarvestReport.Show()

    End Sub


    Private Sub ButtonCreatePDF_Click(sender As Object, e As EventArgs)
        ' Hide the print button

        ButtonAddRep.Visible = False
        ButtonAddSite.Visible = False
        ButtonAddVessel.Visible = False

        HarvestTBindingNavigator.Visible = False


        ' Restore the print button
        ButtonAddRep.Visible = True
        ButtonAddSite.Visible = True
        ButtonAddVessel.Visible = True

        HarvestTBindingNavigator.Visible = True

    End Sub

#End Region


#Region "Settings Tab"
    Private Sub TBLogPath_TextChanged(sender As Object, e As EventArgs) Handles TBLogPath.Enter
        FolderBrowserDialog1.ShowNewFolderButton = False
        FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyDocuments
        FolderBrowserDialog1.SelectedPath = TBLogPath.Text
        'FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TBLogPath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Save_Settings() Handles ButtonSaveSettings.Click
        My.Settings.VesselName = TBVessel.Text
        My.Settings.NoMachines = Convert.ToInt32(TBNoMachines.Text)
        My.Settings.LogPath = TBLogPath.Text
        My.Settings.SecondScreen = CBSecondScreen.Checked
        My.Settings.GateCloseDelay = Convert.ToInt32(TBGateCloseDelay.Text)
        My.Settings.HammerDelay = Convert.ToInt32(TBHammerDelay.Text)
        My.Settings.KnifeDelay = Convert.ToInt32(TBKnifeDelay.Text)
        My.Settings.KnifeTime = Convert.ToInt32(TBKnifeTime.Text)
        My.Settings.LiftTime = Convert.ToInt32(TBLiftTime.Text)
        My.Settings.GateOpenDelay = Convert.ToInt32(TBGateOpenDelay.Text)
        My.Settings.AutoOverride = CBSettingsAutooverride.Checked
        My.Settings.OverrideWait = Convert.ToInt32(TBoverridewait.Text)
        My.Settings.ReverseDisplay = CBReverseDisplay.Checked
        My.Settings.Save()
        MsgBox("Settings Saved.  Please restart")
    End Sub


#End Region




    Private Sub TimerMain_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerLog.Tick

        Dim logtask As Task

        logtask = New Task(AddressOf readplcvalues)
        logtask.Start()

        logtask.Wait()
    End Sub

    Private Sub ShBResetAll_Up(sender As Object, e As MouseEventArgs) Handles ShBResetAll.MouseUp

    End Sub
    Private Sub ShBResetAll_Down(sender As Object, e As MouseEventArgs) Handles ShBResetAll.MouseDown

    End Sub
End Class




