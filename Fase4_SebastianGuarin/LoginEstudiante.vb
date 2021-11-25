Imports System.Data.SqlClient

Public Class LoginEstudiante

    Private Sub Regresar_Inicio_Click(sender As Object, e As EventArgs) Handles Regresar_Inicio.Click
        Dim Inicio As New Inicio()
        Inicio.Show()
        Hide()
    End Sub

    Private Sub Ingresar_Estudiante_Click(sender As Object, e As EventArgs) Handles Ingresar_Estudiante.Click

        Dim conexion As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Estudiantes.mdf;Integrated Security=True;Connect Timeout=30")
        Dim comando As New SqlCommand("SELECT * FROM Estudiante WHERE Identificación = @usuario AND Contraseña = @contraseña", conexion)

        comando.Parameters.AddWithValue("@usuario", Usuario.Text)
        comando.Parameters.AddWithValue("@contraseña", Contraseña.Text)

        Dim adaptador As New SqlDataAdapter(comando)
        Dim tabla As New DataTable()

        adaptador.Fill(tabla)

        If tabla.Rows.Count() <= 0 Then

            MsgBox("Datos de usuario o contraseña incorrectos. Por favor verifique los datos.", MsgBoxStyle.Exclamation, "Ingreso al módulo")

        Else

            Dim AccesoEstudiante As New PlataformaEstudiante()
            AccesoEstudiante.Show()
            Hide()

        End If

    End Sub

End Class