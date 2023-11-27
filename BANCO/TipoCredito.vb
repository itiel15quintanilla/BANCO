Imports System.Data.SqlClient

Public Class TipoCredito
    Dim connectionString As String = "Data Source=LAPTOP-M9JG8B6B\SQLEXPRESS02; Initial Catalog=BANCO; Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    Private Sub TipoCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar datos al iniciar el formulario
        LoadData()
    End Sub

    Private Sub LoadData()
        ' Cargar datos en el DataGridView
        Dim query As String = "SELECT * FROM TipoCredito"
        Dim adapter As New SqlDataAdapter(query, connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        ' Agregar un nuevo tipo de credito
        Dim query As String = "INSERT INTO TipoCredito (id_tipo_credito, tipo_credito) VALUES (@id_tipo_credito, @tipo_credito)"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("id_tipo_credito", txtIdTipoCredito.Text)
            cmd.Parameters.AddWithValue("@tipo_credito", txtTipoCredito.Text)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de agregar
        LoadData()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        ' Actualizar un tipo de credito existente
        Dim query As String = "UPDATE TipoCredito SET tipo_credito = @tipo_credito WHERE id_tipo_credito = @id_tipo_credito"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@tipo_credito", txtTipoCreditoo.Text)
            cmd.Parameters.AddWithValue("@id_tipo_credito", DataGridView1.CurrentRow.Cells("id_tipo_credito").Value)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de actualizar
        LoadData()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ' Eliminar un tipo de credito
        Dim query As String = "DELETE FROM TipoCredito WHERE id_tipo_credito=@id_tipo_credito"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@id_tipo_credito", DataGridView1.CurrentRow.Cells("id_tipo_credito").Value)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de eliminar
        LoadData()
    End Sub
End Class