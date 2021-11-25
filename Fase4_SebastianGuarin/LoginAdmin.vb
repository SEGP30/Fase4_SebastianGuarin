Imports System.Data.SqlClient

Public Class LoginAdmin
    Private Sub Regresar_Inicio_Click(sender As Object, e As EventArgs) Handles Regresar_Inicio.Click
        Dim Inicio As New Inicio()
        Inicio.Show()
        Hide()

    End Sub

    Private Sub Ingresar_Admin_Click(sender As Object, e As EventArgs) Handles Ingresar_Admin.Click

        Dim conexion As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Fase4_SebastianGuarin\Fase4_SebastianGuarin\Usuarios.mdf;Integrated Security=True")
        Dim comando As New SqlCommand("SELECT * FROM Admin WHERE Id = @usuario AND Password = @contraseña", conexion)

        comando.Parameters.AddWithValue("@usuario", Usuario.Text)
        comando.Parameters.AddWithValue("@contraseña", Contraseña.Text)

        Dim adaptador As New SqlDataAdapter(comando)
        Dim tabla As New DataTable()

        adaptador.Fill(tabla)

        If tabla.Rows.Count() <= 0 Then

            MsgBox("Datos de usuario o contraseña incorrectos. Por favor verifique los datos.", MsgBoxStyle.Exclamation, "Ingreso al módulo")

        Else

            Dim GestAdmin As New GestionAdmin()
            GestAdmin.Show()
            Hide()

        End If

    End Sub
End Class