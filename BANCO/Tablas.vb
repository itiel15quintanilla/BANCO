Public Class Tablas

    Private Sub BtnSucursal_Click(sender As Object, e As EventArgs) Handles BtnSucursal.Click
        Sucursal.ShowDialog()
    End Sub

    Private Sub BtnCliente_Click(sender As Object, e As EventArgs) Handles BtnCliente.Click
        Cliente.ShowDialog()
    End Sub

    Private Sub BtnCuenta_Click(sender As Object, e As EventArgs) Handles BtnCuenta.Click
        Cuenta.ShowDialog()
    End Sub

    Private Sub BtnTipoCuena_Click(sender As Object, e As EventArgs) Handles BtnTipoCuena.Click
        TipoCuenta.ShowDialog()
    End Sub

    Private Sub BtnMov_Click(sender As Object, e As EventArgs) Handles BtnMov.Click
        Movimiento.ShowDialog()
    End Sub

    Private Sub BtnTipoMov_Click(sender As Object, e As EventArgs) Handles BtnTipoMov.Click
        TipoMovimiento.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Credito.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TipoCredito.ShowDialog()
    End Sub

    Private Sub BtnCalPago_Click(sender As Object, e As EventArgs) Handles BtnCalPago.Click
        CalendarioPago.ShowDialog()
    End Sub

    Private Sub BtnPago_Click(sender As Object, e As EventArgs) Handles BtnPago.Click
        Pago.ShowDialog()
    End Sub
End Class