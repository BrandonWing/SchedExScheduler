<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcomePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWelcomePage))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEmployeeLogin = New System.Windows.Forms.Button()
        Me.btnManagerLogin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(398, 82)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WELCOME"
        '
        'btnEmployeeLogin
        '
        Me.btnEmployeeLogin.BackColor = System.Drawing.Color.Black
        Me.btnEmployeeLogin.BackgroundImage = CType(resources.GetObject("btnEmployeeLogin.BackgroundImage"), System.Drawing.Image)
        Me.btnEmployeeLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEmployeeLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployeeLogin.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnEmployeeLogin.Location = New System.Drawing.Point(47, 327)
        Me.btnEmployeeLogin.Name = "btnEmployeeLogin"
        Me.btnEmployeeLogin.Size = New System.Drawing.Size(156, 55)
        Me.btnEmployeeLogin.TabIndex = 2
        Me.btnEmployeeLogin.UseVisualStyleBackColor = False
        '
        'btnManagerLogin
        '
        Me.btnManagerLogin.BackColor = System.Drawing.Color.Black
        Me.btnManagerLogin.BackgroundImage = CType(resources.GetObject("btnManagerLogin.BackgroundImage"), System.Drawing.Image)
        Me.btnManagerLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnManagerLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManagerLogin.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnManagerLogin.Location = New System.Drawing.Point(254, 327)
        Me.btnManagerLogin.Name = "btnManagerLogin"
        Me.btnManagerLogin.Size = New System.Drawing.Size(156, 55)
        Me.btnManagerLogin.TabIndex = 3
        Me.btnManagerLogin.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(78, 72)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 283)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SlateGray
        Me.Button1.Location = New System.Drawing.Point(383, 388)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 26)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightBlue
        Me.Button2.Location = New System.Drawing.Point(12, 388)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 26)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Help"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmWelcomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(468, 415)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnManagerLogin)
        Me.Controls.Add(Me.btnEmployeeLogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmWelcomePage"
        Me.Text = "Welcome Page"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEmployeeLogin As Button
    Friend WithEvents btnManagerLogin As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
