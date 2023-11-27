Imports System.Data.SqlClient

Public Class Pago
    Dim connectionString As String = "Data Source=LAPTOP-M9JG8B6B\SQLEXPRESS02; Initial Catalog=BANCO; Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    Private Sub Pago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar datos al iniciar el formulario
        LoadData()
    End Sub

    Private Sub LoadData()
        ' Cargar datos en el DataGridView
        Dim query As String = "SELECT * FROM Pago"
        Dim adapter As New SqlDataAdapter(query, connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        ' Agregar un nuevo pago
        Dim query As String = "INSERT INTO Pago (id_pago, monto, id_tipo_movimiento) VALUES (@id_pago, @monto, @id_tipo_movimiento)"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("id_pago", txtIdPago.Text)
            cmd.Parameters.AddWithValue("monto", txtMonto.Text)
            cmd.Parameters.AddWithValue("@id_tipo_movimiento", txtTipoMov.Text)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de agregar
        LoadData()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        ' Actualizar un pago existente
        Dim query As String = "UPDATE Pago SET monto = @monto, id_tipo_movimiento = @id_tipo_movimiento WHERE id_pago = @id_pago"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("monto", txtMontoo.Text)
            cmd.Parameters.AddWithValue("@id_tipo_movimiento", txtTipoMovv.Text)
            cmd.Parameters.AddWithValue("@id_pago", DataGridView1.CurrentRow.Cells("id_pago").Value)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de actualizar
        LoadData()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ' Eliminar un pago
        Dim query As String = "DELETE FROM Pago WHERE id_pago=@id_pago"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@id_pago", DataGridView1.CurrentRow.Cells("id_pago").Value)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de eliminar
        LoadData()
    End Sub
End Class