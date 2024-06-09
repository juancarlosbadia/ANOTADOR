Public Class TecladoLetras
    Dim LetraMayúscula = False
    Dim FijaMayúsculas = False
    Dim Acentuada = False
    Dim Dieresis = False
    'Dim Tabla(385) As String

    'Dim TeclaPresionada As String

    'Dim DisparoAutomatico As Boolean = True






    Public Sub PoneLetra()
        'Dim Keys As Boolean = True
        If AKeys = True Then
            If FijaMayúsculas = False Then PoneMinusculas()
            If LetraElegida = " " Then 'vbCrLf Or LetraElegida = Chr(13) & Chr(10) 
                SendKeys.Send(LetraElegida)
            ElseIf LetraElegida = Chr(13) & Chr(10) Then
                SendKeys.Send(vbCr)
            Else
                SendKeys.Send("{" & LetraElegida & "}")
            End If

            Anotador.Texto.ScrollToCaret()
            FormAuxiliar.BotonRepiteAscii.Text = LetraElegida
            'Anotador.Texto.Focus()
            RestauraColorTecla3(TeclaAcento)
            Acentuada = False
            Dieresis = False
            Exit Sub
            'LetraElegida
        End If
        If FijaMayúsculas = False Then PoneMinusculas()
        Anotador.PosiciónDeInicio = Anotador.Texto.SelectionStart
        Anotador.PosiciónDeFinalSeleccion = Anotador.Texto.SelectionStart + Len(Anotador.Texto.SelectedText)
        Dim TextoAnterior = Anotador.Texto.Text.Substring(0, Anotador.PosiciónDeInicio)
        Dim TextoPosterior = Anotador.Texto.Text.Substring(Anotador.PosiciónDeFinalSeleccion, Anotador.Texto.Text.Length() - Anotador.PosiciónDeFinalSeleccion)
        Anotador.Texto.Text = TextoAnterior & LetraElegida & TextoPosterior
        Anotador.Texto.SelectionStart = Len(TextoAnterior) + 1
        Anotador.Texto.ScrollToCaret()
        FormAuxiliar.BotonRepiteAscii.Text = LetraElegida
        Anotador.Texto.Focus()
        ' Temas varios
        RestauraColorTecla3(TeclaAcento)
        Acentuada = False
        Dieresis = False
    End Sub
    Private Sub Posicionesb()
        If FijaMayúsculas = False Then PoneMinusculas()
        Anotador.PosiciónDeInicio = Anotador.Texto.SelectionStart
        Anotador.PosiciónDeFinalSeleccion = Anotador.Texto.SelectionStart + Len(Anotador.Texto.SelectedText)
        Dim TextoAnterior = Anotador.Texto.Text.Substring(0, Anotador.PosiciónDeInicio)
        Dim TextoPosterior = Anotador.Texto.Text.Substring(Anotador.PosiciónDeFinalSeleccion, Anotador.Texto.Text.Length() - Anotador.PosiciónDeFinalSeleccion)
        Anotador.Texto.Text = TextoAnterior & LetraElegida & TextoPosterior
        Anotador.Texto.SelectionStart = Len(TextoAnterior) + 1
        Anotador.Texto.ScrollToCaret()
        FormAuxiliar.BotonRepiteAscii.Text = LetraElegida
        Anotador.Texto.Focus()
        ' Temas varios
        RestauraColorTecla3(TeclaAcento)
        Acentuada = False
        Dieresis = False
    End Sub

    Private Sub InsertaTexto(ByVal TextoAInsertar As String, ByVal Seleccionado As String)
        If FijaMayúsculas = False Then PoneMinusculas()
        Anotador.PosiciónDeInicio = Anotador.Texto.SelectionStart
        Anotador.PosiciónDeFinalSeleccion = Anotador.Texto.SelectionStart + Len(Seleccionado)
        Dim TextoAnterior = Anotador.Texto.Text.Substring(0, Anotador.PosiciónDeInicio)
        Dim TextoPosterior = Anotador.Texto.Text.Substring(Anotador.PosiciónDeFinalSeleccion, Anotador.Texto.Text.Length() - Anotador.PosiciónDeFinalSeleccion)
        Anotador.Texto.Text = TextoAnterior & TextoAInsertar & TextoPosterior
        Anotador.Texto.SelectionStart = Len(TextoAnterior) + 1
        Anotador.Texto.ScrollToCaret()
        FormAuxiliar.BotonRepiteAscii.Text = TextoAInsertar
        'Anotador.Texto.Cursor.Show()
        Anotador.Texto.Focus()
    End Sub


    Public Sub PoneTeclaEnter(ByVal a As String)
        If AKeys = True Then
            SendKeys.Send("{ENTER}")
            Anotador.Texto.ScrollToCaret()
            Anotador.Texto.Focus()
            Exit Sub
        End If
        Anotador.PosiciónDeInicio = Anotador.Texto.SelectionStart
        Dim TextoAnterior = Anotador.Texto.Text.Substring(0, Anotador.PosiciónDeInicio)
        Dim TextoPosterior = Anotador.Texto.Text.Substring(Anotador.PosiciónDeInicio, Anotador.Texto.Text.Length() - Anotador.PosiciónDeInicio)
        Anotador.Texto.Text = TextoAnterior & a & TextoPosterior
        Anotador.Texto.SelectionStart = Len(TextoAnterior) + 2
        Anotador.Texto.ScrollToCaret()
        Anotador.Texto.Focus()
    End Sub



    Private Sub Teclado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Anotador.TopMost = False
        'CargaTabladeCaracteres()
        'TecladoColorPredeterminado()
        'CambiaColorTeclado(TecladoColorFondo1, TecladoColorFondo2, TecladoColorFondo3, TecladoColorFondoListas, TecladoColorLetraTeclas, TecladoColorLetraListas)


        Dim difb = 15
        Dim difa = 15


        Me.Width = TeclaMayusculas.Left + TeclaMayusculas.Width + difa
        'Me.Width = BotonAbrir.Left + BotonAbrir.Width + 5
        BotonAbrir.Text = "<"

        'Me.Width = BotonAbrir.Left + BotonAbrir.Width + difa
        'BotonAbrir.Text = ">"

        'Me.Height = ListaRecortes.Top + ListaRecortes.Height + 30 + difb
        'Me.Width = TeclaMayusculas.Left + TeclaMayusculas.Width + difa
        'BotonAbrir.Text = "<"

        Me.Height = Boton0.Top + Boton0.Height + 23 + difb
        'BotonAbrir.Text = ">"

    End Sub

    Public Sub Copia(ByVal Seleccionado As String)
        Anotador.TextoCopiadoTeclado = Seleccionado
        Anotador.Texto.Focus()
        'Anotador.PosiciónDeInicio = Anotador.Texto.SelectionStart
        'Anotador.PosiciónDeFinalSeleccion = Anotador.Texto.SelectionStart + Len(Seleccionado)
        'Anotador.Texto.SelectionStart = Anotador.PosiciónDeFinalSeleccion
    End Sub
    Public Sub Pega(ByVal Seleccionado As String)
        Anotador.PosiciónDeInicio = Anotador.Texto.SelectionStart
        Anotador.PosiciónDeFinalSeleccion = Anotador.Texto.SelectionStart + Len(Seleccionado)
        Dim TextoAnterior = Anotador.Texto.Text.Substring(0, Anotador.PosiciónDeInicio)
        Dim TextoPosterior = Anotador.Texto.Text.Substring(Anotador.PosiciónDeFinalSeleccion, Anotador.Texto.Text.Length() - Anotador.PosiciónDeFinalSeleccion)
        Anotador.Texto.Text = TextoAnterior & Anotador.TextoCopiadoTeclado & TextoPosterior
        Anotador.Texto.SelectionStart = Len(TextoAnterior) + Len(Anotador.TextoCopiadoTeclado)
        Anotador.Texto.ScrollToCaret()
        Anotador.Texto.Focus()
    End Sub
    Public Sub PegaPortapapeles(ByVal Seleccionado As String)
        Anotador.PosiciónDeInicio = Anotador.Texto.SelectionStart
        Anotador.PosiciónDeFinalSeleccion = Anotador.Texto.SelectionStart + Len(Seleccionado)
        Dim TextoAnterior = Anotador.Texto.Text.Substring(0, Anotador.PosiciónDeInicio)
        Dim TextoPosterior = Anotador.Texto.Text.Substring(Anotador.PosiciónDeFinalSeleccion, Anotador.Texto.Text.Length() - Anotador.PosiciónDeFinalSeleccion)
        Anotador.Texto.Text = TextoAnterior & Clipboard.GetText & TextoPosterior
        Anotador.Texto.SelectionStart = Len(TextoAnterior) + Len(Clipboard.GetText)
        Anotador.Texto.ScrollToCaret()
        Anotador.Texto.Focus()
    End Sub

    Private Sub Mayusculas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaMayusculas.Click
    End Sub
    Private Sub Mayusculas_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaMayusculas.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If LetraMayúscula = True Then
                LetraMayúscula = False
                FijaMayúsculas = False
                PoneMinusculas()
            Else
                LetraMayúscula = True
                PoneMayusculas()
                FijaMayúsculas = False
            End If

        Else
            If LetraMayúscula = True Then
                LetraMayúscula = False
                FijaMayúsculas = False
                PoneMinusculas()
            Else
                LetraMayúscula = True
                PoneMayusculas()
                FijaMayúsculas = True

            End If
        End If
        SuenaMay()
        TeclaMayusculas.BackColor = Inviertecolor(TecladoColorFondo1)
        TeclaMayusculas.ForeColor = Inviertecolor(TecladoColorLetraTeclas)
        'InvierteColorSuenaTecla(TeclaMayusculas)
    End Sub
    Private Sub TeclaMayusculas_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaMayusculas.MouseHover
        If DisparoAutomatico = True Then
            PoneLetrasMayusculasAuto()
        End If
        IluminaColorTecla(TeclaMayusculas)
    End Sub

    Private Sub TeclaMayusculas_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaMayusculas.MouseLeave
        RestauraColorTecla3(TeclaMayusculas)
    End Sub

    Private Sub TeclaMayusculas_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaMayusculas.MouseUp
        RestauraColorTecla3(TeclaMayusculas)
    End Sub
    Private Sub PoneLetrasMayusculasAuto()
        If LetraMayúscula = True Then
            LetraMayúscula = False
            FijaMayúsculas = False
            PoneMinusculas()
        Else
            LetraMayúscula = True
            PoneMayusculas()
            FijaMayúsculas = False
        End If
        SuenaMay()
    End Sub
    Private Sub PoneMayusculas()
        LetraA.Text = "A"
        LetraB.Text = "B"
        LetraC.Text = "C"
        LetraD.Text = "D"
        LetraE.Text = "E"
        LetraF.Text = "F"
        LetraG.Text = "G"
        LetraH.Text = "H"
        LetraI.Text = "I"
        LetraJ.Text = "J"
        LetraK.Text = "K"
        LetraL.Text = "L"
        LetraM.Text = "M"
        LetraN.Text = "N"
        LetraÑ.Text = "Ñ"
        LetraO.Text = "O"
        LetraP.Text = "P"
        LetraQ.Text = "Q"
        LetraR.Text = "R"
        LetraS.Text = "S"
        LetraT.Text = "T"
        LetraU.Text = "U"
        LetraV.Text = "V"
        LetraW.Text = "W"
        LetraX.Text = "X"
        LetraY.Text = "Y"
        LetraZ.Text = "Z"
        TeclaPunto.Text = ":"
        TeclaComa.Text = ";"
        TeclaGuion.Text = "_"
        TeclaComillas.Text = "'"
        TeclaNumeral.Text = "|"
        TeclaPesos.Text = "@"
        TeclaPorCiento.Text = "*"
        TeclaAbreParentesis.Text = "["
        TeclaCierraParentesis.Text = "]"
        TeclaAbreInterrogacion.Text = "{"
        TeclaCierraInterrogacion.Text = "}"
        TeclaAbreAdmiracion.Text = "«"
        TeclaCierraAdmiracion.Text = "»"
        TeclaBarra.Text = "\"
        TeclaOrdinal.Text = "ª"
        TeclaGuionLargo.Text = "•"
        Anotador.Texto.Focus()
    End Sub
    Private Sub PoneMinusculas()
        If FijaMayúsculas = True Then Exit Sub
        LetraMayúscula = False
        LetraA.Text = "a"
        LetraB.Text = "b"
        LetraC.Text = "c"
        LetraD.Text = "d"
        LetraE.Text = "e"
        LetraF.Text = "f"
        LetraG.Text = "g"
        LetraH.Text = "h"
        LetraI.Text = "i"
        LetraJ.Text = "j"
        LetraK.Text = "k"
        LetraL.Text = "l"
        LetraM.Text = "m"
        LetraN.Text = "n"
        LetraÑ.Text = "ñ"
        LetraO.Text = "o"
        LetraP.Text = "p"
        LetraQ.Text = "q"
        LetraR.Text = "r"
        LetraS.Text = "s"
        LetraT.Text = "t"
        LetraU.Text = "u"
        LetraV.Text = "v"
        LetraW.Text = "w"
        LetraX.Text = "x"
        LetraY.Text = "y"
        LetraZ.Text = "z"
        TeclaPunto.Text = "."
        TeclaComa.Text = ","
        TeclaGuion.Text = "-"
        TeclaComillas.Text = """"
        TeclaNumeral.Text = "#"
        TeclaPesos.Text = "$"
        TeclaPorCiento.Text = "%"
        TeclaAbreParentesis.Text = "("
        TeclaCierraParentesis.Text = ")"
        TeclaAbreInterrogacion.Text = "¿"
        TeclaCierraInterrogacion.Text = "?"
        TeclaAbreAdmiracion.Text = "¡"
        TeclaCierraAdmiracion.Text = "!"
        TeclaBarra.Text = "/"
        TeclaOrdinal.Text = "º"
        TeclaGuionLargo.Text = "—"
        Anotador.Texto.Focus()
    End Sub
    Private Sub LetraA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraA.Click
    End Sub
    Private Sub LetraA_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraA.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(LetraA)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Public Sub MouseDownTecla(ByVal Tecla As System.Windows.Forms.Button)
        InvierteColorSuenaTecla(Tecla)
        'EligeLetraA(Tecla)
        PoneLetra()
        ActivarRepeticion()
        DesactivaTimerOprimirAuto()
    End Sub

    Private Sub TextoLetraA()
        If Acentuada = False And Dieresis = False Then
            LetraElegida = LetraA.Text
        ElseIf Acentuada = True Then
            If LetraA.Text = "A" Then
                LetraElegida = "Á"
            Else
                LetraElegida = "á"
            End If
            'Acentuada = False
            'TeclaAcento.BackColor = Nothing
        ElseIf Dieresis = True Then
            If LetraA.Text = "A" Then
                LetraElegida = "Ä"
            Else
                LetraElegida = "ä"
            End If
            'Dieresis = False
            'TeclaAcento.BackColor = Nothing
        End If
    End Sub
    Private Sub ActivarRepeticion()
        TimerActivaRepeticion.Enabled = True
    End Sub
    Private Sub ActivaTimerOprimirAuto()
        If DisparoAutomatico = True Then
            TimerOprimirAuto.Enabled = True
        End If
    End Sub
    Private Sub DesactivaTimerOprimirAuto()
        TimerOprimirAuto.Enabled = False
    End Sub
    Private Sub LetraA_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraA.MouseHover
        TextoLetraA()
        MouseHoverTecla(LetraA)
    End Sub

    Private Sub LetraA_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraA.MouseLeave
        MouseLeaveTecla(LetraA)
    End Sub




    Private Sub LetraA_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraA.MouseUp
        MouseUpTecla(LetraA)
    End Sub


    Private Sub LetraS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraS.Click
    End Sub
    Private Sub LetraS_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraS.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(LetraS)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraS()
        LetraElegida = LetraS.Text
    End Sub
    Private Sub LetraS_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraS.MouseHover
        TextoLetraS()
        MouseHoverTecla(LetraS)
    End Sub

    Private Sub LetraS_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraS.MouseLeave
        MouseLeaveTecla(LetraS)

    End Sub
    Private Sub LetraS_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraS.MouseUp
        MouseUpTecla(LetraS)

    End Sub
    Private Sub AsciiComentado_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'If ListaAsciiComentado.SelectedIndex < 0 Then Exit Sub
        'BotonRepiteAscii.Text = Tabla(ListaAsciiComentado.SelectedIndex)

    End Sub

    Private Sub AsciiComentado_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AsciiComentado_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AsciiComentado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Public Function FuncionCaracter(ByVal Codigo As Integer) As String
        Dim Caracter As String = ""
        Return Caracter
    End Function

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
        'InvierteColorSuenaTecla(BotonBorra)
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
    Private Sub BAvanzaRetrocede_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAvanzaRetrocede.Click
    End Sub
    Private Sub BAvanzaRetrocede_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonAvanzaRetrocede.MouseDown
        HorizontalVertical = True
        If e.Button = Windows.Forms.MouseButtons.Left Then
            AtrasAdelante = True
        Else
            AtrasAdelante = False
        End If
        Anotador.Direcciones()
        InvierteColorSuenaTecla(BotonAvanzaRetrocede)
        SuenaScroll()
        BotonAvanzaRetrocede.BackColor = Inviertecolor(TecladoColorFondo1)
        BotonAvanzaRetrocede.ForeColor = Inviertecolor(TecladoColorLetraTeclas)
    End Sub
    Private Sub BotonAvanzaRetrocede_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonAvanzaRetrocede.MouseHover
        IluminaColorTecla(BotonAvanzaRetrocede)
    End Sub
    Private Sub BotonAvanzaRetrocede_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonAvanzaRetrocede.MouseLeave
        Anotador.TimerActivaScrollAutomatico.Enabled = False
        Anotador.TimerAvanzaRetrocedeAuto.Enabled = False
        RestauraColorTecla2(BotonAvanzaRetrocede)
    End Sub
    Private Sub BAvanzaRetrocede_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonAvanzaRetrocede.MouseUp
        Anotador.TimerActivaScrollAutomatico.Enabled = False
        Anotador.TimerAvanzaRetrocedeAuto.Enabled = False
        RestauraColorTecla2(BotonAvanzaRetrocede)
    End Sub
    Private Sub Teclado_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
    End Sub
    Private Sub Teclado_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        AcomodaTeclado()
    End Sub
    Private Sub AcomodaTeclado()
        If TecladoRedimensionable = False Then
            Exit Sub
        End If
        Dim MedidaParaFuente As Decimal
        Dim TamañoFuente As Decimal
        Dim Ancho1 As Decimal = (Me.Width - 12) / 19
        Dim Alto1 As Decimal = (Me.Height - 35) / 4

        If Ancho1 < Alto1 Then
            MedidaParaFuente = Ancho1
        Else
            MedidaParaFuente = Alto1
        End If
        TamañoFuente = MedidaParaFuente / 2.5
        Dim Fuente As New System.Drawing.Font("Arial", TamañoFuente)
        Boton1.Left = 1
        Boton1.Top = 1

        Boton1.Width = Ancho1
        Boton1.Height = Alto1
        Boton1.Font = Fuente
        Boton2.Left = Ancho1
        Boton2.Top = 1
        Boton2.Width = Ancho1
        Boton2.Height = Alto1
        Boton2.Font = Fuente
        Boton3.Left = Ancho1 * 2
        Boton3.Top = 1
        Boton3.Width = Ancho1
        Boton3.Height = Alto1
        Boton3.Font = Fuente
        BotonMas.Left = Ancho1 * 3
        BotonMas.Top = 1
        BotonMas.Width = Ancho1
        BotonMas.Height = Alto1
        BotonMas.Font = Fuente
        BotonMenos.Left = Ancho1 * 4
        BotonMenos.Top = 1
        BotonMenos.Width = Ancho1
        BotonMenos.Height = Alto1
        BotonMenos.Font = Fuente
        BotonTeclado.Left = Ancho1 * 5
        BotonTeclado.Top = 1
        BotonTeclado.Width = Ancho1
        BotonTeclado.Height = Alto1
        BotonTeclado.Font = Fuente
        LetraQ.Left = Ancho1 * 6
        LetraQ.Top = 1
        LetraQ.Width = Ancho1
        LetraQ.Height = Alto1
        LetraQ.Font = Fuente
        LetraW.Left = Ancho1 * 7
        LetraW.Top = 1
        LetraW.Width = Ancho1
        LetraW.Height = Alto1
        LetraW.Font = Fuente
        LetraE.Left = Ancho1 * 8
        LetraE.Top = 1
        LetraE.Width = Ancho1
        LetraE.Height = Alto1
        LetraE.Font = Fuente
        LetraR.Left = Ancho1 * 9
        LetraR.Top = 1
        LetraR.Width = Ancho1
        LetraR.Height = Alto1
        LetraR.Font = Fuente
        LetraT.Left = Ancho1 * 10
        LetraT.Top = 1
        LetraT.Width = Ancho1
        LetraT.Height = Alto1
        LetraT.Font = Fuente
        LetraY.Left = Ancho1 * 11
        LetraY.Top = 1
        LetraY.Width = Ancho1
        LetraY.Height = Alto1
        LetraY.Font = Fuente
        LetraU.Left = Ancho1 * 12
        LetraU.Top = 1
        LetraU.Width = Ancho1
        LetraU.Height = Alto1
        LetraU.Font = Fuente
        LetraI.Left = Ancho1 * 13
        LetraI.Top = 1
        LetraI.Width = Ancho1
        LetraI.Height = Alto1
        LetraI.Font = Fuente
        LetraO.Left = Ancho1 * 14
        LetraO.Top = 1
        LetraO.Width = Ancho1
        LetraO.Height = Alto1
        LetraO.Font = Fuente
        LetraP.Left = Ancho1 * 15
        LetraP.Top = 1
        LetraP.Width = Ancho1
        LetraP.Height = Alto1
        LetraP.Font = Fuente
        TeclaAbreInterrogacion.Left = Ancho1 * 16
        TeclaAbreInterrogacion.Top = 1
        TeclaAbreInterrogacion.Width = Ancho1
        TeclaAbreInterrogacion.Height = Alto1
        TeclaAbreInterrogacion.Font = Fuente
        TeclaCierraInterrogacion.Left = Ancho1 * 17
        TeclaCierraInterrogacion.Top = 1
        TeclaCierraInterrogacion.Width = Ancho1
        TeclaCierraInterrogacion.Height = Alto1
        TeclaCierraInterrogacion.Font = Fuente
        TeclaAcento.Left = Ancho1 * 18
        TeclaAcento.Top = 1
        TeclaAcento.Width = Ancho1
        TeclaAcento.Height = Alto1 / 2
        TeclaAcento.Font = Fuente

        BotonTransparencia.Left = Ancho1 * 18
        BotonTransparencia.Top = Alto1 * 0.4
        BotonTransparencia.Width = Ancho1
        BotonTransparencia.Height = Alto1 * 0.6
        BotonTransparencia.Font = Fuente

        Boton4.Left = 1
        Boton4.Top = Alto1
        Boton4.Width = Ancho1
        Boton4.Height = Alto1
        Boton4.Font = Fuente
        Boton5.Left = Ancho1
        Boton5.Top = Alto1
        Boton5.Width = Ancho1
        Boton5.Height = Alto1
        Boton5.Font = Fuente
        Boton6.Left = Ancho1 * 2
        Boton6.Top = Alto1
        Boton6.Width = Ancho1
        Boton6.Height = Alto1
        Boton6.Font = Fuente
        BotonPor.Left = Ancho1 * 3
        BotonPor.Top = Alto1
        BotonPor.Width = Ancho1
        BotonPor.Height = Alto1
        BotonPor.Font = Fuente
        BotonDiv.Left = Ancho1 * 4
        BotonDiv.Top = Alto1
        BotonDiv.Width = Ancho1
        BotonDiv.Height = Alto1
        BotonDiv.Font = Fuente
        BotonAbrir.Left = Ancho1 * 5
        BotonAbrir.Top = Alto1
        BotonAbrir.Width = Ancho1
        BotonAbrir.Height = Alto1 * 2
        BotonAbrir.Font = Fuente
        LetraA.Left = Ancho1 * 6
        LetraA.Top = Alto1
        LetraA.Width = Ancho1
        LetraA.Height = Alto1
        LetraA.Font = Fuente
        LetraS.Left = Ancho1 * 7
        LetraS.Top = Alto1
        LetraS.Width = Ancho1
        LetraS.Height = Alto1
        LetraS.Font = Fuente
        LetraD.Left = Ancho1 * 8
        LetraD.Top = Alto1
        LetraD.Width = Ancho1
        LetraD.Height = Alto1
        LetraD.Font = Fuente
        LetraF.Left = Ancho1 * 9
        LetraF.Top = Alto1
        LetraF.Width = Ancho1
        LetraF.Height = Alto1
        LetraF.Font = Fuente
        LetraG.Left = Ancho1 * 10
        LetraG.Top = Alto1
        LetraG.Width = Ancho1
        LetraG.Height = Alto1
        LetraG.Font = Fuente
        LetraH.Left = Ancho1 * 11
        LetraH.Top = Alto1
        LetraH.Width = Ancho1
        LetraH.Height = Alto1
        LetraH.Font = Fuente
        LetraJ.Left = Ancho1 * 12
        LetraJ.Top = Alto1
        LetraJ.Width = Ancho1
        LetraJ.Height = Alto1
        LetraJ.Font = Fuente
        LetraK.Left = Ancho1 * 13
        LetraK.Top = Alto1
        LetraK.Width = Ancho1
        LetraK.Height = Alto1
        LetraK.Font = Fuente
        LetraL.Left = Ancho1 * 14
        LetraL.Top = Alto1
        LetraL.Width = Ancho1
        LetraL.Height = Alto1
        LetraL.Font = Fuente
        LetraÑ.Left = Ancho1 * 15
        LetraÑ.Top = Alto1
        LetraÑ.Width = Ancho1
        LetraÑ.Height = Alto1
        LetraÑ.Font = Fuente
        TeclaAbreAdmiracion.Left = Ancho1 * 16
        TeclaAbreAdmiracion.Top = Alto1
        TeclaAbreAdmiracion.Width = Ancho1
        TeclaAbreAdmiracion.Height = Alto1
        TeclaAbreAdmiracion.Font = Fuente
        TeclaCierraAdmiracion.Left = Ancho1 * 17
        TeclaCierraAdmiracion.Top = Alto1
        TeclaCierraAdmiracion.Width = Ancho1
        TeclaCierraAdmiracion.Height = Alto1
        TeclaCierraAdmiracion.Font = Fuente
        TeclaMayusculas.Left = Ancho1 * 18
        TeclaMayusculas.Top = Alto1
        TeclaMayusculas.Width = Ancho1
        TeclaMayusculas.Height = Alto1
        TeclaMayusculas.Font = Fuente

        Boton7.Left = 1
        Boton7.Top = Alto1 * 2
        Boton7.Width = Ancho1
        Boton7.Height = Alto1
        Boton7.Font = Fuente
        Boton8.Left = Ancho1
        Boton8.Top = Alto1 * 2
        Boton8.Width = Ancho1
        Boton8.Height = Alto1
        Boton8.Font = Fuente
        Boton9.Left = Ancho1 * 2
        Boton9.Top = Alto1 * 2
        Boton9.Width = Ancho1
        Boton9.Height = Alto1
        Boton9.Font = Fuente
        BotonIgual.Left = Ancho1 * 3
        BotonIgual.Top = Alto1 * 2
        BotonIgual.Width = Ancho1
        BotonIgual.Height = Alto1
        BotonIgual.Font = Fuente
        BotonEnter.Left = Ancho1 * 4
        BotonEnter.Top = Alto1 * 2
        BotonEnter.Width = Ancho1
        BotonEnter.Height = Alto1
        BotonEnter.Font = Fuente
        LetraZ.Left = Ancho1 * 6
        LetraZ.Top = Alto1 * 2
        LetraZ.Width = Ancho1
        LetraZ.Height = Alto1
        LetraZ.Font = Fuente
        LetraX.Left = Ancho1 * 7
        LetraX.Top = Alto1 * 2
        LetraX.Width = Ancho1
        LetraX.Height = Alto1
        LetraX.Font = Fuente
        LetraC.Left = Ancho1 * 8
        LetraC.Top = Alto1 * 2
        LetraC.Width = Ancho1
        LetraC.Height = Alto1
        LetraC.Font = Fuente
        LetraV.Left = Ancho1 * 9
        LetraV.Top = Alto1 * 2
        LetraV.Width = Ancho1
        LetraV.Height = Alto1
        LetraV.Font = Fuente
        LetraB.Left = Ancho1 * 10
        LetraB.Top = Alto1 * 2
        LetraB.Width = Ancho1
        LetraB.Height = Alto1
        LetraB.Font = Fuente
        LetraN.Left = Ancho1 * 11
        LetraN.Top = Alto1 * 2
        LetraN.Width = Ancho1
        LetraN.Height = Alto1
        LetraN.Font = Fuente
        LetraM.Left = Ancho1 * 12
        LetraM.Top = Alto1 * 2
        LetraM.Width = Ancho1
        LetraM.Height = Alto1
        LetraM.Font = Fuente
        TeclaComa.Left = Ancho1 * 13
        TeclaComa.Top = Alto1 * 2
        TeclaComa.Width = Ancho1
        TeclaComa.Height = Alto1
        TeclaComa.Font = Fuente
        TeclaPunto.Left = Ancho1 * 14
        TeclaPunto.Top = Alto1 * 2
        TeclaPunto.Width = Ancho1
        TeclaPunto.Height = Alto1
        TeclaPunto.Font = Fuente
        TeclaGuion.Left = Ancho1 * 15
        TeclaGuion.Top = Alto1 * 2
        TeclaGuion.Width = Ancho1
        TeclaGuion.Height = Alto1
        TeclaGuion.Font = Fuente
        TeclaComillas.Left = Ancho1 * 16
        TeclaComillas.Top = Alto1 * 2
        TeclaComillas.Width = Ancho1
        TeclaComillas.Height = Alto1
        TeclaComillas.Font = Fuente
        TeclaBarra.Left = Ancho1 * 17
        TeclaBarra.Top = Alto1 * 2
        TeclaBarra.Width = Ancho1
        TeclaBarra.Height = Alto1
        TeclaBarra.Font = Fuente
        TeclaOrdinal.Left = Ancho1 * 18
        TeclaOrdinal.Top = Alto1 * 2
        TeclaOrdinal.Width = Ancho1
        TeclaOrdinal.Height = Alto1
        TeclaOrdinal.Font = Fuente

        Boton0.Left = 1
        Boton0.Top = Alto1 * 3
        Boton0.Width = Ancho1
        Boton0.Height = Alto1
        Boton0.Font = Fuente
        BotonComa.Left = Ancho1
        BotonComa.Top = Alto1 * 3
        BotonComa.Width = Ancho1
        BotonComa.Height = Alto1
        BotonComa.Font = Fuente
        BotonCopia.Left = Ancho1 * 2
        BotonCopia.Top = Alto1 * 3
        BotonCopia.Width = Ancho1
        BotonCopia.Height = Alto1
        BotonCopia.Font = Fuente
        BotonPega.Left = Ancho1 * 3
        BotonPega.Top = Alto1 * 3
        BotonPega.Width = Ancho1
        BotonPega.Height = Alto1
        BotonPega.Font = Fuente
        BotonBorra.Left = Ancho1 * 4
        BotonBorra.Top = Alto1 * 3
        BotonBorra.Width = Ancho1
        BotonBorra.Height = Alto1
        BotonBorra.Font = Fuente
        BotonAvanzaRetrocede.Left = Ancho1 * 5
        BotonAvanzaRetrocede.Top = Alto1 * 3
        BotonAvanzaRetrocede.Width = Ancho1
        BotonAvanzaRetrocede.Height = Alto1
        BotonAvanzaRetrocede.Font = Fuente
        BotonArribaAbajo.Left = Ancho1 * 6
        BotonArribaAbajo.Top = Alto1 * 3
        BotonArribaAbajo.Width = Ancho1
        BotonArribaAbajo.Height = Alto1
        BotonArribaAbajo.Font = Fuente
        CheckConShift.Left = Ancho1 * 7.3
        CheckConShift.Top = Alto1 * 3.3
        TeclaEspacio.Left = Ancho1 * 8
        TeclaEspacio.Top = Alto1 * 3
        TeclaEspacio.Width = Ancho1 * 5
        TeclaEspacio.Height = Alto1
        TeclaEspacio.Font = Fuente
        TeclaNumeral.Left = Ancho1 * 13
        TeclaNumeral.Top = Alto1 * 3
        TeclaNumeral.Width = Ancho1
        TeclaNumeral.Height = Alto1
        TeclaNumeral.Font = Fuente
        TeclaPesos.Left = Ancho1 * 14
        TeclaPesos.Top = Alto1 * 3
        TeclaPesos.Width = Ancho1
        TeclaPesos.Height = Alto1
        TeclaPesos.Font = Fuente
        TeclaPorCiento.Left = Ancho1 * 15
        TeclaPorCiento.Top = Alto1 * 3
        TeclaPorCiento.Width = Ancho1
        TeclaPorCiento.Height = Alto1
        TeclaPorCiento.Font = Fuente
        TeclaAbreParentesis.Left = Ancho1 * 16
        TeclaAbreParentesis.Top = Alto1 * 3
        TeclaAbreParentesis.Width = Ancho1
        TeclaAbreParentesis.Height = Alto1
        TeclaAbreParentesis.Font = Fuente
        TeclaCierraParentesis.Left = Ancho1 * 17
        TeclaCierraParentesis.Top = Alto1 * 3
        TeclaCierraParentesis.Width = Ancho1
        TeclaCierraParentesis.Height = Alto1
        TeclaCierraParentesis.Font = Fuente
        TeclaGuionLargo.Left = Ancho1 * 18
        TeclaGuionLargo.Top = Alto1 * 3
        TeclaGuionLargo.Width = Ancho1
        TeclaGuionLargo.Height = Alto1
        TeclaGuionLargo.Font = Fuente



        Exit Sub
        Me.Left = Anotador.Left + Anotador.Width - Me.Width
    End Sub
    Private Sub BotonTeclado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonTeclado.Click
    End Sub

    Private Sub BotonTeclado_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonTeclado.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Anotador.Minimo()
            Exit Sub
            If Anotador.Minimizado = False Then
                Anotador.Posiciones00()
                Anotador.Texto.Focus()
            Else
                Me.Visible = False
                FormularioActivo(2) = False
                Anotador.Focus()
                Exit Sub
                ExpandeAnotador()
                Anotador.Texto.Focus()
            End If
        Else
            Me.Visible = False
            FormularioActivo(2) = False
            Exit Sub
            If MuestraOcultaFormularios = False Then
                MuestraOcultaFormularios = True
                'If FormularioActivo(2) = True Then Teclado.Visible = True
                If FormularioActivo(3) = True Then FormAuxiliar.Visible = True
                If FormularioActivo(4) = True Then Director.Visible = True
                If FormularioActivo(5) = True Then FormIndice.Visible = True
            Else
                MuestraOcultaFormularios = False
                ' Teclado.Visible = False
                FormAuxiliar.Visible = False
                Director.Visible = False
                FormIndice.Visible = False
            End If
        End If
    End Sub
    Private Sub BotonTeclado_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonTeclado.DoubleClick
        If FormAuxiliar.Visible = True Then
            FormAuxiliar.Visible = False
        Else
            FormAuxiliar.Visible = True
        End If
    End Sub
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub ComboBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub BotonCombo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Public Sub CambiaColorTeclado(ByVal TecladoColorFondo1 As Color, ByVal TecladoColorFondo2 As Color, ByVal TecladoColorFondo3 As Color, ByVal TecladoColorFondoListas As Color, ByVal TecladoColorLetraTeclas As Color, ByVal TecladoColorLetraListas As Color)
        ' COLORES DE FONDO (BACKCOLOR)
        ' Color Fondo 1  Teclas generales
        Me.BackColor = TecladoColorFondo1
        Boton1.BackColor = TecladoColorFondo1
        Boton2.BackColor = TecladoColorFondo1
        Boton3.BackColor = TecladoColorFondo1
        Boton4.BackColor = TecladoColorFondo1
        Boton5.BackColor = TecladoColorFondo1
        Boton6.BackColor = TecladoColorFondo1
        Boton7.BackColor = TecladoColorFondo1
        Boton8.BackColor = TecladoColorFondo1
        Boton9.BackColor = TecladoColorFondo1
        Boton0.BackColor = TecladoColorFondo1
        BotonMas.BackColor = TecladoColorFondo1
        BotonMenos.BackColor = TecladoColorFondo1
        BotonPor.BackColor = TecladoColorFondo1
        BotonDiv.BackColor = TecladoColorFondo1
        BotonIgual.BackColor = TecladoColorFondo1
        BotonComa.BackColor = TecladoColorFondo1
        BotonTransparencia.BackColor = TecladoColorFondo1
        ' Color Fondo 2  Teclas especiales
        BotonBorra.BackColor = TecladoColorFondo2
        BotonCopia.BackColor = TecladoColorFondo2
        BotonPega.BackColor = TecladoColorFondo2
        BotonAvanzaRetrocede.BackColor = TecladoColorFondo2
        BotonArribaAbajo.BackColor = TecladoColorFondo2
        BotonIgual.BackColor = TecladoColorFondo2
        FormAuxiliar.BotonQuitaEspacios.BackColor = TecladoColorFondo2
        FormAuxiliar.BotonTodoMayMin.BackColor = TecladoColorFondo2
        FormAuxiliar.BotonMayusculasIniciales.BackColor = TecladoColorFondo2
        FormAuxiliar.BotonRepiteAscii.BackColor = TecladoColorFondo2
        FormAuxiliar.BotonLeeRecortes.BackColor = TecladoColorFondo2
        FormAuxiliar.BotonRepiteRecorte.BackColor = TecladoColorFondo2
        FormAuxiliar.BotonRepìtePredeterminado.BackColor = TecladoColorFondo2
        FormAuxiliar.BotonReemplazar.BackColor = TecladoColorFondo2
        FormAuxiliar.BotonBusca1.BackColor = TecladoColorFondo2
        FormAuxiliar.BotonBusca2.BackColor = TecladoColorFondo2
        FormAuxiliar.BotonAjusta.BackColor = TecladoColorFondo3
        ' Color Fondo 3  Controles
        FormAuxiliar.BotonAcentuarDesacentuar.BackColor = TecladoColorFondo2
        BotonEnter.BackColor = TecladoColorFondo3
        BotonAbrir.BackColor = TecladoColorFondo3
        BotonTeclado.BackColor = TecladoColorFondo3
        TeclaMayusculas.BackColor = TecladoColorFondo3

        LetraA.BackColor = TecladoColorFondo1
        LetraB.BackColor = TecladoColorFondo1
        LetraC.BackColor = TecladoColorFondo1
        LetraD.BackColor = TecladoColorFondo1
        LetraE.BackColor = TecladoColorFondo1
        LetraF.BackColor = TecladoColorFondo1
        LetraG.BackColor = TecladoColorFondo1
        LetraH.BackColor = TecladoColorFondo1
        LetraI.BackColor = TecladoColorFondo1
        LetraJ.BackColor = TecladoColorFondo1
        LetraK.BackColor = TecladoColorFondo1
        LetraL.BackColor = TecladoColorFondo1
        LetraM.BackColor = TecladoColorFondo1
        LetraN.BackColor = TecladoColorFondo1
        LetraÑ.BackColor = TecladoColorFondo1
        LetraO.BackColor = TecladoColorFondo1
        LetraP.BackColor = TecladoColorFondo1
        LetraQ.BackColor = TecladoColorFondo1
        LetraR.BackColor = TecladoColorFondo1
        LetraS.BackColor = TecladoColorFondo1
        LetraT.BackColor = TecladoColorFondo1
        LetraU.BackColor = TecladoColorFondo1
        LetraV.BackColor = TecladoColorFondo1
        LetraW.BackColor = TecladoColorFondo1
        LetraX.BackColor = TecladoColorFondo1
        LetraY.BackColor = TecladoColorFondo1
        LetraZ.BackColor = TecladoColorFondo1

        TeclaAbreAdmiracion.BackColor = TecladoColorFondo1
        TeclaCierraAdmiracion.BackColor = TecladoColorFondo1
        TeclaAbreInterrogacion.BackColor = TecladoColorFondo1
        TeclaCierraInterrogacion.BackColor = TecladoColorFondo1
        TeclaAcento.BackColor = TecladoColorFondo3
        TeclaAbreParentesis.BackColor = TecladoColorFondo1
        TeclaCierraParentesis.BackColor = TecladoColorFondo1
        TeclaPunto.BackColor = TecladoColorFondo1
        TeclaGuion.BackColor = TecladoColorFondo1
        TeclaComa.BackColor = TecladoColorFondo1
        TeclaComillas.BackColor = TecladoColorFondo1
        TeclaBarra.BackColor = TecladoColorFondo1
        TeclaOrdinal.BackColor = TecladoColorFondo1
        TeclaNumeral.BackColor = TecladoColorFondo1
        TeclaPesos.BackColor = TecladoColorFondo1
        TeclaPorCiento.BackColor = TecladoColorFondo1
        TeclaEspacio.BackColor = TecladoColorFondo2
        TeclaGuionLargo.BackColor = TecladoColorFondo1
        ' Director
        Director.BackColor = Color.LightGray
        Director.BotonArriba.BackColor = TecladoColorFondo2
        Director.BotonAbajo.BackColor = TecladoColorFondo2
        Director.BotonCentral.BackColor = TecladoColorFondo3
        Director.BotonAvanza.BackColor = TecladoColorFondo2
        Director.BotonRetrocede.BackColor = TecladoColorFondo2
        Director.BotonTeclado.BackColor = TecladoColorFondo2

        Director.BotonCopia.BackColor = TecladoColorFondo2
        Director.BotonPega.BackColor = TecladoColorFondo2
        Director.BotonBorra.BackColor = TecladoColorFondo2
        Director.BotonEnter.BackColor = TecladoColorFondo3
        Director.BotonTransparencia.BackColor = Color.LightGray
        Director.TeclaEspacio.BackColor = TecladoColorFondo2

        'Fondos de Listas
        FormAuxiliar.ListaAsciiComentado.BackColor = TecladoColorFondoListas
        FormAuxiliar.ListaPredeterminados.BackColor = TecladoColorFondoListas
        FormAuxiliar.ListaRecortes.BackColor = TecladoColorFondoListas
        FormAuxiliar.TextoBuscar1.BackColor = TecladoColorFondoListas
        FormAuxiliar.TextoReemplazar1.BackColor = TecladoColorFondoListas
        FormAuxiliar.TextoBuscar2.BackColor = TecladoColorFondoListas
        FormAuxiliar.TextoReemplazar2.BackColor = TecladoColorFondoListas

        ' COLORES DE LETRA (FORECOLOR)
        Boton1.ForeColor = TecladoColorLetraTeclas
        Boton2.ForeColor = TecladoColorLetraTeclas
        Boton3.ForeColor = TecladoColorLetraTeclas
        Boton4.ForeColor = TecladoColorLetraTeclas
        Boton5.ForeColor = TecladoColorLetraTeclas
        Boton6.ForeColor = TecladoColorLetraTeclas
        Boton7.ForeColor = TecladoColorLetraTeclas
        Boton8.ForeColor = TecladoColorLetraTeclas
        Boton9.ForeColor = TecladoColorLetraTeclas
        Boton0.ForeColor = TecladoColorLetraTeclas
        BotonMas.ForeColor = TecladoColorLetraTeclas
        BotonMenos.ForeColor = TecladoColorLetraTeclas
        BotonPor.ForeColor = TecladoColorLetraTeclas
        BotonDiv.ForeColor = TecladoColorLetraTeclas
        BotonIgual.ForeColor = TecladoColorLetraTeclas
        BotonComa.ForeColor = TecladoColorLetraTeclas
        BotonBorra.ForeColor = TecladoColorLetraTeclas
        BotonCopia.ForeColor = TecladoColorLetraTeclas
        BotonPega.ForeColor = TecladoColorLetraTeclas
        BotonIgual.ForeColor = TecladoColorLetraTeclas
        BotonEnter.ForeColor = TecladoColorLetraTeclas
        BotonAbrir.ForeColor = TecladoColorLetraTeclas
        BotonTeclado.ForeColor = TecladoColorLetraTeclas
        BotonTransparencia.ForeColor = TecladoColorLetraTeclas

        LetraA.ForeColor = TecladoColorLetraTeclas
        LetraB.ForeColor = TecladoColorLetraTeclas
        LetraC.ForeColor = TecladoColorLetraTeclas
        LetraD.ForeColor = TecladoColorLetraTeclas
        LetraE.ForeColor = TecladoColorLetraTeclas
        LetraF.ForeColor = TecladoColorLetraTeclas
        LetraG.ForeColor = TecladoColorLetraTeclas
        LetraH.ForeColor = TecladoColorLetraTeclas
        LetraI.ForeColor = TecladoColorLetraTeclas
        LetraJ.ForeColor = TecladoColorLetraTeclas
        LetraK.ForeColor = TecladoColorLetraTeclas
        LetraL.ForeColor = TecladoColorLetraTeclas
        LetraM.ForeColor = TecladoColorLetraTeclas
        LetraN.ForeColor = TecladoColorLetraTeclas
        LetraÑ.ForeColor = TecladoColorLetraTeclas
        LetraO.ForeColor = TecladoColorLetraTeclas
        LetraP.ForeColor = TecladoColorLetraTeclas
        LetraQ.ForeColor = TecladoColorLetraTeclas
        LetraR.ForeColor = TecladoColorLetraTeclas
        LetraS.ForeColor = TecladoColorLetraTeclas
        LetraT.ForeColor = TecladoColorLetraTeclas
        LetraU.ForeColor = TecladoColorLetraTeclas
        LetraV.ForeColor = TecladoColorLetraTeclas
        LetraW.ForeColor = TecladoColorLetraTeclas
        LetraX.ForeColor = TecladoColorLetraTeclas
        LetraY.ForeColor = TecladoColorLetraTeclas
        LetraZ.ForeColor = TecladoColorLetraTeclas
        BotonAvanzaRetrocede.ForeColor = TecladoColorLetraTeclas
        BotonArribaAbajo.ForeColor = TecladoColorLetraTeclas
        TeclaAbreAdmiracion.ForeColor = TecladoColorLetraTeclas
        TeclaCierraAdmiracion.ForeColor = TecladoColorLetraTeclas
        TeclaAbreInterrogacion.ForeColor = TecladoColorLetraTeclas
        TeclaCierraInterrogacion.ForeColor = TecladoColorLetraTeclas
        TeclaAbreParentesis.ForeColor = TecladoColorLetraTeclas
        TeclaCierraParentesis.ForeColor = TecladoColorLetraTeclas
        TeclaAcento.ForeColor = TecladoColorLetraTeclas
        TeclaPunto.ForeColor = TecladoColorLetraTeclas
        TeclaGuion.ForeColor = TecladoColorLetraTeclas
        TeclaComa.ForeColor = TecladoColorLetraTeclas
        TeclaComillas.ForeColor = TecladoColorLetraTeclas
        TeclaBarra.ForeColor = TecladoColorLetraTeclas
        TeclaOrdinal.ForeColor = TecladoColorLetraTeclas
        TeclaNumeral.ForeColor = TecladoColorLetraTeclas
        TeclaPesos.ForeColor = TecladoColorLetraTeclas
        TeclaPorCiento.ForeColor = TecladoColorLetraTeclas
        TeclaEspacio.ForeColor = TecladoColorLetraTeclas
        TeclaMayusculas.ForeColor = TecladoColorLetraTeclas
        TeclaGuionLargo.ForeColor = TecladoColorLetraTeclas
        'Botones extensión
        FormAuxiliar.BotonQuitaEspacios.ForeColor = TecladoColorLetraTeclas
        FormAuxiliar.BotonTodoMayMin.ForeColor = TecladoColorLetraTeclas
        FormAuxiliar.BotonMayusculasIniciales.ForeColor = TecladoColorLetraTeclas
        FormAuxiliar.BotonRepiteAscii.ForeColor = TecladoColorLetraTeclas
        FormAuxiliar.BotonLeeRecortes.ForeColor = TecladoColorLetraTeclas
        FormAuxiliar.TextoBuscar1.BackColor = TecladoColorFondoListas
        FormAuxiliar.TextoReemplazar1.BackColor = TecladoColorFondoListas
        FormAuxiliar.BotonRepiteRecorte.ForeColor = TecladoColorLetraTeclas
        FormAuxiliar.TextoBuscar1.BackColor = TecladoColorFondoListas
        FormAuxiliar.TextoReemplazar1.BackColor = TecladoColorFondoListas
        FormAuxiliar.BotonRepìtePredeterminado.ForeColor = TecladoColorLetraTeclas
        FormAuxiliar.BotonAcentuarDesacentuar.ForeColor = TecladoColorLetraTeclas
        FormAuxiliar.TextoBuscar1.BackColor = TecladoColorFondoListas
        FormAuxiliar.TextoReemplazar1.BackColor = TecladoColorFondoListas
        FormAuxiliar.BotonReemplazar.ForeColor = TecladoColorLetraTeclas
        FormAuxiliar.BotonBusca1.ForeColor = TecladoColorLetraTeclas
        FormAuxiliar.BotonBusca2.ForeColor = TecladoColorLetraTeclas
        FormAuxiliar.BotonAjusta.ForeColor = TecladoColorLetraTeclas

        'Director
        Director.BotonArriba.ForeColor = TecladoColorLetraTeclas
        Director.BotonAbajo.ForeColor = TecladoColorLetraTeclas
        Director.BotonCentral.ForeColor = TecladoColorLetraTeclas
        Director.BotonAvanza.ForeColor = TecladoColorLetraTeclas
        Director.BotonRetrocede.ForeColor = TecladoColorLetraTeclas
        Director.TeclaEspacio.ForeColor = TecladoColorLetraTeclas
        Director.BotonCopia.ForeColor = TecladoColorLetraTeclas
        Director.BotonPega.ForeColor = TecladoColorLetraTeclas
        Director.BotonBorra.ForeColor = TecladoColorLetraTeclas
        Director.BotonEnter.ForeColor = TecladoColorLetraTeclas
        Director.BotonTransparencia.ForeColor = TecladoColorLetraTeclas
        'Listas
        FormAuxiliar.TextoBuscar1.BackColor = TecladoColorFondoListas
        FormAuxiliar.TextoReemplazar1.BackColor = TecladoColorFondoListas
        FormAuxiliar.ListaPredeterminados.ForeColor = TecladoColorLetraListas
        FormAuxiliar.ListaAsciiComentado.ForeColor = TecladoColorLetraListas
        FormAuxiliar.TextoBuscar1.BackColor = TecladoColorFondoListas
        FormAuxiliar.TextoReemplazar1.BackColor = TecladoColorFondoListas
        FormAuxiliar.ListaRecortes.ForeColor = TecladoColorLetraListas
        FormAuxiliar.TextoBuscar1.ForeColor = TecladoColorLetraListas
        FormAuxiliar.TextoReemplazar1.ForeColor = TecladoColorLetraListas
        FormAuxiliar.TextoBuscar2.ForeColor = TecladoColorLetraListas
        FormAuxiliar.TextoReemplazar2.ForeColor = TecladoColorLetraListas
    End Sub
    Private Sub Abrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAbrir.Click
    End Sub
    Private Sub Abrir_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonAbrir.MouseDown
        Dim difb = 15
        Dim difa = 15
        If e.Button = Windows.Forms.MouseButtons.Left Then


            If Me.Width < BotonAbrir.Left + BotonAbrir.Width + difa * 2 Then
                ' Me.Width = Screen.PrimaryScreen.Bounds.Width - BotonAbrir.Left + BotonAbrir.Width
                TecladoRedimensionable = True
                Anotador.TecladoEstirableMenu.Text = "Teclado tamaño fijo"

                Me.Width = TeclaMayusculas.Left + TeclaMayusculas.Width + difa
                'Me.Left = Screen.PrimaryScreen.Bounds.Width - Me.Width - TeclaMayusculas.Width * 1.5
                BotonAbrir.Text = "<"
            Else
                'Me.Left = Screen.PrimaryScreen.Bounds.Width - Me.Width
                TecladoRedimensionable = False
                Anotador.TecladoEstirableMenu.Text = "Teclado tamaño fijo"
                Me.Width = BotonAbrir.Left + BotonAbrir.Width + difa
                ' Me.Left = Screen.PrimaryScreen.Bounds.Width - Me.Width
                BotonAbrir.Text = ">"
            End If





            ' If Me.Left + BotonAbrir.Left + BotonAbrir.Width < Screen.PrimaryScreen.Bounds.Left Then
            'Me.Left = Screen.PrimaryScreen.Bounds.Width - BotonAbrir.Left + BotonAbrir.Width


            'Me.Width = TeclaMayusculas.Left + TeclaMayusculas.Width + difa
            'BotonAbrir.Text = "<"
            'Else
            ' Me.Left = Screen.PrimaryScreen.Bounds.Width - Me.Width
            'Me.Width = BotonAbrir.Left + BotonAbrir.Width + difa
            'BotonAbrir.Text = ">"
            'End If
        Else

            If FormAuxiliar.Visible = True Then
                FormAuxiliar.Visible = False
                FormIndice.Visible = False
                Director.Visible = False
            Else
                FormAuxiliar.Visible = True
                FormIndice.Visible = True
                Director.Visible = True
            End If
        End If
    End Sub

    Private Sub BotonLetra_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub TeclaAcento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaAcento.Click
    End Sub
    Private Sub TeclaAcento_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaAcento.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Acentuada = True
            Dieresis = False
            TeclaAcento.BackColor = Color.Red
            SuenaTilde()
            ' If Acentuada = False Then
            'Acentuada = True
            ' Dieresis = False
            'TeclaAcento.BackColor = Color.Red
            'Else
            'Acentuada = False
            'TeclaAcento.BackColor = Nothing
            'End If
        Else
            Dieresis = True
            Acentuada = False
            TeclaAcento.BackColor = Color.LightGreen
            SuenaTilde()
            'If Dieresis = False Then
            'Dieresis = True
            ' Acentuada = False
            'TeclaAcento.BackColor = Color.LightGreen
            ' Else
            ' Dieresis = False
            'TeclaAcento.BackColor = Nothing
            'End If
        End If
    End Sub
    Private Sub TeclaAcento_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaAcento.MouseHover
        IluminaColorTecla(TeclaAcento)
        If DisparoAutomatico = True Then
            PoneLetrasAcentuadasAuto()
        End If
    End Sub

    Private Sub TeclaAcento_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaAcento.MouseLeave
        'RestauraColorTecla3(TeclaAcento)
    End Sub

    Private Sub TeclaAcento_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaAcento.MouseUp
        'RestauraColorTecla3(TeclaAcento)
    End Sub
    Private Sub PoneLetrasAcentuadasAuto()
        Acentuada = True
        Dieresis = False
        TeclaAcento.BackColor = Color.Red
        SuenaTilde()
        'If Acentuada = False Then
        'Acentuada = True
        'Dieresis = False
        'TeclaAcento.BackColor = Color.Red
        ' Else
        'Acentuada = False
        ' TeclaAcento.BackColor = TecladoColorFondo3
        'End If
    End Sub
    Private Sub BotonIgual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonIgual.Click
    End Sub
    Private Sub BotonIgual_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonIgual.MouseDown
        LetraElegida = "="
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' Posiciones("=", Anotador.Texto.SelectedText)
            'LetraPresionada = "="
            PoneLetra()
            Anotador.Calcula()
        Else
            Anotador.RetrocedeBorra1solo()
            'PoneLetra()
            'ActivarRepeticion()
        End If
        InvierteColorSuenaTecla(BotonIgual)
    End Sub
    Private Sub TextoLetraIgual()
        LetraElegida = "="
    End Sub

    Private Sub BotonIgual_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonIgual.MouseHover
        TextoLetraIgual()
        MouseHoverTecla(BotonIgual)
        'IluminaColorTecla(BotonIgual)
    End Sub

    Private Sub BotonIgual_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonIgual.MouseLeave
        MouseLeaveTecla2(BotonIgual)
        'DetieneTimerLetra()
        'RestauraColorTecla2(BotonIgual)
    End Sub

    Private Sub BotonIgual_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonIgual.MouseUp
        MouseUpTecla2(BotonIgual)
        'DetieneTimerLetra()
        'RestauraColorTecla2(BotonIgual)
    End Sub

    Private Sub TeclaTodoMayMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub TeclaTodoMayMin_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub





    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ListaRecortes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub TimerPresionContinua_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerRepeticion.Tick
        PresionContinua()
        'TimerPresionContinua.Enabled = False
    End Sub
    Private Sub PresionContinua()
        PoneLetra()
        SuenaRepite()

    End Sub

    Private Sub TimerActivaRepeticion_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerActivaRepeticion.Tick
        TimerRepeticion.Enabled = True
    End Sub





    Private Sub LetraT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraT.Click

    End Sub
    Private Sub LetraT_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraT.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(LetraT)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraT()
        LetraElegida = LetraT.Text
    End Sub
    Private Sub LetraT_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraT.MouseHover
        TextoLetraT()
        MouseHoverTecla(LetraT)
    End Sub

    Private Sub LetraT_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraT.MouseLeave
        MouseLeaveTecla(LetraT)
    End Sub

    Private Sub LetraT_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraT.MouseUp
        MouseUpTecla(LetraT)

    End Sub
    Private Sub LetraD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraD.Click
    End Sub
    Private Sub LetraD_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraD.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(LetraD)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraD()
        LetraElegida = LetraD.Text
    End Sub
    Private Sub LetraD_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraD.MouseHover
        TextoLetraD()
        MouseHoverTecla(LetraD)
    End Sub

    Private Sub LetraD_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraD.MouseLeave
        MouseLeaveTecla(LetraD)
    End Sub

    Private Sub LetraD_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraD.MouseUp
        MouseUpTecla(LetraD)
    End Sub
    Private Sub LetraF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraF.Click
    End Sub
    Private Sub LetraF_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraF.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(LetraF)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraF()
        LetraElegida = LetraF.Text
    End Sub
    Private Sub LetraF_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraF.MouseHover
        TextoLetraF()
        MouseHoverTecla(LetraF)
    End Sub

    Private Sub LetraF_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraF.MouseLeave
        MouseLeaveTecla(LetraF)
    End Sub

    Private Sub LetraF_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraF.MouseUp
        MouseUpTecla(LetraF)
    End Sub
    Private Sub LetraG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraG.Click
    End Sub
    Private Sub LetraG_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraG.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(LetraG)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraG()
        LetraElegida = LetraG.Text
    End Sub
    Private Sub LetraG_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraG.MouseHover
        TextoLetraG()
        MouseHoverTecla(LetraG)
    End Sub

    Private Sub LetraG_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraG.MouseLeave
        MouseLeaveTecla(LetraG)
    End Sub

    Private Sub LetraG_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraG.MouseUp
        MouseUpTecla(LetraG)

    End Sub
    Private Sub LetraH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraH.Click
    End Sub
    Private Sub LetraH_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraH.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(LetraH)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraH()
        LetraElegida = LetraH.Text
    End Sub
    Private Sub LetraH_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraH.MouseHover
        TextoLetraH()
        MouseHoverTecla(LetraH)
    End Sub
    Private Sub LetraH_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraH.MouseLeave
        MouseLeaveTecla(LetraH)
    End Sub
    Private Sub LetraH_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraH.MouseUp
        DetieneTimerLetra()
        RestauraColorTecla1(LetraH)
    End Sub
    Private Sub LetraJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraJ.Click
    End Sub
    Private Sub LetraJ_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraJ.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(LetraJ)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraJ()
        LetraElegida = LetraJ.Text
    End Sub

    Private Sub LetraJ_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraJ.MouseHover
        TextoLetraJ()
        MouseHoverTecla(LetraJ)
    End Sub

    Private Sub LetraJ_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraJ.MouseLeave
        MouseLeaveTecla(LetraJ)
    End Sub

    Private Sub LetraJ_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraJ.MouseUp
        MouseUpTecla(LetraJ)
    End Sub
    Private Sub LetraK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraK.Click
    End Sub
    Private Sub LetraK_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraK.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(LetraK)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraK()
        LetraElegida = LetraK.Text
    End Sub

    Private Sub LetraK_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraK.MouseHover
        TextoLetraK()
        MouseHoverTecla(LetraK)
    End Sub

    Private Sub LetraK_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraK.MouseLeave
        MouseLeaveTecla(LetraK)
    End Sub

    Private Sub LetraK_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraK.MouseUp
        MouseUpTecla(LetraK)
    End Sub
    Private Sub LetraL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraL.Click
    End Sub
    Private Sub LetraL_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraL.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(LetraL)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraL()
        LetraElegida = LetraL.Text
    End Sub

    Private Sub LetraL_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraL.MouseHover
        TextoLetraL()
        MouseHoverTecla(LetraL)
    End Sub

    Private Sub LetraL_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraL.MouseLeave
        MouseLeaveTecla(LetraL)
    End Sub

    Private Sub LetraL_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraL.MouseUp
        MouseUpTecla(LetraL)
    End Sub
    Private Sub LetraÑ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraÑ.Click

    End Sub
    Private Sub LetraÑ_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraÑ.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(LetraÑ)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraÑ()
        LetraElegida = LetraÑ.Text
    End Sub
    Private Sub LetraÑ_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraÑ.MouseHover
        TextoLetraÑ()
        MouseHoverTecla(LetraÑ)
    End Sub

    Private Sub LetraÑ_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraÑ.MouseLeave
        MouseLeaveTecla(LetraÑ)
    End Sub

    Private Sub LetraÑ_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraÑ.MouseUp
        MouseUpTecla(LetraÑ)
    End Sub
    Private Sub TeclaAbreAdmiracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaAbreAdmiracion.Click
    End Sub
    Private Sub TeclaAbreAdmiracion_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaAbreAdmiracion.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(TeclaAbreAdmiracion)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraAbreAdmiracion()
        LetraElegida = TeclaAbreAdmiracion.Text
    End Sub
    Private Sub TeclaAbreAdmiracion_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaAbreAdmiracion.MouseHover
        TextoLetraAbreAdmiracion()
        MouseHoverTecla(TeclaAbreAdmiracion)
    End Sub
    Private Sub TeclaAbreAdmiracion_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaAbreAdmiracion.MouseLeave
        MouseLeaveTecla(TeclaAbreAdmiracion)
    End Sub

    Private Sub TeclaAbreAdmiracion_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaAbreAdmiracion.MouseUp
        MouseUpTecla(TeclaAbreAdmiracion)
    End Sub
    Private Sub TeclaCierraAdmiracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaCierraAdmiracion.Click
    End Sub
    Private Sub TeclaCierraAdmiracion_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaCierraAdmiracion.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(TeclaCierraAdmiracion)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraCierraAdmiracion()
        LetraElegida = TeclaCierraAdmiracion.Text
    End Sub
    Private Sub TeclaCierraAdmiracion_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaCierraAdmiracion.MouseHover
        TextoLetraCierraAdmiracion()
        MouseHoverTecla(TeclaCierraAdmiracion)
    End Sub
    Private Sub TeclaCierraAdmiracion_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaCierraAdmiracion.MouseLeave
        MouseLeaveTecla(TeclaCierraAdmiracion)
    End Sub
    Private Sub TeclaCierraAdmiracion_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaCierraAdmiracion.MouseUp
        MouseUpTecla(TeclaCierraAdmiracion)
    End Sub
    Private Sub LetraZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraZ.Click
    End Sub
    Private Sub LetraZ_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraZ.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(LetraZ)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraZ()
        LetraElegida = LetraZ.Text
    End Sub
    Private Sub LetraZ_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraZ.MouseHover
        TextoLetraZ()
        MouseHoverTecla(LetraZ)
    End Sub
    Private Sub LetraZ_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraZ.MouseLeave
        MouseLeaveTecla(LetraZ)
    End Sub
    Private Sub LetraZ_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraZ.MouseUp
        MouseUpTecla(LetraZ)
    End Sub
    Private Sub LetraX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraX.Click
    End Sub
    Private Sub LetraX_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraX.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(LetraX)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraX()
        LetraElegida = LetraX.Text
    End Sub
    Private Sub LetraX_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraX.MouseHover
        TextoLetraX()
        MouseHoverTecla(LetraX)
    End Sub

    Private Sub LetraX_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraX.MouseLeave
        MouseLeaveTecla(LetraX)
    End Sub

    Private Sub LetraX_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraX.MouseUp
        MouseUpTecla(LetraX)
    End Sub
    Private Sub LetraC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraC.Click
    End Sub
    Private Sub LetraC_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraC.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(LetraC)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraC()
        LetraElegida = LetraC.Text
    End Sub

    Private Sub LetraC_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraC.MouseHover
        TextoLetraC()
        MouseHoverTecla(LetraC)
    End Sub

    Private Sub LetraC_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraC.MouseLeave
        MouseLeaveTecla(LetraC)
    End Sub

    Private Sub LetraC_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraC.MouseUp
        MouseUpTecla(LetraC)
    End Sub
    Private Sub LetraV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraV.Click

    End Sub
    Private Sub LetraV_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraV.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(LetraV)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraV()
        LetraElegida = LetraV.Text
    End Sub
    Private Sub LetraV_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraV.MouseHover
        TextoLetraV()
        MouseHoverTecla(LetraV)
    End Sub

    Private Sub LetraV_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraV.MouseLeave
        MouseLeaveTecla(LetraV)
    End Sub
    Private Sub LetraV_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraV.MouseUp
        MouseUpTecla(LetraV)
    End Sub
    Private Sub LetraB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraB.Click
    End Sub
    Private Sub LetraB_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraB.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(LetraB)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraB()
        LetraElegida = LetraB.Text
    End Sub
    Private Sub LetraB_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraB.MouseHover
        TextoLetraB()
        MouseHoverTecla(LetraB)
    End Sub

    Private Sub LetraB_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraB.MouseLeave
        MouseLeaveTecla(LetraB)
    End Sub

    Private Sub LetraB_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraB.MouseUp
        MouseUpTecla(LetraB)
    End Sub
    Private Sub LetraN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraN.Click
    End Sub
    Public Sub LetraN_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraN.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(LetraN)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextroLetraN()
        LetraElegida = LetraN.Text
    End Sub
    Private Sub LetraN_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraN.MouseHover
        TextroLetraN()
        MouseHoverTecla(LetraN)
    End Sub

    Private Sub LetraN_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraN.MouseLeave
        MouseLeaveTecla(LetraN)
    End Sub

    Private Sub LetraN_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraN.MouseUp
        MouseUpTecla(LetraN)
    End Sub
    Private Sub LetraM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraM.Click
    End Sub
    Private Sub LetraM_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraM.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(LetraM)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextroLetraM()
        LetraElegida = LetraM.Text
    End Sub
    Private Sub LetraM_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraM.MouseHover
        TextroLetraM()
        MouseHoverTecla(LetraM)
    End Sub

    Private Sub LetraM_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraM.MouseLeave
        MouseLeaveTecla(LetraM)
    End Sub

    Private Sub LetraM_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraM.MouseUp
        MouseUpTecla(LetraM)
    End Sub
    Private Sub TeclaComa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaComa.Click
    End Sub
    Private Sub TeclaComa_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaComa.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(TeclaComa)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraComa1()
        LetraElegida = TeclaComa.Text
    End Sub
    Private Sub TeclaComa_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaComa.MouseHover
        TextoLetraComa()
        MouseHoverTecla(TeclaComa)
    End Sub

    Private Sub TeclaComa_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaComa.MouseLeave
        MouseLeaveTecla(TeclaComa)
    End Sub

    Private Sub TeclaComa_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaComa.MouseUp
        MouseUpTecla(TeclaComa)
    End Sub
    Private Sub TeclaPunto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaPunto.Click
    End Sub
    Private Sub TeclaPunto_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaPunto.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(TeclaPunto)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraPunto()
        LetraElegida = TeclaPunto.Text
    End Sub
    Private Sub TeclaPunto_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaPunto.MouseHover
        TextoLetraPunto()
        MouseHoverTecla(TeclaPunto)
    End Sub
    Private Sub TeclaPunto_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaPunto.MouseLeave
        MouseLeaveTecla(TeclaPunto)
    End Sub

    Private Sub TeclaPunto_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaPunto.MouseUp
        MouseUpTecla(TeclaPunto)
    End Sub
    Private Sub TeclaGuion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaGuion.Click
    End Sub
    Private Sub TeclaGuion_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaGuion.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(TeclaGuion)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraGuion()
        LetraElegida = TeclaGuion.Text
    End Sub
    Private Sub TeclaGuion_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaGuion.MouseHover
        TextoLetraGuion()
        MouseHoverTecla(TeclaGuion)
    End Sub

    Private Sub TeclaGuion_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaGuion.MouseLeave
        MouseLeaveTecla(TeclaGuion)
    End Sub

    Private Sub TeclaGuion_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaGuion.MouseUp
        MouseUpTecla(TeclaGuion)
    End Sub
    Private Sub TeclaComillas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaComillas.Click
    End Sub
    Private Sub TeclaComillas_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaComillas.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(TeclaComillas)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraComillas()
        LetraElegida = TeclaComillas.Text
    End Sub
    Private Sub TeclaComillas_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaComillas.MouseHover
        TextoLetraComillas()
        MouseHoverTecla(TeclaComillas)
    End Sub
    Private Sub TeclaComillas_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaComillas.MouseLeave
        MouseLeaveTecla(TeclaComillas)
    End Sub

    Private Sub TeclaComillas_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaComillas.MouseUp
        MouseUpTecla(TeclaComillas)
    End Sub
    Private Sub TeclaBarra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaBarra.Click
    End Sub
    Private Sub TeclaBarra_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaBarra.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(TeclaBarra)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraBarra()
        LetraElegida = TeclaBarra.Text
    End Sub

    Private Sub TeclaBarra_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaBarra.MouseHover
        TextoLetraBarra()
        MouseHoverTecla(TeclaBarra)
    End Sub

    Private Sub TeclaBarra_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaBarra.MouseLeave
        MouseLeaveTecla(TeclaBarra)
    End Sub

    Private Sub TeclaBarra_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaBarra.MouseUp
        MouseUpTecla(TeclaBarra)
    End Sub
    Private Sub TeclaOrdinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaOrdinal.Click
    End Sub
    Private Sub TeclaOrdinal_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaOrdinal.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(TeclaOrdinal)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraTeclaOrdinal()
        LetraElegida = TeclaOrdinal.Text
    End Sub
    Private Sub TeclaOrdinal_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaOrdinal.MouseHover
        TextoLetraTeclaOrdinal()
        MouseHoverTecla(TeclaOrdinal)
    End Sub
    Private Sub TeclaOrdinal_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaOrdinal.MouseLeave
        MouseLeaveTecla(TeclaOrdinal)
    End Sub
    Private Sub TeclaOrdinal_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaOrdinal.MouseUp
        MouseUpTecla(TeclaOrdinal)
    End Sub
    Private Sub TeclaNumeral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaNumeral.Click
    End Sub
    Private Sub TeclaNumeral_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaNumeral.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(TeclaNumeral)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraNumeral()
        LetraElegida = TeclaNumeral.Text
    End Sub
    Private Sub TeclaNumeral_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaNumeral.MouseHover
        TextoLetraNumeral()
        MouseHoverTecla(TeclaNumeral)
    End Sub

    Private Sub TeclaNumeral_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaNumeral.MouseLeave
        MouseLeaveTecla(TeclaNumeral)
    End Sub

    Private Sub TeclaNumeral_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaNumeral.MouseUp
        MouseUpTecla(TeclaNumeral)
    End Sub

    Private Sub TeclaPesos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaPesos.Click
    End Sub
    Private Sub TeclaPesos_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaPesos.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(TeclaPesos)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoletraPesos()
        LetraElegida = TeclaPesos.Text
    End Sub
    Private Sub TeclaPesos_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaPesos.MouseHover
        TextoletraPesos()
        MouseHoverTecla(TeclaPesos)
    End Sub
    Private Sub TeclaPesos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaPesos.MouseLeave
        MouseLeaveTecla(TeclaPesos)
    End Sub

    Private Sub TeclaPesos_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaPesos.MouseUp
        MouseUpTecla(TeclaPesos)
    End Sub
    Private Sub TeclaPorCiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaPorCiento.Click
    End Sub
    Private Sub TeclaPorCiento_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaPorCiento.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(TeclaPorCiento)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraPorCiento()
        LetraElegida = TeclaPorCiento.Text
    End Sub
    Private Sub TeclaPorCiento_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaPorCiento.MouseHover
        TextoLetraPorCiento()
        MouseHoverTecla(TeclaPorCiento)
    End Sub
    Private Sub TeclaPorCiento_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaPorCiento.MouseLeave
        MouseLeaveTecla(TeclaPorCiento)
    End Sub
    Private Sub TeclaPorCiento_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaPorCiento.MouseUp
        MouseUpTecla(TeclaPorCiento)
    End Sub
    Private Sub TeclaAbreParentesis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaAbreParentesis.Click
    End Sub
    Private Sub TeclaAbreParentesis_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaAbreParentesis.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(TeclaAbreParentesis)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraAbreParentesis()
        LetraElegida = TeclaAbreParentesis.Text
    End Sub
    Private Sub TeclaAbreParentesis_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaAbreParentesis.MouseHover
        TextoLetraAbreParentesis()
        MouseHoverTecla(TeclaAbreParentesis)
    End Sub
    Private Sub TeclaAbreParentesis_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaAbreParentesis.MouseLeave
        MouseLeaveTecla(TeclaAbreParentesis)
    End Sub
    Private Sub TeclaAbreParentesis_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaAbreParentesis.MouseUp
        MouseUpTecla(TeclaAbreParentesis)
    End Sub
    Private Sub TeclaCierraParentesis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaCierraParentesis.Click
    End Sub
    Private Sub TeclaCierraParentesis_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaCierraParentesis.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(TeclaCierraParentesis)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraCierraParentesis()
        LetraElegida = TeclaCierraParentesis.Text
    End Sub
    Private Sub TeclaCierraParentesis_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaCierraParentesis.MouseHover
        TextoLetraCierraParentesis()
        MouseHoverTecla(TeclaCierraParentesis)
    End Sub
    Private Sub TeclaCierraParentesis_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaCierraParentesis.MouseLeave
        MouseLeaveTecla(TeclaCierraParentesis)
    End Sub
    Private Sub TeclaCierraParentesis_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaCierraParentesis.MouseUp
        MouseUpTecla(TeclaCierraParentesis)
    End Sub
    Private Sub TeclaGuionLargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaGuionLargo.Click
    End Sub
    Private Sub TeclaGuionLargo_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaGuionLargo.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(TeclaGuionLargo)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraGuionLargo()
        LetraElegida = TeclaGuionLargo.Text
    End Sub
    Private Sub TeclaGuionLargo_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaGuionLargo.MouseHover
        TextoLetraGuionLargo()
        MouseHoverTecla(TeclaGuionLargo)
    End Sub
    Private Sub TeclaGuionLargo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaGuionLargo.MouseLeave
        MouseLeaveTecla(TeclaGuionLargo)
    End Sub
    Private Sub TeclaGuionLargo_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaGuionLargo.MouseUp
        MouseUpTecla(TeclaGuionLargo)
    End Sub
    Private Sub LetraQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraQ.Click
    End Sub
    Private Sub LetraQ_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraQ.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(LetraQ)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraQ()
        LetraElegida = LetraQ.Text
    End Sub
    Private Sub LetraQ_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraQ.MouseHover
        TextoLetraQ()
        MouseHoverTecla(LetraQ)
    End Sub
    Private Sub LetraQ_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraQ.MouseLeave
        MouseLeaveTecla(LetraQ)
    End Sub
    Private Sub LetraQ_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraQ.MouseUp
        MouseUpTecla(LetraQ)
    End Sub
    Private Sub LetraW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraW.Click
    End Sub
    Private Sub LetraW_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraW.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(LetraW)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraW()
        LetraElegida = LetraW.Text
    End Sub
    Private Sub LetraW_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraW.MouseHover
        TextoLetraW()
        MouseHoverTecla(LetraW)
    End Sub
    Private Sub LetraW_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraW.MouseLeave
        MouseLeaveTecla(LetraW)
    End Sub
    Private Sub LetraW_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraW.MouseUp
        MouseUpTecla(LetraW)
    End Sub
    Private Sub LetraE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraE.Click
    End Sub
    Private Sub LetraE_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraE.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(LetraE)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraE()
        If Acentuada = False And Dieresis = False Then
            LetraElegida = LetraE.Text
        ElseIf Acentuada = True Then
            If LetraE.Text = "E" Then
                LetraElegida = "É"
            Else
                LetraElegida = "é"
            End If
            'Acentuada = False
            'TeclaAcento.BackColor = Nothing
        ElseIf Dieresis = True Then
            If LetraE.Text = "E" Then
                LetraElegida = "Ë"
            Else
                'Posiciones(LetraE.Text, Anotador.Texto.SelectedText)
                LetraElegida = "ë"
            End If
            'Dieresis = False
            ' TeclaAcento.BackColor = Nothing
        End If
    End Sub
    Private Sub LetraE_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraE.MouseHover
        TextoLetraE()
        MouseHoverTecla(LetraE)
    End Sub

    Private Sub LetraE_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraE.MouseLeave
        MouseLeaveTecla(LetraE)
    End Sub

    Private Sub LetraE_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraE.MouseUp
        MouseUpTecla(LetraE)
    End Sub
    Private Sub LetraR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraR.Click
    End Sub
    Private Sub LetraR_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraR.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(LetraR)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraR()
        LetraElegida = LetraR.Text
    End Sub

    Private Sub LetraR_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraR.MouseHover
        TextoLetraR()
        MouseHoverTecla(LetraR)
    End Sub

    Private Sub LetraR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraR.MouseLeave
        MouseLeaveTecla(LetraR)
    End Sub

    Private Sub LetraR_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraR.MouseUp
        MouseUpTecla(LetraR)
    End Sub
    Private Sub LetraY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraY.Click
    End Sub
    Private Sub LetraY_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraY.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(LetraY)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraY()
        LetraElegida = LetraY.Text
    End Sub

    Private Sub LetraY_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraY.MouseHover
        TextoLetraY()
        MouseHoverTecla(LetraY)
    End Sub

    Private Sub LetraY_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraY.MouseLeave
        MouseLeaveTecla(LetraY)
    End Sub

    Private Sub LetraY_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraY.MouseUp
        MouseUpTecla(LetraY)
    End Sub
    Private Sub LetraU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraU.Click
    End Sub
    Private Sub LetraU_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraU.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(LetraU)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraU()
        If Acentuada = False And Dieresis = False Then
            LetraElegida = LetraU.Text
        ElseIf Acentuada = True Then
            If LetraU.Text = "U" Then
                LetraElegida = "Ú"
            Else
                LetraElegida = "ú"
            End If
            'Acentuada = False
            'TeclaAcento.BackColor = Nothing
        ElseIf Dieresis = True Then
            If LetraU.Text = "U" Then
                LetraElegida = "Ü"
            Else
                LetraElegida = "ü"
                'Posiciones(LetraU.Text, Anotador.Texto.SelectedText)
            End If
            'Dieresis = False
            'TeclaAcento.BackColor = Nothing
        End If
    End Sub

    Private Sub LetraU_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraU.MouseHover
        TextoLetraU()
        MouseHoverTecla(LetraU)
    End Sub

    Private Sub LetraU_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraU.MouseLeave
        MouseLeaveTecla(LetraU)
    End Sub

    Private Sub LetraU_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraU.MouseUp
        MouseUpTecla(LetraU)
    End Sub
    Private Sub LetraI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraI.Click
    End Sub
    Private Sub LetraI_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraI.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(LetraI)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraI()
        If Acentuada = False And Dieresis = False Then
            LetraElegida = LetraI.Text
        ElseIf Acentuada = True Then
            If LetraI.Text = "I" Then
                LetraElegida = "Í"
            Else
                LetraElegida = "í"
            End If
            'Acentuada = False
            'TeclaAcento.BackColor = Nothing
        ElseIf Dieresis = True Then
            If LetraI.Text = "I" Then
                LetraElegida = "Ï"
            Else
                'Posiciones(LetraI.Text, Anotador.Texto.SelectedText)
                LetraElegida = "ï"
            End If
            ' Dieresis = False
            'TeclaAcento.BackColor = Nothing
        End If
    End Sub
    Private Sub LetraI_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraI.MouseHover
        TextoLetraI()
        MouseHoverTecla(LetraI)
    End Sub

    Private Sub LetraI_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraI.MouseLeave
        MouseLeaveTecla(LetraI)
    End Sub

    Private Sub LetraI_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraI.MouseUp
        MouseUpTecla(LetraI)
    End Sub
    Private Sub LetraO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraO.Click

    End Sub
    Private Sub LetraO_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraO.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(LetraO)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraO()
        If Acentuada = False And Dieresis = False Then
            LetraElegida = LetraO.Text
        ElseIf Acentuada = True Then
            If LetraO.Text = "O" Then
                LetraElegida = "Ó"
            Else
                LetraElegida = "ó"
            End If
            'Acentuada = False
            ' TeclaAcento.BackColor = Nothing
        ElseIf Dieresis = True Then
            If LetraO.Text = "O" Then
                LetraElegida = "Ö"
            Else
                'Posiciones(LetraO.Text, Anotador.Texto.SelectedText)
                LetraElegida = "ö"
            End If
            'Dieresis = False
            ' TeclaAcento.BackColor = Nothing

        End If
    End Sub
    Private Sub LetraO_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraO.MouseHover
        TextoLetraO()
        MouseHoverTecla(LetraO)
    End Sub

    Private Sub LetraO_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraO.MouseLeave
        MouseLeaveTecla(LetraO)
    End Sub

    Private Sub LetraO_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraO.MouseUp
        MouseUpTecla(LetraO)
    End Sub
    Private Sub LetraP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraP.Click
    End Sub
    Private Sub LetraP_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraP.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(LetraP)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraP()
        LetraElegida = LetraP.Text
    End Sub
    Private Sub LetraP_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraP.MouseHover
        TextoLetraP()
        MouseHoverTecla(LetraP)
    End Sub

    Private Sub LetraP_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraP.MouseLeave
        MouseLeaveTecla(LetraP)
    End Sub

    Private Sub LetraP_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraP.MouseUp
        MouseUpTecla(LetraP)
    End Sub
    Private Sub TeclaAbreInterrogacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaAbreInterrogacion.Click
    End Sub
    Private Sub TeclaAbreInterrogacion_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaAbreInterrogacion.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(TeclaAbreInterrogacion)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraAbreInterrogacion()
        LetraElegida = TeclaAbreInterrogacion.Text
    End Sub
    Private Sub TeclaAbreInterrogacion_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaAbreInterrogacion.MouseHover
        TextoLetraAbreInterrogacion()
        MouseHoverTecla(TeclaAbreInterrogacion)
    End Sub

    Private Sub TeclaAbreInterrogacion_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaAbreInterrogacion.MouseLeave
        MouseLeaveTecla(TeclaAbreInterrogacion)
    End Sub

    Private Sub TeclaAbreInterrogacion_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaAbreInterrogacion.MouseUp
        MouseUpTecla(TeclaAbreInterrogacion)
    End Sub
    Private Sub TeclaCierraInterrogacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaCierraInterrogacion.Click
    End Sub
    Private Sub TeclaCierraInterrogacion_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaCierraInterrogacion.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(TeclaCierraInterrogacion)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraCierraInterrogacion()
        LetraElegida = TeclaCierraInterrogacion.Text
    End Sub
    Private Sub TeclaCierraInterrogacion_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaCierraInterrogacion.MouseHover
        TextoLetraCierraInterrogacion()
        MouseHoverTecla(TeclaCierraInterrogacion)
    End Sub
    Private Sub TeclaCierraInterrogacion_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaCierraInterrogacion.MouseLeave
        MouseLeaveTecla(TeclaCierraInterrogacion)
    End Sub

    Private Sub TeclaCierraInterrogacion_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaCierraInterrogacion.MouseUp
        MouseUpTecla(TeclaCierraInterrogacion)
    End Sub
    Private Sub Boton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton1.Click
    End Sub
    Private Sub Boton1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Boton1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(Boton1)
        Else
            Anotador.RetrocedeBorra1solo()
        End If

        'LetraElegida = "1"
        'PoneLetra()
        'ActivarRepeticion()
        'InvierteColorSuenaTecla(Boton1)
    End Sub
    Private Sub TextoLetra1()
        LetraElegida = "1"
    End Sub

    Private Sub Boton1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Boton1.MouseHover
        TextoLetra1()
        MouseHoverTecla(Boton1)

        'IluminaColorTecla(Boton1)
    End Sub

    Private Sub Boton1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Boton1.MouseLeave
        MouseLeaveTecla(Boton1)
        'DetieneTimerLetra()
        'RestauraColorTecla1(Boton1)
    End Sub

    Private Sub Boton1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Boton1.MouseUp
        MouseUpTecla(Boton1)
        'DetieneTimerLetra()
        'RestauraColorTecla1(Boton1)
    End Sub
    Private Sub Boton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton2.Click
    End Sub
    Private Sub Boton2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Boton2.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(Boton2)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetra2()
        LetraElegida = "2"
    End Sub
    Private Sub Boton2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Boton2.MouseHover
        TextoLetra2()
        MouseHoverTecla(Boton2)
    End Sub
    Private Sub Boton2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Boton2.MouseLeave
        MouseLeaveTecla(Boton2)
    End Sub
    Private Sub Boton2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Boton2.MouseUp
        MouseUpTecla(Boton2)
    End Sub
    Private Sub Boton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton3.Click
    End Sub
    Private Sub Boton3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Boton3.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(Boton3)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetra3()
        LetraElegida = "3"
    End Sub
    Private Sub Boton3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Boton3.MouseHover
        TextoLetra3()
        MouseHoverTecla(Boton3)
    End Sub
    Private Sub Boton3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Boton3.MouseLeave
        MouseLeaveTecla(Boton3)
    End Sub
    Private Sub Boton3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Boton3.MouseUp
        MouseUpTecla(Boton3)
    End Sub
    Private Sub Boton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton4.Click
    End Sub
    Private Sub Boton4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Boton4.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(Boton4)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetra4()
        LetraElegida = "4"
    End Sub
    Private Sub Boton4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Boton4.MouseHover
        TextoLetra4()
        MouseHoverTecla(Boton4)
    End Sub
    Private Sub Boton4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Boton4.MouseLeave
        MouseLeaveTecla(Boton4)
    End Sub
    Private Sub Boton4_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Boton4.MouseUp
        MouseUpTecla(Boton4)
    End Sub
    Private Sub Boton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton5.Click
    End Sub
    Private Sub Boton5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Boton5.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(Boton4)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetra5()
        LetraElegida = "5"
    End Sub
    Private Sub Boton5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Boton5.MouseHover
        TextoLetra5()
        MouseHoverTecla(Boton5)
    End Sub
    Private Sub Boton5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Boton5.MouseLeave
        MouseLeaveTecla(Boton5)
    End Sub
    Private Sub Boton5_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Boton5.MouseUp
        MouseUpTecla(Boton5)
    End Sub
    Private Sub Boton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton6.Click
    End Sub
    Private Sub Boton6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Boton6.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(Boton6)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetra6()
        LetraElegida = "6"
    End Sub
    Private Sub Boton6_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Boton6.MouseHover
        TextoLetra6()
        MouseHoverTecla(Boton6)
    End Sub
    Private Sub Boton6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Boton6.MouseLeave
        MouseLeaveTecla(Boton6)
    End Sub
    Private Sub Boton6_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Boton6.MouseUp
        MouseUpTecla(Boton6)
    End Sub
    Private Sub Boton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton7.Click
    End Sub
    Private Sub Boton7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Boton7.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(Boton7)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetra7()
        LetraElegida = "7"
    End Sub
    Private Sub Boton7_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Boton7.MouseHover
        TextoLetra7()
        MouseHoverTecla(Boton7)
    End Sub
    Private Sub Boton7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Boton7.MouseLeave
        MouseLeaveTecla(Boton7)
    End Sub
    Private Sub Boton7_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Boton7.MouseUp
        MouseUpTecla(Boton7)
    End Sub
    Private Sub Boton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton8.Click
    End Sub
    Private Sub Boton8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Boton8.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(Boton8)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetra8()
        LetraElegida = "8"
    End Sub
    Private Sub Boton8_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Boton8.MouseHover
        TextoLetra8()
        MouseHoverTecla(Boton8)
    End Sub
    Private Sub Boton8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Boton8.MouseLeave
        MouseLeaveTecla(Boton8)
    End Sub
    Private Sub Boton8_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Boton8.MouseUp
        MouseUpTecla(Boton8)
    End Sub
    Private Sub Boton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton9.Click
    End Sub
    Private Sub Boton9_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Boton9.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(Boton9)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetra9()
        LetraElegida = "9"
    End Sub
    Private Sub Boton9_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Boton9.MouseHover
        TextoLetra9()
        MouseHoverTecla(Boton9)
    End Sub
    Private Sub Boton9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Boton9.MouseLeave
        MouseLeaveTecla(Boton9)
    End Sub
    Private Sub Boton9_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Boton9.MouseUp
        MouseUpTecla(Boton9)
    End Sub
    Private Sub Boton0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton0.Click
    End Sub
    Private Sub Boton0_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Boton0.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(Boton0)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetra0()
        LetraElegida = "0"
    End Sub
    Private Sub Boton0_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Boton0.MouseHover
        TextoLetra0()
        MouseHoverTecla(Boton0)
    End Sub
    Private Sub Boton0_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Boton0.MouseLeave
        MouseLeaveTecla(Boton0)
    End Sub
    Private Sub Boton0_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Boton0.MouseUp
        MouseUpTecla(Boton0)
    End Sub
    Private Sub BotonComa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonComa.Click
    End Sub
    Private Sub BotonComa_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonComa.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(BotonComa)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraComa()
        LetraElegida = ","
    End Sub
    Private Sub BotonComa_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonComa.MouseHover
        TextoLetraComa()
        MouseHoverTecla(BotonComa)
    End Sub
    Private Sub BotonComa_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonComa.MouseLeave
        MouseLeaveTecla(BotonComa)
    End Sub
    Private Sub BotonComa_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonComa.MouseUp
        MouseUpTecla(BotonComa)
    End Sub
    Private Sub BotonMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonMenos.Click
        ' IluminaColorTecla(BotonMenos)
    End Sub
    Private Sub BotonMenos_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonMenos.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(BotonMenos)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraMenos()
        LetraElegida = "-"
    End Sub
    Private Sub BotonMenos_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonMenos.MouseHover
        TextoLetraMenos()
        MouseHoverTecla(BotonMenos)
    End Sub
    Private Sub BotonMenos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonMenos.MouseLeave
        MouseLeaveTecla(BotonMenos)
    End Sub
    Private Sub BotonMenos_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonMenos.MouseUp
        MouseUpTecla(BotonMenos)
    End Sub
    Private Sub BotonMas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonMas.Click
    End Sub
    Private Sub BotonMas_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonMas.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(BotonMas)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraMas()
        LetraElegida = "+"
    End Sub
    Private Sub BotonMas_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonMas.MouseHover
        TextoLetraMas()
        MouseHoverTecla(BotonMas)
    End Sub
    Private Sub BotonMas_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonMas.MouseLeave
        MouseLeaveTecla(BotonMas)
    End Sub
    Private Sub BotonMas_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonMas.MouseUp
        MouseUpTecla(BotonMas)
    End Sub
    Private Sub BotonPor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonPor.Click
    End Sub
    Private Sub BotonPor_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonPor.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(BotonPor)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraPor()
        LetraElegida = "×"
    End Sub
    Private Sub BotonPor_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonPor.MouseHover
        TextoLetraPor()
        MouseHoverTecla(BotonPor)
    End Sub
    Private Sub BotonPor_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonPor.MouseLeave
        MouseLeaveTecla(BotonPor)
    End Sub
    Private Sub BotonPor_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonPor.MouseUp
        MouseUpTecla(BotonPor)
    End Sub
    Private Sub BotonDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonDiv.Click
    End Sub
    Private Sub BotonDiv_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonDiv.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(BotonDiv)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraDiv()
        LetraElegida = "÷"
    End Sub
    Private Sub BotonDiv_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonDiv.MouseHover
        TextoLetraDiv()
        MouseHoverTecla(BotonDiv)
    End Sub
    Private Sub BotonDiv_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonDiv.MouseLeave
        MouseLeaveTecla(BotonDiv)
    End Sub
    Private Sub BotonDiv_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonDiv.MouseUp
        MouseUpTecla(BotonDiv)
    End Sub
    Private Sub TeclaEspacio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaEspacio.Click
    End Sub
    Private Sub TeclaEspacio_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaEspacio.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(TeclaEspacio)
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Private Sub TextoLetraEspacio()
        LetraElegida = " "
    End Sub
    Private Sub TeclaEspacio_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaEspacio.MouseHover
        TextoLetraEspacio()
        MouseHoverTecla(TeclaEspacio)
    End Sub
    Private Sub TeclaEspacio_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TeclaEspacio.MouseLeave
        MouseLeaveTecla2(TeclaEspacio)
        ' Utiliza RestauraColorTecla2
    End Sub

    Private Sub TeclaEspacio_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaEspacio.MouseUp
        MouseUpTecla2(TeclaEspacio)
        ' Utiliza RestauraColorTecla2
    End Sub

    Private Sub BotonRepiteAscii_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub BotonRepiteAscii_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub BotonRepiteAscii_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BotonRepiteAscii_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub



    Private Sub BTeclado_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonTeclado.MouseHover
        Anotador.TopMost = True
        Anotador.TopMost = False
        Me.TopMost = True
    End Sub

    Private Sub Button1_Click_4(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BotonQuitaEspacios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub BotonQuitaEspacios_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub Button1_MouseDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub Aclaraciones_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles Aclaraciones.Popup
        Aclaraciones.IsBalloon = True

    End Sub

    Private Sub BotonAcentuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BotonAcentuar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub


    Private Sub BotonCopia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonCopia.Click
    End Sub
    Private Sub BotonCopia_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonCopia.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Left Then
            Copia(Anotador.Texto.SelectedText)
            InvierteColorSuenaTecla(BotonCopia)
        Else
            Clipboard.SetText(Anotador.Texto.SelectedText)
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
            Pega(Anotador.Texto.SelectedText)
        Else
            PegaPortapapeles(Anotador.Texto.SelectedText)
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
    Private Sub BotonEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonEnter.Click
    End Sub
    Private Sub BotonEnter_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonEnter.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDownTecla(BotonEnter)
        Else
            Anotador.RetrocedeBorra1solo()
        End If

        'Dim varchr = vbCrLf '        Chr(13) 'vbenter 'Chr(10) & Chr(13)
        'PoneTeclaEnter(varchr)
        'InvierteColorSuenaTecla(BotonEnter)
    End Sub
    Private Sub TextoLetraEnter()
        'LetraElegida = vbCrLf
        LetraElegida = Chr(13) & Chr(10)

    End Sub
    Private Sub BotonEnter_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonEnter.MouseHover
        TextoLetraEnter()
        MouseHoverTecla(BotonEnter)
    End Sub
    Private Sub BotonEnter_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonEnter.MouseLeave
        MouseLeaveTecla3(BotonEnter)
    End Sub
    Private Sub BotonEnter_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonEnter.MouseUp
        MouseUpTecla3(BotonEnter)
    End Sub

    Private Sub BotonQuitaEspacios_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BotonQuitaEspacios_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BotonQuitaEspacios_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub BotonAcentuarDesacentuar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BotonAcentuarDesacentuar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BotonAcentuarDesacentuar_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub BotonTodoMayMin_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub BotonTodoMayMin_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub BotonTodoMayMin_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    End Sub

    Private Sub BotonMayusculasIniciales_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub BotonMayusculasIniciales_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub BotonMayusculasIniciales_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    End Sub

    Private Sub BotonLeeRecortes_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub BotonLeeRecortes_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BotonLeeRecortes_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BotonLeeRecortes_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub BotonRepiteRecorte_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub
    Private Sub BotonRepiteRecorte_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub BotonRepiteRecorte_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub BotonRepiteRecorte_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    End Sub
    Private Sub BotonRepìtePredeterminado_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    End Sub
    Private Sub BotonRepìtePredeterminado_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub BotonRepìtePredeterminado_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub BotonRepìtePredeterminado_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    End Sub




    Private Sub TimerOprimirAuto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerOprimirAuto.Tick
        PoneLetra()
        SuenaTic()
        TimerOprimirAuto.Enabled = False
        InvierteColorSuenaTecla(TeclaPresionada)
        TimerRevertirColor.Enabled = True
    End Sub

    Private Sub TimerRevertirColor_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerRevertirColor.Tick
        RestauraColorTecla1(TeclaPresionada)
        TimerRevertirColor.Enabled = False
    End Sub

    Private Sub TextoVelocidadRepeticion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub TextoVelocidadRepeticion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckDisparoAuto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckSonido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FolderBrowserDialog1.HelpRequest

    End Sub


    Private Sub BotonReemplazar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BotonReemplazar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    End Sub


    Private Sub Checkeys_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextoVelocidadRepetición_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub BotonArribaAbajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonArribaAbajo.Click
    End Sub
    Private Sub BotonArribaAbajo_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonArribaAbajo.MouseDown
        HorizontalVertical = False
        If e.Button = Windows.Forms.MouseButtons.Left Then
            AtrasAdelante = True
        Else
            AtrasAdelante = False
        End If
        Anotador.Direcciones()
        InvierteColorSuenaTecla(BotonArribaAbajo)
        SuenaScroll()
    End Sub
    Private Sub BotonArribaAbajo_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonArribaAbajo.MouseHover
    End Sub
    Private Sub BotonArribaAbajo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonArribaAbajo.MouseLeave
        Anotador.TimerActivaScrollAutomatico.Enabled = False
        Anotador.TimerAvanzaRetrocedeAuto.Enabled = False
        RestauraColorTecla2(BotonArribaAbajo)
    End Sub
    Private Sub BotonArribaAbajo_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonArribaAbajo.MouseUp
        Anotador.TimerActivaScrollAutomatico.Enabled = False
        Anotador.TimerAvanzaRetrocedeAuto.Enabled = False
        RestauraColorTecla2(BotonArribaAbajo)
    End Sub

    Private Sub BotonDirector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckConShift_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckConShift.CheckedChanged
        If CheckConShift.Checked = True Then
            ConShift = True
        Else
            ConShift = False
        End If
        If CheckConShift.Checked = True Then
            FormAuxiliar.CheckAcento.Checked = False
            FormAuxiliar.CheckMin.Checked = False
            FormAuxiliar.CheckMay1.Checked = False
            FormAuxiliar.CheckMay2.Checked = False
        End If

    End Sub

    Private Sub BotonTransparencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonTransparencia.Click

    End Sub

    Private Sub BotonTransparencia_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonTransparencia.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Opacity = Me.Opacity + 0.05
        Else
            Me.Opacity = Me.Opacity - 0.05
            If Me.Opacity < 0.3 Then Me.Opacity = 0.4
        End If
    End Sub
    Public Sub MouseHoverTecla(ByVal Tecla As System.Windows.Forms.Button)
        TeclaPresionada = Tecla
        IluminaColorTecla(Tecla)
        ActivaTimerOprimirAuto()
    End Sub

    Private Sub BotonTeclado_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonTeclado.MouseLeave

    End Sub
End Class