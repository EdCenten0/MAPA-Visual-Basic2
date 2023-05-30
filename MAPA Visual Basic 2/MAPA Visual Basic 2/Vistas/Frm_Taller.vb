Public Class Frm_Taller
    Private Sub Frm_Taller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.taller' Puede moverla o quitarla según sea necesario.
        Me.TallerTableAdapter.Fill(Me.MAPADataSet.taller)

    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click

        MessageBox.Show("Se ha guardado el registro: " & txtNombre.Text)

        Me.TallerTableAdapter.Guardar(txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text, 1)
        Me.TallerTableAdapter.Fill(Me.MAPADataSet.taller)

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click

        MessageBox.Show("Se ha eliminado el registro: " & txtNombre.Text)

        Me.TallerTableAdapter.Eliminar(lblId.Text)
        Me.TallerTableAdapter.Fill(Me.MAPADataSet.taller)

    End Sub

    Private Sub btn_vaciar_campos_Click(sender As Object, e As EventArgs) Handles btn_vaciar_campos.Click
        txtNombre.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
        txtEmail.Clear()
    End Sub

    Private Sub btn_editar_Click_1(sender As Object, e As EventArgs) Handles btn_editar.Click
        MessageBox.Show("Se ha editado el registro: " & txtNombre.Text)

        Me.TallerTableAdapter.Editar(txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text, 1, lblId.Text, lblId.Text)
        Me.TallerTableAdapter.Fill(Me.MAPADataSet.taller)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.TallerTableAdapter.Buscar(Me.MAPADataSet.taller, Me.txtBuscar.Text)
    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        Me.TallerTableAdapter.Fill(Me.MAPADataSet.taller)
    End Sub
End Class