Public Class FormMenuUtama
    Sub Terkunci()
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        MasterToolStripMenuItem.Enabled = False
        TransaksiToolStripMenuItem.Enabled = False
        LaporanToolStripMenuItem.Enabled = False
        UtilityToolStripMenuItem.Enabled = False
        STLabel2.Text = ""
        STLabel4.Text = ""
        STLabel6.Text = ""
        LoginToolStripMenuItem1.Enabled = True
        LogoutToolStripMenuItem1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Label2.Visible = True
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Terkunci()
        STLabel10.Text = Today
    End Sub
    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        FormLogin.ShowDialog()
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        MsgBox("Logout Berhasil")
        Call Terkunci()
    End Sub
    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub
    Private Sub AdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminToolStripMenuItem.Click
        FormMasterAdmin.ShowDialog()
    End Sub
    Private Sub PelangganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PelangganToolStripMenuItem.Click
        FormMasterPelanggan.ShowDialog()
    End Sub
    Private Sub BarangToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangToolStripMenuItem1.Click
        FormMasterBarang.ShowDialog()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        STLabel8.Text = TimeOfDay
    End Sub
    Private Sub PenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjualanToolStripMenuItem.Click
        FormTransJual.ShowDialog()
    End Sub
    Private Sub LaporanDataMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanDataMasterToolStripMenuItem.Click
        FormLapDataMaster.ShowDialog()
    End Sub
    Private Sub LaporanPenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPenjualanToolStripMenuItem.Click
        FormLapJual.ShowDialog()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ContextMenuStripFile.Show(Button1, 1, Button1.Height)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ContextMenuStripMaster.Show(Button3, 1, Button3.Height)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ContextMenuStripLaporan.Show(Button2, 1, Button2.Height)
    End Sub
    Private Sub LoginToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem1.Click
        FormLogin.ShowDialog()
    End Sub
    Private Sub LogoutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem1.Click
        MsgBox("Logout Berhasil")
        Call Terkunci()
    End Sub
    Private Sub KeluarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem1.Click
        End
    End Sub
    Private Sub AdminToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminToolStripMenuItem1.Click
        FormMasterAdmin.ShowDialog()
    End Sub
    Private Sub PelangganToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PelangganToolStripMenuItem1.Click
        FormMasterPelanggan.ShowDialog()
    End Sub
    Private Sub BarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangToolStripMenuItem.Click
        FormMasterBarang.ShowDialog()
    End Sub
    Private Sub LaporanDataMasterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanDataMasterToolStripMenuItem1.Click
        FormLapDataMaster.ShowDialog()
    End Sub
    Private Sub LaporanPenjualanToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPenjualanToolStripMenuItem1.Click
        FormLapJual.ShowDialog()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Application.Exit()
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        FormGantiPassword.ShowDialog()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If STLabel6.Text = "USER" Then
            FormTransJual.ShowDialog()
        End If
    End Sub
    Private Sub GantiPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GantiPasswordToolStripMenuItem.Click
        FormGantiPassword.ShowDialog()
    End Sub
End Class
