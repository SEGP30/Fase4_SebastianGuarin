<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionAdmin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionAdmin))
        Me.Regresar = New System.Windows.Forms.Button()
        Me.Txt_Email = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txt_Direccion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Txt_Contraseña = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_Telefono = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Edad = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_Apellido = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBox_Genero = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Actualizar_Registro = New System.Windows.Forms.Button()
        Me.Eliminar_Registro = New System.Windows.Forms.Button()
        Me.Ingresar_Registro = New System.Windows.Forms.Button()
        Me.Txt_Id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdentificaciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EdadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDeNacimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GéneroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeléfonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContraseñaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoElectrónicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirecciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstudianteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstudiantesDataSet = New Fase4_SebastianGuarin.EstudiantesDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EstudianteTableAdapter = New Fase4_SebastianGuarin.EstudiantesDataSetTableAdapters.EstudianteTableAdapter()
        CType(Me.Edad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstudianteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstudiantesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Regresar
        '
        Me.Regresar.Font = New System.Drawing.Font("Poppins SemiBold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresar.Location = New System.Drawing.Point(539, 12)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(75, 23)
        Me.Regresar.TabIndex = 51
        Me.Regresar.Text = "Regresar"
        Me.Regresar.UseVisualStyleBackColor = True
        '
        'Txt_Email
        '
        Me.Txt_Email.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudianteBindingSource, "Correo Electrónico", True))
        Me.Txt_Email.Location = New System.Drawing.Point(462, 286)
        Me.Txt_Email.Name = "Txt_Email"
        Me.Txt_Email.Size = New System.Drawing.Size(121, 20)
        Me.Txt_Email.TabIndex = 50
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(308, 285)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 23)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Correo electrónico:"
        '
        'Txt_Direccion
        '
        Me.Txt_Direccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudianteBindingSource, "Dirección", True))
        Me.Txt_Direccion.Location = New System.Drawing.Point(175, 286)
        Me.Txt_Direccion.Name = "Txt_Direccion"
        Me.Txt_Direccion.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Direccion.TabIndex = 48
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(51, 286)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 23)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Dirección:"
        '
        'Txt_Contraseña
        '
        Me.Txt_Contraseña.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudianteBindingSource, "Contraseña", True))
        Me.Txt_Contraseña.Location = New System.Drawing.Point(462, 242)
        Me.Txt_Contraseña.Name = "Txt_Contraseña"
        Me.Txt_Contraseña.Size = New System.Drawing.Size(121, 20)
        Me.Txt_Contraseña.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(335, 242)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 23)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Contraseña:"
        '
        'Txt_Telefono
        '
        Me.Txt_Telefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudianteBindingSource, "Teléfono", True))
        Me.Txt_Telefono.Location = New System.Drawing.Point(175, 242)
        Me.Txt_Telefono.Name = "Txt_Telefono"
        Me.Txt_Telefono.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Telefono.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(51, 242)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 23)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Teléfono:"
        '
        'FechaNacimiento
        '
        Me.FechaNacimiento.CustomFormat = "dd-MM-yyyy"
        Me.FechaNacimiento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudianteBindingSource, "Fecha de nacimiento", True))
        Me.FechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaNacimiento.Location = New System.Drawing.Point(463, 158)
        Me.FechaNacimiento.Name = "FechaNacimiento"
        Me.FechaNacimiento.Size = New System.Drawing.Size(120, 20)
        Me.FechaNacimiento.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(302, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 23)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Fecha de nacimiento:"
        '
        'Edad
        '
        Me.Edad.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EstudianteBindingSource, "Edad", True))
        Me.Edad.Location = New System.Drawing.Point(462, 198)
        Me.Edad.Name = "Edad"
        Me.Edad.Size = New System.Drawing.Size(120, 20)
        Me.Edad.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(349, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 23)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Edad:"
        '
        'Txt_Apellido
        '
        Me.Txt_Apellido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudianteBindingSource, "Apellidos", True))
        Me.Txt_Apellido.Location = New System.Drawing.Point(175, 199)
        Me.Txt_Apellido.Name = "Txt_Apellido"
        Me.Txt_Apellido.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Apellido.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(51, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 23)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Apellidos:"
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudianteBindingSource, "Nombre(s)", True))
        Me.Txt_Nombre.Location = New System.Drawing.Point(175, 160)
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Nombre.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(51, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 23)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Nombre(s)"
        '
        'CBox_Genero
        '
        Me.CBox_Genero.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudianteBindingSource, "Género", True))
        Me.CBox_Genero.FormattingEnabled = True
        Me.CBox_Genero.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.CBox_Genero.Location = New System.Drawing.Point(462, 118)
        Me.CBox_Genero.Name = "CBox_Genero"
        Me.CBox_Genero.Size = New System.Drawing.Size(121, 21)
        Me.CBox_Genero.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(349, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 23)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Género:"
        '
        'Actualizar_Registro
        '
        Me.Actualizar_Registro.Font = New System.Drawing.Font("Poppins SemiBold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Actualizar_Registro.Location = New System.Drawing.Point(284, 340)
        Me.Actualizar_Registro.Name = "Actualizar_Registro"
        Me.Actualizar_Registro.Size = New System.Drawing.Size(75, 23)
        Me.Actualizar_Registro.TabIndex = 32
        Me.Actualizar_Registro.Text = "Actualizar"
        Me.Actualizar_Registro.UseVisualStyleBackColor = True
        '
        'Eliminar_Registro
        '
        Me.Eliminar_Registro.Font = New System.Drawing.Font("Poppins SemiBold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminar_Registro.Location = New System.Drawing.Point(390, 340)
        Me.Eliminar_Registro.Name = "Eliminar_Registro"
        Me.Eliminar_Registro.Size = New System.Drawing.Size(75, 23)
        Me.Eliminar_Registro.TabIndex = 31
        Me.Eliminar_Registro.Text = "Eliminar"
        Me.Eliminar_Registro.UseVisualStyleBackColor = True
        '
        'Ingresar_Registro
        '
        Me.Ingresar_Registro.Font = New System.Drawing.Font("Poppins SemiBold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ingresar_Registro.Location = New System.Drawing.Point(175, 340)
        Me.Ingresar_Registro.Name = "Ingresar_Registro"
        Me.Ingresar_Registro.Size = New System.Drawing.Size(75, 23)
        Me.Ingresar_Registro.TabIndex = 30
        Me.Ingresar_Registro.Text = "Ingresar"
        Me.Ingresar_Registro.UseVisualStyleBackColor = True
        '
        'Txt_Id
        '
        Me.Txt_Id.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudianteBindingSource, "Identificación", True))
        Me.Txt_Id.Location = New System.Drawing.Point(175, 119)
        Me.Txt_Id.Name = "Txt_Id"
        Me.Txt_Id.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Id.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(51, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 23)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Identificación:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificaciónDataGridViewTextBoxColumn, Me.NombresDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.EdadDataGridViewTextBoxColumn, Me.FechaDeNacimientoDataGridViewTextBoxColumn, Me.GéneroDataGridViewTextBoxColumn, Me.TeléfonoDataGridViewTextBoxColumn, Me.ContraseñaDataGridViewTextBoxColumn, Me.CorreoElectrónicoDataGridViewTextBoxColumn, Me.DirecciónDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EstudianteBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 369)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(602, 150)
        Me.DataGridView1.TabIndex = 27
        '
        'IdentificaciónDataGridViewTextBoxColumn
        '
        Me.IdentificaciónDataGridViewTextBoxColumn.DataPropertyName = "Identificación"
        Me.IdentificaciónDataGridViewTextBoxColumn.HeaderText = "Identificación"
        Me.IdentificaciónDataGridViewTextBoxColumn.Name = "IdentificaciónDataGridViewTextBoxColumn"
        '
        'NombresDataGridViewTextBoxColumn
        '
        Me.NombresDataGridViewTextBoxColumn.DataPropertyName = "Nombre(s)"
        Me.NombresDataGridViewTextBoxColumn.HeaderText = "Nombre(s)"
        Me.NombresDataGridViewTextBoxColumn.Name = "NombresDataGridViewTextBoxColumn"
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        '
        'EdadDataGridViewTextBoxColumn
        '
        Me.EdadDataGridViewTextBoxColumn.DataPropertyName = "Edad"
        Me.EdadDataGridViewTextBoxColumn.HeaderText = "Edad"
        Me.EdadDataGridViewTextBoxColumn.Name = "EdadDataGridViewTextBoxColumn"
        '
        'FechaDeNacimientoDataGridViewTextBoxColumn
        '
        Me.FechaDeNacimientoDataGridViewTextBoxColumn.DataPropertyName = "Fecha de nacimiento"
        Me.FechaDeNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha de nacimiento"
        Me.FechaDeNacimientoDataGridViewTextBoxColumn.Name = "FechaDeNacimientoDataGridViewTextBoxColumn"
        '
        'GéneroDataGridViewTextBoxColumn
        '
        Me.GéneroDataGridViewTextBoxColumn.DataPropertyName = "Género"
        Me.GéneroDataGridViewTextBoxColumn.HeaderText = "Género"
        Me.GéneroDataGridViewTextBoxColumn.Name = "GéneroDataGridViewTextBoxColumn"
        '
        'TeléfonoDataGridViewTextBoxColumn
        '
        Me.TeléfonoDataGridViewTextBoxColumn.DataPropertyName = "Teléfono"
        Me.TeléfonoDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.TeléfonoDataGridViewTextBoxColumn.Name = "TeléfonoDataGridViewTextBoxColumn"
        '
        'ContraseñaDataGridViewTextBoxColumn
        '
        Me.ContraseñaDataGridViewTextBoxColumn.DataPropertyName = "Contraseña"
        Me.ContraseñaDataGridViewTextBoxColumn.HeaderText = "Contraseña"
        Me.ContraseñaDataGridViewTextBoxColumn.Name = "ContraseñaDataGridViewTextBoxColumn"
        '
        'CorreoElectrónicoDataGridViewTextBoxColumn
        '
        Me.CorreoElectrónicoDataGridViewTextBoxColumn.DataPropertyName = "Correo Electrónico"
        Me.CorreoElectrónicoDataGridViewTextBoxColumn.HeaderText = "Correo Electrónico"
        Me.CorreoElectrónicoDataGridViewTextBoxColumn.Name = "CorreoElectrónicoDataGridViewTextBoxColumn"
        '
        'DirecciónDataGridViewTextBoxColumn
        '
        Me.DirecciónDataGridViewTextBoxColumn.DataPropertyName = "Dirección"
        Me.DirecciónDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.DirecciónDataGridViewTextBoxColumn.Name = "DirecciónDataGridViewTextBoxColumn"
        '
        'EstudianteBindingSource
        '
        Me.EstudianteBindingSource.DataMember = "Estudiante"
        Me.EstudianteBindingSource.DataSource = Me.EstudiantesDataSet
        '
        'EstudiantesDataSet
        '
        Me.EstudiantesDataSet.DataSetName = "EstudiantesDataSet"
        Me.EstudiantesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(168, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 42)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Gestión de Estudiantes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EstudianteTableAdapter
        '
        Me.EstudianteTableAdapter.ClearBeforeFill = True
        '
        'GestionAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(626, 531)
        Me.Controls.Add(Me.Regresar)
        Me.Controls.Add(Me.Txt_Email)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Txt_Direccion)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Txt_Contraseña)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Txt_Telefono)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.FechaNacimiento)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Edad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Txt_Apellido)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txt_Nombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBox_Genero)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Actualizar_Registro)
        Me.Controls.Add(Me.Eliminar_Registro)
        Me.Controls.Add(Me.Ingresar_Registro)
        Me.Controls.Add(Me.Txt_Id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "GestionAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GestionAdmin"
        CType(Me.Edad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstudianteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstudiantesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Regresar As Button
    Friend WithEvents Txt_Email As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Txt_Direccion As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Txt_Contraseña As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Txt_Telefono As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents FechaNacimiento As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Edad As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_Apellido As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_Nombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CBox_Genero As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Actualizar_Registro As Button
    Friend WithEvents Eliminar_Registro As Button
    Friend WithEvents Ingresar_Registro As Button
    Friend WithEvents Txt_Id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents EstudiantesDataSet As EstudiantesDataSet
    Friend WithEvents EstudianteBindingSource As BindingSource
    Friend WithEvents EstudianteTableAdapter As EstudiantesDataSetTableAdapters.EstudianteTableAdapter
    Friend WithEvents IdentificaciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EdadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDeNacimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GéneroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeléfonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContraseñaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoElectrónicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DirecciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
