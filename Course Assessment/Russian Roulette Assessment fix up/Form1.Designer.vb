<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnBattle = New System.Windows.Forms.Button()
        Me.BtnForceEvade = New System.Windows.Forms.Button()
        Me.BtnTryAgain = New System.Windows.Forms.Button()
        Me.BtnSpinCrystal = New System.Windows.Forms.Button()
        Me.Btnactivatelightsaber = New System.Windows.Forms.Button()
        Me.PbHumanChoice = New System.Windows.Forms.PictureBox()
        Me.PbBattlePic = New System.Windows.Forms.PictureBox()
        Me.PbComputerguesspic = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LbllosesCounter = New System.Windows.Forms.Label()
        Me.LblWinsCounter = New System.Windows.Forms.Label()
        Me.lblLoses = New System.Windows.Forms.Label()
        Me.LblWins = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnHelp = New System.Windows.Forms.Button()
        CType(Me.PbHumanChoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbBattlePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbComputerguesspic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnBattle
        '
        Me.BtnBattle.BackgroundImage = Global.Russian_Roulette_Assessment_fix_up.My.Resources.Pictures_sound.how_to_draw_a_lightsaber_1_000000001266_5
        Me.BtnBattle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBattle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBattle.ForeColor = System.Drawing.Color.Blue
        Me.BtnBattle.Location = New System.Drawing.Point(540, 635)
        Me.BtnBattle.Name = "BtnBattle"
        Me.BtnBattle.Size = New System.Drawing.Size(193, 58)
        Me.BtnBattle.TabIndex = 0
        Me.BtnBattle.Text = "Battle"
        Me.BtnBattle.UseVisualStyleBackColor = True
        '
        'BtnForceEvade
        '
        Me.BtnForceEvade.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnForceEvade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnForceEvade.Location = New System.Drawing.Point(77, 635)
        Me.BtnForceEvade.Name = "BtnForceEvade"
        Me.BtnForceEvade.Size = New System.Drawing.Size(189, 57)
        Me.BtnForceEvade.TabIndex = 1
        Me.BtnForceEvade.Text = "Quick Force Evade"
        Me.BtnForceEvade.UseVisualStyleBackColor = False
        '
        'BtnTryAgain
        '
        Me.BtnTryAgain.BackColor = System.Drawing.Color.Red
        Me.BtnTryAgain.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTryAgain.ForeColor = System.Drawing.Color.Blue
        Me.BtnTryAgain.Location = New System.Drawing.Point(1045, 634)
        Me.BtnTryAgain.Name = "BtnTryAgain"
        Me.BtnTryAgain.Size = New System.Drawing.Size(193, 59)
        Me.BtnTryAgain.TabIndex = 2
        Me.BtnTryAgain.Text = "Try Again"
        Me.BtnTryAgain.UseVisualStyleBackColor = False
        '
        'BtnSpinCrystal
        '
        Me.BtnSpinCrystal.BackColor = System.Drawing.Color.Red
        Me.BtnSpinCrystal.BackgroundImage = Global.Russian_Roulette_Assessment_fix_up.My.Resources.Pictures_sound.LukeLightsaberConstruction
        Me.BtnSpinCrystal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSpinCrystal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSpinCrystal.ForeColor = System.Drawing.Color.Blue
        Me.BtnSpinCrystal.Location = New System.Drawing.Point(1045, 569)
        Me.BtnSpinCrystal.Name = "BtnSpinCrystal"
        Me.BtnSpinCrystal.Size = New System.Drawing.Size(193, 59)
        Me.BtnSpinCrystal.TabIndex = 3
        Me.BtnSpinCrystal.Text = "Spin Lightsaber Crystal"
        Me.BtnSpinCrystal.UseVisualStyleBackColor = False
        '
        'Btnactivatelightsaber
        '
        Me.Btnactivatelightsaber.BackgroundImage = Global.Russian_Roulette_Assessment_fix_up.My.Resources.Pictures_sound.Tyranus_lightsaber_l
        Me.Btnactivatelightsaber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnactivatelightsaber.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnactivatelightsaber.ForeColor = System.Drawing.Color.Blue
        Me.Btnactivatelightsaber.Location = New System.Drawing.Point(1045, 504)
        Me.Btnactivatelightsaber.Name = "Btnactivatelightsaber"
        Me.Btnactivatelightsaber.Size = New System.Drawing.Size(193, 59)
        Me.Btnactivatelightsaber.TabIndex = 4
        Me.Btnactivatelightsaber.Text = "Activate Saber Crystals"
        Me.Btnactivatelightsaber.UseVisualStyleBackColor = True
        '
        'PbHumanChoice
        '
        Me.PbHumanChoice.Location = New System.Drawing.Point(12, 122)
        Me.PbHumanChoice.Name = "PbHumanChoice"
        Me.PbHumanChoice.Size = New System.Drawing.Size(312, 373)
        Me.PbHumanChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbHumanChoice.TabIndex = 5
        Me.PbHumanChoice.TabStop = False
        '
        'PbBattlePic
        '
        Me.PbBattlePic.Location = New System.Drawing.Point(353, 122)
        Me.PbBattlePic.Name = "PbBattlePic"
        Me.PbBattlePic.Size = New System.Drawing.Size(567, 373)
        Me.PbBattlePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbBattlePic.TabIndex = 6
        Me.PbBattlePic.TabStop = False
        '
        'PbComputerguesspic
        '
        Me.PbComputerguesspic.Location = New System.Drawing.Point(954, 122)
        Me.PbComputerguesspic.Name = "PbComputerguesspic"
        Me.PbComputerguesspic.Size = New System.Drawing.Size(316, 373)
        Me.PbComputerguesspic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbComputerguesspic.TabIndex = 7
        Me.PbComputerguesspic.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Russian_Roulette_Assessment_fix_up.My.Resources.Pictures_sound._107611
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.LbllosesCounter)
        Me.Panel1.Controls.Add(Me.LblWinsCounter)
        Me.Panel1.Controls.Add(Me.lblLoses)
        Me.Panel1.Controls.Add(Me.LblWins)
        Me.Panel1.Location = New System.Drawing.Point(1069, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(228, 100)
        Me.Panel1.TabIndex = 8
        '
        'LbllosesCounter
        '
        Me.LbllosesCounter.AutoSize = True
        Me.LbllosesCounter.Location = New System.Drawing.Point(77, 42)
        Me.LbllosesCounter.Name = "LbllosesCounter"
        Me.LbllosesCounter.Size = New System.Drawing.Size(0, 13)
        Me.LbllosesCounter.TabIndex = 3
        '
        'LblWinsCounter
        '
        Me.LblWinsCounter.AutoSize = True
        Me.LblWinsCounter.Location = New System.Drawing.Point(74, 21)
        Me.LblWinsCounter.Name = "LblWinsCounter"
        Me.LblWinsCounter.Size = New System.Drawing.Size(0, 13)
        Me.LblWinsCounter.TabIndex = 2
        '
        'lblLoses
        '
        Me.lblLoses.AutoSize = True
        Me.lblLoses.Location = New System.Drawing.Point(15, 43)
        Me.lblLoses.Name = "lblLoses"
        Me.lblLoses.Size = New System.Drawing.Size(38, 13)
        Me.lblLoses.TabIndex = 1
        Me.lblLoses.Text = "Loses:"
        '
        'LblWins
        '
        Me.LblWins.AutoSize = True
        Me.LblWins.Location = New System.Drawing.Point(15, 21)
        Me.LblWins.Name = "LblWins"
        Me.LblWins.Size = New System.Drawing.Size(34, 13)
        Me.LblWins.TabIndex = 0
        Me.LblWins.Text = "Wins:"
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Red
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Black
        Me.BtnExit.Location = New System.Drawing.Point(12, 3)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(91, 51)
        Me.BtnExit.TabIndex = 9
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnHelp
        '
        Me.BtnHelp.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHelp.Location = New System.Drawing.Point(12, 60)
        Me.BtnHelp.Name = "BtnHelp"
        Me.BtnHelp.Size = New System.Drawing.Size(91, 53)
        Me.BtnHelp.TabIndex = 10
        Me.BtnHelp.Text = "Help"
        Me.BtnHelp.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Russian_Roulette_Assessment_fix_up.My.Resources.Pictures_sound.bg_tatooine_thumb
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1297, 704)
        Me.Controls.Add(Me.BtnHelp)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PbComputerguesspic)
        Me.Controls.Add(Me.PbBattlePic)
        Me.Controls.Add(Me.PbHumanChoice)
        Me.Controls.Add(Me.Btnactivatelightsaber)
        Me.Controls.Add(Me.BtnSpinCrystal)
        Me.Controls.Add(Me.BtnTryAgain)
        Me.Controls.Add(Me.BtnForceEvade)
        Me.Controls.Add(Me.BtnBattle)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Star Wars Russian Roulette"
        CType(Me.PbHumanChoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbBattlePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbComputerguesspic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnBattle As System.Windows.Forms.Button
    Friend WithEvents BtnForceEvade As System.Windows.Forms.Button
    Friend WithEvents BtnTryAgain As System.Windows.Forms.Button
    Friend WithEvents BtnSpinCrystal As System.Windows.Forms.Button
    Friend WithEvents Btnactivatelightsaber As System.Windows.Forms.Button
    Friend WithEvents PbHumanChoice As System.Windows.Forms.PictureBox
    Friend WithEvents PbBattlePic As System.Windows.Forms.PictureBox
    Friend WithEvents PbComputerguesspic As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LbllosesCounter As System.Windows.Forms.Label
    Friend WithEvents LblWinsCounter As System.Windows.Forms.Label
    Friend WithEvents lblLoses As System.Windows.Forms.Label
    Friend WithEvents LblWins As System.Windows.Forms.Label
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnHelp As System.Windows.Forms.Button

End Class
