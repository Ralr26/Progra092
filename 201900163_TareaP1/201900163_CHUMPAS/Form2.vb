Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtprecioC.Text = precio_costo
        txtpreciov.Text = precio_venta
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub txtprecioC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecioC.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If


    End Sub

    Private Sub txtpreciov_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpreciov.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtprecioC_TextChanged(sender As Object, e As EventArgs) Handles txtprecioC.TextChanged
        txtprecioC = Format(Val(txtprecioC, "0.00")

    End Sub

    Private Sub txtpreciov_TextChanged(sender As Object, e As EventArgs) Handles txtpreciov.TextChanged
        txtpreciov = Format(Val(txtpreciov, "0.00")
    End Sub
End Class