Imports System.Diagnostics.PerformanceData

Public Class Form1
    Dim Dialogform As New HelpBox
    Dim mygameplay As New Gameplay

    Private Sub Btnactivatelightsaber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnactivatelightsaber.Click
        '------Activate Lightsaber Crystals (Load Bullets)------ 
        PbHumanChoice.Image = My.Resources.new_pictures.picture_box_left
        PbBattlePic.Image = My.Resources.new_pictures.Picture_box_middle
        PbComputerguesspic.Image = My.Resources.new_pictures.picture_box_right
        BtnForceEvade.Enabled = True
        BtnBattle.Enabled = True

        My.Computer.Audio.Play(My.Resources.Pictures_sound.Lightsaber_Turn_On_SoundBible_com_647586083, AudioPlayMode.Background)

    End Sub
    Private Sub BtnSpinCrystal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSpinCrystal.Click
        '------Spin Light Saber Crystal Button(Spin Chamber)-----

        mygameplay.RandomNumberGenerator()

        My.Computer.Audio.Play(My.Resources.Pictures_sound.Lightsaber_Turn_On_SoundBible_com_1637663395, AudioPlayMode.Background)
    End Sub
    Private Sub BtnBattle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBattle.Click
        '----------Starts battle (Fire Button)------

        mygameplay.randomNumber -= 1

        Select Case mygameplay.randomNumber
            Case 0 'win 
                PbBattlePic.Image = My.Resources.Pictures_sound.DookuVersusAnakin
                PbComputerguesspic.Image = My.Resources.Pictures_sound.Dooku_sEnd
                PbHumanChoice.Image = My.Resources.Pictures_sound.Anakin_tötet_Dooku
                mygameplay.intwins += 1
                My.Computer.Audio.Play(My.Resources.Pictures_sound.Lightsaber_Turn_Off_SoundBible_com_726724693, AudioPlayMode.Background)
                BtnForceEvade.Enabled = False
                BtnBattle.Enabled = False
            Case 1 'bullet 
                PbBattlePic.Image = My.Resources.Pictures_sound.Qui_Gon_s_death
                PbComputerguesspic.Image = My.Resources.Pictures_sound.Dooku_salute
                PbHumanChoice.Image = My.Resources.Pictures_sound.Galen_Marek_clone_killed
                BtnForceEvade.Enabled = False
                BtnBattle.Enabled = False
                My.Computer.Audio.Play(My.Resources.Pictures_sound.Lightsaber_Turn_Off_SoundBible_com_726724693, AudioPlayMode.Background)
                mygameplay.intloses += 1
            Case 2 'blank 
                PbBattlePic.Image = My.Resources.Pictures_sound._25026_star_wars_jedi_duel
                PbComputerguesspic.Image = My.Resources.Pictures_sound.Count_Dooku
                PbHumanChoice.Image = My.Resources.Pictures_sound.Windu_Angry
                My.Computer.Audio.Play(My.Resources.Pictures_sound.Lightsaber_Clash_SoundBible_com_203518049, AudioPlayMode.Background)
            Case 3 'blank
                PbBattlePic.Image = My.Resources.Pictures_sound._25026_star_wars_jedi_duel
                PbComputerguesspic.Image = My.Resources.Pictures_sound.Dooku_salute
                PbHumanChoice.Image = My.Resources.Pictures_sound.EpisodeII_ObiWan2
                My.Computer.Audio.Play(My.Resources.Pictures_sound.Lightsaber_Clash_SoundBible_com_203518049, AudioPlayMode.Background)
            Case 4 'blank
                PbBattlePic.Image = My.Resources.Pictures_sound._25026_star_wars_jedi_duel
                PbComputerguesspic.Image = My.Resources.Pictures_sound.Dooku_salute
                PbHumanChoice.Image = My.Resources.Pictures_sound.EpisodeII_ObiWan2
                My.Computer.Audio.Play(My.Resources.Pictures_sound.Lightsaber_Clash_SoundBible_com_203518049, AudioPlayMode.Background)
            Case 5 'blank
                PbBattlePic.Image = My.Resources.Pictures_sound.Kenobi_Maul_clash
                PbComputerguesspic.Image = My.Resources.Pictures_sound.Darth_Maul
                PbHumanChoice.Image = My.Resources.Pictures_sound.star_wars_picture_1
                My.Computer.Audio.Play(My.Resources.Pictures_sound.Lightsaber_Clash_SoundBible_com_203518049, AudioPlayMode.Background)
            Case 6 'blank
                PbBattlePic.Image = My.Resources.Pictures_sound._25026_star_wars_jedi_duel
                PbComputerguesspic.Image = My.Resources.Pictures_sound.Count_Dooku
                PbHumanChoice.Image = My.Resources.Pictures_sound.Obiwan_Soresu
                My.Computer.Audio.Play(My.Resources.Pictures_sound.Lightsaber_Clash_SoundBible_com_203518049, AudioPlayMode.Background)
        End Select

        LblWinsCounter.Text = mygameplay.intwins & vbCrLf
        LbllosesCounter.Text = mygameplay.intloses & vbCrLf



    End Sub

    Private Sub BtnForceEvade_Click(sender As Object, e As EventArgs) Handles BtnForceEvade.Click
        '---------Force Evade button (2 second chances button)-------



        Gameplay.inteevade += 1


        If Gameplay.inteevade = 3 Then

            BtnForceEvade.Enabled = False
        End If

        If BtnForceEvade.Enabled Then
            mygameplay.randomNumber -= 1
            PbBattlePic.Image = My.Resources.Pictures_sound.Star_Wars_Lightsaber_Workout_for_Weight_Loss_2
            PbComputerguesspic.Image = My.Resources.Pictures_sound.Darth_Maul
            PbHumanChoice.Image = My.Resources.Pictures_sound.images
            My.Computer.Audio.Play(My.Resources.Pictures_sound.Lightsaber_Turn_On_SoundBible_com_1637663395, AudioPlayMode.Background)
        End If

    End Sub

    Private Sub BtnTryAgain_Click(sender As Object, e As EventArgs) Handles BtnTryAgain.Click
        Controls.Clear()
        InitializeComponent()

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnHelp_Click(sender As Object, e As EventArgs) Handles BtnHelp.Click
        Dialogform.Show()
    End Sub
End Class
