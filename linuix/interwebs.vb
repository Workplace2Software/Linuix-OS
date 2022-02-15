Imports System.Windows.Forms

Public Class interwebs

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)
        WebBrowser1.GoForward()
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As System.EventArgs) Handles TextBox1.Enter
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub
End Class
