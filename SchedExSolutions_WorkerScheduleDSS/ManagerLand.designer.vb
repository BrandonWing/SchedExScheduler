<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerLand
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManagerLand))
        Me.lblWelcomeMan = New System.Windows.Forms.Label()
        Me.btnManSched = New System.Windows.Forms.Button()
        Me.btnSetSched = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcomeMan
        '
        Me.lblWelcomeMan.AutoSize = True
        Me.lblWelcomeMan.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeMan.Location = New System.Drawing.Point(133, 32)
        Me.lblWelcomeMan.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblWelcomeMan.Name = "lblWelcomeMan"
        Me.lblWelcomeMan.Size = New System.Drawing.Size(171, 24)
        Me.lblWelcomeMan.TabIndex = 0
        Me.lblWelcomeMan.Text = "Welcome Manager"
        '
        'btnManSched
        '
        Me.btnManSched.BackColor = System.Drawing.Color.Black
        Me.btnManSched.BackgroundImage = CType(resources.GetObject("btnManSched.BackgroundImage"), System.Drawing.Image)
        Me.btnManSched.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnManSched.Location = New System.Drawing.Point(10, 86)
        Me.btnManSched.Margin = New System.Windows.Forms.Padding(1)
        Me.btnManSched.Name = "btnManSched"
        Me.btnManSched.Size = New System.Drawing.Size(220, 55)
        Me.btnManSched.TabIndex = 1
        Me.btnManSched.UseVisualStyleBackColor = False
        '
        'btnSetSched
        '
        Me.btnSetSched.BackColor = System.Drawing.Color.Black
        Me.btnSetSched.BackgroundImage = CType(resources.GetObject("btnSetSched.BackgroundImage"), System.Drawing.Image)
        Me.btnSetSched.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSetSched.Location = New System.Drawing.Point(232, 86)
        Me.btnSetSched.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSetSched.Name = "btnSetSched"
        Me.btnSetSched.Size = New System.Drawing.Size(210, 55)
        Me.btnSetSched.TabIndex = 2
        Me.btnSetSched.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(37, 169)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(380, 201)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.Location = New System.Drawing.Point(378, 359)
        Me.Button1.Margin = New System.Windows.Forms.Padding(1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 26)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ManagerLandingPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(452, 386)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSetSched)
        Me.Controls.Add(Me.btnManSched)
        Me.Controls.Add(Me.lblWelcomeMan)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "ManagerLandingPage"
        Me.Text = "Manager Landing Page"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcomeMan As Label
    Friend WithEvents btnManSched As Button
    Friend WithEvents btnSetSched As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
