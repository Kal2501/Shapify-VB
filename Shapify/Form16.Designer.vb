<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrismaSegitiga
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrismaSegitiga))
        Me.txtTinggiAlas = New System.Windows.Forms.TextBox()
        Me.txtTinggiPrisma = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAlas = New System.Windows.Forms.TextBox()
        Me.txtAlas2 = New System.Windows.Forms.TextBox()
        Me.txtTinggiAlas2 = New System.Windows.Forms.TextBox()
        Me.txtTinggiPrisma2 = New System.Windows.Forms.TextBox()
        Me.lbVolume = New System.Windows.Forms.Label()
        Me.lbLuas = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTinggiAlas
        '
        Me.txtTinggiAlas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTinggiAlas.Location = New System.Drawing.Point(168, 432)
        Me.txtTinggiAlas.Name = "txtTinggiAlas"
        Me.txtTinggiAlas.Size = New System.Drawing.Size(316, 24)
        Me.txtTinggiAlas.TabIndex = 201
        '
        'txtTinggiPrisma
        '
        Me.txtTinggiPrisma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTinggiPrisma.Location = New System.Drawing.Point(168, 464)
        Me.txtTinggiPrisma.Name = "txtTinggiPrisma"
        Me.txtTinggiPrisma.Size = New System.Drawing.Size(316, 24)
        Me.txtTinggiPrisma.TabIndex = 200
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Plus Jakarta Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(38, 543)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(446, 58)
        Me.Button1.TabIndex = 199
        Me.Button1.Text = "Hitung"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Plus Jakarta Sans", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 50)
        Me.Label5.TabIndex = 197
        Me.Label5.Text = "Luas"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Font = New System.Drawing.Font("Plus Jakarta Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(517, 543)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(446, 58)
        Me.Button2.TabIndex = 195
        Me.Button2.Text = "Hitung"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Plus Jakarta Sans", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(508, 336)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 50)
        Me.Label6.TabIndex = 194
        Me.Label6.Text = "Volume"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Plus Jakarta Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(264, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(699, 105)
        Me.Label4.TabIndex = 193
        Me.Label4.Text = "Prisma segitiga adalah bangun ruang dengan dua alas berbentuk segitiga dan tiga s" & _
    "isi tegak berbentuk persegi panjang. Bentuk ini menyerupai potongan atap rumah a" & _
    "tau tenda."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Plus Jakarta Sans", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(258, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(296, 50)
        Me.Label3.TabIndex = 192
        Me.Label3.Text = "Pengertian Singkat"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(38, 116)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 194)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 191
        Me.PictureBox1.TabStop = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Black
        Me.Button9.Font = New System.Drawing.Font("Plus Jakarta Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(38, 636)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(925, 58)
        Me.Button9.TabIndex = 190
        Me.Button9.Text = "Kembali"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Plus Jakarta Sans ExtraBold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(329, 66)
        Me.Label2.TabIndex = 189
        Me.Label2.Text = "Prisma Segitiga"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Plus Jakarta Sans ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(873, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 33)
        Me.Label1.TabIndex = 188
        Me.Label1.Text = "Shapify"
        '
        'txtAlas
        '
        Me.txtAlas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlas.Location = New System.Drawing.Point(168, 400)
        Me.txtAlas.Name = "txtAlas"
        Me.txtAlas.Size = New System.Drawing.Size(316, 24)
        Me.txtAlas.TabIndex = 206
        '
        'txtAlas2
        '
        Me.txtAlas2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlas2.Location = New System.Drawing.Point(647, 400)
        Me.txtAlas2.Name = "txtAlas2"
        Me.txtAlas2.Size = New System.Drawing.Size(316, 24)
        Me.txtAlas2.TabIndex = 210
        '
        'txtTinggiAlas2
        '
        Me.txtTinggiAlas2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTinggiAlas2.Location = New System.Drawing.Point(647, 432)
        Me.txtTinggiAlas2.Name = "txtTinggiAlas2"
        Me.txtTinggiAlas2.Size = New System.Drawing.Size(316, 24)
        Me.txtTinggiAlas2.TabIndex = 209
        '
        'txtTinggiPrisma2
        '
        Me.txtTinggiPrisma2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTinggiPrisma2.Location = New System.Drawing.Point(647, 464)
        Me.txtTinggiPrisma2.Name = "txtTinggiPrisma2"
        Me.txtTinggiPrisma2.Size = New System.Drawing.Size(316, 24)
        Me.txtTinggiPrisma2.TabIndex = 208
        '
        'lbVolume
        '
        Me.lbVolume.AutoSize = True
        Me.lbVolume.Font = New System.Drawing.Font("Plus Jakarta Sans", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVolume.Location = New System.Drawing.Point(522, 508)
        Me.lbVolume.Name = "lbVolume"
        Me.lbVolume.Size = New System.Drawing.Size(63, 28)
        Me.lbVolume.TabIndex = 212
        Me.lbVolume.Text = "Hasil : "
        '
        'lbLuas
        '
        Me.lbLuas.AutoSize = True
        Me.lbLuas.Font = New System.Drawing.Font("Plus Jakarta Sans", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLuas.Location = New System.Drawing.Point(43, 508)
        Me.lbLuas.Name = "lbLuas"
        Me.lbLuas.Size = New System.Drawing.Size(63, 28)
        Me.lbLuas.TabIndex = 211
        Me.lbLuas.Text = "Hasil : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Plus Jakarta Sans", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(43, 460)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 28)
        Me.Label7.TabIndex = 213
        Me.Label7.Text = "Tinggi Prisma"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Plus Jakarta Sans", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(43, 428)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 28)
        Me.Label8.TabIndex = 214
        Me.Label8.Text = "Tinggi Alas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Plus Jakarta Sans", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(43, 396)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 28)
        Me.Label9.TabIndex = 215
        Me.Label9.Text = "Alas Alas"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Plus Jakarta Sans", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(522, 400)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 28)
        Me.Label10.TabIndex = 218
        Me.Label10.Text = "Alas Alas"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Plus Jakarta Sans", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(522, 432)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 28)
        Me.Label11.TabIndex = 217
        Me.Label11.Text = "Tinggi Alas"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Plus Jakarta Sans", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(522, 464)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 28)
        Me.Label12.TabIndex = 216
        Me.Label12.Text = "Tinggi Prisma"
        '
        'PrismaSegitiga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbVolume)
        Me.Controls.Add(Me.lbLuas)
        Me.Controls.Add(Me.txtAlas2)
        Me.Controls.Add(Me.txtTinggiAlas2)
        Me.Controls.Add(Me.txtTinggiPrisma2)
        Me.Controls.Add(Me.txtAlas)
        Me.Controls.Add(Me.txtTinggiAlas)
        Me.Controls.Add(Me.txtTinggiPrisma)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PrismaSegitiga"
        Me.Text = "Prisma Segitiga"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTinggiAlas As System.Windows.Forms.TextBox
    Friend WithEvents txtTinggiPrisma As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAlas As System.Windows.Forms.TextBox
    Friend WithEvents txtAlas2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTinggiAlas2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTinggiPrisma2 As System.Windows.Forms.TextBox
    Friend WithEvents lbVolume As System.Windows.Forms.Label
    Friend WithEvents lbLuas As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
