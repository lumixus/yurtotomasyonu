Public Class personeller
    Dim con As New Class1
    Dim isNull As Boolean
    Private Sub personeller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.openCon()
        DataGridView1.DataSource = con.getPersoneller()
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
            TextBox6.Text = DataGridView1.CurrentRow.Cells(5).Value
            TextBox7.Text = DataGridView1.CurrentRow.Cells(7).Value
            TextBox8.Text = DataGridView1.CurrentRow.Cells(6).Value
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Dim cinsiyet As String
        Dim id, ad, soyad, tc, telno, gorevid, mail As String
        DataGridView1.CurrentRow.Cells(0).Value = TextBox1.Text
        DataGridView1.CurrentRow.Cells(1).Value = TextBox2.Text
        DataGridView1.CurrentRow.Cells(2).Value = TextBox4.Text
        DataGridView1.CurrentRow.Cells(3).Value = TextBox5.Text
        DataGridView1.CurrentRow.Cells(4).Value = TextBox6.Text
        DataGridView1.CurrentRow.Cells(5).Value = TextBox7.Text
        DataGridView1.CurrentRow.Cells(7).Value = TextBox8.Text


        id = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        ad = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        soyad = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        tc = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        telno = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        gorevid = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        mail = DataGridView1.CurrentRow.Cells(7).Value.ToString()

        con.openCon()
        con.updatepersoneller(id, ad, soyad, tc, telno, gorevid, mail)
        Dim dtable As DataTable = con.getPersoneller()
        dtable.Clear()
        DataGridView1.DataSource = dtable
        DataGridView1.DataSource = con.getPersoneller()
        con.closeCon()



    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        con.openCon()
        con.deleteVeri("personeller", CStr(DataGridView1.CurrentRow.Cells(0).Value))
        Dim dtable As DataTable = con.getPersoneller()
        dtable.Clear()
        DataGridView1.DataSource = dtable
        DataGridView1.DataSource = con.getPersoneller()
        con.closeCon()
    End Sub
End Class