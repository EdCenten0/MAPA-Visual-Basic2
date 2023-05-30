Public Class Frm_Usuarios
    Private Sub Frm_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.roles' Puede moverla o quitarla según sea necesario.
        Me.RolesTableAdapter.Fill(Me.MAPADataSet.roles)
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.MAPADataSet.usuarios)
        vaciar()
    End Sub

    Private Function vaciar() As String
        Me.txt_usuario.Text = ""
        Me.txt_id.Text = ""
        Me.txt_correo.Text = ""
        Me.txt_clave.Text = ""

        If Not Me.cb_rol.SelectedIndex = -1 Then
            Me.cb_rol.SelectedIndex = 0
        End If

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bt_refrescar_Click_1(sender As Object, e As EventArgs) Handles bt_refrescar.Click
        Me.UsuariosTableAdapter.Fill(Me.MAPADataSet.usuarios)
    End Sub

    Private Sub bt_vaciar_Click(sender As Object, e As EventArgs) Handles bt_vaciar.Click
        vaciar()
    End Sub

    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click

        If Not Me.txt_usuario.Text = "" And Not Me.txt_correo.Text = "" And Not Me.txt_clave.Text = "" Then

            If Me.txt_id.Text = "" Then
                If Me.txt_clave.TextLength >= 8 Then

                    If Me.txt_usuario.TextLength <= 50 Then

                        If Me.txt_clave.TextLength <= 50 Then

                            If Me.txt_correo.TextLength <= 50 Then
                                MessageBox.Show("Se ha guardado el usuario: " & txt_usuario.Text)
                                Me.UsuariosTableAdapter.Guardar(txt_usuario.Text, txt_clave.Text, txt_correo.Text, cb_rol.SelectedValue)
                                Me.UsuariosTableAdapter.Fill(Me.MAPADataSet.usuarios)
                                vaciar()

                            Else
                                MessageBox.Show("Error de correo electronico, debe tener menos de 50 caracteres")
                            End If

                        Else
                            MessageBox.Show("Error de contraseña, debe tener menos de 50 caracteres")
                        End If

                    Else
                        MessageBox.Show("Error de nombre de usuario, debe tener menos de 50 caracteres")
                    End If

                Else
                    MessageBox.Show("La contraseña debe tener más de 8 caracteres")
                End If

            Else
                MessageBox.Show("No se puede guardar un registro con ese id existente")
            End If

        Else
            MessageBox.Show("Llene los campos vacios")
        End If


    End Sub

    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click

        If Not Me.txt_id.Text = "" Then
            MessageBox.Show("Se ha eliminado el usuario: " & txt_usuario.Text)
            Me.UsuariosTableAdapter.Eliminar(Me.txt_id.Text)
            Me.UsuariosTableAdapter.Fill(Me.MAPADataSet.usuarios)
            vaciar()

        Else
            MessageBox.Show("Seleccione al usuario a eliminar")
        End If

    End Sub

    Private Sub bt_editar_Click(sender As Object, e As EventArgs) Handles bt_editar.Click

        If Not Me.txt_usuario.Text = "" And Not Me.txt_correo.Text = "" And Not Me.txt_clave.Text = "" Then

            If Not Me.txt_id.Text = "" Then

                If Me.txt_clave.TextLength >= 8 Then

                    If Me.txt_usuario.TextLength <= 50 Then

                        If Me.txt_clave.TextLength <= 50 Then

                            If Me.txt_correo.TextLength <= 50 Then
                                MessageBox.Show("Se ha editado el usuario: " & txt_usuario.Text)
                                Me.UsuariosTableAdapter.Editar(txt_usuario.Text, txt_clave.Text, txt_correo.Text, cb_rol.SelectedValue, txt_id.Text, txt_id.Text)
                                Me.UsuariosTableAdapter.Fill(Me.MAPADataSet.usuarios)
                                vaciar()

                            Else
                                MessageBox.Show("Error de correo electronico, debe tener menos de 50 caracteres")
                            End If

                        Else
                            MessageBox.Show("Error de contraseña, debe tener menos de 50 caracteres")
                        End If

                    Else
                        MessageBox.Show("Error de nombre de usuario, debe tener menos de 50 caracteres")
                    End If

                Else
                    MessageBox.Show("La contraseña debe tener más de 8 caracteres")
                End If

            Else
                MessageBox.Show("Seleccione el registro a editar")
            End If



        Else
            MessageBox.Show("Llene los campos vacios")
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles bt_buscar.Click
        Me.UsuariosTableAdapter.Buscar(Me.MAPADataSet.usuarios, Me.txt_buscar.Text)
    End Sub
End Class