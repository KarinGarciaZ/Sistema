Imports System.Data.SqlClient
Public Class frmPagos
    Dim conexionsql As New SqlConnection("Data Source = 'KARINSPC'; Initial catalog = 'bdKinder'; Integrated security = 'true'")
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader
    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If Not txtBuscar.Text.Contains("'") Then
            dgBusqueda.Rows.Clear()
            comando.CommandText = "select matricula, nombre, apellidoPaterno, apellidoMaterno from Alumnos where nombre like '%" & txtBuscar.Text & "%'"
            lector = comando.ExecuteReader
            While lector.Read
                dgBusqueda.Rows.Add(lector(0), lector(1), lector(2), lector(3))
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

    Private Sub frmPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        comando.CommandText = "select count(*) from Pagos"
        Dim n As Integer = comando.ExecuteScalar
        txtIdPago.Text = n + 1
        txtBuscar.Enabled = True
        dtpFecha.Enabled = True
        txtConcepto.Enabled = True
        cmdGrabar.Enabled = True
        cmdNuevo.Enabled = False
        txtImporte.Enabled = True
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        If Not txtMatricula.Text.Equals("") And Not txtConcepto.Text.Equals("") And Not txtImporte.Text.Equals("") Then
            comando.CommandText = "insert into Pagos values(" & txtIdPago.Text & ", " & txtMatricula.Text & ", '" & txtConcepto.Text & "','" & dtpFecha.Value.Date & "'," & txtImporte.Text & ")"
            comando.ExecuteNonQuery()
            dgBusqueda.Rows.Clear()
            txtBuscar.Enabled = False
            dtpFecha.Enabled = False
            txtConcepto.Enabled = False
            txtImporte.Enabled = False
            cmdGrabar.Enabled = False
            cmdNuevo.Enabled = True
            dgBusqueda.Rows.Clear()
            txtConcepto.Text = ""
            txtBuscar.Text = ""
            txtImporte.Text = ""
            txtIdPago.Text = ""
            txtMatricula.Text = ""
            txtGrupo.Text = ""
            txtTutor.Text = ""
        Else
            MsgBox("Llene todos los campos.")
        End If
    End Sub

    Private Sub cmSalir_Click(sender As Object, e As EventArgs) Handles cmSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub


    'Private Sub dgBusqueda_SelectionChanged(sender As Object, e As EventArgs) Handles dgBusqueda.SelectionChanged
    '    If lector.IsClosed Then
    '        Dim matricula As Integer = dgBusqueda.Item(0, dgBusqueda.CurrentRow.Index).Value
    '        Dim fechaN As Date
    '        txtMatricula.Text = matricula
    '        comando.CommandText = "select Grupos.grado, Grupos.grupo, Alumnos.fechaNacimiento, Tutores.nombre from Alumnos inner join Grupos on Alumnos.idGrupo = Grupos.idGrupo inner join Tutores on Alumnos.idTutor = Tutores.idTutor where Alumnos.matricula = " & matricula & ""
    '        lector = comando.ExecuteReader
    '        lector.Read()
    '        txtGrupo.Text = lector(0) & lector(1)
    '        fechaN = lector(2)
    '        dtpFechaN.Value = fechaN.Date
    '        txtTutor.Text = lector(3)
    '        lector.Close()
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

    Private Sub dgBusqueda_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBusqueda.CellClick
        If lector.IsClosed Then
            Dim matricula As Integer = dgBusqueda.Item(0, dgBusqueda.CurrentRow.Index).Value
            Dim fechaN As Date
            txtMatricula.Text = matricula
            comando.CommandText = "select Grupos.grado, Grupos.grupo, Alumnos.fechaNacimiento, Tutores.nombre from Alumnos inner join Grupos on Alumnos.idGrupo = Grupos.idGrupo inner join Tutores on Alumnos.idTutor = Tutores.idTutor where Alumnos.matricula = " & matricula & ""
            lector = comando.ExecuteReader
            lector.Read()
            txtGrupo.Text = lector(0) & lector(1)
            fechaN = lector(2)
            dtpFechaN.Value = fechaN.Date
            txtTutor.Text = lector(3)
            lector.Close()
            dgBusqueda.CurrentRow.Selected = True
        End If
    End Sub



    'Private Sub dgBusqueda_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBusqueda.CellContentClick

    '    Dim matricula As Integer = dgBusqueda.Item(0, dgBusqueda.CurrentRow.Index).Value
    '    Dim fechaN As Date
    '    Dim grupo As String
    '    txtMatricula.Text = matricula
    '    comando.CommandText = "select Grupos.grado, Grupos.grupo, Alumnos.fechaNacimiento, Tutores.nombre from Alumnos inner join Grupos on Alumnos.idGrupo = Grupos.idGrupo inner join Tutores on Alumnos.idTutor = Tutores.idTutor where Alumnos.matricula = " & matricula & ""
    '    lector = comando.ExecuteReader
    '    lector.Read()
    '    fechaN = lector(2)
    '    dtpFechaN.Value = fechaN.Date
    '    txtTutor.Text = lector(3)
    '    lector.Close()

    'End Sub
End Class