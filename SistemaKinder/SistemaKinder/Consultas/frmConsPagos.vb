Imports System.Data.SqlClient
Public Class frmConsPagos
    Dim conexionsql As New SqlConnection("Data Source = 'KARINSPC'; Initial catalog = 'bdKinder'; Integrated security = 'true'")
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader
    Private Sub rbID_CheckedChanged(sender As Object, e As EventArgs) Handles rbID.CheckedChanged
        txtID.Visible = True
        txtAlumno.Visible = False
        txtMatricula.Visible = False
        dtpFecha.Visible = False
        txtAlumno.Text = ""
        txtID.Text = ""
        txtMatricula.Text = ""
    End Sub

    Private Sub rbMatricula_CheckedChanged(sender As Object, e As EventArgs) Handles rbMatricula.CheckedChanged
        txtID.Visible = False
        txtAlumno.Visible = False
        txtMatricula.Visible = True
        dtpFecha.Visible = False
        txtAlumno.Text = ""
        txtID.Text = ""
        txtMatricula.Text = ""
    End Sub

    Private Sub rbAlumno_CheckedChanged(sender As Object, e As EventArgs) Handles rbAlumno.CheckedChanged
        txtID.Visible = False
        txtAlumno.Visible = True
        txtMatricula.Visible = False
        dtpFecha.Visible = False
        txtAlumno.Text = ""
        txtID.Text = ""
        txtMatricula.Text = ""
    End Sub

    Private Sub rbFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbFecha.CheckedChanged
        txtID.Visible = False
        txtAlumno.Visible = False
        txtMatricula.Visible = False
        dtpFecha.Visible = True
        txtAlumno.Text = ""
        txtID.Text = ""
        txtMatricula.Text = ""
    End Sub

    Private Sub rbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodos.CheckedChanged
        txtID.Visible = False
        txtAlumno.Visible = False
        txtMatricula.Visible = False
        dtpFecha.Visible = False
        dgPagos.Rows.Clear()
        comando.CommandText = "select Pagos.idPago, Alumnos.nombre, Pagos.concepto, Pagos.fecha, Pagos.importe from Pagos inner join Alumnos on Pagos.matricula = Alumnos.matricula"
        lector = comando.ExecuteReader
        While lector.Read
            dgPagos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()
    End Sub

    Private Sub frmConsPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        If Not txtID.Text.Contains("'") And txtID.TextLength > 0 Then
            If Char.IsNumber(txtID.Text.Chars(txtID.TextLength - 1)) Then
                dgPagos.Rows.Clear()
                comando.CommandText = "select Pagos.idPago, Alumnos.nombre, Pagos.concepto, Pagos.fecha, Pagos.importe from Pagos inner join Alumnos on Pagos.matricula = Alumnos.matricula where Pagos.idPago = " & txtID.Text & ""
                lector = comando.ExecuteReader
                While lector.Read
                    dgPagos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
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

    Private Sub txtAlumno_TextChanged(sender As Object, e As EventArgs) Handles txtAlumno.TextChanged
        If Not txtAlumno.Text.Contains("'") Then
            dgPagos.Rows.Clear()
            comando.CommandText = "select Pagos.idPago, Alumnos.nombre, Pagos.concepto, Pagos.fecha, Pagos.importe from Pagos inner join Alumnos on Pagos.matricula = Alumnos.matricula where Alumnos.nombre like '%" & txtAlumno.Text & "%'"
            lector = comando.ExecuteReader
            While lector.Read
                dgPagos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
            End While
            lector.Close()
        Else
            Dim cadena As String = ""
            For i = 0 To txtAlumno.Text.Length - 2
                cadena += txtAlumno.Text.Chars(i)
            Next
            txtAlumno.Text = cadena
        End If
    End Sub

    Private Sub txtMatricula_TextChanged(sender As Object, e As EventArgs) Handles txtMatricula.TextChanged
        If Not txtMatricula.Text.Contains("'") And txtMatricula.TextLength > 0 Then
            If Char.IsNumber(txtMatricula.Text.Chars(txtMatricula.TextLength - 1)) Then
                dgPagos.Rows.Clear()
                comando.CommandText = "select Pagos.idPago, Alumnos.nombre, Pagos.concepto, Pagos.fecha, Pagos.importe from Pagos inner join Alumnos on Pagos.matricula = Alumnos.matricula where Pagos.matricula = " & txtMatricula.Text & ""
                lector = comando.ExecuteReader
                While lector.Read
                    dgPagos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
                End While
                lector.Close()
            Else
                MessageBox.Show("Solo números.")
                txtMatricula.Text = ""
            End If
        Else
            Dim cadena As String = ""
            For i = 0 To txtMatricula.Text.Length - 2
                cadena += txtMatricula.Text.Chars(i)
            Next
            txtMatricula.Text = cadena
        End If
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        dgPagos.Rows.Clear()
        comando.CommandText = "select Pagos.idPago, Alumnos.nombre, Pagos.concepto, Pagos.fecha, Pagos.importe from Pagos inner join Alumnos on Pagos.matricula = Alumnos.matricula where Pagos.fecha = '" & dtpFecha.Value.Date & "'"
        lector = comando.ExecuteReader
        While lector.Read
            dgPagos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()
    End Sub
End Class