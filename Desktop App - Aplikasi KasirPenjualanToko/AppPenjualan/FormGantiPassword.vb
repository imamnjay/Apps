Imports System.Data.Odbc
Public Class FormGantiPassword
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub FormGantiPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Isi Password Lama dan Baru Dahulu")
        Else
            Call Koneksii()
            Cmd = New OdbcCommand("select * from tbl_admin where KodeAdmin='" & Label4.Text & "' and PasswordAdmin= '" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If StrComp(TextBox1.Text, Rd.GetValue(2), 0) <> 0 Then
                MsgBox("Password Lama Tidak Sesuai")
                Call KondisiAwal()
            Else
                If StrComp(TextBox1.Text, TextBox2.Text, 1) = 0 Then
                    MsgBox("Ganti dengan Password yang Berbeda!")
                Else
                    If MessageBox.Show("Yakin akan mengganti Password Anda?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        Call Koneksii()
                        Dim update As String = "update tbl_admin set PasswordAdmin='" & TextBox2.Text & "' where KodeAdmin = '" & Label4.Text & "'"
                        Cmd = New OdbcCommand(update, Conn)
                        Cmd.ExecuteNonQuery()
                        MsgBox("Password Berhasil Diganti")
                        Me.Close()
                    End If
                End If
            End If
        End If
    End Sub
End Class