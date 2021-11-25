Public Class GestionAdmin
    Private Sub GestionAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EstudiantesDataSet.Estudiante' Puede moverla o quitarla según sea necesario.
        Me.EstudianteTableAdapter.Fill(Me.EstudiantesDataSet.Estudiante)

    End Sub

    Private Sub Ingresar_Registro_Click(sender As Object, e As EventArgs) Handles Ingresar_Registro.Click
        Me.EstudianteTableAdapter.Insertar(Txt_Id.Text, Txt_Nombre.Text, Txt_Apellido.Text, Edad.Value, FechaNacimiento.Text, CBox_Genero.Text, Txt_Telefono.Text, Txt_Contraseña.Text, Txt_Email.Text, Txt_Direccion.Text)
        Me.EstudianteTableAdapter.Fill(Me.EstudiantesDataSet.Estudiante)
    End Sub

    Private Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        Dim Inicio As New Inicio()
        Inicio.Show()
        Hide()
    End Sub

    Private Sub Actualizar_Registro_Click(sender As Object, e As EventArgs) Handles Actualizar_Registro.Click
        Me.EstudianteTableAdapter.Actualizar(Txt_Id.Text, Txt_Nombre.Text, Txt_Apellido.Text, Edad.Value, FechaNacimiento.Text, CBox_Genero.Text, Txt_Telefono.Text, Txt_Contraseña.Text, Txt_Email.Text, Txt_Direccion.Text, Txt_Id.Text)
        Me.EstudianteTableAdapter.Fill(Me.EstudiantesDataSet.Estudiante)
    End Sub

    Private Sub Eliminar_Registro_Click(sender As Object, e As EventArgs) Handles Eliminar_Registro.Click
        Me.EstudianteTableAdapter.Eliminar(Txt_Id.Text)
        Me.EstudianteTableAdapter.Fill(Me.EstudiantesDataSet.Estudiante)
    End Sub

    Private Sub Txt_Telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Telefono.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub Txt_Id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Id.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

End Class