Public Class Frm_Clientes
    Private Sub Frm_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MAPADataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.MAPADataSet.clientes)
        IDTCliente.Enabled = False
        IDCliente.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ClientesTableAdapter.Guardar(NombreCliente.Text, ApellidoCliente.Text, CedulaCliente.Text, EmailCliente.Text, TelefonoCliente.Text, 1)
        Me.ClientesTableAdapter.Fill(Me.MAPADataSet.clientes)
        MessageBox.Show("Se ha guardado el registro: " & NombreCliente.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ClientesTableAdapter.Editar(NombreCliente.Text, ApellidoCliente.Text, CedulaCliente.Text, EmailCliente.Text, TelefonoCliente.Text, IDTCliente.Text, IDCliente.Text, IDCliente.Text)
        Me.ClientesTableAdapter.Fill(Me.MAPADataSet.clientes)
        MessageBox.Show("Se ha editado el registro: " & NombreCliente.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.ClientesTableAdapter.Eliminar(IDCliente.Text)
        Me.ClientesTableAdapter.Fill(Me.MAPADataSet.clientes)
        MessageBox.Show("Se ha eliminado el registro: " & NombreCliente.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.ClientesTableAdapter.Buscar(MAPADataSet.clientes, Busqueda.Text)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        NombreCliente.Clear()
        ApellidoCliente.Clear()
        CedulaCliente.Clear()
        EmailCliente.Clear()
        TelefonoCliente.Clear()
        IDTCliente.Clear()
        IDCliente.Clear()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.ClientesTableAdapter.Fill(Me.MAPADataSet.clientes)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Reporte_Materiales_Pedidos.ShowDialog()
    End Sub
End Class