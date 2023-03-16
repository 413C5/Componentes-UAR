<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtCadena = New System.Windows.Forms.TextBox()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.label11 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.labEncontrado = New System.Windows.Forms.Label()
        Me.labPrimera = New System.Windows.Forms.Label()
        Me.labUltima = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label1.Location = New System.Drawing.Point(31, 31)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(223, 20)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Nombre de componentes UAR"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(31, 63)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(142, 20)
        Me.label2.TabIndex = 1
        Me.label2.Text = "1. Identificador UAR"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(31, 92)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(377, 20)
        Me.label3.TabIndex = 2
        Me.label3.Text = "2. Una Descripción Breve de los Aspectos de Usabilidad"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(31, 125)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(217, 20)
        Me.label4.TabIndex = 3
        Me.label4.Text = "3. Las Evidencias de un Aspecto"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(31, 157)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(217, 20)
        Me.label5.TabIndex = 4
        Me.label5.Text = "4. La Explicación de un Aspecto"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(31, 189)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(493, 20)
        Me.label6.TabIndex = 5
        Me.label6.Text = "5. La Severidad del Problema o el Beneficio de una Característica Positiva"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(31, 223)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(337, 20)
        Me.label7.TabIndex = 6
        Me.label7.Text = "6. Las Posibles Soluciones y los Costos Potenciales"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(31, 257)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(397, 20)
        Me.label8.TabIndex = 7
        Me.label8.Text = "7. La Relación que Tiene con Otros Aspectos de Usabilidad"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(31, 327)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(135, 20)
        Me.label9.TabIndex = 8
        Me.label9.Text = "Ingresa un número:"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(31, 373)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(199, 20)
        Me.label10.TabIndex = 9
        Me.label10.Text = "Ingresa una cadena a buscar:"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(239, 327)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(125, 27)
        Me.txtNumero.TabIndex = 0
        '
        'txtCadena
        '
        Me.txtCadena.Location = New System.Drawing.Point(239, 373)
        Me.txtCadena.Name = "txtCadena"
        Me.txtCadena.Size = New System.Drawing.Size(125, 27)
        Me.txtCadena.TabIndex = 2
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(383, 327)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(94, 29)
        Me.btnMostrar.TabIndex = 1
        Me.btnMostrar.Text = "&Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(383, 373)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(94, 29)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(826, 373)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 29)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label11.Location = New System.Drawing.Point(552, 31)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(247, 20)
        Me.label11.TabIndex = 15
        Me.label11.Text = "Descripción del componente UAR:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(552, 63)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(368, 180)
        Me.txtDescripcion.TabIndex = 16
        Me.txtDescripcion.TabStop = False
        '
        'labEncontrado
        '
        Me.labEncontrado.AutoSize = True
        Me.labEncontrado.Location = New System.Drawing.Point(552, 257)
        Me.labEncontrado.Name = "labEncontrado"
        Me.labEncontrado.Size = New System.Drawing.Size(108, 20)
        Me.labEncontrado.TabIndex = 17
        Me.labEncontrado.Text = "Encontrado en:"
        '
        'labPrimera
        '
        Me.labPrimera.AutoSize = True
        Me.labPrimera.Location = New System.Drawing.Point(552, 293)
        Me.labPrimera.Name = "labPrimera"
        Me.labPrimera.Size = New System.Drawing.Size(123, 20)
        Me.labPrimera.TabIndex = 18
        Me.labPrimera.Text = "Primera posición:"
        Me.labPrimera.Visible = False
        '
        'labUltima
        '
        Me.labUltima.AutoSize = True
        Me.labUltima.Location = New System.Drawing.Point(552, 336)
        Me.labUltima.Name = "labUltima"
        Me.labUltima.Size = New System.Drawing.Size(116, 20)
        Me.labUltima.TabIndex = 19
        Me.labUltima.Text = "Última posicion:"
        Me.labUltima.Visible = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(939, 450)
        Me.Controls.Add(Me.labUltima)
        Me.Controls.Add(Me.labPrimera)
        Me.Controls.Add(Me.labEncontrado)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.txtCadena)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Componentes UAR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents label4 As Label
    Friend WithEvents label5 As Label
    Friend WithEvents label6 As Label
    Friend WithEvents label7 As Label
    Friend WithEvents label8 As Label
    Friend WithEvents label9 As Label
    Friend WithEvents label10 As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtCadena As TextBox
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents label11 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents labEncontrado As Label
    Friend WithEvents labPrimera As Label
    Friend WithEvents labUltima As Label
End Class
