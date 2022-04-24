Module Module1


    Public Cliente(7, 4) As String

    Public fila As Byte = 0

    Public I As Byte


    Sub limpiar_matriz()
        Form1.DataGridView1.Rows.Clear()

        fila = 0

        I = 0

        While (I <= 6)
            Cliente(I, 0) = Nothing
            Cliente(I, 1) = Nothing
            Cliente(I, 2) = Nothing
            Cliente(I, 3) = Nothing


            I = I + 1
        End While

    End Sub

    Sub Mostrar_Matriz()

        Form1.DataGridView1.Rows.Clear()

        I = 0
        While (I <= 6)

            If (Cliente(I, 0) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Cliente(I, 0), Cliente(I, 1), Cliente(I, 2), Cliente(I, 3))
            Else

                Exit While
            End If

            I = I + 1
        End While
    End Sub

    Function comprobar_repetido() As Boolean
        Dim encontrado As Boolean = True

        I = 0
        comprobar_repetido = True
        While (I <= 6) And (encontrado)

            If (Cliente(I, 0) <> Nothing) Then

                If (Cliente(I, 0) = Val(Form1.TextBox1.Text)) Then
                    comprobar_repetido = encontrado = False
                    Return comprobar_repetido
                Else
                    I = I + 1

                End If
            Else
                Exit While
            End If
        End While

        If (encontrado) Then
            Return comprobar_repetido
        End If

    End Function
End Module
