<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlumnos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbGenerales = New System.Windows.Forms.GroupBox()
        Me.txtTipoSangre = New System.Windows.Forms.MaskedTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.gbDiscapacidad = New System.Windows.Forms.GroupBox()
        Me.cboDiscapacidades = New System.Windows.Forms.ComboBox()
        Me.DiscapacidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdKinderDataSet = New SistemaKinder.bdKinderDataSet()
        Me.radioNO = New System.Windows.Forms.RadioButton()
        Me.radioSI = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboGenero = New System.Windows.Forms.ComboBox()
        Me.txtCurp = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEntidad = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFNacimiento = New System.Windows.Forms.MaskedTextBox()
        Me.txtNombre = New System.Windows.Forms.MaskedTextBox()
        Me.txtApellidoMaterno = New System.Windows.Forms.MaskedTextBox()
        Me.txtApellidoPaterno = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMatricula = New System.Windows.Forms.MaskedTextBox()
        Me.gbDatosPersonales = New System.Windows.Forms.GroupBox()
        Me.txtLocalidad = New System.Windows.Forms.MaskedTextBox()
        Me.txtCp = New System.Windows.Forms.MaskedTextBox()
        Me.txtMunicipio = New System.Windows.Forms.MaskedTextBox()
        Me.txtColonia = New System.Windows.Forms.MaskedTextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtYCalle = New System.Windows.Forms.MaskedTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtEntreCalle = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNumInterior = New System.Windows.Forms.MaskedTextBox()
        Me.txtNumExterior = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCalleDondeVive = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cboTutor = New System.Windows.Forms.ComboBox()
        Me.TutoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtParentesco = New System.Windows.Forms.MaskedTextBox()
        Me.cboGrupo = New System.Windows.Forms.ComboBox()
        Me.GruposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label22 = New System.Windows.Forms.Label()
        Me.DiscapacidadesTableAdapter = New SistemaKinder.bdKinderDataSetTableAdapters.DiscapacidadesTableAdapter()
        Me.TutoresTableAdapter = New SistemaKinder.bdKinderDataSetTableAdapters.TutoresTableAdapter()
        Me.GruposTableAdapter = New SistemaKinder.bdKinderDataSetTableAdapters.GruposTableAdapter()
        Me.gbGenerales.SuspendLayout()
        Me.gbDiscapacidad.SuspendLayout()
        CType(Me.DiscapacidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdKinderDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosPersonales.SuspendLayout()
        CType(Me.TutoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(470, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matrícula:"
        '
        'gbGenerales
        '
        Me.gbGenerales.Controls.Add(Me.txtTipoSangre)
        Me.gbGenerales.Controls.Add(Me.Label21)
        Me.gbGenerales.Controls.Add(Me.gbDiscapacidad)
        Me.gbGenerales.Controls.Add(Me.radioNO)
        Me.gbGenerales.Controls.Add(Me.radioSI)
        Me.gbGenerales.Controls.Add(Me.Label11)
        Me.gbGenerales.Controls.Add(Me.cboGenero)
        Me.gbGenerales.Controls.Add(Me.txtCurp)
        Me.gbGenerales.Controls.Add(Me.Label10)
        Me.gbGenerales.Controls.Add(Me.Label8)
        Me.gbGenerales.Controls.Add(Me.txtEntidad)
        Me.gbGenerales.Controls.Add(Me.Label6)
        Me.gbGenerales.Controls.Add(Me.Label7)
        Me.gbGenerales.Controls.Add(Me.txtFNacimiento)
        Me.gbGenerales.Controls.Add(Me.txtNombre)
        Me.gbGenerales.Controls.Add(Me.txtApellidoMaterno)
        Me.gbGenerales.Controls.Add(Me.txtApellidoPaterno)
        Me.gbGenerales.Controls.Add(Me.Label9)
        Me.gbGenerales.Controls.Add(Me.Label5)
        Me.gbGenerales.Controls.Add(Me.Label4)
        Me.gbGenerales.Controls.Add(Me.Label3)
        Me.gbGenerales.Controls.Add(Me.Label2)
        Me.gbGenerales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGenerales.Location = New System.Drawing.Point(9, 29)
        Me.gbGenerales.Name = "gbGenerales"
        Me.gbGenerales.Size = New System.Drawing.Size(691, 185)
        Me.gbGenerales.TabIndex = 1
        Me.gbGenerales.TabStop = False
        Me.gbGenerales.Text = "Datos Generales"
        '
        'txtTipoSangre
        '
        Me.txtTipoSangre.Enabled = False
        Me.txtTipoSangre.Location = New System.Drawing.Point(111, 162)
        Me.txtTipoSangre.Name = "txtTipoSangre"
        Me.txtTipoSangre.Size = New System.Drawing.Size(94, 20)
        Me.txtTipoSangre.TabIndex = 33
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(5, 167)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(98, 13)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "Tipo de Sangre:"
        '
        'gbDiscapacidad
        '
        Me.gbDiscapacidad.Controls.Add(Me.cboDiscapacidades)
        Me.gbDiscapacidad.Location = New System.Drawing.Point(359, 118)
        Me.gbDiscapacidad.Name = "gbDiscapacidad"
        Me.gbDiscapacidad.Size = New System.Drawing.Size(324, 62)
        Me.gbDiscapacidad.TabIndex = 19
        Me.gbDiscapacidad.TabStop = False
        Me.gbDiscapacidad.Text = "Seleccione Discapacidad:"
        Me.gbDiscapacidad.Visible = False
        '
        'cboDiscapacidades
        '
        Me.cboDiscapacidades.DataSource = Me.DiscapacidadesBindingSource
        Me.cboDiscapacidades.DisplayMember = "nombre"
        Me.cboDiscapacidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiscapacidades.Enabled = False
        Me.cboDiscapacidades.FormattingEnabled = True
        Me.cboDiscapacidades.Location = New System.Drawing.Point(6, 19)
        Me.cboDiscapacidades.Name = "cboDiscapacidades"
        Me.cboDiscapacidades.Size = New System.Drawing.Size(270, 21)
        Me.cboDiscapacidades.TabIndex = 0
        Me.cboDiscapacidades.ValueMember = "idDiscapacidad"
        '
        'DiscapacidadesBindingSource
        '
        Me.DiscapacidadesBindingSource.DataMember = "Discapacidades"
        Me.DiscapacidadesBindingSource.DataSource = Me.BdKinderDataSet
        '
        'BdKinderDataSet
        '
        Me.BdKinderDataSet.DataSetName = "bdKinderDataSet"
        Me.BdKinderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'radioNO
        '
        Me.radioNO.AutoSize = True
        Me.radioNO.Enabled = False
        Me.radioNO.Location = New System.Drawing.Point(472, 101)
        Me.radioNO.Name = "radioNO"
        Me.radioNO.Size = New System.Drawing.Size(41, 17)
        Me.radioNO.TabIndex = 18
        Me.radioNO.TabStop = True
        Me.radioNO.Text = "No"
        Me.radioNO.UseVisualStyleBackColor = True
        '
        'radioSI
        '
        Me.radioSI.AutoSize = True
        Me.radioSI.Enabled = False
        Me.radioSI.Location = New System.Drawing.Point(361, 99)
        Me.radioSI.Name = "radioSI"
        Me.radioSI.Size = New System.Drawing.Size(36, 17)
        Me.radioSI.TabIndex = 17
        Me.radioSI.TabStop = True
        Me.radioSI.Text = "Si"
        Me.radioSI.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Nacimiento:"
        '
        'cboGenero
        '
        Me.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGenero.Enabled = False
        Me.cboGenero.FormattingEnabled = True
        Me.cboGenero.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.cboGenero.Location = New System.Drawing.Point(84, 135)
        Me.cboGenero.Name = "cboGenero"
        Me.cboGenero.Size = New System.Drawing.Size(121, 21)
        Me.cboGenero.TabIndex = 14
        '
        'txtCurp
        '
        Me.txtCurp.Enabled = False
        Me.txtCurp.Location = New System.Drawing.Point(401, 50)
        Me.txtCurp.Name = "txtCurp"
        Me.txtCurp.Size = New System.Drawing.Size(282, 20)
        Me.txtCurp.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Fecha de"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(358, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "CURP:"
        '
        'txtEntidad
        '
        Me.txtEntidad.Enabled = False
        Me.txtEntidad.Location = New System.Drawing.Point(503, 24)
        Me.txtEntidad.Name = "txtEntidad"
        Me.txtEntidad.Size = New System.Drawing.Size(180, 20)
        Me.txtEntidad.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Género:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(358, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Entidad de Nacimiento:"
        '
        'txtFNacimiento
        '
        Me.txtFNacimiento.Enabled = False
        Me.txtFNacimiento.Location = New System.Drawing.Point(85, 107)
        Me.txtFNacimiento.Mask = "00/00/0000"
        Me.txtFNacimiento.Name = "txtFNacimiento"
        Me.txtFNacimiento.Size = New System.Drawing.Size(120, 20)
        Me.txtFNacimiento.TabIndex = 12
        Me.txtFNacimiento.ValidatingType = GetType(Date)
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(68, 77)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(285, 20)
        Me.txtNombre.TabIndex = 10
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Enabled = False
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(104, 50)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(248, 20)
        Me.txtApellidoMaterno.TabIndex = 9
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.Enabled = False
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(104, 24)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(248, 20)
        Me.txtApellidoPaterno.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(358, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "¿Tiene Discapacidades?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(191, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Fecha de Nacimiento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Apellido Materno:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Apellido Paterno:"
        '
        'txtMatricula
        '
        Me.txtMatricula.Enabled = False
        Me.txtMatricula.Location = New System.Drawing.Point(531, 8)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(161, 20)
        Me.txtMatricula.TabIndex = 2
        '
        'gbDatosPersonales
        '
        Me.gbDatosPersonales.Controls.Add(Me.txtLocalidad)
        Me.gbDatosPersonales.Controls.Add(Me.txtCp)
        Me.gbDatosPersonales.Controls.Add(Me.txtMunicipio)
        Me.gbDatosPersonales.Controls.Add(Me.txtColonia)
        Me.gbDatosPersonales.Controls.Add(Me.Label20)
        Me.gbDatosPersonales.Controls.Add(Me.Label19)
        Me.gbDatosPersonales.Controls.Add(Me.Label18)
        Me.gbDatosPersonales.Controls.Add(Me.Label17)
        Me.gbDatosPersonales.Controls.Add(Me.txtYCalle)
        Me.gbDatosPersonales.Controls.Add(Me.Label16)
        Me.gbDatosPersonales.Controls.Add(Me.txtEntreCalle)
        Me.gbDatosPersonales.Controls.Add(Me.Label15)
        Me.gbDatosPersonales.Controls.Add(Me.txtNumInterior)
        Me.gbDatosPersonales.Controls.Add(Me.txtNumExterior)
        Me.gbDatosPersonales.Controls.Add(Me.Label14)
        Me.gbDatosPersonales.Controls.Add(Me.Label13)
        Me.gbDatosPersonales.Controls.Add(Me.txtCalleDondeVive)
        Me.gbDatosPersonales.Controls.Add(Me.Label12)
        Me.gbDatosPersonales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosPersonales.Location = New System.Drawing.Point(9, 223)
        Me.gbDatosPersonales.Name = "gbDatosPersonales"
        Me.gbDatosPersonales.Size = New System.Drawing.Size(690, 141)
        Me.gbDatosPersonales.TabIndex = 3
        Me.gbDatosPersonales.TabStop = False
        Me.gbDatosPersonales.Text = "Datos Personales"
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Enabled = False
        Me.txtLocalidad.Location = New System.Drawing.Point(427, 113)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(248, 20)
        Me.txtLocalidad.TabIndex = 36
        '
        'txtCp
        '
        Me.txtCp.Enabled = False
        Me.txtCp.Location = New System.Drawing.Point(427, 83)
        Me.txtCp.Name = "txtCp"
        Me.txtCp.Size = New System.Drawing.Size(88, 20)
        Me.txtCp.TabIndex = 35
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Enabled = False
        Me.txtMunicipio.Location = New System.Drawing.Point(104, 113)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(248, 20)
        Me.txtMunicipio.TabIndex = 34
        '
        'txtColonia
        '
        Me.txtColonia.Enabled = False
        Me.txtColonia.Location = New System.Drawing.Point(104, 79)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(248, 20)
        Me.txtColonia.TabIndex = 33
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(362, 116)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 13)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "Localidad:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(5, 116)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 13)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Municipio:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(362, 86)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(27, 13)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "CP:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 86)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 13)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Colonia:"
        '
        'txtYCalle
        '
        Me.txtYCalle.Enabled = False
        Me.txtYCalle.Location = New System.Drawing.Point(427, 52)
        Me.txtYCalle.Name = "txtYCalle"
        Me.txtYCalle.Size = New System.Drawing.Size(248, 20)
        Me.txtYCalle.TabIndex = 28
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(362, 59)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Y calle:"
        '
        'txtEntreCalle
        '
        Me.txtEntreCalle.Enabled = False
        Me.txtEntreCalle.Location = New System.Drawing.Point(104, 52)
        Me.txtEntreCalle.Name = "txtEntreCalle"
        Me.txtEntreCalle.Size = New System.Drawing.Size(248, 20)
        Me.txtEntreCalle.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(5, 59)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Entre calle:"
        '
        'txtNumInterior
        '
        Me.txtNumInterior.Enabled = False
        Me.txtNumInterior.Location = New System.Drawing.Point(600, 26)
        Me.txtNumInterior.Name = "txtNumInterior"
        Me.txtNumInterior.Size = New System.Drawing.Size(75, 20)
        Me.txtNumInterior.TabIndex = 24
        '
        'txtNumExterior
        '
        Me.txtNumExterior.Enabled = False
        Me.txtNumExterior.Location = New System.Drawing.Point(439, 26)
        Me.txtNumExterior.Name = "txtNumExterior"
        Me.txtNumExterior.Size = New System.Drawing.Size(76, 20)
        Me.txtNumExterior.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(518, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "NumInterior:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(361, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "NumExterior:"
        '
        'txtCalleDondeVive
        '
        Me.txtCalleDondeVive.Enabled = False
        Me.txtCalleDondeVive.Location = New System.Drawing.Point(122, 26)
        Me.txtCalleDondeVive.Name = "txtCalleDondeVive"
        Me.txtCalleDondeVive.Size = New System.Drawing.Size(230, 20)
        Me.txtCalleDondeVive.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Calle donde  vive:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(14, 374)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(41, 13)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "Tutor:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(371, 374)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(75, 13)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "Parentesco:"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevo.Location = New System.Drawing.Point(17, 431)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(176, 47)
        Me.cmdNuevo.TabIndex = 7
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Enabled = False
        Me.cmdGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Location = New System.Drawing.Point(262, 431)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(176, 47)
        Me.cmdGuardar.TabIndex = 8
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(507, 431)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(176, 47)
        Me.cmdSalir.TabIndex = 9
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cboTutor
        '
        Me.cboTutor.DataSource = Me.TutoresBindingSource
        Me.cboTutor.DisplayMember = "nombre"
        Me.cboTutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTutor.Enabled = False
        Me.cboTutor.FormattingEnabled = True
        Me.cboTutor.Location = New System.Drawing.Point(76, 371)
        Me.cboTutor.Name = "cboTutor"
        Me.cboTutor.Size = New System.Drawing.Size(285, 21)
        Me.cboTutor.TabIndex = 10
        Me.cboTutor.ValueMember = "idTutor"
        '
        'TutoresBindingSource
        '
        Me.TutoresBindingSource.DataMember = "Tutores"
        Me.TutoresBindingSource.DataSource = Me.BdKinderDataSet
        '
        'txtParentesco
        '
        Me.txtParentesco.Enabled = False
        Me.txtParentesco.Location = New System.Drawing.Point(448, 371)
        Me.txtParentesco.Name = "txtParentesco"
        Me.txtParentesco.Size = New System.Drawing.Size(236, 20)
        Me.txtParentesco.TabIndex = 37
        '
        'cboGrupo
        '
        Me.cboGrupo.DataSource = Me.GruposBindingSource
        Me.cboGrupo.DisplayMember = "generacion"
        Me.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrupo.Enabled = False
        Me.cboGrupo.FormattingEnabled = True
        Me.cboGrupo.Location = New System.Drawing.Point(76, 398)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(160, 21)
        Me.cboGrupo.TabIndex = 38
        Me.cboGrupo.ValueMember = "idGrupo"
        '
        'GruposBindingSource
        '
        Me.GruposBindingSource.DataMember = "Grupos"
        Me.GruposBindingSource.DataSource = Me.BdKinderDataSet
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(14, 401)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 13)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "Grupo:"
        '
        'DiscapacidadesTableAdapter
        '
        Me.DiscapacidadesTableAdapter.ClearBeforeFill = True
        '
        'TutoresTableAdapter
        '
        Me.TutoresTableAdapter.ClearBeforeFill = True
        '
        'GruposTableAdapter
        '
        Me.GruposTableAdapter.ClearBeforeFill = True
        '
        'frmAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(704, 486)
        Me.Controls.Add(Me.cboGrupo)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtParentesco)
        Me.Controls.Add(Me.cboTutor)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.gbDatosPersonales)
        Me.Controls.Add(Me.txtMatricula)
        Me.Controls.Add(Me.gbGenerales)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmAlumnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ALUMNOS"
        Me.gbGenerales.ResumeLayout(False)
        Me.gbGenerales.PerformLayout()
        Me.gbDiscapacidad.ResumeLayout(False)
        CType(Me.DiscapacidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdKinderDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosPersonales.ResumeLayout(False)
        Me.gbDatosPersonales.PerformLayout()
        CType(Me.TutoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents gbGenerales As GroupBox
    Friend WithEvents txtEntidad As MaskedTextBox
    Friend WithEvents txtFNacimiento As MaskedTextBox
    Friend WithEvents txtCurp As MaskedTextBox
    Friend WithEvents txtNombre As MaskedTextBox
    Friend WithEvents txtApellidoMaterno As MaskedTextBox
    Friend WithEvents txtApellidoPaterno As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboGenero As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtMatricula As MaskedTextBox
    Friend WithEvents radioNO As RadioButton
    Friend WithEvents radioSI As RadioButton
    Friend WithEvents gbDiscapacidad As GroupBox
    Friend WithEvents cboDiscapacidades As ComboBox
    Friend WithEvents gbDatosPersonales As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCalleDondeVive As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNumInterior As MaskedTextBox
    Friend WithEvents txtNumExterior As MaskedTextBox
    Friend WithEvents txtYCalle As MaskedTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtEntreCalle As MaskedTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtTipoSangre As MaskedTextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtLocalidad As MaskedTextBox
    Friend WithEvents txtCp As MaskedTextBox
    Friend WithEvents txtMunicipio As MaskedTextBox
    Friend WithEvents txtColonia As MaskedTextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents cmdGuardar As Button
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cboTutor As ComboBox
    Friend WithEvents txtParentesco As MaskedTextBox
    Friend WithEvents cboGrupo As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents BdKinderDataSet As bdKinderDataSet
    Friend WithEvents DiscapacidadesBindingSource As BindingSource
    Friend WithEvents DiscapacidadesTableAdapter As bdKinderDataSetTableAdapters.DiscapacidadesTableAdapter
    Friend WithEvents TutoresBindingSource As BindingSource
    Friend WithEvents TutoresTableAdapter As bdKinderDataSetTableAdapters.TutoresTableAdapter
    Friend WithEvents GruposBindingSource As BindingSource
    Friend WithEvents GruposTableAdapter As bdKinderDataSetTableAdapters.GruposTableAdapter
End Class
