'Doyle_Shaw
'RCET0265
'Spring_2020
'Simple_Calculator
'https://github.com/shawdoyl/DHS-VS-S20

Option Explicit On
Option Strict On
Option Compare Text

Module SimpleRechner

    Sub Main()

        Dim firstNumber As String
        Dim secondNumber As String
        Dim mathSymbol As String

        Console.WriteLine("Please enter first number. Press Enter to proceed.")
        firstNumber = Console.ReadLine()
        Console.WriteLine("Please enter second number. Press Enter to proceed.")
        secondNumber = Console.ReadLine()
        Console.WriteLine("Please enter desired function of; product(*), sum(+), difference(-), or quotient(/). Press Enter to finish calcultion.")
        mathSymbol = Console.ReadLine()

        If mathSymbol = "Sum" Or mathSymbol = "Addition" Or mathSymbol = "Add" Or mathSymbol = "+" Then
            Console.WriteLine(firstNumber & "+" & secondNumber & "=")
            Console.WriteLine(CInt(firstNumber) + CInt(secondNumber))
        ElseIf mathSymbol = "*" Or mathSymbol = "Multiply" Or mathSymbol = "Multiplication" Or mathSymbol = "Product" Then
            Console.WriteLine(firstNumber & "*" & secondNumber & "=")
            Console.WriteLine(CInt(firstNumber) * CInt(secondNumber))
        ElseIf mathSymbol = "-" Or mathSymbol = "Subtract" Or mathSymbol = "Minus" Or mathSymbol = "Difference" Then
            Console.WriteLine(firstNumber & "-" & secondNumber & "=")
            Console.WriteLine(CInt(firstNumber) - CInt(secondNumber))
        ElseIf mathSymbol = "Quotient" Or mathSymbol = "/" Or mathSymbol = "Divide" Or mathSymbol = "Division" Then
            Console.WriteLine(firstNumber & "/" & secondNumber & "=")
            Console.WriteLine(CInt(firstNumber) / CInt(secondNumber))
        Else
            Console.WriteLine("That is not an appropiate Response.")
        End If

        Console.ReadLine()

    End Sub

End Module
