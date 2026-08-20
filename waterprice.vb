Imports MySql.Data.MySqlClient

Public Class waterprice
    Dim con As New MySqlConnection("server=localhost;userid=root;password=;database=eventdriven")
    Private Sub waterprice_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Button3.Click
        LoadWaterPrice()
    End Sub
    Private Sub LoadWaterPrice()
        Try
            con.Open()
            Dim cmd As New MySqlCommand("SELECT water_price FROM water_price LIMIT 1", con)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader()
            If rdr.Read() Then
                txtWaterPrice.Text = rdr("water_price").ToString()
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading water price: " & ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub btnUpdatePrice_Click(sender As Object, e As EventArgs) Handles btnUpdatePrice.Click
        Try
            con.Open()

            Dim checkExist As New MySqlCommand("SELECT COUNT(*) FROM water_price", con)
            Dim count As Integer = CInt(checkExist.ExecuteScalar())

            Dim cmd As MySqlCommand

            If count = 0 Then
                cmd = New MySqlCommand("INSERT INTO water_price (water_pricer) VALUES (@price)", con)
            Else
                cmd = New MySqlCommand("UPDATE water_price SET water_price = @price", con)
            End If

            cmd.Parameters.AddWithValue("@price", txtWaterPrice.Text)
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Water price updated successfully.")
        Catch ex As Exception
            MessageBox.Show("Failed to update water price: " & ex.Message)
            con.Close()
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