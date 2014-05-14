Module ChartModule

    Sub drawchart()
        Dim machine As Integer
        MainForm.DateTimePickerStart.Value = GlobalVar.chartstart '+ " " + TimeSerial(GlobalVar.chartstart.Hour, GlobalVar.chartstart.Minute, GlobalVar.chartstart.Second)
        MainForm.DateTimePickerEnd.Value = GlobalVar.chartend '+ " " + TimeSerial(GlobalVar.chartend.Hour, GlobalVar.chartend.Minute, GlobalVar.chartend.Second)

        MainForm.Chart1.Series.Clear()

        'add machine series to Chart1
        Dim machineseries As System.Windows.Forms.DataVisualization.Charting.Series
        For machine = 0 To (GlobalVar.chartmachines)
            machineseries = New DataVisualization.Charting.Series
            machineseries.Name = GlobalVar.distinctmachines(machine)
            machineseries.Points.DataBind(GlobalVar.chartview, "Time", GlobalVar.distinctmachines(machine), Nothing)
            machineseries.ChartType = DataVisualization.Charting.SeriesChartType.Line
            machineseries.XValueType = DataVisualization.Charting.ChartValueType.Time
            machineseries.BorderWidth = 2
            MainForm.Chart1.Series.Add(machineseries)
        Next

        MainForm.Chart1.Series("Total").ChartArea = "Total"
        MainForm.Chart1.Series("Total").BorderWidth = 3
        MainForm.Chart1.Series("Total").Color = Color.Red

        'clear existing items from cheklistbox
        MainForm.CheckedListBox1.Items.Clear()
        'populate checklistbox
        For machine = 0 To GlobalVar.chartmachines
            MainForm.CheckedListBox1.Items.Add(GlobalVar.distinctmachines(machine))
            MainForm.CheckedListBox1.SetItemChecked(machine, True)
        Next

        MainForm.Chart1.Text = "Production Chart"
        MainForm.Chart1.Titles("MainTitle").Text = GlobalVar.chartstart.ToString("dddd dd-MMM-yyyy")
        GlobalVar.chartloaded = True
        Calc_Summary("")
    End Sub

    Sub Rechart()
        Dim machine As Integer



        Dim filter As String = "[Time] > #" & MainForm.DateTimePickerStart.Value.Hour.ToString("D2") & ":" & MainForm.DateTimePickerStart.Value.Minute.ToString("D2") & ":" & MainForm.DateTimePickerStart.Value.Second.ToString("D2") & "# AND [Time] < #" & MainForm.DateTimePickerEnd.Value.Hour.ToString("D2") & ":" & MainForm.DateTimePickerEnd.Value.Minute.ToString("D2") & ":" & MainForm.DateTimePickerEnd.Value.Second.ToString("D2") & "#"
        'Dim filter As String = "Time > #13:30:00# AND Time < #15:00:00#"
        GlobalVar.chartview.RowFilter = filter
        'reassign chartView to each series on chart
        Try
            For machine = 0 To (GlobalVar.chartmachines - 1)
                MainForm.Chart1.Series(machine).Points.DataBind(GlobalVar.chartview, "Time", Str(machine + 1), Nothing)
            Next
            MainForm.Chart1.Series("Total").Points.DataBind(GlobalVar.chartview, "Time", "Total", Nothing)
        Catch ex As Exception
            loadchartdata()
            drawchart()

            For machine = 0 To (GlobalVar.chartmachines - 1)
                MainForm.Chart1.Series(machine).Points.DataBind(GlobalVar.chartview, "Time", Str(machine + 1), Nothing)
            Next
            MainForm.Chart1.Series("Total").Points.DataBind(GlobalVar.chartview, "Time", "Total", Nothing)
        End Try

        Calc_Summary(filter)
    End Sub


   

    Private Sub Calc_Summary(filter As String) ' Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rowcounter As Integer
        Dim machine As Integer
        Dim maxrows As Integer
        Dim mstarts As System.DateTime
        Dim mends As System.DateTime
        Dim mtime As TimeSpan
        Dim mtotals(0 To GlobalVar.chartmachines) As Single
        Dim maverage(0 To GlobalVar.chartmachines) As Single
        Dim mmax(0 To GlobalVar.chartmachines) As Single
        Dim temp As Single

        'create and configure summary table
        Dim sumds As DataSet = New DataSet
        Dim sumdt As DataTable = sumds.Tables.Add("Summary")
        Dim newrow As DataRow
        sumdt.Columns.Add("Machine")
        sumdt.Columns.Add("Total")
        sumdt.Columns.Add("Average")
        sumdt.Columns.Add("Maximum")
        sumdt.Columns("Average").DataType = GetType(Decimal)

        GlobalVar.chartview.RowFilter = filter
        maxrows = GlobalVar.chartview.Count
        Try
            'mtotals = Nothing
            mstarts = GlobalVar.chartview.Item(0).Item(0)
            mends = GlobalVar.chartview.Item(maxrows - 1).Item(0)
            mtime = mends - mstarts
            'find max values
            For rowcounter = 0 To maxrows - 1
                For machine = 0 To GlobalVar.chartmachines
                    temp = GlobalVar.chartview.Item(rowcounter).Row.Item(machine + 1)
                    mtotals(machine) = mtotals(machine) + temp
                    If temp > mmax(machine) Then mmax(machine) = temp
                Next
            Next

            For machine = 0 To GlobalVar.chartmachines
                newrow = sumdt.NewRow
                If machine = GlobalVar.chartmachines Then
                    newrow.Item("Machine") = "Total"
                Else
                    'Dim dub = GlobalVar.chartview.Table.Columns(machine + 1)
                    newrow.Item("Machine") = GlobalVar.chartview.Table.Columns(machine + 1) 'My.Settings.VesselName & CStr(machine + 1)
                End If

                newrow.Item("Total") = CStr(mtotals(machine))
                newrow.Item("Average") = CStr(mtotals(machine) / (mtime.Hours * 60 + mtime.Minutes))
                newrow.Item("Maximum") = CStr(mmax(machine))
                sumdt.Rows.Add(newrow)
            Next

            
            MainForm.DataGridViewChart.DataSource = sumds
            MainForm.DataGridViewChart.DataMember = "Summary"
            MainForm.DataGridViewChart.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'MainForm.DataGridViewChart.RowsDefaultCellStyle.BackColor = Color.Aquamarine
            MainForm.DataGridViewChart.RowsDefaultCellStyle.Font = New Font("Ariel", 8.25, FontStyle.Regular)
            MainForm.DataGridViewChart.Rows(GlobalVar.chartmachines).DefaultCellStyle.Font = New Font("Ariel", 8.25, FontStyle.Bold)
            MainForm.DataGridViewChart.Columns(0).Width = 100
            MainForm.DataGridViewChart.Columns(1).Width = 80
            MainForm.DataGridViewChart.Columns(2).Width = 80
            MainForm.DataGridViewChart.Columns(3).Width = 80
            MainForm.DataGridViewChart.Columns(2).DefaultCellStyle.Format = "0.00"
            'MainForm.DataGridViewChart.Columns(2).DefaultCellStyle.ForeColor = Color.Crimson
        Catch
            MsgBox("Not enough data to write summary table")
        End Try

    End Sub

    Public Sub loadchartdata() '(sender As Object, e As EventArgs)
        'Dim dateNum As Long = MainForm.DateTimePickerStart.Value.ToBinary()
        'Dim dateDate As Date = Date.FromBinary(dateNum)
        'Dim fileStr As String = dateDate.ToString("yyyy-MM-dd")
        'Dim filename As String = My.Settings.LogPath & "\log\log" & My.Settings.VesselName & fileStr & ".xml"

        Dim filename As String = logfile(MainForm.DateTimePickerStart.Value)

        Dim mtime(0 To 1440) ' maximum rows 60 minutes x 24 hours
        Dim maxrows, colcount, rowcount, machine, total As Integer
        Dim chartTable As DataTable = New DataTable
        Dim HarvestLog As DataSet = New DataSet
        Dim aveper As Integer
        Dim avecou As Single
        Dim mt As Date
        Dim dshelper As DataSetHelper
        Dim distinctm(0 To 10) As String

        'read xml file into HarvestLog (dataset)
        HarvestLog.ReadXmlSchema(My.Settings.LogPath & GlobalVar.logschema)
        Try

            HarvestLog.ReadXml(filename)
        Catch ex As Exception
            'set date to last available log date

            filename = My.Settings.LogPath & "\log\logTest2013-10-09.xml"
            HarvestLog.Clear()
            HarvestLog.ReadXml(filename)
        End Try


        'identify harvestdate
        GlobalVar.chartstart = HarvestLog.Tables("Harvest").Rows(0).Item(0)

        'identify Time column
        mtime = HarvestLog.Tables("Reading").Select

        'count number of datarows
        maxrows = mtime.GetUpperBound(0)

        'read time range
        Dim chartstarttime, chartstartdate, chartendtime As Date
        chartstarttime = mtime(0).item(0)
        chartstartdate = MainForm.DateTimePickerStart.Value.Date
        GlobalVar.chartstart = New Date(chartstartdate.Year, chartstartdate.Month, chartstartdate.Day, chartstarttime.Hour, chartstarttime.Minute, chartstarttime.Second)

        chartendtime = mtime(maxrows).item(0)
        GlobalVar.chartend = New Date(chartstartdate.Year, chartstartdate.Month, chartstartdate.Day, chartendtime.Hour, chartendtime.Minute, chartendtime.Second)
        'Dim buff As Date = GlobalVariables.harvestdate + " " + TimeSerial(stime.Hour, stime.Minute, stime.Second)

        'Call DataSetHelper.dll to add 'DistinctMachines' table
        dshelper = New DataSetHelper(HarvestLog)
        dshelper.SelectDistinct("DistinctMachines", HarvestLog.Tables("Machine"), "machineid")
        Dim totalrow As DataRow = HarvestLog.Tables("DistinctMachines").NewRow

        totalrow("machineid") = "Total"
        HarvestLog.Tables("DistinctMachines").Rows.Add(totalrow)

        'find number of machines
        GlobalVar.chartmachines = HarvestLog.Tables("DistinctMachines").Rows.Count - 1

        ReDim GlobalVar.distinctmachines(0 To GlobalVar.chartmachines)
        For machine = 0 To (GlobalVar.chartmachines)
            GlobalVar.distinctmachines(machine) = HarvestLog.Tables("DistinctMachines").Rows(machine).Item(0)
        Next

        'add columns to chartTable
        chartTable.Columns.Add("Time", GetType(System.DateTime))
        For colcount = 0 To GlobalVar.chartmachines
            chartTable.Columns.Add(GlobalVar.distinctmachines(colcount), GetType(Single))
        Next

        Dim machine_array(0 To GlobalVar.chartmachines)
        'identify machine columns
        For machine = 0 To (GlobalVar.chartmachines - 1)
            Dim machineid As String = "machineid = '" & GlobalVar.distinctmachines(machine) & "'"
            machine_array(machine) = HarvestLog.Tables("Machine").Select(machineid)
        Next


        'populate table
        Dim newchartrow(0 To GlobalVar.chartmachines + 1) As Object
        Dim currentcount, prevcount As Integer
        For rowcount = aveper To maxrows
            'add Time column
            mt = mtime(rowcount).item(0)
            newchartrow(0) = mt
            total = 0
            For machine = 0 To (GlobalVar.chartmachines - 1)
                'add DayCounter columns
                If rowcount > 0 Then
                    currentcount = machine_array(machine)(rowcount).Item(1)
                    prevcount = machine_array(machine)(rowcount - 1).Item(1)

                    avecou = currentcount - prevcount
                Else
                    Try
                        avecou = machine_array(machine)(rowcount).Item(1)
                    Catch
                        avecou = 0
                    End Try

                End If

                If avecou < 0 Then avecou = 0
                newchartrow(machine + 1) = avecou
                total = total + avecou
            Next
            newchartrow(GlobalVar.chartmachines + 1) = total
            chartTable.Rows.Add(newchartrow)
        Next

        GlobalVar.chartview = chartTable.DefaultView
        GlobalVar.chartview.RowFilter = "Time > #00:00:00# AND Time < #23:59:59#"

    End Sub

End Module
