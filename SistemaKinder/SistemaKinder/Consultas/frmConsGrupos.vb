Imports System.Data.SqlClient
Public Class frmConsGrupos

    Dim conexionsql As New SqlConnection("Data Source = 'KARINSPC'; Initial catalog = 'bdKinder'; Integrated security = 'true'")
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader

    Private Sub frmConsGrupos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BdKinderDataSet.Grupos' Puede moverla o quitarla según sea necesario.
        Me.GruposTableAdapter.Fill(Me.BdKinderDataSet.Grupos)
        conexionsql.Open()
    End Sub

    Private Sub cboGrupo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrupo.SelectedIndexChanged
        If Not cboGrupo.Text.Equals("") Then
            Dim R As String
            Dim id As Integer
            Dim gdo As Integer = cboGrado.SelectedValue
            Dim gpo As String = cboGrupo.SelectedValue
            R = "SELECT  Grupos.idGrupo, Grupos.generacion, Grupos.grado, Grupos.grupo, Grupos.noAlumnos, Empleados.nombre FROM Grupos INNER JOIN Empleados ON Grupos.idEmpleado = Empleados.idEmpleado WHERE Grado = " & gdo & " AND Grupo = '" & gpo & "'"
            comando.CommandText = R
            lector = comando.ExecuteReader
            lector.Read()
            id = lector(0)
            txtGeneracion.Text = lector(1)
            txtTotalAlumnos.Text = lector(4)
            txtMaestro.Text = lector(5)
            lector.Close()

            R = "SELECT Alumnos.matricula, Alumnos.nombre, Alumnos.apellidoPaterno, Alumnos.apellidoMaterno FROM Alumnos WHERE idGrupo = " & id
            comando.CommandText = R
            lector = comando.ExecuteReader
            While lector.Read
                dgGrupos.Rows.Add(lector(0), lector(1), lector(2), lector(3))
            End While
            lector.Close()

        End If
    End Sub

    Private Sub cboGrado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrado.SelectedIndexChanged
        If Not cboGrado.Text.Equals("") Then
            Dim R As String
            Dim id As Integer
            Dim gdo As Integer = cboGrado.SelectedValue
            Dim gpo As String = cboGrupo.SelectedValue
            R = "SELECT  Grupos.idGrupo, Grupos.generacion, Grupos.grado, Grupos.grupo, Grupos.noAlumnos, Empleados.nombre FROM Grupos INNER JOIN Empleados ON Grupos.idEmpleado = Empleados.idEmpleado WHERE Grado = " & gdo & " AND Grupo = '" & gpo & "'"
            MessageBox.Show(R)
            comando.CommandText = R
            lector = comando.ExecuteReader
            lector.Read()
            txtGeneracion.Text = lector(1)
            txtTotalAlumnos.Text = lector(4)
            txtMaestro.Text = lector(5)
            id = lector(0)
            lector.Close()

            R = "SELECT * FROM Alumnos WHERE idGrupo = " & id
            comando.CommandText = R
            lector = comando.ExecuteReader
            While lector.Read
                dgGrupos.Rows.Add(lector(0), lector(1), lector(2), lector(3))
            End While
            lector.Close()
        End If
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub
End Class