Public Class frmHowToPlay

    Private Sub frmHowToPlay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rtb1.LoadFile("RRInstructions.rtf")

        Me.MaximumSize = New Size(650, 450)
        Me.MinimumSize = Me.MaximumSize
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = My.Resources.appNameHowToPlay

    End Sub

    
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Hide()
        frmMain.Show()
    End Sub
End Class