Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Encrypt.Click
        Dim Message As String = MessageBox.Text 'Declare message as user inputted message
        Dim EncryptValue As Integer
        Randomize()
        EncryptValue = (8) * Rnd() + 1 'Randomly selects how much to increase the unicode by (from 1 to 9)
        Dim EncryptMessage As String
        FinalOutput.Text = EncryptValue
        For i = 1 To Message.Length ' Runs as many times as there are characters in the message
            EncryptMessage = Asc(Message) ' Converts the firtst character in the string into unicode
            FinalOutput.Text = FinalOutput.Text & ChrW(EncryptMessage + EncryptValue) ' Adds the random integer to the unicode, then converts it back to characters, then using an accumulator adds it to a label
            Message = Message.Remove(0, 1) ' Removes the first character from the original message string
        Next
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles MessageBox.TextChanged
        FinalOutput.Text = "" ' Clears the output label whenever the input textbox is changed
    End Sub
End Class
