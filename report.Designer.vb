<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(report))
        DataGridView1 = New DataGridView()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label2 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(168), CByte(244), CByte(255))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(353, 399)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1217, 504)
        DataGridView1.TabIndex = 0
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        Button6.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Button6.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Button6.Location = New Point(1479, 50)
        Button6.Name = "Button6"
        Button6.Size = New Size(138, 64)
        Button6.TabIndex = 25
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
        Button5.Location = New Point(1650, 50)
        Button5.Name = "Button5"
        Button5.Size = New Size(163, 62)
        Button5.TabIndex = 24
        Button5.Text = "LOG OUT"
        Button5.TextAlign = ContentAlignment.MiddleLeft
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        Button4.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Button4.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Button4.Location = New Point(1302, 50)
        Button4.Name = "Button4"
        Button4.Size = New Size(138, 64)
        Button4.TabIndex = 23
        Button4.Text = "BILLING"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        Button3.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Button3.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Button3.Location = New Point(1102, 50)
        Button3.Name = "Button3"
        Button3.Size = New Size(157, 64)
        Button3.TabIndex = 22
        Button3.Text = "WATER PRICE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        Button2.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Button2.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Button2.Location = New Point(920, 50)
        Button2.Name = "Button2"
        Button2.Size = New Size(138, 64)
        Button2.TabIndex = 21
        Button2.Text = "CONSUMER"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        Button1.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Button1.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Button1.Location = New Point(744, 50)
        Button1.Name = "Button1"
        Button1.Size = New Size(138, 64)
        Button1.TabIndex = 20
        Button1.Text = "DASHBOARD"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(210), CByte(245), CByte(255))
        Label2.Font = New Font("Lucida Sans Typewriter", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkBlue
        Label2.Location = New Point(698, 227)
        Label2.Name = "Label2"
        Label2.Size = New Size(489, 136)
        Label2.TabIndex = 26
        Label2.Text = "REPORT"
        ' 
        ' report
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1902, 1033)
        Controls.Add(Label2)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "report"
        Text = "Report"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
End Class
