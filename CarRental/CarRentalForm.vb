'Shaw_Doyle
'RCET0265
'Spring 2020
'Car_Rental_Program
'https://github.com/shawdoyl/DHS-VS-S20

Option Explicit On
Option Strict On
Option Compare Binary

Public Class CarRentalForm

    Private Sub RentalForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        ResetAll()
        SummaryButton.Enabled = False

    End Sub

    Sub ResetAll()

        'Clear User input
        NameTextBox.Text = ""
        AddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipCodeTextBox.Text = ""
        BeginOdometerTextBox.Text = ""
        EndOdometerTextBox.Text = ""
        DaysTextBox.Text = ""
        MilesRadioButton.Select()
        AAACheckBox.Checked = False
        SeniorCheckBox.Checked = False
        'Clear Output

    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click

        MileageCharge(220) 'check and convert if kilometer.

    End Sub

    Function Discount(totalCharges As Decimal) As Decimal
        'Use the check boxes for AAA Member And Senior Citizen. 
        'AAA members receive a 5% discount
        'senior citizens get a 3% discount.
        'A person can receive both discounts. 
        'Do Not take the discount until the calculate button Is clicked.

        Const AAARATE = 0.05D
        Const SENIORRATE = 0.03D
        Dim totalDiscount As Decimal = 0

        If AAACheckBox.Checked = True Then
            totalDiscount += totalCharges * AAARATE
        End If

        If SeniorCheckBox.Checked = True Then
            totalDiscount += totalCharges * SENIORRATE
        End If

        Return totalDiscount
    End Function

    Sub VerifyOdometer()
        Dim userMessage As String

        Try
            If CInt(BeginOdometerTextBox.Text) > CInt(EndOdometerTextBox.Text) Then
                userMessage = "Beginning odometer must be smaller then Ending odometer"

            End If
        Catch ex As Exception
            userMessage = "Odometer entries must be numbers"
        End Try

    End Sub

    Function MileageCharge(ByRef miles As Decimal) As Decimal
        'First 200 miles driven are always free. 
        'All miles between 201 And 500 inclusive are .12 cents per mile. 
        'miles greater than 500 are charged at .10 cents per mile.

        Dim mileCharge As Decimal

        Const RATEREGULAR = 0.12D
        Const RATELOW = 0.1D
        Const RATEFREE = 0D

        Select Case miles
            Case <= 200
                mileCharge = miles * RATEFREE
            Case > 500
                mileCharge = (300) * RATEREGULAR
                mileCharge += (miles - 500) * RATELOW
            Case Else
                mileCharge = (miles - 200) * RATEREGULAR
        End Select

        Return mileCharge
    End Function

    Function UserMessages(addMessage As Boolean, message As String, clearMessage As Boolean) As String
        Static formattedMessages As String

        If clearMessage = True Then
            formattedMessages = ""
        ElseIf addMessage = True Then
            formattedMessages &= message & vbNewLine
        End If

        Return formattedMessages
    End Function

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ResetAll()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
