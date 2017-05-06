<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsDiscapacidades
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
        Me.dgDiscapacidades = New System.Windows.Forms.DataGridView()
        Me.idDiscapacidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgDiscapacidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(310, 234)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(149, 39)
        Me.cmdSalir.TabIndex = 3
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'dgDiscapacidades
        '
        Me.dgDiscapacidades.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgDiscapacidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDiscapacidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idDiscapacidad, Me.nombre})
        Me.dgDiscapacidades.Location = New System.Drawing.Point(16, 31)
        Me.dgDiscapacidades.Name = "dgDiscapacidades"
        Me.dgDiscapacidades.ReadOnly = True
        Me.dgDiscapacidades.RowHeadersVisible = False
        Me.dgDiscapacidades.Size = New System.Drawing.Size(443, 197)
        Me.dgDiscapacidades.TabIndex = 2
        '
        'idDiscapacidad
        '
        Me.idDiscapacidad.HeaderText = "IdDiscapacidad"
        Me.idDiscapacidad.Name = "idDiscapacidad"
        Me.idDiscapacidad.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 300
        '
        'frmConsDiscapacidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 285)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.dgDiscapacidades)
        Me.Name = "frmConsDiscapacidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA POR DISCAPACIDADES"
        CType(Me.dgDiscapacidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdSalir As Button
    Friend WithEvents dgDiscapacidades As DataGridView
    Friend WithEvents idDiscapacidad As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
End Class
