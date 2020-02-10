'Doyle_Shaw
'RCET0265
'Spring_2020
'Simple_Calculator
'https://github.com/shawdoyl/DHS-VS-S20

Option Explicit On
Option Strict On
Option Compare Text

Module BetterCalculator

    Sub Main()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim mathFunction As String
        Dim quitProgram As Boolean
        Dim promptUser As Boolean

        promptUser = True
        quitProgram = False

        Do While quitProgram = False

            Console.WriteLine("Please enter first number. Press Enter to proceed.")
            Console.WriteLine("Press Q to to Exit at any time.")
            Do While promptUser = True
                Try
                    firstNumber = CInt(Console.ReadLine())
                    promptUser = False
                Catch ex As Exception
                    Console.WriteLine("Please Enter a Whole Number.")
                    promptUser = True
                End Try
            Loop
            promptUser = True

            Console.WriteLine("You entered " & firstNumber & ".")
            Console.WriteLine("Please enter second number. Press Enter to proceed.")
            Do While promptUser = True
                Try
                    secondNumber = CInt(Console.ReadLine())
                    promptUser = False
                Catch ex As Exception
                    Console.WriteLine("Please Enter a Whole Number.")
                    promptUser = True
                End Try
            Loop
            promptUser = True

            Console.WriteLine("Please enter desired function. Press Enter to finish calcultion.")
            Console.WriteLine("1. product(*)")
            Console.WriteLine("2. sum(+)")
            Console.WriteLine("3. difference(-)")
            Console.WriteLine("4. quotient(/)")
            Console.WriteLine("5. exponent(^)")
            mathFunction = Console.ReadLine()

            If mathFunction = "Sum" Or mathFunction = "Addition" Or mathFunction = "Add" Or mathFunction = "+" Or mathFunction = "2" Then
                Try
                    Console.WriteLine(firstNumber & "+" & secondNumber & "=" & firstNumber + secondNumber)
                Catch ex As InvalidCastException
                    Console.WriteLine("Please Enter a Whole Number.")
                Catch ex As Exception
                    Console.WriteLine("This is broken now.")
                End Try
            ElseIf mathFunction = "*" Or mathFunction = "Multiply" Or mathFunction = "Multiplication" Or mathFunction = "Product" Or mathFunction = "Mult" Or mathFunction = "1" Then
                Try
                    Console.WriteLine(firstNumber & "*" & secondNumber & "=" & firstNumber * secondNumber)
                Catch ex As InvalidCastException
                    Console.WriteLine("Please Enter a Whole Number.")
                Catch ex As Exception
                    Console.WriteLine("This is broken now.")
                End Try
            ElseIf mathFunction = "-" Or mathFunction = "Subtract" Or mathFunction = "Minus" Or mathFunction = "Difference" Or mathFunction = "Sub" Or mathFunction = "3" Then
                Try
                    Console.WriteLine(firstNumber & "-" & secondNumber & "=" & firstNumber - secondNumber)
                Catch ex As InvalidCastException
                    Console.WriteLine("Please Enter a Whole Number.")
                Catch ex As Exception
                    Console.WriteLine("This is broken now.")
                End Try
            ElseIf mathFunction = "Quotient" Or mathFunction = "/" Or mathFunction = "Divide" Or mathFunction = "Division" Or mathFunction = "Div" Or mathFunction = "4" Then
                Try
                    Console.WriteLine(firstNumber & "/" & secondNumber & "=" & firstNumber / secondNumber)
                Catch ex As InvalidCastException
                    Console.WriteLine("Please Enter a Whole Number.")
                Catch ex As Exception
                    Console.WriteLine("This is broken now.")
                End Try
            ElseIf mathFunction = "Exponent" Or mathFunction = "^" Or mathFunction = "To the Power of" Or mathFunction = "5" Then
                Try
                    Console.WriteLine(firstNumber & "^" & secondNumber & "=" & firstNumber ^ secondNumber)
                Catch ex As InvalidCastException
                    Console.WriteLine("Please Enter a Whole Number.")
                Catch ex As Exception
                    Console.WriteLine("This is broken now.")
                End Try
            Else
                Console.WriteLine("That is not an appropiate Response.")
            End If

            Console.WriteLine("Press Enter to continue, enter Q then Enter to quit program.")

            If Console.ReadLine() = "q" Then
                quitProgram = True
            Else
                quitProgram = False
            End If

            Console.Clear()

        Loop

        Console.WriteLine("Have A Nice Day.")
        Console.ReadLine()


    End Sub

End Module
