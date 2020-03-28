Public Class giris
    Dim kadi As String
    Dim sifre As String
    Dim anaform As Form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kadi = "admin"
        sifre = "Emir123"
        If TextBox1.Text = kadi And TextBox2.Text = sifre Then
            MsgBox("Doğru girdiniz")
            anaform = Form1
            anaform.Show()
            Hide()
        Else
            MsgBox("Hatalı")
        End If

    End Sub
End Class
