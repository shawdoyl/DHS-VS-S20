'Create a program that rolls 2D6
'Adds the sum of the two and keep track in an array
'Display the results after 1000 rolls of the dice
'write to console thge totals with formatted columns with headers

Module Program
    Sub Main()
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



        Console.WriteLine("                        Roll of the Dice")
        Console.WriteLine("------------------------------------------------------------------")
        For i = 2 To 12
            Console.Write(CStr(diceArray(0, i)).PadRight(5) & "|")

        Next
        Console.WriteLine(System.Environment.NewLine & "------------------------------------------------------------------")
        For j = 2 To 12
            Console.Write(CStr(diceArray(1, j)).PadRight(5) & "|")
        Next
        Console.WriteLine(System.Environment.NewLine & "------------------------------------------------------------------")

        'Console.WriteLine("|" & CStr(diceArray(0, 2)).PadRight(5) & "|" & diceArray(1, 2))
        'Console.WriteLine("|" & CStr(diceArray(0, 3)).PadRight(5) & "|" & diceArray(1, 3))
        'Console.WriteLine("|" & CStr(diceArray(0, 4)).PadRight(5) & "|" & diceArray(1, 4))
        'Console.WriteLine("|" & CStr(diceArray(0, 5)).PadRight(5) & "|" & diceArray(1, 5))
        'Console.WriteLine("|" & CStr(diceArray(0, 6)).PadRight(5) & "|" & diceArray(1, 6))
        'Console.WriteLine("|" & CStr(diceArray(0, 7)).PadRight(5) & "|" & diceArray(1, 7))
        'Console.WriteLine("|" & CStr(diceArray(0, 8)).PadRight(5) & "|" & diceArray(1, 8))
        'Console.WriteLine("|" & CStr(diceArray(0, 9)).PadRight(5) & "|" & diceArray(1, 9))
        'Console.WriteLine("|" & CStr(diceArray(0, 10)).PadRight(5) & "|" & diceArray(1, 10))
        'Console.WriteLine("|" & CStr(diceArray(0, 11)).PadRight(5) & "|" & diceArray(1, 11))
        'Console.WriteLine("|" & CStr(diceArray(0, 12)).PadRight(5) & "|" & diceArray(1, 12))
        'Console.WriteLine("************")

    End Sub


End Module
