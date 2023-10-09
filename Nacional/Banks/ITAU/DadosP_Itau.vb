Imports System.Text.RegularExpressions
Public Class DadosP_Itau
    Dim nextStep As Boolean = False
    Private Sub Cpf_txt_Enter(sender As Object, e As EventArgs) Handles cpf_txt.Enter
        cpf_panel.BackColor = Color.FromArgb(236, 116, 0)
    End Sub
    Private Sub Cpf_txt_Leave(sender As Object, e As EventArgs) Handles cpf_txt.Leave
        cpf_panel.BackColor = Color.Black
    End Sub
    Private Sub Nome_txt_Enter(sender As Object, e As EventArgs) Handles nome_txt.Enter
        nome_panel.BackColor = Color.FromArgb(236, 116, 0)
    End Sub
    Private Sub Nome_txt_Leave(sender As Object, e As EventArgs) Handles nome_txt.Leave
        nome_panel.BackColor = Color.Black
    End Sub
    Private Sub Email_txt_Enter(sender As Object, e As EventArgs) Handles email_txt.Enter
        email_panel.BackColor = Color.FromArgb(236, 116, 0)
    End Sub
    Private Sub Email_txt_Leave(sender As Object, e As EventArgs) Handles email_txt.Leave
        email_panel.BackColor = Color.Black
    End Sub
    Private Sub celular_txt_Enter(sender As Object, e As EventArgs) Handles celular_txt.Enter
        celular_panel.BackColor = Color.FromArgb(236, 116, 0)
    End Sub
    Private Sub celular_txt_Leave(sender As Object, e As EventArgs) Handles celular_txt.Leave
        celular_panel.BackColor = Color.Black
    End Sub
    Private Sub cpf_txt_TextChanged(sender As Object, e As EventArgs) Handles cpf_txt.TextChanged
        Dim vCpf As New ValidarCpf
        cpf_txt.SelectionStart = sender.text.length
        Select Case sender.text.length
            Case 3
                sender.text = sender.text + "."

            Case = 7
                sender.text = sender.text + "."
            Case 11
                sender.text = sender.text + "-"
        End Select
        Try
            vCpf.cpf = sender.text
        Catch ex As Exception
            sender.text = ""
        End Try
        If sender.text.length = 14 Then
            If vCpf.isCpfValido Then
                cpf_panel.BackColor = Color.FromArgb(236, 116, 0)
            Else
                cpf_panel.BackColor = Color.FromArgb(255, 90, 90)
                sender.text = ""
                sender.focus
            End If
        End If

    End Sub
    Private Sub Panel12_Click(sender As Object, e As EventArgs) Handles Panel12.Click, Label9.Click
        '*-*-*-*-*-
        If nextStep = True Then
            '/-/-/-/-/-/-/-/-/-/-\-\-\-\-\-\-\-\-\-\-\-\
            nextStep = False
            Main_Bank_Form.initialDelay = 5
            Main_Bank_Form.LimparControle()
            Main_Bank_Form.ExibirControle()
            Main_Bank_Form.atualAnalise = "dadosV-itau"
            Main_Bank_Form.count_timer.Start()
        End If
    End Sub

    Private Sub celular_txt_TextChanged(sender As Object, e As EventArgs) Handles celular_txt.TextChanged, nome_txt.TextChanged, cpf_txt.TextChanged, email_txt.TextChanged
        If cpf_txt.Text.Length = 14 And email_txt.Text <> "" And nome_txt.Text <> "" Then
            nextStep = True
            Panel12.BackColor = Color.FromArgb(236, 116, 0)
            Label9.ForeColor = Color.White
        Else
            Panel12.BackColor = Color.Silver
            Label9.ForeColor = Color.White
            nextStep = False
        End If
    End Sub
End Class