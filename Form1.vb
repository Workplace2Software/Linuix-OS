

Public Class Form1
    Dim loadprogrss As Integer = 0

    Private Sub ProgressBar1_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar1.Click

    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If Not loadprogrss = 100 Then
            loadprogrss += 1
            ProgressBar1.Value = loadprogrss
        Else
            Timer1.Enabled = False
            Me.Hide()
            OSMain.show()
        End If
    End Sub
    ' oagk etp[nmjg wtnj a bpxg g-p[ve
    ' imagine typing with a boxing glove

    Private Sub Form1_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        My.Computer.Audio.Play(My.Resources.boot, AudioPlayMode.Background)
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class