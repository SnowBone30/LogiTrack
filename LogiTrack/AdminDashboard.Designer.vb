<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtLogID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpSignOut = New System.Windows.Forms.DateTimePicker()
        Me.txtSignOutName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btmEdit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpSignIn = New System.Windows.Forms.DateTimePicker()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSLogID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnUpdateSignIn = New System.Windows.Forms.Button()
        Me.txtSignInName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvLogEntries = New System.Windows.Forms.DataGridView()
        Me.picQRCode = New System.Windows.Forms.PictureBox()
        Me.btnGenerateQR = New System.Windows.Forms.Button()
        Me.btnPrintQR = New System.Windows.Forms.Button()
        Me.PrintPreviewDialogQR = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocumentQR = New System.Drawing.Printing.PrintDocument()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvLogEntries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.SlateGray
        Me.btnExit.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(39, 472)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtLogID
        '
        Me.txtLogID.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogID.Location = New System.Drawing.Point(90, 24)
        Me.txtLogID.Name = "txtLogID"
        Me.txtLogID.Size = New System.Drawing.Size(51, 22)
        Me.txtLogID.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(39, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "log ID:"
        '
        'dtpSignOut
        '
        Me.dtpSignOut.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSignOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSignOut.Location = New System.Drawing.Point(87, 86)
        Me.dtpSignOut.Name = "dtpSignOut"
        Me.dtpSignOut.Size = New System.Drawing.Size(121, 22)
        Me.dtpSignOut.TabIndex = 10
        '
        'txtSignOutName
        '
        Me.txtSignOutName.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSignOutName.ForeColor = System.Drawing.Color.Black
        Me.txtSignOutName.Location = New System.Drawing.Point(90, 58)
        Me.txtSignOutName.Name = "txtSignOutName"
        Me.txtSignOutName.Size = New System.Drawing.Size(251, 22)
        Me.txtSignOutName.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(16, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Full Name:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnRegister)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.btmEdit)
        Me.Panel2.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.Panel2.Location = New System.Drawing.Point(28, 465)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(864, 34)
        Me.Panel2.TabIndex = 16
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.SlateGray
        Me.btnRegister.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(757, 7)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(104, 23)
        Me.btnRegister.TabIndex = 16
        Me.btnRegister.Text = "Create Account"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.SlateGray
        Me.btnDelete.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(647, 7)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(104, 23)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.SlateGray
        Me.btnAdd.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(538, 7)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 23)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btmEdit
        '
        Me.btmEdit.BackColor = System.Drawing.Color.SlateGray
        Me.btmEdit.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.btmEdit.ForeColor = System.Drawing.Color.White
        Me.btmEdit.Location = New System.Drawing.Point(429, 7)
        Me.btmEdit.Name = "btmEdit"
        Me.btmEdit.Size = New System.Drawing.Size(104, 23)
        Me.btmEdit.TabIndex = 14
        Me.btmEdit.Text = "Edit"
        Me.btmEdit.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.SlateGray
        Me.btnUpdate.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(237, 153)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(104, 23)
        Me.btnUpdate.TabIndex = 13
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Controls.Add(Me.txtLogID)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.dtpSignOut)
        Me.GroupBox2.Controls.Add(Me.txtSignOutName)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(396, 278)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(347, 182)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sign Out Section"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(78, 51)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(257, 22)
        Me.txtSearch.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(28, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Search:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 15.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(38, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 23)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "LogiTrack"
        '
        'dtpSignIn
        '
        Me.dtpSignIn.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSignIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSignIn.Location = New System.Drawing.Point(95, 114)
        Me.dtpSignIn.Name = "dtpSignIn"
        Me.dtpSignIn.Size = New System.Drawing.Size(121, 22)
        Me.dtpSignIn.TabIndex = 10
        '
        'cmbRole
        '
        Me.cmbRole.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Location = New System.Drawing.Point(95, 87)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(121, 21)
        Me.cmbRole.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSLogID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnUpdateSignIn)
        Me.GroupBox1.Controls.Add(Me.dtpSignIn)
        Me.GroupBox1.Controls.Add(Me.cmbRole)
        Me.GroupBox1.Controls.Add(Me.txtSignInName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(28, 278)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 182)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sign In Section"
        '
        'txtSLogID
        '
        Me.txtSLogID.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSLogID.Location = New System.Drawing.Point(95, 25)
        Me.txtSLogID.Name = "txtSLogID"
        Me.txtSLogID.Size = New System.Drawing.Size(51, 22)
        Me.txtSLogID.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(44, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "log ID:"
        '
        'btnUpdateSignIn
        '
        Me.btnUpdateSignIn.BackColor = System.Drawing.Color.SlateGray
        Me.btnUpdateSignIn.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.btnUpdateSignIn.ForeColor = System.Drawing.Color.White
        Me.btnUpdateSignIn.Location = New System.Drawing.Point(238, 153)
        Me.btnUpdateSignIn.Name = "btnUpdateSignIn"
        Me.btnUpdateSignIn.Size = New System.Drawing.Size(104, 23)
        Me.btnUpdateSignIn.TabIndex = 14
        Me.btnUpdateSignIn.Text = "Update"
        Me.btnUpdateSignIn.UseVisualStyleBackColor = False
        '
        'txtSignInName
        '
        Me.txtSignInName.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSignInName.Location = New System.Drawing.Point(97, 58)
        Me.txtSignInName.Name = "txtSignInName"
        Me.txtSignInName.Size = New System.Drawing.Size(245, 22)
        Me.txtSignInName.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(52, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Role:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(23, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Full Name:"
        '
        'dgvLogEntries
        '
        Me.dgvLogEntries.AllowUserToAddRows = False
        Me.dgvLogEntries.AllowUserToDeleteRows = False
        Me.dgvLogEntries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.dgvLogEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLogEntries.Location = New System.Drawing.Point(28, 77)
        Me.dgvLogEntries.Name = "dgvLogEntries"
        Me.dgvLogEntries.ReadOnly = True
        Me.dgvLogEntries.RowHeadersWidth = 62
        Me.dgvLogEntries.Size = New System.Drawing.Size(861, 194)
        Me.dgvLogEntries.TabIndex = 10
        '
        'picQRCode
        '
        Me.picQRCode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.picQRCode.Image = CType(resources.GetObject("picQRCode.Image"), System.Drawing.Image)
        Me.picQRCode.Location = New System.Drawing.Point(749, 284)
        Me.picQRCode.Name = "picQRCode"
        Me.picQRCode.Size = New System.Drawing.Size(140, 117)
        Me.picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picQRCode.TabIndex = 17
        Me.picQRCode.TabStop = False
        '
        'btnGenerateQR
        '
        Me.btnGenerateQR.BackColor = System.Drawing.Color.SlateGray
        Me.btnGenerateQR.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.btnGenerateQR.ForeColor = System.Drawing.Color.White
        Me.btnGenerateQR.Location = New System.Drawing.Point(749, 436)
        Me.btnGenerateQR.Name = "btnGenerateQR"
        Me.btnGenerateQR.Size = New System.Drawing.Size(143, 23)
        Me.btnGenerateQR.TabIndex = 14
        Me.btnGenerateQR.Text = "Generate QR"
        Me.btnGenerateQR.UseVisualStyleBackColor = False
        '
        'btnPrintQR
        '
        Me.btnPrintQR.BackColor = System.Drawing.Color.SlateGray
        Me.btnPrintQR.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.btnPrintQR.ForeColor = System.Drawing.Color.White
        Me.btnPrintQR.Location = New System.Drawing.Point(749, 407)
        Me.btnPrintQR.Name = "btnPrintQR"
        Me.btnPrintQR.Size = New System.Drawing.Size(143, 23)
        Me.btnPrintQR.TabIndex = 18
        Me.btnPrintQR.Text = "Print QR"
        Me.btnPrintQR.UseVisualStyleBackColor = False
        '
        'PrintPreviewDialogQR
        '
        Me.PrintPreviewDialogQR.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogQR.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogQR.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialogQR.Enabled = True
        Me.PrintPreviewDialogQR.Icon = CType(resources.GetObject("PrintPreviewDialogQR.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialogQR.Name = "PrintPreviewDialogQR"
        Me.PrintPreviewDialogQR.Visible = False
        '
        'PrintDocumentQR
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(920, 516)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnPrintQR)
        Me.Controls.Add(Me.btnGenerateQR)
        Me.Controls.Add(Me.picQRCode)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvLogEntries)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AdminDashboard"
        Me.Text = "AdminDashboard"
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvLogEntries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents txtLogID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpSignOut As DateTimePicker
    Friend WithEvents txtSignOutName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpSignIn As DateTimePicker
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSignInName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvLogEntries As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btmEdit As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdateSignIn As Button
    Friend WithEvents txtSLogID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents picQRCode As PictureBox
    Friend WithEvents btnGenerateQR As Button
    Friend WithEvents btnPrintQR As Button
    Friend WithEvents PrintPreviewDialogQR As PrintPreviewDialog
    Friend WithEvents PrintDocumentQR As Printing.PrintDocument
    Friend WithEvents PictureBox1 As PictureBox
End Class
