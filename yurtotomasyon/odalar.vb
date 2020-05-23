Public Class Odalar
    Dim con As New Class1
    Private Sub Odalar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.openCon()
        DataGridView1.DataSource = con.getOdalar()
        con.closeCon()
    End Sub
End Class