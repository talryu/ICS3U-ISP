Public Class Form1

    Private Sub btnCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCode.Click
        Dim input As String
        Dim answer As String
        input = Me.txtEnter.Text 'get name from user
        answer = StrReverse(input)
        Me.lblAnswer.Text = answer
    End Sub

    Private Sub btnDecode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDecode.Click
        Dim input As String
        Dim answer As String
        input = Me.txtRevised.Text 'get coded name from user
        answer = StrReverse(input)
        Me.lblAnswer.Text = answer
    End Sub
End Class
