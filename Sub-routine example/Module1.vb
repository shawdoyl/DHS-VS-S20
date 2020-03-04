'Doyle Shaw
'RCET0265
'Spring 2020
'Sub-routine Example
'https://github.com/shawdoyl/DHS-VS-S20

Option Strict On
Option Explicit On
Option Compare Text

Module Module1

    Sub Main()

        'Dim myNumber As Integer
        'myNumber = 7
        'Console.WriteLine("In Sub Main")
        'Console.WriteLine(myNumber)
        'Console.ReadLine()
        'myNumber = MyFunc(myNumber)
        'MySubTheSequel(7, 5, "Multiply")
        'For i = 1 To 80 Step 20
        'ShowPattern(24, "Doyle")
        'Next
        'playSound()
        Dim someNumberInMain As Integer
        someNumberInMain = 17
        MySub(someNumberInMain)
        'Console.ReadLine()

    End Sub

    'ByVal Creates a copy -- Safe
    'ByRef points at the callers actual variable -- Less Safe
    'Sub MySub(ByRef myNumberInMySub As Integer)
    Sub MySub(ByVal myNumberInMySub As Integer)

        '    Dim myNumber As Integer
        '    myNumber = myNumber + 3
        myNumberInMySub += 3
        Console.WriteLine("In Sub MySub")
        Console.WriteLine(myNumberInMySub)
        Console.ReadLine()

    End Sub

    'Function MyFunc(myNumber As Integer) As Integer

    '    Dim myNumber As Integer
    '    myNumber -= 65
    '    Console.WriteLine("In Function MyFunc")
    '    Console.WriteLine(myNumber)
    '    Console.ReadLine()
    '    Return myNumber

    'End Function

    'Sub MySubTheSequel(firstNumber As Integer, easterEgg As Integer, operatorChoice As String)

    '   Dim result As Double

    '   If operatorChoice = "Add" Then
    '        result = firstNumber + easterEgg
    '   ElseIf operatorChoice = "Subtract" Then
    '      result = firstNumber - easterEgg
    '   ElseIf operatorChoice = "Multiply" Then
    '       result = firstNumber * easterEgg
    '   ElseIf operatorChoice = "Divide" Then
    '      result = firstNumber / easterEgg
    '   End If
    '   Console.WriteLine(result)

    'End Sub

    Sub ShowPattern(length As Integer, character As String)

        'Dim character As String
        Dim pattern As String
        Console.WriteLine(Len(character))
        'character = "*"
        pattern = ""
        For index = 1 To length Step 1
            pattern &= character
            Console.WriteLine(pattern)
        Next

        For index = length - 1 To 1 Step -1
            pattern = Left(pattern, index * Len(character))
            Console.WriteLine(pattern)

        Next

    End Sub

    Sub playSound()
        'Console.Beep(392, 500) 'G4'
        'Console.Beep(440, 500) 'A4'
        'Console.Beep(349, 750)
        'Console.Beep(196, 750)
        'Console.Beep(262, 500)
        'Console.Beep(440, 250)
        'Console.Beep(440, 250)
        'Console.Beep(440, 250)
        'Console.Beep(440, 1000)
        'Console.Beep(440, 1000)
        'Console.Beep(440, 1000)
    End Sub

End Module
