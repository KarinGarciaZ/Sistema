<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsTutores
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
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.dgGeneral = New System.Windows.Forms.DataGridView()
        Me.idTutor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.app = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.parentesco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ocupacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nivelEstudios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.celular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.radioTutor = New System.Windows.Forms.RadioButton()
        Me.radioConsulta = New System.Windows.Forms.RadioButton()
        Me.dgTutor = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.parentes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ocup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboTutor = New System.Windows.Forms.ComboBox()
        Me.TutoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdKinderDataSet = New SistemaKinder.bdKinderDataSet()
        Me.txtApp = New System.Windows.Forms.TextBox()
        Me.txtApm = New System.Windows.Forms.TextBox()
        Me.lblApp = New System.Windows.Forms.Label()
        Me.lblApm = New System.Windows.Forms.Label()
        Me.TutoresTableAdapter = New SistemaKinder.bdKinderDataSetTableAdapters.TutoresTableAdapter()
        CType(Me.dgGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTutor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TutoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdKinderDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(1126, 277)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(149, 39)
        Me.cmdSalir.TabIndex = 3
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'dgGeneral
        '
        Me.dgGeneral.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGeneral.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idTutor, Me.nombre, Me.app, Me.apm, Me.parentesco, Me.genero, Me.ocupacion, Me.nivelEstudios, Me.telefono, Me.celular, Me.correo})
        Me.dgGeneral.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgGeneral.Location = New System.Drawing.Point(16, 71)
        Me.dgGeneral.Name = "dgGeneral"
        Me.dgGeneral.ReadOnly = True
        Me.dgGeneral.RowHeadersVisible = False
        Me.dgGeneral.Size = New System.Drawing.Size(1259, 197)
        Me.dgGeneral.TabIndex = 2
        '
        'idTutor
        '
        Me.idTutor.HeaderText = "IdTutor"
        Me.idTutor.Name = "idTutor"
        Me.idTutor.ReadOnly = True
        Me.idTutor.Width = 50
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 150
        '
        'app
        '
        Me.app.HeaderText = "Apellido Paterno"
        Me.app.Name = "app"
        Me.app.ReadOnly = True
        '
        'apm
        '
        Me.apm.HeaderText = "Apellido Materno"
        Me.apm.Name = "apm"
        Me.apm.ReadOnly = True
        '
        'parentesco
        '
        Me.parentesco.HeaderText = "Parentesco"
        Me.parentesco.Name = "parentesco"
        Me.parentesco.ReadOnly = True
        '
        'genero
        '
        Me.genero.HeaderText = "Genero"
        Me.genero.Name = "genero"
        Me.genero.ReadOnly = True
        '
        'ocupacion
        '
        Me.ocupacion.HeaderText = "Ocupación"
        Me.ocupacion.Name = "ocupacion"
        Me.ocupacion.ReadOnly = True
        Me.ocupacion.Width = 150
        '
        'nivelEstudios
        '
        Me.nivelEstudios.HeaderText = "Nivel Estudios"
        Me.nivelEstudios.Name = "nivelEstudios"
        Me.nivelEstudios.ReadOnly = True
        Me.nivelEstudios.Width = 150
        '
        'telefono
        '
        Me.telefono.HeaderText = "Teléfono"
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        '
        'celular
        '
        Me.celular.HeaderText = "Celular"
        Me.celular.Name = "celular"
        Me.celular.ReadOnly = True
        '
        'correo
        '
        Me.correo.HeaderText = "Correo"
        Me.correo.Name = "correo"
        Me.correo.ReadOnly = True
        Me.correo.Width = 150
        '
        'radioTutor
        '
        Me.radioTutor.AutoSize = True
        Me.radioTutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioTutor.Location = New System.Drawing.Point(16, 12)
        Me.radioTutor.Name = "radioTutor"
        Me.radioTutor.Size = New System.Drawing.Size(58, 19)
        Me.radioTutor.TabIndex = 4
        Me.radioTutor.TabStop = True
        Me.radioTutor.Text = "Tutor"
        Me.radioTutor.UseVisualStyleBackColor = True
        '
        'radioConsulta
        '
        Me.radioConsulta.AutoSize = True
        Me.radioConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioConsulta.Location = New System.Drawing.Point(16, 38)
        Me.radioConsulta.Name = "radioConsulta"
        Me.radioConsulta.Size = New System.Drawing.Size(136, 19)
        Me.radioConsulta.TabIndex = 6
        Me.radioConsulta.TabStop = True
        Me.radioConsulta.Text = "Consulta General"
        Me.radioConsulta.UseVisualStyleBackColor = True
        '
        'dgTutor
        '
        Me.dgTutor.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgTutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTutor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.parentes, Me.Email, Me.tel, Me.cel, Me.ocup})
        Me.dgTutor.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgTutor.Location = New System.Drawing.Point(16, 71)
        Me.dgTutor.Name = "dgTutor"
        Me.dgTutor.ReadOnly = True
        Me.dgTutor.RowHeadersVisible = False
        Me.dgTutor.Size = New System.Drawing.Size(1259, 200)
        Me.dgTutor.TabIndex = 7
        Me.dgTutor.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Matrícula"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Alumno"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellido Paterno"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 130
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Apellido Materno"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 130
        '
        'parentes
        '
        Me.parentes.HeaderText = "Parentesco"
        Me.parentes.Name = "parentes"
        Me.parentes.ReadOnly = True
        '
        'Email
        '
        Me.Email.HeaderText = "Correo"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Width = 200
        '
        'tel
        '
        Me.tel.HeaderText = "Teléfono"
        Me.tel.Name = "tel"
        Me.tel.ReadOnly = True
        '
        'cel
        '
        Me.cel.HeaderText = "Celular"
        Me.cel.Name = "cel"
        Me.cel.ReadOnly = True
        '
        'ocup
        '
        Me.ocup.HeaderText = "Ocupación"
        Me.ocup.Name = "ocup"
        Me.ocup.ReadOnly = True
        '
        'cboTutor
        '
        Me.cboTutor.DataSource = Me.TutoresBindingSource
        Me.cboTutor.DisplayMember = "nombre"
        Me.cboTutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTutor.FormattingEnabled = True
        Me.cboTutor.Location = New System.Drawing.Point(80, 12)
        Me.cboTutor.Name = "cboTutor"
        Me.cboTutor.Size = New System.Drawing.Size(215, 21)
        Me.cboTutor.TabIndex = 8
        Me.cboTutor.ValueMember = "idTutor"
        Me.cboTutor.Visible = False
        '
        'TutoresBindingSource
        '
        Me.TutoresBindingSource.DataMember = "Tutores"
        Me.TutoresBindingSource.DataSource = Me.BdKinderDataSet
        '
        'BdKinderDataSet
        '
        Me.BdKinderDataSet.DataSetName = "bdKinderDataSet"
        Me.BdKinderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtApp
        '
        Me.txtApp.Enabled = False
        Me.txtApp.Location = New System.Drawing.Point(440, 13)
        Me.txtApp.Name = "txtApp"
        Me.txtApp.Size = New System.Drawing.Size(184, 20)
        Me.txtApp.TabIndex = 9
        Me.txtApp.Visible = False
        '
        'txtApm
        '
        Me.txtApm.Enabled = False
        Me.txtApm.Location = New System.Drawing.Point(782, 13)
        Me.txtApm.Name = "txtApm"
        Me.txtApm.Size = New System.Drawing.Size(184, 20)
        Me.txtApm.TabIndex = 10
        Me.txtApm.Visible = False
        '
        'lblApp
        '
        Me.lblApp.AutoSize = True
        Me.lblApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApp.Location = New System.Drawing.Point(317, 14)
        Me.lblApp.Name = "lblApp"
        Me.lblApp.Size = New System.Drawing.Size(117, 15)
        Me.lblApp.TabIndex = 11
        Me.lblApp.Text = "Apellido Paterno:"
        Me.lblApp.Visible = False
        '
        'lblApm
        '
        Me.lblApm.AutoSize = True
        Me.lblApm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApm.Location = New System.Drawing.Point(661, 14)
        Me.lblApm.Name = "lblApm"
        Me.lblApm.Size = New System.Drawing.Size(120, 15)
        Me.lblApm.TabIndex = 12
        Me.lblApm.Text = "Apellido Materno:"
        Me.lblApm.Visible = False
        '
        'TutoresTableAdapter
        '
        Me.TutoresTableAdapter.ClearBeforeFill = True
        '
        'frmConsTutores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1283, 325)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblApm)
        Me.Controls.Add(Me.lblApp)
        Me.Controls.Add(Me.txtApm)
        Me.Controls.Add(Me.txtApp)
        Me.Controls.Add(Me.cboTutor)
        Me.Controls.Add(Me.dgTutor)
        Me.Controls.Add(Me.radioConsulta)
        Me.Controls.Add(Me.radioTutor)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.dgGeneral)
        Me.Name = "frmConsTutores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA DE TUTORES"
        CType(Me.dgGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTutor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TutoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdKinderDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdSalir As Button
    Friend WithEvents dgGeneral As DataGridView
    Friend WithEvents radioTutor As RadioButton
    Friend WithEvents radioConsulta As RadioButton
    Friend WithEvents dgTutor As DataGridView
    Friend WithEvents idTutor As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents app As DataGridViewTextBoxColumn
    Friend WithEvents apm As DataGridViewTextBoxColumn
    Friend WithEvents parentesco As DataGridViewTextBoxColumn
    Friend WithEvents genero As DataGridViewTextBoxColumn
    Friend WithEvents ocupacion As DataGridViewTextBoxColumn
    Friend WithEvents nivelEstudios As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents celular As DataGridViewTextBoxColumn
    Friend WithEvents correo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents parentes As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents tel As DataGridViewTextBoxColumn
    Friend WithEvents cel As DataGridViewTextBoxColumn
    Friend WithEvents ocup As DataGridViewTextBoxColumn
    Friend WithEvents cboTutor As ComboBox
    Friend WithEvents txtApp As TextBox
    Friend WithEvents txtApm As TextBox
    Friend WithEvents lblApp As Label
    Friend WithEvents lblApm As Label
    Friend WithEvents BdKinderDataSet As bdKinderDataSet
    Friend WithEvents TutoresBindingSource As BindingSource
    Friend WithEvents TutoresTableAdapter As bdKinderDataSetTableAdapters.TutoresTableAdapter
End Class
