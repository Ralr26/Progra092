Module Module1
    Public posicion As Byte = 0
    Public Nombre(7) As String
    Public Sueldo(7) As Double
    Public Comisión(7) As Double
    Public BonoIncentivo(7) As Double
    Public Total(7) As Double

    Public Const PrecioTablet = 375
    Public Const PrecioDrone = 560
    Public Const PrecioCelular = 1450
    Public Const PrecioTelevisor = 3250
    Public Const PorcentajeComision = 0.055
    Public Const Comision1 = 0.03
    Public Const Comision2 = 0.04
    Public Const Comision3 = 0.05
    Sub limpiar_entradas()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.ComboBox1.SelectedIndex = -1
        Form1.TextBox1.Focus()
    End Sub
    Sub LIMPIAR_VECTORES()
        posicion = 0

        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
    End Sub
    Sub salir()
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "mensaje de salida") = vbYes) Then
            End
        Else
            limpiar_entradas()
            LIMPIAR_VECTORES()
        End If
    End Sub

    Sub muestre_totales()
        Form1.ListBox1.Items.Add(Nombre(posicion))
        Form1.ListBox2.Items.Add(Sueldo(posicion))
        Form1.ListBox3.Items.Add(Comisión(posicion))

    End Sub
End Module
