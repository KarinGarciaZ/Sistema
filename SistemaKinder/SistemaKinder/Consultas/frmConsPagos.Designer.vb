<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsPagos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMatricula = New System.Windows.Forms.MaskedTextBox()
        Me.rbMatricula = New System.Windows.Forms.RadioButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtAlumno = New System.Windows.Forms.MaskedTextBox()
        Me.txtID = New System.Windows.Forms.MaskedTextBox()
        Me.rbFecha = New System.Windows.Forms.RadioButton()
        Me.rbAlumno = New System.Windows.Forms.RadioButton()
        Me.rbID = New System.Windows.Forms.RadioButton()
        Me.dgPagos = New System.Windows.Forms.DataGridView()
        Me.idPrestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMatricula)
        Me.GroupBox1.Controls.Add(Me.rbMatricula)
        Me.GroupBox1.Controls.Add(Me.rbTodos)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.txtAlumno)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.rbFecha)
        Me.GroupBox1.Controls.Add(Me.rbAlumno)
        Me.GroupBox1.Controls.Add(Me.rbID)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(671, 99)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar pago por:"
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(148, 48)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(145, 20)
        Me.txtMatricula.TabIndex = 8
        Me.txtMatricula.Visible = False
        '
        'rbMatricula
        '
        Me.rbMatricula.AutoSize = True
        Me.rbMatricula.Location = New System.Drawing.Point(22, 48)
        Me.rbMatricula.Name = "rbMatricula"
        Me.rbMatricula.Size = New System.Drawing.Size(120, 17)
        Me.rbMatricula.TabIndex = 7
        Me.rbMatricula.TabStop = True
        Me.rbMatricula.Text = "Matricula de alumno"
        Me.rbMatricula.UseVisualStyleBackColor = True
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Location = New System.Drawing.Point(387, 48)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(55, 17)
        Me.rbTodos.TabIndex = 6
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(456, 19)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 5
        Me.dtpFecha.Visible = False
        '
        'txtAlumno
        '
        Me.txtAlumno.Location = New System.Drawing.Point(118, 73)
        Me.txtAlumno.Name = "txtAlumno"
        Me.txtAlumno.Size = New System.Drawing.Size(257, 20)
        Me.txtAlumno.TabIndex = 4
        Me.txtAlumno.Visible = False
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(163, 22)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 3
        Me.txtID.Visible = False
        '
        'rbFecha
        '
        Me.rbFecha.AutoSize = True
        Me.rbFecha.Location = New System.Drawing.Point(387, 19)
        Me.rbFecha.Name = "rbFecha"
        Me.rbFecha.Size = New System.Drawing.Size(55, 17)
        Me.rbFecha.TabIndex = 2
        Me.rbFecha.TabStop = True
        Me.rbFecha.Text = "Fecha"
        Me.rbFecha.UseVisualStyleBackColor = True
        '
        'rbAlumno
        '
        Me.rbAlumno.AutoSize = True
        Me.rbAlumno.Location = New System.Drawing.Point(22, 73)
        Me.rbAlumno.Name = "rbAlumno"
        Me.rbAlumno.Size = New System.Drawing.Size(99, 17)
        Me.rbAlumno.TabIndex = 1
        Me.rbAlumno.TabStop = True
        Me.rbAlumno.Text = "Nombre alumno"
        Me.rbAlumno.UseVisualStyleBackColor = True
        '
        'rbID
        '
        Me.rbID.AutoSize = True
        Me.rbID.Location = New System.Drawing.Point(22, 23)
        Me.rbID.Name = "rbID"
        Me.rbID.Size = New System.Drawing.Size(120, 17)
        Me.rbID.TabIndex = 0
        Me.rbID.TabStop = True
        Me.rbID.Text = "Codigo de pago (ID)"
        Me.rbID.UseVisualStyleBackColor = True
        '
        'dgPagos
        '
        Me.dgPagos.AllowUserToAddRows = False
        Me.dgPagos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idPrestamo, Me.empleado, Me.fecha, Me.concepto, Me.Column1})
        Me.dgPagos.Location = New System.Drawing.Point(11, 117)
        Me.dgPagos.Name = "dgPagos"
        Me.dgPagos.ReadOnly = True
        Me.dgPagos.RowHeadersVisible = False
        Me.dgPagos.Size = New System.Drawing.Size(704, 214)
        Me.dgPagos.TabIndex = 8
        '
        'idPrestamo
        '
        Me.idPrestamo.HeaderText = "IdPago"
        Me.idPrestamo.Name = "idPrestamo"
        Me.idPrestamo.ReadOnly = True
        Me.idPrestamo.Width = 80
        '
        'empleado
        '
        Me.empleado.HeaderText = "Nombre Alumno"
        Me.empleado.Name = "empleado"
        Me.empleado.ReadOnly = True
        Me.empleado.Width = 200
        '
        'fecha
        '
        Me.fecha.HeaderText = "Concepto"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 200
        '
        'concepto
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.concepto.DefaultCellStyle = DataGridViewCellStyle1
        Me.concepto.HeaderText = "Fecha"
        Me.concepto.Name = "concepto"
        Me.concepto.ReadOnly = True
        '
        'Column1
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "Importe"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(290, 337)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(130, 44)
        Me.cmdSalir.TabIndex = 9
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'frmConsPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(727, 384)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.dgPagos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmConsPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA DE PAGOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMatricula As MaskedTextBox
    Friend WithEvents rbMatricula As RadioButton
    Friend WithEvents rbTodos As RadioButton
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtAlumno As MaskedTextBox
    Friend WithEvents txtID As MaskedTextBox
    Friend WithEvents rbFecha As RadioButton
    Friend WithEvents rbAlumno As RadioButton
    Friend WithEvents rbID As RadioButton
    Friend WithEvents dgPagos As DataGridView
    Friend WithEvents cmdSalir As Button
    Friend WithEvents idPrestamo As DataGridViewTextBoxColumn
    Friend WithEvents empleado As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents concepto As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
