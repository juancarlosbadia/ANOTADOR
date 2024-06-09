<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInforme
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInforme))
        Me.LabelDirectorioActual = New System.Windows.Forms.Label
        Me.TextoDirectorioActual = New System.Windows.Forms.TextBox
        Me.TextoNombreArchivo = New System.Windows.Forms.TextBox
        Me.LabelNombreArchivo = New System.Windows.Forms.Label
        Me.TextoNombreArchivoConExtension = New System.Windows.Forms.TextBox
        Me.LabelNombreArchivoConExtension = New System.Windows.Forms.Label
        Me.TextoLugarDelInforme = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BotonAchicaAgranda = New System.Windows.Forms.Button
        Me.TextoPathInicial = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.BotonTeclado = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'LabelDirectorioActual
        '
        Me.LabelDirectorioActual.AutoSize = True
        Me.LabelDirectorioActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDirectorioActual.Location = New System.Drawing.Point(13, 13)
        Me.LabelDirectorioActual.Name = "LabelDirectorioActual"
        Me.LabelDirectorioActual.Size = New System.Drawing.Size(128, 17)
        Me.LabelDirectorioActual.TabIndex = 0
        Me.LabelDirectorioActual.Text = "Directorio actual"
        '
        'TextoDirectorioActual
        '
        Me.TextoDirectorioActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoDirectorioActual.Location = New System.Drawing.Point(17, 33)
        Me.TextoDirectorioActual.Multiline = True
        Me.TextoDirectorioActual.Name = "TextoDirectorioActual"
        Me.TextoDirectorioActual.Size = New System.Drawing.Size(490, 34)
        Me.TextoDirectorioActual.TabIndex = 1
        '
        'TextoNombreArchivo
        '
        Me.TextoNombreArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoNombreArchivo.Location = New System.Drawing.Point(16, 102)
        Me.TextoNombreArchivo.Multiline = True
        Me.TextoNombreArchivo.Name = "TextoNombreArchivo"
        Me.TextoNombreArchivo.Size = New System.Drawing.Size(488, 34)
        Me.TextoNombreArchivo.TabIndex = 3
        '
        'LabelNombreArchivo
        '
        Me.LabelNombreArchivo.AutoSize = True
        Me.LabelNombreArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreArchivo.Location = New System.Drawing.Point(13, 75)
        Me.LabelNombreArchivo.Name = "LabelNombreArchivo"
        Me.LabelNombreArchivo.Size = New System.Drawing.Size(122, 17)
        Me.LabelNombreArchivo.TabIndex = 2
        Me.LabelNombreArchivo.Text = "Nombre archivo"
        '
        'TextoNombreArchivoConExtension
        '
        Me.TextoNombreArchivoConExtension.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoNombreArchivoConExtension.Location = New System.Drawing.Point(10, 159)
        Me.TextoNombreArchivoConExtension.Multiline = True
        Me.TextoNombreArchivoConExtension.Name = "TextoNombreArchivoConExtension"
        Me.TextoNombreArchivoConExtension.Size = New System.Drawing.Size(496, 34)
        Me.TextoNombreArchivoConExtension.TabIndex = 5
        '
        'LabelNombreArchivoConExtension
        '
        Me.LabelNombreArchivoConExtension.AutoSize = True
        Me.LabelNombreArchivoConExtension.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreArchivoConExtension.Location = New System.Drawing.Point(12, 139)
        Me.LabelNombreArchivoConExtension.Name = "LabelNombreArchivoConExtension"
        Me.LabelNombreArchivoConExtension.Size = New System.Drawing.Size(185, 17)
        Me.LabelNombreArchivoConExtension.TabIndex = 4
        Me.LabelNombreArchivoConExtension.Text = "Nombre archivo con Ext."
        '
        'TextoLugarDelInforme
        '
        Me.TextoLugarDelInforme.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoLugarDelInforme.Location = New System.Drawing.Point(11, 220)
        Me.TextoLugarDelInforme.Multiline = True
        Me.TextoLugarDelInforme.Name = "TextoLugarDelInforme"
        Me.TextoLugarDelInforme.Size = New System.Drawing.Size(495, 34)
        Me.TextoLugarDelInforme.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(387, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Lugar del programa en donde se produce el informe"
        '
        'BotonAchicaAgranda
        '
        Me.BotonAchicaAgranda.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonAchicaAgranda.Location = New System.Drawing.Point(238, 3)
        Me.BotonAchicaAgranda.Name = "BotonAchicaAgranda"
        Me.BotonAchicaAgranda.Size = New System.Drawing.Size(265, 28)
        Me.BotonAchicaAgranda.TabIndex = 8
        Me.BotonAchicaAgranda.Text = "Achica texto  /Agranda texto"
        Me.BotonAchicaAgranda.UseVisualStyleBackColor = True
        '
        'TextoPathInicial
        '
        Me.TextoPathInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoPathInicial.Location = New System.Drawing.Point(12, 290)
        Me.TextoPathInicial.Multiline = True
        Me.TextoPathInicial.Name = "TextoPathInicial"
        Me.TextoPathInicial.Size = New System.Drawing.Size(495, 34)
        Me.TextoPathInicial.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Path inicial"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(615, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 60)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Achica texto  /Agranda texto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(557, 102)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(234, 150)
        Me.TextBox1.TabIndex = 12
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
        Me.BotonTeclado.Location = New System.Drawing.Point(473, 70)
        Me.BotonTeclado.Margin = New System.Windows.Forms.Padding(4)
        Me.BotonTeclado.Name = "BotonTeclado"
        Me.BotonTeclado.Size = New System.Drawing.Size(30, 30)
        Me.BotonTeclado.TabIndex = 120
        Me.BotonTeclado.UseVisualStyleBackColor = False
        '
        'FormInforme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 336)
        Me.Controls.Add(Me.BotonTeclado)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextoPathInicial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BotonAchicaAgranda)
        Me.Controls.Add(Me.TextoLugarDelInforme)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextoNombreArchivoConExtension)
        Me.Controls.Add(Me.LabelNombreArchivoConExtension)
        Me.Controls.Add(Me.TextoNombreArchivo)
        Me.Controls.Add(Me.LabelNombreArchivo)
        Me.Controls.Add(Me.TextoDirectorioActual)
        Me.Controls.Add(Me.LabelDirectorioActual)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormInforme"
        Me.Text = "Informe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelDirectorioActual As System.Windows.Forms.Label
    Friend WithEvents TextoDirectorioActual As System.Windows.Forms.TextBox
    Friend WithEvents TextoNombreArchivo As System.Windows.Forms.TextBox
    Friend WithEvents LabelNombreArchivo As System.Windows.Forms.Label
    Friend WithEvents TextoNombreArchivoConExtension As System.Windows.Forms.TextBox
    Friend WithEvents LabelNombreArchivoConExtension As System.Windows.Forms.Label
    Friend WithEvents TextoLugarDelInforme As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BotonAchicaAgranda As System.Windows.Forms.Button
    Friend WithEvents TextoPathInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BotonTeclado As System.Windows.Forms.Button
End Class
