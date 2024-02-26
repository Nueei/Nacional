Imports System.Net
Imports System.Reflection.Emit

Public Class Main_Bank_Form
    Public initialDelay = 10
    Public atualAnalise As String = "Primeira"
    Dim isLog As Boolean = True

    Protected Overrides Function ProcessCmdKey(ByRef m As Message, ByVal keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.Alt Or Keys.F1
                If Finan_config.ShowDialog = DialogResult.OK Then
                End If
                Return True
            Case Else
                Return False
        End Select
    End Function
    Private Sub Close_System_LBL(sender As Object, e As EventArgs) Handles close_LBL.Click
        If MsgBox("Deseja realmente encerrar a aplicação?", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Atenção!") = DialogResult.OK Then
            End
        End If
    End Sub
    Private Sub Politica_Uso_OPEN(sender As Object, e As EventArgs) Handles politica_LBL.Click
        Politicas_USO.ShowDialog()
    End Sub
    Private Sub Main_Bank_Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        If My.Settings.cargoUsuario <> "VENDEDOR" Then
            admin_LBL.Visible = True
        Else
            admin_LBL.Visible = False
        End If
        If isLog = True Then
            InputLog.RunWorkerAsync()
            isLog = False
        End If
        initial_timer.Start()

    End Sub
    Private Sub Initial_timer_Tick(sender As Object, e As EventArgs) Handles initial_timer.Tick
        initialDelay -= 1
        If initialDelay <= 0 Then
            initial_timer.Stop()
            initialDelay = 60
            LimparControle()
            DadosPessoais.TopLevel = False
            DadosPessoais.Parent = center_panel
            DadosPessoais.WindowState = FormWindowState.Maximized
            DadosPessoais.Location = New Point(0, 0)
            DadosPessoais.Show()
        End If
    End Sub
    Private Sub Count_timer_Tick(sender As Object, e As EventArgs) Handles count_timer.Tick
        initialDelay -= 1
        If initialDelay <= 0 Then
            count_timer.Stop()
            Select Case atualAnalise
                Case "segunda-analise"
                    LimparControle()
                    ResultadoFinanciamento.TopLevel = False
                    ResultadoFinanciamento.Parent = center_panel
                    ResultadoFinanciamento.WindowState = FormWindowState.Normal
                    ResultadoFinanciamento.Location = New Point((center_panel.Size.Width / 2) - ResultadoFinanciamento.Size.Width / 2, (center_panel.Size.Height / 2) - ResultadoFinanciamento.Size.Height / 2)
                    ResultadoFinanciamento.Show()
                Case "resultado-consorcio"
                    LimparControle()
                    top_panel.BackColor = Color.White
                    top_panel.ForeColor = Color.Black
                    logo_pic.Size = New Size(150, 90)
                    logo_pic.Location = New Point(0, 0)
                    ResultadoConsorcio.TopLevel = False
                    ResultadoConsorcio.Parent = center_panel
                    ResultadoConsorcio.WindowState = FormWindowState.Maximized
                    ResultadoConsorcio.Location = New Point(0, 0)
                    ResultadoConsorcio.Show()
                Case "RECUSA"
                    LimparControle()
                    Recusa.TopLevel = False
                    Recusa.Parent = center_panel
                    Recusa.WindowState = FormWindowState.Maximized
                    Recusa.Location = New Point(0, 0)
                    Recusa.Show()
            End Select
        End If
    End Sub
    Public Sub LimparControle()
        load_pic.Parent = Me
        load_pic.Visible = False
        center_panel.Controls.Clear()
    End Sub
    Public Sub ExibirControle()
        load_pic.Parent = center_panel
        load_pic.Visible = True
    End Sub
    Private Sub InputLog_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles InputLog.DoWork
        Dim conf As New Config_Class
        Dim logCode As String = conf.TxtAleatorio(8).ToUpper
        My.Settings.logCode = logCode
        Try
            Dim IPHI As IPHostEntry = Dns.GetHostEntry(Dns.GetHostName)
            Dim IpAdd As IPAddress = IPHI.AddressList.GetValue(2)
            Dim hora As String = (System.DateTime.Now.ToString)
            Dim computName As String = (My.Computer.Name.ToString.ToUpper)
            Dim Ip As String = (IpAdd.ToString)
            Dim userName As String = (My.User.Name.ToString.ToUpper)
            Dim con As New Config_Class
            Dim valordoveiculo As Integer = My.Settings.valorVeiculo
            Dim credito As Double() = {20305, 22500, 25000, 27500, 30000, 35000, 40000, 45000, 50000, 55000, 60000, 65000, 70000, 75000, 80000, 90000, 100000, 110000, 120000, 130000}

            Dim numIndexDados As Integer = EncontrarIndiceNumeroMaisProximo(credito, valordoveiculo)


            con.Operar($"INSERT INTO `logs` VALUES (NULL, '{hora}', '{My.Settings.usernameAcesso}', '{Ip}', '{valordoveiculo}', '{credito(numIndexDados).ToString()}','Não', '{logCode}');") '"Exclua depois" = Banco que passou a ficha
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub InputLog_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles InputLog.RunWorkerCompleted
        InputLog.Dispose()
    End Sub
    Private Sub AdministrarUsuariosClick(sender As Object, e As EventArgs) Handles admin_LBL.Click
        AdministrarUsuarios.ShowDialog()
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
End Class