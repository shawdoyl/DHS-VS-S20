'Doyle_Shaw
'RCET0265
'Spring_2020
'Say_My_Name
'https://github.com/shawdoyl/DHS-VS-S20

Option Explicit On
Option Strict On

Module WasistmeinName

    Sub Main()

        Dim userMessage As String
        Console.WriteLine("Please enter your name. Press Enter when done.")
        userMessage = Console.ReadLine()

        If userMessage = "Doyle" Then
            Console.WriteLine("Welcome back Tigerfang.")
        ElseIf userMessage = "Joe" Then
            Console.WriteLine("Welcome  back user " & userMessage & ".")
        ElseIf userMessage = "Emily" Then
            Console.WriteLine("Welcome back user " & userMessage & ".")
        Else
            Console.WriteLine("Welcome new user.")
        End If

        Console.ReadLine()

    End Sub

End Module