Imports System.Data.SqlClient

Namespace ConBizz

    Public Class Execute

        Public Sub ExecuteNonQuery(ByVal connstr As String, ByVal StoreProcedure As String, ByVal params As List(Of Params))


            Dim sqlCon = New SqlConnection(connstr)
            Dim sqlComm As New SqlCommand()

            Try

                Using (sqlCon)

                    sqlComm.Connection = sqlCon

                    sqlComm.CommandText = StoreProcedure
                    sqlComm.CommandType = CommandType.StoredProcedure
                    sqlComm.CommandTimeout = 1200

                    sqlComm.Parameters.Clear()

                    Dim iCounter As Integer
                    Dim param As Params

                    For iCounter = 0 To params.Count - 1

                        param = params.Item(iCounter)
                        sqlComm.Parameters.AddWithValue(param.Parameter, param.Record)

                    Next

                    sqlCon.Open()

                    sqlComm.ExecuteNonQuery()

                End Using


            Catch ex As Exception

                Throw (New AppException.ConnectionException(ex.Message))

            Finally
                sqlComm.Dispose()
                sqlCon.Close()

            End Try

        End Sub

        Public Function ExecuteQuery(ByVal connstr As String, ByVal StoreProcedure As String, ByVal params As List(Of Params)) As DataTable

            ExecuteQuery = Nothing

            Dim sqlCon = New SqlConnection(connstr)

            Dim sqlComm As New SqlCommand()

            Try

                sqlComm.Parameters.Clear()

                Dim iCounter As Integer
                Dim param As Params

                For iCounter = 0 To params.Count - 1
                    param = params.Item(iCounter)
                    sqlComm.Parameters.AddWithValue(param.Parameter, param.Record)

                Next

                sqlComm.Connection = sqlCon
                sqlComm.CommandText = StoreProcedure
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.CommandTimeout = 1200

                Dim DBDataTable As New DataTable

                Dim DBAdapter As New SqlDataAdapter(sqlComm)

                DBAdapter.Fill(DBDataTable)

                ExecuteQuery = DBDataTable

            Catch ex As Exception

                Throw (New AppException.ConnectionException(ex.Message))

            Finally
                sqlComm.Connection.Dispose()

            End Try

            Return ExecuteQuery

        End Function

    End Class

End Namespace


