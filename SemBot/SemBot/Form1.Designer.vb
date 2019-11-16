<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Con = New System.Windows.Forms.GroupBox()
        Me.BtnParar = New System.Windows.Forms.Button()
        Me.BtnEncender = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnAtras = New System.Windows.Forms.Button()
        Me.BtnDerecha = New System.Windows.Forms.Button()
        Me.BtnIzquierda = New System.Windows.Forms.Button()
        Me.BtnAdelante = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TrVelocidad = New System.Windows.Forms.TrackBar()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbEncoder = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbMag = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnAuto = New System.Windows.Forms.Button()
        Me.BtnManual = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Con.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TrVelocidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mistral", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 76)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SemBOT"
        '
        'Con
        '
        Me.Con.Controls.Add(Me.BtnParar)
        Me.Con.Controls.Add(Me.BtnEncender)
        Me.Con.Location = New System.Drawing.Point(42, 107)
        Me.Con.Name = "Con"
        Me.Con.Size = New System.Drawing.Size(142, 130)
        Me.Con.TabIndex = 1
        Me.Con.TabStop = False
        Me.Con.Text = "CONTROL MOTOR"
        '
        'BtnParar
        '
        Me.BtnParar.Location = New System.Drawing.Point(25, 71)
        Me.BtnParar.Name = "BtnParar"
        Me.BtnParar.Size = New System.Drawing.Size(88, 28)
        Me.BtnParar.TabIndex = 1
        Me.BtnParar.Text = "PARAR"
        Me.BtnParar.UseVisualStyleBackColor = True
        '
        'BtnEncender
        '
        Me.BtnEncender.Location = New System.Drawing.Point(25, 27)
        Me.BtnEncender.Name = "BtnEncender"
        Me.BtnEncender.Size = New System.Drawing.Size(88, 30)
        Me.BtnEncender.TabIndex = 0
        Me.BtnEncender.Text = "ENCENDER"
        Me.BtnEncender.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnAtras)
        Me.GroupBox1.Controls.Add(Me.BtnDerecha)
        Me.GroupBox1.Controls.Add(Me.BtnIzquierda)
        Me.GroupBox1.Controls.Add(Me.BtnAdelante)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 243)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 141)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DIRECCION"
        '
        'BtnAtras
        '
        Me.BtnAtras.Location = New System.Drawing.Point(131, 91)
        Me.BtnAtras.Name = "BtnAtras"
        Me.BtnAtras.Size = New System.Drawing.Size(73, 29)
        Me.BtnAtras.TabIndex = 3
        Me.BtnAtras.Text = "ATRAS"
        Me.BtnAtras.UseVisualStyleBackColor = True
        '
        'BtnDerecha
        '
        Me.BtnDerecha.Location = New System.Drawing.Point(226, 51)
        Me.BtnDerecha.Name = "BtnDerecha"
        Me.BtnDerecha.Size = New System.Drawing.Size(68, 30)
        Me.BtnDerecha.TabIndex = 2
        Me.BtnDerecha.Text = "DERECHA"
        Me.BtnDerecha.UseVisualStyleBackColor = True
        '
        'BtnIzquierda
        '
        Me.BtnIzquierda.Location = New System.Drawing.Point(25, 51)
        Me.BtnIzquierda.Name = "BtnIzquierda"
        Me.BtnIzquierda.Size = New System.Drawing.Size(79, 30)
        Me.BtnIzquierda.TabIndex = 1
        Me.BtnIzquierda.Text = "IZQUIERDA"
        Me.BtnIzquierda.UseVisualStyleBackColor = True
        '
        'BtnAdelante
        '
        Me.BtnAdelante.Location = New System.Drawing.Point(131, 16)
        Me.BtnAdelante.Name = "BtnAdelante"
        Me.BtnAdelante.Size = New System.Drawing.Size(73, 29)
        Me.BtnAdelante.TabIndex = 0
        Me.BtnAdelante.Text = "ADELANTE"
        Me.BtnAdelante.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TrVelocidad)
        Me.GroupBox2.Location = New System.Drawing.Point(198, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(164, 130)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "VELOCIDAD"
        '
        'TrVelocidad
        '
        Me.TrVelocidad.Location = New System.Drawing.Point(6, 54)
        Me.TrVelocidad.Maximum = 255
        Me.TrVelocidad.Name = "TrVelocidad"
        Me.TrVelocidad.Size = New System.Drawing.Size(134, 45)
        Me.TrVelocidad.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbEncoder)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TbMag)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(383, 107)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(133, 153)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SENSORES"
        '
        'tbEncoder
        '
        Me.tbEncoder.Location = New System.Drawing.Point(9, 127)
        Me.tbEncoder.Name = "tbEncoder"
        Me.tbEncoder.Size = New System.Drawing.Size(118, 20)
        Me.tbEncoder.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ENCODER:"
        '
        'TbMag
        '
        Me.TbMag.Location = New System.Drawing.Point(9, 60)
        Me.TbMag.Name = "TbMag"
        Me.TbMag.Size = New System.Drawing.Size(118, 20)
        Me.TbMag.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "MAGNETOMETRO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Mistral", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(64, 400)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "ISAURA FLORES"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Mistral", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(128, 400)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "- FERNANDA CARLES"
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM6"
        '
        'Timer1
        '
        '
        'BtnAuto
        '
        Me.BtnAuto.Location = New System.Drawing.Point(241, 38)
        Me.BtnAuto.Name = "BtnAuto"
        Me.BtnAuto.Size = New System.Drawing.Size(75, 23)
        Me.BtnAuto.TabIndex = 9
        Me.BtnAuto.Text = "AUTO"
        Me.BtnAuto.UseVisualStyleBackColor = True
        '
        'BtnManual
        '
        Me.BtnManual.Location = New System.Drawing.Point(340, 38)
        Me.BtnManual.Name = "BtnManual"
        Me.BtnManual.Size = New System.Drawing.Size(75, 23)
        Me.BtnManual.TabIndex = 10
        Me.BtnManual.Text = "MANUAL"
        Me.BtnManual.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(441, 38)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 11
        Me.BtnSalir.Text = "SALIR"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(383, 280)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(142, 116)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DISTANCIA SEMILLA"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 55)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(118, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 422)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnManual)
        Me.Controls.Add(Me.BtnAuto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Con)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Con.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TrVelocidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Con As System.Windows.Forms.GroupBox
    Friend WithEvents BtnParar As System.Windows.Forms.Button
    Friend WithEvents BtnEncender As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDerecha As System.Windows.Forms.Button
    Friend WithEvents BtnIzquierda As System.Windows.Forms.Button
    Friend WithEvents BtnAdelante As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TrVelocidad As System.Windows.Forms.TrackBar
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAtras As System.Windows.Forms.Button
    Friend WithEvents TbMag As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbEncoder As TextBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnAuto As Button
    Friend WithEvents BtnManual As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TextBox1 As TextBox
End Class
