Public Class Frm_Agregar_Usuario
    Private Sub Frm_Agregar_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.roles' Puede moverla o quitarla según sea necesario.
        Me.RolesTableAdapter.Fill(Me.MAPADataSet.roles)
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.MAPADataSet.usuarios)
        txt_clave.PasswordChar = "*"


    End Sub

    Private Sub bt_registrar_Click(sender As Object, e As EventArgs) Handles bt_registrar.Click


        If Not Me.txt_usuario.Text = "" And Not Me.txt_correo.Text = "" And Not Me.txt_clave.Text = "" Then


            If Me.txt_clave.TextLength >= 8 Then

                If Me.txt_usuario.TextLength <= 50 Then

                    If Me.txt_clave.TextLength <= 50 Then

                        If Me.txt_correo.TextLength <= 50 Then
                            MessageBox.Show("Se ha guardado el usuario: " & txt_usuario.Text)
                            Me.UsuariosTableAdapter.Guardar(txt_usuario.Text, txt_clave.Text, txt_correo.Text, cb_rol.SelectedValue)
                            Me.UsuariosTableAdapter.Fill(Me.MAPADataSet.usuarios)
                            Me.Close()

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
        MessageBox.Show("Llene los campos vacios")
        End If
    End Sub

    Private Sub check_mostrar_clave_CheckedChanged(sender As Object, e As EventArgs) Handles check_mostrar_clave.CheckedChanged

        If check_mostrar_clave.Checked = False Then

            txt_clave.PasswordChar = "*"

        Else

            txt_clave.PasswordChar = ""

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class