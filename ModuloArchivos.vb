Module ModuloArchivos
    Structure ArchivoDeDatos
        <VBFixedString(255)> Dim NombreDeRegistro As String
        <VBFixedString(255)> Dim Comentarios As String
    End Structure
    Public FileNumero As Integer
    Public NumeroDeRegistroIndiceEnLaLista As Integer
    Public RutaTotalArchivoDeIndice As String
    Public DirectorioDeArchivosDeIndice As String = "C:\Anotador\Archivos"
    Public NumeroItemSeleccionadoIndice As Integer
    Public Mensaje As String
    Public ComentarioItemSeleccionadoIndice As String = ""
    Public CadenaItemSeleccionadoIndice As String
    Public ReservaComentarioItemSeleccionadoIndice As String = ""
    Public ReservaCadenaItemSeleccionadoIndice As String
    Public TipoItemSeleccionadoIndice As String

    Public Sub CreaArchivo()
        ' CREA EL ARCHIVO DE INDICES
        Dim Formato As ArchivoDeDatos
        FileNumero = FreeFile()
        If FormIndice.TextoNombreDeArchivo.Text = "" Then FormIndice.TextoNombreDeArchivo.Text = "Archivo de Datos Nro" & (800 - 0) * Rnd() + 0
        Dim NombreDelArchivo As String = DirectorioDeArchivosDeIndice & "\" & FormIndice.TextoNombreDeArchivo.Text & ".dat"
        FileOpen(FileNumero, NombreDelArchivo, OpenMode.Random, , , Len(Formato))
        FileClose(FileNumero)
        RutaTotalArchivoDeIndice = NombreDelArchivo
    End Sub
    Public Function EncuentraUltimoRegistro() As Integer
        ' ENCUENTRA ULTIMO REGISTRO DEL ARCHIVO DE INDICES
        Dim Temp As ArchivoDeDatos, FileNumber As Integer
        FileNumber = FreeFile()
        FileOpen(FileNumber, RutaTotalArchivoDeIndice, OpenMode.Random, OpenAccess.Read, , Len(Temp))
        EncuentraUltimoRegistro = 1
        Do While Not EOF(FileNumber)
            FileGet(FileNumber, Temp, )
            EncuentraUltimoRegistro = EncuentraUltimoRegistro + 1
        Loop
        FileClose(FileNumber)
    End Function

    Public Sub LeeArchivo()
        ' LEE EL ARCHIVO DE INDICES
        'On Error Resume Next
        If RutaTotalArchivoDeIndice = "" Then Exit Sub
        Dim Formato As ArchivoDeDatos, Count As Integer
        Dim Ultimoregistro As Integer = 1
        Dim Temp As String = ""
        FileNumero = FreeFile()
        FileOpen(FileNumero, RutaTotalArchivoDeIndice, OpenMode.Random, , , Len(Formato))

        Count = 1

        FormIndice.ListaArchivo.Items.Clear()
        Do While Not EOF(FileNumero)
            FileGet(FileNumero, Formato, Count)
            Temp = Mid(Formato.NombreDeRegistro, 1, 255) '& "  " & Tamaño.H1 & "  " & Tamaño.H2 & "  " & Tamaño.V1 & "  " & Tamaño.V2
            FormIndice.ListaArchivo.Items.Add(Temp)
            Ultimoregistro = Count
            Count = Count + 1
        Loop
        FileClose(FileNumero)
        '       If ListaArchivo.SelectedIndex < 0 Then ListaArchivo.SelectedIndex = 0
        'ListaArchivo.SelectedItem = RegistroSeleccionado
        If NumeroItemSeleccionadoIndice > FormIndice.ListaArchivo.Items.Count Then
            NumeroItemSeleccionadoIndice = FormIndice.ListaArchivo.Items.Count
        End If

        FormIndice.ListaArchivo.SelectedIndex = NumeroItemSeleccionadoIndice - 1
        FormIndice.TextoNumReg.Text = NumeroDeRegistroIndiceEnLaLista
        FormIndice.TextoNumSel.Text = NumeroItemSeleccionadoIndice
        FormIndice.ListaArchivo.Refresh()
    End Sub
    Public Sub AbreArchivoInicial()
        'ABRE ARCHIVO INICIAL DE INDICES
        On Error Resume Next
        'FormDocumentos.OpenFileDialog1.InitialDirectory = DirectorioDeArchivos
        'FormDocumentos.OpenFileDialog1.Filter = "Archivos de datos (*.dat)|*.dat|Todos los archivos (*.*)|*.*"
        'FormDocumentos.OpenFileDialog1.FileName = ""
        'FormDocumentos.OpenFileDialog1.ShowDialog()
        'NombreDirectorioArchivoExtension = FormDocumentos.OpenFileDialog1.FileName
        RutaTotalArchivoDeIndice = DirectorioDeArchivosDeIndice & "\" & "Archivo de Datos Inicial.dat"

        If RutaTotalArchivoDeIndice = "" Then Exit Sub
        Dim NúmeroArchivo = FreeFile()
        Dim Formato As ArchivoDeDatos, Count As Integer
        Dim Temp As String = ""
        FileOpen(NúmeroArchivo, RutaTotalArchivoDeIndice, OpenMode.Random, , , Len(Formato))
        Count = 1
        FormIndice.ListaArchivo.Items.Clear()
        Do While Not EOF(NúmeroArchivo)
            FileGet(NúmeroArchivo, Formato, Count)
            Temp = Mid(Formato.NombreDeRegistro, 1, 255) '& "  " & Tamaño.H1 & "  " & Tamaño.H2 & "  " & Tamaño.V1 & "  " & Tamaño.V2
            FormIndice.ListaArchivo.Items.Add(Temp)
            Count = Count + 1
        Loop
        FileClose(NúmeroArchivo)
        ' Dim obj As Byte = Len(NombreDirectorioArchivoExtension) - Len(DirectorioDeArchivos) - 5
        '  FormDocumentos.TextoNombreDeArchivo.Text = Mid(NombreDirectorioArchivoExtension, Len(DirectorioDeArchivos) + 2, obj)
        FormIndice.TextoNombreDeArchivo.Text = RutaTotalArchivoDeIndice
    End Sub
    Public Sub AbreArchivoDeDirectorios()
        'ABRE ARCHIVO INICIAL DE directorios
        On Error Resume Next
       
        RutaTotalArchivoDeIndice = DirectorioDeArchivosDeIndice & "\" & "Directorios.dat"

        If RutaTotalArchivoDeIndice = "" Then Exit Sub
        Dim NúmeroArchivo = FreeFile()
        Dim Formato As ArchivoDeDatos, Count As Integer
        Dim Temp0 As String = ""
        Dim Temp As String = ""
        FileOpen(NúmeroArchivo, RutaTotalArchivoDeIndice, OpenMode.Random, , , Len(Formato))
        Count = 0
        'FormIndice.ListaArchivo.Items.Clear()
        Do While Not EOF(NúmeroArchivo)
            Count = Count + 1
            FileGet(NúmeroArchivo, Formato, Count)
            Temp0 = Mid(Formato.NombreDeRegistro, 1, 255)
            Temp = Mid(Formato.NombreDeRegistro, 1, InStr(Temp0, " "))
            Select Case Count
                Case Is = 0
                    Anotador.Directorio00Menu.Text = Temp
                Case Is = 1
                    Anotador.Directorio01Menu.Text = Temp
                Case Is = 2
                    Anotador.Directorio02Menu.Text = Temp
                Case Is = 3
                    Anotador.Directorio03Menu.Text = Temp
                Case Is = 4
                    Anotador.Directorio04Menu.Text = Temp
                Case Is = 5
                    Anotador.Directorio05Menu.Text = Temp
                Case Is = 6
                    Anotador.Directorio06Menu.Text = Temp
                Case Is = 7
                    Anotador.Directorio07Menu.Text = Temp
                Case Is = 8
                    Anotador.Directorio08Menu.Text = Temp
                Case Is = 9
                    Anotador.Directorio09Menu.Text = Temp
                Case Is = 10
                    Anotador.Directorio10Menu.Text = Temp
                Case Is = 11
                    Anotador.Directorio11Menu.Text = Temp
                Case Is = 12
                    Anotador.Directorio12Menu.Text = Temp
                Case Is = 13
                    Anotador.Directorio13Menu.Text = Temp
                Case Is = 14
                    Anotador.Directorio14Menu.Text = Temp
                Case Is = 15
                    Anotador.Directorio15Menu.Text = Temp
                Case Is = 16
                    Anotador.Directorio16Menu.Text = Temp
                Case Is = 17
                    Anotador.Directorio17Menu.Text = Temp
                Case Is = 18
                    Anotador.Directorio18Menu.Text = Temp
                Case Is = 19
                    Anotador.Directorio19Menu.Text = Temp
                Case Is = 20
                    Anotador.Directorio20Menu.Text = Temp
            End Select
            If Count > 20 Then
                FileClose(NúmeroArchivo)
                Exit Sub
            End If
        Loop
        FileClose(NúmeroArchivo)
        FormIndice.TextoNombreDeArchivo.Text = RutaTotalArchivoDeIndice
    End Sub
    Public Sub LeeRegistrodeIndice()
        On Error Resume Next
        If RutaTotalArchivoDeIndice = "" Then Exit Sub
        Dim NúmeroArchivo = FreeFile()
        Dim Formato As ArchivoDeDatos
        'Dim Count As Integer

        'Dim NumeroDeRegistro As Integer
        FileOpen(NúmeroArchivo, RutaTotalArchivoDeIndice, OpenMode.Random, , , Len(Formato))
        ' NumeroDeRegistro = NumeroDeRegistroSeleccionadoIndice
        If NumeroItemSeleccionadoIndice < 0 Then Exit Sub
        FileGet(NúmeroArchivo, Formato, NumeroItemSeleccionadoIndice)
        ComentarioItemSeleccionadoIndice = Mid(Formato.Comentarios, 1, 255) '& "  " & Tamaño.H1 & "  " & Tamaño.H2 & "  " & Tamaño.V1 & "  " & Tamaño.V2
        CadenaItemSeleccionadoIndice = Mid(Formato.NombreDeRegistro, 1, 255)
        FileClose(NúmeroArchivo)

        'If Right(FormDocumentos.TextoNombreDeRegistro.Text, 4) = ".txt" Then
        'TipoItemSeleccionadoIndice = "DIRECTORIO: "
        ' FormDocumentos.TextoComentarios.BackColor = Color.Red
        ' Else
        'TipoItemSeleccionadoIndice = "TEXTO: "
        'FormDocumentos.TextoComentarios.BackColor = Color.Azure
        'End If
        'ComentarioItemSeleccionadoIndice = TipoItemSeleccionadoIndice & ComentarioItemSeleccionadoIndice
        FormIndice.TextoComentarios.Text = ComentarioItemSeleccionadoIndice

    End Sub
    Private Sub AnalizaIndice()

    End Sub

    Public Sub AbreArchivo()
        On Error Resume Next
        'Dim ArchivoAAbrir As Object
        FormIndice.OpenFileDialog1.InitialDirectory = DirectorioDeArchivosDeIndice
        FormIndice.OpenFileDialog1.Filter = "Archivos de datos (*.dat)|*.dat|Todos los archivos (*.*)|*.*"
        FormIndice.OpenFileDialog1.FileName = ""
        FormIndice.OpenFileDialog1.ShowDialog()
        RutaTotalArchivoDeIndice = FormIndice.OpenFileDialog1.FileName
        'Me.Text = ArchivoDeRecortes
        If RutaTotalArchivoDeIndice = "" Then Exit Sub
        Dim NúmeroArchivo = FreeFile()
        Dim Formato As ArchivoDeDatos, Count As Integer
        Dim Temp As String = ""
        FileOpen(NúmeroArchivo, RutaTotalArchivoDeIndice, OpenMode.Random, , , Len(Formato))
        Count = 1
        FormIndice.ListaArchivo.Items.Clear()
        Do While Not EOF(NúmeroArchivo)
            FileGet(NúmeroArchivo, Formato, Count)
            Temp = Mid(Formato.NombreDeRegistro, 1, 255) '& "  " & Tamaño.H1 & "  " & Tamaño.H2 & "  " & Tamaño.V1 & "  " & Tamaño.V2
            FormIndice.ListaArchivo.Items.Add(Temp)
            Count = Count + 1
        Loop
        FileClose(NúmeroArchivo)
        Dim obj As Byte = Len(RutaTotalArchivoDeIndice) - Len(DirectorioDeArchivosDeIndice) - 5
        FormIndice.TextoNombreDeArchivo.Text = Mid(RutaTotalArchivoDeIndice, Len(DirectorioDeArchivosDeIndice) + 2, obj)

    End Sub

    Public Sub AplicaRegistroPorOrden(ByVal NumeroReg As Long)
        'Busca registro por ID
        Dim Formato As ArchivoDeDatos
        FileNumero = FreeFile()
        FileOpen(FileNumero, RutaTotalArchivoDeIndice, OpenMode.Random, , , Len(Formato))

        FileGet(FileNumero, Formato, NumeroReg)
        'If Tamaño.Nombretamaño = Val(TextBox5.Text) Then
        'NumeroRegistro = Loc(FileNum)
        NumeroDeRegistroIndiceEnLaLista = NumeroReg

        'PoneValoresDeRecorte(Recorte.Izquierda, Recorte.Arriba, Recorte.Ancho, Recorte.Alto)
        FormIndice.TextoNombreDeArchivo.Text = Formato.NombreDeRegistro
        FormIndice.TextoComentarios.Text = Formato.Comentarios
        FileClose(FileNumero)

    End Sub
    Public Sub AgregaRegistro()
        ' Inserta registro
        If RutaTotalArchivoDeIndice = "" Then Exit Sub
        Dim Formato As ArchivoDeDatos, UltimoRegistro As Integer
        UltimoRegistro = EncuentraUltimoRegistro()
        FileNumero = FreeFile()
        FileOpen(FileNumero, RutaTotalArchivoDeIndice, OpenMode.Random, , , Len(Formato))

        Formato.NombreDeRegistro = FormIndice.TextoNombreDeRegistro.Text
        Formato.Comentarios = FormIndice.TextoComentarios.Text
        FilePut(FileNumero, Formato, UltimoRegistro)
        NumeroItemSeleccionadoIndice = UltimoRegistro
        FormIndice.ListaArchivo.SelectedItem = UltimoRegistro - 1
        FileClose(FileNumero)
    End Sub
    Public Sub GuardaDirectorios()
        ' Inserta registro
        'If RutaTotalArchivoDeIndice = "" Then Exit Sub
        Dim Formato As ArchivoDeDatos, UltimoRegistro As Integer
        'UltimoRegistro = EncuentraUltimoRegistro()
        FileNumero = FreeFile()
        'FileOpen(FileNumero, RutaTotalArchivoDeIndice, OpenMode.Random, , , Len(Formato))
        FileOpen(FileNumero, "C:\Anotador\Archivos\Directorios.dat", OpenMode.Random, , , Len(Formato))
        For NumeroRegistro As Integer = 1 To 20
            Select Case NumeroRegistro
                Case Is = 1
                    Formato.NombreDeRegistro = Anotador.Directorio01Menu.Text
                Case Is = 2
                    Formato.NombreDeRegistro = Anotador.Directorio02Menu.Text
                Case Is = 3
                    Formato.NombreDeRegistro = Anotador.Directorio03Menu.Text
                Case Is = 4
                    Formato.NombreDeRegistro = Anotador.Directorio04Menu.Text
                Case Is = 5
                    Formato.NombreDeRegistro = Anotador.Directorio05Menu.Text
                Case Is = 6
                    Formato.NombreDeRegistro = Anotador.Directorio06Menu.Text
                Case Is = 7
                    Formato.NombreDeRegistro = Anotador.Directorio07Menu.Text
                Case Is = 8
                    Formato.NombreDeRegistro = Anotador.Directorio08Menu.Text
                Case Is = 9
                    Formato.NombreDeRegistro = Anotador.Directorio09Menu.Text
                Case Is = 10
                    Formato.NombreDeRegistro = Anotador.Directorio10Menu.Text
                Case Is = 11
                    Formato.NombreDeRegistro = Anotador.Directorio11Menu.Text
                Case Is = 12
                    Formato.NombreDeRegistro = Anotador.Directorio12Menu.Text
                Case Is = 13
                    Formato.NombreDeRegistro = Anotador.Directorio13Menu.Text
                Case Is = 14
                    Formato.NombreDeRegistro = Anotador.Directorio14Menu.Text
                Case Is = 15
                    Formato.NombreDeRegistro = Anotador.Directorio15Menu.Text
                Case Is = 16
                    Formato.NombreDeRegistro = Anotador.Directorio16Menu.Text
                Case Is = 17
                    Formato.NombreDeRegistro = Anotador.Directorio17Menu.Text
                Case Is = 18
                    Formato.NombreDeRegistro = Anotador.Directorio18Menu.Text
                Case Is = 19
                    Formato.NombreDeRegistro = Anotador.Directorio19Menu.Text
                Case Is = 20
                    Formato.NombreDeRegistro = Anotador.Directorio20Menu.Text
            End Select
            'Formato.Comentarios = FormIndice.TextoComentarios.Text
            Formato.Comentarios = ""
            FilePut(FileNumero, Formato, NumeroRegistro)

            'NumeroItemSeleccionadoIndice = UltimoRegistro
            'FormIndice.ListaArchivo.SelectedItem = UltimoRegistro - 1
        Next
        FileClose(FileNumero)
    End Sub

    Public Sub ModificaRegistro()
        'Actualiza un registro
        If RutaTotalArchivoDeIndice = "" Then Exit Sub
        Dim Formato As ArchivoDeDatos
        FileNumero = FreeFile()
        FileOpen(FileNumero, RutaTotalArchivoDeIndice, OpenMode.Random, , , Len(Formato))
        'Seek(FileNum, Position)
        'Seek(FileNum, NumeroRegistro)
        Formato.NombreDeRegistro = FormIndice.TextoNombreDeRegistro.Text
        Formato.Comentarios = FormIndice.TextoComentarios.Text

        If NumeroItemSeleccionadoIndice = 0 Then Exit Sub
        FilePut(FileNumero, Formato, NumeroItemSeleccionadoIndice)
        FormIndice.ListaArchivo.SelectedItem = NumeroItemSeleccionadoIndice
        'RegistroSeleccionado = NumeroRegistro
        FileClose(FileNumero)
    End Sub
    Public Sub IntercalaRegistro()
        ' Borra un registro
        If RutaTotalArchivoDeIndice = "" Then Exit Sub
        Dim Formato As ArchivoDeDatos, FileNum1, FileNum2 As Integer
        FileNum1 = FreeFile()
        FileOpen(FileNum1, RutaTotalArchivoDeIndice, OpenMode.Random, OpenAccess.Read, , Len(Formato))
        FileNum2 = FreeFile()
        FileOpen(FileNum2, "C:\Anotador\Archivos\Temporal.txt", OpenMode.Random, OpenAccess.Write, , Len(Formato))

        Do While Not EOF(FileNum1)
            If (Loc(FileNum1) <> NumeroDeRegistroIndiceEnLaLista) Then
                FileGet(FileNum1, Formato, )
                FilePut(FileNum2, Formato, )
            Else
                FileGet(FileNum1, Formato, )
                FilePut(FileNum2, Formato, )
                Formato.NombreDeRegistro = FormIndice.TextoNombreDeRegistro.Text
                Formato.Comentarios = FormIndice.TextoComentarios.Text

                FilePut(FileNum2, Formato, )

            End If
        Loop
        FileClose(FileNum1)
        FileClose(FileNum2)
        Kill(RutaTotalArchivoDeIndice)
        Rename("C:\Anotador\Archivos\Temporal.txt", RutaTotalArchivoDeIndice)
    End Sub
    Public Sub BorraArchivo(ByVal RutaTotal As String)
        On Error Resume Next
        Kill(RutaTotal)
    End Sub

    Public Sub BorraRegistro()
        ' Borra un registro
        If RutaTotalArchivoDeIndice = "" Then Exit Sub
        Dim Formato As ArchivoDeDatos, FileNum1, FileNum2 As Integer
        FileNum1 = FreeFile()
        FileOpen(FileNum1, RutaTotalArchivoDeIndice, OpenMode.Random, OpenAccess.Read, , Len(Formato))
        FileNum2 = FreeFile()
        FileOpen(FileNum2, "C:\Anotador\Archivos\Temporal.txt", OpenMode.Random, OpenAccess.Write, , Len(Formato))

        Do While Not EOF(FileNum1)
            If (Loc(FileNum1) <> NumeroDeRegistroIndiceEnLaLista) Then
                FileGet(FileNum1, Formato, )
                FilePut(FileNum2, Formato, )
            Else
                FileGet(FileNum1, Formato, )
            End If
        Loop
        FileClose(FileNum1)
        FileClose(FileNum2)
        Kill(RutaTotalArchivoDeIndice)
        Rename("C:\Anotador\Archivos\Temporal.txt", RutaTotalArchivoDeIndice)
    End Sub
    Public Sub BuscaRegistroPorParámetro()
        'Busca registro por ID
        Dim Recorte As ArchivoDeDatos
        Dim parametro As String = ""
        FileNumero = FreeFile()
        FileOpen(FileNumero, "C:\Muevebezier\Archivos\Objetos.txt", OpenMode.Random, , , Len(Recorte))
        Do While Not EOF(FileNumero)
            FileGet(FileNumero, Recorte, )
            If Recorte.NombreDeRegistro = parametro Then
                NumeroDeRegistroIndiceEnLaLista = Loc(FileNumero)
                'TextBox6.Text = Tamaño.Name
                ' TextBox7.Text = Tamaño.Surname
                Exit Do
            End If
        Loop
        FileClose(FileNumero)
    End Sub

End Module
