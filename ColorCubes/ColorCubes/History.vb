Public Class History

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        lstFavHistory.Items.Clear()
        Me.Close()
    End Sub
End Class