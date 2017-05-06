Imports System.Data.SqlClient
Public Class frmGastos
    Dim conexionsql As New SqlConnection("Data Source = 'KARINSPC'; Initial catalog = 'bdKinder'; Integrated security = 'true'")
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader
    Private Sub frmGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()

    End Sub


    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub



    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If Not txtBuscar.Text.Contains("'") Then
            dgGastos.Rows.Clear()
            comando.CommandText = "select nombre, apellidoPaterno, apellidoMaterno, telefono, eMail, puesto, idEmpleado from Empleados where nombre like '%" & txtBuscar.Text & "%'"
            lector = comando.ExecuteReader
            While lector.Read
                dgGastos.Rows.Add(lector(6), lector(0), lector(1), lector(2), lector(3), lector(4), lector(5))
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

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        txtBuscar.Enabled = True
        txtConcepto.Enabled = True
        dtpFecha.Enabled = True
        txtIdGasto.Enabled = True
        txtImporte.Enabled = True
        comando.CommandText = "select count(*) from Gastos"
        Dim n As Integer = comando.ExecuteScalar
        txtIdGasto.Text = n + 1
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        If Not txtImporte.Text.Equals("") And Not txtConcepto.Text.Equals("") Then
            Dim idEmp As Integer = dgGastos.Item(0, dgGastos.CurrentRow.Index).Value
            comando.CommandText = "insert into Gastos values(" & txtIdGasto.Text & "," & idEmp & ",'" & txtConcepto.Text & "','" & dtpFecha.Value.Date & "'," & txtImporte.Text & ")"
            comando.ExecuteNonQuery()
            txtBuscar.Enabled = False
            txtConcepto.Enabled = False
            dtpFecha.Enabled = False
            txtIdGasto.Enabled = False
            txtImporte.Enabled = False
            txtBuscar.Text = ""
            txtConcepto.Text = ""
            txtImporte.Text = ""
            txtIdGasto.Text = ""
            dgGastos.Rows.Clear()
        Else
            MsgBox("Asegure que el concepto y el importe no esten vacíos.")
        End If

    End Sub

    'Private Sub txtImporte_KeyUp(sender As Object, e As KeyEventArgs) Handles txtImporte.KeyUp
    '    If (Not Char.IsNumber(ChrW(e.KeyCode))) Then
    '        MessageBox.Show("Solo números.")
    '        txtImporte.Text = ""
    '    End If
    'End Sub

    Private Sub txtImporte_TextChanged(sender As Object, e As EventArgs) Handles txtImporte.TextChanged
        If txtImporte.TextLength > 0 Then
            If Not Char.IsNumber(txtImporte.Text.Chars(txtImporte.TextLength - 1)) And Not txtImporte.Text.Chars(txtImporte.TextLength - 1) = "." Then
                MessageBox.Show("Solo números.")
                txtImporte.Text = ""
            End If
        End If
    End Sub

    Private Sub dgGastos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgGastos.CellClick
        dgGastos.CurrentRow.Selected = True
    End Sub


    'Private Sub dgGastos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgGastos.CellContentClick
    '    'txtid.Text = dgGastos.SelectedRows(0).Cells(0).ToString
    '    txtid.Text = dgGastos.Item(0, dgGastos.CurrentRow.Index).Value
    '    txtNombre.Text = dgGastos.Item(0, dgGastos.CurrentRow.Index).Value
    'End Sub
End Class