Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class billing
    Dim con As New MySqlConnection("server=localhost;userid=root;password=;database=eventdriven")
    Dim totalAmount As Decimal

    Private Sub billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Button4.Click
        cmbPaymentMode.Items.Clear()
        cmbPaymentMode.Items.Add("Cash")
        cmbPaymentMode.Items.Add("Gcash")
        cmbPaymentMode.Items.Add("Bank Transfer")
        cmbPaymentMode.SelectedIndex = 0
        txtCubicUsed.Enabled = True
        lblTotalAmount.Visible = True
        cmbPaymentMode.Enabled = False
        dtpBillingDate.Enabled = False
        txtPricePerCubic.ReadOnly = True
        LoadWaterPrice()
    End Sub

    Private Sub LoadWaterPrice()
        Try
            con.Open()
            Dim cmd As New MySqlCommand("SELECT water_price FROM water_price LIMIT 1", con)
            Dim price As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
            txtPricePerCubic.Text = price.ToString("0.00")
        Catch ex As Exception
            MessageBox.Show("Error loading water price: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnViewDetails_Click(sender As Object, e As EventArgs) Handles btnViewDetails.Click
        Try
            con.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM consumer WHERE consumer_id = @id", con)
            cmd.Parameters.AddWithValue("@id", txtconsumerid.Text)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            If dr.Read() Then
                txtname.Text = dr("name").ToString()
                txtPhone.Text = dr("phone").ToString()
                txtaddress.Text = dr("address").ToString()
            Else
                MessageBox.Show("Consumer not found.")
                dr.Close()
                Exit Sub
            End If
            dr.Close()

            cmd = New MySqlCommand("SELECT water_price FROM water_price", con)
            Dim waterPrice As Object = cmd.ExecuteScalar()
            If waterPrice IsNot Nothing Then
                txtPricePerCubic.Text = waterPrice.ToString()
            Else
                txtPricePerCubic.Text = "0"
                MessageBox.Show("Water price not found.")
            End If

            txtCubicUsed.Enabled = True
            txtPricePerCubic.Enabled = False
            lblTotalAmount.Visible = True
            cmbPaymentMode.Enabled = True
            dtpBillingDate.Enabled = True
            lblTotalAmount.Text = "₱0.00"
            RecalculateTotal()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Try
            If Not ValidateFields() Then Exit Sub

            Dim cubicUsed As Decimal = Decimal.Parse(txtCubicUsed.Text)
            Dim pricePerCubic As Decimal = Decimal.Parse(txtPricePerCubic.Text)


            Dim penaltyAmount As Decimal = 0
            Decimal.TryParse(Replace(txtPenalty.Text, "₱", "").Trim(), penaltyAmount)

            totalAmount = (cubicUsed * pricePerCubic) + penaltyAmount

            con.Open()
            Dim getIdCmd As New MySqlCommand("SELECT id FROM consumer WHERE consumer_id = @cid", con)
            getIdCmd.Parameters.AddWithValue("@cid", txtconsumerid.Text.Trim())
            Dim internalIdObj As Object = getIdCmd.ExecuteScalar()
            If internalIdObj Is Nothing Then
                MessageBox.Show("Error: Consumer ID not found.")
                Exit Sub
            End If

            Dim internalId As Integer = Convert.ToInt32(internalIdObj)

            Dim insertCmd As New MySqlCommand(
                "INSERT INTO billing (consumer_id, volume_used, price_per_cubic, total_amount, penalty, pay_mode, billing_date, billing_period_from, billing_period_to, due_date, is_paid) " &
                "VALUES (@cid, @cubic, @price, @total, @penalty, @paymode, @bdate, @periodFrom, @periodTo, @dueDate, 1)", con)

            insertCmd.Parameters.AddWithValue("@cid", internalId)
            insertCmd.Parameters.AddWithValue("@cubic", cubicUsed)
            insertCmd.Parameters.AddWithValue("@price", pricePerCubic)
            insertCmd.Parameters.AddWithValue("@total", totalAmount)
            insertCmd.Parameters.AddWithValue("@penalty", penaltyAmount)
            insertCmd.Parameters.AddWithValue("@paymode", cmbPaymentMode.Text)
            insertCmd.Parameters.AddWithValue("@bdate", dtpBillingDate.Value.Date)
            insertCmd.Parameters.AddWithValue("@periodFrom", dtpPeriodFrom.Value.Date)
            insertCmd.Parameters.AddWithValue("@periodTo", dtpPeriodTo.Value.Date)
            insertCmd.Parameters.AddWithValue("@dueDate", dtpDueDate.Value.Date)

            insertCmd.ExecuteNonQuery()

            MessageBox.Show("Payment successfully recorded!")
            lblTotalAmount.Text = "₱" & totalAmount.ToString("N2")

        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub RecalculateTotal()
        If IsNumeric(txtCubicUsed.Text) AndAlso IsNumeric(txtPricePerCubic.Text) Then
            Dim cubicUsed As Decimal = Decimal.Parse(txtCubicUsed.Text)
            Dim pricePerCubic As Decimal = Decimal.Parse(txtPricePerCubic.Text)
            Dim penalty As Decimal = 0D

            If dtpBillingDate.Value.Date > dtpDueDate.Value.Date Then
                penalty = 30D
            End If

            txtPenalty.Text = "₱" & penalty.ToString("N2")
            totalAmount = (cubicUsed * pricePerCubic) + penalty
            lblTotalAmount.Text = "₱" & totalAmount.ToString("N2")
        Else
            totalAmount = 0
            lblTotalAmount.Text = "₱0.00"
            txtPenalty.Text = "₱0.00"
        End If
    End Sub

    Private Function ValidateFields() As Boolean
        If String.IsNullOrWhiteSpace(txtconsumerid.Text) Then
            MessageBox.Show("Consumer ID is required.")
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtCubicUsed.Text) OrElse Not IsNumeric(txtCubicUsed.Text) Then
            MessageBox.Show("Please enter a valid cubic used value.")
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPricePerCubic.Text) OrElse Not IsNumeric(txtPricePerCubic.Text) Then
            MessageBox.Show("Invalid price per cubic.")
            Return False
        End If

        If cmbPaymentMode.SelectedIndex = -1 Then
            MessageBox.Show("Select a payment mode.")
            Return False
        End If

        If dtpPeriodFrom.Value.Date > dtpPeriodTo.Value.Date Then
            MessageBox.Show("Billing period 'From' date cannot be after 'To' date.")
            Return False
        End If

        If dtpDueDate.Value.Date < dtpPeriodTo.Value.Date Then
            MessageBox.Show("Due date cannot be before billing period 'To' date.")
            Return False
        End If

        Return True
    End Function

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim g As Graphics = e.Graphics
        Dim fontRegular As New Font("Poppins", 16, FontStyle.Regular)
        Dim fontBold As New Font("Poppins", 16, FontStyle.Bold)
        Dim lineHeight As Integer = CInt(fontRegular.GetHeight(g)) + 10
        Dim pageWidth As Integer = e.PageBounds.Width

        Dim marginLeft As Integer = 50
        Dim valueColumnX As Integer = 300
        Dim y As Integer = 50

        Try
            Dim logoPath As String = "C:\Users\USER\Downloads\logo.png"
            If IO.File.Exists(logoPath) Then
                Using logo As Image = Image.FromFile(logoPath)
                    Dim logoWidth As Integer = 400
                    Dim logoHeight As Integer = 100
                    Dim logoX As Integer = (pageWidth - logoWidth) \ 2
                    g.DrawImage(logo, logoX, y, logoWidth, logoHeight)
                    y += logoHeight + 20
                End Using
            End If
        Catch ex As Exception
        End Try

        Dim header As String = "RECEIPT"
        Dim headerSize As SizeF = g.MeasureString(header, fontBold)
        Dim headerX As Integer = (pageWidth - headerSize.Width) \ 2
        g.DrawString(header, fontBold, Brushes.Black, headerX, y)
        y += lineHeight + 10

        Dim info As New Dictionary(Of String, String) From {
        {"Consumer ID", txtconsumerid.Text},
        {"Name", txtname.Text},
        {"Phone Number", txtPhone.Text},
        {"Address", txtaddress.Text},
        {"Volume Used", txtCubicUsed.Text & " cu.m"},
        {"Rate per Cu.m", "₱" & Decimal.Parse(txtPricePerCubic.Text).ToString("N2")},
        {"Penalty", txtPenalty.Text},
        {"Payment Mode", cmbPaymentMode.Text},
        {"Billing Period", $"{dtpPeriodFrom.Value:yyyy-MM-dd} to {dtpPeriodTo.Value:yyyy-MM-dd}"},
        {"Due Date", dtpDueDate.Value.ToString("yyyy-MM-dd")},
        {"Billing Date", dtpBillingDate.Value.ToString("yyyy-MM-dd")}
    }

        For Each pair In info
            g.DrawString(pair.Key & ":", fontRegular, Brushes.Black, marginLeft, y)
            g.DrawString(pair.Value, fontRegular, Brushes.Black, valueColumnX, y)
            y += lineHeight
        Next

        y += 10
        g.DrawString("Total Amount:", fontBold, Brushes.Black, marginLeft, y)
        g.DrawString("₱" & totalAmount.ToString("N2"), fontBold, Brushes.Black, valueColumnX, y)
        y += lineHeight + 10

        g.DrawString("Thank you for your payment!", fontRegular, Brushes.Black, marginLeft, y)
    End Sub


    Private Sub txtCubicUsed_TextChanged(sender As Object, e As EventArgs) Handles txtCubicUsed.TextChanged
        RecalculateTotal()
    End Sub

    Private Sub dtpBillingDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpBillingDate.ValueChanged
        RecalculateTotal()
    End Sub

    Private Sub dtpDueDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDueDate.ValueChanged
        RecalculateTotal()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtconsumerid.Clear()
        txtname.Clear()
        txtPhone.Clear()
        txtaddress.Clear()
        txtCubicUsed.Clear()
        txtPricePerCubic.Clear()
        txtPenalty.Text = "₱0.00"
        lblTotalAmount.Text = "₱0.00"

        cmbPaymentMode.SelectedIndex = 0
        cmbPaymentMode.Enabled = False
        dtpBillingDate.Value = DateTime.Now
        dtpBillingDate.Enabled = False
        dtpPeriodFrom.Value = DateTime.Now
        dtpPeriodTo.Value = DateTime.Now
        dtpDueDate.Value = DateTime.Now

        txtCubicUsed.Enabled = False
        txtPricePerCubic.ReadOnly = True

        txtconsumerid.Focus()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dashboard.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        consumer.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        waterprice.Show()
        Me.Close()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        report.Show()
        Me.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            login.ClearLoginFields()
            login.Show()
            Me.Close()
        End If
    End Sub
End Class
