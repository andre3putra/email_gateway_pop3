Imports app.ConBizz

Namespace Controllers

    Public Class OutEmailController

        Public Function Send(ByVal Setting As Models.Setting, ByVal Email As Models.OutEmail) As String

            Send = Nothing

            Dim oMail As New EASendMail.SmtpMail(LICENSE_SEND_EGKey)
            Dim oSmtp As New EASendMail.SmtpClient()

            ' Set sender email address, please change it to yours
            oMail.From = Email.EFROM

            ' Set recipient email address, please change it to yours
            oMail.To = Email.ETO

            If Not (Email.ECC = Nothing) Then
                oMail.Cc = Email.ECC
            End If

            If Not (Email.EBCC = Nothing) Then
                oMail.Bcc = Email.EBCC
            End If

            ' Set email subject
            oMail.Subject = Email.ESUBJECT

            ' Set HTML body
            oMail.HtmlBody = Email.EBODYHTML

            ' Your SMTP server address
            Dim oServer As New EASendMail.SmtpServer(Setting.OutgoingServer)

            ' User and password for ESMTP authentication, if your server doesn't require
            ' User authentication, please remove the following codes.
            oServer.User = Setting.OutgoingAccountName
            oServer.Password = Setting.OutgoingPassword

            ' If your smtp server requires SSL/TLS connection, please add this line
            oServer.ConnectType = EASendMail.SmtpConnectType.ConnectSSLAuto
            'oServer.AuthType = EASendMail.SmtpAuthType.AuthAuto
            'oServer.Port = EmailServices.OutgoingServerPort

            If Not (Email.EATTACHMENT = Nothing) Then

                'Add attachment from local disk
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(Email.EATTACHMENT)

                    'MsgBox(foundFile)
                    oMail.AddAttachment(foundFile)

                Next

            End If

            Try

                oSmtp.SendMail(oServer, oMail)

                Send = "1"

            Catch ex As Exception

                Send = "0"

                Throw (New AppException.EmailOUTException(ex.Message))

            End Try

        End Function

        Public TotalEmail As Integer

        Public Function LoadEmail(ByVal Setting As Models.Setting) As List(Of Models.OutEmail)
            LoadEmail = Nothing

            Dim OutEmail As New Models.OutEmail

            Dim Exec As New Execute
            Dim params As New List(Of Params)
            Dim DT As New DataTable

            Dim ConnString = "Server=" & Setting.ServerAddress & ";uid=" & Setting.ServerUserLogin & ";pwd=" & Setting.ServerPassword & ";database=" & Setting.ServerDatabase

            Try

                params.Add(New Params("@EFROM", Setting.OutgoingAccountName))

                DT = Exec.ExecuteQuery(ConnString, "sp_email_out_get_all", params)

                TotalEmail = DT.Rows.Count

                If DT.Rows.Count > 0 Then

                    For Each rows As DataRow In DT.Rows

                        Dim Record As New Models.OutEmail

                        Record.ID = rows.Item("ID").ToString()
                        Record.EFROM = rows.Item("EFROM").ToString()
                        Record.ETO = rows.Item("ETO").ToString()
                        Record.ECC = rows.Item("ECC").ToString()
                        Record.EBCC = rows.Item("EBCC").ToString()
                        Record.ESUBJECT = rows.Item("ESUBJECT").ToString()
                        Record.EBODYHTML = rows.Item("EBODYHTML").ToString()
                        Record.EBODYTEXT = rows.Item("EBODYTEXT").ToString()
                        Record.EATTACHMENT = rows.Item("EATTACHMENT").ToString()

                        OutEmail.ListData.Add(Record)

                    Next

                    LoadEmail = OutEmail.ListData
                Else

                End If


            Catch ex As Exception

                Throw (New AppException.EmailOUTException(ex.Message))

            End Try

            Return LoadEmail
        End Function

    End Class

End Namespace


