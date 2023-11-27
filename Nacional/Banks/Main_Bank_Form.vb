Imports System.CodeDom
Imports System.Net
Imports MySql.Data.Types
Imports System.Drawing

Public Class Main_Bank_Form
    Dim secondaryColor As Color = My.Settings.secondaryColor
    Dim primaryColor As Color = My.Settings.primaryColor
    Dim AtualBank As String = My.Settings.atualBank
    Public initialDelay = 9
    Public atualAnalise As String = "Primeira"
    Dim isLog As Boolean = True
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Panel4.Click, Label3.Click, Label5.Click
        Politicas_USO.ShowDialog()
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If MsgBox("Deseja realmente encerrar a aplicação?", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Atenção!") = DialogResult.OK Then
            End
        End If
    End Sub

    Private Sub Main_Bank_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        '-=-=-=-=-=
        '-=-=-=-=-=
        initial_timer.Start()
        '*/-**-*-*-*-*-
        Panel2.BackColor = My.Settings.primaryColor
        Panel3.BackColor = My.Settings.primaryColor
        Panel4.BackColor = My.Settings.primaryColor

        Select Case AtualBank
            Case "BV"
                logo_pic.Image = My.Resources.BV_LOGO
                load_pic.Image = My.Resources.BV_LOAD
                Dim defaultIcon As New Icon(Application.StartupPath & "/icons/bv.ico")
                Me.Icon = defaultIcon
            Case "ITAU"
                logo_pic.Image = My.Resources.ITAU_LOGO
                load_pic.Image = My.Resources.ITAU_LOAD
                top_panel.BackColor = primaryColor
                Label1.ForeColor = Color.White
                Label2.ForeColor = Color.White
                Label3.ForeColor = Color.White
                Label4.ForeColor = Color.White
                Label5.ForeColor = Color.White
                Dim defaultIcon As New Icon(Application.StartupPath & "/icons/itau.ico")
                Me.Icon = defaultIcon
            Case "PAN"
                logo_pic.Image = My.Resources.Banco_PAN_Logo
                load_pic.Image = My.Resources.pan_load_gif1
                Dim defaultIcon As New Icon(Application.StartupPath & "/icons/pan.ico")
                Me.Icon = defaultIcon
            Case "SANTANDER"
                top_panel.BackColor = primaryColor
                top_panel.ForeColor = secondaryColor
                logo_pic.Size = New Size(300, 141)
                logo_pic.SizeMode = PictureBoxSizeMode.StretchImage
                logo_pic.Image = My.Resources.santander_ground1
                TableLayoutPanel1.Visible = False
                load_pic.Image = My.Resources.santander_load_gif
                Label5.Cursor = Cursors.Hand
                Label5.Text = "Política de Uso"
                Label5.Font = New Font("Microsoft Sans Serif", 15)
                Label5.Location = New Point(0, 0)
                load_pic.Size = New Size(48, 52)
                Dim defaultIcon As New Icon(Application.StartupPath & "/icons/santander.ico")
                Me.Icon = defaultIcon
                '-=-=-=-=-=-=-=-=
                logo_pic.Location = New Point((top_panel.Size.Width / 2) - (logo_pic.Size.Width / 2), (top_panel.Size.Height / 2) - (logo_pic.Size.Height / 2))
            Case "BB"
                top_panel.BackColor = primaryColor
                top_panel.ForeColor = secondaryColor
                load_pic.Image = My.Resources.pan_load_gif1
                logo_pic.Image = My.Resources.BB_Logo2
                Dim defaultIcon As New Icon(Application.StartupPath & "/icons/bb.ico")
                Me.Icon = defaultIcon
        End Select
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles Panel4.MouseEnter, Label3.MouseEnter
        Panel4.BackColor = My.Settings.secondaryColor
    End Sub
    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Panel4.MouseLeave, Label3.MouseLeave
        Panel4.BackColor = My.Settings.primaryColor
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Panel3.MouseEnter, Label2.MouseEnter
        Panel3.BackColor = My.Settings.secondaryColor
    End Sub
    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Panel3.MouseLeave, Label2.MouseLeave
        Panel3.BackColor = My.Settings.primaryColor
    End Sub
    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Panel2.MouseEnter, Label1.MouseEnter
        Panel2.BackColor = My.Settings.secondaryColor
    End Sub
    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Panel2.MouseLeave, Label1.MouseLeave
        Panel2.BackColor = My.Settings.primaryColor
    End Sub

    Private Sub Initial_timer_Tick(sender As Object, e As EventArgs) Handles initial_timer.Tick
        initialDelay -= 1
        If initialDelay <= 0 Then
            initial_timer.Stop()
            initialDelay = 60
            LimparControle()
            Select Case AtualBank
                Case "BV"
                    DadosP_BV.TopLevel = False
                    DadosP_BV.Parent = center_panel
                    DadosP_BV.WindowState = FormWindowState.Maximized
                    DadosP_BV.Location = New Point(0, 0)
                    DadosP_BV.Show()
                Case "ITAU"
                    DadosP_Itau.TopLevel = False
                    DadosP_Itau.Parent = center_panel
                    DadosP_Itau.WindowState = FormWindowState.Maximized
                    DadosP_Itau.Location = New Point(0, 0)
                    DadosP_Itau.Show()
                Case "PAN"
                    Dados_PPAN.TopLevel = False
                    Dados_PPAN.Parent = center_panel
                    Dados_PPAN.WindowState = FormWindowState.Maximized
                    Dados_PPAN.Location = New Point(0, 0)
                    Dados_PPAN.Show()
                Case "SANTANDER"
                    Dados_PSantander.TopLevel = False
                    Dados_PSantander.Parent = center_panel
                    Dados_PSantander.WindowState = FormWindowState.Maximized
                    Dados_PSantander.Location = New Point(0, 0)
                    Dados_PSantander.Show()
                Case "BB"
                    Dados_PBB.TopLevel = False
                    Dados_PBB.Parent = center_panel
                    Dados_PBB.WindowState = FormWindowState.Maximized
                    Dados_PBB.Location = New Point(0, 0)
                    Dados_PBB.Show()
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

    Private Sub Count_timer_Tick(sender As Object, e As EventArgs) Handles count_timer.Tick
        initialDelay -= 1
        If initialDelay <= 0 Then
            count_timer.Stop()
            Select Case atualAnalise
                Case "segunda-analise"
                    LimparControle()
                    Result_1_finan.TopLevel = False
                    Result_1_finan.Parent = center_panel
                    Result_1_finan.WindowState = FormWindowState.Normal
                    Result_1_finan.Location = New Point((center_panel.Size.Width / 2) - Result_1_finan.Size.Width / 2, (center_panel.Size.Height / 2) - Result_1_finan.Size.Height / 2) 'New Point(0, 0)
                    Result_1_finan.Show()
                Case "resultado-consorcio"
                    LimparControle()
                    'InputLog.RunWorkerAsync()
                    top_panel.BackColor = Color.White
                    top_panel.ForeColor = Color.Black
                    Label4.ForeColor = Color.Black
                    Label5.ForeColor = Color.Black
                    Label5.Visible = False
                    logo_pic.Size = New Size(150, 90)
                    logo_pic.Location = New Point(0, 0)
                    TableLayoutPanel1.ForeColor = Color.Black
                    Resulta_2_consorcio.TopLevel = False
                    Resulta_2_consorcio.Parent = center_panel
                    Resulta_2_consorcio.WindowState = FormWindowState.Maximized
                    Resulta_2_consorcio.Location = New Point(0, 0)
                    Resulta_2_consorcio.Show()
                Case "dadosV-itau"
                    LimparControle()
                    'InputLog.RunWorkerAsync()
                    DadosV_Itau.TopLevel = False
                    DadosV_Itau.Parent = center_panel
                    DadosV_Itau.WindowState = FormWindowState.Maximized
                    DadosV_Itau.Location = New Point(0, 0)
                    DadosV_Itau.Show()
            End Select
            If isLog = True Then
                InputLog.RunWorkerAsync()
                isLog = False
            End If
        End If
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
            con.Operar($"INSERT INTO `logs` VALUES (NULL, '{hora}', '{computName}', '{Ip}', '{userName}', '{My.Settings.atualBank.ToString.ToUpper}','Não', '{logCode}');")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub InputLog_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles InputLog.RunWorkerCompleted
        InputLog.Dispose()
    End Sub

End Class