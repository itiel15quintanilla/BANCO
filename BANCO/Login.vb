Imports System.Data.SqlClient

Public Class Form1
    Dim conexion As New SqlConnection
    Dim comando As New SqlCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection("Data Source=LAPTOP-M9JG8B6B\SQLEXPRESS02; Initial Catalog=BANCO; Integrated Security=True")
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        conexion.Open()

        Dim consulta As String = "SELECT * FROM Usuario WHERE usuario = @usuario AND contrasena = @contrasena"
        comando = New SqlCommand(consulta, conexion)
        comando.Parameters.AddWithValue("@usuario", textBox1.Text)
        comando.Parameters.AddWithValue("@contrasena", textBox2.Text)

        Dim lector As SqlDataReader
        lector = comando.ExecuteReader()

        If lector.HasRows Then
            Tablas.ShowDialog()
        Else
            MessageBox.Show("Usuario o contraseña incorrecto")
        End If

        conexion.Close()
    End Sub

    Private Sub textBox2_TextChanged(sender As Object, e As EventArgs) Handles textBox2.TextChanged
        ' Configura la propiedad PasswordChar para mostrar asteriscos
        textBox2.PasswordChar = "*"
    End Sub
End Class

