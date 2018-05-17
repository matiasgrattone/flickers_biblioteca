Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim vector(7) As Char
        Dim vecto1r(2) As Char
        Dim respuesta As String
        Dim resultado As String
        Dim x As String

        respuesta = InputBox("ingrese una cedula", Title:=" Ingrese Su Cedua ")

        vector = respuesta.ToCharArray


        x = (Val(vector(0)) * 2) + (Val(vector(1)) * 9) + (Val(vector(2)) * 8) + (Val(vector(3)) * 7) + (Val(vector(4)) * 6) + (Val(vector(5)) * 3) + (Val(vector(6)) * 4)

        Dim numero As String = Val(x) + 10
        Dim a As Integer

        vecto1r = numero.ToCharArray
        a = vecto1r.GetLength(a)
   
        Select Case a

            Case 2

                vecto1r(1) = "0"
                numero = vecto1r(0) + vecto1r(1)
            Case 3

                vecto1r(2) = "0"
                numero = vecto1r(0) + vecto1r(1) + vecto1r(2)

        End Select

        resultado = Val(numero) - x

        If resultado = Val(vector(7)) Then

            MsgBox("la cedula " + respuesta + " es correcta", Title:="cedula correcta")
            WebBrowser1.Navigate("www.google.com.uy")
        Else

            MsgBox("la cedula " + respuesta + "es incorrecta", Title:="cedula incorrecta")
            WebBrowser1.Visible = False
        End If




    End Sub
End Class
