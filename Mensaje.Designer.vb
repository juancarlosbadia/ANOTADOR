<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mensaje
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
        Me.Texto = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Texto
        '
        Me.Texto.AutoSize = True
        Me.Texto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Texto.Location = New System.Drawing.Point(12, 18)
        Me.Texto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Texto.Name = "Texto"
        Me.Texto.Size = New System.Drawing.Size(65, 20)
        Me.Texto.TabIndex = 1
        Me.Texto.Text = "********"
        '
        'Mensaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 45)
        Me.ControlBox = False
        Me.Controls.Add(Me.Texto)
        Me.Name = "Mensaje"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Texto As System.Windows.Forms.Label
End Class
