<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransJual
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransJual))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBLNoJual = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LBLNamaPlg = New System.Windows.Forms.Label()
        Me.LBLAlamat = New System.Windows.Forms.Label()
        Me.LBLTelepon = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LBLTanggal = New System.Windows.Forms.Label()
        Me.LBLJam = New System.Windows.Forms.Label()
        Me.LBLAdmin = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LBLKembali = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LBLNamaBarang = New System.Windows.Forms.Label()
        Me.LBLJumlahBrg = New System.Windows.Forms.Label()
        Me.LBLHargaBarang = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LBLItem = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.LBLSatuanBRG = New System.Windows.Forms.Label()
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor Jual"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(22, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kode Pelanggan"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(22, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(22, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(22, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Telepon"
        '
        'LBLNoJual
        '
        Me.LBLNoJual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNoJual.Location = New System.Drawing.Point(159, 24)
        Me.LBLNoJual.Name = "LBLNoJual"
        Me.LBLNoJual.Size = New System.Drawing.Size(131, 23)
        Me.LBLNoJual.TabIndex = 0
        Me.LBLNoJual.Text = "LBLNoJual"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(159, 49)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(131, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'LBLNamaPlg
        '
        Me.LBLNamaPlg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNamaPlg.Location = New System.Drawing.Point(159, 70)
        Me.LBLNamaPlg.Name = "LBLNamaPlg"
        Me.LBLNamaPlg.Size = New System.Drawing.Size(341, 23)
        Me.LBLNamaPlg.TabIndex = 0
        Me.LBLNamaPlg.Text = "LBLNamaPlg"
        '
        'LBLAlamat
        '
        Me.LBLAlamat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLAlamat.Location = New System.Drawing.Point(159, 93)
        Me.LBLAlamat.Name = "LBLAlamat"
        Me.LBLAlamat.Size = New System.Drawing.Size(341, 23)
        Me.LBLAlamat.TabIndex = 0
        Me.LBLAlamat.Text = "LBLAlamat"
        '
        'LBLTelepon
        '
        Me.LBLTelepon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTelepon.Location = New System.Drawing.Point(159, 116)
        Me.LBLTelepon.Name = "LBLTelepon"
        Me.LBLTelepon.Size = New System.Drawing.Size(131, 23)
        Me.LBLTelepon.TabIndex = 0
        Me.LBLTelepon.Text = "LBLTelepon"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(506, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Tanggal"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(506, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Jam"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(506, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 23)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Admin"
        '
        'LBLTanggal
        '
        Me.LBLTanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTanggal.Location = New System.Drawing.Point(562, 70)
        Me.LBLTanggal.Name = "LBLTanggal"
        Me.LBLTanggal.Size = New System.Drawing.Size(147, 23)
        Me.LBLTanggal.TabIndex = 0
        Me.LBLTanggal.Text = "LBLTanggal"
        '
        'LBLJam
        '
        Me.LBLJam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLJam.Location = New System.Drawing.Point(562, 93)
        Me.LBLJam.Name = "LBLJam"
        Me.LBLJam.Size = New System.Drawing.Size(147, 23)
        Me.LBLJam.TabIndex = 0
        Me.LBLJam.Text = "LBLJam"
        '
        'LBLAdmin
        '
        Me.LBLAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLAdmin.Location = New System.Drawing.Point(562, 116)
        Me.LBLAdmin.Name = "LBLAdmin"
        Me.LBLAdmin.Size = New System.Drawing.Size(147, 23)
        Me.LBLAdmin.TabIndex = 0
        Me.LBLAdmin.Text = "LBLAdmin"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(506, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(203, 37)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "0"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(375, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 37)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Total : RP."
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 185)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(687, 178)
        Me.DataGridView1.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(520, 405)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Di Bayar"
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Location = New System.Drawing.Point(520, 432)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 20)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Kembali"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(578, 405)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(131, 20)
        Me.TextBox1.TabIndex = 9
        '
        'LBLKembali
        '
        Me.LBLKembali.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLKembali.Location = New System.Drawing.Point(578, 429)
        Me.LBLKembali.Name = "LBLKembali"
        Me.LBLKembali.Size = New System.Drawing.Size(131, 23)
        Me.LBLKembali.TabIndex = 0
        Me.LBLKembali.Text = "LBLKembali"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(22, 380)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 48)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "SIMPAN"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(123, 380)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 48)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "BATAL"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(222, 379)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 48)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "TUTUP"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(22, 150)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 23)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Kode"
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Location = New System.Drawing.Point(159, 150)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 23)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Nama"
        '
        'LBLNamaBarang
        '
        Me.LBLNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLNamaBarang.Location = New System.Drawing.Point(205, 150)
        Me.LBLNamaBarang.Name = "LBLNamaBarang"
        Me.LBLNamaBarang.Size = New System.Drawing.Size(134, 23)
        Me.LBLNamaBarang.TabIndex = 5
        Me.LBLNamaBarang.Text = "Nama"
        '
        'LBLJumlahBrg
        '
        Me.LBLJumlahBrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLJumlahBrg.Location = New System.Drawing.Point(450, 121)
        Me.LBLJumlahBrg.Name = "LBLJumlahBrg"
        Me.LBLJumlahBrg.Size = New System.Drawing.Size(50, 23)
        Me.LBLJumlahBrg.TabIndex = 5
        '
        'LBLHargaBarang
        '
        Me.LBLHargaBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLHargaBarang.Location = New System.Drawing.Point(409, 150)
        Me.LBLHargaBarang.Name = "LBLHargaBarang"
        Me.LBLHargaBarang.Size = New System.Drawing.Size(118, 23)
        Me.LBLHargaBarang.TabIndex = 5
        Me.LBLHargaBarang.Text = "Harga"
        '
        'Label18
        '
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Location = New System.Drawing.Point(345, 150)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 23)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Harga"
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Location = New System.Drawing.Point(70, 153)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(83, 20)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(589, 153)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(54, 20)
        Me.TextBox3.TabIndex = 7
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(649, 150)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(60, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Insert"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Location = New System.Drawing.Point(520, 379)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 23)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Item"
        '
        'LBLItem
        '
        Me.LBLItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLItem.Location = New System.Drawing.Point(562, 379)
        Me.LBLItem.Name = "LBLItem"
        Me.LBLItem.Size = New System.Drawing.Size(145, 23)
        Me.LBLItem.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Location = New System.Drawing.Point(409, 121)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 23)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Stok"
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Location = New System.Drawing.Point(533, 150)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 23)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Jumlah"
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Location = New System.Drawing.Point(317, 407)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 20)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Kredit"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(375, 408)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(141, 20)
        Me.TextBox4.TabIndex = 9
        '
        'Label20
        '
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Location = New System.Drawing.Point(317, 382)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 20)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Jatuh Tempo"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(395, 382)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(121, 20)
        Me.DateTimePicker1.TabIndex = 11
        '
        'Label21
        '
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Location = New System.Drawing.Point(294, 121)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 23)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Satuan"
        '
        'LBLSatuanBRG
        '
        Me.LBLSatuanBRG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLSatuanBRG.Location = New System.Drawing.Point(345, 121)
        Me.LBLSatuanBRG.Name = "LBLSatuanBRG"
        Me.LBLSatuanBRG.Size = New System.Drawing.Size(58, 23)
        Me.LBLSatuanBRG.TabIndex = 5
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(319, 36)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 12
        '
        'FormTransJual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 467)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.LBLHargaBarang)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.LBLSatuanBRG)
        Me.Controls.Add(Me.LBLJumlahBrg)
        Me.Controls.Add(Me.LBLNamaBarang)
        Me.Controls.Add(Me.LBLItem)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LBLAdmin)
        Me.Controls.Add(Me.LBLJam)
        Me.Controls.Add(Me.LBLTanggal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LBLKembali)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LBLTelepon)
        Me.Controls.Add(Me.LBLAlamat)
        Me.Controls.Add(Me.LBLNamaPlg)
        Me.Controls.Add(Me.LBLNoJual)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTransJual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Transaksi Penjualan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LBLNoJual As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents LBLNamaPlg As System.Windows.Forms.Label
    Friend WithEvents LBLAlamat As System.Windows.Forms.Label
    Friend WithEvents LBLTelepon As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LBLTanggal As System.Windows.Forms.Label
    Friend WithEvents LBLJam As System.Windows.Forms.Label
    Friend WithEvents LBLAdmin As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LBLKembali As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LBLNamaBarang As System.Windows.Forms.Label
    Friend WithEvents LBLJumlahBrg As System.Windows.Forms.Label
    Friend WithEvents LBLHargaBarang As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LBLItem As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents LBLSatuanBRG As System.Windows.Forms.Label
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
End Class
