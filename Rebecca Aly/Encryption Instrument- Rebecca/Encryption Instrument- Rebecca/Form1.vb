Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnEn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnEn.Click
        Dim input As String 'define input string variable
        Dim answer As String 'define answer string variable
        input = Me.TxtIn.Text 'read input from user
        answer = StrReverse(input) 'reverse input (reverse words and their order)
        Me.Lblanswer.Text = answer 'display encoded string



    End Sub

    Private Sub btnDe_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles btnDe.Enter
        Dim input As String 'define input string variable
        Dim answer As String 'define answer string variable
        input = Me.txtIn2.Text 'read input from user
        answer = StrReverse(input) 'reverse input (reverse words and their order)
        Me.Lblanswer.Text = answer 'display encoded string

    End Sub
End Class
