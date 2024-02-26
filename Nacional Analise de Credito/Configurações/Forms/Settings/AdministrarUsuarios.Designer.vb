<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdministrarUsuarios
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
        Me.RBData2 = New System.Windows.Forms.RadioButton()
        Me.RBtodos = New System.Windows.Forms.RadioButton()
        Me.RBData1 = New System.Windows.Forms.RadioButton()
        Me.RBNome = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RBUser = New System.Windows.Forms.RadioButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.new_nome = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.new_repass = New System.Windows.Forms.TextBox()
        Me.new_pass = New System.Windows.Forms.TextBox()
        Me.new_user = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'RBData2
        '
        Me.RBData2.AutoSize = True
        Me.RBData2.Location = New System.Drawing.Point(14, 102)
        Me.RBData2.Name = "RBData2"
        Me.RBData2.Size = New System.Drawing.Size(141, 17)
        Me.RBData2.TabIndex = 11
        Me.RBData2.Text = "Mais tempo sem acessar"
        Me.RBData2.UseVisualStyleBackColor = True
        '
        'RBtodos
        '
        Me.RBtodos.AutoSize = True
        Me.RBtodos.Checked = True
        Me.RBtodos.Location = New System.Drawing.Point(14, 10)
        Me.RBtodos.Name = "RBtodos"
        Me.RBtodos.Size = New System.Drawing.Size(55, 17)
        Me.RBtodos.TabIndex = 10
        Me.RBtodos.TabStop = True
        Me.RBtodos.Text = "Todos"
        Me.RBtodos.UseVisualStyleBackColor = True
        '
        'RBData1
        '
        Me.RBData1.AutoSize = True
        Me.RBData1.Location = New System.Drawing.Point(14, 79)
        Me.RBData1.Name = "RBData1"
        Me.RBData1.Size = New System.Drawing.Size(151, 17)
        Me.RBData1.TabIndex = 9
        Me.RBData1.Text = "Menos tempo sem acessar"
        Me.RBData1.UseVisualStyleBackColor = True
        '
        'RBNome
        '
        Me.RBNome.AutoSize = True
        Me.RBNome.Location = New System.Drawing.Point(14, 33)
        Me.RBNome.Name = "RBNome"
        Me.RBNome.Size = New System.Drawing.Size(53, 17)
        Me.RBNome.TabIndex = 8
        Me.RBNome.Text = "Nome"
        Me.RBNome.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RBData2)
        Me.Panel1.Controls.Add(Me.RBtodos)
        Me.Panel1.Controls.Add(Me.RBData1)
        Me.Panel1.Controls.Add(Me.RBUser)
        Me.Panel1.Controls.Add(Me.RBNome)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Location = New System.Drawing.Point(293, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(186, 165)
        Me.Panel1.TabIndex = 14
        '
        'RBUser
        '
        Me.RBUser.AutoSize = True
        Me.RBUser.Location = New System.Drawing.Point(14, 56)
        Me.RBUser.Name = "RBUser"
        Me.RBUser.Size = New System.Drawing.Size(61, 17)
        Me.RBUser.TabIndex = 9
        Me.RBUser.Text = "Usuário"
        Me.RBUser.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(42, 128)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 32)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Filtrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.AllowUserToOrderColumns = True
        Me.dgvDados.AllowUserToResizeRows = False
        Me.dgvDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDados.Location = New System.Drawing.Point(12, 183)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.Size = New System.Drawing.Size(632, 254)
        Me.dgvDados.TabIndex = 15
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.new_nome)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.new_repass)
        Me.Panel3.Controls.Add(Me.new_pass)
        Me.Panel3.Controls.Add(Me.new_user)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(12, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(275, 165)
        Me.Panel3.TabIndex = 13
        '
        'new_nome
        '
        Me.new_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.new_nome.Location = New System.Drawing.Point(104, 7)
        Me.new_nome.MaxLength = 49
        Me.new_nome.Name = "new_nome"
        Me.new_nome.Size = New System.Drawing.Size(156, 20)
        Me.new_nome.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(60, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Nome:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(185, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Cadastrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Confirmar Senha:"
        '
        'new_repass
        '
        Me.new_repass.Location = New System.Drawing.Point(104, 90)
        Me.new_repass.MaxLength = 20
        Me.new_repass.Name = "new_repass"
        Me.new_repass.Size = New System.Drawing.Size(156, 20)
        Me.new_repass.TabIndex = 4
        '
        'new_pass
        '
        Me.new_pass.Location = New System.Drawing.Point(104, 61)
        Me.new_pass.MaxLength = 20
        Me.new_pass.Name = "new_pass"
        Me.new_pass.Size = New System.Drawing.Size(156, 20)
        Me.new_pass.TabIndex = 3
        '
        'new_user
        '
        Me.new_user.Location = New System.Drawing.Point(104, 35)
        Me.new_user.MaxLength = 20
        Me.new_user.Name = "new_user"
        Me.new_user.Size = New System.Drawing.Size(156, 20)
        Me.new_user.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Senha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuário:"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(542, 449)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 32)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Atualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AdministrarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 493)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Button2)
        Me.Name = "AdministrarUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdministrarUsuarios"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RBData2 As RadioButton
    Friend WithEvents RBtodos As RadioButton
    Friend WithEvents RBData1 As RadioButton
    Friend WithEvents RBNome As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RBUser As RadioButton
    Friend WithEvents Button3 As Button
    Friend WithEvents dgvDados As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents new_nome As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents new_repass As TextBox
    Friend WithEvents new_pass As TextBox
    Friend WithEvents new_user As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
End Class
