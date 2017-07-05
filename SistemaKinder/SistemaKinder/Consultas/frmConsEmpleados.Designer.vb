<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsEmpleados
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
        Me.dgEmpleados = New System.Windows.Forms.DataGridView()
        Me.idEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.app = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.puesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.radioPuesto = New System.Windows.Forms.RadioButton()
        Me.radioGeneral = New System.Windows.Forms.RadioButton()
        Me.cboPuesto = New System.Windows.Forms.ComboBox()
        Me.BdKinderDataSet = New SistemaKinder.bdKinderDataSet()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosTableAdapter = New SistemaKinder.bdKinderDataSetTableAdapters.EmpleadosTableAdapter()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdKinderDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(578, 267)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(149, 48)
        Me.cmdSalir.TabIndex = 3
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'dgEmpleados
        '
        Me.dgEmpleados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idEmpleado, Me.nombre, Me.app, Me.apm, Me.puesto})
        Me.dgEmpleados.Location = New System.Drawing.Point(17, 64)
        Me.dgEmpleados.Name = "dgEmpleados"
        Me.dgEmpleados.ReadOnly = True
        Me.dgEmpleados.RowHeadersVisible = False
        Me.dgEmpleados.Size = New System.Drawing.Size(710, 197)
        Me.dgEmpleados.TabIndex = 2
        '
        'idEmpleado
        '
        Me.idEmpleado.HeaderText = "IdEmpleado"
        Me.idEmpleado.Name = "idEmpleado"
        Me.idEmpleado.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 200
        '
        'app
        '
        Me.app.HeaderText = "Apellido Paterno"
        Me.app.Name = "app"
        Me.app.ReadOnly = True
        Me.app.Width = 150
        '
        'apm
        '
        Me.apm.HeaderText = "Apellido Materno"
        Me.apm.Name = "apm"
        Me.apm.ReadOnly = True
        Me.apm.Width = 150
        '
        'puesto
        '
        Me.puesto.HeaderText = "Puesto"
        Me.puesto.Name = "puesto"
        Me.puesto.ReadOnly = True
        '
        'radioPuesto
        '
        Me.radioPuesto.AutoSize = True
        Me.radioPuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioPuesto.Location = New System.Drawing.Point(17, 12)
        Me.radioPuesto.Name = "radioPuesto"
        Me.radioPuesto.Size = New System.Drawing.Size(64, 17)
        Me.radioPuesto.TabIndex = 4
        Me.radioPuesto.TabStop = True
        Me.radioPuesto.Text = "Puesto"
        Me.radioPuesto.UseVisualStyleBackColor = True
        '
        'radioGeneral
        '
        Me.radioGeneral.AutoSize = True
        Me.radioGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioGeneral.Location = New System.Drawing.Point(17, 35)
        Me.radioGeneral.Name = "radioGeneral"
        Me.radioGeneral.Size = New System.Drawing.Size(122, 17)
        Me.radioGeneral.TabIndex = 5
        Me.radioGeneral.TabStop = True
        Me.radioGeneral.Text = "Consulta General"
        Me.radioGeneral.UseVisualStyleBackColor = True
        '
        'cboPuesto
        '
        Me.cboPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPuesto.FormattingEnabled = True
        Me.cboPuesto.Items.AddRange(New Object() {"Maestro", "Director", "Intendente"})
        Me.cboPuesto.Location = New System.Drawing.Point(97, 11)
        Me.cboPuesto.Name = "cboPuesto"
        Me.cboPuesto.Size = New System.Drawing.Size(172, 21)
        Me.cboPuesto.TabIndex = 6
        Me.cboPuesto.Visible = False
        '
        'BdKinderDataSet
        '
        Me.BdKinderDataSet.DataSetName = "bdKinderDataSet"
        Me.BdKinderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.BdKinderDataSet
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'frmConsEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(739, 327)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboPuesto)
        Me.Controls.Add(Me.radioGeneral)
        Me.Controls.Add(Me.radioPuesto)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.dgEmpleados)
        Me.Name = "frmConsEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA DE EMPLEADOS"
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdKinderDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdSalir As Button
    Friend WithEvents dgEmpleados As DataGridView
    Friend WithEvents idEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents app As DataGridViewTextBoxColumn
    Friend WithEvents apm As DataGridViewTextBoxColumn
    Friend WithEvents puesto As DataGridViewTextBoxColumn
    Friend WithEvents radioPuesto As RadioButton
    Friend WithEvents radioGeneral As RadioButton
    Friend WithEvents cboPuesto As ComboBox
    Friend WithEvents BdKinderDataSet As bdKinderDataSet
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As bdKinderDataSetTableAdapters.EmpleadosTableAdapter
End Class
