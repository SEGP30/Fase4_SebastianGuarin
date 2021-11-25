<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginEstudiante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginEstudiante))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Regresar_Inicio = New System.Windows.Forms.Button()
        Me.Ingresar_Estudiante = New System.Windows.Forms.Button()
        Me.Contraseña = New System.Windows.Forms.TextBox()
        Me.Usuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(98, 112)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Regresar_Inicio
        '
        Me.Regresar_Inicio.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresar_Inicio.Location = New System.Drawing.Point(112, 276)
        Me.Regresar_Inicio.Name = "Regresar_Inicio"
        Me.Regresar_Inicio.Size = New System.Drawing.Size(77, 28)
        Me.Regresar_Inicio.TabIndex = 19
        Me.Regresar_Inicio.Text = "Regresar"
        Me.Regresar_Inicio.UseVisualStyleBackColor = True
        '
        'Ingresar_Estudiante
        '
        Me.Ingresar_Estudiante.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ingresar_Estudiante.Location = New System.Drawing.Point(383, 214)
        Me.Ingresar_Estudiante.Name = "Ingresar_Estudiante"
        Me.Ingresar_Estudiante.Size = New System.Drawing.Size(75, 29)
        Me.Ingresar_Estudiante.TabIndex = 18
        Me.Ingresar_Estudiante.Text = "‌Ingresar"
        Me.Ingresar_Estudiante.UseVisualStyleBackColor = True
        '
        'Contraseña
        '
        Me.Contraseña.Location = New System.Drawing.Point(350, 176)
        Me.Contraseña.Name = "Contraseña"
        Me.Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Contraseña.Size = New System.Drawing.Size(179, 20)
        Me.Contraseña.TabIndex = 17
        '
        'Usuario
        '
        Me.Usuario.Location = New System.Drawing.Point(350, 134)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(179, 20)
        Me.Usuario.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(231, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 28)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Contraseña:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(251, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 28)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Usuario:"
        '
        'LoginEstudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(626, 417)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Regresar_Inicio)
        Me.Controls.Add(Me.Ingresar_Estudiante)
        Me.Controls.Add(Me.Contraseña)
        Me.Controls.Add(Me.Usuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "LoginEstudiante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginEstudiante"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Regresar_Inicio As Button
    Friend WithEvents Ingresar_Estudiante As Button
    Friend WithEvents Contraseña As TextBox
    Friend WithEvents Usuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
