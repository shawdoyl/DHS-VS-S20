Module ListExample

    Sub Main()
        Dim names As New List(Of String)
        Dim searchString As String

        names.Add("Doyle")
        names.Add("Doxle")

        searchString = Console.ReadLine()

        If names.Contains(searchString) Then
            Console.WriteLine("Name " & searchString & " was found. It is in Index " & names.IndexOf(searchString))
        Else
            Console.WriteLine("Sorry " & searchString & " was not found.")
        End If


        'names.Contains(searchString)

        'Console.WriteLine(names.Contains(searchString))


        'names.Add(Console.ReadLine())

        'Console.WriteLine(names.Contains("Doyle"))

        'For Each name In names
        '    Console.WriteLine(name)
        'Next

        Console.ReadLine()
    End Sub

End Module
