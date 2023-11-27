Imports System.Data.SqlClient

Public Class Cliente
    Dim connectionString As String = "Data Source=LAPTOP-M9JG8B6B\SQLEXPRESS02; Initial Catalog=BANCO; Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar datos al iniciar el formulario
        LoadData()
    End Sub

    Private Sub LoadData()
        ' Cargar datos en el DataGridView
        Dim query As String = "SELECT * FROM Cliente"
        Dim adapter As New SqlDataAdapter(query, connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        ' Agregar un nuevo cliente
        Dim query As String = "INSERT INTO Cliente (id_cliente, nombre_c, ap_pat_c, ape_mat_c, direccion_c, ciudad_c, telefono_c, correo_c, id_sucursal) VALUES (@id_cliente, @nombre_c, @ap_pat_c, @ape_mat_c, @direccion_c, @ciudad_c, @telefono_c, @correo_c, @id_sucursal)"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("id_cliente", txtIdCliente.Text)
            cmd.Parameters.AddWithValue("@nombre_c", txtNombre.Text)
            cmd.Parameters.AddWithValue("@ap_pat_c", TxtApPat.Text)
            cmd.Parameters.AddWithValue("@ape_mat_c", TxtApMat.Text)
            cmd.Parameters.AddWithValue("@direccion_c", txtDireccion.Text)
            cmd.Parameters.AddWithValue("@ciudad_c", txtCiudad.Text)
            cmd.Parameters.AddWithValue("@telefono_c", txtTelefono.Text)
            cmd.Parameters.AddWithValue("@correo_c", txtCorreo.Text)
            cmd.Parameters.AddWithValue("@id_sucursal", txtIdSucursal.Text)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de agregar
        LoadData()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        ' Actualizar un cliente existente
        Dim query As String = "UPDATE Cliente SET nombre_c = @nombre_c, ap_pat_c = @ap_pat_c, ape_mat_c = @ape_mat_c, direccion_c = @direccion_c, ciudad_c = @ciudad_c, telefono_c = @telefono_c, correo_c = @correo_c, id_sucursal = @id_sucursal WHERE id_cliente = @id_cliente"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@nombre_c", txtNombree.Text)
            cmd.Parameters.AddWithValue("@ap_pat_c", txtApPatt.Text)
            cmd.Parameters.AddWithValue("@ape_mat_c", txtApMatt.Text)
            cmd.Parameters.AddWithValue("@direccion_c", txtDireccionn.Text)
            cmd.Parameters.AddWithValue("@ciudad_c", txtCiudadd.Text)
            cmd.Parameters.AddWithValue("@telefono_c", txtTelefonoo.Text)
            cmd.Parameters.AddWithValue("@correo_c", txtCorreoo.Text)
            cmd.Parameters.AddWithValue("@id_sucursal", txtIdSucursal.Text)
            cmd.Parameters.AddWithValue("@id_cliente", DataGridView1.CurrentRow.Cells("id_cliente").Value)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de actualizar
        LoadData()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ' Eliminar un cliente
        Dim query As String = "DELETE FROM Cliente WHERE id_cliente=@id_cliente"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@id_cliente", DataGridView1.CurrentRow.Cells("id_cliente").Value)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de eliminar
        LoadData()
    End Sub
End Class