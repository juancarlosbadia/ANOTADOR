<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTimer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTimer))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.TimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FijaTimerMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.TimerMinutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FijaMinutos = New System.Windows.Forms.ToolStripComboBox
        Me.MensajeTimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MensajeTimer = New System.Windows.Forms.ToolStripComboBox
        Me.ApagaTimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OcultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.TextoTimer = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BotonCreaArchivo = New System.Windows.Forms.Button
        Me.BotonInsertaRegistro = New System.Windows.Forms.Button
        Me.BotonLeeArchivo = New System.Windows.Forms.Button
        Me.ListaArchivo = New System.Windows.Forms.ListBox
        Me.BotonModificaRegustro = New System.Windows.Forms.Button
        Me.BotonBorraRegustro = New System.Windows.Forms.Button
        Me.TextoEventoTimer = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.PlazoTimer = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.FaltaTimer = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CumplidoTimer = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.PorCientoTimer = New System.Windows.Forms.TextBox
        Me.CheckTorta = New System.Windows.Forms.CheckBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TimerToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(334, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TimerToolStripMenuItem
        '
        Me.TimerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TimerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FijaTimerMenu, Me.TimerMinutosToolStripMenuItem, Me.MensajeTimerToolStripMenuItem, Me.ApagaTimerToolStripMenuItem, Me.OcultaToolStripMenuItem})
        Me.TimerToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerToolStripMenuItem.Name = "TimerToolStripMenuItem"
        Me.TimerToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.TimerToolStripMenuItem.Text = "Timer"
        '
        'FijaTimerMenu
        '
        Me.FijaTimerMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FijaTimerMenu.ForeColor = System.Drawing.Color.Maroon
        Me.FijaTimerMenu.Name = "FijaTimerMenu"
        Me.FijaTimerMenu.Size = New System.Drawing.Size(204, 22)
        Me.FijaTimerMenu.Text = "Fija Timer"
        '
        'TimerMinutosToolStripMenuItem
        '
        Me.TimerMinutosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TimerMinutosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FijaMinutos})
        Me.TimerMinutosToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.TimerMinutosToolStripMenuItem.Name = "TimerMinutosToolStripMenuItem"
        Me.TimerMinutosToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.TimerMinutosToolStripMenuItem.Text = "Timer minutos"
        '
        'FijaMinutos
        '
        Me.FijaMinutos.Items.AddRange(New Object() {"0,1", "0,2", "0,3", "0,5", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "90", "120", "180", "240"})
        Me.FijaMinutos.Name = "FijaMinutos"
        Me.FijaMinutos.Size = New System.Drawing.Size(75, 23)
        Me.FijaMinutos.Text = "1"
        '
        'MensajeTimerToolStripMenuItem
        '
        Me.MensajeTimerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MensajeTimerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MensajeTimer})
        Me.MensajeTimerToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.MensajeTimerToolStripMenuItem.Name = "MensajeTimerToolStripMenuItem"
        Me.MensajeTimerToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.MensajeTimerToolStripMenuItem.Text = "Mensaje Timer"
        '
        'MensajeTimer
        '
        Me.MensajeTimer.Items.AddRange(New Object() {"Verificar tiempo de la comida", "Llamar", "A dormir"})
        Me.MensajeTimer.Name = "MensajeTimer"
        Me.MensajeTimer.Size = New System.Drawing.Size(121, 23)
        Me.MensajeTimer.Text = "Tiempo cumplido"
        '
        'ApagaTimerToolStripMenuItem
        '
        Me.ApagaTimerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ApagaTimerToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.ApagaTimerToolStripMenuItem.Name = "ApagaTimerToolStripMenuItem"
        Me.ApagaTimerToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ApagaTimerToolStripMenuItem.Text = "Apaga timer"
        '
        'OcultaToolStripMenuItem
        '
        Me.OcultaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.OcultaToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.OcultaToolStripMenuItem.Name = "OcultaToolStripMenuItem"
        Me.OcultaToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.OcultaToolStripMenuItem.Text = "Oculta cuadro timer"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(27, 20)
        Me.ToolStripMenuItem1.Text = " -"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(27, 20)
        Me.ToolStripMenuItem2.Text = "+"
        '
        'TextoTimer
        '
        Me.TextoTimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextoTimer.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextoTimer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoTimer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextoTimer.Location = New System.Drawing.Point(4, 294)
        Me.TextoTimer.Multiline = True
        Me.TextoTimer.Name = "TextoTimer"
        Me.TextoTimer.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextoTimer.Size = New System.Drawing.Size(292, 93)
        Me.TextoTimer.TabIndex = 4
        '
        'Timer1
        '
        '
        'BotonCreaArchivo
        '
        Me.BotonCreaArchivo.Location = New System.Drawing.Point(4, 28)
        Me.BotonCreaArchivo.Name = "BotonCreaArchivo"
        Me.BotonCreaArchivo.Size = New System.Drawing.Size(52, 23)
        Me.BotonCreaArchivo.TabIndex = 5
        Me.BotonCreaArchivo.Text = "Crea"
        Me.BotonCreaArchivo.UseVisualStyleBackColor = True
        '
        'BotonInsertaRegistro
        '
        Me.BotonInsertaRegistro.Location = New System.Drawing.Point(53, 27)
        Me.BotonInsertaRegistro.Name = "BotonInsertaRegistro"
        Me.BotonInsertaRegistro.Size = New System.Drawing.Size(35, 23)
        Me.BotonInsertaRegistro.TabIndex = 6
        Me.BotonInsertaRegistro.Text = "Agr"
        Me.BotonInsertaRegistro.UseVisualStyleBackColor = True
        '
        'BotonLeeArchivo
        '
        Me.BotonLeeArchivo.Location = New System.Drawing.Point(123, 28)
        Me.BotonLeeArchivo.Name = "BotonLeeArchivo"
        Me.BotonLeeArchivo.Size = New System.Drawing.Size(52, 23)
        Me.BotonLeeArchivo.TabIndex = 7
        Me.BotonLeeArchivo.Text = "Lee"
        Me.BotonLeeArchivo.UseVisualStyleBackColor = True
        '
        'ListaArchivo
        '
        Me.ListaArchivo.FormattingEnabled = True
        Me.ListaArchivo.Location = New System.Drawing.Point(0, 107)
        Me.ListaArchivo.Name = "ListaArchivo"
        Me.ListaArchivo.Size = New System.Drawing.Size(292, 69)
        Me.ListaArchivo.TabIndex = 8
        '
        'BotonModificaRegustro
        '
        Me.BotonModificaRegustro.Location = New System.Drawing.Point(175, 27)
        Me.BotonModificaRegustro.Name = "BotonModificaRegustro"
        Me.BotonModificaRegustro.Size = New System.Drawing.Size(58, 23)
        Me.BotonModificaRegustro.TabIndex = 9
        Me.BotonModificaRegustro.Text = "Modifica"
        Me.BotonModificaRegustro.UseVisualStyleBackColor = True
        '
        'BotonBorraRegustro
        '
        Me.BotonBorraRegustro.Location = New System.Drawing.Point(233, 27)
        Me.BotonBorraRegustro.Name = "BotonBorraRegustro"
        Me.BotonBorraRegustro.Size = New System.Drawing.Size(52, 23)
        Me.BotonBorraRegustro.TabIndex = 10
        Me.BotonBorraRegustro.Text = "Borra"
        Me.BotonBorraRegustro.UseVisualStyleBackColor = True
        '
        'TextoEventoTimer
        '
        Me.TextoEventoTimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextoEventoTimer.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextoEventoTimer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoEventoTimer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextoEventoTimer.Location = New System.Drawing.Point(0, 49)
        Me.TextoEventoTimer.Multiline = True
        Me.TextoEventoTimer.Name = "TextoEventoTimer"
        Me.TextoEventoTimer.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextoEventoTimer.Size = New System.Drawing.Size(292, 52)
        Me.TextoEventoTimer.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(88, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Ins"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PlazoTimer
        '
        Me.PlazoTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlazoTimer.Location = New System.Drawing.Point(157, 174)
        Me.PlazoTimer.Name = "PlazoTimer"
        Me.PlazoTimer.Size = New System.Drawing.Size(135, 29)
        Me.PlazoTimer.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Plazo Timer Segs."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Falta Timer Segs."
        '
        'FaltaTimer
        '
        Me.FaltaTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FaltaTimer.Location = New System.Drawing.Point(157, 199)
        Me.FaltaTimer.Name = "FaltaTimer"
        Me.FaltaTimer.Size = New System.Drawing.Size(135, 29)
        Me.FaltaTimer.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Cumplido Segs."
        '
        'CumplidoTimer
        '
        Me.CumplidoTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CumplidoTimer.Location = New System.Drawing.Point(157, 228)
        Me.CumplidoTimer.Name = "CumplidoTimer"
        Me.CumplidoTimer.Size = New System.Drawing.Size(135, 29)
        Me.CumplidoTimer.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Cumplido %"
        '
        'PorCientoTimer
        '
        Me.PorCientoTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PorCientoTimer.Location = New System.Drawing.Point(157, 259)
        Me.PorCientoTimer.Name = "PorCientoTimer"
        Me.PorCientoTimer.Size = New System.Drawing.Size(135, 29)
        Me.PorCientoTimer.TabIndex = 19
        '
        'CheckTorta
        '
        Me.CheckTorta.AutoSize = True
        Me.CheckTorta.Checked = True
        Me.CheckTorta.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckTorta.Location = New System.Drawing.Point(131, 271)
        Me.CheckTorta.Name = "CheckTorta"
        Me.CheckTorta.Size = New System.Drawing.Size(15, 14)
        Me.CheckTorta.TabIndex = 21
        Me.CheckTorta.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(298, 259)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(36, 23)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Tr"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 399)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CheckTorta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PorCientoTimer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CumplidoTimer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FaltaTimer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PlazoTimer)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextoEventoTimer)
        Me.Controls.Add(Me.BotonBorraRegustro)
        Me.Controls.Add(Me.BotonModificaRegustro)
        Me.Controls.Add(Me.ListaArchivo)
        Me.Controls.Add(Me.BotonLeeArchivo)
        Me.Controls.Add(Me.BotonInsertaRegistro)
        Me.Controls.Add(Me.BotonCreaArchivo)
        Me.Controls.Add(Me.TextoTimer)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormTimer"
        Me.Text = "FormTimer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TextoTimer As System.Windows.Forms.TextBox
    Friend WithEvents TimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FijaTimerMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimerMinutosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MensajeTimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApagaTimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OcultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FijaMinutos As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents MensajeTimer As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BotonCreaArchivo As System.Windows.Forms.Button
    Friend WithEvents BotonInsertaRegistro As System.Windows.Forms.Button
    Friend WithEvents BotonLeeArchivo As System.Windows.Forms.Button
    Friend WithEvents ListaArchivo As System.Windows.Forms.ListBox
    Friend WithEvents BotonModificaRegustro As System.Windows.Forms.Button
    Friend WithEvents BotonBorraRegustro As System.Windows.Forms.Button
    Friend WithEvents TextoEventoTimer As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PlazoTimer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FaltaTimer As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CumplidoTimer As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PorCientoTimer As System.Windows.Forms.TextBox
    Friend WithEvents CheckTorta As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
