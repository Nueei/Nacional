<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DadosPessoais
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DadosPessoais))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ano_txt = New System.Windows.Forms.TextBox()
        Me.modelo_txt = New System.Windows.Forms.TextBox()
        Me.entrada_txt = New System.Windows.Forms.TextBox()
        Me.valor_veiculo_txt = New System.Windows.Forms.TextBox()
        Me.telefone_txt = New System.Windows.Forms.TextBox()
        Me.cpf_txt = New System.Windows.Forms.TextBox()
        Me.nascimento_txt = New System.Windows.Forms.TextBox()
        Me.nome_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Ground_IMG = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Ground_IMG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Ground_IMG)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1016, 640)
        Me.Panel2.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.ano_txt)
        Me.Panel1.Controls.Add(Me.modelo_txt)
        Me.Panel1.Controls.Add(Me.entrada_txt)
        Me.Panel1.Controls.Add(Me.valor_veiculo_txt)
        Me.Panel1.Controls.Add(Me.telefone_txt)
        Me.Panel1.Controls.Add(Me.cpf_txt)
        Me.Panel1.Controls.Add(Me.nascimento_txt)
        Me.Panel1.Controls.Add(Me.nome_txt)
        Me.Panel1.Location = New System.Drawing.Point(36, 177)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(559, 341)
        Me.Panel1.TabIndex = 0
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.ForeColor = System.Drawing.Color.Black
        Me.CheckBox2.Location = New System.Drawing.Point(22, 172)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(441, 56)
        Me.CheckBox2.TabIndex = 10
        Me.CheckBox2.Text = resources.GetString("CheckBox2.Text")
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel3.Location = New System.Drawing.Point(169, 270)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(222, 47)
        Me.Panel3.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Simular Financiamento"
        '
        'ano_txt
        '
        Me.ano_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ano_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ano_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ano_txt.Location = New System.Drawing.Point(419, 117)
        Me.ano_txt.MaxLength = 4
        Me.ano_txt.Name = "ano_txt"
        Me.ano_txt.Size = New System.Drawing.Size(114, 26)
        Me.ano_txt.TabIndex = 8
        '
        'modelo_txt
        '
        Me.modelo_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.modelo_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.modelo_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modelo_txt.Location = New System.Drawing.Point(22, 117)
        Me.modelo_txt.Name = "modelo_txt"
        Me.modelo_txt.Size = New System.Drawing.Size(391, 26)
        Me.modelo_txt.TabIndex = 7
        '
        'entrada_txt
        '
        Me.entrada_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.entrada_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.entrada_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.entrada_txt.Location = New System.Drawing.Point(308, 85)
        Me.entrada_txt.Name = "entrada_txt"
        Me.entrada_txt.Size = New System.Drawing.Size(225, 26)
        Me.entrada_txt.TabIndex = 6
        '
        'valor_veiculo_txt
        '
        Me.valor_veiculo_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.valor_veiculo_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.valor_veiculo_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valor_veiculo_txt.Location = New System.Drawing.Point(22, 85)
        Me.valor_veiculo_txt.Name = "valor_veiculo_txt"
        Me.valor_veiculo_txt.Size = New System.Drawing.Size(280, 26)
        Me.valor_veiculo_txt.TabIndex = 5
        '
        'telefone_txt
        '
        Me.telefone_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.telefone_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.telefone_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefone_txt.Location = New System.Drawing.Point(308, 53)
        Me.telefone_txt.Name = "telefone_txt"
        Me.telefone_txt.Size = New System.Drawing.Size(225, 26)
        Me.telefone_txt.TabIndex = 4
        '
        'cpf_txt
        '
        Me.cpf_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cpf_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cpf_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpf_txt.Location = New System.Drawing.Point(22, 53)
        Me.cpf_txt.Name = "cpf_txt"
        Me.cpf_txt.Size = New System.Drawing.Size(280, 26)
        Me.cpf_txt.TabIndex = 3
        '
        'nascimento_txt
        '
        Me.nascimento_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nascimento_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nascimento_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nascimento_txt.Location = New System.Drawing.Point(308, 21)
        Me.nascimento_txt.MaxLength = 10
        Me.nascimento_txt.Name = "nascimento_txt"
        Me.nascimento_txt.Size = New System.Drawing.Size(225, 26)
        Me.nascimento_txt.TabIndex = 2
        '
        'nome_txt
        '
        Me.nome_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nome_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nome_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nome_txt.Location = New System.Drawing.Point(22, 21)
        Me.nome_txt.Name = "nome_txt"
        Me.nome_txt.Size = New System.Drawing.Size(280, 26)
        Me.nome_txt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(38, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(556, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fácil, e rápido. Basta apenas preencher as informações abaixo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(604, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "As melhores condições para o seu financiamento"
        '
        'Ground_IMG
        '
        Me.Ground_IMG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ground_IMG.Image = Global.Nacional_Analise_de_Credito.My.Resources.Resources.Analise_BG1
        Me.Ground_IMG.Location = New System.Drawing.Point(0, 0)
        Me.Ground_IMG.Name = "Ground_IMG"
        Me.Ground_IMG.Size = New System.Drawing.Size(1016, 640)
        Me.Ground_IMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ground_IMG.TabIndex = 0
        Me.Ground_IMG.TabStop = False
        '
        'DadosPessoais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1016, 640)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DadosPessoais"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DadosP_Itau"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Ground_IMG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Ground_IMG As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ano_txt As TextBox
    Friend WithEvents entrada_txt As TextBox
    Friend WithEvents valor_veiculo_txt As TextBox
    Friend WithEvents telefone_txt As TextBox
    Friend WithEvents cpf_txt As TextBox
    Friend WithEvents nascimento_txt As TextBox
    Friend WithEvents nome_txt As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents modelo_txt As TextBox
    Friend WithEvents CheckBox2 As CheckBox
End Class
