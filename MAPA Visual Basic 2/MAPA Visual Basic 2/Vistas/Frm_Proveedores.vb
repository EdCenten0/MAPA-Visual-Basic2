Public Class Frm_Proveedores
    Private Sub Frm_Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.MAPADataSet.proveedores)
        vaciar()

    End Sub

    Private Sub bt_refrescar_Click(sender As Object, e As EventArgs) Handles bt_refrescar.Click
        Me.ProveedoresTableAdapter.Fill(Me.MAPADataSet.proveedores)
    End Sub

    Private Function vaciar() As String
        Me.Textbox_id.Text = ""
        Me.Textbox_nombre.Text = ""
        Me.Textbox_direccion.Text = ""
        Me.Textbox_email.Text = ""
        Me.Textbox_telefono.Text = ""
        Me.Textbox_catalogo.Text = ""
        Me.Textbox_ruc.Text = ""

    End Function

    Private Sub bt_vaciar_Click(sender As Object, e As EventArgs) Handles bt_vaciar.Click
        vaciar()
    End Sub

    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click

        If Not Me.Textbox_nombre.Text = "" And Not Me.Textbox_email.Text = "" And Not Me.Textbox_direccion.Text = "" And Not Me.Textbox_catalogo.Text = "" And Not Me.Textbox_ruc.Text = "" And Not Me.Textbox_telefono.Text = "" Then

            If Me.Textbox_id.Text = "" Then

                If Me.Textbox_nombre.TextLength <= 50 Then

                    If Me.Textbox_email.TextLength <= 50 Then

                        If Me.Textbox_ruc.TextLength <= 15 Then

                            If Me.Textbox_telefono.TextLength <= 12 Then

                                If Me.Textbox_catalogo.TextLength <= 100 Then

                                    If Me.Textbox_direccion.TextLength <= 300 Then

                                        MessageBox.Show("Se ha guardado el proveedor: " & Textbox_nombre.Text)
                                        Me.ProveedoresTableAdapter.Guardar(Me.Textbox_nombre.Text, Me.Textbox_email.Text, Me.Textbox_telefono.Text, Me.Textbox_catalogo.Text, Me.Textbox_ruc.Text, Me.Textbox_direccion.Text, 1)
                                        Me.ProveedoresTableAdapter.Fill(Me.MAPADataSet.proveedores)
                                        vaciar()

                                    Else
                                        MessageBox.Show("La direccion debe tener menos de 300 caracteres")

                                    End If

                                Else
                                    MessageBox.Show("El catalogo debe tener menos de 100 caracteres")

                                End If

                            Else
                                MessageBox.Show("El telefono debe tener menos de 12 caracteres")

                            End If

                        Else
                            MessageBox.Show("El ruc debe tener menos de 15 caracteres")

                        End If

                    Else
                        MessageBox.Show("El correo electronico debe tener menos de 50 caracteres")

                    End If

                Else
                    MessageBox.Show("El nombre del proveedor debe tener menos de 50 caracteres")

                End If


            Else
                MessageBox.Show("No se puede guardar el proveedor con ese id existente")

            End If

        Else
            MessageBox.Show("Llene los campos vacios")

        End If



    End Sub

    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click

        If Not Me.Textbox_id.Text = "" Then
            MessageBox.Show("Se ha eliminado el proveedor: " & Textbox_nombre.Text)
            Me.ProveedoresTableAdapter.Eliminar(Me.Textbox_id.Text)
            Me.ProveedoresTableAdapter.Fill(Me.MAPADataSet.proveedores)
            vaciar()

        Else
            MessageBox.Show("Seleccione al proveedor a eliminar")

        End If


        vaciar()
    End Sub
    Private Sub bt_editar_Click(sender As Object, e As EventArgs) Handles bt_editar.Click

        If Not Me.Textbox_nombre.Text = "" And Not Me.Textbox_email.Text = "" And Not Me.Textbox_direccion.Text = "" And Not Me.Textbox_catalogo.Text = "" And Not Me.Textbox_ruc.Text = "" And Not Me.Textbox_telefono.Text = "" Then

            If Not Me.Textbox_id.Text = "" Then

                If Me.Textbox_nombre.TextLength <= 50 Then

                    If Me.Textbox_email.TextLength <= 50 Then

                        If Me.Textbox_ruc.TextLength <= 15 Then

                            If Me.Textbox_telefono.TextLength <= 12 Then

                                If Me.Textbox_catalogo.TextLength <= 100 Then

                                    If Me.Textbox_direccion.TextLength <= 300 Then
                                        MessageBox.Show("Se ha editado el proveedor: " & Textbox_nombre.Text)
                                        Me.ProveedoresTableAdapter.Editar(Me.Textbox_nombre.Text, Me.Textbox_email.Text, Me.Textbox_telefono.Text, Me.Textbox_catalogo.Text, Me.Textbox_ruc.Text, Me.Textbox_direccion.Text, 1, Me.Textbox_id.Text, Me.Textbox_id.Text)
                                        Me.ProveedoresTableAdapter.Fill(Me.MAPADataSet.proveedores)
                                        vaciar()

                                    Else
                                        MessageBox.Show("La direccion debe tener menos de 300 caracteres")

                                    End If

                                Else
                                    MessageBox.Show("El catalogo debe tener menos de 100 caracteres")

                                End If

                            Else
                                MessageBox.Show("El telefono debe tener menos de 12 caracteres")

                            End If

                        Else
                            MessageBox.Show("El ruc debe tener menos de 15 caracteres")

                        End If

                    Else
                        MessageBox.Show("El correo electronico debe tener menos de 50 caracteres")

                    End If

                Else
                    MessageBox.Show("El nombre del proveedor debe tener menos de 50 caracteres")

                End If


            Else
                MessageBox.Show("Seleccione al proveedor a editar")

            End If

        Else
            MessageBox.Show("Llene todos campos vacios")

        End If


    End Sub

    Private Sub bt_buscar_Click(sender As Object, e As EventArgs) Handles bt_buscar.Click
        Me.ProveedoresTableAdapter.Buscar(Me.MAPADataSet.proveedores, Me.txt_buscar.Text)
    End Sub
End Class