﻿Public Class FormLapDataMaster
        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
            AxCrystalReport1.ReportFileName = "lap-data-admin.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
        End Sub
        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
            AxCrystalReport1.ReportFileName = "lap-data-pelanggan.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
        End Sub
        Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
            AxCrystalReport1.ReportFileName = "lap-data-barang.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 0
        End Sub
        Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim a As Integer = 1
        AxCrystalReport1.SelectionFormula = "totext({tbl_pelanggan.Kredit})>= '" & a & "'"
            AxCrystalReport1.ReportFileName = "lap-data-piutang.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 0
        End Sub
        
End Class