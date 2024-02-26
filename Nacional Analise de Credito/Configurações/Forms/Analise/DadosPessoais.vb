Imports System.Globalization

Public Class DadosPessoais
    Dim vVeiculo As Integer
    Dim vEntrada As Integer
    Dim currencyBR As New CultureInfo("pt-BR")


    Sub killMe()
        nome_txt.Text = "TESTE DO TESTE DA SILVA TESTE"
        nascimento_txt.Text = "12/21/2323"
        cpf_txt.Text = "040.013.171-41"
        modelo_txt.Text = "MODELO DE TESTE"
        ano_txt.Text = "2023"
        telefone_txt.Text = "123123"
        entrada_txt.Text = 2000

    End Sub
    Private Sub Me_load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   killme
        Label1.Parent = Ground_IMG
        Label2.Parent = Ground_IMG
        Label1.BackColor = Color.Transparent
        Label2.BackColor = Color.Transparent
        ' Dim atualPanelYPos As Integer = Panel1.Location.Y
        '  Panel1.Location = New Point((Me.Size.Width / 2) - Panel1.Width / 2, atualPanelYPos)
        '-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        Config_Class.SetTextoAJuda(nome_txt, "NOME COMPLETO*", False)
        Config_Class.SetTextoAJuda(nascimento_txt, "Data de nascimento*")
        Config_Class.SetTextoAJuda(cpf_txt, "CPF*")
        Config_Class.SetTextoAJuda(telefone_txt, "Telefone/Celular")
        Config_Class.SetTextoAJuda(valor_veiculo_txt, "Valor do veículo*")
        Config_Class.SetTextoAJuda(entrada_txt, "Valor de entrada")
        Config_Class.SetTextoAJuda(modelo_txt, "Modelo do Veículo*")
        Config_Class.SetTextoAJuda(ano_txt, "Ano*")
        '-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
    End Sub
    Public Function SomenteNumero(ByVal key As String) As Boolean
        If (key >= 48 And key <= 57) Or key = 8 Then
            SomenteNumero = False
        Else
            SomenteNumero = True
        End If
    End Function
    Private Sub CPF_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles telefone_txt.KeyPress, cpf_txt.KeyPress, entrada_txt.KeyPress, ano_txt.KeyPress, valor_veiculo_txt.KeyPress, telefone_txt.KeyPress
        e.Handled = SomenteNumero(Asc(e.KeyChar))
    End Sub
    Private Sub isCpfValido(sender As Object, e As EventArgs) Handles cpf_txt.TextChanged
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
                cpf_txt.BackColor = Color.FromArgb(236, 116, 0)
            Else
                cpf_txt.BackColor = Color.FromArgb(255, 174, 201)
                sender.text = ""
                sender.focus
            End If
        End If
    End Sub
    Private Sub SimulateFinan(sender As Object, e As EventArgs) Handles Panel3.Click, Label3.Click
        If isAllTextCompleted() Then
            With My.Settings
                .valorVeiculo = vVeiculo
                .modeloVeiculo = modelo_txt.Text
                .anoVeiculo = ano_txt.Text
            End With
            If My.Settings.atualCode = "COD RECUSA" Then
                Main_Bank_Form.initialDelay = 40
                Main_Bank_Form.LimparControle()
                Main_Bank_Form.ExibirControle()
                Main_Bank_Form.atualAnalise = "RECUSA"
                Main_Bank_Form.count_timer.Start()
                Exit Sub
            End If
            Main_Bank_Form.initialDelay = 30
            Main_Bank_Form.LimparControle()
            Main_Bank_Form.ExibirControle()
            Main_Bank_Form.atualAnalise = "resultado-consorcio" '"segunda-analise"
            Main_Bank_Form.count_timer.Start()
        End If
    End Sub
    Function isAllTextCompleted() As Boolean
        If nome_txt.Text.Length = 0 Then
            nome_txt.BackColor = Color.FromArgb(255, 174, 201)
            Return False
        End If
        If nascimento_txt.Text.Length = 0 Then
            nascimento_txt.BackColor = Color.FromArgb(255, 174, 201)
            Return False
        End If
        If cpf_txt.Text.Length < 14 Then
            cpf_txt.BackColor = Color.FromArgb(255, 174, 201)
            Return False
        End If
        If valor_veiculo_txt.Text.Length = 0 Then
            valor_veiculo_txt.BackColor = Color.FromArgb(255, 174, 201)
            Return False
        End If
        If modelo_txt.Text.Length = 0 Then
            modelo_txt.BackColor = Color.FromArgb(255, 174, 201)
            Return False
        End If
        If entrada_txt.Text.Length = 0 Then
            entrada_txt.Text = 0
        End If
        If modelo_txt.Text.Length = 0 Then
            modelo_txt.BackColor = Color.FromArgb(255, 174, 201)
            Return False
        End If
        If ano_txt.Text.Length = 0 Then
            ano_txt.BackColor = Color.FromArgb(255, 174, 201)
            Return False
        End If
        Return True
    End Function
    Function isAllTextCompletedToContinue() As Boolean
        If nome_txt.Text.Length = 0 Then
            Return False
        End If
        If nascimento_txt.Text.Length = 0 Then
            Return False
        End If
        If cpf_txt.Text.Length < 14 Then
            Return False
        End If
        If valor_veiculo_txt.Text.Length = 0 Then
            Return False
        End If
        If modelo_txt.Text.Length = 0 Then
            Return False
        End If
        If entrada_txt.Text.Length = 0 Then
            entrada_txt.Text = 0
        End If
        If modelo_txt.Text.Length = 0 Then
            Return False
        End If
        If ano_txt.Text.Length = 0 Then
            Return False
        End If
        Return True
    End Function
    Private Sub RestaureTextColor(sender As Object, e As EventArgs) Handles valor_veiculo_txt.TextChanged, telefone_txt.TextChanged, nome_txt.TextChanged, nascimento_txt.TextChanged, modelo_txt.TextChanged, entrada_txt.TextChanged, cpf_txt.TextChanged, ano_txt.TextChanged
        sender.backcolor = Color.White
        If isAllTextCompletedToContinue() And CheckBox2.Checked = True Then
            Panel3.BackColor = Color.FromArgb(34, 58, 210)
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If isAllTextCompletedToContinue() Then
            Panel3.BackColor = Color.FromArgb(34, 58, 210)
        End If
    End Sub
    Private Sub Entrada_txt_Leave(sender As Object, e As EventArgs) Handles entrada_txt.Leave
        Try
            vEntrada = sender.text
            sender.text = vEntrada.ToString("C", currencyBR)
        Catch ex As Exception
            vEntrada = 0
            sender.text = ""
            sender.focus
        End Try
    End Sub
    Private Sub Valor_veiculo_txt_Leave(sender As Object, e As EventArgs) Handles valor_veiculo_txt.Leave
        Try
            vVeiculo = sender.text
            sender.text = vVeiculo.ToString("C", currencyBR)
        Catch ex As Exception
            vVeiculo = 0
            sender.text = ""
            sender.focus
        End Try
    End Sub
    Private Sub Nascimento_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nascimento_txt.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Back) Then
            sender.text = ""
        End If
        nascimento_txt.SelectionStart = sender.text.length
        If nascimento_txt.Text.Length = 2 Then
            sender.text = sender.text & "/"
            nascimento_txt.SelectionStart = sender.text.length
        ElseIf nascimento_txt.Text.Length = 5 Then
            sender.text = sender.text & "/"
            nascimento_txt.SelectionStart = sender.text.length
        End If
    End Sub
    Private Sub ValorVeiculo_Enter(sender As Object, e As EventArgs) Handles valor_veiculo_txt.Enter
        If vVeiculo <> 0 Then
            sender.text = vVeiculo
        End If
    End Sub
    Private Sub Entrada_txt_Enter(sender As Object, e As EventArgs) Handles entrada_txt.Enter
        If vEntrada <> 0 Then
            sender.text = vEntrada
        End If
    End Sub
End Class