Public Class Frm_Ajustes

    Private currentForm As Form = Nothing
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub abrirFromularioHijo(formHijo As Form)
        If currentForm IsNot Nothing Then
            currentForm.Close()
        End If
        currentForm = formHijo
        currentForm.TopLevel = False
        currentForm.FormBorderStyle = FormBorderStyle.None
        currentForm.Dock = DockStyle.Fill
        panel_contenedor_ajustes.Controls.Add(currentForm)
        panel_contenedor_ajustes.Tag = currentForm
        currentForm.BringToFront()
        currentForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        abrirFromularioHijo(New Frm_Rol)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        abrirFromularioHijo(New Frm_Usuarios)
    End Sub
End Class