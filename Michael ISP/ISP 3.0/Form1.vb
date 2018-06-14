Public Class Form1
    Dim message As String = InputBox("Enter Message")
    Dim firstVal As Integer ' This variable will be used to contain the first value of the conversion process
    Dim secondVal As String ' This variable will be used to contain the second value of the conversion process
    Dim reversedMessage As String
    Dim count As Integer 'used to determine if letter is odd or even in decryption, and used to determine when to skip to the next line for encryption
    Dim secretMessage As String
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Label1.Text = ""
        For i As Integer = 0 To message.Length - 1
            If i Mod 2 = 0 Then ' checks if the letter is even
                firstVal = AscW(message.Chars(i)) ' converts letter to unicode
                firstVal = Convert.ToString(firstVal, 2) ' converts unicode to binary
                If count > 15 Then 'determines if 20 words have been added, if so skips to the next line
                    Label1.Text += " " & firstVal & vbCrLf 'updates the label with the next value. A space is put between each letter in a word.
                    count = 0
                Else : Label1.Text += " " & firstVal 'updates the label with the next value. A space is put between each letter in a word.
                    count += 1
                End If
            ElseIf i Mod 2 <> 0 Then ' checks if the letter is odd 
                firstVal = AscW(message.Chars(i)) 'converts letter to unicode
                secondVal = Convert.ToString(firstVal, 16) ' converts unicode to hexadecimal 
                If count > 15 Then 'determines if 20 words have been added, if so skips to the next line
                    Label1.Text += " " & secondVal & vbCrLf 'updates the label with the next value. A space is put between each letter in a word.
                    count = 0
                Else : Label1.Text += " " & secondVal 'updates the label with the next value. A space is put between each letter in a word.
                    count += 1
                End If
            End If
        Next
        secretMessage = Label1.Text
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        count = 0
        Dim newMessage As String = secretMessage.Trim
        newMessage += " " 'adds a space to the end of the message to make sure that the last letter is decrypted
        Dim binaryConvert As String 'will hold the binary value
        Dim spaceIndex As Integer
        Dim hexConvert As String 'will hold hexadecimal value
        Dim originalNumber As Integer 'will hold the original unicode value
        Dim nextLetter As String 'will hold the original letter
        Label1.Text = Nothing
        For i As Integer = 0 To newMessage.Length - 1
            If count = message.Length Then
                Exit For
            End If
            If newMessage.Chars(i) = " " Then 'locates a space, all spaces represent the end of 1 letter
                If count Mod 2 = 0 And newMessage.Chars(i - 1) <> vbCrLf Then 'checks if the letter is even
                    binaryConvert = newMessage.Substring(spaceIndex, 8) 'determines when the binary string ends by creating a substring starting from the index of the space and going to 8, since all binary values have length of 7.
                    binaryConvert = binaryConvert.Trim 'deletes any extra spaces to avoid errors in conversion
                    originalNumber = Convert.ToInt32(binaryConvert, 2) 'converts binary back to unicode
                    nextLetter = ChrW(originalNumber) 'converts unicode back to original letter
                    Label1.Text += nextLetter
                ElseIf count Mod 2 <> 0 And newMessage.Chars(i - 1) <> vbCrLf Then 'checks if the letter is odd
                    hexConvert = newMessage.Substring(spaceIndex + 1, 3) 'determines when the hexadecimal string ends by creating a substring starting from the index of the space and going to 3, since all binary values have length of 2.
                    hexConvert = hexConvert.Trim 'deletes any extra spaces to avoid errors in conversion
                    originalNumber = (Convert.ToInt32(hexConvert, 16)) 'converts hexadecimal back to unicode
                    nextLetter = ChrW(originalNumber) 'converts unicode back to original letter
                    Label1.Text += nextLetter
                Else
                    Continue For
                End If
                count += 1
                spaceIndex = i
            End If
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

    End Sub
End Class
