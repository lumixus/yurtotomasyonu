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
    Public Function getLastStudentName() As String
        command.CommandText = "Select ad from ogrenciler order by id desc"
        command.Connection = baglanti
        Dim ogrenciadi As String = CStr(command.ExecuteScalar())
        Return ogrenciadi
    End Function
    Public Function getLastStudentSurname() As String
        command.CommandText = "Select soyad from ogrenciler order by id desc"
        command.Connection = baglanti
        Dim ogrenciadi As String = CStr(command.ExecuteScalar())
        Return ogrenciadi
    End Function
    Public Function getLastStudentID() As String
        command.CommandText = "Select id from ogrenciler order by id desc"
        command.Connection = baglanti
        Dim ogrenciadi As String = CStr(command.ExecuteScalar())
        Return ogrenciadi
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
    Public Sub addOgrenci(ad As String, soyad As String, tc As String, telno As String, mail As String, bolum As String, okul As String, ogrenimturu As String, odanumarasi As String, gunceldonem As String, bursdurumu As String, dtarih As DateTime)
        Dim ktarih As DateTime = DateTime.Today
        command.CommandText = "INSERT INTO ogrenciler (ad,soyad,tc,telno,mail,bolum,okul,ogrenimturu,odanumarasi,gunceldonem,bursdurumu,dtarih,ktarih) values ('" + ad + "','" + soyad + "','" + tc + "','" + telno + "','" + mail + "','" + bolum + "','" + okul + "','" + ogrenimturu + "','" + odanumarasi + "','" + gunceldonem + "','" + bursdurumu + "','" + dtarih.ToString() + "','" + ktarih.ToString() + "')"
        command.Connection = baglanti
        command.ExecuteNonQuery()
        MsgBox("Öğrenci Eklendi")
    End Sub
    Public Sub addGorevler(gorevadi As String)
        command.CommandText = "INSERT INTO gorevler (gorevad) values (@gorevadi)"
        command.Connection = baglanti
        command.Parameters.AddWithValue("@gorevadi", gorevadi)
        command.ExecuteNonQuery()
        MsgBox("Görev Eklendi")
    End Sub
    Public Sub addOda(odanum As String, yatsay As String)
        command.CommandText = "INSERT INTO odalar (odanumarasi,guncelogrencisayisi,yataksayisi) values (@odanum,0,@yatsay)"
        command.Connection = baglanti
        command.Parameters.AddWithValue("@odanum", odanum)
        command.Parameters.AddWithValue("@yatsay", yatsay)
        command.ExecuteNonQuery()
        MsgBox("Oda Eklendi")
    End Sub
    Public Sub addPersonel(ad As String, soyad As String, tc As String, telno As String, gorevid As String, mail As String, cinsiyet As String)
        command.CommandText = "INSERT INTO personeller (ad,soyad,tc,cinsiyet,telno,gorevid,mail) values (@ad,@soyad,@tc,@cinsiyet,@telno,@gorevid,@mail)"
        command.Connection = baglanti
        command.Parameters.AddWithValue("@ad", ad)
        command.Parameters.AddWithValue("@soyad", soyad)
        command.Parameters.AddWithValue("@tc", tc)
        command.Parameters.AddWithValue("@cinsiyet", cinsiyet)
        command.Parameters.AddWithValue("@telno", telno)
        command.Parameters.AddWithValue("@gorevid", gorevid)
        command.Parameters.AddWithValue("@mail", mail)
        command.ExecuteNonQuery()
        MsgBox("Personel Eklendi")
    End Sub
    Public Function getBosOdalar() As DataTable
        adapter = New OleDbDataAdapter("select * from odalar WHERE guncelogrencisayisi < yataksayisi", baglanti)
        adapter.Fill(table)
        Return table
    End Function

    Public Sub deleteVeri(tabloadi As String, id As String)
        command.CommandText = "DELETE FROM " + tabloadi + " WHERE id = " + id
        command.Connection = baglanti
        command.ExecuteNonQuery()
        MsgBox("Veri Silindi")
    End Sub
    Public Sub updateOgrenci(id As String, ad As String, soyad As String, tc As String, telno As String, mail As String, bolum As String, okul As String, ogrenimturu As String, odanumarasi As String, gunceldonem As String, bursdurumu As String, dtarih As DateTime)

        Dim yenitarih As String
        yenitarih = dtarih.ToString()
        command.CommandText = "UPDATE ogrenciler SET ad = '" + ad + "',soyad = '" + soyad + "',tc = '" + tc + "',telno = '" + telno + "',mail = '" + mail + "',bolum = '" + bolum + "', okul = '" + okul + "',ogrenimturu = '" + ogrenimturu + "',odanumarasi = '" + odanumarasi + "',gunceldonem = '" + gunceldonem + "',bursdurumu = '" + bursdurumu + "', dtarih = '" + yenitarih + "' WHERE id = " + id
        command.Connection = baglanti
        command.ExecuteNonQuery()
        MsgBox("Öğrenci Güncellendi")
    End Sub
    Public Sub updateOdalar(id As String, odan As String, gosay As String, yatsay As String)
        command.CommandText = "UPDATE odalar SET odanumarasi =  '" + odan + "' , guncelogrencisayisi='" + gosay + "', yataksayisi ='" + yatsay + "' WHERE id = " + id
        command.Connection = baglanti
        command.ExecuteNonQuery()
        MsgBox("Oda Güncellendi")
    End Sub
    Public Sub updateGorevler(id As String, gorevad As String)
        command.CommandText = "UPDATE gorevler SET gorevad = '" + gorevad + "' WHERE id = " + id
        command.Connection = baglanti
        command.ExecuteNonQuery()
        MsgBox("Görevler Güncellendi")
    End Sub

    Public Sub updatepersoneller(id As String, ad As String, soyad As String, tc As String, telno As String, gorevid As String, mail As String)
        command.CommandText = "UPDATE personeller SET ad = '" + ad + "',soyad = '" + soyad + "',tc = '" + tc + "',telno = '" + telno + "',gorevid = '" + gorevid + "' ,mail = '" + mail + "'WHERE id = " + id
        command.Connection = baglanti
        command.ExecuteNonQuery()
        MsgBox("personel Güncellendi")
    End Sub
    Public Sub updateOdemeler(id As String, ad As String, tarih As DateTime, odmik As String, odcekmik As String, kalmik As String)
        command.CommandText = "UPDATE sonodemeler SET ogrenciid = '" + ad + "',ay = '" + tarih + "',odenenmikta = '" + odmik + "',odenecekmiktar ='" + odcekmik + "',kalanmiktar='" + kalmik + "'  WHERE id = " + id
        command.Connection = baglanti
        command.ExecuteNonQuery()
        MsgBox("Ödemeler Güncellendi")
    End Sub
    Public Function getMaxStudent() As String
        command.CommandText = "Select maxogrenci from ayarlar"
        command.Connection = baglanti
        adapter.SelectCommand = command
        Dim sonuc As String = CStr(command.ExecuteScalar())
        Return sonuc
    End Function



End Class

