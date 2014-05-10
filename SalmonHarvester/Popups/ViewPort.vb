Public Class ViewPort

    Private Sub PortTBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorSaveItem.Click
        PortTBindingSource.EndEdit()
        ClientDS.WriteXml(My.Settings.LogPath & GlobalVar.harvestdb)
    End Sub

    Private Sub ViewPort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(My.Settings.LogPath & GlobalVar.harvestdb) = True Then ClientDS.ReadXml(My.Settings.LogPath & GlobalVar.harvestdb)
    End Sub
End Class