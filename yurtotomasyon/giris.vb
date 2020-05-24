


Public Class giris
    Dim kadi As String
    Dim sifre As String
    Dim anaform As Form
    Dim con As New Class1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim username, password As String
        username = TextBox1.Text
        password = TextBox2.Text
        con.openCon()

        If con.userControl(username, password) = True Then

            anaform = Form1
            anaform.Show()
            Form1.Label15.Text = TextBox1.Text
            Hide()
            con.closeCon()

        Else
            MsgBox("Hatalı")
            con.closeCon()

        End If

    End Sub
End Class
