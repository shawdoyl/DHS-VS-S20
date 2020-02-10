<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormControlForm
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
        Me.Go = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.KittenDIsplayBox = New System.Windows.Forms.PictureBox()
        Me.UserInput = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.UserSelection = New System.Windows.Forms.GroupBox()
        CType(Me.KittenDIsplayBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserInput.SuspendLayout()
        Me.SuspendLayout()
        '
        'Go
        '
        Me.Go.Location = New System.Drawing.Point(347, 361)
        Me.Go.Name = "Go"
        Me.Go.Size = New System.Drawing.Size(143, 77)
        Me.Go.TabIndex = 0
        Me.Go.Text = "Go"
        Me.Go.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(496, 361)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(143, 77)
        Me.UpdateButton.TabIndex = 1
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(645, 361)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(143, 77)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'KittenDIsplayBox
        '
        Me.KittenDIsplayBox.Location = New System.Drawing.Point(527, 12)
        Me.KittenDIsplayBox.Name = "KittenDIsplayBox"
        Me.KittenDIsplayBox.Size = New System.Drawing.Size(249, 324)
        Me.KittenDIsplayBox.TabIndex = 3
        Me.KittenDIsplayBox.TabStop = False
        '
        'UserInput
        '
        Me.UserInput.Controls.Add(Me.TextBox3)
        Me.UserInput.Controls.Add(Me.TextBox2)
        Me.UserInput.Controls.Add(Me.TextBox1)
        Me.UserInput.Location = New System.Drawing.Point(12, 12)
        Me.UserInput.Name = "UserInput"
        Me.UserInput.Size = New System.Drawing.Size(257, 324)
        Me.UserInput.TabIndex = 4
        Me.UserInput.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(59, 202)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(59, 176)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(59, 150)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 6
        '
        'UserSelection
        '
        Me.UserSelection.Location = New System.Drawing.Point(275, 12)
        Me.UserSelection.Name = "UserSelection"
        Me.UserSelection.Size = New System.Drawing.Size(246, 324)
        Me.UserSelection.TabIndex = 5
        Me.UserSelection.TabStop = False
        '
        'FormControlForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.UserSelection)
        Me.Controls.Add(Me.UserInput)
        Me.Controls.Add(Me.KittenDIsplayBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.Go)
        Me.Name = "FormControlForm"
        Me.Text = "User Control Interface"
        CType(Me.KittenDIsplayBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserInput.ResumeLayout(False)
        Me.UserInput.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Go As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents KittenDIsplayBox As PictureBox
    Friend WithEvents UserInput As GroupBox
    Friend WithEvents UserSelection As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
