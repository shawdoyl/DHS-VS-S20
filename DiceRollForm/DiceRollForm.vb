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
            Select Case sumDice
                Case sumDice
                    diceArray(1, sumDice) += 1
            End Select
        Next

        TotalsListBox.Items.Add(Space(3) & "Result of Roll" & Space(2))
        TotalsListBox.Items.Add(StrDup(20, "*"))
        TotalsListBox.Items.Add("|Value" & Space(5) & "|# ")
        TotalsListBox.Items.Add(StrDup(20, "*"))
        For i = 2 To 12
            TotalsListBox.Items.Add("|" & CStr(diceArray(0, i)).PadRight(10) & "|" & diceArray(1, i))
        Next
        TotalsListBox.Items.Add(StrDup(20, "*"))

        'Disables Roll button after first click and enables Reroll.
        RollButton.Enabled = False
        ReRollButton.Enabled = True
        RerollToolStripMenuItem.Enabled = True
        RollToolStripMenuItem.Enabled = False

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

            Select Case sumDice
                Case sumDice
                    diceArray(1, sumDice) += 1
            End Select
        Next

        TotalsListBox.Items.Add(Space(3) & "Result of Roll" & Space(2))
        TotalsListBox.Items.Add(StrDup(20, "*"))
        TotalsListBox.Items.Add("|Value" & Space(5) & "|# ")
        TotalsListBox.Items.Add(StrDup(20, "*"))
        For i = 2 To 12
            TotalsListBox.Items.Add("|" & CStr(diceArray(0, i)).PadRight(10) & "|" & diceArray(1, i))
        Next
        TotalsListBox.Items.Add(StrDup(20, "*"))

    End Sub

    'Button that closes the program.
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Button that clears the listbox, and resets the Roll and Reroll buttons.
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem.Click
        TotalsListBox.Items.Clear()
        RollButton.Enabled = True
        ReRollButton.Enabled = False
        RerollToolStripMenuItem.Enabled = False
        RollToolStripMenuItem.Enabled = True
    End Sub

    'Toolstrip menu to show some details of the program
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("DiceRolle program Beta Version 1.0.001" & vbNewLine _
               & "Doyle Shaw" & vbNewLine _
               & "Spring 2020" & vbNewLine _
               & "RCET0265" & vbNewLine _
               & "In association with Elmer Fudd Industries.")
    End Sub

End Class
