Public Class Item

    Public Sub New(ByVal startX As Integer, ByVal startY As Integer, ByVal image As Bitmap)
        startX = pXpos
        startY = pYpos
        image = pImage
    End Sub

    Private pXpos As Integer
    Private pYpos As Integer
    Private pImage As Bitmap

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

End Class
