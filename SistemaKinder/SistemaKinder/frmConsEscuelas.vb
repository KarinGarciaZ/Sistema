Imports System.Data.SqlClient
Public Class frmConsEscuelas

    Dim conexionsql As New SqlConnection("Data Source = 'KARINSPC'; Initial catalog = 'bdKinder'; Integrated security = 'true'")
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader

    Private Sub frmConsEscuelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()
        Dim R As String
        R = "SELECT * FROM Escuelas"
        comando.CommandText = R
        lector = comando.ExecuteReader

        While lector.Read
            dgEscuela.Rows.Add(lector(0), lector(1), lector(2), lector(3))
        End While
        lector.Close()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub
End Class