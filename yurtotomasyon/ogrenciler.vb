Public Class Ogrenciler
    Dim con As New Class1
    Dim isNull As Boolean
    Dim isAdded As Boolean = False

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
            MsgBox("BURADA")
            Button2.Enabled = True
            TextBox1.Text = CStr(DataGridView1.CurrentRow.Cells(0).Value)
            TextBox2.Text = CStr(DataGridView1.CurrentRow.Cells(1).Value)
            TextBox3.Text = CStr(DataGridView1.CurrentRow.Cells(4).Value)
            TextBox4.Text = CStr(DataGridView1.CurrentRow.Cells(2).Value)
            TextBox5.Text = CStr(DataGridView1.CurrentRow.Cells(3).Value)
            TextBox6.Text = CStr(DataGridView1.CurrentRow.Cells(5).Value)
            TextBox7.Text = CStr(DataGridView1.CurrentRow.Cells(6).Value)
            TextBox8.Text = CStr(DataGridView1.CurrentRow.Cells(7).Value)
            If CStr(DataGridView1.CurrentRow.Cells(12).Value) = "%25 Burs" Then
                RadioButton1.Checked = True
            ElseIf CStr(DataGridView1.CurrentRow.Cells(12).Value) = "%50 Burs" Then
                RadioButton2.Checked = True
            ElseIf CStr(DataGridView1.CurrentRow.Cells(12).Value) = "%75 Burs" Then
                RadioButton3.Checked = True
            ElseIf CStr(DataGridView1.CurrentRow.Cells(12).Value) = "%100 Burs" Then
                RadioButton4.Checked = True
            Else
                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
            End If
        TextBox9.Text = CStr(DataGridView1.CurrentRow.Cells(10).Value)
                DateTimePicker1.Value = CStr(DataGridView1.CurrentRow.Cells(13).Value)
                DateTimePicker2.Value = CStr(DataGridView1.CurrentRow.Cells(14).Value)
                CheckBox1.Text = CStr(DataGridView1.CurrentRow.Cells(11).Value)
                ComboBox1.Text = CStr(DataGridView1.CurrentRow.Cells(8).Value)
                ComboBox2.Text = CStr(DataGridView1.CurrentRow.Cells(9).Value)


            End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim burs As String
        Dim id, ad, soyad, tc, tel, mail, ogrturu, bolum, okul, odanumarasi, gunceldonem As String
        id = TextBox1.Text
        ad = TextBox2.Text
        soyad = TextBox4.Text
        tc = TextBox5.Text
        tel = TextBox3.Text
        mail = TextBox6.Text
        bolum = TextBox7.Text
        okul = TextBox8.Text
        ogrturu = ComboBox1.Text
        odanumarasi = ComboBox2.Text
        gunceldonem = TextBox9.Text
        If RadioButton1.Checked Then
            burs = RadioButton1.Text
        ElseIf RadioButton3.Checked Then
            burs = RadioButton3.Text
        ElseIf RadioButton2.Checked Then
            burs = RadioButton2.Text
        ElseIf RadioButton4.Checked Then
            burs = RadioButton4.Text
        Else
            burs = "Burs Yok"
        End If
        con.openCon()
        con.updateOgrenci(id, ad, soyad, tc, tel, mail, bolum, okul, ogrturu, odanumarasi, gunceldonem, CheckBox1.Checked, burs, DateTimePicker1.Value)
        Dim dtable As DataTable = con.getOgrenciler()
        dtable.Clear()
        MsgBox(TextBox1.Text)
        DataGridView1.DataSource = dtable
        DataGridView1.DataSource = con.getOgrenciler()
        con.closeCon()

    End Sub

    Private Sub ComboBox1_DropDown(sender As Object, e As EventArgs) Handles ComboBox1.DropDown
        If isAdded = False Then
            ComboBox2.Items.Clear()
            ComboBox2.ResetText()
            con.openCon()
            For Each row As DataRow In con.getBosOdalar().Rows
                ComboBox2.Items.Add(row.Item("odanumarasi"))
            Next row
            con.closeCon()
            isAdded = True
        End If
    End Sub

    Private Sub Ogrenciler_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        con.openCon()
        DataGridView1.DataSource = con.getOgrenciler()
        con.closeCon()
        Button2.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.openCon()
        con.deleteVeri("ogrenciler", CStr(DataGridView1.CurrentRow.Cells(0).Value))
        Dim dtable As DataTable = con.getOgrenciler()
        dtable.Clear()
        DataGridView1.DataSource = dtable
        DataGridView1.DataSource = con.getOgrenciler()
        con.closeCon()
    End Sub
End Class