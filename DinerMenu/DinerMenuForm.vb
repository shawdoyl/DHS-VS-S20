Public Class DinerMenuForm
    Public displayText As String
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click

    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click

    End Sub

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        displayText = "Rabbit Stew from Caerbonnig."
        DisplaySpecialLabel.Text = displayText
    End Sub
End Class
