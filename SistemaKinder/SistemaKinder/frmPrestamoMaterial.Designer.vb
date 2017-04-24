<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrestamoMaterial
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MaskedTextBox11 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox10 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox9 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox8 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox7 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox6 = New System.Windows.Forms.MaskedTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboMaterial = New System.Windows.Forms.ComboBox()
        Me.txtCantidad = New System.Windows.Forms.MaskedTextBox()
        Me.cboEmpleado = New System.Windows.Forms.ComboBox()
        Me.txtConcepto = New System.Windows.Forms.MaskedTextBox()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.txtSalida = New System.Windows.Forms.MaskedTextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MaskedTextBox5 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(799, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Salida:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(674, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Empleado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Material:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(433, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Concepto:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(694, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Cantidad:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox11)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox10)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox9)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox8)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox7)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox6)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cboMaterial)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 195)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(947, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro"
        '
        'MaskedTextBox11
        '
        Me.MaskedTextBox11.Location = New System.Drawing.Point(584, 58)
        Me.MaskedTextBox11.Name = "MaskedTextBox11"
        Me.MaskedTextBox11.Size = New System.Drawing.Size(90, 20)
        Me.MaskedTextBox11.TabIndex = 22
        '
        'MaskedTextBox10
        '
        Me.MaskedTextBox10.Location = New System.Drawing.Point(440, 58)
        Me.MaskedTextBox10.Name = "MaskedTextBox10"
        Me.MaskedTextBox10.Size = New System.Drawing.Size(90, 20)
        Me.MaskedTextBox10.TabIndex = 21
        '
        'MaskedTextBox9
        '
        Me.MaskedTextBox9.Location = New System.Drawing.Point(246, 58)
        Me.MaskedTextBox9.Name = "MaskedTextBox9"
        Me.MaskedTextBox9.Size = New System.Drawing.Size(90, 20)
        Me.MaskedTextBox9.TabIndex = 20
        '
        'MaskedTextBox8
        '
        Me.MaskedTextBox8.Location = New System.Drawing.Point(76, 58)
        Me.MaskedTextBox8.Name = "MaskedTextBox8"
        Me.MaskedTextBox8.Size = New System.Drawing.Size(90, 20)
        Me.MaskedTextBox8.TabIndex = 19
        '
        'MaskedTextBox7
        '
        Me.MaskedTextBox7.Location = New System.Drawing.Point(766, 27)
        Me.MaskedTextBox7.Name = "MaskedTextBox7"
        Me.MaskedTextBox7.Size = New System.Drawing.Size(173, 20)
        Me.MaskedTextBox7.TabIndex = 18
        '
        'MaskedTextBox6
        '
        Me.MaskedTextBox6.Location = New System.Drawing.Point(539, 26)
        Me.MaskedTextBox6.Name = "MaskedTextBox6"
        Me.MaskedTextBox6.Size = New System.Drawing.Size(90, 20)
        Me.MaskedTextBox6.TabIndex = 17
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(538, 61)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 13)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Costo:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(637, 30)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(114, 13)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Unidad de Medida:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(345, 61)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 13)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Existencias:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(178, 61)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Mínimo:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(184, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 13)
        Me.Label14.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Máximo:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(457, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "IdMaterial: "
        '
        'cboMaterial
        '
        Me.cboMaterial.FormattingEnabled = True
        Me.cboMaterial.Location = New System.Drawing.Point(79, 22)
        Me.cboMaterial.Name = "cboMaterial"
        Me.cboMaterial.Size = New System.Drawing.Size(346, 21)
        Me.cboMaterial.TabIndex = 9
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(766, 58)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(173, 20)
        Me.txtCantidad.TabIndex = 7
        '
        'cboEmpleado
        '
        Me.cboEmpleado.FormattingEnabled = True
        Me.cboEmpleado.Location = New System.Drawing.Point(79, 23)
        Me.cboEmpleado.Name = "cboEmpleado"
        Me.cboEmpleado.Size = New System.Drawing.Size(346, 21)
        Me.cboEmpleado.TabIndex = 8
        '
        'txtConcepto
        '
        Me.txtConcepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConcepto.Location = New System.Drawing.Point(505, 73)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(463, 20)
        Me.txtConcepto.TabIndex = 6
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevo.Location = New System.Drawing.Point(21, 312)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(239, 49)
        Me.cmdNuevo.TabIndex = 7
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Location = New System.Drawing.Point(370, 312)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(250, 49)
        Me.cmdGuardar.TabIndex = 8
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(735, 312)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(230, 49)
        Me.cmdSalir.TabIndex = 9
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'txtSalida
        '
        Me.txtSalida.Location = New System.Drawing.Point(862, 20)
        Me.txtSalida.Name = "txtSalida"
        Me.txtSalida.Size = New System.Drawing.Size(105, 20)
        Me.txtSalida.TabIndex = 8
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(735, 47)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(233, 20)
        Me.dtpFecha.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Apellido Paterno:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Apellido Materno:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(545, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "IdEmpleado:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(545, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Puesto:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(545, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Teléfono:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MaskedTextBox5)
        Me.GroupBox2.Controls.Add(Me.MaskedTextBox4)
        Me.GroupBox2.Controls.Add(Me.MaskedTextBox3)
        Me.GroupBox2.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox2.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cboEmpleado)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(21, 95)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(947, 94)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Empleado"
        '
        'MaskedTextBox5
        '
        Me.MaskedTextBox5.Location = New System.Drawing.Point(629, 68)
        Me.MaskedTextBox5.Name = "MaskedTextBox5"
        Me.MaskedTextBox5.Size = New System.Drawing.Size(310, 20)
        Me.MaskedTextBox5.TabIndex = 19
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.Location = New System.Drawing.Point(629, 45)
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(310, 20)
        Me.MaskedTextBox4.TabIndex = 18
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.Location = New System.Drawing.Point(629, 19)
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(123, 20)
        Me.MaskedTextBox3.TabIndex = 17
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(115, 69)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(310, 20)
        Me.MaskedTextBox2.TabIndex = 16
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(115, 47)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(310, 20)
        Me.MaskedTextBox1.TabIndex = 15
        '
        'frmPrestamoMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 385)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtSalida)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmPrestamoMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRÉSTAMO DE MATERIAL"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCantidad As MaskedTextBox
    Friend WithEvents txtConcepto As MaskedTextBox
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents cmdGuardar As Button
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cboMaterial As ComboBox
    Friend WithEvents cboEmpleado As ComboBox
    Friend WithEvents txtSalida As MaskedTextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MaskedTextBox5 As MaskedTextBox
    Friend WithEvents MaskedTextBox4 As MaskedTextBox
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents MaskedTextBox11 As MaskedTextBox
    Friend WithEvents MaskedTextBox10 As MaskedTextBox
    Friend WithEvents MaskedTextBox9 As MaskedTextBox
    Friend WithEvents MaskedTextBox8 As MaskedTextBox
    Friend WithEvents MaskedTextBox7 As MaskedTextBox
    Friend WithEvents MaskedTextBox6 As MaskedTextBox
    Friend WithEvents Label18 As Label
End Class
