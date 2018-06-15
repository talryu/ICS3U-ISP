Public Class Form1
    Function CaesarCipher(ByVal text As String, ByVal N As Integer, ByVal encrypt As Boolean)
        'text encrypt or decrypt, N as shift, “Boolean” distinguish encrypt or decrypt

        Dim result As String = " "  'result variable

        For Each c As Char In text 'loop on each character in the text
            Dim x As Integer
            If encrypt Then 'get the code
                x = Asc(c) + N
                'return a character code corresponding to the letter in the string

            Else
                x = Asc(c) + 26 - N
                'add the mod to the shift
            End If

            If Char.IsLower(c) Then 'decryption
                If x > Asc("z") Then 'check if x is greater than the code
                    x -= 26
                End If
                result += Chr(x) 'return the letter of the sent quote
            ElseIf Char.IsUpper(c) Then
                If x > Asc("Z") Then
                    x -= 26
                End If
                result += Chr(x) 'new letters
            Else
                result += c
            End If
        Next
        Return result
    End Function

    Private Sub btnDecrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecrypt.Click
        lblText.Text = CaesarCipher(txtencrypt.Text, NumericUpDown1.Value, False) 'decrypt function

    End Sub

    Private Sub btnEncrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncrypt.Click
        lblText.Text = CaesarCipher(txtencrypt.Text, NumericUpDown1.Value, True) 'encrypt function
    End Sub

End Class
