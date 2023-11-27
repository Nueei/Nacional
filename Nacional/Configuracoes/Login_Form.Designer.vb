<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_form))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.animacao_aguarde = New System.Windows.Forms.Timer(Me.components)
        Me.Aguarde_lbl = New System.Windows.Forms.Label()
        Me.Extract_pass = New System.ComponentModel.BackgroundWorker()
        Me.Break_BRUTEFORCE = New System.Windows.Forms.Timer(Me.components)
        Me.Aleatorizar_banco = New System.Windows.Forms.Timer(Me.components)
        Me.downloadVersion = New System.ComponentModel.BackgroundWorker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 392)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sempre fique atento(a) as políticas de uso, elas podem ter sido alteradas!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Nacional.My.Resources.Resources.basic_load_preto
        Me.PictureBox1.Location = New System.Drawing.Point(148, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'animacao_aguarde
        '
        Me.animacao_aguarde.Interval = 300
        '
        'Aguarde_lbl
        '
        Me.Aguarde_lbl.AutoSize = True
        Me.Aguarde_lbl.Location = New System.Drawing.Point(152, 138)
        Me.Aguarde_lbl.Name = "Aguarde_lbl"
        Me.Aguarde_lbl.Size = New System.Drawing.Size(47, 13)
        Me.Aguarde_lbl.TabIndex = 2
        Me.Aguarde_lbl.Text = "Aguarde"
        Me.Aguarde_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Extract_pass
        '
        '
        'Break_BRUTEFORCE
        '
        Me.Break_BRUTEFORCE.Interval = 1000
        '
        'Aleatorizar_banco
        '
        Me.Aleatorizar_banco.Interval = 1000
        '
        'downloadVersion
        '
        '
        'Login_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(364, 410)
        Me.Controls.Add(Me.Aguarde_lbl)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents animacao_aguarde As Timer
    Friend WithEvents Aguarde_lbl As Label
    Friend WithEvents Extract_pass As System.ComponentModel.BackgroundWorker
    Friend WithEvents Break_BRUTEFORCE As Timer
    Friend WithEvents Aleatorizar_banco As Timer
    Friend WithEvents downloadVersion As System.ComponentModel.BackgroundWorker
End Class
