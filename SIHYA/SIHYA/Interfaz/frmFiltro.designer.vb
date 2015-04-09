<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFiltro
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
        Me.cbbSexo = New System.Windows.Forms.ComboBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtNRecord = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblRecord = New System.Windows.Forms.Label()
        Me.lblIndMedico = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.cbSerologia = New System.Windows.Forms.CheckBox()
        Me.cbSedimentos = New System.Windows.Forms.CheckBox()
        Me.cbQuimicaSanguinea = New System.Windows.Forms.CheckBox()
        Me.cbOrina = New System.Windows.Forms.CheckBox()
        Me.cbPEmbarazo = New System.Windows.Forms.CheckBox()
        Me.cbCropologico = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtAtendido = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.cbTodos = New System.Windows.Forms.CheckBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.dtpFechaActual = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaEnt = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbbSexo
        '
        Me.cbbSexo.FormattingEnabled = True
        Me.cbbSexo.Items.AddRange(New Object() {"Masculino", "Femenino", "Otro"})
        Me.cbbSexo.Location = New System.Drawing.Point(102, 183)
        Me.cbbSexo.Margin = New System.Windows.Forms.Padding(4)
        Me.cbbSexo.Name = "cbbSexo"
        Me.cbbSexo.Size = New System.Drawing.Size(221, 21)
        Me.cbbSexo.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(102, 29)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(397, 22)
        Me.txtNombre.TabIndex = 1
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(102, 94)
        Me.txtEdad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(182, 20)
        Me.txtEdad.TabIndex = 3
        '
        'txtNRecord
        '
        Me.txtNRecord.Location = New System.Drawing.Point(102, 122)
        Me.txtNRecord.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNRecord.Name = "txtNRecord"
        Me.txtNRecord.Size = New System.Drawing.Size(182, 20)
        Me.txtNRecord.TabIndex = 4
        Me.txtNRecord.Text = "xxxxxxxxxxxxxxxx"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(102, 155)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(221, 20)
        Me.txtTelefono.TabIndex = 5
        Me.txtTelefono.Text = "xxxxxxxxxxxxxxxxx"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(51, 186)
        Me.lblSexo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(44, 18)
        Me.lblSexo.TabIndex = 112
        Me.lblSexo.Text = "Sexo:"
        '
        'lblRecord
        '
        Me.lblRecord.AutoSize = True
        Me.lblRecord.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecord.Location = New System.Drawing.Point(11, 124)
        Me.lblRecord.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRecord.Name = "lblRecord"
        Me.lblRecord.Size = New System.Drawing.Size(87, 18)
        Me.lblRecord.TabIndex = 111
        Me.lblRecord.Text = "Record no.:"
        '
        'lblIndMedico
        '
        Me.lblIndMedico.AutoSize = True
        Me.lblIndMedico.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndMedico.Location = New System.Drawing.Point(516, 33)
        Me.lblIndMedico.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIndMedico.Name = "lblIndMedico"
        Me.lblIndMedico.Size = New System.Drawing.Size(181, 18)
        Me.lblIndMedico.TabIndex = 110
        Me.lblIndMedico.Text = "Indicaciones del Medico:"
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel.Location = New System.Drawing.Point(60, 160)
        Me.lblTel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(35, 18)
        Me.lblTel.TabIndex = 109
        Me.lblTel.Text = "Tel:"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.Location = New System.Drawing.Point(45, 94)
        Me.lblEdad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(49, 18)
        Me.lblEdad.TabIndex = 108
        Me.lblEdad.Text = "Edad:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(-148, 165)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(71, 18)
        Me.lblNombre.TabIndex = 107
        Me.lblNombre.Text = "Nombre:"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(24, 29)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(71, 18)
        Me.lblNom.TabIndex = 118
        Me.lblNom.Text = "Nombre:"
        '
        'cbSerologia
        '
        Me.cbSerologia.AutoSize = True
        Me.cbSerologia.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSerologia.Location = New System.Drawing.Point(519, 65)
        Me.cbSerologia.Name = "cbSerologia"
        Me.cbSerologia.Size = New System.Drawing.Size(79, 18)
        Me.cbSerologia.TabIndex = 10
        Me.cbSerologia.Text = "Serologia"
        Me.cbSerologia.UseVisualStyleBackColor = True
        '
        'cbSedimentos
        '
        Me.cbSedimentos.AutoSize = True
        Me.cbSedimentos.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSedimentos.Location = New System.Drawing.Point(519, 88)
        Me.cbSedimentos.Name = "cbSedimentos"
        Me.cbSedimentos.Size = New System.Drawing.Size(90, 18)
        Me.cbSedimentos.TabIndex = 11
        Me.cbSedimentos.Text = "Sedimentos"
        Me.cbSedimentos.UseVisualStyleBackColor = True
        '
        'cbQuimicaSanguinea
        '
        Me.cbQuimicaSanguinea.AutoSize = True
        Me.cbQuimicaSanguinea.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbQuimicaSanguinea.Location = New System.Drawing.Point(519, 154)
        Me.cbQuimicaSanguinea.Name = "cbQuimicaSanguinea"
        Me.cbQuimicaSanguinea.Size = New System.Drawing.Size(134, 18)
        Me.cbQuimicaSanguinea.TabIndex = 14
        Me.cbQuimicaSanguinea.Text = "Quimica Sanguinea"
        Me.cbQuimicaSanguinea.UseVisualStyleBackColor = True
        '
        'cbOrina
        '
        Me.cbOrina.AutoSize = True
        Me.cbOrina.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOrina.Location = New System.Drawing.Point(519, 111)
        Me.cbOrina.Name = "cbOrina"
        Me.cbOrina.Size = New System.Drawing.Size(58, 18)
        Me.cbOrina.TabIndex = 12
        Me.cbOrina.Text = "Orina"
        Me.cbOrina.UseVisualStyleBackColor = True
        '
        'cbPEmbarazo
        '
        Me.cbPEmbarazo.AutoSize = True
        Me.cbPEmbarazo.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPEmbarazo.Location = New System.Drawing.Point(519, 134)
        Me.cbPEmbarazo.Name = "cbPEmbarazo"
        Me.cbPEmbarazo.Size = New System.Drawing.Size(141, 18)
        Me.cbPEmbarazo.TabIndex = 13
        Me.cbPEmbarazo.Text = "Prueba de Embarazo"
        Me.cbPEmbarazo.UseVisualStyleBackColor = True
        '
        'cbCropologico
        '
        Me.cbCropologico.AutoSize = True
        Me.cbCropologico.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCropologico.Location = New System.Drawing.Point(519, 177)
        Me.cbCropologico.Name = "cbCropologico"
        Me.cbCropologico.Size = New System.Drawing.Size(96, 18)
        Me.cbCropologico.TabIndex = 15
        Me.cbCropologico.Text = "Cropologico"
        Me.cbCropologico.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(293, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Continuar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtAtendido
        '
        Me.txtAtendido.Location = New System.Drawing.Point(102, 218)
        Me.txtAtendido.Name = "txtAtendido"
        Me.txtAtendido.Size = New System.Drawing.Size(100, 20)
        Me.txtAtendido.TabIndex = 7
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(12, 220)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(71, 18)
        Me.lblNumero.TabIndex = 130
        Me.lblNumero.Text = "Numero:"
        '
        'cbTodos
        '
        Me.cbTodos.AutoSize = True
        Me.cbTodos.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTodos.Location = New System.Drawing.Point(519, 201)
        Me.cbTodos.Name = "cbTodos"
        Me.cbTodos.Size = New System.Drawing.Size(61, 18)
        Me.cbTodos.TabIndex = 16
        Me.cbTodos.Text = "Todos"
        Me.cbTodos.UseVisualStyleBackColor = True
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(29, 63)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(69, 18)
        Me.lblApellido.TabIndex = 131
        Me.lblApellido.Text = "Apellido:"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(102, 61)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(221, 20)
        Me.txtApellido.TabIndex = 2
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(404, 289)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 18
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(40, 254)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(55, 18)
        Me.lblFecha.TabIndex = 134
        Me.lblFecha.Text = "Fecha:"
        '
        'dtpFechaActual
        '
        Me.dtpFechaActual.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaActual.Location = New System.Drawing.Point(102, 251)
        Me.dtpFechaActual.Name = "dtpFechaActual"
        Me.dtpFechaActual.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaActual.TabIndex = 8
        '
        'dtpFechaEnt
        '
        Me.dtpFechaEnt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEnt.Location = New System.Drawing.Point(101, 279)
        Me.dtpFechaEnt.Name = "dtpFechaEnt"
        Me.dtpFechaEnt.Size = New System.Drawing.Size(101, 20)
        Me.dtpFechaEnt.TabIndex = 135
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "Fecha Ent:"
        '
        'frmFiltro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 324)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFechaEnt)
        Me.Controls.Add(Me.dtpFechaActual)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.cbTodos)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.txtAtendido)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbCropologico)
        Me.Controls.Add(Me.cbPEmbarazo)
        Me.Controls.Add(Me.cbOrina)
        Me.Controls.Add(Me.cbQuimicaSanguinea)
        Me.Controls.Add(Me.cbSedimentos)
        Me.Controls.Add(Me.cbSerologia)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.cbbSexo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtNRecord)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.lblRecord)
        Me.Controls.Add(Me.lblIndMedico)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.lblEdad)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "frmFiltro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Indicaciones del Paciente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbbSexo As System.Windows.Forms.ComboBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents txtNRecord As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents lblRecord As System.Windows.Forms.Label
    Friend WithEvents lblIndMedico As System.Windows.Forms.Label
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents lblEdad As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents cbSerologia As System.Windows.Forms.CheckBox
    Friend WithEvents cbSedimentos As System.Windows.Forms.CheckBox
    Friend WithEvents cbQuimicaSanguinea As System.Windows.Forms.CheckBox
    Friend WithEvents cbOrina As System.Windows.Forms.CheckBox
    Friend WithEvents cbPEmbarazo As System.Windows.Forms.CheckBox
    Friend WithEvents cbCropologico As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtAtendido As System.Windows.Forms.TextBox
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents cbTodos As System.Windows.Forms.CheckBox
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents dtpFechaActual As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaEnt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
