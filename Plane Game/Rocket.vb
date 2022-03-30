Public Class Rocket
        Inherits Sprite

        Public Sub New(ByVal image As Bitmap, ByVal startX As Integer, ByVal startY As Integer, ByVal health As Integer)
            MyBase.New(image, startX, startY, Health)
        End Sub

    Public Overrides Sub DefaultMove()
        Ypos -= 5
    End Sub

    End Class

