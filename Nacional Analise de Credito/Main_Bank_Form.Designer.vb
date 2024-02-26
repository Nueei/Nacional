<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Bank_Form
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Bank_Form))
        Me.top_panel = New System.Windows.Forms.Panel()
        Me.admin_LBL = New System.Windows.Forms.Label()
        Me.politica_LBL = New System.Windows.Forms.Label()
        Me.close_LBL = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.center_panel = New System.Windows.Forms.Panel()
        Me.initial_timer = New System.Windows.Forms.Timer(Me.components)
        Me.InputLog = New System.ComponentModel.BackgroundWorker()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.count_timer = New System.Windows.Forms.Timer(Me.components)
        Me.load_pic = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.logo_pic = New System.Windows.Forms.PictureBox()
        Me.top_panel.SuspendLayout()
        Me.center_panel.SuspendLayout()
        Me.Panel17.SuspendLayout()
        CType(Me.load_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'top_panel
        '
        Me.top_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.top_panel.Controls.Add(Me.admin_LBL)
        Me.top_panel.Controls.Add(Me.politica_LBL)
        Me.top_panel.Controls.Add(Me.close_LBL)
        Me.top_panel.Controls.Add(Me.logo_pic)
        Me.top_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.top_panel.ForeColor = System.Drawing.Color.White
        Me.top_panel.Location = New System.Drawing.Point(0, 0)
        Me.top_panel.Name = "top_panel"
        Me.top_panel.Size = New System.Drawing.Size(915, 81)
        Me.top_panel.TabIndex = 0
        '
        'admin_LBL
        '
        Me.admin_LBL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.admin_LBL.AutoSize = True
        Me.admin_LBL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.admin_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_LBL.Location = New System.Drawing.Point(756, 37)
        Me.admin_LBL.Name = "admin_LBL"
        Me.admin_LBL.Size = New System.Drawing.Size(156, 18)
        Me.admin_LBL.TabIndex = 4
        Me.admin_LBL.Text = "Operador credenciado"
        '
        'politica_LBL
        '
        Me.politica_LBL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.politica_LBL.AutoSize = True
        Me.politica_LBL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.politica_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.politica_LBL.Location = New System.Drawing.Point(804, 59)
        Me.politica_LBL.Name = "politica_LBL"
        Me.politica_LBL.Size = New System.Drawing.Size(108, 18)
        Me.politica_LBL.TabIndex = 3
        Me.politica_LBL.Text = "Política de Uso"
        '
        'close_LBL
        '
        Me.close_LBL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.close_LBL.AutoSize = True
        Me.close_LBL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_LBL.Location = New System.Drawing.Point(817, 3)
        Me.close_LBL.Name = "close_LBL"
        Me.close_LBL.Size = New System.Drawing.Size(95, 13)
        Me.close_LBL.TabIndex = 3
        Me.close_LBL.Text = "Encerrar aplicativo"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 81)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(915, 4)
        Me.Panel5.TabIndex = 1
        '
        'center_panel
        '
        Me.center_panel.AutoScroll = True
        Me.center_panel.BackColor = System.Drawing.Color.White
        Me.center_panel.Controls.Add(Me.load_pic)
        Me.center_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.center_panel.Location = New System.Drawing.Point(0, 85)
        Me.center_panel.Name = "center_panel"
        Me.center_panel.Size = New System.Drawing.Size(915, 424)
        Me.center_panel.TabIndex = 2
        '
        'initial_timer
        '
        Me.initial_timer.Interval = 1
        '
        'InputLog
        '
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Panel17.Controls.Add(Me.PictureBox2)
        Me.Panel17.Controls.Add(Me.Label32)
        Me.Panel17.Controls.Add(Me.Label30)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel17.Location = New System.Drawing.Point(0, 509)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(915, 67)
        Me.Panel17.TabIndex = 9
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(12, 47)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(393, 13)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "De segunda à sexta-feira, das 08 às 18h. Sábado de 09h às 15h, exceto feriados."
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(12, 9)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(214, 13)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "CENTRAL DE SUPORTE A VENDAS"
        '
        'count_timer
        '
        Me.count_timer.Interval = 1
        '
        'load_pic
        '
        Me.load_pic.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.load_pic.Image = Global.Nacional_Analise_de_Credito.My.Resources.Resources.RED_LOAD_GIF
        Me.load_pic.Location = New System.Drawing.Point(431, 38)
        Me.load_pic.Name = "load_pic"
        Me.load_pic.Size = New System.Drawing.Size(58, 59)
        Me.load_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.load_pic.TabIndex = 0
        Me.load_pic.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.Nacional_Analise_de_Credito.My.Resources.Resources.whatsapp_logo
        Me.PictureBox2.Location = New System.Drawing.Point(792, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(111, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'logo_pic
        '
        Me.logo_pic.Image = Global.Nacional_Analise_de_Credito.My.Resources.Resources.teste
        Me.logo_pic.Location = New System.Drawing.Point(6, 3)
        Me.logo_pic.Name = "logo_pic"
        Me.logo_pic.Size = New System.Drawing.Size(189, 80)
        Me.logo_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo_pic.TabIndex = 1
        Me.logo_pic.TabStop = False
        '
        'Main_Bank_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(915, 576)
        Me.Controls.Add(Me.center_panel)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel17)
        Me.Controls.Add(Me.top_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main_Bank_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main_BV"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.top_panel.ResumeLayout(False)
        Me.top_panel.PerformLayout()
        Me.center_panel.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        CType(Me.load_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents top_panel As Panel
    Friend WithEvents logo_pic As PictureBox
    Friend WithEvents politica_LBL As Label
    Friend WithEvents close_LBL As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents center_panel As Panel
    Friend WithEvents load_pic As PictureBox
    Friend WithEvents initial_timer As Timer
    Friend WithEvents InputLog As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel17 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents admin_LBL As Label
    Friend WithEvents count_timer As Timer
End Class
