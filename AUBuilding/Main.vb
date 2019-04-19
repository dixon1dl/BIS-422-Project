Public Class Main

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addButton.Click
        Add.ShowDialog()
    End Sub

    Private Sub retrieveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles retrieveButton.Click
        Retrieve.ShowDialog()
    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class

