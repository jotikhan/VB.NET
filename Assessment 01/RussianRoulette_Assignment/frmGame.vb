Public Class frmGame
    ' System variables

    Inherits System.Windows.Forms.Form

    Dim CurrentPosition As Integer
    Dim CurrentLives As Integer = 3
    Dim Blocks As Integer = 2
    Dim Shield As Boolean
    Dim AI As Boolean, RRCheat As Boolean

    Dim Round As Integer

    Dim GunBarrel(5) As String
    Public ArrPlayerTurns(5) As String
    Dim SetBullet As Integer = 0
    Dim GameTurn As Integer

    Dim CPUNum0 As Integer = 0, CPUNum01 As Integer, CPUNum02 As Integer, CPUNum03 As Integer, CPUNum04 As Integer, CPUNum05 As Integer, CPUNum06 As Integer

    Private Sub RussianRoulette_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        RRPlayer1 = "Player 1"
        RRPlayer2 = "Player 2"
    End Sub
    Private Sub rbYes_CheckedChanged(sender As Object, e As EventArgs) Handles rbYes.CheckedChanged
        ' Cheat visability

        lstResults3.Visible = True
        lblOne.Visible = True
        lblTwo.Visible = True
        lblThree.Visible = True
        lblFour.Visible = True
        lblFive.Visible = True
        lblSix.Visible = True
        lblCheatOrder.Visible = True
        lstResults2.Visible = True
    End Sub

    Private Sub rbNo_CheckedChanged(sender As Object, e As EventArgs) Handles rbNo.CheckedChanged

        ' Cheat visability
        lstResults3.Visible = False
        lblOne.Visible = False
        lblTwo.Visible = False
        lblThree.Visible = False
        lblFour.Visible = False
        lblFive.Visible = False
        lblSix.Visible = False
        lblCheatOrder.Visible = False
        lstResults2.Visible = False
    End Sub
    Private Sub frmGame_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ' Code to capture the name entered from the main form
        lblRRName.Text = (StrConv(RRName, VbStrConv.ProperCase))

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Default form load settings

        btnPlayer.Visible = False
        btnChamber.Visible = False
        btnBlock.Visible = False
        gbBlock.Visible = False
        btnSave.Visible = False
        ProgressBar1.Visible = True
        PictureBox1.Image = My.Resources.RussianRouletteRR

        GunBarrel(0) = "E"
        GunBarrel(1) = "E"
        GunBarrel(2) = "E"
        GunBarrel(3) = "E"
        GunBarrel(4) = "E"
        GunBarrel(5) = "E"

        ListArrayBarrell()


        ArrPlayerTurns(0) = "O"
        ArrPlayerTurns(1) = "O"
        ArrPlayerTurns(2) = "O"
        ArrPlayerTurns(3) = "O"
        ArrPlayerTurns(4) = "O"
        ArrPlayerTurns(5) = "O"

        GameTurn = 0
        lblGameTurn.Text = "0"

        CalculateBarrel()

        setNum()

        lblLives.Text = CurrentLives
        lblBlocks.Text = Blocks

        lblShield.Text = Shield
        lblAI.Text = AI
        lblMessage.Text = "Click Load Bullet to start!!!"

        'Cheat mode default = No
        rbNo.Checked = True



    End Sub
    


    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        ' code to load the bullet
        ProgressBar1.Value = 0
        AI = False
        lblAI.Text = AI
        lblMessage.Text = "Click Spin chamber!!!"
        btnPlayer.Text = "Player 1"

        If CurrentLives > 0 Then


            ZeroBlockCheck()

            'If Blocks < 1 Then
            '    gbBlock.Visible = False
            '    btnBlock.Visible = False
            'End If

            Round = Round + 1

            lstResults2.Items.Clear()
            lstResults3.Items.Clear()


            Dim objRR As New RouletteConfig

            SetBullet = objRR.BulletPosition
            lblPosition.Text = SetBullet



            GunBarrel(SetBullet - 1) = "B"

            lstResults.Items.Clear()

            ListArrayBarrell()
            ListArrayPlayerTurns()

            btnSet.Visible = False
            btnChamber.Visible = True
            btnPlayer.Visible = False

            ZeroBlockCheck()

            'btnBlock.Visible = True
            'gbBlock.Visible = True


            ' try this

            GameTurn = 0
            lblGameTurn.Text = "0"
            lblRound.Text = Round
            btnBlock.Text = "Use Block"




        Else
            btnPlayer.Visible = False
            btnSave.Visible = True
            btnSet.Text = "Game over"
            PictureBox1.Image = My.Resources.You_lostRR
        End If


    End Sub


    Private Sub ListArrayBarrell()

        'Gun barrel array

        For i = 0 To GunBarrel.Length - 1

            lstResults.Items.Add(GunBarrel(i))

        Next i

    End Sub

    Private Sub ListArrayPlayerTurns()
        ' Player array 

        For i = 0 To (ArrPlayerTurns.Length - 1)

            lstResults3.Items.Add(ArrPlayerTurns(i))

        Next i

    End Sub


    Private Sub btnPlayer_Click(sender As Object, e As EventArgs) Handles btnPlayer_old.Click
        'Firing button code - iniates Firing() Sub

        lblMessage.Text = "Use Block if you have any blocks left!!"

        If btnPlayer_old.Text = "Player 1" And GameTurn < 6 Then

            lblTurn.Text = "Player 2"
            lstResults2.Items.Add("Player 1 ")
            GameTurn = GameTurn + 1
            lblGameTurn.Text = GameTurn

            btnPlayer_old.Text = "Player 2"
            UpdateTurn()


        ElseIf btnPlayer_old.Text = "Player 2" And GameTurn < 6 Then

            lblTurn.Text = "Player 1"
            lstResults2.Items.Add("Player 2")
            GameTurn = GameTurn + 1
            lblGameTurn.Text = GameTurn

            btnPlayer_old.Text = "Player 1"
            UpdateTurn()

        End If
        ' Next

    End Sub

    Public Function Turn()
        ' Random num check

        Dim Num1 As New Random
        Dim Random1 As Integer
        Random1 = Num1.Next(1, 7)

        Return Random1

    End Function



    Public Sub SpinBarrell()

        '  Put each random turn into text box lblone ....lblsix

        Dim generator As New Random


        lblOne.Text = generator.Next(1, 6)
        lblTwo.Text = generator.Next(1, 6)
        lblThree.Text = generator.Next(1, 6)
        lblFour.Text = generator.Next(1, 6)
        lblFive.Text = generator.Next(1, 6)
        lblSix.Text = generator.Next(1, 6)


    End Sub

    Public Function Discharge()
        ' Random number
        Dim DischargeNum1 As New Random
        Dim Random1 As Integer
        Random1 = DischargeNum1.Next(1, 7)

        Return Random1

    End Function

    Public Sub UpdateTurn()

        ' Random num check - Used for testing & further development
        Dim Shot As Integer
        Randomize()
        For i = 0 To 5

            Shot = Discharge()
            lblShot.Text = Shot

            ' Exit condition if the value is three.

            If ArrPlayerTurns(Shot - 1) <> "F" Then
                Exit For

            End If


        Next


        ArrPlayerTurns(Shot - 1) = "F"
        lstResults2.Items.Add(" Barrell: " & Shot)


        lstResults3.Items.Clear()
        ListArrayPlayerTurns()



    End Sub

    Sub CalculateBarrel()
        ' Random num code to set up barrel & shuffel the firing order


        Dim x, mix, temp As Integer
        Dim num As Integer = 6
        Dim randarray(num) As Integer
        Dim randnum As New Random

        For x = 1 To num
            randarray(x) = x
        Next x

        For x = 1 To num
            mix = randnum.Next(1, num + 1)
            temp = randarray(mix)
            randarray(mix) = randarray(x)
            randarray(x) = temp

        Next x

        txtShuffle.Clear()
        For x = 1 To num
            txtShuffle.Text &= randarray(x).ToString & " "
            lstResults5.Items.Add(randarray(x))
        Next x

        lblOne.Text = randarray(1)
        lblTwo.Text = randarray(2)
        lblThree.Text = randarray(3)
        lblFour.Text = randarray(4)
        lblFive.Text = randarray(5)
        lblSix.Text = randarray(6)

        CPUNum01 = (randarray(1) - 1)
        CPUNum02 = (randarray(2) - 1)
        CPUNum03 = (randarray(3) - 1)
        CPUNum04 = (randarray(4) - 1)
        CPUNum05 = (randarray(5) - 1)
        CPUNum06 = (randarray(6) - 1)



    End Sub


    Sub setNum()

        ' Displays the firing order for cheat mode
        lblCPU1.Text = CPUNum01
        lblCPU2.Text = CPUNum02
        lblCpu3.Text = CPUNum03
        lblCPU4.Text = CPUNum04
        lblCPU5.Text = CPUNum05
        lblCPU6.Text = CPUNum06



    End Sub



    Public Sub btnFetch_Click(sender As Object, e As EventArgs) Handles btnFetch.Click
        ' testing code for further development
        Dim rand As New Random
        Dim winnum As New List(Of Integer)
        Dim num, counter, n As Integer
        Dim result As String = ""

        Do
            num = rand.Next(1, 7)
            If winnum.Contains(num) Then
                Do
                    num = rand.Next(1, 7)
                Loop Until winnum.Contains(num) = False
            End If
            winnum.Add(num)
            counter += 1
        Loop Until counter = 2

        'Extracting and displaying the numbers from the array

        ' For n As Integer = 0 To 1
        n = 1
        result = winnum(n) & " " & result
        ArrPlayerTurns(n) = "F"
        'Next



    End Sub


    Private Sub btnBulletPosition_Click(sender As Object, e As EventArgs) Handles btnBulletPosition.Click

        ' Just used in testing to determine the bullet position
        MsgBox("value of bullet position is: " & SetBullet)
    End Sub

    Private Sub btnAddScore_Click(sender As Object, e As EventArgs) Handles btnAddScore.Click
        ' Used in Game Testing 
        Dim objRR As New RouletteConfig
        Dim setscore As Integer

        SetScore = objRR.Score
        objRR.Score = objRR.Score + 1
        lblScore.Text = objRR.Score



    End Sub

    Public Sub ResetRRForm()

        ' Code used to set up the gun barrel E for empty, the bullet B will go in the array

        CalculateBarrel()

        btnPlayer.Visible = False
        ProgressBar1.Visible = True


        GunBarrel(0) = "E"
        GunBarrel(1) = "E"
        GunBarrel(2) = "E"
        GunBarrel(3) = "E"
        GunBarrel(4) = "E"
        GunBarrel(5) = "E"

        ListArrayBarrell()


        ArrPlayerTurns(0) = "O"
        ArrPlayerTurns(1) = "O"
        ArrPlayerTurns(2) = "O"
        ArrPlayerTurns(3) = "O"
        ArrPlayerTurns(4) = "O"
        ArrPlayerTurns(5) = "O"





        setNum()

        lblLives.Text = CurrentLives

        ProgressBar1.Value = 0

        btnSet.Visible = True

        lstResults.Items.Clear() ' clear bullet chamber
        lstResults3.Items.Clear() ' Clear random barrel chamber
        lstResults5.Items.Clear()


        GameTurn = 0
        lblGameTurn.Text = "0"

        btnPlayer.Text = "Player 1"

    End Sub




    Private Sub btnRedo_Click(sender As Object, e As EventArgs) Handles btnRedo.Click
        ' Code to increment the lives count
        CurrentLives = CurrentLives - 1

        '        Application.Restart()


    End Sub


    Private Sub btnBlock_Click(sender As Object, e As EventArgs) Handles btnBlock.Click

        ' Code to display block game option 

        If btnBlock.Text = "Use Block" Then

            Blocks = Blocks - 1
            btnBlock.Text = "Do not Use Block"
            lblBlocks.Text = Blocks
            Shield = True
            lblShield.Text = Shield

        ElseIf btnBlock.Text = "Do not Use Block" Then

            Blocks = Blocks + 1
            btnBlock.Text = "Use Block"
            lblBlocks.Text = Blocks
            Shield = False
            lblShield.Text = Shield


        End If



    End Sub


    Public Sub RefreshBlock()

        ' Code refresh subroutine

        btnBlock.Text = "Use Block"
        lblBlocks.Text = Blocks
        Shield = False
        lblShield.Text = Shield
        lblRound.Text = Round
        lblGameTurn.Text = GameTurn
        lblAI.Text = AI
        lblLives.Text = CurrentLives
    End Sub


    Public Sub ZeroBlockCheck()

        ' to display teh block options


        If Blocks > 0 Then
            btnBlock.Visible = True
            gbBlock.Visible = True
            'End If

        Else

            btnBlock.Visible = False
            gbBlock.Visible = False

        End If

    End Sub


    Public Sub ClearBlockPostLoss()
        ' Make the block option invisible 

        btnBlock.Visible = False
        gbBlock.Visible = False
    End Sub


    Public Sub FiringShots()
        '  Code to fire the shots & insert values into Firing array

        ZeroBlockCheck()
        lblMessage.Text = "Click Use block to deflect a shot"
        'If Blocks < 1 Then
        '    gbBlock.Visible = False
        '    btnBlock.Visible = False
        'End If


        lstResults3.Items.Clear()
        lblLives.Text = CurrentLives

        If GameTurn = 5 Then   '     code makes Button visible property false after 6 turns
            btnPlayer.Visible = False
        End If



        If GameTurn < 6 Then


            '----------------First check for block using Shield boolean--------------

            If Val(CPUNum01 + 1) = Val(SetBullet) AndAlso Shield = True Then

                Shield = False
                ' Refresh Fields
                'lblShield.Text = Shield
                'lblRound.Text = Round
                Timer1.Stop()
                PictureBox1.Image = My.Resources.SurvivedRR
                
                ResetRRForm()
                RefreshBlock()


            Else
                ' end of shield boolean - now fire bullet and continue 

                If GameTurn = 0 Then
                    ArrPlayerTurns(CPUNum01) = "F"

                    AI = True

                    lstResults2.Items.Add(" Barrell: " & (CPUNum01) + 1)

                    If Val(CPUNum01 + 1) = Val(SetBullet) Then
                        PictureBox1.Image = My.Resources.You_lostRR
                        CurrentLives = CurrentLives - 1
                        lblLives.Text = CurrentLives

                        ClearBlockPostLoss()
                        ResetRRForm()
                        ProgressBar1.Visible = False


                    End If

                    lblGameTurn.Text = GameTurn
                    ListArrayPlayerTurns()
                    '  lstResults3.Items.Clear()
                    RefreshBlock()

                End If

                PictureBox1.Image = My.Resources.RussianRouletteRR

            End If
            '   --------- The 2nd shot array =  1st Commputer shot------------------

            'Second check for block using Shield boolean

            If Val(CPUNum02 + 1) = Val(SetBullet) = True Then
                ResetRRForm()

                Shield = False
                Timer1.Stop()
                ' Refresh Fields
                'lblShield.Text = Shield
                'lblRound.Text = Round
                PictureBox1.Image = My.Resources.SurvivedRR
                ProgressBar1.Visible = False
            Else

                If GameTurn = 1 Then
                    ArrPlayerTurns(CPUNum02) = "F"
                    AI = False

                    lstResults2.Items.Add(" Barrell: " & (CPUNum02) + 1)

                    If Val(CPUNum02 + 1) = Val(SetBullet) Then
                        ' CurrentLives = CurrentLives - 1  this is only for Human scoring
                        lblLives.Text = CurrentLives
                        ClearBlockPostLoss()

                        ResetRRForm()
                        RefreshBlock()
                        ProgressBar1.Visible = False
                        PictureBox1.Image = My.Resources.SurvivedRR


                    End If

                    lblGameTurn.Text = GameTurn
                    ListArrayPlayerTurns()

                    RefreshBlock()
                End If
                btnPlayer.Text = "Player 1"
                PictureBox1.Image = My.Resources.SurvivedRR

            End If
            '-----Player 1---- The third shot array ---Human shot 2------------------------
            '3rd check for block using Shield boolean

            If Val(CPUNum03 + 1) = Val(SetBullet) AndAlso Shield = True Then

                Timer1.Stop()
                Shield = False
                ' Refresh Fields
                PictureBox1.Image = My.Resources.SurvivedRR
                lblShield.Text = Shield
                lblRound.Text = Round
                ResetRRForm()

            Else
                If GameTurn = 2 Then
                    ArrPlayerTurns(CPUNum03) = "F"
                    AI = True
                    lblAI.Text = AI

                    lstResults2.Items.Add(" Barrell: " & (CPUNum03) + 1)

                    If Val(CPUNum03 + 1) = Val(SetBullet) Then
                        PictureBox1.Image = My.Resources.You_lostRR
                        CurrentLives = CurrentLives - 1
                        lblLives.Text = CurrentLives

                        ClearBlockPostLoss()
                        ResetRRForm()
                        RefreshBlock()
                        ProgressBar1.Visible = False

                    End If

                    lblGameTurn.Text = GameTurn
                    ListArrayPlayerTurns()

                End If


                PictureBox1.Image = My.Resources.RussianRouletteRR
            End If
            '--Player 2-----the Fourth shot array ----Computer shot 2------------

            '4th check for block using Shield boolean

            If Val(CPUNum04 + 1) = Val(SetBullet) Then

                Shield = False
                ' Refresh Fields
                lblShield.Text = Shield
                lblRound.Text = Round
                ResetRRForm()
                PictureBox1.Image = My.Resources.SurvivedRR
            Else


                If GameTurn = 3 Then
                    ArrPlayerTurns(CPUNum04) = "F"
                    AI = False
                    lblAI.Text = AI

                    lstResults2.Items.Add(" Barrell: " & (CPUNum04) + 1)

                    If Val(CPUNum04 + 1) = Val(SetBullet) Then
                        '  CurrentLives = CurrentLives - 1
                        lblLives.Text = CurrentLives

                        ClearBlockPostLoss()
                        ResetRRForm()
                        RefreshBlock()
                        ProgressBar1.Visible = False
                        PictureBox1.Image = My.Resources.SurvivedRR

                    End If

                    lblGameTurn.Text = GameTurn
                    ListArrayPlayerTurns()

                    'RefreshBlock()
                End If

                PictureBox1.Image = My.Resources.SurvivedRR
            End If
            '---------- The fifth shot array- Player 1 human-------------------------

            '5th check for block using Shield boolean

            If Val(CPUNum05 + 1) = Val(SetBullet) AndAlso Shield = True Then

                Timer1.Stop()
                PictureBox1.Image = My.Resources.SurvivedRR
                Shield = False
                ' Refresh Fields
                lblShield.Text = Shield
                lblRound.Text = Round
                ResetRRForm()

            Else

                If GameTurn = 4 Then
                    ArrPlayerTurns(CPUNum05) = "F"
                    AI = True

                    lstResults2.Items.Add(" Barrell: " & (CPUNum05) + 1)

                    If Val(CPUNum05 + 1) = Val(SetBullet) Then
                        PictureBox1.Image = My.Resources.You_lostRR
                        CurrentLives = CurrentLives - 1
                        lblLives.Text = CurrentLives

                        ClearBlockPostLoss()
                        ResetRRForm()
                        RefreshBlock()
                        ProgressBar1.Visible = False

                    End If

                    lblGameTurn.Text = GameTurn
                    ListArrayPlayerTurns()

                    RefreshBlock()

                End If

                PictureBox1.Image = My.Resources.RussianRouletteRR
            End If
            ' -------- The sixth & final shot array-- = Computer shot---------------

            '6th check for block using Shield boolean

            If Val(CPUNum01 + 1) = Val(SetBullet) AndAlso Shield = True Then


                Shield = False
                ' Refresh Fields
                lblShield.Text = Shield
                lblRound.Text = Round
                ResetRRForm()

            Else

                If GameTurn = 5 Then

                    ArrPlayerTurns(CPUNum06) = "F"
                    AI = False

                    lstResults2.Items.Add(" Barrell: " & (CPUNum06) + 1)
                    Timer1.Stop()
                    If Val(CPUNum06 + 1) = Val(SetBullet) Then
                        '  CurrentLives = CurrentLives - 1
                        lblLives.Text = CurrentLives
                        Timer1.Stop()

                        ClearBlockPostLoss()
                        ResetRRForm()
                        RefreshBlock()
                        ProgressBar1.Visible = False
                        PictureBox1.Image = My.Resources.SurvivedRR
                    End If

                    lblGameTurn.Text = GameTurn
                    ListArrayPlayerTurns()

                    RefreshBlock()

                End If
                PictureBox1.Image = My.Resources.SurvivedRR
            End If
            '------------------------ end of shot array condition checks----------

        Else
            'Button1.Visible = False
        End If





        GameTurn = GameTurn + 1
        lblGameTurn.Text = GameTurn
        ProgressBar1.Value = GameTurn
        CheckGameOver()

        ' MsgBox("Message 2")
        btnPlayer.Text = "Player 2"

    End Sub

    Private Sub btnPlayer_Click_1(sender As Object, e As EventArgs) Handles btnPlayer.Click
        ' The firing button code - changes the text to Player 2 (computer opponent

        If btnPlayer.Text = "Player 1" Then

            ' btnPlayer.Text = RRPlayer2
            'MsgBox("SHot number " & (GameTurn + 1))
            AI = True

            Timer1.Start()

        ElseIf btnPlayer.Text = "Player 2" Then

            ' Change Player button to Player 1


            RefreshFields()


        End If

        RefreshFields()

        FiringShots()


    End Sub


    Public Sub CheckGameOver()

        ' Code to display the save button

        If CurrentLives = 0 Then
            btnSet.Visible = False
            btnSave.Visible = True
            PictureBox1.Image = My.Resources.GameOverRR

        End If
    End Sub


    

    Private Sub RefreshFields()
        'Default Roulette pictue
        PictureBox1.Image = My.Resources.GunBarrelRR
    End Sub

    Private Sub BulletSound()
        ' To be completed firing sound
    End Sub


    Public Sub CompMakeMove()

        'Automated computer move - initiates the firing Subroutine 

        If btnPlayer.Text = "Player 2" Then

            FiringShots()

            AI = False
            btnPlayer.Text = "Player 1"
            'UpdateTurn()
            RefreshFields()


        End If

        Timer1.Stop()

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CompMakeMove()

    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'Saves the file & also resets the lives and blocks variable if another game is started 

        CurrentLives = 3
        Blocks = 2
        ResetRRForm()

        Dim file As System.IO.StreamWriter


        file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\jk017\Downloads\RR.txt", True)
        file.WriteLine(lblRRName.Text & "," & lblRound.Text)

        MsgBox("Successfully Saved " & lblRRName.Text)

        file.Close()
        Me.Close()
        frmMain.Show()



    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        'opens the main form
        Me.Hide()
        frmMain.Show()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)
        'to be completed later 
        AxWindowsMediaPlayer1.URL = "C:\Users\jk017\Downloads\gunshot.wav"
    End Sub


    Private Sub btnChamber_Click(sender As Object, e As EventArgs) Handles btnChamber.Click

        ' Sets up the bullet & chamber variables

        btnSet.Visible = False
        btnChamber.Visible = False
        btnPlayer.Visible = True

        CalculateBarrel()

        'btnPlayer.Visible = False
        ProgressBar1.Visible = True


      
        ArrPlayerTurns(0) = "O"
        ArrPlayerTurns(1) = "O"
        ArrPlayerTurns(2) = "O"
        ArrPlayerTurns(3) = "O"
        ArrPlayerTurns(4) = "O"
        ArrPlayerTurns(5) = "O"

        lstResults3.Items.Clear()

        lblMessage.Text = "Please click on Player 1 - Computer will autoshot"

        lblLives.Text = CurrentLives

        ProgressBar1.Value = 0

        lstResults5.Items.Clear()


        GameTurn = 0
    
        btnPlayer.Text = "Player 1"

    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        frmMain.Show()


    End Sub
End Class
