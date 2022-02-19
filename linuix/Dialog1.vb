Imports System.Windows.Forms

Public Class apps

    Private Sub apps_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(Button1, "DT Assistant 1.0")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        OSMain.PictureBox1.Visible = True
    End Sub
End Class
