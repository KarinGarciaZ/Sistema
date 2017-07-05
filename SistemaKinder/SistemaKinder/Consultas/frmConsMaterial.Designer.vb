<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsMaterial
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
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.dgMateriales = New System.Windows.Forms.DataGridView()
        Me.idMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaUltima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.existencias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.maximo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.minimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unidadMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(612, 236)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(149, 39)
        Me.cmdSalir.TabIndex = 3
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'dgMateriales
        '
        Me.dgMateriales.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMateriales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idMaterial, Me.descripcion, Me.fechaUltima, Me.existencias, Me.maximo, Me.minimo, Me.costo, Me.unidadMedida})
        Me.dgMateriales.Location = New System.Drawing.Point(10, 33)
        Me.dgMateriales.Name = "dgMateriales"
        Me.dgMateriales.ReadOnly = True
        Me.dgMateriales.RowHeadersVisible = False
        Me.dgMateriales.Size = New System.Drawing.Size(751, 197)
        Me.dgMateriales.TabIndex = 2
        '
        'idMaterial
        '
        Me.idMaterial.HeaderText = "IdMaterial"
        Me.idMaterial.Name = "idMaterial"
        Me.idMaterial.ReadOnly = True
        Me.idMaterial.Width = 70
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 250
        '
        'fechaUltima
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.fechaUltima.DefaultCellStyle = DataGridViewCellStyle1
        Me.fechaUltima.HeaderText = "Última Fecha Compra"
        Me.fechaUltima.Name = "fechaUltima"
        Me.fechaUltima.ReadOnly = True
        '
        'existencias
        '
        Me.existencias.HeaderText = "Existencias"
        Me.existencias.Name = "existencias"
        Me.existencias.ReadOnly = True
        Me.existencias.Width = 70
        '
        'maximo
        '
        Me.maximo.HeaderText = "Máximo"
        Me.maximo.Name = "maximo"
        Me.maximo.ReadOnly = True
        Me.maximo.Width = 50
        '
        'minimo
        '
        Me.minimo.HeaderText = "Mínimo"
        Me.minimo.Name = "minimo"
        Me.minimo.ReadOnly = True
        Me.minimo.Width = 50
        '
        'costo
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.costo.DefaultCellStyle = DataGridViewCellStyle2
        Me.costo.HeaderText = "Costo"
        Me.costo.Name = "costo"
        Me.costo.ReadOnly = True
        Me.costo.Width = 50
        '
        'unidadMedida
        '
        Me.unidadMedida.HeaderText = "Unidad de Medida"
        Me.unidadMedida.Name = "unidadMedida"
        Me.unidadMedida.ReadOnly = True
        '
        'frmConsMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(774, 288)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.dgMateriales)
        Me.Name = "frmConsMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA DE MATERIALES"
        CType(Me.dgMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdSalir As Button
    Friend WithEvents dgMateriales As DataGridView
    Friend WithEvents idMaterial As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents fechaUltima As DataGridViewTextBoxColumn
    Friend WithEvents existencias As DataGridViewTextBoxColumn
    Friend WithEvents maximo As DataGridViewTextBoxColumn
    Friend WithEvents minimo As DataGridViewTextBoxColumn
    Friend WithEvents costo As DataGridViewTextBoxColumn
    Friend WithEvents unidadMedida As DataGridViewTextBoxColumn
End Class
