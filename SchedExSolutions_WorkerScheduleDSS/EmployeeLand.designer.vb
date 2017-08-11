<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeLand
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeLand))
        Me.btnEmSched = New System.Windows.Forms.Button()
        Me.btnTimeOff = New System.Windows.Forms.Button()
        Me.lblWelcomeEm = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEmSched
        '
        Me.btnEmSched.BackColor = System.Drawing.Color.Black
        Me.btnEmSched.BackgroundImage = CType(resources.GetObject("btnEmSched.BackgroundImage"), System.Drawing.Image)
        Me.btnEmSched.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEmSched.Location = New System.Drawing.Point(10, 82)
        Me.btnEmSched.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEmSched.Name = "btnEmSched"
        Me.btnEmSched.Size = New System.Drawing.Size(245, 55)
        Me.btnEmSched.TabIndex = 0
        Me.btnEmSched.UseVisualStyleBackColor = False
        '
        'btnTimeOff
        '
        Me.btnTimeOff.BackColor = System.Drawing.Color.Black
        Me.btnTimeOff.BackgroundImage = CType(resources.GetObject("btnTimeOff.BackgroundImage"), System.Drawing.Image)
        Me.btnTimeOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTimeOff.Location = New System.Drawing.Point(305, 82)
        Me.btnTimeOff.Margin = New System.Windows.Forms.Padding(1)
        Me.btnTimeOff.Name = "btnTimeOff"
        Me.btnTimeOff.Size = New System.Drawing.Size(245, 55)
        Me.btnTimeOff.TabIndex = 1
        Me.btnTimeOff.UseVisualStyleBackColor = False
        '
        'lblWelcomeEm
        '
        Me.lblWelcomeEm.AutoSize = True
        Me.lblWelcomeEm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeEm.Location = New System.Drawing.Point(187, 32)
        Me.lblWelcomeEm.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblWelcomeEm.Name = "lblWelcomeEm"
        Me.lblWelcomeEm.Size = New System.Drawing.Size(182, 24)
        Me.lblWelcomeEm.TabIndex = 2
        Me.lblWelcomeEm.Text = "Welcome Employee"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(157, 168)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(246, 211)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.Location = New System.Drawing.Point(486, 406)
        Me.Button1.Margin = New System.Windows.Forms.Padding(1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 26)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'EmployeeLandingPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(560, 452)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblWelcomeEm)
        Me.Controls.Add(Me.btnTimeOff)
        Me.Controls.Add(Me.btnEmSched)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "EmployeeLandingPage"
        Me.Text = "Employee Landing Page"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEmSched As Button
    Friend WithEvents btnTimeOff As Button
    Friend WithEvents lblWelcomeEm As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
