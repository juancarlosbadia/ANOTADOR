Public Class Director
    Dim Ancho As Decimal
    Dim Alto As Decimal
    Dim Mover As Boolean
    Dim PosMovIzq As Integer
    Dim PosMovArr As Integer
    ' Dim ValorFuente As Integer = 1
    Private Sub Director_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub
    Private Sub Director_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Mover = True
            PosMovIzq = e.X
            PosMovArr = e.Y
            Me.TopMost = True
        Else
            Me.Visible = False
            FormularioActivo(4) = False
            Anotador.Focus()
        End If
    End Sub

    Private Sub Director_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If Mover = True Then
            Me.Top = (Me.Top + e.Y - PosMovArr) ' - Me.Height / 2
            Me.Left = (Me.Left + e.X - PosMovIzq) ' - Me.Width / 2
        End If
    End Sub
    Private Sub Director_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        Mover = False
    End Sub

    Private Sub Director_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Ancho = Me.Width / 4 - 5
        Alto = (Me.Height - 5) / 4 - 5
        BotonArriba.Top = 0
        BotonArriba.Left = Ancho
        BotonArriba.Width = Ancho
        BotonArriba.Height = Alto

        BotonGuarda.Top = 0
        BotonGuarda.Left = Ancho * 2
        BotonGuarda.Width = Ancho / 2
        BotonGuarda.Height = Alto / 2

        BotonColor.Top = Alto * 2 + Alto / 2
        BotonColor.Left = Ancho * 3 + Ancho / 2
        BotonColor.Width = Ancho / 2
        BotonColor.Height = Alto / 2


        BotonAbajo.Top = Alto * 2
        BotonAbajo.Left = Ancho
        BotonAbajo.Width = Ancho
        BotonAbajo.Height = Alto
        '
        BotonRetrocede.Top = Alto
        BotonRetrocede.Left = 0
        BotonRetrocede.Width = Ancho
        BotonRetrocede.Height = Alto

        BotonAvanza.Top = Alto
        BotonAvanza.Left = Ancho * 2
        BotonAvanza.Width = Ancho
        BotonAvanza.Height = Alto

        BotonCentral.Top = Alto
        BotonCentral.Left = Ancho
        BotonCentral.Width = Ancho
        BotonCentral.Height = Alto

        BotonTam.Top = Alto * 2 + Alto / 2
        BotonTam.Left = Ancho * 3
        BotonTam.Width = Ancho / 2
        BotonTam.Height = Alto / 2

        BotonCuadro.Top = Alto * 2
        BotonCuadro.Left = Ancho * 3 + Ancho / 2
        BotonCuadro.Width = Ancho / 2
        BotonCuadro.Height = Alto / 2

        TeclaEspacio.Top = Alto * 3
        TeclaEspacio.Left = 0
        TeclaEspacio.Width = Ancho * 3
        TeclaEspacio.Height = Alto

        BotonCopia.Top = 0
        BotonCopia.Left = Ancho * 3
        BotonCopia.Width = Ancho / 2
        BotonCopia.Height = Alto

        BotonCorta.Top = 0
        BotonCorta.Left = Ancho * 3 + Ancho / 2
        BotonCorta.Width = Ancho / 2
        BotonCorta.Height = Alto

        BotonPega.Top = Alto
        BotonPega.Left = Ancho * 3
        BotonPega.Width = Ancho
        BotonPega.Height = Alto

        BotonTeclado2.Top = Alto / 2
        BotonTeclado2.Left = 0
        BotonTeclado2.Width = Ancho / 2
        BotonTeclado2.Height = Alto / 2

        BotonBorra.Top = Alto / 2
        BotonBorra.Left = Ancho / 2 'Ancho * 3
        BotonBorra.Width = Ancho / 2
        BotonBorra.Height = Alto / 2

        BotonFuente.Top = Alto * 2
        BotonFuente.Left = Ancho * 3
        BotonFuente.Width = Ancho / 2
        BotonFuente.Height = Alto / 2

        BotonEnter.Top = Alto * 3
        BotonEnter.Left = Ancho * 3
        BotonEnter.Width = Ancho
        BotonEnter.Height = Alto

        BotonTransparencia.Top = Alto * 2
        BotonTransparencia.Left = Ancho * 2
        BotonTransparencia.Width = Ancho
        BotonTransparencia.Height = Alto

        BotonTeclado.Width = Ancho / 3
        BotonTeclado.Height = Alto / 3
        BotonTeclado.Top = 0 'Alto - BotonTeclado.Height
        BotonTeclado.Left = Ancho - BotonTeclado.Width  'Ancho * 2 + Ancho / 4
        

        BotonMayusculasIniciales.Top = Alto * 2
        BotonMayusculasIniciales.Left = 0
        BotonMayusculasIniciales.Width = Ancho / 2
        BotonMayusculasIniciales.Height = Alto / 2

        BotonTodoMayMin.Top = Alto * 2
        BotonTodoMayMin.Left = Ancho / 2
        BotonTodoMayMin.Width = Ancho / 2
        BotonTodoMayMin.Height = Alto / 2

        BotonAentuarDesacentuar.Top = Alto * 2 + Alto / 2
        BotonAentuarDesacentuar.Left = 0
        BotonAentuarDesacentuar.Width = Ancho / 2
        BotonAentuarDesacentuar.Height = Alto / 2

       

    End Sub

    Private Sub BotonRetrocede_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonRetrocede.Click

    End Sub

    Private Sub BotonRetrocede_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonRetrocede.MouseDown
        HorizontalVertical = True
        If e.Button = Windows.Forms.MouseButtons.Left Then
            AtrasAdelante = True
            ConShift = False
        Else
            AtrasAdelante = True
            ConShift = True
        End If
        Anotador.Direcciones()
        InvierteColorSuenaTecla(BotonRetrocede)
        SuenaScroll()
        BotonRetrocede.BackColor = Inviertecolor(TecladoColorFondo1)
        BotonRetrocede.ForeColor = Inviertecolor(TecladoColorLetraTeclas)
    End Sub

    Private Sub BotonRetrocede_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonRetrocede.MouseHover
        IluminaColorTecla(BotonRetrocede)
    End Sub

    Private Sub BotonRetrocede_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonRetrocede.MouseLeave
        Anotador.TimerActivaScrollAutomatico.Enabled = False
        Anotador.TimerAvanzaRetrocedeAuto.Enabled = False
        RestauraColorTecla2(BotonRetrocede)
    End Sub

    Private Sub BotonRetrocede_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonRetrocede.MouseUp
        Anotador.TimerActivaScrollAutomatico.Enabled = False
        Anotador.TimerAvanzaRetrocedeAuto.Enabled = False
        RestauraColorTecla2(BotonRetrocede)
    End Sub
    Private Sub BotonAvanza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAvanza.Click
    End Sub
    Private Sub BotonAvanza_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonAvanza.MouseDown
        HorizontalVertical = True
        If e.Button = Windows.Forms.MouseButtons.Left Then
            AtrasAdelante = False
            ConShift = False
        Else
            AtrasAdelante = False
            ConShift = True
        End If
        Anotador.Direcciones()
        InvierteColorSuenaTecla(BotonAvanza)
        SuenaScroll()
        BotonAvanza.BackColor = Inviertecolor(TecladoColorFondo1)
        BotonAvanza.ForeColor = Inviertecolor(TecladoColorLetraTeclas)
    End Sub

    Private Sub BotonAvanza_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonAvanza.MouseHover
        IluminaColorTecla(BotonAvanza)
    End Sub

    Private Sub BotonAvanza_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonAvanza.MouseLeave
        Anotador.TimerActivaScrollAutomatico.Enabled = False
        Anotador.TimerAvanzaRetrocedeAuto.Enabled = False
        RestauraColorTecla2(BotonAvanza)
    End Sub

    Private Sub BotonAvanza_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonAvanza.MouseUp
        Anotador.TimerActivaScrollAutomatico.Enabled = False
        Anotador.TimerAvanzaRetrocedeAuto.Enabled = False
        RestauraColorTecla2(BotonAvanza)
    End Sub

    Private Sub BotonArriba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonArriba.Click
    End Sub

    Private Sub BotonArriba_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonArriba.MouseDown
        HorizontalVertical = False
        AtrasAdelante = True
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ConShift = False
        Else
            ConShift = True
        End If
        Anotador.Direcciones()
        InvierteColorSuenaTecla(BotonArriba)
        SuenaScroll()
        BotonArriba.BackColor = Inviertecolor(TecladoColorFondo1)
        BotonArriba.ForeColor = Inviertecolor(TecladoColorLetraTeclas)
    End Sub

    Private Sub BotonArriba_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonArriba.MouseHover
        IluminaColorTecla(BotonArriba)
    End Sub

    Private Sub BotonArriba_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonArriba.MouseLeave
        Anotador.TimerActivaScrollAutomatico.Enabled = False
        Anotador.TimerAvanzaRetrocedeAuto.Enabled = False
        RestauraColorTecla2(BotonArriba)
    End Sub

    Private Sub BotonArriba_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonArriba.MouseUp
        Anotador.TimerActivaScrollAutomatico.Enabled = False
        Anotador.TimerAvanzaRetrocedeAuto.Enabled = False
        RestauraColorTecla2(BotonArriba)
    End Sub

    Private Sub BotonAbajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAbajo.Click
    End Sub

    Private Sub BotonAbajo_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonAbajo.MouseDown
        HorizontalVertical = False
        AtrasAdelante = False
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ConShift = False
        Else
            ConShift = True
        End If
        Anotador.Direcciones()
        InvierteColorSuenaTecla(BotonAbajo)
        SuenaScroll()
        BotonAbajo.BackColor = Inviertecolor(TecladoColorFondo1)
        BotonAbajo.ForeColor = Inviertecolor(TecladoColorLetraTeclas)
    End Sub

    Private Sub BotonAbajo_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonAbajo.MouseHover
        IluminaColorTecla(BotonAbajo)
    End Sub

    Private Sub BotonAbajo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonAbajo.MouseLeave
        Anotador.TimerActivaScrollAutomatico.Enabled = False
        Anotador.TimerAvanzaRetrocedeAuto.Enabled = False
        RestauraColorTecla2(BotonAbajo)
    End Sub

    Private Sub BotonAbajo_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonAbajo.MouseUp
        Anotador.TimerActivaScrollAutomatico.Enabled = False
        Anotador.TimerAvanzaRetrocedeAuto.Enabled = False
        RestauraColorTecla2(BotonAbajo)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonTransparencia.Click
    End Sub
    Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonTransparencia.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.Opacity = Me.Opacity + 0.05

        Else
            Me.Opacity = Me.Opacity - 0.05
            If Me.Opacity < 0.3 Then Me.Opacity = 0.4
        End If
        Teclado.Opacity = Me.Opacity
    End Sub

    Private Sub BotonCentral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonCentral.Click

    End Sub

    Private Sub BotonCentral_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonCentral.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            SendKeys.Send("^{Z}")
        Else
            Anotador.Texto.SelectionStart = 0
            Anotador.Texto.SelectionLength = Anotador.Texto.TextLength
        End If

        Anotador.Texto.ScrollToCaret()
        ' BotonRepiteAscii.Text = LetraElegida
        Anotador.Texto.Focus()
        'SendKeys.Send("^(Z)")
    End Sub
    Private Sub BotonCentral_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonCentral.MouseHover
        'IluminaColorTecla(BotonCentral)
    End Sub
    Private Sub BotonCentral_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonCentral.MouseLeave
        RestauraColorTecla3(BotonCentral)
    End Sub
    Private Sub BotonCentral_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonCentral.MouseUp
        RestauraColorTecla3(BotonCentral)
    End Sub
    Private Sub BotonCopia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonCopia.Click
    End Sub

    Private Sub BotonCopia_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonCopia.DoubleClick

    End Sub

    Private Sub BotonCopia_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonCopia.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Anotador.TextoCopiadoTeclado0 = Anotador.Texto.SelectedText
            Anotador.Texto.Focus()
            InvierteColorSuenaTecla(BotonCopia)
        Else
            Clipboard.SetText(Anotador.Texto.SelectedText)
            InvierteColorSuenaTecla(BotonCopia)
        End If

    End Sub

    Private Sub BotonCopia_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonCopia.MouseHover
        IluminaColorTecla(BotonCopia)
    End Sub
    Private Sub BotonCopia_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonCopia.MouseLeave
        RestauraColorTecla2(BotonCopia)
    End Sub

    Private Sub BotonCopia_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonCopia.MouseUp
        RestauraColorTecla2(BotonCopia)
    End Sub

    Private Sub BotonPega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonPega.Click

    End Sub

    Private Sub BotonPega_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonPega.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Anotador.Pega(Anotador.TextoCopiadoTeclado0, Anotador.Texto.SelectedText)
        Else
            Teclado.PegaPortapapeles(Anotador.Texto.SelectedText)
        End If
        InvierteColorSuenaTecla(BotonPega)
    End Sub

    Private Sub BotonPega_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonPega.MouseHover
        IluminaColorTecla(BotonPega)
    End Sub
    Private Sub BotonPega_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonPega.MouseLeave
        RestauraColorTecla2(BotonPega)
    End Sub

    Private Sub BotonPega_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonPega.MouseUp
        RestauraColorTecla2(BotonPega)
    End Sub

    Private Sub BotonBorra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonBorra.Click
    End Sub

    Private Sub BotonBorra_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonBorra.MouseDown
        If Len(Anotador.Texto.SelectedText) <> 0 Then
            Anotador.BorraSeleccionado(Anotador.Texto.SelectedText)
            SuenaGoma()
            Exit Sub
        Else
            If e.Button = Windows.Forms.MouseButtons.Left Then
                Anotador.RetrocedeBorra()
            Else
                Anotador.AvanzaBorra()
            End If
        End If
        SuenaGoma()
        BotonBorra.BackColor = Inviertecolor(TecladoColorFondo1)
        BotonBorra.ForeColor = Inviertecolor(TecladoColorLetraTeclas)
    End Sub

    Private Sub BotonBorra_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonBorra.MouseHover
        IluminaColorTecla(BotonBorra)
    End Sub
    Private Sub BotonBorra_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonBorra.MouseLeave
        RestauraColorTecla2(BotonBorra)
        Anotador.TimerBorraAuto.Enabled = False
        Anotador.TimerScrollBorraAuto.Enabled = False
    End Sub
    Private Sub BotonBorra_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonBorra.MouseUp
        RestauraColorTecla2(BotonBorra)
        Anotador.TimerBorraAuto.Enabled = False
        Anotador.TimerScrollBorraAuto.Enabled = False
    End Sub

    Private Sub BotonEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonEnter.Click

    End Sub

    Private Sub BotonEnter_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonEnter.MouseDown
        Dim varchr = vbCrLf '        Chr(13) 'vbenter 'Chr(10) & Chr(13)
        Teclado.PoneTeclaEnter(varchr)
        InvierteColorSuenaTecla(BotonEnter)
    End Sub
    Private Sub BotonEnter_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonEnter.MouseHover
        IluminaColorTecla(BotonEnter)
    End Sub
    Private Sub BotonEnter_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonEnter.MouseLeave
        RestauraColorTecla3(BotonEnter)
    End Sub
    Private Sub BotonEnter_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonEnter.MouseUp
        RestauraColorTecla3(BotonEnter)
    End Sub

    Private Sub TeclaEspacio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaEspacio.Click

    End Sub

    Private Sub TeclaEspacio_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaEspacio.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then

            InvierteColorSuenaTecla(TeclaEspacio)
            LetraElegida = " "
            Teclado.PoneLetra()

        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub

    Private Sub TeclaEspacio_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaEspacio.MouseHover
        ' IluminaColorTecla(TeclaEspacio)
    End Sub

    Private Sub TeclaEspacio_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaEspacio.MouseLeave
        MouseLeaveTecla2(TeclaEspacio)
    End Sub

    Private Sub TeclaEspacio_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaEspacio.MouseUp
        MouseUpTecla2(TeclaEspacio)
    End Sub
    Private Sub BotonTeclado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonTeclado.Click

    End Sub

    Private Sub BotonTeclado_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonTeclado.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Anotador.MinimizaFormulario()
            Exit Sub
            If Anotador.Minimizado = False Then
                Anotador.Posiciones00()
                Anotador.Texto.Focus()
            Else
                Anotador.ExpandeAnotador()
                Anotador.Texto.Focus()
            End If
        Else

            Me.Visible = False
            FormularioActivo(4) = False
            Anotador.Focus()
        End If
    End Sub

    Private Sub BotonTeclado_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonTeclado.MouseHover
        Anotador.TopMost = True
        Anotador.TopMost = False
        Me.TopMost = True
    End Sub

    Private Sub BotonAentuarDesacentuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAentuarDesacentuar.Click

    End Sub

    Private Sub BotonAcentuarDesacentuar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonAentuarDesacentuar.MouseDown

        Anotador.BotonAcentuarDesacentuar_MouseDown(sender, e)

        Exit Sub

        If e.Button = Windows.Forms.MouseButtons.Left Then
            Anotador.SeleccionaVocal()
            Anotador.Acentuar()
        Else
            Anotador.SeleccionaVocal()
            Anotador.DesAcentuar()
        End If
        SuenaTic()
    End Sub

    Private Sub BotonMayusculasIniciales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonMayusculasIniciales.Click



    End Sub

    Private Sub BotonMayusculasIniciales_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonMayusculasIniciales.MouseDown

        'Anotador.BotonMayusculasIniciales_MouseDown(sender, e)
        Anotador.CuadroAlBorde()

        If e.Button = Windows.Forms.MouseButtons.Left Then
            Anotador.SeleccionaPalabra()
            Anotador.ConvertirMayusculasIniciales()
        Else
            Anotador.SeleccionaPalabra()
            Anotador.ConvertirMayusculasMinusculas(Anotador.Texto.SelectedText, False)
        End If

        

        'SuenaTic()
    End Sub

    Private Sub BotonTodoMayMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonTodoMayMin.Click

    End Sub

    Private Sub BotonTodoMayMin_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonTodoMayMin.MouseDown

        'Anotador.BotonTodoMayMin_MouseDown(sender, e)

        Anotador.CuadroAlBorde()
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Anotador.SeleccionaPalabra()
            Anotador.ConvertirMayusculasMinusculas(Anotador.Texto.SelectedText, True)
        Else
            Anotador.SeleccionaPalabra()
            Anotador.ConvertirMayusculasMinusculas(Anotador.Texto.SelectedText, False)
        End If
        'SuenaTic()
    End Sub

    Private Sub BotonTeclado2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonTeclado2.DoubleClick
        'Teclado.Width = Teclado.Width * 1.5
        'Teclado.Height = Teclado.Height * 1.5
    End Sub

    Private Sub BotonTeclado2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonTeclado2.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            TecladoRedimensionable = True
            If Teclado.Visible = True Then
                Teclado.Width = Teclado.Width * 1.1
                Teclado.Height = Teclado.Height * 1.1
                Teclado.Top = Me.Top
                Teclado.Left = Me.Left + Me.Width 'Screen.PrimaryScreen.Bounds.Width / 4
            Else
                Teclado.Visible = True
                Teclado.Top = Me.Top
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
                Teclado.Top = Me.Top
                Teclado.Left = Me.Left + Me.Width 'Screen.PrimaryScreen.Bounds.Width / 4
            End If
        End If
        If Teclado.Top > Screen.PrimaryScreen.Bounds.Height - Teclado.Height Then
            Teclado.Top = Screen.PrimaryScreen.Bounds.Height - Teclado.Height * 1.1
        End If


    End Sub

    Private Sub BotonGuarda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonGuarda.Click

    End Sub

    Private Sub BotonGuarda_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonGuarda.MouseDown
        Anotador.Button29_MouseDown(sender, e)
    End Sub

    Private Sub ButtonColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonColor.Click

    End Sub

    Private Sub ButtonColor_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonColor.MouseDown
        Anotador.Botoncolor_MouseDown(sender, e)
    End Sub

    Private Sub BotonMayusculasIniciales_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonMayusculasIniciales.MouseUp
        
    End Sub

    Private Sub BotonFuente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonFuente.Click

    End Sub

    Private Sub BotonFuente_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonFuente.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Left Then
            FormatoFuente(0)
        Else
            FormatoFuente(1)
        End If
    End Sub
    

    Private Sub BotonTam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonTam.Click

    End Sub

    Private Sub BotonTam_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonTam.MouseDown
        Anotador.BotonMasMenos_MouseDown(sender, e)


    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonCuadro.Click

    End Sub

    Private Sub BotonCuadro_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonCuadro.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Left Then
            Anotador.Mas()

        Else
            Anotador.Menos()
        End If

       

    End Sub

    Private Sub BotonCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

  
    Private Sub BotonTeclado2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonTeclado2.Click

    End Sub

    Private Sub BotonCorta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonCorta.Click

    End Sub

    Private Sub BotonCorta_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonCorta.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Anotador.TextoCopiadoTeclado0 = Anotador.Texto.SelectedText
            Anotador.Texto.Focus()
            InvierteColorSuenaTecla(BotonCopia)
        Else
            Clipboard.SetText(Anotador.Texto.SelectedText)
            InvierteColorSuenaTecla(BotonCopia)
        End If
        SendKeys.Send("{BACKSPACE}")
    End Sub

    Private Sub BotonCorta_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonCorta.MouseHover
        IluminaColorTecla(BotonCorta)
    End Sub

    Private Sub BotonCorta_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonCorta.MouseLeave
        RestauraColorTecla2(BotonCorta)
    End Sub

    Private Sub BotonCorta_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonCorta.MouseUp
        RestauraColorTecla2(BotonCorta)
    End Sub

    Private Sub BotonPega_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonPega.MouseWheel

       
    End Sub

    Public Sub ValorColor(ByVal suma As Integer, ByRef Canal As Integer)
        Canal = Canal + suma
        If Canal > 255 Then Canal = 255
        If Canal < 1 Then Canal = 1
    End Sub

    Private Sub TeclaEspacio_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaEspacio.MouseWheel

        ManejaBackColor(TeclaEspacio, e)
        Exit Sub


        Dim suma As Integer
        Dim rojo As Integer
        Dim verde As Integer
        Dim azul As Integer
        Dim Ancho As Integer = TeclaEspacio.Width / 3

        rojo = Anotador.Texto.BackColor.R
        verde = Anotador.Texto.BackColor.G
        azul = Anotador.Texto.BackColor.B

        If e.Delta > 0 Then
            suma = 4
        ElseIf e.Delta < 0 Then
            suma = -4
        End If

        If e.X < Ancho Then
            ValorColor(suma, rojo)
        End If
        If e.X > Ancho And e.X < Ancho * 2 Then
            ValorColor(suma, verde)
        End If
        If e.X > Ancho * 2 Then
            ValorColor(suma, azul)
        End If
        TextoBackColorPublic = Color.FromArgb(rojo, verde, azul)
        Anotador.Texto.BackColor = Color.FromArgb(rojo, verde, azul)
        Anotador.ActualizaColores()
        TeclaEspacio.BackColor = Anotador.Texto.BackColor
    End Sub



    Private Sub BotonCentral_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonCentral.MouseWheel
        ManejaForeColor(BotonCentral, e)
        Exit Sub

        Dim suma As Integer
        Dim rojo As Integer
        Dim verde As Integer
        Dim azul As Integer
        Dim Ancho As Integer = BotonCentral.Width / 3

        rojo = Anotador.Texto.ForeColor.R
        verde = Anotador.Texto.ForeColor.G
        azul = Anotador.Texto.ForeColor.B

        If e.Delta > 0 Then
            suma = 4
        ElseIf e.Delta < 0 Then
            suma = -4
        End If

        If e.X < Ancho Then
            ValorColor(suma, rojo)
        End If
        If e.X > Ancho And e.X < Ancho * 2 Then
            ValorColor(suma, verde)
        End If
        If e.X > Ancho * 2 Then
            ValorColor(suma, azul)
        End If
        TextoBackColorPublic = Anotador.Texto.BackColor
        TextoForeColorPublic = Color.FromArgb(rojo, verde, azul)
        Anotador.Texto.ForeColor = Color.FromArgb(rojo, verde, azul)
        Anotador.ActualizaColores()
    End Sub
   
   
    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles ToolTip1.Popup

    End Sub
End Class