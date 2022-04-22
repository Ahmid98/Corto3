Module Resultados

    Public Const sencilla = 250
    Public Const doble = 400
    Public Const cabaña = 650

    Public index As Byte = 0

    Public nombre1(6) As String
    Public nit1(6) As Integer
    Public no_dias1(6) As Integer
    Public valor_im1(6) As Double
    Public tipo_habitacion1(6) As String
    Public tipo_pago1(6) As String
    Public total_pagar1(6) As Double
    Public descuento1(6) As Double
    Public recar1(6) As Double
    Public total_final1(6) As Double

    Function Calcular() As Double
        Dim total As Double
        Select Case Form1.cb_tipohabi.Text
            Case "Sencilla"
                total = sencilla + Form1.txt_impuesto.Text
            Case "Doble"
                total = doble + Form1.txt_impuesto.Text
            Case "Cabaña"
                total = cabaña + Form1.txt_impuesto.Text
        End Select

        Return total
    End Function

    Function Descuento() As Double
        Dim desc1 As Double
        Select Case Form1.cb_tipopago.SelectedIndex
            Case 0
                desc1 = Calcular() * 0.15
            Case 1
                desc1 = 0
            Case 2
                desc1 = 0
            Case 3
                desc1 = 0
        End Select
        Return desc1
    End Function

    Function Recargo1() As Double
        Dim re As Double
        Select Case Form1.cb_tipopago.SelectedIndex
            Case 0
                re = 0
            Case 1
                re = Calcular() * 0.03
            Case 2
                re = 0
            Case 3
                re = 0
        End Select
        Return re
    End Function

    Function TotalFinal() As Double
        Dim totalf As Double
        If Form1.cb_tipopago.SelectedIndex = 1 Then
            totalf = Calcular() + Recargo1()
        Else
            totalf = Calcular() - Descuento()
        End If
        Return totalf
    End Function
End Module
