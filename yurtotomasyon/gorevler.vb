﻿Public Class gorevler
    Dim con As New Class1
    Private Sub gorevler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.openCon()
        DataGridView1.DataSource = con.getGorevler()
        con.closeCon()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If IsDBNull(DataGridView1.CurrentRow.Cells(0).Value) Then
            MessageBox.Show("Dolu olan bir satır seçilmelidir !")
        Else
            TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
            TextBox4.Text = DataGridView1.CurrentRow.Cells(1).Value
        End If


    End Sub
End Class