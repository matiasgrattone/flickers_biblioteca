Public Class Carga

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick




        If ProgressBar1.Value = 100 Then

            Timer1.Stop()
            Timer2.Stop()

        Else
            ProgressBar1.Value = ProgressBar1.Value + 1


        End If
    End Sub
    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick

        Label1.Text = ProgressBar1.Value.ToString & "%"
    End Sub
End Class