Imports System.Globalization
Public Class ResultadoFinanciamento
    Dim pctEntrada As Integer = My.Settings.pct_entrada
    Dim valorVeiculo As Integer = My.Settings.valorVeiculo
    Dim txJuros As Double = My.Settings.tx_juros
    Dim vTarifas As Integer = My.Settings.tarifas_adc
    '/-/-/-/-/-\-\-\-\-\
    Dim currencyBR As New CultureInfo("pt-BR")
    '\-\-\-\-\-/-/-/-/-/
    Dim valorEntrada As Integer = (valorVeiculo - (valorVeiculo * (pctEntrada / 100)))
    Dim valorFinanciado As Integer = ((valorVeiculo - valorEntrada) * txJuros)
    '/-/-/-/-/-\-\-\-\-\
    Dim valorLiquido As Integer = valorVeiculo - valorEntrada
    Dim ValorTotalComJuros As Integer = (valorFinanciado * txJuros)
    Dim valorFinal As Integer = ((valorVeiculo - valorEntrada) + vTarifas) * txJuros
    '\-\-\-\-\-/-/-/-/-/
    Private Sub Panel12_Click(sender As Object, e As EventArgs) Handles Panel12.Click, Label16.Click, Label15.Click
        Main_Bank_Form.initialDelay = 70
        Main_Bank_Form.LimparControle()
        Main_Bank_Form.ExibirControle()
        Main_Bank_Form.atualAnalise = "resultado-consorcio"
        Main_Bank_Form.count_timer.Start()
    End Sub
    Private Sub Result_1_finan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Label17.Text = My.Settings.modeloVeiculo
            Label4.Text = $"O valor precisa estar entre: {valorEntrada.ToString("C", currencyBR)} e {valorFinanciado.ToString("C", currencyBR)}."
            vparcela12.Text = (valorFinanciado / 12).ToString("C", currencyBR)
            vparcela24.Text = (valorFinanciado / 24).ToString("C", currencyBR)
            vparcela36.Text = (valorFinanciado / 36).ToString("C", currencyBR)
            vparcela48.Text = (valorFinanciado / 48).ToString("C", currencyBR)
            vparcela60.Text = (valorFinanciado / 60).ToString("C", currencyBR)
            lblEntrada.Text = valorEntrada.ToString("C", currencyBR)
            vLiquidoLiberado.Text = valorLiquido.ToString("C", currencyBR)
            lblVFinanciado.Text = valorFinanciado.ToString("C", currencyBR)
            lblVTarifas.Text = vTarifas.ToString("C", currencyBR)
            exibirParcela.Text = $"48x de {(valorFinanciado / 48).ToString("C", currencyBR)}"
            totalSemSeguro.Text = (valorFinanciado + vTarifas + valorEntrada).ToString("C", currencyBR)
            Label18.Text = $"Veículo no valor de: {valorVeiculo.ToString("C", currencyBR)}"
            '-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
            entrada_bar.Size = New Size((liberado_bar.Width * (pctEntrada / 100)), 12)
        Catch ex As Exception
            MsgBox("Falha na conexão, reiniciando aplicação", MsgBoxStyle.Critical, "Atenção")
            Application.Restart()
        End Try
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles vparcela60.Click, Panel3.Click, Label5.Click
        exibirParcela.Text = $"60x de {(valorFinanciado / 60).ToString("C", currencyBR)}"
    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles vparcela48.Click, Panel4.Click, Label8.Click
        exibirParcela.Text = $"48x de {(valorFinanciado / 48).ToString("C", currencyBR)}"
    End Sub
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles vparcela36.Click, Panel5.Click, Label10.Click
        exibirParcela.Text = $"36x de {(valorFinanciado / 36).ToString("C", currencyBR)}"
    End Sub
    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles vparcela24.Click, Panel6.Click, Label12.Click
        exibirParcela.Text = $"24x de {(valorFinanciado / 24).ToString("C", currencyBR)}"
    End Sub
    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles vparcela12.Click, Panel7.Click, Label14.Click
        exibirParcela.Text = $"12x de {(valorFinanciado / 12).ToString("C", currencyBR)}"
    End Sub
End Class