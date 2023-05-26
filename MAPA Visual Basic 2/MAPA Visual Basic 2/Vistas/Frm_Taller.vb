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




End Class