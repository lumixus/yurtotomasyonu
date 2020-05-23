Imports Microsoft.VisualBasic
Imports System.Data.OleDb

Public Class Class1
    Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='yurtotomasyonu.mdb'")
    Dim command As New OleDbCommand()
    Dim adapter As New OleDbDataAdapter
    Dim table As New DataTable
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



    Public Sub updateSettings(toplamoda As Integer, maxogrenci As Integer)
        command.CommandText = "UPDATE ayarlar SET toplamoda= @toplamoda , maxogrenci = @maxogrenci WHERE id=1"
        command.Connection = baglanti
        command.Parameters.AddWithValue("@toplamoda", toplamoda)
        command.Parameters.AddWithValue("@maxogrenci", maxogrenci)
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
    Public Function getStaffCount() As String
        command.CommandText = "Select count(*) from personeller"
        command.Connection = baglanti
        adapter.SelectCommand = command
        Dim sonuc As String = CStr(command.ExecuteScalar())
        Return sonuc
    End Function
    Public Function getStudentCount() As String
        command.CommandText = "Select count(*) from ogrenciler"
        command.Connection = baglanti
        adapter.SelectCommand = command
        Dim sonuc As String = CStr(command.ExecuteScalar())
        Return sonuc
    End Function
    Public Function getRoomCount() As String
        command.CommandText = "Select count(*) from odalar"
        command.Connection = baglanti
        adapter.SelectCommand = command
        Dim sonuc As String = CStr(command.ExecuteScalar())
        Return sonuc
    End Function
    Public Function getBedCount() As String
        command.CommandText = "Select sum(yataksayisi) from odalar"
        command.Connection = baglanti
        adapter.SelectCommand = command
        Dim sonuc As String = CStr(command.ExecuteScalar())
        Return sonuc
    End Function
    Public Function getLastStudent() As String
        command.CommandText = "Select * from ogrenciler order by id desc"
        command.Connection = baglanti
        adapter.SelectCommand = command
        data = command.ExecuteReader()
        Dim kullaniciadi As String
        Return kullaniciadi
    End Function

    Public Function getOgrenciler() As DataTable
        adapter = New OleDbDataAdapter("select * from ogrenciler", baglanti)
        adapter.Fill(table)
        Return table
    End Function
    Public Function getPersoneller() As DataTable
        adapter = New OleDbDataAdapter("select * from personeller", baglanti)
        adapter.Fill(table)
        Return table
    End Function
    Public Function getOdalar() As DataTable
        adapter = New OleDbDataAdapter("select * from odalar", baglanti)
        adapter.Fill(table)
        Return table
    End Function
    Public Function getGorevler() As DataTable
        adapter = New OleDbDataAdapter("select * from gorevler", baglanti)
        adapter.Fill(table)
        Return table
    End Function
    Public Function getOdemeler()
        adapter = New OleDbDataAdapter("select * from sonodemeler", baglanti)
        adapter.Fill(table)
        Return table
    End Function



End Class

