Public Class odemeler
    Dim con As New Class1
    Dim isNull As Boolean
    Private Sub odemeler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.openCon()
        DataGridView1.DataSource = con.getOdemeler()
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
            TextBox1.Text = CStr(DataGridView1.CurrentRow.Cells(0).Value)
            TextBox2.Text = CStr(DataGridView1.CurrentRow.Cells(1).Value)
            TextBox3.Text = CStr(DataGridView1.CurrentRow.Cells(4).Value)
            TextBox4.Text = CStr(DataGridView1.CurrentRow.Cells(3).Value)
            TextBox5.Text = CStr(DataGridView1.CurrentRow.Cells(5).Value)
            DateTimePicker2.Value = CStr(DataGridView1.CurrentRow.Cells(2).Value)

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim id, ad, odmik, odcekmik, kalmik As String
        Dim tarih As DateTime
        DataGridView1.CurrentRow.Cells(0).Value = TextBox1.Text
        DataGridView1.CurrentRow.Cells(1).Value = TextBox2.Text
        DataGridView1.CurrentRow.Cells(3).Value = TextBox4.Text
        DataGridView1.CurrentRow.Cells(5).Value = TextBox5.Text
        DataGridView1.CurrentRow.Cells(4).Value = TextBox3.Text
        DataGridView1.CurrentRow.Cells(2).Value = DateTimePicker2.Value
        id = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        ad = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        odmik = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        odcekmik = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        kalmik = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        tarih = Convert.ToDateTime(DataGridView1.CurrentRow.Cells(2).Value.ToString())
        con.openCon()
        con.updateOdemeler(id, ad, tarih, odmik, odcekmik, kalmik)
        Dim dtable As DataTable = con.getOdemeler()
        dtable.Clear()
        DataGridView1.DataSource = dtable
        DataGridView1.DataSource = con.getOdemeler()
        con.closeCon()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.openCon()
        con.deleteVeri("sonodemeler", CStr(DataGridView1.CurrentRow.Cells(0).Value))
        Dim dtable As DataTable = con.getOdalar()
        dtable.Clear()
        DataGridView1.DataSource = dtable
        DataGridView1.DataSource = con.getOdemeler()
        con.closeCon()
    End Sub
End Class