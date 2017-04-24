<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagos
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.txtIdPago = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTutor = New System.Windows.Forms.MaskedTextBox()
        Me.txtGrupo = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAño = New System.Windows.Forms.MaskedTextBox()
        Me.txtMatricula = New System.Windows.Forms.MaskedTextBox()
        Me.txtApm = New System.Windows.Forms.MaskedTextBox()
        Me.txtApp = New System.Windows.Forms.MaskedTextBox()
        Me.cboNombre = New System.Windows.Forms.ComboBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.txtImporte = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(762, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IdPago:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Matrícula:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(440, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Año:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tutor:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(619, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Fecha:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(442, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Concepto:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(706, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Importe:"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevo.Location = New System.Drawing.Point(21, 258)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(149, 46)
        Me.cmdNuevo.TabIndex = 9
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGrabar.Location = New System.Drawing.Point(391, 258)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(149, 46)
        Me.cmdGrabar.TabIndex = 10
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(761, 259)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(149, 46)
        Me.cmdSalir.TabIndex = 11
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'txtIdPago
        '
        Me.txtIdPago.Location = New System.Drawing.Point(820, 13)
        Me.txtIdPago.Name = "txtIdPago"
        Me.txtIdPago.Size = New System.Drawing.Size(90, 20)
        Me.txtIdPago.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(378, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Apellido Paterno:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(628, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Apellido Materno:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(673, 42)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(237, 20)
        Me.dtpFecha.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTutor)
        Me.GroupBox1.Controls.Add(Me.txtGrupo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtAño)
        Me.GroupBox1.Controls.Add(Me.txtMatricula)
        Me.GroupBox1.Controls.Add(Me.txtApm)
        Me.GroupBox1.Controls.Add(Me.txtApp)
        Me.GroupBox1.Controls.Add(Me.cboNombre)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(890, 127)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'txtTutor
        '
        Me.txtTutor.Location = New System.Drawing.Point(75, 89)
        Me.txtTutor.Name = "txtTutor"
        Me.txtTutor.Size = New System.Drawing.Size(553, 20)
        Me.txtTutor.TabIndex = 23
        '
        'txtGrupo
        '
        Me.txtGrupo.Location = New System.Drawing.Point(283, 58)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(94, 20)
        Me.txtGrupo.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(222, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Grupo:"
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(481, 58)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(147, 20)
        Me.txtAño.TabIndex = 20
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(75, 58)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(139, 20)
        Me.txtMatricula.TabIndex = 19
        '
        'txtApm
        '
        Me.txtApm.Location = New System.Drawing.Point(738, 27)
        Me.txtApm.Name = "txtApm"
        Me.txtApm.Size = New System.Drawing.Size(147, 20)
        Me.txtApm.TabIndex = 17
        '
        'txtApp
        '
        Me.txtApp.Location = New System.Drawing.Point(481, 27)
        Me.txtApp.Name = "txtApp"
        Me.txtApp.Size = New System.Drawing.Size(147, 20)
        Me.txtApp.TabIndex = 16
        '
        'cboNombre
        '
        Me.cboNombre.FormattingEnabled = True
        Me.cboNombre.Location = New System.Drawing.Point(75, 25)
        Me.cboNombre.Name = "cboNombre"
        Me.cboNombre.Size = New System.Drawing.Size(303, 21)
        Me.cboNombre.TabIndex = 15
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(530, 65)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(380, 20)
        Me.MaskedTextBox2.TabIndex = 17
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(759, 229)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(147, 20)
        Me.txtImporte.TabIndex = 24
        '
        'frmPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 317)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtIdPago)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAGOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents cmdGrabar As Button
    Friend WithEvents cmdSalir As Button
    Friend WithEvents txtIdPago As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents txtApm As MaskedTextBox
    Friend WithEvents txtApp As MaskedTextBox
    Friend WithEvents cboNombre As ComboBox
    Friend WithEvents txtTutor As MaskedTextBox
    Friend WithEvents txtGrupo As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAño As MaskedTextBox
    Friend WithEvents txtMatricula As MaskedTextBox
    Friend WithEvents txtImporte As MaskedTextBox
End Class
