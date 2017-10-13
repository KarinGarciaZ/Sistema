Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class frmAlumnos

    Dim conexionsql As SqlConnection = openConection()
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader

    Private Sub radioSI_CheckedChanged(sender As Object, e As EventArgs) Handles radioSI.CheckedChanged
        If radioSI.Checked = True Then
            gbDiscapacidad.Visible = True
        Else
            gbDiscapacidad.Visible = False
        End If
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click

        txtMatricula.Enabled = True
        txtApellidoPaterno.Enabled = True
        txtApellidoMaterno.Enabled = True
        txtNombre.Enabled = True
        txtFNacimiento.Enabled = True
        cboGenero.Enabled = True
        txtTipoSangre.Enabled = True
        txtEntidad.Enabled = True
        txtCurp.Enabled = True
        radioSI.Enabled = True
        radioNO.Enabled = True
        cboDiscapacidades.Enabled = True
        txtCalleDondeVive.Enabled = True
        txtEntreCalle.Enabled = True
        txtColonia.Enabled = True
        txtMunicipio.Enabled = True
        cboTutor.Enabled = True
        cboGrupo.Enabled = True
        txtNumExterior.Enabled = True
        txtNumInterior.Enabled = True
        txtYCalle.Enabled = True
        txtCp.Enabled = True
        txtLocalidad.Enabled = True
        cmdGuardar.Enabled = True
        cmdNuevo.Enabled = False
    End Sub

    Private Sub frmAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
<<<<<<< HEAD

        'TODO: esta línea de código carga datos en la tabla 'BdKinderDataSet.Discapacidades' Puede moverla o quitarla según sea necesario.
        Me.DiscapacidadesTableAdapter.Fill(Me.BdKinderDataSet.Discapacidades)
        Me.TutoresTableAdapter.Fill(Me.BdKinderDataSet.Tutores)
        Me.GruposTableAdapter.Fill(Me.BdKinderDataSet.Grupos)

        conexionsql.Open()


=======
        conexionsql.Open()
        'TODO: esta línea de código carga datos en la tabla 'BdKinderDataSet.Grupos' Puede moverla o quitarla según sea necesario.
        Me.GruposTableAdapter.Fill(Me.BdKinderDataSet.Grupos)
        'TODO: esta línea de código carga datos en la tabla 'BdKinderDataSet.Tutores' Puede moverla o quitarla según sea necesario.
        Me.TutoresTableAdapter.Fill(Me.BdKinderDataSet.Tutores)
        'TODO: esta línea de código carga datos en la tabla 'BdKinderDataSet.Discapacidades' Puede moverla o quitarla según sea necesario.
        Me.DiscapacidadesTableAdapter.Fill(Me.BdKinderDataSet.Discapacidades)
>>>>>>> Develop
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If Not txtNombre.Text.Equals("") And Not txtNombre.Text.Contains("'") Then
            If Not txtApellidoPaterno.Text.Equals("") And Not txtApellidoPaterno.Text.Contains("'") Then
                If Not txtApellidoMaterno.Text.Equals("") And Not txtApellidoMaterno.Text.Contains("'") Then
                    If IsDate(txtFNacimiento.Text) Then
                        If Not txtCurp.Text.Equals("") And Not txtCurp.Text.Contains("'") Then
                            If Not txtEntidad.Text.Equals("") And Not txtEntidad.Text.Contains("'") Then
                                If Not txtCalleDondeVive.Text.Equals("") And Not txtCalleDondeVive.Text.Contains("'") Then
                                    If Not txtNumExterior.Text.Equals("") And Not txtNumExterior.Text.Contains("'") Then
                                        If Not txtNumInterior.Text.Contains("'") Then
                                            If Not txtEntreCalle.Text.Equals("") And Not txtEntreCalle.Text.Contains("'") Then
                                                If Not txtYCalle.Text.Equals("") And Not txtYCalle.Text.Contains("'") Then
                                                    If Not txtColonia.Text.Equals("") And Not txtColonia.Text.Contains("'") Then
                                                        If Not txtCp.Text.Equals("") And Not txtCp.Text.Contains("'") Then
                                                            If Not txtMunicipio.Text.Equals("") And Not txtMunicipio.Text.Contains("'") Then
                                                                If Not txtLocalidad.Text.Equals("") And Not txtNombre.Text.Contains("'") Then
                                                                    If Not txtTipoSangre.Text.Contains("'") Then
                                                                        If IsNumeric(txtMatricula.Text) Then
                                                                            If Not CDbl(txtMatricula.Text) > 2147483647 And Not CDbl(txtMatricula.Text) < 1 Then
                                                                                Dim ban As Boolean = False
                                                                                Dim S As String
                                                                                S = "SELECT matricula FROM Alumnos"
                                                                                comando.CommandText = S
                                                                                lector = comando.ExecuteReader
                                                                                While lector.Read
                                                                                    If lector(0) = CInt(txtMatricula.Text) Then
                                                                                        ban = True
                                                                                    End If
                                                                                End While
                                                                                lector.Close()
                                                                                If Not ban Then
                                                                                    Dim mat As Integer = txtMatricula.Text
                                                                                    Dim nom As String = txtNombre.Text
                                                                                    Dim app As String = txtApellidoPaterno.Text
                                                                                    Dim apm As String = txtApellidoMaterno.Text
                                                                                    Dim fdn As String = txtFNacimiento.Text
                                                                                    Dim dis As Integer = cboDiscapacidades.SelectedValue
                                                                                    Dim gen As String = cboGenero.Text
                                                                                    Dim cur As String = txtCurp.Text
                                                                                    Dim ent As String = txtEntidad.Text
                                                                                    Dim tut As Integer = cboTutor.SelectedValue
                                                                                    Dim cdv As String = txtCalleDondeVive.Text
                                                                                    Dim numEx As String = txtNumExterior.Text
                                                                                    Dim numIn As String = txtNumInterior.Text
                                                                                    Dim enc As String = txtEntreCalle.Text
                                                                                    Dim yca As String = txtYCalle.Text
                                                                                    Dim col As String = txtColonia.Text
                                                                                    Dim cp As String = txtCp.Text
                                                                                    Dim mun As String = txtMunicipio.Text
                                                                                    Dim loc As String = txtLocalidad.Text
                                                                                    Dim gpo As Integer = cboGrupo.SelectedValue
                                                                                    Dim tsa As String = txtTipoSangre.Text
                                                                                    Dim bit As Integer = 0

                                                                                    If gen.Equals("Femenino") Then
                                                                                        bit = 1
                                                                                    End If

                                                                                    If gen.Equals("Masculino") Then
                                                                                        bit = 0
                                                                                    End If

                                                                                    Dim R As String
                                                                                    R = "INSERT INTO Alumnos (matricula, nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento, idDiscapacidad, genero, curp, entidadNacimiento, idTutor, calle, noExterior, noInterior, entreCalle, yCalle, colonia, cP, municipio, localidad, idGrupo, tipoSangre) VALUES(" & mat & ",'" & nom & "','" & app & "','" & apm & "','" & fdn & "'," & dis & "," & bit & ",'" & cur & "','" & ent & "'," & tut & ",'" & cdv & "','" & numEx & "','" & numIn & "','" & enc & "','" & yca & "','" & col & "','" & cp & "','" & mun & "','" & loc & "'," & gpo & ",'" & tsa & "')"
                                                                                    comando.CommandText = R
                                                                                    comando.ExecuteNonQuery()

                                                                                    txtMatricula.Enabled = False
                                                                                    txtApellidoPaterno.Enabled = False
                                                                                    txtApellidoMaterno.Enabled = False
                                                                                    txtNombre.Enabled = False
                                                                                    txtFNacimiento.Enabled = False
                                                                                    cboGenero.Enabled = False
                                                                                    txtTipoSangre.Enabled = False
                                                                                    txtEntidad.Enabled = False
                                                                                    txtCurp.Enabled = False
                                                                                    radioSI.Enabled = False
                                                                                    radioNO.Enabled = False
                                                                                    cboDiscapacidades.Enabled = False
                                                                                    txtCalleDondeVive.Enabled = False
                                                                                    txtEntreCalle.Enabled = False
                                                                                    txtColonia.Enabled = False
                                                                                    txtMunicipio.Enabled = False
                                                                                    cboTutor.Enabled = False
                                                                                    cboGrupo.Enabled = False
                                                                                    txtNumExterior.Enabled = False
                                                                                    txtNumInterior.Enabled = False
                                                                                    txtYCalle.Enabled = False
                                                                                    txtCp.Enabled = False
                                                                                    txtLocalidad.Enabled = False
                                                                                    txtParentesco.Enabled = False
                                                                                    cmdGuardar.Enabled = False

                                                                                    txtMatricula.Text = ""
                                                                                    txtApellidoPaterno.Text = ""
                                                                                    txtApellidoMaterno.Text = ""
                                                                                    txtNombre.Text = ""
                                                                                    txtFNacimiento.Text = ""
                                                                                    cboGenero.Text = ""
                                                                                    txtTipoSangre.Text = ""
                                                                                    txtEntidad.Text = ""
                                                                                    txtCurp.Text = ""
                                                                                    cboDiscapacidades.Text = ""
                                                                                    txtCalleDondeVive.Text = ""
                                                                                    txtEntreCalle.Text = ""
                                                                                    txtColonia.Text = ""
                                                                                    txtMunicipio.Text = ""
                                                                                    cboTutor.Text = ""
                                                                                    cboGrupo.Text = ""
                                                                                    txtNumExterior.Text = ""
                                                                                    txtNumInterior.Text = ""
                                                                                    txtYCalle.Text = ""
                                                                                    txtCp.Text = ""
                                                                                    txtLocalidad.Text = ""
                                                                                    txtParentesco.Text = ""
                                                                                    cmdGuardar.Enabled = False
                                                                                    cmdNuevo.Enabled = True
                                                                                Else
                                                                                    MessageBox.Show("La matricula ya se encuentra registrada")
                                                                                End If
                                                                            Else
                                                                                MessageBox.Show("No se aceptan valores numericos mayores a 2,147,483,647 ó menores a 1")
                                                                            End If

                                                                        Else
                                                                            MessageBox.Show("La matrícula debe ser un valor numerico")
                                                                        End If
                                                                    Else
                                                                        MessageBox.Show("Introduzca un valor válido para tipo de sangre")
                                                                    End If
                                                                Else
                                                                    MessageBox.Show("Introduzca un valor válido para localidad")
                                                                End If
                                                            Else
                                                                MessageBox.Show("Introduzca un valor válido para municipio")
                                                            End If
                                                        Else
                                                            MessageBox.Show("Introduzca un valor válido para CP ")
                                                        End If
                                                    Else
                                                        MessageBox.Show("Introduzca un valor válido para colonia")
                                                    End If
                                                Else
                                                    MessageBox.Show("Introduzca un valor válido para y calle")
                                                End If
                                            Else
                                                MessageBox.Show("Introduzca un valor válido para entre calle")
                                            End If
                                        Else
                                            MessageBox.Show("Introduzca un valor válido para número interior")
                                        End If
                                    Else
                                        MessageBox.Show("Introduzca un valor válido para número exterior")
                                    End If
                                Else
                                    MessageBox.Show("Introduzca un valor válido para calle donde vive")
                                End If
                            Else
                                MessageBox.Show("Introduzca un valor válido para entidad")
                            End If
                        Else
                            MessageBox.Show("Introduzca un valor válido para curp")
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
            MessageBox.Show("Introduzca un valor válido para nombre ")
        End If
    End Sub



    Private Sub cboTutor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTutor.SelectedIndexChanged
        If conexionsql.State = ConnectionState.Open Then
            comando.CommandText = "SELECT parentesco FROM Tutores WHERE idTutor = " & cboTutor.SelectedValue
            lector = comando.ExecuteReader
            lector.Read()
            txtParentesco.Text = lector(0)
            lector.Close()
        End If
    End Sub

    Private Sub txtApellidoPaterno_Click(sender As Object, e As EventArgs) Handles txtApellidoPaterno.Click
        If txtApellidoPaterno.Text.Equals("") Then
            txtApellidoPaterno.Select(0, 0)
        Else
            txtApellidoPaterno.Select(txtApellidoPaterno.Text.Length, 0)
        End If

    End Sub

    Private Sub txtApellidoMaterno_Click(sender As Object, e As EventArgs) Handles txtApellidoMaterno.Click
        If txtApellidoMaterno.Text.Equals("") Then
            txtApellidoMaterno.Select(0, 0)
        Else
            txtApellidoMaterno.Select(txtApellidoMaterno.Text.Length, 0)
        End If

    End Sub

    Private Sub txtNombre_Click(sender As Object, e As EventArgs) Handles txtNombre.Click
        If txtNombre.Text.Equals("") Then
            txtNombre.Select(0, 0)
        Else
            txtNombre.Select(txtNombre.Text.Length, 0)
        End If
    End Sub

    Private Sub txtEntidad_Click(sender As Object, e As EventArgs) Handles txtEntidad.Click
        If txtEntidad.Text.Equals("") Then
            txtEntidad.Select(0, 0)
        Else
            txtEntidad.Select(txtEntidad.Text.Length, 0)
        End If
    End Sub

    Private Sub txtCurp_Click(sender As Object, e As EventArgs) Handles txtCurp.Click
        If txtCurp.Text.Equals("") Then
            txtCurp.Select(0, 0)
        Else
            txtCurp.Select(txtCurp.Text.Length, 0)
        End If
    End Sub

    Private Sub txtTipoSangre_Click(sender As Object, e As EventArgs) Handles txtTipoSangre.Click
        If txtTipoSangre.Text.Equals("") Then
            txtTipoSangre.Select(0, 0)
        Else
            txtTipoSangre.Select(txtTipoSangre.Text.Length, 0)
        End If
    End Sub

    Private Sub txtCalleDondeVive_Click(sender As Object, e As EventArgs) Handles txtCalleDondeVive.Click
        If txtCalleDondeVive.Text.Equals("") Then
            txtCalleDondeVive.Select(0, 0)
        Else
            txtCalleDondeVive.Select(txtCalleDondeVive.Text.Length, 0)
        End If
    End Sub

    Private Sub txtNumExterior_Click(sender As Object, e As EventArgs) Handles txtNumExterior.Click
        If txtNumExterior.Text.Equals("") Then
            txtNumExterior.Select(0, 0)
        Else
            txtNumExterior.Select(txtNumExterior.Text.Length, 0)
        End If
    End Sub

    Private Sub txtNumInterior_Click(sender As Object, e As EventArgs) Handles txtNumInterior.Click
        If txtNumInterior.Text.Equals("") Then
            txtNumInterior.Select(0, 0)
        Else
            txtNumInterior.Select(txtNumInterior.Text.Length, 0)
        End If
    End Sub

    Private Sub txtEntreCalle_Click(sender As Object, e As EventArgs) Handles txtEntreCalle.Click
        If txtEntreCalle.Text.Equals("") Then
            txtEntreCalle.Select(0, 0)
        Else
            txtEntreCalle.Select(txtEntreCalle.Text.Length, 0)
        End If
    End Sub

    Private Sub txtYCalle_Click(sender As Object, e As EventArgs) Handles txtYCalle.Click
        If txtYCalle.Text.Equals("") Then
            txtYCalle.Select(0, 0)
        Else
            txtYCalle.Select(txtYCalle.Text.Length, 0)
        End If
    End Sub

    Private Sub txtColonia_Click(sender As Object, e As EventArgs) Handles txtColonia.Click
        If txtColonia.Text.Equals("") Then
            txtColonia.Select(0, 0)
        Else
            txtColonia.Select(txtColonia.Text.Length, 0)
        End If
    End Sub

    Private Sub txtCp_Click(sender As Object, e As EventArgs) Handles txtCp.Click
        If txtCp.Text.Equals("") Then
            txtCp.Select(0, 0)
        Else
            txtCp.Select(txtCp.Text.Length, 0)
        End If
    End Sub

    Private Sub txtMunicipio_Click(sender As Object, e As EventArgs) Handles txtMunicipio.Click
        If txtMunicipio.Text.Equals("") Then
            txtMunicipio.Select(0, 0)
        Else
            txtMunicipio.Select(txtMunicipio.Text.Length, 0)
        End If
    End Sub

    Private Sub txtLocalidad_Click(sender As Object, e As EventArgs) Handles txtLocalidad.Click
        If txtLocalidad.Text.Equals("") Then
            txtLocalidad.Select(0, 0)
        Else
            txtLocalidad.Select(txtLocalidad.Text.Length, 0)
        End If
    End Sub

    Private Sub cboTutor_Validating(sender As Object, e As CancelEventArgs) Handles cboTutor.Validating

        Dim cont As Integer = 0
        Dim R As String
        Dim ban As Boolean = False
        R = "SELECT Tutores.nombre FROM Tutores"
        comando.CommandText = R
        lector = comando.ExecuteReader

        While lector.Read
            If cboTutor.Text.Equals(lector(0)) Then
                ban = True
            End If

        End While
        lector.Close()

        If Not ban Then
            MessageBox.Show("Seleccione un nombre de la lista")
            cboTutor.Focus()
        End If
    End Sub

    Private Sub cboGrupo_Validating(sender As Object, e As CancelEventArgs) Handles cboGrupo.Validating

        Dim R As String
        Dim ban As Boolean = False
        R = "SELECT Grupos.generacion FROM Grupos"
        comando.CommandText = R
        lector = comando.ExecuteReader

        While lector.Read
            If cboGrupo.Text.Equals(lector(0)) Then
                ban = True
            End If

        End While
        lector.Close()

        If Not ban Then
            MessageBox.Show("Seleccione un grupo de la lista")
            cboGrupo.Focus()
        End If
    End Sub
End Class