Imports System.ComponentModel

Public Class Frm_Materiales_Por_Pedido
    Public id_pedido As Integer

    Private Sub Frm_Materiales_Por_Pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Materiales_por_pedidoTableAdapter.Fill(Me.MAPADataSet.materiales_por_pedido, id_pedido)
        lbl_id_pedido.Text = id_pedido
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        MessageBox.Show("Se ha guardado el registro: " & txt_material.Text)

        Me.Materiales_por_pedidoTableAdapter.InsertQuery(txt_material.Text, txt_descripcion.Text, txt_cantidad.Text, cb_unidad_medida.Text, txt_precio_unidad.Text, txt_precio_total.Text, id_pedido)
        Me.Materiales_por_pedidoTableAdapter.Fill(Me.MAPADataSet.materiales_por_pedido, id_pedido)
        vaciar_campos()
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        MessageBox.Show("Se ha editado el registro: " & txt_material.Text)

        Me.Materiales_por_pedidoTableAdapter.Update1(txt_material.Text, txt_descripcion.Text, txt_cantidad.Text, cb_unidad_medida.Text, txt_precio_unidad.Text, txt_precio_total.Text, id_pedido, lbl_id_material.Text)
        Me.Materiales_por_pedidoTableAdapter.Fill(Me.MAPADataSet.materiales_por_pedido, id_pedido)
        vaciar_campos()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        MessageBox.Show("Se ha editado el registro:")
        Me.Materiales_por_pedidoTableAdapter.Delete1(lbl_id_material.Text)
        Me.Materiales_por_pedidoTableAdapter.Fill(Me.MAPADataSet.materiales_por_pedido, id_pedido)
        vaciar_campos()
    End Sub

    Private Sub btn_vaciar_campos_Click(sender As Object, e As EventArgs) Handles btn_vaciar_campos.Click
        vaciar_campos()
    End Sub

    Private Sub vaciar_campos()
        txt_material.Clear()
        txt_descripcion.Clear()
        txt_precio_unidad.Clear()
        txt_cantidad.Clear()
        txt_precio_total.Clear()
        cb_unidad_medida.SelectedIndex = 0
    End Sub
End Class