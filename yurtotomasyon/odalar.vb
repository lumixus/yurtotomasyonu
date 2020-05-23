Public Class Odalar
    Dim con As New Class1
    Dim isNull As Boolean
    Private Sub Odalar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.openCon()
        DataGridView1.DataSource = con.getOdalar()
        con.closeCon()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        For i As Integer = 0 To DataGridView1.Columns.Count - 1
            If IsDBNull(DataGridView1.CurrentRow.Cells(i).Value) Then
                isNull = True
                Exit For
            Else
                isNull = False
            End If

        Next
        If isNull Then
            MessageBox.Show("Dolu olan bir satır seçilmelidir !")
        Else
            TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
            TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value
            TextBox4.Text = DataGridView1.CurrentRow.Cells(2).Value
            TextBox5.Text = DataGridView1.CurrentRow.Cells(3).Value
        End If
    End Sub
End Class