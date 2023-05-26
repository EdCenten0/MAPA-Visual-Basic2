Public Class Frm_Principal

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

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        abrirFromularioHijo(New Frm_Ajustes)
    End Sub
End Class