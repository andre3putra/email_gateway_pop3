<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FSetting
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtIncomingBackUp = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbLeaveEmail = New System.Windows.Forms.CheckBox()
        Me.cbEncryptedConnection = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIncomingPort = New System.Windows.Forms.NumericUpDown()
        Me.txtIncomingServer = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIncomingPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIncomingAccountName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.txtOutgoingBackUp = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtOutgoingPort = New System.Windows.Forms.NumericUpDown()
        Me.txtOutgoingServer = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtOutgoingPassword = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtOutgoingAccountName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TxtServerPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtServerLogin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtServerDatabase = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtServerAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.txtIncomingPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.txtOutgoingPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(250, 279)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(169, 279)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(333, 271)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TabControl2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(325, 245)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Email"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(3, 3)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(319, 239)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtIncomingBackUp)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.cbLeaveEmail)
        Me.TabPage3.Controls.Add(Me.cbEncryptedConnection)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.txtIncomingPort)
        Me.TabPage3.Controls.Add(Me.txtIncomingServer)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.txtIncomingPassword)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.txtIncomingAccountName)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(311, 213)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Incoming"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtIncomingBackUp
        '
        Me.txtIncomingBackUp.Location = New System.Drawing.Point(103, 109)
        Me.txtIncomingBackUp.Name = "txtIncomingBackUp"
        Me.txtIncomingBackUp.Size = New System.Drawing.Size(202, 20)
        Me.txtIncomingBackUp.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Drive Backup"
        '
        'cbLeaveEmail
        '
        Me.cbLeaveEmail.AutoSize = True
        Me.cbLeaveEmail.Location = New System.Drawing.Point(9, 178)
        Me.cbLeaveEmail.Name = "cbLeaveEmail"
        Me.cbLeaveEmail.Size = New System.Drawing.Size(130, 17)
        Me.cbLeaveEmail.TabIndex = 11
        Me.cbLeaveEmail.Text = "Leave email on server"
        Me.cbLeaveEmail.UseVisualStyleBackColor = True
        '
        'cbEncryptedConnection
        '
        Me.cbEncryptedConnection.AutoSize = True
        Me.cbEncryptedConnection.Location = New System.Drawing.Point(9, 155)
        Me.cbEncryptedConnection.Name = "cbEncryptedConnection"
        Me.cbEncryptedConnection.Size = New System.Drawing.Size(291, 17)
        Me.cbEncryptedConnection.TabIndex = 10
        Me.cbEncryptedConnection.Text = "This server requres an encrypted connection (SSL/TLS)"
        Me.cbEncryptedConnection.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Port"
        '
        'txtIncomingPort
        '
        Me.txtIncomingPort.Location = New System.Drawing.Point(103, 83)
        Me.txtIncomingPort.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtIncomingPort.Name = "txtIncomingPort"
        Me.txtIncomingPort.Size = New System.Drawing.Size(55, 20)
        Me.txtIncomingPort.TabIndex = 8
        '
        'txtIncomingServer
        '
        Me.txtIncomingServer.Location = New System.Drawing.Point(103, 57)
        Me.txtIncomingServer.Name = "txtIncomingServer"
        Me.txtIncomingServer.Size = New System.Drawing.Size(202, 20)
        Me.txtIncomingServer.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Server"
        '
        'txtIncomingPassword
        '
        Me.txtIncomingPassword.Location = New System.Drawing.Point(103, 31)
        Me.txtIncomingPassword.Name = "txtIncomingPassword"
        Me.txtIncomingPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtIncomingPassword.Size = New System.Drawing.Size(202, 20)
        Me.txtIncomingPassword.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Password"
        '
        'txtIncomingAccountName
        '
        Me.txtIncomingAccountName.Location = New System.Drawing.Point(103, 5)
        Me.txtIncomingAccountName.Name = "txtIncomingAccountName"
        Me.txtIncomingAccountName.Size = New System.Drawing.Size(202, 20)
        Me.txtIncomingAccountName.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Account name"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.txtOutgoingBackUp)
        Me.TabPage4.Controls.Add(Me.Label14)
        Me.TabPage4.Controls.Add(Me.Label9)
        Me.TabPage4.Controls.Add(Me.txtOutgoingPort)
        Me.TabPage4.Controls.Add(Me.txtOutgoingServer)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.txtOutgoingPassword)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.txtOutgoingAccountName)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(311, 213)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Outgoing"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'txtOutgoingBackUp
        '
        Me.txtOutgoingBackUp.Location = New System.Drawing.Point(103, 109)
        Me.txtOutgoingBackUp.Name = "txtOutgoingBackUp"
        Me.txtOutgoingBackUp.Size = New System.Drawing.Size(202, 20)
        Me.txtOutgoingBackUp.TabIndex = 19
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Drive Backup"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Port"
        '
        'txtOutgoingPort
        '
        Me.txtOutgoingPort.Location = New System.Drawing.Point(103, 83)
        Me.txtOutgoingPort.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtOutgoingPort.Name = "txtOutgoingPort"
        Me.txtOutgoingPort.Size = New System.Drawing.Size(55, 20)
        Me.txtOutgoingPort.TabIndex = 16
        '
        'txtOutgoingServer
        '
        Me.txtOutgoingServer.Location = New System.Drawing.Point(103, 57)
        Me.txtOutgoingServer.Name = "txtOutgoingServer"
        Me.txtOutgoingServer.Size = New System.Drawing.Size(202, 20)
        Me.txtOutgoingServer.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Server"
        '
        'txtOutgoingPassword
        '
        Me.txtOutgoingPassword.Location = New System.Drawing.Point(103, 31)
        Me.txtOutgoingPassword.Name = "txtOutgoingPassword"
        Me.txtOutgoingPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOutgoingPassword.Size = New System.Drawing.Size(202, 20)
        Me.txtOutgoingPassword.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Password"
        '
        'txtOutgoingAccountName
        '
        Me.txtOutgoingAccountName.Location = New System.Drawing.Point(103, 5)
        Me.txtOutgoingAccountName.Name = "txtOutgoingAccountName"
        Me.txtOutgoingAccountName.Size = New System.Drawing.Size(202, 20)
        Me.txtOutgoingAccountName.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Account name"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TxtServerPassword)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.TxtServerLogin)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.TxtServerDatabase)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtServerAddress)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(325, 245)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Server"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TxtServerPassword
        '
        Me.TxtServerPassword.Location = New System.Drawing.Point(104, 84)
        Me.TxtServerPassword.Name = "TxtServerPassword"
        Me.TxtServerPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtServerPassword.Size = New System.Drawing.Size(211, 20)
        Me.TxtServerPassword.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Password"
        '
        'TxtServerLogin
        '
        Me.TxtServerLogin.Location = New System.Drawing.Point(104, 58)
        Me.TxtServerLogin.Name = "TxtServerLogin"
        Me.TxtServerLogin.Size = New System.Drawing.Size(211, 20)
        Me.TxtServerLogin.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "User login"
        '
        'TxtServerDatabase
        '
        Me.TxtServerDatabase.Location = New System.Drawing.Point(104, 32)
        Me.TxtServerDatabase.Name = "TxtServerDatabase"
        Me.TxtServerDatabase.Size = New System.Drawing.Size(211, 20)
        Me.TxtServerDatabase.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Database"
        '
        'txtServerAddress
        '
        Me.txtServerAddress.Location = New System.Drawing.Point(104, 6)
        Me.txtServerAddress.Name = "txtServerAddress"
        Me.txtServerAddress.Size = New System.Drawing.Size(211, 20)
        Me.txtServerAddress.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Address"
        '
        'FSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 314)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FSetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.txtIncomingPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.txtOutgoingPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TxtServerPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtServerLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtServerDatabase As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtServerAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIncomingAccountName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtIncomingPort As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtIncomingServer As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtIncomingPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbEncryptedConnection As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtOutgoingPort As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtOutgoingServer As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtOutgoingPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtOutgoingAccountName As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbLeaveEmail As System.Windows.Forms.CheckBox
    Friend WithEvents txtIncomingBackUp As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtOutgoingBackUp As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
