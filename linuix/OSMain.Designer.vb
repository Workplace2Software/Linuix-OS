<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OSMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OSMain))
        Me.Launcher_LinuixSettings = New System.Windows.Forms.Button()
        Me.DesktopClock = New System.Windows.Forms.Label()
        Me.UpdateTime = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Launcher_VirusSheild = New System.Windows.Forms.Button()
        Me.Launcher_Interwebs = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Launcher_LinuixSettings
        '
        Me.Launcher_LinuixSettings.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Launcher_LinuixSettings.FlatAppearance.BorderSize = 0
        Me.Launcher_LinuixSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Launcher_LinuixSettings.Image = Global.WindowsApplication1.My.Resources.Resources.Setting
        Me.Launcher_LinuixSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Launcher_LinuixSettings.Location = New System.Drawing.Point(12, 13)
        Me.Launcher_LinuixSettings.Name = "Launcher_LinuixSettings"
        Me.Launcher_LinuixSettings.Size = New System.Drawing.Size(70, 96)
        Me.Launcher_LinuixSettings.TabIndex = 0
        Me.Launcher_LinuixSettings.Text = "Linuix Settings"
        Me.Launcher_LinuixSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Launcher_LinuixSettings.UseVisualStyleBackColor = False
        '
        'DesktopClock
        '
        Me.DesktopClock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DesktopClock.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DesktopClock.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesktopClock.Location = New System.Drawing.Point(606, 13)
        Me.DesktopClock.Name = "DesktopClock"
        Me.DesktopClock.Size = New System.Drawing.Size(182, 80)
        Me.DesktopClock.TabIndex = 1
        Me.DesktopClock.Text = "15/2/2022" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:39"
        Me.DesktopClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UpdateTime
        '
        Me.UpdateTime.Enabled = True
        Me.UpdateTime.Interval = 1000
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.WindowsApplication1.My.Resources.Resources.POWER
        Me.Button2.Location = New System.Drawing.Point(12, 518)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 70)
        Me.Button2.TabIndex = 2
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Launcher_VirusSheild
        '
        Me.Launcher_VirusSheild.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Launcher_VirusSheild.FlatAppearance.BorderSize = 0
        Me.Launcher_VirusSheild.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Launcher_VirusSheild.Image = Global.WindowsApplication1.My.Resources.Resources.Virus_Sheild1
        Me.Launcher_VirusSheild.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Launcher_VirusSheild.Location = New System.Drawing.Point(88, 12)
        Me.Launcher_VirusSheild.Name = "Launcher_VirusSheild"
        Me.Launcher_VirusSheild.Size = New System.Drawing.Size(70, 96)
        Me.Launcher_VirusSheild.TabIndex = 3
        Me.Launcher_VirusSheild.Text = "Virus-Sheild 2009"
        Me.Launcher_VirusSheild.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Launcher_VirusSheild.UseVisualStyleBackColor = False
        '
        'Launcher_Interwebs
        '
        Me.Launcher_Interwebs.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Launcher_Interwebs.FlatAppearance.BorderSize = 0
        Me.Launcher_Interwebs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Launcher_Interwebs.Image = Global.WindowsApplication1.My.Resources.Resources.interwebs
        Me.Launcher_Interwebs.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Launcher_Interwebs.Location = New System.Drawing.Point(164, 12)
        Me.Launcher_Interwebs.Name = "Launcher_Interwebs"
        Me.Launcher_Interwebs.Size = New System.Drawing.Size(70, 96)
        Me.Launcher_Interwebs.TabIndex = 4
        Me.Launcher_Interwebs.Text = "Interwebs Looker"
        Me.Launcher_Interwebs.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Launcher_Interwebs.UseVisualStyleBackColor = False
        '
        'OSMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.metro
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Launcher_Interwebs)
        Me.Controls.Add(Me.Launcher_VirusSheild)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DesktopClock)
        Me.Controls.Add(Me.Launcher_LinuixSettings)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OSMain"
        Me.Text = "Linuix OS v0.0.11"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Launcher_LinuixSettings As System.Windows.Forms.Button
    Friend WithEvents DesktopClock As System.Windows.Forms.Label
    Friend WithEvents UpdateTime As System.Windows.Forms.Timer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Launcher_VirusSheild As System.Windows.Forms.Button
    Friend WithEvents Launcher_Interwebs As System.Windows.Forms.Button
End Class
