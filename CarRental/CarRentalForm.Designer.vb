<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarRentalForm
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
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.BeginOdometerTextBox = New System.Windows.Forms.TextBox()
        Me.EndOdometerTextBox = New System.Windows.Forms.TextBox()
        Me.DaysTextBox = New System.Windows.Forms.TextBox()
        Me.MileageTextBox = New System.Windows.Forms.TextBox()
        Me.MileageChargeTextBox = New System.Windows.Forms.TextBox()
        Me.DayChargeTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountTextBox = New System.Windows.Forms.TextBox()
        Me.TotalOwedTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.KilometerRadioButton = New System.Windows.Forms.RadioButton()
        Me.MilesRadioButton = New System.Windows.Forms.RadioButton()
        Me.DiscountGroupBox = New System.Windows.Forms.GroupBox()
        Me.SeniorCheckBox = New System.Windows.Forms.CheckBox()
        Me.AAACheckBox = New System.Windows.Forms.CheckBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.ZipLabel = New System.Windows.Forms.Label()
        Me.BeginOdometerLabel = New System.Windows.Forms.Label()
        Me.EndOdometerLabel = New System.Windows.Forms.Label()
        Me.DaysLabel = New System.Windows.Forms.Label()
        Me.DistanceDrivenLabel = New System.Windows.Forms.Label()
        Me.MileageChargeLabel = New System.Windows.Forms.Label()
        Me.DayChargeLabel = New System.Windows.Forms.Label()
        Me.DiscountLabel = New System.Windows.Forms.Label()
        Me.TotalOwedLabel = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.DiscountGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(117, 29)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(146, 20)
        Me.NameTextBox.TabIndex = 0
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(117, 56)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(146, 20)
        Me.AddressTextBox.TabIndex = 1
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(117, 83)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(146, 20)
        Me.CityTextBox.TabIndex = 2
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(117, 110)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(146, 20)
        Me.StateTextBox.TabIndex = 3
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(117, 137)
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(146, 20)
        Me.ZipCodeTextBox.TabIndex = 4
        '
        'BeginOdometerTextBox
        '
        Me.BeginOdometerTextBox.Location = New System.Drawing.Point(117, 164)
        Me.BeginOdometerTextBox.Name = "BeginOdometerTextBox"
        Me.BeginOdometerTextBox.Size = New System.Drawing.Size(146, 20)
        Me.BeginOdometerTextBox.TabIndex = 5
        '
        'EndOdometerTextBox
        '
        Me.EndOdometerTextBox.Location = New System.Drawing.Point(117, 191)
        Me.EndOdometerTextBox.Name = "EndOdometerTextBox"
        Me.EndOdometerTextBox.Size = New System.Drawing.Size(146, 20)
        Me.EndOdometerTextBox.TabIndex = 6
        '
        'DaysTextBox
        '
        Me.DaysTextBox.Location = New System.Drawing.Point(117, 218)
        Me.DaysTextBox.Name = "DaysTextBox"
        Me.DaysTextBox.Size = New System.Drawing.Size(146, 20)
        Me.DaysTextBox.TabIndex = 7
        '
        'MileageTextBox
        '
        Me.MileageTextBox.Location = New System.Drawing.Point(495, 29)
        Me.MileageTextBox.Name = "MileageTextBox"
        Me.MileageTextBox.Size = New System.Drawing.Size(178, 20)
        Me.MileageTextBox.TabIndex = 8
        '
        'MileageChargeTextBox
        '
        Me.MileageChargeTextBox.Location = New System.Drawing.Point(495, 59)
        Me.MileageChargeTextBox.Name = "MileageChargeTextBox"
        Me.MileageChargeTextBox.Size = New System.Drawing.Size(178, 20)
        Me.MileageChargeTextBox.TabIndex = 9
        '
        'DayChargeTextBox
        '
        Me.DayChargeTextBox.Location = New System.Drawing.Point(495, 83)
        Me.DayChargeTextBox.Name = "DayChargeTextBox"
        Me.DayChargeTextBox.Size = New System.Drawing.Size(178, 20)
        Me.DayChargeTextBox.TabIndex = 10
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.Location = New System.Drawing.Point(495, 110)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.Size = New System.Drawing.Size(178, 20)
        Me.DiscountTextBox.TabIndex = 11
        '
        'TotalOwedTextBox
        '
        Me.TotalOwedTextBox.Location = New System.Drawing.Point(495, 136)
        Me.TotalOwedTextBox.Name = "TotalOwedTextBox"
        Me.TotalOwedTextBox.Size = New System.Drawing.Size(178, 20)
        Me.TotalOwedTextBox.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.KilometerRadioButton)
        Me.GroupBox1.Controls.Add(Me.MilesRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(87, 288)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 86)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'KilometerRadioButton
        '
        Me.KilometerRadioButton.AutoSize = True
        Me.KilometerRadioButton.Location = New System.Drawing.Point(45, 55)
        Me.KilometerRadioButton.Name = "KilometerRadioButton"
        Me.KilometerRadioButton.Size = New System.Drawing.Size(73, 17)
        Me.KilometerRadioButton.TabIndex = 1
        Me.KilometerRadioButton.TabStop = True
        Me.KilometerRadioButton.Text = "Kilometers"
        Me.KilometerRadioButton.UseVisualStyleBackColor = True
        '
        'MilesRadioButton
        '
        Me.MilesRadioButton.AutoSize = True
        Me.MilesRadioButton.Location = New System.Drawing.Point(45, 31)
        Me.MilesRadioButton.Name = "MilesRadioButton"
        Me.MilesRadioButton.Size = New System.Drawing.Size(49, 17)
        Me.MilesRadioButton.TabIndex = 0
        Me.MilesRadioButton.TabStop = True
        Me.MilesRadioButton.Text = "Miles"
        Me.MilesRadioButton.UseVisualStyleBackColor = True
        '
        'DiscountGroupBox
        '
        Me.DiscountGroupBox.Controls.Add(Me.SeniorCheckBox)
        Me.DiscountGroupBox.Controls.Add(Me.AAACheckBox)
        Me.DiscountGroupBox.Location = New System.Drawing.Point(394, 288)
        Me.DiscountGroupBox.Name = "DiscountGroupBox"
        Me.DiscountGroupBox.Size = New System.Drawing.Size(279, 86)
        Me.DiscountGroupBox.TabIndex = 14
        Me.DiscountGroupBox.TabStop = False
        Me.DiscountGroupBox.Text = "Enter a Discount"
        '
        'SeniorCheckBox
        '
        Me.SeniorCheckBox.AutoSize = True
        Me.SeniorCheckBox.Location = New System.Drawing.Point(31, 55)
        Me.SeniorCheckBox.Name = "SeniorCheckBox"
        Me.SeniorCheckBox.Size = New System.Drawing.Size(101, 17)
        Me.SeniorCheckBox.TabIndex = 1
        Me.SeniorCheckBox.Text = "Senior Discount"
        Me.SeniorCheckBox.UseVisualStyleBackColor = True
        '
        'AAACheckBox
        '
        Me.AAACheckBox.AutoSize = True
        Me.AAACheckBox.Location = New System.Drawing.Point(31, 31)
        Me.AAACheckBox.Name = "AAACheckBox"
        Me.AAACheckBox.Size = New System.Drawing.Size(133, 17)
        Me.AAACheckBox.TabIndex = 0
        Me.AAACheckBox.Text = "AAA Member Discount"
        Me.AAACheckBox.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(188, 401)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 15
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(294, 400)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 16
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(394, 399)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(75, 23)
        Me.SummaryButton.TabIndex = 17
        Me.SummaryButton.Text = "Summary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(351, 527)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Customer Name"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(12, 59)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(45, 13)
        Me.AddressLabel.TabIndex = 20
        Me.AddressLabel.Text = "Address"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(12, 83)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(24, 13)
        Me.CityLabel.TabIndex = 21
        Me.CityLabel.Text = "City"
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(13, 113)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(32, 13)
        Me.StateLabel.TabIndex = 22
        Me.StateLabel.Text = "State"
        '
        'ZipLabel
        '
        Me.ZipLabel.AutoSize = True
        Me.ZipLabel.Location = New System.Drawing.Point(13, 136)
        Me.ZipLabel.Name = "ZipLabel"
        Me.ZipLabel.Size = New System.Drawing.Size(47, 13)
        Me.ZipLabel.TabIndex = 23
        Me.ZipLabel.Text = "ZipCode"
        '
        'BeginOdometerLabel
        '
        Me.BeginOdometerLabel.AutoSize = True
        Me.BeginOdometerLabel.Location = New System.Drawing.Point(13, 164)
        Me.BeginOdometerLabel.Name = "BeginOdometerLabel"
        Me.BeginOdometerLabel.Size = New System.Drawing.Size(103, 13)
        Me.BeginOdometerLabel.TabIndex = 24
        Me.BeginOdometerLabel.Text = "Beginning Odometer"
        '
        'EndOdometerLabel
        '
        Me.EndOdometerLabel.AutoSize = True
        Me.EndOdometerLabel.Location = New System.Drawing.Point(12, 191)
        Me.EndOdometerLabel.Name = "EndOdometerLabel"
        Me.EndOdometerLabel.Size = New System.Drawing.Size(89, 13)
        Me.EndOdometerLabel.TabIndex = 25
        Me.EndOdometerLabel.Text = "Ending Odometer"
        '
        'DaysLabel
        '
        Me.DaysLabel.AutoSize = True
        Me.DaysLabel.Location = New System.Drawing.Point(12, 218)
        Me.DaysLabel.Name = "DaysLabel"
        Me.DaysLabel.Size = New System.Drawing.Size(65, 13)
        Me.DaysLabel.TabIndex = 26
        Me.DaysLabel.Text = "Days Driven"
        '
        'DistanceDrivenLabel
        '
        Me.DistanceDrivenLabel.AutoSize = True
        Me.DistanceDrivenLabel.Location = New System.Drawing.Point(359, 32)
        Me.DistanceDrivenLabel.Name = "DistanceDrivenLabel"
        Me.DistanceDrivenLabel.Size = New System.Drawing.Size(121, 13)
        Me.DistanceDrivenLabel.TabIndex = 27
        Me.DistanceDrivenLabel.Text = "Distance Driven in Miles"
        '
        'MileageChargeLabel
        '
        Me.MileageChargeLabel.AutoSize = True
        Me.MileageChargeLabel.Location = New System.Drawing.Point(359, 59)
        Me.MileageChargeLabel.Name = "MileageChargeLabel"
        Me.MileageChargeLabel.Size = New System.Drawing.Size(87, 13)
        Me.MileageChargeLabel.TabIndex = 28
        Me.MileageChargeLabel.Text = "Mileage Charged"
        '
        'DayChargeLabel
        '
        Me.DayChargeLabel.AutoSize = True
        Me.DayChargeLabel.Location = New System.Drawing.Point(359, 83)
        Me.DayChargeLabel.Name = "DayChargeLabel"
        Me.DayChargeLabel.Size = New System.Drawing.Size(63, 13)
        Me.DayChargeLabel.TabIndex = 29
        Me.DayChargeLabel.Text = "Day Charge"
        '
        'DiscountLabel
        '
        Me.DiscountLabel.AutoSize = True
        Me.DiscountLabel.Location = New System.Drawing.Point(359, 110)
        Me.DiscountLabel.Name = "DiscountLabel"
        Me.DiscountLabel.Size = New System.Drawing.Size(80, 13)
        Me.DiscountLabel.TabIndex = 30
        Me.DiscountLabel.Text = "Minus Discount"
        '
        'TotalOwedLabel
        '
        Me.TotalOwedLabel.AutoSize = True
        Me.TotalOwedLabel.Location = New System.Drawing.Point(359, 136)
        Me.TotalOwedLabel.Name = "TotalOwedLabel"
        Me.TotalOwedLabel.Size = New System.Drawing.Size(51, 13)
        Me.TotalOwedLabel.TabIndex = 31
        Me.TotalOwedLabel.Text = "You Owe"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(497, 399)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 32
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'CarRentalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.TotalOwedLabel)
        Me.Controls.Add(Me.DiscountLabel)
        Me.Controls.Add(Me.DayChargeLabel)
        Me.Controls.Add(Me.MileageChargeLabel)
        Me.Controls.Add(Me.DistanceDrivenLabel)
        Me.Controls.Add(Me.DaysLabel)
        Me.Controls.Add(Me.EndOdometerLabel)
        Me.Controls.Add(Me.BeginOdometerLabel)
        Me.Controls.Add(Me.ZipLabel)
        Me.Controls.Add(Me.StateLabel)
        Me.Controls.Add(Me.CityLabel)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.DiscountGroupBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TotalOwedTextBox)
        Me.Controls.Add(Me.DiscountTextBox)
        Me.Controls.Add(Me.DayChargeTextBox)
        Me.Controls.Add(Me.MileageChargeTextBox)
        Me.Controls.Add(Me.MileageTextBox)
        Me.Controls.Add(Me.DaysTextBox)
        Me.Controls.Add(Me.EndOdometerTextBox)
        Me.Controls.Add(Me.BeginOdometerTextBox)
        Me.Controls.Add(Me.ZipCodeTextBox)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Name = "CarRentalForm"
        Me.Text = "Car Rental"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.DiscountGroupBox.ResumeLayout(False)
        Me.DiscountGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents ZipCodeTextBox As TextBox
    Friend WithEvents BeginOdometerTextBox As TextBox
    Friend WithEvents EndOdometerTextBox As TextBox
    Friend WithEvents DaysTextBox As TextBox
    Friend WithEvents MileageTextBox As TextBox
    Friend WithEvents MileageChargeTextBox As TextBox
    Friend WithEvents DayChargeTextBox As TextBox
    Friend WithEvents DiscountTextBox As TextBox
    Friend WithEvents TotalOwedTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents KilometerRadioButton As RadioButton
    Friend WithEvents MilesRadioButton As RadioButton
    Friend WithEvents DiscountGroupBox As GroupBox
    Friend WithEvents SeniorCheckBox As CheckBox
    Friend WithEvents AAACheckBox As CheckBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents CityLabel As Label
    Friend WithEvents StateLabel As Label
    Friend WithEvents ZipLabel As Label
    Friend WithEvents BeginOdometerLabel As Label
    Friend WithEvents EndOdometerLabel As Label
    Friend WithEvents DaysLabel As Label
    Friend WithEvents DistanceDrivenLabel As Label
    Friend WithEvents MileageChargeLabel As Label
    Friend WithEvents DayChargeLabel As Label
    Friend WithEvents DiscountLabel As Label
    Friend WithEvents TotalOwedLabel As Label
    Friend WithEvents ExitButton As Button
End Class
