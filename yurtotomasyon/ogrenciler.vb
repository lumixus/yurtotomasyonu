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
            Button2.Enabled = True
            TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
            TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
            TextBox3.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
            TextBox4.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
            TextBox5.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
            TextBox6.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
            TextBox7.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
            TextBox8.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
            If DataGridView1.CurrentRow.Cells(12).Value.ToString() = "%25 Burs" Then
                RadioButton1.Checked = True
            ElseIf DataGridView1.CurrentRow.Cells(12).Value.ToString() = "%50 Burs" Then
                RadioButton2.Checked = True
            ElseIf DataGridView1.CurrentRow.Cells(12).Value.ToString() = "%75 Burs" Then
                RadioButton3.Checked = True
            ElseIf DataGridView1.CurrentRow.Cells(12).Value.ToString() = "%100 Burs" Then
                RadioButton4.Checked = True
            Else
                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
            End If
            TextBox9.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString()
            DateTimePicker1.Value = DataGridView1.CurrentRow.Cells(13).Value.ToString()
            DateTimePicker2.Value = DataGridView1.CurrentRow.Cells(14).Value.ToString()
            CheckBox1.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString()
            ComboBox1.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString()
            ComboBox2.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString()


        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim burs As String
        Dim id, ad, soyad, tc, tel, mail, ogrturu, bolum, okul, odanumarasi, gunceldonem As String
        Dim test As Boolean
        Dim tarih As DateTime
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
        DataGridView1.CurrentRow.Cells(0).Value = TextBox1.Text
        DataGridView1.CurrentRow.Cells(1).Value = TextBox2.Text
        DataGridView1.CurrentRow.Cells(2).Value = TextBox4.Text
        DataGridView1.CurrentRow.Cells(3).Value = TextBox5.Text
        DataGridView1.CurrentRow.Cells(4).Value = TextBox3.Text
        DataGridView1.CurrentRow.Cells(5).Value = TextBox6.Text
        DataGridView1.CurrentRow.Cells(6).Value = TextBox7.Text
        DataGridView1.CurrentRow.Cells(7).Value = TextBox8.Text
        DataGridView1.CurrentRow.Cells(8).Value = ComboBox1.Text
        DataGridView1.CurrentRow.Cells(9).Value = ComboBox2.Text
        DataGridView1.CurrentRow.Cells(10).Value = TextBox9.Text
        DataGridView1.CurrentRow.Cells(11).Value = CheckBox1.Checked
        DataGridView1.CurrentRow.Cells(12).Value = burs
        DataGridView1.CurrentRow.Cells(13).Value = DateTimePicker1.Value
        id = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        ad = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        soyad = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        tc = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        tel = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        mail = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        ogrturu = DataGridView1.CurrentRow.Cells(8).Value.ToString()
        bolum = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        okul = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        odanumarasi = DataGridView1.CurrentRow.Cells(9).Value.ToString()
        gunceldonem = DataGridView1.CurrentRow.Cells(10).Value.ToString()
        test = DataGridView1.CurrentRow.Cells(11).Value.ToString()
        tarih = Convert.ToDateTime(DataGridView1.CurrentRow.Cells(13).Value.ToString())
        con.openCon()
        con.updateOgrenci(id, ad, soyad, tc, tel, mail, bolum, okul, ogrturu, odanumarasi, gunceldonem, test, DataGridView1.CurrentRow.Cells(12).Value.ToString(), tarih)
        Dim dtable As DataTable = con.getOgrenciler()
        dtable.Clear()
        DataGridView1.DataSource = dtable
        DataGridView1.DataSource = con.getOgrenciler()
        con.closeCon()

    End Sub


    Private Sub Ogrenciler_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        con.openCon()
        DataGridView1.DataSource = con.getOgrenciler()
        con.closeCon()
        Button2.Enabled = False
    End Sub

    Private Sub ComboBox2_DropDown(sender As Object, e As EventArgs) Handles ComboBox2.DropDown

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