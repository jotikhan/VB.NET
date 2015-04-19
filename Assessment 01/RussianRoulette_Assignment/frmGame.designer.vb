<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGame))
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.btnPlayer_old = New System.Windows.Forms.Button()
        Me.lblTurn = New System.Windows.Forms.Label()
        Me.lstResults2 = New System.Windows.Forms.ListBox()
        Me.lblShot = New System.Windows.Forms.Label()
        Me.lblCPU1 = New System.Windows.Forms.Label()
        Me.lblCPU2 = New System.Windows.Forms.Label()
        Me.lblGameTurn = New System.Windows.Forms.Label()
        Me.lstResults3 = New System.Windows.Forms.ListBox()
        Me.lblOne = New System.Windows.Forms.Label()
        Me.lblThree = New System.Windows.Forms.Label()
        Me.lblTwo = New System.Windows.Forms.Label()
        Me.lblFour = New System.Windows.Forms.Label()
        Me.lblFive = New System.Windows.Forms.Label()
        Me.lblSix = New System.Windows.Forms.Label()
        Me.lstResults4 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPlayer = New System.Windows.Forms.Button()
        Me.txtShuffle = New System.Windows.Forms.TextBox()
        Me.btnFetch = New System.Windows.Forms.Button()
        Me.lstResults5 = New System.Windows.Forms.ListBox()
        Me.txtHappy = New System.Windows.Forms.TextBox()
        Me.lblCpu3 = New System.Windows.Forms.Label()
        Me.lblCPU4 = New System.Windows.Forms.Label()
        Me.lblCPU5 = New System.Windows.Forms.Label()
        Me.lblCPU6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLives = New System.Windows.Forms.Label()
        Me.btnBulletPosition = New System.Windows.Forms.Button()
        Me.btnAddScore = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnRedo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.labelAI = New System.Windows.Forms.Label()
        Me.lblAI = New System.Windows.Forms.Label()
        Me.lblShield = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblBlocks = New System.Windows.Forms.Label()
        Me.gbBlock = New System.Windows.Forms.GroupBox()
        Me.btnBlock = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblRound = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblRRName = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.rbYes = New System.Windows.Forms.RadioButton()
        Me.lblCheatOrder = New System.Windows.Forms.Label()
        Me.btnChamber = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBlock.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(256, 5)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(36, 82)
        Me.lstResults.TabIndex = 0
        '
        'btnSet
        '
        Me.btnSet.Location = New System.Drawing.Point(3, 5)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(77, 37)
        Me.btnSet.TabIndex = 1
        Me.btnSet.Text = "Load Bullet"
        Me.ToolTip1.SetToolTip(Me.btnSet, "Click to load the bullet")
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.ForeColor = System.Drawing.Color.Maroon
        Me.lblPosition.Location = New System.Drawing.Point(148, 335)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(22, 24)
        Me.lblPosition.TabIndex = 2
        Me.lblPosition.Text = ".."
        '
        'btnPlayer_old
        '
        Me.btnPlayer_old.Location = New System.Drawing.Point(18, 285)
        Me.btnPlayer_old.Name = "btnPlayer_old"
        Me.btnPlayer_old.Size = New System.Drawing.Size(72, 30)
        Me.btnPlayer_old.TabIndex = 3
        Me.btnPlayer_old.Text = "Player 1"
        Me.btnPlayer_old.UseVisualStyleBackColor = True
        '
        'lblTurn
        '
        Me.lblTurn.AutoSize = True
        Me.lblTurn.Location = New System.Drawing.Point(16, 143)
        Me.lblTurn.Name = "lblTurn"
        Me.lblTurn.Size = New System.Drawing.Size(13, 13)
        Me.lblTurn.TabIndex = 4
        Me.lblTurn.Text = ".."
        Me.lblTurn.Visible = False
        '
        'lstResults2
        '
        Me.lstResults2.FormattingEnabled = True
        Me.lstResults2.Location = New System.Drawing.Point(359, 5)
        Me.lstResults2.Name = "lstResults2"
        Me.lstResults2.Size = New System.Drawing.Size(72, 82)
        Me.lstResults2.TabIndex = 5
        '
        'lblShot
        '
        Me.lblShot.AutoSize = True
        Me.lblShot.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShot.Location = New System.Drawing.Point(90, 197)
        Me.lblShot.Name = "lblShot"
        Me.lblShot.Size = New System.Drawing.Size(20, 24)
        Me.lblShot.TabIndex = 6
        Me.lblShot.Text = ".."
        '
        'lblCPU1
        '
        Me.lblCPU1.AutoSize = True
        Me.lblCPU1.Location = New System.Drawing.Point(525, 79)
        Me.lblCPU1.Name = "lblCPU1"
        Me.lblCPU1.Size = New System.Drawing.Size(10, 13)
        Me.lblCPU1.TabIndex = 7
        Me.lblCPU1.Text = "."
        Me.lblCPU1.Visible = False
        '
        'lblCPU2
        '
        Me.lblCPU2.AutoSize = True
        Me.lblCPU2.Location = New System.Drawing.Point(522, 121)
        Me.lblCPU2.Name = "lblCPU2"
        Me.lblCPU2.Size = New System.Drawing.Size(13, 13)
        Me.lblCPU2.TabIndex = 8
        Me.lblCPU2.Text = ".."
        Me.lblCPU2.Visible = False
        '
        'lblGameTurn
        '
        Me.lblGameTurn.AutoSize = True
        Me.lblGameTurn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameTurn.Location = New System.Drawing.Point(384, 200)
        Me.lblGameTurn.Name = "lblGameTurn"
        Me.lblGameTurn.Size = New System.Drawing.Size(13, 15)
        Me.lblGameTurn.TabIndex = 9
        Me.lblGameTurn.Text = ".."
        '
        'lstResults3
        '
        Me.lstResults3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstResults3.FormattingEnabled = True
        Me.lstResults3.ItemHeight = 15
        Me.lstResults3.Location = New System.Drawing.Point(317, 1)
        Me.lstResults3.Name = "lstResults3"
        Me.lstResults3.Size = New System.Drawing.Size(36, 94)
        Me.lstResults3.TabIndex = 10
        Me.lstResults3.Visible = False
        '
        'lblOne
        '
        Me.lblOne.AutoSize = True
        Me.lblOne.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOne.Location = New System.Drawing.Point(431, 1)
        Me.lblOne.Name = "lblOne"
        Me.lblOne.Size = New System.Drawing.Size(13, 15)
        Me.lblOne.TabIndex = 11
        Me.lblOne.Text = ".."
        '
        'lblThree
        '
        Me.lblThree.AutoSize = True
        Me.lblThree.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThree.Location = New System.Drawing.Point(432, 31)
        Me.lblThree.Name = "lblThree"
        Me.lblThree.Size = New System.Drawing.Size(13, 15)
        Me.lblThree.TabIndex = 12
        Me.lblThree.Text = ".."
        '
        'lblTwo
        '
        Me.lblTwo.AutoSize = True
        Me.lblTwo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTwo.Location = New System.Drawing.Point(431, 16)
        Me.lblTwo.Name = "lblTwo"
        Me.lblTwo.Size = New System.Drawing.Size(13, 15)
        Me.lblTwo.TabIndex = 13
        Me.lblTwo.Text = ".."
        '
        'lblFour
        '
        Me.lblFour.AutoSize = True
        Me.lblFour.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFour.Location = New System.Drawing.Point(431, 49)
        Me.lblFour.Name = "lblFour"
        Me.lblFour.Size = New System.Drawing.Size(13, 15)
        Me.lblFour.TabIndex = 14
        Me.lblFour.Text = ".."
        '
        'lblFive
        '
        Me.lblFive.AutoSize = True
        Me.lblFive.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFive.Location = New System.Drawing.Point(432, 67)
        Me.lblFive.Name = "lblFive"
        Me.lblFive.Size = New System.Drawing.Size(13, 15)
        Me.lblFive.TabIndex = 15
        Me.lblFive.Text = ".."
        '
        'lblSix
        '
        Me.lblSix.AutoSize = True
        Me.lblSix.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSix.Location = New System.Drawing.Point(432, 82)
        Me.lblSix.Name = "lblSix"
        Me.lblSix.Size = New System.Drawing.Size(13, 15)
        Me.lblSix.TabIndex = 16
        Me.lblSix.Text = ".."
        '
        'lstResults4
        '
        Me.lstResults4.FormattingEnabled = True
        Me.lstResults4.Location = New System.Drawing.Point(140, 9)
        Me.lstResults4.Name = "lstResults4"
        Me.lstResults4.Size = New System.Drawing.Size(98, 160)
        Me.lstResults4.TabIndex = 17
        Me.lstResults4.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(285, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Total Shots"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 343)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 15)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Barrel Chamber Number"
        '
        'btnPlayer
        '
        Me.btnPlayer.Location = New System.Drawing.Point(98, 39)
        Me.btnPlayer.Name = "btnPlayer"
        Me.btnPlayer.Size = New System.Drawing.Size(91, 42)
        Me.btnPlayer.TabIndex = 20
        Me.btnPlayer.Text = "Player 1"
        Me.ToolTip1.SetToolTip(Me.btnPlayer, """Player 1 click to shoot""")
        Me.btnPlayer.UseVisualStyleBackColor = True
        '
        'txtShuffle
        '
        Me.txtShuffle.Location = New System.Drawing.Point(32, 143)
        Me.txtShuffle.Multiline = True
        Me.txtShuffle.Name = "txtShuffle"
        Me.txtShuffle.Size = New System.Drawing.Size(100, 20)
        Me.txtShuffle.TabIndex = 21
        '
        'btnFetch
        '
        Me.btnFetch.Location = New System.Drawing.Point(36, 169)
        Me.btnFetch.Name = "btnFetch"
        Me.btnFetch.Size = New System.Drawing.Size(75, 23)
        Me.btnFetch.TabIndex = 22
        Me.btnFetch.Text = "Get 1st"
        Me.btnFetch.UseVisualStyleBackColor = True
        '
        'lstResults5
        '
        Me.lstResults5.FormattingEnabled = True
        Me.lstResults5.Location = New System.Drawing.Point(33, 42)
        Me.lstResults5.Name = "lstResults5"
        Me.lstResults5.Size = New System.Drawing.Size(98, 95)
        Me.lstResults5.TabIndex = 23
        '
        'txtHappy
        '
        Me.txtHappy.Location = New System.Drawing.Point(96, 258)
        Me.txtHappy.Multiline = True
        Me.txtHappy.Name = "txtHappy"
        Me.txtHappy.Size = New System.Drawing.Size(100, 65)
        Me.txtHappy.TabIndex = 24
        Me.txtHappy.Visible = False
        '
        'lblCpu3
        '
        Me.lblCpu3.AutoSize = True
        Me.lblCpu3.Location = New System.Drawing.Point(522, 168)
        Me.lblCpu3.Name = "lblCpu3"
        Me.lblCpu3.Size = New System.Drawing.Size(10, 13)
        Me.lblCpu3.TabIndex = 25
        Me.lblCpu3.Text = "."
        Me.lblCpu3.Visible = False
        '
        'lblCPU4
        '
        Me.lblCPU4.AutoSize = True
        Me.lblCPU4.Location = New System.Drawing.Point(522, 202)
        Me.lblCPU4.Name = "lblCPU4"
        Me.lblCPU4.Size = New System.Drawing.Size(10, 13)
        Me.lblCPU4.TabIndex = 26
        Me.lblCPU4.Text = "."
        Me.lblCPU4.Visible = False
        '
        'lblCPU5
        '
        Me.lblCPU5.AutoSize = True
        Me.lblCPU5.Location = New System.Drawing.Point(522, 253)
        Me.lblCPU5.Name = "lblCPU5"
        Me.lblCPU5.Size = New System.Drawing.Size(10, 13)
        Me.lblCPU5.TabIndex = 27
        Me.lblCPU5.Text = "."
        Me.lblCPU5.Visible = False
        '
        'lblCPU6
        '
        Me.lblCPU6.AutoSize = True
        Me.lblCPU6.Location = New System.Drawing.Point(514, 304)
        Me.lblCPU6.Name = "lblCPU6"
        Me.lblCPU6.Size = New System.Drawing.Size(10, 13)
        Me.lblCPU6.TabIndex = 28
        Me.lblCPU6.Text = "."
        Me.lblCPU6.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(182, 343)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 15)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Lives Remaining: "
        '
        'lblLives
        '
        Me.lblLives.AutoSize = True
        Me.lblLives.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLives.ForeColor = System.Drawing.Color.Maroon
        Me.lblLives.Location = New System.Drawing.Point(283, 335)
        Me.lblLives.Name = "lblLives"
        Me.lblLives.Size = New System.Drawing.Size(20, 24)
        Me.lblLives.TabIndex = 30
        Me.lblLives.Text = ".."
        '
        'btnBulletPosition
        '
        Me.btnBulletPosition.Location = New System.Drawing.Point(140, 175)
        Me.btnBulletPosition.Name = "btnBulletPosition"
        Me.btnBulletPosition.Size = New System.Drawing.Size(64, 23)
        Me.btnBulletPosition.TabIndex = 31
        Me.btnBulletPosition.Text = "Value"
        Me.btnBulletPosition.UseVisualStyleBackColor = True
        '
        'btnAddScore
        '
        Me.btnAddScore.Location = New System.Drawing.Point(129, 204)
        Me.btnAddScore.Name = "btnAddScore"
        Me.btnAddScore.Size = New System.Drawing.Size(75, 23)
        Me.btnAddScore.TabIndex = 32
        Me.btnAddScore.Text = "Add Score"
        Me.btnAddScore.UseVisualStyleBackColor = True
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.LightCoral
        Me.lblScore.Location = New System.Drawing.Point(137, 234)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(51, 13)
        Me.lblScore.TabIndex = 33
        Me.lblScore.Text = "Score is :"
        '
        'btnRedo
        '
        Me.btnRedo.Location = New System.Drawing.Point(77, 9)
        Me.btnRedo.Name = "btnRedo"
        Me.btnRedo.Size = New System.Drawing.Size(46, 23)
        Me.btnRedo.TabIndex = 34
        Me.btnRedo.Text = "Redo"
        Me.btnRedo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Panel1.Controls.Add(Me.btnMain)
        Me.Panel1.Controls.Add(Me.btnRedo)
        Me.Panel1.Controls.Add(Me.lblScore)
        Me.Panel1.Controls.Add(Me.lstResults5)
        Me.Panel1.Controls.Add(Me.btnAddScore)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.txtShuffle)
        Me.Panel1.Controls.Add(Me.btnBulletPosition)
        Me.Panel1.Controls.Add(Me.btnFetch)
        Me.Panel1.Controls.Add(Me.txtHappy)
        Me.Panel1.Controls.Add(Me.lblShot)
        Me.Panel1.Controls.Add(Me.lstResults4)
        Me.Panel1.Controls.Add(Me.btnPlayer_old)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.labelAI)
        Me.Panel1.Controls.Add(Me.lblTurn)
        Me.Panel1.Controls.Add(Me.lblAI)
        Me.Panel1.Controls.Add(Me.lblShield)
        Me.Panel1.Location = New System.Drawing.Point(547, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(233, 333)
        Me.Panel1.TabIndex = 35
        Me.Panel1.Visible = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(77, 239)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(76, 40)
        Me.AxWindowsMediaPlayer1.TabIndex = 36
        '
        'btnMain
        '
        Me.btnMain.Location = New System.Drawing.Point(4, 200)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(75, 23)
        Me.btnMain.TabIndex = 35
        Me.btnMain.Text = "Main"
        Me.btnMain.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(184, 233)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 23)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(104, 285)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 48
        Me.TextBox1.Visible = False
        '
        'labelAI
        '
        Me.labelAI.AutoSize = True
        Me.labelAI.Location = New System.Drawing.Point(126, 156)
        Me.labelAI.Name = "labelAI"
        Me.labelAI.Size = New System.Drawing.Size(17, 13)
        Me.labelAI.TabIndex = 44
        Me.labelAI.Text = "AI"
        Me.labelAI.Visible = False
        '
        'lblAI
        '
        Me.lblAI.AutoSize = True
        Me.lblAI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAI.ForeColor = System.Drawing.Color.Tomato
        Me.lblAI.Location = New System.Drawing.Point(51, 148)
        Me.lblAI.Name = "lblAI"
        Me.lblAI.Size = New System.Drawing.Size(15, 15)
        Me.lblAI.TabIndex = 45
        Me.lblAI.Text = ".."
        Me.lblAI.Visible = False
        '
        'lblShield
        '
        Me.lblShield.AutoSize = True
        Me.lblShield.Location = New System.Drawing.Point(110, 288)
        Me.lblShield.Name = "lblShield"
        Me.lblShield.Size = New System.Drawing.Size(13, 13)
        Me.lblShield.TabIndex = 40
        Me.lblShield.Text = ".."
        Me.lblShield.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(286, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 15)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Blocks"
        '
        'lblBlocks
        '
        Me.lblBlocks.AutoSize = True
        Me.lblBlocks.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlocks.Location = New System.Drawing.Point(383, 178)
        Me.lblBlocks.Name = "lblBlocks"
        Me.lblBlocks.Size = New System.Drawing.Size(13, 15)
        Me.lblBlocks.TabIndex = 37
        Me.lblBlocks.Text = ".."
        '
        'gbBlock
        '
        Me.gbBlock.BackColor = System.Drawing.Color.Cornsilk
        Me.gbBlock.Controls.Add(Me.btnBlock)
        Me.gbBlock.Location = New System.Drawing.Point(287, 234)
        Me.gbBlock.Name = "gbBlock"
        Me.gbBlock.Size = New System.Drawing.Size(149, 69)
        Me.gbBlock.TabIndex = 39
        Me.gbBlock.TabStop = False
        Me.gbBlock.Text = "Shot Away shot?"
        '
        'btnBlock
        '
        Me.btnBlock.Location = New System.Drawing.Point(23, 25)
        Me.btnBlock.Name = "btnBlock"
        Me.btnBlock.Size = New System.Drawing.Size(97, 35)
        Me.btnBlock.TabIndex = 39
        Me.btnBlock.Text = "Use Block"
        Me.ToolTip1.SetToolTip(Me.btnBlock, "Click to block a shot / Shot away")
        Me.btnBlock.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(285, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 15)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Round :"
        '
        'lblRound
        '
        Me.lblRound.AutoSize = True
        Me.lblRound.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRound.Location = New System.Drawing.Point(383, 156)
        Me.lblRound.Name = "lblRound"
        Me.lblRound.Size = New System.Drawing.Size(13, 15)
        Me.lblRound.TabIndex = 42
        Me.lblRound.Text = ".."
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(5, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 34)
        Me.btnSave.TabIndex = 43
        Me.btnSave.Text = "Save Score"
        Me.ToolTip1.SetToolTip(Me.btnSave, "Click to save your score")
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNewGame
        '
        Me.btnNewGame.Location = New System.Drawing.Point(466, -1)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(75, 23)
        Me.btnNewGame.TabIndex = 46
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        Me.btnNewGame.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Print", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Indigo
        Me.Label6.Location = New System.Drawing.Point(347, 331)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 30)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Ver 1.1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1235
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(14, 388)
        Me.ProgressBar1.Maximum = 6
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(389, 23)
        Me.ProgressBar1.TabIndex = 49
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(384, 372)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "06"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(332, 371)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 13)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "05"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(135, 372)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 13)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "02"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(78, 371)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 13)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "01"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(202, 371)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 13)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "03"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(264, 372)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 13)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "04"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(86, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 14)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Welcome"
        '
        'lblRRName
        '
        Me.lblRRName.AutoSize = True
        Me.lblRRName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRRName.ForeColor = System.Drawing.Color.SeaGreen
        Me.lblRRName.Location = New System.Drawing.Point(143, 9)
        Me.lblRRName.Name = "lblRRName"
        Me.lblRRName.Size = New System.Drawing.Size(17, 19)
        Me.lblRRName.TabIndex = 57
        Me.lblRRName.Text = ".."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(465, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 23)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbNo)
        Me.GroupBox1.Controls.Add(Me.rbYes)
        Me.GroupBox1.Location = New System.Drawing.Point(298, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(91, 36)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cheat Mode"
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Location = New System.Drawing.Point(48, 12)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(39, 17)
        Me.rbNo.TabIndex = 1
        Me.rbNo.TabStop = True
        Me.rbNo.Text = "No"
        Me.ToolTip1.SetToolTip(Me.rbNo, "Select to hide cheat mode")
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'rbYes
        '
        Me.rbYes.AutoSize = True
        Me.rbYes.Location = New System.Drawing.Point(8, 13)
        Me.rbYes.Name = "rbYes"
        Me.rbYes.Size = New System.Drawing.Size(43, 17)
        Me.rbYes.TabIndex = 0
        Me.rbYes.TabStop = True
        Me.rbYes.Text = "Yes"
        Me.ToolTip1.SetToolTip(Me.rbYes, "Select  to display the firing order")
        Me.rbYes.UseVisualStyleBackColor = True
        '
        'lblCheatOrder
        '
        Me.lblCheatOrder.AutoSize = True
        Me.lblCheatOrder.Location = New System.Drawing.Point(389, 105)
        Me.lblCheatOrder.Name = "lblCheatOrder"
        Me.lblCheatOrder.Size = New System.Drawing.Size(61, 13)
        Me.lblCheatOrder.TabIndex = 61
        Me.lblCheatOrder.Text = "Firing Order"
        '
        'btnChamber
        '
        Me.btnChamber.Location = New System.Drawing.Point(5, 45)
        Me.btnChamber.Name = "btnChamber"
        Me.btnChamber.Size = New System.Drawing.Size(75, 39)
        Me.btnChamber.TabIndex = 62
        Me.btnChamber.Text = "Spin Chamber"
        Me.ToolTip1.SetToolTip(Me.btnChamber, "Click to spin the gun chamber")
        Me.btnChamber.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(226, 90)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 63
        Me.Label14.Text = "Gun Chamber"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.RussianRoulette_Assignment.My.Resources.Resources.GunBarrelRR
        Me.PictureBox1.Location = New System.Drawing.Point(5, 111)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(275, 225)
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.DarkViolet
        Me.lblMessage.Location = New System.Drawing.Point(11, 91)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(15, 13)
        Me.lblMessage.TabIndex = 65
        Me.lblMessage.Text = ".."
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Maroon
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(409, 388)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(35, 23)
        Me.btnExit.TabIndex = 66
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 423)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnChamber)
        Me.Controls.Add(Me.lblCheatOrder)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblRRName)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblRound)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.gbBlock)
        Me.Controls.Add(Me.lblBlocks)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblLives)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCPU6)
        Me.Controls.Add(Me.lblCPU5)
        Me.Controls.Add(Me.lblCPU4)
        Me.Controls.Add(Me.lblCpu3)
        Me.Controls.Add(Me.btnPlayer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSix)
        Me.Controls.Add(Me.lblFive)
        Me.Controls.Add(Me.lblFour)
        Me.Controls.Add(Me.lblTwo)
        Me.Controls.Add(Me.lblThree)
        Me.Controls.Add(Me.lblOne)
        Me.Controls.Add(Me.lstResults3)
        Me.Controls.Add(Me.lblGameTurn)
        Me.Controls.Add(Me.lblCPU2)
        Me.Controls.Add(Me.lblCPU1)
        Me.Controls.Add(Me.lstResults2)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.lstResults)
        Me.Name = "frmGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Russian Roulette"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBlock.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstResults As System.Windows.Forms.ListBox
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents btnPlayer_old As System.Windows.Forms.Button
    Friend WithEvents lblTurn As System.Windows.Forms.Label
    Friend WithEvents lstResults2 As System.Windows.Forms.ListBox
    Friend WithEvents lblShot As System.Windows.Forms.Label
    Friend WithEvents lblCPU1 As System.Windows.Forms.Label
    Friend WithEvents lblCPU2 As System.Windows.Forms.Label
    Friend WithEvents lblGameTurn As System.Windows.Forms.Label
    Friend WithEvents lstResults3 As System.Windows.Forms.ListBox
    Friend WithEvents lblOne As System.Windows.Forms.Label
    Friend WithEvents lblThree As System.Windows.Forms.Label
    Friend WithEvents lblTwo As System.Windows.Forms.Label
    Friend WithEvents lblFour As System.Windows.Forms.Label
    Friend WithEvents lblFive As System.Windows.Forms.Label
    Friend WithEvents lblSix As System.Windows.Forms.Label
    Friend WithEvents lstResults4 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPlayer As System.Windows.Forms.Button
    Friend WithEvents txtShuffle As System.Windows.Forms.TextBox
    Friend WithEvents btnFetch As System.Windows.Forms.Button
    Friend WithEvents lstResults5 As System.Windows.Forms.ListBox
    Friend WithEvents txtHappy As System.Windows.Forms.TextBox
    Friend WithEvents lblCpu3 As System.Windows.Forms.Label
    Friend WithEvents lblCPU4 As System.Windows.Forms.Label
    Friend WithEvents lblCPU5 As System.Windows.Forms.Label
    Friend WithEvents lblCPU6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblLives As System.Windows.Forms.Label
    Friend WithEvents btnBulletPosition As System.Windows.Forms.Button
    Friend WithEvents btnAddScore As System.Windows.Forms.Button
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents btnRedo As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblBlocks As System.Windows.Forms.Label
    Friend WithEvents gbBlock As System.Windows.Forms.GroupBox
    Friend WithEvents btnBlock As System.Windows.Forms.Button
    Friend WithEvents lblShield As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblRound As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents labelAI As System.Windows.Forms.Label
    Friend WithEvents lblAI As System.Windows.Forms.Label
    Friend WithEvents btnNewGame As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblRRName As System.Windows.Forms.Label
    Friend WithEvents btnMain As System.Windows.Forms.Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbYes As System.Windows.Forms.RadioButton
    Friend WithEvents lblCheatOrder As System.Windows.Forms.Label
    Friend WithEvents btnChamber As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
