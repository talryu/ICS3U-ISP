Public Class Form1
    Dim Unknownword As String
    Dim Word As String
    Dim Guesses As Integer = 0
    Dim Wrong As Integer
    Dim Wordguess As String

    Sub disablebuttons()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        Button10.Enabled = False
        Button11.Enabled = False
        Button12.Enabled = False
        Button13.Enabled = False
        Button14.Enabled = False
        Button15.Enabled = False
        Button16.Enabled = False
        Button17.Enabled = False
        Button18.Enabled = False
        Button19.Enabled = False
        Button20.Enabled = False
        Button21.Enabled = False
        Button22.Enabled = False
        Button23.Enabled = False
        Button24.Enabled = False
        Button25.Enabled = False
        Button26.Enabled = False
        Button27.Enabled = False
    End Sub
    Sub enablebutton()
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Button10.Enabled = True
        Button11.Enabled = True
        Button12.Enabled = True
        Button13.Enabled = True
        Button14.Enabled = True
        Button15.Enabled = True
        Button16.Enabled = True
        Button17.Enabled = True
        Button18.Enabled = True
        Button19.Enabled = True
        Button20.Enabled = True
        Button21.Enabled = True
        Button22.Enabled = True
        Button23.Enabled = True
        Button24.Enabled = True
        Button25.Enabled = True
        Button26.Enabled = True
        Button27.Enabled = True
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        guessletter(Button1.Text.ToLower)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.Enabled = False
        guessletter(Button2.Text.ToLower)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button3.Enabled = False
        guessletter(Button3.Text.ToLower)
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button4.Enabled = False
        guessletter(Button4.Text.ToLower)
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Button5.Enabled = False
        guessletter(Button5.Text.ToLower)
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Button6.Enabled = False
        guessletter(Button6.Text.ToLower)
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Button7.Enabled = False
        guessletter(Button7.Text.ToLower)
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Button8.Enabled = False
        guessletter(Button8.Text.ToLower)
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Button9.Enabled = False
        guessletter(Button9.Text.ToLower)
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Button10.Enabled = False
        guessletter(Button10.Text.ToLower)
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Button11.Enabled = False
        guessletter(Button11.Text.ToLower)
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Button12.Enabled = False
        guessletter(Button12.Text.ToLower)
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Button13.Enabled = False
        guessletter(Button13.Text.ToLower)
    End Sub
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Button14.Enabled = False
        guessletter(Button14.Text.ToLower)
    End Sub
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Button15.Enabled = False
        guessletter(Button15.Text.ToLower)
    End Sub
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Button16.Enabled = False
        guessletter(Button16.Text.ToLower)
    End Sub
    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Button17.Enabled = False
        guessletter(Button17.Text.ToLower)
    End Sub
    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Button18.Enabled = False
        guessletter(Button18.Text.ToLower)
    End Sub
    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Button19.Enabled = False
        guessletter(Button19.Text.ToLower)
    End Sub
    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Button20.Enabled = False
        guessletter(Button20.Text.ToLower)
    End Sub
    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Button21.Enabled = False
        guessletter(Button21.Text.ToLower)
    End Sub
    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Button22.Enabled = False
        guessletter(Button22.Text.ToLower)
    End Sub
    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Button23.Enabled = False
        guessletter(Button23.Text.ToLower)
    End Sub
    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        Button24.Enabled = False
        guessletter(Button24.Text.ToLower)
    End Sub
    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        Button25.Enabled = False
        guessletter(Button25.Text.ToLower)
    End Sub
    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        Button26.Enabled = False
        guessletter(Button26.Text.ToLower)
    End Sub
    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        Button27.Enabled = False
        guessletter(" ")
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Pic1.Visible = False
        Pic2.Visible = False
        Pic3.Visible = False
        Pic4.Visible = False
        Pic5.Visible = False
        Pic6.Visible = False
        Wrong = 0
        enablebutton()
        btnNew.Enabled = False
        Unknownword = InputBox("Enter your new word:").ToLower
        loadlabeldisplay()
        DisplayHangman(Wrong)
    End Sub
    Private Sub Form1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
       Pic1.Visible = False
        Pic2.Visible = False
        Pic3.Visible = False
        Pic4.Visible = False
        Pic5.Visible = False
        Pic6.Visible = False
    End Sub
   
    Sub loadlabeldisplay()
        lblNewword.Text = ""
        Dim lengthofword As Integer
        lengthofword = Unknownword.Length - 1
        Dim letterposition As Integer
        For letterposition = 0 To lengthofword
            lblNewword.Text = lblNewword.Text & "-"

        Next
    End Sub

    Sub guessletter(ByVal letterguess As String)
        Dim strguesssofar As String = lblNewword.Text
        Dim lengthofsecretword As Integer
        lengthofsecretword = Unknownword.Length - 1
        Word = ""
        Dim letterposition As Integer
        For letterposition = 0 To lengthofsecretword
            If Unknownword.Substring(letterposition, 1) = letterguess Then
                Word = Word & letterguess
            Else
                Word = Word & lblNewword.Text.Substring(letterposition, 1)
            End If
        Next
        lblNewword.Text = Word
        If lblNewword.Text = Unknownword Then
            disablebuttons()
            btnNew.Enabled = True
            MsgBox("You won!")
        End If
        If lblNewword.Text = strguesssofar Then
            Wrong = Wrong + 1
        End If
        DisplayHangman(Wrong)
    End Sub
    Sub DisplayHangman(ByVal numwrong)
        If numwrong = 1 Then
            Pic1.Visible = True

        End If
        If numwrong = 2 Then
            Pic2.Visible = True

        End If
        If numwrong = 3 Then
            Pic3.Visible = True

        End If
        If numwrong = 4 Then
            Pic4.Visible = True

        End If
        If numwrong = 5 Then
            Pic5.Visible = True

        End If
        If numwrong = 10 Then
            Pic6.Visible = True
            MsgBox("The correct answer is " & " " & Unknownword)
            disablebuttons()
            btnNew.Enabled = True
        End If
    End Sub
End Class
