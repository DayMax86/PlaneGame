Public Class KamikazeEnemy
    Inherits Enemy

    Public Sub New(ByVal image As Bitmap, ByVal startX As Integer, ByVal startY As Integer, ByVal health As Integer)
        MyBase.New(Image, startX, startY, Health)
        MyBase.Damage = 30
        MyBase.Speed = 9
        MyBase.defaultSpeed = 9
        MyBase.Health = 50
    End Sub

    Public Overrides Sub DefaultMove()
        Ypos += Me.Speed
        checkEdgeCollisions()
        If MyBase.Health <= (MyBase.health / 2) Then
            'Me.Image = Form1.pbxEnemyKamikazeDownDamaged.Image
        Else
            Me.Image = Form1.pbxEnemyKamikazeDown.Image
        End If
        MyBase.movementDir = Form1.Directions.Down
        MyBase.numberOfSteps += 1
    End Sub
    Public Overrides Sub UpMove()
        Ypos -= Me.Speed
        checkEdgeCollisions()
        If MyBase.Health <= (MyBase.Health / 2) Then REM this doesn't work.
            'Me.Image = Form1.pbxEnemyKamikazeUpDamaged.Image
        Else
            Me.Image = Form1.pbxEnemyKamikazeUp.Image
        End If
        MyBase.movementDir = Form1.Directions.Up
        MyBase.numberOfSteps += 1
    End Sub
    Public Overrides Sub NEMove()
        Ypos -= (Me.Speed + 1)
        Xpos += (Me.Speed - 1)
        checkEdgeCollisions()
        If MyBase.Health <= (MyBase.Health / 2) Then
            'Me.Image = Form1.pbxEnemyKamikazeUpDamaged.Image
        Else
            Me.Image = Form1.pbxEnemyKamikazeNE.Image
        End If
        MyBase.movementDir = Form1.Directions.NE
        MyBase.numberOfSteps += 1
    End Sub
    Public Overrides Sub DownMove()
        Ypos += Me.Speed
        checkEdgeCollisions()
        If MyBase.Health <= (MyBase.Health / 2) Then
            'Me.Image = Form1.pbxEnemyKamikazeDownDamaged.Image
        Else
            Me.Image = Form1.pbxEnemyKamikazeDown.Image
        End If
        MyBase.movementDir = Form1.Directions.Down
        MyBase.numberOfSteps += 1
    End Sub
    Public Overrides Sub SEMove()
        Ypos += Me.Speed - 1
        Xpos += Me.Speed - 1
        checkEdgeCollisions()
        If MyBase.Health <= (MyBase.health / 2) Then
            'Me.Image = Form1.pbxEnemyKamikazeUpDamaged.Image
        Else
            Me.Image = Form1.pbxEnemyKamikazeSE.Image
        End If
        MyBase.movementDir = Form1.Directions.SE
        MyBase.numberOfSteps += 1
    End Sub
    Public Overrides Sub LeftMove()
        Xpos -= Me.Speed
        checkEdgeCollisions()
        If MyBase.Health <= (MyBase.health / 2) Then
            'Me.Image = Form1.pbxEnemyKamikazeLeftDamaged.Image
        Else
            Me.Image = Form1.pbxEnemyKamikazeLeft.Image
        End If
        MyBase.movementDir = Form1.Directions.Left
        MyBase.numberOfSteps += 1
    End Sub
    Public Overrides Sub NWMove()
        Ypos -= (Me.Speed + 1)
        Xpos -= (Me.Speed + 1)
        checkEdgeCollisions()
        If MyBase.Health <= (MyBase.health / 2) Then
            'Me.Image = Form1.pbxEnemyKamikazeUpDamaged.Image
        Else
            Me.Image = Form1.pbxEnemyKamikazeNW.Image
        End If
        MyBase.movementDir = Form1.Directions.NW
        MyBase.numberOfSteps += 1
    End Sub
    Public Overrides Sub RightMove()
        Xpos += Me.Speed
        checkEdgeCollisions()
        If MyBase.Health <= (MyBase.health / 2) Then
            'Me.Image = Form1.pbxEnemyKamikazeRightDamaged.Image
        Else
            Me.Image = Form1.pbxEnemyKamikazeRight.Image
        End If
        MyBase.movementDir = Form1.Directions.Right
        MyBase.numberOfSteps += 1
    End Sub
    Public Overrides Sub SWMove()
        Ypos += Me.Speed - 1
        Xpos -= Me.Speed + 1
        checkEdgeCollisions()
        If MyBase.Health <= (MyBase.Health / 2) Then
            'Me.Image = Form1.pbxEnemyKamikazeUpDamaged.Image
        Else
            Me.Image = Form1.pbxEnemyKamikazeSW.Image
        End If
        MyBase.movementDir = Form1.Directions.SW
        MyBase.numberOfSteps += 1
    End Sub

    Public Overrides Function OnCollision(ByRef other As Sprite) As Boolean
        If TypeOf other Is Bullet Then
            Return True
        elseIf TypeOf other Is PlaneSprite Then
            Form1.Plane.LoseHealth(Me.Damage)
            REM this should delete the enemy when it hits the player's plane but it doesn't...
            'Form1.alProjectile.Remove(Me)
            'MyBase.Health = 0
            MyBase.onDead()
        Else
            Return False
        End If
        Return False
    End Function

End Class
