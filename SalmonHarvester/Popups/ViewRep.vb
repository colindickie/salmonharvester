Public Class ViewRep

    Private Sub RepTBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RepTBindingNavigatorSaveItem.Click
        RepTBindingSource.EndEdit()
        ClientDS.WriteXml(My.Settings.LogPath & GlobalVar.harvestdb)
    End Sub

    Private Sub ViewRep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(My.Settings.LogPath & GlobalVar.harvestdb) = True Then ClientDS.ReadXml(My.Settings.LogPath & GlobalVar.harvestdb)
    End Sub
End Class