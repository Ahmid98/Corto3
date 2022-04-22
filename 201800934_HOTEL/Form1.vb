Public Class Form1
    Private Sub CALCULOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULOToolStripMenuItem.Click

        nombre1(index) = txt_nombre.Text
        nit1(index) = txt_nit.Text
        no_dias1(index) = txt_nodias.Text
        valor_im1(index) = txt_impuesto.Text
        tipo_habitacion1(index) = cb_tipohabi.Text
        tipo_pago1(index) = cb_tipopago.Text

        total_pagar1(index) = Resultados.Calcular()
        descuento1(index) = Resultados.Descuento
        recar1(index) = Resultados.Recargo1
        total_final1(index) = Resultados.TotalFinal

    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        tabla.Rows.Clear()
        Dim i As Byte = 0
        While (i <= 6)


            If (nit1(i) <> Nothing) Then
                tabla.Rows.Add(nombre1(i), nit1(i), no_dias1(i), valor_im1(i), tipo_habitacion1(i), tipo_pago1(i), total_pagar1(i), descuento1(i), recar1(i), total_final1(i))
            Else
                Exit While
            End If

            i = i + 1
        End While
    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click
        Dim i As Byte = 0
        While (i <= 6)


            If (nit1(i) = txt_consultanit.Text) Then
                txt_nombre.Text = nombre1(i)
                txt_nit.Text = nit1(i)
                txt_nodias.Text = no_dias1(i)
                txt_impuesto.Text = valor_im1(i)
                cb_tipohabi.Text = tipo_habitacion1(i)
                cb_tipopago.Text = tipo_pago1(i)
            End If

            i = i + 1
        End While
    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click
        Dim i As Byte = 0
        While (i <= 6)


            If (nit1(i) = txt_consultanit.Text) Then
                txt_nombre.Text = nombre1(i)
                txt_nit.Text = nit1(i)
                txt_nodias.Text = no_dias1(i)
                txt_impuesto.Text = valor_im1(i)
                cb_tipohabi.Text = tipo_habitacion1(i)
                cb_tipopago.Text = tipo_pago1(i)
            End If

            i = i + 1
        End While

    End Sub

    Private Sub BUSCARVEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BUSCARVEToolStripMenuItem.Click
        For i = 0 To 6
            nombre1(i) = Nothing
            nit1(i) = Nothing
            no_dias1(i) = Nothing
            valor_im1(i) = Nothing
            tipo_habitacion1(i) = Nothing
            tipo_pago1(i) = Nothing
            total_pagar1(i) = Nothing
            descuento1(i) = Nothing
            recar1(i) = Nothing
            total_final1(i) = Nothing
        Next i
    End Sub
End Class
