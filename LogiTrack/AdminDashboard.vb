﻿Imports System.Drawing
Imports System.Drawing.Printing
Imports System.IO
Imports MySql.Data.MySqlClient
Imports QRCoder

Public Class AdminDashboard

    Private Sub LoadLogEntries()

        Try
            ' Connection string for XAMPP MySQL
            Dim connectionString As String = "Server=localhost;Database=logbookdb;Uid=root;Pwd=;"
            Dim query As String = "SELECT log_id, name, role, sign_in_time,sign_out_time FROM log_entries"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Fill DataGridView
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dgvLogEntries.DataSource = dt

                conn.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            ' Validate that a record is selected
            If txtLogID.Text.Trim() = "" Then
                MessageBox.Show("Please select a record to delete.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Confirm the deletion
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Connection string for XAMPP MySQL
                Dim connectionString As String = "Server=localhost;Database=logbookdb;Uid=root;Pwd=;"
                Dim query As String = "DELETE FROM log_entries WHERE log_id = @log_id"

                Using conn As New MySqlConnection(connectionString)
                    conn.Open()

                    ' Prepare the SQL command
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@log_id", txtLogID.Text.Trim())

                        ' Execute the command
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using

                    conn.Close()
                End Using

                ' Refresh the DataGridView
                LoadLogEntries()

                ' Clear input field
                txtLogID.Text = ""
                dtpSignOut.Value = DateTime.Now
                txtSignInName.Text = ""
                cmbRole.Text = ""
                txtSignOutName.Text = ""
                dtpSignIn.Value = DateTime.Now



            End If

        Catch ex As Exception
            MessageBox.Show("Error deleting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLogEntries()
        cmbRole.Items.AddRange(New String() {"Visitor", "Staff", "Admin"})

        picQRCode.Image = Nothing

        dgvLogEntries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        GroupBox1.Enabled = False
        GroupBox2.Enabled = False



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim mainmenu As New MainMenu
        mainmenu.Show()
        Me.Hide()


    End Sub

    Private Sub dgvLogEntries_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLogEntries.CellContentClick
        Try
            ' Get the selected row
            Dim rowIndex As Integer = e.RowIndex
            If rowIndex >= 0 Then
                ' Populate the Sign Out Section
                txtLogID.Text = dgvLogEntries.Rows(rowIndex).Cells(0).Value.ToString()
                txtSignOutName.Text = dgvLogEntries.Rows(rowIndex).Cells(1).Value.ToString()
                dtpSignOut.Text = dgvLogEntries.Rows(rowIndex).Cells(4).Value.ToString()
                txtSLogID.Text = dgvLogEntries.Rows(rowIndex).Cells(0).Value.ToString()
                txtSignInName.Text = dgvLogEntries.Rows(rowIndex).Cells(1).Value.ToString()
                cmbRole.Text = dgvLogEntries.Rows(rowIndex).Cells(2).Value.ToString()
                dtpSignIn.Text = dgvLogEntries.Rows(rowIndex).Cells(3).Value.ToString()

                ' ✅ Load the corresponding QR image if available
                Dim logID As String = dgvLogEntries.Rows(rowIndex).Cells(0).Value?.ToString().Trim()
                If Not String.IsNullOrWhiteSpace(logID) Then
                    Dim safeLogID As String = String.Join("_", logID.Split(IO.Path.GetInvalidFileNameChars()))
                    Dim qrFolder As String = "C:\LogbookQRs\"
                    Dim qrPath As String = IO.Path.Combine(qrFolder, $"QR_{safeLogID}.png")

                    If IO.File.Exists(qrPath) Then
                        ' Release previously loaded image first
                        If picQRCode.Image IsNot Nothing Then
                            picQRCode.Image.Dispose()
                            picQRCode.Image = Nothing
                        End If

                        ' Load new image
                        Using qrBitmap As New Bitmap(qrPath)
                            picQRCode.Image = New Bitmap(qrBitmap)
                        End Using
                        picQRCode.Refresh()
                    Else
                        picQRCode.Image = Nothing
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            ' Validate all required fields
            If txtSignInName.Text.Trim() = "" OrElse cmbRole.SelectedIndex = -1 OrElse dtpSignIn.Value = Nothing Then
                MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Connection string for XAMPP MySQL
            Dim connectionString As String = "Server=localhost;Database=logbookdb;Uid=root;Pwd=;"
            Dim query As String = "INSERT INTO log_entries (name, role, sign_in_time) VALUES (@name, @role, @sign_in_time)"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Prepare the SQL command
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", txtSignInName.Text.Trim())
                    cmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@sign_in_time", dtpSignIn.Value.ToString("yyyy-MM-dd HH:mm:ss"))

                    ' Execute the command
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Sign In successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using

                conn.Close()
            End Using

            ' Refresh the DataGridView
            LoadLogEntries()

            If dgvLogEntries.Rows.Count > 0 Then
                dgvLogEntries.ClearSelection()
                dgvLogEntries.Rows(dgvLogEntries.Rows.Count - 1).Selected = True
                dgvLogEntries.FirstDisplayedScrollingRowIndex = dgvLogEntries.Rows.Count - 1
            End If

            ' Clear input fields
            txtSignInName.Clear()
            cmbRole.SelectedIndex = -1
            dtpSignIn.Value = DateTime.Now

        Catch ex As Exception
            MessageBox.Show("Error signing in: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btmEdit_Click(sender As Object, e As EventArgs) Handles btmEdit.Click
        ' Toggle the enabled state
        Dim newState As Boolean = Not GroupBox1.Enabled

        GroupBox1.Enabled = newState
        GroupBox2.Enabled = newState

        ' Set the opposite state for the other buttons
        btnAdd.Enabled = Not newState
        btnDelete.Enabled = Not newState
        btnExit.Enabled = Not newState
        btnRegister.Enabled = Not newState
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If txtLogID.Text.Trim() = "" Then
                MessageBox.Show("Please select a record to sign out.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim updatedLogID As String = txtLogID.Text.Trim()

            ' Connection string for XAMPP MySQL
            Dim connectionString As String = "Server=localhost;Database=logbookdb;Uid=root;Pwd=;"
            Dim query As String = "UPDATE log_entries SET name = @name, sign_out_time = @sign_out_time WHERE log_id = @log_id"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Prepare the SQL command
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@log_id", txtLogID.Text.Trim())
                    cmd.Parameters.AddWithValue("@name", txtSignOutName.Text.Trim())
                    cmd.Parameters.AddWithValue("@sign_out_time", dtpSignOut.Value.ToString("yyyy-MM-dd HH:mm:ss"))

                    ' Execute the command
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Sign Out successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using

                conn.Close()
            End Using

            ' Refresh the DataGridView
            LoadLogEntries()

            For Each row As DataGridViewRow In dgvLogEntries.Rows
                If row.Cells("log_id").Value.ToString() = updatedLogID Then
                    dgvLogEntries.ClearSelection()
                    row.Selected = True
                    dgvLogEntries.FirstDisplayedScrollingRowIndex = row.Index
                    Exit For
                End If
            Next

            ' Clear input fields
            txtSLogID.Text = ""
            txtLogID.Text = ""
            txtSignInName.Text = ""
            txtSignOutName.Text = ""
            cmbRole.Text = ""
            dtpSignIn.Value = DateTime.Now
            dtpSignOut.Value = DateTime.Now

        Catch ex As Exception
            MessageBox.Show("Error signing out: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnUpdateSignIn_Click(sender As Object, e As EventArgs) Handles btnUpdateSignIn.Click
        Try
            If txtLogID.Text.Trim() = "" Then
                MessageBox.Show("Please select a record to sign out.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim updatedLogID As String = txtSLogID.Text.Trim()

            ' Connection string for XAMPP MySQL
            Dim connectionString As String = "Server=localhost;Database=logbookdb;Uid=root;Pwd=;"
            Dim query As String = "UPDATE log_entries SET name = @name, role = @role, sign_in_time = @sign_in_time WHERE log_id = @log_id"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Prepare the SQL command
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@log_id", txtLogID.Text.Trim())
                    cmd.Parameters.AddWithValue("@name", txtSignInName.Text.Trim())
                    cmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@sign_in_time", dtpSignOut.Value.ToString("yyyy-MM-dd HH:mm:ss"))

                    ' Execute the command
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record Succesfully Updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using

                conn.Close()
            End Using

            ' Refresh the DataGridView
            LoadLogEntries()

            For Each row As DataGridViewRow In dgvLogEntries.Rows
                If row.Cells("log_id").Value.ToString() = updatedLogID Then
                    dgvLogEntries.ClearSelection()
                    row.Selected = True
                    dgvLogEntries.FirstDisplayedScrollingRowIndex = row.Index
                    Exit For
                End If
            Next

            ' Clear input fields
            txtSLogID.Text = ""
            txtLogID.Text = ""
            txtSignInName.Text = ""
            txtSignOutName.Text = ""
            cmbRole.Text = ""
            dtpSignIn.Value = DateTime.Now
            dtpSignOut.Value = DateTime.Now

        Catch ex As Exception
            MessageBox.Show("Error signing out: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim connectionString As String = "Server=localhost;Database=logbookdb;Uid=root;Pwd=;"
            Dim searchQuery As String = "SELECT log_id, name, role, sign_in_time, sign_out_time FROM log_entries WHERE log_id LIKE @search OR name LIKE @search"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Using cmd As New MySqlCommand(searchQuery, conn)
                    cmd.Parameters.AddWithValue("@search", "%" & txtSearch.Text & "%")
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvLogEntries.DataSource = dt
                End Using
                conn.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error searching: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim ar As New AdminRegistration
        ar.Show()
        Me.Hide()
    End Sub

    Private Sub btnGenerateQR_Click(sender As Object, e As EventArgs) Handles btnGenerateQR.Click
        Try
            ' Folder to save QR images
            Dim qrFolder As String = "C:\LogbookQRs\"
            If Not Directory.Exists(qrFolder) Then
                Directory.CreateDirectory(qrFolder)
            End If

            If dgvLogEntries.Rows.Count = 0 Then
                MessageBox.Show("No records found in the table.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim generatedCount As Integer = 0
            Dim skippedCount As Integer = 0

            ' ✅ Loop through all rows in the DataGridView
            For Each row As DataGridViewRow In dgvLogEntries.Rows
                If Not row.IsNewRow Then
                    ' ✅ Fetch values for this row
                    Dim logID As String = row.Cells("log_id").Value?.ToString().Trim()
                    Dim name As String = row.Cells("name").Value?.ToString().Trim()
                    Dim role As String = row.Cells("role").Value?.ToString().Trim()
                    Dim signIn As String = row.Cells("sign_in_time").Value?.ToString().Trim()
                    Dim signOut As String = row.Cells("sign_out_time").Value?.ToString().Trim()

                    ' ✅ Skip if logID is empty
                    If String.IsNullOrWhiteSpace(logID) Then Continue For

                    ' ✅ Sanitize logID and define path
                    Dim safeLogID As String = String.Join("_", logID.Split(Path.GetInvalidFileNameChars()))
                    Dim filePath As String = Path.Combine(qrFolder, $"QR_{safeLogID}.png")

                    ' ✅ Skip this record if QR already exists
                    If File.Exists(filePath) Then
                        skippedCount += 1
                        Continue For
                    End If

                    ' ✅ Unique QR content per record
                    Dim qrText As String = $"Log ID: {logID}" & vbCrLf &
                                   $"Name: {name}" & vbCrLf &
                                   $"Role: {role}" & vbCrLf &
                                   $"Sign In: {signIn}" & vbCrLf &
                                   $"Sign Out: {signOut}"

                    ' ✅ Generate QR code for this record
                    Dim qrGenerator As New QRCodeGenerator()
                    Dim qrData = qrGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q)
                    Dim qrCode = New QRCode(qrData)
                    Dim qrImage As Bitmap = qrCode.GetGraphic(5)

                    ' ✅ Save image safely
                    qrImage.Save(filePath, Imaging.ImageFormat.Png)
                    generatedCount += 1
                End If
            Next

            ' ✅ Don't show or save last QR anymore
            picQRCode.Image = Nothing

            MessageBox.Show(
            $"QR codes generated: {generatedCount}" & vbCrLf &
            $"Skipped (already exist): {skippedCount}",
            "QR Generation Complete",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

            ' Auto-select the last row to trigger QR display
            If dgvLogEntries.Rows.Count > 0 Then
                dgvLogEntries.ClearSelection()
                dgvLogEntries.Rows(dgvLogEntries.Rows.Count - 1).Selected = True
                dgvLogEntries.FirstDisplayedScrollingRowIndex = dgvLogEntries.Rows.Count - 1
            End If


        Catch ex As Exception
            MessageBox.Show("Error generating QR codes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    Private Sub btnPrintQR_Click(sender As Object, e As EventArgs) Handles btnPrintQR.Click
        If picQRCode.Image IsNot Nothing Then
            PrintPreviewDialogQR.Document = PrintDocumentQR
            PrintPreviewDialogQR.ShowDialog()
        Else
            MessageBox.Show("Please generate a QR code first.", "No QR Code", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub PrintDocumentQR_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocumentQR.PrintPage
        ' Define the size and position to draw the image
        Dim x As Integer = 120
        Dim y As Integer = 120
        Dim width As Integer = 600
        Dim height As Integer = 600

        e.Graphics.DrawImage(picQRCode.Image, New Rectangle(x, y, width, height))
    End Sub

    Private Sub txtSignInName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSignInName.KeyDown
        If (e.KeyCode = 13) Then
            cmbRole.Focus()
        End If
    End Sub

    Private Sub cmbRole_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbRole.KeyDown
        If (e.KeyCode = 13) Then
            dtpSignIn.Focus()
        End If
    End Sub

    Private Sub dtpSignIn_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpSignIn.KeyDown
        If (e.KeyCode = 13) Then
            btnUpdateSignIn.Focus()
        End If
    End Sub

    Private Sub txtSignOutName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSignOutName.KeyDown
        If (e.KeyCode = 13) Then
            dtpSignOut.Focus()
        End If
    End Sub

    Private Sub dtpSignOut_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpSignOut.KeyDown
        If (e.KeyCode = 13) Then
            btnUpdate.Focus()
        End If
    End Sub
End Class