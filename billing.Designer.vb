<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class billing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(billing))
        grpConsumerInfo = New GroupBox()
        txtPhone = New TextBox()
        btnViewDetails = New Button()
        txtaddress = New TextBox()
        Label4 = New Label()
        Label1 = New Label()
        txtname = New TextBox()
        Label3 = New Label()
        txtconsumerid = New TextBox()
        Label2 = New Label()
        btnPrint = New Button()
        dtpBillingDate = New DateTimePicker()
        lblTotalAmount = New TextBox()
        btnCancel = New Button()
        btnPay = New Button()
        cmbPaymentMode = New ComboBox()
        txtPricePerCubic = New TextBox()
        txtCubicUsed = New TextBox()
        PrintDocument1 = New Printing.PrintDocument()
        PrintDocument2 = New Printing.PrintDocument()
        PrintDialog1 = New PrintDialog()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        GroupBox1 = New GroupBox()
        dtpDueDate = New DateTimePicker()
        Label13 = New Label()
        dtpPeriodTo = New DateTimePicker()
        dtpPeriodFrom = New DateTimePicker()
        Label12 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        txtPenalty = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        grpConsumerInfo.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpConsumerInfo
        ' 
        grpConsumerInfo.BackColor = Color.FromArgb(CByte(210), CByte(245), CByte(255))
        grpConsumerInfo.Controls.Add(txtPhone)
        grpConsumerInfo.Controls.Add(btnViewDetails)
        grpConsumerInfo.Controls.Add(txtaddress)
        grpConsumerInfo.Controls.Add(Label4)
        grpConsumerInfo.Controls.Add(Label1)
        grpConsumerInfo.Controls.Add(txtname)
        grpConsumerInfo.Controls.Add(Label3)
        grpConsumerInfo.Controls.Add(txtconsumerid)
        grpConsumerInfo.Controls.Add(Label2)
        grpConsumerInfo.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpConsumerInfo.Location = New Point(374, 276)
        grpConsumerInfo.Name = "grpConsumerInfo"
        grpConsumerInfo.Size = New Size(555, 449)
        grpConsumerInfo.TabIndex = 0
        grpConsumerInfo.TabStop = False
        grpConsumerInfo.Text = "CONSUMER DETAILS"
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(180, 209)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(323, 31)
        txtPhone.TabIndex = 25
        ' 
        ' btnViewDetails
        ' 
        btnViewDetails.ForeColor = Color.DarkBlue
        btnViewDetails.Image = CType(resources.GetObject("btnViewDetails.Image"), Image)
        btnViewDetails.ImageAlign = ContentAlignment.MiddleRight
        btnViewDetails.Location = New Point(228, 362)
        btnViewDetails.Name = "btnViewDetails"
        btnViewDetails.Size = New Size(211, 46)
        btnViewDetails.TabIndex = 19
        btnViewDetails.Text = "VIEW DETAILS"
        btnViewDetails.TextAlign = ContentAlignment.MiddleLeft
        btnViewDetails.UseVisualStyleBackColor = True
        ' 
        ' txtaddress
        ' 
        txtaddress.Location = New Point(180, 275)
        txtaddress.Multiline = True
        txtaddress.Name = "txtaddress"
        txtaddress.ReadOnly = True
        txtaddress.Size = New Size(323, 53)
        txtaddress.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans Typewriter", 10.8F, FontStyle.Bold)
        Label4.Location = New Point(64, 275)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 21)
        Label4.TabIndex = 18
        Label4.Text = "ADDRESS"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans Typewriter", 10.8F, FontStyle.Bold)
        Label1.Location = New Point(27, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 21)
        Label1.TabIndex = 15
        Label1.Text = "CONSUMER ID"
        ' 
        ' txtname
        ' 
        txtname.Location = New Point(180, 140)
        txtname.Name = "txtname"
        txtname.ReadOnly = True
        txtname.Size = New Size(323, 31)
        txtname.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans Typewriter", 10.8F, FontStyle.Bold)
        Label3.Location = New Point(42, 214)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 21)
        Label3.TabIndex = 17
        Label3.Text = "PHONE NO."
        ' 
        ' txtconsumerid
        ' 
        txtconsumerid.Location = New Point(180, 80)
        txtconsumerid.Name = "txtconsumerid"
        txtconsumerid.Size = New Size(323, 31)
        txtconsumerid.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans Typewriter", 10.8F, FontStyle.Bold)
        Label2.Location = New Point(42, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 21)
        Label2.TabIndex = 16
        Label2.Text = "FULL NAME"
        ' 
        ' btnPrint
        ' 
        btnPrint.ForeColor = Color.DarkBlue
        btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), Image)
        btnPrint.ImageAlign = ContentAlignment.MiddleRight
        btnPrint.Location = New Point(382, 643)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(136, 42)
        btnPrint.TabIndex = 28
        btnPrint.Text = "RECEIPT"
        btnPrint.TextAlign = ContentAlignment.MiddleLeft
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' dtpBillingDate
        ' 
        dtpBillingDate.Format = DateTimePickerFormat.Custom
        dtpBillingDate.Location = New Point(195, 586)
        dtpBillingDate.Name = "dtpBillingDate"
        dtpBillingDate.Size = New Size(323, 31)
        dtpBillingDate.TabIndex = 26
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.Location = New Point(195, 264)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.ReadOnly = True
        lblTotalAmount.Size = New Size(323, 31)
        lblTotalAmount.TabIndex = 24
        ' 
        ' btnCancel
        ' 
        btnCancel.ForeColor = Color.DarkBlue
        btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), Image)
        btnCancel.ImageAlign = ContentAlignment.MiddleRight
        btnCancel.Location = New Point(223, 644)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(124, 40)
        btnCancel.TabIndex = 23
        btnCancel.Text = "CANCEL"
        btnCancel.TextAlign = ContentAlignment.MiddleLeft
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnPay
        ' 
        btnPay.ForeColor = Color.DarkBlue
        btnPay.Image = CType(resources.GetObject("btnPay.Image"), Image)
        btnPay.ImageAlign = ContentAlignment.MiddleRight
        btnPay.Location = New Point(88, 644)
        btnPay.Name = "btnPay"
        btnPay.Size = New Size(105, 44)
        btnPay.TabIndex = 22
        btnPay.Text = "PAY"
        btnPay.TextAlign = ContentAlignment.MiddleLeft
        btnPay.UseVisualStyleBackColor = True
        ' 
        ' cmbPaymentMode
        ' 
        cmbPaymentMode.FormattingEnabled = True
        cmbPaymentMode.Items.AddRange(New Object() {"CASH", "GCASH", "MAYA"})
        cmbPaymentMode.Location = New Point(195, 336)
        cmbPaymentMode.Name = "cmbPaymentMode"
        cmbPaymentMode.Size = New Size(323, 31)
        cmbPaymentMode.TabIndex = 21
        ' 
        ' txtPricePerCubic
        ' 
        txtPricePerCubic.Location = New Point(195, 130)
        txtPricePerCubic.Name = "txtPricePerCubic"
        txtPricePerCubic.ReadOnly = True
        txtPricePerCubic.Size = New Size(323, 31)
        txtPricePerCubic.TabIndex = 20
        ' 
        ' txtCubicUsed
        ' 
        txtCubicUsed.Location = New Point(195, 69)
        txtCubicUsed.Name = "txtCubicUsed"
        txtCubicUsed.Size = New Size(323, 31)
        txtCubicUsed.TabIndex = 13
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintDocument2
        ' 
        PrintDocument2.DocumentName = ""
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(210), CByte(245), CByte(255))
        GroupBox1.Controls.Add(dtpDueDate)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(dtpPeriodTo)
        GroupBox1.Controls.Add(dtpPeriodFrom)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(txtPenalty)
        GroupBox1.Controls.Add(btnPrint)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(btnCancel)
        GroupBox1.Controls.Add(dtpBillingDate)
        GroupBox1.Controls.Add(btnPay)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(cmbPaymentMode)
        GroupBox1.Controls.Add(txtCubicUsed)
        GroupBox1.Controls.Add(txtPricePerCubic)
        GroupBox1.Controls.Add(lblTotalAmount)
        GroupBox1.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = SystemColors.ControlText
        GroupBox1.Location = New Point(1048, 266)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(570, 738)
        GroupBox1.TabIndex = 29
        GroupBox1.TabStop = False
        GroupBox1.Text = "BILLING DETAILS"
        ' 
        ' dtpDueDate
        ' 
        dtpDueDate.Format = DateTimePickerFormat.Custom
        dtpDueDate.Location = New Point(195, 527)
        dtpDueDate.Name = "dtpDueDate"
        dtpDueDate.Size = New Size(323, 31)
        dtpDueDate.TabIndex = 39
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Lucida Sans Typewriter", 10.8F, FontStyle.Bold)
        Label13.Location = New Point(25, 527)
        Label13.Name = "Label13"
        Label13.Size = New Size(43, 21)
        Label13.TabIndex = 38
        Label13.Text = "DUE"
        ' 
        ' dtpPeriodTo
        ' 
        dtpPeriodTo.Format = DateTimePickerFormat.Custom
        dtpPeriodTo.Location = New Point(195, 464)
        dtpPeriodTo.Name = "dtpPeriodTo"
        dtpPeriodTo.Size = New Size(323, 31)
        dtpPeriodTo.TabIndex = 37
        ' 
        ' dtpPeriodFrom
        ' 
        dtpPeriodFrom.Format = DateTimePickerFormat.Custom
        dtpPeriodFrom.Location = New Point(195, 398)
        dtpPeriodFrom.Name = "dtpPeriodFrom"
        dtpPeriodFrom.Size = New Size(323, 31)
        dtpPeriodFrom.TabIndex = 36
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Lucida Sans Typewriter", 10.8F, FontStyle.Bold)
        Label12.Location = New Point(25, 408)
        Label12.Name = "Label12"
        Label12.Size = New Size(54, 21)
        Label12.TabIndex = 35
        Label12.Text = "FROM"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Lucida Sans Typewriter", 10.8F, FontStyle.Bold)
        Label10.Location = New Point(25, 464)
        Label10.Name = "Label10"
        Label10.Size = New Size(32, 21)
        Label10.TabIndex = 34
        Label10.Text = "TO"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Lucida Sans Typewriter", 10.8F, FontStyle.Bold)
        Label11.Location = New Point(22, 204)
        Label11.Name = "Label11"
        Label11.Size = New Size(87, 21)
        Label11.TabIndex = 33
        Label11.Text = "PENALTY"
        ' 
        ' txtPenalty
        ' 
        txtPenalty.Location = New Point(195, 194)
        txtPenalty.Name = "txtPenalty"
        txtPenalty.ReadOnly = True
        txtPenalty.Size = New Size(323, 31)
        txtPenalty.TabIndex = 31
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Lucida Sans Typewriter", 10.8F, FontStyle.Bold)
        Label9.Location = New Point(22, 586)
        Label9.Name = "Label9"
        Label9.Size = New Size(142, 21)
        Label9.TabIndex = 30
        Label9.Text = "BILLING DATE"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Lucida Sans Typewriter", 10.8F, FontStyle.Bold)
        Label8.Location = New Point(25, 341)
        Label8.Name = "Label8"
        Label8.Size = New Size(87, 21)
        Label8.TabIndex = 29
        Label8.Text = "PAYMENT"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Lucida Sans Typewriter", 10.8F, FontStyle.Bold)
        Label7.Location = New Point(22, 274)
        Label7.Name = "Label7"
        Label7.Size = New Size(142, 21)
        Label7.TabIndex = 28
        Label7.Text = "TOTAL AMOUNT"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Lucida Sans Typewriter", 10.8F, FontStyle.Bold)
        Label6.Location = New Point(22, 138)
        Label6.Name = "Label6"
        Label6.Size = New Size(153, 21)
        Label6.TabIndex = 27
        Label6.Text = "CUBIC PRICE/M"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Sans Typewriter", 10.8F, FontStyle.Bold)
        Label5.Location = New Point(22, 72)
        Label5.Name = "Label5"
        Label5.Size = New Size(120, 21)
        Label5.TabIndex = 26
        Label5.Text = "CUBIC USED"
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        Button6.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Button6.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Button6.Location = New Point(1465, 49)
        Button6.Name = "Button6"
        Button6.Size = New Size(138, 64)
        Button6.TabIndex = 35
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
        Button5.Location = New Point(1636, 49)
        Button5.Name = "Button5"
        Button5.Size = New Size(163, 62)
        Button5.TabIndex = 34
        Button5.Text = "LOG OUT"
        Button5.TextAlign = ContentAlignment.MiddleLeft
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        Button4.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Button4.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Button4.Location = New Point(1288, 49)
        Button4.Name = "Button4"
        Button4.Size = New Size(138, 64)
        Button4.TabIndex = 33
        Button4.Text = "BILLING"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        Button3.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Button3.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Button3.Location = New Point(1088, 49)
        Button3.Name = "Button3"
        Button3.Size = New Size(157, 64)
        Button3.TabIndex = 32
        Button3.Text = "WATER PRICE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        Button2.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Button2.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Button2.Location = New Point(906, 49)
        Button2.Name = "Button2"
        Button2.Size = New Size(138, 64)
        Button2.TabIndex = 31
        Button2.Text = "CONSUMER"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(209), CByte(242), CByte(253))
        Button1.Font = New Font("Lucida Sans Typewriter", 12F, FontStyle.Bold)
        Button1.ForeColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        Button1.Location = New Point(730, 49)
        Button1.Name = "Button1"
        Button1.Size = New Size(138, 64)
        Button1.TabIndex = 30
        Button1.Text = "DASHBOARD"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' billing
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
        Controls.Add(grpConsumerInfo)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "billing"
        Text = "Consumer Billing"
        grpConsumerInfo.ResumeLayout(False)
        grpConsumerInfo.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents grpConsumerInfo As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtCubicUsed As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtconsumerid As TextBox
    Friend WithEvents btnViewDetails As Button
    Friend WithEvents txtPricePerCubic As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnPay As Button
    Friend WithEvents cmbPaymentMode As ComboBox
    Friend WithEvents lblTotalAmount As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents dtpBillingDate As DateTimePicker
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dtpPeriodTo As DateTimePicker
    Friend WithEvents dtpPeriodFrom As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPenalty As TextBox
    Friend WithEvents dtpDueDate As DateTimePicker
    Friend WithEvents Label13 As Label
End Class
