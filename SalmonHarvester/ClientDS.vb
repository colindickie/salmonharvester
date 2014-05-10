Partial Class ClientDS
    Partial Class HarvestTDataTable

        Private Sub HarvestTDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.RepCommentsColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class ClientTDataTable

        Private Sub ClientTDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ClientIDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
