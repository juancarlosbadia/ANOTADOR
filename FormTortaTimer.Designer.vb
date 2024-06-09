<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTortaTimer
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.BotonTeclado = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(32, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 26)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "< G >"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gold
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(-4, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 26)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Tr"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'BotonTeclado
        '
        Me.BotonTeclado.BackColor = System.Drawing.Color.PeachPuff
        Me.BotonTeclado.BackgroundImage = Global.TXT.My.Resources.Resources.bolita02
        Me.BotonTeclado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BotonTeclado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonTeclado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonTeclado.Image = Global.TXT.My.Resources.Resources.bolita01
        Me.BotonTeclado.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BotonTeclado.Location = New System.Drawing.Point(76, 1)
        Me.BotonTeclado.Name = "BotonTeclado"
        Me.BotonTeclado.Size = New System.Drawing.Size(23, 25)
        Me.BotonTeclado.TabIndex = 70
        Me.BotonTeclado.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gold
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(98, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(29, 26)
        Me.Button3.TabIndex = 71
        Me.Button3.Text = "T"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'FormTortaTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BotonTeclado)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FormTortaTimer"
        Me.TransparencyKey = System.Drawing.Color.LightGray
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BotonTeclado As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
