Public Class RouletteConfig
    Dim SetBullet As Integer
    Dim GameTurn As Integer

    Public Score As Integer
    Public Lives As Integer
    Public Blocks As Integer



    Public Function BulletPosition()

        Dim Num1 As New Random
        Dim Random1 As Integer



        Random1 = Num1.Next(1, 7)


        Return Random1


    End Function


    'Public Function PlayerTurn()


    '    Dim Num1 As New Random
    '    Dim Random1 As Integer
    '    Random1 = Num1.Next(1, 7)

    '    Return Random1

    'End Function


End Class
