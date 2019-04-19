<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Retrieve
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nameSearchTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.quitButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.updateButton = New System.Windows.Forms.Button()
        Me.makeTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.modelComboBox = New System.Windows.Forms.ComboBox()
        Me.BuildingDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.locationSearchComboBox = New System.Windows.Forms.ComboBox()
        Me.yearComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.BuildingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Car:"
        '
        'nameSearchTextBox
        '
        Me.nameSearchTextBox.Location = New System.Drawing.Point(58, 11)
        Me.nameSearchTextBox.Name = "nameSearchTextBox"
        Me.nameSearchTextBox.Size = New System.Drawing.Size(121, 20)
        Me.nameSearchTextBox.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(264, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Location:"
        '
        'quitButton
        '
        Me.quitButton.Location = New System.Drawing.Point(298, 202)
        Me.quitButton.Name = "quitButton"
        Me.quitButton.Size = New System.Drawing.Size(75, 23)
        Me.quitButton.TabIndex = 12
        Me.quitButton.Text = "Cancel"
        Me.quitButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID:"
        '
        'updateButton
        '
        Me.updateButton.Location = New System.Drawing.Point(217, 202)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Size = New System.Drawing.Size(75, 23)
        Me.updateButton.TabIndex = 11
        Me.updateButton.Text = "Update"
        Me.updateButton.UseVisualStyleBackColor = True
        '
        'makeTextBox
        '
        Me.makeTextBox.Location = New System.Drawing.Point(66, 166)
        Me.makeTextBox.Name = "makeTextBox"
        Me.makeTextBox.Size = New System.Drawing.Size(121, 20)
        Me.makeTextBox.TabIndex = 8
        '
        'IDTextBox
        '
        Me.IDTextBox.Location = New System.Drawing.Point(17, 166)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(43, 20)
        Me.IDTextBox.TabIndex = 6
        '
        'modelComboBox
        '
        Me.modelComboBox.FormattingEnabled = True
        Me.modelComboBox.Location = New System.Drawing.Point(194, 166)
        Me.modelComboBox.Name = "modelComboBox"
        Me.modelComboBox.Size = New System.Drawing.Size(106, 21)
        Me.modelComboBox.TabIndex = 10
        '
        'BuildingDataGridView
        '
        Me.BuildingDataGridView.AllowUserToAddRows = False
        Me.BuildingDataGridView.AllowUserToDeleteRows = False
        Me.BuildingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BuildingDataGridView.Location = New System.Drawing.Point(13, 37)
        Me.BuildingDataGridView.Name = "BuildingDataGridView"
        Me.BuildingDataGridView.ReadOnly = True
        Me.BuildingDataGridView.RowHeadersVisible = False
        Me.BuildingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BuildingDataGridView.Size = New System.Drawing.Size(356, 110)
        Me.BuildingDataGridView.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(191, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Make:"
        '
        'locationSearchComboBox
        '
        Me.locationSearchComboBox.FormattingEnabled = True
        Me.locationSearchComboBox.Location = New System.Drawing.Point(248, 10)
        Me.locationSearchComboBox.Name = "locationSearchComboBox"
        Me.locationSearchComboBox.Size = New System.Drawing.Size(121, 21)
        Me.locationSearchComboBox.TabIndex = 3
        '
        'yearComboBox1
        '
        Me.yearComboBox1.FormattingEnabled = True
        Me.yearComboBox1.Location = New System.Drawing.Point(306, 166)
        Me.yearComboBox1.Name = "yearComboBox1"
        Me.yearComboBox1.Size = New System.Drawing.Size(106, 21)
        Me.yearComboBox1.TabIndex = 13
        '
        'Retrieve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 227)
        Me.Controls.Add(Me.yearComboBox1)
        Me.Controls.Add(Me.locationSearchComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BuildingDataGridView)
        Me.Controls.Add(Me.modelComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nameSearchTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.quitButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.updateButton)
        Me.Controls.Add(Me.makeTextBox)
        Me.Controls.Add(Me.IDTextBox)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Retrieve"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retrieve a Rental Car"
        CType(Me.BuildingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nameSearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents quitButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents updateButton As System.Windows.Forms.Button
    Friend WithEvents makeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents modelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BuildingDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents locationSearchComboBox As ComboBox
    Friend WithEvents yearComboBox1 As ComboBox
End Class
