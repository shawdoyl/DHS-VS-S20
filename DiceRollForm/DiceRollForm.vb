'Doyle Shaw
'RCET0265
'Spring 2020
'RollDiceForm
'https://github.com/shawdoyl/DHS-VS-S20

Option Strict On
Option Explicit On
Option Compare Binary

Public Class DiceRollForm
    'Button that rolls two dice and adds the results displaying number of each result.
    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click, RollToolStripMenuItem.Click
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
            For j = 2 To 12
                diceArray(0, j) = j
            Next
            For j = 2 To 12
                diceArray(1, sumDice) += 1
            Next
        Next
        TotalsListBox.Items.Add(Space(2) & "Result of Roll" & Space(2))
        TotalsListBox.Items.Add(StrDup(20, "*"))
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
        TotalsListBox.Items.Add(StrDup(20, "*"))
        'Disables Roll button after first click and enables Reroll.
        RollButton.Enabled = False
        ReRollButton.Enabled = True
    End Sub
    'Button that clears the listbox and rolls the two dice again and redisplays the results.
    Private Sub ReRollButton_Click(sender As Object, e As EventArgs) Handles ReRollButton.Click, RerollToolStripMenuItem.Click
        Dim sumDice As Integer
        Static firstDice As Integer
        Static secondDice As Integer
        Dim diceArray(1, 12) As Integer
        TotalsListBox.Items.Clear()
        For i = 1 To 1000
            Randomize()
            firstDice = CInt((5 * Rnd()) + 1)
            Randomize()
            secondDice = CInt((5 * Rnd()) + 1)
            sumDice = firstDice + secondDice
            For j = 2 To 12
                diceArray(0, j) = j
            Next
            For j = 2 To 12
                diceArray(1, sumDice) += 1
            Next
        Next
        TotalsListBox.Items.Add(Space(2) & "Result of Reroll" & Space(2))
        TotalsListBox.Items.Add(StrDup(20, "*"))
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
        TotalsListBox.Items.Add(StrDup(20, "*"))
    End Sub
    'Button that closes the program.
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Button that clears the listbox.
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem.Click
        TotalsListBox.Items.Clear()
    End Sub
End Class
