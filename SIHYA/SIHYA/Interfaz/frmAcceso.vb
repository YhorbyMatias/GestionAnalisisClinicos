Imports System.Data
Imports System.Data.SqlClient
Imports SIHYA.Modulo
Imports SIHYA.GlobalVariables
Imports SIHYA.cIniArray

Imports System.Windows.Forms

Public Class frmAcceso
    Dim Funcion As New Funciones

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
        Me.Close()
    End Sub

    Private Sub frmAcceso_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            End
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        ' frmPrincipal.Show()
        gsUsuario = Me.txtUsuario.Text
        glToday = Funcion.FormatDate(Date.Today.ToString)
        If Funcion.Conectar Then
            strSQL = "SELECT password, Nombre FROM TB_Usuario WHERE Cod_Usuario = '" & gsUsuario & "'"
            If Funcion.RecFound(strSQL, rsXDA, rsXDT) Then
                Dim rsxDR As DataRow = rsXDT(0)
                If Me.txtClave.Text = rsxDR("password").ToString Then
                    gsUsrSesion = rsxDR("Nombre").ToString
                    frmPrincipal.Show()
                    txtClave.Text = ""
                    frmPrincipal.Text = txtUsuario.Text + "=" + frmPrincipal.Text
                    Me.Hide()
                Else
                    MessageBox.Show("Usuario no Autorizado", "Control de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Usuario no Autorizado", "Control de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub frmAcceso_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class