Module Timer
    Structure ArchivoTimer
        <VBFixedString(120)> Dim EventoTimer As String
        'Dim H1 As Integer
        'Dim H2 As Integer
        'Dim V1 As Integer
        'Dim V2 As Integer
    End Structure
    Public FileNum As Integer
    Public NumeroRegistro As Integer
    Public TiempoDeAlarma As Double
    Public PlazoTimer As Double
    Public InversoDia As String
    Public InversoAño As String
    Public InversoMes As String
    Public InversoHoras As String
    Public InversoMinutos As String
    Public InversoSegundos As String
    Public InversoCadenaFecha As String
    Public InversoDiaSemanaCorto As String
    Public CadenaTiempoInversoCorta As String
    Public CadenaTiempoInversoMuyCorta As String
    Public Sub FijaTiempoJulianoActual()
        Dim Fecha As Date
        Fecha = Now()
        'Anotador.Texto1.Visible = True
        Dim Día As Integer = Fecha.Day
        Dim Mes As Integer = Fecha.Month
        Dim Año As Integer = Fecha.Year
        Dim Horas As Integer = Fecha.Hour
        Dim Minutos As Integer = Fecha.Minute
        Dim Segundos As Integer = Fecha.Second
        Dim DíaSemana As Integer = Fecha.DayOfWeek
        Dim Huso As Integer = 3
        'CalculaCarta(Año, Mes, Día, Horas, Minutos, Segundos, Huso)
        Call CalculaTiempoJuliano(Año, Mes, Día, Horas, Minutos, Segundos, Huso, TiempoJuliano)
        TiempoDeAlarma = TiempoJuliano + (1 / 1440 * FormTimer.FijaMinutos.Text)
        PlazoTimer = 1 / 1440 * FormTimer.FijaMinutos.Text
        'Call CálculoTiempoInverso(TiempoJuliano, Huso, CadenaTiempoInverso, CadenaTiempoInversoCorta)
        'Texto1.Text = ""
        'Texto1.Text = Texto1.Text & CadenaTiempoInverso & Chr(13) & Chr(10)
        'Texto1.Text = Texto1.Text & TiempoJuliano & Chr(13) & Chr(10)
        'Texto1.Text = Texto1.Text & CadenaTiempoInversoCorta & Chr(13) & Chr(10)
        'Texto1.Text = Texto1.Text & Chr(13) & Chr(10)
        'My.Computer.Audio.Play(My.Resources.Campanada, AudioPlayMode.Background)
    End Sub
    Public Sub ApagaTimer()
        FormTimer.Timer1.Enabled = False
        'Timer1.Interval = 1000
        FormTimer.FijaTimerMenu.BackColor = Nothing
        'FormTimer.TextoTimer.Visible = False
        FormTimer.FijaTimerMenu.Text = "Fija timer"
        Anotador.Texto.BackColor = ColorFijoAsignadoAFondoTablero
        Anotador.Texto.ForeColor = ColorFijoAsignadoALetraTablero
        FormTimer.TextoTimer.BackColor = Anotador.Texto.BackColor
        FormTimer.TextoTimer.ForeColor = Anotador.Texto.ForeColor
        FormTimer.BackColor = ColorFijoAsignadoAFondoTablero
        Anotador.TimerMenu.Text = "x"
        Anotador.TextoRelojTimer.Text = "00:00"
        'Anotador.TextoRelojTimer.Visible = False
    End Sub
    Public Sub FijaTimer()
        FijaTiempoJulianoActual()
        FormTimer.Timer1.Enabled = True
        FormTimer.Timer1.Interval = 1000
        FormTimer.FijaTimerMenu.BackColor = Color.Yellow
        FormTimer.FijaTimerMenu.Text = "Timer fijado " & FormTimer.FijaMinutos.Text & " minutos"
        Anotador.Texto.BackColor = ColorFijoAsignadoAFondoTablero
        Anotador.Texto.ForeColor = ColorFijoAsignadoALetraTablero
        Anotador.TimerMenu.Text = "•"
        Anotador.TextoRelojTimer.Visible = True
    End Sub
    Public Sub TickDeTimer()
        Dim Fecha As Date
        Fecha = Now()
        Dim Día As Integer = Fecha.Day
        Dim Mes As Integer = Fecha.Month
        Dim Año As Integer = Fecha.Year
        Dim Horas As Integer = Fecha.Hour
        Dim Minutos As Integer = Fecha.Minute
        Dim Segundos As Integer = Fecha.Second
        Dim DíaSemana As Integer = Fecha.DayOfWeek
        Dim Huso As Integer = 3
        Dim TiempoJuliano As Double
        Dim CadenaTiempoInverso As String = ""
        Dim CadenaTiempoInversoCorta As String = ""
        'CalculaCarta(Año, Mes, Día, Horas, Minutos, Segundos, Huso)
        Call CalculaTiempoJuliano(Año, Mes, Día, Horas, Minutos, Segundos, Huso, TiempoJuliano)
        Call CálculoTiempoInverso(TiempoJuliano, Huso, CadenaTiempoInverso, CadenaTiempoInversoCorta, CadenaTiempoInversoMuyCorta)
        FormTimer.TextoTimer.Text = ""
        FormTimer.TextoTimer.Text = FormTimer.TextoTimer.Text & CadenaTiempoInverso & Chr(13) & Chr(10)
        FormTimer.TextoTimer.Text = FormTimer.TextoTimer.Text & "Tiempo Juliano actual: " & TiempoJuliano & Chr(13) & Chr(10)
        'Texto1.Text = Texto1.Text & CadenaTiempoInversoCorta & Chr(13) & Chr(10)
        Dim TiempoQueFalta As Double = TiempoDeAlarma - TiempoJuliano
        Dim PlazoTimerEnSegundos As Integer = CInt(PlazoTimer / 0.000011574074074074073)
        Dim TiempoQueFaltaEnSegundos As Integer = CInt(TiempoQueFalta / 0.000011574074074074073)
        If TiempoQueFaltaEnSegundos < 0 Then TiempoQueFaltaEnSegundos = 0
        'Anotador.Texto1.Text = Anotador.Texto1.Text & "Faltan " & TiempoQueFaltaEnSegundos & " segundos" & Chr(13) & Chr(10)
        Dim CantidadDeMinutosQueFaltan As Integer = Int(TiempoQueFaltaEnSegundos / 60)
        Dim RestoDeSegundosSolosQueFaltan As Integer = TiempoQueFaltaEnSegundos - CantidadDeMinutosQueFaltan * 60
        'Dim TiempoSegundos As Double = TiempoQueFalta - TiempoQueFaltaEnMinutos * 0.00069444444444444447
        'Dim TiempoQueFaltaSegundos As Integer = CInt(TiempoSegundos / 0.000011574074074074067)
        FormTimer.TextoTimer.Text = FormTimer.TextoTimer.Text & "Faltan " & CantidadDeMinutosQueFaltan & " minutos y " & RestoDeSegundosSolosQueFaltan & " segundos" & Chr(13) & Chr(10)
        FormTimer.TextoTimer.Text = FormTimer.TextoTimer.Text & "para " & FormTimer.MensajeTimer.Text
        FormTimer.TextoTimer.Text = FormTimer.TextoTimer.Text & Chr(13) & Chr(10)
        FormTimer.PlazoTimer.Text = PlazoTimerEnSegundos
        FormTimer.FaltaTimer.Text = TiempoQueFaltaEnSegundos
        ActualizaTorta()


        FormTimer.CumplidoTimer.Text = PlazoTimerEnSegundos - TiempoQueFaltaEnSegundos
        FormTimer.PorCientoTimer.Text = 100 / PlazoTimerEnSegundos * (PlazoTimerEnSegundos - TiempoQueFaltaEnSegundos)
        ' FormRelojTimer.TextoReloj.Text = CantidadDeMinutosQueFaltan & ":" & RestoDeSegundosSolosQueFaltan
        'Dim HoraString As String = Formatea1(2, Fecha.Hour)
        Dim MinutoString As String = Formatea1(2, CantidadDeMinutosQueFaltan)
        Dim SegundoString As String = Formatea1(2, RestoDeSegundosSolosQueFaltan)

        'Anotador.TextoRelojTimer.Text = CantidadDeMinutosQueFaltan & ":" & RestoDeSegundosSolosQueFaltan
        Anotador.TextoRelojTimer.Text = MinutoString & ":" & SegundoString

        If TiempoJuliano > TiempoDeAlarma Then
            FormTimer.Visible = True
            FormTimer.TextoTimer.Visible = True
            'Anotador.TimerMenu.Text = "x"
            My.Computer.Audio.Play(My.Resources.Campanada, AudioPlayMode.Background)
            FormTimer.TextoTimer.Text = FormTimer.MensajeTimer.Text & Chr(13) & Chr(10) & FormTimer.TextoTimer.Text & Chr(13) & Chr(10)
            FormTimer.FijaTimerMenu.BackColor = Color.Red
            If Anotador.Texto.BackColor = ColorFijoAsignadoAFondoTablero Then
                Anotador.Texto.BackColor = SorteaColorAmplio()
                'Anotador.Texto.ForeColor = Color.FromArgb(Anotador.PorcientoGama, 255 - Anotador.Texto.BackColor.R, 255 - Anotador.Texto.BackColor.G, 255 - Anotador.Texto.BackColor.B)
                Anotador.Texto.ForeColor = ColorOpuesto(Anotador.Texto.BackColor)
                Anotador.BackColor = Anotador.Texto.BackColor
            Else
                Anotador.Texto.BackColor = ColorFijoAsignadoAFondoTablero
                Anotador.BackColor = ColorFijoAsignadoAFondoTablero
                Anotador.Texto.ForeColor = ColorFijoAsignadoALetraTablero 'ColorDeTextoAlarma 'ColorFijoAsignadoALetra
            End If
            FormTimer.TextoTimer.BackColor = ColorOpuesto(Anotador.Texto.BackColor)
            FormTimer.TextoTimer.ForeColor = ColorOpuesto(Anotador.Texto.ForeColor)
        End If
    End Sub
    Public Sub ActualizaTorta()
        If FormTimer.CheckTorta.Checked = False Then
            FormTortaTimer.Hide()
            Exit Sub
        End If

        FormTortaTimer.Show()
        FormTortaTimer.ángulo = 360 / 100 * Val(FormTimer.PorCientoTimer.Text)
        FormTortaTimer.Invalidate()
    End Sub
    Public Function PoneCeros(ByRef valor As String) As String
        valor = Mid(valor, 2, Len(valor) - 1) ''le saca el str del signo
        If Len(valor) = 1 Then
            valor = "0" + valor
            ''Right$(valor, 1) = "0"
            ''PoneCeros = valor
        End If
        PoneCeros = valor
    End Function
    Public Sub CálculoTiempoInverso(ByRef tiempoJuliano As Double, ByRef huso As Decimal, ByRef CadenaTiempoInverso As String, ByRef CadenaTiempoInversoCorta As String, ByRef CadenaTiempoInversoMuyCorta As String)
        'Dim Cadena As Object
        Dim anio As Integer
        Dim mes As Integer
        Dim diadia As Integer
        Dim horas As Integer
        Dim minutos As Integer
        Dim segundos As Integer
        Dim inversoNumSegundos As Object
        Dim inversoNumMinutos As Object
        Dim inversoNumHoras As Object
        Dim inversoNumAno As Object
        Dim inversoNumAnoCorto As Object
        Dim inversoNumMes As Object
        Dim inversoNumMesCorto As Object
        Dim inversoNumDia As Object
        Dim inversoNumDiaSemana As Object
        Dim NombreDiaSemanaActual As String
        Dim NombreDiaSemanaActualCorto As String
        Dim qq As Object
        Dim ds As Object
        Dim dia As Object
        Dim numeroMes As Object
        Dim nombreMes As Object = ""
        Dim menos As Object
        Dim a As Object
        Dim plus As Object
        Dim exced As Object
        Dim prro As Object
        Dim base As Object
        Dim ano As Object
        Dim dj As Double
        Dim restofinal As Object
        Dim segundosenteros As Object
        Dim restoMinutosNoenterosEnSegundos As Double
        Dim restoMinNoEnteros As Object
        Dim minutosEnteros As Object
        Dim restoEnMinutos As Double
        Dim restoDeTiempo As Object
        Dim soloLasHoras As Object
        Dim tiempoTotEnHoras As Object
        Dim diajulinv As Double
        Dim soloHoras As Object
        Dim u As Decimal
        Dim fecHora As Double
        'Dim Control As String
        'Esta rutina  toma como único dato de entrada la variable TiempoJuliano
        'y devuelve una cadena de caracteres denominada imprimir con el nombre del día de la semana,
        'el nombre del mes, la fecha, la hora, los minutos y los segundos.

        Dim nombreDiaSemana(7) As String
        nombreDiaSemana(1) = "sábado"
        nombreDiaSemana(2) = "domingo"
        nombreDiaSemana(3) = "lunes"
        nombreDiaSemana(4) = "martes"
        nombreDiaSemana(5) = "miércoles"
        nombreDiaSemana(6) = "jueves"
        nombreDiaSemana(7) = "viernes"
        Dim nombreDelMes(12) As String
        ''Dim mi(12)
        nombreDelMes(1) = "enero"
        nombreDelMes(2) = "febrero"
        nombreDelMes(3) = "marzo"
        nombreDelMes(4) = "abril"
        nombreDelMes(5) = "mayo"
        nombreDelMes(6) = "junio"
        nombreDelMes(7) = "julio"
        nombreDelMes(8) = "agosto "
        nombreDelMes(9) = "septiembre"
        nombreDelMes(10) = "octubre"
        nombreDelMes(11) = "noviembre"
        nombreDelMes(12) = "diciembre"
        'Control = NombreDelMes(1)
        Dim largomes(12) As Short
        largomes(1) = 31 : largomes(2) = 59 : largomes(3) = 90 : largomes(4) = 120 : largomes(5) = 151 : largomes(6) = 181
        largomes(7) = 212 : largomes(8) = 243 : largomes(9) = 273 : largomes(10) = 304 : largomes(11) = 334 : largomes(12) = 365

        ''DATA 31,ENE,59,FEB,90,MAR,120,ABR,151,MAY,181,JUN,212,JUL,243,AGO,273,SET
        ''  Data 304, Oct, 334, NOV, 365, DIC
        fecHora = tiempoJuliano
        u = -0.5
        fecHora = fecHora - huso / 24
        If (fecHora - (Int(fecHora))) < 0.5 Then u = 0.5
        soloHoras = (fecHora - Int(fecHora)) + u 'TIENE LA HORA TOTAL
        'AQUí HABRíA QUE RESTAR EL HUSO PARA TRABAJAR CON HORA Y DIA LOCAL
        ' se debe restar el huso /24
        diajulinv = fecHora - soloHoras ' OBTENEMOS DE VUELTA EL DIA JULIANO
        horas = Int(soloHoras * 24) ' SEPARAMOS LAS HORAS ENTERAS
        ''   minutos = Int((SoloHoras * 24 - Horas) * 60 + 0.5): 'OBTENEMOS LOS MINUTOS
        minutos = Int((soloHoras * 24 - horas) * 60 + 0.5) 'OBTENEMOS LOS MINUTOS

        '****proceso de los segundos  ******

        tiempoTotEnHoras = soloHoras * 24 'tiene el tiempo del dia en horas.
        soloLasHoras = Int(soloHoras * 24) 'tiene sólo las hora enteras
        restoDeTiempo = tiempoTotEnHoras - soloLasHoras 'tiene el resto de tiempo en horas
        restoEnMinutos = restoDeTiempo * 60
        minutosEnteros = Int(restoEnMinutos)
        minutos = minutosEnteros
        restoMinNoEnteros = restoEnMinutos - minutosEnteros ' agregué 2014 dic
        restoMinutosNoenterosEnSegundos = restoMinNoEnteros * 60
        segundosenteros = Int(restoMinutosNoenterosEnSegundos)
        ' como prueba de décimas de segundo?
        restofinal = restoMinutosNoenterosEnSegundos - segundosenteros
        segundos = segundosenteros
        segundos = Int(segundos * 1.725)
        If segundos = 101 Then segundos = 0
        'Segundos = Segundos * 1.7
        '**** Fin del proceso de los segundos    ******

        '************  P R O C E S O   D E    F E C H A
        If diajulinv < 2415079.5 Then dj = diajulinv - 1 : GoTo 1000
        dj = diajulinv
1000:   dj = dj - 1721013.5
        ano = Int(dj / 365.25) 'ANO TENTATIVO
        base = 367 * ano - Int(1.75 * ano)
        prro = base + 31 'PRIMERO DE ANO
        If base + 31 <= dj Then GoTo 2000
        ano = ano - 1 'ANO CORREGIDO
        anio = ano
        base = 367 * ano - Int(1.75 * ano) 'NUEVA BASE
        prro = base + 31 'PRIMERO DE ANO
2000:
        exced = (dj - prro) + 1 'DESDE EL PRIMERO DE ANO

        plus = (ano / 4 - Int(ano / 4) = 0) ^ 2 ' PLUS 1 PARA BISIESTOS
        For a = 1 To 12

            menos = (plus = 1 And a < 2) 'MENOS=-1 P/ENERO DE BISIESTOS, SI NO DA 0
            If exced <= (largomes(a) + plus + menos) Then
                nombreMes = nombreDelMes(a)
                numeroMes = a
                mes = numeroMes
                GoTo 3000
            End If
        Next a
3000:

        dia = exced - ((largomes(a - 1)) + plus + (plus = 1 And ((a - 1) < 2)))
        diadia = dia

        '************ D I A   D E   L A   S E M A N A

        ds = diajulinv - 1720996.5
        qq = ds - 7 * Int(ds / 7) + 1

        NombreDiaSemanaActual = nombreDiaSemana(qq)
        inversoNumDiaSemana = qq
        ' corrección del número dia sem para el almanaque
        inversoNumDiaSemana = inversoNumDiaSemana - 1
        If inversoNumDiaSemana = 0 Then inversoNumDiaSemana = 7
        ' fin corrección del número dia sem para el almanaque

        'If Segundos > 50 Then Minutos = Minutos - 1
        inversoNumDia = diadia
        inversoNumMes = mes
        inversoNumAno = ano
        inversoNumHoras = horas
        inversoNumMinutos = minutos
        inversoNumSegundos = segundos

        'Actualiza variables públicas para tomar de retorno por otras partes del programa
        InversoDia = inversoNumDia
        InversoAño = inversoNumAno
        InversoMes = inversoNumMes
        InversoHoras = inversoNumHoras
        InversoMinutos = inversoNumMinutos
        InversoSegundos = inversoNumSegundos
        InversoCadenaFecha = PoneCeros(Str(inversoNumDia)) & " " & PoneCeros(Str(inversoNumMes)) & Str(ano)

        ' Pone en mayúsculas la primera letra del día de la semana actual
        NombreDiaSemanaActual = UCase(Mid(NombreDiaSemanaActual, 1, 1)) & Mid(NombreDiaSemanaActual, 2)
        InversoDiaSemanaCorto = NombreDiaSemanaActual
        CadenaTiempoInverso = "Día " & PoneCeros(Str(inversoNumDia)) & " de " + nombreMes + Chr(13) + Chr(10) & "de" + Str(ano) + ". " + Chr(13) + Chr(10) & NombreDiaSemanaActual + ". " & Chr(13) + Chr(10) & PoneCeros(Str(inversoNumHoras)) + " h. " + PoneCeros(Str(inversoNumMinutos)) + " m. " + PoneCeros(Str(inversoNumSegundos)) + " s. "

        CadenaTiempoInversoCorta = PoneCeros(Str(inversoNumDia)) & " " & PoneCeros(Str(inversoNumMes)) & Str(ano) & " " & PoneCeros(Str(inversoNumHoras)) + ":" + PoneCeros(Str(inversoNumMinutos)) + ":" + PoneCeros(Str(inversoNumSegundos)) '+ "  " + NombreDiaSemanaActual

        CadenaTiempoInversoMuyCorta = Mid(NombreDiaSemanaActual, 1, 3) & " " + PoneCeros(Str(inversoNumDia)) & " " + Mid(nombreMes, 1, 3) & " " + Right(Str(ano), 2)
    End Sub
End Module
