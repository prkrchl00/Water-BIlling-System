<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class consumer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(consumer))
        txtSearch = New TextBox()
        btnSearch = New Button()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        DataGridView1 = New DataGridView()
        TabPage4 = New TabPage()
        Label9 = New Label()
        cbStatusUpdate = New ComboBox()
        btnDelete = New Button()
        btnUpdate = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtaddress = New TextBox()
        txtphone = New TextBox()
        txtname = New TextBox()
        txtconsumerid = New TextBox()
        TabPage5 = New TabPage()
        Status = New Label()
        cbStatus = New ComboBox()
        btnAdd = New Button()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TabPage4.SuspendLayout()
        TabPage5.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Lucida Sans Typewriter", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(755, 271)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(435, 29)
        txtSearch.TabIndex = 26
        ' 
        ' btnSearch
        ' 
        btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), Image)
        btnSearch.Location = New Point(1205, 271)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(64, 36)
        btnSearch.TabIndex = 27
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Controls.Add(TabPage5)
        TabControl1.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(372, 333)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1228, 566)
        TabControl1.TabIndex = 28
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.FromArgb(CByte(168), CByte(244), CByte(255))
        TabPage1.Controls.Add(DataGridView1)
        TabPage1.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabPage1.Location = New Point(4, 32)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1220, 530)
        TabPage1.TabIndex = 0
        TabPage1.Text = "CONSUMER LIST"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(168), CByte(244), CByte(255))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(15, 26)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1199, 498)
        DataGridView1.TabIndex = 0
        ' 
        ' TabPage4
        ' 
        TabPage4.BackColor = Color.FromArgb(CByte(168), CByte(244), CByte(255))
        TabPage4.Controls.Add(Label9)
        TabPage4.Controls.Add(cbStatusUpdate)
        TabPage4.Controls.Add(btnDelete)
        TabPage4.Controls.Add(btnUpdate)
        TabPage4.Controls.Add(Label4)
        TabPage4.Controls.Add(Label3)
        TabPage4.Controls.Add(Label2)
        TabPage4.Controls.Add(Label1)
        TabPage4.Controls.Add(txtaddress)
        TabPage4.Controls.Add(txtphone)
        TabPage4.Controls.Add(txtname)
        TabPage4.Controls.Add(txtconsumerid)
        TabPage4.Location = New Point(4, 32)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(1220, 530)
        TabPage4.TabIndex = 1
        TabPage4.Text = "MANAGE CONSUMER"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Label9.Location = New Point(376, 354)
        Label9.Name = "Label9"
        Label9.Size = New Size(82, 23)
        Label9.TabIndex = 25
        Label9.Text = "STATUS"
        ' 
        ' cbStatusUpdate
        ' 
        cbStatusUpdate.FormattingEnabled = True
        cbStatusUpdate.Items.AddRange(New Object() {"Active", "Inactive"})
        cbStatusUpdate.Location = New Point(506, 354)
        cbStatusUpdate.Name = "cbStatusUpdate"
        cbStatusUpdate.Size = New Size(388, 31)
        cbStatusUpdate.TabIndex = 24
        ' 
        ' btnDelete
        ' 
        btnDelete.ForeColor = Color.DarkBlue
        btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), Image)
        btnDelete.ImageAlign = ContentAlignment.MiddleRight
        btnDelete.Location = New Point(724, 416)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(123, 44)
        btnDelete.TabIndex = 22
        btnDelete.Text = "DELETE"
        btnDelete.TextAlign = ContentAlignment.MiddleLeft
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.ForeColor = Color.DarkBlue
        btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), Image)
        btnUpdate.ImageAlign = ContentAlignment.MiddleRight
        btnUpdate.Location = New Point(555, 416)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(126, 44)
        btnUpdate.TabIndex = 21
        btnUpdate.Text = "UPDATE"
        btnUpdate.TextAlign = ContentAlignment.MiddleLeft
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Label4.Location = New Point(367, 290)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 23)
        Label4.TabIndex = 10
        Label4.Text = "ADDRESS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Label3.Location = New Point(343, 219)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 23)
        Label3.TabIndex = 9
        Label3.Text = "PHONE NO."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Label2.Location = New Point(343, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 23)
        Label2.TabIndex = 8
        Label2.Text = "FULL NAME"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Label1.Location = New Point(328, 95)
        Label1.Name = "Label1"
        Label1.Size = New Size(142, 23)
        Label1.TabIndex = 7
        Label1.Text = "CONSUMER ID"
        ' 
        ' txtaddress
        ' 
        txtaddress.Location = New Point(506, 280)
        txtaddress.Name = "txtaddress"
        txtaddress.Size = New Size(388, 38)
        txtaddress.TabIndex = 3
        ' 
        ' txtphone
        ' 
        txtphone.Location = New Point(506, 215)
        txtphone.Name = "txtphone"
        txtphone.Size = New Size(388, 38)
        txtphone.TabIndex = 2
        ' 
        ' txtname
        ' 
        txtname.Location = New Point(506, 150)
        txtname.Name = "txtname"
        txtname.Size = New Size(388, 38)
        txtname.TabIndex = 1
        ' 
        ' txtconsumerid
        ' 
        txtconsumerid.Location = New Point(506, 91)
        txtconsumerid.Name = "txtconsumerid"
        txtconsumerid.Size = New Size(388, 38)
        txtconsumerid.TabIndex = 0
        ' 
        ' TabPage5
        ' 
        TabPage5.BackColor = Color.FromArgb(CByte(168), CByte(244), CByte(255))
        TabPage5.Controls.Add(Status)
        TabPage5.Controls.Add(cbStatus)
        TabPage5.Controls.Add(btnAdd)
        TabPage5.Controls.Add(Label5)
        TabPage5.Controls.Add(Label6)
        TabPage5.Controls.Add(Label7)
        TabPage5.Controls.Add(Label8)
        TabPage5.Controls.Add(TextBox1)
        TabPage5.Controls.Add(TextBox2)
        TabPage5.Controls.Add(TextBox3)
        TabPage5.Controls.Add(TextBox4)
        TabPage5.Location = New Point(4, 32)
        TabPage5.Name = "TabPage5"
        TabPage5.Size = New Size(1220, 530)
        TabPage5.TabIndex = 2
        TabPage5.Text = "ADD CONSUMER"
        ' 
        ' Status
        ' 
        Status.AutoSize = True
        Status.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Status.Location = New Point(353, 357)
        Status.Name = "Status"
        Status.Size = New Size(82, 23)
        Status.TabIndex = 23
        Status.Text = "STATUS"
        ' 
        ' cbStatus
        ' 
        cbStatus.BackColor = Color.FromArgb(CByte(210), CByte(245), CByte(255))
        cbStatus.FormattingEnabled = True
        cbStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        cbStatus.Location = New Point(483, 357)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(388, 31)
        cbStatus.TabIndex = 22
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), Image)
        btnAdd.ImageAlign = ContentAlignment.MiddleRight
        btnAdd.Location = New Point(606, 411)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(133, 49)
        btnAdd.TabIndex = 21
        btnAdd.Text = "ADD"
        btnAdd.TextAlign = ContentAlignment.MiddleLeft
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Label5.Location = New Point(344, 289)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 23)
        Label5.TabIndex = 18
        Label5.Text = "ADDRESS"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Label6.Location = New Point(320, 218)
        Label6.Name = "Label6"
        Label6.Size = New Size(118, 23)
        Label6.TabIndex = 17
        Label6.Text = "PHONE NO."
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Label7.Location = New Point(320, 149)
        Label7.Name = "Label7"
        Label7.Size = New Size(118, 23)
        Label7.TabIndex = 16
        Label7.Text = "FULL NAME"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Label8.Location = New Point(305, 94)
        Label8.Name = "Label8"
        Label8.Size = New Size(142, 23)
        Label8.TabIndex = 15
        Label8.Text = "CONSUMER ID"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(483, 279)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(388, 38)
        TextBox1.TabIndex = 14
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(483, 214)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(388, 38)
        TextBox2.TabIndex = 13
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(483, 149)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(388, 38)
        TextBox3.TabIndex = 12
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(483, 90)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(388, 38)
        TextBox4.TabIndex = 11
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        Button6.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Button6.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Button6.Location = New Point(1490, 53)
        Button6.Name = "Button6"
        Button6.Size = New Size(138, 64)
        Button6.TabIndex = 34
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
        Button5.Location = New Point(1661, 53)
        Button5.Name = "Button5"
        Button5.Size = New Size(163, 62)
        Button5.TabIndex = 33
        Button5.Text = "LOG OUT"
        Button5.TextAlign = ContentAlignment.MiddleLeft
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        Button4.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Button4.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Button4.Location = New Point(1313, 53)
        Button4.Name = "Button4"
        Button4.Size = New Size(138, 64)
        Button4.TabIndex = 32
        Button4.Text = "BILLING"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        Button3.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Button3.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Button3.Location = New Point(1113, 53)
        Button3.Name = "Button3"
        Button3.Size = New Size(157, 64)
        Button3.TabIndex = 31
        Button3.Text = "WATER PRICE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        Button2.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Button2.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Button2.Location = New Point(931, 53)
        Button2.Name = "Button2"
        Button2.Size = New Size(138, 64)
        Button2.TabIndex = 30
        Button2.Text = "CONSUMER"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        Button1.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Button1.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Button1.Location = New Point(755, 53)
        Button1.Name = "Button1"
        Button1.Size = New Size(138, 64)
        Button1.TabIndex = 29
        Button1.Text = "DASHBOARD"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' consumer
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
        Controls.Add(TabControl1)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "consumer"
        Text = "Client"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        TabPage5.ResumeLayout(False)
        TabPage5.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtconsumerid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Status As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbStatusUpdate As ComboBox
End Class