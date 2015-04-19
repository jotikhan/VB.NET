Public Class frmMain
    Dim score As Integer
    Private Sub RussianRouletteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RussianRouletteToolStripMenuItem.Click
        Me.Hide()
        frmGame.Show()

    End Sub

    Private Sub frmMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'lblShowScore.Text = "Your score is : " + Score.ToString + " Points"
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtInput1.Text = "Vision College"
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub



    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click


        If txtInput1.Text <> "" Then
            RRName = txtInput1.Text
            Me.Hide()
            frmGame.Show()


        Else
            MsgBox("Please enter your Name to play")
            txtInput1.Focus()
        End If

    End Sub

    Private Sub btnHighScores_Click(sender As Object, e As EventArgs) Handles btnHighScores.Click
        Me.Hide()
        frmDataGridView.Show()

    End Sub

    

    

    

    Private Sub btnHowToPlay_Click(sender As Object, e As EventArgs) Handles btnHowToPlay.Click
        Me.Hide()
        frmHowToPlay.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class