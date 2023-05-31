Public Class ReporteClientes

    Public Sub CargarReporte()
        Dim objReporte As New CrystalReport2
        objReporte.DataSourceConnections.Item(0).SetLogon("sa", "1234")
        objReporte.SetParameterValue("@descripcion", TextBox1.Text)
        Me.cryreport.ReportSource = objReporte
    End Sub
    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        CargarReporte()
    End Sub

    Private Sub ReporteClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarReporte()
    End Sub
End Class