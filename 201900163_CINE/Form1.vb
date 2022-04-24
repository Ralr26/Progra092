Public Class Form1
    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click


        Cliente(fila, 0) = TextBox1.Text
        Cliente(fila, 1) = TextBox2.Text
        Cliente(fila, 2) = TextBox3.Text


        If (RadioButton1.Checked) Then
            Cliente(fila, 3) = RadioButton1.Text
        ElseIf (RadioButton2.Checked) Then
            Cliente(fila, 3) = RadioButton2.Text
        Else   (RadioButton3.Checked) 
            Cliente(fila, 3) = RadioButton3.Text

        End If


        Cliente(fila, 3) = Str(Round((Val(Cliente(fila, 2)), 2)))
        'se indica con un mensaje que el registro fue actualizado correctamente
        MsgBox("Registro actualizado correctamente en la matriz")
        fila = 3

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Close()
        End If
    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarMatrizToolStripMenuItem.Click
        limpiar_matriz()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        Mostrar_Matriz()
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click

        Dim existe As Boolean = True


        I = 0

        While (I <= 6) And (existe)

            If (Cliente(I, 0) <> Nothing) Then
                If (Val(Cliente(I, 0)) = Val(TextBox1.Text)) Then
                    existe = False
                Else
                    I = I + 1
                End If
            Else
                Exit While
            End If
        End While

        If (existe) Then
            MsgBox("NIT no Encontrado")
            TextBox1.Focus()
        Else
            MsgBox("NIT Encontrado")

            TextBox1.Text = Cliente(I, 0)
            TextBox2.Text = Cliente(I, 1)
            TextBox3.Text = Cliente(I, 2)

            If (Cliente(I, 3) = "Normal") Then

                RadioButton1.Checked = True
            ElseIf (Cliente(I, 3) = "3D") Then
                RadioButton2.Checked = True
            ElseIf (Cliente(I, 3) = "4DX") Then
                RadioButton3.Checked = True

            End If

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Cliente(I, 0), Cliente(I, 1), Cliente(I, 2))

            fila = I
        End If
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click

        If ((comprobar_repetido())) Then
            If (fila <= 6) Then
                'se determina cual fue el curso seleccionado para guardarlo en la columna respectiva
                If (RadioButton1.Checked) Then
                    Cliente(fila, 7) = RadioButton1.Text
                ElseIf (RadioButton2.Checked) Then
                    Cliente(fila, 7) = RadioButton2.Text
                ElseIf (RadioButton3.Checked) Then
                    Cliente(fila, 7) = RadioButton3.Text

                Else
                    MsgBox("Error, no seleccionó Tipo de sala")
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede colocar numeros")
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede colocar numeros")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
