Imports System.Windows.Forms

Public Class LinuixSettings

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        My.Settings.BackgroundColour = BackgroundColor_choice.Color
        If ListBox1.SelectedItem = "metro" Then
            My.Settings.Wallpaper = "metro"
        End If
        If ListBox1.SelectedItem = "Sandstone" Then
            My.Settings.Wallpaper = "Sandstone"
        End If
        If CheckBox1.Checked Then
            My.Settings.WhiteBGIconText = True
        Else
            My.Settings.WhiteBGIconText = False
        End If
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        BackgroundColor_choice.ShowDialog()
    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As System.EventArgs) Handles ComboBox1.TextChanged
        If ComboBox1.Text = "None" Or ComboBox1.Text = "Tile" Or ComboBox1.Text = "Center" Or ComboBox1.Text = "Stretch" Or ComboBox1.Text = "Zoom" Then
            My.Settings.BackgroundColourSizeMode = ComboBox1.Text
        Else
            MessageBox.Show("What F**K Who do you think i am ??  ", "Invalid Background Image Size Mode..")
            ComboBox1.Text = My.Settings.BackgroundColourSizeMode
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        MessageBox.Show("To shutdown the system please press the power button on the desktop", "sorry that feature was removed")

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown, CloseButton.MouseDown
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

    Private Sub CloseButton_Click(sender As System.Object, e As System.EventArgs) Handles CloseButton.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub LinuixSettings_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        BackgroundColor_choice.Color = My.Settings.BackgroundColour
        If My.Settings.WhiteBGIconText Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
        ComboBox1.Text = My.Settings.BackgroundColourSizeMode
    End Sub

End Class
