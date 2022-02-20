<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lbpreciocosto = New System.Windows.Forms.Label()
        Me.lbprecioventa = New System.Windows.Forms.Label()
        Me.txtprecioC = New System.Windows.Forms.TextBox()
        Me.txtpreciov = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbpreciocosto
        '
        Me.lbpreciocosto.AutoSize = True
        Me.lbpreciocosto.BackColor = System.Drawing.Color.Transparent
        Me.lbpreciocosto.ForeColor = System.Drawing.SystemColors.Control
        Me.lbpreciocosto.Location = New System.Drawing.Point(46, 52)
        Me.lbpreciocosto.Name = "lbpreciocosto"
        Me.lbpreciocosto.Size = New System.Drawing.Size(123, 13)
        Me.lbpreciocosto.TabIndex = 0
        Me.lbpreciocosto.Text = "Precio Costo (Quetzales)"
        '
        'lbprecioventa
        '
        Me.lbprecioventa.AutoSize = True
        Me.lbprecioventa.BackColor = System.Drawing.Color.Transparent
        Me.lbprecioventa.ForeColor = System.Drawing.Color.Transparent
        Me.lbprecioventa.Location = New System.Drawing.Point(46, 97)
        Me.lbprecioventa.Name = "lbprecioventa"
        Me.lbprecioventa.Size = New System.Drawing.Size(123, 13)
        Me.lbprecioventa.TabIndex = 1
        Me.lbprecioventa.Text = "Precio venta (Quetzales)"
        '
        'txtprecioC
        '
        Me.txtprecioC.Location = New System.Drawing.Point(226, 52)
        Me.txtprecioC.Name = "txtprecioC"
        Me.txtprecioC.Size = New System.Drawing.Size(100, 20)
        Me.txtprecioC.TabIndex = 2
        '
        'txtpreciov
        '
        Me.txtpreciov.Location = New System.Drawing.Point(226, 94)
        Me.txtpreciov.Name = "txtpreciov"
        Me.txtpreciov.Size = New System.Drawing.Size(100, 20)
        Me.txtpreciov.TabIndex = 3
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(359, 143)
        Me.Controls.Add(Me.txtpreciov)
        Me.Controls.Add(Me.txtprecioC)
        Me.Controls.Add(Me.lbprecioventa)
        Me.Controls.Add(Me.lbpreciocosto)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbpreciocosto As Label
    Friend WithEvents lbprecioventa As Label
    Friend WithEvents txtprecioC As TextBox
    Friend WithEvents txtpreciov As TextBox
End Class
