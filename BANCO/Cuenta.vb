Imports System.Data.SqlClient

Public Class Cuenta
    Dim connectionString As String = "Data Source=LAPTOP-M9JG8B6B\SQLEXPRESS02; Initial Catalog=BANCO; Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    Private Sub Cuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar datos al iniciar el formulario
        LoadData()
    End Sub

    Private Sub LoadData()
        ' Cargar datos en el DataGridView
        Dim query As String = "SELECT * FROM Cuenta"
        Dim adapter As New SqlDataAdapter(query, connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        ' Agregar una nueva cuenta
        Dim query As String = "INSERT INTO Cuenta (id_cuenta ,fecha_apertura, id_cliente, id_tipo_cuenta) VALUES (@id_cuenta, @fecha_apertura, @id_cliente, @id_tipo_cuenta)"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("id_cuenta", txtIdCuenta.Text)
            cmd.Parameters.AddWithValue("@fecha_apertura", txtFecha.Text)
            cmd.Parameters.AddWithValue("@id_cliente", txtIdCliente.Text)
            cmd.Parameters.AddWithValue("@id_tipo_cuenta", txtIdTipoCuenta.Text)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de agregar
        LoadData()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        ' Actualizar una cuenta existente
        Dim query As String = "UPDATE Cuenta SET fecha_apertura = @fecha_apertura, id_cliente = @id_cliente, id_tipo_cuenta = @id_tipo_cuenta WHERE id_cuenta = @id_cuenta"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@fecha_apertura", txtFechaa.Text)
            cmd.Parameters.AddWithValue("@id_cliente", txtIdClientee.Text)
            cmd.Parameters.AddWithValue("@id_tipo_cuenta", txtIdTipoCuentaa.Text)
            cmd.Parameters.AddWithValue("@id_cuenta", DataGridView1.CurrentRow.Cells("id_cuenta").Value)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de actualizar
        LoadData()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ' Eliminar una cuenta
        Dim query As String = "DELETE FROM Cuenta WHERE id_cuenta=@id_cuenta"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@id_cuenta", DataGridView1.CurrentRow.Cells("id_cuenta").Value)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de eliminar
        LoadData()
    End Sub
End Class