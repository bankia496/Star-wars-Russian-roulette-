Public Class Gameplay


    Public randomNumber As Integer
    Public intwins, intloses As Integer
    Public Shared inteevade As Integer = 0
    Public Sub RandomNumberGenerator()

        Dim rndNumber As New Random()
        randomNumber = rndNumber.Next(2, 7)
    End Sub

End Class
