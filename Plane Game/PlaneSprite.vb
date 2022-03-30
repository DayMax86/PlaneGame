Imports Plane_Game.Form1

Public Class PlaneSprite
    Inherits Sprite

    Private pDisplayWidth, pDisplayHeight As Integer
    Private pxPos As Integer
    Private pyPos As Integer
    Private pImage As Bitmap
    Private pPlaneWidth, pPlaneHeight As Integer
    Private pLife As Integer
    Private pMaximumHealth As Integer
    Private pRingShot As Boolean
    Private pDiagonalShot As Boolean
    Private pZigZagShot As Boolean
    Private pRepairs As Boolean
    Private pSplitShot As Boolean
    Private pUniqueAttackModifier As Form1.ShotTypes
    Private pBulletImage As Bitmap
    Private pActiveItem As ActiveItem

    Public Sub activateItem()
        Select Case pActiveItem.ItemName
            Case ActiveItems.Sloth
                For Each Enemy1 In Form1.alProjectile
                    If Not Enemy1.GetType().Equals(GetType(Bullet)) Or Enemy1.GetType().Equals(GetType(ZigZagBullet)) Then
                        If Enemy1.ishostile And Enemy1.Speed = Enemy1.defaultSpeed Then
                            Enemy1.Speed = Math.Ceiling(Enemy1.Speed / 2)
                        End If
                    End If
                Next

                pActiveItem.currentAnimationFrame = 1
                pActiveItem.canAnimate = True
                pActiveItem.Xpos = 5
                pActiveItem.Ypos = 30
                pActiveItem.animationType = Animations.movement
                pActiveItem.animationImage = pActiveItem.movementAnimationFrames(0)
                Form1.alAnimation.Add(pActiveItem)

                Form1.ActiveItemTimer.Enabled = True
        End Select
    End Sub

    Public Property activeItem As ActiveItem
        Get
            Return pActiveItem
        End Get
        Set(value As ActiveItem)
            pActiveItem = value
        End Set
    End Property

    Public Property splitShot As Boolean
        Get
            Return pSplitShot
        End Get
        Set(value As Boolean)
            pSplitShot = value
        End Set
    End Property

    Public Property bulletImage As Bitmap
        Get
            Return pBulletImage
        End Get
        Set(value As Bitmap)
            pBulletImage = value
        End Set
    End Property

    Public Property uniqueAttackModifier As Form1.ShotTypes
        Get
            Return pUniqueAttackModifier
        End Get
        Set(value As Form1.ShotTypes)
            pUniqueAttackModifier = value
        End Set
    End Property

    Public Property maximumHealth As Integer
        Get
            Return pMaximumHealth
        End Get
        Set(value As Integer)
            pMaximumHealth = value
        End Set
    End Property

    Public Sub New(ByVal image As Bitmap, ByVal startX As Integer, ByVal startY As Integer, ByVal health As Integer)
        MyBase.New(image, startX, startY, health)
        pDisplayWidth = Form1.Display.Width
        pDisplayHeight = Form1.Display.Height
        pMaximumHealth = 100
        MyBase.Speed = 6
        MyBase.Damage = 35
    End Sub

    Public Property repairs As Boolean
        Get
            Return pRepairs
        End Get
        Set(value As Boolean)
            pRepairs = value
        End Set
    End Property

    Public Property zigZagShot As Boolean
        Get
            Return pZigZagShot
        End Get
        Set(value As Boolean)
            pZigZagShot = value
        End Set
    End Property

    Public Property ringShot As Boolean
        Get
            Return pRingShot
        End Get
        Set(value As Boolean)
            pRingShot = value
        End Set
    End Property

    Public Property diagonalShot As Boolean
        Get
            Return pDiagonalShot
        End Get
        Set(value As Boolean)
            pDiagonalShot = value
        End Set
    End Property

    Public Sub MoveLeft()
        pxPos -= MyBase.Speed
        If pxPos < 0 Then
            pxPos = 0
        End If
    End Sub

    Public Sub MoveRight()
        pxPos += MyBase.Speed
        If pxPos > pDisplayWidth - PlaneWidth Then
            pxPos = pDisplayWidth - PlaneWidth
        End If
    End Sub

    Public Sub MoveUp()
        pyPos -= MyBase.Speed
        If pyPos < 0 Then
            pyPos = 0
        End If
    End Sub

    Public Sub MoveDown()
        pyPos += MyBase.Speed
        If pyPos > pDisplayHeight - PlaneHeight Then
            pyPos = pDisplayHeight - PlaneHeight
        End If
    End Sub

    Public Overloads Property xPos As Integer
        Get
            Return pxPos
        End Get
        Set(ByVal value As Integer)
            pxPos = value
        End Set
    End Property

    Public Overloads Property yPos As Integer
        Get
            Return pyPos
        End Get
        Set(ByVal value As Integer)
            pyPos = value
        End Set
    End Property

    Public Overloads Property Image As Bitmap
        Get
            Return pImage
        End Get
        Set(ByVal value As Bitmap)
            pImage = value
        End Set
    End Property


    Public Property PlaneWidth As Integer
        Get
            Return pPlaneWidth
        End Get
        Set(ByVal value As Integer)
            pPlaneWidth = value
        End Set
    End Property


    Public Property PlaneHeight As Integer
        Get
            Return pPlaneHeight
        End Get
        Set(ByVal value As Integer)
            pPlaneHeight = value
        End Set
    End Property

    Public Overrides ReadOnly Property Bounds() As Rectangle
        Get
            Dim rect As Rectangle
            rect = New Rectangle(pxPos, pyPos, PlaneWidth, pPlaneHeight)
            Return rect
        End Get
    End Property

    Public Property Life As Integer
        Get
            Return pLife
        End Get
        Set(ByVal value As Integer)
            pLife = value
        End Set
    End Property

    Public Function LoseLife()
        pLife -= 1
        Return pLife
    End Function

    Public Sub Heal(ByVal amount As Integer)
        MyBase.Health += amount
    End Sub

    Public Overrides Function onCollision(ByRef other As Sprite) As Boolean
        If TypeOf other Is Enemy Then
            LoseHealth(other.Damage)
        End If
        Return False
    End Function

End Class
