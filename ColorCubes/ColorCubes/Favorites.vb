Public Class Favorites
    ' Paint Color
    Private Sub btnPaint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        'Sets the selected color on Main to the selected color in the favorites list
        Main.cboColor.Text = lstFav.Text
    End Sub
    ' Remove From Fav
    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        lstFav.Items.Remove(lstFav.Text)
    End Sub

    Private Sub FavoritesHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FavoritesHistoryToolStripMenuItem.Click
        For i As Integer = 0 To Main.intFavCount
            Try
                'Add items to the list box
                History.lstFavHistory.Items.Add(Main.strFav(i))
            Catch ex As Exception

            End Try
        Next
        History.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Favorites_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            For i As Integer = 0 To Main.intFavCount
                lstFav.Items.Add(Main.strFav(i))
            Next
        Catch ex As Exception
        End Try
    End Sub
End Class