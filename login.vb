Imports MySql.Data.MySqlClient
Imports System.Text

Public Class login
    Dim connectionString As String = "server=localhost;userid=root;password=;database=eventdriven"
    Dim connection As MySqlConnection

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MessageBox.Show("Please enter your username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter your password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Exit Sub
        End If

        Try
            connection = New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT * FROM users WHERE username = @username AND password = @password"
            Dim cmd As New MySqlCommand(query, connection)

            cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
            cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim())

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                reader.Close()
                connection.Close()

                Dim dash As New dashboard()
                dash.Show()
                Me.Close()
            Else
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                reader.Close()
                connection.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub ClearLoginFields()
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub
End Class
