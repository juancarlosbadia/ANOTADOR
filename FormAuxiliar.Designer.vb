<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAuxiliar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAuxiliar))
        Me.TextoBuscar2 = New System.Windows.Forms.ComboBox
        Me.TextoReemplazar2 = New System.Windows.Forms.ComboBox
        Me.TextoReemplazar1 = New System.Windows.Forms.ComboBox
        Me.TextoBuscar1 = New System.Windows.Forms.ComboBox
        Me.BotonTransparencia = New System.Windows.Forms.Button
        Me.TextoVelocidadRepeticion = New System.Windows.Forms.ComboBox
        Me.BotonReemplazar = New System.Windows.Forms.Button
        Me.CheckSonido = New System.Windows.Forms.CheckBox
        Me.CheckDisparoAuto = New System.Windows.Forms.CheckBox
        Me.TextoVelocidadDisparo = New System.Windows.Forms.ComboBox
        Me.BotonAcentuarDesacentuar = New System.Windows.Forms.Button
        Me.BotonRepiteRecorte = New System.Windows.Forms.Button
        Me.BotonLeeRecortes = New System.Windows.Forms.Button
        Me.ListaRecortes = New System.Windows.Forms.ComboBox
        Me.BotonQuitaEspacios = New System.Windows.Forms.Button
        Me.BotonTodoMayMin = New System.Windows.Forms.Button
        Me.BotonRepiteAscii = New System.Windows.Forms.Button
        Me.ListaAsciiComentado = New System.Windows.Forms.ComboBox
        Me.BotonMayusculasIniciales = New System.Windows.Forms.Button
        Me.BotonRepìtePredeterminado = New System.Windows.Forms.Button
        Me.ListaPredeterminados = New System.Windows.Forms.ComboBox
        Me.Aclaraciones = New System.Windows.Forms.ToolTip(Me.components)
        Me.BotonBusca1 = New System.Windows.Forms.Button
        Me.BotonBusca2 = New System.Windows.Forms.Button
        Me.BotonAjusta = New System.Windows.Forms.Button
        Me.CheckAcento = New System.Windows.Forms.CheckBox
        Me.CheckMay1 = New System.Windows.Forms.CheckBox
        Me.CheckMay2 = New System.Windows.Forms.CheckBox
        Me.CheckMin = New System.Windows.Forms.CheckBox
        Me.TextoAscii = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextoReemplazar0 = New System.Windows.Forms.ComboBox
        Me.BotonTeclado = New System.Windows.Forms.Button
        Me.Checkeys = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'TextoBuscar2
        '
        Me.TextoBuscar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextoBuscar2.DropDownWidth = 400
        Me.TextoBuscar2.FormattingEnabled = True
        Me.TextoBuscar2.Items.AddRange(New Object() {"", "(RETORNO DE CARRO)", "(NUEVA LINEA)", "(RETORNO DE CARRO - NUEVA LINEA)", "(ESPACIO)", "*_", "_*", "*"})
        Me.TextoBuscar2.Location = New System.Drawing.Point(2, 22)
        Me.TextoBuscar2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextoBuscar2.Name = "TextoBuscar2"
        Me.TextoBuscar2.Size = New System.Drawing.Size(240, 21)
        Me.TextoBuscar2.TabIndex = 115
        Me.Aclaraciones.SetToolTip(Me.TextoBuscar2, "Texto a buscar o a reemplazar 2")
        '
        'TextoReemplazar2
        '
        Me.TextoReemplazar2.DropDownWidth = 400
        Me.TextoReemplazar2.FormattingEnabled = True
        Me.TextoReemplazar2.Items.AddRange(New Object() {"", "(RETORNO DE CARRO)", "(NUEVA LINEA)", "(RETORNO DE CARRO - NUEVA LINEA)", "(ESPACIO)", "*_", "_*", "*"})
        Me.TextoReemplazar2.Location = New System.Drawing.Point(2, 85)
        Me.TextoReemplazar2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextoReemplazar2.Name = "TextoReemplazar2"
        Me.TextoReemplazar2.Size = New System.Drawing.Size(240, 21)
        Me.TextoReemplazar2.TabIndex = 114
        Me.Aclaraciones.SetToolTip(Me.TextoReemplazar2, "Texto de reemplazo 2")
        '
        'TextoReemplazar1
        '
        Me.TextoReemplazar1.DropDownWidth = 400
        Me.TextoReemplazar1.FormattingEnabled = True
        Me.TextoReemplazar1.Items.AddRange(New Object() {"", "(RETORNO DE CARRO)", "(NUEVA LINEA)", "(RETORNO DE CARRO - NUEVA LINEA)", "(ESPACIO)", "*_", "_*", "*"})
        Me.TextoReemplazar1.Location = New System.Drawing.Point(2, 66)
        Me.TextoReemplazar1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextoReemplazar1.Name = "TextoReemplazar1"
        Me.TextoReemplazar1.Size = New System.Drawing.Size(240, 21)
        Me.TextoReemplazar1.TabIndex = 113
        Me.Aclaraciones.SetToolTip(Me.TextoReemplazar1, "Texto de reemplazo 1")
        '
        'TextoBuscar1
        '
        Me.TextoBuscar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextoBuscar1.DropDownWidth = 400
        Me.TextoBuscar1.FormattingEnabled = True
        Me.TextoBuscar1.Items.AddRange(New Object() {"", "(RETORNO DE CARRO)", "(NUEVA LINEA)", "(RETORNO DE CARRO - NUEVA LINEA)", "(ESPACIO)", "*_", "_*", "*"})
        Me.TextoBuscar1.Location = New System.Drawing.Point(2, 2)
        Me.TextoBuscar1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextoBuscar1.Name = "TextoBuscar1"
        Me.TextoBuscar1.Size = New System.Drawing.Size(240, 21)
        Me.TextoBuscar1.TabIndex = 112
        Me.Aclaraciones.SetToolTip(Me.TextoBuscar1, "Texto a buscar o a reemplazar 1")
        '
        'BotonTransparencia
        '
        Me.BotonTransparencia.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BotonTransparencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonTransparencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonTransparencia.Location = New System.Drawing.Point(4, 116)
        Me.BotonTransparencia.Name = "BotonTransparencia"
        Me.BotonTransparencia.Size = New System.Drawing.Size(94, 27)
        Me.BotonTransparencia.TabIndex = 111
        Me.BotonTransparencia.Text = "Transp."
        Me.Aclaraciones.SetToolTip(Me.BotonTransparencia, "• TRANSPARENCIA DEL TECLADO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "— Más opaco (Botón izquierdo)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "— Más transparente (B" & _
                "otón derecho)")
        Me.BotonTransparencia.UseVisualStyleBackColor = False
        '
        'TextoVelocidadRepeticion
        '
        Me.TextoVelocidadRepeticion.BackColor = System.Drawing.Color.White
        Me.TextoVelocidadRepeticion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoVelocidadRepeticion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextoVelocidadRepeticion.FormattingEnabled = True
        Me.TextoVelocidadRepeticion.Items.AddRange(New Object() {"50", "100", "110", "120", "130", "140", "150", "160", "170", "180", "190", "200", "210", "220", "230", "240", "250", "300", "350", "400", "450", "500", "550", "600", "650", "700", "750", "800", "850", "900", "950", "1000", "1100", "1200", "1300", "1400", "1500", "1600", "1700", "1800", "1900", "2000"})
        Me.TextoVelocidadRepeticion.Location = New System.Drawing.Point(2, 300)
        Me.TextoVelocidadRepeticion.Name = "TextoVelocidadRepeticion"
        Me.TextoVelocidadRepeticion.Size = New System.Drawing.Size(96, 28)
        Me.TextoVelocidadRepeticion.TabIndex = 110
        Me.TextoVelocidadRepeticion.Text = "150"
        Me.Aclaraciones.SetToolTip(Me.TextoVelocidadRepeticion, "• Retardo para repeticiones de teclado")
        '
        'BotonReemplazar
        '
        Me.BotonReemplazar.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BotonReemplazar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonReemplazar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonReemplazar.Location = New System.Drawing.Point(248, 52)
        Me.BotonReemplazar.Name = "BotonReemplazar"
        Me.BotonReemplazar.Size = New System.Drawing.Size(30, 53)
        Me.BotonReemplazar.TabIndex = 108
        Me.BotonReemplazar.Text = "R"
        Me.Aclaraciones.SetToolTip(Me.BotonReemplazar, "• REEMPLAZA EN SELECCIONADO / EN TODO")
        Me.BotonReemplazar.UseVisualStyleBackColor = False
        '
        'CheckSonido
        '
        Me.CheckSonido.AutoSize = True
        Me.CheckSonido.Checked = True
        Me.CheckSonido.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckSonido.Location = New System.Drawing.Point(111, 303)
        Me.CheckSonido.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckSonido.Name = "CheckSonido"
        Me.CheckSonido.Size = New System.Drawing.Size(59, 17)
        Me.CheckSonido.TabIndex = 107
        Me.CheckSonido.Text = "Sonido"
        Me.CheckSonido.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.CheckSonido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Aclaraciones.SetToolTip(Me.CheckSonido, "• Habilita sonido de teclado")
        Me.CheckSonido.UseVisualStyleBackColor = True
        '
        'CheckDisparoAuto
        '
        Me.CheckDisparoAuto.AutoSize = True
        Me.CheckDisparoAuto.Location = New System.Drawing.Point(167, 304)
        Me.CheckDisparoAuto.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckDisparoAuto.Name = "CheckDisparoAuto"
        Me.CheckDisparoAuto.Size = New System.Drawing.Size(120, 17)
        Me.CheckDisparoAuto.TabIndex = 106
        Me.CheckDisparoAuto.Text = "Teclado automático"
        Me.CheckDisparoAuto.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.CheckDisparoAuto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Aclaraciones.SetToolTip(Me.CheckDisparoAuto, "• Habilita disparo automático de teclado")
        Me.CheckDisparoAuto.UseVisualStyleBackColor = True
        '
        'TextoVelocidadDisparo
        '
        Me.TextoVelocidadDisparo.BackColor = System.Drawing.Color.White
        Me.TextoVelocidadDisparo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoVelocidadDisparo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextoVelocidadDisparo.FormattingEnabled = True
        Me.TextoVelocidadDisparo.Items.AddRange(New Object() {"50", "100", "110", "120", "130", "140", "150", "160", "170", "180", "190", "200", "210", "220", "230", "240", "250", "300", "350", "400", "450", "500", "550", "600", "650", "700", "750", "800", "850", "900", "950", "1000", "1100", "1200", "1300", "1400", "1500", "1600", "1700", "1800", "1900", "2000"})
        Me.TextoVelocidadDisparo.Location = New System.Drawing.Point(2, 269)
        Me.TextoVelocidadDisparo.Name = "TextoVelocidadDisparo"
        Me.TextoVelocidadDisparo.Size = New System.Drawing.Size(96, 28)
        Me.TextoVelocidadDisparo.TabIndex = 105
        Me.TextoVelocidadDisparo.Text = "500"
        Me.Aclaraciones.SetToolTip(Me.TextoVelocidadDisparo, "• Retardo para disparo automático de teclado")
        '
        'BotonAcentuarDesacentuar
        '
        Me.BotonAcentuarDesacentuar.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BotonAcentuarDesacentuar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonAcentuarDesacentuar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonAcentuarDesacentuar.Location = New System.Drawing.Point(9, 246)
        Me.BotonAcentuarDesacentuar.Name = "BotonAcentuarDesacentuar"
        Me.BotonAcentuarDesacentuar.Size = New System.Drawing.Size(104, 21)
        Me.BotonAcentuarDesacentuar.TabIndex = 104
        Me.BotonAcentuarDesacentuar.Text = "Acent/Des"
        Me.Aclaraciones.SetToolTip(Me.BotonAcentuarDesacentuar, "• ALTERNA ACENTUAR / DESACENTUAR " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en el texto seleccionado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "— ACENTUA (Botón izq" & _
                "uierdo)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "— QUITA ACENTOS (Botón derecho)")
        Me.BotonAcentuarDesacentuar.UseVisualStyleBackColor = False
        '
        'BotonRepiteRecorte
        '
        Me.BotonRepiteRecorte.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BotonRepiteRecorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonRepiteRecorte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonRepiteRecorte.Location = New System.Drawing.Point(253, 147)
        Me.BotonRepiteRecorte.Name = "BotonRepiteRecorte"
        Me.BotonRepiteRecorte.Size = New System.Drawing.Size(23, 25)
        Me.BotonRepiteRecorte.TabIndex = 103
        Me.BotonRepiteRecorte.Text = "•"
        Me.Aclaraciones.SetToolTip(Me.BotonRepiteRecorte, "• Repite recorte seleccionado")
        Me.BotonRepiteRecorte.UseVisualStyleBackColor = False
        '
        'BotonLeeRecortes
        '
        Me.BotonLeeRecortes.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BotonLeeRecortes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonLeeRecortes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonLeeRecortes.Location = New System.Drawing.Point(101, 121)
        Me.BotonLeeRecortes.Name = "BotonLeeRecortes"
        Me.BotonLeeRecortes.Size = New System.Drawing.Size(176, 21)
        Me.BotonLeeRecortes.TabIndex = 102
        Me.BotonLeeRecortes.Text = "Carga recortes"
        Me.Aclaraciones.SetToolTip(Me.BotonLeeRecortes, "• Carga recortes")
        Me.BotonLeeRecortes.UseVisualStyleBackColor = False
        '
        'ListaRecortes
        '
        Me.ListaRecortes.BackColor = System.Drawing.Color.White
        Me.ListaRecortes.DropDownWidth = 800
        Me.ListaRecortes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaRecortes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListaRecortes.FormattingEnabled = True
        Me.ListaRecortes.Location = New System.Drawing.Point(3, 145)
        Me.ListaRecortes.Name = "ListaRecortes"
        Me.ListaRecortes.Size = New System.Drawing.Size(246, 28)
        Me.ListaRecortes.TabIndex = 101
        Me.Aclaraciones.SetToolTip(Me.ListaRecortes, "• Listado de recortes")
        '
        'BotonQuitaEspacios
        '
        Me.BotonQuitaEspacios.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BotonQuitaEspacios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonQuitaEspacios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonQuitaEspacios.Location = New System.Drawing.Point(9, 222)
        Me.BotonQuitaEspacios.Name = "BotonQuitaEspacios"
        Me.BotonQuitaEspacios.Size = New System.Drawing.Size(104, 21)
        Me.BotonQuitaEspacios.TabIndex = 100
        Me.BotonQuitaEspacios.Text = "-ESP Sel/Tot"
        Me.Aclaraciones.SetToolTip(Me.BotonQuitaEspacios, "• QUITA ESPACIOS " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "— En el texto seleccionado (Botón izquierdo)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "— En todo el tex" & _
                "to (Botón derecho)")
        Me.BotonQuitaEspacios.UseVisualStyleBackColor = False
        '
        'BotonTodoMayMin
        '
        Me.BotonTodoMayMin.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BotonTodoMayMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonTodoMayMin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonTodoMayMin.Location = New System.Drawing.Point(128, 221)
        Me.BotonTodoMayMin.Name = "BotonTodoMayMin"
        Me.BotonTodoMayMin.Size = New System.Drawing.Size(92, 21)
        Me.BotonTodoMayMin.TabIndex = 99
        Me.BotonTodoMayMin.Text = "MAY/min"
        Me.Aclaraciones.SetToolTip(Me.BotonTodoMayMin, "• TODO MAYÚSCULAS / minúsculas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en el texto seleccionado." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "— TODO MAYÚSCULAS (Bot" & _
                "ón izquierdo)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "—  todo minúsculas (Botón derecho)")
        Me.BotonTodoMayMin.UseVisualStyleBackColor = False
        '
        'BotonRepiteAscii
        '
        Me.BotonRepiteAscii.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BotonRepiteAscii.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonRepiteAscii.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonRepiteAscii.Location = New System.Drawing.Point(288, 148)
        Me.BotonRepiteAscii.Name = "BotonRepiteAscii"
        Me.BotonRepiteAscii.Size = New System.Drawing.Size(23, 25)
        Me.BotonRepiteAscii.TabIndex = 98
        Me.BotonRepiteAscii.Text = "•"
        Me.Aclaraciones.SetToolTip(Me.BotonRepiteAscii, "• Repite carácter elegido")
        Me.BotonRepiteAscii.UseVisualStyleBackColor = False
        '
        'ListaAsciiComentado
        '
        Me.ListaAsciiComentado.BackColor = System.Drawing.Color.White
        Me.ListaAsciiComentado.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaAsciiComentado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListaAsciiComentado.FormattingEnabled = True
        Me.ListaAsciiComentado.Items.AddRange(New Object() {"Valor nulo", "☺    1", "☻    2", "♥    3", "♦    4", "♣    5", "♠    6", "•    7", "◘    8", "○   9", "◙    10 Nueva línea", "♂    11", "♀    12", "♪   13 Retorno de carro", "♫    14", "☼    15", "►    16", "◄    17", "↕    18", "‼    19", "¶    20", "§    21", "▬    22", "↨    23", "↑    24", "↓    25", "→    26", "←    27 Escape", "∟    28", "↔    29", "▲    30", "▼    31", "  32    Espacio", "!    33", """    34", "#    35", "$    36", "%    37", "&     38", "'     39", "(    40", ")    41", "*    42", "+    43", ",    44", "-    45", ".    46", "/    47", "0    48", "1    49", "2    50", "3    51", "4    52", "5    53", "6    54", "7    55", "8    56", "9    57", ":    58", ";    59", "<    60", "=    61", ">    62", "?    63", "@    64", "A    65", "B    66", "C    67", "D    68", "E    69", "F    70", "G    71", "H    72", "I    73", "J    74", "K    75", "L    76", "M    77", "N    78", "O    79", "P    80", "Q    81", "R    82", "S    83", "T    84", "U    85", "V    86", "W    87", "X    88", "Y    89", "Z    90", "[    91", "\    92", "]    93", "^    94", "_    95", "`    96", "a    97", "b    98", "c    99", "d    100", "e    101", "f    102", "g    103", "h    104", "i    105", "j    106", "k    107", "l    108", "m    109", "n    110", "o    111", "p    112", "q    113", "r    114", "s    115", "t    116", "u    117", "v    118", "w    119", "x    120", "y    121", "z    122", "{    123", "|    124", "}    125", "~    126", "⌂    127", "Ç    128", "ü    129", "é    130", "â    131", "ä    132", "à    133", "å    134", "ç    135", "ê    136", "ë    137", "è    138", "ï    139", "î    140", "ì    141", "Ä    142", "Å    143", "É    144", "æ    145", "Æ    146", "ô    147", "ö    148", "ò    149", "û    150", "ù    151", "ÿ    152", "Ö    153", "Ü    154", "ø    155", "£    156", "Ø    157", "×    158", "ƒ    159", "á    160", "í    161", "ó    162", "ú    163", "ñ    164", "Ñ    165", "ª    166", "º    167", "¿    68", "®    169", "¬    170", "½    171", "¼    172", "¡    173", "«    174", "»    175", "░    176", "▒    177", "▓    178", "│    179", "┤    180", "Á    181", "Â    182", "À    183", "©    184", "╣    185", "║    186", "╗    187", "╝    188", "¢    189", "¥    190", "┐    191", "└    192", "┴    193", "┬    194", "├    195", "─    196", "┼    197", "ã    198", "Ã    199", "╚    200", "╔    201", "╩    202", "╦    203", "╠    204", "═    205", "╬    206", "¤    207", "ð    208", "Ð    209", "Ê    210", "Ë    211", "È    212", "ı    213", "Í    214", "Î    215", "Ï    216", "┘ 217", "┌    218", "█    219", "▄    220", "¦    221", "Ì    222", "▀    223", "Ó    224", "ß    225", "Ô    226", "Ò    227", "õ    228", "Õ    229", "µ    230", "þ    231", "Þ    232", "Ú    233", "Û    234", "Ù    235", "ý    236", "Ý    237", "¯    238", "´    239", "­    240", "±    241", "‗    242", "¾    243", "¶    244", "§    245", "÷    246", "¸    247", "°    248", "¨    249", "·    250", "¹    251", "³    252", "²    253", "■    254", "     255", "    0127 ", "€    0128 ", "{    0129 ", " ‚    0130", " ƒ    0131", " „    0132", "…    0133 Puntos suspensivos", "†    0134 ", "‡    0135 ", "ˆ    0136 ", "‰    0137 ", "Š    0138 ", "‹    0139 ", "Œ    0140 ", "        0141", "Ž    0142 ", "      0143", "     0144", "‘    0145 ", "’    0146 ", """    0147 ", """    0148 ", "•    0149 ", "–    0150 ", "—    0151  Guión largo", "˜    0152 ", "™    0153 ", "š    0154 ", "›    0155 ", "œ    0156 ", "    0157", "ž    0158 ", "Ÿ    0159 ", "      0160", "¡    0161", "¢    0162 ", "£    0163", "¤    0164 ", "¥    0165 ", "¦    0166 ", "§    0167 ", "¨    0168 ", "©    0169 ", "ª    0170 ", "«    0171 ", "¬    0172 ", "­    0173 ", "®    0174 ", "¯    0175 ", "°    0176 ", "±    0177 ", "²    0178 ", "³    0179 ", "´    0180 ", "µ    0181 ", "¶    0182 ", "·    0183 ", "¸    0184 ", "¹    0185 ", "º    0186 ", "»    0187 ", "¼    0188 ", "½    0189 ", "¾    0190 ", " ¿    0191", "À    0192 ", "Á    0193 ", "Â    0194 ", "Ã    0195 ", "Ä    0196 ", "Å    0197 ", "Æ    0198 ", "Ç    0199 ", "È    0200 ", "É    0201 ", "Ê    0202 ", "Ë    0203 ", "Ì    0204 ", " Í    0205", "Î     0206 ", "Ï    0207 ", "Ð    0208 ", "Ñ    0209 ", "Ò    0210 ", "Ó    0211 ", "Ô    0212 ", "Õ    0213 ", "Ö    0214 ", "×    0215 ", "Ø    0216 ", "Ù    0217 ", "Ú    0218 ", "Û    0219 ", "Ü    0220 ", "Ý    0221 ", "Þ    0222 ", "ß    0223 ", "à    0224 ", "á    0225 ", "â    0226 ", "ã    0227 ", "ä    0228 ", "å    0229 ", "æ    0230 ", "ç     0231 ", "è    0232 ", "é    0233 ", "ê    0234 ", "ë    0235 ", "ì     0236 ", "í     0237 ", "î     0238 ", "ï    0239 ", "ð    0240 ", "ñ    0241 ", "ò    0242 ", "ó    0243 ", "ô    0244 ", "õ    0245 ", "ö    0246 ", "÷    0247 ", "ø    0248 ", "ù    0249 ", "ú    0250 ", "û    0251 ", "ü    0252 ", "ý    0253 ", "þ    0254 ", "ÿ    0255 "})
        Me.ListaAsciiComentado.Location = New System.Drawing.Point(4, 177)
        Me.ListaAsciiComentado.Name = "ListaAsciiComentado"
        Me.ListaAsciiComentado.Size = New System.Drawing.Size(307, 41)
        Me.ListaAsciiComentado.TabIndex = 97
        Me.Aclaraciones.SetToolTip(Me.ListaAsciiComentado, "• Lista de caracteres")
        '
        'BotonMayusculasIniciales
        '
        Me.BotonMayusculasIniciales.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BotonMayusculasIniciales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonMayusculasIniciales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonMayusculasIniciales.Location = New System.Drawing.Point(128, 245)
        Me.BotonMayusculasIniciales.Name = "BotonMayusculasIniciales"
        Me.BotonMayusculasIniciales.Size = New System.Drawing.Size(92, 21)
        Me.BotonMayusculasIniciales.TabIndex = 116
        Me.BotonMayusculasIniciales.Text = "May/min"
        Me.Aclaraciones.SetToolTip(Me.BotonMayusculasIniciales, "• Mayúsculas Iniciales /  todo minúsculas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en el texto seleccionado." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Mayúscula" & _
                "s Iniciales (Botón izquierdo)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-  todo minúsculas (Botón derecho)")
        Me.BotonMayusculasIniciales.UseVisualStyleBackColor = False
        '
        'BotonRepìtePredeterminado
        '
        Me.BotonRepìtePredeterminado.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BotonRepìtePredeterminado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonRepìtePredeterminado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonRepìtePredeterminado.Location = New System.Drawing.Point(121, 328)
        Me.BotonRepìtePredeterminado.Name = "BotonRepìtePredeterminado"
        Me.BotonRepìtePredeterminado.Size = New System.Drawing.Size(23, 25)
        Me.BotonRepìtePredeterminado.TabIndex = 118
        Me.BotonRepìtePredeterminado.Text = "•"
        Me.BotonRepìtePredeterminado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Aclaraciones.SetToolTip(Me.BotonRepìtePredeterminado, "• Repite valor predeterminado")
        Me.BotonRepìtePredeterminado.UseVisualStyleBackColor = False
        '
        'ListaPredeterminados
        '
        Me.ListaPredeterminados.BackColor = System.Drawing.Color.White
        Me.ListaPredeterminados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaPredeterminados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListaPredeterminados.FormattingEnabled = True
        Me.ListaPredeterminados.Items.AddRange(New Object() {"Linea fina", "Línea fina cortada", "CLAUSULA", "Item"})
        Me.ListaPredeterminados.Location = New System.Drawing.Point(2, 330)
        Me.ListaPredeterminados.Name = "ListaPredeterminados"
        Me.ListaPredeterminados.Size = New System.Drawing.Size(111, 28)
        Me.ListaPredeterminados.TabIndex = 117
        Me.Aclaraciones.SetToolTip(Me.ListaPredeterminados, "• Valores predeterminados")
        '
        'Aclaraciones
        '
        Me.Aclaraciones.AutomaticDelay = 1000
        Me.Aclaraciones.AutoPopDelay = 10000
        Me.Aclaraciones.InitialDelay = 1000
        Me.Aclaraciones.ReshowDelay = 1000
        '
        'BotonBusca1
        '
        Me.BotonBusca1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BotonBusca1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonBusca1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonBusca1.Location = New System.Drawing.Point(245, 0)
        Me.BotonBusca1.Name = "BotonBusca1"
        Me.BotonBusca1.Size = New System.Drawing.Size(32, 25)
        Me.BotonBusca1.TabIndex = 120
        Me.BotonBusca1.Text = "B"
        Me.Aclaraciones.SetToolTip(Me.BotonBusca1, "• VUELVE A CERO  / BUSCA desde cero - REPITE BUSQUEDA")
        Me.BotonBusca1.UseVisualStyleBackColor = False
        '
        'BotonBusca2
        '
        Me.BotonBusca2.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BotonBusca2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonBusca2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonBusca2.Location = New System.Drawing.Point(246, 26)
        Me.BotonBusca2.Name = "BotonBusca2"
        Me.BotonBusca2.Size = New System.Drawing.Size(32, 25)
        Me.BotonBusca2.TabIndex = 121
        Me.BotonBusca2.Text = "S"
        Me.Aclaraciones.SetToolTip(Me.BotonBusca2, "• Repite Búsqueda")
        Me.BotonBusca2.UseVisualStyleBackColor = False
        '
        'BotonAjusta
        '
        Me.BotonAjusta.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BotonAjusta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonAjusta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonAjusta.Location = New System.Drawing.Point(284, 85)
        Me.BotonAjusta.Name = "BotonAjusta"
        Me.BotonAjusta.Size = New System.Drawing.Size(29, 35)
        Me.BotonAjusta.TabIndex = 122
        Me.BotonAjusta.Text = "V"
        Me.Aclaraciones.SetToolTip(Me.BotonAjusta, "• Expande/Retrae el formulario")
        Me.BotonAjusta.UseVisualStyleBackColor = False
        '
        'CheckAcento
        '
        Me.CheckAcento.AutoSize = True
        Me.CheckAcento.Location = New System.Drawing.Point(114, 249)
        Me.CheckAcento.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckAcento.Name = "CheckAcento"
        Me.CheckAcento.Size = New System.Drawing.Size(15, 14)
        Me.CheckAcento.TabIndex = 123
        Me.CheckAcento.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.CheckAcento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Aclaraciones.SetToolTip(Me.CheckAcento, "• Habilita Acentuar Desacentuar Mouse")
        Me.CheckAcento.UseVisualStyleBackColor = True
        '
        'CheckMay1
        '
        Me.CheckMay1.AutoSize = True
        Me.CheckMay1.Location = New System.Drawing.Point(220, 220)
        Me.CheckMay1.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckMay1.Name = "CheckMay1"
        Me.CheckMay1.Size = New System.Drawing.Size(15, 14)
        Me.CheckMay1.TabIndex = 124
        Me.CheckMay1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.CheckMay1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Aclaraciones.SetToolTip(Me.CheckMay1, "• • Habilita Todo Mayúsculas Mouse")
        Me.CheckMay1.UseVisualStyleBackColor = True
        '
        'CheckMay2
        '
        Me.CheckMay2.AutoSize = True
        Me.CheckMay2.Location = New System.Drawing.Point(220, 253)
        Me.CheckMay2.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckMay2.Name = "CheckMay2"
        Me.CheckMay2.Size = New System.Drawing.Size(15, 14)
        Me.CheckMay2.TabIndex = 125
        Me.CheckMay2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.CheckMay2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Aclaraciones.SetToolTip(Me.CheckMay2, "• Habilita Mayúsculas Iniciales Mouse")
        Me.CheckMay2.UseVisualStyleBackColor = True
        '
        'CheckMin
        '
        Me.CheckMin.AutoSize = True
        Me.CheckMin.Location = New System.Drawing.Point(220, 237)
        Me.CheckMin.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckMin.Name = "CheckMin"
        Me.CheckMin.Size = New System.Drawing.Size(15, 14)
        Me.CheckMin.TabIndex = 126
        Me.CheckMin.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.CheckMin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Aclaraciones.SetToolTip(Me.CheckMin, "• Habilita Minúsculas Mouse")
        Me.CheckMin.UseVisualStyleBackColor = True
        '
        'TextoAscii
        '
        Me.TextoAscii.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoAscii.ForeColor = System.Drawing.Color.Blue
        Me.TextoAscii.Location = New System.Drawing.Point(236, 218)
        Me.TextoAscii.Margin = New System.Windows.Forms.Padding(2)
        Me.TextoAscii.Name = "TextoAscii"
        Me.TextoAscii.Size = New System.Drawing.Size(54, 26)
        Me.TextoAscii.TabIndex = 127
        Me.Aclaraciones.SetToolTip(Me.TextoAscii, "ASCII")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(282, -3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 30)
        Me.Button1.TabIndex = 128
        Me.Aclaraciones.SetToolTip(Me.Button1, "Cuadro de Búsqueda AGREGA TEXTO SELECCIONADO / BORRA ")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(282, 51)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(29, 30)
        Me.Button2.TabIndex = 129
        Me.Aclaraciones.SetToolTip(Me.Button2, "Cuadro de Sstitución AGREGA TEXTO SELECCIONADO / BORRA ")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextoReemplazar0
        '
        Me.TextoReemplazar0.DropDownWidth = 400
        Me.TextoReemplazar0.FormattingEnabled = True
        Me.TextoReemplazar0.Items.AddRange(New Object() {"", "(RETORNO DE CARRO)", "(NUEVA LINEA)", "(RETORNO DE CARRO - NUEVA LINEA)", "(ESPACIO)", "*_", "_*", "*"})
        Me.TextoReemplazar0.Location = New System.Drawing.Point(2, 46)
        Me.TextoReemplazar0.Margin = New System.Windows.Forms.Padding(2)
        Me.TextoReemplazar0.Name = "TextoReemplazar0"
        Me.TextoReemplazar0.Size = New System.Drawing.Size(240, 21)
        Me.TextoReemplazar0.TabIndex = 130
        Me.Aclaraciones.SetToolTip(Me.TextoReemplazar0, "Texto de reemplazo 1")
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
        Me.BotonTeclado.Location = New System.Drawing.Point(289, 27)
        Me.BotonTeclado.Name = "BotonTeclado"
        Me.BotonTeclado.Size = New System.Drawing.Size(22, 24)
        Me.BotonTeclado.TabIndex = 119
        Me.Aclaraciones.SetToolTip(Me.BotonTeclado, "• Minimiza / Expande Anotador (Botón Izquierdo)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Oculta este formulario  (Botón" & _
                " Derecho)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.BotonTeclado.UseVisualStyleBackColor = False
        '
        'Checkeys
        '
        Me.Checkeys.AutoSize = True
        Me.Checkeys.Checked = True
        Me.Checkeys.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Checkeys.Location = New System.Drawing.Point(111, 273)
        Me.Checkeys.Margin = New System.Windows.Forms.Padding(2)
        Me.Checkeys.Name = "Checkeys"
        Me.Checkeys.Size = New System.Drawing.Size(138, 17)
        Me.Checkeys.TabIndex = 109
        Me.Checkeys.Text = "Habilita envío de teclas"
        Me.Checkeys.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Checkeys.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Checkeys.UseVisualStyleBackColor = True
        '
        'FormAuxiliar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 362)
        Me.Controls.Add(Me.TextoReemplazar0)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextoAscii)
        Me.Controls.Add(Me.CheckMin)
        Me.Controls.Add(Me.CheckMay2)
        Me.Controls.Add(Me.CheckMay1)
        Me.Controls.Add(Me.CheckAcento)
        Me.Controls.Add(Me.BotonAjusta)
        Me.Controls.Add(Me.BotonBusca2)
        Me.Controls.Add(Me.BotonBusca1)
        Me.Controls.Add(Me.BotonTeclado)
        Me.Controls.Add(Me.BotonRepìtePredeterminado)
        Me.Controls.Add(Me.ListaPredeterminados)
        Me.Controls.Add(Me.BotonMayusculasIniciales)
        Me.Controls.Add(Me.TextoBuscar2)
        Me.Controls.Add(Me.TextoReemplazar2)
        Me.Controls.Add(Me.TextoReemplazar1)
        Me.Controls.Add(Me.TextoBuscar1)
        Me.Controls.Add(Me.BotonTransparencia)
        Me.Controls.Add(Me.TextoVelocidadRepeticion)
        Me.Controls.Add(Me.Checkeys)
        Me.Controls.Add(Me.BotonReemplazar)
        Me.Controls.Add(Me.CheckSonido)
        Me.Controls.Add(Me.CheckDisparoAuto)
        Me.Controls.Add(Me.TextoVelocidadDisparo)
        Me.Controls.Add(Me.BotonAcentuarDesacentuar)
        Me.Controls.Add(Me.BotonRepiteRecorte)
        Me.Controls.Add(Me.BotonLeeRecortes)
        Me.Controls.Add(Me.ListaRecortes)
        Me.Controls.Add(Me.BotonQuitaEspacios)
        Me.Controls.Add(Me.BotonTodoMayMin)
        Me.Controls.Add(Me.BotonRepiteAscii)
        Me.Controls.Add(Me.ListaAsciiComentado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAuxiliar"
        Me.Text = "FormAuxiliar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextoBuscar2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextoReemplazar2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextoReemplazar1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextoBuscar1 As System.Windows.Forms.ComboBox
    Friend WithEvents BotonTransparencia As System.Windows.Forms.Button
    Friend WithEvents TextoVelocidadRepeticion As System.Windows.Forms.ComboBox
    Friend WithEvents BotonReemplazar As System.Windows.Forms.Button
    Friend WithEvents CheckSonido As System.Windows.Forms.CheckBox
    Friend WithEvents CheckDisparoAuto As System.Windows.Forms.CheckBox
    Friend WithEvents TextoVelocidadDisparo As System.Windows.Forms.ComboBox
    Friend WithEvents BotonAcentuarDesacentuar As System.Windows.Forms.Button
    Friend WithEvents BotonRepiteRecorte As System.Windows.Forms.Button
    Friend WithEvents BotonLeeRecortes As System.Windows.Forms.Button
    Friend WithEvents ListaRecortes As System.Windows.Forms.ComboBox
    Friend WithEvents BotonQuitaEspacios As System.Windows.Forms.Button
    Friend WithEvents BotonTodoMayMin As System.Windows.Forms.Button
    Friend WithEvents BotonRepiteAscii As System.Windows.Forms.Button
    Friend WithEvents ListaAsciiComentado As System.Windows.Forms.ComboBox
    Friend WithEvents BotonMayusculasIniciales As System.Windows.Forms.Button
    Friend WithEvents BotonRepìtePredeterminado As System.Windows.Forms.Button
    Friend WithEvents ListaPredeterminados As System.Windows.Forms.ComboBox
    Friend WithEvents BotonTeclado As System.Windows.Forms.Button
    Friend WithEvents Aclaraciones As System.Windows.Forms.ToolTip
    Friend WithEvents BotonBusca1 As System.Windows.Forms.Button
    Friend WithEvents BotonBusca2 As System.Windows.Forms.Button
    Friend WithEvents BotonAjusta As System.Windows.Forms.Button
    Friend WithEvents CheckAcento As System.Windows.Forms.CheckBox
    Friend WithEvents CheckMay1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckMay2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckMin As System.Windows.Forms.CheckBox
    Friend WithEvents TextoAscii As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextoReemplazar0 As System.Windows.Forms.ComboBox
    Friend WithEvents Checkeys As System.Windows.Forms.CheckBox
End Class
