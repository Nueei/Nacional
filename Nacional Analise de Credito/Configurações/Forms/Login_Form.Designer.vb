<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Form))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Login_BGW = New System.ComponentModel.BackgroundWorker()
        Me.Break_BRUTEFORCE = New System.Windows.Forms.Timer(Me.components)
        Me.username = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Config_Count = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
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
        'Login_BGW
        '
        '
        'Break_BRUTEFORCE
        '
        Me.Break_BRUTEFORCE.Interval = 1000
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(46, 23)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(178, 20)
        Me.username.TabIndex = 3
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(46, 49)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Size = New System.Drawing.Size(178, 20)
        Me.password.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(46, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Acessar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.password)
        Me.Panel1.Controls.Add(Me.username)
        Me.Panel1.Location = New System.Drawing.Point(54, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(268, 119)
        Me.Panel1.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Nacional_Analise_de_Credito.My.Resources.Resources.basic_load_preto
        Me.PictureBox1.Location = New System.Drawing.Point(150, 110)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Config_Count
        '
        Me.Config_Count.Interval = 1000
        '
        'Login_Form
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(364, 410)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Login_BGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents Break_BRUTEFORCE As Timer
    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Config_Count As Timer
End Class
