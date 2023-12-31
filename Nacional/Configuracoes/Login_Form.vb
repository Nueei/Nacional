﻿Imports System.ComponentModel
Imports System.Text
Imports System.Net.WebClient
Imports System.Net

Public Class Login_form
    Dim Config As New Config_Class
    Dim ds As New DataSet
    Dim bf As Integer = 30
    Dim timeToRnd As Integer = 20
    Dim PodeAlterar = False
    '||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    Dim vCredito As Double()
    Dim vParcelas As Double()
    Dim vEntrada As Double()
    '-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
    Dim vCreditoS As String
    Dim vParcelasS As String
    Dim vEntradaS As String
    Dim isAtualizavel As Boolean
    '||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    Private Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        My.Settings.Reset()
        animacao_aguarde.Start()
        '/*/*/*/*/*/*/*/*/*\*\*\*\*\*\*\*\*\*\
        Break_BRUTEFORCE.Start()
        Extract_pass.RunWorkerAsync()
        Me.TopMost = False
    End Sub
    Private Sub Animacao_aguarde_Tick(sender As Object, e As EventArgs) Handles animacao_aguarde.Tick
        Aguarde_lbl.Text = Aguarde_lbl.Text & "."
        If Aguarde_lbl.Text = "Aguarde...." Then
            Aguarde_lbl.Text = "Aguarde"
        End If
    End Sub
    Private Sub Extract_pass_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Extract_pass.DoWork

        '-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        Try
            ds = Nothing
            ds = Config.Listar("SELECT * FROM `sys_config` where id_config = '1'")
            If isNecessarioAtualizar(ds.Tables(0).Rows(0)("sys_version")) Then

                downloadVersion.RunWorkerAsync()
                isAtualizavel = True
                Exit Sub

            End If
        Catch ex As Exception
            '    MsgBox("Erro critico ao tentar acesso ao sistema." + vbNewLine + "Contate o supervisor.", MsgBoxStyle.Critical, "Atenção")
            MsgBox(ex.Message)
        End Try
    End Sub
    '-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

    Function isNecessarioAtualizar(versaoMaisRecente As String) As Boolean
        Dim versaoInstalada As String = My.Application.Info.Version.ToString()
        If versaoInstalada <> versaoMaisRecente Then
            ' Aguarde_lbl.Text = ("Nova versão do sistema detectada," + vbNewLine + "Aguarde enquanto finalizamos o download!")

            Return True 'true quando as versões são diferentes
        End If
        Return False
    End Function


    '-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
    Private Sub downloadVersion_DoWork(sender As Object, e As DoWorkEventArgs) Handles downloadVersion.DoWork
        Dim urlNovaVersao As String = ds.Tables(0).Rows(0)("download_link").ToString
        Dim localDeDownload As String = Application.StartupPath.ToString & "\NacionalUpdate.exe"

        Dim wbClient As New WebClient
        wbClient.DownloadFile(urlNovaVersao, localDeDownload)
        Process.Start(localDeDownload)
        End
    End Sub
    Private Sub Extract_pass_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles Extract_pass.RunWorkerCompleted
        If isAtualizavel = False Then
            If ds.Tables(0).Rows.Count > 0 Then
                Dim pass As String = InputBox("Digite a senha de acesso ao sistema:", "Atenção", "", -1, -1)
                If pass = "" Then
                    pass = InputBox("Digite a senha de acesso ao sistema:", "Atenção", "", -1, -1)
                End If
                Try
                    pass = pass.ToUpper
                Catch ex As Exception

                End Try
                If pass.ToUpper = ds.Tables(0).Rows(0)("pass").ToString.ToUpper Then
                    MsgBox("Logado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Sucesso.")

                    Break_BRUTEFORCE.Stop()
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
        End If
    End Sub

    Private Sub Break_BRUTEFORCE_Tick(sender As Object, e As EventArgs) Handles Break_BRUTEFORCE.Tick
        bf -= 1
        If bf <= 0 Then
            Break_BRUTEFORCE.Stop()
            Extract_pass.Dispose()
            MsgBox("Tempo limite esgotado." + vbNewLine + "Encerrando aplicação", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
            End
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
                Aleatorizar_banco.Stop()
                animacao_aguarde.Stop()
                If Finan_config.ShowDialog = DialogResult.OK Then
                    Aleatorizar_banco.Start()
                    animacao_aguarde.Start()
                End If
                Return True
            Case Keys.F1 And PodeAlterar = True
                Aleatorizar_banco.Stop()
                animacao_aguarde.Stop()
                PodeAlterar = False
                '/-/-/-/-/-/-/-\-\-\-\-\-\-\
                ResultBV()
                Return True
            Case Keys.F2 And PodeAlterar = True
                Aleatorizar_banco.Stop()
                animacao_aguarde.Stop()
                PodeAlterar = False
                '/-/-/-/-/-/-/-\-\-\-\-\-\-\
                ResultITAU()
                Return True
            Case Keys.F3 And PodeAlterar = True
                Aleatorizar_banco.Stop()
                animacao_aguarde.Stop()
                PodeAlterar = False
                '/-/-/-/-/-/-/-\-\-\-\-\-\-\
                ResultPAN()
                Return True
            Case Keys.F4 And PodeAlterar = True
                Aleatorizar_banco.Stop()
                animacao_aguarde.Stop()
                PodeAlterar = False
                '/-/-/-/-/-/-/-\-\-\-\-\-\-\
                ResultSantander()
                Return True
            Case Keys.F5 And PodeAlterar = True
                Aleatorizar_banco.Stop()
                animacao_aguarde.Stop()
                PodeAlterar = False
                '/-/-/-/-/-/-/-\-\-\-\-\-\-\
                ResultBB()
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
                ResultBV()
            Case 2
                ResultITAU()
            Case 3
                ResultPAN()
            Case 4
                ResultSantander()
            Case 5
                ResultBB()
            Case Else
                ResultBV()
        End Select
    End Sub
    Sub ResultBV()
        My.Settings.atualBank = "BV"
        My.Settings.secondaryColor = Color.FromArgb(75, 115, 218)
        Main_Bank_Form.Show()
        Me.Close()
    End Sub
    Sub ResultBB()
        My.Settings.atualBank = "BB"
        My.Settings.primaryColor = Color.FromArgb(255, 239, 56)
        My.Settings.secondaryColor = Color.FromArgb(0, 61, 164)
        Main_Bank_Form.Show()
        Me.Close()
    End Sub
    Sub ResultITAU()
        My.Settings.atualBank = "ITAU"
        My.Settings.primaryColor = Color.FromArgb(236, 116, 0)
        My.Settings.secondaryColor = Color.White
        Main_Bank_Form.Show()
        Me.Close()
    End Sub
    Sub ResultPAN()
        My.Settings.atualBank = "PAN"
        My.Settings.primaryColor = Color.FromArgb(65, 65, 65)
        My.Settings.secondaryColor = Color.FromArgb(0, 197, 255)
        Main_Bank_Form.Show()
        Me.Close()
    End Sub
    Sub ResultSantander()
        My.Settings.atualBank = "SANTANDER"
        My.Settings.primaryColor = Color.FromArgb(235, 1, 4)
        My.Settings.secondaryColor = Color.FromArgb(255, 255, 255)
        Main_Bank_Form.Show()
        Me.Close()
    End Sub

    Private Sub downloadVersion_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles downloadVersion.RunWorkerCompleted
        MsgBox("Download concluido")
        End
    End Sub
End Class