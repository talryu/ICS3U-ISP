Public Class Form1
    Function Caesar_Cipher(ByVal text As String, ByVal X As Integer, ByVal encode As Boolean) 'X is how much user want to shift the word, text to classify encode or decode
        Dim Final As String = " "
        For Each c As Char In text
            Dim A As Integer
            If encode Then
                A = Asc(c) + X

            Else
                A = Asc(c) + 26 - X

            End If

            If Char.IsLower(c) Then    'Classifying the Capital letters
                If A > Asc("z") Then
                    A -= 26
                End If
                Final += Chr(A)
            ElseIf Char.IsUpper(c) Then
                If A > Asc("Z") Then
                    A -= 26
                End If
                Final += Chr(A)               'Getting the answer
            Else
                Final += c
            End If
        Next
        Return Final
    End Function

    Private Sub btnDecode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecode.Click
        lblAnswer.Text = Caesar_Cipher(txtEncode.Text, NumericUpDown1.Value, False) 'button to run the program( to shift the word to left)

    End Sub

    Private Sub btnEncode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncode.Click
        lblAnswer.Text = Caesar_Cipher(txtEncode.Text, NumericUpDown1.Value, True)
        'button to run the program( to shift the word to right)
    End Sub
End Class
'Algorithm: 
'First, I will get the word from user. Then, I will make the loop that can shift the words to how much the user wants E.G 2 letters shifting left or right. I will make sure if the user is using capital letter or lower case letter. Then I will show the user the value that my code got.


'Reflection:
'The challenges that I had is first I didn’t get the idea to shift the words. After I had the idea by searching up, I could not figure out the code for it. However, after getting advice from friend who took computer science course, I looked up in the internet and video to find code. Therefore, I was able to do the code as well. After that, I checked my code with friends so there is no mistake in it.
