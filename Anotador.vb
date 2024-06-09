Imports System.IO

Public Class Anotador
    Public ElArchivo As String
    Public ElArchivoConExtension As String
    Public ArchivoGuardado As Boolean
    Public DirectorioActual As String
    'Public ColorFondo00 As Color
    ' Public ColorLetra00 As Color
    Public Fuente As Font
    Public FuenteDelMenu As Font
   

    Public Mover As Boolean
    Public PantallaCompleta As Boolean
    Public ColorÚnicoPlus As Color
    Public ColorÚnicoAnterior As Color
    Public ColorDeIntercambio As Color
    Public ColorDeFondoAlarma As Color
    Public ColorDeTextoAlarma As Color
    Public CantiPasosColor As Decimal
    Public NumPasoColor As Decimal
    Public ColorTransición As Color
    Public PorcientoGama As Decimal = 255
    Public SorteaAleacolorTrans As Boolean = False
    Public CantidadDeMouseMoveColor
    Public LLenoMouseMoveColor As Integer = 4
    Public LetraOscura As Boolean = False
    Public SeparaFondoDeTransiciónColor As Boolean = False
    Public SeparaLetraDeTransiciónColor As Boolean = False

    Public FórmulaComplementaria As Byte = 1
    Public CadenaDeControlA As String
    Public CadenaDeControlB As String
    Public Velocidad As Integer = 100
    Public SinCabecera = False
    Public TextoDepurado As String
    Public TextoGuardado As Boolean
    Public PosiciónDeInicio As Integer
    Public PosiciónDeFinalSeleccion As Integer
    Public CadenaResultado As String
    Public LargoCadenaResultado As Integer
    Public LargoCadenaOperaciónYResultado As Integer
    Public CadenaOperacionYResultado As String
    Public Minimizado As Boolean = False
    Public NombreFechaLargaDeOrigen As String
    Public TextoCopiadoTeclado As String
    Public PathInicial As String = ""
    Dim BorraAvanzaRetrocedeAuto As Boolean
    Private GuardaTexto1 As String
    Private GuardaTexto2 As String
    Private GuardaTexto3 As String
    Dim PosMovIzq
    Dim PosMovArr


    Private Sub Anotador_ControlRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles Me.ControlRemoved
        RecaudosDeSalir()
    End Sub

    Private Sub Anotador_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        If NombreDelCuadroACerrar <> "Anotador" Then Exit Sub
        RecaudosDeSalir()
    End Sub

    Private Sub Anotador_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        'ExpandeAnotador()
        If Me.Name <> "Anotador" Then
            Me.Width = 299
            Me.Height = 299
            Exit Sub
        End If
        RestauraFormulariosAnotador()
        Exit Sub
        If MuestraOcultaFormularios = False Then
            MuestraOcultaFormularios = True
            If FormularioActivo(2) = True Then Teclado.Visible = True
            If FormularioActivo(3) = True Then FormAuxiliar.Visible = True
            If FormularioActivo(4) = True Then Director.Visible = True
            If FormularioActivo(5) = True Then FormIndice.Visible = True
        Else
            MuestraOcultaFormularios = False
            Teclado.Visible = False
            FormAuxiliar.Visible = False
            Director.Visible = False
            FormIndice.Visible = False
        End If
    End Sub


    Private Sub Anotador_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'RecaudosDeSalir()
    End Sub

    Private Sub Anotador_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.Name <> "Anotador" Then Exit Sub
        RecaudosDeSalir()
    End Sub
    Private Sub Anotador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If My.Application.CommandLineArgs.Count > 0 Then
                'AbrirArchivo(My.Application.CommandLineArgs(My.Application.CommandLineArgs.Count))
                AbrirArchivoInicial(My.Application.CommandLineArgs(0))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try


        NombreFechaLargaDeOrigen = NombreFechaLarga()
        ElArchivo = NombreFechaLarga()
        ElArchivoConExtension = ElArchivo & ".txt"
        ColorÚnicoPlus = SorteaColor()
        ColorÚnicoAnterior = SorteaColor()
        'TimerVoz.Interval = 1500
        'TimerVoz.Enabled = True
        TimerBorraPrueba.Interval = 6000
        TimerMouseDown.Interval = 20
        TimerColor01.Interval = 20
        TimerColor01.Enabled = False
        If Environment.GetCommandLineArgs.Length > 1 Then
            CargarArchivoInicio()
        Else
            AbreInicial1()
        End If

        ' ColorÚnicoAnterior = Color.YellowGreen 'w Texto.BackColor
        'ColorÚnicoPlus = Color.YellowGreen 'Texto.BackColor
        'Texto.Font = New Font(Texto.Font.Name, 20, FontStyle.Bold)
        'New Font("Arial Narrow", 20, FontStyle.Bold)
        Dim Fuente As New Font("Arial Narrow", 20, FontStyle.Bold)

        With Texto
            .Top = (MenuTablero.Height)
            .Left = 0
            .Width = Me.Width - 8
            .Height = Me.Height - MenuTablero.Height - MenuTablero.Height
        End With

        ColorFijoAsignadoAFondoTablero = Color.FromArgb(255, 255, 255, 222)
        ColorFijoAsignadoALetraTablero = Color.FromArgb(255, 150, 100, 0)
        'ColorÚnicoAnterior = ColorFondo00 'w Texto.BackColor
        'ColorÚnicoPlus = ColorFondo00

        TecladoColorPredeterminado()
        Teclado.CambiaColorTeclado(TecladoColorFondo1, TecladoColorFondo2, TecladoColorFondo3, TecladoColorFondoListas, TecladoColorLetraTeclas, TecladoColorLetraListas)


        With Texto
            .Font = Fuente
            .BackColor = ColorFijoAsignadoAFondoTablero
            .ForeColor = ColorFijoAsignadoALetraTablero
        End With

        Texto.Font = Fuente

        With Me
            '.Height = 300
            '.Width = 520
            GuardaAlto = .Height
            GuardaAncho = .Width
            GuardaTop = .Top
            GuardaLeft = .Left
        End With
        ''''Boca.Hablante.Visible = True
        'Boca.Hablante.MouthEnabled = True
        'Boca.Hablante.SpeedLipType = 1
        'MsgBox(Boca.Hablante.Speed)
        '''''Boca.Hablante.Speed = Velocidad ' el más lento 95  el más rápido 225
        'Boca.Hablante.Age(345) ' el más lento 95
        'Boca.Hablante.Speaker(67800)
        'Boca.Hablante.Pitch = Tono
        ''''Boca.Hablante.Speak("Hola")
        'Dim DirDeLaAplicación = Application.StartupPath

        'Dim ExisteCNotas As Boolean
        'ExisteCNotas = System.IO.Directory.Exists("C:\Notas")
        'If ExisteCNotas = True Then

        'If Not Directory.Exists("C:\Notas") Then
        'Directory.CreateDirectory("C:\Notas")
        'End If
        'If "c:\notas" does not exist then
        'End If
        If Directory.Exists("C:\Notas") Then

            If DirectorioActual = "" Then
                DirectorioActual = "C:\Notas"
            End If
        Else
            DirectorioActual = Application.StartupPath ' al abrir pone el directorio actual en donde está la aplicación
        End If
        Me.Text = "Anotador " & DirectorioActual & ElArchivo
        Teclado.Text = ElArchivo
        '            DirectorioActual = DirDeLaAplicación ' al abrir pone el directorio actual en donde está la aplicación
        'Shell("explorer.exe root =" & DirDeLaAplicación, vbNormalFocus)

        GuardaPosicionPersonalizada()

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If My.Application.CommandLineArgs.Count > 0 Then
                AbrirArchivoInicial(My.Application.CommandLineArgs(0))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub AbrirElArchivo(ByVal Archivo As String)

        Texto.Text = Archivo
        Exit Sub

        Try

            Dim dsMain = New DataSet
            dsMain.ReadXml(Archivo)

            Texto.Text = String.Concat("XMLEditor - ", Archivo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub





    Private Sub ArchivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchivoMenu.Click


    End Sub
    Private Sub CargarArchivoInicio()

        On Error Resume Next
        Exit Sub
        'If Environment.GetCommandLineArgs.Length > 1 Then
        'Texto.Lines = Environment.GetCommandLineArgs
        'Else
        'Texto.Text = "No se han indicado parámetros en la línea de comandos" & vbCrLf & _
        '"El nombre (y path) del ejecutable es:" & vbCrLf & _
        'Environment.GetCommandLineArgs(0)
        'End If




        'Dim ArchivoAAbrir As Object
        ElArchivo = Environment.GetCommandLineArgs(1)
        'System.Windows.Forms.OpenFileDialog.elarchi
        'Dim objStreamReader As New StreamReader("C:\Biorritmos\Textos\Biorritmos1.txt", System.Text.Encoding.Default)
        Dim objStreamReader As New StreamReader(ElArchivo, System.Text.Encoding.Default)
        Texto.Text = ""
        Dim Línea As String
        Línea = objStreamReader.ReadLine
        'Continue to read until you reach the end of the file.
        Do While Not Línea Is Nothing
            'Write the line to the Console window.
            'Console.WriteLine(strLine)
            Texto.Text = Texto.Text & Línea & Chr(13) & Chr(10)
            'Read the next line.
            Línea = objStreamReader.ReadLine
        Loop
        Me.Text = "Anotador " & DirectorioActual & ElArchivo
        Teclado.Text = ElArchivo
    End Sub
    Private Sub AbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next

        If Texto.Text = "" Then AbrirDocumentoExistente(DirectorioActual) : Exit Sub
        If ArchivoGuardado = False Then
            ' MsgBox("Salir sin guardar", MsgBoxStyle.OkCancel, "Atención")
            Dim a = 0

            Dim Result As DialogResult = MessageBox.Show("Descartar datos actuales", "Abrir Arcxhivo", MessageBoxButtons.OKCancel)
            If Result = 1 Then
                AbrirDocumentoExistente(DirectorioActual) : Exit Sub
            Else
                Exit Sub
            End If

        Else
            AbrirDocumentoExistente(DirectorioActual)
        End If

    End Sub
    Public Sub AbrirArchivoInicial(ByVal PathTotal As String)
        'On Error Resume Next
        'AbrirArchivo("C:\Juridico\CLIENTES\Brandan\Mala_praxis\Honorarios\2016-10-19 Acuerdo de honorarios.txt")

        PathInicial = PathTotal
        Dim objStreamReader As New StreamReader(PathTotal, System.Text.Encoding.Default)
        Texto.Text = ""
        Dim Línea As String
        Línea = objStreamReader.ReadLine
        'Continue to read until you reach the end of the file.
        Do While Not Línea Is Nothing
            'Write the line to the Console window.
            'Console.WriteLine(strLine)
            Texto.Text = Texto.Text & Línea & Chr(13) & Chr(10)
            'Read the next line.
            Línea = objStreamReader.ReadLine
        Loop
        'Close the file.
        objStreamReader.Close()

        DivideString(PathTotal, "\")
        Me.Text = "Anotador " & ElArchivoConExtension
        Teclado.Text = ElArchivoConExtension

    End Sub
    Public Sub DivideString(ByVal CadenaTotal As String, ByVal CaracterBuscado As String)
        Dim LargoCadena As Integer = Len(CadenaTotal)
        Dim CaracterExaminado As String
        Dim CadenaAnterior As String = ""
        Dim CadenaPosterior As String = ""
        Dim PosicionDeEncuentro As Integer
        For posicion = LargoCadena To 1 Step -1
            CaracterExaminado = Mid(CadenaTotal, posicion, 1)
            If CaracterExaminado = CaracterBuscado Then
                CadenaAnterior = Mid(CadenaTotal, 1, posicion - 1)
                CadenaPosterior = Mid(CadenaTotal, posicion + 1, LargoCadena - posicion + 1)
                PosicionDeEncuentro = posicion
                GoTo salir
            End If
        Next
salir:
        DirectorioActual = CadenaAnterior
        ElArchivoConExtension = CadenaPosterior
        ElArchivo = ElArchivoConExtension.Substring(0, ElArchivoConExtension.Length() - 4)
    End Sub

    Public Sub AbrirDocumentoExistente(ByVal Directorio As String)
        On Error Resume Next
        Dim ArchivoAAbrir As String
        Dim GuardarNombreArchivoConExtension As String = ElArchivoConExtension
        'OpenFileDialog1.Filter = "Archivos de Texto (*.txt)|*.txt"
        OpenFileDialog1.Filter = "Archivos de Texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        OpenFileDialog1.FileName = ""
        'OpenFileDialog1.InitialDirectory = DirectorioActual
        OpenFileDialog1.InitialDirectory = Directorio
        OpenFileDialog1.ShowDialog()
        ArchivoAAbrir = OpenFileDialog1.FileName

        'ElArchivo = ArchivoAAbrir
        ElArchivoConExtension = IO.Path.GetFileName(OpenFileDialog1.FileName)
        If ElArchivoConExtension.Length = 0 Then
            ElArchivoConExtension = GuardarNombreArchivoConExtension
            FormInforme.Informa("Procedimiento Abrir cancelado")
            Exit Sub
        End If

        ElArchivo = ElArchivoConExtension.Substring(0, ElArchivoConExtension.Length() - 4)
        ' ElArchivoExt = ElArchivo & ".txt"
        DirectorioActual = IO.Path.GetDirectoryName(OpenFileDialog1.FileName)
        'System.Windows.Forms.OpenFileDialog.elarchi
        'Dim objStreamReader As New StreamReader("C:\Biorritmos\Textos\Biorritmos1.txt", System.Text.Encoding.Default)
        Dim objStreamReader As New StreamReader(ArchivoAAbrir, System.Text.Encoding.Default)
        Texto.Text = ""
        Dim Línea As String
        Línea = objStreamReader.ReadLine
        'Continue to read until you reach the end of the file.
        Do While Not Línea Is Nothing
            'Write the line to the Console window.
            'Console.WriteLine(strLine)
            Texto.Text = Texto.Text & Línea & Chr(13) & Chr(10)
            'Read the next line.
            Línea = objStreamReader.ReadLine
        Loop
        'Close the file.
        objStreamReader.Close()
        Me.Text = "Anotador " & ElArchivoConExtension
        Teclado.Text = ElArchivoConExtension
        FormInforme.Informa("Procedimiento Abrir con nuevo archivo abierto")
    End Sub
    Public Sub AbreInicial1()
        On Error Resume Next
        '"C:\Anotador\Archivos\UltimoArchivo.txt",
        ' SeparaNombreDeArchivo(PathTotalDelArchivo)
        'Dim ArchivoAAbrir As String
        'Dim GuardarNombreArchivoConExtension As String = ElArchivoConExtension
        'ArchivoAAbrir = PathTotalDelArchivo
        'ElArchivo = ElArchivoConExtension.Substring(0, ElArchivoConExtension.Length() - 4)

        Dim DireccionInicial As String
        Dim objStreamReader As New StreamReader("C:\Anotador\Archivos\UltimoArchivo.txt", System.Text.Encoding.Default)
        DireccionInicial = ""
        Dim Línea As String
        Línea = objStreamReader.ReadLine
        Do While Not Línea Is Nothing
            DireccionInicial = DireccionInicial & Línea '& Chr(13) & Chr(10)
            Línea = objStreamReader.ReadLine
        Loop
        objStreamReader.Close()
        FormInforme.Informa("Procedimiento Abrir con el indice")

        AbreDesdeElIndice(DireccionInicial)
    End Sub
    Public Sub AbreDesdeElIndice(ByVal PathTotalDelArchivo As String)
        'On Error Resume Next
        On Error GoTo TratamientoDelError
        SeparaNombreDeArchivo(PathTotalDelArchivo)
        Dim ArchivoAAbrir As String
        Dim GuardarNombreArchivoConExtension As String = ElArchivoConExtension
        ArchivoAAbrir = PathTotalDelArchivo


        ElArchivo = ElArchivoConExtension.Substring(0, ElArchivoConExtension.Length() - 4)
        Dim objStreamReader As New StreamReader(ArchivoAAbrir, System.Text.Encoding.Default)
        Texto.Text = ""
        Dim Línea As String
        Línea = objStreamReader.ReadLine
        'Continue to read until you reach the end of the file.
        Do While Not Línea Is Nothing
            'Write the line to the Console window.
            'Console.WriteLine(strLine)
            Texto.Text = Texto.Text & Línea & Chr(13) & Chr(10)
            'Read the next line.
            Línea = objStreamReader.ReadLine
        Loop
        'Close the file.
        objStreamReader.Close()
        ' Me.Text = "Anotador " & ElArchivoConExtension
        'Teclado.Text = ElArchivoConExtension
        FormInforme.Informa("Procedimiento Abrir con el indice")
        Exit Sub
TratamientoDelError:
        Exit Sub
    End Sub
    Public Sub SeparaNombreDeArchivo(ByVal PathTotalDelArchivo As String)
        Dim Posicion As Integer = PathTotalDelArchivo.LastIndexOf("\")
        DirectorioActual = Mid(PathTotalDelArchivo, 1, Posicion)
        ElArchivoConExtension = Mid(PathTotalDelArchivo, Posicion + 2)
        TitulaAnotadorYTeclado()

    End Sub

    Public Sub AbrirRecorte(ByVal ArchivoAAbrir As String)
        On Error Resume Next
        Dim Recorte As String = ""
        'Dim ArchivoAAbrir As String
        ArchivoAAbrir = "C:\Notas\Recortes\" & ArchivoAAbrir
        Dim objStreamReader As New StreamReader(ArchivoAAbrir, System.Text.Encoding.Default)
        'Dim objStreamReader As New StreamReader(ArchivoAAbrir, System.Text.Encoding.Default)
        Recorte = ""
        Dim Línea As String
        Línea = objStreamReader.ReadLine
        'Continue to read until you reach the end of the file.
        Do While Not Línea Is Nothing
            'Write the line to the Console window.
            'Console.WriteLine(strLine)
            Recorte = Recorte & Línea & Chr(13) & Chr(10)
            'Read the next line.
            Línea = objStreamReader.ReadLine
        Loop
        'Close the file.
        objStreamReader.Close()
        'Me.Text = "Anotador " & ElArchivoExt
        InsertaRecorte(Recorte, Texto.SelectedText)

    End Sub
    Private Sub InsertaTexto(ByVal TextoAInsertar As String, ByVal Seleccionado As String)
        'If FijaMayúsculas = False Then PoneMinusculas()
        PosiciónDeInicio = Texto.SelectionStart
        PosiciónDeFinalSeleccion = Texto.SelectionStart + Len(Seleccionado)
        Dim TextoAnterior = Texto.Text.Substring(0, PosiciónDeInicio)
        Dim TextoPosterior = Texto.Text.Substring(PosiciónDeFinalSeleccion, Texto.Text.Length() - PosiciónDeFinalSeleccion)
        Texto.Text = TextoAnterior & TextoAInsertar & TextoPosterior
        Texto.SelectionStart = Len(TextoAnterior) + 1
        Texto.ScrollToCaret()
        'BotonLetra.Text = TextoAInsertar
        'Anotador.Texto.Cursor.Show()
        Texto.Focus()
    End Sub
    Private Sub InsertaRecorte(ByVal TextoDelRecorte As String, ByVal Seleccionado As String)
        'If FijaMayúsculas = False Then PoneMinusculas()
        TextoDelRecorte = Mid(TextoDelRecorte, 1, Len(TextoDelRecorte) - 2)
        PosiciónDeInicio = Texto.SelectionStart
        PosiciónDeFinalSeleccion = Texto.SelectionStart + Len(Seleccionado)
        Dim TextoAnterior = Texto.Text.Substring(0, PosiciónDeInicio)
        Dim TextoPosterior = Texto.Text.Substring(PosiciónDeFinalSeleccion, Texto.Text.Length() - PosiciónDeFinalSeleccion)
        Texto.Text = TextoAnterior & TextoDelRecorte & TextoPosterior
        'Texto.SelectionStart = Len(TextoAnterior) + 2
        Texto.SelectionStart = Len(TextoAnterior) + Len(TextoDelRecorte)

        'Texto.ScrollToCaret()
        'BotonLetra.Text = TextoAInsertar
        'Anotador.Texto.Cursor.Show()
        Texto.Focus()
    End Sub

    Public Function Formatea1(ByVal CantDígitos As Byte, ByVal Valor As Byte) As String
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


    Public Function NombreFechaLarga()
        Dim Fecha As Date
        Dim FechaLarga As String
        Fecha = Now()
        Dim Año As String = Fecha.Year()
        Dim Mes As String = Formatea1(2, Fecha.Month)
        Dim Dia As String = Formatea1(2, Fecha.Day)
        Dim Horas As String = Formatea1(2, Fecha.Hour)
        Dim Minutos As String = Formatea1(2, Fecha.Minute)
        Dim Segundos As String = Formatea1(2, Fecha.Second)
        Dim Milisegundos As String = Fecha.Millisecond
        If Len(Milisegundos) = 2 Then Milisegundos = "0" & Milisegundos
        If Len(Milisegundos) = 1 Then Milisegundos = "00" & Milisegundos
        FechaLarga = Año & "-" & Mes & "-" & Dia & "__" & Horas & "-" & Minutos & "__" & Segundos & "-" & Milisegundos
        Return FechaLarga
    End Function
    Public Function Fechora() As String
        Dim Fecha As Date
        Dim DiasSemana As String = "dom"
        Dim NombreMes As String = "jano"
        Fecha = Now()
        Dim Año As String = Fecha.Year()
        Dim Mes As String = Formatea1(2, Fecha.Month)

        Dim Dia As String = Formatea1(2, Fecha.Day)
        Dim DiaSem As Integer = Formatea1(2, Fecha.DayOfWeek)

        Dim Horas As String = Formatea1(2, Fecha.Hour)
        Dim Minutos As String = Formatea1(2, Fecha.Minute)
        Dim Segundos As String = Formatea1(2, Fecha.Second)
        Dim Milisegundos As String = Fecha.Millisecond
        If Len(Milisegundos) = 2 Then Milisegundos = "0" & Milisegundos
        If Len(Milisegundos) = 1 Then Milisegundos = "00" & Milisegundos
        'Fechora = Año & "-" & Mes & "-" & Dia & "__" & Horas & "-" & Minutos & "__" & Segundos & "-" & Milisegundos
        Select Case DiaSem
            Case Is = 1
                DiasSemana = "Lun"
            Case Is = 2
                DiasSemana = "Mar"
            Case Is = 3
                DiasSemana = "Mié"
            Case Is = 4
                DiasSemana = "Jue"
            Case Is = 5
                DiasSemana = "Vie"
            Case Is = 6
                DiasSemana = "Sáb"
            Case Is = 7
                DiasSemana = "Dom"
        End Select
        Select Case Fecha.Month
            Case Is = 1
                NombreMes = "Ene"
            Case Is = 2
                NombreMes = "Feb"
            Case Is = 3
                NombreMes = "Mar"
            Case Is = 4
                NombreMes = "Abr"
            Case Is = 5
                NombreMes = "May"
            Case Is = 6
                NombreMes = "Jun"
            Case Is = 7
                NombreMes = "Jul"
            Case Is = 8
                NombreMes = "Ago"
            Case Is = 9
                NombreMes = "Sep"
            Case Is = 10
                NombreMes = "Oct"
            Case Is = 11
                NombreMes = "Nov"
            Case Is = 12
                NombreMes = "Dic"
        End Select

        Fechora = "[" & DiasSemana & ". " & Dia & " " & NombreMes & ". " & Horas & ":" & Minutos & "]"
        Return Fechora
    End Function

    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim Particula As String
        If Me.Name <> "Anotador" Then
            Dim numAleatorio As New Random()
            Dim valorAleatorio As Integer = numAleatorio.Next(1, 1000)
            Dim Particulin As String = Str(valorAleatorio)
            'Dim num As Integer = Rnd()
            'Dim midnum = Mid(Str(num), 1, 3)
            Particula = Me.Name & " " & Particulin & " "
            Particula = "Recorte" & " " & Particulin & " "
        Else
            Particula = ""
        End If

        Dim CadenaGuardar = DirectorioActual & "\" & Particula & ElArchivoConExtension
        GuardarDocumento(CadenaGuardar)
        Dim UltimoArchivo As String = DirectorioActual & "\" & ElArchivoConExtension
        GuardarDireccion("C:\Anotador\Archivos\UltimoArchivo.txt", UltimoArchivo)

    End Sub
    Private Sub GuardarDocumento(ByVal CadenaCompleta As String)
        'Dim CadenaCompleta = DirectorioActual & "\" & ElArchivoConExtension
        FileOpen(1, CadenaCompleta, OpenMode.Output)
        Print(1, Texto.Text)
        FileClose(1)
        ArchivoGuardado = True
        FormInforme.Informa("Procedimiento guardar archivo")
    End Sub
    Private Sub GuardarDireccion(ByVal DondeGuardar As String, ByVal DireccionAGuardar As String)
        'Dim CadenaCompleta = DirectorioActual & "\" & ElArchivoConExtension
        FileOpen(1, DondeGuardar, OpenMode.Output)
        Print(1, DireccionAGuardar)
        FileClose(1)
        ArchivoGuardado = True
        FormInforme.Informa("Procedimiento guardar dirección último archivo")
    End Sub

    Private Sub GuardarComoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarComoToolStripMenuItem.Click
        GuardarComo(False)

    End Sub
    Public Sub GuardarComo(ByVal SoloSeleccionado As Boolean)
        Dim GuardaDirectorioActual As String = DirectorioActual

        SaveFileDialog1.Filter = "Archivos de Texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If ElArchivoConExtension = "" Then
            ElArchivo = NombreFechaLarga()
            ElArchivoConExtension = ElArchivo & ".txt"
            'ElArchivo = NombreFechaLargaDeOrigen
        End If

        SaveFileDialog1.InitialDirectory = DirectorioActual
        SaveFileDialog1.FileName = ElArchivoConExtension

        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName <> "" Then
            FileOpen(1, SaveFileDialog1.FileName, OpenMode.Output)
            If SoloSeleccionado = False Then
                Print(1, Texto.Text)
            Else
                Print(1, Texto.SelectedText)
            End If
            FileClose(1)
            FormInforme.Informa("Procedimiento Guardar Como exitoso")
            'Exit Sub
        Else
            FormInforme.Informa("Procedimiento Guardar Como situacion 1")
            Exit Sub
        End If

        DirectorioActual = IO.Path.GetDirectoryName(SaveFileDialog1.FileName)
        If DirectorioActual = "" Then
            DirectorioActual = GuardaDirectorioActual
        End If
        ElArchivoConExtension = IO.Path.GetFileName(SaveFileDialog1.FileName)
        ElArchivo = ElArchivoConExtension.Substring(0, ElArchivoConExtension.Length() - 4)

        Me.Text = "Anotador " & DirectorioActual & ElArchivoConExtension
        Teclado.Text = ElArchivoConExtension
        'Me.Text = "Anotador " & Fechora() & " " & DirectorioActual & " " & ElArchivo
        ArchivoGuardado = True
        FormInforme.Informa("Procedimiento Guardar Como con archivo Exitoso")
        Dim UltimoArchivo As String = DirectorioActual & "\" & ElArchivoConExtension
        GuardarDireccion("C:\Anotador\Archivos\UltimoArchivo.txt", UltimoArchivo)


    End Sub
    Public Sub GuardarSeleccionadoComoArchivo()
        Dim GuardaDirectorioActual As String = DirectorioActual

        SaveFileDialog1.Filter = "Archivos de Texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If ElArchivoConExtension = "" Then
            ElArchivo = NombreFechaLarga()
            ElArchivoConExtension = ElArchivo & ".txt"
            'ElArchivo = NombreFechaLargaDeOrigen
        End If

        SaveFileDialog1.InitialDirectory = DirectorioActual
        SaveFileDialog1.FileName = ElArchivoConExtension

        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName <> "" Then
            FileOpen(1, SaveFileDialog1.FileName, OpenMode.Output)
            Print(1, Texto.Text)
            FileClose(1)
            FormInforme.Informa("Procedimiento Guardar Como exitoso")
            'Exit Sub
        Else
            FormInforme.Informa("Procedimiento Guardar Como situacion 1")
            Exit Sub
        End If

        DirectorioActual = IO.Path.GetDirectoryName(SaveFileDialog1.FileName)
        If DirectorioActual = "" Then
            DirectorioActual = GuardaDirectorioActual
        End If
        ElArchivoConExtension = IO.Path.GetFileName(SaveFileDialog1.FileName)
        ElArchivo = ElArchivoConExtension.Substring(0, ElArchivoConExtension.Length() - 4)

        Me.Text = "Anotador " & DirectorioActual & ElArchivoConExtension
        Teclado.Text = ElArchivoConExtension
        'Me.Text = "Anotador " & Fechora() & " " & DirectorioActual & " " & ElArchivo
        ArchivoGuardado = True
        FormInforme.Informa("Procedimiento Guardar Como con archivo Exitoso")
    End Sub
    Public Sub GuardarComoRecorte()
        If Len(Texto.SelectedText) = 0 Then
            Exit Sub
        End If

        SaveFileDialog1.Filter = "Archivos de Texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If ElArchivo = "" Then
            ElArchivo = NombreFechaLarga()
            ElArchivoConExtension = ElArchivo & ".txt"
            'ElArchivo = NombreFechaLargaDeOrigen
        End If

        'SaveFileDialog1.InitialDirectory = DirectorioActual
        SaveFileDialog1.InitialDirectory = "C:\Notas\Recortes\"
        SaveFileDialog1.FileName = ElArchivoConExtension

        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName <> "" Then
            FileOpen(1, SaveFileDialog1.FileName, OpenMode.Output)
            Print(1, Texto.SelectedText)
            FileClose(1)
        End If

        ' DirectorioActual = IO.Path.GetDirectoryName(SaveFileDialog1.FileName)
        ' ElArchivoExt = IO.Path.GetFileName(SaveFileDialog1.FileName)
        ' ElArchivo = ElArchivoExt.Substring(0, ElArchivoExt.Length() - 4)

        ' Me.Text = "Anotador " & DirectorioActual & ElArchivoExt
        'ArchivoGuardado = True
    End Sub
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        RecaudosDeSalir()

    End Sub
    Public Sub RecaudosDeSalir()
        'If NombreDelCuadroACerrar <> "Anotador" Then Exit Sub
        'Dim UltimoArchivo As String = DirectorioActual & "\" & ElArchivoConExtension
        'GuardarDireccion("C:\Anotador\Archivos\UltimoArchivo.txt", UltimoArchivo)
        If Texto.Text = "" Then End
        If ArchivoGuardado = False Then

            ' MsgBox("Salir sin guardar", MsgBoxStyle.OkCancel, "Atención")
            Dim a = 0
            Dim Result As DialogResult = MessageBox.Show("Salir sin guardar", "Atención", MessageBoxButtons.OKCancel)
            If Result = 1 Then
                End
            Else
                GuardarComo(False)
                'Exit Sub
            End If


        Else
            End
        End If
    End Sub
    Private Sub FuenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuenteMenu.Click

    End Sub
    Private Sub FondoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FondoToolStripMenuItem.Click
        TextoInicial("")
        ColorDialog1.Color = Texto.BackColor
        ColorDialog1.ShowDialog()
        'FontDialog1.Color = Color.Tomato
        TextoInicial("")
        Texto.BackColor = ColorDialog1.Color
        ColorTransición = ColorDialog1.Color
        SeparaFondoDeTransiciónColor = True
        ColorFijoAsignadoAFondoTablero = ColorDialog1.Color
    End Sub
    Private Sub FuenteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuenteToolStripMenuItem1.Click
        TextoInicial("")
        ColorDialog1.Color = Texto.ForeColor
        ColorDialog1.ShowDialog()
        TextoInicial("")
        Texto.ForeColor = ColorDialog1.Color
        SeparaLetraDeTransiciónColor = True
        ColorFijoAsignadoALetraTablero = ColorDialog1.Color
    End Sub
    Private Sub Anotador_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Mover = True
        PosMovIzq = e.X
        PosMovArr = e.Y
        'Me.Visible = False
    End Sub
    Private Sub Anotador_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        If Me.Left < 0 Then Me.Left = 0

    End Sub
    Private Sub Anotador_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If Mover = True Then
            Me.Top = (Me.Top + e.Y - PosMovArr) ' - Me.Height / 2
            Me.Left = (Me.Left + e.X - PosMovIzq) ' - Me.Width / 2
        End If
        'Me.Top = (Me.Top + e.Y) - Me.Height / 2
        'Me.Left = (Me.Left + e.X) - Me.Width / 2

    End Sub
    Private Sub Anotador_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        Mover = False
        'Exit Sub
        'If e.X > Me.Width Then Exit Sub
        'If e.Y > Me.Height Then Exit Sub
        If e.Button = Windows.Forms.MouseButtons.Right Then
            MenuTablero.Visible = True
            Me.MaximizeBox = True
            Me.MinimizeBox = True
            Me.ControlBox = True
            'Me.Text = "Anotador " & ElArchivo
            Me.Text = "Anotador " & DirectorioActual & ElArchivoConExtension
            Teclado.Text = ElArchivoConExtension
            With Me
                .Height = GuardaAlto
                .Width = GuardaAncho
                .Top = GuardaTop
                .Left = GuardaLeft
            End With
        End If
    End Sub
    Private Sub Anotador_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'If PantallaCompleta = True Then
        'Exit Sub
        'PantallaCompleta = False
        'End If

        If SinCabecera = True Then
            'SinCabecera = False
            Exit Sub
        End If


        If PantallaCompleta = True Then
            With Me
                .Width = Screen.PrimaryScreen.Bounds.Width
                .Height = Screen.PrimaryScreen.Bounds.Height
            End With

            With Texto
                .Top = 0
                .Left = 0
                .Width = Me.Width - 10
                .Height = Me.Height
            End With
            'PantallaCompleta = False
            Exit Sub
        End If

        If Me.Height < 52 Or Me.Width < 152 Then Exit Sub



        If Me.Width < 800 Then
            FuenteDelMenu = FormMenu.Font
            FuenteDelMenu = New Font(FuenteDelMenu.FontFamily, Me.Width / 80, FuenteDelMenu.Style, FuenteDelMenu.Unit, FuenteDelMenu.GdiCharSet)

            FormMenu.Text = "F"
            FormMenu.Font = FuenteDelMenu
            ArchivoMenu.Text = "A"
            ArchivoMenu.Font = FuenteDelMenu
            TextoCopiaMenu.Text = "X"
            TextoCopiaMenu.Font = FuenteDelMenu
            ColorMenu.Text = "C"
            ColorMenu.Font = FuenteDelMenu
            DistribucionMenu.Text = "O"
            DistribucionMenu.Font = FuenteDelMenu
            TableroMenu.Text = "T"
            TableroMenu.Font = FuenteDelMenu
            FuenteMenu.Text = "F"
            FuenteMenu.Font = FuenteDelMenu
            AcercaDeMenu.Text = "A"
            AcercaDeMenu.Font = FuenteDelMenu
            MinimizaMenu.Font = FuenteDelMenu
            TotalMenu.Font = FuenteDelMenu
            MuestraTecladoMenu.Font = FuenteDelMenu
            Colores1Menu.Font = FuenteDelMenu
            Colores2Menu.Font = FuenteDelMenu
            Colores3Menu.Font = FuenteDelMenu
        Else
            FuenteDelMenu = FormMenu.Font
            FuenteDelMenu = New Font(FuenteDelMenu.FontFamily, 12, FuenteDelMenu.Style, FuenteDelMenu.Unit, FuenteDelMenu.GdiCharSet)

            FormMenu.Text = "Form."
            FormMenu.Font = FuenteDelMenu
            ArchivoMenu.Text = "Archivo"
            ArchivoMenu.Font = FuenteDelMenu
            TextoCopiaMenu.Text = "Txt."
            TextoCopiaMenu.Font = FuenteDelMenu
            ColorMenu.Text = "Color"
            ColorMenu.Font = FuenteDelMenu
            DistribucionMenu.Text = "Org."
            DistribucionMenu.Font = FuenteDelMenu
            TableroMenu.Text = "Tabl."
            TableroMenu.Font = FuenteDelMenu
            FuenteMenu.Text = "Fuente"
            FuenteMenu.Font = FuenteDelMenu
            AcercaDeMenu.Text = "Acerca de"
            AcercaDeMenu.Font = FuenteDelMenu
            MinimizaMenu.Font = FuenteDelMenu
            TotalMenu.Font = FuenteDelMenu
            MuestraTecladoMenu.Font = FuenteDelMenu
            Colores1Menu.Font = FuenteDelMenu
            Colores2Menu.Font = FuenteDelMenu
            Colores3Menu.Font = FuenteDelMenu
        End If



        Me.MenuTablero.Visible = True
        With Texto
            .Top = (MenuTablero.Height)
            .Left = 0
            .Width = Me.Width - 8
            .Height = Me.Height - MenuTablero.Height - MenuTablero.Height
        End With


        With Me
            .MenuTablero.Visible = True
            '.Top = 0
            '.Left = 0
            '.Width = Screen.PrimaryScreen.Bounds.Width
            '.Height = Screen.PrimaryScreen.Bounds.Height
            '.MaximizeBox = True
            '.MinimizeBox = True
            .ControlBox = True
            '.Text = ""


            GuardaAlto = .Height
            GuardaAncho = .Width
            GuardaTop = .Top
            GuardaLeft = .Left
        End With
    End Sub

    Private Function ColorComplementarioClaro(ByVal ColorBase As Color)
        Dim ColorComplementario As Color
        Select Case FórmulaComplementaria
            Case Is = 1
                ColorComplementario = Color.FromArgb(255, 255 - (ColorBase.G / 2), 255 - (ColorBase.B / 2), 255 - (ColorBase.R / 2))
            Case Is = 2
                ColorComplementario = Color.FromArgb(255, 255 - (ColorBase.B / 2), 255 - (ColorBase.R / 2), 255 - (ColorBase.G / 2))
            Case Is = 3
                ColorComplementario = Color.FromArgb(255, 255 - (ColorBase.R / 2), 255 - (ColorBase.G / 2), 255 - (ColorBase.B / 2))
            Case Is = 4
                ColorComplementario = Color.FromArgb(255, 255 - (ColorBase.B / 2), 255 - (ColorBase.G / 2), 255 - (ColorBase.R / 2))
            Case Is = 5
                ColorComplementario = Color.FromArgb(255, 255 - (ColorBase.G / 2), 255 - (ColorBase.R / 2), 255 - (ColorBase.B / 2))
            Case Is = 6
                ColorComplementario = Color.FromArgb(255, 255 - (ColorBase.R / 2), 255 - (ColorBase.B / 2), 255 - (ColorBase.G / 2))
        End Select

        Return ColorComplementario
    End Function






    Private Sub Texto_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If SorteaAleacolorTrans = True Then
            TransiciónDeColorPaso()
        End If

    End Sub
    Private Sub Texto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub InvertirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvertirToolStripMenuItem.Click
        TextoInicial("")

        Dim InterColor As New Color
        InterColor = Texto.BackColor
        Texto.BackColor = Texto.ForeColor
        Texto.ForeColor = InterColor
        InterColor = MenuTablero.BackColor
        MenuTablero.BackColor = MenuTablero.ForeColor
        MenuTablero.ForeColor = InterColor
    End Sub

    Private Sub BlancoYNegroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlancoYNegroToolStripMenuItem.Click
        TextoInicial("")
        Texto.BackColor = Color.FromArgb(255, 255, 255, 255)
        Texto.ForeColor = Color.FromArgb(255, 0, 0, 0)
        MenuTablero.BackColor = Color.FromArgb(255, 255, 255, 255)
        MenuTablero.ForeColor = Color.FromArgb(255, 0, 0, 0)
    End Sub
    Private Sub MenuCreaNuevoDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCreaNuevoDocumento.Click
        CreaNuevoDocumento()
    End Sub
    Private Sub CreaNuevoDocumento()
        If DirectorioActual = "" Then
            DirectorioActual = "C:\Notas"
        End If
        If Texto.Text = "" Then
            'ElArchivo = ""
            ElArchivo = NombreFechaLarga()
            ElArchivoConExtension = ElArchivo & ".txt"
            Texto.Text = ""
            'Me.Text = "Anotador " & ElArchivo
            Me.Text = "Anotador " & DirectorioActual & ElArchivoConExtension
            Teclado.Text = ElArchivoConExtension
            NombreFechaLargaDeOrigen = NombreFechaLarga()
            FormInforme.Informa("Crea nuevo documento sin texto anterior")

            Exit Sub
        End If


        If ArchivoGuardado = False Then
            ' MsgBox("Salir sin guardar", MsgBoxStyle.OkCancel, "Atención")
            Dim a = 0

            Dim Result As DialogResult = MessageBox.Show("Descartar datos actuales", "Atención", MessageBoxButtons.OKCancel)
            If Result = 1 Then
                ElArchivo = NombreFechaLarga()
                ElArchivoConExtension = ElArchivo & ".txt"
                Texto.Text = ""
                Me.Text = "Anotador " & DirectorioActual & ElArchivoConExtension
                Teclado.Text = ElArchivoConExtension
                NombreFechaLargaDeOrigen = NombreFechaLarga()
                FormInforme.Informa("Crea nuevo documento. Descarta cambios texto anterior")
            Else
                FormInforme.Informa("Crea nuevo documento CANCELADO")
                Exit Sub
            End If


        Else
            'ElArchivo = ""
            ElArchivo = NombreFechaLarga()
            ElArchivoConExtension = ElArchivo & ".txt"
            Texto.Text = ""
            'Me.Text = "Anotador " & ElArchivo
            Me.Text = "Anotador " & DirectorioActual & ElArchivoConExtension
            Teclado.Text = ElArchivoConExtension
            FormInforme.Informa("Crea nuevo documento. Texto anterior ya guardado")
        End If
    End Sub

    Private Sub PredeterminadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PredeterminadoToolStripMenuItem.Click
        TextoInicial("")
        MenuTablero.BackColor = Color.FromArgb(255, 255, 224, 192)
        MenuTablero.ForeColor = Color.FromArgb(255, 0, 0, 0)
        With Texto
            ColorFijoAsignadoAFondoTablero = Color.FromArgb(255, 255, 255, 222)
            ColorFijoAsignadoALetraTablero = Color.FromArgb(255, 150, 100, 0)
            .BackColor = ColorFijoAsignadoAFondoTablero
            .ForeColor = ColorFijoAsignadoALetraTablero
        End With
    End Sub
    Private Sub MedioDerechoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MedioDerechoToolStripMenuItem.Click
        If Me.WindowState = FormWindowState.Maximized Then Me.WindowState = FormWindowState.Normal
        With Me
            .Top = 0
            .Left = 0
            .Height = Screen.PrimaryScreen.Bounds.Height
            .Width = Screen.PrimaryScreen.Bounds.Width / 2
        End With
    End Sub
    Private Sub MedioIzquierdoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MedioIzquierdoToolStripMenuItem.Click
        If Me.WindowState = FormWindowState.Maximized Then Me.WindowState = FormWindowState.Normal
        With Me
            .Top = 0
            .Left = Screen.PrimaryScreen.Bounds.Width / 2
            .Height = Screen.PrimaryScreen.Bounds.Height
            .Width = Screen.PrimaryScreen.Bounds.Width / 2
        End With
    End Sub
    Private Sub TercioDerechoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TercioDerechoToolStripMenuItem.Click
        If Me.WindowState = FormWindowState.Maximized Then Me.WindowState = FormWindowState.Normal
        With Me
            .Top = 0
            .Left = 0
            .Height = Screen.PrimaryScreen.Bounds.Height
            .Width = Screen.PrimaryScreen.Bounds.Width / 3
        End With
    End Sub
    Private Sub TercioMedioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TercioMedioToolStripMenuItem.Click
        If Me.WindowState = FormWindowState.Maximized Then Me.WindowState = FormWindowState.Normal
        With Me
            .Top = 0
            .Left = Screen.PrimaryScreen.Bounds.Width / 3
            .Height = Screen.PrimaryScreen.Bounds.Height
            .Width = Screen.PrimaryScreen.Bounds.Width / 3
        End With
    End Sub
    Private Sub TercioDerechoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TercioDerechoToolStripMenuItem1.Click
        With Me
            .Top = 0
            .Left = Screen.PrimaryScreen.Bounds.Width / 3 * 2
            .Height = Screen.PrimaryScreen.Bounds.Height
            .Width = Screen.PrimaryScreen.Bounds.Width / 3
        End With
    End Sub
    Private Sub MedioSuperiorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MedioSuperiorToolStripMenuItem.Click
        If Me.WindowState = FormWindowState.Maximized Then Me.WindowState = FormWindowState.Normal
        With Me
            .Top = 0
            .Left = 0
            .Height = Screen.PrimaryScreen.Bounds.Height / 2
            .Width = Screen.PrimaryScreen.Bounds.Width
        End With
    End Sub
    Private Sub MedioInferiorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MedioInferiorToolStripMenuItem.Click
        If Me.WindowState = FormWindowState.Maximized Then Me.WindowState = FormWindowState.Normal
        With Me
            .Top = Screen.PrimaryScreen.Bounds.Height / 2
            .Left = 0
            .Height = Screen.PrimaryScreen.Bounds.Height / 2
            .Width = Screen.PrimaryScreen.Bounds.Width
        End With
    End Sub
    Private Sub CuartoPantallaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuartoPantallaToolStripMenuItem.Click
        If Me.WindowState = FormWindowState.Maximized Then Me.WindowState = FormWindowState.Normal
        With Me
            .Top = 0
            .Left = 0
            .Height = Screen.PrimaryScreen.Bounds.Height / 2
            .Width = Screen.PrimaryScreen.Bounds.Width / 2
        End With
    End Sub
    Private Sub SextroPantallaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SextroPantallaToolStripMenuItem.Click
        If Me.WindowState = FormWindowState.Maximized Then Me.WindowState = FormWindowState.Normal
        With Me
            .Top = 0
            .Left = 0
            .Height = Screen.PrimaryScreen.Bounds.Height / 2
            .Width = Screen.PrimaryScreen.Bounds.Width / 3
        End With
    End Sub
    Private Sub TotalPantallaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalPantallaToolStripMenuItem.Click
        If Me.WindowState = FormWindowState.Maximized Then Me.WindowState = FormWindowState.Normal
        With Me
            .Top = 0
            .Left = 0
            .Height = Screen.PrimaryScreen.Bounds.Height
            .Width = Screen.PrimaryScreen.Bounds.Width
        End With
    End Sub
    Private Sub PequeñoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PequeñoToolStripMenuItem.Click
        If Me.WindowState = FormWindowState.Maximized Then Me.WindowState = FormWindowState.Normal
        With Me
            ' .Top = 0
            '.Left = 0
            .Height = MenuTablero.Height * 6
            .Width = Screen.PrimaryScreen.Bounds.Width / 2.5
        End With
    End Sub
    Private Sub MínimoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MínimoToolStripMenuItem.Click
        If Me.WindowState = FormWindowState.Maximized Then Me.WindowState = FormWindowState.Normal
        With Me
            '.Top = 0
            '.Left = 0
            .Height = MenuTablero.Height * 2
            .Width = Screen.PrimaryScreen.Bounds.Width / 6
        End With

    End Sub
    Private Sub SiempreArribaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SiempreArribaToolStripMenuItem.Click
        Me.TopMost = True
        SiempreArribaToolStripMenuItem.Checked = True
        PermitirOcultarToolStripMenuItem.Checked = False

    End Sub
    Private Sub PermitirOcultarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermitirOcultarToolStripMenuItem.Click
        Me.TopMost = False
        SiempreArribaToolStripMenuItem.Checked = False
        PermitirOcultarToolStripMenuItem.Checked = True
    End Sub
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraMasMenu.Click
        TextoInicial("")
        Fuente = Texto.Font
        Fuente = New Font(Fuente.FontFamily, Fuente.Size * 1.1, Fuente.Style, Fuente.Unit, Fuente.GdiCharSet)
        Texto.Font = Fuente
    End Sub
    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetraMenosMenu.Click
        TextoInicial("")
        Fuente = Texto.Font
        Fuente = New Font(Fuente.FontFamily, Fuente.Size * 0.9, Fuente.Style, Fuente.Unit, Fuente.GdiCharSet)
        Texto.Font = Fuente
    End Sub
    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        If Me.WindowState = FormWindowState.Maximized Then Me.WindowState = FormWindowState.Normal
        With Me
            ' .Top = 0
            '.Left = 0
            .Height = MenuTablero.Height
            .Width = Screen.PrimaryScreen.Bounds.Width / 6
        End With
    End Sub
    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        If Me.WindowState = FormWindowState.Maximized Then Me.WindowState = FormWindowState.Normal
        With Me
            '.Top = 0
            '.Left = 0
            .Height = MenuTablero.Height * 12
            .Width = Screen.PrimaryScreen.Bounds.Width / 1.9
        End With
    End Sub
    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FomMenosMenu.Click

        If Me.WindowState = FormWindowState.Maximized Then Me.WindowState = FormWindowState.Normal

        If Me.Height = MenuTablero.Height * 2 Then
            With Me
                '.Top = 0
                '.Left = 0
                .Height = MenuTablero.Height
                .ControlBox = False
                .Text = ""
                .MaximizeBox = False
                .MinimizeBox = False
                '.Height = Screen.PrimaryScreen.Bounds.Height
                '.Width = Screen.PrimaryScreen.Bounds.Width
                GuardaAncho = .Height
                GuardaAncho = .Width
            End With
            Exit Sub
        End If


        With Me
            ' .Top = 0
            '.Left = 0

            .Width = .Width * 0.7
            .Height = .Width / 4 * 3
            GuardaAncho = .Height
            GuardaAncho = .Width
        End With


        If Me.Height = MenuTablero.Height * 2 Then
            With Me
                '.Top = 0
                '.Left = 0
                .Height = MenuTablero.Height
                .ControlBox = False
                .Text = ""
                '.MaximizeBox = False
                '.MinimizeBox = False
                '.Height = Screen.PrimaryScreen.Bounds.Height
                '.Width = Screen.PrimaryScreen.Bounds.Width
                GuardaAncho = .Height
                GuardaAncho = .Width
            End With
            Exit Sub
        End If



        If Me.Height <= Screen.PrimaryScreen.Bounds.Height / 6 Then
            With Me
                '.Top = 0
                '.Left = 0
                .Height = MenuTablero.Height * 2
                .ControlBox = True
                .Text = ""
                '.MaximizeBox = True
                '.MinimizeBox = True
                '.Height = Screen.PrimaryScreen.Bounds.Height
                '.Width = Screen.PrimaryScreen.Bounds.Width
                GuardaAlto = .Height
                GuardaAncho = .Width
                GuardaTop = .Top
                GuardaLeft = .Left
            End With

        End If

    End Sub
    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormMasMenu.Click
        If Me.ControlBox = False Then
            With Me
                '.Top = 0
                '.Left = 0
                '.Height = Menú.Height * 1.2
                .ControlBox = True
                '.Text = "Anotador " & ElArchivo
                .Text = "Anotador " & DirectorioActual & ElArchivoConExtension
                '.MaximizeBox = True
                '.MinimizeBox = True
                '.Height = Screen.PrimaryScreen.Bounds.Height
                '.Width = Screen.PrimaryScreen.Bounds.Width
                GuardaAncho = .Height
                GuardaAncho = .Width
            End With
            Teclado.Text = ElArchivoConExtension
            Exit Sub
        End If
        If Me.Height >= Screen.PrimaryScreen.Bounds.Height / 6 Then
            With Me
                '.Top = 0
                '.Left = 0
                '.Height = Menú.Height * 2
                .ControlBox = True
                '.Text = "Anotador " & ElArchivo
                .Text = "Anotador " & DirectorioActual & ElArchivoConExtension
                '.MaximizeBox = True
                '.MinimizeBox = True
                '.Height = Screen.PrimaryScreen.Bounds.Height
                '.Width = Screen.PrimaryScreen.Bounds.Width
                GuardaAncho = .Height
                GuardaAncho = .Width
            End With
            Teclado.Text = ElArchivoConExtension
        End If

        If Me.WindowState = FormWindowState.Maximized Then Me.WindowState = FormWindowState.Normal


        With Me
            ' .Top = 0
            '.Left = 0
            .Width = .Width * 1.3
            .Height = .Width / 4 * 3
            GuardaAncho = .Height
            GuardaAncho = .Width
        End With
        If Me.Height >= Screen.PrimaryScreen.Bounds.Height Or Me.Width >= Screen.PrimaryScreen.Bounds.Width Then
            With Me
                .Top = 0
                .Left = 0
                .Height = Screen.PrimaryScreen.Bounds.Height
                .Width = Screen.PrimaryScreen.Bounds.Width
                GuardaAlto = .Height
                GuardaAncho = .Width
                GuardaTop = .Top
                GuardaLeft = .Left
            End With
        End If



    End Sub
    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeMenu.Click
        FormAcercaDe.Show()
        FormAcercaDe.TopMost = True
    End Sub
    Private Sub MenuTransparencia60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuTransparencia60.Click
        TextoInicial("")
        Me.Opacity = 0.4
        Teclado.Opacity = 0.4
        Director.Opacity = 0.4
        CheckedTransparencia(MenuTransparencia60)
    End Sub
    Private Sub CheckedTransparencia(ByVal cual As Object)
        MenuTransparencia00.Checked = False
        MenuTransparencia10.Checked = False
        MenuTransparencia20.Checked = False
        MenuTransparencia30.Checked = False
        MenuTransparencia40.Checked = False
        MenuTransparencia50.Checked = False
        MenuTransparencia60.Checked = False
        MenuTransparencia70.Checked = False
        MenuTransparencia80.Checked = False

        If MenuTransparencia00 Is cual Then MenuTransparencia00.Checked = True
        If MenuTransparencia10 Is cual Then MenuTransparencia10.Checked = True
        If MenuTransparencia20 Is cual Then MenuTransparencia20.Checked = True
        If MenuTransparencia30 Is cual Then MenuTransparencia30.Checked = True
        If MenuTransparencia40 Is cual Then MenuTransparencia40.Checked = True
        If MenuTransparencia50 Is cual Then MenuTransparencia50.Checked = True
        If MenuTransparencia60 Is cual Then MenuTransparencia60.Checked = True
        If MenuTransparencia70 Is cual Then MenuTransparencia70.Checked = True
        If MenuTransparencia80 Is cual Then MenuTransparencia80.Checked = True
    End Sub
    Private Sub MenuTransparencia80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuTransparencia80.Click
        TextoInicial("")
        Me.Opacity = 0.2
        Teclado.Opacity = 0.2
        Director.Opacity = 0.2
        CheckedTransparencia(MenuTransparencia80)
    End Sub
    Private Sub MenuTransparencia40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuTransparencia40.Click
        TextoInicial("")
        Me.Opacity = 0.6
        Teclado.Opacity = 0.6
        Director.Opacity = 0.6
        CheckedTransparencia(MenuTransparencia40)
    End Sub
    Private Sub MenuTransparencia20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuTransparencia20.Click
        TextoInicial("")
        Me.Opacity = 0.8
        Teclado.Opacity = 0.8
        Director.Opacity = 0.8
        CheckedTransparencia(MenuTransparencia20)
    End Sub
    Private Sub MenuTransparencia10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuTransparencia10.Click
        TextoInicial("")
        Me.Opacity = 0.9
        Teclado.Opacity = 0.9
        Director.Opacity = 0.9
        CheckedTransparencia(MenuTransparencia10)
    End Sub
    Private Sub MenuTransparencia00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuTransparencia00.Click
        TextoInicial("")
        Me.Opacity = 1
        CheckedTransparencia(MenuTransparencia00)
    End Sub
    Private Sub OpacidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpacidadToolStripMenuItem.Click

    End Sub
    Private Sub MenuTransparencia30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuTransparencia30.Click
        TextoInicial("")
        Me.Opacity = 0.7
        Teclado.Opacity = 0.7
        Director.Opacity = 0.7
        CheckedTransparencia(MenuTransparencia30)
    End Sub
    Private Sub MenuTransparencia50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuTransparencia50.Click
        TextoInicial("")
        Me.Opacity = 0.5
        Teclado.Opacity = 0.5
        Director.Opacity = 0.5
        CheckedTransparencia(MenuTransparencia50)
    End Sub
    Private Sub ToolStripMenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub ToolStripMenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimizaMenu.Click
        Minimo()
    End Sub
    Public Sub Minimo()
        Posiciones00()
        If Me.Name <> "Anotador" Then Exit Sub
        FormAuxiliar.Visible = False
        Director.Visible = False
        Teclado.Visible = False
        FormIndice.Visible = False
        Posiciones00Menu.Checked = True
        Posiciones01Menu.Checked = False
        Posiciones02Menu.Checked = False
        Posiciones03Menu.Checked = False
        Posiciones04Menu.Checked = False
        Posiciones05Menu.Checked = False
        Posiciones06Menu.Checked = False
        Posiciones07Menu.Checked = False
    End Sub
    Public Sub Posiciones00()
        'PosicionesFormularios = 0
        With Me
            .Height = 10
            .Width = 20
            .BackColor = Texto.BackColor 'Color.FromArgb(0, 0, 255)
        End With

        MenuTablero.Visible = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.ControlBox = False
        Me.Text = ""
        Minimizado = True

        Posiciones00Menu.Checked = True
        Posiciones01Menu.Checked = False
        Posiciones02Menu.Checked = False
        Posiciones03Menu.Checked = False
        Posiciones04Menu.Checked = False
        Posiciones05Menu.Checked = False
        Posiciones06Menu.Checked = False
        Posiciones07Menu.Checked = False

    End Sub
    Private Sub ToolStripMenuItem16_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles MinimizaMenu.MouseHover

    End Sub
    Private Sub ToolStripMenuItem16_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MinimizaMenu.MouseMove

    End Sub
    Private Sub AbrirDirectorioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirDirectorioToolStripMenuItem.Click
        AbrirDirectorio(DirectorioActual)
    End Sub
    Public Sub AbrirDirectorio(ByVal Direccion As String)
        Me.TopMost = False
        Dim DirectorioAAbrir
        If Direccion <> "" Then
            DirectorioAAbrir = Direccion
        Else
            DirectorioAAbrir = Application.StartupPath
        End If
        'DirDeLaAplicación = Application.StartupPath
        Shell("explorer.exe root =" & DirectorioAAbrir, vbNormalFocus)

        'Shell("explorer.exe root = c:\Notas", vbNormalFocus)
        'Dim DirDeLaAplicación = Application.StartupPath
        'Shell("explorer.exe root =" & DirectorioAAbrir, vbNormalFocus)
    End Sub
    Public Sub AbrirDirectorioant()
        Me.TopMost = False
        Dim DirDeLaAplicación
        If DirectorioActual <> "" Then
            DirDeLaAplicación = DirectorioActual
        Else
            DirDeLaAplicación = Application.StartupPath
        End If

        'DirDeLaAplicación = Application.StartupPath
        Shell("explorer.exe root =" & DirDeLaAplicación, vbNormalFocus)


        'Shell("explorer.exe root = c:\Notas", vbNormalFocus)
        'Dim DirDeLaAplicación = Application.StartupPath
        Shell("explorer.exe root =" & DirDeLaAplicación, vbNormalFocus)
    End Sub
    Private Sub NuevoAnotadorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoAnotadorToolStripMenuItem.Click
        'Dim Proceso As New System.Diagnostics.Process
        'Proceso.StartInfo.FileName = "c:\Notas\anotador2.exe"
        'Proceso.Start()
        Dim DirDeLaAplicación = Application.StartupPath
        Dim Proceso As New System.Diagnostics.Process
        Proceso.StartInfo.FileName = DirDeLaAplicación & "\anotador.exe"
        Proceso.Start()
    End Sub
    Private Sub ToolStripMenuItem17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Colores1Menu.Click

    End Sub
    Private Sub ColorTeclado()
        Teclado.CambiaColorTeclado(TecladoColorFondo1, TecladoColorFondo2, TecladoColorFondo3, TecladoColorFondoListas, TecladoColorLetraTeclas, TecladoColorLetraListas)
    End Sub
    Private Sub SorteaColorTotal()
        TextoInicial("")
        Randomize()
        Dim PropiedadesDelColor As Color
        PropiedadesDelColor = SorteaColor()
        'Color.FromArgb(255, CInt(Math.Floor((255 - 0 + 1) * Rnd())) + 0, CInt(Math.Floor((255 - 0 + 1) * Rnd())) + 0, CInt(Math.Floor((255 - 0 + 1) * Rnd())) + 0) 

        ColorTransición = PropiedadesDelColor
        Dim ColorUno = ColorTransición
        Dim ColorDos As Color = ColorComplementarioClaro(ColorUno)




        If LetraOscura = False Then
            If SeparaFondoDeTransiciónColor = False Then
                Texto.BackColor = ColorUno
            Else
                Texto.BackColor = ColorFijoAsignadoAFondoTablero
            End If

            If SeparaLetraDeTransiciónColor = False Then
                Texto.ForeColor = ColorDos
            Else
                Texto.ForeColor = ColorFijoAsignadoALetraTablero
            End If
        Else
            If SeparaFondoDeTransiciónColor = False Then
                Texto.BackColor = ColorDos
            Else
                Texto.BackColor = ColorFijoAsignadoAFondoTablero
            End If

            If SeparaLetraDeTransiciónColor = False Then
                Texto.ForeColor = ColorUno
            Else
                Texto.ForeColor = ColorFijoAsignadoALetraTablero
            End If
        End If
        'Menú.BackColor = ColorDos
        'Menú.ForeColor = ColorUno




        ' PropiedadesDelColor = Color.FromArgb(255, CInt(Math.Floor((255 - 0 + 1) * Rnd())) + 0, CInt(Math.Floor((255 - 0 + 1) * Rnd())) + 0, CInt(Math.Floor((255 - 0 + 1) * Rnd())) + 0)

        ' PropiedadesDelColor = Color.FromArgb(255 - (Texto.BackColor.R / 4), 255 - (Texto.BackColor.G / 4), 255 - (Texto.BackColor.B / 4))




    End Sub
    Private Sub ToolStripMenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Randomize()
        Dim PropiedadesDelColor As Color
        PropiedadesDelColor = Color.FromArgb(255, CInt(Math.Floor((255 - 0 + 1) * Rnd())) + 0, CInt(Math.Floor((255 - 0 + 1) * Rnd())) + 0, CInt(Math.Floor((255 - 0 + 1) * Rnd())) + 0)

        Texto.ForeColor = PropiedadesDelColor
    End Sub
    Private Sub TimerBorraPrueba_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerBorraPrueba.Tick
        'If Texto.Text = "Prueba de Letra" Then Texto.Text = ""
        If Mid(Texto.Text, 1, 15) = "Prueba de Letra" Then Texto.Text = ""

        TimerBorraPrueba.Enabled = False

    End Sub
    Private Sub ToolStripMenuItem18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalMenu.Click
        PantallaCompleta = True
        With Me
            .MenuTablero.Visible = False
            .Top = 0
            .Left = 0
            .Width = Screen.PrimaryScreen.Bounds.Width
            .Height = Screen.PrimaryScreen.Bounds.Height
            .MaximizeBox = False
            .MinimizeBox = False
            .ControlBox = False
            .Text = ""

        End With
        With Texto
            .Top = 0
            .Left = 0
            .Width = Me.Width - 10
            .Height = Me.Height
        End With
        PantallaCompleta = False
        QuitaCabecera()
        If Teclado.Visible = True Then Teclado.TopMost = True

    End Sub
    Private Sub TimerColor01_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerColor01.Tick
        Randomize()
        Dim PropiedadesDelColor As Color
        Dim ColorRojo As Decimal
        'Dim ColorVerde As Decimal
        'Dim ColorAzul As Decimal
        Dim Tendencia As Byte
        Dim ColorCambia As Byte
        Tendencia = CInt(Math.Floor((1 - 0 + 1) * Rnd())) + 0
        ColorCambia = CInt(Math.Floor((3 - 0 + 1) * Rnd())) + 1

        Select Case ColorCambia
            Case Is = 1
                ColorRojo = Texto.BackColor.R
            Case Is = 2
            Case Is = 3

        End Select
        PropiedadesDelColor = Color.FromArgb(255, CInt(Math.Floor((255 - 0 + 1) * Rnd())) + 0, CInt(Math.Floor((255 - 0 + 1) * Rnd())) + 0, CInt(Math.Floor((255 - 0 + 1) * Rnd())) + 0)

        Texto.BackColor = PropiedadesDelColor
        ColorÚnicoAnterior = Texto.BackColor

        PropiedadesDelColor = Color.FromArgb(255, CInt(Math.Floor((255 - 0 + 1) * Rnd())) + 0, CInt(Math.Floor((255 - 0 + 1) * Rnd())) + 0, CInt(Math.Floor((255 - 0 + 1) * Rnd())) + 0)

        Texto.ForeColor = PropiedadesDelColor
    End Sub
    Private Sub TransiciónDeColorPaso()
        CantiPasosColor = 20
        NumPasoColor = NumPasoColor + 1

        If NumPasoColor = CantiPasosColor Then
            NumPasoColor = 0
            ColorÚnicoAnterior = ColorÚnicoPlus
            ' ----------------------- ACÁ VA AL SORTEO DEL NUEVO COLORPLUS
            ColorÚnicoPlus = SorteaColor()
            ' -----------------------
        End If


        Dim CanalTrans As Decimal
        Dim CanalPlus As Decimal
        CanalTrans = ColorÚnicoAnterior.R
        CanalPlus = ColorÚnicoPlus.R
        Dim DiferenciaPrimeraRojo As Decimal = CanalPlus - CanalTrans
        CanalTrans = ColorÚnicoAnterior.G
        CanalPlus = ColorÚnicoPlus.G
        Dim DiferenciaPrimeraVerde As Decimal = CanalPlus - CanalTrans
        CanalTrans = ColorÚnicoAnterior.B
        CanalPlus = ColorÚnicoPlus.B
        Dim DiferenciaPrimeraAzul As Decimal = CanalPlus - CanalTrans

        Dim AmplitudPasoRojo = DiferenciaPrimeraRojo / CantiPasosColor '- 0.01
        Dim AmplitudPasoVerde = DiferenciaPrimeraVerde / CantiPasosColor ' - 0.01
        Dim AmplitudPasoAzul = DiferenciaPrimeraAzul / CantiPasosColor '- 0.01

        Dim RojoCambiado As Decimal = ColorTransición.R + AmplitudPasoRojo
        If RojoCambiado > 255 Then RojoCambiado = 255
        If RojoCambiado < 0 Then RojoCambiado = 0
        Dim VerdeCambiado As Decimal = ColorTransición.G + AmplitudPasoVerde
        If VerdeCambiado > 255 Then VerdeCambiado = 255
        If VerdeCambiado < 0 Then VerdeCambiado = 0
        Dim AzulCambiado As Decimal = ColorTransición.B + AmplitudPasoAzul
        If AzulCambiado > 255 Then AzulCambiado = 255
        If AzulCambiado < 0 Then AzulCambiado = 0

        ColorTransición = Color.FromArgb(PorcientoGama, RojoCambiado, VerdeCambiado, AzulCambiado)
        ' Texto.Text = "Paso " & NumPasoColor & " " & RojoCambiado & " " & VerdeCambiado & " " & AzulCambiado & " " & Texto.Text

        Dim ColorUno = ColorTransición
        Dim ColorDos As Color = ColorComplementarioClaro(ColorUno)


        If LetraOscura = False Then
            If SeparaFondoDeTransiciónColor = False Then
                Texto.BackColor = ColorUno
            Else
                Texto.BackColor = ColorFijoAsignadoAFondoTablero
            End If

            If SeparaLetraDeTransiciónColor = False Then
                Texto.ForeColor = ColorDos
            Else
                Texto.ForeColor = ColorFijoAsignadoALetraTablero
            End If
        Else
            If SeparaFondoDeTransiciónColor = False Then
                Texto.BackColor = ColorDos
            Else
                Texto.BackColor = ColorFijoAsignadoAFondoTablero
            End If

            If SeparaLetraDeTransiciónColor = False Then
                Texto.ForeColor = ColorUno
            Else
                Texto.ForeColor = ColorFijoAsignadoALetraTablero
            End If
        End If
        ' Menú.BackColor = ColorDos
        ' Menú.ForeColor = ColorUno










        ' If LetraOscura = False Then
        ' Texto.BackColor = ColorUno
        ' Texto.ForeColor = ColorDos

        ' Else
        '  Texto.BackColor = ColorDos
        ' Texto.ForeColor = ColorUno
        ' End If
        ' Menú.BackColor = ColorDos
        'Menú.ForeColor = ColorUno

    End Sub

    Public Function SorteaColor()
        Randomize()
        Dim PropiedadesDelColor As Color
        'randomValue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound

        PropiedadesDelColor = Color.FromArgb(PorcientoGama, CInt(Math.Floor((255 - 200 + 1) * Rnd())) + 200, CInt(Math.Floor((255 - 200 + 1) * Rnd())) + 200, CInt(Math.Floor((255 - 200 + 1) * Rnd())) + 200)
        'PropiedadesDelColor = Color.FromArgb(CInt(Math.Floor((255 - 200 + 1) * Rnd())) + 200, CInt(Math.Floor((255 - 200 + 1) * Rnd())) + 200, CInt(Math.Floor((255 - 0 + 1) * Rnd())) + 0, CInt(Math.Floor((255 - 0 + 1) * Rnd())) + 0)
        'PortaColor = PropiedadesDelColor
        Return (PropiedadesDelColor)
    End Function
    Private Sub ToolStripMenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem19.Click
        If ToolStripMenuItem19.Checked = True Then
            ToolStripMenuItem19.Checked = False
            SorteaAleacolorTrans = False
        Else
            ToolStripMenuItem19.Checked = True
            ToolStripMenuItem20.Checked = False
            SorteaAleacolorTrans = True
            SeparaLetraDeTransiciónColor = False
            SeparaFondoDeTransiciónColor = False
            ColorFijoAsignadoALetraTablero = Color.White
            ColorÚnicoAnterior = Texto.BackColor
            ColorÚnicoPlus = Texto.BackColor
            ColorTransición = Texto.BackColor ' Color.FromArgb(255, 100, 15, 95)
            Texto.ForeColor = Color.White
        End If
        LetraOscura = False
    End Sub
    Private Sub ToolStripMenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem20.Click
        If ToolStripMenuItem20.Checked = True Then
            ToolStripMenuItem20.Checked = False
            SorteaAleacolorTrans = False
            LetraOscura = False
        Else
            ToolStripMenuItem20.Checked = True
            ToolStripMenuItem19.Checked = False
            SorteaAleacolorTrans = True
            LetraOscura = True
            SeparaLetraDeTransiciónColor = False
            SeparaFondoDeTransiciónColor = False


        End If
    End Sub

    Private Sub ToolStripMenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem21.Click

    End Sub

    Private Sub ToolStripMenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem23.Click
        FórmulaComplementaria = 1
    End Sub

    Private Sub ToolStripMenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem24.Click
        FórmulaComplementaria = 2
    End Sub

    Private Sub ToolStripMenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem25.Click
        FórmulaComplementaria = 3
    End Sub

    Private Sub ToolStripMenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem26.Click
        FórmulaComplementaria = 4
    End Sub

    Private Sub ToolStripMenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem27.Click
        FórmulaComplementaria = 5
    End Sub

    Private Sub ToolStripMenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem28.Click
        FórmulaComplementaria = 6
    End Sub

    Private Sub TimerMouseDown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerMouseDown.Tick
        TransiciónDeColorPaso()
    End Sub



    Private Sub Texto_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Public Sub AnalizaCadena(ByVal CadenaCalculoAAnalizar, ByVal LargoCadenaCalculoAAnalizar, ByVal PosiciónOrigendelacadena)
        On Error Resume Next
        Dim Operando(10) As String
        Dim OperandoAnterior As Boolean = True
        Dim NúmeroOperando As Integer = 1
        Dim Operador(10) As String
        Dim NúmeroOperador As Integer = 0
        Dim PosiciónDeTrabajo As Integer = 0
        Dim CaracterAAnalizar As String
        Dim OperandoNumerico1 As Decimal = 0
        Dim OperandoNumerico2 As Decimal = 0
        Dim ResultadoNumerico As Decimal = 0
        For conta = 1 To LargoCadenaCalculoAAnalizar
            CaracterAAnalizar = CadenaCalculoAAnalizar.Substring(PosiciónDeTrabajo, 1)
            If CaracterAAnalizar <> "+" And CaracterAAnalizar <> "-" And CaracterAAnalizar <> "×" And CaracterAAnalizar <> "*" And CaracterAAnalizar <> "÷" And CaracterAAnalizar <> "/" And CaracterAAnalizar <> "=" Or CaracterAAnalizar = "-" And OperandoAnterior = True Then
                If CaracterAAnalizar = "," Then CaracterAAnalizar = "."
                Operando(NúmeroOperando) = Operando(NúmeroOperando) & CaracterAAnalizar

                PosiciónDeTrabajo = PosiciónDeTrabajo + 1
                OperandoAnterior = False
            Else
                NúmeroOperador = NúmeroOperador + 1
                Operador(NúmeroOperador) = CaracterAAnalizar
                NúmeroOperando = NúmeroOperando + 1
                PosiciónDeTrabajo = PosiciónDeTrabajo + 1
                OperandoAnterior = True
            End If
        Next
        'Hace las operaciones
        For Operación = 1 To NúmeroOperador
            If Operación = 1 Then ResultadoNumerico = Val(Operando(1))
            ' OperandoNumerico1 = Val(Operando(Operación))
            OperandoNumerico2 = Val(Operando(Operación + 1))
            Select Case Operador(Operación)
                Case Is = "+"
                    ResultadoNumerico = ResultadoNumerico + OperandoNumerico2
                Case Is = "-"
                    ResultadoNumerico = ResultadoNumerico - OperandoNumerico2
                Case Is = "-"
                    ResultadoNumerico = ResultadoNumerico - OperandoNumerico2
                Case Is = "×"
                    ResultadoNumerico = ResultadoNumerico * OperandoNumerico2
                Case Is = "*"
                    ResultadoNumerico = ResultadoNumerico * OperandoNumerico2
                Case Is = "÷"
                    ResultadoNumerico = ResultadoNumerico / OperandoNumerico2
                Case Is = "/"
                    ResultadoNumerico = ResultadoNumerico / OperandoNumerico2
                Case Is = "="
                    ResultadoNumerico = ResultadoNumerico

            End Select
        Next

        CadenaResultado = Str(ResultadoNumerico)

        CadenaResultado = CadenaResultado.Replace(".", ",")
        CadenaCalculoAAnalizar = CadenaCalculoAAnalizar & CadenaResultado
        LargoCadenaResultado = Len(CadenaResultado)
        CadenaOperacionYResultado = CadenaCalculoAAnalizar
        ' Exit Sub

        'paraerror:
        '' CadenaResultado = "error"
        ' LargoCadenaResultado = Len(CadenaResultado)
        ' CadenaOperacionYResultado = CadenaCalculoAAnalizar
        '        Resume Next

    End Sub




    Private Sub Texto_MouseUp1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        TimerMouseDown.Enabled = False
    End Sub

    Private Sub Texto_TextChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ArchivoGuardado = False
    End Sub

    Private Sub LeerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub TimerVoz_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub DisponerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub OtraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripMenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripMenuItem22_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem22.Click
        'With Me
        '.Height = 10
        ' .Width = 20
        '.BackColor = Texto.BackColor 'Color.FromArgb(0, 0, 255)
        'End With
        QuitaCabecera()
    End Sub
    Private Sub QuitaCabecera()
        SinCabecera = True
        MenuTablero.Visible = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.ControlBox = False

        'Me.Icon = Nothing
        Me.Text = Nothing
        MenuTablero.Visible = False
        With Texto
            .Top = 0
            .Left = 0
            .Width = Me.Width - 8
            .Height = Me.Height
        End With
        SinCabecera = True
    End Sub
    Private Sub PosiciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TableroMenu.Click

    End Sub

    Private Sub Menú_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuTablero.ItemClicked

    End Sub

    Private Sub TimerHora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerHora.Tick
        If Minimizado = False And SinCabecera = False Then
            TitulaAnotadorYTeclado()
            'Me.Text = DirectorioActual & "\" & ElArchivoConExtension & "  • • •  " & Fechora()
            'Teclado.Text = ElArchivoConExtension
        End If
    End Sub
    Private Sub TitulaAnotadorYTeclado()
        Me.Text = DirectorioActual & "\" & ElArchivoConExtension & "  • • • • • •  " & Fechora() & Me.Name
        Teclado.Text = ElArchivoConExtension
    End Sub

    Private Sub InsertarFechaYHoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarFechaYHoraToolStripMenuItem.Click

        PosiciónDeInicio = Texto.SelectionStart
        Dim TextoAnterior = Texto.Text.Substring(0, PosiciónDeInicio)

        Dim TextoPosterior = Texto.Text.Substring(PosiciónDeInicio, Texto.Text.Length() - PosiciónDeInicio)
        Texto.Text = TextoAnterior & NombreFechaLarga() & TextoPosterior
        Texto.SelectionStart = Len(TextoAnterior) + Len(NombreFechaLarga())
        Texto.ScrollToCaret()
        'NombreFechaLarga()
        'Fechora()

        'Texto.Text = TextoAnterior & NombreFechaLarga() & TextoPosterior
        ' Clipboard.SetDataObject(NombreFechaLarga())
    End Sub

    Private Sub TimerResguardo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerResguardo.Tick
        HaceReaseguro()
    End Sub
    Private Sub HaceReaseguro()
        '       If ElArchivo = "" Then
        'ElArchivo = "C:\Notas\" & NombreFechaLargaDeOrigen
        ' End If
        Dim CadenaParaReaseguro As String
        If ReasegurarEnDirectorioActual = True Then
            CadenaParaReaseguro = DirectorioActual & "\" & ElArchivo
        Else
            CadenaParaReaseguro = "C:\Notas\Reaseguros\" & ElArchivo
        End If
        'CadenaParaReaseguro = CadenaParaReaseguro.Substring(0, CadenaParaReaseguro.Length() - 4)
        ' le saca a la cadena para reaseguro el .txt"
        Dim NombreReaseguro = CadenaParaReaseguro + "-Reaseguro.txt"
        FileOpen(1, NombreReaseguro, OpenMode.Output)
        Print(1, Texto.Text)
        FileClose(1)
        'ArchivoGuardado = True
    End Sub
    Private Sub FechaYHoraAlPortapapelesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FechaYHoraAlPortapapelesToolStripMenuItem.Click
        Clipboard.SetDataObject(NombreFechaLarga())
    End Sub

    Private Sub ToolStripMenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormMenu.Click

    End Sub

    Private Sub FijaTimerMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ApagaTimerMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub OcultaCuadroTimerMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub OcultaCuadroTimerMenu_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorMenu.Click

    End Sub

    Private Sub ToolStripMenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Colores3Menu.Click

    End Sub

    Private Sub ToolStripMenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Colores2Menu.Click

    End Sub

    Private Sub Texto_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Texto.DoubleClick
        'Minimizado = False
        SinCabecera = False
        MenuTablero.Visible = True
        Texto.Left = 2
        Texto.Top = MenuTablero.Height
    End Sub

    Private Sub Texto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Texto.GotFocus

        'If Teclado.Visible = True Then Teclado.TopMost = True
        'Texto.Focus()
        'If Director.Visible = True Then Director.TopMost = True
        'Texto.Focus()
    End Sub

    Private Sub Texto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Texto.KeyDown
        On Error Resume Next
        If Texto.SelectionStart = 0 Then Exit Sub
        If SorteaAleacolorTrans = True Then
            TransiciónDeColorPaso()

            'CambiaColorLetra()
        End If
        If e.KeyCode = 13 Then ' 32 Then 'essp'13 Then ' Al poner Enter

            If Texto.Text.Substring(Texto.SelectionStart - 1, 1) = "=" Then
                Calcula()
            End If
        End If
        Exit Sub
ParaError:
        CadenaResultado = "error en la operación "
    End Sub
    Public Sub Calcula()
        PosiciónDeInicio = Texto.SelectionStart ' da la posición actual
        Dim PosiciónOrigendelacadena As Integer
        Dim TextoAnterior = Texto.Text.Substring(0, PosiciónDeInicio)
        'Texto.SelectionStart = PosiciónActual
        'Dim TextoAnterior = Texto.Text.Substring(1, PosiciónActual - 1)
        Dim LargoTotalTexto = Texto.Text.Length()
        Dim TextoPosterior = Texto.Text.Substring(PosiciónDeInicio, Texto.Text.Length() - PosiciónDeInicio)
        Dim CaracterAAnalizar As String
        'Dim Textointroducido As String = ""
        Dim operando(20) As String
        Dim CadenaCalculoAAnalizar As String = ""
        Dim LargoCadenaCalculoAAnalizar As Integer
        Dim LugarDeBúsqueda As Integer
        If PosiciónDeInicio = 0 Then Exit Sub
        If Texto.Text.Substring(PosiciónDeInicio - 1, 1) = "=" Then
            'e.Handled = True
            ' busca primero el anterior enter o el nro cero
            For Busca = 1 To 50
                ' Dim charbusca = Str(Busca)
                LugarDeBúsqueda = PosiciónDeInicio - Busca
                CaracterAAnalizar = Texto.Text.Substring(PosiciónDeInicio - Busca, 1)
                CadenaCalculoAAnalizar = CaracterAAnalizar + CadenaCalculoAAnalizar
                If CaracterAAnalizar = Chr(13) Or LugarDeBúsqueda = 0 Then
                    If CaracterAAnalizar = Chr(13) Then
                        CadenaCalculoAAnalizar = CadenaCalculoAAnalizar.Remove(0, 2)
                    End If
                    LargoCadenaCalculoAAnalizar = Len(CadenaCalculoAAnalizar)
                    PosiciónOrigendelacadena = PosiciónDeInicio - Busca + 2

                    AnalizaCadena(CadenaCalculoAAnalizar, LargoCadenaCalculoAAnalizar, PosiciónOrigendelacadena)
                    Busca = Busca 'tiempo
                    GoTo Sale
                End If
            Next
Sale:
            TextoAnterior = TextoAnterior.Remove(Len(TextoAnterior) - LargoCadenaCalculoAAnalizar, LargoCadenaCalculoAAnalizar)
            'Texto.Text = " " + TextoAnterior + Textointroducido + TextoPosterior
            'Textointroducido = CadenaOperacionYResultado '"(encontré el 13)" + " "
            Texto.Text = TextoAnterior + CadenaOperacionYResultado + TextoPosterior
            TextoDepurado = Texto.Text.Substring(0, Texto.Text.Length())
            LargoCadenaOperaciónYResultado = Len(CadenaOperacionYResultado)
            TextoGuardado = True
            'Texto.Text = TextoDepurado
        End If



        Texto.SelectionStart = Len(TextoAnterior) + Len(CadenaOperacionYResultado)
        Texto.ScrollToCaret()
    End Sub

    Private Sub Texto_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Texto.KeyUp
        'Texto.Text.Remove(Texto.SelectionStart, -1)
        'Texto.Text.Insert(Texto.SelectionStart, "   ")
        ' Exit Sub
        If TextoGuardado = True Then
            Texto.Text = TextoDepurado
            Texto.SelectionStart = PosiciónDeInicio + LargoCadenaResultado
            TextoGuardado = False
            Texto.ScrollToCaret()
            Texto.Focus()

        End If
    End Sub
    Private Sub Texto_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Texto.MouseDown
        If SorteaAleacolorTrans = True Then
            TimerMouseDown.Enabled = True
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Teclado.CheckConShift.Checked = True Then
                'Dim tomavalorvertical = ScrollBars.Vertical
                'Teclado.Pega(Texto.SelectedText)
                'Texto.SelectionLength = 0
                'Dim tomavalorvertical = Texto.ScrollBars
                'Texto.ScrollBars = ScrollBars.Vertical

                'Texto.ScrollBars = tomavalorvertical
                'SendKeys.Send("{" & LetraElegida & "}")
                'SendKeys.Send(LetraElegida)
                'SendKeys.Send("a")
            End If
        End If
    End Sub

    Private Sub Texto_MouseMove2(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Texto.MouseMove
        If SorteaAleacolorTrans = True Then
            LLenoMouseMoveColor = 20
            CantidadDeMouseMoveColor = CantidadDeMouseMoveColor + 1
            If CantidadDeMouseMoveColor = LLenoMouseMoveColor Then
                CantidadDeMouseMoveColor = 0
                TransiciónDeColorPaso()
                'CambiaColorLetra()
            End If

        End If
    End Sub

    Private Sub Texto_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Texto.MouseUp
        TimerMouseDown.Enabled = False
        If Teclado.CheckConShift.Checked = True Then
            Teclado.Pega(Texto.SelectedText)
            Texto.SelectionLength = 0
        End If
        If FormAuxiliar.CheckAcento.Checked = True Then
            Acentuar()
        End If
        If FormAuxiliar.CheckMay1.Checked = True Then
            ConvertirMayusculasMinusculas(Texto.SelectedText, True)
        End If
        If FormAuxiliar.CheckMay2.Checked = True Then
            ConvertirMayusculasIniciales()
        End If
        If FormAuxiliar.CheckMin.Checked = True Then
            ConvertirMayusculasMinusculas(Texto.SelectedText, False)
        End If
    End Sub

    Private Sub Texto_TextChanged_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Texto.TextChanged
        ArchivoGuardado = False
    End Sub

    Private Sub ReduceCuadroTimerMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TimerMinutosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripMenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub MuestraOcultaTeclado()
        If Teclado.Visible = False Then
            Teclado.Visible = True
            FormularioActivo(2) = True
            'Teclado.Left = Me.Left + Me.Width - Teclado.Width
            'Teclado.Top = Screen.PrimaryScreen.Bounds.Top
            'Teclado.Left = Screen.PrimaryScreen.Bounds.Width - Teclado.Width
            Teclado.TopMost = True
            Me.Focus()
        Else
            Teclado.Visible = False
            FormularioActivo(2) = False
        End If
    End Sub
    Private Sub MuestraOcultaDirector()
        If Director.Visible = False Then
            Director.Visible = True
            FormularioActivo(4) = True
            'Director.Left = Screen.PrimaryScreen.Bounds.Width - Director.Width
            'Director.Top = Teclado.Top + Teclado.Height
            Director.TopMost = True
            Me.Focus()
        Else
            Director.Visible = False
            FormularioActivo(4) = False
        End If
    End Sub
    Public Sub MuestraOcultaInforme()
        If FormInforme.Visible = False Then
            FormInforme.Visible = True
            FormInforme.Left = 1 ' Screen.PrimaryScreen.Bounds.Width - Director.Width
            FormInforme.Top = Screen.PrimaryScreen.Bounds.Height - FormInforme.Height  'Teclado.Top + Teclado.Height
            FormInforme.TopMost = True
            FormInforme.Informa("Procedimiento de apertura del formulario de informe")
        Else
            FormInforme.Visible = False
        End If
    End Sub
    Private Sub MuestraOcultaIndice()
        If FormIndice.Visible = False Then
            FormIndice.Visible = True
            FormularioActivo(5) = True
            FormIndice.Left = 1 ' Screen.PrimaryScreen.Bounds.Width - Director.Width
            FormIndice.Top = 1 'Teclado.Top + Teclado.Height
            FormIndice.TopMost = True
        Else
            FormIndice.Visible = False
            FormularioActivo(5) = False
        End If
    End Sub
    Private Sub MuestraOcultaAuxiliar()
        If FormAuxiliar.Visible = False Then
            FormAuxiliar.Visible = True
            FormularioActivo(3) = True
            'FormAuxiliar.Left = Screen.PrimaryScreen.Bounds.Width - FormAuxiliar.Width
            'FormAuxiliar.Top = Screen.PrimaryScreen.Bounds.Top 'Teclado.Top + Teclado.Height
            FormAuxiliar.TopMost = True
        Else
            FormAuxiliar.Visible = False
            FormularioActivo(3) = False
        End If
    End Sub

    Private Sub ToolStripMenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem30.Click
        AbrirDocumentoExistente(DirectorioActual)
    End Sub

    Private Sub ToolStripMenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MuestraTecladoMenu.Click
    End Sub
    Private Sub ToolStripMenuItem33_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MuestraTecladoMenu.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MuestraOcultaTeclado()
        Else
            If MuestraOcultaFormularios = False Then
                MuestraOcultaFormularios = True
                If FormularioActivo(2) = True Then Teclado.Visible = True
                If FormularioActivo(3) = True Then FormAuxiliar.Visible = True
                If FormularioActivo(4) = True Then Director.Visible = True
                If FormularioActivo(5) = True Then FormIndice.Visible = True
                Me.Focus()
            Else
                MuestraOcultaFormularios = False
                Teclado.Visible = False
                FormAuxiliar.Visible = False
                Director.Visible = False
                FormIndice.Visible = False
                Me.Focus()
            End If
            Exit Sub



            If Teclado.Visible = False Then
                Director.Visible = True
                FormAuxiliar.Visible = True
                FormIndice.Visible = True
                Teclado.Visible = True
            Else
                Director.Visible = False
                FormAuxiliar.Visible = False
                FormIndice.Visible = False
                Teclado.Visible = False
            End If


            'MuestraOcultaDirector()
            ' Me.Visible = False
        End If
    End Sub

    Private Sub TecladoColorFondoTeclas1Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TecladoColorFondoTeclas1Menu.Click
        ColorDialog1.Color = TecladoColorFondo1
        ColorDialog1.ShowDialog()
        TecladoColorFondo1 = ColorDialog1.Color
        Teclado.CambiaColorTeclado(TecladoColorFondo1, TecladoColorFondo2, TecladoColorFondo3, TecladoColorFondoListas, TecladoColorLetraTeclas, TecladoColorLetraListas)
    End Sub

    Private Sub TecladoColorLetrasMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TecladoColorLetrasMenu.Click
        ColorDialog1.Color = TecladoColorLetraTeclas
        ColorDialog1.ShowDialog()
        TecladoColorLetraTeclas = ColorDialog1.Color
        Teclado.CambiaColorTeclado(TecladoColorFondo1, TecladoColorFondo2, TecladoColorFondo3, TecladoColorFondoListas, TecladoColorLetraTeclas, TecladoColorLetraListas)
    End Sub

    Private Sub TecladoColorFondoTeclas2Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TecladoColorFondoTeclas2Menu.Click
        ColorDialog1.Color = TecladoColorFondo2
        ColorDialog1.ShowDialog()
        TecladoColorFondo2 = ColorDialog1.Color
        Teclado.CambiaColorTeclado(TecladoColorFondo1, TecladoColorFondo2, TecladoColorFondo3, TecladoColorFondoListas, TecladoColorLetraTeclas, TecladoColorLetraListas)

    End Sub

    Private Sub TecladoColorFondoTeclas3Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TecladoColorFondoTeclas3Menu.Click
        ColorDialog1.Color = TecladoColorFondo3
        ColorDialog1.ShowDialog()
        TecladoColorFondo3 = ColorDialog1.Color
        Teclado.CambiaColorTeclado(TecladoColorFondo1, TecladoColorFondo2, TecladoColorFondo3, TecladoColorFondoListas, TecladoColorLetraTeclas, TecladoColorLetraListas)

    End Sub

    Private Sub TecladoColorGris_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TecladoColorGris.Click
        TecladoColorFondo1 = Color.FromArgb(255, 245, 245, 245)
        TecladoColorFondo2 = Color.FromArgb(255, 234, 234, 234)
        TecladoColorFondo3 = Color.FromArgb(255, 211, 211, 211)
        TecladoColorFondoListas = Color.FromArgb(255, 255, 255, 255)
        TecladoColorLetraTeclas = Color.Black
        Teclado.CambiaColorTeclado(TecladoColorFondo1, TecladoColorFondo2, TecladoColorFondo3, TecladoColorFondoListas, TecladoColorLetraTeclas, TecladoColorLetraListas)
    End Sub

    Private Sub TecladoColorNegro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TecladoColorNegro.Click
        TecladoColorFondo1 = Color.FromArgb(255, 0, 0, 0)
        TecladoColorFondo2 = Color.FromArgb(255, 80, 80, 80)
        TecladoColorFondo3 = Color.FromArgb(255, 120, 120, 120)
        TecladoColorFondoListas = Color.FromArgb(255, 0, 0, 0)
        TecladoColorLetraTeclas = Color.White
        Teclado.CambiaColorTeclado(TecladoColorFondo1, TecladoColorFondo2, TecladoColorFondo3, TecladoColorFondoListas, TecladoColorLetraTeclas, TecladoColorLetraListas)

    End Sub

    Private Sub TecladoColorCopia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TecladoColorCopia.Click
        TecladoColorFondo1Res = TecladoColorFondo1
        TecladoColorFondo2Res = TecladoColorFondo2
        TecladoColorFondo3Res = TecladoColorFondo3
        TecladoColorFondoListasRes = TecladoColorFondoListas
        TecladoColorLetraRes = TecladoColorLetraTeclas
    End Sub

    Private Sub TecladoColorRestaura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TecladoColorRestaura.Click
        TecladoColorFondo1 = TecladoColorFondo1Res
        TecladoColorFondo2 = TecladoColorFondo2Res
        TecladoColorFondo3 = TecladoColorFondo3Res
        TecladoColorFondoListas = TecladoColorFondoListasRes
        TecladoColorLetraTeclas = TecladoColorLetraRes
        Teclado.CambiaColorTeclado(TecladoColorFondo1, TecladoColorFondo2, TecladoColorFondo3, TecladoColorFondoListas, TecladoColorLetraTeclas, TecladoColorLetraListas)

    End Sub

    Private Sub TecladoColorPredeterminadoMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TecladoColorPredeterminadoMenu.Click
        TecladoColorPredeterminado()
    End Sub

    Private Sub TecladoColorTomaDeTablero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TecladoColorTomaDeTablero.Click
        'TecladoColorFondo1 = ColorFijoAsignadoAFondo
        'TecladoColorFondo2 = ColorFijoAsignadoAFondo
        'TecladoColorFondo3 = ColorFijoAsignadoAFondo
        'TecladoColorFondoListas = ColorFijoAsignadoAFondo
        'TecladoColorLetra = ColorFijoAsignadoALetra
        'Teclado.CambiaColorTeclado(TecladoColorFondo1, TecladoColorFondo2, TecladoColorFondo3, TecladoColorFondoListas, TecladoColorLetra)
        TecladoColorFondo3 = MenuTablero.BackColor
        TecladoColorFondo1 = Texto.BackColor
        TecladoColorFondo2 = Texto.BackColor
        TecladoColorFondoListas = Texto.BackColor
        TecladoColorLetraTeclas = Texto.ForeColor
        Teclado.CambiaColorTeclado(TecladoColorFondo1, TecladoColorFondo2, TecladoColorFondo3, TecladoColorFondoListas, TecladoColorLetraTeclas, TecladoColorLetraListas)

    End Sub

    Private Sub ToolStripMenuItem17_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Colores1Menu.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            DeterminaColorFacil()
            ColorFijoAsignadoAFondoTablero = ColorFondoTablero
            ColorFijoAsignadoALetraTablero = ColorLetraTablero
            Texto.BackColor = ColorFondoTablero
            Texto.ForeColor = ColorLetraTablero
            TextoInicial(Str(NumeroColorFacil))

        Else
            DeterminaColorFacil()
            TecladoColorFondo1 = ColorFondoTablero
            TecladoColorFondo2 = ColorFondoTablero
            TecladoColorFondo3 = ColorFondoTablero
            TecladoColorLetraTeclas = ColorLetraTablero
            ColorTeclado()
        End If
    End Sub

    Private Sub SorteaColoresFondoClaroMenu_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Colores3Menu.MouseDown
        'Sortea Colores de fondo claros

        If e.Button = Windows.Forms.MouseButtons.Left Then
            ColorFondoTablero = SorteaColorClaro()
            MenuTablero.BackColor = SorteaColorClaro()
            MenuTablero.ForeColor = SorteaColorOscuro()
            ColorLetraTablero = SorteaColorOscuro()

            ColorFijoAsignadoAFondoTablero = ColorFondoTablero
            ColorFijoAsignadoAFondoMenuTablero = MenuTablero.BackColor
            Texto.BackColor = ColorFondoTablero
            Texto.ForeColor = ColorLetraTablero
            TextoInicial(" Color fondo aleatorio")
        Else
            SorteaColorFondo()
            TecladoColorFondo1 = SorteaColorClaro()
            SorteaColorFondo()
            TecladoColorFondo2 = SorteaColorClaro()
            SorteaColorFondo()
            TecladoColorFondo3 = SorteaColorClaro()
            TecladoColorLetraTeclas = SorteaColorOscuro()
            TecladoColorFondoListas = Color.White
            TecladoColorLetraListas = Color.Black
            ColorTeclado()
        End If
    End Sub

    Private Sub SorteaColoresFondoOscuroMenu_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Colores2Menu.MouseDown
        'Sortea Colores de fondo oscuros

        If e.Button = Windows.Forms.MouseButtons.Left Then
            ColorFondoTablero = SorteaColorOscuro()
            MenuTablero.BackColor = SorteaColorOscuro()
            MenuTablero.ForeColor = SorteaColorClaro()
            ColorLetraTablero = SorteaColorClaro()

            ColorFijoAsignadoAFondoTablero = ColorFondoTablero
            ColorFijoAsignadoAFondoMenuTablero = MenuTablero.BackColor
            Texto.BackColor = ColorFondoTablero
            Texto.ForeColor = ColorLetraTablero
            TextoInicial(" Color fondo aleatorio")
        Else
            TecladoColorFondo1 = SorteaColorOscuro()
            TecladoColorFondo2 = SorteaColorOscuro()
            TecladoColorFondo3 = SorteaColorOscuro()
            TecladoColorLetraTeclas = SorteaColorClaro()
            TecladoColorFondoListas = Color.White
            TecladoColorLetraListas = Color.Black
            ColorTeclado()
        End If
    End Sub




    Private Sub FuentesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuentesToolStripMenuItem.Click
        FontDialog1.Font = Texto.Font
        'FontDialog1.Color = ColorFijoAsignadoALetra
        FontDialog1.ShowDialog()
        Texto.Font = FontDialog1.Font
    End Sub

    Private Sub NegritaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NegritaToolStripMenuItem.Click
        Texto.Font = New Font(Texto.Font, FontStyle.Bold)
    End Sub

    Private Sub ToolStripMenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem35.Click
        Texto.Font = New Font(Texto.Font, FontStyle.Regular)
    End Sub

    Private Sub ToolStripMenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem36.Click
        Texto.Font = New Font(Texto.Font, FontStyle.Italic)
    End Sub

    Private Sub MonoespaciadaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonoespaciadaToolStripMenuItem.Click
        Texto.Font = New System.Drawing.Font("Courier New", Texto.Font.Size)
    End Sub

    Private Sub OtraToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtraToolStripMenuItem.Click
        Texto.Font = New System.Drawing.Font("Arial", Texto.Font.Size)
    End Sub

    Private Sub ToolStripMenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem37.Click
        Texto.Font = New Font(Texto.Font, FontStyle.Bold Or FontStyle.Italic)
    End Sub

    Private Sub PruebaAbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub ToolStripMenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem38.Click
        GuardarComoRecorte()
    End Sub




    Private Sub TecladoColorBlancoMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TecladoColorBlancoMenu.Click
        TecladoColorFondo1 = Color.FromArgb(255, 255, 255, 255)
        TecladoColorFondo2 = Color.FromArgb(255, 255, 255, 255)
        TecladoColorFondo3 = Color.FromArgb(255, 255, 255, 255)
        TecladoColorFondoListas = Color.FromArgb(255, 255, 255, 255)
        TecladoColorLetraTeclas = Color.Black
        Teclado.CambiaColorTeclado(TecladoColorFondo1, TecladoColorFondo2, TecladoColorFondo3, TecladoColorFondoListas, TecladoColorLetraTeclas, TecladoColorLetraListas)
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        ColorDialog1.Color = TecladoColorFondoListas
        ColorDialog1.ShowDialog()
        TecladoColorFondoListas = ColorDialog1.Color
        Teclado.CambiaColorTeclado(TecladoColorFondo1, TecladoColorFondo2, TecladoColorFondo3, TecladoColorFondoListas, TecladoColorLetraTeclas, TecladoColorLetraListas)
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)

    End Sub

    Private Sub Ayuda_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs)

    End Sub

    Private Sub TecladoCelesteMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TecladoCelesteMenu.Click
        TecladoColorFondo1 = Color.FromArgb(255, 225, 255, 255)
        TecladoColorFondo2 = Color.FromArgb(255, 124, 255, 255)
        TecladoColorFondo3 = Color.FromArgb(255, 225, 225, 255)
        TecladoColorFondoListas = Color.FromArgb(255, 255, 255, 255)
        TecladoColorLetraTeclas = Color.Black
        Teclado.CambiaColorTeclado(TecladoColorFondo1, TecladoColorFondo2, TecladoColorFondo3, TecladoColorFondoListas, TecladoColorLetraTeclas, TecladoColorLetraListas)

    End Sub

    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub ToolStripMenuItem60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem60.Click
        MenuTablero.BackColor = TecladoColorFondo3
        MenuTablero.ForeColor = TecladoColorLetraTeclas
        Texto.BackColor = TecladoColorFondo1
        Texto.ForeColor = TecladoColorLetraTeclas
    End Sub

    Private Sub ToolStripMenuItem31_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem31.Click
        ColorDialog1.Color = TecladoColorLetraListas
        ColorDialog1.ShowDialog()
        TecladoColorLetraListas = ColorDialog1.Color
        Teclado.CambiaColorTeclado(TecladoColorFondo1, TecladoColorFondo2, TecladoColorFondo3, TecladoColorFondoListas, TecladoColorLetraTeclas, TecladoColorLetraListas)

    End Sub

    Private Sub ToolStripMenuItem32_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem32.Click
        TextoInicial("")
        ColorDialog1.Color = MenuTablero.BackColor
        ColorDialog1.ShowDialog()
        TextoInicial("")
        MenuTablero.BackColor = ColorDialog1.Color
    End Sub

    Private Sub ToolStripMenuItem61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem61.Click
        TextoInicial("")
        ColorDialog1.Color = MenuTablero.ForeColor
        ColorDialog1.ShowDialog()
        TextoInicial("")
        MenuTablero.ForeColor = ColorDialog1.Color
    End Sub
    Public Sub BorraSeleccionado(ByVal Seleccionado As String)
        If AKeys = True Then
            'SendKeys.Send("{ENTER}")
            SendKeys.Send("{BACKSPACE}")
            Texto.ScrollToCaret()
            Texto.Focus()
            BorraAvanzaRetrocedeAuto = False
            TimerScrollBorraAuto.Enabled = True
            Exit Sub
            'LetraElegida
        End If
        PosiciónDeInicio = Texto.SelectionStart
        PosiciónDeFinalSeleccion = Texto.SelectionStart + Len(Seleccionado)
        Dim TextoAnterior = Texto.Text.Substring(0, PosiciónDeInicio)
        Dim TextoPosterior = Texto.Text.Substring(PosiciónDeFinalSeleccion, Texto.Text.Length() - PosiciónDeFinalSeleccion)
        Texto.Text = TextoAnterior & TextoPosterior
        Texto.SelectionStart = Len(TextoAnterior)
        Texto.ScrollToCaret()
        Texto.Focus()
    End Sub
    Public Sub AvanzaBorra()
        On Error Resume Next
        'Dim Keys As Boolean = True
        If AKeys = True Then
            'SendKeys.Send("{ENTER}")
            SendKeys.Send("{DEL}")
            Texto.ScrollToCaret()
            Texto.Focus()
            BorraAvanzaRetrocedeAuto = True
            TimerScrollBorraAuto.Enabled = True
            Exit Sub
            'LetraElegida
        End If

        PosiciónDeInicio = Texto.SelectionStart
        If PosiciónDeInicio + 1 > Texto.Text.Length Then Exit Sub
        Dim TextoAnterior = Texto.Text.Substring(0, PosiciónDeInicio)
        Dim TextoPosterior = Texto.Text.Substring(PosiciónDeInicio + 1, Texto.Text.Length() - (PosiciónDeInicio + 1))
        Texto.Text = TextoAnterior & TextoPosterior
        Texto.SelectionStart = Len(TextoAnterior) ' - 1
        Texto.ScrollToCaret()
        Texto.Focus()
        BorraAvanzaRetrocedeAuto = True
        TimerScrollBorraAuto.Enabled = True

    End Sub
    Public Sub RetrocedeBorra()
        'Dim Keys As Boolean = True
        If AKeys = True Then
            'SendKeys.Send("{ENTER}")
            SendKeys.Send("{BACKSPACE}")
            Texto.ScrollToCaret()
            Texto.Focus()
            BorraAvanzaRetrocedeAuto = False
            TimerScrollBorraAuto.Enabled = True
            Exit Sub
            'LetraElegida
        End If

        Dim Paso = 1
        PosiciónDeInicio = Texto.SelectionStart
        If PosiciónDeInicio = 0 Then Paso = 0
        Dim TextoAnterior = Texto.Text.Substring(0, PosiciónDeInicio - Paso)
        Dim TextoPosterior = Texto.Text.Substring(PosiciónDeInicio, Texto.Text.Length() - PosiciónDeInicio)
        Texto.Text = TextoAnterior & TextoPosterior
        Texto.SelectionStart = Len(TextoAnterior) ' - 1
        Texto.ScrollToCaret()
        Texto.Focus()
        BorraAvanzaRetrocedeAuto = False
        TimerScrollBorraAuto.Enabled = True
    End Sub
    Public Sub RetrocedeBorra1solo()
        If AKeys = True Then
            'SendKeys.Send("{ENTER}")
            SendKeys.Send("{BACKSPACE}")
            Texto.ScrollToCaret()
            Texto.Focus()
            SuenaGoma()
            'BorraAvanzaRetrocedeAuto = False
            'TimerScrollBorraAuto.Enabled = True
            Exit Sub
            'LetraElegida
        End If


        Dim Paso = 1
        PosiciónDeInicio = Texto.SelectionStart
        If PosiciónDeInicio = 0 Then Paso = 0
        Dim TextoAnterior = Texto.Text.Substring(0, PosiciónDeInicio - Paso)
        Dim TextoPosterior = Texto.Text.Substring(PosiciónDeInicio, Texto.Text.Length() - PosiciónDeInicio)
        Texto.Text = TextoAnterior & TextoPosterior
        Texto.SelectionStart = Len(TextoAnterior) ' - 1
        Texto.ScrollToCaret()
        Texto.Focus()
        SuenaGoma()
        'BorraAvanzaRetrocedeAuto = False
        'TimerScrollBorraAuto.Enabled = True
    End Sub
    Public Sub Direcciones()
        If AKeys = True Then
            If HorizontalVertical = True Then
                If AtrasAdelante = True Then
                    If ConShift = False Then
                        SendKeys.Send("{LEFT}")
                    Else
                        SendKeys.Send("+{LEFT}")
                    End If
                Else
                    If ConShift = False Then
                        SendKeys.Send("{RIGHT}")
                    Else
                        SendKeys.Send("+{RIGHT}")
                    End If
                End If
            Else
                If AtrasAdelante = True Then
                    If ConShift = False Then
                        SendKeys.Send("{UP}")
                    Else
                        SendKeys.Send("+{UP}")
                    End If
                Else
                    If ConShift = False Then
                        SendKeys.Send("{DOWN}")
                    Else
                        SendKeys.Send("+{DOWN}")
                    End If

                End If
            End If
            Texto.ScrollToCaret()
            Texto.Focus()
            SuenaGoma()
            TimerActivaScrollAutomatico.Enabled = True
            Exit Sub
        End If



        Dim Paso = 1
        PosiciónDeInicio = Texto.SelectionStart

        If AtrasAdelante = True Then

            Texto.SelectionStart = Texto.SelectionStart + Paso
        Else
            If PosiciónDeInicio = 0 Then Paso = 0
            Texto.SelectionStart = Texto.SelectionStart - Paso
        End If
        Texto.ScrollToCaret()
        Texto.Focus()
        TimerActivaScrollAutomatico.Enabled = True
    End Sub
    Public Sub DireccionesSelecciona()
        Dim Paso = 1
        PosiciónDeInicio = Texto.SelectionStart

        If AtrasAdelante = True Then

            Texto.SelectionStart = Texto.SelectionStart + Paso
        Else
            If PosiciónDeInicio = 0 Then Paso = 0
            Texto.SelectionStart = Texto.SelectionStart - Paso
        End If
        Texto.ScrollToCaret()
        Texto.Focus()
        TimerActivaScrollAutomatico.Enabled = True
    End Sub
    Private Sub TimerAvanzaRetrocedeAuto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerAvanzaRetrocedeAuto.Tick
        Direcciones()
        SuenaScroll()
    End Sub

    Private Sub TimerScrollAutomatico_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerActivaScrollAutomatico.Tick
        TimerAvanzaRetrocedeAuto.Enabled = True

    End Sub

    Private Sub TimerScrollBorraAuto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerScrollBorraAuto.Tick
        TimerBorraAuto.Enabled = True
    End Sub

    Private Sub TimerBorraAuto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerBorraAuto.Tick
        If BorraAvanzaRetrocedeAuto = True Then
            AvanzaBorra()
        Else
            RetrocedeBorra()
        End If
        SuenaGoma()
    End Sub
    Public Sub QuitaDobleEspacioASeleccionado(ByVal Seleccionado As String)
        Dim PosiciónDeInicio = Texto.SelectionStart
        Dim PosiciónDeFinalSeleccion = Texto.SelectionStart + Len(Texto.SelectedText)
        Dim TextoAnterior = Texto.Text.Substring(0, PosiciónDeInicio)
        Dim TextoPosterior = Texto.Text.Substring(PosiciónDeFinalSeleccion, Texto.Text.Length() - PosiciónDeFinalSeleccion)
        Dim TextoSeleccionado = Texto.Text.Substring(PosiciónDeInicio, PosiciónDeFinalSeleccion - PosiciónDeInicio)
        TextoSeleccionado = TextoSeleccionado.Replace("  ", " ")
        Texto.Text = TextoAnterior & TextoSeleccionado & TextoPosterior
        'Selecciona el texto seleccionado
        Texto.SelectionStart = Len(TextoAnterior)
        Texto.SelectionLength = Len(TextoSeleccionado)
        'Posiciona el anotador
        Texto.ScrollToCaret()
        Texto.Focus()
    End Sub

    Public Sub QuitaDobleEspacioATodo(ByVal Seleccionado As String)
        Texto.Text = Texto.Text.Replace("  ", " ")
    End Sub
    Public Sub BuscaEnSeleccionado(ByVal Buscar As String, ByVal Reemplazar As String)
        On Error Resume Next
        If Buscar = "" Then Exit Sub

        Dim PosiciónDeInicio = Texto.SelectionStart
        Dim PosiciónDeFinalSeleccion = Texto.SelectionStart + Len(Texto.SelectedText)
        Dim TextoAnterior = Texto.Text.Substring(0, PosiciónDeInicio)
        Dim TextoPosterior = Texto.Text.Substring(PosiciónDeFinalSeleccion, Texto.Text.Length() - PosiciónDeFinalSeleccion)
        Dim TextoSeleccionado = Texto.Text.Substring(PosiciónDeInicio, PosiciónDeFinalSeleccion - PosiciónDeInicio)
        TextoSeleccionado = TextoSeleccionado.Replace(Buscar, Reemplazar)
        'TextoSeleccionado = TextoSeleccionado.Replace(vbLf, Reemplazar)
        '  TextoSeleccionado = TextoSeleccionado.Replace(Chr(Asc(13)) & Chr(Asc(10)), Reemplazar)
        Texto.Text = TextoAnterior & TextoSeleccionado & TextoPosterior
        'Selecciona el texto seleccionado
        Texto.SelectionStart = Len(TextoAnterior)
        Texto.SelectionLength = Len(TextoSeleccionado)
        'Posiciona el anotador
        Texto.ScrollToCaret()
        Texto.Focus()
        Exit Sub
SalirError:
        Exit Sub
    End Sub

    Public Sub ReemplazaEnSeleccionado(ByVal Buscar As String, ByVal Reemplazar As String)
        On Error Resume Next
        If Buscar = "" Then Exit Sub

        Dim PosiciónDeInicio = Texto.SelectionStart
        Dim PosiciónDeFinalSeleccion = Texto.SelectionStart + Len(Texto.SelectedText)
        Dim TextoAnterior = Texto.Text.Substring(0, PosiciónDeInicio)
        Dim TextoPosterior = Texto.Text.Substring(PosiciónDeFinalSeleccion, Texto.Text.Length() - PosiciónDeFinalSeleccion)
        Dim TextoSeleccionado = Texto.Text.Substring(PosiciónDeInicio, PosiciónDeFinalSeleccion - PosiciónDeInicio)
        TextoSeleccionado = TextoSeleccionado.Replace(Buscar, Reemplazar)
        'TextoSeleccionado = TextoSeleccionado.Replace(vbLf, Reemplazar)
        '  TextoSeleccionado = TextoSeleccionado.Replace(Chr(Asc(13)) & Chr(Asc(10)), Reemplazar)
        Texto.Text = TextoAnterior & TextoSeleccionado & TextoPosterior
        'Selecciona el texto seleccionado
        Texto.SelectionStart = Len(TextoAnterior)
        Texto.SelectionLength = Len(TextoSeleccionado)
        'Posiciona el anotador
        Texto.ScrollToCaret()
        Texto.Focus()
        Exit Sub
SalirError:
        Exit Sub
    End Sub
    Public Sub ReemplazaEnTodoElTexto(ByVal Buscar As String, ByVal Reemplazar As String)
        On Error Resume Next
        If Buscar = "" Then Exit Sub
        If Texto.Text = "" Then Exit Sub
        Texto.Text = Texto.Text.Replace(Buscar, Reemplazar)
    End Sub
    Private Sub ToolStripMenuItem62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If FormIndice.Visible = False Then
            FormIndice.Show()
            FormIndice.TopMost = True
        Else
            FormIndice.Visible = False
        End If
    End Sub

    Private Sub MenuTransparencia70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuTransparencia70.Click
        TextoInicial("")
        Me.Opacity = 0.3
        Teclado.Opacity = 0.3
        Director.Opacity = 0.3
        CheckedTransparencia(MenuTransparencia70)
    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        Dim CadenaArchivo As String
        CadenaArchivo = Texto.SelectedText
        ElArchivo = CadenaArchivo
        CadenaArchivo = CadenaArchivo & ".txt"
        ElArchivoConExtension = CadenaArchivo
        TitulaAnotadorYTeclado()
    End Sub

    Private Sub ReasegurosEnElDirectorioActualMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReasegurosEnElDirectorioActualMenu.Click
        If ReasegurarEnDirectorioActual = True Then
            ReasegurarEnDirectorioActual = False
            ReasegurosEnElDirectorioActualMenu.BackColor = Nothing
            ReasegurosEnElDirectorioActualMenu.Checked = False
            ReasegurosEnElDirectorioActualMenu.Text = "Reasegurar en el directorio actual"
        Else
            ReasegurarEnDirectorioActual = True
            ReasegurosEnElDirectorioActualMenu.BackColor = Color.Yellow
            ReasegurosEnElDirectorioActualMenu.Checked = True
            ReasegurosEnElDirectorioActualMenu.Text = "Reasegura en el directorio actual"
        End If
    End Sub
    Private Sub IndiceMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndiceMenu.Click
        MuestraOcultaIndice()
    End Sub

    Private Sub TecladoMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TecladoMenu.Click
        MuestraOcultaTeclado()
    End Sub

    Private Sub TimerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerToolStripMenuItem.Click
        If FormTimer.Visible = False Then
            FormTimer.Visible = True
            FormTimer.TopMost = True
        Else
            FormTimer.Visible = False
        End If
    End Sub

    Private Sub DirectorMostrarOcultarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirectorMostrarOcultarToolStripMenuItem.Click
        MuestraOcultaDirector()
    End Sub

    Private Sub InformeMostrarOcultarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformeMostrarOcultarToolStripMenuItem.Click
        MuestraOcultaInforme()

    End Sub

    Private Sub TecladoEstirableMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TecladoEstirableMenu.Click
        If TecladoRedimensionable = True Then
            TecladoRedimensionable = False
            TecladoEstirableMenu.Text = "Teclado tamaño fijo"
        Else
            TecladoRedimensionable = True
            TecladoEstirableMenu.Text = "Teclado redimensionable"
        End If
    End Sub

    Private Sub TecladoEstirableMenu_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TecladoEstirableMenu.Paint
        If TecladoRedimensionable = False Then
            TecladoEstirableMenu.Text = "Teclado tamaño fijo"
        Else
            TecladoEstirableMenu.Text = "Teclado redimensionable"
        End If
    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        MuestraOcultaAuxiliar()
    End Sub

    Private Sub DistribucionMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DistribucionMenu.Click

    End Sub

    Private Sub Posiciones01Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Posiciones01Menu.Click
        Posiciones01()

    End Sub

    Private Sub Posiciones02Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Posiciones02Menu.Click
        Posiciones02()

    End Sub


    Private Sub Posiciones03Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Posiciones03Menu.Click
        Posiciones03()

    End Sub

    Private Sub ReaseguroMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReaseguroMenu.Click
        If TimerResguardo.Enabled = True Then
            TimerResguardo.Enabled = False
            ReaseguroMenu.Text = "Reaseguro desactivado"
        Else
            TimerResguardo.Enabled = True
            ReaseguroMenu.Text = "Reaseguro activado"
        End If
    End Sub

    Private Sub TimerHoraMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerHoraMenu.Click
        If TimerHora.Enabled = True Then
            TimerHora.Enabled = False
            TimerHoraMenu.Text = "Timer Hora desactivado"
        Else
            TimerHora.Enabled = True
            TimerHoraMenu.Text = "Timer Hora  activado"
        End If
    End Sub

    Private Sub Posiciones00Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Posiciones00Menu.Click
        Posiciones00()
        FormAuxiliar.Visible = False
        Director.Visible = False
        Teclado.Visible = False
        FormIndice.Visible = False

        'Formguion.Visible = False

    End Sub

    Private Sub Posiciones05Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Posiciones05Menu.Click
        Posiciones05()

    End Sub

    Private Sub Posiciones06Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Posiciones06Menu.Click
        Posiciones06()

    End Sub

    Private Sub Posiciones04Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Posiciones04Menu.Click
        Posiciones04()

    End Sub

    Private Sub ToolStripMenuItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        DirectorioActual = "C:\Notas"
    End Sub

    Private Sub GuardarSeleccionadoComoMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarSeleccionadoComoMenu.Click
        GuardarComo(True)
    End Sub


    Private Sub ToolStripMenuItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Dim Anotador2 As New Anotador
        Anotador2.Show()
        Anotador2.ElArchivo = Me.ElArchivo & "recorte"
        Anotador2.Texto.Text = Me.Texto.SelectedText
        Anotador2.Texto.BackColor = Color.FromArgb(0, 0, 160) 'azul oscuro
        Anotador2.Texto.ForeColor = Color.FromArgb(0, 255, 255) ' cyan 
        Anotador2.MenuTablero.BackColor = Color.FromArgb(0, 255, 255) ' cyan 
        Anotador2.MenuTablero.ForeColor = Color.FromArgb(0, 0, 160) 'azul oscuro
        Anotador2.Name = "Anotador2"
    End Sub

    Private Sub ToolStripMenuItem6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        GuardaPosicionPersonalizada()
    End Sub

    Private Sub PosiciónPersonalizadaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Posiciones07Menu.Click
        Posiciones07()

    End Sub

    Private Sub ToolStripMenuItem7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        If Me.Name <> "Anotador" Then
            NombreDelCuadroACerrar = Me.Name
            Me.Dispose()
        End If
    End Sub

    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
        AgregaRegistroOrg()
    End Sub


    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click
        LeeRegistroOrg()
    End Sub

    Private Sub CopiaTexto1Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiaTexto1Menu.Click
        GuardaTexto1 = Texto.Text
        CopiaTexto1Menu.BackColor = Color.Aqua
    End Sub

    Private Sub RestauraTextoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestauraTextoToolStripMenuItem.Click
        If GuardaTexto1 = "" Then Exit Sub
        Texto.Text = GuardaTexto1
    End Sub

    Private Sub CopiaTexto2Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiaTexto2Menu.Click
        GuardaTexto2 = Texto.Text
        CopiaTexto2Menu.BackColor = Color.Aqua
    End Sub

    Private Sub CopiaTexto3Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiaTexto3Menu.Click
        GuardaTexto3 = Texto.Text
        CopiaTexto3Menu.BackColor = Color.Aqua
    End Sub

    Private Sub RestauraTexto2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestauraTexto2ToolStripMenuItem.Click
        If GuardaTexto2 = "" Then Exit Sub
        Texto.Text = GuardaTexto2
    End Sub

    Private Sub RestauraTexto3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestauraTexto3ToolStripMenuItem.Click
        If GuardaTexto3 = "" Then Exit Sub
        Texto.Text = GuardaTexto3
    End Sub

    Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem12.Click
        Dim CadenaArchivo As String
        CadenaArchivo = NombreFechaLarga()
        ElArchivo = CadenaArchivo
        CadenaArchivo = CadenaArchivo & ".txt"
        ElArchivoConExtension = CadenaArchivo
        TitulaAnotadorYTeclado()
        FormInforme.Informa("Crea nuevo NOMBRE DE ARCHIVO FECHA ACTUAL")
    End Sub
End Class
