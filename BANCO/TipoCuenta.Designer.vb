<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TipoCuenta
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
        Me.txtTipoCuentaa = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtIdTipoCuenta = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTipoCuenta = New System.Windows.Forms.TextBox()
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
        Me.DataGridView1.Size = New System.Drawing.Size(712, 213)
        Me.DataGridView1.TabIndex = 0
        '
        'txtTipoCuentaa
        '
        Me.txtTipoCuentaa.Location = New System.Drawing.Point(431, 290)
        Me.txtTipoCuentaa.Name = "txtTipoCuentaa"
        Me.txtTipoCuentaa.Size = New System.Drawing.Size(149, 22)
        Me.txtTipoCuentaa.TabIndex = 79
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(316, 295)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 17)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "Tipo Cuenta:"
        '
        'txtIdTipoCuenta
        '
        Me.txtIdTipoCuenta.Location = New System.Drawing.Point(131, 293)
        Me.txtIdTipoCuenta.Name = "txtIdTipoCuenta"
        Me.txtIdTipoCuenta.Size = New System.Drawing.Size(149, 22)
        Me.txtIdTipoCuenta.TabIndex = 75
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 296)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 17)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "ID Tipo Cuenta:"
        '
        'txtTipoCuenta
        '
        Me.txtTipoCuenta.Location = New System.Drawing.Point(131, 330)
        Me.txtTipoCuenta.Name = "txtTipoCuenta"
        Me.txtTipoCuenta.Size = New System.Drawing.Size(149, 22)
        Me.txtTipoCuenta.TabIndex = 71
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 333)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Tipo Cuenta:"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(612, 247)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(107, 38)
        Me.BtnEliminar.TabIndex = 67
        Me.BtnEliminar.Text = "ELIMINAR"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(313, 247)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(113, 38)
        Me.BtnActualizar.TabIndex = 66
        Me.BtnActualizar.Text = "ACTUALIZAR "
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(22, 247)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(107, 38)
        Me.BtnAgregar.TabIndex = 65
        Me.BtnAgregar.Text = "AGREGAR"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'TipoCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 365)
        Me.Controls.Add(Me.txtTipoCuentaa)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtIdTipoCuenta)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtTipoCuenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "TipoCuenta"
        Me.Text = "TipoCuenta"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtTipoCuentaa As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtIdTipoCuenta As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTipoCuenta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnAgregar As Button
End Class
