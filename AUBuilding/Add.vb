Public Class Add

    Private Sub Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addButton.Click

    End Sub

    Private Sub quitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quitButton.Click
        IDTextBox.Text = ""
        nameTextBox.Text = ""
        locationComboBox.Text = ""

        Me.Close()
    End Sub
End Class