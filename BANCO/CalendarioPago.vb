Imports System.Data.SqlClient

Public Class CalendarioPago
    Dim connectionString As String = "Data Source=LAPTOP-M9JG8B6B\SQLEXPRESS02; Initial Catalog=BANCO; Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    Private Sub CalendarioPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar datos al iniciar el formulario
        LoadData()
    End Sub

    Private Sub LoadData()
        ' Cargar datos en el DataGridView
        Dim query As String = "SELECT * FROM CalendarioPago"
        Dim adapter As New SqlDataAdapter(query, connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        ' Agregar un nuevo calendario
        Dim query As String = "INSERT INTO CalendarioPago (id_cal_pago ,fecha_pago, id_credito) VALUES (@id_cal_pago, @fecha_pago, @id_credito)"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("id_cal_pago", txtIdCalendario.Text)
            cmd.Parameters.AddWithValue("@fecha_pago", txtFecha.Text)
            cmd.Parameters.AddWithValue("@id_credito", txtIdCredito.Text)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de agregar
        LoadData()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        ' Actualizar un calendario existente
        Dim query As String = "UPDATE CalendarioPago SET fecha_pago = @fecha_pago, id_credito = @id_credito WHERE id_cal_pago = @id_cal_pago"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@fecha_pago", txtFechaa.Text)
            cmd.Parameters.AddWithValue("@id_credito", txtIdCreditoo.Text)
            cmd.Parameters.AddWithValue("@id_cal_pago", DataGridView1.CurrentRow.Cells("id_cal_pago").Value)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de actualizar
        LoadData()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ' Eliminar un calendario 
        Dim query As String = "DELETE FROM CalendarioPago WHERE id_cal_pago=@id_cal_pago"
        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@id_cal_pago", DataGridView1.CurrentRow.Cells("id_cal_pago").Value)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Recargar datos después de eliminar
        LoadData()
    End Sub
End Class