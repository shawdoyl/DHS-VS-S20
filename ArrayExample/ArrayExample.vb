Module ArrayExample

    Sub Main()
        Dim myArray(3) As Integer

        myArray(1) = 5

        myArray = {1, 2, 3, 4}

        myArray(0) = 5
        ReDim Preserve myArray(15)

        Dim anotherMatrix = New Integer(3, 2) {{1, 2, 3}, {2, 3, 4}, {3, 4, 5}, {4, 5, 6}}

        ANotherArrayExample()

        Console.ReadLine()
    End Sub




    Sub AnotherArrayExample()
        'No element definition
        Dim infoArray() As String

        infoArray = Split("Hello,Goodbye,    Pizza, Hungry, Ice Cream", ",")

        'For Each thingy As String In infoArray
        '    Console.WriteLine(thingy)
        '    infoArray.Contains(thingy)
        'Next

        For i = LBound(infoArray) To UBound(infoArray)
            Console.WriteLine("at " & Str(i) & " Value is " & infoArray(i))
        Next


        Console.ReadLine()

    End Sub


End Module
