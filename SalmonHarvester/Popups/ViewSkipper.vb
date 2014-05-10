Public Class ViewSkipper

    Private Sub SkipperTBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorSaveItem.Click
        SkipperTBindingSource.EndEdit()
        ClientDS.WriteXml(My.Settings.LogPath & GlobalVar.harvestdb)
    End Sub

    Private Sub ViewSkipper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(My.Settings.LogPath & GlobalVar.harvestdb) = True Then ClientDS.ReadXml(My.Settings.LogPath & GlobalVar.harvestdb)
    End Sub


End Class