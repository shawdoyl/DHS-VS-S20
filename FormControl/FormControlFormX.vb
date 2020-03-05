﻿Public Class FormControlFormX
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim displayText As String

        displayText = NameTextBox.Text & vbNewLine & StreetTextBox.Text & vbNewLine & StateTextBox.Text
        DisplayLabel.Text = displayText

    End Sub

    Private Sub Go_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        If CheckBox1.Checked = True Then
            DisplayLabel.Text = NameTextBox.Text
        End If
        If CheckBox2.Checked = True Then
            MsgBox("Hello, your data is no good.")
        End If
        If CheckBox3.Checked = True Then
            UserPictureBox.Image = My.Resources.moon_elf
        Else
            UserPictureBox.Image = Nothing
        End If
    End Sub

    Private Sub FormControlFormX_Load(sender As Object, e As EventArgs) Handles Me.Load
        ResetAllControls()
    End Sub

    Sub ResetAllControls()

        'clear all textboxes
        NameTextBox.Text = ""
        StreetTextBox.Text = ""
        StateTextBox.Text = ""

        'start up selection
        RadioButton1.Checked = True
        RadioButton4.Checked = True

        'Disabled by default
        GoButton.Enabled = False
        UpdateButton.Enabled = False
        UserSelection.Enabled = False

        'Same as Disabling UserSelection below
        'RadioButton1.Enabled = False
        'RadioButton2.Enabled = False
        'RadioButton3.Enabled = False
        'CheckBox1.Enabled = False
        'CheckBox2.Enabled = False
        'CheckBox3.Enabled = False
        'CheckBox7.Enabled = False

    End Sub

    Private Sub AnyTextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged, StreetTextBox.TextChanged, StateTextBox.TextChanged
        EvaluateTextBoxes()
    End Sub

    Sub EvaluateTextBoxes()

        If NameTextBox.Text <> "" And StreetTextBox.Text <> "" And StateTextBox.Text <> "" Then
            UserSelection.Enabled = True
            UpdateButton.Enabled = True
        Else
            UserSelection.Enabled = False
            UpdateButton.Enabled = False
        End If

    End Sub

    Private Sub AgeTextBox_Validate(sender As Object, e As EventArgs) Handles AgeTextBox.Leave
        Dim tempNumber As Integer
        Try
            tempNumber = CInt(AgeTextBox.Text)
            If tempNumber > 15 And tempNumber < 27 Then
                MsgBox("Good Job.")
            Else
                MsgBox("Sorry Try the kiddy rides")
                AgeTextBox.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Please enter a valid age.")
            AgeTextBox.Text = ""
        End Try



    End Sub
End Class

