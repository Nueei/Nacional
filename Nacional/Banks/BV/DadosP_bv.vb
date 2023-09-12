Public Class DadosP_bv
    Dim tipoVeiculo As String
    Dim modeloVeiculo As String
    Dim primaryColor As Color = My.Settings.primaryColor
    Dim secondaryColor As Color = My.Settings.secondaryColor

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
        tipoVeiculo = sender.text
        Panel2.Visible = True
        Label2.Text = $"Você já sabe qual o modelo de {sender.TEXT.ToString.ToUpper} quer financiar?"
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Panel3.Visible = True
        modeloVeiculo = "Ainda não decidi o modelo."
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
    Private Sub Panel12_Click(sender As Object, e As EventArgs) Handles Panel12.Click, Label9.Click
        Main_Bank_Form.LimparControle()
        Main_Bank_Form.ExibirControle()
        Main_Bank_Form.atualAnalise = "segunda-analise"
        Main_Bank_Form.count_timer.Start()
    End Sub
End Class