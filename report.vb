Imports MySql.Data.MySqlClient

Public Class Report
    Dim connection As New MySqlConnection("server=localhost;userid=root;password=;database=eventdriven")
    Dim adapter As MySqlDataAdapter
    Dim dt As DataTable

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Button6.Click
        LoadReportData()
    End Sub

    Private Sub LoadReportData()
        Try
            connection.Open()

            Dim query As String = "
                SELECT 
                    IFNULL(b.billing_id, 'N/A') AS 'Billing ID',
                    IFNULL(b.billing_date, 'N/A') AS 'Date',
                    c.ID AS 'Consumer ID',
                    c.name AS 'Consumer Name',
                    c.phone AS 'Phone',
                    c.address AS 'Address',
                    IFNULL(b.volume_used, 0) AS 'Cubic Used',
                    IFNULL(b.price_per_cubic, 0) AS 'Price per Cubic',
                    IFNULL(b.total_amount, 0) AS 'Total Amount',
                    CASE 
                        WHEN b.is_paid = 1 THEN 'Paid'
                        WHEN b.is_paid = 0 THEN 'Pending'
                        ELSE 'No Billing'
                    END AS 'Payment Status'
                FROM consumer c
                LEFT JOIN billing b ON b.consumer_id = c.ID
                ORDER BY b.billing_date DESC;
            "

            adapter = New MySqlDataAdapter(query, connection)
            dt = New DataTable()
            adapter.Fill(dt)

            DataGridView1.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message)
        Finally
            connection.Close()
        End Try
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
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        billing.Show()
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
