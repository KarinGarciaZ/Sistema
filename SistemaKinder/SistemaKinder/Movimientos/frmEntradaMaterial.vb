Imports System.Data.SqlClient
Public Class frmEntradaMaterial
    Dim conexionsql As New SqlConnection("Data Source = 'KARINSPC'; Initial catalog = 'bdKinder'; Integrated security = 'true'")
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader


    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        txtProveedor.Enabled = True
        dtpFecha.Enabled = True
        txtCantidad.Enabled = True
        txtCosto.Enabled = True
        txtBuscar.Enabled = True
        cmdNuevo.Enabled = False
        Dim n As Integer
        comando.CommandText = "select count(*) from EntradaMaterial"
        n = comando.ExecuteScalar()
        txtIdEntrada.Text = n + 1
    End Sub

    Private Sub frmEntradaMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        If dgAgregar.Rows.Count > 0 And Not txtProveedor.Text.Equals("") Then
            txtProveedor.Enabled = False
            txtSubtotal.Enabled = False
            dtpFecha.Enabled = False
            txtIVA.Enabled = False
            txtTotal.Enabled = False
            txtCantidad.Enabled = False
            txtCosto.Enabled = False
            cmdGrabar.Enabled = False
            cmdNuevo.Enabled = True
            txtBuscar.Enabled = False
            Dim cantidad As Double
            Dim costo As Double
            Dim idMat As Integer
            For i = 0 To dgAgregar.Rows.Count - 1
                cantidad = dgAgregar.Item(2, i).Value
                idMat = dgAgregar.Item(0, i).Value
                costo = dgAgregar.Item(3, i).Value
                comando.CommandText = "update Materiales set existencias += " & cantidad & ", costo = " & costo & ", ultimaFechaCompra = '" & dtpFecha.Value.Date & "' where idMaterial = " & idMat & ""
                comando.ExecuteNonQuery()
                comando.CommandText = "insert into DetalleEntradaMaterial values(" & txtIdEntrada.Text & "," & idMat & "," & cantidad & "," & costo & ")"
                comando.ExecuteNonQuery()
            Next
            comando.CommandText = "insert into EntradaMaterial values(" & txtIdEntrada.Text & ",'" & txtProveedor.Text & "','" & dtpFecha.Value.Date & "'," & txtIVA.Text & "," & txtSubtotal.Text & "," & txtTotal.Text & ")"
            comando.ExecuteNonQuery()
            txtIdEntrada.Text = ""
            txtIVA.Text = ""
            txtProveedor.Text = ""
            txtSubtotal.Text = ""
            txtTotal.Text = ""
            dgAgregar.Rows.Clear()
        Else
            MsgBox("Asegure poner el proveedor y materiales de compa")
        End If

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If Not txtBuscar.Text.Contains("'") Then
            dgBusqueda.Rows.Clear()
            Dim dia As Date
            comando.CommandText = "select idMaterial, descripcion, existencias, costo, ultimaFechaCompra from Materiales where descripcion like '%" & txtBuscar.Text & "%'"
            lector = comando.ExecuteReader
            While lector.Read
                dia = lector(4)
                dgBusqueda.Rows.Add(lector(0), lector(1), lector(2), lector(3), dia.Date)
            End While
            lector.Close()
        Else
            Dim cadena As String = ""
            For i = 0 To txtBuscar.Text.Length - 2
                cadena += txtBuscar.Text.Chars(i)
            Next
            txtBuscar.Text = cadena

        End If

    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If dgBusqueda.Rows.Count > 0 And Not txtCantidad.Text.Equals("") And Not txtCosto.Text.Equals("") Then
            Dim pos As Integer = dgBusqueda.Item(0, dgBusqueda.CurrentRow.Index).Value
            Dim nombre As String = dgBusqueda.Item(1, dgBusqueda.CurrentRow.Index).Value
            txtSubtotal.Text = CDbl(txtSubtotal.Text) + (CDbl(txtCantidad.Text) * CDbl(txtCosto.Text))
            txtIVA.Text = CDbl(txtSubtotal.Text) * 0.16
            txtTotal.Text = CDbl(txtSubtotal.Text) * 1.16
            dgAgregar.Rows.Add(pos, nombre, txtCantidad.Text, txtCosto.Text, CDbl(txtCantidad.Text) * CDbl(txtCosto.Text))
            txtCosto.Text = ""
            txtCantidad.Text = ""
            txtBuscar.Text = ""
            dgBusqueda.Rows.Clear()
        Else
            MsgBox("Asegure llenar los campos y haber seleccionado un material.")
        End If

    End Sub


    'Private Sub txtCantidad_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCantidad.KeyUp
    '    If (Not Char.IsNumber(ChrW(e.KeyCode))) Then
    '        MessageBox.Show("Solo números.")
    '        txtCantidad.Text = ""
    '    End If
    'End Sub

    'Private Sub txtCosto_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCosto.KeyUp
    '    If (Not Char.IsNumber(ChrW(e.KeyCode))) Then
    '        MessageBox.Show("Solo números.")
    '        txtCosto.Text = ""
    '    End If
    'End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        If txtCantidad.TextLength > 0 Then
            If Not Char.IsNumber(txtCantidad.Text.Chars(txtCantidad.TextLength - 1)) And Not txtCantidad.Text.Chars(txtCantidad.TextLength - 1) = "." Then
                MessageBox.Show("Solo números.")
                txtCantidad.Text = ""
            End If
        End If
    End Sub

    Private Sub txtCosto_TextChanged(sender As Object, e As EventArgs) Handles txtCosto.TextChanged
        If txtCosto.TextLength > 0 Then
            If Not Char.IsNumber(txtCosto.Text.Chars(txtCosto.TextLength - 1)) And Not txtCosto.Text.Chars(txtCosto.TextLength - 1) = "." Then
                MessageBox.Show("Solo números.")
                txtCosto.Text = ""
            End If
        End If
    End Sub

    Private Sub dgBusqueda_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBusqueda.CellClick
        dgBusqueda.CurrentRow.Selected = True
    End Sub



    'Private Sub dgAgregar_SelectionChanged(sender As Object, e As EventArgs) Handles dgAgregar.SelectionChanged
    '    txt.Text = dgGastos.Item(0, dgGastos.CurrentRow.Index).Value
    'End Sub
End Class