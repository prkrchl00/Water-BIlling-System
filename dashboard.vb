Imports MySql.Data.MySqlClient

Public Class dashboard
    Public Sub UpdateTotalCustomers()
        Try
            Dim con As New MySqlConnection("server=localhost;userid=root;password=;database=eventdriven")
            con.Open()

            Dim queryTotal As String = "SELECT COUNT(*) FROM consumer"
            Dim cmdTotal As New MySqlCommand(queryTotal, con)
            Dim totalCount As Integer = Convert.ToInt32(cmdTotal.ExecuteScalar())
            totalcustomer.Text = totalCount.ToString()

            Dim queryActive As String = "SELECT COUNT(*) FROM consumer WHERE status = 'Active'"
            Dim cmdActive As New MySqlCommand(queryActive, con)
            Dim activeCount As Integer = Convert.ToInt32(cmdActive.ExecuteScalar())
            lblActiveCount.Text = activeCount.ToString()

            Dim queryInactive As String = "SELECT COUNT(*) FROM consumer WHERE status = 'Inactive'"
            Dim cmdInactive As New MySqlCommand(queryInactive, con)
            Dim inactiveCount As Integer = Convert.ToInt32(cmdInactive.ExecuteScalar())
            lblInactiveCount.Text = inactiveCount.ToString()

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Failed to update customer counts: " & ex.Message)
        End Try
    End Sub
    Public Sub UpdateTotalCollected()
        Try
            Dim con As New MySqlConnection("server=localhost;userid=root;password=;database=eventdriven")
            con.Open()

            Dim query As String = "SELECT SUM(total_amount) FROM billing"
            Dim cmd As New MySqlCommand(query, con)
            Dim result = cmd.ExecuteScalar()

            Dim totalCollected As Decimal = 0D
            If Not IsDBNull(result) Then
                totalCollected = Convert.ToDecimal(result)
            End If

            lblTotalCollected.Text = "₱" & totalCollected.ToString("N2")
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Failed to load total collected amount: " & ex.Message)
        End Try
    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Button1.Click
        Timer1.Start()
        UpdateTotalCustomers()
        UpdateTotalCollected()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
        lblDate.Text = DateTime.Now.ToString("dddd, dd-MMM-yyyy")
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
