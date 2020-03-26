Public Class Laporan

    Private Sub Laporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DataTable1TableAdapter.Fill(Me.DataSet1.DataTable1)
        Me.ReportViewer1.RefreshReport()
    End Sub


End Class