Public Class AddressLabelForm
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        Dim displayText As String

        displayText = FirstNameTextBox.Text & " " & LastNameTextBox.Text & vbNewLine & StreetAddressTextBox.Text & vbNewLine & CityTextBox.Text & ", " & StateTextBox.Text & " " & ZipTextBox.Text
        OutputGroupBox.Text = displayText
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'OutputGroupBox.Text.
    End Sub
End Class
