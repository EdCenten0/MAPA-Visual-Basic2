Public Class Frm_Ventas
    Private Sub Frm_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.MAPADataSet.ventas)
        IDTVenta.Enabled = False
        IDVenta.Enabled = False
        IDFVenta.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.VentasTableAdapter.Guardar(CantidadVenta.Text, DescripcionVenta.Text, IDTVenta.Text, IDFVenta.Text)
        Me.VentasTableAdapter.Fill(Me.MAPADataSet.ventas)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.VentasTableAdapter.Editar(CantidadVenta.Text, DescripcionVenta.Text, IDTVenta.Text, IDFVenta.Text, IDVenta.Text, IDVenta.Text)
        Me.VentasTableAdapter.Fill(Me.MAPADataSet.ventas)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.VentasTableAdapter.Eliminar(IDVenta.Text)
        Me.VentasTableAdapter.Fill(Me.MAPADataSet.ventas)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.VentasTableAdapter.Buscar(MAPADataSet.ventas, IDVenta.Text)
        Me.VentasTableAdapter.Fill(Me.MAPADataSet.ventas)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.VentasTableAdapter.Fill(Me.MAPADataSet.ventas)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        IDVenta.Clear()
        IDFVenta.Clear()
        IDTVenta.Clear()
        CantidadVenta.Clear()
        DescripcionVenta.Clear()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        ReporteClientes.Show()
    End Sub

    Private Sub IDFVenta_TextChanged(sender As Object, e As EventArgs) Handles IDFVenta.TextChanged

    End Sub
End Class