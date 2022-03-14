Public Class Form1


    Public Indice As String
    Public Matriz(10, Indice) As String
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

        If Indice < 2 Then

            Matriz(0, Indice) = TxtNombre.Text
            Matriz(1, Indice) = txtCarne.Text
            Matriz(2, Indice) = CbIdioma.SelectedItem
            Matriz(3, Indice) = CbDia.SelectedItem
            Matriz(4, Indice) = TxtHoras.Text
            Matriz(5, Indice) = CbPago.SelectedItem
            Matriz(6, Indice) = Fecha.Text

            Dim PagoParcial As Integer
            Dim Descuento1 As Integer
            Dim descuento2 As Integer
            Dim Total As Integer

            If (CbIdioma.Text = "Ingles" And CbDia.Text = "Viernes") Then
                PagoParcial = Ingles * TxtHoras.Text
            ElseIf (CbIdioma.Text = "Ingles" And CbDia.Text = "Sabado") Then
                PagoParcial = Ingles * TxtHoras.Text
            ElseIf (CbIdioma.Text = "Ingles" And CbDia.Text = "Ambos") Then
                PagoParcial = Ingles * TxtHoras.Text * 2
            End If


            If (CbIdioma.Text = "Frances" And CbDia.Text = "Viernes") Then
                PagoParcial = Frances * TxtHoras.Text
            ElseIf (CbIdioma.Text = "Frances" And CbDia.Text = "Sabado") Then
                PagoParcial = Frances * TxtHoras.Text
            ElseIf (CbIdioma.Text = "Frances" And CbDia.Text = "Ambos") Then
                PagoParcial = Frances * TxtHoras.Text * 2
            End If


            If (CbIdioma.Text = "Portugues" And CbDia.Text = "Viernes") Then
                PagoParcial = Portugues * TxtHoras.Text
            ElseIf (CbIdioma.Text = "Portugues" And CbDia.Text = "Sabado") Then
                PagoParcial = Portugues * TxtHoras.Text
            ElseIf (CbIdioma.Text = "Portugues" And CbDia.Text = "Ambos") Then
                PagoParcial = Portugues * TxtHoras.Text * 2
            End If

            If (CbPago.Text = "Efectivo") Then
                Descuento1 = PagoParcial * Descefectivo

            ElseIf (CbPago.Text = "Cheque") Then
                Descuento1 = PagoParcial * DescCheque
            End If

            If (CbDia.Text = "Ambos") Then
                descuento2 = PagoParcial * DescDías
            Else
                descuento2 = 0

            End If

            Total = PagoParcial - Descuento1 - descuento2

            Matriz(7, Indice) = Descuento1
            Matriz(8, Indice) = descuento2
            Matriz(9, Indice) = PagoParcial
            Matriz(10, Indice) = Total
            DataGridView1.Rows.Add(Indice + 1, Matriz(0, Indice), Matriz(1, Indice), Matriz(2, Indice), Matriz(3, Indice), Matriz(4, Indice), Matriz(5, Indice), Matriz(6, Indice), Matriz(7, Indice), Matriz(8, Indice), Matriz(9, Indice), Matriz(10, Indice))
            Indice = Indice + 1

        Else
            MsgBox("Maximo Número de inscripciones Alcanzado")
        End If


    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        If (MsgBox("¿Desea cerrar la aplicación?", vbQuestion + vbYesNo, "Cerrando") = vbYes) Then
            Me.Close()
            End
        End If
    End Sub

    Private Sub DatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosToolStripMenuItem.Click
        TxtNombre.Clear()
        txtCarne.Clear()
        TxtHoras.Clear()
        CbDia.Text = ""
        CbIdioma.Text = ""
        CbPago.Text = ""
    End Sub

    Private Sub FormularioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormularioToolStripMenuItem.Click
        Indice = 0
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
