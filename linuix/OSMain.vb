Public Class OSMain
    Dim WallpaperFile As String
    Private Sub OSMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ApplySettings()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Launcher_LinuixSettings.Click
        LinuixSettings.ShowDialog()
        If LinuixSettings.DialogResult = Windows.Forms.DialogResult.OK Then
            Me.ApplySettings()
        End If
    End Sub
    Public Function ApplySettings()
        ' APPLY BackgroundColour 4U
        Launcher_LinuixSettings.BackColor = My.Settings.BackgroundColour
        DesktopClock.BackColor = My.Settings.BackgroundColour
        Button2.BackColor = My.Settings.BackgroundColour
        Launcher_VirusSheild.BackColor = My.Settings.BackgroundColour
        Launcher_Interwebs.BackColor = My.Settings.BackgroundColour
        ' APPLY Wallpepper 4U
        If My.Settings.Wallpaper = "metro" Then
            Me.BackgroundImage = My.Resources.metro
        ElseIf My.Settings.Wallpaper = "Sandstone" Then
            Me.BackgroundImage = My.Resources.Sandstone
        End If
        ' APPLY Background Image Size Mode 4U
        If My.Settings.BackgroundColourSizeMode = "None" Then
            Me.BackgroundImageLayout = ImageLayout.None
        ElseIf My.Settings.BackgroundColourSizeMode = "Tile" Then
            Me.BackgroundImageLayout = ImageLayout.Tile
        ElseIf My.Settings.BackgroundColourSizeMode = "Center" Then
            Me.BackgroundImageLayout = ImageLayout.Center
        ElseIf My.Settings.BackgroundColourSizeMode = "Stretch" Then
            Me.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf My.Settings.BackgroundColourSizeMode = "Zoom" Then
            Me.BackgroundImageLayout = ImageLayout.Zoom
        End If
        ' Apply ICON Text Size Colour Choice 4U
        If My.Settings.WhiteBGIconText Then
            Launcher_LinuixSettings.ForeColor = Color.White
            Launcher_Interwebs.ForeColor = Color.White
            Launcher_VirusSheild.ForeColor = Color.White
            DesktopClock.ForeColor = Color.White
        Else
            Launcher_LinuixSettings.ForeColor = Color.Black
            Launcher_Interwebs.ForeColor = Color.Black
            Launcher_VirusSheild.ForeColor = Color.Black
            DesktopClock.ForeColor = Color.Black
        End If
    End Function

    Private Sub UpdateTime_Tick(sender As System.Object, e As System.EventArgs) Handles UpdateTime.Tick
        DesktopClock.Text = DateTime.Now
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Application.Exit()
        End
    End Sub

    Private Sub DesktopClock_Click(sender As System.Object, e As System.EventArgs) Handles DesktopClock.Click

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Launcher_VirusSheild.Click
        VirusSheild.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Launcher_Interwebs.Click
        interwebs.ShowDialog()
    End Sub
End Class