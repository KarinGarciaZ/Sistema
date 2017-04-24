<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGastos
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
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboNombre = New System.Windows.Forms.ComboBox()
        Me.txtApm = New System.Windows.Forms.MaskedTextBox()
        Me.txtApp = New System.Windows.Forms.MaskedTextBox()
        Me.txtPuesto = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail = New System.Windows.Forms.MaskedTextBox()
        Me.txtTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIdGasto = New System.Windows.Forms.MaskedTextBox()
        Me.txtConcepto = New System.Windows.Forms.MaskedTextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtImporte = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 245)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(132, 53)
        Me.cmdNuevo.TabIndex = 0
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGrabar.Location = New System.Drawing.Point(368, 245)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(132, 53)
        Me.cmdGrabar.TabIndex = 1
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(724, 245)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(132, 53)
        Me.cmdSalir.TabIndex = 2
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(677, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "IdGasto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(561, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(442, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Concepto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(679, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Importe:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboNombre)
        Me.GroupBox1.Controls.Add(Me.txtApm)
        Me.GroupBox1.Controls.Add(Me.txtApp)
        Me.GroupBox1.Controls.Add(Me.txtPuesto)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(843, 101)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información General"
        '
        'cboNombre
        '
        Me.cboNombre.FormattingEnabled = True
        Me.cboNombre.Location = New System.Drawing.Point(69, 19)
        Me.cboNombre.Name = "cboNombre"
        Me.cboNombre.Size = New System.Drawing.Size(247, 21)
        Me.cboNombre.TabIndex = 15
        '
        'txtApm
        '
        Me.txtApm.Location = New System.Drawing.Point(668, 19)
        Me.txtApm.Name = "txtApm"
        Me.txtApm.Size = New System.Drawing.Size(168, 20)
        Me.txtApm.TabIndex = 14
        '
        'txtApp
        '
        Me.txtApp.Location = New System.Drawing.Point(421, 19)
        Me.txtApp.Name = "txtApp"
        Me.txtApp.Size = New System.Drawing.Size(140, 20)
        Me.txtApp.TabIndex = 13
        '
        'txtPuesto
        '
        Me.txtPuesto.Location = New System.Drawing.Point(610, 58)
        Me.txtPuesto.Name = "txtPuesto"
        Me.txtPuesto.Size = New System.Drawing.Size(227, 20)
        Me.txtPuesto.TabIndex = 12
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(295, 58)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(266, 20)
        Me.txtEmail.TabIndex = 11
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(69, 58)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(163, 20)
        Me.txtTelefono.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(561, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Puesto:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(248, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Email:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Teléfono:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(561, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Apellido Materno:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(323, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Apellido Paterno:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nombre:"
        '
        'txtIdGasto
        '
        Me.txtIdGasto.Location = New System.Drawing.Point(741, 22)
        Me.txtIdGasto.Name = "txtIdGasto"
        Me.txtIdGasto.Size = New System.Drawing.Size(116, 20)
        Me.txtIdGasto.TabIndex = 8
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(514, 73)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(342, 20)
        Me.txtConcepto.TabIndex = 9
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(624, 47)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(233, 20)
        Me.dtpFecha.TabIndex = 10
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(739, 219)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(116, 20)
        Me.txtImporte.TabIndex = 16
        '
        'frmGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 312)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.txtIdGasto)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmGastos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GASTOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboNombre As ComboBox
    Friend WithEvents txtApm As MaskedTextBox
    Friend WithEvents txtApp As MaskedTextBox
    Friend WithEvents txtPuesto As MaskedTextBox
    Friend WithEvents txtEmail As MaskedTextBox
    Friend WithEvents txtTelefono As MaskedTextBox
    Friend WithEvents txtIdGasto As MaskedTextBox
    Friend WithEvents txtConcepto As MaskedTextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtImporte As MaskedTextBox
End Class
