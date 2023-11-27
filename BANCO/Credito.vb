Imports System.Data.SqlClient

Public Class Credito

    Dim connectionString As String = "Data Source=LAPTOP-M9JG8B6B\SQLEXPRESS02; Initial Catalog=BANCO; Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    Private Sub Credito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar datos al iniciar el formulario
        LoadData()
    End Sub

    Private Sub LoadData()
        ' Cargar datos en el DataGridView
        Dim query As String = "SELECT * FROM Credito"
        Dim adapter As New SqlDataAdapter(query, connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        ' Agregar un nuevo credito
        Dim query As String = "INSERT INTO Credito (id_credito , id_cliente, id_tipo_credito) VALUES (@id_credito, @id_cliente, @id_tipo_credito)"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("id_credito", txtIdCredito.Text)
            cmd.Parameters.AddWithValue("@id_cliente", txtIdCliente.Text)
            cmd.Parameters.AddWithValue("@id_tipo_credito", txtIdTipoCredito.Text)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de agregar
        LoadData()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        ' Actualizar un credito existente
        Dim query As String = "UPDATE Credito SET  id_cliente = @id_cliente, id_tipo_credito = @id_tipo_credito WHERE id_credito = @id_credito"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@id_cliente", txtIdClientee.Text)
            cmd.Parameters.AddWithValue("@id_tipo_credito", txtIdTipoCreditoo.Text)
            cmd.Parameters.AddWithValue("@id_credito", DataGridView1.CurrentRow.Cells("id_credito").Value)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de actualizar
        LoadData()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ' Eliminar una cuenta
        Dim query As String = "DELETE FROM Credito WHERE id_credito=@id_credito"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@id_credito", DataGridView1.CurrentRow.Cells("id_credito").Value)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de eliminar
        LoadData()
    End Sub
End Class