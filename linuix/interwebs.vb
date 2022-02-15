Imports System.Windows.Forms

Public Class interwebs

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WebBrowser1.Refresh()
    End Sub



    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click, Button1.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub interwebs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
