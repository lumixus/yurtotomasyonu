Public Class ayarlar
    Dim con As New Class1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.openCon()
        con.updateSettings(CInt(TextBox1.Text))
        con.closeCon()

    End Sub
End Class