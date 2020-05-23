Public Class gorevler
    Dim con As New Class1
    Dim isNull As Boolean
    Private Sub gorevler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.openCon()
        DataGridView1.DataSource = con.getGorevler()
        con.closeCon()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        For i = 0 To DataGridView1.Columns.Count
            If IsDBNull(DataGridView1.CurrentRow.Cells(i).Value) Then
                isNull = True
            Else
                isNull = False
            End If
            i = i + 1
        Next
        If isNull Then
            MessageBox.Show("Dolu olan bir satır seçilmelidir !")
        Else
            TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
            TextBox4.Text = DataGridView1.CurrentRow.Cells(1).Value
        End If


    End Sub
End Class