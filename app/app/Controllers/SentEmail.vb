
Imports app.ConBizz

Namespace Controllers

    Public Class SentEmail

        Public Function EmailID(ByVal Setting As Models.Setting, ByVal ID As String) As String
            EmailID = Nothing

            Dim ConnString = "Server=" & Setting.ServerAddress & ";uid=" & Setting.ServerUserLogin & ";pwd=" & Setting.ServerPassword & ";database=" & Setting.ServerDatabase

            Try

                Dim Exec As New Execute
                Dim params As New List(Of Params)

                Dim StoreProcedureID As String = "sp_email_sent_insert"

                params.Add(New Params("@ID", ID))

                Exec.ExecuteNonQuery(ConnString, StoreProcedureID, params)

            Catch ex As Exception

                Throw (New AppException.EmailSentException(ex.Message))

            End Try

            Return EmailID
        End Function

    End Class

End Namespace


