Imports System.Data.Odbc
Public Class FormLogin

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Sub Terbuka()
        FormMenuUtama.LoginToolStripMenuItem.Enabled = False
        FormMenuUtama.LogoutToolStripMenuItem.Enabled = True
        FormMenuUtama.MasterToolStripMenuItem.Enabled = True
        FormMenuUtama.TransaksiToolStripMenuItem.Enabled = True
        FormMenuUtama.LaporanToolStripMenuItem.Enabled = True
        FormMenuUtama.UtilityToolStripMenuItem.Enabled = True

        FormMenuUtama.LoginToolStripMenuItem1.Enabled = False
        FormMenuUtama.LogoutToolStripMenuItem1.Enabled = True
        FormMenuUtama.Button2.Enabled = True
        FormMenuUtama.Button3.Enabled = True
        FormMenuUtama.Button4.Enabled = True
        FormMenuUtama.Button5.Enabled = True

        FormMenuUtama.MasterToolStripMenuItem.Visible = True
        FormMenuUtama.TransaksiToolStripMenuItem.Visible = True
        FormMenuUtama.AdminToolStripMenuItem1.Enabled = True
        FormMenuUtama.BarangToolStripMenuItem.Enabled = True
        FormMenuUtama.PelangganToolStripMenuItem1.Enabled = True

        FormMenuUtama.LaporanToolStripMenuItem.Visible = True
        FormMenuUtama.LaporanDataMasterToolStripMenuItem.Enabled = True
        FormMenuUtama.LaporanDataMasterToolStripMenuItem1.Enabled = True
        FormMenuUtama.LaporanPenjualanToolStripMenuItem.Enabled = True
        FormMenuUtama.LaporanPenjualanToolStripMenuItem1.Enabled = True
        TextBox1.Focus()
    End Sub
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        CheckBox1.Checked = False
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Kode Admin dan Password tidak boleh kosong")
        Else
            Call Koneksii()
            Cmd = New OdbcCommand("select * from tbl_admin where KodeAdmin='" & TextBox1.Text & "' and passwordadmin = '" & TextBox2.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                If StrComp(TextBox2.Text, Rd.GetValue(2), 0) = 0 Then
                    Me.Close()
                    Call Terbuka()
                    FormMenuUtama.STLabel2.Text = Rd!KodeAdmin
                    FormMenuUtama.STLabel4.Text = Rd!NamaAdmin
                    FormMenuUtama.STLabel6.Text = Rd!LevelAdmin
                    FormGantiPassword.Label4.Text = Rd!KodeAdmin
                    FormMenuUtama.Label2.Text = Rd!NamaAdmin
                    If FormMenuUtama.STLabel6.Text = "ADMIN" Then
                        FormMenuUtama.MasterToolStripMenuItem.Visible = False
                        FormMenuUtama.TransaksiToolStripMenuItem.Visible = False
                        FormMenuUtama.AdminToolStripMenuItem1.Enabled = False
                        FormMenuUtama.BarangToolStripMenuItem.Enabled = False
                        FormMenuUtama.PelangganToolStripMenuItem1.Enabled = False
                    Else
                        FormMenuUtama.LaporanToolStripMenuItem.Visible = False
                        FormMenuUtama.LaporanDataMasterToolStripMenuItem.Enabled = False
                        FormMenuUtama.LaporanDataMasterToolStripMenuItem1.Enabled = False
                        FormMenuUtama.LaporanPenjualanToolStripMenuItem.Enabled = False
                        FormMenuUtama.LaporanPenjualanToolStripMenuItem1.Enabled = False
                    End If
                Else
                    MsgBox("Kode Admin atau Password Salah!")
                End If
            Else
                MsgBox("Kode Admin atau Password Salah!")
            End If
        End If
    End Sub

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub
    Private Sub CheckBox1_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckStateChanged
        If CheckBox1.Checked = True Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "x"
        End If
    End Sub
End Class