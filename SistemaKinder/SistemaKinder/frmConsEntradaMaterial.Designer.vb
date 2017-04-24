<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsEntradaMaterial
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
        Me.cboEntrada = New System.Windows.Forms.ComboBox()
        Me.dgEntrada = New System.Windows.Forms.DataGridView()
        Me.proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdSalir = New System.Windows.Forms.Button()
        CType(Me.dgEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IdEntrada:"
        '
        'cboEntrada
        '
        Me.cboEntrada.FormattingEnabled = True
        Me.cboEntrada.Location = New System.Drawing.Point(99, 25)
        Me.cboEntrada.Name = "cboEntrada"
        Me.cboEntrada.Size = New System.Drawing.Size(121, 21)
        Me.cboEntrada.TabIndex = 1
        '
        'dgEntrada
        '
        Me.dgEntrada.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEntrada.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.proveedor, Me.fecha, Me.subtotal, Me.iva, Me.total})
        Me.dgEntrada.Location = New System.Drawing.Point(13, 59)
        Me.dgEntrada.Name = "dgEntrada"
        Me.dgEntrada.ReadOnly = True
        Me.dgEntrada.RowHeadersVisible = False
        Me.dgEntrada.Size = New System.Drawing.Size(710, 179)
        Me.dgEntrada.TabIndex = 2
        '
        'proveedor
        '
        Me.proveedor.HeaderText = "Proveedor"
        Me.proveedor.Name = "proveedor"
        Me.proveedor.ReadOnly = True
        Me.proveedor.Width = 300
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "Subtotal"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        '
        'iva
        '
        Me.iva.HeaderText = "IVA"
        Me.iva.Name = "iva"
        Me.iva.ReadOnly = True
        '
        'total
        '
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(606, 244)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(117, 44)
        Me.cmdSalir.TabIndex = 3
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'frmConsEntradaMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 294)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.dgEntrada)
        Me.Controls.Add(Me.cboEntrada)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmConsEntradaMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA DE ENTRADA MATERIAL"
        CType(Me.dgEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboEntrada As ComboBox
    Friend WithEvents dgEntrada As DataGridView
    Friend WithEvents proveedor As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents iva As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents cmdSalir As Button
End Class
