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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.logo_pic = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.center_panel = New System.Windows.Forms.Panel()
        Me.load_pic = New System.Windows.Forms.PictureBox()
        Me.initial_timer = New System.Windows.Forms.Timer(Me.components)
        Me.count_timer = New System.Windows.Forms.Timer(Me.components)
        Me.InputLog = New System.ComponentModel.BackgroundWorker()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.top_panel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.logo_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.center_panel.SuspendLayout()
        CType(Me.load_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel17.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'top_panel
        '
        Me.top_panel.Controls.Add(Me.Label5)
        Me.top_panel.Controls.Add(Me.Label4)
        Me.top_panel.Controls.Add(Me.TableLayoutPanel1)
        Me.top_panel.Controls.Add(Me.logo_pic)
        Me.top_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.top_panel.Location = New System.Drawing.Point(0, 0)
        Me.top_panel.Name = "top_panel"
        Me.top_panel.Size = New System.Drawing.Size(915, 81)
        Me.top_panel.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(756, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 18)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Operador credenciado"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Location = New System.Drawing.Point(817, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Encerrar aplicativo"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.46154!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.53846!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(179, 36)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.75!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.25!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(434, 42)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(268, 30)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(158, 4)
        Me.Panel4.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(121, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(141, 4)
        Me.Panel3.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(8, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(107, 4)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Para você"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(121, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Para Empresas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(268, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Políticas de uso"
        '
        'logo_pic
        '
        Me.logo_pic.Location = New System.Drawing.Point(3, 3)
        Me.logo_pic.Name = "logo_pic"
        Me.logo_pic.Size = New System.Drawing.Size(85, 72)
        Me.logo_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo_pic.TabIndex = 1
        Me.logo_pic.TabStop = False
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
        'load_pic
        '
        Me.load_pic.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.load_pic.Location = New System.Drawing.Point(426, 24)
        Me.load_pic.Name = "load_pic"
        Me.load_pic.Size = New System.Drawing.Size(85, 79)
        Me.load_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.load_pic.TabIndex = 0
        Me.load_pic.TabStop = False
        '
        'initial_timer
        '
        Me.initial_timer.Interval = 1000
        '
        'count_timer
        '
        Me.count_timer.Interval = 1000
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
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.Nacional.My.Resources.Resources.whatsapp_logo
        Me.PictureBox2.Location = New System.Drawing.Point(792, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(111, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
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
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.logo_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.center_panel.ResumeLayout(False)
        CType(Me.load_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents top_panel As Panel
    Friend WithEvents logo_pic As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents center_panel As Panel
    Friend WithEvents load_pic As PictureBox
    Friend WithEvents initial_timer As Timer
    Friend WithEvents count_timer As Timer
    Friend WithEvents InputLog As System.ComponentModel.BackgroundWorker
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel17 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label30 As Label
End Class
