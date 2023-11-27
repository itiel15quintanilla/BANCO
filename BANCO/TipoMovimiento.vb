Imports System.Data.SqlClient

Public Class TipoMovimiento
    Dim connectionString As String = "Data Source=LAPTOP-M9JG8B6B\SQLEXPRESS02; Initial Catalog=BANCO; Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    Private Sub TipoMovimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar datos al iniciar el formulario
        LoadData()
    End Sub

    Private Sub LoadData()
        ' Cargar datos en el DataGridView
        Dim query As String = "SELECT * FROM TipoMovimiento"
        Dim adapter As New SqlDataAdapter(query, connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        ' Agregar un nuevo tipo de movimiento
        Dim query As String = "INSERT INTO TipoMovimiento (id_tipo_movimiento, tipo_movimiento) VALUES (@id_tipo_movimiento, @tipo_movimiento)"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("id_tipo_movimiento", txtIdTipoMov.Text)
            cmd.Parameters.AddWithValue("@tipo_movimiento", txtTipoMov.Text)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de agregar
        LoadData()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        ' Actualizar un tipo de movimiento existente
        Dim query As String = "UPDATE TipoCuenta SET tipo_movimiento = @tipo_movimineto WHERE id_tipo_movimiento = @id_tipo_movimiento"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@tipo_movimiento", txtTipoMovv.Text)
            cmd.Parameters.AddWithValue("@id_tipo_movimiento", DataGridView1.CurrentRow.Cells("id_tipo_movimiento").Value)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de actualizar
        LoadData()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ' Eliminar un tipo de movimiento
        Dim query As String = "DELETE FROM TipoMovimiento WHERE id_tipo_movimiento=@id_tipo_movimiento"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@id_tipo_movimiento", DataGridView1.CurrentRow.Cells("id_tipo_movimiento").Value)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de eliminar
        LoadData()
    End Sub
End Class