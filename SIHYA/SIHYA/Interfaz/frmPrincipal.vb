Public Class frmPrincipal

    Private Sub UsuariosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        frmNUsuarios.Show()
    End Sub

    Private Sub EmergenciaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EmergenciaToolStripMenuItem.Click
        frmFiltro.Show()
        frmFiltro.lblNumero.Text = "Emergencia"
    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NormalToolStripMenuItem.Click
        frmFiltro.lblNumero.Text = "Normal"
        frmFiltro.Show()
    End Sub

    Private Sub frmPrincipal_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            End
        End If
    End Sub

  
    Private Sub PacientesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PacientesToolStripMenuItem.Click
        
        frmBusPac.btnEliminar.Visible = False

        frmBusPac.Text = "Consulta de Pacientes"
        frmBusPac.Show()
    End Sub

    Private Sub LlenarAnalisisToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LlenarAnalisisToolStripMenuItem.Click
       
        frmBusPac.btnEliminar.Visible = True
        frmBusPac.Text = "Formulario de Pacientes"
        frmBusPac.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class