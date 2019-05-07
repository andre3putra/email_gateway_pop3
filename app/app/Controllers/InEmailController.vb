Imports System.IO
Imports app.ConBizz
Imports EAGetMail

Namespace Controllers

    Public Class InEmailController

        Public TotalEmail As Integer
        Public HasEmail As Integer
        Public IsEmptyEmail As Boolean

        Public Function GetDataPop3(ByVal IncomingServerName As String, ByVal EmailAddress As String, ByVal password As String,
                                            IncomingServerPort As String, ByVal LeaveOnServer As Boolean, ByVal DriveBackUp As String) As List(Of Models.InEmail)

            GetDataPop3 = Nothing

            Dim Email As New Models.InEmail

            ' Create a folder named "inbox" under current directory
            ' to save the email retrieved.
            Dim curpath As String = Directory.GetCurrentDirectory()
            'Dim mailbox As String = [String].Format("{0}\inbox", curpath)

            '' If the folder is not existed, create it.
            'If Not Directory.Exists(mailbox) Then
            '    Directory.CreateDirectory(mailbox)
            'End If

            Dim _ServerProtocol As New ServerProtocol

            _ServerProtocol = ServerProtocol.Pop3

            ' Gmail IMAP server is "imap.gmail.com"
            Dim oServer As New MailServer(IncomingServerName, EmailAddress, password, _ServerProtocol)
            Dim oClient As New MailClient(LICENSE_GET_EGKey)

            ' Enable SSL connection
            oServer.SSLConnection = True

            ' Set IMAP4 SSL port
            oServer.Port = IncomingServerPort

            Try

                Dim Record As New Models.InEmail

                Dim emailattachment = New Models.InEmailAttachment

                oClient.Connect(oServer)
                Dim infos As MailInfo() = oClient.GetMailInfos()

                HasEmail = 0

                Dim path As String = DriveBackUp

                TotalEmail = infos.Length

                For i As Integer = 0 To infos.Length - 1

                    'Dim i As Integer = ID

                    Dim info As MailInfo = infos(i)

                    'this ID
                    Dim paramID As String = "Index: " & info.Index & "; Size: " & info.Size & "; UIDL: " & info.UIDL & ""

                    ' Receive email from Gmail server
                    Dim oMail As Mail = oClient.GetMail(info)

                    '[START] Save email to local disk
                    Dim d As System.DateTime = System.DateTime.Now
                    Dim cur As New System.Globalization.CultureInfo("en-US")
                    Dim sdate As String = d.ToString("yyyyMMddHHmmss", cur)

                    Dim fileName As String = [String].Format("{0}\{1}{2}{3}.eml", DriveBackUp, sdate, d.Millisecond.ToString("d3"), i)

                    Dim _URL As String = path & "\" & EmailAddress & "\" & sdate & d.Millisecond.ToString("d3")

                    'set value

                    Dim EmailID As String = sdate & d.Millisecond.ToString("d3")
                    Dim EmailFrom As String = EmailAddress

                    Record.EmailSize = info.Size

                    Record.EmailID = "ICC-" & EmailID

                    If (Not System.IO.Directory.Exists(_URL)) Then
                        System.IO.Directory.CreateDirectory(_URL)
                    End If

                    Dim URL As String = _URL & "\Email.eml"

                    oMail.SaveAs(URL, True)


                    emailattachment = New Models.InEmailAttachment

                    emailattachment.EmailID = Record.EmailID
                    emailattachment.Path = EmailFrom & "\" & EmailID & "\" & "Email.eml"


                    Record.Attachment.Add(emailattachment)

                    HasEmail = HasEmail + 1
                    '[END]

                    'this from
                    Record.EmailFrom = oMail.From.ToString()

                    'this to
                    Dim recordTo As String = Nothing
                    For j As Integer = 0 To oMail.To.Count - 1
                        If oMail.To(j).ToString <> "" Then
                            recordTo = recordTo & Trim(Replace(oMail.To(j).Address, "'", "")) & ";"
                        Else
                            Exit For
                        End If
                    Next j

                    Record.EmailTo = recordTo

                    'this cc
                    Dim recordCC As String = Nothing
                    For j As Integer = 0 To oMail.Cc.Count - 1
                        If oMail.Cc(j).ToString <> "" Then
                            recordCC = recordCC & Trim(Replace(oMail.Cc(j).Address, "'", "")) & ";"
                        Else
                            Exit For
                        End If
                    Next j

                    Record.EmailCc = recordCC

                    'this Bcc
                    Dim recordBcc As String = Nothing
                    For j As Integer = 0 To oMail.Bcc.Count - 1
                        If oMail.Bcc(j).ToString <> "" Then
                            recordBcc = recordBcc & Trim(Replace(oMail.Bcc(j).Address, "'", "")) & ";"
                        Else
                            Exit For
                        End If
                    Next j

                    Record.EmailBcc = recordBcc

                    '[START] For download Attachment Email
                    Dim path_attach As String = _URL
                    Dim attname As String = ""
                    Dim s_path_attach As String = ""

                    oMail.Load(URL, False)
                    oMail.DecodeTNEF()

                    Dim atts() As EAGetMail.Attachment = oMail.Attachments
                    Dim tempFolder As String = path_attach
                    Dim count As Integer = atts.Length

                    If (Not System.IO.Directory.Exists(tempFolder)) Then
                        System.IO.Directory.CreateDirectory(tempFolder)
                    End If

                    For j As Integer = 0 To count - 1
                        Dim att As EAGetMail.Attachment = atts(j)
                        attname = String.Format("{0}\{1}", tempFolder, att.Name)
                        att.SaveAs(attname, True)
                        s_path_attach = s_path_attach & Trim(attname) & ","

                        emailattachment = New Models.InEmailAttachment

                        emailattachment.EmailID = Record.EmailID
                        emailattachment.Path = EmailFrom & "\" & EmailID & "\" & att.Name

                        Record.Attachment.Add(emailattachment)

                    Next j


                    'this  subject
                    Record.EmailSubject = oMail.Subject.ToString()

                    'this Body
                    Record.EmailBodyText = oMail.TextBody.ToString()

                    Record.EmailBodyHtml = oMail.HtmlBody.ToString()

                    Record.EmailSentDate = oMail.SentDate.ToString()

                    If Not (LeaveOnServer = True) Then
                        oClient.Delete(info)
                    End If

                    Email.ListData.Add(Record)

                Next

                GetDataPop3 = Email.ListData

                IsEmptyEmail = False

                oClient.Quit()

            Catch ex As Exception

                Throw (New AppException.EmailINException(ex.Message))

            End Try

            Return GetDataPop3

        End Function

        Public Function StoreAttachmentIntoDatabase(ByVal Setting As Models.Setting, ByVal Email As Models.InEmail) As String
            StoreAttachmentIntoDatabase = Nothing

            Dim ConnString = "Server=" & Setting.ServerAddress & ";uid=" & Setting.ServerUserLogin & ";pwd=" & Setting.ServerPassword & ";database=" & Setting.ServerDatabase

            For Each tmp In Email.Attachment

                Try

                    Dim Exec As New Execute
                    Dim params As New List(Of Params)

                    Dim StoreProcedureID As String = "sp_email_in_attachment_insert"

                    params.Add(New Params("@EMAILID", tmp.EmailID))
                    params.Add(New Params("@Path", tmp.Path))

                    Exec.ExecuteNonQuery(ConnString, StoreProcedureID, params)


                Catch ex As Exception

                    Throw (New AppException.EmailINException(ex.Message))

                End Try

            Next

            Return StoreAttachmentIntoDatabase
        End Function

        Public Function StoreEmailINIntoDatabase(ByVal Setting As Models.Setting, ByVal Email As Models.InEmail) As String

            StoreEmailINIntoDatabase = Nothing

            Dim ConnString = "Server=" & Setting.ServerAddress & ";uid=" & Setting.ServerUserLogin & ";pwd=" & Setting.ServerPassword & ";database=" & Setting.ServerDatabase

            For Each item In Email.ListData

                Dim Exec As New Execute
                Dim params As New List(Of Params)

                Dim StoreProcedureID As String = "sp_email_in_insert"

                Try

                    params.Add(New Params("@EMAILID", Email.EmailID))
                    params.Add(New Params("@EFROM", CleanEmail(Email.EmailFrom)))
                    params.Add(New Params("@ETO", Email.EmailTo))
                    params.Add(New Params("@ECC", IsNull(Email.EmailCc)))
                    params.Add(New Params("@EBCC", IsNull(Email.EmailBcc)))
                    params.Add(New Params("@ESUBJECT", Email.EmailSubject))
                    params.Add(New Params("@EBODYTEXT", Email.EmailBodyText))
                    params.Add(New Params("@EBODYHTML", Email.EmailBodyHtml))
                    params.Add(New Params("@DATESENT", Email.EmailSentDate))
                    params.Add(New Params("@ESIZE", Email.EmailSize))

                    Exec.ExecuteNonQuery(ConnString, StoreProcedureID, params)

                    StoreEmailINIntoDatabase = "Save From :" & Email.EmailFrom

                Catch ex As Exception

                    Throw (New AppException.EmailINException(ex.Message))

                End Try

            Next


            Return StoreEmailINIntoDatabase
        End Function

    End Class

End Namespace


