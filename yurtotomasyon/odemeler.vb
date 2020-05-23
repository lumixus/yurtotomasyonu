Public Class odemeler
    Dim con As New Class1
    Private Sub odemeler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.openCon()
        DataGridView1.DataSource = con.getOdemeler()
        con.closeCon()
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If IsDBNull(DataGridView1.CurrentRow.Cells(0).Value) Then
            MessageBox.Show("Dolu olan bir satır seçilmelidir.")
        Else
            TextBox1.Text = CStr(DataGridView1.CurrentRow.Cells(0).Value)
            TextBox2.Text = CStr(DataGridView1.CurrentRow.Cells(1).Value)
            TextBox3.Text = CStr(DataGridView1.CurrentRow.Cells(4).Value)
            TextBox4.Text = CStr(DataGridView1.CurrentRow.Cells(3).Value)
            TextBox5.Text = CStr(DataGridView1.CurrentRow.Cells(5).Value)
            DateTimePicker2.Value = CStr(DataGridView1.CurrentRow.Cells(2).Value)

        End If


    End Sub
End Class