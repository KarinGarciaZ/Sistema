Imports System.Data.SqlClient
Public Class frmPrestamoMaterial
    Dim conexionsql As SqlConnection = openConection()
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader
    Private Sub frmPrestamoMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        comando.CommandText = "select count(*) from PrestamosMateriales"
        Dim n As Integer = comando.ExecuteScalar
        txtidPrestamo.Text = n + 1
        dtpFecha.Enabled = True
        txtConcepto.Enabled = True
        txtBuscarEmpleado.Enabled = True
        txtBuscarMaterial.Enabled = True
        txtCantidad.Enabled = True
        cmdAgregar.Enabled = True
        cmdGuardar.Enabled = True
        cmdNuevo.Enabled = False
    End Sub

    Private Sub txtBuscarEmpleado_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarEmpleado.TextChanged
        If Not txtBuscarEmpleado.Text.Contains("'") Then
            dgEmpleados.Rows.Clear()
            comando.CommandText = "select idEmpleado, nombre, apellidoPaterno, apellidoMaterno, puesto from Empleados where nombre like '%" & txtBuscarEmpleado.Text & "%'"
            lector = comando.ExecuteReader
            While lector.Read
                dgEmpleados.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
            End While
            lector.Close()
        Else
            Dim cadena As String = ""
            For i = 0 To txtBuscarEmpleado.Text.Length - 2
                cadena += txtBuscarEmpleado.Text.Chars(i)
            Next
            txtBuscarEmpleado.Text = cadena
        End If
    End Sub

    Private Sub txtBuscarMaterial_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarMaterial.TextChanged
        If Not txtBuscarMaterial.Text.Contains("'") Then
            dgBuscarMateriales.Rows.Clear()
            comando.CommandText = "select idMaterial, descripcion, existencias from Materiales where descripcion like '%" & txtBuscarMaterial.Text & "%'"
            lector = comando.ExecuteReader
            While lector.Read
                dgBuscarMateriales.Rows.Add(lector(0), lector(1), lector(2))
            End While
            lector.Close()
        Else
            Dim cadena As String = ""
            For i = 0 To txtBuscarMaterial.Text.Length - 2
                cadena += txtBuscarMaterial.Text.Chars(i)
            Next
            txtBuscarMaterial.Text = cadena
        End If
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        If dgBuscarMateriales.Rows.Count > 0 And Not txtCantidad.Text.Equals("") And IsNumeric(txtCantidad.Text) Then
            If Not CDbl(txtCantidad.Text) > 2147483647 And Not CDbl(txtCantidad.Text) < 1 Then
                If dgBuscarMateriales.Item(2, dgBuscarMateriales.CurrentRow.Index).Value >= CDbl(txtCantidad.Text) Then

                    Dim ban As Boolean = False
                    Dim pos As Integer
                    Dim id As Integer = dgBuscarMateriales.Item(0, dgBuscarMateriales.CurrentRow.Index).Value

                    For i = 0 To dgMateriales.Rows.Count - 1
                        If id = dgMateriales.Item(0, i).Value Then
                            pos = i
                            ban = True
                        End If
                    Next

                    If ban = False Then
                        Dim nombre As String = dgBuscarMateriales.Item(1, dgBuscarMateriales.CurrentRow.Index).Value
                        dgMateriales.Rows.Add(id, nombre, txtCantidad.Text)
                        txtCantidad.Text = ""
                        txtBuscarMaterial.Text = ""
                        dgBuscarMateriales.Rows.Clear()
                    Else
                        dgMateriales.Item(2, pos).Value += CDbl(txtCantidad.Text)
                    End If
                Else
                    MessageBox.Show("No hay suficientes materiales para realizar la operación")
                End If

            Else
                    MessageBox.Show("No se aceptan valores numericos mayores a 2,147,483,647 ó menores a 1")
            End If
        Else
            MsgBox("Asegure llenar los campos, haber seleccionado un material y poner un valor numérico.")
        End If
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        If txtCantidad.TextLength > 0 Then
            If Not Char.IsNumber(txtCantidad.Text.Chars(txtCantidad.TextLength - 1)) And Not txtCantidad.Text.Chars(txtCantidad.TextLength - 1) = "." Then
                MessageBox.Show("Solo números.")
                txtCantidad.Text = ""
            End If
        End If
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If Not txtConcepto.Text.Equals("") And dgMateriales.Rows.Count > 0 And dgEmpleados.Rows.Count > 0 Then
            txtConcepto.Enabled = False
            dtpFecha.Enabled = False
            txtBuscarEmpleado.Enabled = False
            txtBuscarMaterial.Enabled = False
            cmdAgregar.Enabled = False
            txtCantidad.Enabled = False
            cmdGuardar.Enabled = False
            cmdNuevo.Enabled = True
            Dim idEmpleado As Integer = dgEmpleados.Item(0, dgEmpleados.CurrentRow.Index).Value
            Dim idMat As Integer
            Dim cantidad As Decimal
            For i = 0 To dgMateriales.Rows.Count - 1
                idMat = dgMateriales.Item(0, i).Value
                cantidad = dgMateriales.Item(2, i).Value
                comando.CommandText = "update Materiales set existencias -= " & cantidad & " where idMaterial = " & idMat & ""
                comando.ExecuteNonQuery()
                comando.CommandText = "insert into DetallePrestamosMateriales values(" & txtidPrestamo.Text & "," & idMat & ", " & cantidad & ")"
                comando.ExecuteNonQuery()
            Next
            comando.CommandText = "insert into PrestamosMateriales values(" & txtidPrestamo.Text & "," & idEmpleado & ",'" & dtpFecha.Value.Date & "','" & txtConcepto.Text & "')"
            comando.ExecuteNonQuery()
            txtBuscarEmpleado.Text = ""
            txtConcepto.Text = ""
            txtidPrestamo.Text = ""
            dgMateriales.Rows.Clear()
            dgEmpleados.Rows.Clear()
        Else
            MsgBox("Asegure seleccionar un empleado, agregar materiales y poner un concepto.")
        End If
    End Sub

    Private Sub dgEmpleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEmpleados.CellClick
        dgEmpleados.CurrentRow.Selected = True
    End Sub

    Private Sub dgBuscarMateriales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBuscarMateriales.CellClick
        dgBuscarMateriales.CurrentRow.Selected = True
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        dgMateriales.Rows.Remove(dgMateriales.SelectedRows(0))
    End Sub

    Private Sub dgMateriales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMateriales.CellClick
        dgMateriales.CurrentRow.Selected = True
    End Sub
End Class