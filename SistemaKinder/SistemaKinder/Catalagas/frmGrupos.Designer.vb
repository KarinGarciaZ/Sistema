<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrupos
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
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNoAlumnos = New System.Windows.Forms.MaskedTextBox()
        Me.cboGrupo = New System.Windows.Forms.ComboBox()
        Me.cboGrado = New System.Windows.Forms.ComboBox()
        Me.cboMaestro = New System.Windows.Forms.ComboBox()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdKinderDataSet = New SistemaKinder.bdKinderDataSet()
        Me.txtGeneracion = New System.Windows.Forms.MaskedTextBox()
        Me.txtIdGrupo = New System.Windows.Forms.MaskedTextBox()
        Me.EmpleadosTableAdapter = New SistemaKinder.bdKinderDataSetTableAdapters.EmpleadosTableAdapter()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillByToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdKinderDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.FillByToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevo.Location = New System.Drawing.Point(21, 162)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(131, 51)
        Me.cmdNuevo.TabIndex = 0
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGrabar.Location = New System.Drawing.Point(193, 162)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(131, 51)
        Me.cmdGrabar.TabIndex = 1
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(365, 162)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(131, 51)
        Me.cmdSalir.TabIndex = 2
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(371, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "IdGrupo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Maestro:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Generación:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Grado:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(356, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Grupo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(325, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "no.Alumnos:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNoAlumnos)
        Me.GroupBox1.Controls.Add(Me.cboGrupo)
        Me.GroupBox1.Controls.Add(Me.cboGrado)
        Me.GroupBox1.Controls.Add(Me.cboMaestro)
        Me.GroupBox1.Controls.Add(Me.txtGeneracion)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 110)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro"
        '
        'txtNoAlumnos
        '
        Me.txtNoAlumnos.Enabled = False
        Me.txtNoAlumnos.Location = New System.Drawing.Point(399, 49)
        Me.txtNoAlumnos.Name = "txtNoAlumnos"
        Me.txtNoAlumnos.Size = New System.Drawing.Size(71, 20)
        Me.txtNoAlumnos.TabIndex = 14
        '
        'cboGrupo
        '
        Me.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrupo.Enabled = False
        Me.cboGrupo.FormattingEnabled = True
        Me.cboGrupo.Items.AddRange(New Object() {"A", "B"})
        Me.cboGrupo.Location = New System.Drawing.Point(399, 22)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(71, 21)
        Me.cboGrupo.TabIndex = 13
        '
        'cboGrado
        '
        Me.cboGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrado.Enabled = False
        Me.cboGrado.FormattingEnabled = True
        Me.cboGrado.Items.AddRange(New Object() {"2", "3"})
        Me.cboGrado.Location = New System.Drawing.Point(75, 69)
        Me.cboGrado.Name = "cboGrado"
        Me.cboGrado.Size = New System.Drawing.Size(69, 21)
        Me.cboGrado.TabIndex = 11
        '
        'cboMaestro
        '
        Me.cboMaestro.DataSource = Me.EmpleadosBindingSource
        Me.cboMaestro.DisplayMember = "nombre"
        Me.cboMaestro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMaestro.Enabled = False
        Me.cboMaestro.FormattingEnabled = True
        Me.cboMaestro.Location = New System.Drawing.Point(75, 19)
        Me.cboMaestro.Name = "cboMaestro"
        Me.cboMaestro.Size = New System.Drawing.Size(247, 21)
        Me.cboMaestro.TabIndex = 10
        Me.cboMaestro.ValueMember = "idEmpleado"
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.BdKinderDataSet
        '
        'BdKinderDataSet
        '
        Me.BdKinderDataSet.DataSetName = "bdKinderDataSet"
        Me.BdKinderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtGeneracion
        '
        Me.txtGeneracion.Enabled = False
        Me.txtGeneracion.Location = New System.Drawing.Point(75, 44)
        Me.txtGeneracion.Mask = "0000-0000"
        Me.txtGeneracion.Name = "txtGeneracion"
        Me.txtGeneracion.Size = New System.Drawing.Size(139, 20)
        Me.txtGeneracion.TabIndex = 9
        '
        'txtIdGrupo
        '
        Me.txtIdGrupo.Enabled = False
        Me.txtIdGrupo.Location = New System.Drawing.Point(425, 20)
        Me.txtIdGrupo.Name = "txtIdGrupo"
        Me.txtIdGrupo.Size = New System.Drawing.Size(71, 20)
        Me.txtIdGrupo.TabIndex = 15
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(518, 25)
        Me.FillByToolStrip.TabIndex = 16
        Me.FillByToolStrip.Text = "FillByToolStrip"
        Me.FillByToolStrip.Visible = False
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'FillByToolStrip1
        '
        Me.FillByToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton1})
        Me.FillByToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip1.Name = "FillByToolStrip1"
        Me.FillByToolStrip1.Size = New System.Drawing.Size(111, 25)
        Me.FillByToolStrip1.TabIndex = 17
        Me.FillByToolStrip1.Text = "FillByToolStrip1"
        '
        'FillByToolStripButton1
        '
        Me.FillByToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton1.Name = "FillByToolStripButton1"
        Me.FillByToolStripButton1.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton1.Text = "FillBy"
        '
        'frmGrupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(518, 225)
        Me.ControlBox = False
        Me.Controls.Add(Me.FillByToolStrip1)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.txtIdGrupo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.MaximizeBox = False
        Me.Name = "frmGrupos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GRUPOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdKinderDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.FillByToolStrip1.ResumeLayout(False)
        Me.FillByToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdNuevo As Button
    Friend WithEvents cmdGrabar As Button
    Friend WithEvents cmdSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNoAlumnos As MaskedTextBox
    Friend WithEvents cboGrupo As ComboBox
    Friend WithEvents cboGrado As ComboBox
    Friend WithEvents cboMaestro As ComboBox
    Friend WithEvents txtGeneracion As MaskedTextBox
    Friend WithEvents txtIdGrupo As MaskedTextBox
    Friend WithEvents BdKinderDataSet As bdKinderDataSet
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As bdKinderDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents FillByToolStrip1 As ToolStrip
    Friend WithEvents FillByToolStripButton1 As ToolStripButton
End Class
