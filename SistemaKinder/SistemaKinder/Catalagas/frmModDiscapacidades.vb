Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class frmModDiscapacidades

    Dim conexionsql As SqlConnection = openConection()
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader

    Private Sub frmModDiscapacidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()
        Dim cont As Integer = 0
        Dim R As String

        R = "SELECT Discapacidades.idDiscapacidad, Discapacidades.nombre FROM Discapacidades"
        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read
            cboNombre.Items.Add(lector(1))
            cboId.Items.Add(lector(0))
            cont += 1
        End While
        lector.Close()

        Dim a(cont - 1) As String
        For x = 0 To cont - 1
            a(x) = cboNombre.Items(x)
        Next


        cboNombre.AutoCompleteCustomSource.AddRange(a)
        cboNombre.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cboNombre.AutoCompleteSource = AutoCompleteSource.CustomSource

    End Sub

    Private Sub cboNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNombre.SelectedIndexChanged
        cboId.Text = cboId.Items(cboNombre.SelectedIndex)
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub

    Private Sub cmdModificar_Click(sender As Object, e As EventArgs) Handles cmdModificar.Click
        txtNombre.Enabled = True
        cmdModificar.Enabled = False
        cmdGrabar.Enabled = True
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        Dim R As String
        If cboId.Text = "" Then
            MessageBox.Show("Seleccione un valor correcto")
        Else

            R = "UPDATE Discapacidades SET nombre = '" & txtNombre.Text & "' WHERE idDiscapacidad = " & cboId.Text & " AND nombre = '" & cboNombre.Text & "'"
            comando.CommandText = R
            comando.ExecuteNonQuery()

            txtNombre.Enabled = False
            cmdGrabar.Enabled = False
            cmdModificar.Enabled = True
        End If

    End Sub

    Private Sub txtNombre_Click(sender As Object, e As EventArgs) Handles txtNombre.Click
        If txtNombre.Text.Equals("") Then
            txtNombre.Select(0, 0)
        Else
            txtNombre.Select(txtNombre.Text.Length, 0)
        End If

    End Sub

    Private Sub cboNombre_Validating(sender As Object, e As CancelEventArgs) Handles cboNombre.Validating
        Dim cont As Integer = 0
        Dim R As String
        Dim ban As Boolean = False
        R = "SELECT Discapacidades.nombre FROM Discapacidades"
        comando.CommandText = R
        lector = comando.ExecuteReader

        While lector.Read
            If cboNombre.Text.Equals(lector(0)) Then
                ban = True
            End If

        End While
        lector.Close()

        If Not ban Then
            MessageBox.Show("Seleccione un nombre válido")
            cboNombre.Focus()
        End If
    End Sub
End Class