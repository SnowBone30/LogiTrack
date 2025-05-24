Imports MySql.Data.MySqlClient

Public Class ReportLogin
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connString As String = "server=localhost;userid=root;password=;database=logbookdb;"
        connection = New MySqlConnection(connString)

        Try
            connection.Open()
            Dim query As String = "SELECT * FROM login WHERE username = @username AND password = @password"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
            command.Parameters.AddWithValue("@password", txtPassword.Text.Trim())
            reader = command.ExecuteReader()

            If reader.HasRows Then
                ' Login success
                Dim rf As New ReportForm
                rf.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password", "Admin Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Text = ""
                txtUsername.Text = ""
            End If
            reader.Close()
            connection.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim mm As New MainMenu
        mm.Show()
        Me.Hide()
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If (e.KeyCode = 13) Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If (e.KeyCode = 13) Then
            btnLogin.Focus()
        End If
    End Sub
End Class
