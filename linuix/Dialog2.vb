Imports System.Windows.Forms

Public Class DT


    Private Sub OK_Button_Click(sender As System.Object, e As System.EventArgs) Handles OK_Button.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Hello to you to!", "DT's Responce:")
        ElseIf TextBox1.Text = "Where to buy a pet russian dolphin?" Then
            MessageBox.Show("Frankly i beleve that is a stupid question and i want to know why it was asked.", "DT's Responce")
        End If
    End Sub
End Class
