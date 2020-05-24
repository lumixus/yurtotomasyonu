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
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
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
        Me.AyarlarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÇıkışlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GörüntüleToolStripMenuItem, Me.EkleToolStripMenuItem, Me.AyarlarToolStripMenuItem, Me.ÇıkışlToolStripMenuItem})
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
        'AyarlarToolStripMenuItem
        '
        Me.AyarlarToolStripMenuItem.Name = "AyarlarToolStripMenuItem"
        Me.AyarlarToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.AyarlarToolStripMenuItem.Text = "Ayarlar"
        '
        'ÇıkışlToolStripMenuItem
        '
        Me.ÇıkışlToolStripMenuItem.Name = "ÇıkışlToolStripMenuItem"
        Me.ÇıkışlToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ÇıkışlToolStripMenuItem.Text = "Çıkış"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 14)
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
        Me.Label5.Location = New System.Drawing.Point(64, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 44)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "32"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Panel1.Location = New System.Drawing.Point(810, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(193, 93)
        Me.Panel1.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(348, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 56)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Panel2.Location = New System.Drawing.Point(810, 456)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(193, 93)
        Me.Panel2.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 10)
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
        Me.Label3.Location = New System.Drawing.Point(64, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 44)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "32"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Panel3.Location = New System.Drawing.Point(810, 357)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(193, 93)
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
        Me.Label6.Location = New System.Drawing.Point(64, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 44)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "32"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Panel4.Location = New System.Drawing.Point(810, 258)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(193, 93)
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
        Me.Label8.Location = New System.Drawing.Point(68, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 44)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "32"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Panel5.Location = New System.Drawing.Point(810, 159)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(193, 93)
        Me.Panel5.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 11)
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
        Me.Label12.Location = New System.Drawing.Point(64, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 44)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "32"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(330, 63)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Hoşgeldiniz!"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(41, 502)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(199, 22)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Son Eklenen Öğrenci"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(41, 541)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(219, 22)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Emir Taşkın - 221803047"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(353, 502)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 22)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Ekleyen"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(353, 541)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(191, 22)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Emre Er - 221803031"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label16.Location = New System.Drawing.Point(3, 516)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 33)
        Me.Label16.TabIndex = 19
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(187, 508)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(0, 22)
        Me.Label17.TabIndex = 20
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(603, 541)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(108, 22)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "29.03.2020"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(-22, -45)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 492)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(-8, 568)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(586, 22)
        Me.Label19.TabIndex = 24
        Me.Label19.Text = "---------------------------------------------------------------------------------" &
    "---------------"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(-8, 471)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(586, 22)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "---------------------------------------------------------------------------------" &
    "---------------"
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        Me.Chart1.BackImageTransparentColor = System.Drawing.Color.Transparent
        Me.Chart1.BackSecondaryColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderlineColor = System.Drawing.Color.Transparent
        ChartArea5.BackColor = System.Drawing.Color.Transparent
        ChartArea5.BackImageTransparentColor = System.Drawing.Color.Transparent
        ChartArea5.BackSecondaryColor = System.Drawing.Color.Transparent
        ChartArea5.BorderColor = System.Drawing.Color.Transparent
        ChartArea5.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea5)
        Legend5.BackColor = System.Drawing.Color.Transparent
        Legend5.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend5)
        Me.Chart1.Location = New System.Drawing.Point(-4, 180)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Chart1.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(141, Byte), Integer))}
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series5.Color = System.Drawing.Color.Lime
        Series5.Legend = "Legend1"
        Series5.Name = "Series1"
        Series5.ShadowColor = System.Drawing.Color.Black
        Series5.ShadowOffset = 7
        Series5.YValuesPerPoint = 2
        Me.Chart1.Series.Add(Series5)
        Me.Chart1.Size = New System.Drawing.Size(383, 288)
        Me.Chart1.TabIndex = 26
        Me.Chart1.Text = "Chart1"
        '
        'Chart2
        '
        Me.Chart2.BackColor = System.Drawing.Color.Transparent
        Me.Chart2.BorderlineColor = System.Drawing.Color.Transparent
        ChartArea6.BackColor = System.Drawing.Color.Transparent
        ChartArea6.BackImageTransparentColor = System.Drawing.Color.Transparent
        ChartArea6.BackSecondaryColor = System.Drawing.Color.Transparent
        ChartArea6.BorderColor = System.Drawing.Color.Transparent
        ChartArea6.Name = "ChartArea1"
        ChartArea6.ShadowColor = System.Drawing.Color.Blue
        Me.Chart2.ChartAreas.Add(ChartArea6)
        Legend6.BackColor = System.Drawing.Color.Transparent
        Legend6.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend6)
        Me.Chart2.Location = New System.Drawing.Point(403, 180)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Chart2.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(115, Byte), Integer))}
        Series6.BackImageTransparentColor = System.Drawing.Color.Transparent
        Series6.BackSecondaryColor = System.Drawing.Color.Transparent
        Series6.BorderColor = System.Drawing.Color.Transparent
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series6.Color = System.Drawing.Color.Transparent
        Series6.LabelBackColor = System.Drawing.Color.Transparent
        Series6.LabelBorderColor = System.Drawing.Color.Transparent
        Series6.Legend = "Legend1"
        Series6.Name = "Series1"
        Series6.ShadowColor = System.Drawing.Color.Black
        Series6.ShadowOffset = 7
        Me.Chart2.Series.Add(Series6)
        Me.Chart2.Size = New System.Drawing.Size(383, 288)
        Me.Chart2.TabIndex = 27
        Me.Chart2.Text = "Chart2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1015, 593)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Yönetici Paneli"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents AyarlarToolStripMenuItem As ToolStripMenuItem
End Class
