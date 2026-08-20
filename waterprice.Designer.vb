<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class waterprice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(waterprice))
        Label1 = New Label()
        txtWaterPrice = New TextBox()
        btnUpdatePrice = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(210), CByte(245), CByte(255))
        Label1.Font = New Font("Lucida Sans Typewriter", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkBlue
        Label1.Location = New Point(726, 357)
        Label1.Name = "Label1"
        Label1.Size = New Size(527, 54)
        Label1.TabIndex = 0
        Label1.Text = "WATER PRICE/ METER"
        ' 
        ' txtWaterPrice
        ' 
        txtWaterPrice.Font = New Font("Lucida Sans Typewriter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtWaterPrice.ForeColor = Color.DarkBlue
        txtWaterPrice.Location = New Point(778, 448)
        txtWaterPrice.Name = "txtWaterPrice"
        txtWaterPrice.Size = New Size(435, 29)
        txtWaterPrice.TabIndex = 1
        ' 
        ' btnUpdatePrice
        ' 
        btnUpdatePrice.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        btnUpdatePrice.Font = New Font("Lucida Sans Typewriter", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdatePrice.ForeColor = Color.DarkBlue
        btnUpdatePrice.Image = CType(resources.GetObject("btnUpdatePrice.Image"), Image)
        btnUpdatePrice.ImageAlign = ContentAlignment.MiddleRight
        btnUpdatePrice.Location = New Point(895, 509)
        btnUpdatePrice.Name = "btnUpdatePrice"
        btnUpdatePrice.Size = New Size(242, 52)
        btnUpdatePrice.TabIndex = 2
        btnUpdatePrice.Text = "UPDATE PRICE"
        btnUpdatePrice.TextAlign = ContentAlignment.MiddleLeft
        btnUpdatePrice.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        Button6.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Button6.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Button6.Location = New Point(1483, 54)
        Button6.Name = "Button6"
        Button6.Size = New Size(138, 64)
        Button6.TabIndex = 40
        Button6.Text = "REPORT"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        Button5.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Button5.Image = CType(resources.GetObject("Button5.Image"), Image)
        Button5.ImageAlign = ContentAlignment.MiddleRight
        Button5.Location = New Point(1654, 54)
        Button5.Name = "Button5"
        Button5.Size = New Size(163, 62)
        Button5.TabIndex = 39
        Button5.Text = "LOG OUT"
        Button5.TextAlign = ContentAlignment.MiddleLeft
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        Button4.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Button4.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Button4.Location = New Point(1306, 54)
        Button4.Name = "Button4"
        Button4.Size = New Size(138, 64)
        Button4.TabIndex = 38
        Button4.Text = "BILLING"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        Button3.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Button3.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Button3.Location = New Point(1106, 54)
        Button3.Name = "Button3"
        Button3.Size = New Size(157, 64)
        Button3.TabIndex = 37
        Button3.Text = "WATER PRICE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        Button2.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Button2.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Button2.Location = New Point(924, 54)
        Button2.Name = "Button2"
        Button2.Size = New Size(138, 64)
        Button2.TabIndex = 36
        Button2.Text = "CONSUMER"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        Button1.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Button1.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Button1.Location = New Point(748, 54)
        Button1.Name = "Button1"
        Button1.Size = New Size(138, 64)
        Button1.TabIndex = 35
        Button1.Text = "DASHBOARD"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' waterprice
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1902, 1033)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(btnUpdatePrice)
        Controls.Add(txtWaterPrice)
        Controls.Add(Label1)
        ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "waterprice"
        Text = "Water Price"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtWaterPrice As TextBox
    Friend WithEvents btnUpdatePrice As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
