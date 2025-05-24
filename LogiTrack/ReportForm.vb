Imports System.Drawing
Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient


Public Class ReportForm

    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpStartDate.Value = DateTime.Today.AddDays(-7)
        dtpEndDate.Value = DateTime.Today
        LoadReportData()
        dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub LoadReportData(Optional ByVal fromDate As DateTime = Nothing, Optional ByVal toDate As DateTime = Nothing)
        Dim connString As String = "Server=localhost;Database=logbookdb;Uid=root;Pwd=;"
        Dim query As String = "SELECT log_id, name, role, sign_in_time, sign_out_time FROM log_entries"

        If fromDate <> DateTime.MinValue AndAlso toDate <> DateTime.MinValue Then
            query &= " WHERE sign_in_time BETWEEN @from AND @to"
        End If

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    If fromDate <> DateTime.MinValue AndAlso toDate <> DateTime.MinValue Then
                        cmd.Parameters.AddWithValue("@from", fromDate.ToString("yyyy-MM-dd 00:00:00"))
                        cmd.Parameters.AddWithValue("@to", toDate.ToString("yyyy-MM-dd 23:59:59"))
                    End If

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvReport.DataSource = dt
                End Using
                conn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message)
        End Try
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        LoadReportData(dtpStartDate.Value.Date, dtpEndDate.Value.Date)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        LoadReportData()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
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
                    dgvReport.DataSource = dt
                End Using
                conn.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error searching: " & ex.Message)
        End Try
    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' Configure the print preview dialog
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Arial", 10)
        Dim x As Integer = 50
        Dim y As Integer = 100
        Dim rowHeight As Integer = 30

        ' Headers
        For Each column As DataGridViewColumn In dgvReport.Columns
            e.Graphics.DrawString(column.HeaderText, font, Brushes.Black, x, y)
            x += column.Width
        Next

        y += rowHeight
        x = 50

        ' Rows
        For Each row As DataGridViewRow In dgvReport.Rows
            If Not row.IsNewRow Then
                For Each cell As DataGridViewCell In row.Cells
                    e.Graphics.DrawString(cell.Value?.ToString(), font, Brushes.Black, x, y)
                    x += dgvReport.Columns(cell.ColumnIndex).Width
                Next
                y += rowHeight
                x = 50
            End If
        Next

        ' NOTE: You can set e.HasMorePages = True here if you want to support multi-page printing.
    End Sub


End Class