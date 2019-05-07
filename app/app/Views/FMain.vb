Imports System.ComponentModel

Public Class FMain

    Private app As New AppSession

    Private sessionSetting As Models.Setting
    Private IncomingEmail As Models.InEmail
    Private OutgoingEmail As Models.OutEmail

    Private onIdle As String = "Idle"
    Private onReadingEmailtoSend As String = "Reading email to send"
    Private onSendingEmail As String = "Sending email"
    Private onDownloadEmailFromMailServer As String = "Download email from Mail Server"
    Private onEnable As String = "Enable"
    Private onDisable As String = "Disable"
    Private onOn As String = "On"
    Private onOff As String = "Off"
    Private InEmailIsNothing As String = "There no email to download from Email Server"

    Private intervalTimer_Max As Integer = 5
    Private DummyData As String = Nothing
    Private intervalTimer As Integer = 0

    Private ID As Integer

    Private Sub BlankLabel()

        lblAccountIN.Text = Nothing
        lblAccountOUT.Text = Nothing
        lblServices.Text = Nothing
        lblTimer.Text = Nothing
        lblBackgroundworker.Text = Nothing
        lblSync.Text = Nothing
        Label5.Text = Nothing
    End Sub

    Private Sub FMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BlankLabel()

        Timer1.Interval = 1000

        CheckForIllegalCrossThreadCalls = False

        LoadSessionSettings()

        MonitioringActivity(True)

    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        MonitioringActivity(False)
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        MonitioringActivity(True)
    End Sub

    Private Sub MonitioringActivity(ByVal StartService As Boolean)

        If StartService = True Then
            lblServices.Text = onEnable
            lblSync.Text = ""
        Else
            lblServices.Text = onDisable
            lblSync.Text = ""

            If BackgroundWorker1.IsBusy Then

                If BackgroundWorker1.WorkerSupportsCancellation Then
                    BackgroundWorker1.CancelAsync()
                End If

            End If

        End If

        BtnStart.Enabled = Not StartService
        BtnStop.Enabled = StartService


    End Sub


    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        RetriveEmail()
        StoreEmailIntoDatabase()
        LoadEmailWillSend()
        SendEmail()
    End Sub

    Private Sub SentOK()

    End Sub
    Private Sub LoadEmailWillSend()

        OutgoingEmail = New Models.OutEmail

        lblSync.Text = onReadingEmailtoSend

        Try

            OutgoingEmail.ListData = app.EmailOUT.LoadEmail(sessionSetting)

            If app.EmailOUT.TotalEmail > 0 Then

                For Each item In OutgoingEmail.ListData

                    OutgoingEmail.ID = item.ID
                    OutgoingEmail.EFROM = item.EFROM
                    OutgoingEmail.ETO = item.ETO
                    OutgoingEmail.ECC = item.ECC
                    OutgoingEmail.EBCC = item.EBCC
                    OutgoingEmail.ESUBJECT = item.ESUBJECT
                    OutgoingEmail.EBODYTEXT = item.EBODYTEXT
                    OutgoingEmail.EBODYHTML = item.EBODYHTML
                    OutgoingEmail.EATTACHMENT = item.EATTACHMENT

                Next

            End If

        Catch ConnectionException As AppException.ConnectionException

            Label5.Text = ConnectionException.Message

            LogIt("FMain.LoadEmailWillSend.ConnectionException", ConnectionException.Message)

        Catch EmailOUTException As AppException.EmailOUTException

            Label5.Text = EmailOUTException.Message

            LogIt("FMain.LoadEmailWillSend.EmailOUTException", EmailOUTException.Message)

        End Try

    End Sub

    Private Sub SendEmail()

        If app.EmailOUT.TotalEmail > 0 Then

            lblSync.Text = onSendingEmail

            Try

                Dim result As String = app.EmailOUT.Send(sessionSetting, OutgoingEmail)

                If result = 1 Then

                    app.EmailSent.EmailID(sessionSetting, OutgoingEmail.ID)

                End If

            Catch ConnectionException As AppException.ConnectionException

                Label5.Text = ConnectionException.Message

                LogIt("FMain.SendEmail.ConnectionException", ConnectionException.Message)

            Catch EmailSentException As AppException.EmailSentException

                Label5.Text = EmailSentException.Message

                LogIt("FMain.SendEmail.EmailSentException", EmailSentException.Message)

            End Try

        End If

    End Sub

    Private Sub StoreEmailIntoDatabase()

        lblSync.Text = onDownloadEmailFromMailServer

        If app.EmailIN.TotalEmail > 0 Then

            Try

                app.EmailIN.StoreEmailINIntoDatabase(sessionSetting, IncomingEmail)
                app.EmailIN.StoreAttachmentIntoDatabase(sessionSetting, IncomingEmail)

            Catch connException As AppException.ConnectionException

                Label5.Text = connException.Message

                LogIt("FMain.StoreEmailIntoDatabase.connException", connException.Message)

            Catch EmailINException As AppException.EmailINException


                Label5.Text = EmailINException.Message

                LogIt("FMain.StoreEmailIntoDatabase.EmailINException", EmailINException.Message)

            End Try

        End If

    End Sub

    Private Sub LoadSessionSettings()

        sessionSetting = New Models.Setting

        Try

            sessionSetting.ListData = app.Setting.LoadSetting()

            If app.Setting.IsSettingExisting = True Then

                For Each item In sessionSetting.ListData

                    sessionSetting.ServerAddress = item.ServerAddress
                    sessionSetting.ServerDatabase = item.ServerDatabase
                    sessionSetting.ServerUserLogin = item.ServerUserLogin
                    sessionSetting.ServerPassword = item.ServerPassword

                    sessionSetting.IncomingAccountName = item.IncomingAccountName
                    sessionSetting.IncomingPassword = item.IncomingPassword
                    sessionSetting.IncomingPort = item.IncomingPort
                    sessionSetting.IncomingServer = item.IncomingServer
                    sessionSetting.EncryptedConnection = item.EncryptedConnection

                    sessionSetting.OutgoingAccountName = item.OutgoingAccountName
                    sessionSetting.OutgoingPassword = item.OutgoingPassword
                    sessionSetting.OutgoingServer = item.OutgoingServer
                    sessionSetting.OutgoingPort = item.OutgoingPort

                    sessionSetting.LeaveEmailOnServer = item.LeaveEmailOnServer

                    sessionSetting.IncomingBackUp = item.IncomingBackUp
                    sessionSetting.OutgoingBackUp = item.OutgoingBackUp

                Next

                lblAccountIN.Text = sessionSetting.IncomingAccountName
                lblAccountOUT.Text = sessionSetting.OutgoingAccountName

            Else

            End If

        Catch SettingsException As AppException.SettingsException

            Label5.Text = SettingsException.Message

            LogIt("FMain.LoadSessionSettings.SettingsException", SettingsException.Message)

        End Try

    End Sub

    Private Sub RetriveEmail()

        lblSync.Text = onDownloadEmailFromMailServer

        IncomingEmail = New Models.InEmail

        Try

            IncomingEmail.ListData = app.EmailIN.GetDataPop3(sessionSetting.IncomingServer, sessionSetting.IncomingAccountName, sessionSetting.IncomingPassword, sessionSetting.IncomingPort, sessionSetting.LeaveEmailOnServer, sessionSetting.IncomingBackUp)

            If (app.EmailIN.IsEmptyEmail = False) Then

                If app.EmailIN.TotalEmail > 0 Then

                    For Each i In IncomingEmail.ListData

                        If Not (i.EmailID = Nothing) Then

                            IncomingEmail.EmailID = i.EmailID
                            IncomingEmail.EmailFrom = i.EmailFrom
                            IncomingEmail.EmailTo = i.EmailTo
                            IncomingEmail.EmailCc = i.EmailCc
                            IncomingEmail.EmailBcc = i.EmailBcc
                            IncomingEmail.EmailSubject = i.EmailSubject
                            IncomingEmail.EmailBodyText = i.EmailBodyText
                            IncomingEmail.EmailBodyHtml = i.EmailBodyHtml
                            IncomingEmail.EmailSentDate = i.EmailSentDate
                            IncomingEmail.EmailSize = i.EmailSize
                            IncomingEmail.Attachment = i.Attachment

                        End If

                    Next

                Else
                    Label5.Text = InEmailIsNothing
                End If

            Else

            End If

            'If (app.EmailIN.TotalEmail) = ID Then
            '    ID = 0
            'Else
            '    ID = ID + 1
            'End If

            'lblSync.Text = app.EmailRetrieve.outputMessage.ToString()
            Label5.Text = app.EmailIN.TotalEmail & " - " & IncomingEmail.EmailSubject

        Catch connException As AppException.ConnectionException

            Label5.Text = connException.Message

            LogIt("FMain.RetriveEmail.connException", connException.Message)

        Catch EmailINException As AppException.EmailINException

            Label5.Text = EmailINException.Message

            LogIt("FMain.RetriveEmail.EmailINException", EmailINException.Message)

        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If intervalTimer_Max > intervalTimer Then

            lblSync.Text = onOn

            intervalTimer = intervalTimer + 1

        End If

        If intervalTimer_Max = intervalTimer Then

            intervalTimer = 0

            Timer1.Enabled = False

            BackgroundWorker1.RunWorkerAsync()

        End If
    End Sub

    Private Sub lblServices_TextChanged(sender As Object, e As EventArgs) Handles lblServices.TextChanged
        'is enanble
        If lblServices.Text = onEnable Then
            lblTimer.Text = onOn
        End If

        'is disable
        If lblServices.Text = onDisable Then
            lblTimer.Text = onOff
        End If

    End Sub

    Private Sub lblTimer_TextChanged(sender As Object, e As EventArgs) Handles lblTimer.TextChanged
        'on
        If lblTimer.Text = onOn Then
            lblBackgroundworker.Text = onOn
            Timer1.Enabled = True
        End If

        'off
        If lblTimer.Text = onOff Then
            lblBackgroundworker.Text = onOff
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Timer1.Enabled = True
    End Sub

    Private Sub FMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        System.Windows.Forms.Application.Exit()
    End Sub
End Class