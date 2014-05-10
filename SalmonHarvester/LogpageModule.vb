Imports System.Xml
Imports System.IO
Module LogpageModule


    Public Sub LogDateChanged()
        Try
            'Dim dateNum As Long = MainForm.DateTimePickerLog.Value.ToBinary()
            'Dim dateDate As Date = Date.FromBinary(dateNum)
            'Dim fileStr As String = dateDate.ToString("yyyy-MM-dd")
            'Dim filename As String = My.Settings.LogPath & "\log\log" & My.Settings.VesselName & fileStr & ".xml"

            Dim filename As String = logfile(MainForm.DateTimePickerLog.Value)

            MainForm.DataGridView1.Show()
            load_xml(filename)
            MainForm.LabelWarning.Text = ""
        Catch ex As Exception
            MainForm.DataGridView1.Hide()
            MainForm.LabelWarning.Text = "No Data"
        End Try
    End Sub

    Private Sub load_xml(ByVal filename As String)
        Dim xmlLog As XmlDocument = New XmlDocument
        Dim ds As DataSet = New DataSet
        Dim newds As DataSet = New DataSet
        Dim newdt As DataTable = newds.Tables.Add("maintable") 'New DataTable("maintable")
        Dim dshelp As DataSetHelper
        Dim nummachines As Integer
        'Dim counter As Integer
        'xmlLog.Load("log\" & filename & ".xml")
        ds.ReadXmlSchema(My.Settings.LogPath & GlobalVar.logschema)
        ds.ReadXml(filename)

        dshelp = New DataSetHelper(ds)
        dshelp.SelectDistinct("DistinctMachines", ds.Tables("Machine"), "machineid")
        Dim totalrow As DataRow = ds.Tables("DistinctMachines").NewRow
        totalrow("machineid") = "Total"
        ds.Tables("DistinctMachines").Rows.Add(totalrow)

        'find number of machines
        nummachines = ds.Tables("DistinctMachines").Rows.Count - 1

        Dim newcol As DataColumn = New DataColumn
        newcol.ColumnName = "Time"
        newdt.Columns.Add(newcol)

        For Each col As DataColumn In ds.Tables("Machine").Columns
            newcol = New DataColumn
            If col.ColumnName = "machineid" Then
                newcol.ColumnName = "Machine ID"
            Else
                newcol.ColumnName = col.ColumnName
            End If

            newdt.Columns.Add(newcol)
        Next

        Dim newrow As DataRow
        Dim counter As Integer = 0
        Dim colcount As Integer = 1
        Dim readingcount As Integer
        Dim readtime As System.DateTime
        Try
            Dim firstmachine As String = ds.Tables("Machine").Rows(0).Item(0)
            For Each machinerow As DataRow In ds.Tables("Machine").Rows
                readingcount = Math.Floor(counter / nummachines)
                newrow = newdt.NewRow
                readtime = ds.Tables("Reading").Rows(readingcount).Item(0)
                newrow.Item(0) = DateSerial(MainForm.DateTimePickerLog.Value.Year, MainForm.DateTimePickerLog.Value.Month, MainForm.DateTimePickerLog.Value.Day) + " " + TimeSerial(readtime.Hour, readtime.Minute, readtime.Second)
                colcount = 1
                For Each cellitem As Object In machinerow.ItemArray
                    newrow.Item(colcount) = cellitem
                    colcount = colcount + 1
                Next

                newdt.Rows.Add(newrow)
                counter = counter + 1
            Next
            'LogView.Items.Clear()
            MainForm.DataGridView1.DataSource = newds
            MainForm.DataGridView1.DataMember = "maintable"
            MainForm.DataGridView1.RowsDefaultCellStyle.Font = New Font("Ariel", 8.25, FontStyle.Regular)
            MainForm.DataGridView1.AutoResizeColumns()
        Catch
            MsgBox("No Current Log File")
        End Try


    End Sub



End Module
