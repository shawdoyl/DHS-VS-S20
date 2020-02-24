Public Class DinerMenuForm
    Public displayText As String
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        displayText = "~Fish of the Day~" & vbNewLine & vbNewLine & "A Herring seasoned with coconut milk. Hand delivered by a African or European Swallow of your choice. Coconut shells are given to poor squires in need of them for their knights."
        DisplaySpecialLabel.Text = displayText
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        displayText = "~Salad of the Day~" & vbNewLine & vbNewLine & "A beautiful Caeser's salad, prepared by the Knights Who Say Ni! Garnished with a branch from the shrubbery gifted to them by King Arthur himself."
        DisplaySpecialLabel.Text = displayText
    End Sub

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        displayText = "~Soup of the Day~" & vbNewLine & vbNewLine & "Rabbit Stew from Caerbonnig." & vbNewLine & vbNewLine & "WARNING! May still have bits of the Holy Hand Grenade of Antioch"
        DisplaySpecialLabel.Text = displayText
    End Sub

End Class
