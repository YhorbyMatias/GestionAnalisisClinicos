<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusPac
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusPac))
        Me.btnLimpiar = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtNAtentido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cbbcasos = New System.Windows.Forms.ComboBox()
        Me.lblUsoArticulo = New System.Windows.Forms.Label()
        Me.lblCodArticulo = New System.Windows.Forms.Label()
        Me.grbFiltrar = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaIng = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lblPresentacion = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblCo = New System.Windows.Forms.Label()
        CType(Me.btnLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbFiltrar.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLimpiar
        '
        Me.btnLimpiar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.btnLimpiar.Location = New System.Drawing.Point(78, 186)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(912, 196)
        Me.btnLimpiar.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(677, 28)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(677, 110)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(677, 81)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtNAtentido
        '
        Me.txtNAtentido.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNAtentido.Location = New System.Drawing.Point(114, 96)
        Me.txtNAtentido.Name = "txtNAtentido"
        Me.txtNAtentido.Size = New System.Drawing.Size(201, 22)
        Me.txtNAtentido.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(114, 17)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(231, 22)
        Me.txtNombre.TabIndex = 5
        '
        'cbbcasos
        '
        Me.cbbcasos.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbcasos.FormattingEnabled = True
        Me.cbbcasos.Items.AddRange(New Object() {"Emergencia", "Normal"})
        Me.cbbcasos.Location = New System.Drawing.Point(114, 69)
        Me.cbbcasos.Name = "cbbcasos"
        Me.cbbcasos.Size = New System.Drawing.Size(151, 22)
        Me.cbbcasos.TabIndex = 4
        '
        'lblUsoArticulo
        '
        Me.lblUsoArticulo.AutoSize = True
        Me.lblUsoArticulo.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsoArticulo.Location = New System.Drawing.Point(36, 103)
        Me.lblUsoArticulo.Name = "lblUsoArticulo"
        Me.lblUsoArticulo.Size = New System.Drawing.Size(57, 14)
        Me.lblUsoArticulo.TabIndex = 3
        Me.lblUsoArticulo.Text = "Numero:"
        '
        'lblCodArticulo
        '
        Me.lblCodArticulo.AutoSize = True
        Me.lblCodArticulo.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodArticulo.Location = New System.Drawing.Point(36, 24)
        Me.lblCodArticulo.Name = "lblCodArticulo"
        Me.lblCodArticulo.Size = New System.Drawing.Size(57, 14)
        Me.lblCodArticulo.TabIndex = 2
        Me.lblCodArticulo.Text = "Nombre:"
        '
        'grbFiltrar
        '
        Me.grbFiltrar.Controls.Add(Me.Label2)
        Me.grbFiltrar.Controls.Add(Me.dtpFechaIng)
        Me.grbFiltrar.Controls.Add(Me.Label1)
        Me.grbFiltrar.Controls.Add(Me.txtApellido)
        Me.grbFiltrar.Controls.Add(Me.lblPresentacion)
        Me.grbFiltrar.Controls.Add(Me.lblCodArticulo)
        Me.grbFiltrar.Controls.Add(Me.lblUsoArticulo)
        Me.grbFiltrar.Controls.Add(Me.cbbcasos)
        Me.grbFiltrar.Controls.Add(Me.txtNAtentido)
        Me.grbFiltrar.Controls.Add(Me.txtNombre)
        Me.grbFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbFiltrar.Location = New System.Drawing.Point(78, 12)
        Me.grbFiltrar.Name = "grbFiltrar"
        Me.grbFiltrar.Size = New System.Drawing.Size(566, 147)
        Me.grbFiltrar.TabIndex = 0
        Me.grbFiltrar.TabStop = False
        Me.grbFiltrar.Text = "Consultar  por"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 14)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Fecha:"
        '
        'dtpFechaIng
        '
        Me.dtpFechaIng.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaIng.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIng.Location = New System.Drawing.Point(114, 122)
        Me.dtpFechaIng.Name = "dtpFechaIng"
        Me.dtpFechaIng.Size = New System.Drawing.Size(200, 22)
        Me.dtpFechaIng.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 14)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Apellido:"
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(114, 43)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(231, 22)
        Me.txtApellido.TabIndex = 8
        '
        'lblPresentacion
        '
        Me.lblPresentacion.AutoSize = True
        Me.lblPresentacion.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresentacion.Location = New System.Drawing.Point(50, 77)
        Me.lblPresentacion.Name = "lblPresentacion"
        Me.lblPresentacion.Size = New System.Drawing.Size(34, 14)
        Me.lblPresentacion.TabIndex = 1
        Me.lblPresentacion.Text = "caso:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(677, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblCo
        '
        Me.lblCo.AutoSize = True
        Me.lblCo.Location = New System.Drawing.Point(474, 431)
        Me.lblCo.Name = "lblCo"
        Me.lblCo.Size = New System.Drawing.Size(0, 13)
        Me.lblCo.TabIndex = 9
        '
        'frmBusPac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 475)
        Me.Controls.Add(Me.lblCo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.grbFiltrar)
        Me.Name = "frmBusPac"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Pacientes"
        CType(Me.btnLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbFiltrar.ResumeLayout(False)
        Me.grbFiltrar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLimpiar As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtNAtentido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents cbbcasos As System.Windows.Forms.ComboBox
    Friend WithEvents lblUsoArticulo As System.Windows.Forms.Label
    Friend WithEvents lblCodArticulo As System.Windows.Forms.Label
    Friend WithEvents grbFiltrar As System.Windows.Forms.GroupBox
    Friend WithEvents lblPresentacion As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaIng As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblCo As System.Windows.Forms.Label
End Class
