Public Class FormTortaTimer
    Public GraficoTorta As Graphics
    ' Public BitmapTorta As Bitmap
    Public ángulo As Single = 0.0
    Dim OpcionMover As Boolean
    Dim DondeX, DondeY As Integer

    'Public ángulo As Single = 0.0
    Dim rnd As New Random

    Dim sf As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}


    Private Sub PictureTorta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FormTortaTimer_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        If FormTimer.Timer1.Enabled = False Then
            FijaTimer()
            Anotador.TimerMenu.Text = "•"
        Else
            ApagaTimer()
            Anotador.TimerMenu.Text = "x"
            FormTimer.Visible = False
        End If
    End Sub

    Private Sub FormTortaTimer_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop

    End Sub

    Private Sub FormTortaTimer_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Width = Me.Height
        Me.TopMost = True
    End Sub

    Private Sub FormTortaTimer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub

    Private Sub FormTortaTimer_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim cuadro As Rectangle = New Rectangle(Me.Width * 0.2, Me.Width * 0.2, Me.Width * 0.5, Me.Width * 0.5)
        Dim trazo As Pen = New Pen(Brushes.Gold, Me.Width / 3)
        Dim letras As New Font("Arial", Me.Width / 20)
        Dim Porciento = CInt(ángulo / 3.6)
    
        If Porciento < 10 Then
            trazo.Color = Color.LightGreen
        ElseIf Porciento > 9 And Porciento < 20 Then
            trazo.Color = Color.Cyan
        ElseIf Porciento > 19 And Porciento < 30 Then
            trazo.Color = Color.Orange
        ElseIf Porciento > 29 And Porciento < 40 Then
            trazo.Color = Color.Chocolate
        ElseIf Porciento > 39 And Porciento < 50 Then
            trazo.Color = Color.Maroon
        ElseIf Porciento > 49 And Porciento < 60 Then
            trazo.Color = Color.Green
        ElseIf Porciento > 59 And Porciento < 70 Then
            trazo.Color = Color.Violet
        ElseIf Porciento > 69 And Porciento < 80 Then
            trazo.Color = Color.Blue
        ElseIf Porciento > 79 And Porciento < 90 Then
            trazo.Color = Color.DarkViolet

        ElseIf Porciento > 89 Then
            trazo.Color = Color.Red
        End If

        'e.Graphics.DrawString((ángulo / 3.6).ToString("N0") & "%", letras, Brushes.Black, cuadro, sf)
        e.Graphics.DrawArc(trazo, cuadro, 0, ángulo)
        e.Graphics.DrawString((Porciento).ToString("N0") & "%", letras, Brushes.Black, cuadro, sf)


    End Sub

    Private Sub FormTortaTimer_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.TopMost = True
        OpcionMover = True
        DondeX = e.X '- Me.Left
        DondeY = e.Y '- Me.Top

    End Sub

    Private Sub FormTortaTimer_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        OpcionMover = False
    End Sub

    Private Sub FormTortaTimer_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If OpcionMover = True Then
                Me.Top = (Me.Top - DondeY + e.Y) ' (Me.Top - 10 + e.Y) ' - Me.Height / 2
                Me.Left = (Me.Left - DondeX + e.X) ' (Me.Left - 10 + e.X) ' - Me.Width / 2
            End If
        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then

            Me.Width = e.X + 20 'TextoReloj.Left + e.X

            Me.Height = e.Y + 20 'TextoReloj.Top + e.Y

            '  Dim Margen As Integer = Me.Width / 4.8
            ' Dim Fuente As New Font("Arial", 1 * Margen, 1, GraphicsUnit.Point, 0)
            'Me.Font = Fuente
        Else
            'nada
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        Me.TopMost = True
        Dim OPACIDAD = Me.Opacity
        If e.Button = Windows.Forms.MouseButtons.Left Then
            OPACIDAD = OPACIDAD + 0.05
        Else
            OPACIDAD = OPACIDAD - 0.05
        End If
        If OPACIDAD > 1 Then OPACIDAD = 1
        If OPACIDAD < 0.01 Then OPACIDAD = 0.01
        Me.Opacity = OPACIDAD
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseDown
        Me.BackColor = Color.LightGray
        Me.TopMost = True
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Opacity = 1
        End If

        If Me.TransparencyKey = Color.LightGray Then
            Me.TransparencyKey = Color.DarkGray
        Else
            Me.TransparencyKey = Color.LightGray
        End If

    End Sub

    Private Sub BotonTeclado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonTeclado.Click

    End Sub

    Private Sub BotonTeclado_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BotonTeclado.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Anotador.TopMost = True
            Anotador.Focus()
        Else
            Me.Visible = False
        End If
     
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseDown
        If FormTimer.Visible = False Then
            FormTimer.Visible = True
            FormTimer.TopMost = True
        Else
            FormTimer.Visible = False
        End If
    End Sub
End Class