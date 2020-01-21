Option Explicit On
Option Strict On

Module MehrOperators

    Sub Main()

        'prompt user for a message
        'then display the message
        Dim userMessage As String
        'userMessage = "Hello"

        Console.WriteLine("Please enter a message. Press Enter when done.")
        userMessage = Console.ReadLine()
        Console.WriteLine("You entered " & userMessage & " Good Job!")
        Console.ReadLine()

    End Sub

End Module
