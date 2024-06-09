Option Strict Off
Option Explicit On
Module CalculoCarta

    Public TiempoEventoActual As Double
    Public Const PI As Double = 3.141598
    Public matrdat(400) As Double ' lectura de datas
    Public MO As Double
    Public DATIN As Double ' lectura de datas
    Public S As Double ' lectura de datas
    ' Public S1 ' lectura de datas
    'Public S2 ' lectura de datas
    Public Planetas(14) As Object
    Public Casas(14) As Object
    Public Año As Integer
    Public Mes As Integer
    Public Día As Integer
    Public Horas As Integer
    Public Minutos As Integer
    Public Segundos As Integer
    Public Huso As Integer
    Dim latgrad As Integer
    Dim latminu As Integer
    Dim ns As String
    Dim longrad As Integer
    Dim longmin As Integer
    Dim eo As String
    Public Longitud As Decimal
    Public Latitud As Decimal
    Public DíaSemana As String
    'Public Casas
    'Public Planetas
    'Public CadenaTiempoInverso
    'Public CadenaTiempoInversoCorta
    Public TiempoJuliano As Double
    Public CadenaTiempoInverso As String
    Public CadenaTiempoInversoCorta As String
    Public NombreSigno(12) As String
    Public NombreDíaSemana(7) As String
    Public NombreDelMes(12) As String
    Public NombreSignoBreve(12) As String
    Public NombrePlaneta(10) As String
    Public NombrePlanetaBreve(10) As String
    Public NombresCargados As Boolean = False
    Public DatasCargadas As Boolean = False

    Public Sub CargaNombres()

        NombrePlaneta(1) = "Sol"
        NombrePlaneta(2) = "Luna"
        NombrePlaneta(3) = "Mercurio"
        NombrePlaneta(4) = "Venus"
        NombrePlaneta(5) = "Marte"
        NombrePlaneta(6) = "Júpiter"
        NombrePlaneta(7) = "Saturno"
        NombrePlaneta(8) = "Urano"
        NombrePlaneta(9) = "Neptuno"
        NombrePlaneta(10) = "Plutón"

        NombrePlanetaBreve(1) = "SO"
        NombrePlanetaBreve(2) = "LU"
        NombrePlanetaBreve(3) = "ME"
        NombrePlanetaBreve(4) = "VE"
        NombrePlanetaBreve(5) = "MA"
        NombrePlanetaBreve(6) = "JA"
        NombrePlanetaBreve(7) = "SA"
        NombrePlanetaBreve(8) = "UR"
        NombrePlanetaBreve(9) = "NE"
        NombrePlanetaBreve(10) = "PL"


        NombreSigno(1) = "Aries"
        NombreSigno(2) = "Tauro"
        NombreSigno(3) = "Géminis"
        NombreSigno(4) = "Cáncer"
        NombreSigno(5) = "Leo"
        NombreSigno(6) = "Virgo"
        NombreSigno(7) = "Libra"
        NombreSigno(8) = "Escorpio"
        NombreSigno(9) = "Sagitario"
        NombreSigno(10) = "Capricornio"
        NombreSigno(11) = "Acuario"
        NombreSigno(12) = "Piscis"

        NombreSignoBreve(1) = "AR"
        NombreSignoBreve(2) = "TA"
        NombreSignoBreve(3) = "GE"
        NombreSignoBreve(4) = "CN"
        NombreSignoBreve(5) = "LE"
        NombreSignoBreve(6) = "VI"
        NombreSignoBreve(7) = "LI"
        NombreSignoBreve(8) = "SC"
        NombreSignoBreve(9) = "SG"
        NombreSignoBreve(10) = "CP"
        NombreSignoBreve(11) = "AC"
        NombreSignoBreve(12) = "PI"

        'Dim NombreDíaSemana(7) As String
        NombreDíaSemana(1) = "sábado"
        NombreDíaSemana(2) = "domingo"
        NombreDíaSemana(3) = "lunes"
        NombreDíaSemana(4) = "martes"
        NombreDíaSemana(5) = "miércoles"
        NombreDíaSemana(6) = "jueves"
        NombreDíaSemana(7) = "viernes"
        'Dim NombreDelMes(12) As String
        ''Dim mi(12)
        NombreDelMes(1) = "enero     "
        NombreDelMes(2) = "febrero   "
        NombreDelMes(3) = "marzo     "
        NombreDelMes(4) = "abril     "
        NombreDelMes(5) = "mayo      "
        NombreDelMes(6) = "junio     "
        NombreDelMes(7) = "julio     "
        NombreDelMes(8) = "agosto    "
        NombreDelMes(9) = "septiembre"
        NombreDelMes(10) = "octubre   "
        NombreDelMes(11) = "noviembre "
        NombreDelMes(12) = "diciembre "
        'Control = NombreDelMes(1)
    End Sub

    Public Sub CalculaTiempoJuliano(ByRef Año As Integer, ByRef mes As Integer, ByRef Día As Integer, ByRef Horas As Integer, ByRef Minutos As Integer, ByRef Segundos As Integer, ByRef huso As Integer, ByRef TiempoJuliano As Double)
        Dim Tiempo As Double
        Dim JD As Double
        Dim LasHoras As Double

        LasHoras = Horas + Minutos / 100 + Segundos / 10000

        LasHoras = FNQ(LasHoras) + huso '    tiene la hora mas el huso en decimal
        JD = 367 * Año - Int(7 * (Año + Int((mes + 9) / 12)) / 4)
        JD = JD + Int(275 * mes / 9) + Día + 1721013.5
        JD = JD - 0.5 * System.Math.Sign(100 * Año + mes - 190002.5) + 0.5
        Tiempo = JD + LasHoras / 24
        TiempoJuliano = Tiempo
    End Sub
    Public Sub IngresoDatosJuanCarlos()
        Día = 26 'RegistroEventos.dia
        Mes = 1 ' RegistroEventos.mes
        Año = 1955 'RegistroEventos.ano
        Horas = 19 'RegistroEventos.horahora
        Minutos = 15 ' RegistroEventos.horamin
        Segundos = 49 '         RegistroEventos.HoraSeg()
        Huso = 3 'RegistroEventos.huso
        longrad = 58 'RegistroEventos.longrad
        longmin = 26 'RegistroEventos.longmin
        Longitud = longrad + longmin / 100
        eo = "O" 'RegistroEventos.eo
        If eo = "e" Or eo = "E" Then Longitud = -Longitud
        Longitud = FNQ(Longitud)
        latgrad = 34 'RegistroEventos.latgrad
        latminu = 36 'RegistroEventos.latminu
        Latitud = latgrad + latminu / 100
        ns = "S" 'RegistroEventos.ns
        If ns = "S" Or ns = "s" Then Latitud = -Latitud
        Latitud = FNR(FNQ(Latitud))
        'X = 0
        CalculaCarta(Año, Mes, Día, Horas, Minutos, Segundos, Huso)
    End Sub
    Public Sub IngresoDatosCartaActual()
        Dim Fecha As Date
        Fecha = Now()

        Dim X As Object
        Dim ns As String
        Dim latminu As Integer
        Dim latgrad As Integer
        Dim eo As String
        Dim longmin As Integer
        Dim longrad As Integer
        Día = Fecha.Day
        Mes = Fecha.Month
        Año = Fecha.Year
        Horas = Fecha.Hour
        Minutos = Fecha.Minute
        Segundos = Fecha.Second
        DíaSemana = Fecha.DayOfWeek
        Huso = 3
        longrad = 58
        longmin = 26
        Longitud = longrad + longmin / 100
        eo = "O"
        If eo = "e" Or eo = "E" Then Longitud = -Longitud
        Longitud = FNQ(Longitud)
        latgrad = 34
        latminu = 36
        Latitud = latgrad + latminu / 100
        ns = "S"
        If ns = "S" Or ns = "s" Then Latitud = -Latitud
        Latitud = FNR(FNQ(Latitud))
        X = 0
        CalculaCarta(Año, Mes, Día, Horas, Minutos, Segundos, Huso)
    End Sub


    Public Sub CalculaCarta(ByVal Año, ByVal mes, ByVal Día, ByVal Horas, ByVal Minutos, ByVal Segundos, ByVal huso)
        Dim SoloSolYLuna As Object
        Dim SoloSol As Object
        Dim RA As Double
        Dim OB As Double
        Dim Tiempo As Double
        'Public Sub CalculaCarta(Año, mes, Día, Horas, Minutos, Segundos, huso, Longitud, Latitud, Casas, Planetas, CadenaTiempoInverso, CadenaTiempoInversoCorta, TiempoJuliano)

        ''ObtieneDeRegistro Año, Mes, Día, Horas, Minutos, Segundos, Huso, Longitud, Latitud
        If DatasCargadas = True Then GoTo SalteaDatasyNombres
        CargaNombres()
        'IngresoDatas1() 'carga las 392 datas desde el disco (Archivo Datas.dat)
        IngresoDatasManual() 'carga las 392 datas desde el procedimiento y funciona muy bien
SalteaDatasyNombres:
        Call CalculaTiempoJuliano(Año, mes, Día, Horas, Minutos, Segundos, huso, TiempoJuliano)
        Call CálculoTiempoInverso(TiempoJuliano, huso, CadenaTiempoInverso, CadenaTiempoInversoCorta)
        ''Text1.Text = CadenaTiempoInversoCorta
        Call CálculoTiempoB(TiempoJuliano, Tiempo, OB, RA, Longitud, huso)
        ''Dim Casas(14), Planetas(14)
        Call CálculoCasas(OB, RA, Tiempo, Latitud, Casas)
        SoloSol = False
        SoloSolYLuna = False
        Call CálculoPlanetas(OB, RA, Tiempo, SoloSol, SoloSolYLuna, Planetas)
        Call SalidaImprimeListado()
    End Sub

    Public Sub CálculoTiempoInverso(ByRef TiempoJuliano As Double, ByRef huso As Decimal, ByRef CadenaTiempoInverso As String, ByRef CadenaTiempoInversoCorta As String)
        'Dim Cadena As Object
        Dim Año As Integer
        Dim Mes As Integer
        Dim Día As Integer
        Dim Horas As Integer
        Dim Minutos As Integer
        Dim Segundos As Integer
        Dim InversoNumSegundos As Object
        Dim InversoNumMinutos As Object
        Dim InversoNumHoras As Object
        Dim InversoNumAño As Object
        Dim InversoNumMes As Object
        Dim InversoNumDía As Object
        Dim InversoNumDíaSemana As Object
        Dim InversoDiaSemana As String
        Dim Q As Object
        Dim DS As Object
        Dim dia As Object
        Dim NúmeroMes As Object
        Dim NombreMes As String = ""
        Dim MENOS As Object
        Dim a As Object
        Dim PLUS As Object
        Dim EXCED As Object
        Dim PRRO As Object
        Dim LBASE As Object
        Dim ano As Object
        Dim DJ As Double
        Dim RestoFinal As Object
        Dim segundosenteros As Object
        Dim RestoDeMinutosNoenterosEnSegundos As Double
        Dim RestoMinNoEnteros As Object
        Dim MinutosEnteros As Object
        Dim RestoEnMinutos As Double
        Dim RestoDeTiempo As Object
        Dim SoloLasHoras As Object
        Dim TiempoTotEnHoras As Object
        Dim DIAJULINV As Double
        Dim SoloHoras As Object
        Dim u As Decimal
        Dim FecHora As Double
        'Dim Control As String
        'Esta rutina  toma como único dato de entrada la variable TiempoJuliano
        'y devuelve una cadena de caracteres denominada imprimir con el nombre del día de la semana,
        'el nombre del mes, la fecha, la hora, los minutos y los segundos.

        Dim NombreDíaSemana(7) As String

        NombreDíaSemana(1) = "sábado"

        NombreDíaSemana(2) = "domingo"

        NombreDíaSemana(3) = "lunes"

        NombreDíaSemana(4) = "martes"

        NombreDíaSemana(5) = "miércoles"

        NombreDíaSemana(6) = "jueves"

        NombreDíaSemana(7) = "viernes"
        Dim NombreDelMes(12) As String
        ''Dim mi(12)
        NombreDelMes(1) = "enero"
        NombreDelMes(2) = "febrero"
        NombreDelMes(3) = "marzo"
        NombreDelMes(4) = "abril"
        NombreDelMes(5) = "mayo"
        NombreDelMes(6) = "junio"
        NombreDelMes(7) = "julio"
        NombreDelMes(8) = "agosto "
        NombreDelMes(9) = "septiembre"
        NombreDelMes(10) = "octubre"
        NombreDelMes(11) = "noviembre"
        NombreDelMes(12) = "diciembre"
        'Control = NombreDelMes(1)
        Dim MI(12) As Short
        MI(1) = 31 : MI(2) = 59 : MI(3) = 90 : MI(4) = 120 : MI(5) = 151 : MI(6) = 181
        MI(7) = 212 : MI(8) = 243 : MI(9) = 273 : MI(10) = 304 : MI(11) = 334 : MI(12) = 365

        ''DATA 31,ENE,59,FEB,90,MAR,120,ABR,151,MAY,181,JUN,212,JUL,243,AGO,273,SET
        ''  Data 304, Oct, 334, NOV, 365, DIC
        FecHora = TiempoJuliano
        u = -0.5
        FecHora = FecHora - huso / 24
        If (FecHora - (Int(FecHora))) < 0.5 Then u = 0.5
        SoloHoras = (FecHora - Int(FecHora)) + u 'TIENE LA HORA TOTAL
        'AQUí HABRíA QUE RESTAR EL HUSO PARA TRABAJAR CON HORA Y DIA LOCAL
        ' se debe restar el huso /24
        DIAJULINV = FecHora - SoloHoras ' OBTENEMOS DE VUELTA EL DIA JULIANO
        Horas = Int(SoloHoras * 24) ' SEPARAMOS LAS HORAS ENTERAS
        ''   minutos = Int((SoloHoras * 24 - Horas) * 60 + 0.5): 'OBTENEMOS LOS MINUTOS
        Minutos = Int((SoloHoras * 24 - Horas) * 60 + 0.5) 'OBTENEMOS LOS MINUTOS

        '****proceso de los segundos ( En ensayo por ahora) ******
        ''segundos = Int((SoloHoras * 24 - Horas - minutos / 60) * 60 + 0.5)
        ''segundos = Int((SoloHoras * 24 - Horas - (minutos / 60)) * 3600)
        TiempoTotEnHoras = SoloHoras * 24 'tiene el tiempo del dia en horas.
        SoloLasHoras = Int(SoloHoras * 24) 'tiene sólo las hora enteras
        RestoDeTiempo = TiempoTotEnHoras - SoloLasHoras 'tiene el resto de tiempo en horas
        RestoEnMinutos = RestoDeTiempo * 60
        MinutosEnteros = Int(RestoEnMinutos)
        Minutos = MinutosEnteros
        RestoMinNoEnteros = RestoEnMinutos - MinutosEnteros ' agregué 2014 dic
        RestoDeMinutosNoenterosEnSegundos = RestoMinNoEnteros * 60
        segundosenteros = Int(RestoDeMinutosNoenterosEnSegundos)
        ' como prueba de décimas de segundo?
        RestoFinal = RestoDeMinutosNoenterosEnSegundos - segundosenteros
        Segundos = segundosenteros
        Segundos = Int(Segundos * 1.725)
        If Segundos = 101 Then Segundos = 0
        'Segundos = Segundos * 1.7
        '**** Fin del proceso de los segundos    ******

        ' horainv = Horas + minutos / 100: 'TIENE LA HORA + LOS MIN EN SEXAGESIMAL ' esta instr es la que estaba sin los segundos
        '''''' horainv = Horas + minutos / 100 + Segundos / 10000: 'TIENE LA HORA + LOS MIN  + LOS SEG EN SEXAGESIMAL 'Esta es con los segundos incluídos

        ''''''''    horainv = FNQ(horainv): 'TIENE LA HORA CON LOS MIN EN DECIMAL

        '************  P R O C E S O   D E    F E C H A

        If DIAJULINV < 2415079.5 Then DJ = DIAJULINV - 1 : GoTo 1000
        DJ = DIAJULINV
1000:   DJ = DJ - 1721013.5
        ano = Int(DJ / 365.25) 'ANO TENTATIVO
        LBASE = 367 * ano - Int(1.75 * ano)
        PRRO = LBASE + 31 'PRIMERO DE ANO
        If LBASE + 31 <= DJ Then GoTo 2000
        ano = ano - 1 'ANO CORREGIDO
        Año = ano
        LBASE = 367 * ano - Int(1.75 * ano) 'NUEVA BASE
        PRRO = LBASE + 31 'PRIMERO DE ANO
2000:
        EXCED = (DJ - PRRO) + 1 'DESDE EL PRIMERO DE ANO

        PLUS = (ano / 4 - Int(ano / 4) = 0) ^ 2 ' PLUS 1 PARA BISIESTOS
        For a = 1 To 12

            MENOS = (PLUS = 1 And a < 2) 'MENOS=-1 P/ENERO DE BISIESTOS, SI NO DA 0
            If EXCED <= (MI(a) + PLUS + MENOS) Then
                NombreMes = NombreDelMes(a)


                NúmeroMes = a
                Mes = NúmeroMes
                GoTo 3000
            End If
        Next a
3000:

        dia = EXCED - ((MI(a - 1)) + PLUS + (PLUS = 1 And ((a - 1) < 2)))
        Día = dia
        '             LPRINT DIA; MES$; ANO
        '************ D I A   D E   L A   S E M A N A

        DS = DIAJULINV - 1720996.5
        Q = DS - 7 * Int(DS / 7) + 1

        InversoDiaSemana = NombreDíaSemana(Q)
        InversoNumDíaSemana = Q
        ' corrección del número dia sem para el almanaque
        InversoNumDíaSemana = InversoNumDíaSemana - 1
        If InversoNumDíaSemana = 0 Then InversoNumDíaSemana = 7
        ' fin corrección del número dia sem para el almanaque

        'If Segundos > 50 Then Minutos = Minutos - 1
        InversoNumDía = Día
        InversoNumMes = Mes
        InversoNumAño = Año
        InversoNumHoras = Horas
        InversoNumMinutos = Minutos
        InversoNumSegundos = Segundos



        CadenaTiempoInverso = "Día " & InversoDiaSemana & " " & Str(dia) & " de  " + NombreMes + "  de  " + Str(ano) + "; " + Chr(13) + Chr(10) + Str(InversoNumHoras) + " hs. " + Str(InversoNumMinutos) + " min. " + Str(InversoNumSegundos) + " seg. "
        CadenaTiempoInversoCorta = PoneCeros(Str(InversoNumDía)) & " " & PoneCeros(Str(InversoNumMes)) & " " & PoneCeros(Str(InversoNumAño)) & " " & PoneCeros(Str(InversoNumHoras)) + ":" + PoneCeros(Str(InversoNumMinutos)) + ":" + PoneCeros(Str(InversoNumSegundos)) + "  " + InversoDiaSemana
        'CadenaTiempoInversoHorario = PoneCeros(Str$(InversoNumHoras)) + ":" + PoneCeros(Str$(InversoNumMinutos)) + ":" + PoneCeros(Str$(InversoNumSegundos))

    End Sub

    Public Function SalidaFormateaDatos(ByVal DatoDeTiempo As Decimal)
        ' entra Dato Z
        Dim GradosEnteros As Integer
        Dim Numsigno As Integer
        Dim Excedente1 As Decimal
        Dim Excedente2 As Decimal
        Dim GradosEnSigno As Integer
        Dim Decimales As Decimal
        Dim Paraminutos As Decimal
        Dim MinutosEnteros As Integer
        Dim Parasegundos As Decimal
        Dim SegundosEnteros As Integer
        GradosEnteros = Int(DatoDeTiempo) 'DatoEnteros Z3 tiene los grados enteros completos
        Numsigno = Int(GradosEnteros / 30) + 1  ' Numsigno Q obtiene el n£mero del signo zodiacal
        Excedente1 = (GradosEnteros / 30 - Int(GradosEnteros / 30)) * 30 'Excedente1 auxil saca el excedente luego del signo
        Excedente2 = FNW(Excedente1) 'Excedente2 aux
        GradosEnSigno = Int(Excedente2)  'GradosEnSigno Z1 tiene los grados enteros luego del signo
        Dim X$ = Right$(Str$(GradosEnSigno), 2)
        If GradosEnSigno < 10 Then X$ = "0" + Right$(X$, 1)
        Decimales = DatoDeTiempo - GradosEnteros 'Decimales decimales es el total menos el int del total, da los decimales
        Paraminutos = Decimales * 60
        MinutosEnteros = Int(Paraminutos)
        Dim minu$ = Right$(Str$(MinutosEnteros), 2)
        If Val(minu$) < 10 Then minu$ = "0" + Right$(minu$, 1)
        Parasegundos = Paraminutos - Minutos
        SegundosEnteros = Int(Parasegundos * 60 + 0.5)
        'SegundosEnteros = Int(Parasegundos / 100 * 60 + 0.5) ' agregue el /100 2014 dic
        Dim segun$ = Right$(Str$(SegundosEnteros), 2)
        If Val(segun$) < 10 Then segun$ = "0" + Right$(segun$, 1)

        Return X$ + NombreSignoBreve(Numsigno) + minu$ + " " + segun$ + "''"

    End Function
    Private Function PoneCeros(ByRef valor As String) As String
        valor = Mid(valor, 2, Len(valor) - 1) ''le saca el str del signo
        If Len(valor) = 1 Then
            valor = "0" + valor
            ''Right$(valor, 1) = "0"
            ''PoneCeros = valor
        End If
        PoneCeros = valor
    End Function
    Private Sub IngresoDatas1()
        Dim ArchivoDatas As Object
        Dim PathPrincipal As Object
        Dim I As Object
        '' Dim matrdat(400)
        I = 0
        PathPrincipal = "C:\Tempus"
        ArchivoDatas = PathPrincipal + "\datas\datas.dat"
        FileOpen(5, ArchivoDatas, OpenMode.Input)

        Do While Not EOF(5)
            Input(5, matrdat(I))
            I = I + 1
        Loop
        FileClose(5)
    End Sub

    Private Sub IngresoDatasManual()
        'Dim BaseDatas = 0
        matrdat(0) = 358.4758
        matrdat(1) = 35999.0498
        matrdat(2) = -0.0002
        matrdat(3) = 0.01675
        matrdat(4) = -0.00004
        matrdat(5) = 0
        matrdat(6) = 1
        matrdat(7) = 101.2208
        matrdat(8) = 1.7192
        matrdat(9) = 0.0005
        matrdat(10) = 0
        matrdat(11) = 0
        matrdat(12) = 0
        matrdat(13) = 0
        matrdat(14) = 0
        matrdat(15) = 0
        matrdat(16) = 102.2794
        matrdat(17) = 149472.5151
        matrdat(18) = 0
        matrdat(19) = 0.20561
        matrdat(20) = 0.00002
        matrdat(21) = 0
        matrdat(22) = 0.387098
        matrdat(23) = 28.7538
        matrdat(24) = 0.3703
        matrdat(25) = 1
        matrdat(26) = 47.1459
        matrdat(27) = 1.185
        matrdat(28) = 0.0002
        matrdat(29) = 7.0029
        matrdat(30) = 0.0019
        matrdat(31) = -0.00002
        matrdat(32) = 212.6032
        matrdat(33) = 58517.8039
        matrdat(34) = 0.0013
        matrdat(35) = 0.00682
        matrdat(36) = -0.00005
        matrdat(37) = 0
        matrdat(38) = 0.7233
        matrdat(39) = 54.3842
        matrdat(40) = 0.5082
        matrdat(41) = -0.0014
        matrdat(42) = 75.7796
        matrdat(43) = 0.8999
        matrdat(44) = 0.0004
        matrdat(45) = 3.3936
        matrdat(46) = 0.001
        matrdat(47) = 0
        matrdat(48) = 319.5294
        matrdat(49) = 19139.8585
        matrdat(50) = 0.0002
        matrdat(51) = 0.09331
        matrdat(52) = 0.00009
        matrdat(53) = 0
        matrdat(54) = 1.5237
        matrdat(55) = 285.4318
        matrdat(56) = 1.0698
        matrdat(57) = 0.0001
        matrdat(58) = 48.7864
        matrdat(59) = 0.77099
        matrdat(60) = 0
        matrdat(61) = 1.8503
        matrdat(62) = -0.0007
        matrdat(63) = 0
        matrdat(64) = 225.4928
        matrdat(65) = 3033.6879
        matrdat(66) = 0
        matrdat(67) = 0.04838
        matrdat(68) = -0.00002
        matrdat(69) = 0
        matrdat(70) = 5.2029
        matrdat(71) = 273.393
        matrdat(72) = 1.3383
        matrdat(73) = 0
        matrdat(74) = 99.4198
        matrdat(75) = 1.0583
        matrdat(76) = 0
        matrdat(77) = 1.3097
        matrdat(78) = -0.0052
        matrdat(79) = 0
        matrdat(80) = -0.001
        matrdat(81) = -0.0005
        matrdat(82) = 0.0045
        matrdat(83) = 0.0051
        matrdat(84) = 581.7
        matrdat(85) = -9.7
        matrdat(86) = -0.0005
        matrdat(87) = 2510.7
        matrdat(88) = -12.5
        matrdat(89) = -0.0026
        matrdat(90) = 1313.7
        matrdat(91) = -61.4
        matrdat(92) = 0.0013
        matrdat(93) = 2370.79
        matrdat(94) = -24.6
        matrdat(95) = -0.0013
        matrdat(96) = 3599.3
        matrdat(97) = 37.7
        matrdat(98) = -0.001
        matrdat(99) = 2574.7
        matrdat(100) = 31.4
        matrdat(101) = -0.00096
        matrdat(102) = 6708.2
        matrdat(103) = -114.5
        matrdat(104) = -0.0006
        matrdat(105) = 5499.4
        matrdat(106) = -74.97
        matrdat(107) = -0.0013
        matrdat(108) = 1419
        matrdat(109) = 54.2
        matrdat(110) = 0.0006
        matrdat(111) = 6339.3
        matrdat(112) = -109
        matrdat(113) = 0.0007
        matrdat(114) = 4824.5
        matrdat(115) = -50.9
        matrdat(116) = 0.002
        matrdat(117) = -0.0134
        matrdat(118) = 0.0127
        matrdat(119) = -0.0023
        matrdat(120) = 676.2
        matrdat(121) = 0.9
        matrdat(122) = 0.00045
        matrdat(123) = 2361.4
        matrdat(124) = 174.9
        matrdat(125) = 0.0015
        matrdat(126) = 1427.5
        matrdat(127) = -188.8
        matrdat(128) = 0.0006
        matrdat(129) = 2110.1
        matrdat(130) = 153.6
        matrdat(131) = 0.0014
        matrdat(132) = 3606.8
        matrdat(133) = -57.7
        matrdat(134) = -0.0017
        matrdat(135) = 2540.2
        matrdat(136) = 121.7
        matrdat(137) = -0.00099
        matrdat(138) = 6704.8
        matrdat(139) = -22.3
        matrdat(140) = -0.0006
        matrdat(141) = 5480.2
        matrdat(142) = 24.5
        matrdat(143) = 0.00096
        matrdat(144) = 1651.3
        matrdat(145) = -118.3
        matrdat(146) = 0.0006
        matrdat(147) = 6310.8
        matrdat(148) = -4.8
        matrdat(149) = 0.0007
        matrdat(150) = 4826.6
        matrdat(151) = 36.2
        matrdat(152) = 174.2153
        matrdat(153) = 1223.50796
        matrdat(154) = 0
        matrdat(155) = 0.05423
        matrdat(156) = -0.0002
        matrdat(157) = 0
        matrdat(158) = 9.5525
        matrdat(159) = 338.9117
        matrdat(160) = -0.3167
        matrdat(161) = 0
        matrdat(162) = 112.8261
        matrdat(163) = 0.8259
        matrdat(164) = 0
        matrdat(165) = 2.4908
        matrdat(166) = -0.0047
        matrdat(167) = 0
        matrdat(168) = -0.0009
        matrdat(169) = 0.0037
        matrdat(170) = 0
        matrdat(171) = 0.0134
        matrdat(172) = 1238.9
        matrdat(173) = -16.4
        matrdat(174) = -0.00426
        matrdat(175) = 3040.9
        matrdat(176) = -25.2
        matrdat(177) = 0.0064
        matrdat(178) = 1835.3
        matrdat(179) = 36.1
        matrdat(180) = -0.0153
        matrdat(181) = 610.8
        matrdat(182) = -44.2
        matrdat(183) = -0.0015
        matrdat(184) = 2480.5
        matrdat(185) = -69.4
        matrdat(186) = -0.0014
        matrdat(187) = 0.0026
        matrdat(188) = 0
        matrdat(189) = 0.0111
        matrdat(190) = 1242.2
        matrdat(191) = 78.3
        matrdat(192) = -0.0045
        matrdat(193) = 3034.96
        matrdat(194) = 62.8
        matrdat(195) = -0.0066
        matrdat(196) = 1829.2
        matrdat(197) = -51.5
        matrdat(198) = -0.0078
        matrdat(199) = 640.6
        matrdat(200) = 24.2
        matrdat(201) = -0.0016
        matrdat(202) = 2363.4
        matrdat(203) = -141.4
        matrdat(204) = 0.0006
        matrdat(205) = -0.0002
        matrdat(206) = 0
        matrdat(207) = -0.0005
        matrdat(208) = 1251.1
        matrdat(209) = 43.7
        matrdat(210) = 0.0005
        matrdat(211) = 622.8
        matrdat(212) = 13.7
        matrdat(213) = 0.0003
        matrdat(214) = 1824.7
        matrdat(215) = -71.1
        matrdat(216) = 0.0001
        matrdat(217) = 2997.1
        matrdat(218) = 78.2
        matrdat(219) = 74.1757
        matrdat(220) = 427.2742
        matrdat(221) = 0
        matrdat(222) = 0.04682
        matrdat(223) = 0.00042
        matrdat(224) = 0
        matrdat(225) = 19.2215
        matrdat(226) = 95.6863
        matrdat(227) = 2.0508
        matrdat(228) = 0
        matrdat(229) = 73.5222
        matrdat(230) = 0.5242
        matrdat(231) = 0
        matrdat(232) = 0.7726
        matrdat(233) = 0.0001
        matrdat(234) = 0
        matrdat(235) = -0.0021
        matrdat(236) = -0.0159
        matrdat(237) = 0
        matrdat(238) = 0.0299
        matrdat(239) = 422.3
        matrdat(240) = -17.7
        matrdat(241) = -0.0049
        matrdat(242) = 3035.1
        matrdat(243) = -31.3
        matrdat(244) = -0.0038
        matrdat(245) = 945.3
        matrdat(246) = 60.1
        matrdat(247) = -0.0023
        matrdat(248) = 1227
        matrdat(249) = -4.99
        matrdat(250) = 0.0134
        matrdat(251) = -0.02186
        matrdat(252) = 0
        matrdat(253) = 0.0317
        matrdat(254) = 404.3
        matrdat(255) = 81.9
        matrdat(256) = -0.00495
        matrdat(257) = 3037.9
        matrdat(258) = 57.3
        matrdat(259) = 0.004
        matrdat(260) = 993.5
        matrdat(261) = -54.4
        matrdat(262) = -0.0018
        matrdat(263) = 1249.4
        matrdat(264) = 79.2
        matrdat(265) = -0.0003
        matrdat(266) = 0.0005
        matrdat(267) = 0
        matrdat(268) = 0.0005
        matrdat(269) = 352.5
        matrdat(270) = -54.99
        matrdat(271) = 0.0001
        matrdat(272) = 3027.5
        matrdat(273) = 54.2
        matrdat(274) = -0.0001
        matrdat(275) = 1150.3
        matrdat(276) = -88
        matrdat(277) = 30.13294
        matrdat(278) = 240.45516
        matrdat(279) = 0
        matrdat(280) = 0.00913
        matrdat(281) = -0.00127
        matrdat(282) = 0
        matrdat(283) = 30.11375
        matrdat(284) = 284.1683
        matrdat(285) = -21.6329
        matrdat(286) = 0
        matrdat(287) = 130.68415
        matrdat(288) = 1.1005
        matrdat(289) = 0
        matrdat(290) = 1.7794
        matrdat(291) = -0.0098
        matrdat(292) = 0
        matrdat(293) = 0.1832
        matrdat(294) = -0.6718
        matrdat(295) = 0.2726
        matrdat(296) = -0.1923
        matrdat(297) = 175.7
        matrdat(298) = 31.8
        matrdat(299) = 0.0122
        matrdat(300) = 542.1
        matrdat(301) = 189.6
        matrdat(302) = 0.0027
        matrdat(303) = 1219.4
        matrdat(304) = 178.1
        matrdat(305) = -0.00496
        matrdat(306) = 3035.6
        matrdat(307) = -31.3
        matrdat(308) = -0.1122
        matrdat(309) = 0.166
        matrdat(310) = -0.0544
        matrdat(311) = -0.00496
        matrdat(312) = 3035.3
        matrdat(313) = 58.7
        matrdat(314) = 0.0961
        matrdat(315) = 177.1
        matrdat(316) = -68.8
        matrdat(317) = -0.0073
        matrdat(318) = 630.9
        matrdat(319) = 51
        matrdat(320) = -0.0025
        matrdat(321) = 1236.6
        matrdat(322) = 78
        matrdat(323) = 0.00196
        matrdat(324) = -0.0119
        matrdat(325) = 0.0111
        matrdat(326) = 0.0001
        matrdat(327) = 3049.3
        matrdat(328) = 44.2
        matrdat(329) = -0.0002
        matrdat(330) = 893.9
        matrdat(331) = 48.5
        matrdat(332) = 0.00007
        matrdat(333) = 1416.5
        matrdat(334) = -25.2
        matrdat(335) = 229.781
        matrdat(336) = 145.1781
        matrdat(337) = 0
        matrdat(338) = 0.24797
        matrdat(339) = 0.002898
        matrdat(340) = 0
        matrdat(341) = 39.539
        matrdat(342) = 113.5366
        matrdat(343) = 0.2086
        matrdat(344) = 0
        matrdat(345) = 108.944
        matrdat(346) = 1.3739
        matrdat(347) = 0
        matrdat(348) = 17.1514
        matrdat(349) = -0.0161
        matrdat(350) = 0
        matrdat(351) = -0.0426
        matrdat(352) = 0.073
        matrdat(353) = -0.029
        matrdat(354) = 0.0371
        matrdat(355) = 372
        matrdat(356) = -331.3
        matrdat(357) = -0.0049
        matrdat(358) = 3049.6
        matrdat(359) = -39.2
        matrdat(360) = -0.0108
        matrdat(361) = 566.2
        matrdat(362) = 318.3
        matrdat(363) = 0.0003
        matrdat(364) = 1746.5
        matrdat(365) = -238.3
        matrdat(366) = -0.0603
        matrdat(367) = 0.5002
        matrdat(368) = -0.6126
        matrdat(369) = 0.049
        matrdat(370) = 273.97
        matrdat(371) = 89.97
        matrdat(372) = -0.0049
        matrdat(373) = 3030.6
        matrdat(374) = 61.3
        matrdat(375) = 0.0027
        matrdat(376) = 1075.3
        matrdat(377) = -28.1
        matrdat(378) = -0.0007
        matrdat(379) = 1402.3
        matrdat(380) = 20.3
        matrdat(381) = 0.0145
        matrdat(382) = -0.0928
        matrdat(383) = 0.1195
        matrdat(384) = 0.0117
        matrdat(385) = 302.6
        matrdat(386) = -77.3
        matrdat(387) = 0.00198
        matrdat(388) = 528.1
        matrdat(389) = 48.6
        matrdat(390) = -0.0002
        matrdat(391) = 1000.4
        matrdat(392) = -46.1
    End Sub

    Public Function FND(ByRef X As Double) As Double
        FND = X * 180 / PI
    End Function
    Public Function FNQ(ByRef X As Double) As Double
        FNQ = System.Math.Sign(X) * (Int(System.Math.Abs(X)) + (System.Math.Abs(X) - Int(System.Math.Abs(X))) * 100 / 60)
    End Function
    Public Function FNR(ByRef X As Double) As Double
        FNR = X * PI / 180
    End Function
    Public Function FNS(ByRef X As Double) As Double
        FNS = System.Math.Sin(X * PI / 180)
    End Function
    Public Function FNU(ByRef X As Double) As Double
        FNU = X - (Int(X / MO) * MO)
    End Function
    Public Function FNW(ByRef X As Double) As Double
        FNW = Int(X * 100 + 0.5) / 100
    End Function
    Private Function FNX(ByRef X As Double) As Double
        FNX = System.Math.Atan(X / System.Math.Sqrt(1 - X * X))
    End Function
    Private Function FNY(ByRef X As Double) As Double
        FNY = System.Math.Atan(System.Math.Sqrt(1 - X * X) / X)
    End Function
    Private Sub CálculoPlanetas(ByRef OB As Object, ByRef RA As Object, ByRef Tiempo As Double, ByRef SoloSol As Object, ByRef SoloSolYLuna As Object, ByRef Planetas As Object)
        Dim Z1 As Double ' ojo no tiene valor
        Dim Y1 As Double ' ojo no tiene valor
        Dim X1 As Double ' ojo no tiene valor
        Dim XK As Double
        Dim SS As Double
        Dim C As Double
        Dim k As Double
        Dim BR As Double
        Dim W As Double
        Dim v As Double
        Dim u As Double
        Dim ij As Integer
        Dim ik As Integer
        Dim ZZ As Double
        Dim Yy As Double
        Dim Xx As Double
        Dim ZW As Double
        Dim ab As Double
        Dim ZA As Double
        Dim YA As Double
        Dim xa As Double
        Dim ZH As Double
        Dim YH As Double
        Dim XH As Double
        Dim a As Double
        Dim R As Double
        Dim X As Double
        Dim INum As Double
        Dim AN As Double
        Dim AP As Double
        Dim YW As Double
        Dim XW As Double
        Dim E1 As Double
        Dim au As Double
        Dim aun As Integer
        Dim EA As Double
        Dim e As Double
        Dim S2 As Decimal
        Dim S1 As Decimal
        Dim SD As Decimal = 0 ' Ojo no tiene valor
        Dim LT As Double
        Dim p As Double
        Dim Y As Double
        Dim ML As Double
        Dim F As Double
        Dim L1 As Double
        Dim d As Double
        Dim L As Double
        Dim G1 As Double
        Dim m As Double
        Dim g As Double
        Dim LL As Double
        Dim NúmeroPlaneta As Integer
        Dim NU As Double
        Dim ms As Double
        Dim LN As Double
        Dim limpiar As Integer

        Dim kum(12) As Object
        Dim t(13) As Object
        Dim Mm(13) As Object

        DATIN = 0
        For limpiar = 1 To 14
            ''Casas(limpiar) = 0
            Planetas(limpiar) = 0
        Next limpiar

        Planetas(11) = FNU((933060 - 6962911 * Tiempo + 7.5 * Tiempo * Tiempo) / 3600)

        '   -----------------------------------*------------------------------------
        '   ------------------------------------------------------------------------
        '   ­­­­­­­­­­­­­­ C A L C U L O   D E   L O S   P L A N E T A S ­­­­­­­­­­­
        '   ------------------------------------------------------------------------
        '   ------------------------CUERPO CENTRAL---------------------------------
        '155
        LN = FNU(259.1833 - 1934.1419 * Tiempo)

        NU = (-(17.2327 + 0.01737 * Tiempo) * FNS(LN) - 1.273 * FNS(2 * ms)) / 3600
        For NúmeroPlaneta = 1 To 10 'era to 10
            ''If NúmeroPlaneta = 2 Then GoTo 108'ERA ASÍ

            If NúmeroPlaneta = 2 And SoloSol = False Then
                ' GoTo CalculaLuna Estos son los cálculos de la Luna

                MO = 360

                LL = 973563 + 1732564379 * Tiempo - 4 * Tiempo * Tiempo
                g = 1012395 + 6189 * Tiempo
                m = 3600
                G1 = 1203586 + 14648523 * Tiempo - 37 * Tiempo * Tiempo
                L = (LL - G1) / m
                d = 1262655 + 1602961611 * Tiempo - 5 * Tiempo * Tiempo
                L1 = ((LL - d) - g) / m
                F = (LL - LN * m) / m
                ML = 22639.6 * FNS(L)
                d = d / m
                Y = 2 * d
                ML = ML - 4586.4 * FNS(L - Y) + 2369.9 * FNS(Y) + 769 * FNS(2 * L) - 669 * FNS(L1)
                ML = ML - 411.6 * FNS(2 * F) - 212 * FNS(2 * L - Y) - 206 * FNS(L + L1 - Y) + 192 * FNS(L + Y)
                ML = ML - 165 * FNS(L1 - Y) + 148 * FNS(L - L1) - 125 * FNS(d) - 110 * FNS(L + L1)
                p = 18465 * FNS(F) + 1010 * FNS(L + F) - 999 * FNS(F - L) - 624 * FNS(F - Y) + 199 * FNS(F + Y - L)
                p = p - 167 * FNS(L + F - Y) + 117 * FNS(F + Y) + 62 * FNS(2 * L + F) - 33 * FNS(F - Y - L)

                LT = (p - 32 * FNS(F - 2 * L) - 30 * FNS(L1 + F - Y) - 45 * FNS(L + 2 * F) + 40 * FNS(L - 2 * F)) / m

                Mm(2) = LT
                Planetas(2) = FNU((LL + ML - 55 * FNS(2 * F - Y)) / m + SD)

                Planetas(11) = FNU(LN + SD)
                If SoloSolYLuna = True Then
                    SoloSolYLuna = False : Exit Sub
                End If
                GoTo 151 'va al next de númeroplanetas
            End If
            If NúmeroPlaneta = 2 And SoloSol = True Then 'ESTA ES LA LLAVE PARA SALIR  CON SÓLO EL SOL
                SoloSol = False 'PARA SALIR  CON SÓLO EL SOL
                Exit Sub 'PARA SALIR  CON SÓLO EL SOL
            End If 'PARA SALIR  CON SÓLO EL SOL
            'PARA SALIR  CON SÓLO EL SOL
            MO = 2 * PI
            '     llama a subrutina para lectura data **************
            'GoSub LeeDatas '1
            S = matrdat(DATIN)
            DATIN = DATIN + 1
            S1 = matrdat(DATIN)
            DATIN = DATIN + 1
            S2 = matrdat(DATIN)
            DATIN = DATIN + 1
            S = FNR(S + S1 * Tiempo + S2 * Tiempo * Tiempo)
            'fin LeeDatas 1
            'Call LecturaDeDatas ' 1
            'Call A103:'1
            m = FNU(S)
            '     llama a subrutina para lectura data **************
            'GoSub LeeDatas '2
            S = matrdat(DATIN)
            DATIN = DATIN + 1
            S1 = matrdat(DATIN)
            DATIN = DATIN + 1
            S2 = matrdat(DATIN)
            DATIN = DATIN + 1
            S = FNR(S + S1 * Tiempo + S2 * Tiempo * Tiempo)
            'fin LeeDatas 2
            'Call LecturaDeDatas ' 2
            'Call A103:'2
            e = FND(S)
            EA = m
            For aun = 1 To 5
                EA = m + e * System.Math.Sin(EA)
            Next aun
            '  READ AU
            '  IF DATIN > 391 THEN DATIN = 0
            au = matrdat(DATIN)
            DATIN = DATIN + 1
            E1 = 0.01720209 / (au ^ 1.5 * (1 - e * System.Math.Cos(EA)))
            '     llama a subrutina para lectura data **************
            'GoSub LeeDatas '3
            S = matrdat(DATIN)
            DATIN = DATIN + 1
            S1 = matrdat(DATIN)
            DATIN = DATIN + 1
            S2 = matrdat(DATIN)
            DATIN = DATIN + 1
            S = FNR(S + S1 * Tiempo + S2 * Tiempo * Tiempo)
            'fin LeeDatas 3
            'Call LecturaDeDatas ' 3
            'Call A103:'3
            XW = -(au * E1) * System.Math.Sin(EA)
            AP = S
            '     llama a subrutina para lectura data ***************
            'GoSub LeeDatas '4
            S = matrdat(DATIN)
            DATIN = DATIN + 1
            S1 = matrdat(DATIN)
            DATIN = DATIN + 1

            S2 = matrdat(DATIN)
            DATIN = DATIN + 1

            S = FNR(S + S1 * Tiempo + S2 * Tiempo * Tiempo)
            'fin LeeDatas 4
            'Call LecturaDeDatas ' 4
            'Call A103:'4
            AN = S
            '     llama a subrutina para lectura data ***************
            'GoSub LeeDatas '5
            S = matrdat(DATIN)
            DATIN = DATIN + 1
            S1 = matrdat(DATIN)
            DATIN = DATIN + 1
            S2 = matrdat(DATIN)
            DATIN = DATIN + 1
            S = FNR(S + S1 * Tiempo + S2 * Tiempo * Tiempo)
            'fin LeeDatas 5
            'Call LecturaDeDatas ' 5
            'Call A103:'5
            INum = S
            X = XW
            Y = YW
            '     llama a subrutina de cálculo  * * * *
            'GoSub 105 '1
            '105       'GoSub 106
            If Y = 0 Then Y = 0.0000000017
            R = (X * X + Y * Y) ^ 0.5
            a = System.Math.Atan(Y / X)
            If a < 0 Then a = a + PI
            If Y < 0 Then a = a + PI
            ' fin del gosub 106
            a = a + AP
            '   llamada a calculo auxiliar para a
            '  GoSub 104
            If a = 0 Then a = 0.0000000017
            X = R * System.Math.Cos(a)
            Y = R * System.Math.Sin(a)
            'fin del GoSub 104
            d = X
            X = Y
            Y = 0
            '   llamada a cálculo auxiliar para ano
            'GoSub 106
            If Y = 0 Then Y = 0.0000000017
            R = (X * X + Y * Y) ^ 0.5
            a = System.Math.Atan(Y / X)
            If a < 0 Then a = a + PI
            If Y < 0 Then a = a + PI
            ' fin del gosub 106
            a = a + INum
            '   llamada a calculo auxiliar para a
            '  GoSub 104
            If a = 0 Then a = 0.0000000017
            X = R * System.Math.Cos(a)
            Y = R * System.Math.Sin(a)
            'fin del GoSub 104
            g = Y
            Y = X
            X = d
            '   llamada a cálculo auxiliar para ano
            'GoSub 106
            If Y = 0 Then Y = 0.0000000017
            R = (X * X + Y * Y) ^ 0.5
            a = System.Math.Atan(Y / X)
            If a < 0 Then a = a + PI
            If Y < 0 Then a = a + PI
            ' fin del gosub 106
            a = a + AN
            If a < 0 Then a = a + 2 * PI
            '   llamada a calculo auxiliar para a
            '  GoSub 104
            If a = 0 Then a = 0.0000000017
            X = R * System.Math.Cos(a)
            Y = R * System.Math.Sin(a)
            'fin del GoSub 104
            ' fin del gosub 105
            XH = X
            YH = Y
            ZH = g
            MO = 360
            If NúmeroPlaneta = 1 Then
                xa = -XH
                YA = -YH
                ZA = -ZH
                ab = 0 : GoTo 107
            End If
            '116
            XW = XH + xa
            YW = YH + YA
            ZW = ZH + ZA
107:
            X = au * (System.Math.Cos(EA) - e)
            Y = au * System.Math.Sin(EA) * (1 - e * e) ^ 0.5
            '     llama a subrutina de cálculo * * * * *
            'GoSub 105 '2
            '105       'GoSub 106
            If Y = 0 Then Y = 0.0000000017
            R = (X * X + Y * Y) ^ 0.5
            a = System.Math.Atan(Y / X)
            If a < 0 Then a = a + PI
            If Y < 0 Then a = a + PI
            ' fin del gosub 106
            a = a + AP
            '   llamada a calculo auxiliar para a
            '  GoSub 104
            If a = 0 Then a = 0.0000000017
            X = R * System.Math.Cos(a)
            Y = R * System.Math.Sin(a)
            'fin del GoSub 104
            d = X
            X = Y
            Y = 0
            '   llamada a cálculo auxiliar para ano
            'GoSub 106
            If Y = 0 Then Y = 0.0000000017
            R = (X * X + Y * Y) ^ 0.5
            a = System.Math.Atan(Y / X)
            If a < 0 Then a = a + PI
            If Y < 0 Then a = a + PI
            ' fin del gosub 106
            a = a + INum
            '   llamada a calculo auxiliar para a
            '  GoSub 104
            If a = 0 Then a = 0.0000000017
            X = R * System.Math.Cos(a)
            Y = R * System.Math.Sin(a)
            'fin del GoSub 104
            g = Y
            Y = X
            X = d
            '   llamada a cálculo auxiliar para ano
            'GoSub 106
            If Y = 0 Then Y = 0.0000000017
            R = (X * X + Y * Y) ^ 0.5
            a = System.Math.Atan(Y / X)
            If a < 0 Then a = a + PI
            If Y < 0 Then a = a + PI
            ' fin del gosub 106
            a = a + AN
            If a < 0 Then a = a + 2 * PI
            '   llamada a calculo auxiliar para a
            '  GoSub 104
            If a = 0 Then a = 0.0000000017
            X = R * System.Math.Cos(a)
            Y = R * System.Math.Sin(a)
            'fin del GoSub 104
            'fin del GoSub 105
            Xx = X
            Yy = Y
            ZZ = g
            '     de saturno en adelante llama a subrutina de calculo  y lee datas
            ' If NúmeroPlaneta > 5 Then GoSub 101: 'Va una sola vez*****************
            If NúmeroPlaneta > 5 Then
                ' acá iba el gosub 101
                kum(6) = 11
                kum(7) = 5
                kum(8) = 4
                kum(9) = 4
                kum(10) = 4
                For ik = 1 To 3
                    'If NúmeroPlaneta = 6 And ik = 3 Then t(3) = 0: Return
                    If NúmeroPlaneta = 6 And ik = 3 Then
                        t(3) = 0 : GoTo FinalGosub
                    End If
                    '1026
                    If ik = 3 Then kum(NúmeroPlaneta) = kum(NúmeroPlaneta) - 1
                    'GoSub LeeDatas '6
                    S = matrdat(DATIN)
                    DATIN = DATIN + 1
                    S1 = matrdat(DATIN)
                    DATIN = DATIN + 1
                    S2 = matrdat(DATIN)
                    DATIN = DATIN + 1
                    S = FNR(S + S1 * Tiempo + S2 * Tiempo * Tiempo)
                    'fin LeeDatas 6
                    'Call LecturaDeDatas '  6
                    'Call A103:'6
                    a = 0
                    For ij = 1 To kum(NúmeroPlaneta)
                        '  READ U, v, W
                        u = matrdat(DATIN)
                        DATIN = DATIN + 1
                        v = matrdat(DATIN)
                        DATIN = DATIN + 1
                        W = matrdat(DATIN)
                        DATIN = DATIN + 1
                        a = a + FNR(u) * System.Math.Cos((v * Tiempo + W) * PI / 180)
                    Next ij
                    t(ik) = FND(S + a)
                Next ik
            End If
FinalGosub:
            ' Fin del GoSub 101 ***********

            Xx = Xx + t(2)
            Yy = Yy + t(1)
            ZZ = ZZ + t(3)
            '1012
            BR = 0
            '     llamada a subrutina de cálculo * * * * *
            ' GoSub 114 '1
            '    114
            X = Xx
            Y = Yy
            ' llamada a cálculo auxiliar para y
            'GoSub 106
            If Y = 0 Then Y = 0.0000000017
            R = (X * X + Y * Y) ^ 0.5
            a = System.Math.Atan(Y / X)
            If a < 0 Then a = a + PI
            If Y < 0 Then a = a + PI
            ' fin del gosub 106
            k = a
            C = FND(a) + NU - BR
            If NúmeroPlaneta = 1 And ab = 1 Then C = FNU(C + 180)
            C = FNU(C + SD)
            SS = C
            Y = ZZ
            X = R
            ' llamada a cálculo auxiliar para y
            'GoSub 106
            If Y = 0 Then Y = 0.0000000017
            R = (X * X + Y * Y) ^ 0.5
            a = System.Math.Atan(Y / X)
            If a < 0 Then a = a + PI
            If Y < 0 Then a = a + PI
            ' fin del gosub 106
            If a > 0.35 Then a = a - 2 * PI
            p = FND(a)
            'fin gosub 114
            ab = 1
            XK = (Xx * YH - Yy * XH) / (Xx * Xx + Yy * Yy)
            If NúmeroPlaneta = 1 Then
                X1 = Xx
                Y1 = Yy
                Z1 = ZZ : GoTo 111
            End If
            '112
            Xx = Xx - X1
            Yy = Yy - Y1
            ZZ = ZZ - Z1
            XK = (Xx * YW - Yy * XW) / (Xx * Xx + Yy * Yy)
111:        BR = 0.0057683 * System.Math.Sqrt(Xx * Xx + Yy * Yy + ZZ * ZZ) * FND(XK)
            '     llamada a subrutina de cálculo * * * * *
            ' GoSub 114 '2
            '    114
            X = Xx
            Y = Yy
            ' llamada a cálculo auxiliar para y
            'GoSub 106
            If Y = 0 Then Y = 0.0000000017
            R = (X * X + Y * Y) ^ 0.5
            a = System.Math.Atan(Y / X)
            If a < 0 Then a = a + PI
            If Y < 0 Then a = a + PI
            ' fin del gosub 106
            k = a
            C = FND(a) + NU - BR
            If NúmeroPlaneta = 1 And ab = 1 Then C = FNU(C + 180)
            C = FNU(C + SD)
            SS = C
            Y = ZZ
            X = R
            ' llamada a cálculo auxiliar para y
            'GoSub 106
            If Y = 0 Then Y = 0.0000000017
            R = (X * X + Y * Y) ^ 0.5
            a = System.Math.Atan(Y / X)
            If a < 0 Then a = a + PI
            If Y < 0 Then a = a + PI
            ' fin del gosub 106
            If a > 0.35 Then a = a - 2 * PI
            p = FND(a)
            'fin gosub 114
            ''If ax = 1 Then Return
            Planetas(NúmeroPlaneta) = SS
            Mm(NúmeroPlaneta) = p
151:        'Retoma para luna
        Next NúmeroPlaneta
        '' GoSub LISTAPLANETAS
        ''  GoSub GRABARCHIVO
        GoTo final
        '
        '   ------------------------------------------------------------------------
        '   ­­­­­­­­­­­­­­­­­­­­­­­­­AUXILIAR DEL CALCULO DE PLANETAS­­­­­­­­­­­­­­­
        '   ------------------------------------------------------------------------
        '  *** LECTURA DATA *** era 103
LeeDatas:  ' READ S, S1, S2
        If DATIN > 392 Then
            DATIN = 0 ' PONE A CERO EL CURSOR DE LA MATRIZ DE DATAS
        End If
        S = matrdat(DATIN)
        DATIN = DATIN + 1
        S1 = matrdat(DATIN)
        DATIN = DATIN + 1
        S2 = matrdat(DATIN)
        DATIN = DATIN + 1
        S = FNR(S + S1 * Tiempo + S2 * Tiempo * Tiempo)
        Return

final:
    End Sub

    Private Sub CálculoCasas(ByRef OB As Object, ByRef RA As Double, ByRef Tiempo As Double, ByRef Latitud As Decimal, ByRef Casas As Object)
        Dim zum As Double
        Dim I As Integer
        Dim SD As Double 'Ojo no tiene valor haría un toque en el valor final de las casas
        Dim L As Double
        Dim Xx As Double
        Dim xa As Integer
        Dim EE As Decimal
        Dim r1um As Double
        Dim Y As Integer
        Dim MC As Double
        'Dim EQ As Object
        'Esta rutina calcula las casas recibiendo los valores de OB y RA '
        'y entrega los valores en las variables Casas (12)
        'EQ = 1
        '   ------------------------------------------------------------------------
        '   ­­­­­­­­­­­­­   C A L C U L O   D E   L A S   C A S A S  ­­­­­­­­­­­­­­­
        '   ------------------------------------------------------------------------
130:
        MC = System.Math.Atan(System.Math.Tan(RA) / System.Math.Cos(OB))
        If MC < 0 Then MC = MC + PI
        If System.Math.Sin(RA) < 0 Then MC = MC + PI
        MC = FND(MC)
        MO = 360
        Y = 0
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        r1um = RA + FNR(30) 'ERA 30
        EE = 3 'ERA 3
        '   llamada a subrutina auxiliar de claculo
        'GoSub 137
        Call AuxiliarCasas(xa, Y, Xx, r1um, OB, Latitud, RA, EE, L)
        Casas(5) = FNU(L + 180)
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        r1um = RA + FNR(60) ' ERA 60^^^^^^^^^^^^^^^^^^^^^^ACACA
        EE = 1.5 'ERA 1.5
        '   llamada a subrutina auxiliar de calculo
        'GoSub 137
        Call AuxiliarCasas(xa, Y, Xx, r1um, OB, Latitud, RA, EE, L)
        Casas(6) = FNU(L + 180)
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'ASI REMITE EL ASCENDENTE
        EE = 1
        'GoSub 137
        Call AuxiliarCasas(xa, Y, Xx, r1um, OB, Latitud, RA, EE, L)
        Casas(1) = L
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        r1um = RA + FNR(120)
        EE = 1.5
        Y = 1
        '   llamada a subrutina auxiliar de calculo
        'GoSub 137
        Call AuxiliarCasas(xa, Y, Xx, r1um, OB, Latitud, RA, EE, L)
        Casas(2) = L
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        r1um = RA + FNR(150)
        EE = 3
        '   llamada a subrutina auxiliar de calculo
        'GoSub 137
        Call AuxiliarCasas(xa, Y, Xx, r1um, OB, Latitud, RA, EE, L)
        Casas(3) = L
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Casas(4) = FNU(MC + 180 - SD)
        'retoques finales a todas las casas
        For I = 1 To 6
            Casas(I) = FNU(Casas(I) + SD)
        Next I
        '' con los valores de 1 a 6   hace  de la 7 a la 12
        For I = 1 To 6
            zum = FNU(Casas(I) + 180)
            Casas(I + 6) = zum
        Next I
    End Sub

    Private Sub CálculoTiempoB(ByRef TiempoJuliano As Double, ByRef Tiempo As Double, ByRef OB As Double, ByRef RA As Double, ByRef Longitud As Double, ByRef huso As Integer)
        Dim horainv As Object
        Dim DIAJULINV As Double
        Dim SoloHoras As Object
        Dim u As Object
        Dim FecHora As Double
        '' Esta es una rutina para  entregar los valores necesarios a las rutinas de cálculo de cartas
        ' Entra la variable Tiempo#  y entrega los valores de AR y de OB
        ' Ascensión Recta y Ascención oblicua.
        MO = 360
        FecHora = TiempoJuliano
        u = -0.5
        FecHora = FecHora - huso / 24
        If (FecHora - (Int(FecHora))) < 0.5 Then u = 0.5
        SoloHoras = (FecHora - Int(FecHora)) + u 'TIENE LA HORA TOTAL
        DIAJULINV = FecHora - SoloHoras ' OBTENEMOS DE VUELTA EL DIA JULIANO
        Horas = Int(SoloHoras * 24) ' SEPARAMOS LAS HORAS ENTERAS
        Minutos = Int((SoloHoras * 24 - Horas) * 60 + 0.5) 'OBTENEMOS LOS MINUTOS
        horainv = Horas + Minutos / 100 'TIENE LA HORA + LOS MIN EN SEXAGESIMAL
        horainv = FNQ(horainv)
        Tiempo = TiempoJuliano - 2415020
        Tiempo = Tiempo / 36525
        ''Planetas(11) = FNU((933060 - 6962911 * TIEMPO# + 7.5 * TIEMPO# * TIEMPO#) / 3600)
        RA = FNR(FNU((6.646066 + 2400.0513 * Tiempo + 0.000025805 * Tiempo * Tiempo + horainv + huso) * 15 - Longitud))
        OB = FNR(23.45229 - 0.0130125 * Tiempo)
    End Sub

    Private Sub SalidaImprimeListado()
        Dim conta As Object
        FormTimer.TextoTimer.Text = ""
        FormTimer.TextoTimer.Text = FormTimer.TextoTimer.Text & CadenaTiempoInverso & Chr(13) & Chr(10)
        FormTimer.TextoTimer.Text = FormTimer.TextoTimer.Text & CadenaTiempoInversoCorta & Chr(13) & Chr(10)
        FormTimer.TextoTimer.Text = FormTimer.TextoTimer.Text & Chr(13) & Chr(10)
        For conta = 1 To 10
            'Dim Strconta$ = Right$(Str$(conta), 2)
            ' Form1.Texto1.Text = Form1.Texto1.Text & PoneCeros(Strconta$) & " " & FormateaDatosSalida(Planetas(conta)) & Chr(13) & Chr(10)
            FormTimer.TextoTimer.Text = FormTimer.TextoTimer.Text & NombrePlanetaBreve(conta) & " " & SalidaFormateaDatos(Planetas(conta)) & Chr(13) & Chr(10)
        Next
        ' Form1.Texto1.Text = Form1.Texto1.Text & CadenaTiempoInverso & Chr(13) & Chr(10)
        'Form1.Texto1.Text = Form1.Texto1.Text & CadenaTiempoInversoCorta & Chr(13) & Chr(10)
        FormTimer.TextoTimer.Text = FormTimer.TextoTimer.Text & Chr(13) & Chr(10)
        For conta = 1 To 12
            Dim Strconta$ = Right$(Str$(conta), 2)
            FormTimer.TextoTimer.Text = FormTimer.TextoTimer.Text & PoneCeros(Strconta$) & " " & SalidaFormateaDatos(Casas(conta)) & Chr(13) & Chr(10)
        Next
    End Sub
    Private Sub AuxiliarCasas(ByRef xa As Integer, ByRef Y As Integer, ByRef Xx As Double, ByRef r1um As Double, ByRef OB As Double, ByRef Latitud As Decimal, ByRef RA As Double, ByRef EE As Decimal, ByRef L As Double)
        Dim R2 As Double
        Dim I As Object
        '   ­­­­­­­­SUBRUTINA AUXILIAR PARA EL CALCULO DE CASAS ­­­­­­­­­­­­­­­­­­­­
137:    xa = -1
        ' pasar xa Y Xx  r1um OB Latitud   RA  EE L
        ' no pasar  R2
        If Y = 1 Then xa = 1
        For I = 1 To 10
            Xx = FNY(xa * System.Math.Sin(r1um) * System.Math.Tan(OB) * System.Math.Tan(Latitud))
            If Xx < 0 Then Xx = Xx + PI
            R2 = RA + (Xx / EE)
            If Y = 1 Then R2 = RA + PI - (Xx / EE)
            r1um = R2
        Next I
        L = System.Math.Atan(System.Math.Tan(r1um) / System.Math.Cos(OB))
        If L < 0 Then L = L + PI
        If System.Math.Sin(r1um) < 0 Then L = L + PI
        L = FND(L)
        ' Return
    End Sub

End Module
