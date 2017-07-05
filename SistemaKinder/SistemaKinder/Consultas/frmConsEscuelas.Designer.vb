<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsEscuelas
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
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.dgEscuela = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreOficial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreConocido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.municipio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgEscuela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(618, 231)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(149, 39)
        Me.cmdSalir.TabIndex = 3
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'dgEscuela
        '
        Me.dgEscuela.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgEscuela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEscuela.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nombreOficial, Me.nombreConocido, Me.municipio})
        Me.dgEscuela.Location = New System.Drawing.Point(7, 28)
        Me.dgEscuela.Name = "dgEscuela"
        Me.dgEscuela.ReadOnly = True
        Me.dgEscuela.RowHeadersVisible = False
        Me.dgEscuela.Size = New System.Drawing.Size(760, 197)
        Me.dgEscuela.TabIndex = 2
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'nombreOficial
        '
        Me.nombreOficial.HeaderText = "Nombre Oficial"
        Me.nombreOficial.Name = "nombreOficial"
        Me.nombreOficial.ReadOnly = True
        Me.nombreOficial.Width = 250
        '
        'nombreConocido
        '
        Me.nombreConocido.HeaderText = "Nombre Conocido"
        Me.nombreConocido.Name = "nombreConocido"
        Me.nombreConocido.ReadOnly = True
        Me.nombreConocido.Width = 250
        '
        'municipio
        '
        Me.municipio.HeaderText = "Municipio"
        Me.municipio.Name = "municipio"
        Me.municipio.ReadOnly = True
        Me.municipio.Width = 150
        '
        'frmConsEscuelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(779, 282)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.dgEscuela)
        Me.Name = "frmConsEscuelas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA DE ESCUELA"
        CType(Me.dgEscuela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdSalir As Button
    Friend WithEvents dgEscuela As DataGridView
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombreOficial As DataGridViewTextBoxColumn
    Friend WithEvents nombreConocido As DataGridViewTextBoxColumn
    Friend WithEvents municipio As DataGridViewTextBoxColumn
End Class
