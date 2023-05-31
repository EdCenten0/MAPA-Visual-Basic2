Public Class ReporteClientes
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub
    Public Sub CargarReporte()
        Dim objReporte As New CrystalReport2
        objReporte.DataSourceConnections.Item(0).SetLogon("sa", "1234")
        objReporte.SetParameterValue("@descripcion", TextBox1.Text)
        Me.cryreport.ReportSource = objReporte
    End Sub
    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        CargarReporte()
    End Sub

    Private Sub cryreport_Load(sender As Object, e As EventArgs) Handles cryreport.Load

    End Sub
End Class