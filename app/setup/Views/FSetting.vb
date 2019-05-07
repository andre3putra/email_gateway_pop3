Public Class FSetting

    Private app As New AppSession

    Private Sub FSetting_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub FSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dataSetting = New Models.Setting

        Try
            dataSetting.ListData = app.Setting.LoadSetting()

            If app.Setting.IsSettingExisting = True Then

                For Each item In dataSetting.ListData

                    txtServerAddress.Text = item.ServerAddress
                    TxtServerDatabase.Text = item.ServerDatabase
                    TxtServerLogin.Text = item.ServerUserLogin
                    TxtServerPassword.Text = item.ServerPassword

                    txtIncomingAccountName.Text = item.IncomingAccountName
                    txtIncomingPassword.Text = item.IncomingPassword
                    txtIncomingPort.Value = item.IncomingPort
                    txtIncomingServer.Text = item.IncomingServer
                    cbEncryptedConnection.Checked = item.EncryptedConnection

                    txtOutgoingAccountName.Text = item.OutgoingAccountName
                    txtOutgoingPassword.Text = item.OutgoingPassword
                    txtOutgoingServer.Text = item.OutgoingServer
                    txtOutgoingPort.Value = item.OutgoingPort

                    cbLeaveEmail.Checked = item.LeaveEmailOnServer

                    txtIncomingBackUp.Text = item.IncomingBackUp
                    txtOutgoingBackUp.Text = item.OutgoingBackUp

                Next

            Else

                BlankFields()

            End If

        Catch SettingsException As AppException.SettingsException

            MsgBox("Setting Exception : " & SettingsException.Message)

            LogIt("FSetting.MyBase.Load.SettingsException", SettingsException.Message)

        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        If IsBlank() = True Then
            Exit Sub
        End If

        Try

            Dim dataSetting = New Models.Setting

            With dataSetting

                .ServerAddress = txtServerAddress.Text
                .ServerDatabase = TxtServerDatabase.Text
                .ServerUserLogin = TxtServerLogin.Text
                .ServerPassword = TxtServerPassword.Text

                .IncomingAccountName = txtIncomingAccountName.Text
                .IncomingPassword = txtIncomingPassword.Text
                .IncomingServer = txtIncomingServer.Text
                .IncomingPort = txtIncomingPort.Value
                .EncryptedConnection = cbEncryptedConnection.Checked

                .OutgoingAccountName = txtOutgoingAccountName.Text
                .OutgoingPassword = txtOutgoingPassword.Text
                .OutgoingServer = txtOutgoingServer.Text
                .OutgoingPort = txtOutgoingPort.Value

                .LeaveEmailOnServer = cbLeaveEmail.Checked

                .IncomingBackUp = txtIncomingBackUp.Text
                .OutgoingBackUp = txtOutgoingBackUp.Text

            End With

            app.Setting.SetupSetting(dataSetting)

            Me.Visible = False
            Me.Close()

        Catch SettingsException As AppException.SettingsException

            MsgBox("SettingsException : " & SettingsException.Message)

            LogIt("FSetting.btnOK.Click.SettingsException", SettingsException.Message)

        End Try

    End Sub

    Private Function IsBlank()
        IsBlank = False

        If txtServerAddress.Text = Nothing Then
            MsgBox("The Server Address must have value")
            IsBlank = True
            Exit Function
        End If

        If TxtServerDatabase.Text = Nothing Then
            MsgBox("The Server Database must have value")
            IsBlank = True
            Exit Function
        End If

        If TxtServerLogin.Text = Nothing Then
            MsgBox("The Server Login must have value")
            Exit Function
        End If

        If TxtServerPassword.Text = Nothing Then
            MsgBox("The Server Password must have value")
            IsBlank = True
            Exit Function
        End If

        If txtIncomingAccountName.Text = Nothing Then
            MsgBox("The Incoming Account Name must have value")
            IsBlank = True
            Exit Function
        End If

        If txtIncomingPassword.Text = Nothing Then
            MsgBox("The Incoming Account Password must have value")
            IsBlank = True
            Exit Function
        End If

        If txtIncomingPort.Value = 0 Then
            MsgBox("The Incoming Port must have value")
            IsBlank = True
            Exit Function
        End If

        If txtIncomingServer.Text = Nothing Then
            MsgBox("The Incoming Server have value")
            IsBlank = True
            Exit Function
        End If

        If txtOutgoingAccountName.Text = Nothing Then
            MsgBox("The Outgoing Account Name have value")
            IsBlank = True
            Exit Function
        End If

        If txtOutgoingPassword.Text = Nothing Then
            MsgBox("The Outgoing Password have value")
            Exit Function
        End If

        If txtOutgoingServer.Text = Nothing Then
            MsgBox("The Outgoing Server have value")
            IsBlank = True
            Exit Function
        End If

        If txtOutgoingPort.Value = 0 Then
            MsgBox("The Outgoing Port have value")
            IsBlank = True
            Exit Function
        End If

        Return IsBlank
    End Function


    Private Sub BlankFields()

        txtServerAddress.Text = Nothing
        TxtServerDatabase.Text = Nothing
        TxtServerLogin.Text = Nothing
        TxtServerPassword.Text = Nothing

        txtIncomingAccountName.Text = Nothing
        txtIncomingPassword.Text = Nothing
        txtIncomingPort.Value = 0
        txtIncomingServer.Text = Nothing
        cbEncryptedConnection.Checked = True

        txtOutgoingAccountName.Text = Nothing
        txtOutgoingPassword.Text = Nothing
        txtOutgoingServer.Text = Nothing
        txtOutgoingPort.Value = 0

        cbLeaveEmail.Checked = True

        txtIncomingBackUp.Text = Nothing
        txtOutgoingBackUp.Text = Nothing

    End Sub
End Class