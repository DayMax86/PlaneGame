Imports System.Timers

Public Class Bullet
    Inherits Sprite

    Public Sub New(ByVal image As Bitmap, ByVal startX As Integer, ByVal startY As Integer, ByVal health As Integer, ByVal movementDir As Form1.Directions)
        MyBase.New(image, startX, startY, health)
        MyBase.movementDir = movementDir
        MyBase.Damage = Form1.Plane.Damage
    End Sub

    Public Overrides Sub checkEdgeCollisions()
        If Xpos > Form1.Display.Width - Me.Image.Width Then
            Form1.alGlobalBin.Add(Me)
        End If
        If Ypos > Form1.Display.Height - Me.Image.Height Then
            Form1.alGlobalBin.Add(Me)
        End If
        If Xpos < (0 - Me.Image.Width) Then
            Form1.alGlobalBin.Add(Me)
        End If
        If Ypos < (0 - Me.Image.Height) Then
            Form1.alGlobalBin.Add(Me)
        End If
    End Sub

    Public Overrides Sub DefaultMove()
        Ypos -= 12
        checkEdgeCollisions()
    End Sub
    Public Overrides Sub RightMove()
        Xpos += 12
        checkEdgeCollisions()
    End Sub
    Public Overrides Sub LeftMove()
        Xpos -= 12
        checkEdgeCollisions()
    End Sub
    Public Overrides Sub DownMove()
        Ypos += 12
        checkEdgeCollisions()
    End Sub
    Public Overrides Sub UpMove()
        Ypos -= 12
        checkEdgeCollisions()
    End Sub
    Public Overrides Sub NEMove()
        Ypos -= 8
        Xpos += 8
        If Form1.Plane.ringShot = True Then
            MyBase.Image = Form1.pbxRingBullet.Image
        Else
            MyBase.Image = Form1.pbxBulletNE.Image
        End If
        checkEdgeCollisions()
    End Sub
    Public Overrides Sub NWMove()
        Ypos -= 8
        Xpos -= 8
        If Form1.Plane.ringShot = True Then
            MyBase.Image = Form1.pbxRingBullet.Image
        Else
            MyBase.Image = Form1.pbxBulletNW.Image
        End If
        checkEdgeCollisions()
    End Sub
    Public Overrides Sub SEMove()
        Ypos += 8
        Xpos += 8
        If Form1.Plane.ringShot = True Then
            MyBase.Image = Form1.pbxRingBullet.Image
        Else
            MyBase.Image = Form1.pbxBulletSE.Image
        End If
        checkEdgeCollisions()
    End Sub
    Public Overrides Sub SWMove()
        Ypos += 8
        Xpos -= 8
        If Form1.Plane.ringShot = True Then
            MyBase.Image = Form1.pbxRingBullet.Image
        Else
            MyBase.Image = Form1.pbxBulletSW.Image
        End If
        checkEdgeCollisions()
    End Sub

    Public Overrides Sub onDead()
        MyBase.canAnimate = False
    End Sub

    Public Overrides Function OnCollision(ByRef other As Sprite) As Boolean
        If TypeOf other Is Bullet Then
            Return False
        Else : Return True
        End If
    End Function
End Class
