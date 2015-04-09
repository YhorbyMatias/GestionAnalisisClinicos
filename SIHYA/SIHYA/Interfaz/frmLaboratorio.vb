Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports SIHYA.Modulo
Imports System.Data
Imports System.Data.SqlClient
Imports SIHYA.cIniArray
Imports SIHYA.GlobalVariables

Public Class frmLaboratorio
    Dim Funcion As New Funciones
    Private Sub frmLaboratorio_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        gbCropologico.Visible = False
        gbOrina.Visible = False
        gbPEmbarazo.Visible = False
        gbQSanguinea.Visible = False
        gbSedimentos.Visible = False
        gbSerologia.Visible = False
        Me.Hide()
    End Sub


    Private Sub frmLaboratorio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'If Not gbSerologia.Visible = True Then
        '    gbOrina.Location = New System.Drawing.Point(283, 12)
        Dim Num As New Integer
        If frmBusPac.btnEliminar.Visible = False Then
            gbCropologico.Enabled = False
            gbOrina.Enabled = False
            gbPEmbarazo.Enabled = False
            gbQSanguinea.Enabled = False
            gbSedimentos.Enabled = False
            gbSerologia.Enabled = False
            btnGuardar.Visible = False
        Else
            gbCropologico.Enabled = True
            gbOrina.Enabled = True
            gbPEmbarazo.Enabled = True
            gbQSanguinea.Enabled = True
            gbSedimentos.Enabled = True
            gbSerologia.Enabled = True
            btnGuardar.Visible = True
        End If

        If frmBusPac.Text = "Consulta de Pacientes" Then
            Dim da As New SqlDataAdapter("SELECT * FROM TB_Coprologico WHERE id='" & lblCPaciente.Text & "'", Conn)
            Dim dt As New DataTable
            da.Fill(dt)
            txtColor2.Text = dt.Rows(0).Item("Color")
            txtConsistencia.Text = dt.Rows(0).Item("Consistencia")
            cbbHuevos.Text = dt.Rows(0).Item("Huevos")
            cbbQuistes.Text = dt.Rows(0).Item("Quistes")
            cbbLarvas.Text = dt.Rows(0).Item("Larvas")
            cbbBacterias.Text = dt.Rows(0).Item("Bacterias")

            Dim da1 As New SqlDataAdapter("SELECT * FROM TB_Orina WHERE id='" & lblCPaciente.Text & "'", Conn)
            Dim dt1 As New DataTable
            da1.Fill(dt1)
            txtColor.Text = dt1.Rows(0).Item("Color")
            cbbAspecto.Text = dt1.Rows(0).Item("Aspecto")
            txtPH.Text = dt1.Rows(0).Item("PH")
            txtDensidad.Text = dt1.Rows(0).Item("Densidad")
            cbbProteinas.Text = dt1.Rows(0).Item("Proteinas")
            cbbGlucosa.Text = dt1.Rows(0).Item("Glucosa")
            cbbAcetona.Text = dt1.Rows(0).Item("Acetona")
            cbbUrobolinogeno.Text = dt1.Rows(0).Item("Urobilinogeno")
            cbbBilirrubina.Text = dt1.Rows(0).Item("Bilirrubina")
            cbbNitritos.Text = dt1.Rows(0).Item("Nitritos")
            txtSangreO.Text = dt1.Rows(0).Item("Sangre_O")

            Dim da2 As New SqlDataAdapter("SELECT * FROM TB_Serologia WHERE id='" & lblCPaciente.Text & "'", Conn)
            Dim dt2 As New DataTable
            da2.Fill(dt2)
            cbbVDRL.Text = dt2.Rows(0).Item("VDRL")
            cbbReumatoide.Text = dt2.Rows(0).Item("F_Reumatoide")
            cbbPCR.Text = dt2.Rows(0).Item("P_C_R")
            txtToxoplasmosis.Text = dt2.Rows(0).Item("Toxoplasmosis")
            cbbIGG.Text = dt2.Rows(0).Item("IGG")
            cbbIGM.Text = dt2.Rows(0).Item("IGM")
            cbbASO.Text = dt2.Rows(0).Item("A_S_O")
            cbbGrupo.Text = dt2.Rows(0).Item("Grupo")
            cbbRH.Text = dt2.Rows(0).Item("RH")
            cbbAFebriles.Text = dt2.Rows(0).Item("A_Febriles")
            cbbHIV.Text = dt2.Rows(0).Item("HIV")
            cbbHBSAG.Text = dt2.Rows(0).Item("HBSAG")
            cbbHVC.Text = dt2.Rows(0).Item("HVC")

            Dim da3 As New SqlDataAdapter("SELECT * FROM TB_Sedimentos WHERE id='" & lblCPaciente.Text & "'", Conn)
            Dim dt3 As New DataTable
            da3.Fill(dt3)
            txtLeucocitos.Text = dt3.Rows(0).Item("Leucocitos")
            txtHematies.Text = dt3.Rows(0).Item("Hematies")
            cbbEpitelios.Text = dt3.Rows(0).Item("Epitelios")
            cbbBacteriasS.Text = dt3.Rows(0).Item("Bacterias")
            cbbFMucosa.Text = dt3.Rows(0).Item("F_Mucosa")
            cbbCilindro.Text = dt3.Rows(0).Item("Cilindro")
            txtCristales.Text = dt3.Rows(0).Item("Cristales")
            txtTVaginales.Text = dt3.Rows(0).Item("T_Vaginales")
            txtMonilias.Text = dt3.Rows(0).Item("Monilias")

            Dim da4 As New SqlDataAdapter("SELECT * FROM TB_QSanguinea WHERE id='" & lblCPaciente.Text & "'", Conn)
            Dim dt4 As New DataTable
            da4.Fill(dt4)
            txtGlicemia.Text = dt4.Rows(0).Item("Glicemia")
            txtUrea.Text = dt4.Rows(0).Item("Urea")
            txtCreatinina.Text = dt4.Rows(0).Item("Creatinina")
            txtColesterol.Text = dt4.Rows(0).Item("Colesterol")
            txtHDL.Text = dt4.Rows(0).Item("HDL")
            txtLDL.Text = dt4.Rows(0).Item("LDL")
            txtTriglicerido.Text = dt4.Rows(0).Item("Triglicerido")
            txtAUrico.Text = dt4.Rows(0).Item("Ac_Urico")
            txtBilirrubinaT.Text = dt4.Rows(0).Item("Bilirrubina_T")
            txtBilirrubinaD.Text = dt4.Rows(0).Item("Bilirrubina_D")
            txtBilirrubinaI.Text = dt4.Rows(0).Item("Bilirrubina_I")
            txtTGO.Text = dt4.Rows(0).Item("T_G_O")

            Conn.Close()

        Else

        End If



    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        frmBusPac.Show()
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Try
            If Not Conn.State = ConnectionState.Open Then
                Conn.Open()
            End If

         

            cmdSQL.Connection = Conn
            cmdSQL.CommandText = "INSERT INTO TB_Coprologico (id,Cod_paciente,Color,Consistencia,Huevos,Quistes,Larvas,Bacterias) VALUES ('" & lblCPaciente.Text & "','" & lblCPaciente.Text & "','" & Me.txtColor2.Text & "','" & Me.txtConsistencia.Text & "','" & Me.cbbHuevos.Text & "','" & Me.cbbQuistes.Text & "','" & Me.cbbLarvas.Text & "','" & Me.cbbBacterias.Text & "' )"
            cmdSQL.ExecuteNonQuery()


            cmdSQL.Connection = Conn
            cmdSQL.CommandText = "INSERT INTO TB_Orina (id, Cod_paciente,color,Aspecto,Densidad,PH,Proteinas,Glucosa,Acetona,Urobilinogeno,Bilirrubina,nitritos,Sangre_O) VALUES ('" & lblCPaciente.Text & "','" & lblCPaciente.Text & "','" & Me.cbbAspecto.Text & "','" & Me.txtPH.Text & "','" & Me.txtDensidad.Text & "','" & Me.cbbProteinas.Text & "','" & Me.cbbGlucosa.Text & "','" & Me.cbbAcetona.Text & "','" & Me.cbbUrobolinogeno.Text & "','" & Me.cbbBilirrubina.Text & "','" & Me.cbbNitritos.Text & "','" & Me.txtSangreO.Text & "')"
            cmdSQL.ExecuteNonQuery()


            cmdSQL.Connection = Conn
            cmdSQL.CommandText = "INSERT INTO TB_Serologia (id, Cod_paciente,VDRL,F_Reumatoide,P_C_R,Toxoplasmosis,IGG,IGM,A_S_O,Grupo,RH,A_Febriles,HIV,HBSAG,HVC,P_Embarazo) VALUES ('" & lblCPaciente.Text & "','" & lblCPaciente.Text & "','" & Me.cbbVDRL.Text & "','" & Me.cbbReumatoide.Text & "','" & Me.cbbPCR.Text & "','" & Me.txtToxoplasmosis.Text & "','" & Me.cbbIGG.Text & "','" & Me.cbbIGM.Text & "','" & Me.cbbASO.Text & "','" & Me.cbbGrupo.Text & "','" & Me.cbbRH.Text & "','" & Me.cbbAFebriles.Text & "','" & Me.cbbHIV.Text & "','" & Me.cbbHBSAG.Text & "','" & Me.cbbHVC.Text & "','" & Me.txtPEmbarazo.Text & "')"
            cmdSQL.ExecuteNonQuery()

            cmdSQL.Connection = Conn
            cmdSQL.CommandText = "INSERT INTO TB_Sedimentos (id,Cod_paciente,Leucocitos,Hematies,Epitelios,Bacterias,F_Mucosa,Cilindros,Cristales,T_vaginales,Monilias) VALUES ('" & lblCPaciente.Text & "','" & lblCPaciente.Text & "','" & Me.txtLeucocitos.Text & "','" & Me.txtHematies.Text & "','" & Me.cbbEpitelios.Text & "','" & Me.cbbBacteriasS.Text & "','" & Me.cbbFMucosa.Text & "','" & Me.cbbCilindro.Text & "','" & Me.cbbCilindro.Text & "','" & Me.txtCristales.Text & "','" & Me.txtTVaginales.Text & "','" & Me.txtMonilias.Text & "')"
            cmdSQL.ExecuteNonQuery()

            cmdSQL.Connection = Conn
            cmdSQL.CommandText = " INSERT INTO TB_QSanguinea (id, Cod_paciente,Glicemia,Urea,Creatinina,Colesterol,HDl,LDL,Triglicerido,Ac_Urico,Bilirrubina_T,Bilirrubina_D,Bilirrubina_i,T_G_O) VALUES ('" & lblCPaciente.Text & "','" & lblCPaciente.Text & "','" & Me.txtGlicemia.Text & "','" & Me.txtUrea.Text & "','" & Me.txtCreatinina.Text & "','" & Me.txtColesterol.Text & "','" & Me.txtHDL.Text & "','" & Me.txtLDL.Text & "','" & Me.txtTriglicerido.Text & "','" & Me.txtAUrico.Text & "','" & Me.txtBilirrubinaT.Text & "','" & Me.txtBilirrubinaD.Text & "','" & Me.txtBilirrubinaI.Text & "',' " & Me.txtTGO.Text & "' )"
            cmdSQL.ExecuteNonQuery()
            Dim embassy As Integer
            'embassy = 1
            'cmdSQL.Connection = Conn

            'cmdSQL.CommandText = "UPDATE TB_Paciente SET atendido = '" & embassy & "', "
            'cmdSQL.ExecuteNonQuery()
            frmBusPac.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

   
    
End Class
