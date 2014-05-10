Public Class ViewSite

    Private Sub ViewSite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(My.Settings.LogPath & GlobalVar.harvestdb) = True Then ClientDS.ReadXml(My.Settings.LogPath & GlobalVar.harvestdb)
    End Sub
    Private Sub SiteTBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SiteTBindingNavigatorSaveItem.Click
        SiteTBindingSource.EndEdit()
        ClientDS.WriteXml(My.Settings.LogPath & GlobalVar.harvestdb)
    End Sub


    Private Sub ClientTBindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles ClientTBindingSource1.CurrentChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ViewClient.Show()
    End Sub


End Class