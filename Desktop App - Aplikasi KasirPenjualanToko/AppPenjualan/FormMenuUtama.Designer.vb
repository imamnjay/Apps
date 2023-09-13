<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuUtama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BarangToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanDataMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GantiPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.STLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel9 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel10 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ContextMenuStripFile = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LoginToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.KeluarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripMaster = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AdminToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PelangganToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripLaporan = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LaporanPenjualanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanDataMasterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ContextMenuStripFile.SuspendLayout()
        Me.ContextMenuStripMaster.SuspendLayout()
        Me.ContextMenuStripLaporan.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.UtilityToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(667, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ToolStripMenuItem1, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Image = CType(resources.GetObject("LoginToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(109, 6)
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Image = CType(resources.GetObject("KeluarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.PelangganToolStripMenuItem, Me.ToolStripMenuItem2, Me.BarangToolStripMenuItem1})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Image = CType(resources.GetObject("AdminToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'PelangganToolStripMenuItem
        '
        Me.PelangganToolStripMenuItem.Image = CType(resources.GetObject("PelangganToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PelangganToolStripMenuItem.Name = "PelangganToolStripMenuItem"
        Me.PelangganToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.PelangganToolStripMenuItem.Text = "Pelanggan"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(127, 6)
        '
        'BarangToolStripMenuItem1
        '
        Me.BarangToolStripMenuItem1.Image = CType(resources.GetObject("BarangToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.BarangToolStripMenuItem1.Name = "BarangToolStripMenuItem1"
        Me.BarangToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
        Me.BarangToolStripMenuItem1.Text = "Barang"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Image = CType(resources.GetObject("PenjualanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPenjualanToolStripMenuItem, Me.LaporanDataMasterToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanPenjualanToolStripMenuItem
        '
        Me.LaporanPenjualanToolStripMenuItem.Image = CType(resources.GetObject("LaporanPenjualanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LaporanPenjualanToolStripMenuItem.Name = "LaporanPenjualanToolStripMenuItem"
        Me.LaporanPenjualanToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.LaporanPenjualanToolStripMenuItem.Text = "Laporan Penjualan"
        '
        'LaporanDataMasterToolStripMenuItem
        '
        Me.LaporanDataMasterToolStripMenuItem.Image = CType(resources.GetObject("LaporanDataMasterToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LaporanDataMasterToolStripMenuItem.Name = "LaporanDataMasterToolStripMenuItem"
        Me.LaporanDataMasterToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.LaporanDataMasterToolStripMenuItem.Text = "Laporan Data Master"
        '
        'UtilityToolStripMenuItem
        '
        Me.UtilityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GantiPasswordToolStripMenuItem})
        Me.UtilityToolStripMenuItem.Name = "UtilityToolStripMenuItem"
        Me.UtilityToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.UtilityToolStripMenuItem.Text = "Utility"
        '
        'GantiPasswordToolStripMenuItem
        '
        Me.GantiPasswordToolStripMenuItem.Image = CType(resources.GetObject("GantiPasswordToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GantiPasswordToolStripMenuItem.Name = "GantiPasswordToolStripMenuItem"
        Me.GantiPasswordToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.GantiPasswordToolStripMenuItem.Text = "Ganti Password"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STLabel1, Me.STLabel2, Me.STLabel3, Me.STLabel4, Me.STLabel5, Me.STLabel6, Me.STLabel7, Me.STLabel8, Me.STLabel9, Me.STLabel10})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 342)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(667, 22)
        Me.StatusStrip1.TabIndex = 37
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'STLabel1
        '
        Me.STLabel1.Name = "STLabel1"
        Me.STLabel1.Size = New System.Drawing.Size(40, 17)
        Me.STLabel1.Text = "Kode :"
        '
        'STLabel2
        '
        Me.STLabel2.Name = "STLabel2"
        Me.STLabel2.Size = New System.Drawing.Size(0, 17)
        '
        'STLabel3
        '
        Me.STLabel3.Name = "STLabel3"
        Me.STLabel3.Size = New System.Drawing.Size(45, 17)
        Me.STLabel3.Text = "Nama :"
        '
        'STLabel4
        '
        Me.STLabel4.Name = "STLabel4"
        Me.STLabel4.Size = New System.Drawing.Size(0, 17)
        '
        'STLabel5
        '
        Me.STLabel5.Name = "STLabel5"
        Me.STLabel5.Size = New System.Drawing.Size(40, 17)
        Me.STLabel5.Text = "Level :"
        '
        'STLabel6
        '
        Me.STLabel6.Name = "STLabel6"
        Me.STLabel6.Size = New System.Drawing.Size(0, 17)
        '
        'STLabel7
        '
        Me.STLabel7.Name = "STLabel7"
        Me.STLabel7.Size = New System.Drawing.Size(34, 17)
        Me.STLabel7.Text = "Jam :"
        '
        'STLabel8
        '
        Me.STLabel8.Name = "STLabel8"
        Me.STLabel8.Size = New System.Drawing.Size(0, 17)
        '
        'STLabel9
        '
        Me.STLabel9.Name = "STLabel9"
        Me.STLabel9.Size = New System.Drawing.Size(56, 17)
        Me.STLabel9.Text = "Tanggal :"
        '
        'STLabel10
        '
        Me.STLabel10.Name = "STLabel10"
        Me.STLabel10.Size = New System.Drawing.Size(0, 17)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(240, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 98)
        Me.Button1.TabIndex = 39
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button2.Location = New System.Drawing.Point(240, 219)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(188, 98)
        Me.Button2.TabIndex = 39
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(452, 95)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(188, 98)
        Me.Button3.TabIndex = 39
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(452, 219)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(188, 98)
        Me.Button4.TabIndex = 39
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button5.Location = New System.Drawing.Point(27, 219)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(188, 98)
        Me.Button5.TabIndex = 39
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(638, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(29, 24)
        Me.Button6.TabIndex = 40
        Me.Button6.UseVisualStyleBackColor = False
        '
        'ContextMenuStripFile
        '
        Me.ContextMenuStripFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem1, Me.LogoutToolStripMenuItem1, Me.ToolStripMenuItem3, Me.KeluarToolStripMenuItem1})
        Me.ContextMenuStripFile.Name = "ContextMenuStrip1"
        Me.ContextMenuStripFile.Size = New System.Drawing.Size(113, 76)
        '
        'LoginToolStripMenuItem1
        '
        Me.LoginToolStripMenuItem1.Image = CType(resources.GetObject("LoginToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.LoginToolStripMenuItem1.Name = "LoginToolStripMenuItem1"
        Me.LoginToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.LoginToolStripMenuItem1.Text = "Login"
        '
        'LogoutToolStripMenuItem1
        '
        Me.LogoutToolStripMenuItem1.Image = CType(resources.GetObject("LogoutToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem1.Name = "LogoutToolStripMenuItem1"
        Me.LogoutToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem1.Text = "Logout"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(109, 6)
        '
        'KeluarToolStripMenuItem1
        '
        Me.KeluarToolStripMenuItem1.Image = CType(resources.GetObject("KeluarToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.KeluarToolStripMenuItem1.Name = "KeluarToolStripMenuItem1"
        Me.KeluarToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.KeluarToolStripMenuItem1.Text = "Keluar"
        '
        'ContextMenuStripMaster
        '
        Me.ContextMenuStripMaster.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem1, Me.PelangganToolStripMenuItem1, Me.ToolStripMenuItem4, Me.BarangToolStripMenuItem})
        Me.ContextMenuStripMaster.Name = "ContextMenuStrip2"
        Me.ContextMenuStripMaster.Size = New System.Drawing.Size(131, 76)
        '
        'AdminToolStripMenuItem1
        '
        Me.AdminToolStripMenuItem1.Image = CType(resources.GetObject("AdminToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.AdminToolStripMenuItem1.Name = "AdminToolStripMenuItem1"
        Me.AdminToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
        Me.AdminToolStripMenuItem1.Text = "Admin"
        '
        'PelangganToolStripMenuItem1
        '
        Me.PelangganToolStripMenuItem1.Image = CType(resources.GetObject("PelangganToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.PelangganToolStripMenuItem1.Name = "PelangganToolStripMenuItem1"
        Me.PelangganToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
        Me.PelangganToolStripMenuItem1.Text = "Pelanggan"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(127, 6)
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.Image = CType(resources.GetObject("BarangToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.BarangToolStripMenuItem.Text = "Barang"
        '
        'ContextMenuStripLaporan
        '
        Me.ContextMenuStripLaporan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPenjualanToolStripMenuItem1, Me.LaporanDataMasterToolStripMenuItem1})
        Me.ContextMenuStripLaporan.Name = "ContextMenuStrip3"
        Me.ContextMenuStripLaporan.Size = New System.Drawing.Size(184, 48)
        '
        'LaporanPenjualanToolStripMenuItem1
        '
        Me.LaporanPenjualanToolStripMenuItem1.Image = CType(resources.GetObject("LaporanPenjualanToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.LaporanPenjualanToolStripMenuItem1.Name = "LaporanPenjualanToolStripMenuItem1"
        Me.LaporanPenjualanToolStripMenuItem1.Size = New System.Drawing.Size(183, 22)
        Me.LaporanPenjualanToolStripMenuItem1.Text = "Laporan Penjualan"
        '
        'LaporanDataMasterToolStripMenuItem1
        '
        Me.LaporanDataMasterToolStripMenuItem1.Image = CType(resources.GetObject("LaporanDataMasterToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.LaporanDataMasterToolStripMenuItem1.Name = "LaporanDataMasterToolStripMenuItem1"
        Me.LaporanDataMasterToolStripMenuItem1.Size = New System.Drawing.Size(183, 22)
        Me.LaporanDataMasterToolStripMenuItem1.Text = "Laporan Data Master"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(27, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(51, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 26)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Selamat Datang,"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(53, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 25)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Silahkan Login"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(94, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(546, 26)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "TOKO MUTI : MENJUAL BAHAN TAS DAN AKSESORIS TAS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(667, 364)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Penjualan Toko Muti"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ContextMenuStripFile.ResumeLayout(False)
        Me.ContextMenuStripMaster.ResumeLayout(False)
        Me.ContextMenuStripLaporan.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PelangganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GantiPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents STLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STLabel9 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STLabel10 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LaporanDataMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStripFile As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LogoutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KeluarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripMaster As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AdminToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PelangganToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripLaporan As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LaporanDataMasterToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPenjualanToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
