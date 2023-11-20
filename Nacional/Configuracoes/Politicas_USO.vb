Public Class Politicas_USO
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If sender.checked = True Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        CheckBox1.Checked = False
        Me.DialogResult = DialogResult.OK
    End Sub
End Class