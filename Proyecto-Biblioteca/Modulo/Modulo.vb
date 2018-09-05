Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Module Modulo

    Public nombre As String 'Variable para cambiar mostrar nombre en inicio usuario

    Dim ubicacion As String = "server=localhost; user id=root; password=''; database=biblioteca"
    'Dim ubicacion As String = "server=192.168.1.49; user id=admin; password=admin; database=biblioteca"
    Public Conexion As MySqlDataAdapter
    Public Tabla As DataTable
    Public Consulta As String
    Public MysqlConexion As MySqlConnection = New MySqlConnection(ubicacion)
    Public opcioncolor As Color
    Public fecha As String
    Public DatagridModulo As DataGridView ' vairable para poder usar el codigo Datagrid_Align en cualquier formulario
    Public correcto As Integer = 0 '----------------------Variable para verificar si la cedula es valida---------------------------

    Public substring As String

    Public Sub consultar()

        Try
            Conexion = New MySqlDataAdapter(Consulta, ubicacion)
            Tabla = New DataTable
            Conexion.Fill(Tabla)
            MysqlConexion.Close()
        Catch ex As Exception

        End Try

    End Sub

    Public Sub Datagrid_Align()


        For x = 0 To DatagridModulo.Columns.Count - 1 'El for recorre cada columna y las va configurando hasta llegar a la columna a'
            DatagridModulo.Columns(x).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        DatagridModulo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alinea las cabeceras de cada columena'
        DatagridModulo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill 'Ajusta las columnas al tamaño del datagrid'


    End Sub


    Public Sub mes()

        If substring = "01" Then
            substring = "enero"
            fecha = Date.Now.ToString("dd") & " de " & substring & " de " & Date.Now.ToString("yyyy")
        End If
        If substring = "02" Then
            substring = "febrero"
            fecha = Date.Now.ToString("dd") & " de " & substring & " de " & Date.Now.ToString("yyyy")
        End If
        If substring = "03" Then
            substring = "marzo"
            fecha = Date.Now.ToString("dd") & " de " & substring & " de " & Date.Now.ToString("yyyy")
        End If
        If substring = "04" Then
            substring = "abril"
            fecha = Date.Now.ToString("dd") & " de " & substring & " de " & Date.Now.ToString("yyyy")
        End If
        If substring = "05" Then
            substring = "mayo"
            fecha = Date.Now.ToString("dd") & " de " & substring & " de " & Date.Now.ToString("yyyy")
        End If
        If substring = "06" Then
            substring = "junio"
            fecha = Date.Now.ToString("dd") & " de " & substring & " de " & Date.Now.ToString("yyyy")
        End If
        If substring = "07" Then
            substring = "julio"
            fecha = Date.Now.ToString("dd") & " de " & substring & " de " & Date.Now.ToString("yyyy")
        End If
        If substring = "08" Then
            substring = "agosto"
            fecha = Date.Now.ToString("dd") & " de " & substring & " de " & Date.Now.ToString("yyyy")
        End If

        If substring = "09" Then
            substring = "septiembre"
            fecha = Date.Now.ToString("dd") & " de " & substring & " de " & Date.Now.ToString("yyyy")
        End If
        If substring = "10" Then
            substring = "octubre"
            fecha = Date.Now.ToString("dd") & " de " & substring & " de " & Date.Now.ToString("yyyy")
        End If
        If substring = "11" Then
            substring = "noviembre"
            fecha = Date.Now.ToString("dd") & " de " & substring & " de " & Date.Now.ToString("yyyy")
        End If
        If substring = "12" Then
            substring = "diciembre"
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
        Dim cedula As String
        Dim num(7) As Char
        Dim suma As Integer
        Dim suma1 As Integer
        Dim calculo() As Integer = {2, 9, 8, 7, 6, 3, 4}

        cedula = cedu
        num = cedu.ToCharArray()

        For i = 0 To 6
            Dim num1 As Integer = Val(num(i))
            suma = (num1 * calculo(i)) + suma
        Next

        'num = suma.ToString.ToCharArray

        'ReDim Preserve num(1)
        'suma1 = Convert.ToInt32(num) + 1
        'num = suma1.ToString.ToCharArray
        'ReDim Preserve num(2)
        'num(2) = "0"

        'suma1 = Convert.ToInt32(num)
        'suma = suma1 - suma

        num = cedula.ToCharArray()

        Dim resto As Integer = 10 - (suma Mod 10)

        If resto = Val(num(7)) Then
            correcto = 0
        Else
            correcto = 1
        End If
    End Sub

End Module
