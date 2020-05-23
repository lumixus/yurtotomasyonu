Public Class Ogrenciler
    Dim con As New Class1
    Dim isNull As Boolean
    Private Sub ogrenciler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.openCon()
        DataGridView1.DataSource = con.getOgrenciler()
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
End Class