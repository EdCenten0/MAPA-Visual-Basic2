Imports System.Data.SqlClient

Public Class Frm_Pedido
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Frm_Pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.estados' Puede moverla o quitarla según sea necesario.
        Me.EstadosTableAdapter.Fill(Me.MAPADataSet.estados)
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.pedidos' Puede moverla o quitarla según sea necesario.
        Me.PedidosTableAdapter.Fill(Me.MAPADataSet.pedidos)
        ComboBox1.SelectedIndex = -1
        llenarComboBoxClientes()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Class Cliente
        Private id_cliente As Integer
        Private nombre As String
        Private apellido As String

        Public Sub New(id_cliente As Integer, nombre As String, apellido As String)
            Me.id_cliente = id_cliente
            Me.nombre = nombre
            Me.apellido = apellido
        End Sub

        Public Function get_id_cliente()
            Return Me.id_cliente
        End Function


        Public Function get_nomrbre()
            Return Me.nombre
        End Function

        Public Function get_apellido()
            Return Me.apellido
        End Function

        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub

        Public Overrides Function ToString() As String
            Return Me.nombre & " " & Me.apellido
        End Function

        Public Overrides Function Equals(obj As Object) As Boolean
            If TypeOf obj Is Cliente Then
                Dim other As Cliente = DirectCast(obj, Cliente)
                Return Me.get_id_cliente() = other.get_id_cliente()
            End If
            Return False
        End Function

        Public Overrides Function GetHashCode() As Integer
            Return MyBase.GetHashCode()
        End Function
    End Class



    Private Function llenarComboBoxClientes()
            Dim connectionString As String = "Data Source=CARLOSCent;Initial Catalog=MAPA;User Id=sa; Password=1234"
            Dim query As String = "SELECT id_cliente, nombre, apellido FROM clientes"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                Do While reader.Read
                    Dim id_cliente As Integer = reader.GetInt32(0)
                    Dim nombre As String = reader.GetString(1)
                    Dim apellido As String = reader.GetString(2)
                    ComboBox2.Items.Add(New Cliente(id_cliente, nombre, apellido))
                Loop

                reader.Close()
                connection.Close()
            End Using
        End Using
    End Function

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedIndex = -1 Then
            tb_index.Text = ""
        Else
            tb_index.Text = ComboBox2.SelectedItem.get_id_cliente()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim id_cliente_tabla As Integer



        If Integer.TryParse(DataGridView1.CurrentRow.Cells(3).Value.ToString(), id_cliente_tabla) Then

            For Each cliente As Cliente In ComboBox2.Items
                If cliente.get_id_cliente() = id_cliente_tabla Then
                    ComboBox2.SelectedItem = cliente
                    Exit For
                End If
            Next
        End If

    End Sub
End Class