﻿Public Class Frm_Materiales
    Private Sub Frm_Materiales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.materiales' Puede moverla o quitarla según sea necesario.
        Me.MaterialesTableAdapter.Fill(Me.MAPADataSet.materiales)





        cb_unidad_medida.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click

        Dim mult As Double

        mult = (txt_precio_unidad.Text * txt_cantidad.Text)




        MessageBox.Show("Se ha guardado el registro: " & txt_material.Text)

        Me.MaterialesTableAdapter.Guardar(txt_material.Text, txt_descripcion.Text, txt_cantidad.Text, cb_unidad_medida.SelectedItem, txt_precio_unidad.Text, mult, 2)
        Me.MaterialesTableAdapter.Fill(Me.MAPADataSet.materiales)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_editar.Click

        Dim mult As Double

        mult = (txt_precio_unidad.Text * txt_cantidad.Text).ToString

        MessageBox.Show("Se ha editado el registro: " & txt_material.Text)

        Me.MaterialesTableAdapter.Editar(txt_material.Text, txt_descripcion.Text, txt_cantidad.Text, cb_unidad_medida.SelectedItem, txt_precio_unidad.Text, mult, 2, lbl_id.Text, lbl_id.Text)
        Me.MaterialesTableAdapter.Fill(Me.MAPADataSet.materiales)

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click

        MessageBox.Show("Se ha eliminado el registro: " & txt_material.Text)

        Me.MaterialesTableAdapter.Eliminar(lbl_id.Text)
        Me.MaterialesTableAdapter.Fill(Me.MAPADataSet.materiales)

    End Sub

    Private Sub btn_vaciar_campos_Click(sender As Object, e As EventArgs) Handles btn_vaciar_campos.Click
        txt_material.Clear()
        txt_descripcion.Clear()
        txt_precio_unidad.Clear()
        txt_cantidad.Clear()
        txt_precio_total.Clear()


    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        Me.MaterialesTableAdapter.Fill(Me.MAPADataSet.materiales)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.MaterialesTableAdapter.Buscar(Me.MAPADataSet.materiales, txtBuscar.Text)
    End Sub
End Class
