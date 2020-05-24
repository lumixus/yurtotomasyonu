Public Class personelekle
    Dim con As New Class1
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
End Class