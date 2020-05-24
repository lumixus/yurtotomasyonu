Public Class gorevler
    Dim con As New Class1
    Dim isNull As Boolean
    Private Sub gorevler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.openCon()
        DataGridView1.DataSource = con.getGorevler()
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
            TextBox4.Text = DataGridView1.CurrentRow.Cells(1).Value
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.openCon()
        con.deleteVeri("gorevler", CStr(DataGridView1.CurrentRow.Cells(0).Value))
        Dim dtable As DataTable = con.getGorevler()
        dtable.Clear()
        DataGridView1.DataSource = dtable
        DataGridView1.DataSource = con.getGorevler()
        con.closeCon()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim burs As String
        Dim id, ad, soyad, tc, tel, mail, ogrturu, bolum, okul, odanumarasi, gunceldonem As String
        id = TextBox1.Text
        ad = TextBox4.Text
        con.openCon()
        'con.updateGorevler(id, ad)
        Dim dtable As DataTable = con.getOgrenciler()
        dtable.Clear()
        MsgBox(TextBox1.Text)
        DataGridView1.DataSource = dtable
        DataGridView1.DataSource = con.getOgrenciler()
        con.closeCon()
    End Sub
End Class