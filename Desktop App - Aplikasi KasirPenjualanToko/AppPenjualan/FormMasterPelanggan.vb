Imports System.Data.Odbc

Public Class FormMasterPelanggan
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        DateTimePicker1.Enabled = False

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True

        Button1.Text = "Input"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Tutup"
        Call koneksii()

        Da = New OdbcDataAdapter("Select * from tbl_pelanggan", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_pelanggan")
        DataGridView1.DataSource = Ds.Tables("tbl_pelanggan")
        DataGridView1.ReadOnly = True
    End Sub
    Sub SiapIsi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        DateTimePicker1.Enabled = True
    End Sub
    Private Sub FormMasterPelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Input" Then
            Button1.Text = "Simpan"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Call SiapIsi()
            Call NomorOtomatis()
            TextBox1.Enabled = False
            TextBox2.Focus()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Silahkan Isi Semua Field !")
            Else
                Call koneksii()
                Dim InputData As String = "insert into tbl_pelanggan values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "')"
                Cmd = New OdbcCommand(InputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Input Data Berhasil !")
                Call KondisiAwal()
            End If
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "Edit" Then
            Button2.Text = "Simpan"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Call SiapIsi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
                MsgBox("Silahkan Isi Semua Field !")
            Else
                Call koneksii()
                Dim UpdateData As String = "update tbl_pelanggan set NamaPelanggan = '" & TextBox2.Text & "', AlamatPelanggan = '" & TextBox3.Text & "', TelpPelanggan = '" & TextBox4.Text & "', Kredit = '" & TextBox5.Text & "', JatuhTempo = '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'  where KodePelanggan = '" & TextBox1.Text & "'"
                Cmd = New OdbcCommand(UpdateData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Update Data Berhasil !")
                Call KondisiAwal()
            End If
        End If
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksii()
            Cmd = New OdbcCommand("Select * From tbl_pelanggan where KodePelanggan = '" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader()
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Kode Pelanggan Tidak Ada")
            Else
                TextBox1.Text = Rd.Item("KodePelanggan")
                TextBox2.Text = Rd.Item("NamaPelanggan")
                TextBox3.Text = Rd.Item("AlamatPelanggan")
                TextBox4.Text = Rd.Item("TelpPelanggan")
                TextBox5.Text = Rd.Item("Kredit")
                DateTimePicker1.Value = Rd.Item("JatuhTempo")
            End If
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Text = "Hapus" Then
            Button3.Text = "Delete"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Text = "Batal"
            Call SiapIsi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Silahkan Isi Semua Field !")
            Else
                Call koneksii()
                Dim HapusData As String = "Delete from tbl_pelanggan where KodePelanggan= '" & TextBox1.Text & "'"
                Cmd = New OdbcCommand(HapusData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Hapus Data Berhasil !")
                Call KondisiAwal()
            End If
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button4.Text = "Tutup" Then
            Me.Close()
        Else
            Call KondisiAwal()
        End If
    End Sub
    Sub NomorOtomatis()
        Call koneksii()
        Cmd = New OdbcCommand("Select * From tbl_pelanggan where Kodepelanggan in (select max(Kodepelanggan) from tbl_pelanggan)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "PLG" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            UrutanKode = "PLG" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        TextBox1.Text = UrutanKode
    End Sub
End Class