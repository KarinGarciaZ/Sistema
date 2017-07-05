Imports System.Data.SqlClient
Public Class frmDiscapacidades

    Dim conexionsql As SqlConnection = openConection()
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim R As String
        R = "SELECT COUNT(*) FROM Discapacidades"
        comando.CommandText = R
        txtIdDiscapacidad.Text = comando.ExecuteScalar + 1

        txtNombre.Enabled = True
        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub

    Private Sub frmDiscapacidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        If Not txtNombre.Text.Contains("'") And Not txtNombre.Text.Equals("") Then
            Dim R As String
            Dim id As Integer = txtIdDiscapacidad.Text
            Dim nombre As String = txtNombre.Text
            R = "INSERT INTO Discapacidades (idDiscapacidad,Nombre) VALUES (" & id & ",'" & nombre & "')"
            comando.CommandText = R
            comando.ExecuteNonQuery()
            txtNombre.Enabled = False
            txtNombre.Text = ""
            txtIdDiscapacidad.Text = ""
            cmdNuevo.Enabled = True
            cmdGrabar.Enabled = False
        Else
            MessageBox.Show("Introduzca un nombre válido")
        End If

    End Sub

End Class