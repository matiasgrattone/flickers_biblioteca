Public Class Menu2
    Dim a As Integer = 0
    Public xco, yco As Integer
    Dim resultx, resulty As Integer
    Dim xc, yc As Integer
    Dim xf, yf As Integer
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Menu2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        xf = Me.Location.X
        yf = Me.Location.Y
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown

        a = 1
    End Sub


    Private Sub Panel1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        xf = Me.Location.X
        yf = Me.Location.Y
        a = 0
    End Sub


    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If a = 1 Then
            '///////////////////////////////////////////////////////MOUSE//////////////////////////////

            

            xc = Cursor.Position.X
            yc = Cursor.Position.Y

            Label3.Text = "X " & xc
            Label4.Text = "Y " & yc

            Label11.Text = "= " & xc - xco
            Label12.Text = "= " & yc - yco

            Dim holax, holay As Integer

            holax = xc - xco
            holay = yc - yco

            Label11.Text = holax
            Label12.Text = holay



            '////////////////////////////////////////////////////////FORMULARIO //////////////////////


           

            Label1.Text = "X " & xf
            Label2.Text = "Y " & yf


            '/////////////////////////////////////////////////////////////////////////////////////////


            ' MsgBox("x = " & resultx & "y " & resulty & "")


            Me.Location = New Point(xf + holax, yf + holay)
            'Me.Location = New Point(x - 431, y)



        End If

        If a = 0 Then




            xco = Cursor.Position.X
            yco = Cursor.Position.Y

            Label9.Text = xco
            Label10.Text = yco


        End If

    End Sub

End Class