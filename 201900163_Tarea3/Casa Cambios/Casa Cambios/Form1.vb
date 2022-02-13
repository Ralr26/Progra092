Public Class Form1
    Public Property CambioColon As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Const CambioDolares As Double = 7.69
        Const CambioPeso As Double = 0.38
        Const CambioEuro As Double = 8.79
        Const CambioColon As Double = 0.012
        Const ComisionCompra As Double = 2.5 / 100
        Const ComisionVenta As Double = 3 / 100

        Dim CompraDolares As Double = 0
        Dim CompraPeso As Double = 0
        Dim CompraEuro As Double = 0
        Dim CompraColon As Double = 0

        Dim VentaDolares As Double = 0
        Dim VentaPeso As Double = 0
        Dim VentaEuro As Double = 0
        Dim VentaColon As Double = 0

        Dim CompraComision As Double = 0
        Dim VentaComision As Double = 0
    End Sub

    Private Sub RadioButtonCompra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonCompra.CheckedChanged
        If RadioButtonCompra.Checked = True Then
            TextBoxCompra.Enabled = True
        Else
            TextBoxCompra.Enabled = False

        End If
    End Sub

    Private Sub RadioButtonVenta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonVenta.CheckedChanged
        If RadioButtonVenta.Checked = True Then
            TextBoxVenta.Enabled = True
        Else
            TextBoxVenta.Enabled = False

        End If
    End Sub

    Private Sub ButtonCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCalcular.Click
        If (RadioButtonCompra.Checked) And (CheckBoxDolares.Checked) Then
            CompraDolar = TextBoxCompra.Text * CambioDolares
            TotalCompra.Text = CompraDolares
        End If

        If (RadioButtonCompra.Checked) And (CheckBoxPeso.Checked) Then
            CompraPeso = TextBoxCompra.Text * CambioPeso
            TotalCompra.Text = CompraPeso
        End If

        If (RadioButtonCompra.Checked) And (CheckBoxEuro.Checked) Then
            CompraEuro = TextBoxCompra.Text * CambioEuro
            TotalCompra.Text = CompraEuro
        End If

        If (RadioButtonCompra.Checked) And (CheckBoxColones.Checked) Then
            Dim CompraColon As Object
            CompraColon = TextBoxCompra.Text * CambioColon
            TotalCompra.Text = CompraColon
        End If

        If (RadioButtonCompra.Checked) Then
            CompraComision = TotalCompra.Text * ComisionCompra
            TextBoxComisionCompra = CompraComision
        End If

        If (RadioButtonVenta.Checked) And (CheckBoxDolares.Checked) Then
            VentaDolares = TextBoxVenta.Text * CambioDolares
            TotalVenta.Text = VentaDolares
        End If

        If (RadioButtonVenta.Checked) And (CheckBoxPeso.Checked) Then
            VentaPeso = TextBoxVenta.Text * CambioPeso
            TotalVenta.Text = VentaPeso
        End If

        If (RadioButtonVenta.Checked) And (CheckBoxEuro.Checked) Then
            VentaEuro = TextBoxVenta.Text * CambioEuro
            TotalVenta.Text = VentaEuro
        End If

        If (RadioButtonVenta.Checked) And (CheckBoxColones.Checked) Then
            VentaColon = TextBoxVenta.Text * CambioColon
            TotalVenta.Text = VentaColon
        End If

        If (RadioButtonVenta.Checked) Then
            VentaComision = TotalVenta.Text * ComisionVenta
            TextBoxComisionVenta = VentaComision
        End If


    End Sub

    Private Function VentaDolares() As String
        Throw New NotImplementedException()
    End Function
    End Sub

    Private Sub ButtonLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLimpiar.Click
        TextBoxCompra.Clear()
        TextBoxVenta.Clear()
        TotalCompra.clear()
        TotalVenta.Clear()
        TextBoxComisionCompra.Clear()
        TextBoxComisionVenta.Clear()

    End Sub


    Private Sub ButtonSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSalir.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        End If
    End Sub
    End Sub
End Class
