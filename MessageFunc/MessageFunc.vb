﻿Module MessageFunc

    Sub Main()
        'MsgBox(UserMessages(True, "Hello", False))
        Console.WriteLine(UserMessages(True, "Hello 1", False))
        Console.WriteLine(UserMessages(True, "Hello 2", False))
        Console.WriteLine(UserMessages(True, "Hello 3", False))
        MsgBox(UserMessages(True, "", False))
    End Sub

    Function UserMessages(addMessage As Boolean, message As String, clearMessage As Boolean) As String
        Static formattedMessages As String '= ""

        formattedMessages &= message & vbNewLine

        Return formattedMessages

    End Function

End Module
