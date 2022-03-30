Public Class Upgrade
    Inherits Sprite

    Private pUpgradeName As Form1.Upgrades

    Public Sub New(ByVal image As Bitmap, ByVal startX As Integer, ByVal startY As Integer, ByVal health As Integer, ByVal upgradeName As Form1.Upgrades)
        MyBase.New(image, startX, startY, 5000)
        MyBase.Damage = 0
        pUpgradeName = upgradeName
    End Sub

    Public Function performUpgrade(ByRef plane As PlaneSprite)

        Select Case pUpgradeName
            Case Form1.Upgrades.DamageIncrease
                If Not plane.Damage > 249 Then
                    plane.Damage += 20
                End If
                Form1.alCollectedUpgrades.Add(New Upgrade(Form1.pbxDamageUpgrade.Image, 0, 0, 1, Form1.Upgrades.DamageIncrease))
            Case Form1.Upgrades.HealthIncrease
                If Not plane.maximumHealth > 599 Then
                    plane.maximumHealth += 200
                    plane.Health = plane.maximumHealth
                    Form1.pbxHealthBar.Width += 20
                End If
                Form1.alCollectedUpgrades.Add(New Upgrade(Form1.pbxHealthUpgrade.Image, 0, 0, 1, Form1.Upgrades.HealthIncrease))
            Case Form1.Upgrades.SpeedIncrease
                If Not plane.Speed > 9 Then
                    plane.Speed += 2
                End If
                Form1.alCollectedUpgrades.Add(New Upgrade(Form1.pbxSpeedUpgrade.Image, 0, 0, 1, Form1.Upgrades.SpeedIncrease))
            Case Form1.Upgrades.FirerateIncrease
                If Not Form1.fireRate = 1 Then
                    Form1.fireRate -= 1
                End If
                Form1.alCollectedUpgrades.Add(New Upgrade(Form1.pbxFirerateUpgrade.Image, 0, 0, 1, Form1.Upgrades.FirerateIncrease))
            Case Form1.Upgrades.ShieldSteal
                Form1.Plane.shieldSteal = True
                Form1.alCollectedUpgrades.Add(New Upgrade(Form1.pbxShieldStealUpgrade.Image, 0, 0, 1, Form1.Upgrades.ShieldSteal))
            Case Form1.Upgrades.RingShot
                Form1.Plane.ringShot = True
                Form1.Plane.bulletImage = Form1.pbxRingBullet.Image
                Form1.Plane.uniqueAttackModifier = Form1.ShotTypes.RingShot
                Form1.Plane.Damage += 10
                Form1.alCollectedUpgrades.Add(New Upgrade(Form1.pbxRingShotUpgrade.Image, 0, 0, 1, Form1.Upgrades.RingShot))
            Case Form1.Upgrades.DiagonalShot
                Form1.Plane.diagonalShot = True
                Form1.alCollectedUpgrades.Add(New Upgrade(Form1.pbxDiagonalShotUpgrade.Image, 0, 0, 1, Form1.Upgrades.DiagonalShot))
            Case Form1.Upgrades.ZigZagShot
                Form1.Plane.zigZagShot = True
                Form1.alCollectedUpgrades.Add(New Upgrade(Form1.pbxZigZagUpgrade.Image, 0, 0, 1, Form1.Upgrades.ZigZagShot))
            Case Form1.Upgrades.Repairs
                Form1.Plane.repairs = True
                Form1.alCollectedUpgrades.Add(New Upgrade(Form1.pbxRepairsUpgrade.Image, 0, 0, 1, Form1.Upgrades.Repairs))
                plane.shielded = False
            Case Form1.Upgrades.SplitShot
                Form1.Plane.splitShot = True
                Form1.alCollectedUpgrades.Add(New Upgrade(Form1.pbxSplitShotUpgrade.Image, 0, 0, 1, Form1.Upgrades.SplitShot))
        End Select
        Return plane
    End Function

    Public Overrides Function OnCollision(ByRef other As Sprite) As Boolean
        performUpgrade(other)
        Return True
    End Function

End Class
