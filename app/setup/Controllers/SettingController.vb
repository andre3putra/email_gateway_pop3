Imports System.IO

Namespace Controllers

    Public Class SettingController

        Public IsSettingExisting As Boolean

        Public Sub SetupSetting(ByVal Setting As Models.Setting)

            RootID = "Controllers.SettingController.SetupSetting"

            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\config.ini") Then
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\config.ini")
            End If

            Try

                Dim fs1 As FileStream = New FileStream(System.AppDomain.CurrentDomain.BaseDirectory & "\config.ini", FileMode.Append, FileAccess.Write)
                Dim s1 As StreamWriter = New StreamWriter(fs1)

                s1.Write("ServerAddress : " & Setting.ServerAddress & vbCrLf)
                s1.Write("ServerDatabase : " & Setting.ServerDatabase & vbCrLf)
                s1.Write("ServerUserLogin : " & Setting.ServerUserLogin & vbCrLf)
                s1.Write("ServerPassword : " & Setting.ServerPassword & vbCrLf)

                s1.Write("IncomingAccountName : " & Setting.IncomingAccountName & vbCrLf)
                s1.Write("IncomingPassword : " & Setting.IncomingPassword & vbCrLf)
                s1.Write("IncomingServer : " & Setting.IncomingServer & vbCrLf)
                s1.Write("IncomingPort : " & Setting.IncomingPort & vbCrLf)
                s1.Write("EncryptedConnection : " & Setting.EncryptedConnection & vbCrLf)

                s1.Write("OutgoingAccountName : " & Setting.OutgoingAccountName & vbCrLf)
                s1.Write("OutgoingPassword : " & Setting.OutgoingPassword & vbCrLf)
                s1.Write("OutgoingServer : " & Setting.OutgoingServer & vbCrLf)
                s1.Write("OutgoingPort : " & Setting.OutgoingPort & vbCrLf)

                s1.Write("LeaveEmailOnServer : " & Setting.LeaveEmailOnServer & vbCrLf)

                s1.Write("IncomingBackUp : " & Setting.IncomingBackUp & vbCrLf)
                s1.Write("OutgoingBackUp : " & Setting.OutgoingBackUp & vbCrLf)

                s1.Close()
                fs1.Close()


            Catch ex As Exception

                Throw (New AppException.SettingsException(ex.Message))

            End Try

        End Sub

        Public Function LoadSetting() As List(Of Models.Setting)

            LoadSetting = Nothing

            RootID = "Controllers.SettingController.LoadSetting"

            Dim oStreamReader As StreamReader = Nothing

            If Not System.IO.File.Exists(Application.StartupPath & "\config.ini") Then
                MsgBox("The config.ini not found !")
            Else

            End If

            Dim newListData As New Models.Setting

            Try
                oStreamReader = New StreamReader(Application.StartupPath & "\config.ini")

                Dim Record As New Models.Setting

                With Record

                    .ServerAddress = Replace(oStreamReader.ReadLine, "ServerAddress : ", "")
                    .ServerDatabase = Replace(oStreamReader.ReadLine, "ServerDatabase : ", "")
                    .ServerUserLogin = Replace(oStreamReader.ReadLine, "ServerUserLogin : ", "")
                    .ServerPassword = Replace(oStreamReader.ReadLine, "ServerPassword : ", "")

                    .IncomingAccountName = Replace(oStreamReader.ReadLine, "IncomingAccountName : ", "")
                    .IncomingPassword = Replace(oStreamReader.ReadLine, "IncomingPassword : ", "")
                    .IncomingServer = Replace(oStreamReader.ReadLine, "IncomingServer : ", "")
                    .IncomingPort = Replace(oStreamReader.ReadLine, "IncomingPort : ", "")
                    .EncryptedConnection = Replace(oStreamReader.ReadLine, "EncryptedConnection : ", "")

                    .OutgoingAccountName = Replace(oStreamReader.ReadLine, "OutgoingAccountName : ", "")
                    .OutgoingPassword = Replace(oStreamReader.ReadLine, "OutgoingPassword : ", "")
                    .OutgoingServer = Replace(oStreamReader.ReadLine, "OutgoingServer : ", "")
                    .OutgoingPort = Replace(oStreamReader.ReadLine, "OutgoingPort : ", "")

                    .LeaveEmailOnServer = Replace(oStreamReader.ReadLine, "LeaveEmailOnServer : ", "")

                    .IncomingBackUp = Replace(oStreamReader.ReadLine, "IncomingBackUp : ", "")
                    .OutgoingBackUp = Replace(oStreamReader.ReadLine, "OutgoingBackUp : ", "")

                End With

                newListData.ListData.Add(Record)

                LoadSetting = newListData.ListData

                oStreamReader.Dispose()

                IsSettingExisting = True

            Catch ex As Exception

                Throw (New AppException.SettingsException(ex.Message))

                IsSettingExisting = False

            End Try

            Return LoadSetting
        End Function

    End Class

End Namespace


