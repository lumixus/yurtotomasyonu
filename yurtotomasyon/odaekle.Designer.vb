﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class odaekle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.AutoEllipsis = True
        Me.Button2.BackColor = System.Drawing.SystemColors.GrayText
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(488, 107)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 49)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "TEMİZLE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AutoEllipsis = True
        Me.Button1.BackColor = System.Drawing.SystemColors.GrayText
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(488, 18)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 49)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "EKLE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(327, 132)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.MaxLength = 11
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(132, 22)
        Me.TextBox3.TabIndex = 46
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(327, 34)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.MaxLength = 25
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 22)
        Me.TextBox1.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(72, 130)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 23)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Yatak Sayısı:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(72, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 23)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Oda Numarası:"
        '
        'odaekle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.yurtotomasyon.My.Resources.Resources.Titanium
        Me.ClientSize = New System.Drawing.Size(823, 217)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "odaekle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "odaekle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
