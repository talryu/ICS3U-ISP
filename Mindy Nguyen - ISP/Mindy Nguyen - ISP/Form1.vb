Public Class Form1

    Private Sub btnCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCode.Click
        Dim input As String
        Dim answer As String
        'reverses your message (makes it backwards)

        input = Me.txtEnter.Text 'get message from user
        answer = StrReverse(input)
        Me.lblResult.Text = answer
    End Sub

    Private Sub btnDecode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDecode.Click
        Dim input As String
        Dim answer As String
        'takes input reversed and makes it the right way

        input = Me.txtRevised.Text 'get reversed message from user
        answer = StrReverse(input)
        Me.lblResult.Text = answer
    End Sub
End Class

