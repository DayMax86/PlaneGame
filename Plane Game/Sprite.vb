Public Class Sprite

    Private pXpos As Integer
    Private pYpos As Integer
    Private pImage As Bitmap
    Private pHealth As Integer
    Private pDamage As Integer
    Private pMovementDir As Form1.Directions
    Private pSpeed As Integer
    Private pCurrentAnimationFrame As Integer
    Private pAnimationImage As Bitmap
    Private pDeathAnimationFrames As ArrayList
    Private pMovementAnimationFrames As ArrayList
    Private pAbilityAnimationFrames As ArrayList
    Private pDamageTakenAnimationFrames As ArrayList
    Private pAnimationType As Form1.Animations

    Public Sub New(ByVal image As Bitmap, ByVal startX As Integer, ByVal startY As Integer, ByVal health As Integer)
        pImage = image
        Xpos = startX
        Ypos = startY
        pHealth = health
        pCurrentAnimationFrame = 1
        pDeathAnimationFrames = New ArrayList
        pMovementAnimationFrames = New ArrayList
        pAbilityAnimationFrames = New ArrayList
        pDamageTakenAnimationFrames = New ArrayList
        PopulateAnimationArraylist()
        pAnimationCount = 0
    End Sub

    Public Property deathAnimationFrames As ArrayList
        Get
            Return pDeathAnimationFrames
        End Get
        Set(value As ArrayList)
            pDeathAnimationFrames = value
        End Set
    End Property
    Public Property movementAnimationFrames As ArrayList
        Get
            Return pMovementAnimationFrames
        End Get
        Set(value As ArrayList)
            pMovementAnimationFrames = value
        End Set
    End Property
    Public Property abilityAnimationFrames As ArrayList
        Get
            Return pAbilityAnimationFrames
        End Get
        Set(value As ArrayList)
            pAbilityAnimationFrames = value
        End Set
    End Property
    Public Property DamagetakenAnimationFrames As ArrayList
        Get
            Return pDamageTakenAnimationFrames
        End Get
        Set(value As ArrayList)
            pDamageTakenAnimationFrames = value
        End Set
    End Property

    Public Property animationType As Form1.Animations
        Get
            Return pAnimationType
        End Get
        Set(value As Form1.Animations)
            pAnimationType = value
        End Set
    End Property

    Public Property animationImage As Bitmap
        Get
            Return pAnimationImage
        End Get
        Set(value As Bitmap)
            pAnimationImage = value
        End Set
    End Property

    Public Overridable Sub checkEdgeCollisions()
        If Xpos > Form1.Display.Width - Me.Image.Width Then
            Xpos = Form1.Display.Width - Me.Image.Width
        End If
        If Ypos > Form1.Display.Height - Me.Image.Height Then
            Ypos = Form1.Display.Height - Me.Image.Height
        End If
        If Xpos < 0 Then
            Xpos = 0
        End If
        If Ypos < 0 Then
            Ypos = 0
        End If
    End Sub

    Public Property Speed As Integer
        Get
            Return pSpeed
        End Get
        Set(value As Integer)
            pSpeed = value
        End Set
    End Property

    Public Property movementDir As Form1.Directions
        Get
            Return pMovementDir
        End Get
        Set(ByVal value As Form1.Directions)
            pMovementDir = value
        End Set
    End Property

    Public Property Xpos As Integer
        Get
            Return pXpos
        End Get
        Set(ByVal value As Integer)
            pXpos = value
        End Set
    End Property

    Public Property Ypos As Integer
        Get
            Return pYpos
        End Get
        Set(ByVal value As Integer)
            pYpos = value
        End Set
    End Property

    Public Property Image As Bitmap
        Get
            Return pImage
        End Get
        Set(ByVal value As Bitmap)
            pImage = value
        End Set
    End Property

    Public Overridable Sub DefaultMove()
        Ypos += Speed
        checkEdgeCollisions()
        movementDir = Form1.Directions.Down
        pNumberOfSteps += 1
    End Sub
    Public Overridable Sub UpMove()
        Ypos -= Speed
        checkEdgeCollisions()
        movementDir = Form1.Directions.Up
        pNumberOfSteps += 1
    End Sub
    Public Overridable Sub NEMove()
        Ypos -= Speed - 0.5
        Xpos += Speed - 0.5
        checkEdgeCollisions()
        movementDir = Form1.Directions.NE
        pNumberOfSteps += 1
    End Sub
    Public Overridable Sub RightMove()
        Xpos += Speed
        checkEdgeCollisions()
        movementDir = Form1.Directions.Right
        pNumberOfSteps += 1
    End Sub
    Public Overridable Sub SEMove()
        Ypos += Speed - 0.5
        Xpos += Speed - 0.5
        checkEdgeCollisions()
        movementDir = Form1.Directions.SE
        pNumberOfSteps += 1
    End Sub
    Public Overridable Sub DownMove()
        Ypos += Speed
        checkEdgeCollisions()
        movementDir = Form1.Directions.Down
        pNumberOfSteps += 1
    End Sub
    Public Overridable Sub SWMove()
        Ypos += Speed - 0.5
        Xpos -= Speed - 0.5
        checkEdgeCollisions()
        movementDir = Form1.Directions.SW
        pNumberOfSteps += 1
    End Sub
    Public Overridable Sub LeftMove()
        Xpos -= Speed
        checkEdgeCollisions()
        movementDir = Form1.Directions.Left
        pNumberOfSteps += 1
    End Sub
    Public Overridable Sub NWMove()
        Ypos -= Speed - 0.5
        Xpos -= Speed - 0.5
        checkEdgeCollisions()
        movementDir = Form1.Directions.NW
        pNumberOfSteps += 1
    End Sub

    Private pNumberOfSteps As Integer

    Public Overridable Property numberOfSteps As Integer
        Get
            Return pNumberOfSteps
        End Get
        Set(value As Integer)
            pNumberOfSteps = value
        End Set
    End Property


    Public Overridable Function IsOffScreen() As Boolean
        If Ypos > (Form1.DisplayHeight + pImage.Height) Or Xpos > (Form1.DisplayWidth + pImage.Width) Or Ypos < (0 - pImage.Height) Or Xpos < (0 - pImage.Width) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Overridable ReadOnly Property Bounds() As Rectangle
        Get
            Dim rect As Rectangle
            rect = New Rectangle(pXpos, pYpos, pImage.Width, pImage.Height)
            Return rect
        End Get
    End Property

    Public Overridable Function IsColliding(ByRef other As Sprite) As Boolean
        Return Me.Bounds.IntersectsWith(other.Bounds())
    End Function

    Public Overridable Function OnCollision(ByRef other As Sprite) As Boolean
        ' Returns TRUE if sprite can be deleted after collision
        Return False
    End Function

    Public Overridable Property Health As Integer
        Get
            Return pHealth
        End Get
        Set(ByVal value As Integer)
            pHealth = value
        End Set
    End Property

    Public Overridable Function LoseHealth(ByVal dmg As Integer) As Integer
        If Not shielded Then
            pHealth -= dmg
        Else
            Dim remainder As Integer = Math.Abs((pShieldStrength - dmg))
            pShieldStrength -= dmg
            If pShieldStrength <= 0 Then
                'pShielded = False
                pShieldStrength = 0
                pHealth -= remainder
            End If
        End If
        Return pHealth
    End Function

    Public Property Damage As Integer
        Get
            Return pDamage
        End Get
        Set(ByVal value As Integer)
            pDamage = value
        End Set
    End Property

    Public Overridable Function isHostile() As Boolean
        Return False
    End Function

    Public Overridable Sub onDead()
        pAnimationType = Form1.Animations.death
        pAnimationImage = pDeathAnimationFrames(0)
        pCanAnimate = True
    End Sub

    Private pShielded As Boolean

    Public Property shielded As Boolean
        Get
            Return pShielded
        End Get
        Set(value As Boolean)
            pShielded = value
        End Set
    End Property

    Private pShieldStrength As Integer

    Public Property shieldStrength
        Get
            Return pShieldStrength
        End Get
        Set(value)
            pShieldStrength = value
        End Set
    End Property

    Private pMaximumShieldStrength As Integer
    Public Property maximumShieldStrength As Integer
        Get
            pMaximumShieldStrength = 50
            Return pMaximumShieldStrength
        End Get
        Set(value As Integer)
            pMaximumShieldStrength = value
        End Set
    End Property

    Private pShieldSteal As Boolean
    Public Property shieldSteal As Boolean
        Get
            Return pShieldSteal
        End Get
        Set(value As Boolean)
            pShieldSteal = value
        End Set
    End Property

    Public Overridable Sub PopulateAnimationArraylist()
        pDeathAnimationFrames.Add(Form1.pbxAnimDeadEnemy1.Image) REM makes sense for the pictures to start at 0 too to avoid confusion.
        pDeathAnimationFrames.Add(Form1.pbxAnimDeadEnemy2.Image)
        pDeathAnimationFrames.Add(Form1.pbxAnimDeadEnemy3.Image)
        pDeathAnimationFrames.Add(Form1.pbxAnimDeadEnemy4.Image)
        pDeathAnimationFrames.Add(Form1.pbxAnimDeadEnemy5.Image)
        pDeathAnimationFrames.Add(Form1.pbxAnimDeadEnemy6.Image)
        pDeathAnimationFrames.Add(Form1.pbxAnimDeadEnemy7.Image)
        pDeathAnimationFrames.Add(Form1.pbxAnimDeadEnemy8.Image)
        pMovementAnimationFrames.Add(Form1.pbxAnimTimerFrame1.Image)
        pMovementAnimationFrames.Add(Form1.pbxAnimTimerFrame2.Image)
        pMovementAnimationFrames.Add(Form1.pbxAnimTimerFrame3.Image)
        pMovementAnimationFrames.Add(Form1.pbxAnimTimerFrame4.Image)
        pMovementAnimationFrames.Add(Form1.pbxAnimTimerFrame5.Image)
        pMovementAnimationFrames.Add(Form1.pbxAnimTimerFrame6.Image)
        pMovementAnimationFrames.Add(Form1.pbxAnimTimerFrame7.Image)
        pMovementAnimationFrames.Add(Form1.pbxAnimTimerFrame8.Image)
    End Sub

    Private pAnimationCount As Integer

    Public Overridable Function GetAnimationImage(ByVal status As Form1.Animations) As Bitmap
        pAnimationCount += 1

        Select Case status
            Case Form1.Animations.death
                Select Case pCurrentAnimationFrame
                    Case 1 : pCurrentAnimationFrame += 1 : Return pDeathAnimationFrames(0)
                    Case 2 : pCurrentAnimationFrame += 1 : Return pDeathAnimationFrames(1)
                    Case 3 : pCurrentAnimationFrame += 1 : Return pDeathAnimationFrames(2)
                    Case 4 : pCurrentAnimationFrame += 1 : Return pDeathAnimationFrames(3)
                    Case 5 : pCurrentAnimationFrame += 1 : Return pDeathAnimationFrames(4)
                    Case 6 : pCurrentAnimationFrame += 1 : Return pDeathAnimationFrames(5)
                    Case 7 : pCurrentAnimationFrame += 1 : Return pDeathAnimationFrames(6)
                    Case 8 : pCurrentAnimationFrame += 1 : Return pDeathAnimationFrames(7)
                        Me.canAnimate = False
                        Form1.alAnimation.Remove(Me)
                End Select
            Case Form1.Animations.movement
                Dim result As Image = pMovementAnimationFrames(pCurrentAnimationFrame - 1)
                If pAnimationCount Mod 10 = 0 Then
                    If pCurrentAnimationFrame = 8 Then
                        Me.canAnimate = False
                    Else
                        pCurrentAnimationFrame += 1
                    End If
                End If
                Return result
        End Select
        Return Nothing
    End Function

    Public Property currentAnimationFrame As Integer
        Get
            Return pCurrentAnimationFrame
        End Get
        Set(value As Integer)
            pCurrentAnimationFrame = value
        End Set
    End Property

    Private pCanAnimate As Boolean = False
    Public Property canAnimate As Boolean
        Get
            Return pCanAnimate
        End Get
        Set(value As Boolean)
            pCanAnimate = value
        End Set
    End Property

End Class
