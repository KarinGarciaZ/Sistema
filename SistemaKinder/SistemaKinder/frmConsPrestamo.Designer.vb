<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsPrestamo
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
        Me.radioPrestamo = New System.Windows.Forms.RadioButton()
        Me.radioEmpleado = New System.Windows.Forms.RadioButton()
        Me.radioMaterial = New System.Windows.Forms.RadioButton()
        Me.radioConsulta = New System.Windows.Forms.RadioButton()
        Me.dgPrestamo = New System.Windows.Forms.DataGridView()
        Me.idPrestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cboPrestamo = New System.Windows.Forms.ComboBox()
        Me.cboEmpleado = New System.Windows.Forms.ComboBox()
        Me.cboMaterial = New System.Windows.Forms.ComboBox()
        Me.lblApp = New System.Windows.Forms.Label()
        Me.lblApm = New System.Windows.Forms.Label()
        Me.txtApp = New System.Windows.Forms.TextBox()
        Me.txtApm = New System.Windows.Forms.TextBox()
        CType(Me.dgPrestamo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radioPrestamo
        '
        Me.radioPrestamo.AutoSize = True
        Me.radioPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioPrestamo.Location = New System.Drawing.Point(12, 11)
        Me.radioPrestamo.Name = "radioPrestamo"
        Me.radioPrestamo.Size = New System.Drawing.Size(90, 19)
        Me.radioPrestamo.TabIndex = 0
        Me.radioPrestamo.TabStop = True
        Me.radioPrestamo.Text = "Préstamo:"
        Me.radioPrestamo.UseVisualStyleBackColor = True
        '
        'radioEmpleado
        '
        Me.radioEmpleado.AutoSize = True
        Me.radioEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioEmpleado.Location = New System.Drawing.Point(12, 36)
        Me.radioEmpleado.Name = "radioEmpleado"
        Me.radioEmpleado.Size = New System.Drawing.Size(94, 19)
        Me.radioEmpleado.TabIndex = 1
        Me.radioEmpleado.TabStop = True
        Me.radioEmpleado.Text = "Empleado:"
        Me.radioEmpleado.UseVisualStyleBackColor = True
        '
        'radioMaterial
        '
        Me.radioMaterial.AutoSize = True
        Me.radioMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioMaterial.Location = New System.Drawing.Point(12, 63)
        Me.radioMaterial.Name = "radioMaterial"
        Me.radioMaterial.Size = New System.Drawing.Size(82, 19)
        Me.radioMaterial.TabIndex = 2
        Me.radioMaterial.TabStop = True
        Me.radioMaterial.Text = "Material:"
        Me.radioMaterial.UseVisualStyleBackColor = True
        '
        'radioConsulta
        '
        Me.radioConsulta.AutoSize = True
        Me.radioConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioConsulta.Location = New System.Drawing.Point(12, 88)
        Me.radioConsulta.Name = "radioConsulta"
        Me.radioConsulta.Size = New System.Drawing.Size(140, 19)
        Me.radioConsulta.TabIndex = 3
        Me.radioConsulta.TabStop = True
        Me.radioConsulta.Text = "Consulta General:"
        Me.radioConsulta.UseVisualStyleBackColor = True
        '
        'dgPrestamo
        '
        Me.dgPrestamo.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPrestamo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idPrestamo, Me.empleado, Me.material, Me.fecha, Me.concepto, Me.cantidad})
        Me.dgPrestamo.Location = New System.Drawing.Point(12, 117)
        Me.dgPrestamo.Name = "dgPrestamo"
        Me.dgPrestamo.ReadOnly = True
        Me.dgPrestamo.RowHeadersVisible = False
        Me.dgPrestamo.Size = New System.Drawing.Size(834, 202)
        Me.dgPrestamo.TabIndex = 4
        '
        'idPrestamo
        '
        Me.idPrestamo.HeaderText = "IdPréstamo"
        Me.idPrestamo.Name = "idPrestamo"
        Me.idPrestamo.ReadOnly = True
        Me.idPrestamo.Width = 70
        '
        'empleado
        '
        Me.empleado.HeaderText = "Empleado"
        Me.empleado.Name = "empleado"
        Me.empleado.ReadOnly = True
        Me.empleado.Width = 250
        '
        'material
        '
        Me.material.HeaderText = "Material"
        Me.material.Name = "material"
        Me.material.ReadOnly = True
        Me.material.Width = 150
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'concepto
        '
        Me.concepto.HeaderText = "Concepto"
        Me.concepto.Name = "concepto"
        Me.concepto.ReadOnly = True
        Me.concepto.Width = 150
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(716, 325)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(130, 44)
        Me.cmdSalir.TabIndex = 5
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cboPrestamo
        '
        Me.cboPrestamo.FormattingEnabled = True
        Me.cboPrestamo.Location = New System.Drawing.Point(108, 9)
        Me.cboPrestamo.Name = "cboPrestamo"
        Me.cboPrestamo.Size = New System.Drawing.Size(121, 21)
        Me.cboPrestamo.TabIndex = 6
        Me.cboPrestamo.Visible = False
        '
        'cboEmpleado
        '
        Me.cboEmpleado.FormattingEnabled = True
        Me.cboEmpleado.Location = New System.Drawing.Point(108, 37)
        Me.cboEmpleado.Name = "cboEmpleado"
        Me.cboEmpleado.Size = New System.Drawing.Size(201, 21)
        Me.cboEmpleado.TabIndex = 7
        Me.cboEmpleado.Visible = False
        '
        'cboMaterial
        '
        Me.cboMaterial.FormattingEnabled = True
        Me.cboMaterial.Location = New System.Drawing.Point(108, 64)
        Me.cboMaterial.Name = "cboMaterial"
        Me.cboMaterial.Size = New System.Drawing.Size(201, 21)
        Me.cboMaterial.TabIndex = 8
        Me.cboMaterial.Visible = False
        '
        'lblApp
        '
        Me.lblApp.AutoSize = True
        Me.lblApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApp.Location = New System.Drawing.Point(315, 40)
        Me.lblApp.Name = "lblApp"
        Me.lblApp.Size = New System.Drawing.Size(117, 15)
        Me.lblApp.TabIndex = 9
        Me.lblApp.Text = "Apellido Paterno:"
        Me.lblApp.Visible = False
        '
        'lblApm
        '
        Me.lblApm.AutoSize = True
        Me.lblApm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApm.Location = New System.Drawing.Point(585, 43)
        Me.lblApm.Name = "lblApm"
        Me.lblApm.Size = New System.Drawing.Size(120, 15)
        Me.lblApm.TabIndex = 10
        Me.lblApm.Text = "Apellido Materno:"
        Me.lblApm.Visible = False
        '
        'txtApp
        '
        Me.txtApp.Enabled = False
        Me.txtApp.Location = New System.Drawing.Point(438, 42)
        Me.txtApp.Name = "txtApp"
        Me.txtApp.Size = New System.Drawing.Size(143, 20)
        Me.txtApp.TabIndex = 11
        Me.txtApp.Visible = False
        '
        'txtApm
        '
        Me.txtApm.Enabled = False
        Me.txtApm.Location = New System.Drawing.Point(703, 43)
        Me.txtApm.Name = "txtApm"
        Me.txtApm.Size = New System.Drawing.Size(143, 20)
        Me.txtApm.TabIndex = 12
        Me.txtApm.Visible = False
        '
        'frmConsPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 374)
        Me.Controls.Add(Me.txtApm)
        Me.Controls.Add(Me.txtApp)
        Me.Controls.Add(Me.lblApm)
        Me.Controls.Add(Me.lblApp)
        Me.Controls.Add(Me.cboMaterial)
        Me.Controls.Add(Me.cboEmpleado)
        Me.Controls.Add(Me.cboPrestamo)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.dgPrestamo)
        Me.Controls.Add(Me.radioConsulta)
        Me.Controls.Add(Me.radioMaterial)
        Me.Controls.Add(Me.radioEmpleado)
        Me.Controls.Add(Me.radioPrestamo)
        Me.Name = "frmConsPrestamo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA PRÉSTAMO MATERIAL"
        CType(Me.dgPrestamo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radioPrestamo As RadioButton
    Friend WithEvents radioEmpleado As RadioButton
    Friend WithEvents radioMaterial As RadioButton
    Friend WithEvents radioConsulta As RadioButton
    Friend WithEvents dgPrestamo As DataGridView
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cboPrestamo As ComboBox
    Friend WithEvents cboEmpleado As ComboBox
    Friend WithEvents cboMaterial As ComboBox
    Friend WithEvents idPrestamo As DataGridViewTextBoxColumn
    Friend WithEvents empleado As DataGridViewTextBoxColumn
    Friend WithEvents material As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents concepto As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents lblApp As Label
    Friend WithEvents lblApm As Label
    Friend WithEvents txtApp As TextBox
    Friend WithEvents txtApm As TextBox
End Class
