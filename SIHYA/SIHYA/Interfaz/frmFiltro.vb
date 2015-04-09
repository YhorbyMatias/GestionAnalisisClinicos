Imports System.Data
Imports System.Data.SqlClient
Imports SIHYA.Modulo
Imports SIHYA.GlobalVariables
Imports SIHYA.cIniArray

Imports System.Windows.Forms

Public Class frmFiltro
    Dim embassy As Integer



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'this value marck if the costumer have already execute
        embassy = 0
        Try

            If cbCropologico.Checked = False And cbOrina.Checked = False And cbPEmbarazo.Checked = False And cbQuimicaSanguinea.Checked = False And cbSedimentos.Checked = False And cbSerologia.Checked = False Then
                MessageBox.Show("Usted no a seleccionado ninguna indicacion", "Control de sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                'frmLaboratorio.gbOrina.Visible = False
                'frmLaboratorio.gbPEmbarazo.Visible = False
                'frmLaboratorio.gbQSanguinea.Visible = False
                'frmLaboratorio.gbSedimentos.Visible = False
                'frmLaboratorio.gbSerologia.Visible = False
                'frmLaboratorio.gbCropologico.Visible = False


                If Not Conn.State = ConnectionState.Open Then
                    Conn.Open()
                End If
                Dim cmd As New SqlCommand
                cmd.Connection = Conn
                cmd.CommandText = "INSERT INTO TB_Paciente (Nombre,Apellido,Telefono,Edad,C_tipo,Sexo,Record_no,fecha_ing,Fecha_Ent,atendido,entregado) VALUES ('" & txtNombre.Text & "','" & txtApellido.Text & "','" & txtTelefono.Text & "','" & txtEdad.Text & "','" & lblNumero.Text & "','" & cbbSexo.Text & "','" & txtNRecord.Text & "','" & dtpFechaActual.Value & "','" & dtpFechaEnt.Value & "','" & txtAtendido.Text & "','" & embassy & "' )"
                cmd.ExecuteNonQuery()






                MessageBox.Show("Datos Guardados", "Articulo Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNombre.Text = ""
                txtApellido.Text = ""
                txtEdad.Text = ""
                cbbSexo.Text = ""
                txtNRecord.Text = ""
                txtTelefono.Text = ""
                txtAtendido.Text = ""
                dtpFechaActual.Text = ""

                'If cbCropologico.CheckState = CheckState.Checked Then
                '    frmLaboratorio.gbCropologico.Visible = True
                'End If
                'If cbSerologia.CheckState = CheckState.Checked Then
                '    frmLaboratorio.gbSerologia.Visible = True
                'End If
                'If cbSedimentos.CheckState = CheckState.Checked Then
                '    frmLaboratorio.gbSedimentos.Visible = True
                'End If
                'If cbOrina.CheckState = CheckState.Checked Then
                '    frmLaboratorio.gbOrina.Visible = True
                'End If
                'If cbPEmbarazo.CheckState = CheckState.Checked Then
                '    frmLaboratorio.gbPEmbarazo.Visible = True
                'End If
                'If cbQuimicaSanguinea.CheckState = CheckState.Checked Then
                '    frmLaboratorio.gbQSanguinea.Visible = True
                'End If

                cbOrina.Checked = False
                cbPEmbarazo.Checked = False
                cbQuimicaSanguinea.Checked = False
                cbSedimentos.Checked = False
                cbSerologia.Checked = False
                cbCropologico.Checked = False

                cbTodos.Checked = False
                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            txtNombre.Focus()

        End Try

    End Sub

    Private Sub cbTodos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbTodos.CheckedChanged
        If cbTodos.CheckState = CheckState.Checked Then
            cbOrina.CheckState = CheckState.Checked
            cbPEmbarazo.CheckState = CheckState.Checked
            cbQuimicaSanguinea.CheckState = CheckState.Checked
            cbSedimentos.CheckState = CheckState.Checked
            cbSerologia.CheckState = CheckState.Checked
            cbCropologico.CheckState = CheckState.Checked
        Else
            cbOrina.Checked = False
            cbPEmbarazo.Checked = False
            cbQuimicaSanguinea.Checked = False
            cbSedimentos.Checked = False
            cbSerologia.Checked = False
            cbCropologico.Checked = False
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiar.Click
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtEdad.Text = ""
        cbbSexo.Text = ""
        txtNRecord.Text = ""
        txtTelefono.Text = ""
        txtAtendido.Text = ""
        dtpFechaActual.Text = ""
    End Sub


    Private Sub cbbSexo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbSexo.SelectedIndexChanged
        If cbbSexo.Text = "Masculino" Then
            cbPEmbarazo.Enabled = False
        Else
            cbPEmbarazo.Enabled = True
        End If
    End Sub

    Private Sub frmFiltro_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class