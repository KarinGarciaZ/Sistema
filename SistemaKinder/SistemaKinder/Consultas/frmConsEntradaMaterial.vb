Imports System.Data.SqlClient
Public Class frmConsEntradaMaterial
    Dim conexionsql As New SqlConnection("Data Source = 'KARINSPC'; Initial catalog = 'bdKinder'; Integrated security = 'true'")
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader
    Private Sub frmConsEntradaMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        If Not txtID.Text.Contains("'") And txtID.TextLength > 0 Then
            If Char.IsNumber(txtID.Text.Chars(txtID.TextLength - 1)) Then
                dgEntrada.Rows.Clear()
                Dim fecha As Date
                comando.CommandText = "select idEntrada, proveedor, fecha, subtotal, iva, total from EntradaMaterial where idEntrada = " & txtID.Text & ""
                lector = comando.ExecuteReader
                While lector.Read
                    fecha = lector(2)
                    dgEntrada.Rows.Add(lector(0), lector(1), fecha.Date, lector(3), lector(4), lector(5))
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

    Private Sub rbFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbFecha.CheckedChanged
        dtpFecha.Visible = True
        txtID.Visible = False
        txtProveedor.Visible = False
        txtID.Text = ""
        txtProveedor.Text = ""
    End Sub

    Private Sub rbProveedor_CheckedChanged(sender As Object, e As EventArgs) Handles rbProveedor.CheckedChanged
        dtpFecha.Visible = False
        txtID.Visible = False
        txtProveedor.Visible = True
        txtID.Text = ""
        txtProveedor.Text = ""
    End Sub

    Private Sub rbID_CheckedChanged(sender As Object, e As EventArgs) Handles rbID.CheckedChanged
        dtpFecha.Visible = False
        txtID.Visible = True
        txtProveedor.Visible = False
        txtID.Text = ""
        txtProveedor.Text = ""
    End Sub

    Private Sub txtProveedor_TextChanged(sender As Object, e As EventArgs) Handles txtProveedor.TextChanged
        If Not txtProveedor.Text.Contains("'") Then
            dgEntrada.Rows.Clear()
            Dim fecha As Date
            comando.CommandText = "select idEntrada, proveedor, fecha, subtotal, iva, total from EntradaMaterial where proveedor like '%" & txtProveedor.Text & "%'"
            lector = comando.ExecuteReader
            While lector.Read
                fecha = lector(2)
                dgEntrada.Rows.Add(lector(0), lector(1), fecha.Date, lector(3), lector(4), lector(5))
            End While
            lector.Close()
        Else
            Dim cadena As String = ""
            For i = 0 To txtProveedor.Text.Length - 2
                cadena += txtProveedor.Text.Chars(i)
            Next
            txtProveedor.Text = cadena
        End If
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        dgEntrada.Rows.Clear()
        Dim fecha As Date
        comando.CommandText = "select idEntrada, proveedor, fecha, subtotal, iva, total from EntradaMaterial where fecha = '" & dtpFecha.Value.Date & "'"
        lector = comando.ExecuteReader
        While lector.Read
            fecha = lector(2)
            dgEntrada.Rows.Add(lector(0), lector(1), fecha.Date, lector(3), lector(4), lector(5))
        End While
        lector.Close()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub

    Private Sub rbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodos.CheckedChanged
        dtpFecha.Visible = False
        txtID.Visible = False
        txtProveedor.Visible = False
        txtID.Text = ""
        txtProveedor.Text = ""
        dgEntrada.Rows.Clear()
        Dim fecha As Date
        comando.CommandText = "select idEntrada, proveedor, fecha, subtotal, iva, total from EntradaMaterial"
        lector = comando.ExecuteReader
        While lector.Read
            fecha = lector(2)
            dgEntrada.Rows.Add(lector(0), lector(1), fecha.Date, lector(3), lector(4), lector(5))
        End While
        lector.Close()
    End Sub

    Private Sub dgEntrada_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEntrada.CellClick
        dgEntrada.CurrentRow.Selected = True
        Dim id As Integer = dgEntrada.Item(0, dgEntrada.CurrentRow.Index).Value
        dgDetalle.Rows.Clear()
        comando.CommandText = "select DetalleEntradaMaterial.idMaterial, Materiales.descripcion, DetalleEntradaMaterial.cantidad, DetalleEntradaMaterial.costo from DetalleEntradaMaterial inner join Materiales on DetalleEntradaMaterial.idMaterial = Materiales.idMaterial where DetalleEntradaMaterial.idEntrada = " & id & ""
        lector = comando.ExecuteReader
        While lector.Read
            dgDetalle.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(2) * lector(3))
        End While
        lector.Close()
    End Sub
End Class