<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCrearProyecto
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
        Me.TextBoxcodproyecto = New System.Windows.Forms.TextBox()
        Me.TextBoxTemas = New System.Windows.Forms.TextBox()
        Me.TextBoxnomestablecimiento = New System.Windows.Forms.TextBox()
        Me.TextBoxnomproyecto = New System.Windows.Forms.TextBox()
        Me.TextBoxcapacidad = New System.Windows.Forms.TextBox()
        Me.TextBoxdireccion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxcantcupos = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxcodproyecto
        '
        Me.TextBoxcodproyecto.Location = New System.Drawing.Point(17, 73)
        Me.TextBoxcodproyecto.Name = "TextBoxcodproyecto"
        Me.TextBoxcodproyecto.Size = New System.Drawing.Size(138, 20)
        Me.TextBoxcodproyecto.TabIndex = 0
        '
        'TextBoxTemas
        '
        Me.TextBoxTemas.Location = New System.Drawing.Point(212, 73)
        Me.TextBoxTemas.Multiline = True
        Me.TextBoxTemas.Name = "TextBoxTemas"
        Me.TextBoxTemas.Size = New System.Drawing.Size(448, 82)
        Me.TextBoxTemas.TabIndex = 1
        '
        'TextBoxnomestablecimiento
        '
        Me.TextBoxnomestablecimiento.Location = New System.Drawing.Point(16, 58)
        Me.TextBoxnomestablecimiento.Name = "TextBoxnomestablecimiento"
        Me.TextBoxnomestablecimiento.Size = New System.Drawing.Size(260, 20)
        Me.TextBoxnomestablecimiento.TabIndex = 2
        '
        'TextBoxnomproyecto
        '
        Me.TextBoxnomproyecto.Location = New System.Drawing.Point(17, 135)
        Me.TextBoxnomproyecto.Name = "TextBoxnomproyecto"
        Me.TextBoxnomproyecto.Size = New System.Drawing.Size(138, 20)
        Me.TextBoxnomproyecto.TabIndex = 3
        '
        'TextBoxcapacidad
        '
        Me.TextBoxcapacidad.Location = New System.Drawing.Point(338, 58)
        Me.TextBoxcapacidad.Name = "TextBoxcapacidad"
        Me.TextBoxcapacidad.Size = New System.Drawing.Size(138, 20)
        Me.TextBoxcapacidad.TabIndex = 4
        '
        'TextBoxdireccion
        '
        Me.TextBoxdireccion.Location = New System.Drawing.Point(16, 125)
        Me.TextBoxdireccion.Name = "TextBoxdireccion"
        Me.TextBoxdireccion.Size = New System.Drawing.Size(260, 20)
        Me.TextBoxdireccion.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Codigo Proyecto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nombre Proyecto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Temas"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxnomproyecto)
        Me.GroupBox1.Controls.Add(Me.TextBoxTemas)
        Me.GroupBox1.Controls.Add(Me.TextBoxcodproyecto)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(732, 189)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Principales"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Nombre Establecimiento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Direccion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(335, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Capacidad"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TextBoxdireccion)
        Me.GroupBox2.Controls.Add(Me.TextBoxcapacidad)
        Me.GroupBox2.Controls.Add(Me.TextBoxnomestablecimiento)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 225)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(730, 191)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Establecimiento"
        '
        'TextBoxcantcupos
        '
        Me.TextBoxcantcupos.Location = New System.Drawing.Point(17, 62)
        Me.TextBoxcantcupos.Name = "TextBoxcantcupos"
        Me.TextBoxcantcupos.Size = New System.Drawing.Size(138, 20)
        Me.TextBoxcantcupos.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Cantidad de Cupos"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(199, 59)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(165, 20)
        Me.DateTimePicker1.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(196, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Fecha de Inicio"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(404, 59)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(165, 20)
        Me.DateTimePicker2.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(401, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Fecha de Finalizacion"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TextBoxcantcupos)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 440)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(728, 120)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de Inscripcion"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(461, 592)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 28)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(620, 592)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 28)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormCrearProyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(772, 648)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormCrearProyecto"
        Me.Text = "Crear Proyecto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBoxcodproyecto As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTemas As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxnomestablecimiento As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxnomproyecto As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxcapacidad As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxdireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxcantcupos As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
