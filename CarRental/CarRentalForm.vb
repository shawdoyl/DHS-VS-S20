'Shaw_Doyle
'RCET0265
'Spring 2020
'Car_Rental_Program
'https://github.com/shawdoyl/DHS-VS-S20

Option Explicit On
Option Strict On
Option Compare Binary

Public Class CarRentalForm
    Dim numCustomers As Integer
    Dim totalMiles As Decimal
    Dim totalCharges As Decimal
    Dim totalDiscount As Decimal = 0

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

        Dim dataValidated As Boolean = False
        Dim userMessage As String = ""
        Dim beginOdo As Decimal
        Dim endOdo As Decimal
        Dim numberOfDays As Integer
        Dim beginOdometerGood As Boolean = False
        Dim endOdometerGood As Boolean = False
        Dim daysNumGood As Boolean = False

        If NameTextBox.Text = "" Then
            userMessage = "Please enter a Name." & vbNewLine
        End If
        If AddressTextBox.Text = "" Then
            userMessage &= "Please enter the Address." & vbNewLine
        End If
        If CityTextBox.Text = "" Then
            userMessage &= "Please enter the City." & vbNewLine
        End If
        If StateTextBox.Text = "" Then
            userMessage &= "Please enter the State." & vbNewLine
        End If
        If ZipCodeTextBox.Text = "" Then
            userMessage &= "Please enter the Zip Code." & vbNewLine
        End If
        If BeginOdometerTextBox.Text = "" Then
            userMessage &= "Please enter the beginning odometer reading." & vbNewLine
        End If
        If EndOdometerTextBox.Text = "" Then
            userMessage &= "Please enter the end odometer reading." & vbNewLine
        End If
        If DaysTextBox.Text = "" Then
            userMessage &= "Please enter the number of days." & vbNewLine
        End If

        'if any of the last 3 are not blank, check to see if they are valid integers
        If BeginOdometerTextBox.Text <> "" Or EndOdometerTextBox.Text <> "" Or
            DaysTextBox.Text <> "" Then
            Try
                beginOdo = CDec(BeginOdometerTextBox.Text)
                beginOdometerGood = True
            Catch ex As Exception
                'did not convert to dec
                userMessage &= "Please enter a valid beginning odometer reading" & vbNewLine
            End Try
            Try
                endOdo = CDec(EndOdometerTextBox.Text)
                endOdometerGood = True
            Catch ex As Exception
                userMessage &= "Please enter a valid ending odometer reading" & vbNewLine
            End Try
            If beginOdometerGood = True And endOdometerGood = True Then
                'as long as both values converted to dec, compare them
                If beginOdo < endOdo Then
                    'do nothing. Beg is less than end
                Else
                    userMessage &= "The ending odometer reading must be greater than the 
                    starting odometer reading. Please fix this to continue." & vbNewLine _
                    & vbNewLine
                End If
            End If
            Try
                numberOfDays = CInt(DaysTextBox.Text)
                If numberOfDays > 0 And numberOfDays <= 45 Then
                    'days is ok
                    daysNumGood = True
                Else
                    'if this line is entered, days input is a number but not in range
                    userMessage &= "The number of days must be between 0 and 45." & vbNewLine
                End If
            Catch ex As Exception
                userMessage &= "Please enter a valid number for the amount of days." _
                    & vbNewLine
            End Try
        End If

        If userMessage <> "" Then
            MsgBox(userMessage)
            'following 3 ifs clears bad data
            If beginOdometerGood = False Then
                BeginOdometerTextBox.Text = ""
            End If
            If endOdometerGood = False Then
                EndOdometerTextBox.Text = ""
            End If
            If daysNumGood = False Then
                DaysTextBox.Text = ""
            End If

            'Following ifs determines which bad data to select (last instance is selected)
            'if statements for each text box, from name to days. 
            'If bad, Then NameTextBox.Select()
            If daysNumGood = False Then
                DaysTextBox.Select()
            End If
            If endOdometerGood = False Then
                'endOdoGood corresponds to validation of end odo text
                EndOdometerTextBox.Select()
            End If
            If beginOdometerGood = False Then
                'begOdoGood corresponds to validation of begin odo text
                BeginOdometerTextBox.Select()
            End If
            If ZipCodeTextBox.Text = "" Then
                ZipCodeTextBox.Select()
            End If
            If StateTextBox.Text = "" Then
                StateTextBox.Select()
            End If
            If CityTextBox.Text = "" Then
                CityTextBox.Select()
            End If
            If AddressTextBox.Text = "" Then
                AddressTextBox.Select()
            End If
            If NameTextBox.Text = "" Then
                NameTextBox.Select()
            End If
        Else
            dataValidated = True
        End If

        If dataValidated = True Then
            'validation checks out. do math here
            Dim milesDriven As Decimal = 0
            Dim dayCharge As Integer = 0
            Dim mileCharge As Decimal = 0
            Dim totalOwed As Decimal = 0

            If MilesRadioButton.Checked = True Then
                milesDriven = endOdo - beginOdo
            Else
                milesDriven = (endOdo - beginOdo) * 0.62D
            End If
            MileageTextBox.Text = Math.Round(milesDriven, 2).ToString("N")

            'daily charge =  days * $15
            dayCharge = numberOfDays * 15
            DayChargeTextBox.Text = dayCharge.ToString("C")

            MileageCharge(milesDriven)

            Dim subTotal As Decimal
            subTotal = mileCharge + dayCharge

            Discount(subTotal)

            MileageTextBox.Text = Str(mileCharge)
            DiscountTextBox.Text = totalDiscount.ToString("c")

            totalOwed = mileCharge + dayCharge - totalDiscount
            TotalOwedTextBox.Text = totalOwed.ToString("c")

            'Add to the number of customers, and total charges and miles
            numCustomers += 1
            totalMiles += milesDriven
            totalCharges += totalOwed
            SummaryButton.Enabled = True
            ResetAll()
        End If

    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        'show summary
        Dim totalSummary As String = ""
        totalSummary = "Total Customers:       " & numCustomers.ToString & vbNewLine
        totalSummary &= "Total Miles Driven:    " & totalMiles.ToString("n") & " mi" & vbNewLine
        totalSummary &= "Total charges:           " & totalCharges.ToString("c") & vbNewLine
        MessageBox.Show(totalSummary, "Detailed Summary")
        ResetAll()
        'clear all output boxes
        MileageTextBox.Text = ""
        MileageChargeTextBox.Text = ""
        DayChargeTextBox.Text = ""
        DiscountTextBox.Text = ""
        TotalOwedTextBox.Text = ""
    End Sub

    Function AllChecksAreValid() As Boolean
        Dim result As Boolean

        'VerifyOdmeter
        'VerifyIfEmpty
        'ValidateNumberOfDays


        result = False
        Return result
    End Function
    Function Discount(totalCharges As Decimal) As Decimal
        'Use the check boxes for AAA Member And Senior Citizen. 
        'AAA members receive a 5% discount
        'senior citizens get a 3% discount.
        'A person can receive both discounts. 
        'Do Not take the discount until the calculate button Is clicked.

        Const AAARATE = 0.05D
        Const SENIORRATE = 0.03D


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
