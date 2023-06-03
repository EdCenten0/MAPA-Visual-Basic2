Public Class Frm_Tienda
    Private Sub bt_vaciar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Frm_Tienda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.tienda' Puede moverla o quitarla según sea necesario.
        Me.TiendaTableAdapter.Fill(Me.MAPADataSet.tienda)
        txt_rol.Text = lbl_nombre.Text
        TextBox1.Text = lbl_direccion.Text
        TextBox2.Text = lbl_telefono.Text
        TextBox3.Text = lbl_email.Text
        txt_id.Text = lbl_id.Text

    End Sub

    Private Sub bt_editar_Click(sender As Object, e As EventArgs) Handles bt_editar.Click
        Panel2.Visible = True
    End Sub

    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
        Me.TiendaTableAdapter.Editar(txt_rol.Text, TextBox1.Text, TextBox2.Text, TextBox3.Text, 1, txt_id.Text)
        Me.TiendaTableAdapter.Fill(Me.MAPADataSet.tienda)
    End Sub

    Private Sub bt_vaciar_Click_1(sender As Object, e As EventArgs) Handles bt_vaciar.Click
        txt_rol.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        txt_id.Text = ""
    End Sub
End Class