Public Class Frm_Materiales_Por_Proveedor
    Private Sub Frm_Materiales_Por_Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.MAPADataSet.proveedores)
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.materiales_por_proveedor' Puede moverla o quitarla según sea necesario.
        Me.Materiales_por_proveedorTableAdapter.Fill(Me.MAPADataSet.materiales_por_proveedor)
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.materiales_por_proveedor' Puede moverla o quitarla según sea necesario.
        Me.Materiales_por_proveedorTableAdapter.Fill(Me.MAPADataSet.materiales_por_proveedor)

    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        MessageBox.Show("Guardado")
        Me.Materiales_por_proveedorTableAdapter.Insert1(ComboBox1.SelectedValue, ComboBox2.SelectedValue)
        Me.Materiales_por_proveedorTableAdapter.Fill(Me.MAPADataSet.materiales_por_proveedor)
    End Sub
End Class