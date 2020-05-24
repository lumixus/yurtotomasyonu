Public Class Odalar
    Dim con As New Class1
    Dim isNull As Boolean

    Private Sub Odalar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.openCon()
        DataGridView1.DataSource = con.getOdalar()
        con.closeCon()
        Button2.Enabled = False
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
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.openCon()
        con.deleteVeri("odalar", CStr(DataGridView1.CurrentRow.Cells(0).Value))
        Dim dtable As DataTable = con.getOdalar()
        dtable.Clear()
        DataGridView1.DataSource = dtable
        DataGridView1.DataSource = con.getOdalar()
        con.closeCon()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim id, odan, gosay, yatsay As String

        DataGridView1.CurrentRow.Cells(0).Value = TextBox1.Text
        DataGridView1.CurrentRow.Cells(1).Value = TextBox2.Text
        DataGridView1.CurrentRow.Cells(2).Value = TextBox4.Text
        DataGridView1.CurrentRow.Cells(3).Value = TextBox5.Text
        id = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        odan = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        gosay = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        yatsay = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        con.openCon()
        con.updateOdalar(id, odan, gosay, yatsay)
        Dim dtable As DataTable = con.getOdalar()
        dtable.Clear()
        DataGridView1.DataSource = dtable
        DataGridView1.DataSource = con.getOdalar()
        con.closeCon()
    End Sub
End Class