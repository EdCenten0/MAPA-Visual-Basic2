Public Class Frm_Materiales
    Private Sub Frm_Materiales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.materiales' Puede moverla o quitarla según sea necesario.
        Me.MaterialesTableAdapter.Fill(Me.MAPADataSet.materiales)





        cb_unidad_medida.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click

        Dim mult As Double

        mult = (txt_precio_unidad.Text * txt_cantidad.Text).ToString

        MessageBox.Show("Se ha guardado el registro: " & txt_material.Text)

        Me.MaterialesTableAdapter.Guardar(txt_material.Text, txt_descripcion.Text, txt_cantidad.Text, cb_unidad_medida.SelectedItem, txt_precio_unidad.Text, mult, 2)
        Me.MaterialesTableAdapter.Fill(Me.MAPADataSet.materiales)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_editar.Click

        MessageBox.Show("Se ha editado el registro: " & txt_material.Text)

        'Me.MaterialesTableAdapter.Editar(txt_material.Text, txt_descripcion.Text, txt_cantidad.Text, "mts", txt_precio_unidad.Text, txt_precio_total.Text, lblId.Text, lblId.Text)
        'Me.MaterialesTableAdapter.Fill(Me.MAPADataSet.materiales)

    End Sub

    Private Sub lbl_material_Click(sender As Object, e As EventArgs) Handles lbl_material.Click

    End Sub

    Private Sub lbl_cantidad_Click(sender As Object, e As EventArgs) Handles lbl_cantidad.Click

    End Sub
End Class
