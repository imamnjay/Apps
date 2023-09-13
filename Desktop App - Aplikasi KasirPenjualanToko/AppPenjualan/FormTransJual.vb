Imports System.Data.Odbc
Public Class FormTransJual
    Dim TglMySql As String
    Dim jatuhtempo As String
    Dim SimpanJual As String
    Sub KondisiAwal()
        LBLNamaPlg.Text = ""
        LBLAlamat.Text = ""
        LBLTelepon.Text = ""
        LBLTanggal.Text = Today
        LBLAdmin.Text = FormMenuUtama.STLabel4.Text
        LBLKembali.Text = ""
        TextBox2.Text = ""
        LBLNamaBarang.Text = ""
        LBLHargaBarang.Text = ""

        TextBox3.Text = ""
        LBLItem.Text = ""
        Call MunculKodePelanggan()
        Call NomorOtomatis()
        Call BuatKolom()
        Label7.Text = "0"
        TextBox1.Text = ""
        ComboBox1.Text = ""
        LBLJumlahBrg.Text = ""
        LBLSatuanBRG.Text = ""
        TextBox4.Text = ""
        TextBox4.Enabled = True
        DateTimePicker1.Enabled = True
        DateTimePicker1.Text = Today
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LBLJam.Text = TimeOfDay
    End Sub

    Private Sub FormTransJual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub
    Sub MunculKodePelanggan()
        Call koneksii()
        ComboBox1.Items.Clear()
        Cmd = New OdbcCommand("Select * From tbl_pelanggan", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboBox1.Items.Add(Rd.Item(0))
        Loop
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call koneksii()
        Cmd = New OdbcCommand("Select * From tbl_pelanggan where KodePelanggan = '" & ComboBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LBLNamaPlg.Text = Rd!NamaPelanggan
            LBLAlamat.Text = Rd!AlamatPelanggan
            LBLTelepon.Text = Rd!TelpPelanggan
        End If
        If ComboBox1.Text = "PLG001" Then
            DateTimePicker1.Enabled = False
            TextBox4.Enabled = False
        Else
            DateTimePicker1.Enabled = True
            TextBox4.Enabled = True
        End If
    End Sub
    Sub NomorOtomatis()
        Call koneksii()
        Cmd = New OdbcCommand("Select NoJual From tbl_jual order by NoJual desc", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            LBLNoJual.Text = Format(Now, "yyMMdd") + "001"
        Else
            If Microsoft.VisualBasic.Left(Rd.Item("NoJual"), 6) = Format(Today, "yyMMdd") Then
                LBLNoJual.Text = Rd.Item("NoJual") + 1
            Else
                LBLNoJual.Text = Format(Today, "yyMMdd") + "001"
            End If
        End If
    End Sub
    Sub BuatKolom()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Kode", "Kode")
        DataGridView1.Columns.Add("Nama", "NamaBarang")
        DataGridView1.Columns.Add("Harga", "Harga")
        DataGridView1.Columns.Add("Jumlah", "Jumlah")
        DataGridView1.Columns.Add("SubTotal", "SubTotal")
    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksii()
            Cmd = New OdbcCommand("Select * From tbl_barang where KodeBarang = '" & TextBox2.Text & "'", Conn)
            Rd = Cmd.ExecuteReader()
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Kode Barang Tidak Ada")
            Else
                TextBox2.Text = Rd.Item("KodeBarang")
                LBLNamaBarang.Text = Rd.Item("NamaBarang")
                LBLHargaBarang.Text = Rd.Item("HargaBarang")
                LBLSatuanBRG.Text = Rd.Item("SatuanBarang")
                LBLJumlahBrg.Text = Rd.Item("JumlahBarang")
            End If
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If LBLNamaBarang.Text = "" Or TextBox3.Text = "" Then
            MsgBox("SIlahkan Masukkan Kode Barang dan Tekan ENTER!!")
        Else
            If Val(LBLJumlahBrg.Text) < Val(TextBox3.Text) Then
                MsgBox("Stok Barang Kurang")
            Else
                DataGridView1.Rows.Add(New String() {TextBox2.Text, LBLNamaBarang.Text, LBLHargaBarang.Text, TextBox3.Text, Val(LBLHargaBarang.Text) * Val(TextBox3.Text)})
                Call RumusSubTotal()
                TextBox2.Text = ""
                LBLNamaBarang.Text = ""
                LBLHargaBarang.Text = ""
                LBLJumlahBrg.Text = ""
                TextBox3.Text = ""
                Call RumusCariItem()
                TextBox2.Focus()
            End If
        End If
    End Sub
    Sub RumusSubTotal()
        Dim Hitung As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            Hitung = Hitung + DataGridView1.Rows(i).Cells(4).Value
            Label7.Text = Hitung
        Next
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If e.KeyChar = Chr(13) Then
            If Val(TextBox1.Text) < Val(Label7.Text) Then
                MsgBox("Pembayaran Kurang")
            ElseIf Val(TextBox1.Text) = Val(Label7.Text) Then
                LBLKembali.Text = 0
                TextBox4.Text = 0
            ElseIf Val(TextBox1.Text) > Val(Label7.Text) Then
                LBLKembali.Text = Val(TextBox1.Text) - Val(Label7.Text)
                TextBox4.Text = 0
                Button1.Focus()
            End If
        End If
    End Sub
    Sub RumusCariItem()
        Dim HitungItem As Integer = 0
        HitungItem = DataGridView1.RowCount - 1
        LBLItem.Text = HitungItem
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If LBLKembali.Text = "" Or LBLNamaPlg.Text = "" Or Label7.Text = "" Then
            MsgBox("Transaksi Tidak Ada, Silahkan lakukan transaksi terlebih dahulu")
        Else
            TglMySql = Format(Today, "yyyy-MM-dd")
            If ComboBox1.Text = "PLG001" Then
                SimpanJual = "insert into tbl_jual values ('" & LBLNoJual.Text & "','" & TglMySql & "','" & LBLJam.Text & "','" & LBLItem.Text & "','" & Label7.Text & "','" & TextBox1.Text & "','" & LBLKembali.Text & "','','','" & ComboBox1.Text & "','" & FormMenuUtama.STLabel2.Text & "')"
            Else
                If TextBox4.Text <> 0 And DateTimePicker1.Text = Today Then
                    MsgBox("Ubah Tanggal Jatuh Tempo!")
                    GoTo 1
                Else
                    SimpanJual = "insert into tbl_jual values ('" & LBLNoJual.Text & "','" & TglMySql & "','" & LBLJam.Text & "','" & LBLItem.Text & "','" & Label7.Text & "','" & TextBox1.Text & "','" & LBLKembali.Text & "','" & TextBox4.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & ComboBox1.Text & "','" & FormMenuUtama.STLabel2.Text & "')"
                    Cmd = New OdbcCommand("select * from tbl_pelanggan where KodePelanggan = '" & ComboBox1.Text & "'", Conn)
                    Rd = Cmd.ExecuteReader
                    Rd.Read()
                    Dim TotalKredit As String = "update tbl_pelanggan set Kredit = '" & Rd.Item("Kredit") + TextBox4.Text & "' where KodePelanggan = '" & ComboBox1.Text & "'"
                    Cmd = New OdbcCommand(TotalKredit, Conn)
                    Cmd.ExecuteNonQuery()
                    Dim JatuhTempo As String = "update tbl_pelanggan set JatuhTempo = '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' where KodePelanggan = '" & ComboBox1.Text & "'"
                    Cmd = New OdbcCommand(JatuhTempo, Conn)
                    Cmd.ExecuteNonQuery()
                End If
            End If
            Label9.Text = TglMySql
            Cmd = New OdbcCommand(SimpanJual, Conn)
            Cmd.ExecuteNonQuery()

            For Baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Dim SimpanDetail As String = "insert into tbl_detailjual values ('" & LBLNoJual.Text & "','" & DataGridView1.Rows(Baris).Cells(0).Value & "', '" & DataGridView1.Rows(Baris).Cells(1).Value & "','" & DataGridView1.Rows(Baris).Cells(2).Value & "','" & DataGridView1.Rows(Baris).Cells(3).Value & "','" & DataGridView1.Rows(Baris).Cells(4).Value & "')"
                Cmd = New OdbcCommand(SimpanDetail, Conn)
                Cmd.ExecuteNonQuery()
                Cmd = New OdbcCommand("select * from tbl_barang where KodeBarang = '" & DataGridView1.Rows(Baris).Cells(0).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                Dim KurangiStok As String = "update tbl_barang set JumlahBarang = '" & Rd.Item("JumlahBarang") - DataGridView1.Rows(Baris).Cells(3).Value & "' where KodeBarang = '" & DataGridView1.Rows(Baris).Cells(0).Value & "'"
                Cmd = New OdbcCommand(KurangiStok, Conn)
                Cmd.ExecuteNonQuery()
            Next

            If MessageBox.Show("Apakah ingin cetak nota...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                AxCrystalReport1.SelectionFormula = "totext({tbl_Jual.NoJual})='" & LBLNoJual.Text & "'"
                AxCrystalReport1.ReportFileName = "notajual.rpt"
                AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
                AxCrystalReport1.RetrieveDataFiles()
                AxCrystalReport1.Action = 1
                Call KondisiAwal()
                ' MsgBox("Transaksi Telah Berhasil Disimpan")
            Else
                Call KondisiAwal()
                MsgBox("Transaksi Telah Berhasil Disimpan")
            End If
1:
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call KondisiAwal()
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or "-.,/".Contains(e.KeyChar) Or e.KeyChar = vbBack) Then e.Handled = True
        If e.KeyChar = Chr(13) Then
            If TextBox4.Text <> Label7.Text And TextBox1.Text < Label7.Text Then
                MsgBox("Masukkan jumlah transaksi yang sesuai dengan subtotal")
            Else
                TextBox1.Text = 0
                LBLKembali.Text = 0
            End If
        End If
    End Sub
End Class