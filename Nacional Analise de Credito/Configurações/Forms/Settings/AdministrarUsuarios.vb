Public Class AdministrarUsuarios
    Dim dsDados As New DataSet
    Dim con As New Config_Class
    Private Sub Cadastrar_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If new_nome.Text = "" Then
            new_nome.Focus()
            new_nome.BackColor = Color.FromArgb(255, 174, 201)
            Exit Sub
        End If
        If new_user.Text = "" Then
            new_user.Focus()
            new_user.BackColor = Color.FromArgb(255, 174, 201)
            Exit Sub
        End If
        If new_pass.Text = "" Then
            new_pass.Focus()
            new_pass.BackColor = Color.FromArgb(255, 174, 201)
            Exit Sub
        End If
        If new_pass.Text <> new_repass.Text Then
            new_repass.Focus()
            new_repass.BackColor = Color.FromArgb(255, 174, 201)
            MsgBox("Senhas não conferem", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Atenção!")
            Exit Sub
        End If
        Me.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        CadastrarNovoUsuario()
    End Sub
    Sub CadastrarNovoUsuario()
        My.Settings.nomeUsuario = "LEMBRE DE ME APAGAR"
        '-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        Try
            con.Operar($"INSERT INTO `users` VALUES (NULL, '{new_nome.Text}', '{new_user.Text}', '{new_pass.Text}', '{My.Settings.usernameAcesso}','VENDEDOR', '{DateAndTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}', '{"Nunca Acessou"}'); ")
        Catch ex As Exception
            If ex.Message.Contains("Duplicate") Then
                MsgBox("Nome de usuário já cadastrado!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Atenção")
                Me.Enabled = True
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
            MsgBox("Um erro foi encontrado durante o cadastro: " & vbNewLine & ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERRO INTERNO")
        End Try
        atualizarUsuarios()
        LimparCampos()
        Me.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub
    Sub atualizarUsuarios(Optional sql As String = "")
        If My.Settings.cargoUsuario = "SUPER USER" Then
            sql = $"SELECT ID, nome, nomeusuario, senha, ultimoacesso FROM `users` where `quem_cadastrou` LIKE '%'"
        End If
        If sql = "" Then
            sql = $"SELECT ID, nome, nomeusuario, senha, ultimoacesso FROM `users` where `quem_cadastrou` = '{My.Settings.usernameAcesso}'"
        End If
        Try

            dsDados = con.Listar(sql)
            CarregarDados()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub CarregarDados()
        If dsDados.Tables(0).Rows.Count > 0 Then
            dgvDados.AutoGenerateColumns = True
            dgvDados.DataSource = dsDados.Tables(0)

            If dgvDados.Columns.Contains("btnExcluir") = False Then
                Dim btnExcluir As New DataGridViewButtonColumn()
                btnExcluir.HeaderText = "Excluir"
                btnExcluir.Text = "Excluir"
                btnExcluir.Name = "btnExcluir"
                btnExcluir.UseColumnTextForButtonValue = True
                dgvDados.Columns.Add(btnExcluir)
            End If

            If dgvDados.Columns.Contains("btnAlterar") = False Then
                Dim btnAlterar As New DataGridViewButtonColumn()
                btnAlterar.HeaderText = "Alterar"
                btnAlterar.Text = "Alterar"
                btnAlterar.Name = "btnAlterar"
                btnAlterar.UseColumnTextForButtonValue = True
                dgvDados.Columns.Add(btnAlterar)
            End If
        Else
            MsgBox("Adicione um novo usuário, ou refine o filtro", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Nenhum cadastro encontrado")
            For i = 0 To dgvDados.Columns.Count
                dgvDados.Columns.Clear()
            Next
            dgvDados.DataSource = Nothing
        End If
        Try
            dgvDados.Columns(dgvDados.Columns.Count - 2).Width = 45
            dgvDados.Columns(dgvDados.Columns.Count - 1).Width = 45
        Catch
        End Try
    End Sub
    Private Sub dgvDados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellClick
        If e.ColumnIndex = dgvDados.Columns("btnExcluir").Index AndAlso e.RowIndex >= 0 Then
            Dim userId As Integer = Convert.ToInt32(dgvDados.Rows(e.RowIndex).Cells("ID").Value)
            ExcluirUsuario(userId)
            CarregarDados()
        End If
        If e.ColumnIndex = dgvDados.Columns("btnAlterar").Index AndAlso e.RowIndex >= 0 Then
            Dim userId As Integer = Convert.ToInt32(dgvDados.Rows(e.RowIndex).Cells("ID").Value)
            AlterarUsuario(userId)
            CarregarDados()
        End If
    End Sub
    Sub ExcluirUsuario(userId As Integer)
        If MsgBox("Deseja realmente excluir este cadastro?", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "ATENÇÃO") = DialogResult.OK Then
            Dim senhaUsuario As String = InputBox("Digite a sua senha:", "EXCLUIR CADASTRO", "", 0, 0)
            If senhaUsuario.ToString.ToUpper = My.Settings.senhaUser Then
                Try
                    con.Operar($"DELETE FROM users WHERE `users`.`id` = {userId}")
                    MsgBox("Usuário excluido", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Sucesso!")
                    atualizarUsuarios()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("Senha incorreta!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Exclusão negada")
            End If
        End If
    End Sub
    Sub AlterarUsuario(userId As Integer)
        If MsgBox("Deseja alterar a senha deste cadastro?", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "ATENÇÃO") = DialogResult.OK Then
            Dim senhaUsuario As String = InputBox("Digite a sua senha:", "ALTERAR CADASTRO", "", 0, 0)
            If senhaUsuario.ToString.ToUpper = My.Settings.senhaUser Then
                Try
                    Dim senha As String = InputBox("Digite a nova senha:", "ALTERAR SENHA", "", 0, 0)
                    Dim resenha As String = InputBox("Digite novamente a senha:", "REPITA NOVA SENHA", "", 0, 0)
                    If senha = resenha Then
                        con.Operar($"UPDATE `users` SET `senha` = '{senha}' WHERE `users`.`id` = {userId};")
                        atualizarUsuarios()
                    Else
                        MsgBox("Senhas não conferem! Tente novamente", MsgBoxStyle.OkOnly, "OPERAÇÃO CANCELADA")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("Senha incorreta!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Alteração negada")
            End If
        End If
    End Sub
    Sub LimparCampos()
        new_nome.Text = ""
        new_user.Text = ""
        new_pass.Text = ""
        new_repass.Text = ""
        new_nome.BackColor = Color.White
        new_user.BackColor = Color.White
        new_pass.BackColor = Color.White
        new_repass.BackColor = Color.White
    End Sub
    Private Sub New_repass_TextChanged(sender As Object, e As EventArgs) Handles new_user.TextChanged, new_repass.TextChanged, new_pass.TextChanged, new_nome.TextChanged
        Try
            sender.backColor = Color.White
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i = 0 To dgvDados.Columns.Count
            dgvDados.Columns.Clear()
        Next

        dgvDados.DataSource = Nothing
        atualizarUsuarios()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim quemCadastrou As String = My.Settings.usernameAcesso
        If RBtodos.Checked = True Then
            atualizarUsuarios()
        End If
        If RBNome.Checked = True Then
            Dim nome As String = InputBox("Digite o nome para pesquisa", "NOME COMPLETO, OU PARTE DO NOME", "", 0, 0)
            atualizarUsuarios($"SELECT ID, nome, nomeusuario, senha, ultimoacesso FROM users WHERE nome LIKE '%{nome}%' and quem_cadastrou = '{quemCadastrou}';")
        End If
        If RBUser.Checked = True Then
            Dim userNome As String = InputBox("Digite o NOME DE USUÁRIO para pesquisa", "NOME DE USUÁRIO COMPLETO, OU PARTE DO NOME DE USUÁRIO", "", 0, 0)
            atualizarUsuarios($"SELECT ID, nome, nomeusuario, senha, ultimoacesso FROM users WHERE nomeusuario = '{userNome}' and quem_cadastrou = '{quemCadastrou}';")
        End If
        If RBData1.Checked = True Then
            atualizarUsuarios($"SELECT ID, nome, nomeusuario, senha, ultimoacesso FROM users WHERE quem_cadastrou = '{quemCadastrou}' ORDER BY CASE WHEN ultimoacesso = 'Nunca Acessou' THEN 2 ELSE 1 END, ultimoacesso DESC;")
        End If
        If RBData2.Checked = True Then
            atualizarUsuarios($"SELECT ID, nome, nomeusuario, senha, ultimoacesso FROM users WHERE quem_cadastrou = '{quemCadastrou}' Order By CASE WHEN ultimoacesso = 'Nunca Acessou' THEN 1 ELSE 2 END, ultimoacesso ASC;")
        End If
    End Sub

    Private Sub AdministrarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class