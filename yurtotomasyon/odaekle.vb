Public Class odaekle
    Dim con As New Class1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.openCon()
        con.addOda(TextBox1.Text, TextBox3.Text)
        con.closeCon()
    End Sub
End Class