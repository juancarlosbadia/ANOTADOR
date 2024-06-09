Public Class FormInforme

    Private Sub Informe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Informa(ByVal LugarDelInforme As String)
        Me.TopMost = True
        TextoDirectorioActual.Text = Anotador.Ruta
        TextoNombreArchivo.Text = Anotador.Nombre
        TextoNombreArchivoConExtension.Text = Anotador.NombreExtension
        TextoLugarDelInforme.Text = LugarDelInforme
        TextoPathInicial.Text = Anotador.PathInicial

    End Sub

    Private Sub BotonAchicaAgranda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAchicaAgranda.Click

    End Sub

    Private Sub BotonAchicaAgranda_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonAchicaAgranda.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            AchicaAgrandaTexto(0)
        Else
            AchicaAgrandaTexto(1)
        End If
    End Sub
    Private Sub AchicaAgrandaTexto(ByVal Valor)
        Dim Parametro As Decimal
        If Valor = 1 Then Parametro = 1.1
        If Valor = 0 Then Parametro = 0.9
        Dim Fuente = TextoNombreArchivo.Font
        Fuente = New Font(Fuente.FontFamily, Fuente.Size * Parametro, Fuente.Style, Fuente.Unit, Fuente.GdiCharSet)
        TextoNombreArchivo.Font = Fuente
        TextoDirectorioActual.Font = Fuente
        TextoLugarDelInforme.Font = Fuente
        TextoNombreArchivoConExtension.Font = Fuente
        TextoPathInicial.Font = Fuente
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AnalizaTexto("")

    End Sub
    Private Sub AnalizaTexto(ByVal Cadena As String)
        'for
    End Sub

    Private Sub BotonTeclado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonTeclado.Click

    End Sub

    Private Sub BotonTeclado_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonTeclado.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Anotador.Minimizado = False Then
                Anotador.Posiciones00()
                Anotador.Texto.Focus()
            Else
                Anotador.ExpandeAnotador()
                Anotador.Texto.Focus()
            End If
        Else
            Me.Visible = False
        End If
    End Sub
End Class