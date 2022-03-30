Public Class Round

    Private pRoundNumber As Integer
    Private pMaxEnemyCount As Integer

    Public Sub New(ByVal roundNumber As Integer)
        pRoundNumber = roundNumber
    End Sub

    Public Property roundNumber As Integer
        Get
            Return pRoundNumber
        End Get
        Set(ByVal value As Integer)
            pRoundNumber = value
        End Set
    End Property

    Public Property maxEnemyCount As Integer
        Get
            Return pMaxEnemyCount
        End Get
        Set(ByVal value As Integer)
            pMaxEnemyCount = value
        End Set
    End Property

    Public Sub onRoundChange()
        Form1.numberOfMothershipSpawns = 0
        Form1.PauseGame()
        Form1.RoundChangeTimer.Enabled = True
        pRoundNumber += 1
        Select Case pRoundNumber
            Case 1
                pMaxEnemyCount = 10
            Case 2
                pMaxEnemyCount = 20
            Case 3
                pMaxEnemyCount = 20
            Case 4
                pMaxEnemyCount = 30
                Form1.SpawnTimer.Interval = 1200
            Case 5
                Form1.SpawnTimer.Interval = 1000
                pMaxEnemyCount = 1
            Case 6
                pMaxEnemyCount = 10
            Case 7
                pMaxEnemyCount = 11
                Form1.EnemyAttackTimer.Enabled = True
            Case 8
                pMaxEnemyCount = 5
            Case 9
                Form1.SpawnTimer.Interval = 1200
                pMaxEnemyCount = 24
            Case 10
                pMaxEnemyCount = 32
            Case 11
                pMaxEnemyCount = 5
        End Select
        Form1.alProjectile.Clear()
        Form1.DropUpgrade()
    End Sub

    Public Sub spawnEnemies()
        If Not Form1.spawnedEnemyCounter >= pMaxEnemyCount Then
            Select Case pRoundNumber
                Case 1
                    Form1.MakeEnemy(Form1.enemyTypes.basic, 2)
                Case 2
                    Form1.MakeEnemy(Form1.enemyTypes.strong, 1)
                Case 3
                    If Form1.spawnedEnemyCounter >= pMaxEnemyCount / 2 Then
                        Form1.MakeEnemy(Form1.enemyTypes.strong, 1)
                    Else
                        Form1.MakeEnemy(Form1.enemyTypes.basic, 1)
                    End If
                Case 4
                    Form1.MakeEnemy(Form1.enemyTypes.strong, 1)
                    Form1.MakeEnemy(Form1.enemyTypes.basic, 1)

                Case 5
                    Form1.MakeEnemy(Form1.enemyTypes.mothership, 1)
                    Form1.EnemyAttackTimer.Enabled = True
                Case 6
                    Form1.MakeEnemy(Form1.enemyTypes.shooter, 1)
                Case 7
                    If Form1.spawnedEnemyCounter >= 1 Then
                        Form1.MakeEnemy(Form1.enemyTypes.shooter, 1)
                    Else
                        Form1.MakeEnemy(Form1.enemyTypes.mothership, 1)
                    End If
                Case 8
                    Form1.MakeEnemy(Form1.enemyTypes.Kamikaze, 1)
                Case 9
                    Select Case Form1.spawnedEnemyCounter
                        Case 0 To 9 REM basic x9
                            Form1.MakeEnemy(Form1.enemyTypes.basic, 3)
                        Case 10 To 16 REM kamikaze x7
                            Form1.MakeEnemy(Form1.enemyTypes.kamikaze, 1)
                        Case (17 + Form1.numberOfMothershipSpawns) To (18 + Form1.numberOfMothershipSpawns) REM mothership x2
                            Form1.MakeEnemy(Form1.enemyTypes.mothership, 1)
                        Case (19 + Form1.numberOfMothershipSpawns) To (24 + Form1.numberOfMothershipSpawns) REM shooter x6
                            Form1.MakeEnemy(Form1.enemyTypes.shooter, 1)
                    End Select
                Case 10
                    Select Case Form1.spawnedEnemyCounter
                        Case (0 + Form1.numberOfMothershipSpawns) To (1 + Form1.numberOfMothershipSpawns) REM mothership x3
                            Form1.MakeEnemy(Form1.enemyTypes.mothership, 3)
                        Case (2 + Form1.numberOfMothershipSpawns) To (16 + Form1.numberOfMothershipSpawns) REM shooter x5 + strong x10
                            Form1.MakeEnemy(Form1.enemyTypes.shooter, 1)
                            Form1.MakeEnemy(Form1.enemyTypes.strong, 1)
                        Case (17 + Form1.numberOfMothershipSpawns) To (26 + Form1.numberOfMothershipSpawns) REM kamikaze x10
                            Form1.MakeEnemy(Form1.enemyTypes.mothership, 2)
                        Case (27 + Form1.numberOfMothershipSpawns) To (32 + Form1.numberOfMothershipSpawns) REM shooter x6
                            Form1.MakeEnemy(Form1.enemyTypes.shooter, 1)
                    End Select
            End Select
        End If
    End Sub

End Class
