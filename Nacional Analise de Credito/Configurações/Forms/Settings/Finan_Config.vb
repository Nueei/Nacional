Imports System.Globalization
Public Class Finan_config

    Dim EntradaI As Integer = My.Settings.pct_entrada
    Dim tarifaI As Integer = My.Settings.tarifas_adc
    Dim txJurosI As Double = My.Settings.tx_juros
    Dim atualCode As String = My.Settings.atualCode
    Dim currencyBR As New CultureInfo("pt-BR")
    Private Sub Finan_config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        entrada_txt.Text = EntradaI.ToString
        tarifa_txt.Text = tarifaI.ToString("C", currencyBR)
        tx_txt.Text = My.Settings.tx_juros.ToString
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If sender.checked = True Then
            Panel1.Enabled = False
        Else
            Panel1.Enabled = True
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If sender.checked = True Then
            Panel2.Enabled = False
        Else
            Panel2.Enabled = True
        End If
    End Sub
    Sub ErrorLbl(e As TextBox)
        e.BackColor = Color.Pink
        e.Text = ""
        e.Focus()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If EntradaI > 100 Then
            ErrorLbl(entrada_txt)
            Exit Sub
        End If
        If tarifa_txt.Text = "" Then
            ErrorLbl(tarifa_txt)
            Exit Sub
        End If
        If tx_txt.Text = "" Then
            ErrorLbl(tx_txt)
            Exit Sub
        End If
        If txJurosI >= 10 Then
            If MsgBox("A taxa de juros está mais alta que o normal, deseja continuar?", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Atenção") = DialogResult.Cancel Then
                txJurosI = 2.75
                tx_txt.Focus()
                tx_txt.Text = txJurosI
                Exit Sub
            End If
        End If
        My.Settings.pct_entrada = EntradaI
        My.Settings.tarifas_adc = tarifaI
        My.Settings.tx_juros = txJurosI
        My.Settings.atualCode = atualCode.ToString.ToUpper
        Me.DialogResult = DialogResult.OK
    End Sub

    Public Function SomenteNumero(ByVal key As String) As Boolean
        If (key >= 48 And key <= 57) Or key = 8 Then
            SomenteNumero = False
        Else
            SomenteNumero = True
        End If
    End Function

    Private Sub Entrada_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tx_txt.KeyPress, tarifa_txt.KeyPress, entrada_txt.KeyPress
        e.Handled = SomenteNumero(Asc(e.KeyChar))
        sender.backcolor = Color.White
    End Sub

    Private Sub Entrada_txt_Leave(sender As Object, e As EventArgs) Handles entrada_txt.Leave
        If sender.text <> "" Then
            EntradaI = sender.text
            sender.text = sender.text & "%"
        Else
            sender.text = EntradaI
        End If
    End Sub

    Private Sub Entrada_txt_Enter(sender As Object, e As EventArgs) Handles entrada_txt.Enter
        sender.text = ""
    End Sub

    Private Sub Tarifa_txt_Leave(sender As Object, e As EventArgs) Handles tarifa_txt.Leave
        If sender.text <> "" Then
            tarifaI = sender.text
            sender.text = tarifaI.ToString("C", currencyBR)
        End If
    End Sub

    Private Sub Tx_txt_Leave(sender As Object, e As EventArgs) Handles tx_txt.Leave
        If sender.text <> "" Then
            txJurosI = sender.text
        End If
    End Sub

    Private Sub Tarifa_txt_Enter(sender As Object, e As EventArgs) Handles tarifa_txt.Enter
        sender.text = ""
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged, RadioButton2.CheckedChanged, RadioButton1.CheckedChanged, RadioButton5.CheckedChanged, RadioButton4.CheckedChanged
        atualCode = sender.text
    End Sub
End Class