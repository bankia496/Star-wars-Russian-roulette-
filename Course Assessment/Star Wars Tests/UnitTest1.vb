Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1
    Dim rndNumber As New Random()
    Dim randomNumber As Integer
    Dim intwins, intloses As Integer
    Dim IsEvadingAtEnd As Boolean = True

    Private Property BtnForceEvade As Object

    Private Property BtnBattle As Object

    Private Property Dialogform As Object

    Private Property Controls As Object

    <TestMethod()> Public Sub TestMethod1()
    End Sub
    Private Sub Btnactivatelightsaber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '------Activate Lightsaber Crystals (Load Bullets)------ 
        BtnForceEvade.Enabled = True
        BtnBattle.Enabled = True

    End Sub
    Private Sub BtnSpinCrystal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '------Spin Light Saber Crystal Button(Spin Chamber)-----

        randomNumber = rndNumber.Next(2, 7)
    End Sub


    Private Sub BtnForceEvade_Click(sender As Object, e As EventArgs) 
        '---------Force Evade button (2 second chances button)-------

        Static inteevade As Integer = 0

        inteevade += 1

        If inteevade = 2 Then
            '  ISEvading = true

            BtnForceEvade.Enabled = False
        End If

        If BtnForceEvade.Enabled Then
            randomNumber -= 1
        End If

    End Sub
    Private Sub BtnTryAgain_Click(sender As Object, e As EventArgs)
        Controls.Clear()
        InitializeComponent()

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnHelp_Click(sender As Object, e As EventArgs) 
        Dialogform.Show()
    End Sub




    Private Sub Close()
        Throw New NotImplementedException
    End Sub

    Private Sub InitializeComponent()
        Throw New NotImplementedException
    End Sub

End Class
