Imports System.Data
Imports System.Data.SqlClient
Imports SIHYA.Modulo
Imports SIHYA.GlobalVariables
Public Class frmBusPac
    Public Sub MostrarDatos()
        If Not Conn.State = ConnectionState.Open Then
            Conn.Open()
        End If
        Dim dt As New SqlDataAdapter("SELECT * FROM TB_Paciente", Conn)
        Dim ds As New DataSet
        dt.Fill(ds, "TB_Paciente")
        btnLimpiar.DataSource = ds
        btnLimpiar.DataMember = "TB_Paciente"
    End Sub
    Private Sub btnBuscar_TextChanged(sender As Object, e As System.EventArgs) Handles btnBuscar.TextChanged
        Try
            If Not Conn.State = ConnectionState.Open Then
                Conn.Open()
            End If
            Dim da As New SqlDataAdapter("SELECT * FROM TB_Paciente WHERE Nombre Like '%" & txtNombre.Text & "%' or cod_Paciente like '%" & txtNombre.Text & "%'", Conn)
            Dim ds As New DataSet
            da.Fill(ds, "TB_Paciente")
            btnLimpiar.DataSource = ds
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgRegistro_RowHeaderMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles btnLimpiar.RowHeaderMouseClick
        Try
            If btnLimpiar.Rows.Count Then
                If btnLimpiar.SelectedRows.Count > 0 Then
                    Dim intCodigoPac As String = btnLimpiar.SelectedRows(0).Cells("cod_Paciente").Value
                    Dim da As New SqlDataAdapter("SELECT * FROM TB_Paciente WHERE cod_Paciente='" & intCodigoPac.ToString & "'", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    txtNombre.Text = dt.Rows(0).Item("Nombre")
                    cbbcasos.Text = dt.Rows(0).Item("c_tipo")
                    txtNAtentido.Text = dt.Rows(0).Item("Atendido")
                    txtApellido.Text = dt.Rows(0).Item("Apellido")
                    dtpFechaIng.Text = dt.Rows(0).Item("Fecha_Ing")
                    frmLaboratorio.lblCPaciente.Text = dt.Rows(0).Item("Cod_Paciente")
                    frmLaboratorio.lblNombreP.Text = dt.Rows(0).Item("Nombre")
                    frmLaboratorio.lblApellidoP.Text = dt.Rows(0).Item("Apellido")
                End If
            End If
            
            Dim da1 As New SqlDataAdapter("SELECT * FROM TB_Coprologico WHERE cod_Coprologico='" & frmLaboratorio.lblCPaciente.Text & "'", Conn)
            Dim dt1 As New DataTable
            da1.Fill(dt1)
            lblCo.Text = dt1.Rows(0).Item("Cod_Coprologico")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        ' frmAcceso.gbAtutenticacionUrs.Focus()
        Conn.Close()
        txtNombre.Text = ""
        txtApellido.Text = ""
        cbbcasos.Text = ""
        txtNAtentido.Text = ""
        dtpFechaIng.Text = ""
        Me.Hide()
    End Sub

    Private Sub frmBusArt_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'If e.CloseReason = CloseReason.UserClosing Then
        '    End
        'End If
    End Sub

    Private Sub frmBusArt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MostrarDatos()
    End Sub
    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Try
           


            If txtNombre.Text = "" Then
                MessageBox.Show("Selecione el Nombre del paciente paciente a llenar analisis", "Control Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
            If txtApellido.Text = "" Then
                MessageBox.Show("Selecione el Apellido paciente a llenar analisis", "Control Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If

            If txtNAtentido.Text = "" Then

                MessageBox.Show("Selecione el Numero de orden paciente a llenar analisis", "Control Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)





            Else
                frmLaboratorio.Show()
                Me.Hide()


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs)
        'frmManArtvb.Show()
        'frmManArtvb.btnActualizar.Visible = False
        'frmManArtvb.btnGuardar.Visible = True
        'frmManArtvb.txtCodArticulo.Enabled = True
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        Try
            If btnLimpiar.Rows.Count > 0 Then
                If btnLimpiar.SelectedRows.Count > 0 Then
                    Dim intID As String = btnLimpiar.SelectedRows(0).Cells("cod_Paciente").Value
                    If Not Conn.State = ConnectionState.Open Then
                        Conn.Open()
                    End If
                    Dim cmd As New SqlCommand
                    cmd.Connection = Conn
                    cmd.CommandText = "DELETE FROM TB_Paciente WHERE cod_Paciente=" & intID
                    cmd.ExecuteNonQuery()
                    Conn.Close()
                    MessageBox.Show("Eliminacion Completada")
                    MostrarDatos()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtNombre_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNombre.TextChanged
        If Not Conn.State = ConnectionState.Open Then
            Conn.Open()
        End If
        Dim da As New SqlDataAdapter("SELECT * FROM TB_Paciente WHERE Nombre Like '%" & txtNombre.Text & "%' and Apellido like '%" & txtApellido.Text & "%' and Atendido like '%" & txtNAtentido.Text & "%' and Fecha_Ing like '%" & dtpFechaIng.Text & "%' and C_Tipo Like '%" & cbbcasos.Text & "%'", Conn)
        Dim ds As New DataSet
        da.Fill(ds, "TB_Paciente")
        btnLimpiar.DataSource = ds
    End Sub

    Private Sub cbbcasos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbcasos.SelectedIndexChanged
        If Not Conn.State = ConnectionState.Open Then
            Conn.Open()
        End If
        Dim da As New SqlDataAdapter("SELECT * FROM TB_Paciente WHERE Nombre Like '%" & txtNombre.Text & "%' and Apellido like '%" & txtApellido.Text & "%' and Atendido like '%" & txtNAtentido.Text & "%' and Fecha_Ing like '%" & dtpFechaIng.Text & "%' and C_Tipo Like '%" & cbbcasos.Text & "%'", Conn)
        Dim ds As New DataSet
        da.Fill(ds, "TB_Paciente")
        btnLimpiar.DataSource = ds
    End Sub

    Private Sub txtApellido_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtApellido.TextChanged
        If Not Conn.State = ConnectionState.Open Then
            Conn.Open()
        End If
        Dim da As New SqlDataAdapter("SELECT * FROM TB_Paciente WHERE Nombre Like '%" & txtNombre.Text & "%' and Apellido like '%" & txtApellido.Text & "%' and Atendido like '%" & txtNAtentido.Text & "%' and Fecha_Ing like '%" & dtpFechaIng.Text & "%' and C_Tipo Like '%" & cbbcasos.Text & "%'", Conn)
        Dim ds As New DataSet
        da.Fill(ds, "TB_Paciente")
        btnLimpiar.DataSource = ds
    End Sub

    Private Sub txtNAtentido_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNAtentido.TextChanged
        If Not Conn.State = ConnectionState.Open Then
            Conn.Open()
        End If
        Dim da As New SqlDataAdapter("SELECT * FROM TB_Paciente WHERE Nombre Like '%" & txtNombre.Text & "%' and Apellido like '%" & txtApellido.Text & "%' and Atendido like '%" & txtNAtentido.Text & "%' and Fecha_Ing like '%" & dtpFechaIng.Text & "%' and C_Tipo Like '%" & cbbcasos.Text & "%'", Conn)
        Dim ds As New DataSet
        da.Fill(ds, "TB_Paciente")
        btnLimpiar.DataSource = ds
    End Sub


    Private Sub dtpFechaIng_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpFechaIng.ValueChanged
        If Not Conn.State = ConnectionState.Open Then
            Conn.Open()
        End If
        Dim da As New SqlDataAdapter("SELECT * FROM TB_Paciente WHERE Nombre Like '%" & txtNombre.Text & "%' and Apellido like '%" & txtApellido.Text & "%' and Atendido like '%" & txtNAtentido.Text & "%' and Fecha_Ing like '%" & dtpFechaIng.Text & "%' and C_Tipo Like '%" & cbbcasos.Text & "%'", Conn)
        Dim ds As New DataSet
        da.Fill(ds, "TB_Paciente")
        btnLimpiar.DataSource = ds
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        txtNombre.Text = ""
        txtApellido.Text = ""
        cbbcasos.Text = ""
        txtNAtentido.Text = ""
    End Sub


End Class