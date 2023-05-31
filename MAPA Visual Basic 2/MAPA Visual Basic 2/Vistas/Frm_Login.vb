Imports System.Data.SqlClient

Public Class Frm_Login

    Dim conexion As New SqlConnection
    Dim comando As New SqlCommand

    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection("Data Source=CARLOSCent;Initial Catalog=MAPA;Persist Security Info=True;User ID=sa;Password=1234")
        txt_Clave.PasswordChar = "*"
    End Sub

    Private Sub bt_Ingresar_Click(sender As Object, e As EventArgs) Handles bt_Ingresar.Click
        conexion.Open()
        Dim consulta As String = "select * from usuarios where nombre = '" & Me.txt_Usuario.Text & "' AND clave = '" & Me.txt_Clave.Text & "' "
        comando = New SqlCommand(consulta, conexion)
        Dim consultaBD As SqlDataReader
        consultaBD = comando.ExecuteReader


        If consultaBD.HasRows Then
            MessageBox.Show("Bienvenido al sistema de MAPA " & Me.txt_Usuario.Text)
            Me.Hide()
            Frm_Principal.ShowDialog()

        Else
            MsgBox("El Usuario y contraseña no son validos, intente ingresar los datos correctos", vbCritical)

        End If


        conexion.Close()

    End Sub

    Private Sub check_Mostrar_CheckedChanged(sender As Object, e As EventArgs) Handles check_Mostrar.CheckedChanged

        If check_Mostrar.Checked = False Then

            txt_Clave.PasswordChar = "*"

        Else

            txt_Clave.PasswordChar = ""

        End If

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Frm_Agregar_Usuario.ShowDialog()
    End Sub
End Class