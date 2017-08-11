<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManagerLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManagerLogin))
        Me.btnManagerSubmit = New System.Windows.Forms.Button()
        Me.txtManagerUsername = New System.Windows.Forms.TextBox()
        Me.txtManagerPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnManagerSubmit
        '
        Me.btnManagerSubmit.BackColor = System.Drawing.Color.SkyBlue
        Me.btnManagerSubmit.BackgroundImage = CType(resources.GetObject("btnManagerSubmit.BackgroundImage"), System.Drawing.Image)
        Me.btnManagerSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnManagerSubmit.Location = New System.Drawing.Point(148, 195)
        Me.btnManagerSubmit.Name = "btnManagerSubmit"
        Me.btnManagerSubmit.Size = New System.Drawing.Size(124, 35)
        Me.btnManagerSubmit.TabIndex = 3
        Me.btnManagerSubmit.UseVisualStyleBackColor = False
        '
        'txtManagerUsername
        '
        Me.txtManagerUsername.Location = New System.Drawing.Point(136, 80)
        Me.txtManagerUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtManagerUsername.Name = "txtManagerUsername"
        Me.txtManagerUsername.Size = New System.Drawing.Size(151, 20)
        Me.txtManagerUsername.TabIndex = 1
        '
        'txtManagerPassword
        '
        Me.txtManagerPassword.Location = New System.Drawing.Point(136, 150)
        Me.txtManagerPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtManagerPassword.Name = "txtManagerPassword"
        Me.txtManagerPassword.Size = New System.Drawing.Size(152, 20)
        Me.txtManagerPassword.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 134)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Password"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(148, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 33)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(320, 223)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(211, 175)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'frmManagerLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(482, 379)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtManagerPassword)
        Me.Controls.Add(Me.txtManagerUsername)
        Me.Controls.Add(Me.btnManagerSubmit)
        Me.Name = "frmManagerLogin"
        Me.Text = "Manager Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnManagerSubmit As Button
    Friend WithEvents txtManagerUsername As TextBox
    Friend WithEvents txtManagerPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
