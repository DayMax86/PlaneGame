Public Class Drop
    Inherits Sprite

    Public Sub New(ByVal Image As Bitmap, ByVal startX As Integer, ByVal startY As Integer, ByVal health As Integer)
        MyBase.New(Image, startX, startY, health)
    End Sub

    Public Overrides Function OnCollision(ByRef other As Sprite) As Boolean
        Return True
    End Function

    Private pFrameCount As Integer

    Public Property frameCount As Integer
        Get
            Return pFrameCount
        End Get
        Set(value As Integer)
            pFrameCount = value
        End Set
    End Property

End Class
