﻿'Shaw_Doyle
'RCET0265
'Spring 2020
'Math Contest
'https://github.com/shawdoyl/DHS-VS-S20

Public Class MathContestForm

    Dim numberOfProblems As Integer = 0
    Dim numberOfProblemsCorrect As Integer = 0
    Dim studentAge As Integer
    Dim studentGrade As Integer
    Dim firstNumber As Integer
    Dim secondNumber As Integer
    Dim studentAnswer As Integer
    Dim actualAnswer As Integer
    Dim studentName As String = ""

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click

        Dim userMessage As String
        If AddRadioButton.Checked = True Then
            actualAnswer = firstNumber + secondNumber
        ElseIf SubtractRadioButton.Checked = True Then
            actualAnswer = firstNumber - secondNumber
        ElseIf DivideRadioButton.Checked = True Then
            actualAnswer = firstNumber / secondNumber
        ElseIf MultiplyRadioButton.Checked = True Then
            actualAnswer = firstNumber * secondNumber
        End If

        If studentAnswer = actualAnswer Then
            userMessage = "Good job, " & studentName & ", that is correct!"
            numberOfProblemsCorrect += 1
        Else
            userMessage = "Sorry, " & studentName & ", that is not correct. The correct " _
                        & "answer was " & actualAnswer & "."
        End If
        MsgBox(userMessage)
        FirstNumberTextBox.Text = ""
        SecondNumberTextBox.Text = ""
        AnswerTextBox.Text = ""
        SummaryButton.Enabled = True
        numberOfProblems += 1

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        numberOfProblems = 0
        numberOfProblemsCorrect = 0
        NameTextBox.Text = ""
        GradeTextBox.Text = ""
        AgeTextBox.Text = ""
        AnswerTextBox.Text = ""
        FirstNumberTextBox.Text = ""
        SecondNumberTextBox.Text = ""
        ResetAllControls()
    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        MsgBox("You got " & numberOfProblemsCorrect & " answers correct out of all possible " & numberOfProblems)
    End Sub

    Private Sub MathContest_Load(sender As Object, e As EventArgs) Handles Me.Load
        ResetAllControls()
    End Sub

    Sub ResetAllControls()
        AddRadioButton.Enabled = False
        SubtractRadioButton.Enabled = False
        MultiplyRadioButton.Enabled = False
        DivideRadioButton.Enabled = False
        SubmitButton.Enabled = False
        SummaryButton.Enabled = False
        FirstNumberTextBox.Enabled = False
        SecondNumberTextBox.Enabled = False
        AnswerTextBox.Enabled = False
        AddRadioButton.Checked = True
        NameTextBox.Enabled = True
        AgeTextBox.Enabled = True
        GradeTextBox.Enabled = True
        ValidateButton.Enabled = True
    End Sub

    Private Sub ValidateClick(sender As Object, e As EventArgs) Handles ValidateButton.Click
        Dim userMessage As String = ""
        Dim AgeBad As Boolean = False
        Dim GradeBad As Boolean = False
        If NameTextBox.Text = "" Then
            userMessage = "Please enter the students name." & vbNewLine
        Else
            studentName = NameTextBox.Text
        End If

        Try
            studentAge = CInt(AgeTextBox.Text)
            If studentAge > 6 And studentAge < 12 Then
            Else
                userMessage &= "Sorry, only students that are between 7 and 11 may compete" & vbNewLine
            End If
        Catch ex As Exception
            userMessage &= "Please enter a valid age" & vbNewLine
            AgeBad = True
        End Try
        Try
            studentGrade = CInt(GradeTextBox.Text)
            If studentGrade > 0 And studentGrade < 5 Then
            Else
                userMessage &= "Sorry, only students that are in grades 1 through 4 may compete" & vbNewLine
            End If
        Catch ex As Exception
            userMessage &= "Please enter a valid grade" & vbNewLine
            GradeBad = True
        End Try
        If userMessage <> "" Then
            MsgBox(userMessage)
            If AgeBad = True Then
                AgeTextBox.Text = ""
            End If
            If GradeBad = True Then
                GradeTextBox.Text = ""
            End If
            If NameTextBox.Text = "" Then
                NameTextBox.Select()
            ElseIf AgeBad = True Then
                AgeTextBox.Select()
            ElseIf GradeBad = True Then
                GradeTextBox.Select()
            End If
        Else
            AddRadioButton.Enabled = True
            SubtractRadioButton.Enabled = True
            MultiplyRadioButton.Enabled = True
            DivideRadioButton.Enabled = True
            FirstNumberTextBox.Enabled = True
            SecondNumberTextBox.Enabled = True
            AnswerTextBox.Enabled = True
            NameTextBox.Enabled = False
            AgeTextBox.Enabled = False
            GradeTextBox.Enabled = False
            ValidateButton.Enabled = False
        End If
    End Sub

    Private Sub AnyNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstNumberTextBox.TextChanged, SecondNumberTextBox.TextChanged, AnswerTextBox.TextChanged
        Dim userMessage As String = ""
        Dim firstNumberGood As Boolean
        Dim secondNumberGood As Boolean
        Dim AnswerGood As Boolean
        firstNumberGood = False
        secondNumberGood = False
        AnswerGood = False

        If FirstNumberTextBox.Text <> "" Then
            Try
                firstNumber = CInt(FirstNumberTextBox.Text)
                If firstNumber < 13 Then
                    firstNumberGood = True
                Else
                    userMessage &= "Please enter a number less than 13 in first number box" & vbNewLine
                End If
            Catch ex As Exception
                MsgBox("Please enter a valid number in first number box")
                FirstNumberTextBox.Text = ""
            End Try
        End If
        If SecondNumberTextBox.Text <> "" Then
            Try
                secondNumber = CInt(SecondNumberTextBox.Text)
                If firstNumber < 13 Then
                    secondNumberGood = True
                Else
                    userMessage &= "Please enter a number less than 13 in second number box" & vbNewLine
                End If
            Catch ex As Exception
                MsgBox("Please enter a valid number in second number box")
                SecondNumberTextBox.Text = ""
            End Try
        End If

        If AnswerTextBox.Text <> "" Then
            Try
                AnswerGood = True
            Catch ex As Exception
                MsgBox("Please enter a valid answer")
            End Try
        End If

        If userMessage <> "" Then
            MsgBox(userMessage)
        Else
        End If
        If firstNumberGood = True And secondNumberGood = True And AnswerGood = True Then
            SubmitButton.Enabled = True
        Else
            SubmitButton.Enabled = False
        End If
    End Sub

End Class
