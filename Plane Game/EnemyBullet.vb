Public Class EnemyBullet
    Inherits Bullet

    Public Sub New(ByVal image As Bitmap, ByVal startX As Integer, ByVal startY As Integer, ByVal health As Integer, ByVal movementDir As Form1.Directions)
        MyBase.New(image, startX, startY, health, movementDir)
        MyBase.Damage = 20
    End Sub

    Public Overrides Sub DefaultMove()
        Ypos -= 10
    End Sub
    Public Overrides Sub RightMove()
        Xpos += 10
    End Sub
    Public Overrides Sub LeftMove()
        Xpos -= 10
    End Sub
    Public Overrides Sub DownMove()
        Ypos += 10
    End Sub
    Public Overrides Sub UpMove()
        Ypos -= 10
    End Sub

End Class
