Imports Microsoft.VisualBasic
Imports System.Data.OleDb

Public Class Class1
    Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='yurtotomasyonu.mdb'")
    Dim command As New OleDbCommand()
    Dim adapter As New OleDbDataAdapter
    Dim data As OleDbDataReader


    Public Sub openCon()
        baglanti.Open()
    End Sub

    Public Sub closeCon()
        baglanti.Close()
    End Sub
    Public Function userControl(username As String, password As String) As Boolean

        command.CommandText = "SELECT count(*) FROM yoneticiler WHERE kullaniciadi = '" + username + "' and sifresi='" + password + "'"
        command.Connection = baglanti
        adapter.SelectCommand = command
        Dim sonuc As String = CStr(command.ExecuteScalar())

        If sonuc = "1" Then
            Return True
        Else
            Return False
            End If
            Return False

    End Function



    Public Sub updateSettings(toplamoda As Integer)
        command.CommandText = "UPDATE ayarlar SET toplamoda= @toplamoda WHERE id=1"
        command.Connection = baglanti
        command.Parameters.AddWithValue("@toplamoda", toplamoda)
        command.ExecuteNonQuery()
        MessageBox.Show("Ayarlar Güncellendi")
    End Sub


    Public Function getFullRooms() As String
        command.CommandText = "SELECT count(*) FROM odalar WHERE guncelogrencisayisi=yataksayisi"
        command.Connection = baglanti
        adapter.SelectCommand = command
        Dim sonuc As String = CStr(command.ExecuteScalar())
        Return sonuc
    End Function


    Public Function getEmptyRooms() As String
        command.CommandText = "SELECT count(*) FROM odalar WHERE guncelogrencisayisi<>yataksayisi"
        command.Connection = baglanti
        adapter.SelectCommand = command
        Dim sonuc As String = CStr(command.ExecuteScalar())
        Return sonuc
    End Function
End Class
