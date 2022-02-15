Imports System.Windows.Forms

Public Class interwebs

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        WebBrowser1.Refresh()
    End Sub



    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub
End Class
