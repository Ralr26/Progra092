Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim X As Byte
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        For X = 0 To 9
            If Valor(X) <> Nothing Then
                ListBox1.Items.Add(Str(Valor(X)))
                ListBox2.Items.Add(Str(Peso(X)))
                ListBox3.Items.Add(Nombre(X))
                ListBox4.Items.Add(Tipo(X))
                ListBox5.Items.Add(Forma(X))

            Else
                Exit For
            End If
        Next X
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim J As Byte

        For J = 0 To 9
            Valor(J) = Nothing
            Peso(J) = Nothing
        Next J
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()

        FILA = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)
        ListBox2.Items.Add(TextBox2.Text)
        ListBox3.Items.Add(TextBox3.Text)

        Dim BASE As Integer
        Dim Porcentaje As Integer
        Dim RESULTADO As Long
        Dim I As Integer

        BASE = Val(TextBox2.Text)
        Porcentaje = Val(ComboBox1.Text)
        RESULTADO = BASE

        For I = 2 To Porcentaje
            RESULTADO = RESULTADO * BASE
            ListBox6.Items.Add(Str(RESULTADO))
        Next I
        TextBox2.Text = Str(RESULTADO)
    End Sub
End Class
