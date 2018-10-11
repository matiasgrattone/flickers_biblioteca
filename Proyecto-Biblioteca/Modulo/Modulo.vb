Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net.Mail
Imports System.Net
Imports System.Security.Cryptography
Imports System.Text

Module Modulo

    Public nombre As String 'Variable para cambiar mostrar nombre en inicio usuario

    Dim ubicacion As String
    Public invitado As Integer = 0
    Public ERROR1 As Integer
    Public Conexion As MySqlDataAdapter
    Public Tabla As DataTable
    Public Consulta As String
    Public MysqlConexion As MySqlConnection = New MySqlConnection(ubicacion)

    Public rutaGuardadoFotos As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\GitHub\flickers_biblioteca\Proyecto-Biblioteca\bin\Debug\Fotos_de_perfil" ' Ruta donde estan las fotos de perfil de los funcionarios
    Public cedula_ingresada As String

    Public opcioncolor As Color
    Public fecha As String
    Public DatagridModulo As DataGridView ' Variable para poder usar el codigo Datagrid_Align en cualquier formulario
    Public correcto As Integer = 0 '----------------------Variable para verificar si la cedula es valida---------------------------
    Public ANIMACION As Integer = 0
    Public substring As String

    Private des As New TripleDESCryptoServiceProvider 'Algorithmo TripleDES
    Private hashmd5 As New MD5CryptoServiceProvider 'objeto md5
    Private myKey As String = "MyKey2012" 'Clave secreta(puede alterarse)

    Public Sub consultar()

        If invitado = 0 Then
            'ubicacion = "server=localhost; user id=root; password=''; database=biblioteca"
            'ubicacion = "server=192.168.1.12; user id=admin; password=admin; database=biblioteca" ' NO BORRAR, YO USO ESTA PARA PROGRAMAR EN CASA, GUILLE (NO PUEDO USAR EL DOMINIO EN LAN)
            ubicacion = "server=bibliotecadb.ddns.net; user id=admin; password=admin; database=biblioteca"
        Else
            'ubicacion = "server=192.168.1.12; user id=invitado; password=invitado; database=biblioteca"
            'ubicacion = "server=bibliotecadb.ddns.net; user id=invitado; password=invitado; database=biblioteca"
        End If

        Try
            Conexion = New MySqlDataAdapter(Consulta, ubicacion)
            Tabla = New DataTable
            Conexion.Fill(Tabla)
            MysqlConexion.Close()
            If ERROR1 = 2 Then
                'MsgBox("ha vuelto la conexiòn", MsgBoxStyle.Information)
                ERROR1 = 0
            End If

        Catch ex As Exception

            If (ex.Message.ToLowerInvariant().Contains("unable to connect")) And ERROR1 = 0 Then
                '    MsgBox("no hay conexion con la base de datos", MsgBoxStyle.OkOnly, "ERROR")
                ERROR1 = 2
            ElseIf (ex.Message.ToLowerInvariant().Contains("duplicate entry")) Then
                MsgBox("hay datos duplicados , verifique que los datos no esten ya ingresados en la plataforma", MsgBoxStyle.OkOnly, "ERROR")
                ERROR1 = 1
            ElseIf (ex.Message.ToLowerInvariant().Contains("unable to connect")) And ERROR1 = 2 Then
            ElseIf ERROR1 <> 2 Then
                If MsgBox("ha ocurrido un error desea verlo?", MsgBoxStyle.YesNo) = vbYes Then
                    MsgBox(ex.ToString)
                Else
                End If
            End If
        End Try

    End Sub

    Public Sub Datagrid_Align()
        For x = 0 To DatagridModulo.Columns.Count - 1 'El for recorre cada columna y las va configurando hasta llegar a la columna a'
            DatagridModulo.Columns(x).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        DatagridModulo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alinea las cabeceras de cada columena'
        DatagridModulo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill 'Ajusta las columnas al tamaño del datagrid'
    End Sub
    Public Sub mestonum()

        Select Case substring

            Case "Enero"
                substring = "01"
            Case "Febrero"
                substring = "02"
            Case "Marzo"
                substring = "03"
            Case "Abril"
                substring = "04"
            Case "Mayo"
                substring = "05"
            Case "Junio"
                substring = "06"
            Case "Julio"
                substring = "07"
            Case "Agosto"
                substring = "08"
            Case "Septiembre"
                substring = "09"
            Case "Octubre"
                substring = "10"
            Case "Noviembre"
                substring = "11"
            Case "Diciembre"
                substring = "12"

        End Select

    End Sub


    Public Sub mes()

        If substring = "01" Then
            substring = "Enero"
            fecha = Date.Now.ToString("dd") & " de " & substring & " de " & Date.Now.ToString("yyyy")
        End If
        If substring = "02" Then
            substring = "Febrero"
            fecha = Date.Now.ToString("dd") & " de " & substring & " de " & Date.Now.ToString("yyyy")
        End If
        If substring = "03" Then
            substring = "Marzo"
            fecha = Date.Now.ToString("dd") & " de " & substring & " de " & Date.Now.ToString("yyyy")
        End If
        If substring = "04" Then
            substring = "Abril"
            fecha = Date.Now.ToString("dd") & " de " & substring & " de " & Date.Now.ToString("yyyy")
        End If
        If substring = "05" Then
            substring = "Mayo"
            fecha = Date.Now.ToString("dd") & " de " & substring & " de " & Date.Now.ToString("yyyy")
        End If
        If substring = "06" Then
            substring = "Junio"
            fecha = Date.Now.ToString("dd") & " de " & substring & " de " & Date.Now.ToString("yyyy")
        End If
        If substring = "07" Then
            substring = "Julio"
            fecha = Date.Now.ToString("dd") & " de " & substring & " de " & Date.Now.ToString("yyyy")
        End If
        If substring = "08" Then
            substring = "Agosto"
            fecha = Date.Now.ToString("dd") & " de " & substring & " de " & Date.Now.ToString("yyyy")
        End If

        If substring = "09" Then
            substring = "Septiembre"
            fecha = Date.Now.ToString("dd") & " de " & substring & " de " & Date.Now.ToString("yyyy")
        End If
        If substring = "10" Then
            substring = "Octubre"
            fecha = Date.Now.ToString("dd") & " de " & substring & " de " & Date.Now.ToString("yyyy")
        End If
        If substring = "11" Then
            substring = "Noviembre"
            fecha = Date.Now.ToString("dd") & " de " & substring & " de " & Date.Now.ToString("yyyy")
        End If
        If substring = "12" Then
            substring = "Diciembre"
            fecha = Date.Now.ToString("dd") & " de " & substring & " de " & Date.Now.ToString("yyyy")
        End If

    End Sub
    Public Sub prueba() ' VERIFICAR SI ESTA CERRADA LA CONEXION

        Select Case MysqlConexion.State
            Case ConnectionState.Open
                MsgBox("open")
            Case ConnectionState.Closed
                MsgBox("close")
            Case ConnectionState.Connecting
                MsgBox("connect")
            Case ConnectionState.Fetching
                MsgBox("fetching")
            Case ConnectionState.Broken
                MsgBox("broke")

        End Select
    End Sub

    Public Sub Verificar_Cedula(ByVal cedu)
        Try
            Dim cedula As String
            Dim num(7) As Char
            Dim suma As Integer
            Dim calculo() As Integer = {2, 9, 8, 7, 6, 3, 4}

            cedula = cedu
            num = cedu.ToCharArray()

            For i = 0 To 6
                Dim num1 As Integer = Val(num(i))
                suma = (num1 * calculo(i)) + suma
            Next

            num = cedula.ToCharArray()

            Dim resto As Integer = 10 - (suma Mod 10)
            If resto = 10 Then
                resto = 0
            End If
            If resto = Val(num(7)) Then
                correcto = 0 ' La cedula esta correcta
            Else
                correcto = 1
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, Title:=" MODULO VERIFICAR CEDULA ")
            correcto = 1
        End Try

    End Sub

    Public Sub enviarEmail(destino As String, ByVal asunto As String, ByVal cuerpo As String)
        Dim Email As New MailMessage()

        Try

            'Declaramos nuestro objeto servidor SMTP
            Dim SMTPServer As New SmtpClient

            Email.From = New MailAddress("flickers.srl.uy@gmail.com")
            Email.To.Add(New MailAddress(destino))
            Email.Subject = asunto
            Email.Body = cuerpo

            'Especificamos cual es nuestro servidor SMTP
            SMTPServer.Host = "smtp.gmail.com"
            'Puerto SMTP de nuestro server
            SMTPServer.Port = 587
            'Credenciales de acceso de la cuenta de envio
            SMTPServer.Credentials = New System.Net.NetworkCredential("flickers.srl.uy@gmail.com", "Falcon1234.Flickers")
            'Si nuestro servidor de correo admite SSL
            SMTPServer.EnableSsl = True
            'Enviamos el correo
            SMTPServer.Send(Email)

            'Destruimos el objeto de correo
            Email.Dispose()

            MsgBox("Correo Enviado", MsgBoxStyle.OkOnly & MsgBoxStyle.Information, Title:="Correo enviado")
            Mail.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            'MsgBox("Ocurrio un error al enviar el correo: " & ex.Message,
            '"Mail Sender", MsgBoxStyle.OkOnly & MsgBoxStyle.Critical)
        End Try

    End Sub

    'Funcion para el Encriptado de Cadenas de Texto
    Public Function Encriptar(ByVal texto As String) As String

        If Trim(texto) = "" Then
            Encriptar = ""
        Else
            des.Key = hashmd5.ComputeHash((New UnicodeEncoding).GetBytes(myKey))
            des.Mode = CipherMode.ECB
            Dim encrypt As ICryptoTransform = des.CreateEncryptor()
            Dim buff() As Byte = UnicodeEncoding.ASCII.GetBytes(texto)
            Encriptar = Convert.ToBase64String(encrypt.TransformFinalBlock(buff, 0, buff.Length))
        End If
        Return Encriptar

    End Function


    'Funcion para el Desencriptado de Cadenas de Texto
    Public Function Desencriptar(ByVal texto As String) As String
        If Trim(texto) = "" Then
            Desencriptar = ""
        Else
            des.Key = hashmd5.ComputeHash((New UnicodeEncoding).GetBytes(myKey))
            des.Mode = CipherMode.ECB
            Dim desencrypta As ICryptoTransform = des.CreateDecryptor()
            Dim buff() As Byte = Convert.FromBase64String(texto)
            Desencriptar = UnicodeEncoding.ASCII.GetString(desencrypta.TransformFinalBlock(buff, 0, buff.Length))
        End If
        Return Desencriptar
    End Function

End Module