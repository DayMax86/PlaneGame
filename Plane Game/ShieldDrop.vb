Public Class ShieldDrop
    Inherits Drop

    Public Sub New(ByVal Image As Bitmap, ByVal startX As Integer, ByVal startY As Integer, ByVal health As Integer)
        MyBase.New(Image, startX, startY, health)
    End Sub

    Public Sub ProvideShield(ByVal strength As Integer)
        If Not (Form1.Plane.shieldStrength + strength) >= Form1.Plane.maximumShieldStrength Then
            Form1.Plane.shieldStrength += strength
        Else
            Form1.Plane.shieldStrength += (Form1.Plane.maximumShieldStrength - Form1.Plane.shieldStrength)
        End If
        'Form1.Plane.shielded = True
    End Sub

    Public Overrides Function OnCollision(ByRef other As Sprite) As Boolean
        Return True
    End Function
End Class
