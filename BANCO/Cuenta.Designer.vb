<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cuenta
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
        Me.txtIdTipoCuentaa = New System.Windows.Forms.TextBox()
        Me.txtIdClientee = New System.Windows.Forms.TextBox()
        Me.txtFechaa = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtIdCuenta = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtIdTipoCuenta = New System.Windows.Forms.TextBox()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.DataGridView1.Size = New System.Drawing.Size(702, 351)
        Me.DataGridView1.TabIndex = 0
        '
        'txtIdTipoCuentaa
        '
        Me.txtIdTipoCuentaa.Location = New System.Drawing.Point(437, 507)
        Me.txtIdTipoCuentaa.Name = "txtIdTipoCuentaa"
        Me.txtIdTipoCuentaa.Size = New System.Drawing.Size(149, 22)
        Me.txtIdTipoCuentaa.TabIndex = 64
        '
        'txtIdClientee
        '
        Me.txtIdClientee.Location = New System.Drawing.Point(437, 469)
        Me.txtIdClientee.Name = "txtIdClientee"
        Me.txtIdClientee.Size = New System.Drawing.Size(149, 22)
        Me.txtIdClientee.TabIndex = 63
        '
        'txtFechaa
        '
        Me.txtFechaa.Location = New System.Drawing.Point(437, 431)
        Me.txtFechaa.Name = "txtFechaa"
        Me.txtFechaa.Size = New System.Drawing.Size(149, 22)
        Me.txtFechaa.TabIndex = 62
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(322, 512)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 17)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Id tipo cuenta:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(322, 474)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 17)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Id Cliente"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(322, 436)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 17)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Fecha apertura:"
        '
        'txtIdCuenta
        '
        Me.txtIdCuenta.Location = New System.Drawing.Point(137, 434)
        Me.txtIdCuenta.Name = "txtIdCuenta"
        Me.txtIdCuenta.Size = New System.Drawing.Size(149, 22)
        Me.txtIdCuenta.TabIndex = 56
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 437)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 17)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "ID Cuenta:"
        '
        'txtIdTipoCuenta
        '
        Me.txtIdTipoCuenta.Location = New System.Drawing.Point(137, 547)
        Me.txtIdTipoCuenta.Name = "txtIdTipoCuenta"
        Me.txtIdTipoCuenta.Size = New System.Drawing.Size(149, 22)
        Me.txtIdTipoCuenta.TabIndex = 52
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(137, 509)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(149, 22)
        Me.txtIdCliente.TabIndex = 51
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(137, 471)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(149, 22)
        Me.txtFecha.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 550)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Id tipo cuenta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 512)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Id Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 474)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Fecha apertura:"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(607, 388)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(107, 38)
        Me.BtnEliminar.TabIndex = 44
        Me.BtnEliminar.Text = "ELIMINAR"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(319, 388)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(113, 38)
        Me.BtnActualizar.TabIndex = 43
        Me.BtnActualizar.Text = "ACTUALIZAR "
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(28, 388)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(107, 38)
        Me.BtnAgregar.TabIndex = 42
        Me.BtnAgregar.Text = "AGREGAR"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'Cuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 605)
        Me.Controls.Add(Me.txtIdTipoCuentaa)
        Me.Controls.Add(Me.txtIdClientee)
        Me.Controls.Add(Me.txtFechaa)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtIdCuenta)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtIdTipoCuenta)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Cuenta"
        Me.Text = "Cuenta"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtIdTipoCuentaa As TextBox
    Friend WithEvents txtIdClientee As TextBox
    Friend WithEvents txtFechaa As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtIdCuenta As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtIdTipoCuenta As TextBox
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnAgregar As Button
End Class
