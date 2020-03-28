Public Class Form1
    Private Sub giris_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case MessageBox.Show("Çıkmak istediğinize emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case Windows.Forms.DialogResult.Yes
                giris.Close()
            Case Windows.Forms.DialogResult.No
                e.Cancel = True
        End Select
    End Sub
End Class