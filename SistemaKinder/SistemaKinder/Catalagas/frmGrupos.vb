Imports System.Data.SqlClient
Public Class frmGrupos

    Dim conexionsql As New SqlConnection("Data Source = 'KARINSPC'; Initial catalog = 'bdKinder'; Integrated security = 'true'")
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim R As String
        R = "SELECT COUNT(*) FROM GRUPOS"
        comando.CommandText = R
        txtIdGrupo.Text = comando.ExecuteScalar + 1

        cboMaestro.Enabled = True
        cboGrupo.Enabled = True
        cboGrado.Enabled = True
        txtGeneracion.Enabled = True
        txtNoAlumnos.Enabled = True
        cmdGrabar.Enabled = True

    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        Dim idGpo As Integer = txtIdGrupo.Text
        Dim emp As Integer = cboMaestro.SelectedValue
        Dim gen As String = txtGeneracion.Text
        Dim gdo As Integer = cboGrado.Text
        Dim alu As Integer = txtNoAlumnos.Text
        Dim gpo As String = cboGrupo.Text

        Dim R As String
        R = "INSERT INTO Grupos(idGrupo, idEmpleado, generacion, grado, noAlumnos, grupo) VALUES(" & idGpo & "," & emp & ",'" & gen & "'," & gdo & "," & alu & ",'" & gpo & "')"
        comando.CommandText = R
        comando.ExecuteNonQuery()

        cmdGrabar.Enabled = False
        cmdNuevo.Enabled = True
        txtIdGrupo.Text = ""
        txtGeneracion.Text = ""
        txtNoAlumnos.Text = ""
        cboGrado.Text = ""
        cboGrupo.Text = ""
        cboMaestro.Text = ""
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub

    Private Sub frmGrupos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BdKinderDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.BdKinderDataSet.Empleados)
        conexionsql.Open()
    End Sub
End Class