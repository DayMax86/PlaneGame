Public Class Mothership
    Inherits Enemy

    Public Sub New(ByVal image As Bitmap, ByVal startX As Integer, ByVal startY As Integer, ByVal health As Integer)
        MyBase.New(image, startX, startY, health)
        MyBase.Damage = 5
        MyBase.Speed = 1
        MyBase.defaultSpeed = 1
        MyBase.Health = 2000
        pMovementTimer = 500
    End Sub

    Private pMovementDir1
    Public Property movementDir1
        Get
            Return pMovementDir1
        End Get
        Set(value)
            pMovementDir1 = value
        End Set
    End Property

    Private pMovementTimer As Integer
    Public Property MovementTimer As Integer
        Get
            Return pMovementTimer
        End Get
        Set(value As Integer)
            pMovementTimer = value
        End Set
    End Property

    Public Overrides Sub UpMove()
        Ypos -= Speed
        checkEdgeCollisions()
        pMovementDir1 = Form1.Directions.Up
        MyBase.numberOfSteps += 1
    End Sub
    Public Overrides Sub DownMove()
        Ypos += Speed
        checkEdgeCollisions()
        pMovementDir1 = Form1.Directions.Down
        MyBase.numberOfSteps += 1
    End Sub

    Public Overrides Sub onDead()
        MyBase.onDead()
        REM drops
        Dim rndNum As Integer = 0
        Randomize()
        Form1.alItem.Add(New HealthDrop(Form1.pbxHealthDrop.Image, Me.Xpos, Me.Ypos, 100000))
        Form1.alItem.Add(New ShieldDrop(Form1.pbxShieldDrop.Image, Me.Xpos + 32, Me.Ypos + 32, 100000))
        Form1.alItem.Add(New HealthDrop(Form1.pbxHealthDrop.Image, Me.Xpos + 64, Me.Ypos + 64, 100000))
        Form1.alItem.Add(New HealthDrop(Form1.pbxHealthDrop.Image, Me.Xpos + 64, Me.Ypos + 32, 100000))
        Form1.alItem.Add(New HealthDrop(Form1.pbxHealthDrop.Image, Me.Xpos + 32, Me.Ypos + 64, 100000))
        REM shield steal etc
        If Form1.Plane.shieldSteal = True Then
            If Not Form1.Plane.shieldStrength >= Form1.Plane.maximumShieldStrength Then
                Form1.Plane.shieldStrength += 10
                'Form1.Plane.shielded = True
            End If
        End If
    End Sub

End Class
