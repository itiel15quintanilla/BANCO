<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TipoCredito
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
        Me.txtTipoCreditoo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtIdTipoCredito = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTipoCredito = New System.Windows.Forms.TextBox()
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
        Me.DataGridView1.Location = New System.Drawing.Point(14, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(694, 285)
        Me.DataGridView1.TabIndex = 0
        '
        'txtTipoCreditoo
        '
        Me.txtTipoCreditoo.Location = New System.Drawing.Point(423, 363)
        Me.txtTipoCreditoo.Name = "txtTipoCreditoo"
        Me.txtTipoCreditoo.Size = New System.Drawing.Size(149, 22)
        Me.txtTipoCreditoo.TabIndex = 97
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(308, 368)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 17)
        Me.Label12.TabIndex = 96
        Me.Label12.Text = "Tipo Credito:"
        '
        'txtIdTipoCredito
        '
        Me.txtIdTipoCredito.Location = New System.Drawing.Point(143, 366)
        Me.txtIdTipoCredito.Name = "txtIdTipoCredito"
        Me.txtIdTipoCredito.Size = New System.Drawing.Size(149, 22)
        Me.txtIdTipoCredito.TabIndex = 95
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 369)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 17)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "ID Tipo Credito:"
        '
        'txtTipoCredito
        '
        Me.txtTipoCredito.Location = New System.Drawing.Point(143, 403)
        Me.txtTipoCredito.Name = "txtTipoCredito"
        Me.txtTipoCredito.Size = New System.Drawing.Size(149, 22)
        Me.txtTipoCredito.TabIndex = 93
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 406)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Tipo Credito:"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(604, 320)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(107, 38)
        Me.BtnEliminar.TabIndex = 91
        Me.BtnEliminar.Text = "ELIMINAR"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(305, 320)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(113, 38)
        Me.BtnActualizar.TabIndex = 90
        Me.BtnActualizar.Text = "ACTUALIZAR "
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(14, 320)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(107, 38)
        Me.BtnAgregar.TabIndex = 89
        Me.BtnAgregar.Text = "AGREGAR"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'TipoCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 439)
        Me.Controls.Add(Me.txtTipoCreditoo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtIdTipoCredito)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtTipoCredito)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "TipoCredito"
        Me.Text = "TipoCredito"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtTipoCreditoo As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtIdTipoCredito As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTipoCredito As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnAgregar As Button
End Class
