Public Class Form1
    Private Sub giris_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case MessageBox.Show("Çıkmak istediğinize emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case Windows.Forms.DialogResult.Yes
                giris.Close()
            Case Windows.Forms.DialogResult.No
                e.Cancel = True
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(70, Panel1.BackColor.R, Panel1.BackColor.G, Panel1.BackColor.B)
        Panel2.BackColor = Color.FromArgb(70, Panel1.BackColor.R, Panel1.BackColor.G, Panel1.BackColor.B)
        Panel3.BackColor = Color.FromArgb(70, Panel1.BackColor.R, Panel1.BackColor.G, Panel1.BackColor.B)
        Panel4.BackColor = Color.FromArgb(70, Panel1.BackColor.R, Panel1.BackColor.G, Panel1.BackColor.B)
        Panel5.BackColor = Color.FromArgb(70, Panel1.BackColor.R, Panel1.BackColor.G, Panel1.BackColor.B)

        Me.Chart1.Series("Series1").Points.AddXY("Dolu Oda", 80)
        Me.Chart1.Series("Series1").Points.AddXY("Boş Oda", 40)
        Me.Chart2.Series("Series1").Points.AddXY("Dolu Oda", 40)
        Me.Chart2.Series("Series1").Points.AddXY("Boş Oda", 80)

    End Sub

    Private Sub ÖğrenciEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÖğrenciEkleToolStripMenuItem.Click
        ogrenciekle.Show()
    End Sub
End Class