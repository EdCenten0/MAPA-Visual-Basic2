Public Class Reporte_Materiales_Pedidos
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim reporte As New CrystalReport1
        reporte.DataSourceConnections.Item(0).SetLogon("sa", "1234")
        Me.CrystalReportViewer1.ReportSource = reporte
    End Sub
End Class