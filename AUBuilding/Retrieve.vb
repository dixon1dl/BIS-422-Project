Public Class Retrieve
    Private DB As New DBAccessClass

    Private Sub Retrieve_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DB.ExecuteQuery("SELECT DISTINCT Make FROM Vehicle WHERE AvailableYN = 'Y' ORDER BY Make")

        If DB.ErrorFlag Then
            Exit Sub
        End If

        locationSearchComboBox.DataSource = DB.DBDataTable
        locationSearchComboBox.DisplayMember = "Make"
        locationSearchComboBox.Text = ""

        DB.ExecuteQuery("SELECT DISTINCT Model FROM Vehicle WHERE AvailableYN = 'Y' ORDER BY Model")

        If DB.ErrorFlag Then
            Exit Sub
        End If

        modelComboBox.DataSource = DB.DBDataTable
        modelComboBox.DisplayMember = "Model"
        modelComboBox.Text = ""

        DB.ExecuteQuery("SELECT * FROM Vehicle Order BY VehicleID")

        If DB.ErrorFlag Then
            Exit Sub
        End If

        BuildingDataGridView.DataSource = DB.DBDataTable

        updateButton.Enabled = False
    End Sub

    Private Sub nameSearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nameSearchTextBox.TextChanged
        DB.AddParam("@Make", nameSearchTextBox.Text & "%")
        DB.AddParam("@Model", locationSearchComboBox.Text & "%")

        DB.ExecuteQuery("SELECT * FROM Vehicle WHERE Make LIKE ? AND Model LIKE ? ORDER BY VehicleID")

        If DB.ErrorFlag Then
            Exit Sub
        End If

        BuildingDataGridView.DataSource = DB.DBDataTable

        IDTextBox.Text = ""
        makeTextBox.Text = ""
        modelComboBox.Text = ""

        updateButton.Enabled = False
    End Sub

    Private Sub locationSearchComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles locationSearchComboBox.SelectedIndexChanged
        DB.AddParam("@Make", nameSearchTextBox.Text & "%")
        DB.AddParam("@Model", locationSearchComboBox.Text & "%")

        DB.ExecuteQuery("SELECT * FROM Vehicle WHERE Make LIKE ? AND Model LIKE ? ORDER BY VehicleID")

        If DB.ErrorFlag Then
            Exit Sub
        End If

        BuildingDataGridView.DataSource = DB.DBDataTable

        IDTextBox.Text = ""
        makeTextBox.Text = ""
        modelComboBox.Text = ""

        updateButton.Enabled = False
    End Sub

    Private Sub BuildingDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles BuildingDataGridView.CellClick
        If e.RowIndex > -1 Then
            IDTextBox.Text = BuildingDataGridView.Rows(e.RowIndex).Cells(0).Value()
            makeTextBox.Text = BuildingDataGridView.Rows(e.RowIndex).Cells(1).Value()
            modelComboBox.Text = BuildingDataGridView.Rows(e.RowIndex).Cells(2).Value()

            updateButton.Enabled = True
        End If
    End Sub

    Private Sub updateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateButton.Click
        If makeTextBox.Text = "" Then
            MessageBox.Show("Please enter a name for the car.", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            makeTextBox.Focus()
        ElseIf modelComboBox.Text = "" Then
            MessageBox.Show("Please select a location for the building.", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            modelComboBox.Focus()
        Else
            DB.AddParam("@Make", makeTextBox.Text)
            DB.AddParam("@Model", modelComboBox.Text)
            DB.AddParam("@Year", yearTextBox.Text)
            DB.AddParam("@VehicleID", IDTextBox.Text)

            DB.ExecuteNonQuery("UPDATE Vehicle SET Make = ?, Model = ?, Year = ?, WHERE VehicleID = ?")

            nameSearchTextBox.Text = ""
            locationSearchComboBox.Text = ""
            IDTextBox.Text = ""
            makeTextBox.Text = ""
            modelComboBox.Text = ""

            DB.ExecuteQuery("SELECT * FROM Building Order BY BuildingID")

            If DB.ErrorFlag Then
                Exit Sub
            End If

            BuildingDataGridView.DataSource = DB.DBDataTable

            updateButton.Enabled = False
        End If
    End Sub

    Private Sub quitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quitButton.Click
        nameSearchTextBox.Text = ""
        locationSearchComboBox.Text = ""
        IDTextBox.Text = ""
        makeTextBox.Text = ""
        modelComboBox.Text = ""

        Me.Close()
    End Sub

End Class
