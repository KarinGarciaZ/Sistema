Imports System.Data.SqlClient
Public Class frmConsEmpleados

    Dim conexionsql As SqlConnection = openConection()
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader

    Private Sub radioPuesto_CheckedChanged(sender As Object, e As EventArgs) Handles radioPuesto.CheckedChanged
        If radioPuesto.Checked = True Then
            dgEmpleados.Rows.Clear()
            cboPuesto.Visible = True
        Else
            cboPuesto.Visible = False
        End If
    End Sub

    Private Sub frmConsEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()
    End Sub

    Private Sub radioGeneral_CheckedChanged(sender As Object, e As EventArgs) Handles radioGeneral.CheckedChanged
        If radioGeneral.Checked Then
            dgEmpleados.Rows.Clear()
            Dim R As String
            R = "SELECT * FROM Empleados"
            comando.CommandText = R
            lector = comando.ExecuteReader

            While lector.Read
                dgEmpleados.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(11))
            End While
            lector.Close()
        End If
    End Sub

    Private Sub cboPuesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPuesto.SelectedIndexChanged
        dgEmpleados.Rows.Clear()
        Dim R As String
        R = "SELECT * FROM Empleados WHERE puesto = '" & cboPuesto.Text & "'"
        comando.CommandText = R
        lector = comando.ExecuteReader

        While lector.Read
            dgEmpleados.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(11))
        End While
        lector.Close()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub
End Class