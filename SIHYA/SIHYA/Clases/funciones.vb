Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data
Imports System.Data.SqlClient
Imports SIHYA.cIniArray
Imports SIHYA.GlobalVariables
Namespace Modulo
    Public Class Funciones


        Public Function Conectar() As Boolean
            Dim enEjecucion As Boolean
            Dim sCadenaConexion As String
            Try

                enEjecucion = Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName).Length > 1

                'If enEjecucion Then
                '    MessageBox.Show("Existe otra version del programa ejecutandose actualmente")
                '    Return False
                '    Exit Function
                'End If

                Call BuscarDefaults()

                If Not Conn Is Nothing Then
                    If Conn.State = ConnectionState.Open Then
                        Conn.Close()
                    End If
                End If

                If gsTipoConexion1 = "SQL" Then
                    'Conexión DGJP con SQL
                    sCadenaConexion = "Server=" & gsDataServer1 _
                                  & ";Database=" & gsDataBase1 _
                                  & ";User Id=" & gsUserId1 _
                                  & ";Password=" & gsPassword1 _
                                  & ";Connect Timeout=" & gsConnectTimeout & ";"
                Else
                    'Conexión DGJP con Active Directory
                    sCadenaConexion = "Server=" & gsDataServer1 _
                                          & ";Database=" & gsDataBase1 _
                                          & ";Integrated Security=SSPI" _
                                          & ";Persist Security Info=true" _
                                          & ";Connect Timeout=" & gsConnectTimeout & ";"
                End If
                'Crear la nueva conexion  
                Conn = New SqlConnection(sCadenaConexion)
                'Abrir la conexion
                Conn.Open()

                cmdSQL.Connection = Conn

                Return True

            Catch ex As Exception
                MSG("ERROR al conectar o recuperar los datos:" & vbCrLf & ex.Message, "Conectar con la base", 0, 16)
                Return False
            End Try
        End Function

        Private Sub BuscarDefaults()
            Dim sMyDir As String, sMyFile As String
            Dim mINI As New cIniArray
            '=====================================================================================
            ' Modificación para leer parámetros pasados desde archivo .INI Eddy Sánchez 20-02-2014
            '=====================================================================================
            'Asignar la ruta donde esta el ejecutable
            sMyDir = AppPath() & "\SIJUPEN_DN.ini"
            'Verifica si el archivo existe
            sMyFile = Dir(sMyDir)
            'Si el resultado de la busqueda es vacio es porque no existe
            If sMyFile = "" Then
                MSG("Archivo INI No existe, Imposible Ejecutar Aplicación", "SIJUPEN: Leer Parámetros", 0, 16)
                End
            End If
            '#1
            'Asignarle a las variables los valores que estan en el archivo.
            'smydir = Directorio + archivo, Database = Seccion, Conexion1 = Linea a leer
            gsTipoConexion1 = mINI.IniGet(sMyDir, "DataBase", "Conexion1", "")
            gsDataServer1 = mINI.IniGet(sMyDir, "DataBase", "DataServer1", "")
            gsDataBase1 = mINI.IniGet(sMyDir, "DataBase", "DataBase1", "")
            gsUserId1 = mINI.IniGet(sMyDir, "DataBase", "UserId1", "")
            gsPassword1 = mINI.IniGet(sMyDir, "DataBase", "Password1", "")
            'Generico
            gsConnectTimeout = mINI.IniGet(sMyDir, "DataBase", "ConnectTimeout", 15)
            gsSiglas = mINI.IniGet(sMyDir, "Parameters", "Siglas", "")
            ID_x = mINI.IniGet(sMyDir, "Parameters", "ID", "")
            gsPWD = mINI.IniGet(sMyDir, "Parameters", "PWD", "")
            gsRNCSEH = mINI.IniGet(sMyDir, "Parameters", "rncSEH", "")
            gsDirExp = mINI.IniGet(sMyDir, "Path", "DirExp", "")
            gsDirReports = mINI.IniGet(sMyDir, "Path", "Reports", "")

            gsArea = "DN"
            gsSistema = "SIJUPEN"
        End Sub

        Public Function RecFound(pSQL As String, ByRef rsRegDA As SqlDataAdapter, ByRef rsRegDT As DataTable) As Boolean
            ' Para Buscar un Registro en la Base de Datos
            Try
                rsRegDA = New SqlDataAdapter(pSQL, Conn)

                Dim cb As New SqlCommandBuilder(rsRegDA)
                ' Como hay campos con caracteres especiales,
                ' al usarlos incluirlos entre corchetes.
                cb.QuotePrefix = "["
                cb.QuoteSuffix = "]"

                'Crear un nuevo Datatable
                rsRegDT = New DataTable

                ' Llenar la tabla con los datos indicados
                rsRegDA.Fill(rsRegDT)

                'Preguntar si tiene informacion
                If rsRegDT.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
                Exit Function

            Catch ex As Exception
                MSG("ERROR al recuperar los datos:" & vbCrLf & ex.Message, "Buscar Datos", 0, 16)
                Return False
            End Try
        End Function

        'Para ejecutar las instrucciones SQL [Insertar, Borrar, Actualizar]
        Public Function EjecutaSQL(pSQL As String, Formulario As Form) As Boolean
            'Iniciar la transaccion
            cmdSQL.Transaction = Conn.BeginTransaction
            'asignar el tiempo de espera maximo [0 = infinito]
            cmdSQL.CommandTimeout = 0
            Try
                'Asignar la instruccion SQL al Comando SQL 
                cmdSQL.CommandText = pSQL
                'Ejecutar el comando
                cmdSQL.ExecuteNonQuery()
                'Aplicar el comando
                cmdSQL.Transaction.Commit()
                Return True

            Catch ex As Exception
                'Devolver los cambios
                cmdSQL.Transaction.Rollback()
                'Destruir el comando
                cmdSQL.Dispose()
                MSG("ERROR al Ejecutar Instrucción:" & vbCrLf & ex.Message, "Ejecutar Query", 0, 16)
                Return False
            End Try
        End Function

        'pFecha Viene en Formato dd/MM/yyyy  y la Devuelve yyyymmdd
        Public Function FormatDate(pFecha As String) As Long
            Try
                FormatDate = Mid(pFecha, 7, 4) & Mid(pFecha, 4, 2) & Mid(pFecha, 1, 2)
                Return FormatDate
                Exit Function

            Catch ex As Exception
                FormatDate = "19000101"
                Return FormatDate
            End Try
        End Function

        Public Sub MSG(Mensaje As String, Titulo As String, Boton As Integer, Alerta As Integer)
            Select Case Boton
                Case Is = 0
                    Select Case Alerta
                        Case Is = 16
                            MessageBox.Show(Mensaje, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)        'Hand, Stop
                        Case Is = 64
                            MessageBox.Show(Mensaje, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)  'Asterix
                        Case Is = 48
                            MessageBox.Show(Mensaje, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning)      'Exclamation
                        Case Is = 0
                            MessageBox.Show(Mensaje, Titulo, MessageBoxButtons.OK, MessageBoxIcon.None)
                        Case Is = 32
                            MessageBox.Show(Mensaje, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Question)
                    End Select
            End Select
        End Sub

        Sub LimpiarCampos()
            Throw New NotImplementedException
        End Sub

    End Class
End Namespace
