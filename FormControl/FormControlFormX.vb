Public Class FormControlFormX
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim displayText As String

        displayText = NameTextBox.Text & vbNewLine & StreetTextBox.Text & vbNewLine & StateTextBox.Text
        DisplayLabel.Text = displayText

    End Sub

    Private Sub Street_Click(sender As Object, e As EventArgs) Handles StreetLabel.Click

    End Sub

    Private Sub Go_Click(sender As Object, e As EventArgs) Handles Go.Click
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
        RadioButton1.Checked = True
    End Sub

End Class
