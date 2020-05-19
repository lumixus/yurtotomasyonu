Public Class ogrenciler
    Dim con As New Class1
    Private Sub ogrenciler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.openCon()
        DataGridView1.DataSource = con.getOgrenciler()
        con.closeCon()
    End Sub
End Class