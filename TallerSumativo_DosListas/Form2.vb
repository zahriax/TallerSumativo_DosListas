Public Class Form2
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        If tbUsuario.Text = "Nombre" And tbContra.Text = "123" Then
            MsgBox("Bienvenido Usuario")
            Me.Hide()
            Form1.Show()
        Else
            MsgBox("El usuario o la contrasena son incorrectos")
            tbUsuario.Text = ""
            tbContra.Text = ""
            tbUsuario.Focus()
        End If
    End Sub
End Class