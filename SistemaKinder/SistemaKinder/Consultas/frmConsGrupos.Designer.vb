<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsGrupos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.dgGrupos = New System.Windows.Forms.DataGridView()
        Me.matricula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.app = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboGrupo = New System.Windows.Forms.ComboBox()
        Me.GruposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdKinderDataSet = New SistemaKinder.bdKinderDataSet()
        Me.cboGrado = New System.Windows.Forms.ComboBox()
        Me.GruposBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtMaestro = New System.Windows.Forms.MaskedTextBox()
        Me.txtGeneracion = New System.Windows.Forms.MaskedTextBox()
        Me.txtTotalAlumnos = New System.Windows.Forms.MaskedTextBox()
        Me.GruposTableAdapter = New SistemaKinder.bdKinderDataSetTableAdapters.GruposTableAdapter()
        CType(Me.dgGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdKinderDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GruposBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(475, 305)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(149, 39)
        Me.cmdSalir.TabIndex = 3
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'dgGrupos
        '
        Me.dgGrupos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGrupos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.matricula, Me.nombre, Me.app, Me.apm})
        Me.dgGrupos.Location = New System.Drawing.Point(11, 95)
        Me.dgGrupos.Name = "dgGrupos"
        Me.dgGrupos.ReadOnly = True
        Me.dgGrupos.RowHeadersVisible = False
        Me.dgGrupos.Size = New System.Drawing.Size(615, 197)
        Me.dgGrupos.TabIndex = 4
        '
        'matricula
        '
        Me.matricula.HeaderText = "Matrícula"
        Me.matricula.Name = "matricula"
        Me.matricula.ReadOnly = True
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Grupo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(222, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Grado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Maestro:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Generación:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(384, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Total de Alumnos:"
        '
        'cboGrupo
        '
        Me.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrupo.FormattingEnabled = True
        Me.cboGrupo.Items.AddRange(New Object() {"A", "B"})
        Me.cboGrupo.Location = New System.Drawing.Point(72, 18)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(121, 21)
        Me.cboGrupo.TabIndex = 10
        '
        'GruposBindingSource
        '
        Me.GruposBindingSource.DataMember = "Grupos"
        Me.GruposBindingSource.DataSource = Me.BdKinderDataSet
        '
        'BdKinderDataSet
        '
        Me.BdKinderDataSet.DataSetName = "bdKinderDataSet"
        Me.BdKinderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboGrado
        '
        Me.cboGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrado.FormattingEnabled = True
        Me.cboGrado.Items.AddRange(New Object() {"2", "3"})
        Me.cboGrado.Location = New System.Drawing.Point(278, 18)
        Me.cboGrado.Name = "cboGrado"
        Me.cboGrado.Size = New System.Drawing.Size(121, 21)
        Me.cboGrado.TabIndex = 11
        '
        'GruposBindingSource1
        '
        Me.GruposBindingSource1.DataMember = "Grupos"
        Me.GruposBindingSource1.DataSource = Me.BdKinderDataSet
        '
        'txtMaestro
        '
        Me.txtMaestro.Enabled = False
        Me.txtMaestro.Location = New System.Drawing.Point(72, 46)
        Me.txtMaestro.Name = "txtMaestro"
        Me.txtMaestro.Size = New System.Drawing.Size(552, 20)
        Me.txtMaestro.TabIndex = 12
        '
        'txtGeneracion
        '
        Me.txtGeneracion.Enabled = False
        Me.txtGeneracion.Location = New System.Drawing.Point(102, 70)
        Me.txtGeneracion.Name = "txtGeneracion"
        Me.txtGeneracion.Size = New System.Drawing.Size(121, 20)
        Me.txtGeneracion.TabIndex = 13
        '
        'txtTotalAlumnos
        '
        Me.txtTotalAlumnos.Enabled = False
        Me.txtTotalAlumnos.Location = New System.Drawing.Point(503, 72)
        Me.txtTotalAlumnos.Name = "txtTotalAlumnos"
        Me.txtTotalAlumnos.Size = New System.Drawing.Size(121, 20)
        Me.txtTotalAlumnos.TabIndex = 14
        '
        'GruposTableAdapter
        '
        Me.GruposTableAdapter.ClearBeforeFill = True
        '
        'frmConsGrupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(636, 356)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtTotalAlumnos)
        Me.Controls.Add(Me.txtGeneracion)
        Me.Controls.Add(Me.txtMaestro)
        Me.Controls.Add(Me.cboGrado)
        Me.Controls.Add(Me.cboGrupo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgGrupos)
        Me.Controls.Add(Me.cmdSalir)
        Me.Name = "frmConsGrupos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA DE GRUPOS"
        CType(Me.dgGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdKinderDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GruposBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdSalir As Button
    Friend WithEvents dgGrupos As DataGridView
    Friend WithEvents matricula As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents app As DataGridViewTextBoxColumn
    Friend WithEvents apm As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboGrupo As ComboBox
    Friend WithEvents cboGrado As ComboBox
    Friend WithEvents txtMaestro As MaskedTextBox
    Friend WithEvents txtGeneracion As MaskedTextBox
    Friend WithEvents txtTotalAlumnos As MaskedTextBox
    Friend WithEvents BdKinderDataSet As bdKinderDataSet
    Friend WithEvents GruposBindingSource As BindingSource
    Friend WithEvents GruposTableAdapter As bdKinderDataSetTableAdapters.GruposTableAdapter
    Friend WithEvents GruposBindingSource1 As BindingSource
End Class
