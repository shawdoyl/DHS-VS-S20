'Doyle Shaw
'RCET0265
'Spring 2020
'Sub-routine Example
'https://github.com/shawdoyl/DHS-VS-S20

Module Module1

    Sub Main()
        Dim myNumber As Integer
        myNumber = 7
        Console.WriteLine("In Sub Main")
        Console.WriteLine(myNumber)
        Console.ReadLine()
        MySub(myNumber)
        myNumber = MyFunc(myNumber)
        Console.WriteLine("In Sub Main")
        Console.WriteLine(myNumber)
        'Console.WriteLine("In Sub Main")
        'Console.WriteLine(myNumber)
        Console.ReadLine()
    End Sub

    Sub MySub(myNumber As Integer)
        'Dim myNumber As Integer
        myNumber = myNumber + 3
        myNumber += 3
        Console.WriteLine("In Sub MySub")
        Console.WriteLine(myNumber)
        Console.ReadLine()
    End Sub

    Function MyFunc(myNumber As Integer) As Integer
        'Dim myNumber As Integer
        myNumber -= 65
        Console.WriteLine("In Function MyFunc")
        Console.WriteLine(myNumber)
        Console.ReadLine()
        Return myNumber
    End Function

End Module
