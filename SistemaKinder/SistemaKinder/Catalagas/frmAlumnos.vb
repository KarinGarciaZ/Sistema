Imports System.Data.SqlClient
Public Class frmAlumnos

    Dim conexionsql As New SqlConnection("Data Source = 'KARINSPC'; Initial catalog = 'bdKinder'; Integrated security = 'true'")
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
        txtParentesco.Enabled = True
        cmdGuardar.Enabled = True

    End Sub

    Private Sub frmAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BdKinderDataSet.Grupos' Puede moverla o quitarla según sea necesario.
        Me.GruposTableAdapter.Fill(Me.BdKinderDataSet.Grupos)
        'TODO: esta línea de código carga datos en la tabla 'BdKinderDataSet.Tutores' Puede moverla o quitarla según sea necesario.
        Me.TutoresTableAdapter.Fill(Me.BdKinderDataSet.Tutores)
        'TODO: esta línea de código carga datos en la tabla 'BdKinderDataSet.Discapacidades' Puede moverla o quitarla según sea necesario.
        Me.DiscapacidadesTableAdapter.Fill(Me.BdKinderDataSet.Discapacidades)
        conexionsql.Open()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
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
    End Sub

End Class