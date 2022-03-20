Module Module1
    Public posicion As Byte = 0
    Public Nombredelpack(6) As String
    Public Productodeseado(6) As String
    Public Cantidadenelinventario(6) As Double
    Public Cantidaddeseadaenelpack(6) As Double
    Public Sobrante(6) As Double
    Public Ingresosesperadosporelpack(6) As Double
    Public Ingresosesperadosporelproductosobrante(6) As Double
    Public Descuento(6) As Double
    Public total(6) As Double
    Public Const Preciojugos = 8.5
    Public Const Preciofrituras = 11.2
    Public Const Preciogalletas = 4.25
    Public Const Preciobaterias = 15
    Public Const Descuento1 = 0.03
    Public Const Descuento2 = 0.05
    Public Const Descuento3 = 0.1

    Sub salir()
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "mensaje de salida") = vbYes) Then
            End
        End If
    End Sub


End Module
