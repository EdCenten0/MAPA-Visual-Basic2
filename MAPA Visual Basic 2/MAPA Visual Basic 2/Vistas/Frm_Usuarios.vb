Public Class Frm_Usuarios
    Private Sub Frm_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.roles' Puede moverla o quitarla según sea necesario.
        Me.RolesTableAdapter.Fill(Me.MAPADataSet.roles)
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.MAPADataSet.usuarios)
        vaciar()
    End Sub

    Private Function vaciar() As String
        Me.txt_usuario.Text = ""
        Me.txt_id.Text = ""
        Me.txt_correo.Text = ""
        Me.txt_clave.Text = ""
        Me.cb_rol.SelectedIndex = 0
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bt_refrescar_Click_1(sender As Object, e As EventArgs) Handles bt_refrescar.Click
        Me.UsuariosTableAdapter.Fill(Me.MAPADataSet.usuarios)
    End Sub

    Private Sub bt_vaciar_Click(sender As Object, e As EventArgs) Handles bt_vaciar.Click
        vaciar()
    End Sub

    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
        MessageBox.Show("Se ha guardado el usuario: " & txt_usuario.Text)
        Me.UsuariosTableAdapter.Guardar(txt_usuario.Text, txt_clave.Text, txt_correo.Text, cb_rol.SelectedValue)
        Me.UsuariosTableAdapter.Fill(Me.MAPADataSet.usuarios)
    End Sub

    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        MessageBox.Show("Se ha eliminado el usuario: " & txt_usuario.Text)
        Me.UsuariosTableAdapter.Eliminar(txt_id.Text)
        Me.UsuariosTableAdapter.Fill(Me.MAPADataSet.usuarios)
    End Sub

    Private Sub bt_editar_Click(sender As Object, e As EventArgs) Handles bt_editar.Click
        MessageBox.Show("Se ha editado el usuario: " & txt_usuario.Text)
        Me.UsuariosTableAdapter.Editar(txt_usuario.Text, txt_clave.Text, txt_correo.Text, cb_rol.SelectedValue, txt_id.Text, txt_id.Text)
        Me.UsuariosTableAdapter.Fill(Me.MAPADataSet.usuarios)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class