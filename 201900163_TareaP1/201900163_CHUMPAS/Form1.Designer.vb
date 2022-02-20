<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbLarge = New System.Windows.Forms.RadioButton()
        Me.rbMedium = New System.Windows.Forms.RadioButton()
        Me.rbSmall = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbLona = New System.Windows.Forms.RadioButton()
        Me.rbSeda = New System.Windows.Forms.RadioButton()
        Me.rbAlgodon = New System.Windows.Forms.RadioButton()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lbCantidaddechumpas = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbLarge)
        Me.GroupBox1.Controls.Add(Me.rbMedium)
        Me.GroupBox1.Controls.Add(Me.rbSmall)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(119, 93)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tamaño"
        '
        'rbLarge
        '
        Me.rbLarge.AutoSize = True
        Me.rbLarge.Location = New System.Drawing.Point(35, 65)
        Me.rbLarge.Name = "rbLarge"
        Me.rbLarge.Size = New System.Drawing.Size(52, 17)
        Me.rbLarge.TabIndex = 2
        Me.rbLarge.TabStop = True
        Me.rbLarge.Text = "Large"
        Me.rbLarge.UseVisualStyleBackColor = True
        '
        'rbMedium
        '
        Me.rbMedium.AutoSize = True
        Me.rbMedium.Location = New System.Drawing.Point(35, 42)
        Me.rbMedium.Name = "rbMedium"
        Me.rbMedium.Size = New System.Drawing.Size(62, 17)
        Me.rbMedium.TabIndex = 1
        Me.rbMedium.TabStop = True
        Me.rbMedium.Text = "Medium"
        Me.rbMedium.UseVisualStyleBackColor = True
        '
        'rbSmall
        '
        Me.rbSmall.AutoSize = True
        Me.rbSmall.BackColor = System.Drawing.Color.Transparent
        Me.rbSmall.Location = New System.Drawing.Point(35, 19)
        Me.rbSmall.Name = "rbSmall"
        Me.rbSmall.Size = New System.Drawing.Size(50, 17)
        Me.rbSmall.TabIndex = 0
        Me.rbSmall.TabStop = True
        Me.rbSmall.Text = "Small"
        Me.rbSmall.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rbLona)
        Me.GroupBox2.Controls.Add(Me.rbSeda)
        Me.GroupBox2.Controls.Add(Me.rbAlgodon)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(12, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(134, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Material"
        '
        'rbLona
        '
        Me.rbLona.AutoSize = True
        Me.rbLona.Location = New System.Drawing.Point(29, 71)
        Me.rbLona.Name = "rbLona"
        Me.rbLona.Size = New System.Drawing.Size(49, 17)
        Me.rbLona.TabIndex = 2
        Me.rbLona.TabStop = True
        Me.rbLona.Text = "Lona"
        Me.rbLona.UseVisualStyleBackColor = True
        '
        'rbSeda
        '
        Me.rbSeda.AutoSize = True
        Me.rbSeda.Location = New System.Drawing.Point(29, 48)
        Me.rbSeda.Name = "rbSeda"
        Me.rbSeda.Size = New System.Drawing.Size(50, 17)
        Me.rbSeda.TabIndex = 1
        Me.rbSeda.TabStop = True
        Me.rbSeda.Text = "Seda"
        Me.rbSeda.UseVisualStyleBackColor = True
        '
        'rbAlgodon
        '
        Me.rbAlgodon.AutoSize = True
        Me.rbAlgodon.Location = New System.Drawing.Point(29, 25)
        Me.rbAlgodon.Name = "rbAlgodon"
        Me.rbAlgodon.Size = New System.Drawing.Size(64, 17)
        Me.rbAlgodon.TabIndex = 0
        Me.rbAlgodon.TabStop = True
        Me.rbAlgodon.Text = "Algodón"
        Me.rbAlgodon.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(191, 51)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(120, 20)
        Me.txtCantidad.TabIndex = 2
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.Black
        Me.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCalcular.Location = New System.Drawing.Point(207, 135)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(88, 26)
        Me.btnCalcular.TabIndex = 3
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Black
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLimpiar.Location = New System.Drawing.Point(207, 167)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(88, 26)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSalir.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSalir.Location = New System.Drawing.Point(207, 199)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(88, 26)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'lbCantidaddechumpas
        '
        Me.lbCantidaddechumpas.AutoSize = True
        Me.lbCantidaddechumpas.BackColor = System.Drawing.Color.Transparent
        Me.lbCantidaddechumpas.Location = New System.Drawing.Point(175, 22)
        Me.lbCantidaddechumpas.Name = "lbCantidaddechumpas"
        Me.lbCantidaddechumpas.Size = New System.Drawing.Size(168, 13)
        Me.lbCantidaddechumpas.TabIndex = 6
        Me.lbCantidaddechumpas.Text = "Ingrese una cantidad de chumpas"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(358, 254)
        Me.Controls.Add(Me.lbCantidaddechumpas)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Chumpas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbLarge As RadioButton
    Friend WithEvents rbMedium As RadioButton
    Friend WithEvents rbSmall As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lbCantidaddechumpas As Label
    Friend WithEvents rbLona As RadioButton
    Friend WithEvents rbSeda As RadioButton
    Friend WithEvents rbAlgodon As RadioButton
End Class
