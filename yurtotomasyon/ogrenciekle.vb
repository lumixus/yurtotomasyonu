﻿Public Class ogrenciekle
    Dim con As New Class1
    Dim isAdded As Boolean = False
    Private Sub ogrenciekle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim burs As String
        DateTimePicker1.Value = DateTime.Today
        If RadioButton4.Checked Then
            burs = RadioButton4.Text
        ElseIf RadioButton3.checked Then
            burs = RadioButton3.Text
        ElseIf RadioButton6.checked Then
            burs = RadioButton6.Text
        ElseIf RadioButton5.checked Then
            burs = RadioButton5.Text
        Else
            burs = "Burs Yok"
        End If
        Dim ogtur As String
        If RadioButton1.Checked Then
            ogtur = "1"
        Else
            ogtur = "2"
        End If
        con.openCon()
        con.addOgrenci(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, ogtur, ComboBox1.Text, TextBox10.Text, burs, DateTimePicker1.Value)
        Form1.Label13.Text = con.getLastStudentName() + " " + con.getLastStudentSurname() + " - " + con.getLastStudentID()
        con.closeCon()
        Form1.Label15.Text = giris.TextBox1.Text
    End Sub

    Private Sub ComboBox1_DropDown(sender As Object, e As EventArgs) Handles ComboBox1.DropDown

        If isAdded = False Then
            ComboBox1.Items.Clear()
        ComboBox1.ResetText()
        con.openCon()
        For Each row As DataRow In con.getBosOdalar().Rows
            ComboBox1.Items.Add(row.Item("odanumarasi"))
        Next row
        con.closeCon()
            isAdded = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox10.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        ' RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        DateTimePicker1.Value = Now.ToString()
        ComboBox1.Text = ""

    End Sub
End Class