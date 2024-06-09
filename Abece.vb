Public Class Abece
    'Dim LetraMayúscula = False
    ' Dim FijaMayúsculas = False
    'Dim Acentuada = False
    'Dim Dieresis = False
    Private Sub TeclaMayusculas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaMayusculas.Click

    End Sub

    Private Sub Mayusculas_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaMayusculas.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If LetraMayúscula = True Then
                LetraMayúscula = False
                FijaMayúsculas = False
                PoneMinusculas()
                Teclado.PoneMinusculas()
            Else
                LetraMayúscula = True
                PoneMayusculas()
                Teclado.PoneMayusculas()
                FijaMayúsculas = False
            End If

        Else
            If LetraMayúscula = True Then
                LetraMayúscula = False
                FijaMayúsculas = False
                PoneMinusculas()
                Teclado.PoneMinusculas()
            Else
                LetraMayúscula = True
                PoneMayusculas()
                Teclado.PoneMayusculas()
                FijaMayúsculas = True

            End If
        End If
        SuenaMay()
        TeclaMayusculas.BackColor = Inviertecolor(TecladoColorFondo1)
        TeclaMayusculas.ForeColor = Inviertecolor(TecladoColorLetraTeclas)
        'InvierteColorSuenaTecla(TeclaMayusculas)
    End Sub

    Private Sub Abece_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

        Anotador.Texto.Focus()
    End Sub

    Public Sub MouseDownTecla(ByVal Tecla As System.Windows.Forms.Button)
        InvierteColorSuenaTecla(Tecla)
        'EligeLetraA(Tecla)
        PoneLetra()
        'ActivarRepeticion()
        'DesactivaTimerOprimirAuto()
    End Sub
    Public Sub PoneLetra()
        'Dim Keys As Boolean = True

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
    Public Sub PoneLetrares()
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

    Private Sub LetraA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraA.Click

    End Sub

    Private Sub LetraA_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraA.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            'TextoLetraA()
            LetraElegida = LetraA.Text
            'PoneLetra()
            Anotador.PoneLetra()
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub
    Public Sub TextoLetraA()
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
    Private Sub LetraB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraB.Click

    End Sub

    Private Sub LetraB_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraB.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LetraElegida = LetraB.Text
            'PoneLetra()
            Anotador.PoneLetra()
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub

    Private Sub LetraC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraC.Click

    End Sub

    Private Sub LetraC_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraC.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LetraElegida = LetraC.Text
            'PoneLetra()
            Anotador.PoneLetra()
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub

    Private Sub LetraD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraD.Click

    End Sub

    Private Sub LetraD_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraD.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LetraElegida = LetraD.Text
            'PoneLetra()
            Anotador.PoneLetra()
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub

    Private Sub LetraE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraE.Click

    End Sub

    Private Sub LetraE_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraE.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LetraElegida = LetraE.Text
            'PoneLetra()
            Anotador.PoneLetra()
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub

    Private Sub LetraF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraF.Click

    End Sub

    Private Sub LetraF_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraF.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LetraElegida = LetraF.Text
            'PoneLetra()
            Anotador.PoneLetra()
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub

    Private Sub LetraG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraG.Click

    End Sub

    Private Sub LetraG_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraG.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LetraElegida = LetraG.Text
            'PoneLetra()
            Anotador.PoneLetra()
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub

    Private Sub LetraH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraH.Click

    End Sub

    Private Sub LetraH_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraH.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LetraElegida = LetraH.Text
            'PoneLetra()
            Anotador.PoneLetra()
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub

    Private Sub LetraI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraI.Click

    End Sub

    Private Sub LetraI_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraI.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LetraElegida = LetraI.Text
            'PoneLetra()
            Anotador.PoneLetra()
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub

    Private Sub LetraJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraJ.Click

    End Sub

    Private Sub LetraJ_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraJ.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LetraElegida = LetraJ.Text
            'PoneLetra()
            Anotador.PoneLetra()
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub

    Private Sub LetraK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraK.Click

    End Sub

    Private Sub LetraK_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraK.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LetraElegida = LetraK.Text
            'PoneLetra()
            Anotador.PoneLetra()
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub

    Private Sub LetraL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraL.Click

    End Sub

    Private Sub LetraL_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraL.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LetraElegida = LetraL.Text
            'PoneLetra()
            Anotador.PoneLetra()
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub

    Private Sub LetraM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraM.Click

    End Sub

    Private Sub LetraM_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraM.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LetraElegida = LetraM.Text
            'PoneLetra()
            Anotador.PoneLetra()
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub

    Private Sub LetraN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraN.Click

    End Sub

    Private Sub LetraN_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraN.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LetraElegida = LetraN.Text
            'PoneLetra()
            Anotador.PoneLetra()
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub

    Private Sub LetraÑ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraÑ.Click

    End Sub

    Private Sub LetraÑ_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraÑ.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LetraElegida = LetraÑ.Text
            'PoneLetra()
            Anotador.PoneLetra()
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub

    Private Sub LetraO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraO.Click

    End Sub

    Private Sub LetraO_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraO.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LetraElegida = LetraO.Text
            'PoneLetra()
            Anotador.PoneLetra()
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub

    Private Sub LetraP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraP.Click

    End Sub

    Private Sub LetraP_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraP.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LetraElegida = LetraP.Text
            'PoneLetra()
            Anotador.PoneLetra()
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub

    Private Sub LetraQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraQ.Click

    End Sub

    Private Sub LetraQ_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraQ.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LetraElegida = LetraQ.Text
            'PoneLetra()
            Anotador.PoneLetra()
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub

    Private Sub LetraR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraR.Click

    End Sub

    Private Sub LetraR_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraR.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LetraElegida = LetraR.Text
            'PoneLetra()
            Anotador.PoneLetra()
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub

    Private Sub LetraS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraS.Click

    End Sub

    Private Sub LetraS_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraS.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LetraElegida = LetraS.Text
            'PoneLetra()
            Anotador.PoneLetra()
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub

    Private Sub LetraT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraT.Click

    End Sub

    Private Sub LetraT_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraT.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LetraElegida = LetraT.Text
            'PoneLetra()
            Anotador.PoneLetra()
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub

    Private Sub LetraU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraU.Click

    End Sub

    Private Sub LetraU_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraU.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LetraElegida = LetraU.Text
            'PoneLetra()
            Anotador.PoneLetra()
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub

    Private Sub LetraV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraV.Click

    End Sub

    Private Sub LetraV_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraV.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LetraElegida = LetraV.Text
            'PoneLetra()
            Anotador.PoneLetra()
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub

    Private Sub LetraW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraW.Click

    End Sub

    Private Sub LetraW_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraW.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LetraElegida = LetraW.Text
            'PoneLetra()
            Anotador.PoneLetra()
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub

    Private Sub LetraX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraX.Click

    End Sub

    Private Sub LetraX_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraX.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LetraElegida = LetraX.Text
            'PoneLetra()
            Anotador.PoneLetra()
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub

    Private Sub LetraY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraY.Click

    End Sub

    Private Sub LetraY_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraY.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LetraElegida = LetraY.Text
            'PoneLetra()
            Anotador.PoneLetra()
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub

    Private Sub LetraZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraZ.Click

    End Sub

    Private Sub LetraZ_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LetraZ.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LetraElegida = LetraZ.Text
            'PoneLetra()
            Anotador.PoneLetra()
        Else
            Anotador.RetrocedeBorra1solo()
        End If
    End Sub

    Private Sub TeclaAcento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeclaAcento.Click

    End Sub

    Private Sub TeclaAcento_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TeclaAcento.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Acentuada = True
            Dieresis = False
            TeclaAcento.BackColor = Color.Red
            SuenaTilde()
        Else
            Dieresis = True
            Acentuada = False
            TeclaAcento.BackColor = Color.LightGreen
            SuenaTilde()
        End If
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
                Me.Visible = False
                FormularioActivo(6) = False
                Anotador.Focus()
                Exit Sub
                Anotador.ExpandeAnotador()
                Anotador.Texto.Focus()
            End If
        Else
            Me.Visible = False
            FormularioActivo(6) = False
            Exit Sub
            If MuestraOcultaFormularios = False Then
                MuestraOcultaFormularios = True
                'If FormularioActivo(2) = True Then Teclado.Visible = True
                If FormularioActivo(3) = True Then FormAuxiliar.Visible = True
                If FormularioActivo(4) = True Then Director.Visible = True
                If FormularioActivo(5) = True Then FormIndice.Visible = True
                ' If FormularioActivo(6) = True Then Abece.Visible = True
            Else
                MuestraOcultaFormularios = False
                ' Teclado.Visible = False
                FormAuxiliar.Visible = False
                Director.Visible = False
                FormIndice.Visible = False
            End If
        End If
    End Sub

    Private Sub LetraE_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraE.MouseHover
        Teclado.TextoLetraE()
        MouseHoverTecla(LetraE)
    End Sub

    Private Sub LetraA_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraA.MouseHover
        Teclado.TextoLetraA()
        MouseHoverTecla(LetraA)
    End Sub

    Private Sub LetraB_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraB.MouseHover
        Teclado.TextoLetraB()
        MouseHoverTecla(LetraB)
    End Sub

    Private Sub LetraC_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraC.MouseHover
        Teclado.TextoLetraC()
        MouseHoverTecla(LetraC)
    End Sub

    Private Sub LetraD_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraD.MouseHover
        Teclado.TextoLetraD()
        MouseHoverTecla(LetraD)
    End Sub

    Private Sub LetraF_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraF.MouseHover
        Teclado.TextoLetraF()
        MouseHoverTecla(LetraF)
    End Sub

    Private Sub LetraG_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraG.MouseHover
        Teclado.TextoLetrag()
        MouseHoverTecla(LetraG)
    End Sub

    Private Sub LetraH_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraH.MouseHover
        Teclado.TextoLetraH()
        MouseHoverTecla(LetraH)
    End Sub

    Private Sub LetraI_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraI.MouseHover
        Teclado.TextoLetraI()
        MouseHoverTecla(LetraI)
    End Sub

    Private Sub LetraJ_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraJ.MouseHover
        Teclado.TextoLetraJ()
        MouseHoverTecla(LetraJ)
    End Sub
    Private Sub LetraK_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetraK.MouseHover
        Teclado.TextoLetraK()
        MouseHoverTecla(LetraK)
    End Sub

    Private Sub CheckDisparoAuto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckDisparoAuto.CheckedChanged
        If CheckDisparoAuto.Checked = True Then
            DisparoAutomatico = True
            Teclado.CheckDisparoAuto.Checked = True
        Else
            DisparoAutomatico = False
            Teclado.CheckDisparoAuto.Checked = False
        End If
    End Sub
End Class