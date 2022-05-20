Module Module1

    Public Const PEstandar = 250
    Public Const PAire_Acondicionado = 290
    Public Const PJacuzzi = 370
    Public Const PExtra_por_persona = 60

    Public Cliente(6, 5) As String

        Public fila As Byte = 0

        Public I As Byte


    Public Sub limpiar_matriz()
        Form1.DataGridView1.Rows.Clear()

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


    Sub Mostrar_Matriz()

            Form1.DataGridView1.Rows.Clear()

            I = 0
            While (I <= 5)

                If (Cliente(I, 0) <> Nothing) Then
                    Form1.DataGridView1.Rows.Add(Cliente(I, 0), Cliente(I, 1), Cliente(I, 2), Cliente(I, 3), Cliente(I, 4), Cliente(I, 5), Cliente(I, 6))
                Else

                    Exit While
                End If

                I = I + 1
            End While
        End Sub

        Function comprobar_NIT() As Boolean
            Dim encontrado As Boolean = True

            I = 0
            comprobar_NIT = True
            While (I <= 5) And (encontrado)

                If (Cliente(I, 0) <> Nothing) Then

                    If (Cliente(I, 0) = Val(Form1.TextBox1.Text)) Then
                        comprobar_NIT = encontrado = False
                        Return comprobar_NIT
                    Else
                        I = I + 1

                    End If
                Else
                    Exit While
                End If
            End While

            If (encontrado) Then
                Return comprobar_NIT
            End If

        End Function

    End Module
