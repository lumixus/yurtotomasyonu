﻿Public Class gorevler
    Dim con As New Class1
    Private Sub gorevler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.openCon()
        DataGridView1.DataSource = con.getGorevler()
        con.closeCon()
    End Sub
End Class