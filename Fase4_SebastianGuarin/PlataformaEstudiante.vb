Public Class PlataformaEstudiante
    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter
        AxWindowsMediaPlayer1.URL = "Videos/Realidad Virtual_ ¿Cómo funciona y Usos.mp4"
    End Sub

    Private Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        Dim Inicio As New Inicio()
        Inicio.Show()
        Hide()
    End Sub

End Class