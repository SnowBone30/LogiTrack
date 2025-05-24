Imports MySql.Data.MySqlClient

Public Class AdminRegistration
    Dim connection As MySqlConnection

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim connString As String = "server=localhost;userid=root;password=;database=logbookdb;"
        connection = New MySqlConnection(connString)

        Try
            connection.Open()
            Dim query As String = "INSERT INTO login (username, password, log_id) VALUES (@username, @password, @log_id)"
            Dim command As New MySqlCommand(query, connection)

            ' Parameterized query to prevent SQL injection
            command.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
            command.Parameters.AddWithValue("@password", txtPassword.Text.Trim())
            command.Parameters.AddWithValue("@log_id", txtLogID.Text.Trim())

            command.ExecuteNonQuery()
            MessageBox.Show("Account successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Optionally clear fields
            txtLogID.Text = ""
            txtUsername.Text = ""
            txtPassword.Text = ""



        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim ad As New AdminDashboard
        ad.Show()
        Me.Close()
    End Sub

    Private Sub AdminRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtLogID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLogID.KeyDown
        If (e.KeyCode = 13) Then
            txtUsername.Focus()
        End If
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If (e.KeyCode = 13) Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If (e.KeyCode = 13) Then
            btnCreate.Focus()
        End If
    End Sub
End Class
