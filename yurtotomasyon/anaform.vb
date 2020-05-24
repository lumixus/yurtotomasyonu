﻿Public Class Form1
    Dim con As New Class1
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
        con.openCon()
        Label8.Text = con.getEmptyRooms()
        Label6.Text = con.getStaffCount()
        Label3.Text = con.getStudentCount()
        Label12.Text = con.getRoomCount()
        Label5.Text = con.getBedCount()
        Me.Chart1.Series("Series1").Points.AddXY("Dolu Oda", CInt(con.getFullRooms()))
        Me.Chart1.Series("Series1").Points.AddXY("Boş Oda", CInt(con.getEmptyRooms()))
        Me.Chart2.Series("Series1").Points.AddXY("Öğrenci Sayısı", con.getStudentCount())
        Me.Chart2.Series("Series1").Points.AddXY("Maksimum Öğrenci", CInt(con.getMaxStudent))
        Label13.Text = con.getLastStudentName() + " " + con.getLastStudentSurname() + " - " + con.getLastStudentID()
        Label15.Text = giris.TextBox1.Text()
        Label18.Text = Date.Now.ToString()
        con.closeCon()


    End Sub

    Private Sub ÖğrenciEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÖğrenciEkleToolStripMenuItem.Click
        ogrenciekle.Show()
    End Sub

    Private Sub AyarlarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyarlarToolStripMenuItem.Click
        ayarlar.Show()

    End Sub

    Private Sub ÖğrencilerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÖğrencilerToolStripMenuItem.Click
        Ogrenciler.Show()
    End Sub

    Private Sub PersonellerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonellerToolStripMenuItem.Click
        personeller.Show()
    End Sub

    Private Sub ÖdemelerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÖdemelerToolStripMenuItem.Click
        odemeler.Show()
    End Sub

    Private Sub GörevlerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GörevlerToolStripMenuItem.Click
        gorevler.Show()
    End Sub

    Private Sub PersonelEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonelEkleToolStripMenuItem.Click
        personelekle.Show()
    End Sub

    Private Sub OdalarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OdalarToolStripMenuItem.Click
        Odalar.Show()
    End Sub

    Private Sub GörevEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GörevEkleToolStripMenuItem.Click
        gorevekle.Show()
    End Sub

    Private Sub OdaEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OdaEkleToolStripMenuItem.Click
        odaekle.Show()
    End Sub

    Private Sub ÇıkışlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÇıkışlToolStripMenuItem.Click
        giris.Show()
        Me.Hide()
        ogrenciekle.Close()
        Ogrenciler.Close()
        gorevler.Close()
        gorevekle.Close()
        personelekle.Close()
        personeller.Close()
        Odalar.Close()
        odaekle.Close()
        odemeler.Close()
        ayarlar.Close()

    End Sub
End Class