Public Class StrongEnemy
    Inherits Enemy

    Private pHealth As Integer

    Public Sub New(ByVal image As Bitmap, ByVal startX As Integer, ByVal startY As Integer, ByVal health As Integer)
        MyBase.New(Form1.pbxStrongEnemyDown.Image, startX, startY, health)
        image = Form1.pbxStrongEnemyDown.Image
        MyBase.Speed = 2
        MyBase.defaultSpeed = 2
        MyBase.Health = 100
    End Sub

    Public Overrides Sub DefaultMove()
        Ypos += MyBase.Speed
        checkEdgeCollisions()
        If MyBase.Health <= (pHealth / 2) Then
            Me.Image = Form1.pbxStrongEnemyDownDamaged.Image
        Else
            Me.Image = Form1.pbxStrongEnemyDown.Image
        End If
        MyBase.movementDir = Form1.Directions.Down
        MyBase.numberOfSteps += 1
    End Sub
    Public Overrides Sub UpMove()
        Ypos -= MyBase.Speed
        checkEdgeCollisions()
        If MyBase.Health <= (pHealth / 2) Then REM this doesn't work.
            Me.Image = Form1.pbxStrongEnemyUpDamaged.Image
        Else
            Me.Image = Form1.pbxStrongEnemyUp.Image
        End If
        MyBase.movementDir = Form1.Directions.Up
        MyBase.numberOfSteps += 1
    End Sub
    Public Overrides Sub NEMove()
        Ypos -= MyBase.Speed
        Xpos += MyBase.Speed
        checkEdgeCollisions()
        If MyBase.Health <= (pHealth / 2) Then
            Me.Image = Form1.pbxStrongEnemyUpDamaged.Image
        Else
            Me.Image = Form1.pbxStrongEnemyNE.Image
        End If
        MyBase.movementDir = Form1.Directions.NE
        MyBase.numberOfSteps += 1
    End Sub
    Public Overrides Sub DownMove()
        Ypos += MyBase.Speed
        checkEdgeCollisions()
        If MyBase.Health <= (pHealth / 2) Then
            Me.Image = Form1.pbxStrongEnemyDownDamaged.Image
        Else
            Me.Image = Form1.pbxStrongEnemyDown.Image
        End If
        MyBase.movementDir = Form1.Directions.Down
        MyBase.numberOfSteps += 1
    End Sub
    Public Overrides Sub SEMove()
        Ypos += MyBase.Speed
        Xpos += MyBase.Speed
        checkEdgeCollisions()
        If MyBase.Health <= (pHealth / 2) Then
            Me.Image = Form1.pbxStrongEnemyUpDamaged.Image
        Else
            Me.Image = Form1.pbxStrongEnemySE.Image
        End If
        MyBase.movementDir = Form1.Directions.SE
        MyBase.numberOfSteps += 1
    End Sub
    Public Overrides Sub LeftMove()
        Xpos -= MyBase.Speed
        checkEdgeCollisions()
        If MyBase.Health <= (pHealth / 2) Then
            Me.Image = Form1.pbxStrongEnemyLeftDamaged.Image
        Else
            Me.Image = Form1.pbxStrongEnemyLeft.Image
        End If
        MyBase.movementDir = Form1.Directions.Left
        MyBase.numberOfSteps += 1
    End Sub
    Public Overrides Sub NWMove()
        Ypos -= MyBase.Speed
        Xpos -= MyBase.Speed
        checkEdgeCollisions()
        If MyBase.Health <= (pHealth / 2) Then
            Me.Image = Form1.pbxStrongEnemyUpDamaged.Image
        Else
            Me.Image = Form1.pbxStrongEnemyNW.Image
        End If
        MyBase.movementDir = Form1.Directions.NW
        MyBase.numberOfSteps += 1
    End Sub
    Public Overrides Sub RightMove()
        Xpos += MyBase.Speed
        checkEdgeCollisions()
        If MyBase.Health <= (pHealth / 2) Then
            Me.Image = Form1.pbxStrongEnemyRightDamaged.Image
        Else
            Me.Image = Form1.pbxStrongEnemyRight.Image
        End If
        MyBase.movementDir = Form1.Directions.Right
        MyBase.numberOfSteps += 1
    End Sub
    Public Overrides Sub SWMove()
        Ypos += MyBase.Speed
        Xpos -= MyBase.Speed
        checkEdgeCollisions()
        If MyBase.Health <= (pHealth / 2) Then
            Me.Image = Form1.pbxStrongEnemyUpDamaged.Image
        Else
            Me.Image = Form1.pbxStrongEnemySW.Image
        End If
        MyBase.movementDir = Form1.Directions.SW
        MyBase.numberOfSteps += 1
    End Sub

    Public Overrides Function isHostile() As Boolean
        Return True
    End Function

    Public Overrides Sub onDead()
        MyBase.onDead()
        Dim rndNum As Integer = 0
        Randomize()
        rndNum = (Rnd() * 100)
        If rndNum < 10 Then
            Form1.alItem.Add(New HealthDrop(Form1.pbxHealthDrop.Image, Me.Xpos, Me.Ypos, 100000))
        End If
    End Sub

End Class
