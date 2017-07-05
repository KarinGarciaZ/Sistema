<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTutores
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.MaskedTextBox()
        Me.txtCelular = New System.Windows.Forms.MaskedTextBox()
        Me.txtTelefonoAlterno = New System.Windows.Forms.MaskedTextBox()
        Me.txtTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboLeerEscribir = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboNivelEstudios = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboOcupacion = New System.Windows.Forms.ComboBox()
        Me.cboParentesco = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboGenero = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEntidad = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFechaNacimiento = New System.Windows.Forms.MaskedTextBox()
        Me.txtNombre = New System.Windows.Forms.MaskedTextBox()
        Me.txtApellidoMaterno = New System.Windows.Forms.MaskedTextBox()
        Me.txtApellidoPaterno = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.txtIdTutor = New System.Windows.Forms.MaskedTextBox()
        Me.gbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(581, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "idTutor:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 5
        '
        'gbDatos
        '
        Me.gbDatos.Controls.Add(Me.txtEmail)
        Me.gbDatos.Controls.Add(Me.txtCelular)
        Me.gbDatos.Controls.Add(Me.txtTelefonoAlterno)
        Me.gbDatos.Controls.Add(Me.txtTelefono)
        Me.gbDatos.Controls.Add(Me.Label19)
        Me.gbDatos.Controls.Add(Me.Label18)
        Me.gbDatos.Controls.Add(Me.Label17)
        Me.gbDatos.Controls.Add(Me.Label16)
        Me.gbDatos.Controls.Add(Me.cboLeerEscribir)
        Me.gbDatos.Controls.Add(Me.Label15)
        Me.gbDatos.Controls.Add(Me.cboNivelEstudios)
        Me.gbDatos.Controls.Add(Me.Label9)
        Me.gbDatos.Controls.Add(Me.cboOcupacion)
        Me.gbDatos.Controls.Add(Me.cboParentesco)
        Me.gbDatos.Controls.Add(Me.Label14)
        Me.gbDatos.Controls.Add(Me.Label13)
        Me.gbDatos.Controls.Add(Me.Label11)
        Me.gbDatos.Controls.Add(Me.cboGenero)
        Me.gbDatos.Controls.Add(Me.Label10)
        Me.gbDatos.Controls.Add(Me.Label8)
        Me.gbDatos.Controls.Add(Me.txtEntidad)
        Me.gbDatos.Controls.Add(Me.Label2)
        Me.gbDatos.Controls.Add(Me.Label7)
        Me.gbDatos.Controls.Add(Me.txtFechaNacimiento)
        Me.gbDatos.Controls.Add(Me.txtNombre)
        Me.gbDatos.Controls.Add(Me.txtApellidoMaterno)
        Me.gbDatos.Controls.Add(Me.txtApellidoPaterno)
        Me.gbDatos.Controls.Add(Me.Label5)
        Me.gbDatos.Controls.Add(Me.Label4)
        Me.gbDatos.Controls.Add(Me.Label3)
        Me.gbDatos.Controls.Add(Me.Label12)
        Me.gbDatos.Enabled = False
        Me.gbDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatos.Location = New System.Drawing.Point(12, 38)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(727, 224)
        Me.gbDatos.TabIndex = 6
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Datos Generales"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(462, 192)
        Me.txtEmail.Mask = "??????????????????????????????"
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(261, 20)
        Me.txtEmail.TabIndex = 35
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(462, 164)
        Me.txtCelular.Mask = "000-000-0000"
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(110, 20)
        Me.txtCelular.TabIndex = 34
        '
        'txtTelefonoAlterno
        '
        Me.txtTelefonoAlterno.Location = New System.Drawing.Point(461, 136)
        Me.txtTelefonoAlterno.Mask = "(999)000-0000"
        Me.txtTelefonoAlterno.Name = "txtTelefonoAlterno"
        Me.txtTelefonoAlterno.Size = New System.Drawing.Size(111, 20)
        Me.txtTelefonoAlterno.TabIndex = 33
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(461, 106)
        Me.txtTelefono.Mask = "(999)000-0000"
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(111, 20)
        Me.txtTelefono.TabIndex = 32
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(360, 142)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(105, 13)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Télefono Alterno:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(420, 195)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 13)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "E-mail:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(415, 167)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 13)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Celular:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(404, 114)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 13)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Teléfono:"
        '
        'cboLeerEscribir
        '
        Me.cboLeerEscribir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLeerEscribir.FormattingEnabled = True
        Me.cboLeerEscribir.Items.AddRange(New Object() {"Si", "No"})
        Me.cboLeerEscribir.Location = New System.Drawing.Point(461, 77)
        Me.cboLeerEscribir.Name = "cboLeerEscribir"
        Me.cboLeerEscribir.Size = New System.Drawing.Size(260, 21)
        Me.cboLeerEscribir.TabIndex = 27
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(355, 84)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 13)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Sabe leer-escribir:"
        '
        'cboNivelEstudios
        '
        Me.cboNivelEstudios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNivelEstudios.FormattingEnabled = True
        Me.cboNivelEstudios.Items.AddRange(New Object() {"Posgrado", "Licenciatura", "Bachillerato", "Secundaria", "Primaria", "No tiene estudios"})
        Me.cboNivelEstudios.Location = New System.Drawing.Point(461, 50)
        Me.cboNivelEstudios.Name = "cboNivelEstudios"
        Me.cboNivelEstudios.Size = New System.Drawing.Size(260, 21)
        Me.cboNivelEstudios.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(355, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Nivel de Estudios:"
        '
        'cboOcupacion
        '
        Me.cboOcupacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOcupacion.FormattingEnabled = True
        Me.cboOcupacion.Items.AddRange(New Object() {"Trabajador(a)", "Ama(o) de casa", "Estudiante"})
        Me.cboOcupacion.Location = New System.Drawing.Point(461, 23)
        Me.cboOcupacion.Name = "cboOcupacion"
        Me.cboOcupacion.Size = New System.Drawing.Size(260, 21)
        Me.cboOcupacion.TabIndex = 23
        '
        'cboParentesco
        '
        Me.cboParentesco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboParentesco.FormattingEnabled = True
        Me.cboParentesco.Items.AddRange(New Object() {"Padre", "Madre", "Hermano(a)", "Abuelo(a)", "Tío(a)", "Otro", "No tiene parentesco"})
        Me.cboParentesco.Location = New System.Drawing.Point(87, 191)
        Me.cboParentesco.Name = "cboParentesco"
        Me.cboParentesco.Size = New System.Drawing.Size(121, 21)
        Me.cboParentesco.TabIndex = 22
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 195)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Parentesco:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(4, 146)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Nacimiento:"
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
        Me.cboGenero.FormattingEnabled = True
        Me.cboGenero.Items.AddRange(New Object() {"Femenino ", "Masculino"})
        Me.cboGenero.Location = New System.Drawing.Point(87, 160)
        Me.cboGenero.Name = "cboGenero"
        Me.cboGenero.Size = New System.Drawing.Size(121, 21)
        Me.cboGenero.TabIndex = 14
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
        Me.Label8.Location = New System.Drawing.Point(393, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Ocupación:"
        '
        'txtEntidad
        '
        Me.txtEntidad.Location = New System.Drawing.Point(87, 134)
        Me.txtEntidad.Mask = "????????????????????"
        Me.txtEntidad.Name = "txtEntidad"
        Me.txtEntidad.Size = New System.Drawing.Size(267, 20)
        Me.txtEntidad.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Género:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Entidad de"
        '
        'txtFechaNacimiento
        '
        Me.txtFechaNacimiento.Location = New System.Drawing.Point(85, 107)
        Me.txtFechaNacimiento.Mask = "00/00/0000"
        Me.txtFechaNacimiento.Name = "txtFechaNacimiento"
        Me.txtFechaNacimiento.Size = New System.Drawing.Size(120, 20)
        Me.txtFechaNacimiento.TabIndex = 12
        Me.txtFechaNacimiento.ValidatingType = GetType(Date)
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(68, 77)
        Me.txtNombre.Mask = "??????????????????????????????"
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(285, 20)
        Me.txtNombre.TabIndex = 10
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(104, 50)
        Me.txtApellidoMaterno.Mask = "???????????????"
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(248, 20)
        Me.txtApellidoMaterno.TabIndex = 9
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(104, 24)
        Me.txtApellidoPaterno.Mask = "???????????????"
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(248, 20)
        Me.txtApellidoPaterno.TabIndex = 8
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Apellido Paterno:"
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(562, 268)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(176, 47)
        Me.cmdSalir.TabIndex = 12
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Enabled = False
        Me.cmdGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Location = New System.Drawing.Point(287, 268)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(176, 47)
        Me.cmdGuardar.TabIndex = 11
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 268)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(176, 47)
        Me.cmdNuevo.TabIndex = 10
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'txtIdTutor
        '
        Me.txtIdTutor.Enabled = False
        Me.txtIdTutor.Location = New System.Drawing.Point(630, 15)
        Me.txtIdTutor.Name = "txtIdTutor"
        Me.txtIdTutor.Size = New System.Drawing.Size(105, 20)
        Me.txtIdTutor.TabIndex = 36
        '
        'frmTutores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(751, 318)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtIdTutor)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.gbDatos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmTutores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TUTORES"
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents gbDatos As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cboGenero As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEntidad As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFechaNacimiento As MaskedTextBox
    Friend WithEvents txtNombre As MaskedTextBox
    Friend WithEvents txtApellidoMaterno As MaskedTextBox
    Friend WithEvents txtApellidoPaterno As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cboParentesco As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cboOcupacion As ComboBox
    Friend WithEvents cboNivelEstudios As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cboLeerEscribir As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtEmail As MaskedTextBox
    Friend WithEvents txtCelular As MaskedTextBox
    Friend WithEvents txtTelefonoAlterno As MaskedTextBox
    Friend WithEvents txtTelefono As MaskedTextBox
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cmdGuardar As Button
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents txtIdTutor As MaskedTextBox
End Class
