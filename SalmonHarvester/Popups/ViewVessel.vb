Public Class ViewVessel

    Private Sub ViewVessel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(My.Settings.LogPath & GlobalVar.harvestdb) = True Then ClientDS.ReadXml(My.Settings.LogPath & GlobalVar.harvestdb)
    End Sub

    Private Sub VesselTBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VesselTBindingNavigatorSaveItem.Click
        VesselTBindingSource.EndEdit()
        ClientDS.WriteXml(My.Settings.LogPath & GlobalVar.harvestdb)
    End Sub


End Class