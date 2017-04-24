Imports System.Data.SqlClient
Public Class frmEmpleados
    Dim conexionsql As New SqlConnection("Data Source = 'KARINSPC'; Initial catalog = 'bdKinder'; Integrated security = 'true'")
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader

    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim R As String

        R = "SELECT COUNT(*) FROM Empleados"
        comando.CommandText = R
        txtIdEmpleado.Text = comando.ExecuteScalar + 1

        txtApellidoMaterno.Enabled = True
        txtApellidoPaterno.Enabled = True
        txtNombre.Enabled = True
        txtCalleDondeVive.Enabled = True
        txtNumExterior.Enabled = True
        txtNumInterior.Enabled = True
        txtColonia.Enabled = True
        txtTelefono.Enabled = True
        txtEmail.Enabled = True
        cboPuesto.Enabled = True
        cmdGuardar.Enabled = True
        txtFechaNacimiento.Enabled = True
        cmdNuevo.Enabled = False

    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim id As Integer = txtIdEmpleado.Text
        Dim app As String = txtApellidoPaterno.Text
        Dim apm As String = txtApellidoMaterno.Text
        Dim nom As String = txtNombre.Text
        Dim fec As Date = txtFechaNacimiento.Text
        Dim cal As String = txtCalleDondeVive.Text
        Dim numEx As String = txtNumExterior.Text
        Dim numIn As String = txtNumInterior.Text
        Dim col As String = txtColonia.Text
        Dim tel As String = txtTelefono.Text
        Dim ema As String = txtEmail.Text
        Dim pue As String = cboPuesto.Text

        Dim R As String
        R = "INSERT INTO Empleados (idEmpleado, nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento, calle, noExterior, noInterior, colonia, telefono, eMail, puesto) VALUES (" & id & ",'" & nom & "','" & app & "','" & apm & "','" & fec & "','" & cal & "','" & numEx & "','" & numIn & "','" & col & "','" & tel & "','" & ema & "','" & pue & "')"
        comando.CommandText = R
        comando.ExecuteNonQuery()
        cmdNuevo.Enabled = True
        cmdGuardar.Enabled = False

        txtApellidoMaterno.Enabled = False
        txtApellidoPaterno.Enabled = False
        txtNombre.Enabled = False
        txtCalleDondeVive.Enabled = False
        txtNumExterior.Enabled = False
        txtNumInterior.Enabled = False
        txtColonia.Enabled = False
        txtTelefono.Enabled = False
        txtEmail.Enabled = False
        cboPuesto.Enabled = False
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub
End Class