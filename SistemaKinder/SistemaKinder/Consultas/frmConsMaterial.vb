Imports System.Data.SqlClient
Public Class frmConsMaterial

    Dim conexionsql As New SqlConnection("Data Source = 'KARINSPC'; Initial catalog = 'bdKinder'; Integrated security = 'true'")
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader

    Private Sub frmConsMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()
        Dim R As String
        R = "SELECT * FROM Materiales"
        comando.CommandText = R
        lector = comando.ExecuteReader

        While lector.Read
            dgMateriales.Rows.Add(lector(0), lector(2), lector(1), lector(3), lector(4), lector(5), lector(6), lector(7))
        End While
        lector.Close()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub
End Class