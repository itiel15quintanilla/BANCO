Imports System.Data.SqlClient

Public Class Movimiento
    Dim connectionString As String = "Data Source=LAPTOP-M9JG8B6B\SQLEXPRESS02; Initial Catalog=BANCO; Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)


    Private Sub Movimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar datos al iniciar el formulario
        LoadData()
    End Sub

    Private Sub LoadData()
        ' Cargar datos en el DataGridView
        Dim query As String = "SELECT * FROM Movimiento"
        Dim adapter As New SqlDataAdapter(query, connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        ' Agregar un nuevo movimiento 
        Dim query As String = "INSERT INTO Movimiento (id_movimiento ,fecha_movimiento, importe_movimiento, id_tipo_movimiento, id_cuenta) VALUES (@id_movimiento, @fecha_movimiento, @importe_movimiento, @id_tipo_movimiento, @id_cuenta)"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("id_movimiento", txtIdMov.Text)
            cmd.Parameters.AddWithValue("@fecha_movimiento", txtFecha.Text)
            cmd.Parameters.AddWithValue("@importe_movimiento", txtImporte.Text)
            cmd.Parameters.AddWithValue("@id_tipo_movimiento", txtIdTipoMov.Text)
            cmd.Parameters.AddWithValue("@id_cuenta", txtIdCuenta.Text)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de agregar
        LoadData()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        ' Actualizar un movimiento existente
        Dim query As String = "UPDATE Movimiento SET fecha_movimiento = @fecha_movimiento, importe_movimiento = @importe_movimiento, id_tipo_movimiento = @id_tipo_movimiento, id_cuenta = @id_cuenta WHERE id_movimiento = @id_movimiento"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@fecha_movimiento", txtFechaa.Text)
            cmd.Parameters.AddWithValue("@importe_movimiento", txtImportee.Text)
            cmd.Parameters.AddWithValue("@id_tipo_movimiento", txtIdTipoMovv.Text)
            cmd.Parameters.AddWithValue("@id_cuenta", TxtIdCuentaa.Text)
            cmd.Parameters.AddWithValue("@id_movimiento", DataGridView1.CurrentRow.Cells("id_movimiento").Value)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de actualizar
        LoadData()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ' Eliminar un movimiento 
        Dim query As String = "DELETE FROM Movimiento WHERE id_movimiento=@id_movimiento"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@id_movimiento", DataGridView1.CurrentRow.Cells("id_movimiento").Value)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de eliminar
        LoadData()
    End Sub
End Class