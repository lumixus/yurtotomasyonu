Public Class odemeler
    Dim con As New Class1
    Private Sub odemeler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.openCon()
        DataGridView1.DataSource = con.getOdemeler()
        con.closeCon()
    End Sub
End Class