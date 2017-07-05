Imports System.Data.SqlClient
Public Class frmEmpleados
    Dim conexionsql As SqlConnection = openConection()
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
        If Not txtApellidoPaterno.Text.Contains("'") And Not txtApellidoPaterno.Text.Equals("") Then
            If Not txtApellidoMaterno.Text.Contains("'") And Not txtApellidoMaterno.Text.Equals("") Then
                If Not txtNombre.Text.Contains("'") And Not txtNombre.Text.Equals("") Then
                    If Not txtCalleDondeVive.Text.Contains("'") And Not txtCalleDondeVive.Text.Equals("") Then
                        If Not txtNumExterior.Text.Contains("'") And Not txtNumExterior.Text.Equals("") Then
                            If Not txtNumInterior.Text.Contains("'") And Not txtNumInterior.Text.Equals("") Then
                                If Not txtColonia.Text.Contains("'") And Not txtColonia.Text.Equals("") Then
                                    If Not txtTelefono.Text.Contains("'") And Not txtTelefono.Text.Equals("") Then
                                        If Not txtEmail.Text.Contains("'") And Not txtEmail.Text.Equals("") Then
                                            If IsDate(txtFechaNacimiento.Text) Then
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
                                                txtFechaNacimiento.Enabled = False
                                            Else
                                                MessageBox.Show("Introduzca un valor valido para fecha de nacimiento")
                                            End If
                                        Else
                                            MessageBox.Show("Introduzca un valor valido para email")
                                        End If
                                    Else
                                        MessageBox.Show("Introduzca un valor valido para telefono")
                                    End If
                                Else
                                    MessageBox.Show("Introduzca un valor valido para colonia")
                                End If
                            Else
                                MessageBox.Show("Introduzca un valor valido para número interior")
                            End If
                        Else
                            MessageBox.Show("Introduzca un valor valido para número exterior")
                        End If
                    Else
                        MessageBox.Show("Introduzca un valor valido para calle donde vive")
                    End If
                Else
                    MessageBox.Show("Introduzca un valor valido para nombre")
                End If
            Else
                MessageBox.Show("Introduzca un valor valido para apellido materno")
            End If
        Else
            MessageBox.Show("Introduzca un valor valido para apellido paterno")
        End If


    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub
End Class