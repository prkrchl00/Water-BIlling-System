Imports MySql.Data.MySqlClient

Public Class consumer
    Dim con As New MySqlConnection("server=localhost;userid=root;password=;database=eventdriven")
    Dim selectedConsumerId As String = ""
    Dim selectedConsumerRow As DataGridViewRow = Nothing

    Private Sub consumer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadConsumers()

        cbStatusUpdate.Items.Clear()
        cbStatusUpdate.Items.Add("Active")
        cbStatusUpdate.Items.Add("Inactive")
        cbStatusUpdate.SelectedIndex = 0

        AddHandler DataGridView1.CellClick, AddressOf DataGridView1_CellClick
        AddHandler TabControl1.SelectedIndexChanged, AddressOf TabControl1_SelectedIndexChanged
    End Sub

    Private Sub LoadConsumers()
        Try
            Dim query As String = "SELECT * FROM consumer"
            Dim adapter As New MySqlDataAdapter(query, con)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dashboard.totalcustomer.Text = table.Rows.Count.ToString()
            cbStatus.Items.Clear()
            cbStatus.Items.Add("Active")
            cbStatus.Items.Add("Inactive")
            cbStatus.SelectedIndex = 0


        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim cmd As New MySqlCommand("INSERT INTO consumer (consumer_id, name, phone, address, status) VALUES (@id, @name, @phone, @address, @status)", con)
            cmd.Parameters.AddWithValue("@status", cbStatus.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@id", TextBox4.Text)
            cmd.Parameters.AddWithValue("@name", TextBox3.Text)
            cmd.Parameters.AddWithValue("@phone", TextBox2.Text)
            cmd.Parameters.AddWithValue("@address", TextBox1.Text)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Consumer added successfully.")
            LoadConsumers()
            ClearTextFields()
            dashboard.UpdateTotalCustomers()
        Catch ex As Exception
            MessageBox.Show("Add failed: " & ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(selectedConsumerId) Then
            MessageBox.Show("Please select a row to update first.")
            Return
        End If

        Try
            Dim cmd As New MySqlCommand("UPDATE consumer SET name=@name, phone=@phone, address=@address, status=@status WHERE consumer_id=@id", con)
            cmd.Parameters.AddWithValue("@id", selectedConsumerId)
            cmd.Parameters.AddWithValue("@name", txtname.Text)
            cmd.Parameters.AddWithValue("@phone", txtphone.Text)
            cmd.Parameters.AddWithValue("@address", txtaddress.Text)
            cmd.Parameters.AddWithValue("@status", cbStatusUpdate.SelectedItem.ToString())


            con.Open()
            Dim rowsAffected = cmd.ExecuteNonQuery()
            con.Close()

            If rowsAffected > 0 Then
                MessageBox.Show("Consumer updated successfully.")
                LoadConsumers()
            Else
                MessageBox.Show("Update failed: No matching record found.")
            End If
        Catch ex As Exception
            MessageBox.Show("Update failed: " & ex.Message)
            con.Close()
        End Try
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim cmd As New MySqlCommand("DELETE FROM consumer WHERE consumer_id=@id", con)
            cmd.Parameters.AddWithValue("@id", txtconsumerid.Text)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Consumer deleted successfully.")
            LoadConsumers()
            ClearTextFields()
            dashboard.UpdateTotalCustomers()
        Catch ex As Exception
            MessageBox.Show("Delete failed: " & ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            selectedConsumerId = row.Cells("consumer_id").Value.ToString()

            Dim statusValue As String = row.Cells("status").Value.ToString()
            If cbStatus.Items.Contains(statusValue) Then
                cbStatus.SelectedItem = statusValue
            Else
                cbStatus.SelectedIndex = 0
            End If

            txtconsumerid.Text = selectedConsumerId
            txtname.Text = row.Cells("name").Value.ToString()
            txtphone.Text = row.Cells("phone").Value.ToString()
            txtaddress.Text = row.Cells("address").Value.ToString()
            cbStatusUpdate.SelectedItem = row.Cells("status").Value.ToString()

            TabControl1.SelectedTab = TabPage4
        End If
    End Sub


    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is TabPage4 Then
            If Not String.IsNullOrEmpty(selectedConsumerId) Then
                For Each row As DataGridViewRow In DataGridView1.Rows
                    If row.Cells("consumer_id").Value.ToString() = selectedConsumerId Then
                        txtconsumerid.Text = row.Cells("consumer_id").Value.ToString()
                        txtname.Text = row.Cells("name").Value.ToString()
                        txtphone.Text = row.Cells("phone").Value.ToString()
                        txtaddress.Text = row.Cells("address").Value.ToString()
                        cbStatus.SelectedItem = row.Cells("status").Value.ToString()

                        Exit For
                    End If
                Next
            Else
                MessageBox.Show("Please select a consumer record from the table first.")
                TabControl1.SelectedIndex = 0
            End If
        Else
            ClearTextFields()
        End If
    End Sub

    Private Sub ClearTextFields()
        txtconsumerid.Clear()
        txtname.Clear()
        txtphone.Clear()
        txtaddress.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dashboard.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        waterprice.Show()
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        billing.Show()
        Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        report.Show()
        Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim searchQuery As String = "SELECT * FROM consumer WHERE name LIKE @search OR consumer_id LIKE @search"
            Dim cmd As New MySqlCommand(searchQuery, con)
            cmd.Parameters.AddWithValue("@search", "%" & txtSearch.Text & "%")

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Search failed: " & ex.Message)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        btnSearch.PerformClick()
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
