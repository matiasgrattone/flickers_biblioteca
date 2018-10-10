Public Class Mail
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub
    Private Sub Mail_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Txt_Asunto.Text = "Aviso Biblioteca"
    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        enviarEmail(Txt_Destino.Text, Txt_Asunto.Text, TextBox1.Text)
    End Sub
    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        Me.Close()
    End Sub
End Class