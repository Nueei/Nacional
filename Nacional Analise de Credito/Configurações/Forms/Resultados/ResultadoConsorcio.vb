Imports System.Globalization
Imports System.Reflection.Emit

Public Class ResultadoConsorcio
    Dim coeficiente As Double
    Dim sql As String
    Dim logCode As String = My.Settings.logCode
    Dim atualCode As String = My.Settings.atualCode
    Dim con As New Config_Class
    Dim vVeiculo As Integer = My.Settings.valorVeiculo
    Dim maxMin As Integer = 45
    Dim maxSec As Integer = 59
    Dim currencyBR As New CultureInfo("pt-BR")
    Private Sub updateLog_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles updateLog.DoWork
        Try
            con.Operar(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Resulta_2_consorcio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        '-=-=-=-=-=-=-=-=-=-=-=-
        Main_Bank_Form.logo_pic.Image = My.Resources.Banco_Central_logo

        '-=-=-=-=-=-=-=-=-=-=-=-

        Label9.Text = "Ao clicar em continuar, você concorda com todos os termos de uso do aplicativo. Concorda também que está ciente de todos os termos e que os leu completamente em algum momento. Clicando em continuar, você também concorda que esta oferta é única e não será oferecida novamente em nenhum outro momento, caso o tempo tenha expirado. Caso o tempo se esgote, outra oferta será analisada. Não há garantias de que serão oferecidas as mesmas condições acima.Caso discorde de alguma informação acima, NÃO UTILIZE ESTE SIMULADOR. Encerre o aplicativo e releia todos os termos novamente. Essa oferta não é oferecida por nenhum banco ou empresa e trata-se apenas de uma simulação. Leia completamente o contrato antes da assinatura."
        Label9.MaximumSize = New Size(bottom_panel.Size.Width, bottom_panel.Size.Height)


        Select Case atualCode
            Case "COD 1"
                coeficiente = 7.5 / 100
            Case "COD 2"
                coeficiente = 9.5 / 100
            Case "COD 3"
                coeficiente = 12.5 / 100
            Case "COD ESPECIAL"
                coeficiente = 15 / 100
        End Select
        Dim credito As Double() = {20305, 22500, 25000, 27500, 30000, 35000, 40000, 45000, 50000, 55000, 60000, 65000, 70000, 75000, 80000, 90000, 100000, 110000, 120000, 130000}
        Dim entrada(credito.Length - 1) As Double
        Dim parcela As Double() = {325.5, 366.18, 406.87, 447.56, 488.24, 569.62, 650.99, 732.37, 813.74, 895.11, 976.49, 1057.86, 1139.24, 1220.61, 1301.98, 1464.73, 1627.48, 1790.23, 1952.98, 2115.72}


        For i = 0 To credito.Length - 1
            entrada(i) = credito(i) * coeficiente
            '-=-=-=-==-

        Next

        Dim numIndexDados As Integer = EncontrarIndiceNumeroMaisProximo(credito, vVeiculo)


        entrada_txt.Text = (credito(numIndexDados) * coeficiente).ToString("C", currencyBR)
        vcredito_txt.Text = credito(numIndexDados).ToString("C", currencyBR)
        parcelas_txt.Text = parcela(numIndexDados).ToString("C", currencyBR)
        sql = $"UPDATE `logs` SET mostradoResultado = 'Sim' , vveiculo = '{vVeiculo.ToString()}', vcredito = '{(credito(numIndexDados)).ToString()}'  WHERE `logs`.`log_code` = '{logCode}';"

        updateLog.RunWorkerAsync()
    End Sub


    Function EncontrarIndiceNumeroMaisProximo(numeros() As Double, valorEscolhido As Integer) As Integer
        Dim indiceNumeroMaisProximo As Integer = 0
        Dim menorDiferenca As Integer = Math.Abs(valorEscolhido - numeros(0))
        For i As Integer = 1 To numeros.Length - 1
            Dim diferenca As Integer = Math.Abs(valorEscolhido - numeros(i))
            If diferenca < menorDiferenca Then
                menorDiferenca = diferenca
                indiceNumeroMaisProximo = i
            End If
        Next
        Return indiceNumeroMaisProximo
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        maxSec -= 1
        If maxSec <= 0 Then
            maxSec = 59
            maxMin -= 1
            If maxMin <= 0 Then
                Timer1.Stop()
                timer_Lbl.Text = "00" & ":" & "00"
                MsgBox("Devido ao tempo de análise ter se expirado, descartaremos o resultado da sua simulação!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Sentimos Muito")

                End
            End If
        End If
        timer_Lbl.Text = maxMin.ToString("00") & ":" & maxSec.ToString("00")
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Panel2.Click, Label10.Click
        MsgBox($"Cota garantida com sucesso! Gere o contrato nº{con.NumeroAleatorio(4).ToString & vbNewLine } clique em OK para iniciar o cadastro do contrato.")
        Process.Start("https://federalconsorcios.sistemasircon.com.br/login")
        My.Settings.Reset()
        End
    End Sub
End Class