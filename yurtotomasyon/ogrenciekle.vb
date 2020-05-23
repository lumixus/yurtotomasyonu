Public Class ogrenciekle
    Dim con As New Class1
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
        con.addOgrenci(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, ogtur, ComboBox1.Text, TextBox10.Text, CheckBox1.Checked, burs, DateTimePicker1.Value)
        con.closeCon()
    End Sub
End Class