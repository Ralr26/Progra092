Public Class Form1


    Public Indice As String
    Public Matriz(10, Indice) As String


    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click

        Dim TamSofa = 250.99
        Dim TamIndiv = 150.99
        Dim TamDoble = 200.99

        Dim CueroSofa = 600
        Dim CueroIndv = 262.5
        Dim CueroDoble = 450

        Dim CuerinaSofa = 367.92
        Dim CuerinaIndiv = 160.965
        Dim CuerinaDobe = 275.94

        If Indice < 8 Then


            Matriz(0, Indice) = CbTamaño.Text
            Matriz(1, Indice) = CbTela.Text


            Dim costo As Double
            Dim PrecioVenta As Double

            If (CbTamaño.Text = "Sofa" And CbTela.Text = "Cuero") Then
                costo = TamSofa + CueroSofa

            ElseIf (CbTamaño.Text = "Sofa" And CbTela.Text = "Cuerina") Then

                costo = TamSofa + CuerinaSofa

            ElseIf (CbTamaño.Text = "Individual" And CbTela.Text = "Cuero") Then

                costo = TamIndiv + CueroIndv

            ElseIf (CbTamaño.Text = "Individual" And CbTela.Text = "Cuerina") Then

                costo = TamIndiv + CuerinaIndiv

            ElseIf (CbTamaño.Text = "Doble" And CbTela.Text = "Cuero") Then
                costo = TamDoble + CueroDoble

            ElseIf (CbTamaño.Text = "Doble" And CbTela.Text = "Cuerina") Then
                costo = TamDoble + CuerinaDobe

            End If

            PrecioVenta = costo + costo * 0.65

            Matriz(2, Indice) = costo
            Matriz(3, Indice) = PrecioVenta



            dgv_Valores.Rows.Add(Indice + 1, Matriz(0, Indice), Matriz(1, Indice), Matriz(2, Indice), Matriz(3, Indice))
            Indice = 1 + Indice

            If CbTamaño.Text = "" Then
                MsgBox("Ingrese un tamaño")
            End If

            If CbTela.Text = "" Then
                MsgBox("Ingrese un Tipo de tela")
            End If

        Else
            MsgBox("Maximo Número de Sillones alcanzado")

        End If




    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Me.Close()
            End
        End If
    End Sub

    Private Sub DatosDeEntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosDeEntradaToolStripMenuItem.Click
        CbTamaño.Text = ""
        CbTela.Text = ""
    End Sub

    Private Sub VectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VectoresToolStripMenuItem.Click
        Indice = 0
        dgv_Valores.Rows.Clear()
    End Sub
End Class
