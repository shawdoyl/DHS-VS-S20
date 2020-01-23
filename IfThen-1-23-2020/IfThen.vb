'Doyle_Shaw
'RCET0265
'Spring_2020
'IfThen
'https://github.com/shawdoyl/DHS-VS-S20

Module IfThen

    Sub Main()

        Dim firstNumber As Integer
        Dim secondNumber As Integer

        firstNumber = 5
        secondNumber = 3

        If firstNumber > secondNumber Then
            Console.WriteLine("First number is greater...")
        ElseIf firstNumber < secondNumber Then
            Console.WriteLine("Second number is greater...")
        ElseIf firstNumber = secondNumber Then
            Console.WriteLine("Numbers are equal...")
        End If

        If firstNumber <= secondNumber Then
            Console.WriteLine("First number is is smaller or equal...")
        ElseIf firstNumber >= secondNumber Then
            Console.WriteLine("First number is is greater or equal...")
        ElseIf firstNumber <> secondNumber Then
            Console.WriteLine("No Numbers are equal...")
        Else
            Console.WriteLine("Some other thing???")
        End If
        Console.ReadLine()

    End Sub

End Module
