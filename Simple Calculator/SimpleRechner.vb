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
            Try
                Console.WriteLine(firstNumber & "+" & secondNumber & "=")
                Console.WriteLine(CInt(firstNumber) + CInt(secondNumber))
            Catch ex As Exception
                Console.WriteLine("Please Enter a Whole Number.")
                Console.WriteLine(ex.Message.ToString)
            End Try
        ElseIf mathSymbol = "*" Or mathSymbol = "Multiply" Or mathSymbol = "Multiplication" Or mathSymbol = "Product" Then
            Try
                Console.WriteLine(firstNumber & "*" & secondNumber & "=")
                Console.WriteLine(CInt(firstNumber) * CInt(secondNumber))
            Catch ex As Exception
                Console.WriteLine("Please Enter a Whole Number.")
            End Try
        ElseIf mathSymbol = "-" Or mathSymbol = "Subtract" Or mathSymbol = "Minus" Or mathSymbol = "Difference" Then
            Try
                Console.WriteLine(firstNumber & "-" & secondNumber & "=")
                Console.WriteLine(CInt(firstNumber) - CInt(secondNumber))
            Catch ex As Exception
                Console.WriteLine("Please Enter a Whole Number.")
            End Try
        ElseIf mathSymbol = "Quotient" Or mathSymbol = "/" Or mathSymbol = "Divide" Or mathSymbol = "Division" Then
            Try
                Console.WriteLine(firstNumber & "/" & secondNumber & "=")
                Console.WriteLine(CInt(firstNumber) / CInt(secondNumber))
            Catch ex As Exception
                Console.WriteLine("Please Enter a Whole Number.")
            End Try
        Else
            Console.WriteLine("That is not an appropiate Response.")
        End If

        Console.WriteLine("Have A Nice Day.")
        Console.ReadLine()

    End Sub

End Module
