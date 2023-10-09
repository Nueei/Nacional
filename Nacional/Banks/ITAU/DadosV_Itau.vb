Public Class DadosV_Itau
    Dim nextStep As Boolean = False
    Dim TipoVeiculo As String
    Dim valorVeiculo As Integer
    Dim entradaI As Integer
    Dim anoVeiculo As String
    Dim modeloVeiculo As String
    Private Sub Cpf_txt_Enter(sender As Object, e As EventArgs) Handles valorveiculo_txt.Enter
        cpf_panel.BackColor = Color.FromArgb(236, 116, 0)
    End Sub
    Private Sub Cpf_txt_Leave(sender As Object, e As EventArgs) Handles valorveiculo_txt.Leave
        cpf_panel.BackColor = Color.Black
    End Sub
    Private Sub Nome_txt_Enter(sender As Object, e As EventArgs) Handles entrada.Enter
        nome_panel.BackColor = Color.FromArgb(236, 116, 0)
    End Sub
    Private Sub Nome_txt_Leave(sender As Object, e As EventArgs) Handles entrada.Leave
        nome_panel.BackColor = Color.Black
    End Sub
    Private Sub Email_txt_Enter(sender As Object, e As EventArgs) Handles ano.Enter
        email_panel.BackColor = Color.FromArgb(236, 116, 0)
    End Sub
    Private Sub Email_txt_Leave(sender As Object, e As EventArgs) Handles ano.Leave
        anoVeiculo = sender.text
        email_panel.BackColor = Color.Black
    End Sub
    Private Sub celular_txt_Enter(sender As Object, e As EventArgs) Handles marca.Enter
        TipoVeiculo = sender.text
        celular_panel.BackColor = Color.FromArgb(236, 116, 0)
    End Sub
    Private Sub celular_txt_Leave(sender As Object, e As EventArgs) Handles marca.Leave
        modeloVeiculo = sender.text
        celular_panel.BackColor = Color.Black
    End Sub
    Private Sub CPF_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles entrada.KeyPress, valorveiculo_txt.KeyPress
        e.Handled = SomenteNumero(Asc(e.KeyChar))

    End Sub

    Private Sub Valorveiculo_txt_Enter(sender As Object, e As EventArgs) Handles valorveiculo_txt.Enter
        If valorVeiculo <> 0 Then
            Try
                sender.text = valorVeiculo
            Catch ex As Exception
                sender.text = ""
            End Try
        End If
    End Sub
    Private Sub ValorVeiculo_txt_Leave(sender As Object, e As EventArgs) Handles valorveiculo_txt.Leave
        If sender.text <> "" Then
            valorVeiculo = sender.text
            sender.text = valorVeiculo.ToString("C")
        End If
    End Sub

    Private Sub Entrada_Enter(sender As Object, e As EventArgs) Handles entrada.Enter
        If entradaI <> 0 Then
            Try
                sender.text = entradaI
            Catch ex As Exception
                sender.text = ""
            End Try
        End If
    End Sub
    Private Sub Entrada_Leave(sender As Object, e As EventArgs) Handles entrada.Leave
        If sender.text <> "" Then
            entradaI = sender.text
            sender.text = entradaI.ToString("C")
        End If
    End Sub


    Private Sub celular_txt_TextChanged(sender As Object, e As EventArgs) Handles marca.TextChanged, entrada.TextChanged, valorveiculo_txt.TextChanged, ano.TextChanged, RadioButton1.CheckedChanged
        If valorveiculo_txt.Text <> "" And ano.Text <> "" And entrada.Text <> "" Then
            nextStep = True
            Panel12.BackColor = Color.FromArgb(236, 116, 0)
            Label9.ForeColor = Color.White
        Else
            Panel12.BackColor = Color.Silver
            Label9.ForeColor = Color.White
            nextStep = False
        End If
    End Sub
    Public Function SomenteNumero(ByVal key As String) As Boolean
        If (key >= 48 And key <= 57) Or key = 8 Then
            SomenteNumero = False
        Else
            SomenteNumero = True
        End If
    End Function
    Private Sub Panel12_Click(sender As Object, e As EventArgs) Handles Panel12.Click, Label9.Click
        If nextStep = True Then
            With My.Settings
                .tipoVeiculo = tipoVeiculo.ToString.ToUpper
                .valorVeiculo = valorVeiculo
                .anoVeiculo = anoVeiculo
                .modeloVeiculo = modeloVeiculo
            End With
            '/-/-/-/-/-/-/-/-/-/-\-\-\-\-\-\-\-\-\-\-\-\
            Main_Bank_Form.initialDelay = 30
            Main_Bank_Form.LimparControle()
            Main_Bank_Form.ExibirControle()
            Main_Bank_Form.atualAnalise = "segunda-analise"
            Main_Bank_Form.count_timer.Start()
        End If
    End Sub
End Class