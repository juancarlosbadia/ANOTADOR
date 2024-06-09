'Imports System.Diagnostics
Public Class Formato
    Dim Mover As Boolean
    Dim PosMovIzq As Integer
    Dim PosMovArr As Integer
    Dim antes As Integer
    Dim largo As Integer
    Private isDragging As Boolean = False

    Private Sub Formato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True
        ActualizaColores()

    End Sub

    Private Sub BotonCopia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonCopia.Click

    End Sub

    Private Sub BotonCopia_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonCopia.MouseDown
        Anotador.COPIA(sender, e)
    End Sub

    Private Sub BotonMayusculasIniciales_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonMayusculasIniciales.MouseDown
        Anotador.BotonMayusculasIniciales_MouseDown(sender, e)
        RecuperaEspacio()
    End Sub
    Public Sub RecuperaEspacio()
        'LetraElegida = " " Then 'vbCrLf Or LetraElegida = Chr(13) & Chr(10) 
        'SendKeys.Send(LetraElegida)
        'SendKeys.SendWait("{DOWN}")
        Anotador.Focus()
        'recuperacadena()

        antes = Anotador.Texto.SelectionStart
        largo = Anotador.Texto.SelectionLength
        Dim ubicacion As Integer = Anotador.Ey
        Dim bajo As Integer = Anotador.Height
        Dim distan = Int(Math.Abs(bajo - ubicacion))
        Dim veces = CInt(Math.Abs(bajo - ubicacion) / 38)
        'Debug.Print(distan)


        For a = 1 To veces - 2
            SendKeys.SendWait("{DOWN}")
        Next

        TimerRecupera.Enabled = True
        'PoneMensaje("Ey: " & ubicacion & " bajo " & Anotador.Height & " rengl " & veces, Color.Cyan)
        'Debug.Print("Ey: " & ubicacion & " bajo " & Anotador.Height & " rengl " & veces)

    End Sub
    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click

    End Sub

    Private Sub Button35_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button35.MouseDown
        Anotador.Button35_MouseDown(sender, e)
    End Sub

    Private Sub BotonPega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonPega.Click

    End Sub

    Private Sub BotonPega_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonPega.MouseDown
        Anotador.BotonPega_MouseDown(sender, e)
    End Sub

    Private Sub BotonBorra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonBorra.Click

    End Sub

    Private Sub BotonBorra_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonBorra.MouseDown
        Anotador.BotonBorra_MouseDown(sender, e)
    End Sub

    Private Sub BotonCentral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonCentral.Click

    End Sub

    Private Sub BotonCentral_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonCentral.MouseDown
        Anotador.BotonCentral_MouseDown(sender, e)
    End Sub

    Private Sub TeclaAbreInterrogacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaAbreInterrogacion.Click

    End Sub

    Private Sub TeclaAbreInterrogacion_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaAbreInterrogacion.MouseDown
        Anotador.TeclaAbreInterrogacion_MouseDown(sender, e)
        RecuperaEspacio()
    End Sub

    Private Sub TeclaAbreAdmiracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaAbreAdmiracion.Click

    End Sub

    Private Sub TeclaTabulador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaTabulador.Click

    End Sub

    Private Sub TeclaTabulador_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaTabulador.MouseDown
        Anotador.TeclaTabulador_MouseDown(sender, e)
    End Sub

    Private Sub BotonAcentuarDesacentuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAcentuarDesacentuar.Click

    End Sub

    Private Sub BotonAcentuarDesacentuar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonAcentuarDesacentuar.MouseDown
        Anotador.BotonAcentuarDesacentuar_MouseDown(sender, e)
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click

    End Sub

    Private Sub Button13_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button13.MouseDown
        Anotador.Button13_MouseDown(sender, e)
    End Sub

    Private Sub TeclaAbreParentesis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaAbreParentesis.Click

    End Sub

    Private Sub TeclaAbreParentesis_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaAbreParentesis.MouseDown
        'Anotador.PoneMayusculas()
        'Anotador.PublicCierraParentesis(e)
        Anotador.TeclaAbreParentesis_MouseDown(sender, e)
        RecuperaEspacio()
    End Sub

    Private Sub TeclaComa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaComa.Click

    End Sub

    Private Sub TeclaComa_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaComa.MouseDown
        Anotador.PublicComa(e)
        'Anotador.p()
        'Anotador.TeclaComa_MouseDown(sender, e)
    End Sub

    Private Sub TeclaEspacio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaEspacio.Click

    End Sub

    Private Sub TeclaEspacio_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaEspacio.MouseDown
        Anotador.TeclaEspacio_MouseDown(sender, e)

    End Sub

    Private Sub TeclaPunto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaPunto.Click
        ' " '
    End Sub

    Private Sub TeclaPunto_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaPunto.MouseDown
        Anotador.TeclaPunto_MouseDown(sender, e)

    End Sub

    Private Sub TeclaCierraParentesis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaCierraParentesis.Click

    End Sub

    Private Sub TeclaCierraParentesis_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaCierraParentesis.MouseDown
        'Anotador.PoneMinusculas()
        'Anotador.PublicCierraParentesis(e)
        Anotador.TeclaCierraParentesis_MouseDown(sender, e)
        RecuperaEspacio()

    End Sub

    Private Sub TeclaCierraInterrogacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaCierraInterrogacion.Click
    End Sub

    Private Sub TeclaCierraInterrogacion_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaCierraInterrogacion.MouseDown
        Anotador.PublicCierraInterrogacion(e)
        'Anotador.TeclaCierraInterrogacion_MouseDown(sender, e)
        RecuperaEspacio()
    End Sub

    Private Sub TeclaCierraAdmiracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaCierraAdmiracion.Click

    End Sub

    Private Sub TeclaCierraAdmiracion_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaCierraAdmiracion.MouseDown
        'Anotador.PublicCierraAdmiracion(e)
        'Anotador.PoneMinusculas()
        Anotador.TeclaCierraAdmiracion_MouseDown(sender, e)
        RecuperaEspacio()
    End Sub

    Private Sub TeclaGuion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaGuion.Click

    End Sub

    Private Sub TeclaGuion_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaGuion.MouseDown
        'Anotador.PoneMinusculas()
        'Anotador.PublicGuion(e)
        Anotador.TeclaGuion_MouseDown(sender, e)
        RecuperaEspacio()
    End Sub

    Private Sub BotonGuarda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonGuarda.Click

    End Sub

    Private Sub BotonGuarda_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonGuarda.MouseDown
        Anotador.BotonGuarda_MouseDown(sender, e)
    End Sub

    Private Sub BotonBorra_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonBorra.MouseUp
        Anotador.BotonBorra_MouseUp(sender, e)
    End Sub

    Private Sub TeclaAbreAdmiracion_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaAbreAdmiracion.MouseDown
        'Anotador.PoneMayusculas()
        'Anotador.TeclaCierraAdmiracion_MouseDown(sender, e)
        Anotador.TeclaAbreAdmiracion_MouseDown(sender, e)
        RecuperaEspacio()
    End Sub
    Private Sub CheckConShift_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckConShift.CheckedChanged
        Anotador.CheckConShift.Checked = CheckConShift.Checked
    End Sub
    Private Sub BotonTodoMayMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonTodoMayMin.Click
    End Sub
    Private Sub BotonTodoMayMin_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonTodoMayMin.MouseDown
        Anotador.BotonTodoMayMin_MouseDown(sender, e)
        RecuperaEspacio()
    End Sub
    Private Sub CheckDisparoAuto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckDisparoAuto.CheckedChanged
        Anotador.CheckDisparoAuto.Checked = CheckDisparoAuto.Checked
    End Sub
    Private Sub Formato_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Mover = True
            PosMovIzq = e.X
            PosMovArr = e.Y
            Me.TopMost = True
        Else
            Me.Visible = False
            Me.Width = BotonExit.Left + BotonExit.Width * 2
            Me.Height = BotonExit.Top + BotonExit.Height * 2
            FormularioActivo(4) = False
            Anotador.Focus()
        End If
    End Sub

    Private Sub Formato_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If Mover = True Then
            Me.Top = (Me.Top + e.Y - PosMovArr) ' - Me.Height / 2
            Me.Left = (Me.Left + e.X - PosMovIzq) ' - Me.Width / 2
        End If
    End Sub
    Private Sub Formato_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        Mover = False
    End Sub
    Private Sub BotonTeclado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonTeclado.Click
    End Sub
    Private Sub BotonTeclado_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonTeclado.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Anotador.Visible = False Then
                Anotador.Visible = True
            Else
                Anotador.Visible = False
            End If
        Else

            'FormularioActivo(4) = False
            'Anotador.Focus()

            If Anotador.Minimizado = False Then
                Anotador.MinimizaFormulario()
                Anotador.Posiciones00()
                Anotador.Texto.Focus()
            Else
                Anotador.ExpandeAnotador()
                Anotador.PoneCabecera()
                Anotador.Texto.Focus()
            End If
        End If

    End Sub
    Private Sub PoneMayusculas()

        TeclaPunto.Text = ":"
        TeclaComa.Text = ";"
        TeclaGuion.Text = "_"
        'TeclaComillas.Text = "'"
        'TeclaNumeral.Text = "|"
        'TeclaPesos.Text = "@"
        'TeclaPorCiento.Text = "*"
        TeclaAbreParentesis.Text = "["
        TeclaCierraParentesis.Text = "]"
        TeclaAbreInterrogacion.Text = "{"
        TeclaCierraInterrogacion.Text = "}"
        TeclaAbreAdmiracion.Text = "«"
        TeclaCierraAdmiracion.Text = "»"
        'TeclaBarra.Text = "\"
        'TeclaOrdinal.Text = "ª"
        'TeclaGuionLargo.Text = "•"
        Anotador.Texto.Focus()
    End Sub

    Private Sub BotonTeclado_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonTeclado.MouseHover
        Anotador.TopMost = True
        Anotador.TopMost = False
        Me.TopMost = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TeclaComillas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaComillas.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BotonColorFondo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonColorFondo.Click

    End Sub

    Private Sub BotonColorFondo_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonColorFondo.MouseDown
        Dim GuardaColorLetraTablero = TextoForeColorPublic
        Dim GuardaColorFondoTablero = TextoBackColorPublic

        Dim Ancho As Integer = BotonColorFondo.Width / 3
        If e.X < Ancho Then
            Anotador.ColorDeFondo()
        End If
        If e.X > Ancho And e.X < Ancho * 2 Then
            ' ValorColor(suma, verde)

            DeterminaColorFacil(False, 1, TextoForeColorPublic, TextoBackColorPublic)
            Anotador.ActualizaColorCuadro()
            'TextoInicial("Texto")
        End If
        If e.X > Ancho * 2 Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                Claridad(True, Anotador.Texto.BackColor)
            Else
                Claridad(False, Anotador.Texto.BackColor)
            End If
            TextoBackColorPublic = Anotador.Texto.BackColor
        End If

        TextoForeColorPublic = GuardaColorLetraTablero
        Anotador.ActualizaColores()
        BotonColorLetra.ForeColor = Anotador.Texto.ForeColor
        BotonColorLetra.BackColor = Anotador.Texto.BackColor ' GuardaColorLetraTablero '
        BotonColorFondo.BackColor = Anotador.Texto.BackColor
        BotonFondoClaroscuro.BackColor = Anotador.Texto.BackColor
        ActualizaColores()

    End Sub

    Private Sub BotonColorFondo_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonColorFondo.MouseWheel
        ManejaBackColor(BotonColorFondo, e)
        'BotonColorLetra.BackColor = Anotador.Texto.ForeColor
        'BotonColorLetra.BackColor = Anotador.Texto.BackColor ' GuardaColorLetraTablero '
        'BotonColorFondo.BackColor = Anotador.Texto.BackColor
        'BotonFondoClaroscuro.BackColor = Anotador.Texto.BackColor
        ActualizaColores()
    End Sub

    Private Sub BotonColorLetra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonColorLetra.Click

    End Sub

    Private Sub BotonColorLetra_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonColorLetra.MouseDown


        Dim Ancho As Integer = BotonColorLetra.Width / 3
        Dim GuardaColorLetraTablero = TextoForeColorPublic
        Dim GuardaColorFondoTablero = Anotador.Texto.BackColor ' ColorFondoTablero
        TextoBackColorPublic = Anotador.Texto.BackColor

        If e.X < Ancho Then
            Anotador.ColorDeLetra()
        End If

        If e.X > Ancho And e.X < Ancho * 2 Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                DeterminaColorFacil(True, 0, TextoForeColorPublic, TextoBackColorPublic)
            Else
                DeterminaColorFacil(False, 0, TextoForeColorPublic, TextoBackColorPublic)
            End If
            'TextoBackColorPublic = GuardaColorFondoTablero
            'TextoForeColorPublic = GuardaColorLetraTablero
            Anotador.ActualizaColorCuadro()
        End If

            If e.X > Ancho * 2 Then
                If e.Button = Windows.Forms.MouseButtons.Left Then
                    Claridad(True, Anotador.Texto.ForeColor)
                Else
                    Claridad(False, Anotador.Texto.ForeColor)
                End If
                TextoForeColorPublic = Anotador.Texto.ForeColor
            End If


            TextoBackColorPublic = GuardaColorFondoTablero
            TextoInicial("Texto")
            Anotador.ActualizaColorCuadro()
            BotonColorLetra.ForeColor = Anotador.Texto.ForeColor
            BotonTextoClaroscuro.BackColor = Anotador.Texto.ForeColor
            BotonColorFondo.BackColor = Anotador.Texto.BackColor
            BotonColorFondo.ForeColor = Anotador.Texto.ForeColor
            BotonFondoClaroscuro.BackColor = Anotador.Texto.BackColor
            ActualizaColores()
    End Sub
    Public Sub Claridad(ByVal AclaraOscurece As Boolean, ByRef ValorColor As Color)
        Dim Signo As Integer
        Dim ColorTratado As New Color
        Dim RR, GG, BB As Integer
        Dim Paso = 4
        ColorTratado = ValorColor
        If AclaraOscurece = True Then
            Signo = 1
        Else
            Signo = -1
        End If

        RR = Val(ColorTratado.R) + (Paso * Signo)
        GG = Val(ColorTratado.G) + (Paso * Signo)
        BB = Val(ColorTratado.B) + (Paso * Signo)

        If RR > 255 Then
            RR = 255
        End If
        If RR < 0 Then
            RR = 0
        End If

        If GG > 255 Then
            GG = 255
        End If
        If GG < 0 Then
            GG = 0
        End If

        If BB > 255 Then
            BB = 255
        End If
        If BB < 0 Then
            BB = 0
        End If

        ColorTratado = Color.FromArgb(255, RR, GG, BB)
        ValorColor = ColorTratado
        'Anotador.Texto.ForeColor = ValorColor

    End Sub


    Private Sub BotonColorLetra_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonColorLetra.MouseWheel
        ManejaForeColor(BotonColorLetra, e)
        BotonTextoClaroscuro.BackColor = BotonColorLetra.ForeColor
        BotonColorFondo.BackColor = Anotador.Texto.BackColor
        ActualizaColores()
    End Sub

    Private Sub BotonFuente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonFuente.Click

    End Sub

    Private Sub BotonFuente_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonFuente.DoubleClick

    End Sub

    Private Sub BotonFuente_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonFuente.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            FormatoFuente(0)
        Else
            Anotador.Fuentes()
        End If
    End Sub

    Private Sub BotonCuadro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonCuadro.Click

    End Sub

    Private Sub BotonCuadro_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonCuadro.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Anotador.Mas()

        Else
            Anotador.Menos()
        End If
    End Sub

    Private Sub BotonTam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonTam.Click

    End Sub

    Private Sub BotonTam_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonTam.MouseDown
        Anotador.BotonMasMenos_MouseDown(sender, e)
    End Sub

    Private Sub BotonColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonColor.Click

    End Sub

    Private Sub BotonColor_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonColor.MouseDown
        Anotador.BotonColor_MouseDown(sender, e)
        ActualizaColores()
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button4.MouseDown
        Dim varchr = vbCrLf '        Chr(13) 'vbenter 'Chr(10) & Chr(13)
        Teclado.PoneTeclaEnter(varchr)
        InvierteColorSuenaTecla(Button4)
    End Sub

    Private Sub BotonTeclado2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonTeclado2.Click

    End Sub

    Private Sub BotonTeclado2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonTeclado2.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            TecladoRedimensionable = True
            If Teclado.Visible = True Then
                Teclado.Width = Teclado.Width * 1.1
                Teclado.Height = Teclado.Height * 1.1
                Teclado.Top = Me.Top + 160
                Teclado.Left = Me.Left + Me.Width 'Screen.PrimaryScreen.Bounds.Width / 4
            Else
                Teclado.Visible = True
                Teclado.Top = Me.Top + 160
                Teclado.Left = Me.Left + Me.Width 'Screen.PrimaryScreen.Bounds.Width / 4
                Teclado.Width = Screen.PrimaryScreen.Bounds.Width / 3
                Teclado.Height = Screen.PrimaryScreen.Bounds.Height / 5
                Teclado.Opacity = 1
            End If

        Else
            If Teclado.Visible = True Then
                Teclado.Visible = False
            Else
                Teclado.Visible = True
                Teclado.Top = Me.Top + 160
                Teclado.Left = Me.Left + Me.Width 'Screen.PrimaryScreen.Bounds.Width / 4
            End If
        End If
        If Teclado.Top > Screen.PrimaryScreen.Bounds.Height - Teclado.Height Then
            Teclado.Top = Screen.PrimaryScreen.Bounds.Height - Teclado.Height * 1.1
        End If

    End Sub

    Private Sub CheckDragDrop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckDragDrop.CheckedChanged
        If CheckDragDrop.Checked = True Then
            FuncionesComunes.DragDrop = True
        Else
            FuncionesComunes.DragDrop = False
        End If
    End Sub

    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub TeclaMayusculas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaMayusculas.Click

    End Sub

    Private Sub TeclaMayusculas_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaMayusculas.MouseDown
        Anotador.TeclaMayusculas_MouseDown(sender, e)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Anotador.MuestraOcultaAuxiliar()
        Else
            Anotador.MuestraOcultaAuxiliar()
            FormAuxiliar.Top = Me.Top + Me.Height
            FormAuxiliar.Left = Me.Left
            'FormAuxiliar.Height = FormAuxiliar.TextoReemplazar2.Top + FormAuxiliar.TextoReemplazar2.Height + 40
        End If
        FormAuxiliar.ContraerForm()
    End Sub

    Private Sub BotonMayusculasIniciales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonMayusculasIniciales.Click

    End Sub

    Private Sub TimerRecupera_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerRecupera.Tick
        Anotador.Texto.SelectionStart = antes
        Anotador.Texto.SelectionLength = largo
        TimerRecupera.Enabled = False

    End Sub

    Private Sub TeclaComillas_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaComillas.MouseDown
        'Anotador.PoneMinusculas()
        Anotador.TeclaComillas_MouseDown(sender, e)
        RecuperaEspacio()
    End Sub

    Private Sub Button2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        'Anotador.PoneMayusculas()
        Anotador.TeclaComillas_MouseDown(sender, e)
        RecuperaEspacio()
    End Sub

    Private Sub Formato_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel

    End Sub
    Public Sub ManejaTransparencia(ByRef OBJETO As Object, ByVal E As Object)
        Dim OPACIDAD = OBJETO.Opacity

        If E < 0 Then
            OPACIDAD = OPACIDAD - 0.05
        Else
            OPACIDAD = OPACIDAD + 0.05
        End If
        If OPACIDAD > 1 Then OPACIDAD = 1
        If OPACIDAD < 0.01 Then OPACIDAD = 0.01
        OBJETO.Opacity = OPACIDAD
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click

    End Sub

    Private Sub Button31_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button31.MouseWheel
        ManejaTransparencia(Anotador, e.Delta)
    End Sub

    Private Sub Button44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button44.Click

    End Sub

    Private Sub Button44_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button44.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Anotador.TransparencyKey = Anotador.Texto.BackColor
        Else
            Anotador.TransparencyKey = Anotador.Texto.ForeColor
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button2_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseWheel
        ManejaTransparencia(Me, e.Delta)
    End Sub

    Private Sub BotonTam_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonTam.MouseWheel
        Anotador.Fuente = Anotador.Texto.Font
        Dim TamaRes As Integer = Anotador.Fuente.Size
        If e.Delta <> 0 Then
            If e.Delta <= 0 Then

                TamaRes = TamaRes - 1
                If Anotador.Texto.Font.Size > 200 Then Exit Sub 'minimum 500?
            Else

                TamaRes = TamaRes + 1
                If Anotador.Texto.Font.Size < 3 Then Exit Sub 'maximum 2000?
            End If


            Anotador.Fuente = Anotador.Texto.Font
            Anotador.Fuente = New Font(Anotador.Fuente.FontFamily, TamaRes, Anotador.Fuente.Style, Anotador.Fuente.Unit, Anotador.Fuente.GdiCharSet)
            Anotador.Texto.Font = Anotador.Fuente

            Anotador.Texto.ScrollToCaret()
        End If
    End Sub

    Private Sub BotonArribaAbajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonArribaAbajo.Click

    End Sub

    Private Sub BotonAvanzaRetrocede_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAvanzaRetrocede.Click

    End Sub

    Private Sub BotonAvanzaRetrocede_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonAvanzaRetrocede.MouseDown
        Anotador.Focus()
        If e.Button = Windows.Forms.MouseButtons.Right Then
            SendKeys.Send("{RIGHT}")
        Else
            SendKeys.Send("{LEFT}")
        End If
    End Sub

    Private Sub BotonAvanzaRetrocede_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonAvanzaRetrocede.MouseWheel
        If e.Delta > 0 Then
            SendKeys.Send("{RIGHT}")
        Else
            SendKeys.Send("{LEFT}")
        End If
    End Sub

    Private Sub BotonArribaAbajo_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonArribaAbajo.MouseDown
        Anotador.Focus()
        If e.Button = Windows.Forms.MouseButtons.Left Then
            SendKeys.Send("{UP}")
        Else
            SendKeys.Send("{DOWN}")
        End If
    End Sub

    Private Sub BotonArribaAbajo_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonArribaAbajo.MouseWheel
        If e.Delta > 0 Then
            SendKeys.Send("{UP}")
        Else
            SendKeys.Send("{DOWN}")
        End If
    End Sub

    Private Sub Button42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button42.Click

    End Sub

    Private Sub Button42_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button42.MouseDown
        Anotador.AgregaRenglon(e)
    End Sub

    Private Sub Button53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button53.Click

    End Sub

    Private Sub Button53_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button53.MouseDown
        Anotador.AlPrincipioFin(e)
    End Sub

    Private Sub Button54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button54.Click
        Anotador.LINK()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        OpenControlPanelSection("")
        'Dim processStartInfo As New ProcessStartInfo("control.exe", "")
        'Process.Start(processStartInfo)
    End Sub
    Private Sub OpenControlPanelSection(ByVal section As String)
        Try
            ' Crea un proceso para ejecutar el comando
            Dim processStartInfo As New ProcessStartInfo("control.exe", section)
            ' Inicia el proceso
            Process.Start(processStartInfo)
        Catch ex As Exception
            MessageBox.Show("Error al abrir el panel de control: " & ex.Message)
        End Try
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Anotador.SeleccionaCopiaFrase()
    End Sub
    Private Sub BotonTextoClaroscuro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonTextoClaroscuro.Click
    End Sub
    Private Sub BotonTextoClaroscuro_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonTextoClaroscuro.MouseDown
        Dim Color As Color
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Color = Color.FromArgb(255, 255, 255)
        Else
            Color = Color.FromArgb(0, 0, 0)
        End If
        TextoBackColorPublic = Anotador.Texto.BackColor
        TextoForeColorPublic = Color
        Anotador.Texto.ForeColor = Color
        TextoForeColorPublic = Color
        'ColorLetraTablero = Color.FromArgb(rojo, verde, azul)
        ' Anotador.ActualizaColores()
        BotonTextoClaroscuro.BackColor = Color
        'BotonColorLetra.ForeColor = BotonTextoClaroscuro.BackColor
        BotonColorLetra.ForeColor = Anotador.Texto.ForeColor
        BotonColorFondo.ForeColor = Anotador.Texto.ForeColor
        BotonColorFondo.BackColor = Anotador.Texto.BackColor
        BotonColorLetra.BackColor = Anotador.Texto.BackColor
        BotonFondoClaroscuro.BackColor = Anotador.Texto.BackColor
        BotonTextoClaroscuro.BackColor = Anotador.Texto.ForeColor
        ActualizaColores()
    End Sub
    Private Sub BotonTextoClaroscuro_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonTextoClaroscuro.MouseWheel
        TextoAclaraOscurece(BotonTextoClaroscuro, e)
        BotonColorLetra.ForeColor = Anotador.Texto.ForeColor
        BotonColorLetra.BackColor = Anotador.Texto.BackColor
        BotonColorFondo.ForeColor = Anotador.Texto.ForeColor
        BotonColorFondo.BackColor = Anotador.Texto.BackColor
        BotonFondoClaroscuro.BackColor = Anotador.Texto.BackColor
        BotonTextoClaroscuro.BackColor = Anotador.Texto.ForeColor
        ActualizaColores()
    End Sub
    Private Sub BotonFondoClaroscuro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonFondoClaroscuro.Click
    End Sub
    Private Sub BotonFondoClaroscuro_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonFondoClaroscuro.MouseDown
        Dim Color As Color
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Color = Color.FromArgb(255, 255, 255)
        Else
            Color = Color.FromArgb(0, 0, 0)
        End If
        TextoBackColorPublic = Color
        'ColorLetraTablero = Color
        Anotador.Texto.BackColor = Color
        'BotonFondoClaroscuro.BackColor = Color
        BotonColorLetra.ForeColor = Anotador.Texto.ForeColor
        BotonColorLetra.BackColor = Anotador.Texto.BackColor
        BotonColorFondo.ForeColor = Anotador.Texto.ForeColor
        BotonColorFondo.BackColor = Anotador.Texto.BackColor
        BotonFondoClaroscuro.BackColor = Anotador.Texto.BackColor
        BotonTextoClaroscuro.BackColor = Anotador.Texto.ForeColor
        ActualizaColores()
    End Sub
    Private Sub BotonFondoClaroscuro_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonFondoClaroscuro.MouseWheel
        FondoAclaraOscurece(BotonFondoClaroscuro, e)
        BotonColorLetra.ForeColor = Anotador.Texto.ForeColor
        BotonColorLetra.BackColor = Anotador.Texto.BackColor
        BotonColorFondo.ForeColor = Anotador.Texto.ForeColor
        BotonColorFondo.BackColor = Anotador.Texto.BackColor
        BotonFondoClaroscuro.BackColor = Anotador.Texto.BackColor
        BotonTextoClaroscuro.BackColor = Anotador.Texto.ForeColor
        ActualizaColores()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
    End Sub

    Private Sub Button6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button6.MouseDown
        Anotador.InvertirColores()
        ActualizaColores()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

    End Sub

    Private Sub Button7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button7.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Anotador.Herramientas.Visible = True Then
                Anotador.Herramientas.Visible = False
                Anotador.ControlMinimo.Visible = False
                Anotador.ConHerramientas = False
                Anotador.MenuTablero.Visible = False
            Else
                Anotador.Herramientas.Visible = True
                Anotador.Herramientas.Top = Anotador.Height - Anotador.Herramientas.Height - 40
                Anotador.ControlMinimo.Top = Anotador.Height - Anotador.ControlMinimo.Height - 40
                Anotador.ConHerramientas = True
                Anotador.ControlMinimo.Visible = True
                Anotador.MenuTablero.Visible = True
            End If
        Else
            Anotador.MenuTablero.Visible = False
            'Anotador.ControlBox = False
            'Anotador.Text = ""
            'Anotador.TimerTITULA.Enabled = False
            Anotador.BackColor = Anotador.Texto.BackColor
            Anotador.ForeColor = Anotador.Texto.ForeColor
            Anotador.Texto.Height = Anotador.Height
            'Anotador.Height = Screen.PrimaryScreen.Bounds.Height
            'Anotador.Top = 0
            'Anotador.Left = 0
            'Anotador.Width = Screen.PrimaryScreen.Bounds.Width
            'Anotador.Height = Screen.PrimaryScreen.Bounds.Height
            Anotador.ProduceResize()
            Anotador.Refresh()
            'RaiseEvent(Anotador.Resize())
        End If
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonExit.Click

    End Sub

    Private Sub Button18_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonExit.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Anotador.Visible = True Then
                Anotador.Visible = False
            Else
                Anotador.Visible = True
            End If
        Else
            FileClose()
            Anotador.RecaudosDeSalir()
        End If
    End Sub

    Private Sub RGBletra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RGBletra.TextChanged

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        ActualizaColores()
    End Sub
    Public Sub ActualizaColores()
        TextoBackColorPublic = Anotador.Texto.BackColor
        TextoForeColorPublic = Anotador.Texto.ForeColor
        RGBletra.Text = Anotador.Texto.ForeColor.R & " " & Anotador.Texto.ForeColor.G & " " & Anotador.Texto.ForeColor.B
        RGBfondo.Text = Anotador.Texto.BackColor.R & " " & Anotador.Texto.BackColor.G & " " & Anotador.Texto.BackColor.B
        RGBletra.BackColor = Anotador.Texto.BackColor
        RGBfondo.BackColor = Anotador.Texto.BackColor
        RGBletra.ForeColor = Anotador.Texto.ForeColor
        RGBfondo.ForeColor = Anotador.Texto.ForeColor
        'BotonColorLetra.Font.Size = 10
        BotonColorLetra.Text = Anotador.Texto.ForeColor.R & " " & Anotador.Texto.ForeColor.G & " " & Anotador.Texto.ForeColor.B
        BotonColorFondo.Text = Anotador.Texto.BackColor.R & " " & Anotador.Texto.BackColor.G & " " & Anotador.Texto.BackColor.B
        BotonColorLetra.BackColor = Anotador.Texto.BackColor
        BotonColorFondo.BackColor = Anotador.Texto.BackColor
        BotonColorLetra.ForeColor = Anotador.Texto.ForeColor
        BotonFondoClaroscuro.BackColor = Anotador.Texto.BackColor
        BotonTextoClaroscuro.BackColor = Anotador.Texto.ForeColor
        BotonColorFondo.ForeColor = Anotador.Texto.ForeColor
        Me.BackColor = Anotador.Texto.BackColor
        TextoAuxiliar.BackColor = Anotador.Texto.BackColor
        TextoAuxiliar.ForeColor = Anotador.Texto.ForeColor
    End Sub

    Private Sub TextoAuxiliar_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextoAuxiliar.DragDrop
        'Dim txt As TextBox = CType(sender, TextBox)
        'Dim dropPosition As Integer = txt.GetCharIndexFromPosition(txt.PointToClient(New Point(e.X, e.Y)))
        ' txt.Text = txt.Text.Insert(dropPosition, e.Data.GetData(DataFormats.Text).ToString())
    End Sub
    Private Sub TextoAuxiliar_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextoAuxiliar.DragEnter
        ' If e.Data.GetDataPresent(DataFormats.Text) Then
        'e.Effect = DragDropEffects.Copy
        'Else
        ' e.Effect = DragDropEffects.None
        '  End If
    End Sub
    Private Sub TextoAuxiliar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextoAuxiliar.MouseDown
        'If e.Button = MouseButtons.Left Then
        'Dim txt As TextBox = CType(sender, TextBox)
        ' If txt.SelectedText.Length > 0 Then
        'TXT.DoDragDrop(TXT.SelectedText, DragDropEffects.Copy)
        ' End If
        '  End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextoAuxiliar.TextChanged

    End Sub

    Private Sub Formato_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        TextoAuxiliar.Top = 120
        TextoAuxiliar.Left = 1
        TextoAuxiliar.Width = Me.Width - 30
        TextoAuxiliar.Height = Me.Height - 1
        TextoAuxiliar.BackColor = Anotador.Texto.BackColor
    End Sub
End Class