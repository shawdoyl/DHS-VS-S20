'Shaw_Doyle
'RCET0265
'Spring 2020
'Address label program
'https://github.com/shawdoyl/DHS-VS-S20

Module MessageFunc

    Sub Main()

        'Console.WriteLine(UserMessages(True, "Hello 1", False))
        'Console.WriteLine(UserMessages(True, "Hello 2", False))
        'Console.WriteLine(UserMessages(True, "Hello 3", False))
        'MsgBox(UserMessages(False, "", False))
        TestUserMessages()
        Console.ReadLine()

    End Sub

    Function UserMessages(addMessage As Boolean, message As String, clearMessage As Boolean) As String

        Static formattedMessages As String

        If clearMessage = True Then
            formattedMessages = ""
        ElseIf addMessage = True Then
            formattedMessages &= message & vbNewLine
        End If

        Return formattedMessages

    End Function

    Sub TestUserMessages()
        Dim evaluate As String
        Dim control As String
        Dim testString As String
        Dim testCounter As Integer

        For i = 1 To 5
            testString = "Test 1 " & Str(i)
            control &= testString & vbNewLine
            evaluate = UserMessages(True, "Test 1", False)

            If evaluate = control Then
                Console.WriteLine("Test " & Str(i) & "Pass")
            Else
                Console.WriteLine("Test " & Str(i) & "Fail")
                Console.WriteLine("expected: " & vbNewLine & control)
                Console.WriteLine("Actual: " & vbNewLine & evaluate)
            End If
        Next
    End Sub
End Module
