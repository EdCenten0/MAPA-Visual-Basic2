Imports System.Data.SqlClient

Public Class Frm_Cuadro_de_Factura
    Public precio_total As Double
    Public precio_materiales As Double
    Public mano_de_obra As Double
    Public fecha As String
    Public id_pedido As Integer


    Private Sub rellenarCampos()
        buscarPedido()
        sumarMateriales()
        Label10.Text = Date.Now
        fecha = Label10.Text

    End Sub

    Private Function buscarPedido()
        Dim connectionString As String = Frm_Principal.conexionString
        Dim query As String = "SELECT descripcion FROM pedidos WHERE id_pedido = @param1"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.Add("@param1", SqlDbType.Int).Value = Convert.ToInt32(id_pedido)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    Dim descripcion As String = reader.GetString(0)
                    Label6.Text = descripcion
                End If

                reader.Close()
                connection.Close()
            End Using
        End Using
    End Function

    Private Function sumarMateriales()
        Dim connectionString As String = "Data Source=CARLOSCent;Initial Catalog=MAPA;User Id=sa; Password=1234"
        Dim query As String = "SELECT SUM(precio_total) FROM materiales WHERE id_pedido = @param1"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.Add("@param1", SqlDbType.Int).Value = Convert.ToInt32(id_pedido)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                Try
                    If reader.Read() Then
                        Dim precio_materiales As Double = reader.GetDouble(0)
                        Label7.Text = precio_materiales
                        Me.precio_materiales = precio_materiales
                    End If
                Catch ex As Exception
                    MsgBox("El pedido no tiene materiales, agregue al menos uno")
                End Try


                reader.Close()
                connection.Close()
            End Using
        End Using
    End Function
    Private Sub Frm_Cuadro_de_Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rellenarCampos()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Try
            Label9.Text = Double.Parse(Label7.Text) + Double.Parse(TextBox1.Text)
            Me.precio_total = Double.Parse(Label9.Text)
            Me.mano_de_obra = Double.Parse(TextBox1.Text)
        Catch ex As Exception
            MsgBox("Por favor, digite solamente números")
        End Try


    End Sub

    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
        Dim connectionString As String = "Data Source=CARLOSCent;Initial Catalog=MAPA;User Id=sa; Password=1234"
        Dim query As String = "INSERT INTO [dbo].[facturas] ([precio_total], [precio_materiales], [mano_de_obra], [fecha], [id_pedido]) VALUES (@precio_total, @precio_materiales, @mano_de_obra, @fecha, @id_pedido);"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                command.Parameters.Add("@precio_total", Me.precio_total)
                command.Parameters.Add("@precio_materiales", Me.precio_materiales)
                command.Parameters.Add("@mano_de_obra", Me.mano_de_obra)
                command.Parameters.Add("@fecha", Me.fecha)
                command.Parameters.Add("@id_pedido", Me.id_pedido)

                command.ExecuteNonQuery()
                connection.Close()
            End Using
        End Using
        MsgBox("Factura guardada")
    End Sub
End Class