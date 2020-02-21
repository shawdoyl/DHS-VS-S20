<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DinerMenuForm
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
        Me.SoupButton = New System.Windows.Forms.Button()
        Me.SaladButton = New System.Windows.Forms.Button()
        Me.FishButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DinerDisplayLabel = New System.Windows.Forms.Label()
        Me.DisplaySpecialLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SoupButton
        '
        Me.SoupButton.Location = New System.Drawing.Point(27, 385)
        Me.SoupButton.Name = "SoupButton"
        Me.SoupButton.Size = New System.Drawing.Size(101, 38)
        Me.SoupButton.TabIndex = 0
        Me.SoupButton.Text = "Soup"
        Me.SoupButton.UseVisualStyleBackColor = True
        '
        'SaladButton
        '
        Me.SaladButton.Location = New System.Drawing.Point(165, 385)
        Me.SaladButton.Name = "SaladButton"
        Me.SaladButton.Size = New System.Drawing.Size(101, 38)
        Me.SaladButton.TabIndex = 1
        Me.SaladButton.Text = "Salad"
        Me.SaladButton.UseVisualStyleBackColor = True
        '
        'FishButton
        '
        Me.FishButton.Location = New System.Drawing.Point(308, 385)
        Me.FishButton.Name = "FishButton"
        Me.FishButton.Size = New System.Drawing.Size(101, 38)
        Me.FishButton.TabIndex = 2
        Me.FishButton.Text = "Fish"
        Me.FishButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(713, 415)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DinerDisplayLabel
        '
        Me.DinerDisplayLabel.Font = New System.Drawing.Font("Times New Roman", 36.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DinerDisplayLabel.Location = New System.Drawing.Point(274, 9)
        Me.DinerDisplayLabel.Name = "DinerDisplayLabel"
        Me.DinerDisplayLabel.Size = New System.Drawing.Size(295, 43)
        Me.DinerDisplayLabel.TabIndex = 5
        Me.DinerDisplayLabel.Text = "Shaw's Diner"
        '
        'DisplaySpecialLabel
        '
        Me.DisplaySpecialLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplaySpecialLabel.Location = New System.Drawing.Point(218, 98)
        Me.DisplaySpecialLabel.Name = "DisplaySpecialLabel"
        Me.DisplaySpecialLabel.Size = New System.Drawing.Size(363, 245)
        Me.DisplaySpecialLabel.TabIndex = 6
        '
        'DinerMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DisplaySpecialLabel)
        Me.Controls.Add(Me.DinerDisplayLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.FishButton)
        Me.Controls.Add(Me.SaladButton)
        Me.Controls.Add(Me.SoupButton)
        Me.Name = "DinerMenuForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SoupButton As Button
    Friend WithEvents SaladButton As Button
    Friend WithEvents FishButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DinerDisplayLabel As Label
    Friend WithEvents DisplaySpecialLabel As Label
End Class
