
Module MiscFunctions

    Public Class DataSetHelper
        Public ds As DataSet
        Public Sub New(ByVal DataSet As DataSet)
            ds = DataSet
        End Sub

        Public Sub New()
            ds = Nothing
        End Sub

        Private Function ColumnEqual(ByVal A As Object, ByVal B As Object) As Boolean
            '
            ' Compares two values to determine if they are equal. Also compares DBNULL.Value.
            '
            ' NOTE: If your DataTable contains object fields, you must extend this
            ' function to handle the fields in a meaningful way if you intend to group on them.
            '
            If A Is DBNull.Value And B Is DBNull.Value Then Return True ' Both are DBNull.Value.
            If A Is DBNull.Value Or B Is DBNull.Value Then Return False ' Only one is DBNull.Value.
            Return A = B                                                ' Value type standard comparison
        End Function

        Public Function SelectDistinct(ByVal TableName As String, ByVal SourceTable As DataTable, ByVal FieldName As String) As DataTable
            Dim dt As New DataTable(TableName)
            dt.Columns.Add(FieldName, SourceTable.Columns(FieldName).DataType)
            Dim dr As DataRow
            Dim LastValue As Object = Nothing
            For Each dr In SourceTable.Select("", FieldName)

                If LastValue Is Nothing OrElse Not ColumnEqual(LastValue, dr(FieldName)) Then
                    LastValue = dr(FieldName)
                    dt.Rows.Add(New Object() {LastValue})
                End If
            Next
            If Not ds Is Nothing Then ds.Tables.Add(dt)
            Return dt
        End Function
    End Class

    Sub updatetotal(sender As Object, e As EventArgs)
        Dim mcounter As Counter

        Dim totalcount As Integer
        Dim machine As Integer

        totalcount = 0
        For machine = 0 To My.Settings.NoMachines
            Try ' catch exception if counter showing error
                mcounter = CType(MainForm.Controls.Find("Counter" & machine.ToString, True)(0), Counter)
                totalcount = totalcount + Convert.ToInt32(mcounter.intValue)
            Catch
                totalcount = totalcount + 0

            End Try

        Next
        MainForm.LabelTotal.Text = Format(totalcount, "#,##0.")
        If My.Settings.SecondScreen Then
            SecondScreen.LabelSecondTotal.Text = Format(totalcount, "00,000.")
        End If

    End Sub

    Sub readplcvalues()
        Dim dateNum As Long = Date.Now.ToBinary
        Dim dateDate As Date = Date.FromBinary(dateNum)
        Dim timeStr As String = dateDate.ToString("HH:mm:ss")
        Dim total As Integer = 0
        Dim machine As Integer
        'Dim xmeter As MfgControl.AdvancedHMI.DigitalPanelMeter
        Dim meterchanged As Boolean = False


        For machine = 0 To My.Settings.NoMachines - 1
            Try
                GlobalVar.mlog(machine).machineid = My.Settings.VesselName & CStr(machine + 1)
            Catch
                GlobalVar.mlog(machine) = New machinelog
                GlobalVar.mlog(machine).machineid = My.Settings.VesselName & CStr(machine + 1)
            End Try

            GlobalVar.plc(machine).DisableSubscriptions = True
            Try
                'Read PLC Counters
                GlobalVar.mlog(machine).daycounter.Value = Convert.ToInt32(GlobalVar.plc(machine).Read(GlobalVar.mlog(machine).daycounter.address, 3)(2))
                GlobalVar.mlog(machine).lifecountl.Value = Convert.ToInt32(GlobalVar.plc(machine).Read(GlobalVar.mlog(machine).lifecountl.address, 3)(2))
                GlobalVar.mlog(machine).lifecounth.Value = Convert.ToInt32(GlobalVar.plc(machine).Read(GlobalVar.mlog(machine).lifecounth.address, 3)(2))
                GlobalVar.mlog(machine).tailtrigcount.Value = Convert.ToInt32(GlobalVar.plc(machine).Read(GlobalVar.mlog(machine).tailtrigcount.address, 3)(2))
                GlobalVar.mlog(machine).maintrigcount.Value = Convert.ToInt32(GlobalVar.plc(machine).Read(GlobalVar.mlog(machine).maintrigcount.address, 3)(2))
                GlobalVar.mlog(machine).liftcount.Value = Convert.ToInt32(GlobalVar.plc(machine).Read(GlobalVar.mlog(machine).liftcount.address, 3)(2))
                GlobalVar.mlog(machine).bellycount.Value = GlobalVar.plc(machine).Read(GlobalVar.mlog(machine).bellycount.address, 3)(2)

                'Read PLC Timers
                GlobalVar.mlog(machine).gateclosedelay.Value = Convert.ToInt32(GlobalVar.plc(machine).Read(GlobalVar.mlog(machine).gateclosedelay.address, 3)(1))
                GlobalVar.mlog(machine).hammerdelay.Value = Convert.ToInt32(GlobalVar.plc(machine).Read(GlobalVar.mlog(machine).hammerdelay.address, 3)(1))
                GlobalVar.mlog(machine).knifedelay.Value = Convert.ToInt32(GlobalVar.plc(machine).Read(GlobalVar.mlog(machine).knifedelay.address, 3)(1))
                GlobalVar.mlog(machine).knifetime.Value = Convert.ToInt32(GlobalVar.plc(machine).Read(GlobalVar.mlog(machine).knifetime.address, 3)(1))
                GlobalVar.mlog(machine).lifttime.Value = Convert.ToInt32(GlobalVar.plc(machine).Read(GlobalVar.mlog(machine).lifttime.address, 3)(1))
                GlobalVar.mlog(machine).gateopendelay.Value = Convert.ToInt32(GlobalVar.plc(machine).Read(GlobalVar.mlog(machine).gateopendelay.address, 3)(1))
                GlobalVar.mlog(machine).overridewait.Value = Convert.ToInt32(GlobalVar.plc(machine).Read(GlobalVar.mlog(machine).overridewait.address, 3)(1))
                'Dim buf = AutooverrideSet(machine)

                'Read Binary Registers
                GlobalVar.mlog(machine).autooverride.Value = Convert.ToInt32(AutooverrideSet(machine))


            Catch
                GlobalVar.mlog(machine).daycounter.Value = -1
                GlobalVar.mlog(machine).lifecountl.Value = -1
                GlobalVar.mlog(machine).lifecounth.Value = -1
                GlobalVar.mlog(machine).tailtrigcount.Value = -1
                GlobalVar.mlog(machine).maintrigcount.Value = -1
                GlobalVar.mlog(machine).liftcount.Value = -1
                GlobalVar.mlog(machine).bellycount.Value = -1

                GlobalVar.mlog(machine).gateclosedelay.Value = -1
                GlobalVar.mlog(machine).hammerdelay.Value = -1
                GlobalVar.mlog(machine).knifedelay.Value = -1
                GlobalVar.mlog(machine).knifetime.Value = -1
                GlobalVar.mlog(machine).lifttime.Value = -1
                GlobalVar.mlog(machine).gateopendelay.Value = -1
                GlobalVar.mlog(machine).autooverride.Value = -1

            End Try

            GlobalVar.plc(machine).DisableSubscriptions = False

            If GlobalVar.mlog(machine).daycounter.Value <> GlobalVar.lastcounter(machine) Then
                meterchanged = True
            End If

            GlobalVar.lastcounter(machine) = GlobalVar.mlog(machine).daycounter.Value


        Next

        If meterchanged Then writeLog(timeStr, GlobalVar.mlog)

        'for debuging only
        'writeLog(timeStr, GlobalVar.mlog)
    End Sub

    Function AutooverrideSet(machine) As Boolean

        Dim buf1 = GlobalVar.plc(machine).Read("B3:0", 1)
        Dim buf2 = CInt(buf1(0))
        Dim buf3 = ((buf2 And 8) <> 0)

        Return buf3
    End Function


End Module
