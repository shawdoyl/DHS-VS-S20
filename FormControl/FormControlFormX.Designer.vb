<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormControlFormX
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Go = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UserPictureBox = New System.Windows.Forms.PictureBox()
        Me.UserInput = New System.Windows.Forms.GroupBox()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.StreetLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.UserSelection = New System.Windows.Forms.GroupBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        CType(Me.UserPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserInput.SuspendLayout()
        Me.UserSelection.SuspendLayout()
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
        Me.UpdateButton.Text = "&Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(645, 361)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(143, 77)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'UserPictureBox
        '
        Me.UserPictureBox.Location = New System.Drawing.Point(527, 12)
        Me.UserPictureBox.Name = "UserPictureBox"
        Me.UserPictureBox.Size = New System.Drawing.Size(249, 149)
        Me.UserPictureBox.TabIndex = 3
        Me.UserPictureBox.TabStop = False
        '
        'UserInput
        '
        Me.UserInput.Controls.Add(Me.StateLabel)
        Me.UserInput.Controls.Add(Me.StreetLabel)
        Me.UserInput.Controls.Add(Me.NameLabel)
        Me.UserInput.Controls.Add(Me.StateTextBox)
        Me.UserInput.Controls.Add(Me.StreetTextBox)
        Me.UserInput.Controls.Add(Me.NameTextBox)
        Me.UserInput.Location = New System.Drawing.Point(12, 12)
        Me.UserInput.Name = "UserInput"
        Me.UserInput.Size = New System.Drawing.Size(257, 324)
        Me.UserInput.TabIndex = 4
        Me.UserInput.TabStop = False
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(14, 94)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(32, 13)
        Me.StateLabel.TabIndex = 11
        Me.StateLabel.Text = "State"
        '
        'StreetLabel
        '
        Me.StreetLabel.AutoSize = True
        Me.StreetLabel.Location = New System.Drawing.Point(14, 57)
        Me.StreetLabel.Name = "StreetLabel"
        Me.StreetLabel.Size = New System.Drawing.Size(35, 13)
        Me.StreetLabel.TabIndex = 10
        Me.StreetLabel.Text = "Street"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(14, 18)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 9
        Me.NameLabel.Text = "Name"
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(52, 91)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(190, 20)
        Me.StateTextBox.TabIndex = 8
        Me.StateTextBox.Text = "CA"
        '
        'StreetTextBox
        '
        Me.StreetTextBox.Location = New System.Drawing.Point(52, 54)
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.Size = New System.Drawing.Size(190, 20)
        Me.StreetTextBox.TabIndex = 7
        Me.StreetTextBox.Text = "123 Wabbit Woad"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(52, 15)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(190, 20)
        Me.NameTextBox.TabIndex = 6
        Me.NameTextBox.Text = "Elmer Fudd"
        '
        'UserSelection
        '
        Me.UserSelection.Controls.Add(Me.CheckBox7)
        Me.UserSelection.Controls.Add(Me.CheckBox3)
        Me.UserSelection.Controls.Add(Me.CheckBox2)
        Me.UserSelection.Controls.Add(Me.CheckBox1)
        Me.UserSelection.Controls.Add(Me.RadioButton3)
        Me.UserSelection.Controls.Add(Me.RadioButton2)
        Me.UserSelection.Controls.Add(Me.RadioButton1)
        Me.UserSelection.Location = New System.Drawing.Point(275, 12)
        Me.UserSelection.Name = "UserSelection"
        Me.UserSelection.Size = New System.Drawing.Size(246, 324)
        Me.UserSelection.TabIndex = 5
        Me.UserSelection.TabStop = False
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(50, 179)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox7.TabIndex = 7
        Me.CheckBox7.Text = "CheckBox7"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(50, 156)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox3.TabIndex = 6
        Me.CheckBox3.Text = "CheckBox3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(50, 133)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox2.TabIndex = 4
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(50, 110)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(50, 68)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(50, 45)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(50, 22)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'DisplayLabel
        '
        Me.DisplayLabel.Location = New System.Drawing.Point(528, 145)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(248, 168)
        Me.DisplayLabel.TabIndex = 6
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(12, 342)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(12, 365)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton5.TabIndex = 7
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "RadioButton5"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(12, 388)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton6.TabIndex = 8
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "RadioButton6"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(139, 343)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox4.TabIndex = 6
        Me.CheckBox4.Text = "CheckBox4"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(139, 366)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox5.TabIndex = 9
        Me.CheckBox5.Text = "CheckBox5"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(139, 389)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox6.TabIndex = 10
        Me.CheckBox6.Text = "CheckBox6"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'FormControlFormX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.RadioButton6)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.DisplayLabel)
        Me.Controls.Add(Me.UserSelection)
        Me.Controls.Add(Me.UserInput)
        Me.Controls.Add(Me.UserPictureBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.Go)
        Me.Name = "FormControlFormX"
        Me.Text = "User Control Interface"
        CType(Me.UserPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserInput.ResumeLayout(False)
        Me.UserInput.PerformLayout()
        Me.UserSelection.ResumeLayout(False)
        Me.UserSelection.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Go As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents UserPictureBox As PictureBox
    Friend WithEvents UserInput As GroupBox
    Friend WithEvents UserSelection As GroupBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents StreetTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents StateLabel As Label
    Friend WithEvents StreetLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
End Class
