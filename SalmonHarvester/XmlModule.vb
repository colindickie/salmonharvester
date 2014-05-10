Imports System.Xml

Module XmlModule

    Function filestring() As String
        Dim dateNum As Long = Date.Now.ToBinary
        Dim dateDate As Date = Date.FromBinary(dateNum)
        Dim timeStr As String = dateDate.ToString("HH:mm:ss")
        Dim dateStr As String = dateDate.ToString("dd/MM/yyyy")
        Return dateDate.ToString("yyyy-MM-dd")
    End Function

    Function filestring(indate As Date) As String
        Dim dateNum As Long = indate.ToBinary
        Dim dateDate As Date = Date.FromBinary(dateNum)
        Dim timeStr As String = dateDate.ToString("HH:mm:ss")
        Dim dateStr As String = dateDate.ToString("dd/MM/yyyy")
        Return dateDate.ToString("yyyy-MM-dd")
    End Function

    Function logfile() As String

        Return My.Settings.LogPath & "\log\log" & My.Settings.VesselName & filestring() & ".xml"
    End Function

    Function logfile(indate As Date) As String

        Return My.Settings.LogPath & "\log\log" & My.Settings.VesselName & filestring(indate) & ".xml"
    End Function

    Public Sub writeLog(ByVal wharvesttime As String, wlog() As machinelog)

        Dim xmlLog As XmlDocument = New XmlDocument
        Dim ns As New XmlNamespaceManager(xmlLog.NameTable)
        Dim nsuri As String = "SalmonHarvest"

        Try
            xmlLog.Schemas.Add(Nothing, My.Settings.LogPath & GlobalVar.logschema)
            xmlLog.Load(logfile)
        Catch ex As Exception

            xmlsetup()
            xmlLog.Schemas.Add(Nothing, My.Settings.LogPath & GlobalVar.logschema)
            xmlLog.Load(logfile)
            'xmlLog.
        End Try

        'Dim ns As String = xmlLog.DocumentElement.NamespaceURI
        ns.AddNamespace(String.Empty, nsuri)
        Dim xmlHarvest As XmlElement = xmlLog.DocumentElement
        Dim xmlReading As XmlElement = xmlLog.CreateElement("Reading", nsuri)
        xmlHarvest.AppendChild(xmlReading)


        xmlReading.SetAttribute("harvesttime", wharvesttime.ToString)

        For Each machine As machinelog In wlog

            Dim xmlMachine As XmlElement = xmlLog.CreateElement("Machine", nsuri)
            xmlReading.AppendChild(xmlMachine)

            xmlMachine.SetAttribute("machineid", machine.machineid)


            Dim xmlSubElement As XmlElement
            Dim readingname As String

            'loop through each value in MachineLog and record its value in XML format
            For Counter = 1 To machinelog.maxindex
                readingname = machine.index(Counter).name
                xmlSubElement = xmlLog.CreateElement(readingname, nsuri)
                xmlSubElement.InnerText = machine.index(Counter).Value
                xmlMachine.AppendChild(xmlSubElement)
            Next
            
        Next
        xmlLog.Save(logfile)
    End Sub



    Public Sub xmlsetup()

        Dim xmlLog As XmlDocument = New XmlDocument
        Dim ns As New XmlNamespaceManager(xmlLog.NameTable)

        Try
            xmlLog.Schemas.Add(Nothing, My.Settings.LogPath & GlobalVar.logschema)
            xmlLog.Load(logfile)
        Catch ex As Exception

            ns.AddNamespace(String.Empty, "SalmonHarvest")


            Dim xmlHarvest As XmlElement = xmlLog.CreateElement("Harvest", "SalmonHarvest")
            xmlLog.AppendChild(xmlHarvest)
            xmlHarvest.SetAttribute("harvestdate", filestring)

            xmlHarvest.SetAttribute("xmlns", "SalmonHarvest")
            xmlHarvest.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance")
            xmlHarvest.SetAttribute("xsi:schemaLocation", "SalmonHarvest logschema.xsd")


            Dim xmldec As XmlDeclaration = xmlLog.CreateXmlDeclaration("1.0", "UTF-8", Nothing)
            xmlLog.InsertBefore(xmldec, xmlHarvest)

            xmlLog.Save(logfile)
        End Try



    End Sub




End Module
