Public Class HealthDrop
    Inherits Drop

    Public Sub New(ByVal Image As Bitmap, ByVal startX As Integer, ByVal startY As Integer, ByVal health As Integer)
        MyBase.New(Image, startX, startY, health)
    End Sub

    Public Sub Heal()
        If (Form1.Plane.maximumHealth - Form1.Plane.Health) <= 15 Then
            Form1.Plane.Health += (Form1.Plane.maximumHealth - Form1.Plane.Health)
        Else
            Form1.Plane.Health += 15
        End If
    End Sub

    Public Overrides Function OnCollision(ByRef other As Sprite) As Boolean
        Return True
    End Function

End Class
