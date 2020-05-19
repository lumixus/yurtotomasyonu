Public Class personeller
    Dim con As New Class1

    Private Sub personeller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.openCon()
        DataGridView1.DataSource = con.getPersoneller()
        con.closeCon()
    End Sub
End Class