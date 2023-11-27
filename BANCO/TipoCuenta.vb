Imports System.Data.SqlClient

Public Class TipoCuenta
    Dim connectionString As String = "Data Source=LAPTOP-M9JG8B6B\SQLEXPRESS02; Initial Catalog=BANCO; Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    Private Sub TipoCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar datos al iniciar el formulario
        LoadData()
    End Sub

    Private Sub LoadData()
        ' Cargar datos en el DataGridView
        Dim query As String = "SELECT * FROM TipoCuenta"
        Dim adapter As New SqlDataAdapter(query, connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        ' Agregar un nuevo tipo de cuenta
        Dim query As String = "INSERT INTO TipoCuenta (id_tipo_cuenta, tipo_cuenta) VALUES (@id_tipo_cuenta, @tipo_cuenta)"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("id_tipo_cuenta", txtIdTipoCuenta.Text)
            cmd.Parameters.AddWithValue("@tipo_cuenta", txtTipoCuenta.Text)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de agregar
        LoadData()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        ' Actualizar una cuenta existente
        Dim query As String = "UPDATE TipoCuenta SET tipo_cuenta = @tipo_cuenta WHERE id_tipo_cuenta = @id_tipo_cuenta"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@tipo_cuenta", txtTipoCuentaa.Text)
            cmd.Parameters.AddWithValue("@id_tipo_cuenta", DataGridView1.CurrentRow.Cells("id_tipo_cuenta").Value)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de actualizar
        LoadData()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ' Eliminar un tipo de cuenta
        Dim query As String = "DELETE FROM TipoCuenta WHERE id_tipo_cuenta=@id_tipo_cuenta"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@id_tipo_cuenta", DataGridView1.CurrentRow.Cells("id_tipo_cuenta").Value)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de eliminar
        LoadData()
    End Sub
End Class