Public Class frmSplashScreen

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value <= 100 Then


            ProgressBar1.Value = ProgressBar1.Value + 1 'increment the value of progress bar by 1
            lblStatus.Text = ProgressBar1.Value & "% Completing..." 'display the current percent of the progress.


            If ProgressBar1.Value = 25 Then
                lblStatus2.Text = "Setting up Russian Roulette"

            End If

            If ProgressBar1.Value = 40 Then
                lblStatus2.Text = "Preparing files..."

            End If


            If ProgressBar1.Value = 60 Then
                lblStatus2.Text = "Feeling lucky..."

            End If

            If ProgressBar1.Value = 75 Then
                lblStatus2.Text = "Are you ready to play ?"

            End If

            If ProgressBar1.Value = 100 Then
                Timer1.Stop()
                Me.Hide()
                frmMain.Show()
                'End If
                ProgressBar1.Value = 0
                Timer2.Stop()

            End If

        Else
            ProgressBar1.Value = 100
        End If




    End Sub

    Private Sub frmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0

        Timer1.Start()
        Timer2.Start()


    End Sub





    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        AxWindowsMediaPlayer1.URL = "C:\Users\jk017\Downloads\power_on.wav"
    End Sub
End Class