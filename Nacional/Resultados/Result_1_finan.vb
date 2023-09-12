Public Class Result_1_finan
    Private Sub Panel12_Click(sender As Object, e As EventArgs) Handles Panel12.Click, Label16.Click, Label15.Click
        Main_Bank_Form.initialDelay = 120
        Main_Bank_Form.LimparControle()
        Main_Bank_Form.ExibirControle()
        Main_Bank_Form.atualAnalise = "resultado-consorcio"
        Main_Bank_Form.count_timer.Start()
    End Sub
End Class