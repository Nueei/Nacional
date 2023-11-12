Imports System.Reflection.Emit

Public Class Resulta_2_consorcio
    Dim logCode As String = My.Settings.logCode
    Dim sql As String = $"UPDATE `logs` SET `mostradoResultado` = 'Sim' WHERE `logs`.`log_code` = '{logCode}';"
    Dim con As New Config_Class
    Private Sub Resulta_2_consorcio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateLog.RunWorkerAsync()
    End Sub

    Private Sub updateLog_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles updateLog.DoWork
        Try
            con.Operar(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class