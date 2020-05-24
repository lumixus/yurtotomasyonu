Public Class personelekle
    Dim con As New Class1
    Dim isAdded As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cinsiyet As String
        If RadioButton1.Checked Then
            cinsiyet = RadioButton1.Text
        Else
            cinsiyet = RadioButton2.Text
        End If
        con.openCon()
        con.addPersonel(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, ComboBox1.Text, TextBox6.Text, cinsiyet)
        con.closeCon()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox6.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        ComboBox1.Text = ""



    End Sub

    Private Sub ComboBox1_DropDown(sender As Object, e As EventArgs) Handles ComboBox1.DropDown
        If isAdded = False Then
            ComboBox1.Items.Clear()
            ComboBox1.ResetText()
            con.openCon()
            For Each row As DataRow In con.getGorevler().Rows
                ComboBox1.Items.Add(row.Item("gorevad"))
            Next row
            con.closeCon()
            isAdded = True
        End If
    End Sub
End Class