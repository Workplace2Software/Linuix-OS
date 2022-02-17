Imports System.Windows.Forms

Public Class VirusSheild

    Private Sub VirusSheild_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Timer1.Start()
        Label1.Visible = True
        PictureBox1.Visible() = True
        Label2.Visible = False
        Label3.Visible = False
        Button1.Visible = False
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Label1.Visible = False
        PictureBox1.Visible = False
        Label2.Visible = True
        Label3.Visible = True
        Button1.Visible = True
        My.Computer.Audio.Play(My.Resources.MalwareFound, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.crash, AudioPlayMode.Background)
        MessageBox.Show("Error Code: you-cant-delete-windows,-windows-delete-YOU", "Linuix has crashed")
        Application.Exit()
        End
    End Sub

    Private Sub Panel1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown, CloseButton.MouseDown
        If e.Button = MouseButtons.Left Then
            Me.Panel1.Capture = False
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            Const HTCAPTION As Integer = 2
            Dim msg As Message = _
                Message.Create(Me.Handle, WM_NCLBUTTONDOWN, _
                               New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
        End If
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        My.Computer.Audio.Stop()
        Me.Close()
    End Sub
End Class
