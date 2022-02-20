Module Module1
    Public Const mano_obra_Small = 65.5
    Public Const mano_obra_Medium = 85.99
    Public Const mano_obra_Large = 99.99


    Public Const precio_yarda_algodon = 15.0
    Public Const precio_yarda_seda = 23.99
    Public Const precio_yarda_lona = 30.99


    Public Const cantidad_yarda_Small = 2
    Public Const cantidad_yarda_Medium = 2.5
    Public Const cantidad_yarda_Large = 3

    Public precio_costo = 0
    Public precio_venta = 0

    Public Sub Calcular(material As String, tamaño As String, Cantidad As Double)

        Select Case tamaño
            Case "Small"
                Select Case material
                    Case "Algodón"
                        precio_costo = Cantidad * mano_obra_Small + Cantidad * precio_yarda_algodon * cantidad_yarda_Small
                    Case "Seda"
                        precio_costo = Cantidad * mano_obra_Small + Cantidad * precio_yarda_seda * cantidad_yarda_Small
                    Case "Lona"
                        precio_costo = Cantidad * mano_obra_Small + Cantidad * precio_yarda_lona * cantidad_yarda_Small
                End Select

            Case "Medium"
                Select Case material
                    Case "Algodón"
                        precio_costo = Cantidad * mano_obra_Medium + Cantidad * precio_yarda_algodon * cantidad_yarda_Medium
                    Case "Seda"
                        precio_costo = Cantidad * mano_obra_Medium + Cantidad * precio_yarda_seda * cantidad_yarda_Medium
                    Case "Lona"
                        precio_costo = Cantidad * mano_obra_Medium + Cantidad * precio_yarda_lona * cantidad_yarda_Medium
                End Select

            Case "Large"
                Select Case material
                    Case "Algodón"
                        precio_costo = Cantidad * mano_obra_Large + Cantidad * precio_yarda_algodon * cantidad_yarda_Large
                    Case "Seda"
                        precio_costo = Cantidad * mano_obra_Large + Cantidad * precio_yarda_seda * cantidad_yarda_Large
                    Case "Lona"
                        precio_costo = Cantidad * mano_obra_Large + Cantidad * precio_yarda_lona * cantidad_yarda_Large
                End Select

        End Select

        precio_venta = 1.65 * precio_costo



    End Sub

End Module
