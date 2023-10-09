<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DadosV_Itau
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.celular_panel = New System.Windows.Forms.Panel()
        Me.email_panel = New System.Windows.Forms.Panel()
        Me.nome_panel = New System.Windows.Forms.Panel()
        Me.cpf_panel = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.marca = New System.Windows.Forms.TextBox()
        Me.ano = New System.Windows.Forms.TextBox()
        Me.entrada = New System.Windows.Forms.TextBox()
        Me.valorveiculo_txt = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(427, 749)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Nacional.My.Resources.Resources.Itau_Ground3
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(934, 661)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(185, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Dados do Veículo"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(427, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(488, 749)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel3.Controls.Add(Me.RadioButton2)
        Me.Panel3.Controls.Add(Me.RadioButton1)
        Me.Panel3.Controls.Add(Me.Panel12)
        Me.Panel3.Controls.Add(Me.celular_panel)
        Me.Panel3.Controls.Add(Me.email_panel)
        Me.Panel3.Controls.Add(Me.nome_panel)
        Me.Panel3.Controls.Add(Me.cpf_panel)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.marca)
        Me.Panel3.Controls.Add(Me.ano)
        Me.Panel3.Controls.Add(Me.entrada)
        Me.Panel3.Controls.Add(Me.valorveiculo_txt)
        Me.Panel3.Location = New System.Drawing.Point(58, 120)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(399, 505)
        Me.Panel3.TabIndex = 2
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(104, 258)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(49, 17)
        Me.RadioButton2.TabIndex = 14
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Moto"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(36, 258)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(50, 17)
        Me.RadioButton1.TabIndex = 14
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Carro"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Panel12
        '
        Me.Panel12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel12.BackColor = System.Drawing.Color.Silver
        Me.Panel12.Controls.Add(Me.Label9)
        Me.Panel12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel12.Location = New System.Drawing.Point(92, 406)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(233, 41)
        Me.Panel12.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(81, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Avançar"
        '
        'celular_panel
        '
        Me.celular_panel.BackColor = System.Drawing.Color.Black
        Me.celular_panel.Location = New System.Drawing.Point(36, 241)
        Me.celular_panel.Name = "celular_panel"
        Me.celular_panel.Size = New System.Drawing.Size(331, 1)
        Me.celular_panel.TabIndex = 2
        '
        'email_panel
        '
        Me.email_panel.BackColor = System.Drawing.Color.Black
        Me.email_panel.Location = New System.Drawing.Point(36, 182)
        Me.email_panel.Name = "email_panel"
        Me.email_panel.Size = New System.Drawing.Size(331, 1)
        Me.email_panel.TabIndex = 2
        '
        'nome_panel
        '
        Me.nome_panel.BackColor = System.Drawing.Color.Black
        Me.nome_panel.Location = New System.Drawing.Point(36, 124)
        Me.nome_panel.Name = "nome_panel"
        Me.nome_panel.Size = New System.Drawing.Size(331, 1)
        Me.nome_panel.TabIndex = 2
        '
        'cpf_panel
        '
        Me.cpf_panel.BackColor = System.Drawing.Color.Black
        Me.cpf_panel.Location = New System.Drawing.Point(36, 68)
        Me.cpf_panel.Name = "cpf_panel"
        Me.cpf_panel.Size = New System.Drawing.Size(331, 1)
        Me.cpf_panel.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Marca, modelo e versão"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Ano modelo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Entrada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valor do veículo"
        '
        'marca
        '
        Me.marca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marca.Location = New System.Drawing.Point(36, 222)
        Me.marca.Name = "marca"
        Me.marca.Size = New System.Drawing.Size(331, 19)
        Me.marca.TabIndex = 4
        '
        'ano
        '
        Me.ano.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ano.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ano.Location = New System.Drawing.Point(36, 163)
        Me.ano.Name = "ano"
        Me.ano.Size = New System.Drawing.Size(331, 19)
        Me.ano.TabIndex = 3
        '
        'entrada
        '
        Me.entrada.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.entrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.entrada.Location = New System.Drawing.Point(36, 105)
        Me.entrada.Name = "entrada"
        Me.entrada.Size = New System.Drawing.Size(331, 19)
        Me.entrada.TabIndex = 2
        '
        'valorveiculo_txt
        '
        Me.valorveiculo_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.valorveiculo_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valorveiculo_txt.Location = New System.Drawing.Point(36, 49)
        Me.valorveiculo_txt.Name = "valorveiculo_txt"
        Me.valorveiculo_txt.Size = New System.Drawing.Size(331, 19)
        Me.valorveiculo_txt.TabIndex = 1
        '
        'DadosV_Itau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(915, 749)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DadosV_Itau"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DadosP_Itau"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents Label1 As Label
        Friend WithEvents Panel2 As Panel
        Friend WithEvents Panel3 As Panel
        Friend WithEvents email_panel As Panel
        Friend WithEvents nome_panel As Panel
        Friend WithEvents cpf_panel As Panel
        Friend WithEvents Label4 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents ano As TextBox
        Friend WithEvents entrada As TextBox
        Friend WithEvents valorveiculo_txt As TextBox
    Friend WithEvents celular_panel As Panel
    Friend WithEvents Label5 As Label
        Friend WithEvents marca As TextBox
        Friend WithEvents Panel12 As Panel
        Friend WithEvents Label9 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
End Class