Public Class DadosP_BV
    Dim tipoVeiculo As String
    Dim modeloVeiculo As String
    Dim primaryColor As Color = My.Settings.primaryColor
    Dim secondaryColor As Color = My.Settings.secondaryColor
    Dim nextStep As Boolean
    '/-/-/-/-/-/-/-/-/-/-\-\-\-\-\-\-\-\-\-\-\-\
    Dim valorVeiculo As Integer
    Dim entradaI As Integer
    Dim anoVeiculo As Integer
    '/-/-/-/-/-/-/-/-/-/-\-\-\-\-\-\-\-\-\-\-\-\
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
        tipoVeiculo = sender.text
        Panel2.Visible = True
        Label2.Text = $"Você já sabe qual o modelo de {sender.TEXT.ToString.ToUpper} quer financiar?"
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Panel3.Visible = True
        modeloVeiculo = "Ainda não decidi o modelo."
        If sender.checked = True Then
            ano.Visible = False
            ano_panel.Visible = False
            marca.Visible = False
            marca_panel.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            marca.Text = "AINDA NÃO DECIDIDO"
        Else
            ano.Visible = True
            ano_panel.Visible = True
            marca.Visible = True
            marca_panel.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            marca.Text = ""
        End If
    End Sub
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Panel3.Visible = True
    End Sub
    Private Sub Nome_TextChanged(sender As Object, e As EventArgs) Handles nome.TextChanged
        If sender.text <> "" Then
            If nome.Text.Contains(" ") Then
                Panel4.Visible = True
            End If
        End If
    End Sub
    Private Sub Nome_Enter(sender As Object, e As EventArgs) Handles nome.Enter
        nome_panel.BackColor = secondaryColor
    End Sub
    Private Sub Nome_Leave(sender As Object, e As EventArgs) Handles nome.Leave
        nome_panel.BackColor = Color.Black
    End Sub
    Private Sub Cpf_Enter(sender As Object, e As EventArgs) Handles cpf.Enter
        cpf_panel.BackColor = secondaryColor
    End Sub
    Private Sub Cpf_Leave(sender As Object, e As EventArgs) Handles cpf.Leave
        cpf_panel.BackColor = Color.Black
    End Sub
    Private Sub Cpf_TextChanged(sender As Object, e As EventArgs) Handles cpf.TextChanged
        If sender.text <> "" Then
            If cpf.Text.Length >= 11 Then
                Panel5.Visible = True
            Else
                Panel5.Visible = False
                last_panel.Visible = False
            End If
        End If
    End Sub
    Private Sub Valorveiculo_txt_Enter(sender As Object, e As EventArgs) Handles valorveiculo_txt.Enter
        valorveiculo_panel.BackColor = secondaryColor
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
            valorveiculo_panel.BackColor = Color.Black
        End If
    End Sub
    Private Sub Entrada_Enter(sender As Object, e As EventArgs) Handles entrada.Enter
        entrada_panel.BackColor = secondaryColor
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
            entrada_panel.BackColor = Color.Black
            sender.text = entradaI.ToString("C")
        End If
    End Sub
    Private Sub Ano_Enter(sender As Object, e As EventArgs) Handles ano.Enter
        ano_panel.BackColor = secondaryColor
    End Sub
    Private Sub Ano_Leave(sender As Object, e As EventArgs) Handles ano.Leave
        ano_panel.BackColor = Color.Black
    End Sub
    Private Sub Marca_Enter(sender As Object, e As EventArgs) Handles marca.Enter
        marca_panel.BackColor = secondaryColor
    End Sub
    Private Sub Marca_Leave(sender As Object, e As EventArgs) Handles marca.Leave
        marca_panel.BackColor = Color.Black
        If RadioButton4.Checked = True Then
            modeloVeiculo = marca.Text
        End If
    End Sub
    Private Sub Entrada_TextChanged(sender As Object, e As EventArgs) Handles entrada.TextChanged
        If sender.text <> "" And RadioButton3.Checked = True Then
            last_panel.Visible = True
        End If
    End Sub
    Private Sub Marca_TextChanged(sender As Object, e As EventArgs) Handles marca.TextChanged
        If sender.text <> "" And RadioButton4.Checked = True Then
            last_panel.Visible = True
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If sender.checked = True Then
            Panel12.BackColor = Color.FromArgb(50, 60, 207)
            nextStep = True
        Else
            Panel12.BackColor = Color.Silver
            nextStep = False
        End If
    End Sub
    Private Sub Panel12_Click(sender As Object, e As EventArgs) Handles Panel12.Click, Label9.Click
        If RadioButton4.Checked = True Then
            modeloVeiculo = marca.Text
        End If
        If nextStep = True Then
            With My.Settings
                .tipoVeiculo = tipoVeiculo.ToString.ToUpper
                .valorVeiculo = valorVeiculo
                .anoVeiculo = anoVeiculo
                .modeloVeiculo = modeloVeiculo
            End With
            '/-/-/-/-/-/-/-/-/-/-\-\-\-\-\-\-\-\-\-\-\-\
            Main_Bank_Form.LimparControle()
            Main_Bank_Form.ExibirControle()
            Main_Bank_Form.atualAnalise = "segunda-analise"
            Main_Bank_Form.count_timer.Start()
        End If
    End Sub
End Class