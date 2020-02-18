﻿Public Class ValidateUserDataForm

    Private Sub ValidateButton_Click(sender As Object, e As EventArgs) Handles ValidateButton.Click
        Dim userMessage As String

        'Empty()
        If IsStringEmpty(TextBox3.Text) = True Then
            userMessage &= ("Please enter text in testbox 3.") & vbNewLine
            TextBox3.Select()
        End If

        If IsStringEmpty(TextBox2.Text) = True Then
            userMessage &= ("Please enter text in testbox 2.") & vbNewLine
            TextBox3.Select()
        End If

        If IsStringEmpty(TextBox1.Text) = True Then
            userMessage &= ("Please enter text in testbox 1.") & vbNewLine
            TextBox3.Select()
        End If

        If userMessage <> "" Then
            MsgBox(userMessage)
        End If

    End Sub

    Sub Empty()
        'Check each textbox and alert user if empty.
        Dim userMessage As String

        '
        'Select Case ""
        '    Case TextBox3.Text
        '        userMessage &= ("Please enter text in testbox 3.") & vbNewLine
        '    Case TextBox2.Text
        '        userMessage &= ("Please enter text in testbox 2.") & vbNewLine
        '    Case TextBox1.Text
        '        userMessage &= ("Please enter text in testbox 1.") & vbNewLine
        'End Select

        If TextBox3.Text = "" Then
            userMessage &= ("Please enter text in testbox .") & vbNewLine
            TextBox3.Select()
        End If

        If TextBox2.Text = "" Then
            userMessage &= ("Please enter text in testbox 2.") & vbNewLine
            TextBox2.Select()
        End If

        If TextBox1.Text = "" Then
            userMessage &= ("Please enter text in textbox 1.") & vbNewLine
            TextBox1.Select()
        End If

        If userMessage <> "" Then
            MsgBox(userMessage)
        End If

    End Sub

    Function IsStringEmpty(stringToTest As String) As Boolean
        Dim status As Boolean
        If stringToTest = "" Then
            status = True
        Else
            status = False
        End If
        Return status
    End Function

    Function RunningTotal(currentValue As Integer) As Integer
        Static total As Integer

        total += currentValue

        Return total
    End Function

    Private Sub TotalButton_Click(sender As Object, e As EventArgs) Handles TotalButton.Click
        Dim tempNumber As Integer
        Const VALUE = 5I 'Another way to declare As Integer.

        For i = 1 To 10
            tempNumber = RunningTotal(VALUE)
        Next

        Console.WriteLine(tempNumber)
    End Sub
End Class
