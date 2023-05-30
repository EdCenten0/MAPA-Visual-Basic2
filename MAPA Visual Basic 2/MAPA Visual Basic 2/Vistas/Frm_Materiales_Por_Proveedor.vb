
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
        Me.Materiales_por_proveedorTableAdapter.Insert1(ComboBox1.SelectedItem.get_id_proveedor, ComboBox2.SelectedItem.get_id_material)
        Me.Materiales_por_proveedorTableAdapter.Fill(Me.MAPADataSet.materiales_por_proveedor)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedIndex = -1 Then
            Label5.Text = ""
        Else
            Label5.Text = ComboBox2.SelectedItem.get_id_material()
        End If
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
            If TypeOf obj Is Material Then
                Dim other As Material = DirectCast(obj, Material)
                Return Me.get_id_material() = other.get_id_material()
            End If
            Return False
        End Function

        Public Overrides Function GetHashCode() As Integer
            Return MyBase.GetHashCode()
        End Function
    End Class

    Private Function llenarComboboxMateriales()
        Dim connectionString As String = "Data Source=CARLOSCent;Initial Catalog=MAPA;User Id=sa; Password=1234"
        Dim query As String = "SELECT id_material, nombre_material FROM materiales"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                Do While reader.Read
                    Dim id_material As Integer = reader.GetInt32(0)
                    Dim nombre_material As String = reader.GetString(1)
                    ComboBox2.Items.Add(New Material(id_material, nombre_material))
                Loop

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
            If TypeOf obj Is Proveedor Then
                Dim other As Proveedor = DirectCast(obj, Proveedor)
                Return Me.get_id_proveedor() = other.get_id_proveedor()
            End If
            Return False
        End Function


        Public Overrides Function GetHashCode() As Integer
            Return MyBase.GetHashCode()
        End Function


    End Class


    Private Function llenarComboBoxProveedores()
        Dim connectionString As String = "Data Source=CARLOSCent;Initial Catalog=MAPA;User Id=sa; Password=1234"
        Dim query As String = "SELECT id_proveedor, nombre FROM proveedores"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                Do While reader.Read
                    Dim id_proveedor As Integer = reader.GetInt32(0)
                    Dim nombre As String = reader.GetString(1)
                    ComboBox1.Items.Add(New Proveedor(id_proveedor, nombre))
                Loop

                reader.Close()
                connection.Close()
            End Using
        End Using
    End Function


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = -1 Then
            Label6.Text = ""
        Else
            Label6.Text = ComboBox1.SelectedItem.get_id_proveedor()
        End If

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        MessageBox.Show("Se eliminó la relación entre: " & ComboBox2.SelectedItem.get_nombre_material & " y " & ComboBox1.SelectedItem.get_nombre)
        Me.Materiales_por_proveedorTableAdapter.DeleteQuery(DataGridView1.CurrentRow.Cells(0).Value.ToString())
        Me.Materiales_por_proveedorTableAdapter.Fill(Me.MAPADataSet.materiales_por_proveedor)
        vaciarComboBoxes()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim id_material_tabla As Integer
        Dim id_proveedor_tabla As Integer


        If Integer.TryParse(DataGridView1.CurrentRow.Cells(1).Value.ToString(), id_proveedor_tabla) AndAlso
        Integer.TryParse(DataGridView1.CurrentRow.Cells(2).Value.ToString(), id_material_tabla) Then

            For Each material As Material In ComboBox2.Items
                If material.get_id_material() = id_material_tabla Then
                    ComboBox2.SelectedItem = material
                    Exit For
                End If
            Next

            For Each proveedor As Proveedor In ComboBox1.Items
                If proveedor.get_id_proveedor() = id_proveedor_tabla Then
                    ComboBox1.SelectedItem = proveedor
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub vaciarComboBoxes()
        Me.ComboBox1.SelectedIndex = -1
        Me.ComboBox2.SelectedIndex = -1
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        MsgBox("Registro editado")
        Me.Materiales_por_proveedorTableAdapter.UpdateQuery(Label6.Text, Label5.Text, DataGridView1.CurrentRow.Cells(0).Value.ToString())
        Me.Materiales_por_proveedorTableAdapter.Fill(Me.MAPADataSet.materiales_por_proveedor)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btn_vaciar_campos_Click(sender As Object, e As EventArgs) Handles btn_vaciar_campos.Click
        vaciarComboBoxes()
    End Sub
End Class


