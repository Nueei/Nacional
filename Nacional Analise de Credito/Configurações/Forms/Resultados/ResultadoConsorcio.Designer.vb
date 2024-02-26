<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResultadoConsorcio
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
        Me.updateLog = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.timer_Lbl = New System.Windows.Forms.Label()
        Me.parcelas_txt = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.vcredito_txt = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.entrada_txt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bottom_panel = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.bottom_panel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'updateLog
        '
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.timer_Lbl)
        Me.Panel1.Controls.Add(Me.parcelas_txt)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.vcredito_txt)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.entrada_txt)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(134, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(303, 374)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(44, 334)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(219, 31)
        Me.Panel2.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(22, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(180, 25)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Confirmar Proposta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 257)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(241, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Previsão do crédito: Disponível para dia 15 ou 30"
        '
        'timer_Lbl
        '
        Me.timer_Lbl.AutoSize = True
        Me.timer_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timer_Lbl.Location = New System.Drawing.Point(118, 301)
        Me.timer_Lbl.Name = "timer_Lbl"
        Me.timer_Lbl.Size = New System.Drawing.Size(62, 25)
        Me.timer_Lbl.TabIndex = 0
        Me.timer_Lbl.Text = "45:45"
        '
        'parcelas_txt
        '
        Me.parcelas_txt.AutoSize = True
        Me.parcelas_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parcelas_txt.Location = New System.Drawing.Point(28, 200)
        Me.parcelas_txt.Name = "parcelas_txt"
        Me.parcelas_txt.Size = New System.Drawing.Size(101, 31)
        Me.parcelas_txt.TabIndex = 0
        Me.parcelas_txt.Text = "Label1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Parcelas Fixas"
        '
        'vcredito_txt
        '
        Me.vcredito_txt.AutoSize = True
        Me.vcredito_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vcredito_txt.Location = New System.Drawing.Point(28, 122)
        Me.vcredito_txt.Name = "vcredito_txt"
        Me.vcredito_txt.Size = New System.Drawing.Size(101, 31)
        Me.vcredito_txt.TabIndex = 0
        Me.vcredito_txt.Text = "Label1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Valor do Crédito"
        '
        'entrada_txt
        '
        Me.entrada_txt.AutoSize = True
        Me.entrada_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.entrada_txt.Location = New System.Drawing.Point(28, 42)
        Me.entrada_txt.Name = "entrada_txt"
        Me.entrada_txt.Size = New System.Drawing.Size(101, 31)
        Me.entrada_txt.TabIndex = 0
        Me.entrada_txt.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Entrada"
        '
        'bottom_panel
        '
        Me.bottom_panel.Controls.Add(Me.Label9)
        Me.bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bottom_panel.Location = New System.Drawing.Point(0, 580)
        Me.bottom_panel.Name = "bottom_panel"
        Me.bottom_panel.Size = New System.Drawing.Size(915, 57)
        Me.bottom_panel.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "text"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Nacional_Analise_de_Credito.My.Resources.Resources.Resultado_BG1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(915, 637)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ResultadoConsorcio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(915, 637)
        Me.Controls.Add(Me.bottom_panel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ResultadoConsorcio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resulta_2_consorcio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.bottom_panel.ResumeLayout(False)
        Me.bottom_panel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents updateLog As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents timer_Lbl As Label
    Friend WithEvents parcelas_txt As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents vcredito_txt As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents entrada_txt As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bottom_panel As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Timer1 As Timer
End Class
