Imports System.ComponentModel
Imports System.Net.Mail

Public Class Login_Form
    Dim Config As New Config_Class
    Dim ds As New DataSet
    Dim bf As Integer = 45
    Dim timeToConfig As Integer = 10
    Dim PodeAlterar = False
    '-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
    Public Function SomenteLetras(ByVal key As String) As Boolean
        If (key >= 65 And key <= 90) Or (key >= 97 And key <= 122) Or (key >= 48 And key <= 57) Or key = 8 Then
            SomenteLetras = False
        Else
            SomenteLetras = True
        End If
    End Function
    Private Sub CPF_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles username.KeyPress
        e.Handled = SomenteLetras(Asc(e.KeyChar))
    End Sub
    Private Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.Reset()
        Dim txtAjuda As New Config_Class
        txtAjuda.SetTextoAJuda(username, "NOME DE USUÁRIO")
        txtAjuda.SetTextoAJuda(password, "SENHA DE ACESSO")
        username.Focus()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If username.Text = "" Then
            MsgBox("Preencha o nome de usuário", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Atenção")
            username.Focus()
            Exit Sub
        End If
        If password.Text = "" Then
            MsgBox("Preencha a senha de acesso", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Atenção")
            password.Focus()
            Exit Sub
        End If
        Panel1.Visible = False
        PictureBox1.Visible = True
        Me.TopMost = True
        My.Settings.Reset()
        PictureBox1.Visible = True
        Break_BRUTEFORCE.Start()
        Login_BGW.RunWorkerAsync()
        Me.TopMost = False
    End Sub
    Private Sub LoginBGWWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Login_BGW.DoWork
        Try
            ds = Nothing
            ds = Config.Listar($"SELECT * FROM `users` WHERE nomeusuario = '{username.Text}' and senha = '{password.Text}'")
            Try
                Config.Operar($"update `users` SET ultimoacesso = '{DateAndTime.Now.ToString()}' WHERE nomeusuario = '{username.Text}' and senha = '{password.Text}'")
            Catch ex As Exception

            End Try
        Catch ex As Exception
            MsgBox("Erro critico ao tentar acesso ao sistema." + vbNewLine + "Contate o supervisor.", MsgBoxStyle.Critical, "Atenção")
            End
        End Try
    End Sub
    Private Sub Extract_pass_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles Login_BGW.RunWorkerCompleted
        If ds.Tables(0).Rows.Count > 0 Then
            Panel1.Visible = True
            PictureBox1.Visible = False
            With My.Settings
                .nomeUsuario = ds.Tables(0).Rows(0)("nome").ToString.ToUpper
                .usernameAcesso = ds.Tables(0).Rows(0)("nomeusuario").ToString.ToUpper
                .cargoUsuario = ds.Tables(0).Rows(0)("cargo").ToString.ToUpper
            End With
            Panel1.Visible = False
            PictureBox1.Visible = True
            'logado com sucesso
            My.Settings.senhaUser = password.Text.ToString.ToUpper()
            PodeAlterar = True
            Break_BRUTEFORCE.Stop()
            Config_Count.Start()
        Else
            Break_BRUTEFORCE.Stop()
            MsgBox("Nome de usuário ou senha incorreto", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
            Panel1.Visible = True
            PictureBox1.Visible = False
        End If
    End Sub
    Private Sub Break_BRUTEFORCE_Tick(sender As Object, e As EventArgs) Handles Break_BRUTEFORCE.Tick
        bf -= 1
        If bf <= 0 Then
            Break_BRUTEFORCE.Stop()
            MsgBox("Tempo limite esgotado." + vbNewLine + "Encerrando aplicação", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
            End
        End If
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef m As Message, ByVal keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.Alt Or Keys.F1 And PodeAlterar = True
                Config_Count.Stop()
                If Finan_config.ShowDialog = DialogResult.OK Then
                    timeToConfig = 10
                    Config_Count.Start()
                End If
                Return True
            Case Else
                Return False
        End Select
    End Function
    Sub FinalizarLogin()
        Config_Count.Stop()
        Main_Bank_Form.Show()
        Me.Close()
    End Sub

    Private Sub Config_Count_Tick(sender As Object, e As EventArgs) Handles Config_Count.Tick
        timeToConfig -= 1
        If timeToConfig <= 0 Then
            FinalizarLogin()
        End If
    End Sub
End Class
