Imports System.Data.SqlClient
Public Class frmConsPrestamo
    Dim conexionsql As SqlConnection = openConection()
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader
    Private Sub rbID_CheckedChanged(sender As Object, e As EventArgs) Handles rbID.CheckedChanged
        dtpFecha.Visible = False
        txtID.Visible = True
        txtEmpleado.Visible = False
        txtID.Text = ""
        txtEmpleado.Text = ""
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub

    Private Sub frmConsPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()
    End Sub

    Private Sub rbEmpleado_CheckedChanged(sender As Object, e As EventArgs) Handles rbEmpleado.CheckedChanged
        dtpFecha.Visible = False
        txtID.Visible = False
        txtEmpleado.Visible = True
        txtID.Text = ""
        txtEmpleado.Text = ""
    End Sub

    Private Sub rbFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbFecha.CheckedChanged
        dtpFecha.Visible = True
        txtID.Visible = False
        txtEmpleado.Visible = False
        txtID.Text = ""
        txtEmpleado.Text = ""
    End Sub

    Private Sub rbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodos.CheckedChanged
        dtpFecha.Visible = False
        txtID.Visible = False
        txtEmpleado.Visible = False
        txtID.Text = ""
        txtEmpleado.Text = ""
        dgPrestamo.Rows.Clear()
        Dim fecha As Date
        comando.CommandText = "select PrestamosMateriales.idPrestamo, Empleados.nombre, PrestamosMateriales.fecha, PrestamosMateriales.concepto from PrestamosMateriales inner join Empleados on PrestamosMateriales.idEmpleado = Empleados.idEmpleado"
        lector = comando.ExecuteReader
        While lector.Read
            fecha = lector(2)
            dgPrestamo.Rows.Add(lector(0), lector(1), fecha.Date, lector(3))
        End While
        lector.Close()
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        If Not txtID.Text.Contains("'") And txtID.TextLength > 0 Then
            If Char.IsNumber(txtID.Text.Chars(txtID.TextLength - 1)) Then
                dgPrestamo.Rows.Clear()
                Dim fecha As Date
                comando.CommandText = "select PrestamosMateriales.idPrestamo, Empleados.nombre, PrestamosMateriales.fecha, PrestamosMateriales.concepto from PrestamosMateriales inner join Empleados on PrestamosMateriales.idEmpleado = Empleados.idEmpleado where PrestamosMateriales.idPrestamo = " & txtID.Text & ""
                lector = comando.ExecuteReader
                While lector.Read
                    fecha = lector(2)
                    dgPrestamo.Rows.Add(lector(0), lector(1), fecha.Date, lector(3))
                End While
                lector.Close()
            Else
                MessageBox.Show("Solo números.")
                txtID.Text = ""
            End If
        Else
            Dim cadena As String = ""
            For i = 0 To txtID.Text.Length - 2
                cadena += txtID.Text.Chars(i)
            Next
            txtID.Text = cadena
        End If
    End Sub

    Private Sub txtEmpleado_TextChanged(sender As Object, e As EventArgs) Handles txtEmpleado.TextChanged
        If Not txtEmpleado.Text.Contains("'") Then
            dgPrestamo.Rows.Clear()
            Dim fecha As Date
            comando.CommandText = "select PrestamosMateriales.idPrestamo, Empleados.nombre, PrestamosMateriales.fecha, PrestamosMateriales.concepto from PrestamosMateriales inner join Empleados on PrestamosMateriales.idEmpleado = Empleados.idEmpleado where Empleados.nombre like '%" & txtEmpleado.Text & "%'"
            lector = comando.ExecuteReader
            While lector.Read
                fecha = lector(2)
                dgPrestamo.Rows.Add(lector(0), lector(1), fecha.Date, lector(3))
            End While
            lector.Close()
        Else
            Dim cadena As String = ""
            For i = 0 To txtEmpleado.Text.Length - 2
                cadena += txtEmpleado.Text.Chars(i)
            Next
            txtEmpleado.Text = cadena
        End If
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        dgPrestamo.Rows.Clear()
        Dim fecha As Date
        comando.CommandText = "select PrestamosMateriales.idPrestamo, Empleados.nombre, PrestamosMateriales.fecha, PrestamosMateriales.concepto from PrestamosMateriales inner join Empleados on PrestamosMateriales.idEmpleado = Empleados.idEmpleado where PrestamosMateriales.fecha = '" & dtpFecha.Value.Date & "'"
        lector = comando.ExecuteReader
        While lector.Read
            fecha = lector(2)
            dgPrestamo.Rows.Add(lector(0), lector(1), fecha.Date, lector(3))
        End While
        lector.Close()
    End Sub

    Private Sub dgPrestamo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPrestamo.CellClick
        dgPrestamo.CurrentRow.Selected = True
        Dim id As Integer = dgPrestamo.Item(0, dgPrestamo.CurrentRow.Index).Value
        dgDetalle.Rows.Clear()
        comando.CommandText = "select DetallePrestamosMateriales.idMaterial, Materiales.descripcion, DetallePrestamosMateriales.cantidad from DetallePrestamosMateriales inner join Materiales on DetallePrestamosMateriales.idMaterial = Materiales.idMaterial where DetallePrestamosMateriales.idPrestamo = " & id & ""
        lector = comando.ExecuteReader
        While lector.Read
            dgDetalle.Rows.Add(lector(0), lector(1), lector(2))
        End While
        lector.Close()
    End Sub
End Class