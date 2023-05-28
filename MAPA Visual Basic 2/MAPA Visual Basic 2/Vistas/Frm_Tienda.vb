Public Class Frm_Tienda
    Private Sub bt_vaciar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Frm_Tienda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.tienda' Puede moverla o quitarla según sea necesario.
        Me.TiendaTableAdapter.Fill(Me.MAPADataSet.tienda)

    End Sub

    Private Sub bt_editar_Click(sender As Object, e As EventArgs) Handles bt_editar.Click
        Panel2.Visible = True
    End Sub
End Class