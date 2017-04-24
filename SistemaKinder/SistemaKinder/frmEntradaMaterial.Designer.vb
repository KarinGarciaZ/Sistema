<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntradaMaterial
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
        Me.txtIdEntrada = New System.Windows.Forms.MaskedTextBox()
        Me.txtSubtotal = New System.Windows.Forms.MaskedTextBox()
        Me.txtIVA = New System.Windows.Forms.MaskedTextBox()
        Me.txtTotal = New System.Windows.Forms.MaskedTextBox()
        Me.txtProveedor = New System.Windows.Forms.MaskedTextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(402, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IdEntrada:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(272, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Proveedor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(344, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Subtotal:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(370, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "IVA:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(362, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total:"
        '
        'txtIdEntrada
        '
        Me.txtIdEntrada.Location = New System.Drawing.Point(475, 15)
        Me.txtIdEntrada.Name = "txtIdEntrada"
        Me.txtIdEntrada.Size = New System.Drawing.Size(83, 20)
        Me.txtIdEntrada.TabIndex = 6
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(408, 117)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(150, 20)
        Me.txtSubtotal.TabIndex = 7
        '
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(408, 143)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(150, 20)
        Me.txtIVA.TabIndex = 8
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(408, 168)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(150, 20)
        Me.txtTotal.TabIndex = 9
        '
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(103, 91)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(455, 20)
        Me.txtProveedor.TabIndex = 10
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(325, 41)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(233, 20)
        Me.dtpFecha.TabIndex = 11
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevo.Location = New System.Drawing.Point(30, 194)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(131, 40)
        Me.cmdNuevo.TabIndex = 12
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGrabar.Location = New System.Drawing.Point(229, 194)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(131, 40)
        Me.cmdGrabar.TabIndex = 13
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(427, 194)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(131, 40)
        Me.cmdSalir.TabIndex = 14
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'frmEntradaMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 246)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtIVA)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.txtIdEntrada)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmEntradaMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ENTRADA DE MATERIAL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtIdEntrada As MaskedTextBox
    Friend WithEvents txtSubtotal As MaskedTextBox
    Friend WithEvents txtIVA As MaskedTextBox
    Friend WithEvents txtTotal As MaskedTextBox
    Friend WithEvents txtProveedor As MaskedTextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents cmdGrabar As Button
    Friend WithEvents cmdSalir As Button
End Class
