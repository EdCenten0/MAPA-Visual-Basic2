Public Class Frm_Proveedores
    Private Sub Frm_Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.MAPADataSet.proveedores)

    End Sub

    Private Sub bt_refrescar_Click(sender As Object, e As EventArgs) Handles bt_refrescar.Click
        Me.ProveedoresTableAdapter.Fill(Me.MAPADataSet.proveedores)
    End Sub

    Private Function vaciar() As String
        Me.Textbox_id.Text = ""
        Me.Textbox_nombre.Text = ""
        Me.Textbox_direccion.Text = ""
        Me.Textbox_email.Text = ""
        Me.Textbox_telefono.Text = ""
        Me.Textbox_catalogo.Text = ""
        Me.Textbox_ruc.Text = ""

    End Function

    Private Sub bt_vaciar_Click(sender As Object, e As EventArgs) Handles bt_vaciar.Click
        vaciar()
    End Sub

    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
        MessageBox.Show("Se ha guardado el proveedor: " & Textbox_nombre.Text)
        Me.ProveedoresTableAdapter.Guardar(Me.Textbox_nombre.Text, Me.Textbox_email.Text, Me.Textbox_telefono.Text, Me.Textbox_catalogo.Text, Me.Textbox_ruc.Text, Me.Textbox_direccion.Text, 1)
        Me.ProveedoresTableAdapter.Fill(Me.MAPADataSet.proveedores)
    End Sub

    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        MessageBox.Show("Se ha eliminado el proveedor: " & Textbox_nombre.Text)
        Me.ProveedoresTableAdapter.Eliminar(Me.Textbox_id.Text)
        Me.ProveedoresTableAdapter.Fill(Me.MAPADataSet.proveedores)
    End Sub
    Private Sub bt_editar_Click(sender As Object, e As EventArgs) Handles bt_editar.Click
        MessageBox.Show("Se ha editado el proveedor:" & Textbox_nombre.Text)
        Me.ProveedoresTableAdapter.Editar(Me.Textbox_nombre.Text, Me.Textbox_email.Text, Me.Textbox_telefono.Text, Me.Textbox_catalogo.Text, Me.Textbox_ruc.Text, Me.Textbox_direccion.Text, 1, Me.Textbox_id.Text, Me.Textbox_id.Text)
        Me.ProveedoresTableAdapter.Fill(Me.MAPADataSet.proveedores)
    End Sub

End Class