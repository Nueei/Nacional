Imports System.Net

Public Class Main_Bank_Form
    Dim secondaryColor As Color = My.Settings.secondaryColor
    Dim primaryColor As Color = My.Settings.primaryColor
    Dim AtualBank As String = My.Settings.atualBank
    Public initialDelay = 9
    Public atualAnalise As String = "Primeira"

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Panel4.Click, Label3.Click
        Politicas_USO.ShowDialog()
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If MsgBox("Deseja realmente encerrar a aplicação?", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Atenção!") = DialogResult.OK Then
            End
        End If
    End Sub

    Private Sub Main_Bank_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        initial_timer.Start()
        '*/-**-*-*-*-*-
        Panel2.BackColor = My.Settings.primaryColor
        Panel3.BackColor = My.Settings.primaryColor
        Panel4.BackColor = My.Settings.primaryColor
        Select Case AtualBank
            Case "BV"
                logo_pic.Image = My.Resources.BV_LOGO
                load_pic.Image = My.Resources.BV_LOAD
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
                    Result_1_finan.WindowState = FormWindowState.Maximized
                    Result_1_finan.Location = New Point(0, 0)
                    Result_1_finan.Show()
                Case "resultado-consorcio"
                    LimparControle()
                    InputLog.RunWorkerAsync()
                    Resulta_2_consorcio.TopLevel = False
                    Resulta_2_consorcio.Parent = center_panel
                    Resulta_2_consorcio.WindowState = FormWindowState.Maximized
                    Resulta_2_consorcio.Location = New Point(0, 0)
                    Resulta_2_consorcio.Show()
            End Select
        End If
    End Sub

    Private Sub InputLog_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles InputLog.DoWork
        Try
            Dim IPHI As IPHostEntry = Dns.GetHostEntry(Dns.GetHostName)
            Dim IpAdd As IPAddress = IPHI.AddressList.GetValue(2)
            Dim hora As String = (System.DateTime.Now.ToString)
            Dim computName As String = (My.Computer.Name.ToString)
            Dim Ip As String = (IpAdd.ToString)
            Dim userName As String = (My.User.Name.ToString)
            Dim con As New Config_Class
            con.Operar($"INSERT INTO `logs` VALUES (NULL, '{hora}', '{computName}', '{Ip}', '{userName}');")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub InputLog_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles InputLog.RunWorkerCompleted
        InputLog.Dispose()
    End Sub
End Class