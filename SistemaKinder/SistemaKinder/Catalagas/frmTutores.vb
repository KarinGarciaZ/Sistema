Imports System.Data.SqlClient
Public Class frmTutores

    Dim conexionsql As SqlConnection = openConection()
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader

    Private Sub frmTutores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        gbDatos.Enabled = True
        cmdGuardar.Enabled = True
        cmdNuevo.Enabled = False
        comando.CommandText = "SELECT COUNT(*) FROM Tutores"
        txtIdTutor.Text = comando.ExecuteScalar + 1
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If Not txtNombre.Text.Equals("") And Not txtNombre.Text.Contains("'") Then
            If Not txtApellidoPaterno.Text.Equals("") And Not txtApellidoPaterno.Text.Contains("'") Then
                If Not txtApellidoMaterno.Text.Equals("") And Not txtApellidoMaterno.Text.Contains("'") Then
                    If IsDate(txtFechaNacimiento.Text) Then
                        If Not txtEntidad.Text.Equals("") And Not txtEntidad.Text.Contains("'") Then
                            If Not cboGenero.Text.Equals("") Then
                                If Not cboParentesco.Text.Equals("") Then
                                    If Not cboOcupacion.Text.Equals("") Then
                                        If Not cboNivelEstudios.Text.Equals("") Then
                                            If Not cboLeerEscribir.Text.Equals("") Then
                                                If Not txtEmail.Text.Equals("") And Not txtEmail.Text.Contains("'") Then
                                                    If Not txtTelefono.Text.Equals("") And Not txtTelefono.Text.Contains("'") Then
                                                        If Not txtCelular.Text.Equals("") And Not txtCelular.Text.Contains("'") Then
                                                            If Not txtTelefonoAlterno.Text.Equals("") And Not txtTelefonoAlterno.Text.Contains("'") Then
                                                                Dim idTut As Integer = txtIdTutor.Text
                                                                Dim nom As String = txtNombre.Text
                                                                Dim app As String = txtApellidoPaterno.Text
                                                                Dim apm As String = txtApellidoMaterno.Text
                                                                Dim fdn As Date = txtFechaNacimiento.Text
                                                                Dim ent As String = txtEntidad.Text
                                                                Dim gen As String = cboGenero.Text
                                                                Dim par As String = cboParentesco.Text
                                                                Dim ocu As String = cboOcupacion.Text
                                                                Dim est As String = cboNivelEstudios.Text
                                                                Dim lye As String = cboLeerEscribir.Text
                                                                Dim ema As String = txtEmail.Text
                                                                Dim tel As String = txtTelefono.Text
                                                                Dim cel As String = txtCelular.Text
                                                                Dim tel2 As String = txtTelefonoAlterno.Text
                                                                Dim bit As Integer = 1

                                                                If gen.Equals("Femenino") Then
                                                                    bit = 1
                                                                End If

                                                                If gen.Equals("Masculino") Then
                                                                    bit = 0
                                                                End If

                                                                Dim R As String
                                                                R = "INSERT INTO Tutores(idTutor, nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento, entidadNacimiento, genero, parentesco, ocupacion, nivelEstudios, leerEscribir, correo, telefono, telCelular, telefonoAlterno) VALUES(" & idTut & ",'" & nom & "','" & app & "','" & apm & "','" & fdn & "','" & ent & "'," & bit & ",'" & par & "','" & ocu & "','" & est & "','" & lye & "','" & ema & "','" & tel & "','" & cel & "','" & tel2 & "')"
                                                                comando.CommandText = R
                                                                comando.ExecuteNonQuery()

                                                                txtIdTutor.Text = ""
                                                                txtNombre.Text = ""
                                                                txtApellidoPaterno.Text = ""
                                                                txtApellidoMaterno.Text = ""
                                                                txtFechaNacimiento.Text = ""
                                                                txtEntidad.Text = ""
                                                                cboGenero.Text = ""
                                                                cboParentesco.Text = ""
                                                                cboOcupacion.Text = ""
                                                                cboNivelEstudios.Text = ""
                                                                cboLeerEscribir.Text = ""
                                                                txtEmail.Text = ""
                                                                txtTelefono.Text = ""
                                                                txtCelular.Text = ""
                                                                txtTelefonoAlterno.Text = ""
                                                                gbDatos.Enabled = False
                                                                cmdGuardar.Enabled = False
                                                                cmdNuevo.Enabled = True
                                                            Else
                                                                MessageBox.Show("Introduzca un valor válido para teléfono alterno")
                                                            End If
                                                        Else
                                                            MessageBox.Show("Introduzca un valor válido para celular")
                                                        End If
                                                    Else
                                                        MessageBox.Show("Introduzca un valor válido para teléfono")
                                                    End If
                                                Else
                                                    MessageBox.Show("Introduzca un valor válido para email")
                                                End If
                                            Else
                                                MessageBox.Show("Introduzca un valor válido para sabe leer-escribir")
                                            End If
                                        Else
                                            MessageBox.Show("Introduzca un valor válido para nivel estudios")
                                        End If
                                    Else
                                        MessageBox.Show("Introduzca un valor válido para ocupación")
                                    End If
                                Else
                                    MessageBox.Show("Introduzca un valor válido para parentezco")
                                End If
                            Else
                                MessageBox.Show("Introduzca un valor válido para genero")
                            End If
                        Else
                            MessageBox.Show("Introduzca un valor válido para entidad")
                        End If
                    Else
                        MessageBox.Show("Introduzca un valor válido para fecha de nacimiento")
                    End If
                Else
                    MessageBox.Show("Introduzca un valor válido para apellido materno")
                End If
            Else
                MessageBox.Show("Introduzca un valor válido para apellido paterno")
            End If
        Else
            MessageBox.Show("Introduzca un valor válido para nombre")
        End If

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub
End Class