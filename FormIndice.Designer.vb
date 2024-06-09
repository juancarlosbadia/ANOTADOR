<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIndice
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormIndice))
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.ListaArchivo = New System.Windows.Forms.ComboBox
        Me.TextoNombreDeArchivo = New System.Windows.Forms.TextBox
        Me.TextoNumReg = New System.Windows.Forms.TextBox
        Me.TextoNumSel = New System.Windows.Forms.TextBox
        Me.TextoComentarios = New System.Windows.Forms.TextBox
        Me.TextoNombreDeRegistro = New System.Windows.Forms.TextBox
        Me.BotonAbre = New System.Windows.Forms.Button
        Me.BotonCrea = New System.Windows.Forms.Button
        Me.BotonLee = New System.Windows.Forms.Button
        Me.BotonAgrega = New System.Windows.Forms.Button
        Me.BotonInserta = New System.Windows.Forms.Button
        Me.BotonBorra = New System.Windows.Forms.Button
        Me.BotonModifica = New System.Windows.Forms.Button
        Me.BotonAbreArchivo = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.AclaraIndices = New System.Windows.Forms.ToolTip(Me.components)
        Me.BotonReservaTextoItem = New System.Windows.Forms.Button
        Me.BotonRestauraTextoItem = New System.Windows.Forms.Button
        Me.BotonRestauraComentarioItem = New System.Windows.Forms.Button
        Me.BotonReservaComentarioItem = New System.Windows.Forms.Button
        Me.BotonBorraComentarioItem = New System.Windows.Forms.Button
        Me.BotonBorraTextoItem = New System.Windows.Forms.Button
        Me.BotonTeclado = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextoExtraeDirectorio = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.BotonAjusta = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ListaArchivo
        '
        Me.ListaArchivo.DropDownHeight = 200
        Me.ListaArchivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListaArchivo.DropDownWidth = 1200
        Me.ListaArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ListaArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaArchivo.FormattingEnabled = True
        Me.ListaArchivo.IntegralHeight = False
        Me.ListaArchivo.Location = New System.Drawing.Point(1, 65)
        Me.ListaArchivo.Name = "ListaArchivo"
        Me.ListaArchivo.Size = New System.Drawing.Size(373, 28)
        Me.ListaArchivo.TabIndex = 0
        Me.AclaraIndices.SetToolTip(Me.ListaArchivo, "• Listado de documentos")
        '
        'TextoNombreDeArchivo
        '
        Me.TextoNombreDeArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoNombreDeArchivo.Location = New System.Drawing.Point(0, 1)
        Me.TextoNombreDeArchivo.Multiline = True
        Me.TextoNombreDeArchivo.Name = "TextoNombreDeArchivo"
        Me.TextoNombreDeArchivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextoNombreDeArchivo.Size = New System.Drawing.Size(305, 32)
        Me.TextoNombreDeArchivo.TabIndex = 1
        Me.AclaraIndices.SetToolTip(Me.TextoNombreDeArchivo, "• Archivo de índice")
        '
        'TextoNumReg
        '
        Me.TextoNumReg.Location = New System.Drawing.Point(382, 39)
        Me.TextoNumReg.Name = "TextoNumReg"
        Me.TextoNumReg.Size = New System.Drawing.Size(60, 22)
        Me.TextoNumReg.TabIndex = 2
        Me.AclaraIndices.SetToolTip(Me.TextoNumReg, "• Número de registro (comienza en cero)")
        '
        'TextoNumSel
        '
        Me.TextoNumSel.Location = New System.Drawing.Point(446, 39)
        Me.TextoNumSel.Name = "TextoNumSel"
        Me.TextoNumSel.Size = New System.Drawing.Size(57, 22)
        Me.TextoNumSel.TabIndex = 3
        Me.AclaraIndices.SetToolTip(Me.TextoNumSel, "• Número de la Entrada seleccionada")
        '
        'TextoComentarios
        '
        Me.TextoComentarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoComentarios.Location = New System.Drawing.Point(1, 223)
        Me.TextoComentarios.Multiline = True
        Me.TextoComentarios.Name = "TextoComentarios"
        Me.TextoComentarios.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextoComentarios.Size = New System.Drawing.Size(342, 67)
        Me.TextoComentarios.TabIndex = 4
        Me.AclaraIndices.SetToolTip(Me.TextoComentarios, "• Comentarios: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Es un cuadro editable." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Su contenido se puede guardar en " & _
                "un registro." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Cuando se trae un archivo abierto en el Anotador," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     se cop" & _
                "ian aquí los primeros 255 caracteres.")
        '
        'TextoNombreDeRegistro
        '
        Me.TextoNombreDeRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoNombreDeRegistro.Location = New System.Drawing.Point(0, 95)
        Me.TextoNombreDeRegistro.Multiline = True
        Me.TextoNombreDeRegistro.Name = "TextoNombreDeRegistro"
        Me.TextoNombreDeRegistro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextoNombreDeRegistro.Size = New System.Drawing.Size(343, 52)
        Me.TextoNombreDeRegistro.TabIndex = 5
        Me.AclaraIndices.SetToolTip(Me.TextoNombreDeRegistro, "• Ruta a guardar o a abrir:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "— Ruta completa a una carpeta." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "— Ruta completa a un" & _
                " archivo de texto." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Es un cuadro editable." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Su contenido se puede guardar en " & _
                "un registro)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'BotonAbre
        '
        Me.BotonAbre.BackColor = System.Drawing.Color.Cornsilk
        Me.BotonAbre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonAbre.Location = New System.Drawing.Point(54, 39)
        Me.BotonAbre.Name = "BotonAbre"
        Me.BotonAbre.Size = New System.Drawing.Size(57, 25)
        Me.BotonAbre.TabIndex = 6
        Me.BotonAbre.Text = "Abre"
        Me.AclaraIndices.SetToolTip(Me.BotonAbre, "• Abre un índice existente")
        Me.BotonAbre.UseVisualStyleBackColor = False
        '
        'BotonCrea
        '
        Me.BotonCrea.BackColor = System.Drawing.Color.Cornsilk
        Me.BotonCrea.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonCrea.Location = New System.Drawing.Point(0, 39)
        Me.BotonCrea.Name = "BotonCrea"
        Me.BotonCrea.Size = New System.Drawing.Size(54, 25)
        Me.BotonCrea.TabIndex = 7
        Me.BotonCrea.Text = "Crea"
        Me.AclaraIndices.SetToolTip(Me.BotonCrea, "• Crea un nuevo índice con el nombre que se asigne" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    en el cuadro Archivo de Í" & _
                "ndice." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Si ese cuadro está vacío pone un nombre aleatorio.")
        Me.BotonCrea.UseVisualStyleBackColor = False
        '
        'BotonLee
        '
        Me.BotonLee.BackColor = System.Drawing.Color.Cornsilk
        Me.BotonLee.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonLee.Location = New System.Drawing.Point(111, 39)
        Me.BotonLee.Name = "BotonLee"
        Me.BotonLee.Size = New System.Drawing.Size(45, 25)
        Me.BotonLee.TabIndex = 8
        Me.BotonLee.Text = "Lee"
        Me.AclaraIndices.SetToolTip(Me.BotonLee, "• Lee el índice actual")
        Me.BotonLee.UseVisualStyleBackColor = False
        '
        'BotonAgrega
        '
        Me.BotonAgrega.BackColor = System.Drawing.Color.Cornsilk
        Me.BotonAgrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonAgrega.Location = New System.Drawing.Point(156, 39)
        Me.BotonAgrega.Name = "BotonAgrega"
        Me.BotonAgrega.Size = New System.Drawing.Size(45, 25)
        Me.BotonAgrega.TabIndex = 9
        Me.BotonAgrega.Text = "Agr."
        Me.AclaraIndices.SetToolTip(Me.BotonAgrega, "• Agrega documento al índice")
        Me.BotonAgrega.UseVisualStyleBackColor = False
        '
        'BotonInserta
        '
        Me.BotonInserta.BackColor = System.Drawing.Color.Cornsilk
        Me.BotonInserta.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonInserta.Location = New System.Drawing.Point(201, 39)
        Me.BotonInserta.Name = "BotonInserta"
        Me.BotonInserta.Size = New System.Drawing.Size(38, 25)
        Me.BotonInserta.TabIndex = 10
        Me.BotonInserta.Text = "Ins."
        Me.AclaraIndices.SetToolTip(Me.BotonInserta, "• Intercala documento en el índice")
        Me.BotonInserta.UseVisualStyleBackColor = False
        '
        'BotonBorra
        '
        Me.BotonBorra.BackColor = System.Drawing.Color.Cornsilk
        Me.BotonBorra.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonBorra.Location = New System.Drawing.Point(294, 39)
        Me.BotonBorra.Name = "BotonBorra"
        Me.BotonBorra.Size = New System.Drawing.Size(79, 25)
        Me.BotonBorra.TabIndex = 11
        Me.BotonBorra.Text = "Borra"
        Me.AclaraIndices.SetToolTip(Me.BotonBorra, "• Borra entrada seleccionada")
        Me.BotonBorra.UseVisualStyleBackColor = False
        '
        'BotonModifica
        '
        Me.BotonModifica.BackColor = System.Drawing.Color.Cornsilk
        Me.BotonModifica.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonModifica.Location = New System.Drawing.Point(239, 39)
        Me.BotonModifica.Name = "BotonModifica"
        Me.BotonModifica.Size = New System.Drawing.Size(55, 25)
        Me.BotonModifica.TabIndex = 12
        Me.BotonModifica.Text = "Mod"
        Me.AclaraIndices.SetToolTip(Me.BotonModifica, "• Modifica entrada seleccionada")
        Me.BotonModifica.UseVisualStyleBackColor = False
        '
        'BotonAbreArchivo
        '
        Me.BotonAbreArchivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BotonAbreArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonAbreArchivo.Location = New System.Drawing.Point(145, 152)
        Me.BotonAbreArchivo.Name = "BotonAbreArchivo"
        Me.BotonAbreArchivo.Size = New System.Drawing.Size(76, 24)
        Me.BotonAbreArchivo.TabIndex = 13
        Me.BotonAbreArchivo.Text = "Abre"
        Me.AclaraIndices.SetToolTip(Me.BotonAbreArchivo, resources.GetString("BotonAbreArchivo.ToolTip"))
        Me.BotonAbreArchivo.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(6, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 24)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Trae"
        Me.AclaraIndices.SetToolTip(Me.Button1, "• Trae directorio, nombre y datos " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    del documento actual.")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AclaraIndices
        '
        Me.AclaraIndices.AutoPopDelay = 25000
        Me.AclaraIndices.InitialDelay = 500
        Me.AclaraIndices.IsBalloon = True
        Me.AclaraIndices.ReshowDelay = 100
        Me.AclaraIndices.ShowAlways = True
        '
        'BotonReservaTextoItem
        '
        Me.BotonReservaTextoItem.BackColor = System.Drawing.Color.Cornsilk
        Me.BotonReservaTextoItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonReservaTextoItem.Location = New System.Drawing.Point(349, 126)
        Me.BotonReservaTextoItem.Name = "BotonReservaTextoItem"
        Me.BotonReservaTextoItem.Size = New System.Drawing.Size(25, 22)
        Me.BotonReservaTextoItem.TabIndex = 16
        Me.BotonReservaTextoItem.Text = "G"
        Me.AclaraIndices.SetToolTip(Me.BotonReservaTextoItem, "• Memoriza el contenido actual.")
        Me.BotonReservaTextoItem.UseVisualStyleBackColor = False
        '
        'BotonRestauraTextoItem
        '
        Me.BotonRestauraTextoItem.BackColor = System.Drawing.Color.Honeydew
        Me.BotonRestauraTextoItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonRestauraTextoItem.Location = New System.Drawing.Point(348, 148)
        Me.BotonRestauraTextoItem.Name = "BotonRestauraTextoItem"
        Me.BotonRestauraTextoItem.Size = New System.Drawing.Size(25, 22)
        Me.BotonRestauraTextoItem.TabIndex = 17
        Me.BotonRestauraTextoItem.Text = "R"
        Me.AclaraIndices.SetToolTip(Me.BotonRestauraTextoItem, "• Restaura el contenido memorizado,")
        Me.BotonRestauraTextoItem.UseVisualStyleBackColor = False
        '
        'BotonRestauraComentarioItem
        '
        Me.BotonRestauraComentarioItem.BackColor = System.Drawing.Color.Honeydew
        Me.BotonRestauraComentarioItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonRestauraComentarioItem.Location = New System.Drawing.Point(348, 268)
        Me.BotonRestauraComentarioItem.Name = "BotonRestauraComentarioItem"
        Me.BotonRestauraComentarioItem.Size = New System.Drawing.Size(25, 22)
        Me.BotonRestauraComentarioItem.TabIndex = 19
        Me.BotonRestauraComentarioItem.Text = "R"
        Me.AclaraIndices.SetToolTip(Me.BotonRestauraComentarioItem, "• Restaura el contenido memorizado.")
        Me.BotonRestauraComentarioItem.UseVisualStyleBackColor = False
        '
        'BotonReservaComentarioItem
        '
        Me.BotonReservaComentarioItem.BackColor = System.Drawing.Color.Cornsilk
        Me.BotonReservaComentarioItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonReservaComentarioItem.Location = New System.Drawing.Point(348, 246)
        Me.BotonReservaComentarioItem.Name = "BotonReservaComentarioItem"
        Me.BotonReservaComentarioItem.Size = New System.Drawing.Size(25, 22)
        Me.BotonReservaComentarioItem.TabIndex = 18
        Me.BotonReservaComentarioItem.Text = "G"
        Me.AclaraIndices.SetToolTip(Me.BotonReservaComentarioItem, "• Memoriza el contenido actual.")
        Me.BotonReservaComentarioItem.UseVisualStyleBackColor = False
        '
        'BotonBorraComentarioItem
        '
        Me.BotonBorraComentarioItem.BackColor = System.Drawing.Color.Orange
        Me.BotonBorraComentarioItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonBorraComentarioItem.Location = New System.Drawing.Point(348, 224)
        Me.BotonBorraComentarioItem.Name = "BotonBorraComentarioItem"
        Me.BotonBorraComentarioItem.Size = New System.Drawing.Size(25, 22)
        Me.BotonBorraComentarioItem.TabIndex = 20
        Me.BotonBorraComentarioItem.Text = "B"
        Me.AclaraIndices.SetToolTip(Me.BotonBorraComentarioItem, "• Borra contenido. ")
        Me.BotonBorraComentarioItem.UseVisualStyleBackColor = False
        '
        'BotonBorraTextoItem
        '
        Me.BotonBorraTextoItem.BackColor = System.Drawing.Color.Orange
        Me.BotonBorraTextoItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonBorraTextoItem.Location = New System.Drawing.Point(349, 104)
        Me.BotonBorraTextoItem.Name = "BotonBorraTextoItem"
        Me.BotonBorraTextoItem.Size = New System.Drawing.Size(25, 22)
        Me.BotonBorraTextoItem.TabIndex = 21
        Me.BotonBorraTextoItem.Text = "B"
        Me.AclaraIndices.SetToolTip(Me.BotonBorraTextoItem, "• Borra contenido.")
        Me.BotonBorraTextoItem.UseVisualStyleBackColor = False
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
        Me.BotonTeclado.Location = New System.Drawing.Point(343, 1)
        Me.BotonTeclado.Margin = New System.Windows.Forms.Padding(4)
        Me.BotonTeclado.Name = "BotonTeclado"
        Me.BotonTeclado.Size = New System.Drawing.Size(30, 30)
        Me.BotonTeclado.TabIndex = 71
        Me.AclaraIndices.SetToolTip(Me.BotonTeclado, "• Minimiza / Expande Anotador (Botón Izquierdo)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Oculta Indices  (Botón Derecho" & _
                ")")
        Me.BotonTeclado.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(226, 152)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 24)
        Me.Button2.TabIndex = 72
        Me.Button2.Text = "Abre Externo"
        Me.AclaraIndices.SetToolTip(Me.Button2, resources.GetString("Button2.ToolTip"))
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextoExtraeDirectorio
        '
        Me.TextoExtraeDirectorio.BackColor = System.Drawing.Color.Azure
        Me.TextoExtraeDirectorio.Location = New System.Drawing.Point(-3, 175)
        Me.TextoExtraeDirectorio.Name = "TextoExtraeDirectorio"
        Me.TextoExtraeDirectorio.Size = New System.Drawing.Size(373, 22)
        Me.TextoExtraeDirectorio.TabIndex = 73
        Me.AclaraIndices.SetToolTip(Me.TextoExtraeDirectorio, resources.GetString("TextoExtraeDirectorio.ToolTip"))
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(258, 199)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 24)
        Me.Button3.TabIndex = 74
        Me.Button3.Text = "Explora Dir"
        Me.AclaraIndices.SetToolTip(Me.Button3, "• Explora Directorio con el Explorador de Windows." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Permite abrir las rutas de " & _
                "ítems que estén registrados como archivos." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Toma la ruta desde la línea Direc" & _
                "torio Extraído.")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(187, 199)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(65, 24)
        Me.Button4.TabIndex = 75
        Me.Button4.Text = "Comp"
        Me.AclaraIndices.SetToolTip(Me.Button4, "• Compone la ruta a guardar o abrir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Antepone el directorio  de Extrae Direc" & _
                "torio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     al nombre de archivo del  cuadro de ruta." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     (Borrar el directori" & _
                "o primero, y luego componer)")
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(69, 152)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(70, 24)
        Me.Button5.TabIndex = 76
        Me.Button5.Text = "Guarda"
        Me.AclaraIndices.SetToolTip(Me.Button5, "• GUARDA EL TEXTO DEL DOCUMENTO ACTUAL," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    en la ruta y con el nombre del cuadr" & _
                "o de ruta.")
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(-3, 199)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(86, 24)
        Me.Button6.TabIndex = 77
        Me.Button6.Text = "Toma Dir"
        Me.AclaraIndices.SetToolTip(Me.Button6, "• Toma el directorio del cuadro Extrae Directorio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    y lo asigna como DIRECTORI" & _
                "O ACTUAL del Anotador.")
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Violet
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(89, 199)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(92, 24)
        Me.Button7.TabIndex = 78
        Me.Button7.Text = "Crea Dir"
        Me.AclaraIndices.SetToolTip(Me.Button7, "• Crea un nuevo Directorio con el Explorador de Windows." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Toma la ruta desde" & _
                " la línea Directorio Extraído.")
        Me.Button7.UseVisualStyleBackColor = False
        '
        'BotonAjusta
        '
        Me.BotonAjusta.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BotonAjusta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonAjusta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonAjusta.Location = New System.Drawing.Point(310, 2)
        Me.BotonAjusta.Margin = New System.Windows.Forms.Padding(4)
        Me.BotonAjusta.Name = "BotonAjusta"
        Me.BotonAjusta.Size = New System.Drawing.Size(30, 30)
        Me.BotonAjusta.TabIndex = 123
        Me.BotonAjusta.Text = "X"
        Me.AclaraIndices.SetToolTip(Me.BotonAjusta, "• Expande/Retrae el formulario")
        Me.BotonAjusta.UseVisualStyleBackColor = False
        '
        'FormIndice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(374, 290)
        Me.Controls.Add(Me.BotonAjusta)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextoExtraeDirectorio)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BotonTeclado)
        Me.Controls.Add(Me.BotonBorraTextoItem)
        Me.Controls.Add(Me.BotonBorraComentarioItem)
        Me.Controls.Add(Me.BotonRestauraComentarioItem)
        Me.Controls.Add(Me.BotonReservaComentarioItem)
        Me.Controls.Add(Me.BotonRestauraTextoItem)
        Me.Controls.Add(Me.BotonReservaTextoItem)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BotonAbreArchivo)
        Me.Controls.Add(Me.BotonModifica)
        Me.Controls.Add(Me.BotonBorra)
        Me.Controls.Add(Me.BotonInserta)
        Me.Controls.Add(Me.BotonAgrega)
        Me.Controls.Add(Me.BotonLee)
        Me.Controls.Add(Me.BotonCrea)
        Me.Controls.Add(Me.BotonAbre)
        Me.Controls.Add(Me.TextoNombreDeRegistro)
        Me.Controls.Add(Me.TextoComentarios)
        Me.Controls.Add(Me.TextoNumSel)
        Me.Controls.Add(Me.TextoNumReg)
        Me.Controls.Add(Me.TextoNombreDeArchivo)
        Me.Controls.Add(Me.ListaArchivo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormIndice"
        Me.Text = "Gestor de Índices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ListaArchivo As System.Windows.Forms.ComboBox
    Friend WithEvents TextoNombreDeArchivo As System.Windows.Forms.TextBox
    Friend WithEvents TextoNumReg As System.Windows.Forms.TextBox
    Friend WithEvents TextoNumSel As System.Windows.Forms.TextBox
    Friend WithEvents TextoComentarios As System.Windows.Forms.TextBox
    Friend WithEvents TextoNombreDeRegistro As System.Windows.Forms.TextBox
    Friend WithEvents BotonAbre As System.Windows.Forms.Button
    Friend WithEvents BotonCrea As System.Windows.Forms.Button
    Friend WithEvents BotonLee As System.Windows.Forms.Button
    Friend WithEvents BotonAgrega As System.Windows.Forms.Button
    Friend WithEvents BotonInserta As System.Windows.Forms.Button
    Friend WithEvents BotonBorra As System.Windows.Forms.Button
    Friend WithEvents BotonModifica As System.Windows.Forms.Button
    Friend WithEvents BotonAbreArchivo As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AclaraIndices As System.Windows.Forms.ToolTip
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents BotonReservaTextoItem As System.Windows.Forms.Button
    Friend WithEvents BotonRestauraTextoItem As System.Windows.Forms.Button
    Friend WithEvents BotonRestauraComentarioItem As System.Windows.Forms.Button
    Friend WithEvents BotonReservaComentarioItem As System.Windows.Forms.Button
    Friend WithEvents BotonBorraComentarioItem As System.Windows.Forms.Button
    Friend WithEvents BotonBorraTextoItem As System.Windows.Forms.Button
    Friend WithEvents BotonTeclado As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextoExtraeDirectorio As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents BotonAjusta As System.Windows.Forms.Button
End Class
