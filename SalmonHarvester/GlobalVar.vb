Public Class GlobalVar
    Public Shared plc(My.Settings.NoMachines - 1) As AdvancedHMIDrivers.EthernetIPforPLCSLCMicroCom
    Public Shared mlog(My.Settings.NoMachines - 1) As machinelog
    Public Shared lastcounter(My.Settings.NoMachines - 1) As Integer

    Public Shared chartstart As System.DateTime
    Public Shared chartend As System.DateTime
    Public Shared chartmachines As Integer
    Public Shared distinctmachines() As String
    Public Shared chartview As DataView
    Public Shared chartloaded As Boolean
    Public Shared currentmachine As Integer
    Public Shared timingdrawn As Integer

    Public Shared logschema As String = "\logschema.xsd"
    Public Shared harvestdb As String = "\harvestdb.xml"

    Public Shared version As String = "Version: 1.0.4.0"
End Class
