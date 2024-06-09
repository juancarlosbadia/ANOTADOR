<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Director
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Director))
        Me.BotonArriba = New System.Windows.Forms.Button
        Me.BotonRetrocede = New System.Windows.Forms.Button
        Me.TeclaEspacio = New System.Windows.Forms.Button
        Me.BotonPega = New System.Windows.Forms.Button
        Me.BotonCopia = New System.Windows.Forms.Button
        Me.BotonBorra = New System.Windows.Forms.Button
        Me.BotonEnter = New System.Windows.Forms.Button
        Me.BotonAbajo = New System.Windows.Forms.Button
        Me.BotonAvanza = New System.Windows.Forms.Button
        Me.BotonCentral = New System.Windows.Forms.Button
        Me.BotonTransparencia = New System.Windows.Forms.Button
        Me.BotonTeclado = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BotonMayusculasIniciales = New System.Windows.Forms.Button
        Me.BotonTodoMayMin = New System.Windows.Forms.Button
        Me.BotonAentuarDesacentuar = New System.Windows.Forms.Button
        Me.BotonTeclado2 = New System.Windows.Forms.Button
        Me.BotonGuarda = New System.Windows.Forms.Button
        Me.BotonColor = New System.Windows.Forms.Button
        Me.BotonFuente = New System.Windows.Forms.Button
        Me.BotonTam = New System.Windows.Forms.Button
        Me.BotonCuadro = New System.Windows.Forms.Button
        Me.BotonCorta = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'BotonArriba
        '
        Me.BotonArriba.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BotonArriba.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonArriba.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonArriba.Location = New System.Drawing.Point(38, 0)
        Me.BotonArriba.Name = "BotonArriba"
        Me.BotonArriba.Size = New System.Drawing.Size(38, 41)
        Me.BotonArriba.TabIndex = 96
        Me.BotonArriba.Text = "↑"
        Me.ToolTip1.SetToolTip(Me.BotonArriba, "• DESPLAZA EL CURSOR HACIA  ARIBA (Botón izquierdo)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• SELECCIONA HACIA ARRIBA  " & _
                "(Botón derecho).")
        Me.BotonArriba.UseVisualStyleBackColor = False
        '
        'BotonRetrocede
        '
        Me.BotonRetrocede.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BotonRetrocede.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonRetrocede.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonRetrocede.Location = New System.Drawing.Point(0, 41)
        Me.BotonRetrocede.Name = "BotonRetrocede"
        Me.BotonRetrocede.Size = New System.Drawing.Size(38, 41)
        Me.BotonRetrocede.TabIndex = 95
        Me.BotonRetrocede.Text = "←"
        Me.ToolTip1.SetToolTip(Me.BotonRetrocede, "• DESPLAZA EL CURSOR A LA IZQUIERDA (Botón izquierdo)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• SELECCIONA HACIA LA IZQ" & _
                "UIERDA  (Botón derecho).")
        Me.BotonRetrocede.UseVisualStyleBackColor = False
        '
        'TeclaEspacio
        '
        Me.TeclaEspacio.BackColor = System.Drawing.Color.White
        Me.TeclaEspacio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeclaEspacio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TeclaEspacio.Location = New System.Drawing.Point(0, 122)
        Me.TeclaEspacio.Name = "TeclaEspacio"
        Me.TeclaEspacio.Size = New System.Drawing.Size(112, 41)
        Me.TeclaEspacio.TabIndex = 94
        Me.TeclaEspacio.Text = "ESPACIO"
        Me.ToolTip1.SetToolTip(Me.TeclaEspacio, "• Espacio (Botón Izquierdo)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Borra retroceso (Botón Derecho)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• RUEDA DEL MOUSE" & _
                " COLOR FONDO  RGB")
        Me.TeclaEspacio.UseVisualStyleBackColor = False
        '
        'BotonPega
        '
        Me.BotonPega.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BotonPega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonPega.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonPega.Location = New System.Drawing.Point(112, 40)
        Me.BotonPega.Name = "BotonPega"
        Me.BotonPega.Size = New System.Drawing.Size(38, 41)
        Me.BotonPega.TabIndex = 93
        Me.BotonPega.Text = "P"
        Me.ToolTip1.SetToolTip(Me.BotonPega, "• PEGA el texto que se ha copiado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- desde el portapapeles del Anotador (Botón iz" & _
                "quierdo)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- desde el portapapeles de Windows (Botón derecho)")
        Me.BotonPega.UseVisualStyleBackColor = False
        '
        'BotonCopia
        '
        Me.BotonCopia.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BotonCopia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonCopia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonCopia.Location = New System.Drawing.Point(112, 0)
        Me.BotonCopia.Name = "BotonCopia"
        Me.BotonCopia.Size = New System.Drawing.Size(18, 41)
        Me.BotonCopia.TabIndex = 92
        Me.BotonCopia.Text = "C"
        Me.ToolTip1.SetToolTip(Me.BotonCopia, "• COPIA el texto seleccionado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Al portapapeles del Anotador (Botón izquierdo)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & _
                "- Al portapapeles de Windows (Botón derecho)")
        Me.BotonCopia.UseVisualStyleBackColor = False
        '
        'BotonBorra
        '
        Me.BotonBorra.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BotonBorra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonBorra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonBorra.Location = New System.Drawing.Point(17, 19)
        Me.BotonBorra.Name = "BotonBorra"
        Me.BotonBorra.Size = New System.Drawing.Size(21, 23)
        Me.BotonBorra.TabIndex = 91
        Me.BotonBorra.Text = "▓ "
        Me.ToolTip1.SetToolTip(Me.BotonBorra, "• BORRA el texto seleccionado." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Si no hay selección de texto:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- BORRA HACIA LA" & _
                " IZQUIERDA (Botón izquierdo);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- BORRA HACIA LA DERECHA (Botón derecho)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.BotonBorra.UseVisualStyleBackColor = False
        '
        'BotonEnter
        '
        Me.BotonEnter.BackColor = System.Drawing.Color.PeachPuff
        Me.BotonEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonEnter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonEnter.Location = New System.Drawing.Point(112, 119)
        Me.BotonEnter.Name = "BotonEnter"
        Me.BotonEnter.Size = New System.Drawing.Size(38, 41)
        Me.BotonEnter.TabIndex = 90
        Me.BotonEnter.Text = "┘"
        Me.ToolTip1.SetToolTip(Me.BotonEnter, "• Nueva línea" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.BotonEnter.UseVisualStyleBackColor = False
        '
        'BotonAbajo
        '
        Me.BotonAbajo.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BotonAbajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonAbajo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonAbajo.Location = New System.Drawing.Point(38, 81)
        Me.BotonAbajo.Name = "BotonAbajo"
        Me.BotonAbajo.Size = New System.Drawing.Size(38, 41)
        Me.BotonAbajo.TabIndex = 98
        Me.BotonAbajo.Text = "↓"
        Me.ToolTip1.SetToolTip(Me.BotonAbajo, "• DESPLAZA EL CURSOR HACIA  ABAJO (Botón izquierdo)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• SELECCIONA HACIA ABAJO  (" & _
                "Botón derecho).")
        Me.BotonAbajo.UseVisualStyleBackColor = False
        '
        'BotonAvanza
        '
        Me.BotonAvanza.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BotonAvanza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonAvanza.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonAvanza.Location = New System.Drawing.Point(75, 41)
        Me.BotonAvanza.Name = "BotonAvanza"
        Me.BotonAvanza.Size = New System.Drawing.Size(38, 41)
        Me.BotonAvanza.TabIndex = 99
        Me.BotonAvanza.Text = "→"
        Me.ToolTip1.SetToolTip(Me.BotonAvanza, "• DESPLAZA EL CURSOR A LA DERECHA (Botón izquierdo)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• SELECCIONA HACIA LA DEREC" & _
                "HA (Botón derecho).")
        Me.BotonAvanza.UseVisualStyleBackColor = False
        '
        'BotonCentral
        '
        Me.BotonCentral.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BotonCentral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonCentral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonCentral.Location = New System.Drawing.Point(38, 41)
        Me.BotonCentral.Name = "BotonCentral"
        Me.BotonCentral.Size = New System.Drawing.Size(38, 41)
        Me.BotonCentral.TabIndex = 100
        Me.BotonCentral.Text = "D"
        Me.ToolTip1.SetToolTip(Me.BotonCentral, "• DESHACER (Botón Izquierdo)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• SELECCIONA TODO  (Botón Derecho)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• RUEDA DEL MOU" & _
                "SE COLOR LETRA  RGB")
        Me.BotonCentral.UseVisualStyleBackColor = False
        '
        'BotonTransparencia
        '
        Me.BotonTransparencia.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BotonTransparencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonTransparencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonTransparencia.Location = New System.Drawing.Point(75, 80)
        Me.BotonTransparencia.Name = "BotonTransparencia"
        Me.BotonTransparencia.Size = New System.Drawing.Size(38, 41)
        Me.BotonTransparencia.TabIndex = 101
        Me.BotonTransparencia.Text = "TR"
        Me.ToolTip1.SetToolTip(Me.BotonTransparencia, "•TRANSPARENCIA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "— DISMINUYE (Botón izquierdo)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "— AUMENTA  (Botón derecho).")
        Me.BotonTransparencia.UseVisualStyleBackColor = False
        '
        'BotonTeclado
        '
        Me.BotonTeclado.BackColor = System.Drawing.Color.PeachPuff
        Me.BotonTeclado.BackgroundImage = Global.TXT.My.Resources.Resources.bolita02
        Me.BotonTeclado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BotonTeclado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonTeclado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonTeclado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonTeclado.Image = Global.TXT.My.Resources.Resources.bolita01
        Me.BotonTeclado.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BotonTeclado.Location = New System.Drawing.Point(20, -1)
        Me.BotonTeclado.Name = "BotonTeclado"
        Me.BotonTeclado.Size = New System.Drawing.Size(19, 20)
        Me.BotonTeclado.TabIndex = 102
        Me.ToolTip1.SetToolTip(Me.BotonTeclado, "• Minimiza / Expande Anotador (Botón Izquierdo)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Oculta Director  (Botón Derech" & _
                "o)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.BotonTeclado.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        '
        'BotonMayusculasIniciales
        '
        Me.BotonMayusculasIniciales.BackColor = System.Drawing.Color.Peru
        Me.BotonMayusculasIniciales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonMayusculasIniciales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonMayusculasIniciales.ForeColor = System.Drawing.Color.White
        Me.BotonMayusculasIniciales.Location = New System.Drawing.Point(0, 80)
        Me.BotonMayusculasIniciales.Name = "BotonMayusculasIniciales"
        Me.BotonMayusculasIniciales.Size = New System.Drawing.Size(18, 23)
        Me.BotonMayusculasIniciales.TabIndex = 103
        Me.BotonMayusculasIniciales.Text = "Mm"
        Me.ToolTip1.SetToolTip(Me.BotonMayusculasIniciales, "• Mayúsculas iniciales / minúsculas")
        Me.BotonMayusculasIniciales.UseVisualStyleBackColor = False
        '
        'BotonTodoMayMin
        '
        Me.BotonTodoMayMin.BackColor = System.Drawing.Color.Peru
        Me.BotonTodoMayMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonTodoMayMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonTodoMayMin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BotonTodoMayMin.Location = New System.Drawing.Point(20, 80)
        Me.BotonTodoMayMin.Name = "BotonTodoMayMin"
        Me.BotonTodoMayMin.Size = New System.Drawing.Size(18, 23)
        Me.BotonTodoMayMin.TabIndex = 104
        Me.BotonTodoMayMin.Text = "MM"
        Me.ToolTip1.SetToolTip(Me.BotonTodoMayMin, "• TODO MAYUSCULAS / minúsculas")
        Me.BotonTodoMayMin.UseVisualStyleBackColor = False
        '
        'BotonAentuarDesacentuar
        '
        Me.BotonAentuarDesacentuar.BackColor = System.Drawing.Color.Red
        Me.BotonAentuarDesacentuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonAentuarDesacentuar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonAentuarDesacentuar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BotonAentuarDesacentuar.Location = New System.Drawing.Point(0, 103)
        Me.BotonAentuarDesacentuar.Name = "BotonAentuarDesacentuar"
        Me.BotonAentuarDesacentuar.Size = New System.Drawing.Size(18, 19)
        Me.BotonAentuarDesacentuar.TabIndex = 105
        Me.BotonAentuarDesacentuar.Text = "`"
        Me.ToolTip1.SetToolTip(Me.BotonAentuarDesacentuar, "• Acentúa / Desacentúa")
        Me.BotonAentuarDesacentuar.UseVisualStyleBackColor = False
        '
        'BotonTeclado2
        '
        Me.BotonTeclado2.BackColor = System.Drawing.Color.SteelBlue
        Me.BotonTeclado2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonTeclado2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonTeclado2.ForeColor = System.Drawing.Color.Yellow
        Me.BotonTeclado2.Location = New System.Drawing.Point(0, 21)
        Me.BotonTeclado2.Name = "BotonTeclado2"
        Me.BotonTeclado2.Size = New System.Drawing.Size(18, 19)
        Me.BotonTeclado2.TabIndex = 106
        Me.BotonTeclado2.Text = "T"
        Me.ToolTip1.SetToolTip(Me.BotonTeclado2, "TECLADO")
        Me.BotonTeclado2.UseVisualStyleBackColor = False
        '
        'BotonGuarda
        '
        Me.BotonGuarda.BackColor = System.Drawing.Color.DeepPink
        Me.BotonGuarda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonGuarda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BotonGuarda.ForeColor = System.Drawing.Color.White
        Me.BotonGuarda.Location = New System.Drawing.Point(75, 0)
        Me.BotonGuarda.Name = "BotonGuarda"
        Me.BotonGuarda.Size = New System.Drawing.Size(18, 23)
        Me.BotonGuarda.TabIndex = 107
        Me.BotonGuarda.Text = "G"
        Me.ToolTip1.SetToolTip(Me.BotonGuarda, "• Guarda / Como")
        Me.BotonGuarda.UseVisualStyleBackColor = False
        '
        'BotonColor
        '
        Me.BotonColor.BackColor = System.Drawing.Color.DodgerBlue
        Me.BotonColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BotonColor.ForeColor = System.Drawing.Color.White
        Me.BotonColor.Location = New System.Drawing.Point(132, 98)
        Me.BotonColor.Name = "BotonColor"
        Me.BotonColor.Size = New System.Drawing.Size(18, 23)
        Me.BotonColor.TabIndex = 108
        Me.BotonColor.Text = "C"
        Me.ToolTip1.SetToolTip(Me.BotonColor, "• COLOR Letra/Fondo")
        Me.BotonColor.UseVisualStyleBackColor = False
        '
        'BotonFuente
        '
        Me.BotonFuente.BackColor = System.Drawing.Color.Peru
        Me.BotonFuente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonFuente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonFuente.ForeColor = System.Drawing.Color.White
        Me.BotonFuente.Location = New System.Drawing.Point(112, 80)
        Me.BotonFuente.Name = "BotonFuente"
        Me.BotonFuente.Size = New System.Drawing.Size(18, 23)
        Me.BotonFuente.TabIndex = 109
        Me.BotonFuente.Text = "F"
        Me.ToolTip1.SetToolTip(Me.BotonFuente, "• ALTERNA TIPO FUENTE")
        Me.BotonFuente.UseVisualStyleBackColor = False
        '
        'BotonTam
        '
        Me.BotonTam.BackColor = System.Drawing.Color.Coral
        Me.BotonTam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonTam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonTam.ForeColor = System.Drawing.Color.White
        Me.BotonTam.Location = New System.Drawing.Point(112, 98)
        Me.BotonTam.Name = "BotonTam"
        Me.BotonTam.Size = New System.Drawing.Size(18, 23)
        Me.BotonTam.TabIndex = 111
        Me.BotonTam.Text = "+"
        Me.ToolTip1.SetToolTip(Me.BotonTam, "• TAMAÑO FUENTE -/+")
        Me.BotonTam.UseVisualStyleBackColor = False
        '
        'BotonCuadro
        '
        Me.BotonCuadro.BackColor = System.Drawing.Color.PowderBlue
        Me.BotonCuadro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonCuadro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonCuadro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonCuadro.Location = New System.Drawing.Point(132, 80)
        Me.BotonCuadro.Name = "BotonCuadro"
        Me.BotonCuadro.Size = New System.Drawing.Size(18, 23)
        Me.BotonCuadro.TabIndex = 112
        Me.BotonCuadro.Text = "C"
        Me.ToolTip1.SetToolTip(Me.BotonCuadro, "• CUADRO -/+")
        Me.BotonCuadro.UseVisualStyleBackColor = False
        '
        'BotonCorta
        '
        Me.BotonCorta.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BotonCorta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonCorta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonCorta.Location = New System.Drawing.Point(132, 1)
        Me.BotonCorta.Name = "BotonCorta"
        Me.BotonCorta.Size = New System.Drawing.Size(18, 41)
        Me.BotonCorta.TabIndex = 113
        Me.BotonCorta.Text = "X"
        Me.ToolTip1.SetToolTip(Me.BotonCorta, "• CORTA el texto seleccionado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Al portapapeles del Anotador (Botón izquierdo)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & _
                "- Al portapapeles de Windows (Botón derecho)")
        Me.BotonCorta.UseVisualStyleBackColor = False
        '
        'Director
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(156, 169)
        Me.ControlBox = False
        Me.Controls.Add(Me.BotonCorta)
        Me.Controls.Add(Me.BotonCuadro)
        Me.Controls.Add(Me.BotonTam)
        Me.Controls.Add(Me.BotonFuente)
        Me.Controls.Add(Me.BotonColor)
        Me.Controls.Add(Me.BotonGuarda)
        Me.Controls.Add(Me.BotonTeclado2)
        Me.Controls.Add(Me.BotonAentuarDesacentuar)
        Me.Controls.Add(Me.BotonTodoMayMin)
        Me.Controls.Add(Me.BotonMayusculasIniciales)
        Me.Controls.Add(Me.BotonTeclado)
        Me.Controls.Add(Me.BotonTransparencia)
        Me.Controls.Add(Me.BotonCentral)
        Me.Controls.Add(Me.BotonAvanza)
        Me.Controls.Add(Me.BotonAbajo)
        Me.Controls.Add(Me.BotonArriba)
        Me.Controls.Add(Me.BotonRetrocede)
        Me.Controls.Add(Me.TeclaEspacio)
        Me.Controls.Add(Me.BotonPega)
        Me.Controls.Add(Me.BotonCopia)
        Me.Controls.Add(Me.BotonBorra)
        Me.Controls.Add(Me.BotonEnter)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Director"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BotonArriba As System.Windows.Forms.Button
    Friend WithEvents BotonRetrocede As System.Windows.Forms.Button
    Friend WithEvents TeclaEspacio As System.Windows.Forms.Button
    Friend WithEvents BotonPega As System.Windows.Forms.Button
    Friend WithEvents BotonCopia As System.Windows.Forms.Button
    Friend WithEvents BotonBorra As System.Windows.Forms.Button
    Friend WithEvents BotonEnter As System.Windows.Forms.Button
    Friend WithEvents BotonAbajo As System.Windows.Forms.Button
    Friend WithEvents BotonAvanza As System.Windows.Forms.Button
    Friend WithEvents BotonCentral As System.Windows.Forms.Button
    Friend WithEvents BotonTransparencia As System.Windows.Forms.Button
    Friend WithEvents BotonTeclado As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BotonMayusculasIniciales As System.Windows.Forms.Button
    Friend WithEvents BotonTodoMayMin As System.Windows.Forms.Button
    Friend WithEvents BotonAentuarDesacentuar As System.Windows.Forms.Button
    Friend WithEvents BotonTeclado2 As System.Windows.Forms.Button
    Friend WithEvents BotonGuarda As System.Windows.Forms.Button
    Friend WithEvents BotonColor As System.Windows.Forms.Button
    Friend WithEvents BotonFuente As System.Windows.Forms.Button
    Friend WithEvents BotonTam As System.Windows.Forms.Button
    Friend WithEvents BotonCuadro As System.Windows.Forms.Button
    Friend WithEvents BotonCorta As System.Windows.Forms.Button
End Class
