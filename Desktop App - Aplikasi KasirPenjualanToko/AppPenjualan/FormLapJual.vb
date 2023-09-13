
Public Class FormLapJual
    Dim tes As String
    Private Sub FormLapJual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("1")
        ComboBox1.Items.Add("2")
        ComboBox1.Items.Add("3")
        ComboBox1.Items.Add("4")
        ComboBox1.Items.Add("5")
        ComboBox1.Items.Add("6")
        ComboBox1.Items.Add("7")
        ComboBox1.Items.Add("8")
        ComboBox1.Items.Add("9")
        ComboBox1.Items.Add("10")
        ComboBox1.Items.Add("11")
        ComboBox1.Items.Add("12")
        ComboBox2.Items.Add("2015")
        ComboBox2.Items.Add("2016")
        ComboBox2.Items.Add("2017")
        ComboBox2.Items.Add("2018")
        ComboBox2.Items.Add("2019")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AxCrystalReport1.SelectionFormula = "totext({tbl_Jual.NoJual})='" & TextBox1.Text & "'"
        AxCrystalReport1.ReportFileName = "lap-jual-pernota.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AxCrystalReport1.SelectionFormula = "{tbl_jual.TglJual}=CDate('" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "')"
        AxCrystalReport1.ReportFileName = "lap-jual-harian.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AxCrystalReport1.SelectionFormula = "({tbl_jual.TglJual}>=CDate('" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "') and {tbl_jual.TglJual}<=CDate('" & Format(DateTimePicker4.Value, "yyyy-MM-dd") & "'))"
        AxCrystalReport1.ReportFileName = "lap-jual-mingguan.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        AxCrystalReport1.SelectionFormula = "Month({tbl_jual.TglJual})=" & Val(ComboBox1.Text) & " and Year({tbl_jual.TglJual})=" & Val(ComboBox2.Text)
        AxCrystalReport1.ReportFileName = "lap-jual-bulanan.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub
End Class
