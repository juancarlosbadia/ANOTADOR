Public Class FormAuxiliar
    Dim Tabla(385) As String
    Dim TextoBusquedaInicio As Integer
    Dim TextoPasado As Integer
    Private Sub CargaTabladeCaracteres()
        Tabla(0) = ""
        Tabla(1) = "☺"
        Tabla(2) = "☻"
        Tabla(3) = "♥"
        Tabla(4) = "♦"
        Tabla(5) = "♣"
        Tabla(6) = "♠"
        Tabla(7) = "•"
        Tabla(8) = "◘"
        Tabla(9) = "○"
        Tabla(10) = "◙"
        Tabla(11) = "♂"
        Tabla(12) = "♀"
        Tabla(13) = "♪"
        Tabla(14) = "♫"
        Tabla(15) = "☼"
        Tabla(16) = "►"
        Tabla(17) = "◄"
        Tabla(18) = "↕"
        Tabla(19) = "‼"
        Tabla(20) = "¶"
        Tabla(21) = "§"
        Tabla(22) = "▬"
        Tabla(23) = "↨"
        Tabla(24) = "↑"
        Tabla(25) = "↓"
        Tabla(26) = "→"
        Tabla(27) = "←"
        Tabla(28) = "∟"
        Tabla(29) = "↔"
        Tabla(30) = "▲"
        Tabla(31) = "▼"
        Tabla(32) = " "
        Tabla(33) = "!"
        Tabla(34) = """"
        Tabla(35) = "#"
        Tabla(36) = "$"
        Tabla(37) = "%"
        Tabla(38) = "&"
        Tabla(39) = "'"
        Tabla(40) = "("
        Tabla(41) = ")"
        Tabla(42) = "*"
        Tabla(43) = "+"
        Tabla(44) = ","
        Tabla(45) = "-"
        Tabla(46) = "."
        Tabla(47) = "/"
        Tabla(48) = "0"
        Tabla(49) = "1"
        Tabla(50) = "2"
        Tabla(51) = "3"
        Tabla(52) = "4"
        Tabla(53) = "5"
        Tabla(54) = "6"
        Tabla(55) = "7"
        Tabla(56) = "8"
        Tabla(57) = "9"
        Tabla(58) = ":"
        Tabla(59) = ";"
        Tabla(60) = "<"
        Tabla(61) = "="
        Tabla(62) = ">"
        Tabla(63) = "?"
        Tabla(64) = "@"
        Tabla(65) = "A"
        Tabla(66) = "B"
        Tabla(67) = "C"
        Tabla(68) = "D"
        Tabla(69) = "E"
        Tabla(70) = "F"
        Tabla(71) = "G"
        Tabla(72) = "H"
        Tabla(73) = "I"
        Tabla(74) = "J"
        Tabla(75) = "K"
        Tabla(76) = "L"
        Tabla(77) = "M"
        Tabla(78) = "N"
        Tabla(79) = "O"
        Tabla(80) = "P"
        Tabla(81) = "Q"
        Tabla(82) = "R"
        Tabla(83) = "S"
        Tabla(84) = "T"
        Tabla(85) = "U"
        Tabla(86) = "V"
        Tabla(87) = "W"
        Tabla(88) = "X"
        Tabla(89) = "Y"
        Tabla(90) = "Z"
        Tabla(91) = "["
        Tabla(92) = "\"
        Tabla(93) = "]"
        Tabla(94) = "^"
        Tabla(95) = "_"
        Tabla(96) = "`"
        Tabla(97) = "a"
        Tabla(98) = "b"
        Tabla(99) = "c"
        Tabla(100) = "d"
        Tabla(101) = "e"
        Tabla(102) = "f"
        Tabla(103) = "g"
        Tabla(104) = "h"
        Tabla(105) = "i"
        Tabla(106) = "j"
        Tabla(107) = "k"
        Tabla(108) = "l"
        Tabla(109) = "m"
        Tabla(110) = "n"
        Tabla(111) = "o"
        Tabla(112) = "p"
        Tabla(113) = "q"
        Tabla(114) = "r"
        Tabla(115) = "s"
        Tabla(116) = "t"
        Tabla(117) = "u"
        Tabla(118) = "v"
        Tabla(119) = "w"
        Tabla(120) = "x"
        Tabla(121) = "y"
        Tabla(122) = "z"
        Tabla(123) = "{"
        Tabla(124) = "|"
        Tabla(125) = "}"
        Tabla(126) = "~"
        Tabla(127) = "⌂"
        Tabla(128) = "Ç"
        Tabla(129) = "ü"
        Tabla(130) = "é"
        Tabla(131) = "â"
        Tabla(132) = "ä"
        Tabla(133) = "à"
        Tabla(134) = "å"
        Tabla(135) = "ç"
        Tabla(136) = "ê"
        Tabla(137) = "ë"
        Tabla(138) = "è"
        Tabla(139) = "ï"
        Tabla(140) = "î"
        Tabla(141) = "ì"
        Tabla(142) = "Ä"
        Tabla(143) = "Å"
        Tabla(144) = "É"
        Tabla(145) = "æ"
        Tabla(146) = "Æ"
        Tabla(147) = "ô"
        Tabla(148) = "ö"
        Tabla(149) = "ò"
        Tabla(150) = "û"
        Tabla(151) = "ù"
        Tabla(152) = "ÿ"
        Tabla(153) = "Ö"
        Tabla(154) = "Ü"
        Tabla(155) = "ø"
        Tabla(156) = "£"
        Tabla(157) = "Ø"
        Tabla(158) = "×"
        Tabla(159) = "ƒ"
        Tabla(160) = "á"
        Tabla(161) = "í"
        Tabla(162) = "ó"
        Tabla(163) = "ú"
        Tabla(164) = "ñ"
        Tabla(165) = "Ñ"
        Tabla(166) = "ª"
        Tabla(167) = "º"
        Tabla(168) = "¿"
        Tabla(169) = "®"
        Tabla(170) = "¬"
        Tabla(171) = "½"
        Tabla(172) = "¼"
        Tabla(173) = "¡"
        Tabla(174) = "«"
        Tabla(175) = "»"
        Tabla(176) = "░"
        Tabla(177) = "▒"
        Tabla(178) = "▓"
        Tabla(179) = "│"
        Tabla(180) = "┤"
        Tabla(181) = "Á"
        Tabla(182) = "Â"
        Tabla(183) = "À"
        Tabla(184) = "©"
        Tabla(185) = "╣"
        Tabla(186) = "║"
        Tabla(187) = "╗"
        Tabla(188) = "╝"
        Tabla(189) = "¢"
        Tabla(190) = "¥"
        Tabla(191) = "┐"
        Tabla(192) = "└"
        Tabla(193) = "┴"
        Tabla(194) = "┬"
        Tabla(195) = "├"
        Tabla(196) = "─"
        Tabla(197) = "┼"
        Tabla(198) = "ã"
        Tabla(199) = "Ã"
        Tabla(200) = "╚"
        Tabla(201) = "╔"
        Tabla(202) = "╩"
        Tabla(203) = "╦"
        Tabla(204) = "╠"
        Tabla(205) = "═"
        Tabla(206) = "╬"
        Tabla(207) = "¤"
        Tabla(208) = "ð"
        Tabla(209) = "Ð"
        Tabla(210) = "Ê"
        Tabla(211) = "Ë"
        Tabla(212) = "È"
        Tabla(213) = "ı"
        Tabla(214) = "Í"
        Tabla(215) = "Î"
        Tabla(216) = "Ï"
        Tabla(217) = "┘"
        Tabla(218) = "┌"
        Tabla(219) = "█"
        Tabla(220) = "▄"
        Tabla(221) = "¦"
        Tabla(222) = "Ì"
        Tabla(223) = "▀"
        Tabla(224) = "Ó"
        Tabla(225) = "ß"
        Tabla(226) = "Ô"
        Tabla(227) = "Ò"
        Tabla(228) = "õ"
        Tabla(229) = "Õ"
        Tabla(230) = "µ"
        Tabla(231) = "þ"
        Tabla(232) = "Þ"
        Tabla(233) = "Ú"
        Tabla(234) = "Û"
        Tabla(235) = "Ù"
        Tabla(236) = "ý"
        Tabla(237) = "Ý"
        Tabla(238) = "¯"
        Tabla(239) = "´"
        Tabla(240) = "­"
        Tabla(241) = "±"
        Tabla(242) = "‗"
        Tabla(243) = "¾"
        Tabla(244) = "¶"
        Tabla(245) = "§"
        Tabla(246) = "÷"
        Tabla(247) = "¸"
        Tabla(248) = "°"
        Tabla(249) = "¨"
        Tabla(250) = "·"
        Tabla(251) = "¹"
        Tabla(252) = "³"
        Tabla(253) = "²"
        Tabla(254) = "■"
        Tabla(255) = " "
        Tabla(256) = ""
        Tabla(257) = "€"
        Tabla(258) = "{"
        Tabla(259) = "‚"
        Tabla(260) = "ƒ"
        Tabla(261) = "„"
        Tabla(262) = "…"
        Tabla(263) = "†"
        Tabla(264) = "‡"
        Tabla(265) = "ˆ"
        Tabla(266) = "‰"
        Tabla(267) = "Š"
        Tabla(268) = "‹"
        Tabla(269) = "Œ"
        Tabla(270) = " "
        Tabla(271) = "Ž"
        Tabla(272) = " "
        Tabla(273) = " "
        Tabla(274) = "‘"
        Tabla(275) = "’"
        Tabla(276) = """"
        Tabla(277) = """"
        Tabla(278) = "•"
        Tabla(279) = "–"
        Tabla(280) = "—"
        Tabla(281) = "˜"
        Tabla(282) = "™"
        Tabla(283) = "š"
        Tabla(284) = "›"
        Tabla(285) = "œ"
        Tabla(286) = " "
        Tabla(287) = "ž"
        Tabla(288) = "Ÿ"
        Tabla(289) = ""
        Tabla(290) = "¡"
        Tabla(291) = "¢"
        Tabla(292) = "£"
        Tabla(293) = "¤"
        Tabla(294) = "¥"
        Tabla(295) = "¦"
        Tabla(296) = "§"
        Tabla(297) = "¨"
        Tabla(298) = "©"
        Tabla(299) = "ª"
        Tabla(300) = "«"
        Tabla(301) = "¬"
        Tabla(302) = "­"
        Tabla(303) = "®"
        Tabla(304) = "¯"
        Tabla(305) = "°"
        Tabla(306) = "±"
        Tabla(307) = "²"
        Tabla(308) = "³"
        Tabla(309) = "´"
        Tabla(310) = "µ"
        Tabla(311) = "¶"
        Tabla(312) = "·"
        Tabla(313) = "¸"
        Tabla(314) = "¹"
        Tabla(315) = "º"
        Tabla(316) = "»"
        Tabla(317) = "¼"
        Tabla(318) = "½"
        Tabla(319) = "¾"
        Tabla(320) = "¿"
        Tabla(321) = "À"
        Tabla(322) = "Á"
        Tabla(323) = "Â"
        Tabla(324) = "Ã"
        Tabla(325) = "Ä"
        Tabla(326) = "Å"
        Tabla(327) = "Æ"
        Tabla(328) = "Ç"
        Tabla(329) = "È"
        Tabla(330) = "É"
        Tabla(331) = "Ê"
        Tabla(332) = "Ë"
        Tabla(333) = "Ì"
        Tabla(334) = "Í"
        Tabla(335) = "Î"
        Tabla(336) = "Ï"
        Tabla(337) = "Ð"
        Tabla(338) = "Ñ"
        Tabla(339) = "Ò"
        Tabla(340) = "Ó"
        Tabla(341) = "Ô"
        Tabla(342) = "Õ"
        Tabla(343) = "Ö"
        Tabla(344) = "×"
        Tabla(345) = "Ø"
        Tabla(346) = "Ù"
        Tabla(347) = "Ú"
        Tabla(348) = "Û"
        Tabla(349) = "Ü"
        Tabla(350) = "Ý"
        Tabla(351) = "Þ"
        Tabla(352) = "ß"
        Tabla(353) = "à"
        Tabla(354) = "á"
        Tabla(355) = "â"
        Tabla(356) = "ã"
        Tabla(357) = "ä"
        Tabla(358) = "å"
        Tabla(359) = "æ"
        Tabla(360) = "ç"
        Tabla(361) = "è"
        Tabla(362) = "é"
        Tabla(363) = "ê"
        Tabla(364) = "ë"
        Tabla(365) = "ì"
        Tabla(366) = "í"
        Tabla(367) = "î"
        Tabla(368) = "ï"
        Tabla(369) = "ð"
        Tabla(370) = "ñ"
        Tabla(371) = "ò"
        Tabla(372) = "ó"
        Tabla(373) = "ô"
        Tabla(374) = "õ"
        Tabla(375) = "ö"
        Tabla(376) = "÷"
        Tabla(377) = "ø"
        Tabla(378) = "ù"
        Tabla(379) = "ú"
        Tabla(380) = "û"
        Tabla(381) = "ü"
        Tabla(382) = "ý"
        Tabla(383) = "þ"
        Tabla(384) = "ÿ"
    End Sub

    Private Sub BotonQuitaEspacios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonQuitaEspacios.Click

    End Sub

    Private Sub BotonQuitaEspacios_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonQuitaEspacios.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Anotador.QuitaDobleEspacioASeleccionado(Anotador.Texto.SelectedText)
        Else
            Anotador.QuitaDobleEspacioATodo(Anotador.Texto.SelectedText)
        End If
        InvierteColorSuenaTecla(BotonQuitaEspacios)
    End Sub

    Private Sub BotonTodoMayMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonTodoMayMin.Click
    End Sub

    Private Sub BotonTodoMayMin_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonTodoMayMin.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Anotador.ConvertirMayusculasMinusculas(Anotador.Texto.SelectedText, True)
        Else
            Anotador.ConvertirMayusculasMinusculas(Anotador.Texto.SelectedText, False)
        End If
        InvierteColorSuenaTecla(BotonTodoMayMin)
    End Sub

    Private Sub ListaAsciiComentado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaAsciiComentado.SelectedIndexChanged
        LetraElegida = Tabla(ListaAsciiComentado.SelectedIndex)
        Teclado.PoneLetra()
    End Sub

    Private Sub FormAuxiliar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Anotador.TopMost = False
        CargaTabladeCaracteres()

    End Sub

    Private Sub BotonRepiteAscii_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonRepiteAscii.Click

    End Sub

    Private Sub BotonRepiteAscii_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonRepiteAscii.MouseDown
        Teclado.MouseDownTecla(BotonRepiteAscii)
    End Sub

    Private Sub BotonQuitaEspacios_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonQuitaEspacios.MouseHover
        IluminaColorTecla(BotonQuitaEspacios)
    End Sub

    Private Sub BotonQuitaEspacios_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonQuitaEspacios.MouseLeave
        RestauraColorTecla2(BotonQuitaEspacios)
    End Sub

    Private Sub BotonQuitaEspacios_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonQuitaEspacios.MouseUp
        RestauraColorTecla2(BotonQuitaEspacios)
    End Sub

    Private Sub BotonTodoMayMin_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonTodoMayMin.MouseHover
        IluminaColorTecla(BotonTodoMayMin)
    End Sub

    Private Sub BotonTodoMayMin_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonTodoMayMin.MouseLeave
        RestauraColorTecla2(BotonTodoMayMin)
    End Sub

    Private Sub BotonTodoMayMin_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonTodoMayMin.MouseUp
        RestauraColorTecla2(BotonTodoMayMin)
    End Sub

    Private Sub BotonRepiteAscii_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonRepiteAscii.MouseHover
        TextoLetraRepiteAscii()
        MouseHoverTecla(BotonRepiteAscii)
    End Sub
    Private Sub TextoLetraRepiteAscii()
        LetraElegida = BotonRepiteAscii.Text
    End Sub

    Private Sub BotonRepiteAscii_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonRepiteAscii.MouseLeave
        MouseLeaveTecla(BotonRepiteAscii)
    End Sub

    Private Sub BotonRepiteAscii_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonRepiteAscii.MouseUp
        MouseUpTecla(BotonRepiteAscii)
    End Sub

    Private Sub BotonAcentuarDesacentuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAcentuarDesacentuar.Click

    End Sub

    Private Sub BotonAcentuarDesacentuar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonAcentuarDesacentuar.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Anotador.Acentuar()
        Else
            Anotador.DesAcentuar()
        End If

        InvierteColorSuenaTecla(BotonAcentuarDesacentuar)
    End Sub

    Private Sub BotonAcentuarDesacentuar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonAcentuarDesacentuar.MouseHover
        IluminaColorTecla(BotonAcentuarDesacentuar)
    End Sub

    Private Sub BotonAcentuarDesacentuar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonAcentuarDesacentuar.MouseLeave
        RestauraColorTecla2(BotonAcentuarDesacentuar)
    End Sub

    Private Sub BotonAcentuarDesacentuar_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonAcentuarDesacentuar.MouseUp
        RestauraColorTecla2(BotonAcentuarDesacentuar)
    End Sub

    Private Sub BotonMayusculasIniciales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonMayusculasIniciales.Click

    End Sub

    Private Sub BotonMayusculasIniciales_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonMayusculasIniciales.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ConvertirMayusculasIniciales()
        Else
            Anotador.ConvertirMayusculasMinusculas(Anotador.Texto.SelectedText, False)
        End If
        InvierteColorSuenaTecla(BotonMayusculasIniciales)
    End Sub

    Private Sub BotonMayusculasIniciales_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonMayusculasIniciales.MouseHover
        IluminaColorTecla(BotonMayusculasIniciales)
    End Sub

    Private Sub BotonMayusculasIniciales_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonMayusculasIniciales.MouseLeave
        RestauraColorTecla2(BotonMayusculasIniciales)
    End Sub

    Private Sub BotonMayusculasIniciales_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonMayusculasIniciales.MouseUp
        RestauraColorTecla2(BotonMayusculasIniciales)
    End Sub
    Private Sub ListFiles(ByVal folderPath As String)
        ListaRecortes.Items.Clear()

        Dim fileNames = My.Computer.FileSystem.GetFiles(folderPath, FileIO.SearchOption.SearchTopLevelOnly, "*.txt")

        For Each fileName As String In fileNames
            Dim SoloArchivo = Mid(fileName, 19)
            ' ListaRecortes.Items.Add(fileName)
            ListaRecortes.Items.Add(SoloArchivo)
        Next
    End Sub
    Private Sub BotonLeeRecortes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonLeeRecortes.Click

    End Sub

    Private Sub BotonLeeRecortes_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonLeeRecortes.MouseDown
        ListFiles("C:\Notas\Recortes\")
        InvierteColorSuenaTecla(BotonLeeRecortes)
    End Sub

    Private Sub BotonLeeRecortes_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonLeeRecortes.MouseHover
        IluminaColorTecla(BotonLeeRecortes)
    End Sub

    Private Sub BotonLeeRecortes_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonLeeRecortes.MouseLeave
        RestauraColorTecla2(BotonLeeRecortes)
    End Sub

    Private Sub BotonLeeRecortes_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonLeeRecortes.MouseUp
        RestauraColorTecla2(BotonLeeRecortes)
    End Sub

    Private Sub ListaRecortes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaRecortes.SelectedIndexChanged
        Anotador.AbrirRecorte(ListaRecortes.SelectedItem)
    End Sub

    Private Sub BotonRepiteRecorte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonRepiteRecorte.Click

    End Sub

    Private Sub BotonRepiteRecorte_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonRepiteRecorte.MouseDown
        If ListaRecortes.SelectedItem = Nothing Then Exit Sub
        Anotador.AbrirRecorte(ListaRecortes.SelectedItem)
        InvierteColorSuenaTecla(BotonRepiteRecorte)
    End Sub

    Private Sub BotonRepiteRecorte_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonRepiteRecorte.MouseHover
        IluminaColorTecla(BotonRepiteRecorte)
    End Sub

    Private Sub BotonRepiteRecorte_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonRepiteRecorte.MouseLeave
        RestauraColorTecla2(BotonRepiteRecorte)
    End Sub

    Private Sub BotonRepiteRecorte_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonRepiteRecorte.MouseUp
        RestauraColorTecla2(BotonRepiteRecorte)
    End Sub
    Private Sub ComponeTexto(ByVal TextoBuscar1 As String, ByVal TextoBuscar2 As String, ByVal TextoReemplazar0 As String, ByVal TextoReemplazar1 As String, ByVal TextoReemplazar2 As String, ByRef Buscar As String, ByRef Reemplazar As String)
        'If Buscar = "" Then Exit Sub
        If TextoBuscar1 = "(RETORNO DE CARRO)" Then TextoBuscar1 = Chr(13) 'vbCr 'Chr(Asc(13))
        If TextoBuscar1 = "(NUEVA LINEA)" Then TextoBuscar1 = Chr(10) ' vbLf 'Chr(Asc(10))
        If TextoBuscar1 = "(RETORNO DE CARRO - NUEVA LINEA)" Then TextoBuscar1 = Chr(13) & Chr(10) 'vbCrLf 'Chr(Asc(13)) & Chr(Asc(10))
        If TextoBuscar1 = "(ESPACIO)" Then TextoBuscar1 = Chr(32) 'Chr(Asc(32))
        If TextoBuscar2 = "(RETORNO DE CARRO)" Then TextoBuscar2 = Chr(13) 'vbCr 'Chr(Asc(13))
        If TextoBuscar2 = "(NUEVA LINEA)" Then TextoBuscar2 = Chr(10) ' vbLf 'Chr(Asc(10))
        If TextoBuscar2 = "(RETORNO DE CARRO - NUEVA LINEA)" Then TextoBuscar2 = Chr(13) & Chr(10) 'vbCrLf 'Chr(Asc(13)) & Chr(Asc(10))
        If TextoBuscar2 = "(ESPACIO)" Then TextoBuscar2 = Chr(32) 'Chr(Asc(32))

        If TextoReemplazar0 = "(RETORNO DE CARRO)" Then TextoReemplazar0 = Chr(13) 'vbCr 'Chr(Asc(13))
        If TextoReemplazar0 = "(NUEVA LINEA)" Then TextoReemplazar0 = Chr(10) 'vbLf 'Chr(Asc(10))
        If TextoReemplazar0 = "(RETORNO DE CARRO - NUEVA LINEA)" Then TextoReemplazar0 = Chr(13) & Chr(10) 'vbCrLf 'Chr(Asc(13)) & Chr(Asc(10))
        If TextoReemplazar0 = "(ESPACIO)" Then TextoReemplazar0 = Chr(32) 'Chr(Asc(32))
        If TextoReemplazar1 = "(RETORNO DE CARRO)" Then TextoReemplazar1 = Chr(13) 'vbCr 'Chr(Asc(13))
        If TextoReemplazar1 = "(NUEVA LINEA)" Then TextoReemplazar1 = Chr(10) 'vbLf 'Chr(Asc(10))
        If TextoReemplazar1 = "(RETORNO DE CARRO - NUEVA LINEA)" Then TextoReemplazar1 = Chr(13) & Chr(10) 'vbCrLf 'Chr(Asc(13)) & Chr(Asc(10))
        If TextoReemplazar1 = "(ESPACIO)" Then TextoReemplazar1 = Chr(32) 'Chr(Asc(32))
        If TextoReemplazar2 = "(RETORNO DE CARRO)" Then TextoReemplazar2 = Chr(13) 'vbCr 'Chr(Asc(13))
        If TextoReemplazar2 = "(NUEVA LINEA)" Then TextoReemplazar2 = Chr(10) 'vbLf 'Chr(Asc(10))
        If TextoReemplazar2 = "(RETORNO DE CARRO - NUEVA LINEA)" Then TextoReemplazar2 = Chr(13) & Chr(10) 'vbCrLf 'Chr(Asc(13)) & Chr(Asc(10))
        If TextoReemplazar2 = "(ESPACIO)" Then TextoReemplazar2 = Chr(32) 'Chr(Asc(32))
        Buscar = TextoBuscar1 & TextoBuscar2
        Reemplazar = TextoReemplazar0 & TextoReemplazar1 & TextoReemplazar2
    End Sub




    Private Sub BotonReemplazar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonReemplazar.Click

    End Sub

    Private Sub BotonReemplazar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonReemplazar.MouseDown
        Dim Buscar As String
        Dim Reemplazar As String

        ComponeTexto(TextoBuscar1.Text, TextoBuscar2.Text, TextoReemplazar0.Text, TextoReemplazar1.Text, TextoReemplazar2.Text, Buscar, Reemplazar)

        If e.Button = Windows.Forms.MouseButtons.Left Then
            Anotador.ReemplazaEnSeleccionado(Buscar, Reemplazar)
        Else
            Anotador.ReemplazaEnTodoElTexto(Buscar, Reemplazar)
        End If
    End Sub

    Private Sub TextoVelocidadRepeticion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextoVelocidadRepeticion.SelectedIndexChanged
        VelocidadRepeticionTecla = TextoVelocidadRepeticion.Text
        Anotador.TimerBorraAuto.Interval = VelocidadRepeticionTecla
        Anotador.TimerAvanzaRetrocedeAuto.Interval = VelocidadRepeticionTecla
        Teclado.TimerRepeticion.Interval = VelocidadRepeticionTecla
    End Sub

    Private Sub CheckSonido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckSonido.CheckedChanged
        If CheckSonido.Checked = True Then
            SonidoActivado = True
        Else
            SonidoActivado = False
        End If
    End Sub

    Private Sub CheckDisparoAuto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckDisparoAuto.CheckedChanged
        If CheckDisparoAuto.Checked = True Then
            DisparoAutomatico = True
        Else
            DisparoAutomatico = False
        End If
    End Sub

    Private Sub TextoVelocidadDisparo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextoVelocidadDisparo.SelectedIndexChanged
        Teclado.TimerOprimirAuto.Interval = Val(TextoVelocidadDisparo.Text)
    End Sub

    Private Sub Checkeys_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Checkeys.CheckedChanged
        If Checkeys.Checked = True Then
            AKeys = True
        Else
            AKeys = False
        End If
    End Sub
    Private Sub PoneCombo(ByVal Index As Integer)
        Dim Cadena As String = ""
        Select Case Index
            Case Is = 0
                Cadena = "_________________________________"
            Case Is = 1
                Cadena = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ "
            Case Is = 2
                Cadena = "CLAUSULA_________:"
            Case Is = 3
                Cadena = "•"
            Case Else
                Exit Sub
        End Select
        PoneCombos(Cadena, Anotador.Texto.SelectedText, Len(Cadena))
    End Sub
    Private Sub PoneCombos(ByVal a As String, ByVal Seleccionado As String, ByVal Largo As Integer)
        Anotador.PosiciónDeInicio = Anotador.Texto.SelectionStart
        Anotador.PosiciónDeFinalSeleccion = Anotador.Texto.SelectionStart + Len(Seleccionado)
        Dim TextoAnterior = Anotador.Texto.Text.Substring(0, Anotador.PosiciónDeInicio)
        Dim TextoPosterior = Anotador.Texto.Text.Substring(Anotador.PosiciónDeFinalSeleccion, Anotador.Texto.Text.Length() - Anotador.PosiciónDeFinalSeleccion)
        Anotador.Texto.Text = TextoAnterior & a & TextoPosterior
        Anotador.Texto.SelectionStart = Len(TextoAnterior) + Largo
        Anotador.Texto.ScrollToCaret()
        'Anotador.Texto.Cursor.Show()
        Anotador.Texto.Focus()

    End Sub
    Private Sub ListaPredeterminados_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaPredeterminados.SelectedIndexChanged
        PoneCombo(ListaPredeterminados.SelectedIndex)
    End Sub

    Private Sub BotonRepìtePredeterminado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonRepìtePredeterminado.Click

    End Sub

    Private Sub BotonRepìtePredeterminado_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonRepìtePredeterminado.MouseDown
        PoneCombo(ListaPredeterminados.SelectedIndex)
        InvierteColorSuenaTecla(BotonRepìtePredeterminado)
    End Sub

    Private Sub BotonRepìtePredeterminado_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonRepìtePredeterminado.MouseHover
        IluminaColorTecla(BotonRepìtePredeterminado)
    End Sub

    Private Sub BotonRepìtePredeterminado_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonRepìtePredeterminado.MouseLeave
        RestauraColorTecla2(BotonRepìtePredeterminado)
    End Sub

    Private Sub BotonRepìtePredeterminado_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonRepìtePredeterminado.MouseUp
        RestauraColorTecla2(BotonRepìtePredeterminado)
    End Sub

    Private Sub TextoVelocidadDisparo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextoVelocidadDisparo.TextChanged
        Teclado.TimerOprimirAuto.Interval = Val(TextoVelocidadDisparo.Text)
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
            FormularioActivo(3) = False
            Anotador.Focus()
        End If
    End Sub

    Private Sub BotonTransparencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonTransparencia.Click

    End Sub

    Private Sub BotonTransparencia_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonTransparencia.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Teclado.Opacity = Teclado.Opacity + 0.05
        Else
            Teclado.Opacity = Teclado.Opacity - 0.05
            If Teclado.Opacity < 0.3 Then Teclado.Opacity = 0.4
        End If
    End Sub

    Private Sub BotonBusca1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonBusca1.Click

    End Sub
    Private Sub BotonBusca1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonBusca1.MouseDown
        TomaCadena()
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Busqueda(e)
        Else
            TextoPasado = 0
            TextoBusquedaInicio = 1
        End If
    End Sub
    Private Sub Busqueda(ByVal LR As System.Windows.Forms.MouseEventArgs)
        On Error GoTo TratamientoDelError
        Dim Buscar As String
        Dim Reemplazar As String
        ComponeTexto(TextoBuscar1.Text, TextoBuscar2.Text, TextoReemplazar0.Text, TextoReemplazar1.Text, TextoReemplazar2.Text, Buscar, Reemplazar)


        Dim TextoABuscar As String
        Dim TextoTotalInicio As Integer
        Dim TextoTotalFin As Integer

        'Dim TextoBusquedaInicio As Integer es publica
        ' TextoPasado es pública
        Dim TextoBusquedaFin As Integer

        Dim TextoEnElQueSeBusca As String
        Dim LargoRangoBusqueda As Integer
        Dim LugarDeEncuentro As Integer

        TextoABuscar = Buscar
        Dim LargoTextoABuscar = TextoABuscar.Length
        TextoTotalInicio = 1
        TextoTotalFin = Anotador.Texto.Text.Length
        'TextoBusquedaInicio = TextoTotalInicio
        TextoBusquedaInicio = TextoTotalInicio + TextoPasado
        TextoBusquedaFin = TextoTotalFin
        LargoRangoBusqueda = TextoBusquedaFin - TextoBusquedaInicio
        TextoEnElQueSeBusca = Mid(Anotador.Texto.Text, TextoBusquedaInicio, LargoRangoBusqueda)

        'LugarDeEncuentro = InStr(Anotador.Texto.Text, TextoABuscar)
        LugarDeEncuentro = InStr(TextoEnElQueSeBusca, TextoABuscar)
        If LR.Button = Left Then

        End If
        If LugarDeEncuentro = 0 Then
            TextoPasado = 0
            MsgBox("Se terminó la búsqueda")
            Exit Sub
        End If

        'Anotador.Texto.SelectionStart = LugarDeEncuentro - 1
        Anotador.Texto.SelectionStart = LugarDeEncuentro - 1 + TextoPasado
        TextoPasado = TextoPasado + LugarDeEncuentro + LargoTextoABuscar - 1 'Agregue el -1 (acá quedó bien)
        Anotador.Texto.SelectionLength = LargoTextoABuscar
        Anotador.Texto.ScrollToCaret()
        Anotador.Texto.Focus()
        TextoBusquedaInicio = LugarDeEncuentro + LargoTextoABuscar
        Exit Sub
TratamientoDelError:
        TextoPasado = 0

    End Sub


 
    Public Sub TomaCadena()
        If Anotador.Texto.SelectedText <> Nothing Then
            TextoBuscar1.Text = Anotador.Texto.SelectedText
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonBusca2.Click
        Dim Buscar As String
        Dim Reemplazar As String
        ComponeTexto(TextoBuscar1.Text, TextoBuscar2.Text, TextoReemplazar0.Text, TextoReemplazar1.Text, TextoReemplazar2.Text, Buscar, Reemplazar)


        Dim TextoABuscar As String
        Dim TextoTotalInicio As Integer
        Dim TextoTotalFin As Integer

        'Dim TextoBusquedaInicio As Integer
        Dim TextoBusquedaFin As Integer

        Dim TextoBusqueda As String
        Dim LargoRangoBusqueda As Integer
        Dim LugarDeEncuentro As Integer
        TextoABuscar = Buscar
        Dim LargoTextoABuscar = TextoABuscar.Length
        TextoTotalInicio = 1
        TextoTotalFin = Anotador.Texto.Text.Length
        'TextoBusquedaInicio = TextoTotalInicio
        TextoBusquedaFin = TextoTotalFin
        LargoRangoBusqueda = TextoBusquedaFin - TextoBusquedaInicio
        TextoBusqueda = Mid(Anotador.Texto.Text, TextoBusquedaInicio, LargoRangoBusqueda)
        LugarDeEncuentro = InStr(TextoBusqueda, TextoABuscar)
        If LugarDeEncuentro = 0 Then
            TextoPasado = 0
            MsgBox("Se terminó la búsqueda")
            Exit Sub
        End If
        Anotador.Texto.SelectionStart = TextoBusquedaInicio + LugarDeEncuentro - 2
        Anotador.Texto.SelectionLength = LargoTextoABuscar
        Anotador.Texto.ScrollToCaret()
        Anotador.Texto.Focus()
        TextoBusquedaInicio = TextoBusquedaInicio - 1 + LugarDeEncuentro + LargoTextoABuscar

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAjusta.Click
      ContraerForm
    End Sub
    Public Sub ContraerForm()
        If Me.Height > TextoReemplazar2.Top + TextoReemplazar2.Height + 50 Then
            Me.Height = TextoReemplazar2.Top + TextoReemplazar2.Height + 40
        Else
            Me.Height = ListaPredeterminados.Top + ListaPredeterminados.Height + 40
        End If
    End Sub

    Private Sub FormAuxiliar_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LocationChanged

    End Sub
    Private Sub FormAuxiliar_MenuComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MenuComplete

    End Sub

    Private Sub FormAuxiliar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Opacity = Me.Opacity + 0.05
        Else
            Me.Opacity = Me.Opacity - 0.05
            If Me.Opacity < 0.3 Then Me.Opacity = 0.4
        End If
    End Sub

    Private Sub CheckAcento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckAcento.CheckedChanged
        If CheckAcento.Checked = True Then
            CheckMay1.Checked = False
            CheckMay2.Checked = False
            CheckMin.Checked = False
            Teclado.CheckConShift.Checked = False
        End If
    End Sub

    Private Sub CheckMay1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckMay1.CheckedChanged
        If CheckMay1.Checked = True Then
            CheckAcento.Checked = False
            CheckMay2.Checked = False
            CheckMin.Checked = False
            Teclado.CheckConShift.Checked = False
        End If
    End Sub

    Private Sub CheckMin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckMin.CheckedChanged
        If CheckMin.Checked = True Then
            CheckAcento.Checked = False
            CheckMay2.Checked = False
            CheckMay1.Checked = False
            Teclado.CheckConShift.Checked = False
        End If
    End Sub

    Private Sub CheckMay2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckMay2.CheckedChanged
        If CheckMay2.Checked = True Then
            CheckAcento.Checked = False
            CheckMin.Checked = False
            CheckMay1.Checked = False
            Teclado.CheckConShift.Checked = False
        End If
    End Sub

    Private Sub BotonTeclado_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotonTeclado.MouseHover
        Anotador.TopMost = True
        Anotador.TopMost = False
        Me.TopMost = True
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'TextoBuscar1.Text = ""
        'TextoBuscar2.Text = ""
    End Sub
    Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            TextoBuscar1.Text = ""
            TextoBuscar2.Text = ""
        Else
            TextoBuscar1.Text = TextoBuscar1.Text & Anotador.Texto.SelectedText
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
     
    End Sub
    Private Sub Button2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            TextoReemplazar0.Text = ""
            TextoReemplazar1.Text = ""
            TextoReemplazar2.Text = ""
        Else
            TextoReemplazar0.Text = TextoReemplazar0.Text & Anotador.Texto.SelectedText
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextoReemplazar0.SelectedIndexChanged

    End Sub

    Private Sub TextoReemplazar1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextoReemplazar1.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextoBuscar1.Text = TextoBuscar1.Text & Anotador.Texto.SelectedText

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

  
   
End Class