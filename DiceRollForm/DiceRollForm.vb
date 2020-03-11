Public Class DiceRollForm
    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        Dim sumDice As Integer
        Static firstDice As Integer
        Static secondDice As Integer
        Dim diceArray(1, 12) As Integer

        For i = 1 To 1000

            Randomize()
            firstDice = CInt((5 * Rnd()) + 1)
            Randomize()
            secondDice = CInt((5 * Rnd()) + 1)

            sumDice = firstDice + secondDice

            diceArray(0, 2) = 2
            diceArray(0, 3) = 3
            diceArray(0, 4) = 4
            diceArray(0, 5) = 5
            diceArray(0, 6) = 6
            diceArray(0, 7) = 7
            diceArray(0, 8) = 8
            diceArray(0, 9) = 9
            diceArray(0, 10) = 10
            diceArray(0, 11) = 11
            diceArray(0, 12) = 12


            If sumDice = 2 Then
                diceArray(1, 2) += 1
            ElseIf sumDice = 3 Then
                diceArray(1, 3) += 1
            ElseIf sumDice = 4 Then
                diceArray(1, 4) += 1
            ElseIf sumDice = 5 Then
                diceArray(1, 5) += 1
            ElseIf sumDice = 6 Then
                diceArray(1, 6) += 1
            ElseIf sumDice = 7 Then
                diceArray(1, 7) += 1
            ElseIf sumDice = 8 Then
                diceArray(1, 8) += 1
            ElseIf sumDice = 9 Then
                diceArray(1, 9) += 1
            ElseIf sumDice = 10 Then
                diceArray(1, 10) += 1
            ElseIf sumDice = 12 Then
                diceArray(1, 11) += 1
            ElseIf sumDice = 11 Then
                diceArray(1, 12) += 1
            End If

        Next

        TotalsListBox.Items.Add("|" & CStr(diceArray(0, 2)).PadRight(5) & "|" & diceArray(1, 2))
        TotalsListBox.Items.Add("|" & CStr(diceArray(0, 3)).PadRight(5) & "|" & diceArray(1, 3))
        TotalsListBox.Items.Add("|" & CStr(diceArray(0, 4)).PadRight(5) & "|" & diceArray(1, 4))
        TotalsListBox.Items.Add("|" & CStr(diceArray(0, 5)).PadRight(5) & "|" & diceArray(1, 5))
        TotalsListBox.Items.Add("|" & CStr(diceArray(0, 6)).PadRight(5) & "|" & diceArray(1, 6))
        TotalsListBox.Items.Add("|" & CStr(diceArray(0, 7)).PadRight(5) & "|" & diceArray(1, 7))
        TotalsListBox.Items.Add("|" & CStr(diceArray(0, 8)).PadRight(5) & "|" & diceArray(1, 8))
        TotalsListBox.Items.Add("|" & CStr(diceArray(0, 9)).PadRight(5) & "|" & diceArray(1, 9))
        TotalsListBox.Items.Add("|" & CStr(diceArray(0, 10)).PadRight(5) & "|" & diceArray(1, 10))
        TotalsListBox.Items.Add("|" & CStr(diceArray(0, 11)).PadRight(5) & "|" & diceArray(1, 11))
        TotalsListBox.Items.Add("|" & CStr(diceArray(0, 12)).PadRight(5) & "|" & diceArray(1, 12))
        TotalsListBox.Items.Add("************")

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        TotalsListBox.Items.Clear()
    End Sub

    Private Sub TotalsListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TotalsListBox.SelectedIndexChanged

    End Sub

    Private Sub ReRollButton_Click(sender As Object, e As EventArgs) Handles ReRollButton.Click
        TotalsListBox.Items.Clear()

        Dim sumDice As Integer
        Static firstDice As Integer
        Static secondDice As Integer
        Dim diceArray(1, 12) As Integer

        For i = 1 To 1000

            Randomize()
            firstDice = CInt((5 * Rnd()) + 1)
            Randomize()
            secondDice = CInt((5 * Rnd()) + 1)

            sumDice = firstDice + secondDice

            diceArray(0, 2) = 2
            diceArray(0, 3) = 3
            diceArray(0, 4) = 4
            diceArray(0, 5) = 5
            diceArray(0, 6) = 6
            diceArray(0, 7) = 7
            diceArray(0, 8) = 8
            diceArray(0, 9) = 9
            diceArray(0, 10) = 10
            diceArray(0, 11) = 11
            diceArray(0, 12) = 12


            If sumDice = 2 Then
                diceArray(1, 2) += 1
            ElseIf sumDice = 3 Then
                diceArray(1, 3) += 1
            ElseIf sumDice = 4 Then
                diceArray(1, 4) += 1
            ElseIf sumDice = 5 Then
                diceArray(1, 5) += 1
            ElseIf sumDice = 6 Then
                diceArray(1, 6) += 1
            ElseIf sumDice = 7 Then
                diceArray(1, 7) += 1
            ElseIf sumDice = 8 Then
                diceArray(1, 8) += 1
            ElseIf sumDice = 9 Then
                diceArray(1, 9) += 1
            ElseIf sumDice = 10 Then
                diceArray(1, 10) += 1
            ElseIf sumDice = 12 Then
                diceArray(1, 11) += 1
            ElseIf sumDice = 11 Then
                diceArray(1, 12) += 1
            End If

        Next

        TotalsListBox.Items.Add("|" & CStr(diceArray(0, 2)).PadRight(5) & "|" & diceArray(1, 2))
        TotalsListBox.Items.Add("|" & CStr(diceArray(0, 3)).PadRight(5) & "|" & diceArray(1, 3))
        TotalsListBox.Items.Add("|" & CStr(diceArray(0, 4)).PadRight(5) & "|" & diceArray(1, 4))
        TotalsListBox.Items.Add("|" & CStr(diceArray(0, 5)).PadRight(5) & "|" & diceArray(1, 5))
        TotalsListBox.Items.Add("|" & CStr(diceArray(0, 6)).PadRight(5) & "|" & diceArray(1, 6))
        TotalsListBox.Items.Add("|" & CStr(diceArray(0, 7)).PadRight(5) & "|" & diceArray(1, 7))
        TotalsListBox.Items.Add("|" & CStr(diceArray(0, 8)).PadRight(5) & "|" & diceArray(1, 8))
        TotalsListBox.Items.Add("|" & CStr(diceArray(0, 9)).PadRight(5) & "|" & diceArray(1, 9))
        TotalsListBox.Items.Add("|" & CStr(diceArray(0, 10)).PadRight(5) & "|" & diceArray(1, 10))
        TotalsListBox.Items.Add("|" & CStr(diceArray(0, 11)).PadRight(5) & "|" & diceArray(1, 11))
        TotalsListBox.Items.Add("|" & CStr(diceArray(0, 12)).PadRight(5) & "|" & diceArray(1, 12))
        TotalsListBox.Items.Add("************")

    End Sub
End Class
