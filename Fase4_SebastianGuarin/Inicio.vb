Public Class Inicio
    Private Sub Acceso_Admin_Click(sender As Object, e As EventArgs) Handles Acceso_Admin.Click
        Dim AccesoAdmin = New LoginAdmin()
        AccesoAdmin.Show()
        Hide()
    End Sub

    Private Sub Acceso_Estudiante_Click(sender As Object, e As EventArgs) Handles Acceso_Estudiante.Click
        Dim AccesoEstudiante = New LoginEstudiante()
        AccesoEstudiante.Show()
        Hide()
    End Sub
End Class
