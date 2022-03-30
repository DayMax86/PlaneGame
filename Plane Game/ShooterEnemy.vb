Public Class ShooterEnemy
    Inherits Enemy

    Public Sub New(ByVal image As Bitmap, ByVal startX As Integer, ByVal startY As Integer, ByVal health As Integer)
        MyBase.New(image, startX, startY, health)
        MyBase.Damage = 2
        MyBase.Speed = 4
        MyBase.defaultSpeed = 4
        MyBase.Health = 100
    End Sub

    Public Overrides Sub onDead()
        MyBase.onDead()
        REM drops
        Dim rndNum As Integer = 0
        Randomize()
        rndNum = (Rnd() * 100)
        If rndNum < 5 Then
            Form1.alItem.Add(New HealthDrop(Form1.pbxHealthDrop.Image, Me.Xpos, Me.Ypos, 100000))
        ElseIf rndNum >= 5 And rndNum <= 10 Then
            Form1.alItem.Add(New ShieldDrop(Form1.pbxShieldDrop.Image, Me.Xpos, Me.Ypos, 100000))
        End If
        REM shield steal etc
        If Form1.Plane.shieldSteal = True Then
            If Not Form1.Plane.shieldStrength >= Form1.Plane.maximumShieldStrength Then
                Form1.Plane.shieldStrength += 1
                'Form1.Plane.shielded = True
            End If
        End If
    End Sub

    Public Overrides Sub checkEdgeCollisions()
        REM so it doesn't get deleted on a strafe run
        If MyBase.Xpos < (0 - MyBase.Image.Width) Then
            REM off the left of the screen
            giveNewMovementDir()
        ElseIf MyBase.Xpos > (Form1.DisplayWidth) Then
            REM off the right of the screen
            giveNewMovementDir()
        ElseIf MyBase.Ypos < (0 - MyBase.Image.Width) Then
            REM off the top of the screen
            giveNewMovementDir()
        ElseIf MyBase.Ypos > (Form1.DisplayHeight) Then
            REM off the bottom of the screen
            giveNewMovementDir()
        End If
    End Sub

    Public Sub giveNewMovementDir()
        Randomize()
        Dim rndmX As Integer = Rnd() * (Form1.DisplayWidth)
        Dim rndmY As Integer = Rnd() * (Form1.DisplayHeight)
        Dim rndmNum As Integer
        rndmNum = Rnd() * 1000
        If rndmNum < 500 Then
            REM do random in x
            If rndmX < (Form1.DisplayWidth / 2) Then
                MyBase.Ypos = 0
            Else
                MyBase.Ypos = (Form1.DisplayHeight) - Form1.pbxEnemyShooterDown.Height
            End If
            MyBase.Xpos = Rnd() * ((Form1.DisplayWidth) - Form1.pbxEnemyShooterDown.Width)
        Else
            REM do random in y
            If rndmY < (Form1.DisplayHeight / 2) Then
                MyBase.Xpos = 0
            Else
                MyBase.Xpos = (Form1.DisplayWidth) - Form1.pbxEnemyShooterDown.Width
            End If
            MyBase.Ypos = Rnd() * ((Form1.DisplayHeight) - Form1.pbxEnemyShooterDown.Height)
        End If
        '--------------------------------------------------------------------'
        Dim rndnum2 As Integer
        Randomize()
        Select Case MyBase.Xpos
            Case Is < ((Form1.DisplayWidth / 20) * 7) REM in the left most quarter
                If MyBase.Ypos < Form1.DisplayHeight / 2 Then
                    REM in the top left corner so can go right or down (or diagonally if I add that)
                    rndnum2 = Rnd() * 100
                    If rndnum2 <= 85 Then REM go right
                        MyBase.movementDir = Form1.Directions.Right
                    Else REM go down
                        MyBase.movementDir = Form1.Directions.Down
                    End If
                ElseIf MyBase.Ypos >= Form1.DisplayHeight / 2 Then
                    REM in the bottom left corner so can go right or up (or diagonally if I add that)
                    rndnum2 = Rnd() * 100
                    If rndnum2 <= 85 Then REM go right
                        MyBase.movementDir = Form1.Directions.Right
                    Else REM go up
                        MyBase.movementDir = Form1.Directions.Up
                    End If
                End If
            Case Is > ((Form1.DisplayWidth / 20) * 13) REM in the right most quarter
                If MyBase.Ypos < Form1.DisplayHeight / 2 Then
                    REM in the top right corner so can go left or down (or diagonally if I add that)
                    rndnum2 = Rnd() * 100
                    If rndnum2 <= 85 Then REM go left
                        MyBase.movementDir = Form1.Directions.Left
                    Else REM go down
                        MyBase.movementDir = Form1.Directions.Down
                    End If
                ElseIf MyBase.Ypos >= Form1.DisplayHeight / 2 Then
                    REM in the bottom right corner so can go left or up (or diagonally if I add that)
                    rndnum2 = Rnd() * 100
                    If rndnum2 <= 85 Then REM go left
                        MyBase.movementDir = Form1.Directions.Left
                    Else REM go up
                        MyBase.movementDir = Form1.Directions.Up
                    End If
                End If
            Case Else REM must be in the middle half
                If MyBase.Ypos < Form1.DisplayHeight / 2 Then
                    MyBase.movementDir = Form1.Directions.Down
                ElseIf MyBase.Ypos >= Form1.DisplayHeight / 2 Then
                    MyBase.movementDir = Form1.Directions.Up
                End If
        End Select
    End Sub

    Public Overrides Sub DefaultMove()
        Ypos += MyBase.Speed
        checkEdgeCollisions()
        Select Case Me.GetType()
            Case GetType(Enemy) : MyBase.Image = Form1.pbxEnemyDown.Image
            Case GetType(ShooterEnemy) : MyBase.Image = Form1.pbxEnemyShooterDown.Image
        End Select
        MyBase.numberOfSteps += 1
    End Sub
    Public Overrides Sub UpMove()
        Ypos -= MyBase.Speed
        checkEdgeCollisions()
        Select Case Me.GetType()
            Case GetType(Enemy) : MyBase.Image = Form1.pbxEnemyUp.Image
            Case GetType(ShooterEnemy) : MyBase.Image = Form1.pbxEnemyShooterUp.Image
        End Select
        MyBase.numberOfSteps += 1
    End Sub
    Public Overrides Sub NEMove()
        Ypos -= MyBase.Speed - 0.5
        Xpos += MyBase.Speed - 0.5
        checkEdgeCollisions()
        Select Case Me.GetType()
            Case GetType(Enemy) : MyBase.Image = Form1.pbxEnemyNE.Image
            Case GetType(ShooterEnemy) : MyBase.Image = Form1.pbxEnemyShooterNE.Image
        End Select
        MyBase.numberOfSteps += 1
    End Sub
    Public Overrides Sub DownMove()
        Ypos += MyBase.Speed
        checkEdgeCollisions()
        Select Case Me.GetType()
            Case GetType(Enemy) : MyBase.Image = Form1.pbxEnemyDown.Image
            Case GetType(ShooterEnemy) : MyBase.Image = Form1.pbxEnemyShooterDown.Image
        End Select
        MyBase.numberOfSteps += 1
    End Sub
    Public Overrides Sub SEMove()
        Ypos += MyBase.Speed - 0.5
        Xpos += MyBase.Speed - 0.5
        checkEdgeCollisions()
        Select Case Me.GetType()
            Case GetType(Enemy) : MyBase.Image = Form1.pbxEnemySE.Image
            Case GetType(ShooterEnemy) : MyBase.Image = Form1.pbxEnemyShooterSE.Image
        End Select
        MyBase.numberOfSteps += 1
    End Sub
    Public Overrides Sub LeftMove()
        Xpos -= MyBase.Speed
        checkEdgeCollisions()
        Select Case Me.GetType()
            Case GetType(Enemy) : MyBase.Image = Form1.pbxEnemyLeft.Image
            Case GetType(ShooterEnemy) : MyBase.Image = Form1.pbxEnemyShooterLeft.Image
        End Select
        MyBase.numberOfSteps += 1
    End Sub
    Public Overrides Sub NWMove()
        Ypos -= MyBase.Speed - 0.5
        Xpos -= MyBase.Speed - 0.5
        checkEdgeCollisions()
        Select Case Me.GetType()
            Case GetType(Enemy) : MyBase.Image = Form1.pbxEnemyNW.Image
            Case GetType(ShooterEnemy) : MyBase.Image = Form1.pbxEnemyShooterNW.Image
        End Select
        MyBase.numberOfSteps += 1
    End Sub
    Public Overrides Sub RightMove()
        Xpos += MyBase.Speed
        checkEdgeCollisions()
        Select Case Me.GetType()
            Case GetType(Enemy) : MyBase.Image = Form1.pbxEnemyRight.Image
            Case GetType(ShooterEnemy) : MyBase.Image = Form1.pbxEnemyShooterRight.Image
        End Select
        MyBase.numberOfSteps += 1
    End Sub
    Public Overrides Sub SWMove()
        Ypos += MyBase.Speed - 0.5
        Xpos -= MyBase.Speed - 0.5
        checkEdgeCollisions()
        Select Case Me.GetType()
            Case GetType(Enemy) : MyBase.Image = Form1.pbxEnemySW.Image
            Case GetType(ShooterEnemy) : MyBase.Image = Form1.pbxEnemyShooterSW.Image
        End Select
        MyBase.numberOfSteps += 1
    End Sub

    Public Overrides Function isoffscreen() As Boolean
        Return False
    End Function

End Class
