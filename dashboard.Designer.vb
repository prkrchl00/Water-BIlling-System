<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Timer1 = New Timer(components)
        totalcustomer = New Label()
        PictureBox1 = New PictureBox()
        PictureBox6 = New PictureBox()
        Label2 = New Label()
        lblTime = New Label()
        lblDate = New Label()
        Button5 = New Button()
        Button6 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        lblActiveCount = New Label()
        lblInactiveCount = New Label()
        lblTotalCollected = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' totalcustomer
        ' 
        totalcustomer.AutoSize = True
        totalcustomer.BackColor = Color.FromArgb(CByte(163), CByte(225), CByte(246))
        totalcustomer.Font = New Font("Lucida Sans Unicode", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        totalcustomer.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        totalcustomer.Location = New Point(559, 569)
        totalcustomer.Name = "totalcustomer"
        totalcustomer.Size = New Size(71, 73)
        totalcustomer.TabIndex = 0
        totalcustomer.Text = "0"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(292, 450)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(425, 248)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Location = New Point(1715, 221)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(0, 0)
        PictureBox6.TabIndex = 6
        PictureBox6.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(210), CByte(245), CByte(255))
        Label2.Font = New Font("Lucida Sans Typewriter", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkBlue
        Label2.Location = New Point(620, 243)
        Label2.Name = "Label2"
        Label2.Size = New Size(705, 136)
        Label2.TabIndex = 16
        Label2.Text = "DASHBOARD"
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.BackColor = Color.FromArgb(CByte(210), CByte(245), CByte(255))
        lblTime.Font = New Font("Lucida Sans Unicode", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTime.ForeColor = Color.SteelBlue
        lblTime.Location = New Point(685, 752)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(71, 73)
        lblTime.TabIndex = 17
        lblTime.Text = "0"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.BackColor = Color.FromArgb(CByte(210), CByte(245), CByte(255))
        lblDate.Font = New Font("Lucida Sans Unicode", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDate.ForeColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        lblDate.Location = New Point(685, 861)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(52, 54)
        lblDate.TabIndex = 18
        lblDate.Text = "0"
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        Button5.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Button5.Image = CType(resources.GetObject("Button5.Image"), Image)
        Button5.ImageAlign = ContentAlignment.MiddleRight
        Button5.Location = New Point(1679, 44)
        Button5.Name = "Button5"
        Button5.Size = New Size(163, 62)
        Button5.TabIndex = 14
        Button5.Text = "LOG OUT"
        Button5.TextAlign = ContentAlignment.MiddleLeft
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        Button6.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Button6.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Button6.Location = New Point(1508, 44)
        Button6.Name = "Button6"
        Button6.Size = New Size(138, 64)
        Button6.TabIndex = 19
        Button6.Text = "REPORT"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        Button4.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Button4.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Button4.Location = New Point(1331, 44)
        Button4.Name = "Button4"
        Button4.Size = New Size(138, 64)
        Button4.TabIndex = 13
        Button4.Text = "BILLING"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        Button3.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Button3.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Button3.Location = New Point(1131, 44)
        Button3.Name = "Button3"
        Button3.Size = New Size(157, 64)
        Button3.TabIndex = 12
        Button3.Text = "WATER PRICE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        Button2.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Button2.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Button2.Location = New Point(949, 44)
        Button2.Name = "Button2"
        Button2.Size = New Size(138, 64)
        Button2.TabIndex = 11
        Button2.Text = "CONSUMER"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        Button1.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Button1.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Button1.Location = New Point(773, 44)
        Button1.Name = "Button1"
        Button1.Size = New Size(138, 64)
        Button1.TabIndex = 10
        Button1.Text = "DASHBOARD"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' lblActiveCount
        ' 
        lblActiveCount.AutoSize = True
        lblActiveCount.BackColor = Color.FromArgb(CByte(176), CByte(234), CByte(253))
        lblActiveCount.Font = New Font("Lucida Sans Unicode", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblActiveCount.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        lblActiveCount.Location = New Point(1089, 544)
        lblActiveCount.Name = "lblActiveCount"
        lblActiveCount.Size = New Size(52, 54)
        lblActiveCount.TabIndex = 20
        lblActiveCount.Text = "0"
        ' 
        ' lblInactiveCount
        ' 
        lblInactiveCount.AutoSize = True
        lblInactiveCount.BackColor = Color.FromArgb(CByte(176), CByte(234), CByte(253))
        lblInactiveCount.Font = New Font("Lucida Sans Unicode", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInactiveCount.ForeColor = Color.Red
        lblInactiveCount.Location = New Point(1102, 607)
        lblInactiveCount.Name = "lblInactiveCount"
        lblInactiveCount.Size = New Size(52, 54)
        lblInactiveCount.TabIndex = 21
        lblInactiveCount.Text = "0"
        ' 
        ' lblTotalCollected
        ' 
        lblTotalCollected.AutoSize = True
        lblTotalCollected.BackColor = Color.FromArgb(CByte(142), CByte(227), CByte(255))
        lblTotalCollected.Font = New Font("Lucida Sans Unicode", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalCollected.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        lblTotalCollected.Location = New Point(1428, 588)
        lblTotalCollected.Name = "lblTotalCollected"
        lblTotalCollected.Size = New Size(52, 54)
        lblTotalCollected.TabIndex = 22
        lblTotalCollected.Text = "0"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(761, 450)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(425, 248)
        PictureBox2.TabIndex = 23
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(1234, 450)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(481, 248)
        PictureBox3.TabIndex = 24
        PictureBox3.TabStop = False
        ' 
        ' dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1902, 1033)
        Controls.Add(lblTotalCollected)
        Controls.Add(lblInactiveCount)
        Controls.Add(lblActiveCount)
        Controls.Add(Button6)
        Controls.Add(lblDate)
        Controls.Add(lblTime)
        Controls.Add(Label2)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox6)
        Controls.Add(totalcustomer)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox3)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "dashboard"
        Text = "Dashboard"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Public WithEvents totalcustomer As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Public WithEvents lblActiveCount As Label
    Public WithEvents lblInactiveCount As Label
    Public WithEvents lblTotalCollected As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
