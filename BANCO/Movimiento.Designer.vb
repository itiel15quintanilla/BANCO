<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Movimiento
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
        Me.txtIdTipoMovv = New System.Windows.Forms.TextBox()
        Me.txtImportee = New System.Windows.Forms.TextBox()
        Me.txtFechaa = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtIdMov = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtIdTipoMov = New System.Windows.Forms.TextBox()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.txtIdCuenta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtIdCuentaa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(694, 271)
        Me.DataGridView1.TabIndex = 0
        '
        'txtIdTipoMovv
        '
        Me.txtIdTipoMovv.Location = New System.Drawing.Point(445, 436)
        Me.txtIdTipoMovv.Name = "txtIdTipoMovv"
        Me.txtIdTipoMovv.Size = New System.Drawing.Size(149, 22)
        Me.txtIdTipoMovv.TabIndex = 81
        '
        'txtImportee
        '
        Me.txtImportee.Location = New System.Drawing.Point(445, 398)
        Me.txtImportee.Name = "txtImportee"
        Me.txtImportee.Size = New System.Drawing.Size(149, 22)
        Me.txtImportee.TabIndex = 80
        '
        'txtFechaa
        '
        Me.txtFechaa.Location = New System.Drawing.Point(445, 360)
        Me.txtFechaa.Name = "txtFechaa"
        Me.txtFechaa.Size = New System.Drawing.Size(149, 22)
        Me.txtFechaa.TabIndex = 79
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(314, 439)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 17)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Id tipo movimiento:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(314, 401)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 17)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Importe movimiento:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(314, 363)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 17)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "Fecha movimiento:"
        '
        'txtIdMov
        '
        Me.txtIdMov.Location = New System.Drawing.Point(148, 361)
        Me.txtIdMov.Name = "txtIdMov"
        Me.txtIdMov.Size = New System.Drawing.Size(149, 22)
        Me.txtIdMov.TabIndex = 75
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 364)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 17)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "ID Movimiento:"
        '
        'txtIdTipoMov
        '
        Me.txtIdTipoMov.Location = New System.Drawing.Point(148, 474)
        Me.txtIdTipoMov.Name = "txtIdTipoMov"
        Me.txtIdTipoMov.Size = New System.Drawing.Size(149, 22)
        Me.txtIdTipoMov.TabIndex = 73
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(148, 436)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(149, 22)
        Me.txtImporte.TabIndex = 72
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(148, 398)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(149, 22)
        Me.txtFecha.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 477)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 17)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Id tipo movimiento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 439)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 17)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Importe movimiento:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 401)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 17)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Fecha movimiento:"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(599, 315)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(107, 38)
        Me.BtnEliminar.TabIndex = 67
        Me.BtnEliminar.Text = "ELIMINAR"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(311, 315)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(113, 38)
        Me.BtnActualizar.TabIndex = 66
        Me.BtnActualizar.Text = "ACTUALIZAR "
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(20, 315)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(107, 38)
        Me.BtnAgregar.TabIndex = 65
        Me.BtnAgregar.Text = "AGREGAR"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'txtIdCuenta
        '
        Me.txtIdCuenta.Location = New System.Drawing.Point(148, 511)
        Me.txtIdCuenta.Name = "txtIdCuenta"
        Me.txtIdCuenta.Size = New System.Drawing.Size(149, 22)
        Me.txtIdCuenta.TabIndex = 83
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 514)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Id Cuenta:"
        '
        'TxtIdCuentaa
        '
        Me.TxtIdCuentaa.Location = New System.Drawing.Point(445, 472)
        Me.TxtIdCuentaa.Name = "TxtIdCuentaa"
        Me.TxtIdCuentaa.Size = New System.Drawing.Size(149, 22)
        Me.TxtIdCuentaa.TabIndex = 85
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(315, 475)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 17)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Id Cuenta:"
        '
        'Movimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 562)
        Me.Controls.Add(Me.TxtIdCuentaa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtIdCuenta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtIdTipoMovv)
        Me.Controls.Add(Me.txtImportee)
        Me.Controls.Add(Me.txtFechaa)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtIdMov)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtIdTipoMov)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Movimiento"
        Me.Text = "Movimiento"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtIdTipoMovv As TextBox
    Friend WithEvents txtImportee As TextBox
    Friend WithEvents txtFechaa As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtIdMov As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtIdTipoMov As TextBox
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents txtIdCuenta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtIdCuentaa As TextBox
    Friend WithEvents Label5 As Label
End Class
