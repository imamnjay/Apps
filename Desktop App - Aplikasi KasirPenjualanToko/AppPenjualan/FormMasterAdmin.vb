Imports System.Data.Odbc

Public Class FormMasterAdmin
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = false
        ComboBox1.Enabled = False

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True

        Button1.Text = "Input"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Tutup"
        Call koneksii()

        Da = New OdbcDataAdapter("Select KodeAdmin, NamaAdmin, LevelAdmin from tbl_admin", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_admin")
        DataGridView1.DataSource = Ds.Tables("tbl_admin")
        DataGridView1.ReadOnly = True
    End Sub
    Sub SiapIsi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        ComboBox1.Enabled = True
    End Sub

    Private Sub FormMasterAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Input" Then
            Button1.Text = "Simpan"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            ComboBox1.Items.Add("ADMIN")
            ComboBox1.Items.Add("USER")
            Call SiapIsi()
            Call NomorOtomatis()
            TextBox1.Enabled = False
            TextBox2.Focus()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Silahkan Isi Semua Field !")
            Else
                Call koneksii()
                Dim InputData As String = "insert into tbl_admin values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "')"
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
            ComboBox1.Items.Add("USER")
            Call SiapIsi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Silahkan Isi Semua Field !")
            Else
                Call koneksii()
                Dim UpdateData As String = "update tbl_admin set NamaAdmin = '" & TextBox2.Text & "', PasswordAdmin = '" & TextBox3.Text & "', LevelAdmin = '" & ComboBox1.Text & "' where KodeAdmin = '" & TextBox1.Text & "'"
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
            Cmd = New OdbcCommand("Select * From tbl_admin where KodeAdmin = '" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader()
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Kode Admin Tidak Ada")
            ElseIf Rd.Item("LevelAdmin") = "ADMIN" Then
                MsgBox("Tidak Bisa Mengubah ADMIN")
            Else
                TextBox1.Text = Rd.Item("KodeAdmin")
                TextBox2.Text = Rd.Item("NamaAdmin")
                TextBox3.Text = Rd.Item("PasswordAdmin")
                ComboBox1.Text = Rd.Item("LevelAdmin")
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
            ComboBox1.Items.Add("USER")
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Silahkan Isi Semua Field !")
            Else
                Call koneksii()
                Dim HapusData As String = "Delete from tbl_admin where KodeAdmin= '" & TextBox1.Text & "'"
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
        Cmd = New OdbcCommand("Select * From tbl_admin where KodeAdmin in (select max(KodeAdmin) from tbl_admin)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "USR" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            UrutanKode = "USR" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        TextBox1.Text = UrutanKode
    End Sub
    Sub NomorOtomatis2()
        Call koneksii()
        Cmd = New OdbcCommand("Select KodeAdmin From tbl_admin where KodeAdmin like 'A%' order by KodeAdmin desc", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "ADM" + "001"
        Else
            If Microsoft.VisualBasic.Left(Rd.Item("KodeAdmin"), 1) = "A" Then
                Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
                UrutanKode = "ADM" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
            End If
        End If
        TextBox1.Text = UrutanKode
    End Sub
    
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "ADMIN" Then
            TextBox1.Enabled = False
            Call NomorOtomatis2()
        Else
            TextBox1.Enabled = False
            Call NomorOtomatis()
        End If
    End Sub
End Class
