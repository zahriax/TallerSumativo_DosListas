Public Class Form1
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'End
        'Me.Close()
        Dim opcion As DialogResult
        opcion = MessageBox.Show("Desea salir ", "Salir del  programa  ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nombre As String = ""
    
        ListBox1.Items.Add(InputBox("Ingrese los Datos", "Datos", nombre))

    End Sub

    Private Sub btnIzquierda_Click(sender As Object, e As EventArgs) Handles btnIzquierda.Click
        ListBox1.Items.Add(ListBox2.SelectedItem)
        ListBox2.Items.Remove(ListBox2.SelectedItem)
    End Sub

    Private Sub btnTodo2_Click(sender As Object, e As EventArgs) Handles btnTodo2.Click
        ListBox1.Items.AddRange(ListBox2.Items)
        ListBox2.Items.Clear()
    End Sub

    Private Sub btnDerecha_Click(sender As Object, e As EventArgs) Handles btnDerecha.Click
        ListBox2.Items.Add(ListBox1.SelectedItem)
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub btnTodo1_Click(sender As Object, e As EventArgs) Handles btnTodo1.Click
        ListBox2.Items.AddRange(ListBox1.Items)
        ListBox1.Items.Clear()
    End Sub
End Class
