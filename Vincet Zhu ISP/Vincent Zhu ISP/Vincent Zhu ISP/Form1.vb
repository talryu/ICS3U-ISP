Public Class Form1

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click

        Dim text, combine, reverse As String

        Do
            text = InputBox("Enter Text(. to stop)", "Reversing Words") 'encrypt is the user input
            combine = combine & " " & text 'combining the new text with the old text
            reverse = StrReverse(combine) 'reversing the text and the order of the text
            lblDecrypt.Text = reverse 'showing the reversed text with reversed order
        Loop Until text = "|"
        ' preventing a infinite loop with a stop | to the loop
    End Sub
End Class
