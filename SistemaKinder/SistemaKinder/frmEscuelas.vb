Imports System.Data.SqlClient
Public Class frmEscuelas

    Dim conexionsql As New SqlConnection("Data Source = 'KARINSPC'; Initial catalog = 'bdKinder'; Integrated security = 'true'")
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader

    Private Sub frmEscuelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        gbEscuela.Enabled = True
        txtNombreOficial.Enabled = True
        txtNombreConocido.Enabled = True
        txtMunicipio.Enabled = True
        comando.CommandText = "SELECT COUNT(*) FROM Escuelas"
        txtCodigo.Text = comando.ExecuteScalar + 1

        cmdNuevo.Enabled = False
        cmdGuardar.Enabled = True

    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim cod As Integer = txtCodigo.Text
        Dim ofi As String = txtNombreOficial.Text
        Dim nom As String = txtNombreConocido.Text
        Dim mun As String = txtMunicipio.Text

        Dim R As String
        R = "INSERT INTO Escuelas(codigo, nombreOficial, nombreConocido, Municipio) VALUES(" & cod & ",'" & ofi & "','" & nom & "','" & mun & "')"
        comando.CommandText = R
        comando.ExecuteNonQuery()

        txtCodigo.Text = ""
        txtNombreOficial.Text = ""
        txtNombreConocido.Text = ""
        txtMunicipio.Text = ""
        txtNombreOficial.Enabled = False
        txtNombreConocido.Enabled = False
        txtMunicipio.Enabled = False
        cmdGuardar.Enabled = False
        cmdNuevo.Enabled = True

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub
End Class