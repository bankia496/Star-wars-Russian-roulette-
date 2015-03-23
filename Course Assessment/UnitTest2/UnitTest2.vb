Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest2
    Public randomNumber As Integer
    Public intwins, intloses As Integer
    Public Shared inteevade As Integer = 0
    <TestMethod()> Public Sub TestMethod1()


    End Sub
    Public Sub RandomNumberGenerator()

        Dim rndNumber As New Random()
        randomNumber = rndNumber.Next(2, 7)
    End Sub


End Class