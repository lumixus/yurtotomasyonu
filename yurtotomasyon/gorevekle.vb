Public Class gorevekle
    Dim con As New Class1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.openCon()
        con.addGorevler(TextBox8.Text)
        con.closeCon()
    End Sub
End Class