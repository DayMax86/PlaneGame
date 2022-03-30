Imports System.Drawing

REM -----------------------LIST OF KNOWN BUGS--------------------------
REM -FIXED--- Drops don't time out (they don't even spawn atm)
REM -FIXED--- Sometimes it spawns more enemies than the round limit
REM -FIXED--- Repairs heals you above the health limit
REM -FIXED--- Bullet shot speed is the same as the plane so bullets can overlap
REM ---- Occasionally freezes at the point when the last enemy dies in a round. Need more evidence for this one.
REM -FIXED--- Repairs doesn't disable shield properly - the bar stays there
REM -FIXED--- Shots still fire from the top left corner of the plane.
REM -MASKED--- Some rounds still end too early.
REM -MASKED--- Sometimes the final frame of the death animation crashes the game (very rare)
REM -FIXED--- Split shot bullets use the default image even if there is a UAM on the plane.
REM -FIXED--- ZigZag doesn't work with SplitShot (the split bullets freeze)
REM -FIXED--- Damage upgraded bullets fire from the bottom right of the plane (resize image files to fix).
REM -FIXED--- The round change graphic needs updating so that it works with double figures.
REM -FIXED--- Round 10 isn't working properly
REM -FIXED--- Existing bullets stop moving when the ZigZag upgrade is picked up.
REM -FIXED--- Shooter enemy movement needs to be adjusted so that they don't stick to the edges so much.
REM -FIXED--- Bullets don't seem to be deleted when they are off screen in round 6+ (This might just be zigzag shots).
REM -FIXED--- Kamikaze enemies don't work with sloth item. Nor do strong enemies.
REM ---- If you kill the kamikaze enemies by letting them hit you, the round ends early (deadEnemyCounter probs to blame).
REM ---- Round 11 is mental, like a million motherships appear.
REM ---- The animation for the item timeout is messed up horribly.
REM -------------------------------------------------------------------
REM ---------------------LIST OF BALANCE CHANGES-----------------------
REM ---- Strong enemies need faster diagonal movement speed.
REM ---- Motherships need to drop fewer things.
REM ---- More Kamikaze planes in round 8.
REM ---- Need to cap the fire rate at 3 upgrades.
REM -------------------------------------------------------------------

Public Class Form1

    Public Shared DisplayWidth, DisplayHeight As Integer

    Dim FrameCount As Integer
    Dim FrameTimer As Integer
    Dim FrameRate As Integer
    Dim frameCounterFireRate As Integer
    Dim tempFrameDrawingCounter As Integer
    Dim frameCounterMovementChange As Integer
    Dim diagonalShotCounter As Integer
    Dim tempHealingCounter As Integer = 0
    Dim backgroundAnimCounter As Integer = 0
    Public numberOfMothershipSpawns As Integer = 0

    Public upgradeTaken As Boolean = True
    Dim gamePaused As Boolean = False
    Public fireRate As Integer = 5

    Dim roundNumber As Integer = 0
    Dim enemyCounter As Integer = 0
    Public deadEnemyCounter As Integer = 0
    Public spawnedEnemyCounter As Integer = 0
    Dim currentRound As New Round(0)
    Dim canWipeRoundGraphic As Boolean = True

    Dim stayInY As Boolean
    Dim stayInX As Boolean

    Dim pbxFullScreen As PictureBox
    Dim showInfoBox As Boolean = False

    Public Plane As PlaneSprite
    Dim bmpSurface As Bitmap
    Dim gfxSurface As Graphics
    Dim bmpHealthBar As Bitmap
    Dim gfxHealthBar As Graphics
    Dim bmpShieldBar As Bitmap
    Dim gfxShieldBar As Graphics
    Dim bmpInfo As Bitmap
    Dim gfxInfo As Graphics
    Dim gfxFullScreen As Graphics
    Dim bmpFullScreen As Bitmap
    Public alProjectile As ArrayList
    Dim alEnemyProjectile As ArrayList
    Public alAnimation As ArrayList
    Dim alDeadAnim As ArrayList
    Public alItem As ArrayList
    Public alCollectedUpgrades As ArrayList
    Dim ReturnInfo As New System.Text.StringBuilder() With {.Capacity = 255}
    Dim srcBmp As Bitmap
    Public alGlobalBin As ArrayList REM Global variables

    <System.Runtime.InteropServices.
DllImport("winmm.dll", SetLastError:=True)>
    Private Shared Function mciSendString(
            ByVal command As String,
            ByVal buffer As System.Text.StringBuilder,
            ByVal bufferSize As Integer,
            ByVal hwndCallback As IntPtr
    ) As Integer
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim err As UInt32 = 1
        err = mciSendString("open C:\Users\Max\Music\PlaneGameSounds\Laser.wav type waveaudio alias Laser", ReturnInfo, ReturnInfo.Capacity, IntPtr.Zero)
        err = mciSendString("open C:\Users\Max\Music\PlaneGameSounds\GameOver.wav type waveaudio alias GameOver", ReturnInfo, ReturnInfo.Capacity, IntPtr.Zero)
        err = mciSendString("open C:\Users\Max\Music\PlaneGameSounds\arwingHitGround.wav type waveaudio alias EnemyFire", ReturnInfo, ReturnInfo.Capacity, IntPtr.Zero)
        err = mciSendString("open C:\Users\Max\Music\PlaneGameSounds\BombExplode.wav type waveaudio alias Bomb", ReturnInfo, ReturnInfo.Capacity, IntPtr.Zero)

        pbxHealthBar.BackColor = Color.Empty
        pbxShieldBar.BackColor = Color.Empty

        alProjectile = New ArrayList
        alEnemyProjectile = New ArrayList
        alItem = New ArrayList
        alAnimation = New ArrayList
        alDeadAnim = New ArrayList
        alCollectedUpgrades = New ArrayList
        alGlobalBin = New ArrayList

        AnimationTimer.Enabled = True

        Me.Width = 1400
        Me.Height = 780

        DisplayHeight = Display.Height
        DisplayWidth = Display.Width

        Plane = New PlaneSprite(pbxGreenPlane.Image, ((DisplayWidth / 2) - 32), ((DisplayHeight / 2) - 32), 100)

        bmpSurface = New Bitmap(Display.Width, Display.Height)
        gfxSurface = Graphics.FromImage(bmpSurface)
        Display.Image = bmpSurface
        pbxHealthBar.Image = bmpHealthBar

        bmpHealthBar = New Bitmap(pbxHealthBar.Width + 500, pbxHealthBar.Height)
        gfxHealthBar = Graphics.FromImage(bmpHealthBar)

        bmpShieldBar = New Bitmap(pbxShieldBar.Width, pbxShieldBar.Height)
        gfxShieldBar = Graphics.FromImage(bmpShieldBar)

        bmpInfo = New Bitmap(pbxCollectedUpgrades.Width, pbxCollectedUpgrades.Height)
        gfxInfo = Graphics.FromImage(bmpInfo)

        bmpFullScreen = New Bitmap(Me.Width, Me.Height)
        gfxFullScreen = Graphics.FromImage(bmpFullScreen)
        pbxFullScreen = New PictureBox()
        pbxFullScreen.Height = Me.Height
        pbxFullScreen.Width = Me.Width
        pbxFullScreen.Image = Nothing

        Plane.PlaneHeight = pbxPlane.Height
        Plane.PlaneWidth = pbxPlane.Width

        Plane.xPos = ((DisplayWidth / 2) - (Plane.PlaneWidth))
        Plane.yPos = ((DisplayHeight / 2) - (Plane.PlaneHeight))
        Plane.Image = pbxGreenPlane.Image

        srcBmp = New Bitmap(My.Resources.ScrollingPrototype)

        Plane.uniqueAttackModifier = ShotTypes.None
        Plane.shielded = True

        EnemyAttackTimer.Enabled = True

        REM TESTING ONLY
        'currentRound.roundNumber = 1
        'SpawnTimer.Interval = 5000
        Plane.activeItem = New ActiveItem(pbxSlothUpgrade.Image, 0, 0, 5000, ActiveItems.Sloth)
        'AnimationTimer.Interval = 1000
        REM ------------------------------

        GameTimer.Enabled = True

    End Sub

    Public Enum enemyTypes
        basic
        strong
        mothership
        shooter
        kamikaze
    End Enum

    Public Sub MakeEnemy(ByVal enemyType As enemyTypes, ByVal numberOfEnemies As Integer)
        Dim i As Integer = 0
        Do Until i = numberOfEnemies
            If Not gamePaused Then
                Randomize()
                Dim rndmX As Integer = Rnd() * (DisplayWidth)
                Dim rndmY As Integer = Rnd() * (DisplayHeight)
                Dim spawnX As Integer
                Dim spawnY As Integer
                Dim rndmNum As Integer
                rndmNum = Rnd() * 1000
                If rndmNum < 500 Then
                    REM do random in x
                    If rndmX < (DisplayWidth / 2) Then
                        spawnY = 0
                    Else
                        spawnY = (DisplayHeight) - pbxEnemyShooterDown.Height
                    End If
                    spawnX = Rnd() * ((DisplayWidth) - pbxEnemyShooterDown.Width)
                Else
                    REM do random in y
                    If rndmY < (DisplayHeight / 2) Then
                        spawnX = 0
                    Else
                        spawnX = (DisplayWidth) - pbxEnemyShooterDown.Width
                    End If
                    spawnY = Rnd() * ((DisplayHeight) - pbxEnemyShooterDown.Height)
                End If
                Select Case enemyType
                    Case enemyTypes.basic
                        alProjectile.Add(New Enemy(pbxEnemyDown.Image, spawnX, spawnY, 100))
                    Case enemyTypes.strong
                        alProjectile.Add(New StrongEnemy(pbxStrongEnemyDown.Image, spawnX, spawnY, 200))
                    Case enemyTypes.mothership
                        alProjectile.Add(New Mothership(pbxEnemyMothership.Image, spawnX, spawnY, 2000))
                    Case enemyTypes.shooter
                        alProjectile.Add(New ShooterEnemy(pbxEnemyShooterDown.Image, spawnX, spawnY, 400))
                    Case enemyTypes.kamikaze
                        alProjectile.Add(New KamikazeEnemy(pbxEnemyKamikazeDown.Image, spawnX, spawnY, 200))
                End Select
                spawnedEnemyCounter += 1
            End If
            i += 1
        Loop
    End Sub

    Public Enum Directions
        Up
        Down
        Left
        Right
        NE
        NW
        SE
        SW
    End Enum

    Public Enum ShotTypes
        RingShot
        None
    End Enum

    Public Sub ShootBullet(ByVal dir As Directions)

        Select Case Plane.uniqueAttackModifier
            Case ShotTypes.None
                REM no UAM picked up so normal bullets used

                If Plane.diagonalShot = True Then
                    diagonalShotCounter += 1
                    If diagonalShotCounter >= 10 Then
                        alProjectile.Add(New Bullet(pbxBulletNE.Image, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, Directions.NE))
                        alProjectile.Add(New Bullet(pbxBulletNW.Image, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, Directions.NW))
                        alProjectile.Add(New Bullet(pbxBulletSE.Image, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, Directions.SE))
                        alProjectile.Add(New Bullet(pbxBulletSW.Image, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, Directions.SW))
                        diagonalShotCounter = 0
                    End If
                End If
                If Plane.zigZagShot Then
                    Select Case dir
                        Case Directions.Up
                            alProjectile.Add(New ZigZagBullet(pbxBulletNW.Image, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, Directions.NW, Directions.NE))
                        Case Directions.Down
                            alProjectile.Add(New ZigZagBullet(pbxBulletSE.Image, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, Directions.SE, Directions.SW))
                        Case Directions.Right
                            alProjectile.Add(New ZigZagBullet(pbxBulletNE.Image, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, Directions.NE, Directions.SE))
                        Case Directions.Left
                            alProjectile.Add(New ZigZagBullet(pbxBulletSW.Image, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, Directions.SW, Directions.NW))
                    End Select
                Else
                    Select Case Plane.Damage
                        Case 1 To 49
                            Select Case dir
                                Case Directions.Up
                                    alProjectile.Add(New Bullet(pbxBulletLvl1Up.Image, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, dir))
                                Case Directions.Down
                                    alProjectile.Add(New Bullet(pbxBulletLvl1Down.Image, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, dir))
                                Case Directions.Right
                                    alProjectile.Add(New Bullet(pbxBulletLvl1Right.Image, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, dir))
                                Case Directions.Left
                                    alProjectile.Add(New Bullet(pbxBulletLvl1Left.Image, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, dir))
                            End Select
                        Case 50 To 99
                            Select Case dir
                                Case Directions.Up
                                    alProjectile.Add(New Bullet(pbxBulletLvl2Up.Image, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, dir))
                                Case Directions.Down
                                    alProjectile.Add(New Bullet(pbxBulletLvl2Down.Image, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, dir))
                                Case Directions.Right
                                    alProjectile.Add(New Bullet(pbxBulletLvl2Right.Image, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, dir))
                                Case Directions.Left
                                    alProjectile.Add(New Bullet(pbxBulletLvl2Left.Image, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, dir))
                            End Select
                        Case 100 To 199
                            Select Case dir
                                Case Directions.Up
                                    alProjectile.Add(New Bullet(pbxBulletLvl3Up.Image, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, dir))
                                Case Directions.Down
                                    alProjectile.Add(New Bullet(pbxBulletLvl3Down.Image, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, dir))
                                Case Directions.Right
                                    alProjectile.Add(New Bullet(pbxBulletLvl3Right.Image, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, dir))
                                Case Directions.Left
                                    alProjectile.Add(New Bullet(pbxBulletLvl3Left.Image, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, dir))
                            End Select
                        Case 200 To 499
                            REM need to make resprite1s for this level if necessary
                    End Select
                End If
            Case Else REM must have a UAM
                If Plane.zigZagShot Then
                    Select Case dir
                        Case Directions.Up
                            alProjectile.Add(New ZigZagBullet(Plane.bulletImage, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, Directions.NW, Directions.NE))
                        Case Directions.Down
                            alProjectile.Add(New ZigZagBullet(Plane.bulletImage, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, Directions.SE, Directions.SW))
                        Case Directions.Right
                            alProjectile.Add(New ZigZagBullet(Plane.bulletImage, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, Directions.NE, Directions.SE))
                        Case Directions.Left
                            alProjectile.Add(New ZigZagBullet(Plane.bulletImage, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, Directions.SW, Directions.NW))
                    End Select
                Else
                    alProjectile.Add(New Bullet(Plane.bulletImage, (Plane.xPos + (Plane.Image.Width / 2)) - Plane.bulletImage.Width / 2, (Plane.yPos + (Plane.Image.Height / 2)) - Plane.bulletImage.Height / 2, 1, dir))
                End If
                If Plane.diagonalShot Then
                    diagonalShotCounter += 1
                    If diagonalShotCounter >= 10 Then
                        alProjectile.Add(New Bullet(Plane.bulletImage, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, Directions.NE))
                        alProjectile.Add(New Bullet(Plane.bulletImage, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, Directions.NW))
                        alProjectile.Add(New Bullet(Plane.bulletImage, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, Directions.SE))
                        alProjectile.Add(New Bullet(Plane.bulletImage, (Plane.xPos + (Plane.Image.Width / 2)), (Plane.yPos + (Plane.Image.Height / 2)), 1, Directions.SW))
                        diagonalShotCounter = 0
                    End If
                End If
        End Select

        Try
            mciSendString("play Laser from 0", ReturnInfo, ReturnInfo.Capacity, IntPtr.Zero)
        Catch ex As Exception
            MsgBox("Error loading sound")
        End Try
        Label1.Text = alProjectile.Count
    End Sub

    Public Sub DrawBackground()

        Dim y As Integer = 0
        If backgroundAnimCounter >= 2160 Then : backgroundAnimCounter = 0 : End If
        y = backgroundAnimCounter

        Dim srcRect1 As Rectangle
        Dim destRect1 As Rectangle
        Dim srcRect2 As Rectangle
        Dim destRect2 As Rectangle
        Dim overlapAmount As Integer = (y - 1440)

        If overlapAmount < 0 Then
            srcRect1 = New Rectangle(0, y, DisplayWidth, DisplayHeight)
            destRect1 = New Rectangle(0, 0, DisplayWidth, DisplayHeight)
        Else
            srcRect1 = New Rectangle(0, y, DisplayWidth, (DisplayHeight - overlapAmount))
            destRect1 = New Rectangle(0, 0, DisplayWidth, (DisplayHeight - overlapAmount))
        End If
        If overlapAmount < 0 Then
            srcRect2 = New Rectangle(0, y, DisplayWidth, 0)
            destRect2 = New Rectangle(0, 0, DisplayWidth, 0)
        Else
            srcRect2 = New Rectangle(0, 0, DisplayWidth, overlapAmount)
            destRect2 = New Rectangle(0, (DisplayHeight - overlapAmount), DisplayWidth, overlapAmount)
        End If

        gfxSurface.DrawImage(srcBmp, destRect1, srcRect1, GraphicsUnit.Pixel)
        gfxSurface.DrawImage(srcBmp, destRect2, srcRect2, GraphicsUnit.Pixel)

    End Sub

    Public Sub DrawHealthBar()
        gfxHealthBar.Clear(Color.DarkGray)
        Dim healthPercentage As Integer = (Plane.Health / Plane.maximumHealth) * 100
        Dim rect As New Rectangle(0, 0, (Math.Ceiling((healthPercentage / 100) * pbxHealthBar.Width)), pbxHealthBar.Height)
        Dim myBrush As New System.Drawing.SolidBrush(System.Drawing.Color.DarkRed)
        Dim myPen As New Pen(myBrush)
        gfxHealthBar.DrawRectangle(myPen, rect)
        gfxHealthBar.FillRectangle(myBrush, rect)
        pbxHealthBar.Image = bmpHealthBar
    End Sub

    Public Sub DrawShieldBar()
        gfxSurface.DrawImage(Plane.Image, Plane.xPos, Plane.yPos)
        If Plane.shielded Then
            gfxShieldBar.Clear(Color.DarkGray)
            Dim rect2 As New Rectangle(0, 0, (Math.Ceiling((Plane.shieldStrength / Plane.maximumShieldStrength) * 100)), pbxShieldBar.Height)
            Dim myBrush2 As New System.Drawing.SolidBrush(System.Drawing.Color.ForestGreen)
            Dim myPen2 As New Pen(myBrush2)
            gfxShieldBar.DrawRectangle(myPen2, rect2)
            gfxShieldBar.FillRectangle(myBrush2, rect2)
            pbxShieldBar.Image = bmpShieldBar
        Else
            pbxShieldBar.Dispose()
        End If
    End Sub

    Public Sub Draw()

        DrawBackground()
        DrawHealthBar()
        If Plane.shieldStrength >= 0 Then
            DrawShieldBar()
        Else
            pbxShieldBar.Dispose()
        End If
        DrawInfoBox()
        DrawItems()
        DrawProjectiles()
        DrawAnimations()
        DrawRoundGraphics()

    End Sub

    Public Sub DrawRoundGraphics()
        REM draws the round graphic and the info in the top right
        gfxSurface.DrawString("Round " + currentRound.roundNumber.ToString(), DefaultFont, New System.Drawing.SolidBrush(Color.NavajoWhite), 1195, 20)
        gfxSurface.DrawString(("Enemies Remaining " + (currentRound.maxEnemyCount - deadEnemyCounter).ToString()), DefaultFont, Brushes.NavajoWhite, 1130, 40)
        If Not canWipeRoundGraphic Then
            gfxSurface.DrawImage(pbxRound.Image, CInt((DisplayWidth / 2) - (pbxRound.Width / 2)), CInt((DisplayHeight / 2) - (pbxRound.Height / 2)))
            Select Case currentRound.roundNumber
                Case 1 : gfxSurface.DrawImage(pbxOne.Image, CInt((DisplayWidth / 2) - (pbxRound.Width / 2)) + pbxRound.Image.Width, CInt((DisplayHeight / 2) - (pbxRound.Height / 2)))
                Case 2 : gfxSurface.DrawImage(pbxTwo.Image, CInt((DisplayWidth / 2) - (pbxRound.Width / 2)) + pbxRound.Image.Width, CInt((DisplayHeight / 2) - (pbxRound.Height / 2)))
                Case 3 : gfxSurface.DrawImage(pbxThree.Image, CInt((DisplayWidth / 2) - (pbxRound.Width / 2)) + pbxRound.Image.Width, CInt((DisplayHeight / 2) - (pbxRound.Height / 2)))
                Case 4 : gfxSurface.DrawImage(pbxFour.Image, CInt((DisplayWidth / 2) - (pbxRound.Width / 2)) + pbxRound.Image.Width, CInt((DisplayHeight / 2) - (pbxRound.Height / 2)))
                Case 5 : gfxSurface.DrawImage(pbxFive.Image, CInt((DisplayWidth / 2) - (pbxRound.Width / 2)) + pbxRound.Image.Width, CInt((DisplayHeight / 2) - (pbxRound.Height / 2)))
                Case 6 : gfxSurface.DrawImage(pbxSix.Image, CInt((DisplayWidth / 2) - (pbxRound.Width / 2)) + pbxRound.Image.Width, CInt((DisplayHeight / 2) - (pbxRound.Height / 2)))
                Case 7 : gfxSurface.DrawImage(pbxSeven.Image, CInt((DisplayWidth / 2) - (pbxRound.Width / 2)) + pbxRound.Image.Width, CInt((DisplayHeight / 2) - (pbxRound.Height / 2)))
                Case 8 : gfxSurface.DrawImage(pbxEight.Image, CInt((DisplayWidth / 2) - (pbxRound.Width / 2)) + pbxRound.Image.Width, CInt((DisplayHeight / 2) - (pbxRound.Height / 2)))
                Case 9 : gfxSurface.DrawImage(pbxNine.Image, CInt((DisplayWidth / 2) - (pbxRound.Width / 2)) + pbxRound.Image.Width, CInt((DisplayHeight / 2) - (pbxRound.Height / 2)))
                Case 10 : gfxSurface.DrawImage(pbxOne.Image, CInt((DisplayWidth / 2) - (pbxRound.Width / 2)) + pbxRound.Image.Width, CInt((DisplayHeight / 2) - (pbxRound.Height / 2))) : gfxSurface.DrawImage(pbxZero.Image, (CInt((DisplayWidth / 2) - (pbxRound.Width / 2)) + pbxRound.Image.Width + CInt(pbxOne.Width / 2)), CInt((DisplayHeight / 2) - (pbxRound.Height / 2)))
                Case 11 : gfxSurface.DrawImage(pbxOne.Image, CInt((DisplayWidth / 2) - (pbxRound.Width / 2)) + pbxRound.Image.Width, CInt((DisplayHeight / 2) - (pbxRound.Height / 2))) : gfxSurface.DrawImage(pbxOne.Image, (CInt((DisplayWidth / 2) - (pbxRound.Width / 2)) + pbxRound.Image.Width + CInt(pbxOne.Width / 2)), CInt((DisplayHeight / 2) - (pbxRound.Height / 2)))
                Case 12 : gfxSurface.DrawImage(pbxOne.Image, CInt((DisplayWidth / 2) - (pbxRound.Width / 2)) + pbxRound.Image.Width, CInt((DisplayHeight / 2) - (pbxRound.Height / 2))) : gfxSurface.DrawImage(pbxTwo.Image, (CInt((DisplayWidth / 2) - (pbxRound.Width / 2)) + pbxRound.Image.Width + CInt(pbxOne.Width / 2)), CInt((DisplayHeight / 2) - (pbxRound.Height / 2)))
                Case 13 : gfxSurface.DrawImage(pbxOne.Image, CInt((DisplayWidth / 2) - (pbxRound.Width / 2)) + pbxRound.Image.Width, CInt((DisplayHeight / 2) - (pbxRound.Height / 2))) : gfxSurface.DrawImage(pbxThree.Image, (CInt((DisplayWidth / 2) - (pbxRound.Width / 2)) + pbxRound.Image.Width + CInt(pbxOne.Width / 2)), CInt((DisplayHeight / 2) - (pbxRound.Height / 2)))
                Case 14 : gfxSurface.DrawImage(pbxOne.Image, CInt((DisplayWidth / 2) - (pbxRound.Width / 2)) + pbxRound.Image.Width, CInt((DisplayHeight / 2) - (pbxRound.Height / 2))) : gfxSurface.DrawImage(pbxFour.Image, (CInt((DisplayWidth / 2) - (pbxRound.Width / 2)) + pbxRound.Image.Width + CInt(pbxOne.Width / 2)), CInt((DisplayHeight / 2) - (pbxRound.Height / 2)))
            End Select
        End If

        lblLife.Text = "Life :" & Plane.Health.ToString()
        lblShield.Text = "S :" & Plane.shieldStrength.ToString() & "/" & Plane.maximumShieldStrength.ToString()
    End Sub

    Public Sub DrawInfoBox()
        'Select Case upgrade
        '    Case Upgrades.ZigZagShot
        'End Select
        'Dim mypen As New Pen(Brushes.Yellow, 10)
        'gfxFullScreen.DrawRectangle(mypen, (Cursor.Position.X), (Cursor.Position.Y), 500, 500)
        'pbxFullScreen.Image = bmpFullScreen

        REM below is a WIP
        Dim x1, y1 As Integer
        x1 = 0 : y1 = 0
        gfxInfo.Clear(Color.DarkGray)
        For Each UGrade In alCollectedUpgrades
            gfxInfo.DrawImage(UGrade.image, x1, y1)
            y1 += (pbxHealthUpgrade.Height)
        Next
        pbxCollectedUpgrades.Image = bmpInfo
        '------------------------------------------------------------
    End Sub

    Public Sub DrawItems()
        For Each Item In alItem
            gfxSurface.DrawImage(Item.image, CInt(Item.xpos), CInt(Item.ypos))
        Next Item
        If Not Plane.activeItem Is Nothing Then
            gfxSurface.DrawImage(Plane.activeItem.Image, 5, 30)
        End If
    End Sub

    Private Sub MoveProjectiles()
        Dim dead As New ArrayList

        For Each eBullet As EnemyBullet In alEnemyProjectile
            Select Case eBullet.movementDir
                Case Directions.Down
                    eBullet.DownMove()
                Case Directions.Up
                    eBullet.UpMove()
                Case Directions.Left
                    eBullet.LeftMove()
                Case Directions.Right
                    eBullet.RightMove()
                Case Directions.NE
                    eBullet.NEMove()
                Case Directions.NW
                    eBullet.NWMove()
                Case Directions.SE
                    eBullet.SEMove()
                Case Directions.SW
                    eBullet.SWMove()
            End Select
        Next


        For Each sprite In alProjectile
            If sprite.GetType().Equals(GetType(Bullet)) Then
                Select Case sprite.movementDir
                    Case Directions.Up
                        sprite.UpMove()
                    Case Directions.Down
                        sprite.DownMove()
                    Case Directions.Right
                        sprite.RightMove()
                    Case Directions.Left
                        sprite.LeftMove()
                    Case Directions.NE
                        sprite.NEMove()
                    Case Directions.NW
                        sprite.NWMove()
                    Case Directions.SE
                        sprite.SEMove()
                    Case Directions.SW
                        sprite.SWMove()
                End Select
            ElseIf sprite.GetType().Equals(GetType(ZigZagBullet)) Then
                CType(sprite, ZigZagBullet).frameCounter += 1
                If CType(sprite, ZigZagBullet).frameCounter >= 5 Then
                    Select Case CType(sprite, ZigZagBullet).nextMovementDir
                        Case Directions.NE : sprite.NEMove()
                            CType(sprite, ZigZagBullet).nextMovementDir = sprite.movementDir
                            sprite.movementDir = Directions.NE
                        Case Directions.NW : sprite.NWMove()
                            CType(sprite, ZigZagBullet).nextMovementDir = sprite.movementDir
                            sprite.movementDir = Directions.NW
                        Case Directions.SE : sprite.SEMove()
                            CType(sprite, ZigZagBullet).nextMovementDir = sprite.movementDir
                            sprite.movementDir = Directions.SE
                        Case Directions.SW : sprite.SWMove()
                            CType(sprite, ZigZagBullet).nextMovementDir = sprite.movementDir
                            sprite.movementDir = Directions.SW
                    End Select
                    CType(sprite, ZigZagBullet).frameCounter = 0
                Else REM must be the first movement
                    Select Case sprite.movementDir
                        Case Directions.NE : sprite.NEMove()
                        Case Directions.NW : sprite.NWMove()
                        Case Directions.SE : sprite.SEMove()
                        Case Directions.SW : sprite.SWMove()
                    End Select
                End If
            ElseIf sprite.GetType().Equals(GetType(ShooterEnemy)) Then
                Select Case sprite.movementDir
                    Case Directions.Up
                        sprite.UpMove()
                    Case Directions.Down
                        sprite.DownMove()
                    Case Directions.Left
                        sprite.LeftMove()
                    Case Directions.Right
                        sprite.RightMove()
                End Select
            ElseIf sprite.GetType().Equals(GetType(Mothership)) Then
                Dim targetX As Integer
                Dim targetY As Integer
                If sprite.numberOfSteps >= CType(sprite, Mothership).MovementTimer Or sprite.numberOfSteps = 0 Then
                    REM give new target
                    Randomize()
                    targetX = (Rnd() * (Display.Width - sprite.Image.Width))
                    targetY = (Rnd() * (Display.Height - sprite.Image.Height))
                    If sprite.Xpos < targetX Then
                        sprite.RightMove()
                    End If
                    If sprite.Xpos > targetX Then
                        sprite.LeftMove()
                    End If
                    If sprite.Ypos < targetY Then
                        sprite.DownMove()
                        CType(sprite, Mothership).movementDir1 = Directions.Down
                    End If
                    If sprite.Ypos > targetY Then
                        sprite.UpMove()
                        CType(sprite, Mothership).movementDir1 = Directions.Up
                    End If
                    sprite.numberOfSteps = 0
                Else
                    Select Case CType(sprite, Mothership).movementDir1
                        Case Directions.Down
                            sprite.DownMove()
                        Case Directions.Up
                            sprite.UpMove()
                    End Select
                    Select Case CType(sprite, Mothership).movementDir
                        Case Directions.Left
                            sprite.LeftMove()
                        Case Directions.Right
                            sprite.RightMove()
                    End Select

                End If
                sprite.numberOfSteps += 1
            ElseIf sprite.isHostile() Then
                REM need to do a check first to see which axis it is out in, if both then choose randomly, otherwise do the one that's not equal
                Dim moveInThisDir As Directions
                REM need some variable to store the points for each direction which will be used to determine the plane's movement
                REM 2D array, the directions start at North (up) and go clockwise from 1 to 8. The second number is the amount of times it is mentioned in the following algorithm.
                Dim dirScores(8) As Integer
                REM N (Up) = 1
                REM NE = 2
                REM E (Right) = 3
                REM SE = 4
                REM S (Down) = 5
                REM SW = 6
                REM W (Left) = 7
                REM NW = 8

                REM This condition below makes sure it only does this once it has moved in the same direction for the right amount of time
                If sprite.numberOfSteps >= 20 Then
                    REM Choose a target coordinate somewhere near the player, then generate a new target once they've met it
                    If sprite.Xpos > Plane.xPos Then
                        REM sprite is to the right of the plane, should only move W, NW, SW.
                        dirScores(7) += 2 'W
                        dirScores(8) += 1 'NW
                        dirScores(6) += 1 'SW
                    End If
                    If sprite.Xpos < Plane.xPos Then
                        REM sprite is to the left of the plane, should only move E, NE, SE.
                        dirScores(3) += 2 'E
                        dirScores(2) += 1 'NE
                        dirScores(4) += 1 'SE
                    End If
                    If sprite.Ypos > Plane.yPos Then
                        REM sprite is below the plane, should only move NW, N, NE.
                        dirScores(8) += 1 'NW
                        dirScores(1) += 2 'N
                        dirScores(2) += 1 'NE
                    End If
                    If sprite.Ypos < Plane.yPos Then
                        REM sprite is above the plane, should only move SW, S, SE.
                        dirScores(6) += 1 'SW
                        dirScores(5) += 2 'S
                        dirScores(4) += 1 'SE
                    End If

                    Dim x As Integer
                    For x = 1 To 8
                        Select Case x
                            Case 1 : If Math.Abs(Plane.xPos - sprite.Xpos) < 25 And sprite.Ypos > Plane.yPos Then 'N
                                    dirScores(1) += 4
                                End If
                            Case 2 : If (Plane.xPos - sprite.Xpos > 0) And (Plane.yPos - sprite.Ypos < 0) And (-1 > (Math.Abs(Plane.xPos - sprite.Xpos) - (Math.Abs(Plane.yPos - sprite.Ypos))) < 1) Then 'NE
                                    dirScores(2) += 2
                                End If
                            Case 3 : If Math.Abs(Plane.yPos - sprite.Ypos) < 25 And sprite.Xpos < Plane.xPos Then 'E
                                    dirScores(3) += 4
                                End If
                            Case 4 : If (Plane.xPos - sprite.Xpos > 0) And (Plane.yPos - sprite.Ypos > 0) And (-1 > (Math.Abs(Plane.xPos - sprite.Xpos) - (Math.Abs(Plane.yPos - sprite.Ypos))) < 1) Then 'SE
                                    dirScores(4) += 2
                                End If
                            Case 5 : If Math.Abs(Plane.xPos - sprite.Xpos) < 25 And sprite.Ypos < Plane.yPos Then 'S
                                    dirScores(5) += 4
                                End If
                            Case 6 : If (Plane.xPos - sprite.Xpos < 0) And (Plane.yPos - sprite.Ypos > 0) And (-1 > (Math.Abs(Plane.xPos - sprite.Xpos) - (Math.Abs(Plane.yPos - sprite.Ypos))) < 1) Then 'SW
                                    dirScores(6) += 2
                                End If
                            Case 7 : If Math.Abs(Plane.yPos - sprite.Ypos) < 25 And sprite.Xpos > Plane.xPos Then 'W
                                    dirScores(7) += 4
                                End If
                            Case 8 : If (Plane.xPos - sprite.Xpos < 0) And (Plane.yPos - sprite.Ypos < 0) And (-1 > (Math.Abs(Plane.xPos - sprite.Xpos) - (Math.Abs(Plane.yPos - sprite.Ypos))) < 1) Then 'NW
                                    dirScores(8) += 2
                                End If
                        End Select
                    Next

                    REM now we need to see which directions have the highest scores and choose between them
                    Dim highestScore As Integer = 0
                    Dim highestScoringDirections As New ArrayList()
                    Dim i As Integer
                    For i = 1 To 8
                        If dirScores(i) > highestScore Then
                            highestScore = dirScores(i)
                        End If
                    Next

                    Dim u As Integer
                    For u = 1 To 8
                        If dirScores(u) = highestScore Then
                            Select Case u
                                Case 1 'N
                                    highestScoringDirections.Add(Directions.Up)
                                Case 2 'NE
                                    highestScoringDirections.Add(Directions.NE)
                                Case 3 'E
                                    highestScoringDirections.Add(Directions.Right)
                                Case 4 'SE
                                    highestScoringDirections.Add(Directions.SE)
                                Case 5 'S
                                    highestScoringDirections.Add(Directions.Down)
                                Case 6 'SW
                                    highestScoringDirections.Add(Directions.SW)
                                Case 7 'W
                                    highestScoringDirections.Add(Directions.Left)
                                Case 8 'NW
                                    highestScoringDirections.Add(Directions.NW)
                            End Select
                        End If
                    Next

                    REM now we have the compatible directions, we need to choose between them randomly
                    Dim rndNum As Integer
                    rndNum = CInt(Math.Floor(highestScoringDirections.Count * Rnd()))
                    moveInThisDir = highestScoringDirections(rndNum)

                    Select Case moveInThisDir
                        Case Directions.Up
                            sprite.UpMove()
                        Case Directions.NE
                            sprite.NEMove()
                        Case Directions.Right
                            sprite.RightMove()
                        Case Directions.SE
                            sprite.SEMove()
                        Case Directions.Down
                            sprite.DownMove()
                        Case Directions.SW
                            sprite.SWMove()
                        Case Directions.Left
                            sprite.LeftMove()
                        Case Directions.NW
                            sprite.NWMove()
                    End Select

                    REM wipe the variable so that it will be another x steps before it changes direction again
                    sprite.numberOfSteps = 1
                ElseIf sprite.numberOfSteps = 0 Then REM this means that the sprite needs to be given a starting direction
                    If sprite.Xpos <= Plane.xPos Then
                        sprite.RightMove()
                    ElseIf sprite.Ypos <= Plane.yPos Then
                        sprite.DownMove()
                    ElseIf sprite.Xpos > Plane.xPos Then
                        sprite.LeftMove()
                    ElseIf sprite.Xpos > Plane.xPos Then
                        sprite.UpMove()
                    Else
                        sprite.DefaultMove()
                    End If
                Else REM it must still have to move in the same direction
                    Select Case sprite.movementDir
                        Case Directions.Up
                            sprite.UpMove()
                        Case Directions.NE
                            sprite.NEMove()
                        Case Directions.Right
                            sprite.RightMove()
                        Case Directions.SE
                            sprite.SEMove()
                        Case Directions.Down
                            sprite.DownMove()
                        Case Directions.SW
                            sprite.SWMove()
                        Case Directions.Left
                            sprite.LeftMove()
                        Case Directions.NW
                            sprite.NWMove()
                    End Select
                End If
                If sprite.IsOffScreen() Or sprite.Health < 1 Then
                    dead.Add(sprite)
                End If
            End If
        Next

        For Each sprite In dead
            alProjectile.Remove(sprite)
        Next
        For Each Sprite1 In alGlobalBin
            alProjectile.Remove(Sprite1)
        Next

    End Sub
    Public Sub DrawProjectiles()

        Dim dead As New ArrayList

        For Each eBullet As EnemyBullet In alEnemyProjectile
            gfxSurface.DrawImage(eBullet.Image, CInt(eBullet.Xpos), CInt(eBullet.Ypos))
        Next

        For Each sprite As Sprite In alProjectile
            gfxSurface.DrawImage(sprite.Image, CInt(sprite.Xpos), CInt(sprite.Ypos))
        Next sprite

        Label1.Text = alProjectile.Count

    End Sub

    Private Sub DrawAnimations()
        Try
            For Each sprite1 As Sprite In alAnimation
                Dim img As Bitmap = New Bitmap(sprite1.Image.Width, sprite1.Image.Height)
                img = sprite1.animationImage
                gfxSurface.DrawImage(img, CInt(sprite1.Xpos), CInt(sprite1.Ypos))
            Next
        Catch ex As Exception
            MsgBox("Error in animation, most likely nothing set to img variable")
        End Try
    End Sub

    Public Sub AddSprite(ByRef list As ArrayList, ByRef sprite As Sprite)
        If (Not list.Contains(sprite)) Then
            list.Add(sprite)
        End If
    End Sub

    Public Sub CheckCollisions()
        ' Check each sprite for collision with any other
        Dim sprite1, sprite2 As Sprite
        Dim dead As New ArrayList
        Dim dmg As Integer
        Dim DestAl As New ArrayList

        For Each sprite1 In alProjectile
            For Each sprite2 In alProjectile
                If (sprite1 IsNot sprite2) And sprite1.IsColliding(sprite2) Then
                    If sprite1.OnCollision(sprite2) Then
                        dmg = sprite2.Damage
                        sprite1.LoseHealth(dmg)
                        If sprite1.Health < 1 Then
                            AddSprite(dead, sprite1)
                            'dead.Add(sprite1)
                            If TypeOf sprite1 Is Enemy Then
                                If TypeOf sprite2 Is Bullet And Plane.splitShot = True Then
                                    REM needs to know the direction of the bullet before it splits
                                    REM if the plane has the ZigZag upgrade then a seperate case needs to be added
                                    AddSplitShotProjectiles(sprite1, sprite2, DestAl)
                                End If
                            End If
                        End If
                    End If
                End If
            Next

            If Plane.IsColliding(sprite1) And sprite1.isHostile = True Then
                Plane.LoseHealth(sprite1.Damage)
                If sprite1.GetType().Equals(GetType(KamikazeEnemy)) Then
                    'dead.Add(sprite1)
                    AddSprite(dead, sprite1)
                    sprite1.Health = 0
                    sprite1.onDead()
                    'deadEnemyCounter += 1
                End If
            End If
            If sprite1.GetType().Equals(GetType(Bullet)) Then
                If sprite1.IsOffScreen() Then
                    'dead.Add(sprite1)
                    AddSprite(dead, sprite1)
                End If
            End If
        Next

        For Each bullet As Sprite In alEnemyProjectile
            If bullet.IsColliding(Plane) Then
                If bullet.OnCollision(Plane) Then
                    Plane.LoseHealth(bullet.Damage)
                    'dead.Add(bullet)
                    AddSprite(dead, bullet)
                End If
            End If
        Next

        Dim item1 As Sprite
        For Each item1 In alItem
            If item1.GetType().Equals(GetType(HealthDrop)) Then
                CType(item1, Drop).frameCount += 1
                If CType(item1, Drop).frameCount >= 200 Then
                    AddSprite(dead, item1)
                    'dead.Add(item1)
                ElseIf item1.IsColliding(Plane) Then
                    CType(item1, HealthDrop).Heal()
                    'dead.Add(item1)
                    AddSprite(dead, item1)
                End If
            End If
            If item1.GetType().Equals(GetType(ShieldDrop)) Then
                CType(item1, Drop).frameCount += 1
                If CType(item1, Drop).frameCount >= 200 Then
                    'dead.Add(item1)
                    AddSprite(dead, item1)
                ElseIf item1.IsColliding(Plane) Then
                    CType(item1, ShieldDrop).ProvideShield(15)
                    'dead.Add(item1)
                    AddSprite(dead, item1)
                End If
            End If
            If Plane.IsColliding(item1) Then
                If item1.GetType().Equals(GetType(Upgrade)) Then
                    If item1.OnCollision(Plane) Then
                        upgradeTaken = True
                        'dead.Add(item1)
                        AddSprite(dead, item1)
                    End If
                End If

            End If
        Next

        For Each sprite1 In dead
            If TypeOf sprite1 Is Enemy Then
                'Console.WriteLine(sprite1.ToString())
            End If
            sprite1.onDead()
            alProjectile.Remove(sprite1)
            alItem.Remove(sprite1)
            alEnemyProjectile.Remove(sprite1)
            If sprite1.isHostile Then
                alAnimation.Add(sprite1)
            End If
        Next

        For Each temp In DestAl
            alProjectile.Add(temp)
        Next
        DestAl.Clear()

        Label1.Text = alProjectile.Count

    End Sub

    Private Sub AddSplitShotProjectiles(ByVal source As Sprite, ByVal bullet As Sprite, ByRef DestAl As ArrayList)
        If Plane.zigZagShot Then
            Select Case bullet.movementDir
                Case Directions.NE
                    If Plane.uniqueAttackModifier = ShotTypes.None Then
                        DestAl.Add(New ZigZagBullet(pbxBulletLvl1Up.Image, source.Xpos, source.Ypos, 1, Directions.NW, Directions.NE))
                        DestAl.Add(New ZigZagBullet(pbxBulletLvl1Right.Image, source.Xpos, source.Ypos, 1, Directions.NE, Directions.SE))
                    Else
                        DestAl.Add(New ZigZagBullet(Plane.bulletImage, source.Xpos, source.Ypos, 1, Directions.NW, Directions.NE))
                        DestAl.Add(New ZigZagBullet(Plane.bulletImage, source.Xpos, source.Ypos, 1, Directions.NE, Directions.SE))
                    End If
                Case Directions.NW
                    If Plane.uniqueAttackModifier = ShotTypes.None Then
                        DestAl.Add(New ZigZagBullet(pbxBulletLvl1Up.Image, source.Xpos, source.Ypos, 1, Directions.NW, Directions.NE))
                        DestAl.Add(New ZigZagBullet(pbxBulletLvl1Left.Image, source.Xpos, source.Ypos, 1, Directions.SW, Directions.NW))
                    Else
                        DestAl.Add(New ZigZagBullet(Plane.bulletImage, source.Xpos, source.Ypos, 1, Directions.NW, Directions.NE))
                        DestAl.Add(New ZigZagBullet(Plane.bulletImage, source.Xpos, source.Ypos, 1, Directions.SW, Directions.NW))
                    End If
                Case Directions.SE
                    If Plane.uniqueAttackModifier = ShotTypes.None Then
                        DestAl.Add(New ZigZagBullet(pbxBulletLvl1Down.Image, source.Xpos, source.Ypos, 1, Directions.SE, Directions.SW))
                        DestAl.Add(New ZigZagBullet(pbxBulletLvl1Right.Image, source.Xpos, source.Ypos, 1, Directions.NE, Directions.SE))
                    Else
                        DestAl.Add(New ZigZagBullet(Plane.bulletImage, source.Xpos, source.Ypos, 1, Directions.SE, Directions.SW))
                        DestAl.Add(New ZigZagBullet(Plane.bulletImage, source.Xpos, source.Ypos, 1, Directions.NE, Directions.SE))
                    End If
                Case Directions.SW
                    If Plane.uniqueAttackModifier = ShotTypes.None Then
                        DestAl.Add(New ZigZagBullet(pbxBulletLvl1Left.Image, source.Xpos, source.Ypos, 1, Directions.SW, Directions.NW))
                        DestAl.Add(New ZigZagBullet(pbxBulletLvl1Down.Image, source.Xpos, source.Ypos, 1, Directions.SE, Directions.SW))
                    Else
                        DestAl.Add(New ZigZagBullet(Plane.bulletImage, source.Xpos, source.Ypos, 1, Directions.SW, Directions.NW))
                        DestAl.Add(New ZigZagBullet(Plane.bulletImage, source.Xpos, source.Ypos, 1, Directions.SE, Directions.SW))
                    End If
            End Select REM for ZigZag bullets
        Else
            Select Case bullet.movementDir
                Case Directions.Up
                    If Plane.uniqueAttackModifier = ShotTypes.None Then
                        DestAl.Add(New Bullet(pbxBulletNW.Image, source.Xpos, source.Ypos, 1, Directions.NW))
                        DestAl.Add(New Bullet(pbxBulletNE.Image, source.Xpos, source.Ypos, 1, Directions.NE))
                    Else
                        DestAl.Add(New Bullet(Plane.bulletImage, source.Xpos, source.Ypos, 1, Directions.NW))
                        DestAl.Add(New Bullet(Plane.bulletImage, source.Xpos, source.Ypos, 1, Directions.NE))
                    End If
                Case Directions.Down
                    If Plane.uniqueAttackModifier = ShotTypes.None Then
                        DestAl.Add(New Bullet(pbxBulletSW.Image, source.Xpos, source.Ypos, 1, Directions.SW))
                        DestAl.Add(New Bullet(pbxBulletSE.Image, source.Xpos, source.Ypos, 1, Directions.SE))
                    Else
                        DestAl.Add(New Bullet(Plane.bulletImage, source.Xpos, source.Ypos, 1, Directions.SW))
                        DestAl.Add(New Bullet(Plane.bulletImage, source.Xpos, source.Ypos, 1, Directions.SE))
                    End If
                Case Directions.Left
                    If Plane.uniqueAttackModifier = ShotTypes.None Then
                        DestAl.Add(New Bullet(pbxBulletNW.Image, source.Xpos, source.Ypos, 1, Directions.NW))
                        DestAl.Add(New Bullet(pbxBulletSW.Image, source.Xpos, source.Ypos, 1, Directions.SW))
                    Else
                        DestAl.Add(New Bullet(Plane.bulletImage, source.Xpos, source.Ypos, 1, Directions.NW))
                        DestAl.Add(New Bullet(Plane.bulletImage, source.Xpos, source.Ypos, 1, Directions.SW))
                    End If
                Case Directions.Right
                    If Plane.uniqueAttackModifier = ShotTypes.None Then
                        DestAl.Add(New Bullet(pbxBulletSE.Image, source.Xpos, source.Ypos, 1, Directions.SE))
                        DestAl.Add(New Bullet(pbxBulletNE.Image, source.Xpos, source.Ypos, 1, Directions.NE))
                    Else
                        DestAl.Add(New Bullet(Plane.bulletImage, source.Xpos, source.Ypos, 1, Directions.SE))
                        DestAl.Add(New Bullet(Plane.bulletImage, source.Xpos, source.Ypos, 1, Directions.NE))
                    End If
                Case Directions.NE
                    If Plane.uniqueAttackModifier = ShotTypes.None Then
                        DestAl.Add(New Bullet(pbxBulletLvl1Up.Image, source.Xpos, source.Ypos, 1, Directions.Up))
                        DestAl.Add(New Bullet(pbxBulletLvl1Right.Image, source.Xpos, source.Ypos, 1, Directions.Right))
                    Else
                        DestAl.Add(New Bullet(Plane.bulletImage, source.Xpos, source.Ypos, 1, Directions.Up))
                        DestAl.Add(New Bullet(Plane.bulletImage, source.Xpos, source.Ypos, 1, Directions.Right))
                    End If
                Case Directions.NW
                    If Plane.uniqueAttackModifier = ShotTypes.None Then
                        DestAl.Add(New Bullet(pbxBulletLvl1Up.Image, source.Xpos, source.Ypos, 1, Directions.Up))
                        DestAl.Add(New Bullet(pbxBulletLvl1Left.Image, source.Xpos, source.Ypos, 1, Directions.Left))
                    Else
                        DestAl.Add(New Bullet(Plane.bulletImage, source.Xpos, source.Ypos, 1, Directions.Up))
                        DestAl.Add(New Bullet(Plane.bulletImage, source.Xpos, source.Ypos, 1, Directions.Left))
                    End If
                Case Directions.SE
                    If Plane.uniqueAttackModifier = ShotTypes.None Then
                        DestAl.Add(New Bullet(pbxBulletLvl1Down.Image, source.Xpos, source.Ypos, 1, Directions.Down))
                        DestAl.Add(New Bullet(pbxBulletLvl1Right.Image, source.Xpos, source.Ypos, 1, Directions.Right))
                    Else
                        DestAl.Add(New Bullet(Plane.bulletImage, source.Xpos, source.Ypos, 1, Directions.Down))
                        DestAl.Add(New Bullet(Plane.bulletImage, source.Xpos, source.Ypos, 1, Directions.Right))
                    End If
                Case Directions.SW
                    If Plane.uniqueAttackModifier = ShotTypes.None Then
                        DestAl.Add(New Bullet(pbxBulletLvl1Left.Image, source.Xpos, source.Ypos, 1, Directions.Left))
                        DestAl.Add(New Bullet(pbxBulletLvl1Down.Image, source.Xpos, source.Ypos, 1, Directions.Down))
                    Else
                        DestAl.Add(New Bullet(Plane.bulletImage, source.Xpos, source.Ypos, 1, Directions.Left))
                        DestAl.Add(New Bullet(Plane.bulletImage, source.Xpos, source.Ypos, 1, Directions.Down))
                    End If
            End Select REM The non ZigZag cases
        End If
    End Sub

    Public Declare Function GetAsyncKeyState Lib "user32.dll" (ByVal key As Integer) As Integer

    Private Sub GameTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GameTimer.Tick

        backgroundAnimCounter += 2

        REM controls the enemy movement change times
        frameCounterMovementChange += 1

        ' Check for key presses for plane movement
        If GetAsyncKeyState(Keys.D) Then
            Plane.MoveRight()
        End If
        If GetAsyncKeyState(Keys.A) Then
            Plane.MoveLeft()
        End If
        If GetAsyncKeyState(Keys.W) Then
            Plane.MoveUp()
        End If
        If GetAsyncKeyState(Keys.S) Then
            Plane.MoveDown()
        End If

        REM controls the rate of fire
        frameCounterFireRate += 1
        If frameCounterFireRate > fireRate Then
            ' Check for keypress for bullet
            If GetAsyncKeyState(Keys.Up) Then
                ShootBullet(Directions.Up)
            ElseIf GetAsyncKeyState(Keys.Down) Then
                ShootBullet(Directions.Down)

            ElseIf GetAsyncKeyState(Keys.Left) Then
                ShootBullet(Directions.Left)

            ElseIf GetAsyncKeyState(Keys.Right) Then
                ShootBullet(Directions.Right)
            End If
            frameCounterFireRate = 0
        Else
        End If

        If GetAsyncKeyState(Keys.Space) Then
            REM testing 
            'ShootBullet(Directions.Up)
            'ShootBullet(Directions.Down)
            'ShootBullet(Directions.Left)
            'ShootBullet(Directions.Right)
            REM--------
            Plane.activateItem()
        End If

        If GetAsyncKeyState(Keys.B) Then
            Bomb()
        End If

        If tempFrameDrawingCounter >= 10 Then
            canWipeRoundGraphic = True
        End If
        tempFrameDrawingCounter += 1

        Dim healAmount As Integer = 2
        If Plane.repairs Then
            If tempHealingCounter >= 20 Then
                If Not (Plane.Health + healAmount) >= Plane.maximumHealth Then
                    Plane.Heal(healAmount)
                Else
                    Plane.Heal(Plane.maximumHealth - Plane.Health)
                End If
                tempHealingCounter = 0
            End If
            tempHealingCounter += 1
        End If

        MoveProjectiles()
        Draw()
        CheckCollisions()
        Display.Image = bmpSurface

        FPSCounter()
        CheckGameOver()
        If deadEnemyCounter >= currentRound.maxEnemyCount Then
            currentRound.onRoundChange()
        End If

    End Sub

    Public Sub Bomb()
        Dim dead As New ArrayList
        For Each Enemy In alProjectile
            dead.Add(Enemy)
            deadEnemyCounter += 1
        Next

        For Each Enemy In dead
            alProjectile.Remove(Enemy)
        Next

        Try
            mciSendString("play Bomb from 0", ReturnInfo, ReturnInfo.Capacity, IntPtr.Zero)
        Catch ex As Exception
            MsgBox("Error loading sound")
        End Try

    End Sub

    Private Sub FPSCounter()

        FrameCount += 1
        If My.Computer.Clock.TickCount > FrameTimer + 1000 Then
            FrameTimer = My.Computer.Clock.TickCount
            FrameRate = FrameCount
            FrameCount = 0
            lblFPS.Text = "FPS : " & FrameRate
        End If

        'For Each drop1 In alItem REM There must be a way to use the Drop base class in the get type so it works for all its inheritors too. Then we only need one statement.
        '    If drop1.GetType().Equals(GetType(HealthDrop)) Then
        '        drop1.frameCount += 1
        '    ElseIf drop1.GetType().Equals(GetType(ShieldDrop)) Then
        '        drop1.framecount += 1
        '    End If
        'Next

    End Sub

    Private Sub CheckGameOver()
        If Plane.Health <= 0 Then
            Try
                My.Computer.Audio.Play(My.Resources.GameOver_wav, AudioPlayMode.WaitToComplete)
            Catch ex As Exception
                MsgBox("Error loading sound")
            End Try
            Me.Close()
        End If
    End Sub

    Public Enum ActiveItems
        Sloth
    End Enum

    Public Enum Upgrades
        DamageIncrease
        SpeedIncrease
        HealthIncrease
        FirerateIncrease
        ShieldSteal
        RingShot
        DiagonalShot
        ZigZagShot
        Repairs
        SplitShot
    End Enum

    Public Sub DropUpgrade()
        Dim upgrade As Upgrade = Nothing
        Dim rndNum As Integer
        Do
            Randomize()
            rndNum = Math.Floor((Rnd() * ([Enum].GetValues(GetType(Upgrades)).Length))) + 1
            Dim x As Integer = (CInt((DisplayWidth / 2) - pbxHealthUpgrade.Width))
            Dim y As Integer = ((CInt(DisplayHeight / 2) - 200)) - pbxHealthUpgrade.Height
            If ((CInt(DisplayHeight / 2) - (200 + pbxHealthUpgrade.Image.Height))) < Plane.yPos And Plane.yPos < (((CInt(DisplayHeight / 2) - (200 + pbxHealthUpgrade.Image.Height)) + pbxHealthUpgrade.Height)) Then
                y = CInt((DisplayHeight / 2) + 200)
            End If
            REM for testing only -------------------
            'If currentRound.roundNumber = 1 Then
            'rndNum = 8
            'End If
            'If currentRound.roundNumber = 2 Then
            '    rndNum = 6
            'End If
            'If currentRound.roundNumber = 3 Then
            '    rndNum = 8
            'End If
            REM ------------------------------------
            Select Case rndNum
                Case 1 REM drop health upgrade
                    upgrade = New Upgrade(pbxHealthUpgrade.Image, x, y, 0, Upgrades.HealthIncrease)
                Case 2 REM drop damage upgrade
                    upgrade = New Upgrade(pbxDamageUpgrade.Image, x, y, 0, Upgrades.DamageIncrease)
                Case 3 REM drop speed upgrade
                    upgrade = New Upgrade(pbxSpeedUpgrade.Image, x, y, 0, Upgrades.SpeedIncrease)
                Case 4 REM drop fire rate upgrade
                    upgrade = New Upgrade(pbxFirerateUpgrade.Image, x, y, 0, Upgrades.FirerateIncrease)
                Case 5 REM drop shield steal upgrade
                    If Not Plane.shieldSteal Then : upgrade = New Upgrade(pbxShieldStealUpgrade.Image, x, y, 0, Upgrades.ShieldSteal) : End If
                Case 6 REM drop ring shot upgrade
                    If Not Plane.ringShot Then : upgrade = New Upgrade(pbxRingShotUpgrade.Image, x, y, 0, Upgrades.RingShot) : End If
                Case 7 REM drop diagonal shot upgrade
                    If Not Plane.diagonalShot Then : upgrade = New Upgrade(pbxDiagonalShotUpgrade.Image, x, y, 0, Upgrades.DiagonalShot) : End If
                Case 8 REM drop ZigZag shot upgrade
                    If Not Plane.zigZagShot Then : upgrade = New Upgrade(pbxZigZagUpgrade.Image, x, y, 0, Upgrades.ZigZagShot) : End If
                Case 9 REM drop repairs upgrade
                    If Not Plane.repairs Then : upgrade = New Upgrade(pbxRepairsUpgrade.Image, x, y, 0, Upgrades.Repairs) : End If
                Case 10 REM drop SplitShot upgrade
                    If Not Plane.splitShot Then : upgrade = New Upgrade(pbxSplitShotUpgrade.Image, x, y, 0, Upgrades.SplitShot) : End If
            End Select
        Loop Until Not upgrade Is (Nothing)
        alItem.Add(upgrade)
        upgradeTaken = False
    End Sub

    Private Sub SpawnTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpawnTimer.Tick
        If (upgradeTaken) Then
            currentRound.spawnEnemies()
        End If
    End Sub

    Private Sub RoundChangeTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoundChangeTimer.Tick
        canWipeRoundGraphic = False
        deadEnemyCounter = 0
        spawnedEnemyCounter = 0
        If upgradeTaken Then
            RoundChangeTimer.Enabled = False
            UnpauseGame()
        End If
        tempFrameDrawingCounter = 0
    End Sub

    Public Sub PauseGame()
        gamePaused = True
    End Sub

    Public Sub UnpauseGame()
        gamePaused = False
    End Sub

    Dim mothershipSpawnCounter As Integer = 0
    Private Sub EnemyAttackTimer_Tick(sender As System.Object, e As System.EventArgs) Handles EnemyAttackTimer.Tick
        Dim mothershipPresent As Boolean = False
        For Each enemy As Sprite In alProjectile
            If enemy.GetType().Equals(GetType(Mothership)) Then
                ShootEnemyBullet(Directions.Right, enemy)
                ShootEnemyBullet(Directions.Left, enemy)
                ShootEnemyBullet(Directions.Down, enemy)
                ShootEnemyBullet(Directions.Up, enemy)
                mothershipPresent = True
            ElseIf enemy.GetType().Equals(GetType(ShooterEnemy)) Then
                ShootEnemyBullet(enemy.movementDir, enemy)
            End If
        Next

        If mothershipPresent Then
            If mothershipSpawnCounter >= 11 Or mothershipSpawnCounter = 0 Then
                MakeEnemy(enemyTypes.basic, 1)
                numberOfMothershipSpawns += 1
                currentRound.maxEnemyCount += 1
                mothershipSpawnCounter = 1
            End If
        End If
        mothershipSpawnCounter += 1
    End Sub

    Private Sub ShootEnemyBullet(ByVal dir As Directions, ByVal shooter As Sprite)
        Select Case dir
            Case Directions.Down : alEnemyProjectile.Add(New EnemyBullet(pbxBulletEnemyDown.Image, (shooter.Xpos + ((shooter.Image.Width / 8) * 3)), (shooter.Ypos + shooter.Image.Height), 1, dir))
                alEnemyProjectile.Add(New EnemyBullet(pbxBulletEnemyDown.Image, (shooter.Xpos + ((shooter.Image.Width / 8) * 5)), (shooter.Ypos + shooter.Image.Height), 1, dir))
            Case Directions.Up : alEnemyProjectile.Add(New EnemyBullet(pbxBulletEnemyUp.Image, (shooter.Xpos + ((shooter.Image.Width / 8) * 3)), shooter.Ypos, 1, dir))
                alEnemyProjectile.Add(New EnemyBullet(pbxBulletEnemyUp.Image, (shooter.Xpos + ((shooter.Image.Width / 8) * 5)), shooter.Ypos, 1, dir))
            Case Directions.Left : alEnemyProjectile.Add(New EnemyBullet(pbxBulletEnemyLeft.Image, (shooter.Xpos), (shooter.Ypos) + (shooter.Image.Height / 2), 1, dir))
            Case Directions.Right : alEnemyProjectile.Add(New EnemyBullet(pbxBulletEnemyRight.Image, (shooter.Xpos + shooter.Image.Width), (shooter.Ypos) + (shooter.Image.Height / 2), 1, dir))
        End Select
        Try
            mciSendString("play EnemyFire from 0", ReturnInfo, ReturnInfo.Capacity, IntPtr.Zero)
        Catch ex As Exception
            MsgBox("Error loading sound")
        End Try
        Label1.Text = alProjectile.Count
    End Sub

    Public Enum Animations
        movement
        death
        ability
        damageTaken
    End Enum

    Private Sub AnimationTimer_Tick(sender As System.Object, e As System.EventArgs) Handles AnimationTimer.Tick
        For Each sprite1 As Sprite In alAnimation
            If sprite1.canAnimate Then
                Select Case sprite1.animationType
                    Case Animations.movement
                        sprite1.animationImage = sprite1.GetAnimationImage(Animations.movement)
                    Case Animations.ability
                        sprite1.animationImage = sprite1.GetAnimationImage(Animations.ability)
                    Case Animations.death
                        sprite1.animationImage = sprite1.GetAnimationImage(Animations.death)
                    Case Animations.damageTaken
                        sprite1.animationImage = sprite1.GetAnimationImage(Animations.damageTaken)
                End Select
            Else
                alDeadAnim.Add(sprite1)
            End If
            If sprite1.animationImage Is Nothing Then
                alDeadAnim.Add(sprite1)
            End If
        Next

        For Each sprite2 As Sprite In alDeadAnim
            alAnimation.Remove(sprite2)
        Next
        alDeadAnim.Clear()
        'DrawAnimations()
    End Sub

    Private Sub pbxCollectedUpgrades_MouseHover(sender As Object, e As System.EventArgs) Handles pbxCollectedUpgrades.MouseHover
        showInfoBox = True
    End Sub

    Private Sub pbxCollectedUpgrades_MouseLeave(sender As Object, e As System.EventArgs) Handles pbxCollectedUpgrades.MouseLeave
        showInfoBox = False
    End Sub

    Dim numberOfItemTicks As Integer = 0
    Private Sub ActiveItemTimer_Tick(sender As System.Object, e As System.EventArgs) Handles ActiveItemTimer.Tick
        numberOfItemTicks += 1
        Select Case Plane.activeItem.ItemName
            Case ActiveItems.Sloth
                If numberOfItemTicks = 5 Then
                    For Each Enemy1 In alProjectile
                        If Enemy1.ishostile Then
                            Enemy1.Speed = (Enemy1.defaultSpeed)
                        End If
                    Next
                    numberOfItemTicks = 0
                    ActiveItemTimer.Enabled = False
                End If
        End Select
    End Sub

    Dim TimerTimerTickCount As Integer = 0
    Private Sub TimerTimer_Tick(sender As System.Object, e As System.EventArgs) Handles TimerTimer.Tick
        Plane.activeItem.canAnimate = True
        Plane.activeItem.Xpos = 5
        Plane.activeItem.Ypos = 30
        Plane.activeItem.animationType = Animations.movement
        Plane.activeItem.animationImage = Plane.activeItem.movementAnimationFrames(0)
        Select Case TimerTimerTickCount
            Case 0 REM should have an activeItemLocation variable or something so that the numbers aren't hard coded in.
                'gfxSurface.DrawImage(pbxAnimTimerFrame1.Image, 5, 30) 
                'Plane.activeItem.animationImage = Plane.activeItem.movementAnimationFrames(0) REM these should just be cycled through in the getAnimationFrame method
            Case 1
                'gfxSurface.DrawImage(pbxAnimTimerFrame2.Image, 5, 30)
                'Plane.activeItem.animationImage = Plane.activeItem.movementAnimationFrames(1)
            Case 2
                'gfxSurface.DrawImage(pbxAnimTimerFrame3.Image, 5, 30)
                'Plane.activeItem.animationImage = Plane.activeItem.movementAnimationFrames(2)
            Case 3
                'gfxSurface.DrawImage(pbxAnimTimerFrame4.Image, 5, 30)
                'Plane.activeItem.animationImage = Plane.activeItem.movementAnimationFrames(3)
            Case 4
                'gfxSurface.DrawImage(pbxAnimTimerFrame5.Image, 5, 30)
                'Plane.activeItem.animationImage = Plane.activeItem.movementAnimationFrames(4)
            Case 5
                'gfxSurface.DrawImage(pbxAnimTimerFrame6.Image, 5, 30)
                'Plane.activeItem.animationImage = Plane.activeItem.movementAnimationFrames(5)
            Case 6
                'gfxSurface.DrawImage(pbxAnimTimerFrame7.Image, 5, 30)
                'Plane.activeItem.animationImage = Plane.activeItem.movementAnimationFrames(6)
            Case 7
                'gfxSurface.DrawImage(pbxAnimTimerFrame8.Image, 5, 30)
                'Plane.activeItem.animationImage = Plane.activeItem.movementAnimationFrames(7)
                TimerTimerTickCount = 0
        End Select
        alAnimation.Add(Plane.activeItem)
        TimerTimerTickCount += 1
    End Sub

End Class
