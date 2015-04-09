Public Class frmSplash

    Private Sub frmSplash_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ''iniciamos el timer
        TimerSplash.Start()


    End Sub

    Private Sub TimerSplash_Tick(sender As System.Object, e As System.EventArgs) Handles TimerSplash.Tick

        pbSplash.Increment(5)
        Label1.Text = pbSplash.Value
        If pbSplash.Value = 5 Then

            Label3.Text = "Iniciando Sistema.."
        End If

        If pbSplash.Value = 10 Then
            Label3.Text = "Inicializando Requerimientos.."
        End If
        If pbSplash.Value = 25 Then
            Label3.Text = "Leyendo Configuracion.."
        End If

        If pbSplash.Value = 50 Then
            Label3.Text = "Conectando Con  La Base De Datos.."
        End If
        If pbSplash.Value = 75 Then
            Label3.Text = "Cargando Configuracion..."
        End If
        If pbSplash.Value = 90 Then
            Label3.Text = "Abriendo.."
        End If

        If pbSplash.Value = pbSplash.Maximum Then
            TimerSplash.Stop()
            Me.Hide()
            frmAcceso.Show()
        End If
    End Sub
End Class
