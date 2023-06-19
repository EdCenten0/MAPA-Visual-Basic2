Public Class Frm_Principal
    Public Shared server As String = Environment.MachineName
    Public Shared conexionString As String = "Data Source=" & server & ";Initial Catalog=MAPA;User Id=sa; Password=1234"

    Private currentForm As Form = Nothing
    Private Sub abrirFromularioHijo(formHijo As Form)
        If currentForm IsNot Nothing Then
            currentForm.Close()
        End If
        currentForm = formHijo
        currentForm.TopLevel = False
        currentForm.FormBorderStyle = FormBorderStyle.None
        currentForm.Dock = DockStyle.Fill
        panel_contenedor.Controls.Add(currentForm)
        panel_contenedor.Tag = currentForm
        currentForm.BringToFront()
        currentForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        abrirFromularioHijo(New Frm_Vista_Previa_Pedidos)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        abrirFromularioHijo(New Frm_Clientes)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        abrirFromularioHijo(New Frm_Ajustes)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        abrirFromularioHijo(New Frm_Proveedores)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        abrirFromularioHijo(New Frm_Taller)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        abrirFromularioHijo(New Frm_Ventas)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        abrirFromularioHijo(New Frm_Materiales)
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs)
        abrirFromularioHijo(New Frm_Ajustes)
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs)
        abrirFromularioHijo(New Frm_Taller)
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)
        abrirFromularioHijo(New Frm_Ventas)
    End Sub

    Private Sub Frm_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.EnableVisualStyles()
    End Sub

    Private Sub Frm_Principal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Button5_Click_2(sender As Object, e As EventArgs) Handles Button5.Click
        abrirFromularioHijo(New Frm_Materiales_Por_Proveedor)
    End Sub

    Private Sub Button4_Click_2(sender As Object, e As EventArgs)
        abrirFromularioHijo(New Frm_Ventas)
    End Sub

    Private Sub Button7_Click_2(sender As Object, e As EventArgs)
        abrirFromularioHijo(New Frm_Taller)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        abrirFromularioHijo(New Frm_Ajustes)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        abrirFromularioHijo(New Frm_Facturas)
    End Sub

    Private Sub Button4_Click_3(sender As Object, e As EventArgs) Handles Button4.Click
        abrirFromularioHijo(New Frm_Ventas)
    End Sub

    Private Sub Button7_Click_3(sender As Object, e As EventArgs) Handles Button7.Click
        abrirFromularioHijo(New Frm_Taller)
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        abrirFromularioHijo(New Frm_Ajustes)
    End Sub
End Class