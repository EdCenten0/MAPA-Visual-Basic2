Public Class Frm_Rol

    Private Sub Frm_Rol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.roles' Puede moverla o quitarla según sea necesario.
        Me.RolesTableAdapter.Fill(Me.MAPADataSet.roles)
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.RolesTableAdapter.Fill(Me.MAPADataSet.roles)
        vaciar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
        MessageBox.Show("Se ha guardo el rol:  " & txt_rol.Text)
        Me.RolesTableAdapter.Guardar(Me.txt_rol.Text)
        Me.RolesTableAdapter.Fill(Me.MAPADataSet.roles)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        MessageBox.Show("Se ha eliminado el rol: " & txt_rol.Text)
        Me.RolesTableAdapter.Eliminar(Me.txt_id.Text)
        Me.RolesTableAdapter.Fill(Me.MAPADataSet.roles)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles bt_refrescar.Click
        Me.RolesTableAdapter.Fill(Me.MAPADataSet.roles)
    End Sub

    Private Function vaciar() As String
        Me.txt_id.Text = ""
        Me.txt_rol.Text = ""
    End Function

    Private Sub bt_editar_Click(sender As Object, e As EventArgs) Handles bt_editar.Click
        MessageBox.Show("Se ha editado el rol: " & txt_rol.Text)
        Me.RolesTableAdapter.Editar(Me.txt_rol.Text, Me.txt_id.Text, Me.txt_id.Text)
        Me.RolesTableAdapter.Fill(Me.MAPADataSet.roles)
    End Sub

    Private Sub bt_vaciar_Click(sender As Object, e As EventArgs) Handles bt_vaciar.Click
        vaciar()
    End Sub
End Class