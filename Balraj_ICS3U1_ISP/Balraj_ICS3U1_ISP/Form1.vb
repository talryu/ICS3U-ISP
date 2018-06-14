Public Class Form1
    Dim revText, sentence, try1 As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim words, sentence As String

        Do
            words = InputBox("Enter each word seprately including period:") 'getting the seperate input from the user including the period 
            sentence = sentence & " " & words 'Accumuilating/concatenating users input in sentence 
            revText = StrReverse(sentence) 'Using StrReverse function in Visual Basic to reverse the string strored in sentence
            
        Loop Until words = "." 'Using period to stop looping through and asking for input from user.

    End Sub

    Private Sub btnReverse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReverse.Click

        lblReverse.Text = revText 'Assigned revText to label to output on the display
    End Sub
End Class
