Imports System.Data.SqlClient

Public Class Frm_Vista_Previa_Pedidos

    Private currentForm As Form = Nothing
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        abrirFromularioHijo(New Frm_Pedido())
    End Sub

    Private Sub abrirFromularioHijo(formHijo As Form)
        If currentForm IsNot Nothing Then
            currentForm.Close()
        End If
        currentForm = formHijo
        currentForm.TopLevel = False
        currentForm.FormBorderStyle = FormBorderStyle.None
        currentForm.Dock = DockStyle.Fill
        Frm_Principal.panel_contenedor.Controls.Add(currentForm)
        Frm_Principal.panel_contenedor.Tag = currentForm
        currentForm.BringToFront()
        currentForm.Show()
    End Sub


    Private Sub tb_index_TextChanged(sender As Object, e As EventArgs)
        If Not String.IsNullOrEmpty(tb_index.Text) Then
            ' Obtener el id_cliente del TextBox
            Dim idCliente As Integer = Convert.ToInt32(tb_index.Text)


            ' Obtener el nombre y apellido del cliente
            Dim nombreApellido As String = ObtenerNombreApellidoCliente(idCliente)

            ' Mostrar el nombre y apellido en el TextBox
            tb_cliente.Text = nombreApellido
        Else
            ' Limpiar el TextBox si el valor está vacío
            tb_cliente.Text = ""
        End If
    End Sub

    Private Function ObtenerNombreApellidoCliente(idCliente As Integer) As String
        ' Configurar la conexión a la base de datos
        Dim connectionString As String = "Data Source=CARLOSCent;Initial Catalog=MAPA;User Id=sa; Password=1234"
        Dim query As String = "SELECT nombre, apellido FROM clientes WHERE id_cliente = @idCliente"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Configurar el parámetro
                command.Parameters.AddWithValue("@idCliente", idCliente)

                ' Abrir la conexión y ejecutar la consulta
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                Dim nombreApellido As String = ""

                ' Leer el registro y obtener el nombre y apellido
                If reader.Read() Then
                    Dim nombre As String = reader.GetString(0)
                    Dim apellido As String = reader.GetString(1)
                    nombreApellido = nombre & " " & apellido
                End If

                ' Cerrar el lector y la conexión
                reader.Close()
                connection.Close()

                Return nombreApellido
            End Using
        End Using
    End Function

    Private Sub Frm_Vista_Previa_Pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.pedidos' Puede moverla o quitarla según sea necesario.
        Me.PedidosTableAdapter.Fill(Me.MAPADataSet.pedidos)
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet1.pedidos' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.pedidos' Puede moverla o quitarla según sea necesario.
        Me.PedidosTableAdapter.Fill(Me.MAPADataSet.pedidos)
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.clientes' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.pedidos' Puede moverla o quitarla según sea necesario.
        Me.PedidosTableAdapter.Fill(Me.MAPADataSet.pedidos)
        cb_seleccion_pedido.DropDownStyle = ComboBoxStyle.DropDownList



    End Sub

    Private Function obtenerMaterialesAgregados()
        Dim connectionString As String = "Data Source=CARLOSCent;Initial Catalog=MAPA;User Id=sa; Password=1234"
        Dim query As String = "SELECT COUNT(id_pedido) FROM materiales WHERE id_pedido = @id_pedido"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Configurar el parámetro
                Dim si As Integer = cb_seleccion_pedido.SelectedValue
                Console.WriteLine(cb_seleccion_pedido.SelectedValue)
                command.Parameters.Add("@id_pedido", SqlDbType.Int).Value = Convert.ToInt32(cb_seleccion_pedido.SelectedValue)

                ' Abrir la conexión y ejecutar la consulta
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                Dim cantidadMateriales As Integer

                ' Leer el registro y obtener el nombre y apellido
                If reader.Read() Then
                    Dim cantidad As Integer = reader.GetInt32(0)
                    cantidadMateriales = cantidad
                End If

                ' Cerrar el lector y la conexión
                reader.Close()
                connection.Close()

                Return cantidadMateriales
            End Using
        End Using
    End Function





    Private Sub Label6_MouseEnter(sender As Object, e As EventArgs)
        lb_materiales_agregados.ForeColor = Color.Blue
    End Sub

    Private Sub Label6_MouseLeave(sender As Object, e As EventArgs)
        lb_materiales_agregados.ForeColor = Color.Black
    End Sub

    Private Sub bt_agregar_materiales_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cb_seleccion_pedido_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_seleccion_pedido.SelectedIndexChanged
        lb_materiales_agregados.Text = obtenerMaterialesAgregados() & " materiales agregados..."
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class