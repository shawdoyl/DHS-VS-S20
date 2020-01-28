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
        Dim mathFunction As String

        Console.WriteLine("Please enter first number. Press Enter to proceed.")
        firstNumber = Console.ReadLine()
        Console.WriteLine("Please enter second number. Press Enter to proceed.")
        secondNumber = Console.ReadLine()
        Console.WriteLine("Please enter desired function of; product(*), sum(+), difference(-), quotient(/), or exponent(^). Press Enter to finish calcultion.")
        mathFunction = Console.ReadLine()

        If mathFunction = "Sum" Or mathFunction = "Addition" Or mathFunction = "Add" Or mathFunction = "+" Then
            Try
                Console.WriteLine(firstNumber & "/" & secondNumber & "=")
                Console.WriteLine(CInt(firstNumber) / CInt(secondNumber))
            Catch ex As InvalidCastException
                Console.WriteLine("Please Enter a Whole Number.")
            Catch ex As Exception
                Console.WriteLine("This is broken now.")
            End Try
        ElseIf mathFunction = "*" Or mathFunction = "Multiply" Or mathFunction = "Multiplication" Or mathFunction = "Product" Then
            Try
                Console.WriteLine(firstNumber & "/" & secondNumber & "=")
                Console.WriteLine(CInt(firstNumber) / CInt(secondNumber))
            Catch ex As InvalidCastException
                Console.WriteLine("Please Enter a Whole Number.")
            Catch ex As Exception
                Console.WriteLine("This is broken now.")
            End Try
        ElseIf mathFunction = "-" Or mathFunction = "Subtract" Or mathFunction = "Minus" Or mathFunction = "Difference" Then
            Try
                Console.WriteLine(firstNumber & "/" & secondNumber & "=")
                Console.WriteLine(CInt(firstNumber) / CInt(secondNumber))
            Catch ex As InvalidCastException
                Console.WriteLine("Please Enter a Whole Number.")
            Catch ex As Exception
                Console.WriteLine("This is broken now.")
            End Try
        ElseIf mathFunction = "Quotient" Or mathFunction = "/" Or mathFunction = "Divide" Or mathFunction = "Division" Then
            Try
                Console.WriteLine(firstNumber & "/" & secondNumber & "=")
                Console.WriteLine(CInt(firstNumber) / CInt(secondNumber))
            Catch ex As InvalidCastException
                Console.WriteLine("Please Enter a Whole Number.")
            Catch ex As Exception
                Console.WriteLine("This is broken now.")
            End Try
        ElseIf mathFunction = "Exponent" Or mathFunction = "^" Or mathFunction = "To the Power of" Then
            Try
                Console.WriteLine(firstNumber & "^" & secondNumber & "=")
                Console.WriteLine(CInt(firstNumber) ^ CInt(secondNumber))
            Catch ex As InvalidCastException
                Console.WriteLine("Please Enter a Whole Number.")
            Catch ex As Exception
                Console.WriteLine("This is broken now.")
            End Try
        Else
            Console.WriteLine("That is not an appropiate Response.")
        End If

        Console.WriteLine("Have A Nice Day.")
        Console.ReadLine()

    End Sub

End Module
