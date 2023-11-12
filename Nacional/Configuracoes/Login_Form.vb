Imports System.ComponentModel

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
    '||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    Private Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.Reset()

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
    'n7eeie67
    Private Sub Extract_pass_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Extract_pass.DoWork

        '-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        For codeGen = 1 To 3
            Try
                ds = Config.Listar($"SELECT credito, entrada, parcela FROM `CODE{codeGen}` WHERE 1")
                ReDim vParcelas(ds.Tables(0).Rows().Count)
                ReDim vCredito(ds.Tables(0).Rows().Count)
                ReDim vEntrada(ds.Tables(0).Rows().Count)
                For i = 0 To ds.Tables(0).Rows().Count - 1
                    vEntrada(i) = ds.Tables(0).Rows(i)("entrada")
                    vParcelas(i) = ds.Tables(0).Rows(i)("parcela")
                    vCredito(i) = ds.Tables(0).Rows(i)("credito")
                Next

                For i = 0 To ds.Tables(0).Rows.Count - 1
                    If i = ds.Tables(0).Rows.Count - 1 Then
                        vCreditoS = vCreditoS & ds.Tables(0).Rows(i)("credito").ToString
                        vParcelasS = vParcelasS & ds.Tables(0).Rows(i)("parcela").ToString
                        vEntradaS = vEntradaS & ds.Tables(0).Rows(i)("entrada").ToString
                        Exit For
                    End If
                    vCreditoS = vCreditoS & ds.Tables(0).Rows(i)("credito").ToString & ","
                    vParcelasS = vParcelasS & ds.Tables(0).Rows(i)("parcela").ToString & ","
                    vEntradaS = vEntradaS & ds.Tables(0).Rows(i)("entrada").ToString & ","
                Next

                Select Case codeGen
                    Case = 1
                        With My.Settings
                            .creditoC1 = vCreditoS
                            .entradaC1 = vEntradaS
                            .parcelaC1 = vParcelasS
                        End With
                    Case = 2
                        With My.Settings
                            .creditoC2 = vCreditoS
                            .entradaC2 = vEntradaS
                            .parcelaC2 = vParcelasS
                        End With
                    Case = 3
                        With My.Settings
                            .creditoC3 = vCreditoS
                            .entradaC3 = vEntradaS
                            .parcelaC3 = vParcelasS
                        End With
                End Select
                vCreditoS = Nothing
                vParcelasS = Nothing
                vEntradaS = Nothing
            Catch ex As Exception
                MsgBox("Erro interno de sistema, finalizando aplicação!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção!")
                End
            End Try
        Next
        Try
            ds = Nothing
            ds = Config.Listar("SELECT * FROM `sys_config` where id_pass = '1'")
        Catch ex As Exception
            MsgBox("Erro critico ao tentar acesso ao sistema." + vbNewLine + "Contate o supervisor.", MsgBoxStyle.Critical, "Atenção")
        End Try
    End Sub
    '-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
    ' End Sub

    Private Sub Extract_pass_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles Extract_pass.RunWorkerCompleted
        If ds.Tables(0).Rows.Count > 0 Then
            Dim pass As String = InputBox("Digite a senha de acesso ao sistema:", "Atenção", "", -1, -1)
            If pass = "" Then
                pass = InputBox("Digite a senha de acesso ao sistema:", "Atenção", "", -1, -1)
            End If
            If pass = ds.Tables(0).Rows(0)("pass").ToString Then
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
    Sub ResultITAU()
        My.Settings.atualBank = "ITAU"
        My.Settings.primaryColor = Color.FromArgb(236, 116, 0)
        My.Settings.secondaryColor = Color.White
        Main_Bank_Form.Show()
        Me.Close()
    End Sub
End Class