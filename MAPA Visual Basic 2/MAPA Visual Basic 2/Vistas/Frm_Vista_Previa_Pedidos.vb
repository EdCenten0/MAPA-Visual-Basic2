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
End Class