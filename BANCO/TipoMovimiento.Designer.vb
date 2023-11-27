<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TipoMovimiento
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtTipoMovv = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtIdTipoMov = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTipoMov = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(699, 271)
        Me.DataGridView1.TabIndex = 0
        '
        'txtTipoMovv
        '
        Me.txtTipoMovv.Location = New System.Drawing.Point(423, 352)
        Me.txtTipoMovv.Name = "txtTipoMovv"
        Me.txtTipoMovv.Size = New System.Drawing.Size(149, 22)
        Me.txtTipoMovv.TabIndex = 88
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(308, 357)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 17)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "Tipo Movimiento:"
        '
        'txtIdTipoMov
        '
        Me.txtIdTipoMov.Location = New System.Drawing.Point(143, 355)
        Me.txtIdTipoMov.Name = "txtIdTipoMov"
        Me.txtIdTipoMov.Size = New System.Drawing.Size(149, 22)
        Me.txtIdTipoMov.TabIndex = 86
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 358)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 17)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "ID Tipo Movimiento:"
        '
        'txtTipoMov
        '
        Me.txtTipoMov.Location = New System.Drawing.Point(143, 392)
        Me.txtTipoMov.Name = "txtTipoMov"
        Me.txtTipoMov.Size = New System.Drawing.Size(149, 22)
        Me.txtTipoMov.TabIndex = 84
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 395)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Tipo Movimiento:"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(604, 309)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(107, 38)
        Me.BtnEliminar.TabIndex = 82
        Me.BtnEliminar.Text = "ELIMINAR"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(305, 309)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(113, 38)
        Me.BtnActualizar.TabIndex = 81
        Me.BtnActualizar.Text = "ACTUALIZAR "
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(14, 309)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(107, 38)
        Me.BtnAgregar.TabIndex = 80
        Me.BtnAgregar.Text = "AGREGAR"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'TipoMovimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 431)
        Me.Controls.Add(Me.txtTipoMovv)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtIdTipoMov)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtTipoMov)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "TipoMovimiento"
        Me.Text = "TipoMovimiento"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtTipoMovv As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtIdTipoMov As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTipoMov As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnAgregar As Button
End Class
