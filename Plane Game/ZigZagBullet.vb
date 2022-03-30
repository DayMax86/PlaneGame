Public Class ZigZagBullet

    Inherits Bullet

    Private pNextMovementDir As Form1.Directions
    Private pFrameCounter As Integer

    Public Sub New(ByVal image As Bitmap, ByVal startX As Integer, ByVal startY As Integer, ByVal health As Integer, ByVal movementDir As Form1.Directions, ByVal nextMovementDir As Form1.Directions)
        MyBase.New(image, startX, startY, health, movementDir)
        pNextMovementDir = nextMovementDir
    End Sub

    Public Property nextMovementDir As Form1.Directions
        Get
            Return pNextMovementDir
        End Get
        Set(value As Form1.Directions)
            pNextMovementDir = value
        End Set
    End Property

    Public Property frameCounter As Integer
        Get
            Return pFrameCounter
        End Get
        Set(value As Integer)
            pFrameCounter = value
        End Set
    End Property

End Class
