Public Class Form1
    Private Sub DefinicionDeVariablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefinicionDeVariablesToolStripMenuItem.Click

        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Close()
        End If

    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarMatrizToolStripMenuItem.Click

        fila = 0

        I = 0

        While (I <= 5)
            Cliente(I, 0) = Nothing
            Cliente(I, 1) = Nothing
            Cliente(I, 2) = Nothing
            Cliente(I, 3) = Nothing
            Cliente(I, 4) = Nothing
            Cliente(I, 5) = Nothing
            Cliente(I, 6) = Nothing

            I = I + 1
        End While
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        Dim existe As Boolean = True


        I = 0

        While (I <= 5) And (existe)

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

            If (Cliente(I, 6) = "Éstandar") Then

                RadioButton1.Checked = True
            ElseIf (Cliente(I, 6) = "A/C") Then
                RadioButton2.Checked = True
            ElseIf (Cliente(I, 6) = "Jacuzzi") Then
                RadioButton3.Checked = True

            End If

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Cliente(I, 0), Cliente(I, 1), Cliente(I, 2), Cliente(I, 3), Cliente(I, 4), Cliente(I, 5), Cliente(I, 6))

            fila = I
        End If
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click




        I = 0
        While (I <= 5)

            If (Cliente(I, 0) <> Nothing) Then
                DataGridView1.Rows.Add(Cliente(I, 0), Cliente(I, 1), Cliente(I, 2), Cliente(I, 3), Cliente(I, 4), Cliente(I, 5), Cliente(I, 6))
            Else

                Exit While
            End If

            I = I + 1
        End While
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click

        If ((comprobar_nit())) Then
            If (fila <= 5) Then

                If (RadioButton1.Checked) Then
                    Cliente(fila, 6) = RadioButton1.Text
                ElseIf (RadioButton2.Checked) Then
                    Cliente(fila, 6) = RadioButton2.Text
                ElseIf (RadioButton3.Checked) Then
                    Cliente(fila, 6) = RadioButton3.Text

                Else
                    MsgBox("Error, no seleccionó Tipo de habitación")
                    Exit Sub
                End If
            End If
        End If


        If (I <= 5) Then
            Cliente(I, 0) = TextBox1.Text
            Cliente(I, 1) = TextBox2.Text
            Cliente(I, 2) = TextBox3.Text

            If (Val(Cliente(I, 2)) >= 4) Then
                Cliente(I, 3) = Str((Val(Cliente(I, 2)) - 4) * PExtra_por_persona)
            End If

            If RadioButton1 Is [Select]() Then
                Cliente(I, 5) = Str(Val(Cliente(I, 3) + Val(PEstandar)))
                If RadioButton2 Then Is [Select]() Then
                Cliente(I, 5) = Str(Val(Cliente(I, 3) + Val(PAire_Acondicionado)))
            ElseIf RadioButton3 Then Is  [Select]() Then
                Cliente(I, 5) = Str(Val(Cliente(I, 3) + Val(PJacuzzi)))
            End If

            DataGridView1.Rows.Add(Cliente(I, 0), Cliente(I, 1), Cliente(I, 2), Cliente(I, 3), Cliente(I, 4), Cliente(I, 5), Cliente(I, 6))
                I = I + 1
                Else
                    MessageBox.Show("se llegó al límite")
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
