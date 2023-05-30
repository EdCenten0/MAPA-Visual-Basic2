
Imports System.Data.SqlClient

Public Class Frm_Materiales_Por_Proveedor
    Private Sub Frm_Materiales_Por_Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.MAPADataSet.proveedores)
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.materiales_por_proveedor' Puede moverla o quitarla según sea necesario.
        Me.Materiales_por_proveedorTableAdapter.Fill(Me.MAPADataSet.materiales_por_proveedor)
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.materiales_por_proveedor' Puede moverla o quitarla según sea necesario.
        Me.Materiales_por_proveedorTableAdapter.Fill(Me.MAPADataSet.materiales_por_proveedor)
        llenarComboboxMateriales()
        llenarComboBoxProveedores()


    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        MessageBox.Show("Guardado")
        Me.Materiales_por_proveedorTableAdapter.Insert1(ComboBox1.SelectedValue, ComboBox2.SelectedValue)
        Me.Materiales_por_proveedorTableAdapter.Fill(Me.MAPADataSet.materiales_por_proveedor)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Label5.Text = ComboBox2.SelectedItem.get_id_material()
    End Sub

    Private Class Material
        Private id_material As Int32
        Private nombre_material As String

        Public Sub New(id_material As Int32, nombre_material As String)
            Me.id_material = id_material
            Me.nombre_material = nombre_material
        End Sub

        Public Function get_id_material()
            Return Me.id_material
        End Function

        Public Function get_nombre_material()
            Return Me.nombre_material
        End Function

        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub

        Public Overrides Function ToString() As String
            Return Me.nombre_material
        End Function

        Public Overrides Function Equals(obj As Object) As Boolean
            Return MyBase.Equals(obj)
        End Function

        Public Overrides Function GetHashCode() As Integer
            Return MyBase.GetHashCode()
        End Function
    End Class

    Private Function llenarComboboxMateriales()
        Dim connectionString As String = "Data Source=CARLOSCent;Initial Catalog=MAPA;User Id=sa; Password=1234"
        Dim query As String = "SELECT id_material, nombre_material FROM materiales"

        'Creo las variables que quiero que almacenen los datos de la consulta
        Dim id_material As Integer
        Dim nombre_material As String

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)

                'Abro la conexion y preparo el reader
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                'Leo los registros de mi reader para introducirlos en las variables creadas

                Do While reader.Read
                    id_material = reader.GetInt32(0)
                    nombre_material = reader.GetString(1)
                    Me.ComboBox2.Items.Add(New Material(id_material, nombre_material))

                Loop

                'Cierro los recursos de conexion abiertos
                reader.Close()
                connection.Close()
            End Using
        End Using
    End Function

    Private Class Proveedor
        Private id_proveedor As Integer
        Private nombre As String

        Public Sub New(id_proveedor As Integer, nombre As String)
            Me.id_proveedor = id_proveedor
            Me.nombre = nombre
        End Sub

        Public Function get_id_proveedor()
            Return Me.id_proveedor
        End Function

        Public Function get_nombre()
            Return Me.nombre
        End Function

        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub

        Public Overrides Function ToString() As String
            Return Me.nombre
        End Function

        Public Overrides Function Equals(obj As Object) As Boolean
            Return MyBase.Equals(obj)
        End Function

        Public Overrides Function GetHashCode() As Integer
            Return MyBase.GetHashCode()
        End Function


    End Class


    Private Function llenarComboBoxProveedores()
        Dim connectionString As String = "Data Source=CARLOSCent;Initial Catalog=MAPA;User Id=sa; Password=1234"
        Dim query As String = "SELECT id_proveedor, nombre FROM proveedores"

        'Creo las variables que quiero que almacenen los datos de la consulta
        Dim id_proveedor As Integer
        Dim nombre As String

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)

                'Abro la conexion y preparo el reader
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                'Leo los registros de mi reader para introducirlos en las variables creadas

                Do While reader.Read
                    id_proveedor = reader.GetInt32(0)
                    nombre = reader.GetString(1)
                    ComboBox1.Items.Add(New Proveedor(id_proveedor, nombre))

                Loop

                'Cierro los recursos de conexion abiertos
                reader.Close()
                connection.Close()
            End Using
        End Using
    End Function

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label6.Text = ComboBox1.SelectedItem.get_id_proveedor()
    End Sub
End Class


