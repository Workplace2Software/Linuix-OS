Imports System.Windows.Forms

Public Class VirusSheild

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub VirusSheild_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Label1.Visible = True
        PictureBox1.Visible() = True
        Label2.Visible = False
        Label3.Visible = False
        Button1.Visible = False



    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label1.Visible = False
        PictureBox1.Visible = False
        Label2.Visible = True
        Label3.Visible = True
        Label3.Text = "Windows Operating system - LinuixVM.Host"
        Button1.Visible = True


    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.crash, AudioPlayMode.Background)
        MessageBox.Show("Error Code: you-cant-delete-windows,-windows-delete-YOU", "Linuix has crashed")
        Application.Exit()

    End Sub
End Class
