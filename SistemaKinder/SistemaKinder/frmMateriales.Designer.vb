<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMateriales
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.gbMaterial = New System.Windows.Forms.GroupBox()
        Me.cboUnidad = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtCosto = New System.Windows.Forms.MaskedTextBox()
        Me.txtMinimo = New System.Windows.Forms.MaskedTextBox()
        Me.txtMaximo = New System.Windows.Forms.MaskedTextBox()
        Me.txtExistencias = New System.Windows.Forms.MaskedTextBox()
        Me.txtDescripcion = New System.Windows.Forms.MaskedTextBox()
        Me.txtIdMaterial = New System.Windows.Forms.MaskedTextBox()
        Me.gbMaterial.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(473, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IdMaterial:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-1, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Existencias:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Máximo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mínimo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(341, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(341, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Costo:"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevo.Location = New System.Drawing.Point(17, 193)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(138, 56)
        Me.cmdNuevo.TabIndex = 8
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Enabled = False
        Me.cmdGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Location = New System.Drawing.Point(244, 193)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(138, 56)
        Me.cmdGuardar.TabIndex = 9
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(471, 193)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(138, 56)
        Me.cmdSalir.TabIndex = 10
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'gbMaterial
        '
        Me.gbMaterial.Controls.Add(Me.cboUnidad)
        Me.gbMaterial.Controls.Add(Me.Label8)
        Me.gbMaterial.Controls.Add(Me.dtpFecha)
        Me.gbMaterial.Controls.Add(Me.txtCosto)
        Me.gbMaterial.Controls.Add(Me.txtMinimo)
        Me.gbMaterial.Controls.Add(Me.txtMaximo)
        Me.gbMaterial.Controls.Add(Me.txtExistencias)
        Me.gbMaterial.Controls.Add(Me.txtDescripcion)
        Me.gbMaterial.Controls.Add(Me.Label7)
        Me.gbMaterial.Controls.Add(Me.Label6)
        Me.gbMaterial.Controls.Add(Me.Label5)
        Me.gbMaterial.Controls.Add(Me.Label4)
        Me.gbMaterial.Controls.Add(Me.Label3)
        Me.gbMaterial.Controls.Add(Me.Label2)
        Me.gbMaterial.Enabled = False
        Me.gbMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMaterial.Location = New System.Drawing.Point(17, 39)
        Me.gbMaterial.Name = "gbMaterial"
        Me.gbMaterial.Size = New System.Drawing.Size(593, 148)
        Me.gbMaterial.TabIndex = 11
        Me.gbMaterial.TabStop = False
        Me.gbMaterial.Text = "Registro de Materiales"
        '
        'cboUnidad
        '
        Me.cboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidad.FormattingEnabled = True
        Me.cboUnidad.Items.AddRange(New Object() {"Piezas", "Kgs", "Lts", "Mts"})
        Me.cboUnidad.Location = New System.Drawing.Point(387, 51)
        Me.cboUnidad.Name = "cboUnidad"
        Me.cboUnidad.Size = New System.Drawing.Size(197, 21)
        Me.cboUnidad.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(273, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Unidad de Medida:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(387, 22)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 18
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(387, 82)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(79, 20)
        Me.txtCosto.TabIndex = 17
        '
        'txtMinimo
        '
        Me.txtMinimo.Location = New System.Drawing.Point(78, 113)
        Me.txtMinimo.Name = "txtMinimo"
        Me.txtMinimo.Size = New System.Drawing.Size(79, 20)
        Me.txtMinimo.TabIndex = 16
        '
        'txtMaximo
        '
        Me.txtMaximo.Location = New System.Drawing.Point(78, 82)
        Me.txtMaximo.Name = "txtMaximo"
        Me.txtMaximo.Size = New System.Drawing.Size(79, 20)
        Me.txtMaximo.TabIndex = 15
        '
        'txtExistencias
        '
        Me.txtExistencias.Location = New System.Drawing.Point(78, 50)
        Me.txtExistencias.Name = "txtExistencias"
        Me.txtExistencias.Size = New System.Drawing.Size(79, 20)
        Me.txtExistencias.TabIndex = 14
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(78, 19)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(260, 20)
        Me.txtDescripcion.TabIndex = 13
        '
        'txtIdMaterial
        '
        Me.txtIdMaterial.Enabled = False
        Me.txtIdMaterial.Location = New System.Drawing.Point(537, 13)
        Me.txtIdMaterial.Name = "txtIdMaterial"
        Me.txtIdMaterial.Size = New System.Drawing.Size(73, 20)
        Me.txtIdMaterial.TabIndex = 12
        '
        'frmMateriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 261)
        Me.Controls.Add(Me.txtIdMaterial)
        Me.Controls.Add(Me.gbMaterial)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmMateriales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MATERIALES"
        Me.gbMaterial.ResumeLayout(False)
        Me.gbMaterial.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents cmdGuardar As Button
    Friend WithEvents cmdSalir As Button
    Friend WithEvents gbMaterial As GroupBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtCosto As MaskedTextBox
    Friend WithEvents txtMinimo As MaskedTextBox
    Friend WithEvents txtMaximo As MaskedTextBox
    Friend WithEvents txtExistencias As MaskedTextBox
    Friend WithEvents txtDescripcion As MaskedTextBox
    Friend WithEvents txtIdMaterial As MaskedTextBox
    Friend WithEvents cboUnidad As ComboBox
    Friend WithEvents Label8 As Label
End Class
