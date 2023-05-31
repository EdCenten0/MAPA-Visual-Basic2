Public Class Frm_Rol

    Private Sub Frm_Rol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.roles' Puede moverla o quitarla según sea necesario.
        Me.RolesTableAdapter.Fill(Me.MAPADataSet.roles)
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.RolesTableAdapter.Fill(Me.MAPADataSet.roles)
        vaciar()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click

        If Me.txt_id.Text = "" Then

            If comprobar() Then
                MessageBox.Show("Se ha guardo el rol:  " & txt_rol.Text)
                Me.RolesTableAdapter.Guardar(Me.txt_rol.Text)
                Me.RolesTableAdapter.Fill(Me.MAPADataSet.roles)
                vaciar()

            End If

        Else
            MessageBox.Show("No se puede guardar el rol con ese id existente")
        End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click

        If Not Me.txt_id.Text = "" Then

            MessageBox.Show("Se ha eliminado el rol: " & txt_rol.Text)
            Me.RolesTableAdapter.Eliminar(Me.txt_id.Text)
            Me.RolesTableAdapter.Fill(Me.MAPADataSet.roles)
            vaciar()

        Else
            MessageBox.Show("Seleccione el rol a eliminar")

        End If

    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles bt_refrescar.Click
        Me.RolesTableAdapter.Fill(Me.MAPADataSet.roles)
    End Sub


    Private Function vaciar() As String
        Me.txt_id.Text = ""
        Me.txt_rol.Text = ""
    End Function


    Private Sub bt_editar_Click(sender As Object, e As EventArgs) Handles bt_editar.Click

        If Not Me.txt_id.Text = "" Then

            If comprobar() Then
                MessageBox.Show("Se ha editado el rol: " & txt_rol.Text)
                Me.RolesTableAdapter.Editar(Me.txt_rol.Text, Me.txt_id.Text, Me.txt_id.Text)
                Me.RolesTableAdapter.Fill(Me.MAPADataSet.roles)
                vaciar()
            End If

        Else
            MessageBox.Show("Seleccione el rol a editar")

        End If


    End Sub

    Private Sub bt_vaciar_Click(sender As Object, e As EventArgs) Handles bt_vaciar.Click
        vaciar()
    End Sub

    Private Function comprobar() As Boolean
        Dim valido As Boolean = False

        If Not Me.txt_rol.Text = "" Then

            If Me.txt_rol.TextLength <= 50 Then
                valido = True

            Else
                MessageBox.Show("El rol debe tener menos de 50 caracteres")

            End If

        Else
            MessageBox.Show("El campo de rol esta vacio")

        End If

        Return valido

    End Function


    Private Sub bt_buscar_Click(sender As Object, e As EventArgs) Handles bt_buscar.Click
        Me.RolesTableAdapter.Buscar(Me.MAPADataSet.roles, Me.txt_buscar.Text)
    End Sub
End Class