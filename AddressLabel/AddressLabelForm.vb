'Shaw_Doyle
'RCET0265
'Spring 2020
'Address label program
'https://github.com/shawdoyl/DHS-VS-S20

Public Class AddressLabelForm
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        Dim displayText As String

        displayText = FirstNameTextBox.Text & " " & LastNameTextBox.Text &
            vbNewLine & StreetAddressTextBox.Text & vbNewLine & CityTextBox.Text _
            & ", " & StateTextBox.Text & " " & ZipTextBox.Text

        DisplayLabel.Text = displayText

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click

        Me.Close()

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

        DisplayLabel.Text = ""

    End Sub

End Class
