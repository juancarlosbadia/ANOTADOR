Public Class FormIndice

    Private Sub BotonCrea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonCrea.Click
        CreaArchivo()
        TextoNombreDeRegistro.Text = ""
        TextoComentarios.Text = ""
        LeeArchivo()
    End Sub

    Private Sub BotonLee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonLee.Click
        LeeArchivo()
    End Sub

    Private Sub BotonAbre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAbre.Click
        AbreArchivo()
        LeeArchivo()
    End Sub

    Private Sub BotonAgrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAgrega.Click
        AgregaRegistro()
        LeeArchivo()
    End Sub

    Private Sub BotonModifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonModifica.Click
        ModificaRegistro()
        LeeArchivo()
    End Sub

    Private Sub BotonInserta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonInserta.Click
        IntercalaRegistro()
        LeeArchivo()
    End Sub

    Private Sub BotonBorra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonBorra.Click
        BorraRegistro()
        LeeArchivo()
    End Sub

    Private Sub ListaArchivo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaArchivo.Click

    End Sub
    Private Sub ListaArchivo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaArchivo.SelectedIndexChanged
        TextoNombreDeRegistro.Text = RTrim(ListaArchivo.Text) ' borra espacios der
        NumeroDeRegistroIndiceEnLaLista = ListaArchivo.SelectedIndex
        NumeroItemSeleccionadoIndice = ListaArchivo.SelectedIndex + 1
        TextoNumReg.Text = NumeroDeRegistroIndiceEnLaLista
        TextoNumSel.Text = NumeroItemSeleccionadoIndice
        LeeRegistrodeIndice()
        ElaboraEntrada()
    End Sub
    Private Sub BotonAbreArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAbreArchivo.Click
        On Error Resume Next
        CadenaItemSeleccionadoIndice = TextoNombreDeRegistro.Text
        Dim UltimosCaracteresIndice As String = ""
        If Len(CadenaItemSeleccionadoIndice) > 3 Then
            UltimosCaracteresIndice = Mid(CadenaItemSeleccionadoIndice, Len(CadenaItemSeleccionadoIndice) - 3)
        End If

        If UltimosCaracteresIndice = ".txt" Then
            Anotador.AbreDesdeElIndice(RTrim(TextoNombreDeRegistro.Text))
        Else
            Anotador.AbrirDocumentoExistente(TextoNombreDeRegistro.Text)
            'Shell(TextoNombreDeRegistro.Text)
        End If

    End Sub
    Public Function RecortaCadenaALaDerechaDesdeCaracterProvisto(ByVal CaracterProvisto As String, ByVal Cadena As String, ByVal CasoNegativo As String) As String
        'CaracterProvisto = "\"
        Dim LargoCadena As Integer
        Dim PosicionDeAnalisis As Integer
        Dim CaracterAnalizado As String
        Dim PosicionDesdeComienzo As Integer
        Dim CadenaRecortada As String
        LargoCadena = Len(Cadena)
        'Dim PosicionDeTrabajo As Integer
        For PosicionDeAnalisis = LargoCadena To 1 Step -1
            CaracterAnalizado = Mid(Cadena, PosicionDeAnalisis, 1)
            If CaracterAnalizado = CaracterProvisto Then
                PosicionDesdeComienzo = Len(Cadena) - (Len(Cadena) - PosicionDeAnalisis)
                CadenaRecortada = Mid(Cadena, 1, PosicionDesdeComienzo)
                Return CadenaRecortada
                Exit Function
            End If
        Next PosicionDeAnalisis
        Return CasoNegativo
    End Function
    Public Function QuitaEspaciosALaDerecha(ByVal Texto)
        QuitaEspaciosALaDerecha = RTrim(Texto)
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'TextoNombreDeRegistro.Text = ""
        TextoNombreDeRegistro.Text = Anotador.Ruta & "\" & Anotador.NombreExtension
        TextoComentarios.Text = ""
        TextoComentarios.Text = Mid(Anotador.Texto.Text, 1, 255)

    End Sub



    Private Sub FormDocumentos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.TopMost = True
        AbreArchivoInicial()
    End Sub

    Private Sub TextoComentarios_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextoComentarios.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub

    Private Sub ListaArchivo_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaArchivo.MouseHover

    End Sub
    Private Sub TextoNombreDeRegistro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextoNombreDeRegistro.TextChanged
    End Sub
    Private Sub ElaboraEntrada()
        Dim TextoElaborado As String
        TextoElaborado = RTrim(ListaArchivo.Text)

        If Len(TextoElaborado) < 4 Then
            TextoNombreDeRegistro.BackColor = Color.Azure
            TextoComentarios.BackColor = Color.LightCyan
            Exit Sub
        End If

        If Mid(TextoElaborado, Len(TextoElaborado) - 3) = ".txt" Then
            TextoNombreDeRegistro.BackColor = Color.LightYellow
            TextoComentarios.BackColor = Color.FromArgb(255, 255, 255, 200)
        Else
            If Mid(TextoElaborado, Len(TextoElaborado)) <> "\" Then
                TextoElaborado = TextoElaborado & "\"
            End If
            TextoNombreDeRegistro.BackColor = Color.Azure
            TextoComentarios.BackColor = Color.LightCyan
        End If
        TextoNombreDeRegistro.Text = TextoElaborado
        TextoExtraeDirectorio.Text = RecortaCadenaALaDerechaDesdeCaracterProvisto("\", TextoNombreDeRegistro.Text, "C:\")
    End Sub

    Private Sub BotonReservaTextoItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonReservaTextoItem.Click
        ReservaCadenaItemSeleccionadoIndice = TextoNombreDeRegistro.Text
        BotonReservaTextoItem.BackColor = SorteaColorClaro()
    End Sub

    Private Sub BotonRestauraTextoItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonRestauraTextoItem.Click
        TextoNombreDeRegistro.Text = ReservaCadenaItemSeleccionadoIndice
    End Sub

    Private Sub BotonReservaComentarioItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonReservaComentarioItem.Click
        ReservaComentarioItemSeleccionadoIndice = TextoComentarios.Text
        BotonReservaComentarioItem.BackColor = SorteaColorClaro()
    End Sub

    Private Sub BotonRestauraComentarioItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonRestauraComentarioItem.Click
        TextoComentarios.Text = ReservaComentarioItemSeleccionadoIndice
    End Sub

    Private Sub BotonBorraTextoItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonBorraTextoItem.Click
        TextoNombreDeRegistro.Text = ""
    End Sub

    Private Sub BotonBorraComentarioItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonBorraComentarioItem.Click
        TextoComentarios.Text = ""
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
            FormularioActivo(5) = False
            Anotador.Texto.Focus()
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Anotador.AbrirDirectorio(TextoNombreDeRegistro.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' TextBox1.Text = RecortaCadenaALaDerechaDesdeCaracterProvisto("\", TextoNombreDeRegistro.Text, "C:\")
        Anotador.AbrirDirectorio(TextoExtraeDirectorio.Text)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextoNombreDeRegistro.Text = TextoExtraeDirectorio.Text & TextoNombreDeRegistro.Text
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        GuardarDocumento(TextoNombreDeRegistro.Text, Anotador.Texto.Text)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim TextoDir As String = TextoExtraeDirectorio.Text
        If TextoDir = "" Then Exit Sub
        If Mid(TextoDir, 2, 1) <> ":" Then Exit Sub
        If Mid(TextoDir, Len(TextoDir)) = "\" Then
            TextoDir = Mid(TextoDir, 1, Len(TextoDir) - 1)
        End If
        Anotador.Ruta = TextoDir
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        CrearDirectorio(TextoExtraeDirectorio.Text)
    End Sub

    Private Sub BotonAjusta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAjusta.Click
        If Me.Height > TextoNombreDeRegistro.Top + TextoNombreDeRegistro.Height Then
            Me.Height = ListaArchivo.Top + ListaArchivo.Height + 35
        Else
            Me.Height = TextoComentarios.Top + TextoComentarios.Height + 35
        End If
    End Sub

    Private Sub BotonTeclado_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonTeclado.MouseHover
        Anotador.TopMost = True
        Anotador.TopMost = False
        Me.TopMost = True
    End Sub
End Class