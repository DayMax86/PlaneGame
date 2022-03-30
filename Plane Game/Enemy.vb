Public Class Enemy
    Inherits Sprite

    Private pNumberOfSteps As Integer
    Private pDefaultSpeed As Integer

    Public Sub New(ByVal image As Bitmap, ByVal startX As Integer, ByVal startY As Integer, ByVal health As Integer)
        MyBase.New(image, startX, startY, health)
        MyBase.Damage = 2
        MyBase.Speed = 3
        pDefaultSpeed = 3
        MyBase.Health = 80
    End Sub

    Public Property defaultSpeed As Integer
        Get
            Return pDefaultSpeed
        End Get
        Set(value As Integer)
            pDefaultSpeed = value
        End Set
    End Property

    Public Overrides Property numberOfSteps As Integer
        Get
            Return pNumberOfSteps
        End Get
        Set(value As Integer)
            pNumberOfSteps = value
        End Set
    End Property

    Public Overrides Sub DefaultMove()
        Ypos += MyBase.Speed
        checkEdgeCollisions()
        Select Case Me.GetType()
            Case GetType(Enemy) : MyBase.Image = Form1.pbxEnemyDown.Image
            Case GetType(ShooterEnemy) : MyBase.Image = Form1.pbxEnemyShooterDown.Image
        End Select
        MyBase.movementDir = Form1.Directions.Down
        pNumberOfSteps += 1
    End Sub
    Public Overrides Sub UpMove()
        Ypos -= MyBase.Speed
        checkEdgeCollisions()
        Select Case Me.GetType()
            Case GetType(Enemy) : MyBase.Image = Form1.pbxEnemyUp.Image
            Case GetType(ShooterEnemy) : MyBase.Image = Form1.pbxEnemyShooterUp.Image
        End Select
        MyBase.movementDir = Form1.Directions.Up
        pNumberOfSteps += 1
    End Sub
    Public Overrides Sub NEMove()
        Ypos -= MyBase.Speed
        Xpos += MyBase.Speed
        checkEdgeCollisions()
        Select Case Me.GetType()
            Case GetType(Enemy) : MyBase.Image = Form1.pbxEnemyNE.Image
            Case GetType(ShooterEnemy) : MyBase.Image = Form1.pbxEnemyShooterNE.Image
        End Select
        MyBase.movementDir = Form1.Directions.NE
        pNumberOfSteps += 1
    End Sub
    Public Overrides Sub DownMove()
        Ypos += MyBase.Speed
        checkEdgeCollisions()
        Select Case Me.GetType()
            Case GetType(Enemy) : MyBase.Image = Form1.pbxEnemyDown.Image
            Case GetType(ShooterEnemy) : MyBase.Image = Form1.pbxEnemyShooterDown.Image
        End Select
        MyBase.movementDir = Form1.Directions.Down
        pNumberOfSteps += 1
    End Sub
    Public Overrides Sub SEMove()
        Ypos += MyBase.Speed
        Xpos += MyBase.Speed
        checkEdgeCollisions()
        Select Case Me.GetType()
            Case GetType(Enemy) : MyBase.Image = Form1.pbxEnemySE.Image
            Case GetType(ShooterEnemy) : MyBase.Image = Form1.pbxEnemyShooterSE.Image
        End Select
        MyBase.movementDir = Form1.Directions.SE
        pNumberOfSteps += 1
    End Sub
    Public Overrides Sub LeftMove()
        Xpos -= MyBase.Speed
        checkEdgeCollisions()
        Select Case Me.GetType()
            Case GetType(Enemy) : MyBase.Image = Form1.pbxEnemyLeft.Image
            Case GetType(ShooterEnemy) : MyBase.Image = Form1.pbxEnemyShooterLeft.Image
        End Select
        MyBase.movementDir = Form1.Directions.Left
        pNumberOfSteps += 1
    End Sub
    Public Overrides Sub NWMove()
        Ypos -= MyBase.Speed
        Xpos -= MyBase.Speed
        checkEdgeCollisions()
        Select Case Me.GetType()
            Case GetType(Enemy) : MyBase.Image = Form1.pbxEnemyNW.Image
            Case GetType(ShooterEnemy) : MyBase.Image = Form1.pbxEnemyShooterNW.Image
        End Select
        MyBase.movementDir = Form1.Directions.NW
        pNumberOfSteps += 1
    End Sub
    Public Overrides Sub RightMove()
        Xpos += MyBase.Speed
        checkEdgeCollisions()
        Select Case Me.GetType()
            Case GetType(Enemy) : MyBase.Image = Form1.pbxEnemyRight.Image
            Case GetType(ShooterEnemy) : MyBase.Image = Form1.pbxEnemyShooterRight.Image
        End Select
        MyBase.movementDir = Form1.Directions.Right
        pNumberOfSteps += 1
    End Sub
    Public Overrides Sub SWMove()
        Ypos += MyBase.Speed
        Xpos -= MyBase.Speed
        checkEdgeCollisions()
        Select Case Me.GetType()
            Case GetType(Enemy) : MyBase.Image = Form1.pbxEnemySW.Image
            Case GetType(ShooterEnemy) : MyBase.Image = Form1.pbxEnemyShooterSW.Image
        End Select
        MyBase.movementDir = Form1.Directions.SW
        pNumberOfSteps += 1
    End Sub

    Public Overrides Function OnCollision(ByRef other As Sprite) As Boolean
        If TypeOf other Is Bullet Then
            Return True
        Else
            Return False
        End If
        If TypeOf other Is PlaneSprite Then
            Form1.Plane.LoseHealth(Me.Damage)
            Form1.alProjectile.Remove(Me)
            Me.onDead()
        End If
    End Function

    Public Overrides Function LoseHealth(ByVal dmg As Integer) As Integer
        MyBase.Health -= dmg
        Return MyBase.Health
    End Function

    Public Overrides Function IsOffScreen() As Boolean
        If Ypos > Form1.DisplayHeight Or Xpos > Form1.DisplayWidth Then
            Return True
        ElseIf Ypos < 0 Or Xpos < 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Function isHostile() As Boolean
        Return True
    End Function

    Public Overrides Sub onDead()
        MyBase.onDead()
        Form1.deadEnemyCounter += 1
        Console.WriteLine(Me.GetHashCode().ToString() + " : " + Form1.deadEnemyCounter.ToString())
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

End Class
