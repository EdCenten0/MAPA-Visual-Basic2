Imports System.Data.SqlClient

Public Class Frm_Facturas
    Private Sub Frm_Facturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.facturas' Puede moverla o quitarla según sea necesario.
        Me.FacturasTableAdapter.Fill(Me.MAPADataSet.facturas)
        vaciarCampos()

    End Sub

    Private Sub Label7_TextChanged(sender As Object, e As EventArgs) Handles Label7.TextChanged
        Dim connectionString As String = "Data Source=CARLOSCent;Initial Catalog=MAPA;User Id=sa; Password=1234"
        Dim query As String = "SELECT descripcion FROM pedidos WHERE id_pedido = @param1"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.Add("@param1", Label7.Text)
                connection.Open()
                Dim descripcion As String
                Dim reader As SqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    descripcion = reader.GetString(0)
                    Console.WriteLine(descripcion)



                End If

                pedido_descripcion.Text = descripcion

                reader.Close()
                connection.Close()
            End Using
        End Using
    End Sub

    Private Sub bt_vaciar_Click(sender As Object, e As EventArgs) Handles bt_vaciar.Click
        vaciarCampos()
    End Sub

    Private Sub vaciarCampos()
        txt_id.Text = ""
        pedido_descripcion.Text = ""
        txt_buscar.Text = ""
        txt_rol.Text = ""
        TextBox1.Text = ""
        Label7.Text = ""
        DateTimePicker1.ResetText()
    End Sub

    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        Dim connectionString As String = "Data Source=CARLOSCent;Initial Catalog=MAPA;User Id=sa; Password=1234"
        Dim query As String = "DELETE FROM facturas WHERE id_factura = @param1"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.Add("@param1", txt_id.Text)
                connection.Open()
                command.ExecuteNonQuery()


                connection.Close()
            End Using
        End Using
        MsgBox("Registro eliminado")
        Me.FacturasTableAdapter.Fill(Me.MAPADataSet.facturas)
    End Sub

    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
        Dim connectionString As String = "Data Source=CARLOSCent;Initial Catalog=MAPA;User Id=sa; Password=1234"
        Dim query As String = "INSERT INTO ventas(cantidad, descripcion, id_tienda, id_factura) VALUES(@cantidad, @descripcion, 1, @id_factura);"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.Add("@cantidad", TextBox2.Text)
                command.Parameters.Add("@descripcion", pedido_descripcion.Text)
                command.Parameters.Add("@id_factura", txt_id.Text)
                connection.Open()
                command.ExecuteNonQuery()


                connection.Close()
            End Using
        End Using

        MsgBox("Registro de la factura " & txt_id.Text & " guardado como venta")
    End Sub
End Class