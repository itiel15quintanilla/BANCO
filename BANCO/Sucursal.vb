Imports System.Data.SqlClient

Public Class Sucursal
    Dim connectionString As String = "Data Source=LAPTOP-M9JG8B6B\SQLEXPRESS02; Initial Catalog=BANCO; Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    Private Sub Sucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar datos al iniciar el formulario
        LoadData()
    End Sub

    Private Sub LoadData()
        ' Cargar datos en el DataGridView
        Dim query As String = "SELECT * FROM Sucursal"
        Dim adapter As New SqlDataAdapter(query, connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        ' Agregar una nueva sucursal
        Dim query As String = "INSERT INTO Sucursal (id_sucursal,nombre_s, direccion_s, ciudad_s, telefono_s, correo_s) VALUES (@id_sucursal, @nombre_s, @direccion_s, @ciudad_s, @telefono_s, @correo_s)"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("id_sucursal", txtIdSucursal.Text)
            cmd.Parameters.AddWithValue("@nombre_s", txtNombre.Text)
            cmd.Parameters.AddWithValue("@direccion_s", txtDireccion.Text)
            cmd.Parameters.AddWithValue("@ciudad_s", txtCiudad.Text)
            cmd.Parameters.AddWithValue("@telefono_s", txtTelefono.Text)
            cmd.Parameters.AddWithValue("@correo_s", txtCorreo.Text)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de agregar
        LoadData()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        ' Actualizar una sucursal existente
        Dim query As String = "UPDATE Sucursal SET nombre_s = @nombre_s, direccion_s = @direccion_s, ciudad_s = @ciudad_s, telefono_s = @telefono_s, correo_s = @correo_s WHERE id_sucursal = @id_sucursal"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@nombre_s", txtNombree.Text)
            cmd.Parameters.AddWithValue("@direccion_s", txtDireccionn.Text)
            cmd.Parameters.AddWithValue("@ciudad_s", txtCiudadd.Text)
            cmd.Parameters.AddWithValue("@telefono_s", txtTelefonoo.Text)
            cmd.Parameters.AddWithValue("@correo_s", txtCorreoo.Text)
            cmd.Parameters.AddWithValue("@id_sucursal", DataGridView1.CurrentRow.Cells("id_sucursal").Value)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de actualizar
        LoadData()

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ' Eliminar una sucursal
        Dim query As String = "DELETE FROM Sucursal WHERE id_sucursal=@id_sucursal"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@id_sucursal", DataGridView1.CurrentRow.Cells("id_sucursal").Value)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de eliminar
        LoadData()

    End Sub
End Class