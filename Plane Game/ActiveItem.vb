Public Class ActiveItem
    Inherits Sprite

    Private pItemName As Form1.ActiveItems

    Public Sub New(ByVal image As Bitmap, ByVal startX As Integer, ByVal startY As Integer, ByVal health As Integer, ByVal ItemName As Form1.ActiveItems)
        MyBase.New(image, startX, startY, health)
        MyBase.currentAnimationFrame = 1
        pItemName = ItemName
    End Sub

    Public Sub GiveItem(ByVal item As ActiveItem)
        Select Case item.ItemName
            Case Form1.ActiveItems.Sloth
                Form1.Plane.activeItem = Me
                Form1.Plane.activeItem.ItemName = Form1.ActiveItems.Sloth
        End Select
    End Sub

    Public Overrides Function OnCollision(ByRef other As Sprite) As Boolean
        GiveItem(other)
        Return True
    End Function

    Public Property ItemName As Form1.ActiveItems
        Get
            Return pItemName
        End Get
        Set(value As Form1.ActiveItems)
            pItemName = value
        End Set
    End Property

    Public Overrides Sub PopulateAnimationArraylist()
        MyBase.movementAnimationFrames.Add(Form1.pbxAnimTimerFrame1.Image)
        MyBase.movementAnimationFrames.Add(Form1.pbxAnimTimerFrame2.Image)
        MyBase.movementAnimationFrames.Add(Form1.pbxAnimTimerFrame3.Image)
        MyBase.movementAnimationFrames.Add(Form1.pbxAnimTimerFrame4.Image)
        MyBase.movementAnimationFrames.Add(Form1.pbxAnimTimerFrame5.Image)
        MyBase.movementAnimationFrames.Add(Form1.pbxAnimTimerFrame6.Image)
        MyBase.movementAnimationFrames.Add(Form1.pbxAnimTimerFrame7.Image)
        MyBase.movementAnimationFrames.Add(Form1.pbxAnimTimerFrame8.Image)
    End Sub

End Class
