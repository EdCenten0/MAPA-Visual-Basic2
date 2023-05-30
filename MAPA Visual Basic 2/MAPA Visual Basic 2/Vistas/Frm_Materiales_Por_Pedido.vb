Imports System.ComponentModel

Public Class Frm_Materiales_Por_Pedido
    Public id_pedido As Integer

    Private Sub Frm_Materiales_Por_Pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Materiales_por_pedidoTableAdapter.Fill(Me.MAPADataSet.materiales_por_pedido, id_pedido)

    End Sub
End Class