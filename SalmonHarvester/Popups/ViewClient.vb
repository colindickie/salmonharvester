Public Class ViewClient
    Private Sub ViewClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(My.Settings.LogPath & GlobalVar.harvestdb) = True Then ClientDS.ReadXml(My.Settings.LogPath & GlobalVar.harvestdb)
    End Sub
    Private Sub ClientTBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClientTBindingNavigatorSaveItem.Click
        ClientTBindingSource.EndEdit()
        ClientDS.WriteXml(My.Settings.LogPath & GlobalVar.harvestdb)
    End Sub
End Class