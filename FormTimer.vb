Public Class FormTimer

    Private Sub FijaTimerMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FijaTimerMenu.Click
        FijaTimer()
    End Sub

    Private Sub ApagaTimerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApagaTimerToolStripMenuItem.Click
        ApagaTimer()
    End Sub

    Private Sub OcultaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OcultaToolStripMenuItem.Click
        Me.Visible = False
    End Sub

    Private Sub ReduceCuadroTimerMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextoTimer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextoTimer.TextChanged

    End Sub

    Private Sub FormTimer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.TopMost = True
        With TextoTimer
            '.Top = 0
            .Left = 0
            .Width = Me.Width
            .Height = Me.Height
        End With
    End Sub

    Private Sub FormTimer_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        With TextoTimer
            '.Top = 0
            .Left = 0
            .Width = Me.Width
            .Height = Me.Height
        End With
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Dim Fuente = TextoTimer.Font
        Fuente = New Font(Fuente.FontFamily, Fuente.Size * 1.1, Fuente.Style, Fuente.Unit, Fuente.GdiCharSet)
        TextoTimer.Font = Fuente
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TickDeTimer()

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim Fuente = TextoTimer.Font
        Fuente = New Font(Fuente.FontFamily, Fuente.Size * 0.9, Fuente.Style, Fuente.Unit, Fuente.GdiCharSet)
        TextoTimer.Font = Fuente
    End Sub

    '---------------------  MODULO ARCHIVOS -------------------------
    Private Sub BotonCreaArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonCreaArchivo.Click
        CreaArchivo()
    End Sub
    Private Sub BotonInsertaRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonInsertaRegistro.Click
        AgregaRegistro()
    End Sub

    Private Sub BotonLeeArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonLeeArchivo.Click
        LeeArchivo()
    End Sub
    Private Sub ListaArchivo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaArchivo.SelectedIndexChanged
        AplicaRegistroPorOrden(ListaArchivo.SelectedIndex + 1)
    End Sub

    Private Sub BotonModificaRegustro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonModificaRegustro.Click
        ModificaRegistro()
    End Sub
    Private Sub BotonBorraRegustro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonBorraRegustro.Click
        BorraRegistro()
    End Sub
    Private Sub CreaArchivo()
        ' crea el archivo
        'Structure ArchivoTamaños
        ' <VBFixedString(30)> Dim Nombretamaño As String
        'Dim H1 As Integer
        'Dim H2 As Integer
        'Dim V1 As Integer
        'Dim V2 As Integer
        'End Structure
        Dim Registro As ArchivoTimer
        FileNum = FreeFile()
        FileOpen(FileNum, "C:\Anotador\Archivos\Timers.txt", OpenMode.Random, , , Len(Registro))
        FileClose(FileNum)
        LeeArchivo()
    End Sub
    Private Function EncuentraUltimoRegistro() As Integer
        ' encuentra el último registro
        Dim Registro As ArchivoTimer, FileNumber As Integer
        FileNumber = FreeFile()
        FileOpen(FileNumber, "C:\Anotador\Archivos\Timers.txt", OpenMode.Random, OpenAccess.Read, , Len(Registro))
        EncuentraUltimoRegistro = 1
        Do While Not EOF(FileNumber)
            FileGet(FileNumber, Registro, )
            EncuentraUltimoRegistro = EncuentraUltimoRegistro + 1
        Loop
        FileClose(FileNumber)
    End Function
    Private Sub AgregaRegistro()
        ' Inserta registro
        Dim Registro As ArchivoTimer, UltimoRegistro As Integer
        UltimoRegistro = EncuentraUltimoRegistro()
        FileNum = FreeFile()
        FileOpen(FileNum, "C:\Anotador\Archivos\Timers.txt", OpenMode.Random, , , Len(Registro))
        Registro.EventoTimer = TextoEventoTimer.Text
        FilePut(FileNum, Registro, UltimoRegistro)
        FileClose(FileNum)
        LeeArchivo()
    End Sub
    Private Sub LeeArchivo()
        ' Lee el archivo
        Dim Registro As ArchivoTimer, Count As Integer
        Dim Temp As String = ""
        FileNum = FreeFile()
        FileOpen(FileNum, "C:\Anotador\Archivos\Timers.txt", OpenMode.Random, , , Len(Registro))
        Count = 1
        ListaArchivo.Items.Clear()
        Do While Not EOF(FileNum)
            FileGet(FileNum, Registro, Count)
            Temp = Mid(Registro.EventoTimer, 1, 120) '& "  " & Tamaño.H1 & "  " & Tamaño.H2 & "  " & Tamaño.V1 & "  " & Tamaño.V2
            ListaArchivo.Items.Add(Temp)
            Count = Count + 1
        Loop
        FileClose(FileNum)
    End Sub
    Private Sub AplicaRegistroPorOrden(ByVal NumeroReg As Long)
        'Busca registro por ID
        Dim Registro As ArchivoTimer
        FileNum = FreeFile()
        FileOpen(FileNum, "C:\Anotador\Archivos\Timers.txt", OpenMode.Random, , , Len(Registro))

        FileGet(FileNum, Registro, NumeroReg)
        'If Tamaño.Nombretamaño = Val(TextBox5.Text) Then
        'NumeroRegistro = Loc(FileNum)
        NumeroRegistro = NumeroReg
        MensajeTimer.Text = Registro.EventoTimer
        TextoEventoTimer.Text = Registro.EventoTimer
        FileClose(FileNum)
    End Sub
    Private Sub ModificaRegistro()
        'Actualiza un registro
        Dim Registro As ArchivoTimer
        FileNum = FreeFile()
        FileOpen(FileNum, "C:\Anotador\Archivos\Timers.txt", OpenMode.Random, , , Len(Registro))
        'Seek(FileNum, Position)
        'Seek(FileNum, NumeroRegistro)
        Registro.EventoTimer = TextoEventoTimer.Text
        FilePut(FileNum, Registro, NumeroRegistro)
        FileClose(FileNum)
        LeeArchivo()
    End Sub
    Private Sub IntercalaRegistro()
        ' Borra un registro
        'If ArchivoDeTamaños = "" Then Exit Sub
        Dim Registro As ArchivoTimer, FileNum1, FileNum2 As Integer
        FileNum1 = FreeFile()
        FileOpen(FileNum1, "C:\Anotador\Archivos\Timers.txt", OpenMode.Random, OpenAccess.Read, , Len(Registro))
        FileNum2 = FreeFile()
        FileOpen(FileNum2, "C:\Anotador\Archivos\Temporal.txt", OpenMode.Random, OpenAccess.Write, , Len(Registro))

        Do While Not EOF(FileNum1)
            If (Loc(FileNum1) <> NumeroRegistro - 1) Then
                FileGet(FileNum1, Registro, )
                FilePut(FileNum2, Registro, )
            Else
                FileGet(FileNum1, Registro, )
                FilePut(FileNum2, Registro, )
                Registro.EventoTimer = TextoEventoTimer.Text

                FilePut(FileNum2, Registro, )

            End If
        Loop
        FileClose(FileNum1)
        FileClose(FileNum2)
        Kill("C:\Anotador\Archivos\Timers.txt")
        Rename("C:\Anotador\Archivos\Temporal.txt", "C:\Anotador\Archivos\Timers.txt")
        LeeArchivo()
    End Sub
    Private Sub BorraRegistro()
        ' Borra un registro
        Dim Tamaño As ArchivoTimer, FileNum1, FileNum2 As Integer
        FileNum1 = FreeFile()
        FileOpen(FileNum1, "C:\Anotador\Archivos\Timers.txt", OpenMode.Random, OpenAccess.Read, , Len(Tamaño))
        FileNum2 = FreeFile()
        FileOpen(FileNum2, "C:\Anotador\Archivos\Temporal.txt", OpenMode.Random, OpenAccess.Write, , Len(Tamaño))

        Do While Not EOF(FileNum1)
            If (Loc(FileNum1) <> NumeroRegistro - 1) Then
                FileGet(FileNum1, Tamaño, )
                FilePut(FileNum2, Tamaño, )
            Else
                FileGet(FileNum1, Tamaño, )
            End If
        Loop
        FileClose(FileNum1)
        FileClose(FileNum2)
        Kill("C:\Anotador\Archivos\Timers.txt")
        Rename("C:\Anotador\Archivos\Temporal.txt", "C:\Anotador\Archivos\Timers.txt")
        LeeArchivo()
    End Sub
    Private Sub BuscaRegistroPorParámetro()
        'Busca registro por ID
        Dim Tamaño As ArchivoTimer
        Dim parametro As String = ""
        FileNum = FreeFile()
        FileOpen(FileNum, "C:\Anotador\Archivos\Timers.txt", OpenMode.Random, , , Len(Tamaño))
        Do While Not EOF(FileNum)
            FileGet(FileNum, Tamaño, )
            If Tamaño.EventoTimer = parametro Then
                NumeroRegistro = Loc(FileNum)
                'TextBox6.Text = Tamaño.Name
                ' TextBox7.Text = Tamaño.Surname
                Exit Do
            End If
        Loop
        FileClose(FileNum)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        IntercalaRegistro()
    End Sub



    Private Sub TimerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerToolStripMenuItem.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FormTortaTimer.BackColor = Color.LightGray
        FormTortaTimer.TopMost = True
        If FormTortaTimer.TransparencyKey = Color.LightGray Then

            FormTortaTimer.TransparencyKey = Color.DarkGray
        Else
            FormTortaTimer.TransparencyKey = Color.LightGray

        End If
    End Sub
End Class