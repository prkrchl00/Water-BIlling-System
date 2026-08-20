<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        btnLogin = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        btnLogin.Font = New Font("Lucida Sans Typewriter", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), Image)
        btnLogin.ImageAlign = ContentAlignment.MiddleRight
        btnLogin.Location = New Point(1028, 726)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(145, 51)
        btnLogin.TabIndex = 0
        btnLogin.Text = "LOG IN"
        btnLogin.TextAlign = ContentAlignment.MiddleLeft
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Lucida Sans Typewriter", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Label1.Image = CType(resources.GetObject("Label1.Image"), Image)
        Label1.Location = New Point(817, 484)
        Label1.Name = "Label1"
        Label1.Size = New Size(138, 26)
        Label1.TabIndex = 1
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Lucida Sans Typewriter", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Label2.Image = CType(resources.GetObject("Label2.Image"), Image)
        Label2.Location = New Point(817, 615)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 26)
        Label2.TabIndex = 2
        Label2.Text = "Password:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Lucida Sans Unicode", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(817, 513)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(569, 49)
        txtUsername.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Lucida Sans Unicode", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(817, 644)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(569, 49)
        txtPassword.TabIndex = 4
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1902, 1033)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnLogin)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
End Class
