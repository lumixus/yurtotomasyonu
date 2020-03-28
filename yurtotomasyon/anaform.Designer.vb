<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GörüntüleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖğrencilerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonellerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖdemelerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GörevlerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OdalarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖğrenciEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonelEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GörevEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OdaEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÇıkışlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HesaptanÇıkışYapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramıKapatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GörüntüleToolStripMenuItem, Me.EkleToolStripMenuItem, Me.ÇıkışlToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1015, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GörüntüleToolStripMenuItem
        '
        Me.GörüntüleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÖğrencilerToolStripMenuItem, Me.PersonellerToolStripMenuItem, Me.ÖdemelerToolStripMenuItem, Me.GörevlerToolStripMenuItem, Me.OdalarToolStripMenuItem})
        Me.GörüntüleToolStripMenuItem.Name = "GörüntüleToolStripMenuItem"
        Me.GörüntüleToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.GörüntüleToolStripMenuItem.Text = "Görüntüle"
        '
        'ÖğrencilerToolStripMenuItem
        '
        Me.ÖğrencilerToolStripMenuItem.Name = "ÖğrencilerToolStripMenuItem"
        Me.ÖğrencilerToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ÖğrencilerToolStripMenuItem.Text = "Öğrenciler"
        '
        'PersonellerToolStripMenuItem
        '
        Me.PersonellerToolStripMenuItem.Name = "PersonellerToolStripMenuItem"
        Me.PersonellerToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.PersonellerToolStripMenuItem.Text = "Personeller"
        '
        'ÖdemelerToolStripMenuItem
        '
        Me.ÖdemelerToolStripMenuItem.Name = "ÖdemelerToolStripMenuItem"
        Me.ÖdemelerToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ÖdemelerToolStripMenuItem.Text = "Ödemeler"
        '
        'GörevlerToolStripMenuItem
        '
        Me.GörevlerToolStripMenuItem.Name = "GörevlerToolStripMenuItem"
        Me.GörevlerToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.GörevlerToolStripMenuItem.Text = "Görevler"
        '
        'OdalarToolStripMenuItem
        '
        Me.OdalarToolStripMenuItem.Name = "OdalarToolStripMenuItem"
        Me.OdalarToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.OdalarToolStripMenuItem.Text = "Odalar"
        '
        'EkleToolStripMenuItem
        '
        Me.EkleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÖğrenciEkleToolStripMenuItem, Me.PersonelEkleToolStripMenuItem, Me.GörevEkleToolStripMenuItem, Me.OdaEkleToolStripMenuItem})
        Me.EkleToolStripMenuItem.Name = "EkleToolStripMenuItem"
        Me.EkleToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.EkleToolStripMenuItem.Text = "Ekle"
        '
        'ÖğrenciEkleToolStripMenuItem
        '
        Me.ÖğrenciEkleToolStripMenuItem.Name = "ÖğrenciEkleToolStripMenuItem"
        Me.ÖğrenciEkleToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ÖğrenciEkleToolStripMenuItem.Text = "Öğrenci Ekle"
        '
        'PersonelEkleToolStripMenuItem
        '
        Me.PersonelEkleToolStripMenuItem.Name = "PersonelEkleToolStripMenuItem"
        Me.PersonelEkleToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PersonelEkleToolStripMenuItem.Text = "Personel Ekle"
        '
        'GörevEkleToolStripMenuItem
        '
        Me.GörevEkleToolStripMenuItem.Name = "GörevEkleToolStripMenuItem"
        Me.GörevEkleToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.GörevEkleToolStripMenuItem.Text = "Görev Ekle"
        '
        'OdaEkleToolStripMenuItem
        '
        Me.OdaEkleToolStripMenuItem.Name = "OdaEkleToolStripMenuItem"
        Me.OdaEkleToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.OdaEkleToolStripMenuItem.Text = "Oda Ekle"
        '
        'ÇıkışlToolStripMenuItem
        '
        Me.ÇıkışlToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HesaptanÇıkışYapToolStripMenuItem, Me.ProgramıKapatToolStripMenuItem})
        Me.ÇıkışlToolStripMenuItem.Name = "ÇıkışlToolStripMenuItem"
        Me.ÇıkışlToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ÇıkışlToolStripMenuItem.Text = "Çıkış"
        '
        'HesaptanÇıkışYapToolStripMenuItem
        '
        Me.HesaptanÇıkışYapToolStripMenuItem.Name = "HesaptanÇıkışYapToolStripMenuItem"
        Me.HesaptanÇıkışYapToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.HesaptanÇıkışYapToolStripMenuItem.Text = "Hesaptan Çıkış Yap"
        '
        'ProgramıKapatToolStripMenuItem
        '
        Me.ProgramıKapatToolStripMenuItem.Name = "ProgramıKapatToolStripMenuItem"
        Me.ProgramıKapatToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ProgramıKapatToolStripMenuItem.Text = "Programı Kapat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Güncel Yatak Sayısı"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 44)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "32"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Panel1.Location = New System.Drawing.Point(703, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(312, 189)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Panel2.Location = New System.Drawing.Point(0, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(312, 189)
        Me.Panel2.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Öğrenci Sayısı"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 44)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "32"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Panel3.Location = New System.Drawing.Point(0, 405)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(312, 189)
        Me.Panel3.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 22)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Personel Sayısı"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 44)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "32"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Panel4.Location = New System.Drawing.Point(703, 405)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(312, 189)
        Me.Panel4.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 22)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Boş Oda Sayısı"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 44)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "32"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Panel5.Location = New System.Drawing.Point(353, 221)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(312, 189)
        Me.Panel5.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label11.Location = New System.Drawing.Point(72, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(175, 22)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Toplam Oda Sayısı"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label12.Location = New System.Drawing.Point(126, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 44)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "32"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(92, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 56)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1015, 593)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Yönetici Paneli"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ÇıkışlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GörüntüleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÖğrencilerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonellerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÖdemelerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GörevlerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EkleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÖğrenciEkleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonelEkleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GörevEkleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HesaptanÇıkışYapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgramıKapatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OdalarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OdaEkleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
