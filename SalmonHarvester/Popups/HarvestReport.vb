Option Strict On

Public Class HarvestReport

    Private WithEvents PD As New Printing.PrintDocument
    Private PPD As New PrintPreviewDialog With {.WindowState = FormWindowState.Maximized}

    Public Sub load_xml() Handles Me.Load

        Try
            ClientDS.ReadXml(My.Settings.LogPath & GlobalVar.harvestdb)
            HarvestTBindingSource.Position = MainForm.HarvestTBindingSource.Position
        Catch ex As Exception
            MsgBox("Cannot Load Harvest Database")
        End Try

        'Print Report
        HarvestTBindingNavigator.Visible = False
        Me.Hide()
        PPD.Document = PD
        PPD.ShowDialog()
        Me.Close()

    End Sub

    Private Sub PD_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PD.PrintPage
        Dim mt, ml, mb, mr As Integer
        mt = 32
        mr = 0
        mb = -24
        ml = 8

        Dim Bmp As New Bitmap(Me.Width - ml - mr, Me.Height - mt - mb)
        Me.DrawToBitmap(Bmp, New Rectangle(0, 0, Bmp.Width, Bmp.Height))
        e.Graphics.DrawImage(Bmp, -ml, -mt)
    End Sub

End Class