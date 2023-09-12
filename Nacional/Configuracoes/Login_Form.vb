Imports System.ComponentModel

Public Class Login_form
    Dim Config As New Config_Class
    Dim ds As New DataSet
    Dim bf As Integer = 20
    Dim timeToRnd As Integer = 20
    Dim PodeAlterar = False
    Private Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        animacao_aguarde.Start()
        '/*/*/*/*/*/*/*/*/*\*\*\*\*\*\*\*\*\*\
        Break_BRUTEFORCE.Start()
        Extract_pass.RunWorkerAsync()
    End Sub
    Private Sub Animacao_aguarde_Tick(sender As Object, e As EventArgs) Handles animacao_aguarde.Tick
        Aguarde_lbl.Text = Aguarde_lbl.Text & "."
        If Aguarde_lbl.Text = "Aguarde...." Then
            Aguarde_lbl.Text = "Aguarde"
        End If
    End Sub

    Private Sub Extract_pass_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Extract_pass.DoWork
        Try

            ds = Config.Listar("SELECT * FROM `sys_config` where id_pass = '1'")
        Catch ex As Exception
            MsgBox("Erro critico ao tentar acesso ao sistema." + vbNewLine + "Contate o supervisor.", MsgBoxStyle.Critical, "Atenção")
        End Try
    End Sub

    Private Sub Extract_pass_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles Extract_pass.RunWorkerCompleted
        If ds.Tables(0).Rows.Count > 0 Then
            Dim pass As String = InputBox("Digite a senha de acesso ao sistema:", "Atenção", "", -1, -1)
            If pass = "" Then
                pass = InputBox("Digite a senha de acesso ao sistema:", "Atenção", "", -1, -1)
            End If
            If pass = ds.Tables(0).Rows(0)("pass").ToString Then
                MsgBox("Logado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Sucesso.")
                Aleatorizar_banco.Start()
                PodeAlterar = True
            Else
                MsgBox("Senha incorreta, encerrando aplicação.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                End
            End If
        Else
            Break_BRUTEFORCE.Stop()
            MsgBox("O sistema não retornou nenhuma consulta", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
            End
        End If

    End Sub

    Private Sub Break_BRUTEFORCE_Tick(sender As Object, e As EventArgs) Handles Break_BRUTEFORCE.Tick
        bf -= 1
        If bf <= 0 Then
            Break_BRUTEFORCE.Stop()
            Extract_pass.Dispose()
            End
            MsgBox("Tempo limite esgotado." + vbNewLine + "Encerrando aplicação", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End If
    End Sub

    Private Sub Aleatorizar_banco_Tick(sender As Object, e As EventArgs) Handles Aleatorizar_banco.Tick
        timeToRnd -= 1
        If timeToRnd <= 0 Then
            Aleatorizar()
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef m As Message, ByVal keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.Alt Or Keys.F1 And PodeAlterar = True
                If Finan_config.ShowDialog = DialogResult.OK Then
                    Aleatorizar_banco.Stop()
                    animacao_aguarde.Stop()
                Else
                    Aleatorizar_banco.Start()
                    Aleatorizar_banco.Stop()
                End If
                Return True
            Case Keys.F1 And PodeAlterar = True
                resultBV()
                Return True
            Case Else
                Return False
        End Select
    End Function

    Sub Aleatorizar()
        Aleatorizar_banco.Stop()
        Dim int As Integer
        Dim rnd As New Random
        int = rnd.Next(0, 6)
        Select Case int
            Case 1
                resultBV()
            Case Else
                resultBV()
        End Select
    End Sub
    Sub ResultBV()
        My.Settings.atualBank = "BV"
        My.Settings.secondaryColor = Color.FromArgb(75, 115, 218)
        My.Settings.primaryColor = Color.White
        Main_Bank_Form.ShowDialog()
        Me.Close()
    End Sub
End Class
