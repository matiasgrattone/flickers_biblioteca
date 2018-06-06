Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient


Module Modulo

    Dim ubicacion As String = "server=localhost; user id=root; password=''; database=biblioteca"
    Public Conexion As MySqlDataAdapter
    Public Tabla As DataTable
    Public Consulta As String
    Public MysqlConexion As MySqlConnection = New MySqlConnection(ubicacion)
    Public opcioncolor As Color

    Public Sub consultar()

        Try
            Conexion = New MySqlDataAdapter(Consulta, ubicacion)
            Tabla = New DataTable
            Conexion.Fill(Tabla)

        Catch ex As Exception

        End Try

    End Sub


    Public Sub color()



        '////////////////////////////// CONFIGURACION INICIAL PARA EL PANEL USUARIOS /////////////////// 

        '-------------------------- COLOR PARA EL PANEL AL INICIAR -------------------

        inicio_usuarios.Panel4.BackColor = opcioncolor
        inicio_usuarios.Panel10.BackColor = opcioncolor
        inicio_usuarios.Panel5.BackColor = opcioncolor
        inicio_usuarios.Panel6.BackColor = opcioncolor
        inicio_usuarios.Panel7.BackColor = opcioncolor
        inicio_usuarios.Panel1.BackColor = opcioncolor
        inicio_usuarios.Panel13.BackColor = opcioncolor
        '----------------------------------------------------------------------------

        '----------------------------------------------------------------------------

        inicio_usuarios.Panel4.Height = 45
        inicio_usuarios.Panel5.Height = 42
        inicio_usuarios.Panel6.Height = 42
        inicio_usuarios.Panel7.Height = 42

        '----------------------------------------------------------------------------

        '------------------------ COLOR PARA EL PANEL INICIAL ------------------------

        inicio_usuarios.Panel2.BackColor = opcioncolor

        '-----------------------------------------------------------------------------




        '/////// COLOR PANELES ///////////////////////////////////////////////////////


        ' Form1.Panel2.BackColor = Drawing.Color.Red 'PANEL DETRAS DEL TAB CONTROL

        ' Form1.Panel12.BackColor = Drawing.Color.Green 'PANEL BORRAR USUARIOS
        ' Form1.Panel11.BackColor = Drawing.Color.Red 'PANEL EDITAR USUARIOS
        ' Form1.Panel10.BackColor = Drawing.Color.LightBlue 'PANEL AGREGAR USUARIOS
        'Form1.Panel9.BackColor = Drawing.Color.Pink 'PANEL BUSCAR USUARIOS


        inicio_usuarios.Panel2.BackColor = opcioncolor 'PANEL DETRAS DEL TAB CONTROL

        inicio_usuarios.Panel12.BackColor = opcioncolor 'PANEL BORRAR USUARIOS
        inicio_usuarios.Panel11.BackColor = opcioncolor 'PANEL EDITAR USUARIOS
        inicio_usuarios.Panel10.BackColor = opcioncolor 'PANEL AGREGAR USUARIOS
        inicio_usuarios.Panel9.BackColor = opcioncolor 'PANEL BUSCAR USUARIOS


        '/////////////////////////////////////////////////////////////////////////////




    End Sub

End Module
