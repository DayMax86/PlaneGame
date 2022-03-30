<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pbxPlane = New System.Windows.Forms.PictureBox()
        Me.pbxWater = New System.Windows.Forms.PictureBox()
        Me.Display = New System.Windows.Forms.PictureBox()
        Me.pbxBulletLvl1Up = New System.Windows.Forms.PictureBox()
        Me.GameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFPS = New System.Windows.Forms.Label()
        Me.pbxEnemyDown = New System.Windows.Forms.PictureBox()
        Me.SpawnTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblLife = New System.Windows.Forms.Label()
        Me.pbxEnemyUp = New System.Windows.Forms.PictureBox()
        Me.pbxEnemyRight = New System.Windows.Forms.PictureBox()
        Me.pbxEnemyLeft = New System.Windows.Forms.PictureBox()
        Me.pbxBulletLvl1Down = New System.Windows.Forms.PictureBox()
        Me.pbxBulletLvl1Left = New System.Windows.Forms.PictureBox()
        Me.pbxBulletLvl1Right = New System.Windows.Forms.PictureBox()
        Me.pbxHealthBar = New System.Windows.Forms.PictureBox()
        Me.RoundChangeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pbxRound = New System.Windows.Forms.PictureBox()
        Me.pbxEnemyLeftDamaged = New System.Windows.Forms.PictureBox()
        Me.pbxEnemyRightDamaged = New System.Windows.Forms.PictureBox()
        Me.pbxEnemyUpDamaged = New System.Windows.Forms.PictureBox()
        Me.pbxEnemyDownDamaged = New System.Windows.Forms.PictureBox()
        Me.pbxStrongEnemyDown = New System.Windows.Forms.PictureBox()
        Me.pbxStrongEnemyUp = New System.Windows.Forms.PictureBox()
        Me.pbxStrongEnemyLeft = New System.Windows.Forms.PictureBox()
        Me.pbxStrongEnemyRight = New System.Windows.Forms.PictureBox()
        Me.pbxStrongEnemyDownDamaged = New System.Windows.Forms.PictureBox()
        Me.pbxStrongEnemyUpDamaged = New System.Windows.Forms.PictureBox()
        Me.pbxStrongEnemyLeftDamaged = New System.Windows.Forms.PictureBox()
        Me.pbxStrongEnemyRightDamaged = New System.Windows.Forms.PictureBox()
        Me.pbxOne = New System.Windows.Forms.PictureBox()
        Me.pbxTwo = New System.Windows.Forms.PictureBox()
        Me.pbxThree = New System.Windows.Forms.PictureBox()
        Me.pbxFour = New System.Windows.Forms.PictureBox()
        Me.pbxFive = New System.Windows.Forms.PictureBox()
        Me.pbxSix = New System.Windows.Forms.PictureBox()
        Me.pbxSeven = New System.Windows.Forms.PictureBox()
        Me.pbxEight = New System.Windows.Forms.PictureBox()
        Me.pbxNine = New System.Windows.Forms.PictureBox()
        Me.pbxEnemyNW = New System.Windows.Forms.PictureBox()
        Me.pbxEnemyNE = New System.Windows.Forms.PictureBox()
        Me.pbxEnemySW = New System.Windows.Forms.PictureBox()
        Me.pbxEnemySE = New System.Windows.Forms.PictureBox()
        Me.pbxStrongEnemyNE = New System.Windows.Forms.PictureBox()
        Me.pbxStrongEnemyNW = New System.Windows.Forms.PictureBox()
        Me.pbxStrongEnemySE = New System.Windows.Forms.PictureBox()
        Me.pbxStrongEnemySW = New System.Windows.Forms.PictureBox()
        Me.pbxBulletLvl2Up = New System.Windows.Forms.PictureBox()
        Me.pbxBulletLvl2Right = New System.Windows.Forms.PictureBox()
        Me.pbxBulletLvl2Down = New System.Windows.Forms.PictureBox()
        Me.pbxBulletLvl2Left = New System.Windows.Forms.PictureBox()
        Me.pbxBulletLvl3Up = New System.Windows.Forms.PictureBox()
        Me.pbxBulletLvl3Right = New System.Windows.Forms.PictureBox()
        Me.pbxBulletLvl3Down = New System.Windows.Forms.PictureBox()
        Me.pbxBulletLvl3Left = New System.Windows.Forms.PictureBox()
        Me.pbxHealthUpgrade = New System.Windows.Forms.PictureBox()
        Me.pbxDamageUpgrade = New System.Windows.Forms.PictureBox()
        Me.pbxSpeedUpgrade = New System.Windows.Forms.PictureBox()
        Me.pbxFirerateUpgrade = New System.Windows.Forms.PictureBox()
        Me.pbxHealthDrop = New System.Windows.Forms.PictureBox()
        Me.pbxShieldDrop = New System.Windows.Forms.PictureBox()
        Me.pbxShieldBar = New System.Windows.Forms.PictureBox()
        Me.pbxShieldStealUpgrade = New System.Windows.Forms.PictureBox()
        Me.lblShield = New System.Windows.Forms.Label()
        Me.pbxEnemyMothership = New System.Windows.Forms.PictureBox()
        Me.EnemyAttackTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pbxBulletEnemyUp = New System.Windows.Forms.PictureBox()
        Me.pbxBulletEnemyDown = New System.Windows.Forms.PictureBox()
        Me.pbxBulletEnemyLeft = New System.Windows.Forms.PictureBox()
        Me.pbxBulletEnemyRight = New System.Windows.Forms.PictureBox()
        Me.AnimationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pbxAnimDeadEnemy8 = New System.Windows.Forms.PictureBox()
        Me.pbxAnimDeadEnemy7 = New System.Windows.Forms.PictureBox()
        Me.pbxAnimDeadEnemy6 = New System.Windows.Forms.PictureBox()
        Me.pbxAnimDeadEnemy5 = New System.Windows.Forms.PictureBox()
        Me.pbxAnimDeadEnemy1 = New System.Windows.Forms.PictureBox()
        Me.pbxAnimDeadEnemy4 = New System.Windows.Forms.PictureBox()
        Me.pbxAnimDeadEnemy3 = New System.Windows.Forms.PictureBox()
        Me.pbxAnimDeadEnemy2 = New System.Windows.Forms.PictureBox()
        Me.pbxAnimDeadMothership1 = New System.Windows.Forms.PictureBox()
        Me.pbxAnimDeadMothership2 = New System.Windows.Forms.PictureBox()
        Me.pbxAnimDeadMothership3 = New System.Windows.Forms.PictureBox()
        Me.pbxAnimDeadMothership4 = New System.Windows.Forms.PictureBox()
        Me.pbxAnimDeadMothership5 = New System.Windows.Forms.PictureBox()
        Me.pbxAnimDeadMothership6 = New System.Windows.Forms.PictureBox()
        Me.pbxAnimDeadMothership7 = New System.Windows.Forms.PictureBox()
        Me.pbxAnimDeadMothership8 = New System.Windows.Forms.PictureBox()
        Me.pbxEnemyShooterUp = New System.Windows.Forms.PictureBox()
        Me.pbxEnemyShooterDown = New System.Windows.Forms.PictureBox()
        Me.pbxEnemyShooterLeft = New System.Windows.Forms.PictureBox()
        Me.pbxEnemyShooterRight = New System.Windows.Forms.PictureBox()
        Me.pbxEnemyShooterNW = New System.Windows.Forms.PictureBox()
        Me.pbxEnemyShooterNE = New System.Windows.Forms.PictureBox()
        Me.pbxEnemyShooterSE = New System.Windows.Forms.PictureBox()
        Me.pbxEnemyShooterSW = New System.Windows.Forms.PictureBox()
        Me.pbxRingShotUpgrade = New System.Windows.Forms.PictureBox()
        Me.pbxDiagonalShotUpgrade = New System.Windows.Forms.PictureBox()
        Me.pbxRingBullet = New System.Windows.Forms.PictureBox()
        Me.pbxBulletNE = New System.Windows.Forms.PictureBox()
        Me.pbxBulletNW = New System.Windows.Forms.PictureBox()
        Me.pbxBulletSE = New System.Windows.Forms.PictureBox()
        Me.pbxBulletSW = New System.Windows.Forms.PictureBox()
        Me.pbxCollectedUpgrades = New System.Windows.Forms.PictureBox()
        Me.pbxZigZagUpgrade = New System.Windows.Forms.PictureBox()
        Me.pbxGreenPlane = New System.Windows.Forms.PictureBox()
        Me.pbxRepairsUpgrade = New System.Windows.Forms.PictureBox()
        Me.pbxEnemyKamikazeUp = New System.Windows.Forms.PictureBox()
        Me.pbxEnemyKamikazeRight = New System.Windows.Forms.PictureBox()
        Me.pbxEnemyKamikazeDown = New System.Windows.Forms.PictureBox()
        Me.pbxEnemyKamikazeLeft = New System.Windows.Forms.PictureBox()
        Me.pbxEnemyKamikazeNW = New System.Windows.Forms.PictureBox()
        Me.pbxEnemyKamikazeNE = New System.Windows.Forms.PictureBox()
        Me.pbxEnemyKamikazeSE = New System.Windows.Forms.PictureBox()
        Me.pbxEnemyKamikazeSW = New System.Windows.Forms.PictureBox()
        Me.pbxSplitShotUpgrade = New System.Windows.Forms.PictureBox()
        Me.pbxZero = New System.Windows.Forms.PictureBox()
        Me.pbxSlothUpgrade = New System.Windows.Forms.PictureBox()
        Me.ActiveItemTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pbxAnimTimerFrame1 = New System.Windows.Forms.PictureBox()
        Me.pbxAnimTimerFrame2 = New System.Windows.Forms.PictureBox()
        Me.pbxAnimTimerFrame3 = New System.Windows.Forms.PictureBox()
        Me.pbxAnimTimerFrame4 = New System.Windows.Forms.PictureBox()
        Me.pbxAnimTimerFrame5 = New System.Windows.Forms.PictureBox()
        Me.pbxAnimTimerFrame6 = New System.Windows.Forms.PictureBox()
        Me.pbxAnimTimerFrame7 = New System.Windows.Forms.PictureBox()
        Me.pbxAnimTimerFrame8 = New System.Windows.Forms.PictureBox()
        Me.TimerTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbxPlane, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxWater, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Display, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBulletLvl1Up, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemyDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemyUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemyRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemyLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBulletLvl1Down, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBulletLvl1Left, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBulletLvl1Right, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxHealthBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxRound, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemyLeftDamaged, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemyRightDamaged, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemyUpDamaged, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemyDownDamaged, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStrongEnemyDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStrongEnemyUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStrongEnemyLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStrongEnemyRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStrongEnemyDownDamaged, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStrongEnemyUpDamaged, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStrongEnemyLeftDamaged, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStrongEnemyRightDamaged, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxFour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxFive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSeven, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxNine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemyNW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemyNE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemySW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemySE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStrongEnemyNE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStrongEnemyNW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStrongEnemySE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStrongEnemySW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBulletLvl2Up, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBulletLvl2Right, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBulletLvl2Down, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBulletLvl2Left, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBulletLvl3Up, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBulletLvl3Right, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBulletLvl3Down, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBulletLvl3Left, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxHealthUpgrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDamageUpgrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSpeedUpgrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxFirerateUpgrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxHealthDrop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxShieldDrop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxShieldBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxShieldStealUpgrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemyMothership, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBulletEnemyUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBulletEnemyDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBulletEnemyLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBulletEnemyRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAnimDeadEnemy8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAnimDeadEnemy7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAnimDeadEnemy6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAnimDeadEnemy5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAnimDeadEnemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAnimDeadEnemy4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAnimDeadEnemy3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAnimDeadEnemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAnimDeadMothership1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAnimDeadMothership2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAnimDeadMothership3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAnimDeadMothership4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAnimDeadMothership5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAnimDeadMothership6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAnimDeadMothership7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAnimDeadMothership8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemyShooterUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemyShooterDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemyShooterLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemyShooterRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemyShooterNW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemyShooterNE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemyShooterSE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemyShooterSW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxRingShotUpgrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDiagonalShotUpgrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxRingBullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBulletNE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBulletNW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBulletSE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBulletSW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCollectedUpgrades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxZigZagUpgrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxGreenPlane, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxRepairsUpgrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemyKamikazeUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemyKamikazeRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemyKamikazeDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemyKamikazeLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemyKamikazeNW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemyKamikazeNE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemyKamikazeSE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEnemyKamikazeSW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSplitShotUpgrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxZero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSlothUpgrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAnimTimerFrame1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAnimTimerFrame2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAnimTimerFrame3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAnimTimerFrame4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAnimTimerFrame5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAnimTimerFrame6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAnimTimerFrame7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAnimTimerFrame8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxPlane
        '
        Me.pbxPlane.Image = CType(resources.GetObject("pbxPlane.Image"), System.Drawing.Image)
        Me.pbxPlane.Location = New System.Drawing.Point(1632, 12)
        Me.pbxPlane.Name = "pbxPlane"
        Me.pbxPlane.Size = New System.Drawing.Size(32, 32)
        Me.pbxPlane.TabIndex = 0
        Me.pbxPlane.TabStop = False
        Me.pbxPlane.Visible = False
        '
        'pbxWater
        '
        Me.pbxWater.Image = CType(resources.GetObject("pbxWater.Image"), System.Drawing.Image)
        Me.pbxWater.Location = New System.Drawing.Point(1632, 50)
        Me.pbxWater.Name = "pbxWater"
        Me.pbxWater.Size = New System.Drawing.Size(32, 32)
        Me.pbxWater.TabIndex = 1
        Me.pbxWater.TabStop = False
        Me.pbxWater.Visible = False
        '
        'Display
        '
        Me.Display.BackColor = System.Drawing.Color.Red
        Me.Display.Location = New System.Drawing.Point(12, 12)
        Me.Display.Name = "Display"
        Me.Display.Size = New System.Drawing.Size(1280, 720)
        Me.Display.TabIndex = 2
        Me.Display.TabStop = False
        '
        'pbxBulletLvl1Up
        '
        Me.pbxBulletLvl1Up.Image = CType(resources.GetObject("pbxBulletLvl1Up.Image"), System.Drawing.Image)
        Me.pbxBulletLvl1Up.Location = New System.Drawing.Point(1632, 88)
        Me.pbxBulletLvl1Up.Name = "pbxBulletLvl1Up"
        Me.pbxBulletLvl1Up.Size = New System.Drawing.Size(3, 12)
        Me.pbxBulletLvl1Up.TabIndex = 3
        Me.pbxBulletLvl1Up.TabStop = False
        Me.pbxBulletLvl1Up.Tag = "Up"
        Me.pbxBulletLvl1Up.Visible = False
        '
        'GameTimer
        '
        Me.GameTimer.Interval = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1298, 719)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "0"
        '
        'lblFPS
        '
        Me.lblFPS.AutoSize = True
        Me.lblFPS.Location = New System.Drawing.Point(1298, 12)
        Me.lblFPS.Name = "lblFPS"
        Me.lblFPS.Size = New System.Drawing.Size(36, 13)
        Me.lblFPS.TabIndex = 5
        Me.lblFPS.Text = "FPS : "
        '
        'pbxEnemyDown
        '
        Me.pbxEnemyDown.Image = CType(resources.GetObject("pbxEnemyDown.Image"), System.Drawing.Image)
        Me.pbxEnemyDown.Location = New System.Drawing.Point(1632, 126)
        Me.pbxEnemyDown.Name = "pbxEnemyDown"
        Me.pbxEnemyDown.Size = New System.Drawing.Size(32, 32)
        Me.pbxEnemyDown.TabIndex = 6
        Me.pbxEnemyDown.TabStop = False
        Me.pbxEnemyDown.Visible = False
        '
        'SpawnTimer
        '
        Me.SpawnTimer.Enabled = True
        Me.SpawnTimer.Interval = 750
        '
        'lblLife
        '
        Me.lblLife.AutoSize = True
        Me.lblLife.Location = New System.Drawing.Point(1298, 31)
        Me.lblLife.Name = "lblLife"
        Me.lblLife.Size = New System.Drawing.Size(45, 13)
        Me.lblLife.TabIndex = 7
        Me.lblLife.Text = "Life : 10"
        '
        'pbxEnemyUp
        '
        Me.pbxEnemyUp.Image = CType(resources.GetObject("pbxEnemyUp.Image"), System.Drawing.Image)
        Me.pbxEnemyUp.Location = New System.Drawing.Point(1594, 126)
        Me.pbxEnemyUp.Name = "pbxEnemyUp"
        Me.pbxEnemyUp.Size = New System.Drawing.Size(32, 32)
        Me.pbxEnemyUp.TabIndex = 11
        Me.pbxEnemyUp.TabStop = False
        Me.pbxEnemyUp.Visible = False
        '
        'pbxEnemyRight
        '
        Me.pbxEnemyRight.Image = CType(resources.GetObject("pbxEnemyRight.Image"), System.Drawing.Image)
        Me.pbxEnemyRight.Location = New System.Drawing.Point(1556, 126)
        Me.pbxEnemyRight.Name = "pbxEnemyRight"
        Me.pbxEnemyRight.Size = New System.Drawing.Size(32, 32)
        Me.pbxEnemyRight.TabIndex = 12
        Me.pbxEnemyRight.TabStop = False
        Me.pbxEnemyRight.Visible = False
        '
        'pbxEnemyLeft
        '
        Me.pbxEnemyLeft.Image = CType(resources.GetObject("pbxEnemyLeft.Image"), System.Drawing.Image)
        Me.pbxEnemyLeft.Location = New System.Drawing.Point(1518, 126)
        Me.pbxEnemyLeft.Name = "pbxEnemyLeft"
        Me.pbxEnemyLeft.Size = New System.Drawing.Size(32, 32)
        Me.pbxEnemyLeft.TabIndex = 13
        Me.pbxEnemyLeft.TabStop = False
        Me.pbxEnemyLeft.Visible = False
        '
        'pbxBulletLvl1Down
        '
        Me.pbxBulletLvl1Down.Image = CType(resources.GetObject("pbxBulletLvl1Down.Image"), System.Drawing.Image)
        Me.pbxBulletLvl1Down.Location = New System.Drawing.Point(1594, 88)
        Me.pbxBulletLvl1Down.Name = "pbxBulletLvl1Down"
        Me.pbxBulletLvl1Down.Size = New System.Drawing.Size(3, 12)
        Me.pbxBulletLvl1Down.TabIndex = 14
        Me.pbxBulletLvl1Down.TabStop = False
        Me.pbxBulletLvl1Down.Tag = "Down"
        Me.pbxBulletLvl1Down.Visible = False
        '
        'pbxBulletLvl1Left
        '
        Me.pbxBulletLvl1Left.Image = CType(resources.GetObject("pbxBulletLvl1Left.Image"), System.Drawing.Image)
        Me.pbxBulletLvl1Left.Location = New System.Drawing.Point(1556, 88)
        Me.pbxBulletLvl1Left.Name = "pbxBulletLvl1Left"
        Me.pbxBulletLvl1Left.Size = New System.Drawing.Size(12, 3)
        Me.pbxBulletLvl1Left.TabIndex = 15
        Me.pbxBulletLvl1Left.TabStop = False
        Me.pbxBulletLvl1Left.Tag = "Left"
        Me.pbxBulletLvl1Left.Visible = False
        '
        'pbxBulletLvl1Right
        '
        Me.pbxBulletLvl1Right.Image = CType(resources.GetObject("pbxBulletLvl1Right.Image"), System.Drawing.Image)
        Me.pbxBulletLvl1Right.Location = New System.Drawing.Point(1518, 88)
        Me.pbxBulletLvl1Right.Name = "pbxBulletLvl1Right"
        Me.pbxBulletLvl1Right.Size = New System.Drawing.Size(12, 3)
        Me.pbxBulletLvl1Right.TabIndex = 16
        Me.pbxBulletLvl1Right.TabStop = False
        Me.pbxBulletLvl1Right.Tag = "Right"
        Me.pbxBulletLvl1Right.Visible = False
        '
        'pbxHealthBar
        '
        Me.pbxHealthBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxHealthBar.Location = New System.Drawing.Point(17, 17)
        Me.pbxHealthBar.Name = "pbxHealthBar"
        Me.pbxHealthBar.Size = New System.Drawing.Size(100, 10)
        Me.pbxHealthBar.TabIndex = 17
        Me.pbxHealthBar.TabStop = False
        '
        'RoundChangeTimer
        '
        Me.RoundChangeTimer.Interval = 1
        '
        'pbxRound
        '
        Me.pbxRound.Image = CType(resources.GetObject("pbxRound.Image"), System.Drawing.Image)
        Me.pbxRound.Location = New System.Drawing.Point(1464, 350)
        Me.pbxRound.Name = "pbxRound"
        Me.pbxRound.Size = New System.Drawing.Size(200, 100)
        Me.pbxRound.TabIndex = 18
        Me.pbxRound.TabStop = False
        Me.pbxRound.Visible = False
        '
        'pbxEnemyLeftDamaged
        '
        Me.pbxEnemyLeftDamaged.Image = CType(resources.GetObject("pbxEnemyLeftDamaged.Image"), System.Drawing.Image)
        Me.pbxEnemyLeftDamaged.Location = New System.Drawing.Point(1632, 163)
        Me.pbxEnemyLeftDamaged.Name = "pbxEnemyLeftDamaged"
        Me.pbxEnemyLeftDamaged.Size = New System.Drawing.Size(32, 32)
        Me.pbxEnemyLeftDamaged.TabIndex = 19
        Me.pbxEnemyLeftDamaged.TabStop = False
        Me.pbxEnemyLeftDamaged.Visible = False
        '
        'pbxEnemyRightDamaged
        '
        Me.pbxEnemyRightDamaged.Image = CType(resources.GetObject("pbxEnemyRightDamaged.Image"), System.Drawing.Image)
        Me.pbxEnemyRightDamaged.Location = New System.Drawing.Point(1632, 201)
        Me.pbxEnemyRightDamaged.Name = "pbxEnemyRightDamaged"
        Me.pbxEnemyRightDamaged.Size = New System.Drawing.Size(32, 32)
        Me.pbxEnemyRightDamaged.TabIndex = 20
        Me.pbxEnemyRightDamaged.TabStop = False
        Me.pbxEnemyRightDamaged.Visible = False
        '
        'pbxEnemyUpDamaged
        '
        Me.pbxEnemyUpDamaged.Image = CType(resources.GetObject("pbxEnemyUpDamaged.Image"), System.Drawing.Image)
        Me.pbxEnemyUpDamaged.Location = New System.Drawing.Point(1632, 239)
        Me.pbxEnemyUpDamaged.Name = "pbxEnemyUpDamaged"
        Me.pbxEnemyUpDamaged.Size = New System.Drawing.Size(32, 32)
        Me.pbxEnemyUpDamaged.TabIndex = 21
        Me.pbxEnemyUpDamaged.TabStop = False
        Me.pbxEnemyUpDamaged.Visible = False
        '
        'pbxEnemyDownDamaged
        '
        Me.pbxEnemyDownDamaged.Image = CType(resources.GetObject("pbxEnemyDownDamaged.Image"), System.Drawing.Image)
        Me.pbxEnemyDownDamaged.Location = New System.Drawing.Point(1632, 277)
        Me.pbxEnemyDownDamaged.Name = "pbxEnemyDownDamaged"
        Me.pbxEnemyDownDamaged.Size = New System.Drawing.Size(32, 32)
        Me.pbxEnemyDownDamaged.TabIndex = 22
        Me.pbxEnemyDownDamaged.TabStop = False
        Me.pbxEnemyDownDamaged.Visible = False
        '
        'pbxStrongEnemyDown
        '
        Me.pbxStrongEnemyDown.Image = CType(resources.GetObject("pbxStrongEnemyDown.Image"), System.Drawing.Image)
        Me.pbxStrongEnemyDown.Location = New System.Drawing.Point(1594, 163)
        Me.pbxStrongEnemyDown.Name = "pbxStrongEnemyDown"
        Me.pbxStrongEnemyDown.Size = New System.Drawing.Size(32, 32)
        Me.pbxStrongEnemyDown.TabIndex = 23
        Me.pbxStrongEnemyDown.TabStop = False
        Me.pbxStrongEnemyDown.Visible = False
        '
        'pbxStrongEnemyUp
        '
        Me.pbxStrongEnemyUp.Image = CType(resources.GetObject("pbxStrongEnemyUp.Image"), System.Drawing.Image)
        Me.pbxStrongEnemyUp.Location = New System.Drawing.Point(1594, 201)
        Me.pbxStrongEnemyUp.Name = "pbxStrongEnemyUp"
        Me.pbxStrongEnemyUp.Size = New System.Drawing.Size(32, 32)
        Me.pbxStrongEnemyUp.TabIndex = 24
        Me.pbxStrongEnemyUp.TabStop = False
        Me.pbxStrongEnemyUp.Visible = False
        '
        'pbxStrongEnemyLeft
        '
        Me.pbxStrongEnemyLeft.Image = CType(resources.GetObject("pbxStrongEnemyLeft.Image"), System.Drawing.Image)
        Me.pbxStrongEnemyLeft.Location = New System.Drawing.Point(1594, 239)
        Me.pbxStrongEnemyLeft.Name = "pbxStrongEnemyLeft"
        Me.pbxStrongEnemyLeft.Size = New System.Drawing.Size(32, 32)
        Me.pbxStrongEnemyLeft.TabIndex = 25
        Me.pbxStrongEnemyLeft.TabStop = False
        Me.pbxStrongEnemyLeft.Visible = False
        '
        'pbxStrongEnemyRight
        '
        Me.pbxStrongEnemyRight.Image = CType(resources.GetObject("pbxStrongEnemyRight.Image"), System.Drawing.Image)
        Me.pbxStrongEnemyRight.Location = New System.Drawing.Point(1594, 277)
        Me.pbxStrongEnemyRight.Name = "pbxStrongEnemyRight"
        Me.pbxStrongEnemyRight.Size = New System.Drawing.Size(32, 32)
        Me.pbxStrongEnemyRight.TabIndex = 26
        Me.pbxStrongEnemyRight.TabStop = False
        Me.pbxStrongEnemyRight.Visible = False
        '
        'pbxStrongEnemyDownDamaged
        '
        Me.pbxStrongEnemyDownDamaged.Image = CType(resources.GetObject("pbxStrongEnemyDownDamaged.Image"), System.Drawing.Image)
        Me.pbxStrongEnemyDownDamaged.Location = New System.Drawing.Point(1556, 163)
        Me.pbxStrongEnemyDownDamaged.Name = "pbxStrongEnemyDownDamaged"
        Me.pbxStrongEnemyDownDamaged.Size = New System.Drawing.Size(32, 32)
        Me.pbxStrongEnemyDownDamaged.TabIndex = 27
        Me.pbxStrongEnemyDownDamaged.TabStop = False
        Me.pbxStrongEnemyDownDamaged.Visible = False
        '
        'pbxStrongEnemyUpDamaged
        '
        Me.pbxStrongEnemyUpDamaged.Image = CType(resources.GetObject("pbxStrongEnemyUpDamaged.Image"), System.Drawing.Image)
        Me.pbxStrongEnemyUpDamaged.Location = New System.Drawing.Point(1556, 201)
        Me.pbxStrongEnemyUpDamaged.Name = "pbxStrongEnemyUpDamaged"
        Me.pbxStrongEnemyUpDamaged.Size = New System.Drawing.Size(32, 32)
        Me.pbxStrongEnemyUpDamaged.TabIndex = 28
        Me.pbxStrongEnemyUpDamaged.TabStop = False
        Me.pbxStrongEnemyUpDamaged.Visible = False
        '
        'pbxStrongEnemyLeftDamaged
        '
        Me.pbxStrongEnemyLeftDamaged.Image = CType(resources.GetObject("pbxStrongEnemyLeftDamaged.Image"), System.Drawing.Image)
        Me.pbxStrongEnemyLeftDamaged.Location = New System.Drawing.Point(1556, 239)
        Me.pbxStrongEnemyLeftDamaged.Name = "pbxStrongEnemyLeftDamaged"
        Me.pbxStrongEnemyLeftDamaged.Size = New System.Drawing.Size(32, 32)
        Me.pbxStrongEnemyLeftDamaged.TabIndex = 29
        Me.pbxStrongEnemyLeftDamaged.TabStop = False
        Me.pbxStrongEnemyLeftDamaged.Visible = False
        '
        'pbxStrongEnemyRightDamaged
        '
        Me.pbxStrongEnemyRightDamaged.Image = CType(resources.GetObject("pbxStrongEnemyRightDamaged.Image"), System.Drawing.Image)
        Me.pbxStrongEnemyRightDamaged.Location = New System.Drawing.Point(1556, 277)
        Me.pbxStrongEnemyRightDamaged.Name = "pbxStrongEnemyRightDamaged"
        Me.pbxStrongEnemyRightDamaged.Size = New System.Drawing.Size(32, 32)
        Me.pbxStrongEnemyRightDamaged.TabIndex = 30
        Me.pbxStrongEnemyRightDamaged.TabStop = False
        Me.pbxStrongEnemyRightDamaged.Visible = False
        '
        'pbxOne
        '
        Me.pbxOne.Image = CType(resources.GetObject("pbxOne.Image"), System.Drawing.Image)
        Me.pbxOne.Location = New System.Drawing.Point(1396, 458)
        Me.pbxOne.Name = "pbxOne"
        Me.pbxOne.Size = New System.Drawing.Size(80, 100)
        Me.pbxOne.TabIndex = 31
        Me.pbxOne.TabStop = False
        Me.pbxOne.Visible = False
        '
        'pbxTwo
        '
        Me.pbxTwo.Image = CType(resources.GetObject("pbxTwo.Image"), System.Drawing.Image)
        Me.pbxTwo.Location = New System.Drawing.Point(1489, 458)
        Me.pbxTwo.Name = "pbxTwo"
        Me.pbxTwo.Size = New System.Drawing.Size(80, 100)
        Me.pbxTwo.TabIndex = 32
        Me.pbxTwo.TabStop = False
        Me.pbxTwo.Visible = False
        '
        'pbxThree
        '
        Me.pbxThree.Image = CType(resources.GetObject("pbxThree.Image"), System.Drawing.Image)
        Me.pbxThree.Location = New System.Drawing.Point(1584, 458)
        Me.pbxThree.Name = "pbxThree"
        Me.pbxThree.Size = New System.Drawing.Size(80, 100)
        Me.pbxThree.TabIndex = 33
        Me.pbxThree.TabStop = False
        Me.pbxThree.Visible = False
        '
        'pbxFour
        '
        Me.pbxFour.Image = CType(resources.GetObject("pbxFour.Image"), System.Drawing.Image)
        Me.pbxFour.Location = New System.Drawing.Point(1396, 564)
        Me.pbxFour.Name = "pbxFour"
        Me.pbxFour.Size = New System.Drawing.Size(80, 100)
        Me.pbxFour.TabIndex = 34
        Me.pbxFour.TabStop = False
        Me.pbxFour.Visible = False
        '
        'pbxFive
        '
        Me.pbxFive.Image = CType(resources.GetObject("pbxFive.Image"), System.Drawing.Image)
        Me.pbxFive.Location = New System.Drawing.Point(1489, 564)
        Me.pbxFive.Name = "pbxFive"
        Me.pbxFive.Size = New System.Drawing.Size(80, 100)
        Me.pbxFive.TabIndex = 35
        Me.pbxFive.TabStop = False
        Me.pbxFive.Visible = False
        '
        'pbxSix
        '
        Me.pbxSix.Image = CType(resources.GetObject("pbxSix.Image"), System.Drawing.Image)
        Me.pbxSix.Location = New System.Drawing.Point(1584, 564)
        Me.pbxSix.Name = "pbxSix"
        Me.pbxSix.Size = New System.Drawing.Size(80, 100)
        Me.pbxSix.TabIndex = 36
        Me.pbxSix.TabStop = False
        Me.pbxSix.Visible = False
        '
        'pbxSeven
        '
        Me.pbxSeven.Image = CType(resources.GetObject("pbxSeven.Image"), System.Drawing.Image)
        Me.pbxSeven.Location = New System.Drawing.Point(1396, 670)
        Me.pbxSeven.Name = "pbxSeven"
        Me.pbxSeven.Size = New System.Drawing.Size(80, 100)
        Me.pbxSeven.TabIndex = 37
        Me.pbxSeven.TabStop = False
        Me.pbxSeven.Visible = False
        '
        'pbxEight
        '
        Me.pbxEight.Image = CType(resources.GetObject("pbxEight.Image"), System.Drawing.Image)
        Me.pbxEight.Location = New System.Drawing.Point(1489, 670)
        Me.pbxEight.Name = "pbxEight"
        Me.pbxEight.Size = New System.Drawing.Size(80, 100)
        Me.pbxEight.TabIndex = 38
        Me.pbxEight.TabStop = False
        Me.pbxEight.Visible = False
        '
        'pbxNine
        '
        Me.pbxNine.Image = CType(resources.GetObject("pbxNine.Image"), System.Drawing.Image)
        Me.pbxNine.Location = New System.Drawing.Point(1584, 670)
        Me.pbxNine.Name = "pbxNine"
        Me.pbxNine.Size = New System.Drawing.Size(80, 100)
        Me.pbxNine.TabIndex = 39
        Me.pbxNine.TabStop = False
        Me.pbxNine.Visible = False
        '
        'pbxEnemyNW
        '
        Me.pbxEnemyNW.Image = CType(resources.GetObject("pbxEnemyNW.Image"), System.Drawing.Image)
        Me.pbxEnemyNW.Location = New System.Drawing.Point(1480, 88)
        Me.pbxEnemyNW.Name = "pbxEnemyNW"
        Me.pbxEnemyNW.Size = New System.Drawing.Size(32, 32)
        Me.pbxEnemyNW.TabIndex = 40
        Me.pbxEnemyNW.TabStop = False
        Me.pbxEnemyNW.Visible = False
        '
        'pbxEnemyNE
        '
        Me.pbxEnemyNE.Image = CType(resources.GetObject("pbxEnemyNE.Image"), System.Drawing.Image)
        Me.pbxEnemyNE.Location = New System.Drawing.Point(1480, 126)
        Me.pbxEnemyNE.Name = "pbxEnemyNE"
        Me.pbxEnemyNE.Size = New System.Drawing.Size(32, 32)
        Me.pbxEnemyNE.TabIndex = 41
        Me.pbxEnemyNE.TabStop = False
        Me.pbxEnemyNE.Visible = False
        '
        'pbxEnemySW
        '
        Me.pbxEnemySW.Image = CType(resources.GetObject("pbxEnemySW.Image"), System.Drawing.Image)
        Me.pbxEnemySW.Location = New System.Drawing.Point(1444, 88)
        Me.pbxEnemySW.Name = "pbxEnemySW"
        Me.pbxEnemySW.Size = New System.Drawing.Size(32, 32)
        Me.pbxEnemySW.TabIndex = 42
        Me.pbxEnemySW.TabStop = False
        Me.pbxEnemySW.Visible = False
        '
        'pbxEnemySE
        '
        Me.pbxEnemySE.Image = CType(resources.GetObject("pbxEnemySE.Image"), System.Drawing.Image)
        Me.pbxEnemySE.Location = New System.Drawing.Point(1444, 126)
        Me.pbxEnemySE.Name = "pbxEnemySE"
        Me.pbxEnemySE.Size = New System.Drawing.Size(32, 32)
        Me.pbxEnemySE.TabIndex = 43
        Me.pbxEnemySE.TabStop = False
        Me.pbxEnemySE.Visible = False
        '
        'pbxStrongEnemyNE
        '
        Me.pbxStrongEnemyNE.Image = CType(resources.GetObject("pbxStrongEnemyNE.Image"), System.Drawing.Image)
        Me.pbxStrongEnemyNE.Location = New System.Drawing.Point(1520, 163)
        Me.pbxStrongEnemyNE.Name = "pbxStrongEnemyNE"
        Me.pbxStrongEnemyNE.Size = New System.Drawing.Size(32, 32)
        Me.pbxStrongEnemyNE.TabIndex = 44
        Me.pbxStrongEnemyNE.TabStop = False
        Me.pbxStrongEnemyNE.Visible = False
        '
        'pbxStrongEnemyNW
        '
        Me.pbxStrongEnemyNW.Image = CType(resources.GetObject("pbxStrongEnemyNW.Image"), System.Drawing.Image)
        Me.pbxStrongEnemyNW.Location = New System.Drawing.Point(1520, 201)
        Me.pbxStrongEnemyNW.Name = "pbxStrongEnemyNW"
        Me.pbxStrongEnemyNW.Size = New System.Drawing.Size(32, 32)
        Me.pbxStrongEnemyNW.TabIndex = 45
        Me.pbxStrongEnemyNW.TabStop = False
        Me.pbxStrongEnemyNW.Visible = False
        '
        'pbxStrongEnemySE
        '
        Me.pbxStrongEnemySE.Image = CType(resources.GetObject("pbxStrongEnemySE.Image"), System.Drawing.Image)
        Me.pbxStrongEnemySE.Location = New System.Drawing.Point(1520, 239)
        Me.pbxStrongEnemySE.Name = "pbxStrongEnemySE"
        Me.pbxStrongEnemySE.Size = New System.Drawing.Size(32, 32)
        Me.pbxStrongEnemySE.TabIndex = 46
        Me.pbxStrongEnemySE.TabStop = False
        Me.pbxStrongEnemySE.Visible = False
        '
        'pbxStrongEnemySW
        '
        Me.pbxStrongEnemySW.Image = CType(resources.GetObject("pbxStrongEnemySW.Image"), System.Drawing.Image)
        Me.pbxStrongEnemySW.Location = New System.Drawing.Point(1520, 277)
        Me.pbxStrongEnemySW.Name = "pbxStrongEnemySW"
        Me.pbxStrongEnemySW.Size = New System.Drawing.Size(32, 32)
        Me.pbxStrongEnemySW.TabIndex = 47
        Me.pbxStrongEnemySW.TabStop = False
        Me.pbxStrongEnemySW.Visible = False
        '
        'pbxBulletLvl2Up
        '
        Me.pbxBulletLvl2Up.Image = CType(resources.GetObject("pbxBulletLvl2Up.Image"), System.Drawing.Image)
        Me.pbxBulletLvl2Up.Location = New System.Drawing.Point(1423, 859)
        Me.pbxBulletLvl2Up.Name = "pbxBulletLvl2Up"
        Me.pbxBulletLvl2Up.Size = New System.Drawing.Size(5, 12)
        Me.pbxBulletLvl2Up.TabIndex = 48
        Me.pbxBulletLvl2Up.TabStop = False
        Me.pbxBulletLvl2Up.Tag = "Up"
        Me.pbxBulletLvl2Up.Visible = False
        '
        'pbxBulletLvl2Right
        '
        Me.pbxBulletLvl2Right.Image = CType(resources.GetObject("pbxBulletLvl2Right.Image"), System.Drawing.Image)
        Me.pbxBulletLvl2Right.Location = New System.Drawing.Point(1396, 876)
        Me.pbxBulletLvl2Right.Name = "pbxBulletLvl2Right"
        Me.pbxBulletLvl2Right.Size = New System.Drawing.Size(12, 5)
        Me.pbxBulletLvl2Right.TabIndex = 49
        Me.pbxBulletLvl2Right.TabStop = False
        Me.pbxBulletLvl2Right.Tag = "Up"
        Me.pbxBulletLvl2Right.Visible = False
        '
        'pbxBulletLvl2Down
        '
        Me.pbxBulletLvl2Down.Image = CType(resources.GetObject("pbxBulletLvl2Down.Image"), System.Drawing.Image)
        Me.pbxBulletLvl2Down.Location = New System.Drawing.Point(1423, 844)
        Me.pbxBulletLvl2Down.Name = "pbxBulletLvl2Down"
        Me.pbxBulletLvl2Down.Size = New System.Drawing.Size(5, 12)
        Me.pbxBulletLvl2Down.TabIndex = 50
        Me.pbxBulletLvl2Down.TabStop = False
        Me.pbxBulletLvl2Down.Tag = "Up"
        Me.pbxBulletLvl2Down.Visible = False
        '
        'pbxBulletLvl2Left
        '
        Me.pbxBulletLvl2Left.Image = CType(resources.GetObject("pbxBulletLvl2Left.Image"), System.Drawing.Image)
        Me.pbxBulletLvl2Left.Location = New System.Drawing.Point(1414, 877)
        Me.pbxBulletLvl2Left.Name = "pbxBulletLvl2Left"
        Me.pbxBulletLvl2Left.Size = New System.Drawing.Size(12, 5)
        Me.pbxBulletLvl2Left.TabIndex = 51
        Me.pbxBulletLvl2Left.TabStop = False
        Me.pbxBulletLvl2Left.Tag = "Up"
        Me.pbxBulletLvl2Left.Visible = False
        '
        'pbxBulletLvl3Up
        '
        Me.pbxBulletLvl3Up.Image = CType(resources.GetObject("pbxBulletLvl3Up.Image"), System.Drawing.Image)
        Me.pbxBulletLvl3Up.Location = New System.Drawing.Point(1404, 826)
        Me.pbxBulletLvl3Up.Name = "pbxBulletLvl3Up"
        Me.pbxBulletLvl3Up.Size = New System.Drawing.Size(9, 15)
        Me.pbxBulletLvl3Up.TabIndex = 52
        Me.pbxBulletLvl3Up.TabStop = False
        Me.pbxBulletLvl3Up.Tag = "Up"
        Me.pbxBulletLvl3Up.Visible = False
        '
        'pbxBulletLvl3Right
        '
        Me.pbxBulletLvl3Right.Image = CType(resources.GetObject("pbxBulletLvl3Right.Image"), System.Drawing.Image)
        Me.pbxBulletLvl3Right.Location = New System.Drawing.Point(1404, 847)
        Me.pbxBulletLvl3Right.Name = "pbxBulletLvl3Right"
        Me.pbxBulletLvl3Right.Size = New System.Drawing.Size(15, 9)
        Me.pbxBulletLvl3Right.TabIndex = 53
        Me.pbxBulletLvl3Right.TabStop = False
        Me.pbxBulletLvl3Right.Tag = "Up"
        Me.pbxBulletLvl3Right.Visible = False
        '
        'pbxBulletLvl3Down
        '
        Me.pbxBulletLvl3Down.Image = CType(resources.GetObject("pbxBulletLvl3Down.Image"), System.Drawing.Image)
        Me.pbxBulletLvl3Down.Location = New System.Drawing.Point(1419, 826)
        Me.pbxBulletLvl3Down.Name = "pbxBulletLvl3Down"
        Me.pbxBulletLvl3Down.Size = New System.Drawing.Size(9, 15)
        Me.pbxBulletLvl3Down.TabIndex = 54
        Me.pbxBulletLvl3Down.TabStop = False
        Me.pbxBulletLvl3Down.Tag = "Up"
        Me.pbxBulletLvl3Down.Visible = False
        '
        'pbxBulletLvl3Left
        '
        Me.pbxBulletLvl3Left.Image = CType(resources.GetObject("pbxBulletLvl3Left.Image"), System.Drawing.Image)
        Me.pbxBulletLvl3Left.Location = New System.Drawing.Point(1404, 862)
        Me.pbxBulletLvl3Left.Name = "pbxBulletLvl3Left"
        Me.pbxBulletLvl3Left.Size = New System.Drawing.Size(15, 9)
        Me.pbxBulletLvl3Left.TabIndex = 55
        Me.pbxBulletLvl3Left.TabStop = False
        Me.pbxBulletLvl3Left.Tag = "Up"
        Me.pbxBulletLvl3Left.Visible = False
        '
        'pbxHealthUpgrade
        '
        Me.pbxHealthUpgrade.Image = CType(resources.GetObject("pbxHealthUpgrade.Image"), System.Drawing.Image)
        Me.pbxHealthUpgrade.Location = New System.Drawing.Point(1442, 776)
        Me.pbxHealthUpgrade.Name = "pbxHealthUpgrade"
        Me.pbxHealthUpgrade.Size = New System.Drawing.Size(32, 32)
        Me.pbxHealthUpgrade.TabIndex = 56
        Me.pbxHealthUpgrade.TabStop = False
        Me.pbxHealthUpgrade.Visible = False
        '
        'pbxDamageUpgrade
        '
        Me.pbxDamageUpgrade.Image = CType(resources.GetObject("pbxDamageUpgrade.Image"), System.Drawing.Image)
        Me.pbxDamageUpgrade.Location = New System.Drawing.Point(1480, 776)
        Me.pbxDamageUpgrade.Name = "pbxDamageUpgrade"
        Me.pbxDamageUpgrade.Size = New System.Drawing.Size(32, 32)
        Me.pbxDamageUpgrade.TabIndex = 57
        Me.pbxDamageUpgrade.TabStop = False
        Me.pbxDamageUpgrade.Visible = False
        '
        'pbxSpeedUpgrade
        '
        Me.pbxSpeedUpgrade.Image = CType(resources.GetObject("pbxSpeedUpgrade.Image"), System.Drawing.Image)
        Me.pbxSpeedUpgrade.Location = New System.Drawing.Point(1518, 776)
        Me.pbxSpeedUpgrade.Name = "pbxSpeedUpgrade"
        Me.pbxSpeedUpgrade.Size = New System.Drawing.Size(32, 32)
        Me.pbxSpeedUpgrade.TabIndex = 58
        Me.pbxSpeedUpgrade.TabStop = False
        Me.pbxSpeedUpgrade.Visible = False
        '
        'pbxFirerateUpgrade
        '
        Me.pbxFirerateUpgrade.Image = CType(resources.GetObject("pbxFirerateUpgrade.Image"), System.Drawing.Image)
        Me.pbxFirerateUpgrade.Location = New System.Drawing.Point(1556, 776)
        Me.pbxFirerateUpgrade.Name = "pbxFirerateUpgrade"
        Me.pbxFirerateUpgrade.Size = New System.Drawing.Size(32, 32)
        Me.pbxFirerateUpgrade.TabIndex = 59
        Me.pbxFirerateUpgrade.TabStop = False
        Me.pbxFirerateUpgrade.Visible = False
        '
        'pbxHealthDrop
        '
        Me.pbxHealthDrop.Image = CType(resources.GetObject("pbxHealthDrop.Image"), System.Drawing.Image)
        Me.pbxHealthDrop.Location = New System.Drawing.Point(1419, 776)
        Me.pbxHealthDrop.Name = "pbxHealthDrop"
        Me.pbxHealthDrop.Size = New System.Drawing.Size(16, 16)
        Me.pbxHealthDrop.TabIndex = 60
        Me.pbxHealthDrop.TabStop = False
        Me.pbxHealthDrop.Visible = False
        '
        'pbxShieldDrop
        '
        Me.pbxShieldDrop.Image = CType(resources.GetObject("pbxShieldDrop.Image"), System.Drawing.Image)
        Me.pbxShieldDrop.Location = New System.Drawing.Point(1397, 776)
        Me.pbxShieldDrop.Name = "pbxShieldDrop"
        Me.pbxShieldDrop.Size = New System.Drawing.Size(16, 16)
        Me.pbxShieldDrop.TabIndex = 61
        Me.pbxShieldDrop.TabStop = False
        Me.pbxShieldDrop.Visible = False
        '
        'pbxShieldBar
        '
        Me.pbxShieldBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxShieldBar.Location = New System.Drawing.Point(17, 31)
        Me.pbxShieldBar.Name = "pbxShieldBar"
        Me.pbxShieldBar.Size = New System.Drawing.Size(100, 10)
        Me.pbxShieldBar.TabIndex = 62
        Me.pbxShieldBar.TabStop = False
        '
        'pbxShieldStealUpgrade
        '
        Me.pbxShieldStealUpgrade.Image = CType(resources.GetObject("pbxShieldStealUpgrade.Image"), System.Drawing.Image)
        Me.pbxShieldStealUpgrade.Location = New System.Drawing.Point(1594, 776)
        Me.pbxShieldStealUpgrade.Name = "pbxShieldStealUpgrade"
        Me.pbxShieldStealUpgrade.Size = New System.Drawing.Size(32, 32)
        Me.pbxShieldStealUpgrade.TabIndex = 63
        Me.pbxShieldStealUpgrade.TabStop = False
        Me.pbxShieldStealUpgrade.Visible = False
        '
        'lblShield
        '
        Me.lblShield.AutoSize = True
        Me.lblShield.Location = New System.Drawing.Point(1298, 50)
        Me.lblShield.Name = "lblShield"
        Me.lblShield.Size = New System.Drawing.Size(45, 13)
        Me.lblShield.TabIndex = 64
        Me.lblShield.Text = "Shield : "
        '
        'pbxEnemyMothership
        '
        Me.pbxEnemyMothership.Image = CType(resources.GetObject("pbxEnemyMothership.Image"), System.Drawing.Image)
        Me.pbxEnemyMothership.Location = New System.Drawing.Point(1384, 163)
        Me.pbxEnemyMothership.Name = "pbxEnemyMothership"
        Me.pbxEnemyMothership.Size = New System.Drawing.Size(128, 64)
        Me.pbxEnemyMothership.TabIndex = 65
        Me.pbxEnemyMothership.TabStop = False
        Me.pbxEnemyMothership.Visible = False
        '
        'EnemyAttackTimer
        '
        Me.EnemyAttackTimer.Interval = 600
        '
        'pbxBulletEnemyUp
        '
        Me.pbxBulletEnemyUp.Image = CType(resources.GetObject("pbxBulletEnemyUp.Image"), System.Drawing.Image)
        Me.pbxBulletEnemyUp.Location = New System.Drawing.Point(1464, 233)
        Me.pbxBulletEnemyUp.Name = "pbxBulletEnemyUp"
        Me.pbxBulletEnemyUp.Size = New System.Drawing.Size(8, 16)
        Me.pbxBulletEnemyUp.TabIndex = 66
        Me.pbxBulletEnemyUp.TabStop = False
        Me.pbxBulletEnemyUp.Tag = "Right"
        Me.pbxBulletEnemyUp.Visible = False
        '
        'pbxBulletEnemyDown
        '
        Me.pbxBulletEnemyDown.Image = CType(resources.GetObject("pbxBulletEnemyDown.Image"), System.Drawing.Image)
        Me.pbxBulletEnemyDown.Location = New System.Drawing.Point(1480, 233)
        Me.pbxBulletEnemyDown.Name = "pbxBulletEnemyDown"
        Me.pbxBulletEnemyDown.Size = New System.Drawing.Size(8, 16)
        Me.pbxBulletEnemyDown.TabIndex = 67
        Me.pbxBulletEnemyDown.TabStop = False
        Me.pbxBulletEnemyDown.Tag = "Right"
        Me.pbxBulletEnemyDown.Visible = False
        '
        'pbxBulletEnemyLeft
        '
        Me.pbxBulletEnemyLeft.Image = CType(resources.GetObject("pbxBulletEnemyLeft.Image"), System.Drawing.Image)
        Me.pbxBulletEnemyLeft.Location = New System.Drawing.Point(1496, 233)
        Me.pbxBulletEnemyLeft.Name = "pbxBulletEnemyLeft"
        Me.pbxBulletEnemyLeft.Size = New System.Drawing.Size(16, 8)
        Me.pbxBulletEnemyLeft.TabIndex = 68
        Me.pbxBulletEnemyLeft.TabStop = False
        Me.pbxBulletEnemyLeft.Tag = "Right"
        Me.pbxBulletEnemyLeft.Visible = False
        '
        'pbxBulletEnemyRight
        '
        Me.pbxBulletEnemyRight.Image = CType(resources.GetObject("pbxBulletEnemyRight.Image"), System.Drawing.Image)
        Me.pbxBulletEnemyRight.Location = New System.Drawing.Point(1496, 247)
        Me.pbxBulletEnemyRight.Name = "pbxBulletEnemyRight"
        Me.pbxBulletEnemyRight.Size = New System.Drawing.Size(16, 8)
        Me.pbxBulletEnemyRight.TabIndex = 69
        Me.pbxBulletEnemyRight.TabStop = False
        Me.pbxBulletEnemyRight.Tag = "Right"
        Me.pbxBulletEnemyRight.Visible = False
        '
        'AnimationTimer
        '
        Me.AnimationTimer.Interval = 75
        '
        'pbxAnimDeadEnemy8
        '
        Me.pbxAnimDeadEnemy8.Image = CType(resources.GetObject("pbxAnimDeadEnemy8.Image"), System.Drawing.Image)
        Me.pbxAnimDeadEnemy8.Location = New System.Drawing.Point(1037, 849)
        Me.pbxAnimDeadEnemy8.Name = "pbxAnimDeadEnemy8"
        Me.pbxAnimDeadEnemy8.Size = New System.Drawing.Size(32, 32)
        Me.pbxAnimDeadEnemy8.TabIndex = 70
        Me.pbxAnimDeadEnemy8.TabStop = False
        Me.pbxAnimDeadEnemy8.Visible = False
        '
        'pbxAnimDeadEnemy7
        '
        Me.pbxAnimDeadEnemy7.Image = CType(resources.GetObject("pbxAnimDeadEnemy7.Image"), System.Drawing.Image)
        Me.pbxAnimDeadEnemy7.Location = New System.Drawing.Point(999, 849)
        Me.pbxAnimDeadEnemy7.Name = "pbxAnimDeadEnemy7"
        Me.pbxAnimDeadEnemy7.Size = New System.Drawing.Size(32, 32)
        Me.pbxAnimDeadEnemy7.TabIndex = 71
        Me.pbxAnimDeadEnemy7.TabStop = False
        Me.pbxAnimDeadEnemy7.Visible = False
        '
        'pbxAnimDeadEnemy6
        '
        Me.pbxAnimDeadEnemy6.Image = CType(resources.GetObject("pbxAnimDeadEnemy6.Image"), System.Drawing.Image)
        Me.pbxAnimDeadEnemy6.Location = New System.Drawing.Point(961, 849)
        Me.pbxAnimDeadEnemy6.Name = "pbxAnimDeadEnemy6"
        Me.pbxAnimDeadEnemy6.Size = New System.Drawing.Size(32, 32)
        Me.pbxAnimDeadEnemy6.TabIndex = 72
        Me.pbxAnimDeadEnemy6.TabStop = False
        Me.pbxAnimDeadEnemy6.Visible = False
        '
        'pbxAnimDeadEnemy5
        '
        Me.pbxAnimDeadEnemy5.Image = CType(resources.GetObject("pbxAnimDeadEnemy5.Image"), System.Drawing.Image)
        Me.pbxAnimDeadEnemy5.Location = New System.Drawing.Point(923, 849)
        Me.pbxAnimDeadEnemy5.Name = "pbxAnimDeadEnemy5"
        Me.pbxAnimDeadEnemy5.Size = New System.Drawing.Size(32, 32)
        Me.pbxAnimDeadEnemy5.TabIndex = 73
        Me.pbxAnimDeadEnemy5.TabStop = False
        Me.pbxAnimDeadEnemy5.Visible = False
        '
        'pbxAnimDeadEnemy1
        '
        Me.pbxAnimDeadEnemy1.Image = CType(resources.GetObject("pbxAnimDeadEnemy1.Image"), System.Drawing.Image)
        Me.pbxAnimDeadEnemy1.Location = New System.Drawing.Point(771, 849)
        Me.pbxAnimDeadEnemy1.Name = "pbxAnimDeadEnemy1"
        Me.pbxAnimDeadEnemy1.Size = New System.Drawing.Size(32, 32)
        Me.pbxAnimDeadEnemy1.TabIndex = 74
        Me.pbxAnimDeadEnemy1.TabStop = False
        Me.pbxAnimDeadEnemy1.Visible = False
        '
        'pbxAnimDeadEnemy4
        '
        Me.pbxAnimDeadEnemy4.Image = CType(resources.GetObject("pbxAnimDeadEnemy4.Image"), System.Drawing.Image)
        Me.pbxAnimDeadEnemy4.Location = New System.Drawing.Point(885, 849)
        Me.pbxAnimDeadEnemy4.Name = "pbxAnimDeadEnemy4"
        Me.pbxAnimDeadEnemy4.Size = New System.Drawing.Size(32, 32)
        Me.pbxAnimDeadEnemy4.TabIndex = 75
        Me.pbxAnimDeadEnemy4.TabStop = False
        Me.pbxAnimDeadEnemy4.Visible = False
        '
        'pbxAnimDeadEnemy3
        '
        Me.pbxAnimDeadEnemy3.Image = CType(resources.GetObject("pbxAnimDeadEnemy3.Image"), System.Drawing.Image)
        Me.pbxAnimDeadEnemy3.Location = New System.Drawing.Point(809, 849)
        Me.pbxAnimDeadEnemy3.Name = "pbxAnimDeadEnemy3"
        Me.pbxAnimDeadEnemy3.Size = New System.Drawing.Size(32, 32)
        Me.pbxAnimDeadEnemy3.TabIndex = 76
        Me.pbxAnimDeadEnemy3.TabStop = False
        Me.pbxAnimDeadEnemy3.Visible = False
        '
        'pbxAnimDeadEnemy2
        '
        Me.pbxAnimDeadEnemy2.Image = CType(resources.GetObject("pbxAnimDeadEnemy2.Image"), System.Drawing.Image)
        Me.pbxAnimDeadEnemy2.Location = New System.Drawing.Point(847, 849)
        Me.pbxAnimDeadEnemy2.Name = "pbxAnimDeadEnemy2"
        Me.pbxAnimDeadEnemy2.Size = New System.Drawing.Size(32, 32)
        Me.pbxAnimDeadEnemy2.TabIndex = 77
        Me.pbxAnimDeadEnemy2.TabStop = False
        Me.pbxAnimDeadEnemy2.Visible = False
        '
        'pbxAnimDeadMothership1
        '
        Me.pbxAnimDeadMothership1.Image = CType(resources.GetObject("pbxAnimDeadMothership1.Image"), System.Drawing.Image)
        Me.pbxAnimDeadMothership1.Location = New System.Drawing.Point(771, 887)
        Me.pbxAnimDeadMothership1.Name = "pbxAnimDeadMothership1"
        Me.pbxAnimDeadMothership1.Size = New System.Drawing.Size(128, 64)
        Me.pbxAnimDeadMothership1.TabIndex = 78
        Me.pbxAnimDeadMothership1.TabStop = False
        Me.pbxAnimDeadMothership1.Visible = False
        '
        'pbxAnimDeadMothership2
        '
        Me.pbxAnimDeadMothership2.Image = CType(resources.GetObject("pbxAnimDeadMothership2.Image"), System.Drawing.Image)
        Me.pbxAnimDeadMothership2.Location = New System.Drawing.Point(905, 887)
        Me.pbxAnimDeadMothership2.Name = "pbxAnimDeadMothership2"
        Me.pbxAnimDeadMothership2.Size = New System.Drawing.Size(128, 64)
        Me.pbxAnimDeadMothership2.TabIndex = 79
        Me.pbxAnimDeadMothership2.TabStop = False
        Me.pbxAnimDeadMothership2.Visible = False
        '
        'pbxAnimDeadMothership3
        '
        Me.pbxAnimDeadMothership3.Image = CType(resources.GetObject("pbxAnimDeadMothership3.Image"), System.Drawing.Image)
        Me.pbxAnimDeadMothership3.Location = New System.Drawing.Point(1039, 887)
        Me.pbxAnimDeadMothership3.Name = "pbxAnimDeadMothership3"
        Me.pbxAnimDeadMothership3.Size = New System.Drawing.Size(128, 64)
        Me.pbxAnimDeadMothership3.TabIndex = 80
        Me.pbxAnimDeadMothership3.TabStop = False
        Me.pbxAnimDeadMothership3.Visible = False
        '
        'pbxAnimDeadMothership4
        '
        Me.pbxAnimDeadMothership4.Image = CType(resources.GetObject("pbxAnimDeadMothership4.Image"), System.Drawing.Image)
        Me.pbxAnimDeadMothership4.Location = New System.Drawing.Point(1173, 887)
        Me.pbxAnimDeadMothership4.Name = "pbxAnimDeadMothership4"
        Me.pbxAnimDeadMothership4.Size = New System.Drawing.Size(128, 64)
        Me.pbxAnimDeadMothership4.TabIndex = 81
        Me.pbxAnimDeadMothership4.TabStop = False
        Me.pbxAnimDeadMothership4.Visible = False
        '
        'pbxAnimDeadMothership5
        '
        Me.pbxAnimDeadMothership5.Image = CType(resources.GetObject("pbxAnimDeadMothership5.Image"), System.Drawing.Image)
        Me.pbxAnimDeadMothership5.Location = New System.Drawing.Point(771, 957)
        Me.pbxAnimDeadMothership5.Name = "pbxAnimDeadMothership5"
        Me.pbxAnimDeadMothership5.Size = New System.Drawing.Size(128, 64)
        Me.pbxAnimDeadMothership5.TabIndex = 82
        Me.pbxAnimDeadMothership5.TabStop = False
        Me.pbxAnimDeadMothership5.Visible = False
        '
        'pbxAnimDeadMothership6
        '
        Me.pbxAnimDeadMothership6.Image = CType(resources.GetObject("pbxAnimDeadMothership6.Image"), System.Drawing.Image)
        Me.pbxAnimDeadMothership6.Location = New System.Drawing.Point(905, 957)
        Me.pbxAnimDeadMothership6.Name = "pbxAnimDeadMothership6"
        Me.pbxAnimDeadMothership6.Size = New System.Drawing.Size(128, 64)
        Me.pbxAnimDeadMothership6.TabIndex = 83
        Me.pbxAnimDeadMothership6.TabStop = False
        Me.pbxAnimDeadMothership6.Visible = False
        '
        'pbxAnimDeadMothership7
        '
        Me.pbxAnimDeadMothership7.Image = CType(resources.GetObject("pbxAnimDeadMothership7.Image"), System.Drawing.Image)
        Me.pbxAnimDeadMothership7.Location = New System.Drawing.Point(1039, 957)
        Me.pbxAnimDeadMothership7.Name = "pbxAnimDeadMothership7"
        Me.pbxAnimDeadMothership7.Size = New System.Drawing.Size(128, 64)
        Me.pbxAnimDeadMothership7.TabIndex = 84
        Me.pbxAnimDeadMothership7.TabStop = False
        Me.pbxAnimDeadMothership7.Visible = False
        '
        'pbxAnimDeadMothership8
        '
        Me.pbxAnimDeadMothership8.Image = CType(resources.GetObject("pbxAnimDeadMothership8.Image"), System.Drawing.Image)
        Me.pbxAnimDeadMothership8.Location = New System.Drawing.Point(1173, 957)
        Me.pbxAnimDeadMothership8.Name = "pbxAnimDeadMothership8"
        Me.pbxAnimDeadMothership8.Size = New System.Drawing.Size(128, 64)
        Me.pbxAnimDeadMothership8.TabIndex = 85
        Me.pbxAnimDeadMothership8.TabStop = False
        Me.pbxAnimDeadMothership8.Visible = False
        '
        'pbxEnemyShooterUp
        '
        Me.pbxEnemyShooterUp.Image = CType(resources.GetObject("pbxEnemyShooterUp.Image"), System.Drawing.Image)
        Me.pbxEnemyShooterUp.Location = New System.Drawing.Point(1308, 885)
        Me.pbxEnemyShooterUp.Name = "pbxEnemyShooterUp"
        Me.pbxEnemyShooterUp.Size = New System.Drawing.Size(64, 64)
        Me.pbxEnemyShooterUp.TabIndex = 86
        Me.pbxEnemyShooterUp.TabStop = False
        Me.pbxEnemyShooterUp.Visible = False
        '
        'pbxEnemyShooterDown
        '
        Me.pbxEnemyShooterDown.Image = CType(resources.GetObject("pbxEnemyShooterDown.Image"), System.Drawing.Image)
        Me.pbxEnemyShooterDown.Location = New System.Drawing.Point(1378, 885)
        Me.pbxEnemyShooterDown.Name = "pbxEnemyShooterDown"
        Me.pbxEnemyShooterDown.Size = New System.Drawing.Size(64, 64)
        Me.pbxEnemyShooterDown.TabIndex = 87
        Me.pbxEnemyShooterDown.TabStop = False
        Me.pbxEnemyShooterDown.Visible = False
        '
        'pbxEnemyShooterLeft
        '
        Me.pbxEnemyShooterLeft.Image = CType(resources.GetObject("pbxEnemyShooterLeft.Image"), System.Drawing.Image)
        Me.pbxEnemyShooterLeft.Location = New System.Drawing.Point(1448, 885)
        Me.pbxEnemyShooterLeft.Name = "pbxEnemyShooterLeft"
        Me.pbxEnemyShooterLeft.Size = New System.Drawing.Size(64, 64)
        Me.pbxEnemyShooterLeft.TabIndex = 88
        Me.pbxEnemyShooterLeft.TabStop = False
        Me.pbxEnemyShooterLeft.Visible = False
        '
        'pbxEnemyShooterRight
        '
        Me.pbxEnemyShooterRight.Image = CType(resources.GetObject("pbxEnemyShooterRight.Image"), System.Drawing.Image)
        Me.pbxEnemyShooterRight.Location = New System.Drawing.Point(1518, 885)
        Me.pbxEnemyShooterRight.Name = "pbxEnemyShooterRight"
        Me.pbxEnemyShooterRight.Size = New System.Drawing.Size(64, 64)
        Me.pbxEnemyShooterRight.TabIndex = 89
        Me.pbxEnemyShooterRight.TabStop = False
        Me.pbxEnemyShooterRight.Visible = False
        '
        'pbxEnemyShooterNW
        '
        Me.pbxEnemyShooterNW.Image = CType(resources.GetObject("pbxEnemyShooterNW.Image"), System.Drawing.Image)
        Me.pbxEnemyShooterNW.Location = New System.Drawing.Point(1308, 957)
        Me.pbxEnemyShooterNW.Name = "pbxEnemyShooterNW"
        Me.pbxEnemyShooterNW.Size = New System.Drawing.Size(64, 64)
        Me.pbxEnemyShooterNW.TabIndex = 90
        Me.pbxEnemyShooterNW.TabStop = False
        Me.pbxEnemyShooterNW.Visible = False
        '
        'pbxEnemyShooterNE
        '
        Me.pbxEnemyShooterNE.Image = CType(resources.GetObject("pbxEnemyShooterNE.Image"), System.Drawing.Image)
        Me.pbxEnemyShooterNE.Location = New System.Drawing.Point(1376, 957)
        Me.pbxEnemyShooterNE.Name = "pbxEnemyShooterNE"
        Me.pbxEnemyShooterNE.Size = New System.Drawing.Size(64, 64)
        Me.pbxEnemyShooterNE.TabIndex = 91
        Me.pbxEnemyShooterNE.TabStop = False
        Me.pbxEnemyShooterNE.Visible = False
        '
        'pbxEnemyShooterSE
        '
        Me.pbxEnemyShooterSE.Image = CType(resources.GetObject("pbxEnemyShooterSE.Image"), System.Drawing.Image)
        Me.pbxEnemyShooterSE.Location = New System.Drawing.Point(1448, 957)
        Me.pbxEnemyShooterSE.Name = "pbxEnemyShooterSE"
        Me.pbxEnemyShooterSE.Size = New System.Drawing.Size(64, 64)
        Me.pbxEnemyShooterSE.TabIndex = 92
        Me.pbxEnemyShooterSE.TabStop = False
        Me.pbxEnemyShooterSE.Visible = False
        '
        'pbxEnemyShooterSW
        '
        Me.pbxEnemyShooterSW.Image = CType(resources.GetObject("pbxEnemyShooterSW.Image"), System.Drawing.Image)
        Me.pbxEnemyShooterSW.Location = New System.Drawing.Point(1518, 957)
        Me.pbxEnemyShooterSW.Name = "pbxEnemyShooterSW"
        Me.pbxEnemyShooterSW.Size = New System.Drawing.Size(64, 64)
        Me.pbxEnemyShooterSW.TabIndex = 93
        Me.pbxEnemyShooterSW.TabStop = False
        Me.pbxEnemyShooterSW.Visible = False
        '
        'pbxRingShotUpgrade
        '
        Me.pbxRingShotUpgrade.Image = CType(resources.GetObject("pbxRingShotUpgrade.Image"), System.Drawing.Image)
        Me.pbxRingShotUpgrade.Location = New System.Drawing.Point(1632, 776)
        Me.pbxRingShotUpgrade.Name = "pbxRingShotUpgrade"
        Me.pbxRingShotUpgrade.Size = New System.Drawing.Size(32, 32)
        Me.pbxRingShotUpgrade.TabIndex = 94
        Me.pbxRingShotUpgrade.TabStop = False
        Me.pbxRingShotUpgrade.Visible = False
        '
        'pbxDiagonalShotUpgrade
        '
        Me.pbxDiagonalShotUpgrade.Image = CType(resources.GetObject("pbxDiagonalShotUpgrade.Image"), System.Drawing.Image)
        Me.pbxDiagonalShotUpgrade.Location = New System.Drawing.Point(1480, 814)
        Me.pbxDiagonalShotUpgrade.Name = "pbxDiagonalShotUpgrade"
        Me.pbxDiagonalShotUpgrade.Size = New System.Drawing.Size(32, 32)
        Me.pbxDiagonalShotUpgrade.TabIndex = 95
        Me.pbxDiagonalShotUpgrade.TabStop = False
        Me.pbxDiagonalShotUpgrade.Visible = False
        '
        'pbxRingBullet
        '
        Me.pbxRingBullet.Image = CType(resources.GetObject("pbxRingBullet.Image"), System.Drawing.Image)
        Me.pbxRingBullet.Location = New System.Drawing.Point(1404, 798)
        Me.pbxRingBullet.Name = "pbxRingBullet"
        Me.pbxRingBullet.Size = New System.Drawing.Size(26, 26)
        Me.pbxRingBullet.TabIndex = 96
        Me.pbxRingBullet.TabStop = False
        Me.pbxRingBullet.Tag = "Up"
        Me.pbxRingBullet.Visible = False
        '
        'pbxBulletNE
        '
        Me.pbxBulletNE.Image = CType(resources.GetObject("pbxBulletNE.Image"), System.Drawing.Image)
        Me.pbxBulletNE.Location = New System.Drawing.Point(1390, 809)
        Me.pbxBulletNE.Name = "pbxBulletNE"
        Me.pbxBulletNE.Size = New System.Drawing.Size(8, 8)
        Me.pbxBulletNE.TabIndex = 97
        Me.pbxBulletNE.TabStop = False
        Me.pbxBulletNE.Tag = "Up"
        Me.pbxBulletNE.Visible = False
        '
        'pbxBulletNW
        '
        Me.pbxBulletNW.Image = CType(resources.GetObject("pbxBulletNW.Image"), System.Drawing.Image)
        Me.pbxBulletNW.Location = New System.Drawing.Point(1390, 798)
        Me.pbxBulletNW.Name = "pbxBulletNW"
        Me.pbxBulletNW.Size = New System.Drawing.Size(8, 8)
        Me.pbxBulletNW.TabIndex = 98
        Me.pbxBulletNW.TabStop = False
        Me.pbxBulletNW.Tag = "Up"
        Me.pbxBulletNW.Visible = False
        '
        'pbxBulletSE
        '
        Me.pbxBulletSE.Image = CType(resources.GetObject("pbxBulletSE.Image"), System.Drawing.Image)
        Me.pbxBulletSE.Location = New System.Drawing.Point(1390, 823)
        Me.pbxBulletSE.Name = "pbxBulletSE"
        Me.pbxBulletSE.Size = New System.Drawing.Size(8, 8)
        Me.pbxBulletSE.TabIndex = 99
        Me.pbxBulletSE.TabStop = False
        Me.pbxBulletSE.Tag = "Up"
        Me.pbxBulletSE.Visible = False
        '
        'pbxBulletSW
        '
        Me.pbxBulletSW.Image = CType(resources.GetObject("pbxBulletSW.Image"), System.Drawing.Image)
        Me.pbxBulletSW.Location = New System.Drawing.Point(1390, 833)
        Me.pbxBulletSW.Name = "pbxBulletSW"
        Me.pbxBulletSW.Size = New System.Drawing.Size(8, 8)
        Me.pbxBulletSW.TabIndex = 100
        Me.pbxBulletSW.TabStop = False
        Me.pbxBulletSW.Tag = "Up"
        Me.pbxBulletSW.Visible = False
        '
        'pbxCollectedUpgrades
        '
        Me.pbxCollectedUpgrades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxCollectedUpgrades.Location = New System.Drawing.Point(1302, 69)
        Me.pbxCollectedUpgrades.Name = "pbxCollectedUpgrades"
        Me.pbxCollectedUpgrades.Size = New System.Drawing.Size(36, 640)
        Me.pbxCollectedUpgrades.TabIndex = 101
        Me.pbxCollectedUpgrades.TabStop = False
        '
        'pbxZigZagUpgrade
        '
        Me.pbxZigZagUpgrade.Image = CType(resources.GetObject("pbxZigZagUpgrade.Image"), System.Drawing.Image)
        Me.pbxZigZagUpgrade.Location = New System.Drawing.Point(1518, 814)
        Me.pbxZigZagUpgrade.Name = "pbxZigZagUpgrade"
        Me.pbxZigZagUpgrade.Size = New System.Drawing.Size(32, 32)
        Me.pbxZigZagUpgrade.TabIndex = 102
        Me.pbxZigZagUpgrade.TabStop = False
        Me.pbxZigZagUpgrade.Visible = False
        '
        'pbxGreenPlane
        '
        Me.pbxGreenPlane.Image = CType(resources.GetObject("pbxGreenPlane.Image"), System.Drawing.Image)
        Me.pbxGreenPlane.Location = New System.Drawing.Point(1594, 12)
        Me.pbxGreenPlane.Name = "pbxGreenPlane"
        Me.pbxGreenPlane.Size = New System.Drawing.Size(32, 32)
        Me.pbxGreenPlane.TabIndex = 103
        Me.pbxGreenPlane.TabStop = False
        Me.pbxGreenPlane.Visible = False
        '
        'pbxRepairsUpgrade
        '
        Me.pbxRepairsUpgrade.Image = CType(resources.GetObject("pbxRepairsUpgrade.Image"), System.Drawing.Image)
        Me.pbxRepairsUpgrade.Location = New System.Drawing.Point(1442, 814)
        Me.pbxRepairsUpgrade.Name = "pbxRepairsUpgrade"
        Me.pbxRepairsUpgrade.Size = New System.Drawing.Size(32, 32)
        Me.pbxRepairsUpgrade.TabIndex = 104
        Me.pbxRepairsUpgrade.TabStop = False
        Me.pbxRepairsUpgrade.Visible = False
        '
        'pbxEnemyKamikazeUp
        '
        Me.pbxEnemyKamikazeUp.Image = CType(resources.GetObject("pbxEnemyKamikazeUp.Image"), System.Drawing.Image)
        Me.pbxEnemyKamikazeUp.Location = New System.Drawing.Point(771, 782)
        Me.pbxEnemyKamikazeUp.Name = "pbxEnemyKamikazeUp"
        Me.pbxEnemyKamikazeUp.Size = New System.Drawing.Size(64, 64)
        Me.pbxEnemyKamikazeUp.TabIndex = 105
        Me.pbxEnemyKamikazeUp.TabStop = False
        Me.pbxEnemyKamikazeUp.Visible = False
        '
        'pbxEnemyKamikazeRight
        '
        Me.pbxEnemyKamikazeRight.Image = CType(resources.GetObject("pbxEnemyKamikazeRight.Image"), System.Drawing.Image)
        Me.pbxEnemyKamikazeRight.Location = New System.Drawing.Point(841, 782)
        Me.pbxEnemyKamikazeRight.Name = "pbxEnemyKamikazeRight"
        Me.pbxEnemyKamikazeRight.Size = New System.Drawing.Size(64, 64)
        Me.pbxEnemyKamikazeRight.TabIndex = 106
        Me.pbxEnemyKamikazeRight.TabStop = False
        Me.pbxEnemyKamikazeRight.Visible = False
        '
        'pbxEnemyKamikazeDown
        '
        Me.pbxEnemyKamikazeDown.Image = CType(resources.GetObject("pbxEnemyKamikazeDown.Image"), System.Drawing.Image)
        Me.pbxEnemyKamikazeDown.Location = New System.Drawing.Point(911, 782)
        Me.pbxEnemyKamikazeDown.Name = "pbxEnemyKamikazeDown"
        Me.pbxEnemyKamikazeDown.Size = New System.Drawing.Size(64, 64)
        Me.pbxEnemyKamikazeDown.TabIndex = 107
        Me.pbxEnemyKamikazeDown.TabStop = False
        Me.pbxEnemyKamikazeDown.Visible = False
        '
        'pbxEnemyKamikazeLeft
        '
        Me.pbxEnemyKamikazeLeft.Image = CType(resources.GetObject("pbxEnemyKamikazeLeft.Image"), System.Drawing.Image)
        Me.pbxEnemyKamikazeLeft.Location = New System.Drawing.Point(981, 782)
        Me.pbxEnemyKamikazeLeft.Name = "pbxEnemyKamikazeLeft"
        Me.pbxEnemyKamikazeLeft.Size = New System.Drawing.Size(64, 64)
        Me.pbxEnemyKamikazeLeft.TabIndex = 108
        Me.pbxEnemyKamikazeLeft.TabStop = False
        Me.pbxEnemyKamikazeLeft.Visible = False
        '
        'pbxEnemyKamikazeNW
        '
        Me.pbxEnemyKamikazeNW.Image = CType(resources.GetObject("pbxEnemyKamikazeNW.Image"), System.Drawing.Image)
        Me.pbxEnemyKamikazeNW.Location = New System.Drawing.Point(1051, 782)
        Me.pbxEnemyKamikazeNW.Name = "pbxEnemyKamikazeNW"
        Me.pbxEnemyKamikazeNW.Size = New System.Drawing.Size(64, 64)
        Me.pbxEnemyKamikazeNW.TabIndex = 109
        Me.pbxEnemyKamikazeNW.TabStop = False
        Me.pbxEnemyKamikazeNW.Visible = False
        '
        'pbxEnemyKamikazeNE
        '
        Me.pbxEnemyKamikazeNE.Image = CType(resources.GetObject("pbxEnemyKamikazeNE.Image"), System.Drawing.Image)
        Me.pbxEnemyKamikazeNE.Location = New System.Drawing.Point(1121, 782)
        Me.pbxEnemyKamikazeNE.Name = "pbxEnemyKamikazeNE"
        Me.pbxEnemyKamikazeNE.Size = New System.Drawing.Size(64, 64)
        Me.pbxEnemyKamikazeNE.TabIndex = 110
        Me.pbxEnemyKamikazeNE.TabStop = False
        Me.pbxEnemyKamikazeNE.Visible = False
        '
        'pbxEnemyKamikazeSE
        '
        Me.pbxEnemyKamikazeSE.Image = CType(resources.GetObject("pbxEnemyKamikazeSE.Image"), System.Drawing.Image)
        Me.pbxEnemyKamikazeSE.Location = New System.Drawing.Point(1191, 782)
        Me.pbxEnemyKamikazeSE.Name = "pbxEnemyKamikazeSE"
        Me.pbxEnemyKamikazeSE.Size = New System.Drawing.Size(64, 64)
        Me.pbxEnemyKamikazeSE.TabIndex = 111
        Me.pbxEnemyKamikazeSE.TabStop = False
        Me.pbxEnemyKamikazeSE.Visible = False
        '
        'pbxEnemyKamikazeSW
        '
        Me.pbxEnemyKamikazeSW.Image = CType(resources.GetObject("pbxEnemyKamikazeSW.Image"), System.Drawing.Image)
        Me.pbxEnemyKamikazeSW.Location = New System.Drawing.Point(1261, 782)
        Me.pbxEnemyKamikazeSW.Name = "pbxEnemyKamikazeSW"
        Me.pbxEnemyKamikazeSW.Size = New System.Drawing.Size(64, 64)
        Me.pbxEnemyKamikazeSW.TabIndex = 112
        Me.pbxEnemyKamikazeSW.TabStop = False
        Me.pbxEnemyKamikazeSW.Visible = False
        '
        'pbxSplitShotUpgrade
        '
        Me.pbxSplitShotUpgrade.Image = CType(resources.GetObject("pbxSplitShotUpgrade.Image"), System.Drawing.Image)
        Me.pbxSplitShotUpgrade.Location = New System.Drawing.Point(1556, 814)
        Me.pbxSplitShotUpgrade.Name = "pbxSplitShotUpgrade"
        Me.pbxSplitShotUpgrade.Size = New System.Drawing.Size(32, 32)
        Me.pbxSplitShotUpgrade.TabIndex = 113
        Me.pbxSplitShotUpgrade.TabStop = False
        Me.pbxSplitShotUpgrade.Visible = False
        '
        'pbxZero
        '
        Me.pbxZero.Image = CType(resources.GetObject("pbxZero.Image"), System.Drawing.Image)
        Me.pbxZero.Location = New System.Drawing.Point(1396, 350)
        Me.pbxZero.Name = "pbxZero"
        Me.pbxZero.Size = New System.Drawing.Size(80, 100)
        Me.pbxZero.TabIndex = 114
        Me.pbxZero.TabStop = False
        Me.pbxZero.Visible = False
        '
        'pbxSlothUpgrade
        '
        Me.pbxSlothUpgrade.Image = CType(resources.GetObject("pbxSlothUpgrade.Image"), System.Drawing.Image)
        Me.pbxSlothUpgrade.Location = New System.Drawing.Point(1594, 814)
        Me.pbxSlothUpgrade.Name = "pbxSlothUpgrade"
        Me.pbxSlothUpgrade.Size = New System.Drawing.Size(32, 32)
        Me.pbxSlothUpgrade.TabIndex = 115
        Me.pbxSlothUpgrade.TabStop = False
        Me.pbxSlothUpgrade.Visible = False
        '
        'ActiveItemTimer
        '
        Me.ActiveItemTimer.Interval = 1000
        '
        'pbxAnimTimerFrame1
        '
        Me.pbxAnimTimerFrame1.Image = CType(resources.GetObject("pbxAnimTimerFrame1.Image"), System.Drawing.Image)
        Me.pbxAnimTimerFrame1.Location = New System.Drawing.Point(733, 782)
        Me.pbxAnimTimerFrame1.Name = "pbxAnimTimerFrame1"
        Me.pbxAnimTimerFrame1.Size = New System.Drawing.Size(32, 32)
        Me.pbxAnimTimerFrame1.TabIndex = 116
        Me.pbxAnimTimerFrame1.TabStop = False
        Me.pbxAnimTimerFrame1.Visible = False
        '
        'pbxAnimTimerFrame2
        '
        Me.pbxAnimTimerFrame2.Image = CType(resources.GetObject("pbxAnimTimerFrame2.Image"), System.Drawing.Image)
        Me.pbxAnimTimerFrame2.Location = New System.Drawing.Point(733, 814)
        Me.pbxAnimTimerFrame2.Name = "pbxAnimTimerFrame2"
        Me.pbxAnimTimerFrame2.Size = New System.Drawing.Size(32, 32)
        Me.pbxAnimTimerFrame2.TabIndex = 117
        Me.pbxAnimTimerFrame2.TabStop = False
        Me.pbxAnimTimerFrame2.Visible = False
        '
        'pbxAnimTimerFrame3
        '
        Me.pbxAnimTimerFrame3.Image = CType(resources.GetObject("pbxAnimTimerFrame3.Image"), System.Drawing.Image)
        Me.pbxAnimTimerFrame3.Location = New System.Drawing.Point(733, 844)
        Me.pbxAnimTimerFrame3.Name = "pbxAnimTimerFrame3"
        Me.pbxAnimTimerFrame3.Size = New System.Drawing.Size(32, 32)
        Me.pbxAnimTimerFrame3.TabIndex = 118
        Me.pbxAnimTimerFrame3.TabStop = False
        Me.pbxAnimTimerFrame3.Visible = False
        '
        'pbxAnimTimerFrame4
        '
        Me.pbxAnimTimerFrame4.Image = CType(resources.GetObject("pbxAnimTimerFrame4.Image"), System.Drawing.Image)
        Me.pbxAnimTimerFrame4.Location = New System.Drawing.Point(733, 876)
        Me.pbxAnimTimerFrame4.Name = "pbxAnimTimerFrame4"
        Me.pbxAnimTimerFrame4.Size = New System.Drawing.Size(32, 32)
        Me.pbxAnimTimerFrame4.TabIndex = 119
        Me.pbxAnimTimerFrame4.TabStop = False
        Me.pbxAnimTimerFrame4.Visible = False
        '
        'pbxAnimTimerFrame5
        '
        Me.pbxAnimTimerFrame5.Image = CType(resources.GetObject("pbxAnimTimerFrame5.Image"), System.Drawing.Image)
        Me.pbxAnimTimerFrame5.Location = New System.Drawing.Point(733, 904)
        Me.pbxAnimTimerFrame5.Name = "pbxAnimTimerFrame5"
        Me.pbxAnimTimerFrame5.Size = New System.Drawing.Size(32, 32)
        Me.pbxAnimTimerFrame5.TabIndex = 120
        Me.pbxAnimTimerFrame5.TabStop = False
        Me.pbxAnimTimerFrame5.Visible = False
        '
        'pbxAnimTimerFrame6
        '
        Me.pbxAnimTimerFrame6.Image = CType(resources.GetObject("pbxAnimTimerFrame6.Image"), System.Drawing.Image)
        Me.pbxAnimTimerFrame6.Location = New System.Drawing.Point(733, 933)
        Me.pbxAnimTimerFrame6.Name = "pbxAnimTimerFrame6"
        Me.pbxAnimTimerFrame6.Size = New System.Drawing.Size(32, 32)
        Me.pbxAnimTimerFrame6.TabIndex = 121
        Me.pbxAnimTimerFrame6.TabStop = False
        Me.pbxAnimTimerFrame6.Visible = False
        '
        'pbxAnimTimerFrame7
        '
        Me.pbxAnimTimerFrame7.Image = CType(resources.GetObject("pbxAnimTimerFrame7.Image"), System.Drawing.Image)
        Me.pbxAnimTimerFrame7.Location = New System.Drawing.Point(733, 957)
        Me.pbxAnimTimerFrame7.Name = "pbxAnimTimerFrame7"
        Me.pbxAnimTimerFrame7.Size = New System.Drawing.Size(32, 32)
        Me.pbxAnimTimerFrame7.TabIndex = 122
        Me.pbxAnimTimerFrame7.TabStop = False
        Me.pbxAnimTimerFrame7.Visible = False
        '
        'pbxAnimTimerFrame8
        '
        Me.pbxAnimTimerFrame8.Image = CType(resources.GetObject("pbxAnimTimerFrame8.Image"), System.Drawing.Image)
        Me.pbxAnimTimerFrame8.Location = New System.Drawing.Point(733, 989)
        Me.pbxAnimTimerFrame8.Name = "pbxAnimTimerFrame8"
        Me.pbxAnimTimerFrame8.Size = New System.Drawing.Size(32, 32)
        Me.pbxAnimTimerFrame8.TabIndex = 123
        Me.pbxAnimTimerFrame8.TabStop = False
        Me.pbxAnimTimerFrame8.Visible = False
        '
        'TimerTimer
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1676, 1024)
        Me.Controls.Add(Me.pbxAnimTimerFrame8)
        Me.Controls.Add(Me.pbxAnimTimerFrame7)
        Me.Controls.Add(Me.pbxAnimTimerFrame6)
        Me.Controls.Add(Me.pbxAnimTimerFrame5)
        Me.Controls.Add(Me.pbxAnimTimerFrame4)
        Me.Controls.Add(Me.pbxAnimTimerFrame3)
        Me.Controls.Add(Me.pbxAnimTimerFrame2)
        Me.Controls.Add(Me.pbxAnimTimerFrame1)
        Me.Controls.Add(Me.pbxSlothUpgrade)
        Me.Controls.Add(Me.pbxZero)
        Me.Controls.Add(Me.pbxSplitShotUpgrade)
        Me.Controls.Add(Me.pbxEnemyKamikazeSW)
        Me.Controls.Add(Me.pbxEnemyKamikazeSE)
        Me.Controls.Add(Me.pbxEnemyKamikazeNE)
        Me.Controls.Add(Me.pbxEnemyKamikazeNW)
        Me.Controls.Add(Me.pbxEnemyKamikazeLeft)
        Me.Controls.Add(Me.pbxEnemyKamikazeDown)
        Me.Controls.Add(Me.pbxEnemyKamikazeRight)
        Me.Controls.Add(Me.pbxEnemyKamikazeUp)
        Me.Controls.Add(Me.pbxRepairsUpgrade)
        Me.Controls.Add(Me.pbxGreenPlane)
        Me.Controls.Add(Me.pbxZigZagUpgrade)
        Me.Controls.Add(Me.pbxCollectedUpgrades)
        Me.Controls.Add(Me.pbxBulletSW)
        Me.Controls.Add(Me.pbxBulletSE)
        Me.Controls.Add(Me.pbxBulletNW)
        Me.Controls.Add(Me.pbxBulletNE)
        Me.Controls.Add(Me.pbxRingBullet)
        Me.Controls.Add(Me.pbxDiagonalShotUpgrade)
        Me.Controls.Add(Me.pbxRingShotUpgrade)
        Me.Controls.Add(Me.pbxEnemyShooterSW)
        Me.Controls.Add(Me.pbxEnemyShooterSE)
        Me.Controls.Add(Me.pbxEnemyShooterNE)
        Me.Controls.Add(Me.pbxEnemyShooterNW)
        Me.Controls.Add(Me.pbxEnemyShooterRight)
        Me.Controls.Add(Me.pbxEnemyShooterLeft)
        Me.Controls.Add(Me.pbxEnemyShooterDown)
        Me.Controls.Add(Me.pbxEnemyShooterUp)
        Me.Controls.Add(Me.pbxAnimDeadMothership8)
        Me.Controls.Add(Me.pbxAnimDeadMothership7)
        Me.Controls.Add(Me.pbxAnimDeadMothership6)
        Me.Controls.Add(Me.pbxAnimDeadMothership5)
        Me.Controls.Add(Me.pbxAnimDeadMothership4)
        Me.Controls.Add(Me.pbxAnimDeadMothership3)
        Me.Controls.Add(Me.pbxAnimDeadMothership2)
        Me.Controls.Add(Me.pbxAnimDeadMothership1)
        Me.Controls.Add(Me.pbxAnimDeadEnemy2)
        Me.Controls.Add(Me.pbxAnimDeadEnemy3)
        Me.Controls.Add(Me.pbxAnimDeadEnemy4)
        Me.Controls.Add(Me.pbxAnimDeadEnemy1)
        Me.Controls.Add(Me.pbxAnimDeadEnemy5)
        Me.Controls.Add(Me.pbxAnimDeadEnemy6)
        Me.Controls.Add(Me.pbxAnimDeadEnemy7)
        Me.Controls.Add(Me.pbxAnimDeadEnemy8)
        Me.Controls.Add(Me.pbxBulletEnemyRight)
        Me.Controls.Add(Me.pbxBulletEnemyLeft)
        Me.Controls.Add(Me.pbxBulletEnemyDown)
        Me.Controls.Add(Me.pbxBulletEnemyUp)
        Me.Controls.Add(Me.pbxEnemyMothership)
        Me.Controls.Add(Me.lblShield)
        Me.Controls.Add(Me.pbxShieldStealUpgrade)
        Me.Controls.Add(Me.pbxShieldBar)
        Me.Controls.Add(Me.pbxShieldDrop)
        Me.Controls.Add(Me.pbxHealthDrop)
        Me.Controls.Add(Me.pbxFirerateUpgrade)
        Me.Controls.Add(Me.pbxSpeedUpgrade)
        Me.Controls.Add(Me.pbxDamageUpgrade)
        Me.Controls.Add(Me.pbxHealthUpgrade)
        Me.Controls.Add(Me.pbxBulletLvl3Left)
        Me.Controls.Add(Me.pbxBulletLvl3Down)
        Me.Controls.Add(Me.pbxBulletLvl3Right)
        Me.Controls.Add(Me.pbxBulletLvl3Up)
        Me.Controls.Add(Me.pbxBulletLvl2Left)
        Me.Controls.Add(Me.pbxBulletLvl2Down)
        Me.Controls.Add(Me.pbxBulletLvl2Right)
        Me.Controls.Add(Me.pbxBulletLvl2Up)
        Me.Controls.Add(Me.pbxStrongEnemySW)
        Me.Controls.Add(Me.pbxStrongEnemySE)
        Me.Controls.Add(Me.pbxStrongEnemyNW)
        Me.Controls.Add(Me.pbxStrongEnemyNE)
        Me.Controls.Add(Me.pbxEnemySE)
        Me.Controls.Add(Me.pbxEnemySW)
        Me.Controls.Add(Me.pbxEnemyNE)
        Me.Controls.Add(Me.pbxEnemyNW)
        Me.Controls.Add(Me.pbxNine)
        Me.Controls.Add(Me.pbxEight)
        Me.Controls.Add(Me.pbxSeven)
        Me.Controls.Add(Me.pbxSix)
        Me.Controls.Add(Me.pbxFive)
        Me.Controls.Add(Me.pbxFour)
        Me.Controls.Add(Me.pbxThree)
        Me.Controls.Add(Me.pbxTwo)
        Me.Controls.Add(Me.pbxOne)
        Me.Controls.Add(Me.pbxStrongEnemyRightDamaged)
        Me.Controls.Add(Me.pbxStrongEnemyLeftDamaged)
        Me.Controls.Add(Me.pbxStrongEnemyUpDamaged)
        Me.Controls.Add(Me.pbxStrongEnemyDownDamaged)
        Me.Controls.Add(Me.pbxStrongEnemyRight)
        Me.Controls.Add(Me.pbxStrongEnemyLeft)
        Me.Controls.Add(Me.pbxStrongEnemyUp)
        Me.Controls.Add(Me.pbxStrongEnemyDown)
        Me.Controls.Add(Me.pbxEnemyDownDamaged)
        Me.Controls.Add(Me.pbxEnemyUpDamaged)
        Me.Controls.Add(Me.pbxEnemyRightDamaged)
        Me.Controls.Add(Me.pbxEnemyLeftDamaged)
        Me.Controls.Add(Me.pbxRound)
        Me.Controls.Add(Me.pbxHealthBar)
        Me.Controls.Add(Me.pbxBulletLvl1Right)
        Me.Controls.Add(Me.pbxBulletLvl1Left)
        Me.Controls.Add(Me.pbxBulletLvl1Down)
        Me.Controls.Add(Me.pbxEnemyLeft)
        Me.Controls.Add(Me.pbxEnemyRight)
        Me.Controls.Add(Me.pbxEnemyUp)
        Me.Controls.Add(Me.lblLife)
        Me.Controls.Add(Me.pbxEnemyDown)
        Me.Controls.Add(Me.lblFPS)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbxBulletLvl1Up)
        Me.Controls.Add(Me.Display)
        Me.Controls.Add(Me.pbxWater)
        Me.Controls.Add(Me.pbxPlane)
        Me.Name = "Form1"
        CType(Me.pbxPlane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxWater, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Display, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBulletLvl1Up, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemyDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemyUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemyRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemyLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBulletLvl1Down, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBulletLvl1Left, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBulletLvl1Right, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxHealthBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxRound, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemyLeftDamaged, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemyRightDamaged, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemyUpDamaged, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemyDownDamaged, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStrongEnemyDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStrongEnemyUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStrongEnemyLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStrongEnemyRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStrongEnemyDownDamaged, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStrongEnemyUpDamaged, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStrongEnemyLeftDamaged, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStrongEnemyRightDamaged, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxFour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxFive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSeven, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxNine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemyNW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemyNE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemySW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemySE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStrongEnemyNE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStrongEnemyNW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStrongEnemySE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStrongEnemySW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBulletLvl2Up, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBulletLvl2Right, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBulletLvl2Down, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBulletLvl2Left, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBulletLvl3Up, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBulletLvl3Right, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBulletLvl3Down, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBulletLvl3Left, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxHealthUpgrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDamageUpgrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSpeedUpgrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxFirerateUpgrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxHealthDrop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxShieldDrop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxShieldBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxShieldStealUpgrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemyMothership, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBulletEnemyUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBulletEnemyDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBulletEnemyLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBulletEnemyRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAnimDeadEnemy8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAnimDeadEnemy7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAnimDeadEnemy6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAnimDeadEnemy5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAnimDeadEnemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAnimDeadEnemy4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAnimDeadEnemy3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAnimDeadEnemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAnimDeadMothership1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAnimDeadMothership2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAnimDeadMothership3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAnimDeadMothership4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAnimDeadMothership5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAnimDeadMothership6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAnimDeadMothership7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAnimDeadMothership8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemyShooterUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemyShooterDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemyShooterLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemyShooterRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemyShooterNW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemyShooterNE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemyShooterSE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemyShooterSW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxRingShotUpgrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDiagonalShotUpgrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxRingBullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBulletNE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBulletNW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBulletSE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBulletSW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCollectedUpgrades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxZigZagUpgrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxGreenPlane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxRepairsUpgrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemyKamikazeUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemyKamikazeRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemyKamikazeDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemyKamikazeLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemyKamikazeNW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemyKamikazeNE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemyKamikazeSE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEnemyKamikazeSW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSplitShotUpgrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxZero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSlothUpgrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAnimTimerFrame1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAnimTimerFrame2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAnimTimerFrame3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAnimTimerFrame4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAnimTimerFrame5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAnimTimerFrame6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAnimTimerFrame7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAnimTimerFrame8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbxPlane As System.Windows.Forms.PictureBox
    Friend WithEvents pbxWater As System.Windows.Forms.PictureBox
    Friend WithEvents Display As System.Windows.Forms.PictureBox
    Friend WithEvents pbxBulletLvl1Up As System.Windows.Forms.PictureBox
    Friend WithEvents GameTimer As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFPS As System.Windows.Forms.Label
    Friend WithEvents pbxEnemyDown As System.Windows.Forms.PictureBox
    Friend WithEvents SpawnTimer As System.Windows.Forms.Timer
    Friend WithEvents lblLife As System.Windows.Forms.Label
    Friend WithEvents pbxEnemyUp As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEnemyRight As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEnemyLeft As System.Windows.Forms.PictureBox
    Friend WithEvents pbxBulletLvl1Down As System.Windows.Forms.PictureBox
    Friend WithEvents pbxBulletLvl1Left As System.Windows.Forms.PictureBox
    Friend WithEvents pbxBulletLvl1Right As System.Windows.Forms.PictureBox
    Friend WithEvents pbxHealthBar As System.Windows.Forms.PictureBox
    Friend WithEvents RoundChangeTimer As System.Windows.Forms.Timer
    Friend WithEvents pbxRound As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEnemyLeftDamaged As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEnemyRightDamaged As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEnemyUpDamaged As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEnemyDownDamaged As System.Windows.Forms.PictureBox
    Friend WithEvents pbxStrongEnemyDown As System.Windows.Forms.PictureBox
    Friend WithEvents pbxStrongEnemyUp As System.Windows.Forms.PictureBox
    Friend WithEvents pbxStrongEnemyLeft As System.Windows.Forms.PictureBox
    Friend WithEvents pbxStrongEnemyRight As System.Windows.Forms.PictureBox
    Friend WithEvents pbxStrongEnemyDownDamaged As System.Windows.Forms.PictureBox
    Friend WithEvents pbxStrongEnemyUpDamaged As System.Windows.Forms.PictureBox
    Friend WithEvents pbxStrongEnemyLeftDamaged As System.Windows.Forms.PictureBox
    Friend WithEvents pbxStrongEnemyRightDamaged As System.Windows.Forms.PictureBox
    Friend WithEvents pbxOne As System.Windows.Forms.PictureBox
    Friend WithEvents pbxTwo As System.Windows.Forms.PictureBox
    Friend WithEvents pbxThree As System.Windows.Forms.PictureBox
    Friend WithEvents pbxFour As System.Windows.Forms.PictureBox
    Friend WithEvents pbxFive As System.Windows.Forms.PictureBox
    Friend WithEvents pbxSix As System.Windows.Forms.PictureBox
    Friend WithEvents pbxSeven As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEight As System.Windows.Forms.PictureBox
    Friend WithEvents pbxNine As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEnemyNW As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEnemyNE As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEnemySW As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEnemySE As System.Windows.Forms.PictureBox
    Friend WithEvents pbxStrongEnemyNE As System.Windows.Forms.PictureBox
    Friend WithEvents pbxStrongEnemyNW As System.Windows.Forms.PictureBox
    Friend WithEvents pbxStrongEnemySE As System.Windows.Forms.PictureBox
    Friend WithEvents pbxStrongEnemySW As System.Windows.Forms.PictureBox
    Friend WithEvents pbxBulletLvl2Up As System.Windows.Forms.PictureBox
    Friend WithEvents pbxBulletLvl2Right As System.Windows.Forms.PictureBox
    Friend WithEvents pbxBulletLvl2Down As System.Windows.Forms.PictureBox
    Friend WithEvents pbxBulletLvl2Left As System.Windows.Forms.PictureBox
    Friend WithEvents pbxBulletLvl3Up As System.Windows.Forms.PictureBox
    Friend WithEvents pbxBulletLvl3Right As System.Windows.Forms.PictureBox
    Friend WithEvents pbxBulletLvl3Down As System.Windows.Forms.PictureBox
    Friend WithEvents pbxBulletLvl3Left As System.Windows.Forms.PictureBox
    Friend WithEvents pbxHealthUpgrade As System.Windows.Forms.PictureBox
    Friend WithEvents pbxDamageUpgrade As System.Windows.Forms.PictureBox
    Friend WithEvents pbxSpeedUpgrade As System.Windows.Forms.PictureBox
    Friend WithEvents pbxFirerateUpgrade As System.Windows.Forms.PictureBox
    Friend WithEvents pbxHealthDrop As System.Windows.Forms.PictureBox
    Friend WithEvents pbxShieldDrop As System.Windows.Forms.PictureBox
    Friend WithEvents pbxShieldBar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxShieldStealUpgrade As System.Windows.Forms.PictureBox
    Friend WithEvents lblShield As System.Windows.Forms.Label
    Friend WithEvents pbxEnemyMothership As System.Windows.Forms.PictureBox
    Friend WithEvents EnemyAttackTimer As System.Windows.Forms.Timer
    Friend WithEvents pbxBulletEnemyUp As System.Windows.Forms.PictureBox
    Friend WithEvents pbxBulletEnemyDown As System.Windows.Forms.PictureBox
    Friend WithEvents pbxBulletEnemyLeft As System.Windows.Forms.PictureBox
    Friend WithEvents pbxBulletEnemyRight As System.Windows.Forms.PictureBox
    Friend WithEvents AnimationTimer As System.Windows.Forms.Timer
    Friend WithEvents pbxAnimDeadEnemy8 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAnimDeadEnemy7 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAnimDeadEnemy6 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAnimDeadEnemy5 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAnimDeadEnemy1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAnimDeadEnemy4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAnimDeadEnemy3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAnimDeadEnemy2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAnimDeadMothership1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAnimDeadMothership2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAnimDeadMothership3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAnimDeadMothership4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAnimDeadMothership5 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAnimDeadMothership6 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAnimDeadMothership7 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAnimDeadMothership8 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEnemyShooterUp As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEnemyShooterDown As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEnemyShooterLeft As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEnemyShooterRight As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEnemyShooterNW As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEnemyShooterNE As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEnemyShooterSE As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEnemyShooterSW As System.Windows.Forms.PictureBox
    Friend WithEvents pbxRingShotUpgrade As System.Windows.Forms.PictureBox
    Friend WithEvents pbxDiagonalShotUpgrade As System.Windows.Forms.PictureBox
    Friend WithEvents pbxRingBullet As System.Windows.Forms.PictureBox
    Friend WithEvents pbxBulletNE As System.Windows.Forms.PictureBox
    Friend WithEvents pbxBulletNW As System.Windows.Forms.PictureBox
    Friend WithEvents pbxBulletSE As System.Windows.Forms.PictureBox
    Friend WithEvents pbxBulletSW As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCollectedUpgrades As System.Windows.Forms.PictureBox
    Friend WithEvents pbxZigZagUpgrade As System.Windows.Forms.PictureBox
    Friend WithEvents pbxGreenPlane As System.Windows.Forms.PictureBox
    Friend WithEvents pbxRepairsUpgrade As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEnemyKamikazeUp As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEnemyKamikazeRight As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEnemyKamikazeDown As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEnemyKamikazeLeft As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEnemyKamikazeNW As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEnemyKamikazeNE As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEnemyKamikazeSE As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEnemyKamikazeSW As System.Windows.Forms.PictureBox
    Friend WithEvents pbxSplitShotUpgrade As System.Windows.Forms.PictureBox
    Friend WithEvents pbxZero As System.Windows.Forms.PictureBox
    Friend WithEvents pbxSlothUpgrade As System.Windows.Forms.PictureBox
    Friend WithEvents ActiveItemTimer As System.Windows.Forms.Timer
    Friend WithEvents pbxAnimTimerFrame1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAnimTimerFrame2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAnimTimerFrame3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAnimTimerFrame4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAnimTimerFrame5 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAnimTimerFrame6 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAnimTimerFrame7 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAnimTimerFrame8 As System.Windows.Forms.PictureBox
    Friend WithEvents TimerTimer As System.Windows.Forms.Timer

End Class
