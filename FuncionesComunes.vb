Imports System.IO

Module FuncionesComunes
    'Public AnotadorEnFoco As Object
    'Public TextoDeIntercambio As String
    Public DragDrop As Boolean = False
    Public MatrizPaleta(12, 2) As Color
    Public TextoArchivoPaleta As String
    Public ArchivoDePaleta As String = "C:\Anotador\Archivos\Paleta.txt"
    Public TecladoRedimensionable As Boolean = True
    Public Redondea As Boolean = True
    Public ReasegurarEnDirectorioActual = False
    Public NumeroColorFacil As Integer = 0
    Public NumeroColorPaleta As Integer = 0
    Public ColorFijoAsignadoALetraTablero As Color
    Public ColorFijoAsignadoAFondoTablero As Color
    Public ColorFijoAsignadoAFondoMenuTablero As Color
    Public TecladoColorFondo1 As Color
    Public TecladoColorFondo2 As Color
    Public TecladoColorFondo3 As Color
    Public TecladoColorLetraTeclas As Color
    Public TecladoColorFondoListas As Color
    Public TecladoColorLetraListas As Color
    Public TecladoColorFondo1Res As Color
    Public TecladoColorFondo2Res As Color
    Public TecladoColorFondo3Res As Color
    Public TecladoColorFondoListasRes As Color
    Public TecladoColorLetraRes As Color
    Public TextoBackColorPublic As Color
    Public TextoForeColorPublic As Color
    Public Claroscuro As Boolean
    Public SonidoActivado As Boolean = False
    Public HorizontalVertical As Boolean
    Public AtrasAdelante As Boolean
    Public ConShift As Boolean
    Public AKeys As Boolean = True
    Public VelocidadRepeticionTecla As Integer = 100
    Public DisparoAutomatico As Boolean = False
    Public PosicionesFormularios As Integer
    Public FormularioActivo(6) As Boolean
    Public MuestraOcultaFormularios As Boolean

    Public NombreDelCuadroACerrar As String
    Public LetraMayúscula = False
    Public FijaMayúsculas = False
    Public Acentuada = False
    Public Dieresis = False
    Public ValorFuente As Integer = 1

    Public Sub FormatoFuente(ByVal avaret As Boolean)
        If avaret = 0 Then
            ValorFuente = ValorFuente - 1
        Else
            ValorFuente = ValorFuente + 1
        End If

        If ValorFuente > 8 Then
            ValorFuente = 1
        End If
        If ValorFuente < 1 Then
            ValorFuente = 8
        End If
        Dim FuenteActual As Font

        FuenteActual = Anotador.Texto.Font

        Select Case ValorFuente
            Case Is = 1
                Anotador.Texto.Font = FuenteActual ' New System.Drawing.Font("Arial Narrow", Anotador.Texto.Font.Size)
                Anotador.Texto.Font = New Font(Anotador.Texto.Font, FontStyle.Bold)
            Case Is = 2
                Anotador.Texto.Font = FuenteActual ' New System.Drawing.Font("Arial Narrow", Anotador.Texto.Font.Size)
                Anotador.Texto.Font = New Font(Anotador.Texto.Font, FontStyle.Bold Or FontStyle.Italic)
            Case Is = 3
                Anotador.Texto.Font = FuenteActual ' New System.Drawing.Font("Arial Narrow", Anotador.Texto.Font.Size)
                Anotador.Texto.Font = New Font(Anotador.Texto.Font, FontStyle.Regular)
            Case Is = 4
                Anotador.Texto.Font = FuenteActual ' New System.Drawing.Font("Arial Narrow", Anotador.Texto.Font.Size)
                Anotador.Texto.Font = New Font(Anotador.Texto.Font, FontStyle.Regular Or FontStyle.Italic)

            Case Is = 5
                Anotador.Texto.Font = FuenteActual ' New System.Drawing.Font("Courier New", Anotador.Texto.Font.Size)
                Anotador.Texto.Font = New Font(Anotador.Texto.Font, FontStyle.Regular Or FontStyle.Italic)
            Case Is = 6

                Anotador.Texto.Font = FuenteActual ' New System.Drawing.Font("Courier New", Anotador.Texto.Font.Size)
                Anotador.Texto.Font = New Font(Anotador.Texto.Font, FontStyle.Regular)
            Case Is = 7

                Anotador.Texto.Font = FuenteActual ' New System.Drawing.Font("Courier New", Anotador.Texto.Font.Size)
                Anotador.Texto.Font = New Font(Anotador.Texto.Font, FontStyle.Bold Or FontStyle.Italic)
            Case Is = 8

                Anotador.Texto.Font = FuenteActual ' New System.Drawing.Font("Courier New", Anotador.Texto.Font.Size)
                Anotador.Texto.Font = New Font(Anotador.Texto.Font, FontStyle.Bold)

        End Select

    End Sub
    Public Sub TextoAclaraOscurece(ByRef OBJETO As Object, ByVal E As Object)
        Dim suma As Integer
        Dim rojo As Integer
        Dim verde As Integer
        Dim azul As Integer
        rojo = Anotador.Texto.ForeColor.R
        verde = Anotador.Texto.ForeColor.G
        azul = Anotador.Texto.ForeColor.B

        If E.Delta > 0 Then
            suma = 4
        ElseIf E.Delta < 0 Then
            suma = -4
        End If
        ValorColor(suma, rojo)
        ValorColor(suma, verde)
        ValorColor(suma, azul)
        TextoBackColorPublic = Anotador.Texto.BackColor
        TextoForeColorPublic = Color.FromArgb(rojo, verde, azul)
        Anotador.Texto.ForeColor = Color.FromArgb(rojo, verde, azul)
        'Anotador.ActualizaColores()
        OBJETO.ForeColor = Anotador.Texto.ForeColor
        OBJETO.BackColor = Anotador.Texto.BackColor
    End Sub
    Public Sub FondoAclaraOscurece(ByRef OBJETO As Object, ByVal E As Object)
        Dim suma As Integer
        Dim rojo As Integer
        Dim verde As Integer
        Dim azul As Integer
        rojo = Anotador.Texto.BackColor.R
        verde = Anotador.Texto.BackColor.G
        azul = Anotador.Texto.BackColor.B
        If E.Delta > 0 Then
            suma = 4
        ElseIf E.Delta < 0 Then
            suma = -4
        End If
        ValorColor(suma, rojo)
        ValorColor(suma, verde)
        ValorColor(suma, azul)

        'ColorLetraTablero = Color.FromArgb(rojo, verde, azul)
        Anotador.Texto.BackColor = Color.FromArgb(rojo, verde, azul)
        TextoBackColorPublic = Anotador.Texto.BackColor
        'Anotador.ActualizaColores()
        'OBJETO.ForeColor = Anotador.Texto.ForeColor
        OBJETO.BackColor = Anotador.Texto.BackColor
    End Sub


    Public Sub ManejaForeColor(ByRef OBJETO As Object, ByVal E As Object)
        Dim suma As Integer
        Dim rojo As Integer
        Dim verde As Integer
        Dim azul As Integer
        Dim Ancho As Integer = OBJETO.Width / 3

        rojo = Anotador.Texto.ForeColor.R
        verde = Anotador.Texto.ForeColor.G
        azul = Anotador.Texto.ForeColor.B

        If E.Delta > 0 Then
            suma = 4
        ElseIf E.Delta < 0 Then
            suma = -4
        End If

        If E.X < Ancho Then
            ValorColor(suma, rojo)
        End If
        If E.X > Ancho And E.X < Ancho * 2 Then
            ValorColor(suma, verde)
        End If
        If E.X > Ancho * 2 Then
            ValorColor(suma, azul)
        End If
        TextoBackColorPublic = Anotador.Texto.BackColor
        TextoForeColorPublic = Color.FromArgb(rojo, verde, azul)
        Anotador.Texto.ForeColor = Color.FromArgb(rojo, verde, azul)
        'Anotador.ActualizaColores()
        OBJETO.ForeColor = Anotador.Texto.ForeColor
        OBJETO.BackColor = Anotador.Texto.BackColor
    End Sub
    Public Sub ManejaBackColor(ByRef OBJETO As Object, ByVal E As Object)
        ' Anotador.ActualizaColores()
        Dim suma As Integer
        Dim rojo As Integer
        Dim verde As Integer
        Dim azul As Integer
        Dim Ancho As Integer = OBJETO.Width / 3

        rojo = Anotador.Texto.BackColor.R
        verde = Anotador.Texto.BackColor.G
        azul = Anotador.Texto.BackColor.B

        If E.Delta > 0 Then
            suma = 4
        ElseIf E.Delta < 0 Then
            suma = -4
        End If

        If E.X < Ancho Then
            ValorColor(suma, rojo)
        End If
        If E.X > Ancho And E.X < Ancho * 2 Then
            ValorColor(suma, verde)
        End If
        If E.X > Ancho * 2 Then
            ValorColor(suma, azul)
        End If
        TextoBackColorPublic = Color.FromArgb(rojo, verde, azul)
        Anotador.Texto.BackColor = Color.FromArgb(rojo, verde, azul)
        Anotador.ActualizaColores()
        'TeclaEspacio.BackColor = Anotador.Texto.BackColor
        OBJETO.BackColor = Anotador.Texto.BackColor
        OBJETO.ForeColor = Anotador.Texto.ForeColor
    End Sub
    Public Sub ManejaTamaño(ByRef OBJETO As Object, ByVal E As Object)
        Dim incre As Integer = 10
        If E.delta > 0 Then
            incre = incre * -1

        End If
        OBJETO.width = OBJETO.width + incre * OBJETO.width / 90
        OBJETO.height = OBJETO.height + incre * OBJETO.height / 90

    End Sub
    Public Sub ValorColor(ByVal suma As Integer, ByRef Canal As Integer)
        Canal = Canal + suma
        If Canal > 255 Then Canal = 255
        If Canal < 1 Then Canal = 1
    End Sub

    Public Sub PoneMensaje(ByVal Texto As String, ByVal Color As Color)
        Mensaje.TopMost = True
        Mensaje.Visible = True
        Mensaje.BackColor = Color
        Mensaje.Texto.Text = Texto
        Mensaje.Top = Anotador.Top + Anotador.Height / 2
        Mensaje.Left = Anotador.Left + Anotador.Width / 2 - Mensaje.Width / 3
        Mensaje.Width = Mensaje.Texto.Width + Mensaje.Texto.Left * 4
        Anotador.TimerMensaje.Interval = 3000
        Anotador.TimerMensaje.Enabled = True
    End Sub

    Public Sub SeleccionarPaleta()
        Dim ArchivoAAbrir As Object
        On Error Resume Next
        Anotador.OpenFileDialog1.Filter = "Archivos de paleta (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        Anotador.OpenFileDialog1.InitialDirectory = "C:\Anotador\Archivos"
        Anotador.OpenFileDialog1.Filter = "Text files (*.txt)|*.txt"
        Anotador.OpenFileDialog1.ShowDialog()
        ArchivoAAbrir = Anotador.OpenFileDialog1.FileName
        ArchivoDePaleta = ArchivoAAbrir
    End Sub

    Public Sub CargarPaleta()
        On Error Resume Next
        Dim objStreamReader As New StreamReader(ArchivoDePaleta, System.Text.Encoding.Default)
        'Texto.Text = ""
        Dim ValAlfa As String
        Dim ValRojo As String
        Dim ValVerde As String
        Dim ValAzul As String
        ValAlfa = 255
        For NumColor = 1 To 12
            For OrdColor = 1 To 2
                ValRojo = objStreamReader.ReadLine
                ValVerde = objStreamReader.ReadLine
                ValAzul = objStreamReader.ReadLine
                MatrizPaleta(NumColor, OrdColor) = Color.FromArgb(ValAlfa, ValRojo, ValVerde, ValAzul)
            Next
        Next
        objStreamReader.Close()
        'Me.Text = "Anotador " & ElArchivo
    End Sub
    Public Sub GuardarPaleta()
        TextoArchivoPaleta = "" ' pone en  cero textoarchivo porque me parece que quedaba largo
        ComponeArchivoPaleta()
        FileOpen(1, ArchivoDePaleta, OpenMode.Output)
        Print(1, TextoArchivoPaleta)
        FileClose(1)
    End Sub



    Public Sub GuardarPaletaComo()
        Dim ArchivoAAbrir As Object
        On Error Resume Next
        Anotador.SaveFileDialog1.Filter = "Archivos de paleta (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        Anotador.SaveFileDialog1.InitialDirectory = "C:\Anotador\Archivos"
        Anotador.SaveFileDialog1.Filter = "Text files (*.txt)|*.txt"
        Anotador.SaveFileDialog1.ShowDialog()
        ArchivoAAbrir = Anotador.SaveFileDialog1.FileName
        ArchivoDePaleta = ArchivoAAbrir

        TextoArchivoPaleta = "" ' pone en  cero textoarchivo porque me parece que quedaba largo
        ComponeArchivoPaleta()
        FileOpen(1, ArchivoDePaleta, OpenMode.Output)
        Print(1, TextoArchivoPaleta)
        FileClose(1)
    End Sub
    Public Sub ComponeArchivoPaleta()
        Dim ValAlfa As String = "255"
        Dim ValRojo As String
        Dim ValVerde As String
        Dim ValAzul As String

        For NumColor = 1 To 12
            For OrdColor = 1 To 2
                ValRojo = MatrizPaleta(NumColor, OrdColor).R
                ValVerde = MatrizPaleta(NumColor, OrdColor).G
                ValAzul = MatrizPaleta(NumColor, OrdColor).B
                TextoArchivoPaleta = TextoArchivoPaleta & ValRojo & Chr(13) & Chr(10) & ValVerde & Chr(13) & Chr(10) & ValAzul & Chr(13) & Chr(10)
            Next
        Next
    End Sub
    Private Sub Cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CargarPaleta()

        ComponeArchivoPaleta()
    End Sub



    Public Sub GuardarDocumento(ByVal RutaNombreExtension As String, ByVal Texto As String)
        'Dim CadenaCompleta = DirectorioActual & "\" & ElArchivoConExtension
        FileOpen(1, RutaNombreExtension, OpenMode.Output)
        ' Print(1, Texto.Text)
        Print(1, Texto)
        FileClose(1)
        'ArchivoGuardado = True
        FormInforme.Informa("Procedimiento guardar archivo")

    End Sub
    Public Function ColorOpuesto(ByVal ColorEntrada As Color)
        Return Color.FromArgb(Anotador.PorcientoGama, 255 - ColorEntrada.R, 255 - ColorEntrada.G, 255 - ColorEntrada.B)
    End Function
    Public Sub DeterminaColorFacil(ByVal AvanzaRetrocede As Boolean, ByVal LetraFondo As Byte, ByRef ColorDeLaLetra As Color, ByRef ColorDelFondo As Color)
        If AvanzaRetrocede = True Then
            NumeroColorFacil = NumeroColorFacil + 1
        Else
            NumeroColorFacil = NumeroColorFacil - 1
        End If

        If NumeroColorFacil > 14 Then NumeroColorFacil = 0
        If NumeroColorFacil < 0 Then NumeroColorFacil = 14
        Select Case LetraFondo ' letra y fondo al mismo tiempo
            Case Is = 0
                'Color2 = MatrizColores(NumeroColorFacil.2)
                'Color1 = MatrizColores(NumeroColorFacil.1)
                Select Case NumeroColorFacil
                    Case Is = 0
                        ColorDelFondo = Color.FromArgb(0, 0, 160) 'azul oscuro
                        ColorDeLaLetra = Color.FromArgb(0, 255, 255) ' cyan 
                    Case Is = 1
                        ColorDelFondo = Color.FromArgb(210, 255, 255) ' cyan claro
                        ColorDeLaLetra = Color.FromArgb(128, 0, 255) 'violeta
                    Case Is = 2
                        ColorDelFondo = Color.FromArgb(255, 255, 210) 'amarillo clarito
                        ColorDeLaLetra = Color.FromArgb(128, 0, 0) ' marron oscuro
                    Case Is = 3
                        ColorDelFondo = Color.FromArgb(0, 160, 0) 'verde oscuro
                        ColorDeLaLetra = Color.FromArgb(150, 255, 150) 'verde claro
                    Case Is = 4
                        ColorDelFondo = Color.FromArgb(128, 0, 255) ' violeta intenso
                        ColorDeLaLetra = Color.FromArgb(255, 210, 255) 'lila claro
                    Case Is = 5
                        ColorDelFondo = Color.FromArgb(128, 128, 128) 'gris
                        ColorDeLaLetra = Color.FromArgb(255, 255, 0) 'amarillo
                    Case Is = 6
                        ColorDelFondo = Color.FromArgb(128, 0, 0) ' marron oscuro
                        ColorDeLaLetra = Color.FromArgb(255, 255, 128) 'amarillo clarito
                    Case Is = 7
                        ColorDelFondo = Color.FromArgb(255, 220, 200) ' marron clarito
                        ColorDeLaLetra = Color.FromArgb(128, 0, 0) ' marron oscuro
                    Case Is = 8
                        ColorDelFondo = Color.FromArgb(255, 128, 64) 'naranja
                        ColorDeLaLetra = Color.FromArgb(255, 255, 128) 'amarillo claro
                    Case Is = 9
                        ColorDelFondo = Color.FromArgb(0, 128, 192) 'acero
                        ColorDeLaLetra = Color.FromArgb(255, 255, 255) 'blanco
                    Case Is = 10
                        ColorDelFondo = Color.FromArgb(147, 255, 196) 'verde claro
                        ColorDeLaLetra = Color.FromArgb(0, 64, 0) 'verde oscuro
                    Case Is = 11
                        ColorDelFondo = Color.FromArgb(0, 0, 0) 'negro
                        ColorDeLaLetra = Color.FromArgb(255, 255, 255) 'blanco
                    Case Is = 12
                        ColorDelFondo = Color.FromArgb(255, 255, 255) 'blanco
                        ColorDeLaLetra = Color.FromArgb(0, 0, 0) 'negro
                    Case Is = 13
                        ColorDelFondo = Color.FromArgb(255, 255, 200) 'amarillo
                        ColorDeLaLetra = Color.FromArgb(255, 0, 0) 'rojo
                    Case Is = 14
                        ColorDelFondo = Color.FromArgb(255, 0, 0) 'rojo
                        ColorDeLaLetra = Color.FromArgb(255, 255, 255) 'amarillo
                End Select
            Case Is = 1 ' COLOR DE LETRA 
                Select Case NumeroColorFacil
                    Case Is = 0
                        ColorDelFondo = Color.FromArgb(0, 0, 160) 'azul oscuro
                    Case Is = 1
                        ColorDelFondo = Color.FromArgb(210, 255, 255) ' cyan claro
                    Case Is = 2
                        ColorDelFondo = Color.FromArgb(255, 255, 210) 'amarillo clarito
                    Case Is = 3
                        ColorDelFondo = Color.FromArgb(0, 160, 0) 'verde oscuro
                    Case Is = 4
                        ColorDelFondo = Color.FromArgb(128, 0, 255) ' violeta intenso
                    Case Is = 5
                        ColorDelFondo = Color.FromArgb(128, 128, 128) 'gris
                    Case Is = 6
                        ColorDelFondo = Color.FromArgb(128, 0, 0) ' marron oscuro
                    Case Is = 7
                        ColorDelFondo = Color.FromArgb(255, 220, 200) ' marron clarito
                    Case Is = 8
                        ColorDelFondo = Color.FromArgb(255, 128, 64) 'naranja
                    Case Is = 9
                        ColorDelFondo = Color.FromArgb(0, 128, 192) 'acero
                    Case Is = 10
                        ColorDelFondo = Color.FromArgb(147, 255, 196) 'verde claro
                    Case Is = 11
                        ColorDelFondo = Color.FromArgb(0, 0, 0) 'negro
                    Case Is = 12
                        ColorDelFondo = Color.FromArgb(255, 255, 255) 'blanco
                    Case Is = 13
                        ColorDelFondo = Color.FromArgb(255, 255, 200) 'amarillo
                    Case Is = 14
                        ColorDelFondo = Color.FromArgb(255, 0, 0) 'rojo
                End Select
            Case Is = 2 ' COLOR DE FONDO
                Select Case NumeroColorFacil
                    Case Is = 0
                        ColorDeLaLetra = Color.FromArgb(0, 255, 255) ' cyan 
                    Case Is = 1
                        ColorDeLaLetra = Color.FromArgb(128, 0, 255) 'violeta
                    Case Is = 2
                        ColorDeLaLetra = Color.FromArgb(128, 0, 0) ' marron oscuro
                    Case Is = 3
                        ColorDeLaLetra = Color.FromArgb(150, 255, 150) 'verde claro
                    Case Is = 4
                        ColorDeLaLetra = Color.FromArgb(255, 210, 255) 'lila claro
                    Case Is = 5
                        ColorDeLaLetra = Color.FromArgb(255, 255, 0) 'amarillo
                    Case Is = 6
                        ColorDeLaLetra = Color.FromArgb(255, 255, 128) 'amarillo clarito
                    Case Is = 7
                        ColorDeLaLetra = Color.FromArgb(128, 0, 0) ' marron oscuro
                    Case Is = 8
                        ColorDeLaLetra = Color.FromArgb(255, 255, 128) 'amarillo claro
                    Case Is = 9
                        ColorDeLaLetra = Color.FromArgb(255, 255, 255) 'blanco
                    Case Is = 10
                        ColorDeLaLetra = Color.FromArgb(0, 64, 0) 'verde oscuro
                    Case Is = 11
                        ColorDeLaLetra = Color.FromArgb(255, 255, 255) 'blanco
                    Case Is = 12
                        ColorDeLaLetra = Color.FromArgb(0, 0, 0) 'negro
                    Case Is = 13
                        ColorDeLaLetra = Color.FromArgb(255, 0, 0) 'rojo
                    Case Is = 14
                        ColorDeLaLetra = Color.FromArgb(255, 255, 255) 'amarillo
                End Select

        End Select

    End Sub
    Public Sub DeterminaColorPaleta(ByVal AvanzaRetrocede As Boolean, ByVal LetraFondo As Byte, ByRef Color1 As Color, ByRef Color2 As Color)
        If AvanzaRetrocede = True Then
            NumeroColorPaleta = NumeroColorPaleta - 1
        Else
            NumeroColorPaleta = NumeroColorPaleta + 1
        End If

        If NumeroColorPaleta > 12 Then NumeroColorPaleta = 1
        If NumeroColorPaleta < 1 Then NumeroColorPaleta = 12
        Color1 = MatrizPaleta(NumeroColorPaleta, 1)
        Color2 = MatrizPaleta(NumeroColorPaleta, 2)

    End Sub

    Public Sub SorteaColorFondo()
        'ColorFondoTablero = SorteaColorAmplio()
        'ColorFondoTablero = SorteaColorClaro()
    End Sub
    Public Sub SorteaColorLetra()

        'ColorLet = SorteaColorAmplitudTotal()
        'ColorLetraTablero = SorteaColorOscuro()
    End Sub
    Public Function SorteaColorAmplio()
        Randomize()
        Dim PropiedadesDelColor As Color
        'randomValue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
        PropiedadesDelColor = Color.FromArgb(Anotador.PorcientoGama, CInt(Math.Floor((255 - 0 + 0) * Rnd())) + 0, CInt(Math.Floor((255 - 0 + 0) * Rnd())) + 0, CInt(Math.Floor((255 - 0 + 0) * Rnd())) + 0)
        'PropiedadesDelColor = Color.FromArgb(CInt(Math.Floor((255 - 200 + 1) * Rnd())) + 200, CInt(Math.Floor((255 - 200 + 1) * Rnd())) + 200, CInt(Math.Floor((255 - 0 + 1) * Rnd())) + 0, CInt(Math.Floor((255 - 0 + 1) * Rnd())) + 0)
        'PortaColor = PropiedadesDelColor
        Return (PropiedadesDelColor)
    End Function

    Public Sub TextoInicial(ByVal Cadena As String)
        If Anotador.Texto.Text = "" Or Mid(Anotador.Texto.Text, 1, 5) = "Texto" Then
            'Anotador.Texto.Text = "Texto " & Cadena
            Anotador.Texto.Text = Cadena
            Anotador.TimerBorraPrueba.Enabled = True
            Anotador.TimerBorraPrueba.Start()
        End If
    End Sub
    Private Sub SorteaColor()
        Dim BrechaColor As Byte = 20
        Dim ClarOscuro As Boolean
        Dim PropiedadesDelNuevoColor As Color
        If ClarOscuro = True Then
            ClarOscuro = False
            Dim OscuroDelClaro = 128 + BrechaColor - 1
            PropiedadesDelNuevoColor = Color.FromArgb(255, CInt(Math.Floor((255 - OscuroDelClaro + 1) * Rnd())) + OscuroDelClaro, CInt(Math.Floor((255 - OscuroDelClaro + 1) * Rnd())) + OscuroDelClaro, CInt(Math.Floor((255 - OscuroDelClaro + 1) * Rnd())) + OscuroDelClaro)
        Else
            ClarOscuro = True
            Dim ClaroDelOscuro = 128 - BrechaColor
            PropiedadesDelNuevoColor = Color.FromArgb(255, CInt(Math.Floor((ClaroDelOscuro - 0 + 1) * Rnd())) + 0, CInt(Math.Floor((ClaroDelOscuro - 0 + 1) * Rnd())) + 0, CInt(Math.Floor((ClaroDelOscuro - 0 + 1) * Rnd())) + 0)
        End If
    End Sub

    Public Function SorteaColorClaro()
        Randomize()
        Dim BrechaColor As Byte = 80
        Dim OscuroDelClaro = 128 + BrechaColor - 1
        Dim PropiedadesDelColor As Color
        PropiedadesDelColor = Color.FromArgb(255, CInt(Math.Floor((255 - OscuroDelClaro + 1) * Rnd())) + OscuroDelClaro, CInt(Math.Floor((255 - OscuroDelClaro + 1) * Rnd())) + OscuroDelClaro, CInt(Math.Floor((255 - OscuroDelClaro + 1) * Rnd())) + OscuroDelClaro)

        'PropiedadesDelColor = Color.FromArgb(255, CInt(Math.Floor((255 - 150 + 1) * Rnd())) + 150, CInt(Math.Floor((255 - 150 + 1) * Rnd())) + 150, CInt(Math.Floor((255 - 150 + 1) * Rnd())) + 150)
        Return (PropiedadesDelColor)
    End Function
    Public Function SorteaColorOscuro()
        Randomize()
        Dim BrechaColor As Byte = 1
        Dim PropiedadesDelColor As Color
        Dim ClaroDelOscuro = 200 - BrechaColor
        PropiedadesDelColor = Color.FromArgb(255, CInt(Math.Floor((ClaroDelOscuro - 0 + 1) * Rnd())) + 0, CInt(Math.Floor((ClaroDelOscuro - 0 + 1) * Rnd())) + 0, CInt(Math.Floor((ClaroDelOscuro - 0 + 1) * Rnd())) + 0)

        'PropiedadesDelColor = Color.FromArgb(255, CInt(Math.Floor((255 - 150 + 1) * Rnd())) + 150, CInt(Math.Floor((255 - 150 + 1) * Rnd())) + 150, CInt(Math.Floor((255 - 150 + 1) * Rnd())) + 150)
        Return (PropiedadesDelColor)
    End Function
    Public Sub TecladoColorPredeterminado()
        TecladoColorFondo1 = Color.FromArgb(255, 255, 255, 210)
        TecladoColorFondo2 = Color.AntiqueWhite
        TecladoColorFondo3 = Color.PeachPuff
        TecladoColorFondoListas = Color.White
        TecladoColorLetraTeclas = Color.FromArgb(255, 64, 0, 0)
        TecladoColorLetraListas = Color.FromArgb(255, 0, 0, 0)
        Teclado.CambiaColorTeclado(TecladoColorFondo1, TecladoColorFondo2, TecladoColorFondo3, TecladoColorFondoListas, TecladoColorLetraTeclas, TecladoColorLetraListas)
    End Sub

    Public Function SorteaColorClarob()
        Randomize()
        Dim PropiedadesDelColor As Color
        PropiedadesDelColor = Color.FromArgb(255, CInt(Math.Floor((255 - 150 + 1) * Rnd())) + 150, CInt(Math.Floor((255 - 150 + 1) * Rnd())) + 150, CInt(Math.Floor((255 - 150 + 1) * Rnd())) + 150)
        Return (PropiedadesDelColor)
    End Function


    Public Sub InvierteColorSuenaTecla(ByVal Tecla As System.Windows.Forms.Button)
        SuenaTic()
        Tecla.BackColor = Inviertecolor(TecladoColorFondo1)
        Tecla.ForeColor = Inviertecolor(TecladoColorLetraTeclas)
    End Sub
    Public Sub RestauraColorTecla1(ByVal Tecla As System.Windows.Forms.Button)
        Tecla.BackColor = TecladoColorFondo1
        Tecla.ForeColor = TecladoColorLetraTeclas
    End Sub
    Public Sub RestauraColorTecla2(ByVal Tecla As System.Windows.Forms.Button)
        Tecla.BackColor = TecladoColorFondo2
        Tecla.ForeColor = TecladoColorLetraTeclas
    End Sub
    Public Sub RestauraColorTecla3(ByVal Tecla As System.Windows.Forms.Button)
        Tecla.BackColor = TecladoColorFondo3
        Tecla.ForeColor = TecladoColorLetraTeclas
    End Sub
    Private Sub ActivaTimerOprimirAuto()
        If DisparoAutomatico = True Then
            Teclado.TimerOprimirAuto.Enabled = True
        End If
    End Sub
    Public Sub ConvertirMayusculasIniciales()
        On Error Resume Next
        Dim PosiciónDeInicio = Anotador.Texto.SelectionStart
        Dim PosiciónDeFinalSeleccion = Anotador.Texto.SelectionStart + Len(Anotador.Texto.SelectedText)
        Dim TextoAnterior = Anotador.Texto.Text.Substring(0, PosiciónDeInicio)
        Dim TextoPosterior = Anotador.Texto.Text.Substring(PosiciónDeFinalSeleccion, Anotador.Texto.Text.Length() - PosiciónDeFinalSeleccion)
        Dim TextoSeleccionado = Anotador.Texto.Text.Substring(PosiciónDeInicio, PosiciónDeFinalSeleccion - PosiciónDeInicio)

        ' Convierte a mayúsculas el primer carácter
        Dim PosicionEspacio As Integer
        Dim PosicionInicial As Integer
        Dim CaracterInicial As String
        'Toma la letra cero de la cadena 
        CaracterInicial = Mid(TextoSeleccionado, 1, 1)
        'La convierte a may
        CaracterInicial = CaracterInicial.ToUpper
        'La suma a la cadena
        Dim Cadena = CaracterInicial + Mid(TextoSeleccionado, 2)
        For Cantidad = 1 To 1000
            'Encuentra el siguiente espacio
            PosicionEspacio = Cadena.IndexOf(" ") + 1
            If PosicionEspacio = 0 Then GoTo Salir
            PosicionInicial = PosicionEspacio + 1
            If PosicionInicial > Len(Cadena) Then GoTo Salir
            'Sustituye el espacio por signo sustituto
            Mid(Cadena, PosicionEspacio, 1) = "+"
            'Convierte el siguiente carácter en Mayúsculas
            Mid(Cadena, PosicionInicial, 1) = Mid(Cadena, PosicionInicial, 1).ToUpper
        Next Cantidad
Salir:
        'Sustituye los signos sustitutos por espacios
        Cadena = Cadena.Replace("+", " ")
        TextoSeleccionado = Cadena
        'Integra el texto anterior, el seleccionado y el ulterior
        Anotador.Texto.Text = TextoAnterior & TextoSeleccionado & TextoPosterior
        'Selecciona el texto seleccionado
        Anotador.Texto.SelectionStart = Len(TextoAnterior)
        Anotador.Texto.SelectionLength = Len(TextoSeleccionado)
        'Posiciona el anotador
        Anotador.Texto.ScrollToCaret()
        Anotador.Texto.Focus()
    End Sub

    Public Function Inviertecolor(ByVal Color As Color)
        Inviertecolor = Color.FromArgb(255, Math.Abs(Color.R - 255), Math.Abs(Color.R - 255), Math.Abs(Color.R - 255))
    End Function
    Public Sub MouseHoverTecla(ByVal Tecla As System.Windows.Forms.Button)
        TeclaPresionada = Tecla
        IluminaColorTecla(Tecla)
        ActivaTimerOprimirAuto()
    End Sub

    Public Sub DetieneTimerLetra()
        Teclado.TimerActivaRepeticion.Enabled = False
        Teclado.TimerRepeticion.Enabled = False
    End Sub
    Public Sub MouseLeaveTecla(ByVal Tecla As System.Windows.Forms.Button)
        DetieneTimerLetra()
        RestauraColorTecla1(Tecla)
        Teclado.TimerOprimirAuto.Enabled = False
    End Sub
    Public Sub MouseLeaveTecla2(ByVal Tecla As System.Windows.Forms.Button)
        DetieneTimerLetra()
        RestauraColorTecla2(Tecla)
        Teclado.TimerOprimirAuto.Enabled = False
    End Sub
    Public Sub MouseLeaveTecla3(ByVal Tecla As System.Windows.Forms.Button)
        DetieneTimerLetra()
        RestauraColorTecla3(Tecla)
        Teclado.TimerOprimirAuto.Enabled = False
    End Sub
    Public Sub MouseUpTecla(ByVal Tecla As System.Windows.Forms.Button)
        DetieneTimerLetra()
        RestauraColorTecla1(Tecla)
        Teclado.TimerOprimirAuto.Enabled = False
    End Sub
    Public Sub MouseUpTecla2(ByVal Tecla As System.Windows.Forms.Button)
        DetieneTimerLetra()
        RestauraColorTecla2(Tecla)
        Teclado.TimerOprimirAuto.Enabled = False
    End Sub
    Public Sub MouseUpTecla3(ByVal Tecla As System.Windows.Forms.Button)
        DetieneTimerLetra()
        RestauraColorTecla3(Tecla)
        Teclado.TimerOprimirAuto.Enabled = False
    End Sub
    Public Sub IluminaColorTecla(ByVal Tecla As System.Windows.Forms.Button)
        Tecla.BackColor = IluminaColor(TecladoColorFondo1)
        Tecla.ForeColor = IluminaColor(TecladoColorLetraTeclas)
    End Sub
    Private Function IluminaColor(ByVal Color As Color)
        ' IluminaColor = Color.FromArgb(255, Math.Abs(Color.R - 128), Math.Abs(Color.R - 128), Math.Abs(Color.R - 128))
        IluminaColor = Color.FromArgb(255, Color.G, Color.B, Color.R)

    End Function
    Public Sub SuenaTic()

        If SonidoActivado = True Then
            My.Computer.Audio.Play(My.Resources.tic, AudioPlayMode.Background)
        End If
    End Sub
    Public Sub SuenaGoma()
        If SonidoActivado = True Then
            'Dim Sound As New System.Media.SoundPlayer()
            ' Sound.SoundLocation = "C:\Notas\Recortes\Tic.wav"  'ex.: c:\mysound.wav  
            'Sound.Load()
            'Sound.Play()
            My.Computer.Audio.Play(My.Resources.goma, AudioPlayMode.Background)
        End If
    End Sub
    Public Sub SuenaRepite()
        If SonidoActivado = True Then
            My.Computer.Audio.Play(My.Resources.tica, AudioPlayMode.Background)
        End If
    End Sub
    Public Sub SuenaScroll()
        If SonidoActivado = True Then
            My.Computer.Audio.Play(My.Resources.Scroll, AudioPlayMode.Background)
        End If
    End Sub
    Public Sub SuenaTilde()
        If SonidoActivado = True Then
            My.Computer.Audio.Play(My.Resources.tilde, AudioPlayMode.Background)
        End If
    End Sub
    Public Sub SuenaMay()
        If SonidoActivado = True Then
            My.Computer.Audio.Play(My.Resources.May, AudioPlayMode.Background)
        End If
    End Sub
    Public Sub CrearDirectorio(ByVal RutaCompleta As String)
        On Error Resume Next

        ' My.Computer.FileSystem.CreateDirectory("C:\Documents and Settings\All Users\Documents\NewDirectory")
        My.Computer.FileSystem.CreateDirectory(RutaCompleta)

    End Sub
    Public Sub reubicaFormAuxiliar()
        FormAuxiliar.Visible = True
        If Teclado.Visible = True Then
            If Teclado.Top + Teclado.Height + FormAuxiliar.Height > Screen.PrimaryScreen.Bounds.Height Then
                If Teclado.Top - FormAuxiliar.Height < Screen.PrimaryScreen.Bounds.Top Then
                    If Teclado.Left - FormAuxiliar.Width < Screen.PrimaryScreen.Bounds.Left Then
                        FormAuxiliar.Left = Screen.PrimaryScreen.Bounds.Left
                    Else
                        FormAuxiliar.Left = Teclado.Left - FormAuxiliar.Width
                    End If
                Else
                    FormAuxiliar.Top = Teclado.Top - FormAuxiliar.Height
                    'FormAuxiliar.Left = Teclado.Left
                End If
            Else
                FormAuxiliar.Top = Teclado.Top + Teclado.Height
                'FormAuxiliar.Left = Teclado.Left
            End If
        End If
        'Screen.PrimaryScreen.Bounds.Width
    End Sub
    Public Sub Posiciones05()
        PosicionesFormularios = 5

        TecladoRedimensionable = True
        Anotador.Visible = True
        FormularioActivo(1) = True
        Teclado.Visible = True
        FormularioActivo(2) = True
        FormAuxiliar.Visible = False
        FormularioActivo(3) = False
        Director.Visible = False
        FormularioActivo(4) = False
        FormIndice.Visible = False
        FormularioActivo(5) = False
        'FormAuxiliar.Visible = True
        Anotador.Top = Screen.PrimaryScreen.Bounds.Top
        Anotador.Left = Screen.PrimaryScreen.Bounds.Left
        Anotador.Width = Screen.PrimaryScreen.Bounds.Width / 2
        Anotador.Height = Screen.PrimaryScreen.Bounds.Height / 3
        Teclado.Top = Screen.PrimaryScreen.Bounds.Top
        Teclado.Left = Screen.PrimaryScreen.Bounds.Width / 2
        Teclado.Width = Screen.PrimaryScreen.Bounds.Width / 2
        Teclado.Height = Screen.PrimaryScreen.Bounds.Height / 3
        Anotador.GuardaPosicionesAnotador()
        Anotador.Posiciones00Menu.Checked = False
        Anotador.Posiciones01Menu.Checked = False
        Anotador.Posiciones02Menu.Checked = False
        Anotador.Posiciones03Menu.Checked = False
        Anotador.Posiciones04Menu.Checked = False
        Anotador.Posiciones05Menu.Checked = True
        Anotador.Posiciones06Menu.Checked = False
        Anotador.Posiciones07Menu.Checked = False

    End Sub
    Public Sub Posiciones06()
        TecladoRedimensionable = True
        Anotador.Visible = True
        FormularioActivo(1) = True
        Teclado.Visible = True
        FormularioActivo(2) = True
        FormAuxiliar.Visible = False
        FormularioActivo(3) = False
        Director.Visible = False
        FormularioActivo(4) = False
        FormIndice.Visible = False
        FormularioActivo(5) = False
        'FormAuxiliar.Visible = True
        Anotador.Top = Screen.PrimaryScreen.Bounds.Top
        Anotador.Left = Screen.PrimaryScreen.Bounds.Left
        Anotador.Width = Screen.PrimaryScreen.Bounds.Width / 2.7
        Anotador.Height = Screen.PrimaryScreen.Bounds.Height / 3
        Teclado.Top = Screen.PrimaryScreen.Bounds.Top
        Teclado.Left = Anotador.Width
        Teclado.Width = Screen.PrimaryScreen.Bounds.Width - Anotador.Width
        Teclado.Height = Screen.PrimaryScreen.Bounds.Height / 3
        Anotador.Posiciones00Menu.Checked = False
        Anotador.Posiciones01Menu.Checked = False
        Anotador.Posiciones02Menu.Checked = False
        Anotador.Posiciones03Menu.Checked = False
        Anotador.Posiciones04Menu.Checked = False
        Anotador.Posiciones05Menu.Checked = False
        Anotador.Posiciones06Menu.Checked = True
        Anotador.Posiciones07Menu.Checked = False

    End Sub
    Public Sub Posiciones01()
        PosicionesFormularios = 1
        TecladoRedimensionable = True
        Anotador.Visible = True
        FormularioActivo(1) = True
        Teclado.Visible = True
        FormularioActivo(2) = True
        FormAuxiliar.Visible = False
        FormularioActivo(3) = False
        Director.Visible = False
        FormularioActivo(4) = False
        FormIndice.Visible = False
        FormularioActivo(5) = False

        Anotador.Top = Screen.PrimaryScreen.Bounds.Top
        Anotador.Left = Screen.PrimaryScreen.Bounds.Left
        Anotador.Width = Screen.PrimaryScreen.Bounds.Width
        Anotador.Height = Screen.PrimaryScreen.Bounds.Height / 1.8
        Anotador.Opacity = 1

        Teclado.Top = Screen.PrimaryScreen.Bounds.Height / 1.8
        Teclado.Left = Screen.PrimaryScreen.Bounds.Left
        Teclado.Width = Screen.PrimaryScreen.Bounds.Width
        Teclado.Height = Screen.PrimaryScreen.Bounds.Height - Teclado.Top
        Teclado.Opacity = 1

        Anotador.GuardaPosicionesAnotador()
        Anotador.Posiciones00Menu.Checked = False
        Anotador.Posiciones01Menu.Checked = True
        Anotador.Posiciones02Menu.Checked = False
        Anotador.Posiciones03Menu.Checked = False
        Anotador.Posiciones04Menu.Checked = False
        Anotador.Posiciones05Menu.Checked = False
        Anotador.Posiciones06Menu.Checked = False
        Anotador.Posiciones07Menu.Checked = False
    End Sub

    Public Sub Posiciones02()
        PosicionesFormularios = 2
        TecladoRedimensionable = True
        Anotador.Visible = True
        FormularioActivo(1) = True
        Teclado.Visible = True
        FormularioActivo(2) = True
        FormAuxiliar.Visible = True
        FormularioActivo(3) = True
        Director.Visible = True
        FormularioActivo(4) = True

        Anotador.Top = Screen.PrimaryScreen.Bounds.Top
        Anotador.Left = Screen.PrimaryScreen.Bounds.Left
        Anotador.Width = Screen.PrimaryScreen.Bounds.Width - FormAuxiliar.Width
        Anotador.Height = Screen.PrimaryScreen.Bounds.Height / 3 * 2
        Anotador.Opacity = 1

        Teclado.Top = Screen.PrimaryScreen.Bounds.Height / 3 * 2
        Teclado.Left = Screen.PrimaryScreen.Bounds.Width / 4
        Teclado.Width = Screen.PrimaryScreen.Bounds.Width - Teclado.Left
        Teclado.Height = Screen.PrimaryScreen.Bounds.Height / 3
        Teclado.Opacity = 1

        Director.Top = Screen.PrimaryScreen.Bounds.Height / 3 * 2
        Director.Left = Screen.PrimaryScreen.Bounds.Left
        Director.Width = Screen.PrimaryScreen.Bounds.Width / 4
        Director.Height = Screen.PrimaryScreen.Bounds.Height / 3
        Director.Opacity = 1


        FormAuxiliar.Top = Screen.PrimaryScreen.Bounds.Top
        FormAuxiliar.Left = Screen.PrimaryScreen.Bounds.Width - FormAuxiliar.Width
        FormAuxiliar.Opacity = 1

        Anotador.GuardaPosicionesAnotador()
        Anotador.Posiciones00Menu.Checked = False
        Anotador.Posiciones01Menu.Checked = False
        Anotador.Posiciones02Menu.Checked = True
        Anotador.Posiciones03Menu.Checked = False
        Anotador.Posiciones04Menu.Checked = False
        Anotador.Posiciones05Menu.Checked = False
        Anotador.Posiciones06Menu.Checked = False
        Anotador.Posiciones07Menu.Checked = False
    End Sub
    Public Sub Posiciones03()
        PosicionesFormularios = 3
        TecladoRedimensionable = True
        Anotador.Visible = True
        FormularioActivo(1) = True
        Teclado.Visible = True
        FormularioActivo(2) = True
        FormAuxiliar.Visible = True
        FormularioActivo(3) = True
        Director.Visible = True
        FormularioActivo(4) = True
        FormIndice.Visible = False
        FormularioActivo(5) = False

        FormAuxiliar.Top = Screen.PrimaryScreen.Bounds.Top
        FormAuxiliar.Left = Screen.PrimaryScreen.Bounds.Left
        FormAuxiliar.Opacity = 1

        Anotador.Width = Screen.PrimaryScreen.Bounds.Width - FormAuxiliar.Width
        Anotador.Height = Screen.PrimaryScreen.Bounds.Height / 3 * 2
        Anotador.Top = Screen.PrimaryScreen.Bounds.Top
        Anotador.Left = Screen.PrimaryScreen.Bounds.Left + FormAuxiliar.Width
        Anotador.Opacity = 1

        Teclado.Top = Screen.PrimaryScreen.Bounds.Height / 3 * 2
        Teclado.Left = Screen.PrimaryScreen.Bounds.Width / 4
        Teclado.Width = Screen.PrimaryScreen.Bounds.Width - Teclado.Left
        Teclado.Height = Screen.PrimaryScreen.Bounds.Height / 3
        Teclado.Opacity = 1

        Director.Width = Screen.PrimaryScreen.Bounds.Width / 4
        Director.Height = Screen.PrimaryScreen.Bounds.Height / 3
        Director.Top = Screen.PrimaryScreen.Bounds.Height - Director.Height
        Director.Left = Screen.PrimaryScreen.Bounds.Left
        Director.Visible = True
        Director.Opacity = 1

        Anotador.GuardaPosicionesAnotador()

        Anotador.Posiciones00Menu.Checked = False
        Anotador.Posiciones01Menu.Checked = False
        Anotador.Posiciones02Menu.Checked = False
        Anotador.Posiciones03Menu.Checked = True
        Anotador.Posiciones04Menu.Checked = False
        Anotador.Posiciones05Menu.Checked = False
        Anotador.Posiciones06Menu.Checked = False
        Anotador.Posiciones07Menu.Checked = False
    End Sub
    Public Sub Posiciones04()
        PosicionesFormularios = 4
        TecladoRedimensionable = True
        Anotador.Visible = True
        FormularioActivo(1) = True
        Teclado.Visible = True
        FormularioActivo(2) = True
        FormAuxiliar.Visible = True
        FormularioActivo(3) = True
        Director.Visible = True
        FormularioActivo(4) = True
        FormIndice.Visible = True
        FormularioActivo(5) = True

        FormAuxiliar.Top = Screen.PrimaryScreen.Bounds.Top
        FormAuxiliar.Left = Screen.PrimaryScreen.Bounds.Left
        FormAuxiliar.Height = Screen.PrimaryScreen.Bounds.Height / 3
        FormAuxiliar.Opacity = 1

        FormIndice.Top = Screen.PrimaryScreen.Bounds.Height / 3
        FormIndice.Left = Screen.PrimaryScreen.Bounds.Left
        FormIndice.Height = Screen.PrimaryScreen.Bounds.Height / 3
        FormIndice.Opacity = 1

        Anotador.Width = Screen.PrimaryScreen.Bounds.Width - FormAuxiliar.Width
        Anotador.Height = Screen.PrimaryScreen.Bounds.Height / 3 * 2
        Anotador.Top = Screen.PrimaryScreen.Bounds.Top
        Anotador.Left = Screen.PrimaryScreen.Bounds.Left + FormAuxiliar.Width
        Anotador.Opacity = 1

        Teclado.Top = Screen.PrimaryScreen.Bounds.Height / 3 * 2
        Teclado.Left = Screen.PrimaryScreen.Bounds.Width / 4
        Teclado.Width = Screen.PrimaryScreen.Bounds.Width - Teclado.Left
        Teclado.Height = Screen.PrimaryScreen.Bounds.Height / 3
        Teclado.Opacity = 1

        Director.Width = Screen.PrimaryScreen.Bounds.Width / 4
        Director.Height = Screen.PrimaryScreen.Bounds.Height / 3
        Director.Top = Screen.PrimaryScreen.Bounds.Height - Director.Height
        Director.Left = Screen.PrimaryScreen.Bounds.Left
        Director.Opacity = 1
        Director.Visible = True
        Director.TopMost = True

        Anotador.GuardaPosicionesAnotador()

        Anotador.Posiciones00Menu.Checked = False
        Anotador.Posiciones01Menu.Checked = False
        Anotador.Posiciones02Menu.Checked = False
        Anotador.Posiciones03Menu.Checked = False
        Anotador.Posiciones04Menu.Checked = True
        Anotador.Posiciones05Menu.Checked = False
        Anotador.Posiciones06Menu.Checked = False
        Anotador.Posiciones07Menu.Checked = False
    End Sub
    Public Function Formatea1(ByVal CantDígitos As Byte, ByVal Valor As Byte) As String
        If Valor > 99 Then Valor = 99
        Dim ValorString As String = Str(Valor)
        ValorString = Mid(ValorString, 2, Len(ValorString) - 1)
        Dim Diferencia As Byte = CantDígitos - Len(ValorString)
        Dim ValorStringCorregido As String = 0

        Select Case Diferencia
            Case Is = 0
                ValorStringCorregido = ValorString
            Case Is = 1
                ValorStringCorregido = "0" & ValorString
            Case Is = 2
                ValorStringCorregido = "00" & ValorString
        End Select
        Return ValorStringCorregido
    End Function
End Module
