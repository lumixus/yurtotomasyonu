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
        'con.addPersonel(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, cinsiyet)
        con.closeCon()
    End Sub
End Class