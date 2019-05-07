<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMain
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
        Me.components = New System.ComponentModel.Container()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblServices = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblBackgroundworker = New System.Windows.Forms.Label()
        Me.lblSync = New System.Windows.Forms.Label()
        Me.lblAccountOUT = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblAccountIN = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnStart
        '
        Me.BtnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnStart.Location = New System.Drawing.Point(187, 232)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(75, 23)
        Me.BtnStart.TabIndex = 0
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'BtnStop
        '
        Me.BtnStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnStop.Location = New System.Drawing.Point(106, 232)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(75, 23)
        Me.BtnStop.TabIndex = 1
        Me.BtnStop.Text = "Stop"
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Services"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Timer"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(11, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Backgroundworker"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(11, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Sync"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(11, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(250, 56)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "valuenull"
        '
        'lblServices
        '
        Me.lblServices.Location = New System.Drawing.Point(111, 54)
        Me.lblServices.Name = "lblServices"
        Me.lblServices.Size = New System.Drawing.Size(150, 23)
        Me.lblServices.TabIndex = 7
        Me.lblServices.Text = "valuenull"
        '
        'lblTimer
        '
        Me.lblTimer.Location = New System.Drawing.Point(111, 77)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(150, 23)
        Me.lblTimer.TabIndex = 8
        Me.lblTimer.Text = "valuenull"
        '
        'lblBackgroundworker
        '
        Me.lblBackgroundworker.Location = New System.Drawing.Point(111, 100)
        Me.lblBackgroundworker.Name = "lblBackgroundworker"
        Me.lblBackgroundworker.Size = New System.Drawing.Size(150, 23)
        Me.lblBackgroundworker.TabIndex = 9
        Me.lblBackgroundworker.Text = "valuenull"
        '
        'lblSync
        '
        Me.lblSync.Location = New System.Drawing.Point(111, 123)
        Me.lblSync.Name = "lblSync"
        Me.lblSync.Size = New System.Drawing.Size(150, 23)
        Me.lblSync.TabIndex = 10
        Me.lblSync.Text = "valuenull"
        '
        'lblAccountOUT
        '
        Me.lblAccountOUT.Location = New System.Drawing.Point(111, 31)
        Me.lblAccountOUT.Name = "lblAccountOUT"
        Me.lblAccountOUT.Size = New System.Drawing.Size(150, 23)
        Me.lblAccountOUT.TabIndex = 12
        Me.lblAccountOUT.Text = "valuenull"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(11, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Account (Outgoing)"
        '
        'lblAccountIN
        '
        Me.lblAccountIN.Location = New System.Drawing.Point(112, 8)
        Me.lblAccountIN.Name = "lblAccountIN"
        Me.lblAccountIN.Size = New System.Drawing.Size(150, 23)
        Me.lblAccountIN.TabIndex = 14
        Me.lblAccountIN.Text = "valuenull"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(11, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Account (Incoming)"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lblAccountIN)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblAccountOUT)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblSync)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblBackgroundworker)
        Me.Panel1.Controls.Add(Me.lblServices)
        Me.Panel1.Controls.Add(Me.lblTimer)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(270, 219)
        Me.Panel1.TabIndex = 15
        '
        'FMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 267)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.BtnStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Email Gateway"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnStart As System.Windows.Forms.Button
    Friend WithEvents BtnStop As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblServices As System.Windows.Forms.Label
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents lblBackgroundworker As System.Windows.Forms.Label
    Friend WithEvents lblSync As System.Windows.Forms.Label
    Friend WithEvents lblAccountOUT As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblAccountIN As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
End Class
