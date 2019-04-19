<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.exitButton = New System.Windows.Forms.Button()
        Me.retrieveButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(12, 70)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(128, 23)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'retrieveButton
        '
        Me.retrieveButton.Location = New System.Drawing.Point(12, 41)
        Me.retrieveButton.Name = "retrieveButton"
        Me.retrieveButton.Size = New System.Drawing.Size(128, 23)
        Me.retrieveButton.TabIndex = 1
        Me.retrieveButton.Text = "Retrieve a Building"
        Me.retrieveButton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(12, 12)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(128, 23)
        Me.addButton.TabIndex = 0
        Me.addButton.Text = "Add a Building"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(153, 104)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.retrieveButton)
        Me.Controls.Add(Me.addButton)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents retrieveButton As System.Windows.Forms.Button
    Friend WithEvents addButton As System.Windows.Forms.Button

End Class
